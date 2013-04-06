#pragma once

#include "FuncDef.h"

extern "C"
{	
	__declspec(dllexport) CThostFtdcMdApi * __stdcall CreateFtdcMdApi(const char *pszFlowPath, const bool bIsUsingUdp);

	__declspec(dllexport) void __stdcall Release(CThostFtdcMdApi * pMdApi);

	__declspec(dllexport) void __stdcall Init(CThostFtdcMdApi * pMdApi);

	__declspec(dllexport) int __stdcall Join(CThostFtdcMdApi * pMdApi);

	__declspec(dllexport) const char * __stdcall GetTradingDay(CThostFtdcMdApi * pMdApi);

	__declspec(dllexport) void __stdcall RegisterFront(CThostFtdcMdApi * pMdApi, char *pszFrontAddress);

	__declspec(dllexport) void __stdcall RegisterNameServer(CThostFtdcMdApi * pMdApi, char *pszNsAddress);

	__declspec(dllexport) void __stdcall RegisterFunc(CThostFtdcMdApi * pMdApi, 
		FPOnFrontConnected pfOnFrontConnected, FPOnFrontDisconnected pfOnFrontDisconnected,
		FPOnHeartBeatWarning pfOnHeartBeatWarning, 	FPOnRspUserLogin pfOnRspUserLogin,
		FPOnRspUserLogout pfOnRspUserLogout,	FPOnRspError pfOnRspError,
		FPOnRspSubMarketData pfOnRspSubMarketData,	FPOnRspUnSubMarketData pfOnRspUnSubMarketData,
		FPOnRtnDepthMarketData pfOnRtnDepthMarketData);

	__declspec(dllexport) int __stdcall SubscribeMarketData(CThostFtdcMdApi * pMdApi, char *ppInstrumentID[], int nCount);

	__declspec(dllexport) int __stdcall UnSubscribeMarketData(CThostFtdcMdApi * pMdApi, char *ppInstrumentID[], int nCount);

	__declspec(dllexport) int __stdcall ReqUserLogin(CThostFtdcMdApi * pMdApi, CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID);

	__declspec(dllexport) int __stdcall ReqUserLogout(CThostFtdcMdApi * pMdApi, CThostFtdcUserLogoutField *pUserLogout, int nRequestID);
};