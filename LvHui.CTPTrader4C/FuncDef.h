#pragma once

#include "ThostFtdcTraderApi.h"

///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
typedef void (__stdcall * FPOnFrontConnected)();

///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
///@param nReason 错误原因
///        0x1001 网络读失败
///        0x1002 网络写失败
///        0x2001 接收心跳超时
///        0x2002 发送心跳失败
///        0x2003 收到错误报文
typedef void (__stdcall * FPOnFrontDisconnected)(int nReason);

///心跳超时警告。当长时间未收到报文时，该方法被调用。
///@param nTimeLapse 距离上次接收报文的时间
typedef void (__stdcall * FPOnHeartBeatWarning)(int nTimeLapse);

///客户端认证响应
typedef void (__stdcall * FPOnRspAuthenticate)(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;


///登录请求响应
typedef void (__stdcall * FPOnRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///登出请求响应
typedef void (__stdcall * FPOnRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///用户口令更新请求响应
typedef void (__stdcall * FPOnRspUserPasswordUpdate)(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///资金账户口令更新请求响应
typedef void (__stdcall * FPOnRspTradingAccountPasswordUpdate)(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///报单录入请求响应
typedef void (__stdcall * FPOnRspOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///预埋单录入请求响应
typedef void (__stdcall * FPOnRspParkedOrderInsert)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///预埋撤单录入请求响应
typedef void (__stdcall * FPOnRspParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///报单操作请求响应
typedef void (__stdcall * FPOnRspOrderAction)(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///查询最大报单数量响应
typedef void (__stdcall * FPOnRspQueryMaxOrderVolume)(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///投资者结算结果确认响应
typedef void (__stdcall * FPOnRspSettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///删除预埋单响应
typedef void (__stdcall * FPOnRspRemoveParkedOrder)(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///删除预埋撤单响应
typedef void (__stdcall * FPOnRspRemoveParkedOrderAction)(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询报单响应
typedef void (__stdcall * FPOnRspQryOrder)(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询成交响应
typedef void (__stdcall * FPOnRspQryTrade)(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询投资者持仓响应
typedef void (__stdcall * FPOnRspQryInvestorPosition)(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询资金账户响应
typedef void (__stdcall * FPOnRspQryTradingAccount)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询投资者响应
typedef void (__stdcall * FPOnRspQryInvestor)(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询交易编码响应
typedef void (__stdcall * FPOnRspQryTradingCode)(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询合约保证金率响应
typedef void (__stdcall * FPOnRspQryInstrumentMarginRate)(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询合约手续费率响应
typedef void (__stdcall * FPOnRspQryInstrumentCommissionRate)(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询交易所响应
typedef void (__stdcall * FPOnRspQryExchange)(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询合约响应
typedef void (__stdcall * FPOnRspQryInstrument)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询行情响应
typedef void (__stdcall * FPOnRspQryDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询投资者结算结果响应
typedef void (__stdcall * FPOnRspQrySettlementInfo)(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询转帐银行响应
typedef void (__stdcall * FPOnRspQryTransferBank)(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询投资者持仓明细响应
typedef void (__stdcall * FPOnRspQryInvestorPositionDetail)(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询客户通知响应
typedef void (__stdcall * FPOnRspQryNotice)(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询结算信息确认响应
typedef void (__stdcall * FPOnRspQrySettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询投资者持仓明细响应
typedef void (__stdcall * FPOnRspQryInvestorPositionCombineDetail)(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///查询保证金监管系统经纪公司资金账户密钥响应
typedef void (__stdcall * FPOnRspQryCFMMCTradingAccountKey)(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询仓单折抵信息响应
typedef void (__stdcall * FPOnRspQryEWarrantOffset)(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询转帐流水响应
typedef void (__stdcall * FPOnRspQryTransferSerial)(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询银期签约关系响应
typedef void (__stdcall * FPOnRspQryAccountregister)(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///错误应答
typedef void (__stdcall * FPOnRspError)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///报单通知
typedef void (__stdcall * FPOnRtnOrder)(CThostFtdcOrderField *pOrder) ;

///成交通知
typedef void (__stdcall * FPOnRtnTrade)(CThostFtdcTradeField *pTrade) ;

///报单录入错误回报
typedef void (__stdcall * FPOnErrRtnOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) ;

///报单操作错误回报
typedef void (__stdcall * FPOnErrRtnOrderAction)(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) ;

///合约交易状态通知
typedef void (__stdcall * FPOnRtnInstrumentStatus)(CThostFtdcInstrumentStatusField *pInstrumentStatus) ;

///交易通知
typedef void (__stdcall * FPOnRtnTradingNotice)(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) ;

///提示条件单校验错误
typedef void (__stdcall * FPOnRtnErrorConditionalOrder)(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) ;

///请求查询签约银行响应
typedef void (__stdcall * FPOnRspQryContractBank)(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询预埋单响应
typedef void (__stdcall * FPOnRspQryParkedOrder)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询预埋撤单响应
typedef void (__stdcall * FPOnRspQryParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询交易通知响应
typedef void (__stdcall * FPOnRspQryTradingNotice)(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询经纪公司交易参数响应
typedef void (__stdcall * FPOnRspQryBrokerTradingParams)(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///请求查询经纪公司交易算法响应
typedef void (__stdcall * FPOnRspQryBrokerTradingAlgos)(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///银行发起银行资金转期货通知
typedef void (__stdcall * FPOnRtnFromBankToFutureByBank)(CThostFtdcRspTransferField *pRspTransfer) ;

///银行发起期货资金转银行通知
typedef void (__stdcall * FPOnRtnFromFutureToBankByBank)(CThostFtdcRspTransferField *pRspTransfer) ;

///银行发起冲正银行转期货通知
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByBank)(CThostFtdcRspRepealField *pRspRepeal) ;

///银行发起冲正期货转银行通知
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByBank)(CThostFtdcRspRepealField *pRspRepeal) ;

///期货发起银行资金转期货通知
typedef void (__stdcall * FPOnRtnFromBankToFutureByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;

///期货发起期货资金转银行通知
typedef void (__stdcall * FPOnRtnFromFutureToBankByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;

///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;

///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;

///期货发起查询银行余额通知
typedef void (__stdcall * FPOnRtnQueryBankBalanceByFuture)(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) ;

///期货发起银行资金转期货错误回报
typedef void (__stdcall * FPOnErrRtnBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

///期货发起期货资金转银行错误回报
typedef void (__stdcall * FPOnErrRtnFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

///系统运行时期货端手工发起冲正银行转期货错误回报
typedef void (__stdcall * FPOnErrRtnRepealBankToFutureByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

///系统运行时期货端手工发起冲正期货转银行错误回报
typedef void (__stdcall * FPOnErrRtnRepealFutureToBankByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

///期货发起查询银行余额错误回报
typedef void (__stdcall * FPOnErrRtnQueryBankBalanceByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) ;

///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;

///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;

///期货发起银行资金转期货应答
typedef void (__stdcall * FPOnRspFromBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///期货发起期货资金转银行应答
typedef void (__stdcall * FPOnRspFromFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///期货发起查询银行余额应答
typedef void (__stdcall * FPOnRspQueryBankAccountMoneyByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///银行发起银期开户通知
typedef void (__stdcall * FPOnRtnOpenAccountByBank)(CThostFtdcOpenAccountField *pOpenAccount) ;

///银行发起银期销户通知
typedef void (__stdcall * FPOnRtnCancelAccountByBank)(CThostFtdcCancelAccountField *pCancelAccount) ;

///银行发起变更银行账号通知
typedef void (__stdcall * FPOnRtnChangeAccountByBank)(CThostFtdcChangeAccountField *pChangeAccount) ;