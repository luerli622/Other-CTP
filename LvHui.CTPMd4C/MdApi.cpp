#include "MdApi.h"
#include "MdSpiAdapter.h"
#include "ThostFtdcMdApi.h"

CThostFtdcMdApi * __stdcall CreateFtdcMdApi( const char *pszFlowPath /*= ""*/, const bool bIsUsingUdp/*=false*/ )
{
	return CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath, bIsUsingUdp);
}

void __stdcall  Release( CThostFtdcMdApi * pMdApi )
{
	pMdApi->Release();
}

void __stdcall Init( CThostFtdcMdApi * pMdApi )
{
	pMdApi->Init();
}

int __stdcall Join( CThostFtdcMdApi * pMdApi )
{
	return pMdApi->Join();
}

const char * __stdcall GetTradingDay( CThostFtdcMdApi * pMdApi )
{
	return pMdApi->GetTradingDay();
}

void __stdcall RegisterFront( CThostFtdcMdApi * pMdApi, char *pszFrontAddress )
{
	pMdApi->RegisterFront(pszFrontAddress);
}

void __stdcall RegisterNameServer( CThostFtdcMdApi * pMdApi, char *pszNsAddress )
{
	pMdApi->RegisterNameServer(pszNsAddress);
}

void __stdcall RegisterFunc( CThostFtdcMdApi * pMdApi, FPOnFrontConnected pfOnFrontConnected, FPOnFrontDisconnected pfOnFrontDisconnected, FPOnHeartBeatWarning pfOnHeartBeatWarning, FPOnRspUserLogin pfOnRspUserLogin, FPOnRspUserLogout pfOnRspUserLogout, FPOnRspError pfOnRspError, FPOnRspSubMarketData pfOnRspSubMarketData, FPOnRspUnSubMarketData pfOnRspUnSubMarketData, FPOnRtnDepthMarketData pfOnRtnDepthMarketData )
{
	CMdSpiAdapter * pSpi = new CMdSpiAdapter();
	pSpi->m_pfOnFrontConnected = pfOnFrontConnected;	
	pSpi->m_pfOnFrontDisconnected = pfOnFrontDisconnected;
	pSpi->m_pfOnHeartBeatWarning = pfOnHeartBeatWarning;
	pSpi->m_pfOnRspUserLogin = pfOnRspUserLogin;
	pSpi->m_pfOnRspUserLogout = pfOnRspUserLogout;	
	pSpi->m_pfOnRspError = pfOnRspError;
	pSpi->m_pfOnRspSubMarketData = pfOnRspSubMarketData;	
	pSpi->m_pfOnRspUnSubMarketData = pfOnRspUnSubMarketData;
	pSpi->m_pfOnRtnDepthMarketData = pfOnRtnDepthMarketData;

	pMdApi->RegisterSpi(pSpi);
}

int __stdcall SubscribeMarketData( CThostFtdcMdApi * pMdApi, char *ppInstrumentID[], int nCount )
{
	return pMdApi->SubscribeMarketData(ppInstrumentID, nCount);
}

int __stdcall UnSubscribeMarketData( CThostFtdcMdApi * pMdApi, char *ppInstrumentID[], int nCount )
{
	return pMdApi->UnSubscribeMarketData(ppInstrumentID, nCount);
}

int __stdcall ReqUserLogin( CThostFtdcMdApi * pMdApi, CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID )
{
	return pMdApi->ReqUserLogin(pReqUserLoginField, nRequestID);
}

int __stdcall ReqUserLogout( CThostFtdcMdApi * pMdApi, CThostFtdcUserLogoutField *pUserLogout, int nRequestID )
{
	return pMdApi->ReqUserLogout(pUserLogout, nRequestID);
}



