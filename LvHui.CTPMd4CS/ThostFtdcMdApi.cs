#region Version Info
/* ======================================================================== 
* 作者：吕辉       时间：2013/4/3 10:44:53
* email：lvhui.cn@gmail.com 
* 文件名：ThostFtdcMdApi.cs 
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

namespace LvHui.CTPMd4CS
{
    public class CThostFtdcMdSpi
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


        ///登录请求响应
        public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///登出请求响应
        public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///错误应答
        public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///订阅行情应答
        public virtual void OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///取消订阅行情应答
        public virtual void OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }

        ///深度行情通知
        public virtual void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData) { }
    };

    public class CThostFtdcMdApi
    {
        ///创建MdApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        ///modify for udp marketdata
        public static CThostFtdcMdApi CreateFtdcMdApi(string pszFlowPath = "", bool bIsUsingUdp = false)
        {
            CThostFtdcMdApi Api = new CThostFtdcMdApi();
            Api.pMdApi = ThostFtdcMdApiAdapter.CreateFtdcMdApi(pszFlowPath, bIsUsingUdp);                        
            return Api;
        }

        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        public void Release()
        {
            ThostFtdcMdApiAdapter.Release(pMdApi);
        }

        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        public void Init()
        {
            ThostFtdcMdApiAdapter.Init(pMdApi);
        }

        ///等待接口线程结束运行
        ///@return 线程退出代码
        public int Join()
        {
            return ThostFtdcMdApiAdapter.Join(pMdApi);
        }

        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        public string GetTradingDay()
        {
            return ThostFtdcMdApiAdapter.GetTradingDay(pMdApi);
        }

        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址
        ///。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。 
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        public void RegisterFront(string pszFrontAddress)
        {
            ThostFtdcMdApiAdapter.RegisterFront(pMdApi, pszFrontAddress);
        }

        ///注册名字服务器网络地址
        ///@param pszNsAddress：名字服务器网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。 
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
        ///@remark RegisterNameServer优先于RegisterFront
        public void RegisterNameServer(string pszNsAddress)
        {
            ThostFtdcMdApiAdapter.RegisterNameServer(pMdApi, pszNsAddress);
        }

        ///注册回调接口
        ///@param pSpi 派生自回调接口类的实例
        public void RegisterSpi(ref CThostFtdcMdSpi pSpi)
        {
            m_OnFrontConnected = pSpi.OnFrontConnected;
            m_OnFrontDisconnected = pSpi.OnFrontDisconnected;
            m_OnHeartBeatWarning = pSpi.OnHeartBeatWarning;
            m_OnRspUserLogin = pSpi.OnRspUserLogin;
            m_OnRspUserLogout = pSpi.OnRspUserLogout;
            m_OnRspError = pSpi.OnRspError;
            m_OnRspSubMarketData = pSpi.OnRspSubMarketData;
            m_OnRspUnSubMarketData = pSpi.OnRspUnSubMarketData;
            m_OnRtnDepthMarketData = pSpi.OnRtnDepthMarketData;

            ThostFtdcMdApiAdapter.RegisterFunc(pMdApi,
                m_OnFrontConnected, m_OnFrontDisconnected,
                m_OnHeartBeatWarning, m_OnRspUserLogin,
                m_OnRspUserLogout, m_OnRspError,
                m_OnRspSubMarketData, m_OnRspUnSubMarketData,
                m_OnRtnDepthMarketData);
        }

        ///订阅行情。
        ///@param ppInstrumentID 合约ID  
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark 
        public int SubscribeMarketData(string[] ppInstrumentID, int nCount)
        {
            return ThostFtdcMdApiAdapter.SubscribeMarketData(pMdApi, ppInstrumentID, nCount);
        }

        ///退订行情。
        ///@param ppInstrumentID 合约ID  
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark 
        public int UnSubscribeMarketData(string[] ppInstrumentID, int nCount)
        {
            return ThostFtdcMdApiAdapter.UnSubscribeMarketData(pMdApi, ppInstrumentID, nCount);
        }

        ///用户登录请求
        public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return ThostFtdcMdApiAdapter.ReqUserLogin(pMdApi, ref pReqUserLoginField, nRequestID);
        }

        ///登出请求
        public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return ThostFtdcMdApiAdapter.ReqUserLogout(pMdApi, ref pUserLogout, nRequestID);
        }

        
        private IntPtr pMdApi = IntPtr.Zero;
        private CThostFtdcMdApi() { }

       
        private static object obj = new object();

        private OnFrontConnected m_OnFrontConnected;
        private OnFrontDisconnected m_OnFrontDisconnected;
        private OnHeartBeatWarning m_OnHeartBeatWarning;
        private OnRspUserLogin m_OnRspUserLogin;
        private OnRspUserLogout m_OnRspUserLogout;
        private OnRspError m_OnRspError;
        private OnRspSubMarketData m_OnRspSubMarketData;
        private OnRspUnSubMarketData m_OnRspUnSubMarketData;
        private OnRtnDepthMarketData m_OnRtnDepthMarketData;

    }

    public class MySpi : CThostFtdcMdSpi
    {
        public override void OnFrontConnected()
        {
        }

        public override void OnFrontDisconnected(int nReason)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void OnHeartBeatWarning(int nTimeLapse)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        public override void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {

        }

        public override void OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            System.Console.Write(pDepthMarketData.InstrumentID, pDepthMarketData.Volume, pDepthMarketData.UpdateTime);
            System.Console.Write(pDepthMarketData.Volume);
            System.Console.WriteLine(pDepthMarketData.UpdateTime);
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            CThostFtdcMdApi mdapi = CThostFtdcMdApi.CreateFtdcMdApi();
            CThostFtdcMdSpi pUserSpi = new MySpi();
            mdapi.RegisterSpi(ref pUserSpi);
            mdapi.RegisterFront("tcp://210.13.70.236:31213");

            mdapi.Init();
            System.Threading.Thread.Sleep(2 * 1000);
            CThostFtdcReqUserLoginField ReqUserLoginField = new CThostFtdcReqUserLoginField();
            mdapi.ReqUserLogin(ref ReqUserLoginField, 1);

            string[] ifs = new string[2];
            ifs[0] = "IF1304";
            ifs[1] = "IF1305";
            mdapi.SubscribeMarketData(ifs, 2);

            mdapi.Join();
        }
    }
}
