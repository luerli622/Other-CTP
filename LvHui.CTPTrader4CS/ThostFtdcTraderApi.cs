#region Version Info
/* ========================================================================
* 作者：吕辉       时间：2013/4/4 11:49:02
* email：lvhui.cn@gmail.com
* 文件名：ThostFtdcTraderApi.cs
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
using LvHui.CTP4CS;

namespace LvHui.CTPTrader4CS
{

    public class CThostFtdcTraderSpi
    {
        ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
        public virtual void OnFrontConnected() { }

        ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
        ///@param nReason 错误原因
        ///        0x1001 网络读失败
        ///        0x1002 网络写失败
        ///        0x2001 接收心跳超时
        ///        0x2002 发送心跳失败
        ///        0x2003 收到错误报文
        public virtual void OnFrontDisconnected(int nReason) { }

        ///心跳超时警告。当长时间未收到报文时，该方法被调用。
        ///@param nTimeLapse 距离上次接收报文的时间
        public virtual void OnHeartBeatWarning(int nTimeLapse) { }

        ///客户端认证响应
        public virtual void OnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }


        ///登录请求响应
        public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///登出请求响应
        public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///用户口令更新请求响应
        public virtual void OnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///资金账户口令更新请求响应
        public virtual void OnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///报单录入请求响应
        public virtual void OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///预埋单录入请求响应
        public virtual void OnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///预埋撤单录入请求响应
        public virtual void OnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///报单操作请求响应
        public virtual void OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///查询最大报单数量响应
        public virtual void OnRspQueryMaxOrderVolume(ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///投资者结算结果确认响应
        public virtual void OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///删除预埋单响应
        public virtual void OnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///删除预埋撤单响应
        public virtual void OnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询报单响应
        public virtual void OnRspQryOrder(ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询成交响应
        public virtual void OnRspQryTrade(ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询投资者持仓响应
        public virtual void OnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询资金账户响应
        public virtual void OnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询投资者响应
        public virtual void OnRspQryInvestor(ref CThostFtdcInvestorField pInvestor, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询交易编码响应
        public virtual void OnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询合约保证金率响应
        public virtual void OnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询合约手续费率响应
        public virtual void OnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询交易所响应
        public virtual void OnRspQryExchange(ref CThostFtdcExchangeField pExchange, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询合约响应
        public virtual void OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询行情响应
        public virtual void OnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询投资者结算结果响应
        public virtual void OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询转帐银行响应
        public virtual void OnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询投资者持仓明细响应
        public virtual void OnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询客户通知响应
        public virtual void OnRspQryNotice(ref CThostFtdcNoticeField pNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询结算信息确认响应
        public virtual void OnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询投资者持仓明细响应
        public virtual void OnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///查询保证金监管系统经纪公司资金账户密钥响应
        public virtual void OnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询仓单折抵信息响应
        public virtual void OnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询转帐流水响应
        public virtual void OnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询银期签约关系响应
        public virtual void OnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///错误应答
        public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///报单通知
        public virtual void OnRtnOrder(ref CThostFtdcOrderField pOrder) { }

        ///成交通知
        public virtual void OnRtnTrade(ref CThostFtdcTradeField pTrade) { }

        ///报单录入错误回报
        public virtual void OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo) { }

        ///报单操作错误回报
        public virtual void OnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo) { }

        ///合约交易状态通知
        public virtual void OnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus) { }

        ///交易通知
        public virtual void OnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo) { }

        ///提示条件单校验错误
        public virtual void OnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder) { }

        ///请求查询签约银行响应
        public virtual void OnRspQryContractBank(ref CThostFtdcContractBankField pContractBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询预埋单响应
        public virtual void OnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询预埋撤单响应
        public virtual void OnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询交易通知响应
        public virtual void OnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询经纪公司交易参数响应
        public virtual void OnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///请求查询经纪公司交易算法响应
        public virtual void OnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///银行发起银行资金转期货通知
        public virtual void OnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer) { }

        ///银行发起期货资金转银行通知
        public virtual void OnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer) { }

        ///银行发起冲正银行转期货通知
        public virtual void OnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///银行发起冲正期货转银行通知
        public virtual void OnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///期货发起银行资金转期货通知
        public virtual void OnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer) { }

        ///期货发起期货资金转银行通知
        public virtual void OnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer) { }

        ///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public virtual void OnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public virtual void OnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///期货发起查询银行余额通知
        public virtual void OnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount) { }

        ///期货发起银行资金转期货错误回报
        public virtual void OnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo) { }

        ///期货发起期货资金转银行错误回报
        public virtual void OnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo) { }

        ///系统运行时期货端手工发起冲正银行转期货错误回报
        public virtual void OnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo) { }

        ///系统运行时期货端手工发起冲正期货转银行错误回报
        public virtual void OnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo) { }

        ///期货发起查询银行余额错误回报
        public virtual void OnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo) { }

        ///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public virtual void OnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public virtual void OnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal) { }

        ///期货发起银行资金转期货应答
        public virtual void OnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///期货发起期货资金转银行应答
        public virtual void OnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///期货发起查询银行余额应答
        public virtual void OnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///银行发起银期开户通知
        public virtual void OnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount) { }

        ///银行发起银期销户通知
        public virtual void OnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount) { }

        ///银行发起变更银行账号通知
        public virtual void OnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount) { }
    };

    public class CThostFtdcTraderApi
    {
        ///创建TraderApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        //modify for udp marketdata
        public static CThostFtdcTraderApi CreateFtdcTraderApi(string pszFlowPath = "", bool bIsUsingUdp = false)
        {
            CThostFtdcTraderApi Api = new CThostFtdcTraderApi();
            Api.pTraderApi = ThostFtdcTraderApiAdapter.CreateFtdcTraderApi(pszFlowPath, bIsUsingUdp);      
            return Api;
        }

        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        public void Release()
        {
            ThostFtdcTraderApiAdapter.Release(pTraderApi);
        }

        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        public void Init()
        {
            ThostFtdcTraderApiAdapter.Init(pTraderApi);
        }

        ///等待接口线程结束运行
        ///@return 线程退出代码
        public int Join()
        {
            return ThostFtdcTraderApiAdapter.Join(pTraderApi);
        }

        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        public string GetTradingDay()
        {
            return ThostFtdcTraderApiAdapter.GetTradingDay(pTraderApi);
        }

        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        public void RegisterFront(string pszFrontAddress)
        {
            ThostFtdcTraderApiAdapter.RegisterFront(pTraderApi, pszFrontAddress);
        }

        ///注册名字服务器网络地址
        ///@param pszNsAddress：名字服务器网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
        ///@remark RegisterNameServer优先于RegisterFront
        public void RegisterNameServer(string pszNsAddress)
        {
            ThostFtdcTraderApiAdapter.RegisterNameServer(pTraderApi, pszNsAddress);
        }

        ///注册回调接口
        ///@param pSpi 派生自回调接口类的实例
        public void RegisterSpi(ref CThostFtdcTraderSpi pSpi)
        {
            m_Spi.m_pfOnFrontConnected = pSpi.OnFrontConnected ;
            m_Spi.m_pfOnFrontDisconnected = pSpi.OnFrontDisconnected ;
            m_Spi.m_pfOnHeartBeatWarning = pSpi.OnHeartBeatWarning ;
            m_Spi.m_pfOnRspAuthenticate = pSpi.OnRspAuthenticate ;
            m_Spi.m_pfOnRspUserLogin = pSpi.OnRspUserLogin ;
            m_Spi.m_pfOnRspUserLogout = pSpi.OnRspUserLogout ;
            m_Spi.m_pfOnRspUserPasswordUpdate = pSpi.OnRspUserPasswordUpdate ;
            m_Spi.m_pfOnRspTradingAccountPasswordUpdate = pSpi.OnRspTradingAccountPasswordUpdate ;
            m_Spi.m_pfOnRspOrderInsert = pSpi.OnRspOrderInsert ;
            m_Spi.m_pfOnRspParkedOrderInsert = pSpi.OnRspParkedOrderInsert ;
            m_Spi.m_pfOnRspParkedOrderAction = pSpi.OnRspParkedOrderAction ;
            m_Spi.m_pfOnRspOrderAction = pSpi.OnRspOrderAction ;
            m_Spi.m_pfOnRspQueryMaxOrderVolume = pSpi.OnRspQueryMaxOrderVolume ;
            m_Spi.m_pfOnRspSettlementInfoConfirm = pSpi.OnRspSettlementInfoConfirm ;
            m_Spi.m_pfOnRspRemoveParkedOrder = pSpi.OnRspRemoveParkedOrder ;
            m_Spi.m_pfOnRspRemoveParkedOrderAction = pSpi.OnRspRemoveParkedOrderAction ;
            m_Spi.m_pfOnRspQryOrder = pSpi.OnRspQryOrder ;
            m_Spi.m_pfOnRspQryTrade = pSpi.OnRspQryTrade ;
            m_Spi.m_pfOnRspQryInvestorPosition = pSpi.OnRspQryInvestorPosition ;
            m_Spi.m_pfOnRspQryTradingAccount = pSpi.OnRspQryTradingAccount ;
            m_Spi.m_pfOnRspQryInvestor = pSpi.OnRspQryInvestor ;
            m_Spi.m_pfOnRspQryTradingCode = pSpi.OnRspQryTradingCode ;
            m_Spi.m_pfOnRspQryInstrumentMarginRate = pSpi.OnRspQryInstrumentMarginRate ;
            m_Spi.m_pfOnRspQryInstrumentCommissionRate = pSpi.OnRspQryInstrumentCommissionRate ;
            m_Spi.m_pfOnRspQryExchange = pSpi.OnRspQryExchange ;
            m_Spi.m_pfOnRspQryInstrument = pSpi.OnRspQryInstrument ;
            m_Spi.m_pfOnRspQryDepthMarketData = pSpi.OnRspQryDepthMarketData ;
            m_Spi.m_pfOnRspQrySettlementInfo = pSpi.OnRspQrySettlementInfo ;
            m_Spi.m_pfOnRspQryTransferBank = pSpi.OnRspQryTransferBank ;
            m_Spi.m_pfOnRspQryInvestorPositionDetail = pSpi.OnRspQryInvestorPositionDetail ;
            m_Spi.m_pfOnRspQryNotice = pSpi.OnRspQryNotice ;
            m_Spi.m_pfOnRspQrySettlementInfoConfirm = pSpi.OnRspQrySettlementInfoConfirm ;
            m_Spi.m_pfOnRspQryInvestorPositionCombineDetail = pSpi.OnRspQryInvestorPositionCombineDetail ;
            m_Spi.m_pfOnRspQryCFMMCTradingAccountKey = pSpi.OnRspQryCFMMCTradingAccountKey ;
            m_Spi.m_pfOnRspQryEWarrantOffset = pSpi.OnRspQryEWarrantOffset ;
            m_Spi.m_pfOnRspQryTransferSerial = pSpi.OnRspQryTransferSerial ;
            m_Spi.m_pfOnRspQryAccountregister = pSpi.OnRspQryAccountregister ;
            m_Spi.m_pfOnRspError = pSpi.OnRspError ;
            m_Spi.m_pfOnRtnOrder = pSpi.OnRtnOrder ;
            m_Spi.m_pfOnRtnTrade = pSpi.OnRtnTrade ;
            m_Spi.m_pfOnErrRtnOrderInsert = pSpi.OnErrRtnOrderInsert ;
            m_Spi.m_pfOnErrRtnOrderAction = pSpi.OnErrRtnOrderAction ;
            m_Spi.m_pfOnRtnInstrumentStatus = pSpi.OnRtnInstrumentStatus ;
            m_Spi.m_pfOnRtnTradingNotice = pSpi.OnRtnTradingNotice ;
            m_Spi.m_pfOnRtnErrorConditionalOrder = pSpi.OnRtnErrorConditionalOrder ;
            m_Spi.m_pfOnRspQryContractBank = pSpi.OnRspQryContractBank ;
            m_Spi.m_pfOnRspQryParkedOrder = pSpi.OnRspQryParkedOrder ;
            m_Spi.m_pfOnRspQryParkedOrderAction = pSpi.OnRspQryParkedOrderAction ;
            m_Spi.m_pfOnRspQryTradingNotice = pSpi.OnRspQryTradingNotice ;
            m_Spi.m_pfOnRspQryBrokerTradingParams = pSpi.OnRspQryBrokerTradingParams ;
            m_Spi.m_pfOnRspQryBrokerTradingAlgos = pSpi.OnRspQryBrokerTradingAlgos ;
            m_Spi.m_pfOnRtnFromBankToFutureByBank = pSpi.OnRtnFromBankToFutureByBank ;
            m_Spi.m_pfOnRtnFromFutureToBankByBank = pSpi.OnRtnFromFutureToBankByBank ;
            m_Spi.m_pfOnRtnRepealFromBankToFutureByBank = pSpi.OnRtnRepealFromBankToFutureByBank ;
            m_Spi.m_pfOnRtnRepealFromFutureToBankByBank = pSpi.OnRtnRepealFromFutureToBankByBank ;
            m_Spi.m_pfOnRtnFromBankToFutureByFuture = pSpi.OnRtnFromBankToFutureByFuture ;
            m_Spi.m_pfOnRtnFromFutureToBankByFuture = pSpi.OnRtnFromFutureToBankByFuture ;
            m_Spi.m_pfOnRtnRepealFromBankToFutureByFutureManual = pSpi.OnRtnRepealFromBankToFutureByFutureManual ;
            m_Spi.m_pfOnRtnRepealFromFutureToBankByFutureManual = pSpi.OnRtnRepealFromFutureToBankByFutureManual ;
            m_Spi.m_pfOnRtnQueryBankBalanceByFuture = pSpi.OnRtnQueryBankBalanceByFuture ;
            m_Spi.m_pfOnErrRtnBankToFutureByFuture = pSpi.OnErrRtnBankToFutureByFuture ;
            m_Spi.m_pfOnErrRtnFutureToBankByFuture = pSpi.OnErrRtnFutureToBankByFuture ;
            m_Spi.m_pfOnErrRtnRepealBankToFutureByFutureManual = pSpi.OnErrRtnRepealBankToFutureByFutureManual ;
            m_Spi.m_pfOnErrRtnRepealFutureToBankByFutureManual = pSpi.OnErrRtnRepealFutureToBankByFutureManual ;
            m_Spi.m_pfOnErrRtnQueryBankBalanceByFuture = pSpi.OnErrRtnQueryBankBalanceByFuture ;
            m_Spi.m_pfOnRtnRepealFromBankToFutureByFuture = pSpi.OnRtnRepealFromBankToFutureByFuture ;
            m_Spi.m_pfOnRtnRepealFromFutureToBankByFuture = pSpi.OnRtnRepealFromFutureToBankByFuture ;
            m_Spi.m_pfOnRspFromBankToFutureByFuture = pSpi.OnRspFromBankToFutureByFuture ;
            m_Spi.m_pfOnRspFromFutureToBankByFuture = pSpi.OnRspFromFutureToBankByFuture ;
            m_Spi.m_pfOnRspQueryBankAccountMoneyByFuture = pSpi.OnRspQueryBankAccountMoneyByFuture ;
            m_Spi.m_pfOnRtnOpenAccountByBank = pSpi.OnRtnOpenAccountByBank ;
            m_Spi.m_pfOnRtnCancelAccountByBank = pSpi.OnRtnCancelAccountByBank ;
            m_Spi.m_pfOnRtnChangeAccountByBank = pSpi.OnRtnChangeAccountByBank ;

            ThostFtdcTraderApiAdapter.RegisterSpi(pTraderApi, ref m_Spi);
        }

        ///订阅私有流。
        ///@param nResumeType 私有流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后私有流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        public void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType)
        {
            ThostFtdcTraderApiAdapter.SubscribePrivateTopic(pTraderApi, nResumeType);
        }

        ///订阅公共流。
        ///@param nResumeType 公共流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后公共流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
        public void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType)
        {
            ThostFtdcTraderApiAdapter.SubscribePublicTopic(pTraderApi, nResumeType);
        }

        ///客户端认证请求
        public int ReqAuthenticate(ref CThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqAuthenticate(pTraderApi, ref pReqAuthenticateField, nRequestID);
        }

        ///用户登录请求
        public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqUserLogin(pTraderApi, ref pReqUserLoginField, nRequestID);
        }


        ///登出请求
        public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqUserLogout(pTraderApi, ref pUserLogout, nRequestID);
        }

        ///用户口令更新请求
        public int ReqUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqUserPasswordUpdate(pTraderApi, ref pUserPasswordUpdate, nRequestID);
        }

        ///资金账户口令更新请求
        public int ReqTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqTradingAccountPasswordUpdate(pTraderApi, ref pTradingAccountPasswordUpdate, nRequestID);
        }

        ///报单录入请求
        public int ReqOrderInsert(ref CThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqOrderInsert(pTraderApi, ref pInputOrder, nRequestID);
        }

        ///预埋单录入请求
        public int ReqParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqParkedOrderInsert(pTraderApi, ref pParkedOrder, nRequestID);
        }

        ///预埋撤单录入请求
        public int ReqParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqParkedOrderAction(pTraderApi, ref pParkedOrderAction, nRequestID);
        }

        ///报单操作请求
        public int ReqOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqOrderAction(pTraderApi, ref pInputOrderAction, nRequestID);
        }

        ///查询最大报单数量请求
        public int ReqQueryMaxOrderVolume(ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQueryMaxOrderVolume(pTraderApi, ref pQueryMaxOrderVolume, nRequestID);
        }

        ///投资者结算结果确认
        public int ReqSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqSettlementInfoConfirm(pTraderApi, ref pSettlementInfoConfirm, nRequestID);
        }

        ///请求删除预埋单
        public int ReqRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqRemoveParkedOrder(pTraderApi, ref pRemoveParkedOrder, nRequestID);
        }

        ///请求删除预埋撤单
        public int ReqRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqRemoveParkedOrderAction(pTraderApi, ref pRemoveParkedOrderAction, nRequestID);
        }

        ///请求查询报单
        public int ReqQryOrder(ref CThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryOrder(pTraderApi, ref pQryOrder, nRequestID);
        }

        ///请求查询成交
        public int ReqQryTrade(ref CThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTrade(pTraderApi, ref pQryTrade, nRequestID);
        }

        ///请求查询投资者持仓
        public int ReqQryInvestorPosition(ref CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInvestorPosition(pTraderApi, ref pQryInvestorPosition, nRequestID);
        }

        ///请求查询资金账户
        public int ReqQryTradingAccount(ref CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTradingAccount(pTraderApi, ref pQryTradingAccount, nRequestID);
        }

        ///请求查询投资者
        public int ReqQryInvestor(ref CThostFtdcQryInvestorField pQryInvestor, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInvestor(pTraderApi, ref pQryInvestor, nRequestID);
        }

        ///请求查询交易编码
        public int ReqQryTradingCode(ref CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTradingCode(pTraderApi, ref pQryTradingCode, nRequestID);
        }

        ///请求查询合约保证金率
        public int ReqQryInstrumentMarginRate(ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInstrumentMarginRate(pTraderApi, ref pQryInstrumentMarginRate, nRequestID);
        }

        ///请求查询合约手续费率
        public int ReqQryInstrumentCommissionRate(ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInstrumentCommissionRate(pTraderApi, ref pQryInstrumentCommissionRate, nRequestID);
        }

        ///请求查询交易所
        public int ReqQryExchange(ref CThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryExchange(pTraderApi, ref pQryExchange, nRequestID);
        }

        ///请求查询合约
        public int ReqQryInstrument(ref CThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInstrument(pTraderApi, ref pQryInstrument, nRequestID);
        }

        ///请求查询行情
        public int ReqQryDepthMarketData(ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryDepthMarketData(pTraderApi, ref pQryDepthMarketData, nRequestID);
        }

        ///请求查询投资者结算结果
        public int ReqQrySettlementInfo(ref CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQrySettlementInfo(pTraderApi, ref pQrySettlementInfo, nRequestID);
        }

        ///请求查询转帐银行
        public int ReqQryTransferBank(ref CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTransferBank(pTraderApi, ref pQryTransferBank, nRequestID);
        }

        ///请求查询投资者持仓明细
        public int ReqQryInvestorPositionDetail(ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInvestorPositionDetail(pTraderApi, ref pQryInvestorPositionDetail, nRequestID);
        }

        ///请求查询客户通知
        public int ReqQryNotice(ref CThostFtdcQryNoticeField pQryNotice, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryNotice(pTraderApi, ref pQryNotice, nRequestID);
        }

        ///请求查询结算信息确认
        public int ReqQrySettlementInfoConfirm(ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQrySettlementInfoConfirm(pTraderApi, ref pQrySettlementInfoConfirm, nRequestID);
        }

        ///请求查询投资者持仓明细
        public int ReqQryInvestorPositionCombineDetail(ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryInvestorPositionCombineDetail(pTraderApi, ref pQryInvestorPositionCombineDetail, nRequestID);
        }

        ///请求查询保证金监管系统经纪公司资金账户密钥
        public int ReqQryCFMMCTradingAccountKey(ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryCFMMCTradingAccountKey(pTraderApi, ref pQryCFMMCTradingAccountKey, nRequestID);
        }

        ///请求查询仓单折抵信息
        public int ReqQryEWarrantOffset(ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryEWarrantOffset(pTraderApi, ref pQryEWarrantOffset, nRequestID);
        }

        ///请求查询转帐流水
        public int ReqQryTransferSerial(ref CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTransferSerial(pTraderApi, ref pQryTransferSerial, nRequestID);
        }

        ///请求查询银期签约关系
        public int ReqQryAccountregister(ref CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryAccountregister(pTraderApi, ref pQryAccountregister, nRequestID);
        }

        ///请求查询签约银行
        public int ReqQryContractBank(ref CThostFtdcQryContractBankField pQryContractBank, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryContractBank(pTraderApi, ref pQryContractBank, nRequestID);
        }

        ///请求查询预埋单
        public int ReqQryParkedOrder(ref CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryParkedOrder(pTraderApi, ref pQryParkedOrder, nRequestID);
        }

        ///请求查询预埋撤单
        public int ReqQryParkedOrderAction(ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryParkedOrderAction(pTraderApi, ref pQryParkedOrderAction, nRequestID);
        }

        ///请求查询交易通知
        public int ReqQryTradingNotice(ref CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryTradingNotice(pTraderApi, ref pQryTradingNotice, nRequestID);
        }

        ///请求查询经纪公司交易参数
        public int ReqQryBrokerTradingParams(ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryBrokerTradingParams(pTraderApi, ref pQryBrokerTradingParams, nRequestID);
        }

        ///请求查询经纪公司交易算法
        public int ReqQryBrokerTradingAlgos(ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQryBrokerTradingAlgos(pTraderApi, ref pQryBrokerTradingAlgos, nRequestID);
        }

        ///期货发起银行资金转期货请求
        public int ReqFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqFromBankToFutureByFuture(pTraderApi, ref pReqTransfer, nRequestID);
        }

        ///期货发起期货资金转银行请求
        public int ReqFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqFromFutureToBankByFuture(pTraderApi, ref pReqTransfer, nRequestID);
        }

        ///期货发起查询银行余额请求
        public int ReqQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID)
        {
            return ThostFtdcTraderApiAdapter.ReqQueryBankAccountMoneyByFuture(pTraderApi, ref pReqQueryAccount, nRequestID);
        }

        
        private IntPtr pTraderApi = IntPtr.Zero;
        private CThostFtdcTraderApi() { }

        
        private static object obj = new object();

        STraderSpi m_Spi = new STraderSpi();

    };

    public class Test
    {
        public static void Main(string[] args)
        {

        }
    }
}
