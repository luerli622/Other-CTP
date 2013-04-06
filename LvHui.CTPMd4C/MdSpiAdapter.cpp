#include "MdSpiAdapter.h"


void CMdSpiAdapter::OnFrontConnected()
{
	m_pfOnFrontConnected();
}

void CMdSpiAdapter::OnFrontDisconnected( int nReason )
{
	m_pfOnFrontDisconnected(nReason);
}

void CMdSpiAdapter::OnHeartBeatWarning( int nTimeLapse )
{
	m_pfOnHeartBeatWarning(nTimeLapse);
}

void CMdSpiAdapter::OnRspUserLogin( CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast )
{
	m_pfOnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
}

void CMdSpiAdapter::OnRspUserLogout( CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast )
{
	m_pfOnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
}

void CMdSpiAdapter::OnRspError( CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast )
{
	m_pfOnRspError(pRspInfo, nRequestID, bIsLast);
}

void CMdSpiAdapter::OnRspSubMarketData( CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast )
{
	m_pfOnRspSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
}

void CMdSpiAdapter::OnRspUnSubMarketData( CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast )
{
	m_pfOnRspUnSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
}

void CMdSpiAdapter::OnRtnDepthMarketData( CThostFtdcDepthMarketDataField *pDepthMarketData )
{
	m_pfOnRtnDepthMarketData(pDepthMarketData);
}
