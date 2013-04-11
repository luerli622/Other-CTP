#region Version Info
/* ======================================================================== 
* 作者：吕辉       时间：2013/4/3 14:05:49
* email：lvhui.cn@gmail.com 
* 文件名：ThostFtdcTraderApiAdapter.cs 
* 版本：V1.0.1 
* 
* 修改者：           时间：               
* 修改说明： 
* ======================================================================== 
*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using LvHui.CTP4CS;

namespace LvHui.CTPTrader4CS
{

    ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
    delegate void OnFrontConnected();

    ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
    ///@param nReason 错误原因
    ///        0x1001 网络读失败
    ///        0x1002 网络写失败
    ///        0x2001 接收心跳超时
    ///        0x2002 发送心跳失败
    ///        0x2003 收到错误报文
    delegate void OnFrontDisconnected(int nReason);

    ///心跳超时警告。当长时间未收到报文时，该方法被调用。
    ///@param nTimeLapse 距离上次接收报文的时间
    delegate void OnHeartBeatWarning(int nTimeLapse);

    ///客户端认证响应
    delegate void OnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);


    ///登录请求响应
    delegate void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///登出请求响应
    delegate void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///用户口令更新请求响应
    delegate void OnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///资金账户口令更新请求响应
    delegate void OnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///报单录入请求响应
    delegate void OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///预埋单录入请求响应
    delegate void OnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///预埋撤单录入请求响应
    delegate void OnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///报单操作请求响应
    delegate void OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///查询最大报单数量响应
    delegate void OnRspQueryMaxOrderVolume(ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///投资者结算结果确认响应
    delegate void OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///删除预埋单响应
    delegate void OnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///删除预埋撤单响应
    delegate void OnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询报单响应
    delegate void OnRspQryOrder(ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询成交响应
    delegate void OnRspQryTrade(ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询投资者持仓响应
    delegate void OnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询资金账户响应
    delegate void OnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询投资者响应
    delegate void OnRspQryInvestor(ref CThostFtdcInvestorField pInvestor, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询交易编码响应
    delegate void OnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询合约保证金率响应
    delegate void OnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询合约手续费率响应
    delegate void OnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询交易所响应
    delegate void OnRspQryExchange(ref CThostFtdcExchangeField pExchange, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询合约响应
    delegate void OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询行情响应
    delegate void OnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询投资者结算结果响应
    delegate void OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询转帐银行响应
    delegate void OnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询投资者持仓明细响应
    delegate void OnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询客户通知响应
    delegate void OnRspQryNotice(ref CThostFtdcNoticeField pNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询结算信息确认响应
    delegate void OnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询投资者持仓明细响应
    delegate void OnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///查询保证金监管系统经纪公司资金账户密钥响应
    delegate void OnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询仓单折抵信息响应
    delegate void OnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询转帐流水响应
    delegate void OnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询银期签约关系响应
    delegate void OnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///错误应答
    delegate void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///报单通知
    delegate void OnRtnOrder(ref CThostFtdcOrderField pOrder);

    ///成交通知
    delegate void OnRtnTrade(ref CThostFtdcTradeField pTrade);

    ///报单录入错误回报
    delegate void OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo);

    ///报单操作错误回报
    delegate void OnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo);

    ///合约交易状态通知
    delegate void OnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus);

    ///交易通知
    delegate void OnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo);

    ///提示条件单校验错误
    delegate void OnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder);

    ///请求查询签约银行响应
    delegate void OnRspQryContractBank(ref CThostFtdcContractBankField pContractBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询预埋单响应
    delegate void OnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询预埋撤单响应
    delegate void OnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询交易通知响应
    delegate void OnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询经纪公司交易参数响应
    delegate void OnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///请求查询经纪公司交易算法响应
    delegate void OnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///银行发起银行资金转期货通知
    delegate void OnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer);

    ///银行发起期货资金转银行通知
    delegate void OnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer);

    ///银行发起冲正银行转期货通知
    delegate void OnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal);

    ///银行发起冲正期货转银行通知
    delegate void OnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal);

    ///期货发起银行资金转期货通知
    delegate void OnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer);

    ///期货发起期货资金转银行通知
    delegate void OnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer);

    ///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    delegate void OnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);

    ///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    delegate void OnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);

    ///期货发起查询银行余额通知
    delegate void OnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount);

    ///期货发起银行资金转期货错误回报
    delegate void OnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo);

    ///期货发起期货资金转银行错误回报
    delegate void OnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo);

    ///系统运行时期货端手工发起冲正银行转期货错误回报
    delegate void OnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo);

    ///系统运行时期货端手工发起冲正期货转银行错误回报
    delegate void OnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo);

    ///期货发起查询银行余额错误回报
    delegate void OnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo);

    ///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    delegate void OnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal);

    ///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    delegate void OnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal);

    ///期货发起银行资金转期货应答
    delegate void OnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///期货发起期货资金转银行应答
    delegate void OnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///期货发起查询银行余额应答
    delegate void OnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

    ///银行发起银期开户通知
    delegate void OnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount);

    ///银行发起银期销户通知
    delegate void OnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount);

    ///银行发起变更银行账号通知
    delegate void OnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount);

    [StructLayout(LayoutKind.Sequential)]
    class STraderSpi
    {
        ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
        public OnFrontConnected m_pfOnFrontConnected;

        ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
        ///@param nReason 错误原因
        ///        0x1001 网络读失败
        ///        0x1002 网络写失败
        ///        0x2001 接收心跳超时
        ///        0x2002 发送心跳失败
        ///        0x2003 收到错误报文
        public OnFrontDisconnected m_pfOnFrontDisconnected;

        ///心跳超时警告。当长时间未收到报文时，该方法被调用。
        ///@param nTimeLapse 距离上次接收报文的时间
        public OnHeartBeatWarning m_pfOnHeartBeatWarning;

        ///客户端认证响应
        public OnRspAuthenticate m_pfOnRspAuthenticate;


        ///登录请求响应
        public OnRspUserLogin m_pfOnRspUserLogin;

        ///登出请求响应
        public OnRspUserLogout m_pfOnRspUserLogout;

        ///用户口令更新请求响应
        public OnRspUserPasswordUpdate m_pfOnRspUserPasswordUpdate;

        ///资金账户口令更新请求响应
        public OnRspTradingAccountPasswordUpdate m_pfOnRspTradingAccountPasswordUpdate;

        ///报单录入请求响应
        public OnRspOrderInsert m_pfOnRspOrderInsert;

        ///预埋单录入请求响应
        public OnRspParkedOrderInsert m_pfOnRspParkedOrderInsert;

        ///预埋撤单录入请求响应
        public OnRspParkedOrderAction m_pfOnRspParkedOrderAction;

        ///报单操作请求响应
        public OnRspOrderAction m_pfOnRspOrderAction;

        ///查询最大报单数量响应
        public OnRspQueryMaxOrderVolume m_pfOnRspQueryMaxOrderVolume;

        ///投资者结算结果确认响应
        public OnRspSettlementInfoConfirm m_pfOnRspSettlementInfoConfirm;

        ///删除预埋单响应
        public OnRspRemoveParkedOrder m_pfOnRspRemoveParkedOrder;

        ///删除预埋撤单响应
        public OnRspRemoveParkedOrderAction m_pfOnRspRemoveParkedOrderAction;

        ///请求查询报单响应
        public OnRspQryOrder m_pfOnRspQryOrder;

        ///请求查询成交响应
        public OnRspQryTrade m_pfOnRspQryTrade;

        ///请求查询投资者持仓响应
        public OnRspQryInvestorPosition m_pfOnRspQryInvestorPosition;

        ///请求查询资金账户响应
        public OnRspQryTradingAccount m_pfOnRspQryTradingAccount;

        ///请求查询投资者响应
        public OnRspQryInvestor m_pfOnRspQryInvestor;

        ///请求查询交易编码响应
        public OnRspQryTradingCode m_pfOnRspQryTradingCode;

        ///请求查询合约保证金率响应
        public OnRspQryInstrumentMarginRate m_pfOnRspQryInstrumentMarginRate;

        ///请求查询合约手续费率响应
        public OnRspQryInstrumentCommissionRate m_pfOnRspQryInstrumentCommissionRate;

        ///请求查询交易所响应
        public OnRspQryExchange m_pfOnRspQryExchange;

        ///请求查询合约响应
        public OnRspQryInstrument m_pfOnRspQryInstrument;

        ///请求查询行情响应
        public OnRspQryDepthMarketData m_pfOnRspQryDepthMarketData;

        ///请求查询投资者结算结果响应
        public OnRspQrySettlementInfo m_pfOnRspQrySettlementInfo;

        ///请求查询转帐银行响应
        public OnRspQryTransferBank m_pfOnRspQryTransferBank;

        ///请求查询投资者持仓明细响应
        public OnRspQryInvestorPositionDetail m_pfOnRspQryInvestorPositionDetail;

        ///请求查询客户通知响应
        public OnRspQryNotice m_pfOnRspQryNotice;

        ///请求查询结算信息确认响应
        public OnRspQrySettlementInfoConfirm m_pfOnRspQrySettlementInfoConfirm;

        ///请求查询投资者持仓明细响应
        public OnRspQryInvestorPositionCombineDetail m_pfOnRspQryInvestorPositionCombineDetail;

        ///查询保证金监管系统经纪公司资金账户密钥响应
        public OnRspQryCFMMCTradingAccountKey m_pfOnRspQryCFMMCTradingAccountKey;

        ///请求查询仓单折抵信息响应
        public OnRspQryEWarrantOffset m_pfOnRspQryEWarrantOffset;

        ///请求查询转帐流水响应
        public OnRspQryTransferSerial m_pfOnRspQryTransferSerial;

        ///请求查询银期签约关系响应
        public OnRspQryAccountregister m_pfOnRspQryAccountregister;

        ///错误应答
        public OnRspError m_pfOnRspError;

        ///报单通知
        public OnRtnOrder m_pfOnRtnOrder;

        ///成交通知
        public OnRtnTrade m_pfOnRtnTrade;

        ///报单录入错误回报
        public OnErrRtnOrderInsert m_pfOnErrRtnOrderInsert;

        ///报单操作错误回报
        public OnErrRtnOrderAction m_pfOnErrRtnOrderAction;

        ///合约交易状态通知
        public OnRtnInstrumentStatus m_pfOnRtnInstrumentStatus;

        ///交易通知
        public OnRtnTradingNotice m_pfOnRtnTradingNotice;

        ///提示条件单校验错误
        public OnRtnErrorConditionalOrder m_pfOnRtnErrorConditionalOrder;

        ///请求查询签约银行响应
        public OnRspQryContractBank m_pfOnRspQryContractBank;

        ///请求查询预埋单响应
        public OnRspQryParkedOrder m_pfOnRspQryParkedOrder;

        ///请求查询预埋撤单响应
        public OnRspQryParkedOrderAction m_pfOnRspQryParkedOrderAction;

        ///请求查询交易通知响应
        public OnRspQryTradingNotice m_pfOnRspQryTradingNotice;

        ///请求查询经纪公司交易参数响应
        public OnRspQryBrokerTradingParams m_pfOnRspQryBrokerTradingParams;

        ///请求查询经纪公司交易算法响应
        public OnRspQryBrokerTradingAlgos m_pfOnRspQryBrokerTradingAlgos;

        ///银行发起银行资金转期货通知
        public OnRtnFromBankToFutureByBank m_pfOnRtnFromBankToFutureByBank;

        ///银行发起期货资金转银行通知
        public OnRtnFromFutureToBankByBank m_pfOnRtnFromFutureToBankByBank;

        ///银行发起冲正银行转期货通知
        public OnRtnRepealFromBankToFutureByBank m_pfOnRtnRepealFromBankToFutureByBank;

        ///银行发起冲正期货转银行通知
        public OnRtnRepealFromFutureToBankByBank m_pfOnRtnRepealFromFutureToBankByBank;

        ///期货发起银行资金转期货通知
        public OnRtnFromBankToFutureByFuture m_pfOnRtnFromBankToFutureByFuture;

        ///期货发起期货资金转银行通知
        public OnRtnFromFutureToBankByFuture m_pfOnRtnFromFutureToBankByFuture;

        ///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public OnRtnRepealFromBankToFutureByFutureManual m_pfOnRtnRepealFromBankToFutureByFutureManual;

        ///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public OnRtnRepealFromFutureToBankByFutureManual m_pfOnRtnRepealFromFutureToBankByFutureManual;

        ///期货发起查询银行余额通知
        public OnRtnQueryBankBalanceByFuture m_pfOnRtnQueryBankBalanceByFuture;

        ///期货发起银行资金转期货错误回报
        public OnErrRtnBankToFutureByFuture m_pfOnErrRtnBankToFutureByFuture;

        ///期货发起期货资金转银行错误回报
        public OnErrRtnFutureToBankByFuture m_pfOnErrRtnFutureToBankByFuture;

        ///系统运行时期货端手工发起冲正银行转期货错误回报
        public OnErrRtnRepealBankToFutureByFutureManual m_pfOnErrRtnRepealBankToFutureByFutureManual;

        ///系统运行时期货端手工发起冲正期货转银行错误回报
        public OnErrRtnRepealFutureToBankByFutureManual m_pfOnErrRtnRepealFutureToBankByFutureManual;

        ///期货发起查询银行余额错误回报
        public OnErrRtnQueryBankBalanceByFuture m_pfOnErrRtnQueryBankBalanceByFuture;

        ///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public OnRtnRepealFromBankToFutureByFuture m_pfOnRtnRepealFromBankToFutureByFuture;

        ///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public OnRtnRepealFromFutureToBankByFuture m_pfOnRtnRepealFromFutureToBankByFuture;

        ///期货发起银行资金转期货应答
        public OnRspFromBankToFutureByFuture m_pfOnRspFromBankToFutureByFuture;

        ///期货发起期货资金转银行应答
        public OnRspFromFutureToBankByFuture m_pfOnRspFromFutureToBankByFuture;

        ///期货发起查询银行余额应答
        public OnRspQueryBankAccountMoneyByFuture m_pfOnRspQueryBankAccountMoneyByFuture;

        ///银行发起银期开户通知
        public OnRtnOpenAccountByBank m_pfOnRtnOpenAccountByBank;

        ///银行发起银期销户通知
        public OnRtnCancelAccountByBank m_pfOnRtnCancelAccountByBank;

        ///银行发起变更银行账号通知
        public OnRtnChangeAccountByBank m_pfOnRtnChangeAccountByBank;
    };


    class ThostFtdcTraderApiAdapter
    {
        ///创建TraderApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        //modify for udp marketdata
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_CreateFtdcTraderApi@8", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateFtdcTraderApi(string pszFlowPath, bool bIsUsingUdp);

        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_Release@4", CallingConvention = CallingConvention.StdCall)]
        public static extern void Release(IntPtr pTraderApi);

        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_Init@4", CallingConvention = CallingConvention.StdCall)]
        public static extern void Init(IntPtr pTraderApi);

        ///等待接口线程结束运行
        ///@return 线程退出代码
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_Join@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int Join(IntPtr pTraderApi);

        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_GetTradingDay@4", CallingConvention = CallingConvention.StdCall)]
        public static extern string GetTradingDay(IntPtr pTraderApi);

        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。 
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_RegisterFront@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterFront(IntPtr pTraderApi, string pszFrontAddress);

        ///注册名字服务器网络地址
        ///@param pszNsAddress：名字服务器网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。 
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
        ///@remark RegisterNameServer优先于RegisterFront
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_RegisterNameServer@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterNameServer(IntPtr pTraderApi, string pszNsAddress);

        ///注册回调接口
        ///@param pSpi 派生自回调接口类的实例
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_RegisterSpi@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterSpi(IntPtr pTraderApi, ref STraderSpi pSpi);

        ///订阅私有流。
        ///@param nResumeType 私有流重传方式  
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后私有流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_SubscribePrivateTopic@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void SubscribePrivateTopic(IntPtr pTraderApi, THOST_TE_RESUME_TYPE nResumeType);

        ///订阅公共流。
        ///@param nResumeType 公共流重传方式  
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后公共流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_SubscribePublicTopic@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void SubscribePublicTopic(IntPtr pTraderApi, THOST_TE_RESUME_TYPE nResumeType);

        ///客户端认证请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqAuthenticate@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqAuthenticate(IntPtr pTraderApi, ref CThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID);

        ///用户登录请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqUserLogin@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqUserLogin(IntPtr pTraderApi, ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);


        ///登出请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqUserLogout@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqUserLogout(IntPtr pTraderApi, ref CThostFtdcUserLogoutField pUserLogout, int nRequestID);

        ///用户口令更新请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqUserPasswordUpdate@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqUserPasswordUpdate(IntPtr pTraderApi, ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        ///资金账户口令更新请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqTradingAccountPasswordUpdate@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqTradingAccountPasswordUpdate(IntPtr pTraderApi, ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID);

        ///报单录入请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqOrderInsert@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqOrderInsert(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, int nRequestID);

        ///预埋单录入请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqParkedOrderInsert@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqParkedOrderInsert(IntPtr pTraderApi, ref CThostFtdcParkedOrderField pParkedOrder, int nRequestID);

        ///预埋撤单录入请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqParkedOrderAction@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqParkedOrderAction(IntPtr pTraderApi, ref CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID);

        ///报单操作请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqOrderAction@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqOrderAction(IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);

        ///查询最大报单数量请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQueryMaxOrderVolume@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQueryMaxOrderVolume(IntPtr pTraderApi, ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID);

        ///投资者结算结果确认
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqSettlementInfoConfirm@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqSettlementInfoConfirm(IntPtr pTraderApi, ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID);

        ///请求删除预埋单
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqRemoveParkedOrder@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqRemoveParkedOrder(IntPtr pTraderApi, ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);

        ///请求删除预埋撤单
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqRemoveParkedOrderAction@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqRemoveParkedOrderAction(IntPtr pTraderApi, ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);

        ///请求查询报单
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryOrder@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryOrder(IntPtr pTraderApi, ref CThostFtdcQryOrderField pQryOrder, int nRequestID);

        ///请求查询成交
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTrade@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTrade(IntPtr pTraderApi, ref CThostFtdcQryTradeField pQryTrade, int nRequestID);

        ///请求查询投资者持仓
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInvestorPosition@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInvestorPosition(IntPtr pTraderApi, ref CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);

        ///请求查询资金账户
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTradingAccount@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTradingAccount(IntPtr pTraderApi, ref CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        ///请求查询投资者
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInvestor@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInvestor(IntPtr pTraderApi, ref CThostFtdcQryInvestorField pQryInvestor, int nRequestID);

        ///请求查询交易编码
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTradingCode@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTradingCode(IntPtr pTraderApi, ref CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        ///请求查询合约保证金率
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInstrumentMarginRate@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInstrumentMarginRate(IntPtr pTraderApi, ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);

        ///请求查询合约手续费率
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInstrumentCommissionRate@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInstrumentCommissionRate(IntPtr pTraderApi, ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);

        ///请求查询交易所
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryExchange@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryExchange(IntPtr pTraderApi, ref CThostFtdcQryExchangeField pQryExchange, int nRequestID);

        ///请求查询合约
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInstrument@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInstrument(IntPtr pTraderApi, ref CThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        ///请求查询行情
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryDepthMarketData@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryDepthMarketData(IntPtr pTraderApi, ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);

        ///请求查询投资者结算结果
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQrySettlementInfo@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQrySettlementInfo(IntPtr pTraderApi, ref CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);

        ///请求查询转帐银行
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTransferBank@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTransferBank(IntPtr pTraderApi, ref CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);

        ///请求查询投资者持仓明细
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInvestorPositionDetail@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInvestorPositionDetail(IntPtr pTraderApi, ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID);

        ///请求查询客户通知
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryNotice@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryNotice(IntPtr pTraderApi, ref CThostFtdcQryNoticeField pQryNotice, int nRequestID);

        ///请求查询结算信息确认
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQrySettlementInfoConfirm@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQrySettlementInfoConfirm(IntPtr pTraderApi, ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID);

        ///请求查询投资者持仓明细
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryInvestorPositionCombineDetail@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryInvestorPositionCombineDetail(IntPtr pTraderApi, ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);

        ///请求查询保证金监管系统经纪公司资金账户密钥
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryCFMMCTradingAccountKey@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryCFMMCTradingAccountKey(IntPtr pTraderApi, ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID);

        ///请求查询仓单折抵信息
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryEWarrantOffset@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryEWarrantOffset(IntPtr pTraderApi, ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID);

        ///请求查询转帐流水
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTransferSerial@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTransferSerial(IntPtr pTraderApi, ref CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);

        ///请求查询银期签约关系
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryAccountregister@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryAccountregister(IntPtr pTraderApi, ref CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);

        ///请求查询签约银行
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryContractBank@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryContractBank(IntPtr pTraderApi, ref CThostFtdcQryContractBankField pQryContractBank, int nRequestID);

        ///请求查询预埋单
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryParkedOrder@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryParkedOrder(IntPtr pTraderApi, ref CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID);

        ///请求查询预埋撤单
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryParkedOrderAction@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryParkedOrderAction(IntPtr pTraderApi, ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID);

        ///请求查询交易通知
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryTradingNotice@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryTradingNotice(IntPtr pTraderApi, ref CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);

        ///请求查询经纪公司交易参数
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryBrokerTradingParams@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryBrokerTradingParams(IntPtr pTraderApi, ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);

        ///请求查询经纪公司交易算法
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQryBrokerTradingAlgos@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQryBrokerTradingAlgos(IntPtr pTraderApi, ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);

        ///期货发起银行资金转期货请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqFromBankToFutureByFuture@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqFromBankToFutureByFuture(IntPtr pTraderApi, ref CThostFtdcReqTransferField pReqTransfer, int nRequestID);

        ///期货发起期货资金转银行请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqFromFutureToBankByFuture@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqFromFutureToBankByFuture(IntPtr pTraderApi, ref CThostFtdcReqTransferField pReqTransfer, int nRequestID);

        ///期货发起查询银行余额请求
        [DllImport("LvHui.CTPTrader4C.dll", EntryPoint = "_ReqQueryBankAccountMoneyByFuture@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqQueryBankAccountMoneyByFuture(IntPtr pTraderApi, ref CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID);
    }
}
