#region Version Info
/* ======================================================================== 
* 作者：吕辉       时间：2013/4/3 11:34:24
* email：lvhui.cn@gmail.com 
* 文件名：ThostFtdcMdApiAdapter.cs
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

namespace LvHui.CTPMd4CS
{
    delegate void OnFrontConnected();
    delegate void OnFrontDisconnected(int nReason);
    delegate void OnHeartBeatWarning(int nTimeLapse);
    delegate void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    delegate void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    delegate void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    delegate void OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    delegate void OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    delegate void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);

    class ThostFtdcMdApiAdapter
    {
        [DllImport("CTPMd4C.dll", EntryPoint = "_CreateFtdcMdApi@8", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateFtdcMdApi(String pszFlowPath = "", bool bIsUsingUdp = false);

        [DllImport("CTPMd4C.dll", EntryPoint = "_Release@4", CallingConvention = CallingConvention.StdCall)]
        public static extern void Release(IntPtr pMdApi);

        [DllImport("CTPMd4C.dll", EntryPoint = "_Init@4", CallingConvention = CallingConvention.StdCall)]
        public static extern void Init(IntPtr pMdApi);

        [DllImport("CTPMd4C.dll", EntryPoint = "_Join@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int Join(IntPtr pMdApi);

        [DllImport("CTPMd4C.dll", EntryPoint = "_GetTradingDay@4", CallingConvention = CallingConvention.StdCall)]
        public static extern string GetTradingDay(IntPtr pMdApi);

        [DllImport("CTPMd4C.dll", EntryPoint = "_RegisterFront@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterFront(IntPtr pMdApi, string pszFrontAddress);

        [DllImport("CTPMd4C.dll", EntryPoint = "_RegisterNameServer@8", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterNameServer(IntPtr pMdApi, string pszNsAddress);

        [DllImport("CTPMd4C.dll", EntryPoint = "_RegisterFunc@40", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegisterFunc(IntPtr pMdApi,
        OnFrontConnected pfOnFrontConnected, OnFrontDisconnected pfOnFrontDisconnected,
        OnHeartBeatWarning pfOnHeartBeatWarning, OnRspUserLogin pfOnRspUserLogin,
        OnRspUserLogout pfOnRspUserLogout, OnRspError pfOnRspError,
        OnRspSubMarketData pfOnRspSubMarketData, OnRspUnSubMarketData pfOnRspUnSubMarketData,
        OnRtnDepthMarketData pfOnRtnDepthMarketData);

        [DllImport("CTPMd4C.dll", EntryPoint = "_SubscribeMarketData@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int SubscribeMarketData(IntPtr pMdApi, string[] ppInstrumentID, int nCount);

        [DllImport("CTPMd4C.dll", EntryPoint = "_UnSubscribeMarketData@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int UnSubscribeMarketData(IntPtr pMdApi, string[] ppInstrumentID, int nCount);

        [DllImport("CTPMd4C.dll", EntryPoint = "_ReqUserLogin@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqUserLogin(IntPtr pMdApi, ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        [DllImport("CTPMd4C.dll", EntryPoint = "_ReqUserLogout@12", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReqUserLogout(IntPtr pMdApi, ref CThostFtdcUserLogoutField pUserLogout, int nRequestID);
    }
}
