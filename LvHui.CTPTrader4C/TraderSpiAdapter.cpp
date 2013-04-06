#include "TraderSpiAdapter.h"

///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
void CTraderSpiAdapter::OnFrontConnected ()
{
	m_pfOnFrontConnected();
}

///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
///@param nReason 错误原因
///        0x1001 网络读失败
///        0x1002 网络写失败
///        0x2001 接收心跳超时
///        0x2002 发送心跳失败
///        0x2003 收到错误报文
void CTraderSpiAdapter::OnFrontDisconnected (int nReason)
{
	m_pfOnFrontDisconnected(nReason);
}

///心跳超时警告。当长时间未收到报文时，该方法被调用。
///@param nTimeLapse 距离上次接收报文的时间
void CTraderSpiAdapter::OnHeartBeatWarning (int nTimeLapse)
{
	m_pfOnHeartBeatWarning(nTimeLapse);
}

///客户端认证响应
void CTraderSpiAdapter::OnRspAuthenticate (CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspAuthenticate(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
}


///登录请求响应
void CTraderSpiAdapter::OnRspUserLogin (CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
}

///登出请求响应
void CTraderSpiAdapter::OnRspUserLogout (CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
}

///用户口令更新请求响应
void CTraderSpiAdapter::OnRspUserPasswordUpdate (CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserPasswordUpdate(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
}

///资金账户口令更新请求响应
void CTraderSpiAdapter::OnRspTradingAccountPasswordUpdate (CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
}

///报单录入请求响应
void CTraderSpiAdapter::OnRspOrderInsert (CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspOrderInsert(pInputOrder, pRspInfo, nRequestID, bIsLast);
}

///预埋单录入请求响应
void CTraderSpiAdapter::OnRspParkedOrderInsert (CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspParkedOrderInsert(pParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///预埋撤单录入请求响应
void CTraderSpiAdapter::OnRspParkedOrderAction (CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///报单操作请求响应
void CTraderSpiAdapter::OnRspOrderAction (CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspOrderAction(pInputOrderAction, pRspInfo, nRequestID, bIsLast);
}

///查询最大报单数量响应
void CTraderSpiAdapter::OnRspQueryMaxOrderVolume (CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQueryMaxOrderVolume(pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
}

///投资者结算结果确认响应
void CTraderSpiAdapter::OnRspSettlementInfoConfirm (CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspSettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
}

///删除预埋单响应
void CTraderSpiAdapter::OnRspRemoveParkedOrder (CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspRemoveParkedOrder(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///删除预埋撤单响应
void CTraderSpiAdapter::OnRspRemoveParkedOrderAction (CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspRemoveParkedOrderAction(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///请求查询报单响应
void CTraderSpiAdapter::OnRspQryOrder (CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryOrder(pOrder, pRspInfo, nRequestID, bIsLast);
}

///请求查询成交响应
void CTraderSpiAdapter::OnRspQryTrade (CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTrade(pTrade, pRspInfo, nRequestID, bIsLast);
}

///请求查询投资者持仓响应
void CTraderSpiAdapter::OnRspQryInvestorPosition (CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPosition(pInvestorPosition, pRspInfo, nRequestID, bIsLast);
}

///请求查询资金账户响应
void CTraderSpiAdapter::OnRspQryTradingAccount (CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingAccount(pTradingAccount, pRspInfo, nRequestID, bIsLast);
}

///请求查询投资者响应
void CTraderSpiAdapter::OnRspQryInvestor (CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestor(pInvestor, pRspInfo, nRequestID, bIsLast);
}

///请求查询交易编码响应
void CTraderSpiAdapter::OnRspQryTradingCode (CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingCode(pTradingCode, pRspInfo, nRequestID, bIsLast);
}

///请求查询合约保证金率响应
void CTraderSpiAdapter::OnRspQryInstrumentMarginRate (CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrumentMarginRate(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
}

///请求查询合约手续费率响应
void CTraderSpiAdapter::OnRspQryInstrumentCommissionRate (CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrumentCommissionRate(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
}

///请求查询交易所响应
void CTraderSpiAdapter::OnRspQryExchange (CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryExchange(pExchange, pRspInfo, nRequestID, bIsLast);
}

///请求查询合约响应
void CTraderSpiAdapter::OnRspQryInstrument (CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrument(pInstrument, pRspInfo, nRequestID, bIsLast);
}

///请求查询行情响应
void CTraderSpiAdapter::OnRspQryDepthMarketData (CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryDepthMarketData(pDepthMarketData, pRspInfo, nRequestID, bIsLast);
}

///请求查询投资者结算结果响应
void CTraderSpiAdapter::OnRspQrySettlementInfo (CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQrySettlementInfo(pSettlementInfo, pRspInfo, nRequestID, bIsLast);
}

///请求查询转帐银行响应
void CTraderSpiAdapter::OnRspQryTransferBank (CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTransferBank(pTransferBank, pRspInfo, nRequestID, bIsLast);
}

///请求查询投资者持仓明细响应
void CTraderSpiAdapter::OnRspQryInvestorPositionDetail (CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPositionDetail(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
}

///请求查询客户通知响应
void CTraderSpiAdapter::OnRspQryNotice (CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryNotice(pNotice, pRspInfo, nRequestID, bIsLast);
}

///请求查询结算信息确认响应
void CTraderSpiAdapter::OnRspQrySettlementInfoConfirm (CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQrySettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
}

///请求查询投资者持仓明细响应
void CTraderSpiAdapter::OnRspQryInvestorPositionCombineDetail (CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
}

///查询保证金监管系统经纪公司资金账户密钥响应
void CTraderSpiAdapter::OnRspQryCFMMCTradingAccountKey (CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
}

///请求查询仓单折抵信息响应
void CTraderSpiAdapter::OnRspQryEWarrantOffset (CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryEWarrantOffset(pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
}

///请求查询转帐流水响应
void CTraderSpiAdapter::OnRspQryTransferSerial (CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTransferSerial(pTransferSerial, pRspInfo, nRequestID, bIsLast);
}

///请求查询银期签约关系响应
void CTraderSpiAdapter::OnRspQryAccountregister (CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryAccountregister(pAccountregister, pRspInfo, nRequestID, bIsLast);
}

///错误应答
void CTraderSpiAdapter::OnRspError (CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspError(pRspInfo, nRequestID, bIsLast);
}

///报单通知
void CTraderSpiAdapter::OnRtnOrder (CThostFtdcOrderField *pOrder)
{
	m_pfOnRtnOrder(pOrder);
}

///成交通知
void CTraderSpiAdapter::OnRtnTrade (CThostFtdcTradeField *pTrade)
{
	m_pfOnRtnTrade(pTrade);
}

///报单录入错误回报
void CTraderSpiAdapter::OnErrRtnOrderInsert (CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnOrderInsert(pInputOrder, pRspInfo);
}

///报单操作错误回报
void CTraderSpiAdapter::OnErrRtnOrderAction (CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnOrderAction(pOrderAction, pRspInfo);
}

///合约交易状态通知
void CTraderSpiAdapter::OnRtnInstrumentStatus (CThostFtdcInstrumentStatusField *pInstrumentStatus)
{
	m_pfOnRtnInstrumentStatus(pInstrumentStatus);
}

///交易通知
void CTraderSpiAdapter::OnRtnTradingNotice (CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo)
{
	m_pfOnRtnTradingNotice(pTradingNoticeInfo);
}

///提示条件单校验错误
void CTraderSpiAdapter::OnRtnErrorConditionalOrder (CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder)
{
	m_pfOnRtnErrorConditionalOrder(pErrorConditionalOrder);
}

///请求查询签约银行响应
void CTraderSpiAdapter::OnRspQryContractBank (CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryContractBank(pContractBank, pRspInfo, nRequestID, bIsLast);
}

///请求查询预埋单响应
void CTraderSpiAdapter::OnRspQryParkedOrder (CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryParkedOrder(pParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///请求查询预埋撤单响应
void CTraderSpiAdapter::OnRspQryParkedOrderAction (CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///请求查询交易通知响应
void CTraderSpiAdapter::OnRspQryTradingNotice (CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingNotice(pTradingNotice, pRspInfo, nRequestID, bIsLast);
}

///请求查询经纪公司交易参数响应
void CTraderSpiAdapter::OnRspQryBrokerTradingParams (CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryBrokerTradingParams(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
}

///请求查询经纪公司交易算法响应
void CTraderSpiAdapter::OnRspQryBrokerTradingAlgos (CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryBrokerTradingAlgos(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
}

///银行发起银行资金转期货通知
void CTraderSpiAdapter::OnRtnFromBankToFutureByBank (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromBankToFutureByBank(pRspTransfer);
}

///银行发起期货资金转银行通知
void CTraderSpiAdapter::OnRtnFromFutureToBankByBank (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromFutureToBankByBank(pRspTransfer);
}

///银行发起冲正银行转期货通知
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByBank (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByBank(pRspRepeal);
}

///银行发起冲正期货转银行通知
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByBank (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByBank(pRspRepeal);
}

///期货发起银行资金转期货通知
void CTraderSpiAdapter::OnRtnFromBankToFutureByFuture (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromBankToFutureByFuture(pRspTransfer);
}

///期货发起期货资金转银行通知
void CTraderSpiAdapter::OnRtnFromFutureToBankByFuture (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromFutureToBankByFuture(pRspTransfer);
}

///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByFutureManual (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
}

///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByFutureManual (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
}

///期货发起查询银行余额通知
void CTraderSpiAdapter::OnRtnQueryBankBalanceByFuture (CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount)
{
	m_pfOnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
}

///期货发起银行资金转期货错误回报
void CTraderSpiAdapter::OnErrRtnBankToFutureByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnBankToFutureByFuture(pReqTransfer, pRspInfo);
}

///期货发起期货资金转银行错误回报
void CTraderSpiAdapter::OnErrRtnFutureToBankByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnFutureToBankByFuture(pReqTransfer, pRspInfo);
}

///系统运行时期货端手工发起冲正银行转期货错误回报
void CTraderSpiAdapter::OnErrRtnRepealBankToFutureByFutureManual (CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnRepealBankToFutureByFutureManual(pReqRepeal, pRspInfo);
}

///系统运行时期货端手工发起冲正期货转银行错误回报
void CTraderSpiAdapter::OnErrRtnRepealFutureToBankByFutureManual (CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnRepealFutureToBankByFutureManual(pReqRepeal, pRspInfo);
}

///期货发起查询银行余额错误回报
void CTraderSpiAdapter::OnErrRtnQueryBankBalanceByFuture (CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnQueryBankBalanceByFuture(pReqQueryAccount, pRspInfo);
}

///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByFuture (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByFuture(pRspRepeal);
}

///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByFuture (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByFuture(pRspRepeal);
}

///期货发起银行资金转期货应答
void CTraderSpiAdapter::OnRspFromBankToFutureByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspFromBankToFutureByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
}

///期货发起期货资金转银行应答
void CTraderSpiAdapter::OnRspFromFutureToBankByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspFromFutureToBankByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
}

///期货发起查询银行余额应答
void CTraderSpiAdapter::OnRspQueryBankAccountMoneyByFuture (CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQueryBankAccountMoneyByFuture(pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
}

///银行发起银期开户通知
void CTraderSpiAdapter::OnRtnOpenAccountByBank (CThostFtdcOpenAccountField *pOpenAccount)
{
	m_pfOnRtnOpenAccountByBank(pOpenAccount);
}

///银行发起银期销户通知
void CTraderSpiAdapter::OnRtnCancelAccountByBank (CThostFtdcCancelAccountField *pCancelAccount)
{
	m_pfOnRtnCancelAccountByBank(pCancelAccount);
}

///银行发起变更银行账号通知
void CTraderSpiAdapter::OnRtnChangeAccountByBank (CThostFtdcChangeAccountField *pChangeAccount)
{
	m_pfOnRtnChangeAccountByBank(pChangeAccount);
}

CTraderSpiAdapter::CTraderSpiAdapter( const STraderSpi& spi ):STraderSpi(spi)
{

}
