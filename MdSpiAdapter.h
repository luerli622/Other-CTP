#pragma once

#include "MdApi.h"

class CMdSpiAdapter : public CThostFtdcMdSpi
{
public:
	FPOnFrontConnected m_pfOnFrontConnected;
	FPOnFrontDisconnected m_pfOnFrontDisconnected;
	FPOnHeartBeatWarning m_pfOnHeartBeatWarning;
	FPOnRspUserLogin m_pfOnRspUserLogin;
	FPOnRspUserLogout m_pfOnRspUserLogout;	
	FPOnRspError m_pfOnRspError;
	FPOnRspSubMarketData m_pfOnRspSubMarketData;	
	FPOnRspUnSubMarketData m_pfOnRspUnSubMarketData;
	FPOnRtnDepthMarketData m_pfOnRtnDepthMarketData;

public:
	virtual void OnFrontConnected();
	virtual void OnFrontDisconnected(int nReason);
	virtual void OnHeartBeatWarning(int nTimeLapse);
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData);
};

