#include "TraderApi.h"
#include "TraderSpiAdapter.h"

CThostFtdcTraderApi * __stdcall CreateFtdcTraderApi( const char *pszFlowPath /*= ""*/, const bool bIsUsingUdp/*=false*/ )
{
	return CThostFtdcTraderApi::CreateFtdcTraderApi(pszFlowPath, bIsUsingUdp);
}

void __stdcall Release( CThostFtdcTraderApi* pTraderApi )
{
	pTraderApi->Release();
}

void __stdcall Init( CThostFtdcTraderApi* pTraderApi )
{
	pTraderApi->Init();
}

int __stdcall Join( CThostFtdcTraderApi* pTraderApi )
{
	return pTraderApi->Join();
}

const char * __stdcall GetTradingDay(CThostFtdcTraderApi* pTraderApi)
{
	return pTraderApi->GetTradingDay();
}

void __stdcall RegisterFront( CThostFtdcTraderApi* pTraderApi, char *pszFrontAddress )
{
	pTraderApi->RegisterFront(pszFrontAddress);
}

void __stdcall RegisterNameServer( CThostFtdcTraderApi* pTraderApi, char *pszNsAddress )
{
	pTraderApi->RegisterNameServer(pszNsAddress);
}

void __stdcall SubscribePrivateTopic( CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType )
{
	pTraderApi->SubscribePrivateTopic(nResumeType);
}

void __stdcall SubscribePublicTopic( CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType )
{
	pTraderApi->SubscribePublicTopic(nResumeType);
}

int __stdcall ReqAuthenticate( CThostFtdcTraderApi* pTraderApi, CThostFtdcReqAuthenticateField *pReqAuthenticateField, int nRequestID )
{
	return pTraderApi->ReqAuthenticate(pReqAuthenticateField, nRequestID);
}

int __stdcall ReqUserLogin( CThostFtdcTraderApi* pTraderApi, CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID )
{
	return pTraderApi->ReqUserLogin(pReqUserLoginField, nRequestID);
}

int __stdcall ReqUserLogout( CThostFtdcTraderApi* pTraderApi, CThostFtdcUserLogoutField *pUserLogout, int nRequestID )
{
	return pTraderApi->ReqUserLogout(pUserLogout, nRequestID);
}

int __stdcall ReqUserPasswordUpdate( CThostFtdcTraderApi* pTraderApi, CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, int nRequestID )
{
	return pTraderApi->ReqUserPasswordUpdate(pUserPasswordUpdate, nRequestID);
}

int __stdcall ReqTradingAccountPasswordUpdate( CThostFtdcTraderApi* pTraderApi, CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, int nRequestID )
{
	return pTraderApi->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, nRequestID);
}

int __stdcall ReqOrderInsert( CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderField *pInputOrder, int nRequestID )
{
	return pTraderApi->ReqOrderInsert(pInputOrder, nRequestID);
}

int __stdcall ReqParkedOrderInsert( CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderField *pParkedOrder, int nRequestID )
{
	return pTraderApi->ReqParkedOrderInsert(pParkedOrder, nRequestID);
}

int __stdcall ReqParkedOrderAction( CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderActionField *pParkedOrderAction, int nRequestID )
{
	return pTraderApi->ReqParkedOrderAction(pParkedOrderAction, nRequestID);
}

int __stdcall ReqOrderAction( CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderActionField *pInputOrderAction, int nRequestID )
{
	return pTraderApi->ReqOrderAction(pInputOrderAction, nRequestID);
}

int __stdcall ReqQueryMaxOrderVolume( CThostFtdcTraderApi* pTraderApi, CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, int nRequestID )
{
	return pTraderApi->ReqQueryMaxOrderVolume(pQueryMaxOrderVolume, nRequestID);
}

int __stdcall ReqSettlementInfoConfirm( CThostFtdcTraderApi* pTraderApi, CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, int nRequestID )
{
	return pTraderApi->ReqSettlementInfoConfirm(pSettlementInfoConfirm, nRequestID);
}

int __stdcall ReqRemoveParkedOrder( CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, int nRequestID )
{
	return pTraderApi->ReqRemoveParkedOrder(pRemoveParkedOrder, nRequestID);
}

int __stdcall ReqRemoveParkedOrderAction( CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, int nRequestID )
{
	return pTraderApi->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction, nRequestID);
}

int __stdcall ReqQryOrder( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryOrderField *pQryOrder, int nRequestID )
{
	return pTraderApi->ReqQryOrder(pQryOrder, nRequestID);
}

int __stdcall ReqQryTrade( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradeField *pQryTrade, int nRequestID )
{
	return pTraderApi->ReqQryTrade(pQryTrade, nRequestID);
}

int __stdcall ReqQryInvestorPosition( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionField *pQryInvestorPosition, int nRequestID )
{
	return pTraderApi->ReqQryInvestorPosition(pQryInvestorPosition, nRequestID);
}

int __stdcall ReqQryTradingAccount( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingAccountField *pQryTradingAccount, int nRequestID )
{
	return pTraderApi->ReqQryTradingAccount(pQryTradingAccount, nRequestID);
}

int __stdcall ReqQryInvestor( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorField *pQryInvestor, int nRequestID )
{
	return pTraderApi->ReqQryInvestor(pQryInvestor, nRequestID);
}

int __stdcall ReqQryTradingCode( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingCodeField *pQryTradingCode, int nRequestID )
{
	return pTraderApi->ReqQryTradingCode(pQryTradingCode, nRequestID);
}

int __stdcall ReqQryInstrumentMarginRate( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentMarginRateField *pQryInstrumentMarginRate, int nRequestID )
{
	return pTraderApi->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate, nRequestID);
}

int __stdcall ReqQryInstrumentCommissionRate( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentCommissionRateField *pQryInstrumentCommissionRate, int nRequestID )
{
	return pTraderApi->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate, nRequestID);
}

int __stdcall ReqQryExchange( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryExchangeField *pQryExchange, int nRequestID )
{
	return pTraderApi->ReqQryExchange(pQryExchange, nRequestID);
}

int __stdcall ReqQryInstrument( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentField *pQryInstrument, int nRequestID )
{
	return pTraderApi->ReqQryInstrument(pQryInstrument, nRequestID);
}

int __stdcall ReqQryDepthMarketData( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryDepthMarketDataField *pQryDepthMarketData, int nRequestID )
{
	return pTraderApi->ReqQryDepthMarketData(pQryDepthMarketData, nRequestID);
}

int __stdcall ReqQrySettlementInfo( CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoField *pQrySettlementInfo, int nRequestID )
{
	return pTraderApi->ReqQrySettlementInfo(pQrySettlementInfo, nRequestID);
}

int __stdcall ReqQryTransferBank( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferBankField *pQryTransferBank, int nRequestID )
{
	return pTraderApi->ReqQryTransferBank(pQryTransferBank, nRequestID);
}

int __stdcall ReqQryInvestorPositionDetail( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionDetailField *pQryInvestorPositionDetail, int nRequestID )
{
	return pTraderApi->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail, nRequestID);
}

int __stdcall ReqQryNotice( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryNoticeField *pQryNotice, int nRequestID )
{
	return pTraderApi->ReqQryNotice(pQryNotice, nRequestID);
}

int __stdcall ReqQrySettlementInfoConfirm( CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoConfirmField *pQrySettlementInfoConfirm, int nRequestID )
{
	return pTraderApi->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm, nRequestID);
}

int __stdcall ReqQryInvestorPositionCombineDetail( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionCombineDetailField *pQryInvestorPositionCombineDetail, int nRequestID )
{
	return pTraderApi->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail, nRequestID);
}

int __stdcall ReqQryCFMMCTradingAccountKey( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryCFMMCTradingAccountKeyField *pQryCFMMCTradingAccountKey, int nRequestID )
{
	return pTraderApi->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey, nRequestID);
}

int __stdcall ReqQryEWarrantOffset( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryEWarrantOffsetField *pQryEWarrantOffset, int nRequestID )
{
	return pTraderApi->ReqQryEWarrantOffset(pQryEWarrantOffset, nRequestID);
}

int __stdcall ReqQryTransferSerial( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferSerialField *pQryTransferSerial, int nRequestID )
{
	return pTraderApi->ReqQryTransferSerial(pQryTransferSerial, nRequestID);
}

int __stdcall ReqQryAccountregister( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryAccountregisterField *pQryAccountregister, int nRequestID )
{
	return pTraderApi->ReqQryAccountregister(pQryAccountregister, nRequestID);
}

int __stdcall ReqQryContractBank( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryContractBankField *pQryContractBank, int nRequestID )
{
	return pTraderApi->ReqQryContractBank(pQryContractBank, nRequestID);
}

int __stdcall ReqQryParkedOrder( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderField *pQryParkedOrder, int nRequestID )
{
	return pTraderApi->ReqQryParkedOrder(pQryParkedOrder, nRequestID);
}

int __stdcall ReqQryParkedOrderAction( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderActionField *pQryParkedOrderAction, int nRequestID )
{
	return pTraderApi->ReqQryParkedOrderAction(pQryParkedOrderAction, nRequestID);
}

int __stdcall ReqQryTradingNotice( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingNoticeField *pQryTradingNotice, int nRequestID )
{
	return pTraderApi->ReqQryTradingNotice(pQryTradingNotice, nRequestID);
}

int __stdcall ReqQryBrokerTradingParams( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingParamsField *pQryBrokerTradingParams, int nRequestID )
{
	return pTraderApi->ReqQryBrokerTradingParams(pQryBrokerTradingParams, nRequestID);
}

int __stdcall ReqQryBrokerTradingAlgos( CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingAlgosField *pQryBrokerTradingAlgos, int nRequestID )
{
	return pTraderApi->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos, nRequestID);
}

int __stdcall ReqFromBankToFutureByFuture( CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID )
{
	return pTraderApi->ReqFromBankToFutureByFuture(pReqTransfer, nRequestID);
}

int __stdcall ReqFromFutureToBankByFuture( CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID )
{
	return pTraderApi->ReqFromFutureToBankByFuture(pReqTransfer, nRequestID);
}

int __stdcall ReqQueryBankAccountMoneyByFuture( CThostFtdcTraderApi* pTraderApi, CThostFtdcReqQueryAccountField *pReqQueryAccount, int nRequestID )
{
	return pTraderApi->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount, nRequestID);
}

void __stdcall RegisterSpi( CThostFtdcTraderApi* pTraderApi, STraderSpi *pSpi )
{
	CTraderSpiAdapter* tsa = new CTraderSpiAdapter(*pSpi);
	pTraderApi->RegisterSpi(tsa);
}
