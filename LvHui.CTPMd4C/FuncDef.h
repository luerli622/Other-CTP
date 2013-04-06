#pragma once
#include "ThostFtdcMdApi.h"

typedef void (__stdcall * FPOnFrontConnected)();
typedef void (__stdcall * FPOnFrontDisconnected)(int nReason);
typedef void (__stdcall * FPOnHeartBeatWarning)(int nTimeLapse);
typedef void (__stdcall * FPOnRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef void (__stdcall * FPOnRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall * FPOnRspError)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall * FPOnRspSubMarketData)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall * FPOnRspUnSubMarketData)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall * FPOnRtnDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData);