#region Version Info
/* ======================================================================== 
* 作者：吕辉       时间：2013/4/2 9:32:40 
* 文件名：ThostFtdcUserApiStruct.cs 
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

namespace LvHui.CTP4CS
{
    ///信息分发
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcDisseminationField
    {
        ///序列系列号
        public short SequenceSeries;
        ///序列号
        public int SequenceNo;
    };

    ///用户登录请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqUserLoginField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///接口端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string InterfaceProductInfo;
        ///协议信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ProtocolInfo;
        ///Mac地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MacAddress;
        ///动态密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string OneTimePassword;
        ///终端IP地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string ClientIPAddress;
    };

    ///用户登录应答
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspUserLoginField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///登录成功时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LoginTime;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易系统名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string SystemName;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///最大报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MaxOrderRef;
        ///上期所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SHFETime;
        ///大商所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string DCETime;
        ///郑商所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CZCETime;
        ///中金所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string FFEXTime;
    };

    ///用户登出请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserLogoutField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///强制交易员退出
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcForceUserLogoutField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///客户端认证请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqAuthenticateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///认证码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string AuthCode;
    };

    ///客户端认证响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspAuthenticateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
    };

    ///客户端认证信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcAuthenticationInfoField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///认证信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string AuthInfo;
        ///是否为认证结果
        public int IsResult;
    };

    ///银期转帐报文头
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferHeaderField
    {
        ///版本号，常量，1.0
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string Version;
        ///交易代码，必填
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///交易日期，必填，格式：yyyymmdd
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间，必填，格式：hhmmss
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///发起方流水号，N/A
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeSerial;
        ///期货公司代码，必填
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string FutureID;
        ///银行代码，根据查询银行得到，必填
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码，根据查询银行得到，必填
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
        ///操作员，N/A
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///交易设备类型，N/A
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///记录数，N/A
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string RecordNum;
        ///会话编号，N/A
        public int SessionID;
        ///请求编号，N/A
        public int RequestID;
    };

    ///银行资金转期货请求，TradeCode=202001
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferBankToFutureReqField
    {
        ///期货资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FuturePwdFlag;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string FutureAccPwd;
        ///转账金额
        public double TradeAmt;
        ///客户手续费
        public double CustFee;
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///银行资金转期货请求响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferBankToFutureRspField
    {
        ///响应代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string RetCode;
        ///响应信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string RetInfo;
        ///资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///转帐金额
        public double TradeAmt;
        ///应收客户手续费
        public double CustFee;
        ///币种
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///期货资金转银行请求，TradeCode=202002
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferFutureToBankReqField
    {
        ///期货资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FuturePwdFlag;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string FutureAccPwd;
        ///转账金额
        public double TradeAmt;
        ///客户手续费
        public double CustFee;
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///期货资金转银行请求响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferFutureToBankRspField
    {
        ///响应代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string RetCode;
        ///响应信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string RetInfo;
        ///资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///转帐金额
        public double TradeAmt;
        ///应收客户手续费
        public double CustFee;
        ///币种
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///查询银行资金请求，TradeCode=204002
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferQryBankReqField
    {
        ///期货资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FuturePwdFlag;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string FutureAccPwd;
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///查询银行资金请求响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferQryBankRspField
    {
        ///响应代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string RetCode;
        ///响应信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string RetInfo;
        ///资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
        ///银行余额
        public double TradeAmt;
        ///银行可用余额
        public double UseAmt;
        ///银行可取余额
        public double FetchAmt;
        ///币种
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
    };

    ///查询银行交易明细请求，TradeCode=204999
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferQryDetailReqField
    {
        ///期货资金账户
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string FutureAccount;
    };

    ///查询银行交易明细请求响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferQryDetailRspField
    {
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///交易代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///期货流水号
        public int FutureSerial;
        ///期货公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string FutureID;
        ///资金帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=22)]
		public string FutureAccount;
        ///银行流水号
        public int BankSerial;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
        ///银行账号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CertCode;
        ///货币代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyCode;
        ///发生金额
        public double TxAmount;
        ///有效标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Flag;
    };

    ///响应信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspInfoField
    {
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///交易所
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeName;
        ///交易所属性
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ExchangeProperty;
    };

    ///产品
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcProductField
    {
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ProductID;
        ///产品名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string ProductName;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///产品类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ProductClass;
        ///合约数量乘数
        public int VolumeMultiple;
        ///最小变动价位
        public double PriceTick;
        ///市价单最大下单量
        public int MaxMarketOrderVolume;
        ///市价单最小下单量
        public int MinMarketOrderVolume;
        ///限价单最大下单量
        public int MaxLimitOrderVolume;
        ///限价单最小下单量
        public int MinLimitOrderVolume;
        ///持仓类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionType;
        ///持仓日期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionDateType;
        ///平仓处理类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CloseDealType;
    };

    ///合约
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string InstrumentName;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ProductID;
        ///产品类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ProductClass;
        ///交割年份
        public int DeliveryYear;
        ///交割月
        public int DeliveryMonth;
        ///市价单最大下单量
        public int MaxMarketOrderVolume;
        ///市价单最小下单量
        public int MinMarketOrderVolume;
        ///限价单最大下单量
        public int MaxLimitOrderVolume;
        ///限价单最小下单量
        public int MinLimitOrderVolume;
        ///合约数量乘数
        public int VolumeMultiple;
        ///最小变动价位
        public double PriceTick;
        ///创建日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CreateDate;
        ///上市日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OpenDate;
        ///到期日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExpireDate;
        ///开始交割日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string StartDelivDate;
        ///结束交割日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string EndDelivDate;
        ///合约生命周期状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InstLifePhase;
        ///当前是否交易
        public int IsTrading;
        ///持仓类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionType;
        ///持仓日期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionDateType;
        ///多头保证金率
        public double LongMarginRatio;
        ///空头保证金率
        public double ShortMarginRatio;
    };

    ///经纪公司
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///经纪公司简称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string BrokerAbbr;
        ///经纪公司名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string BrokerName;
        ///是否活跃
        public int IsActive;
    };

    ///交易所交易员
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTraderField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装数量
        public int InstallCount;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///投资者
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorField
    {
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者分组代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorGroupID;
        ///投资者名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string InvestorName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdentifiedCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///是否活跃
        public int IsActive;
        ///联系电话
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///通讯地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///开户日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OpenDate;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Mobile;
        ///手续费率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string CommModelID;
        ///保证金率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MarginModelID;
    };

    ///交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingCodeField
    {
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///是否活跃
        public int IsActive;
        ///交易编码类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ClientIDType;
    };

    ///会员编码和经纪公司编码对照表
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcPartBrokerField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///是否活跃
        public int IsActive;
    };

    ///管理用户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSuperUserField
    {
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string UserName;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///是否活跃
        public int IsActive;
    };

    ///管理用户功能权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSuperUserFunctionField
    {
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///功能代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FunctionCode;
    };

    ///投资者组
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorGroupField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者分组代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorGroupID;
        ///投资者分组名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string InvestorGroupName;
    };

    ///资金账户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingAccountField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///上次质押金额
        public double PreMortgage;
        ///上次信用额度
        public double PreCredit;
        ///上次存款额
        public double PreDeposit;
        ///上次结算准备金
        public double PreBalance;
        ///上次占用的保证金
        public double PreMargin;
        ///利息基数
        public double InterestBase;
        ///利息收入
        public double Interest;
        ///入金金额
        public double Deposit;
        ///出金金额
        public double Withdraw;
        ///冻结的保证金
        public double FrozenMargin;
        ///冻结的资金
        public double FrozenCash;
        ///冻结的手续费
        public double FrozenCommission;
        ///当前保证金总额
        public double CurrMargin;
        ///资金差额
        public double CashIn;
        ///手续费
        public double Commission;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///期货结算准备金
        public double Balance;
        ///可用资金
        public double Available;
        ///可取资金
        public double WithdrawQuota;
        ///基本准备金
        public double Reserve;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///信用额度
        public double Credit;
        ///质押金额
        public double Mortgage;
        ///交易所保证金
        public double ExchangeMargin;
        ///投资者交割保证金
        public double DeliveryMargin;
        ///交易所交割保证金
        public double ExchangeDeliveryMargin;
    };

    ///投资者持仓
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorPositionField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///持仓多空方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PosiDirection;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///持仓日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionDate;
        ///上日持仓
        public int YdPosition;
        ///今日持仓
        public int Position;
        ///多头冻结
        public int LongFrozen;
        ///空头冻结
        public int ShortFrozen;
        ///开仓冻结金额
        public double LongFrozenAmount;
        ///开仓冻结金额
        public double ShortFrozenAmount;
        ///开仓量
        public int OpenVolume;
        ///平仓量
        public int CloseVolume;
        ///开仓金额
        public double OpenAmount;
        ///平仓金额
        public double CloseAmount;
        ///持仓成本
        public double PositionCost;
        ///上次占用的保证金
        public double PreMargin;
        ///占用的保证金
        public double UseMargin;
        ///冻结的保证金
        public double FrozenMargin;
        ///冻结的资金
        public double FrozenCash;
        ///冻结的手续费
        public double FrozenCommission;
        ///资金差额
        public double CashIn;
        ///手续费
        public double Commission;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///上次结算价
        public double PreSettlementPrice;
        ///本次结算价
        public double SettlementPrice;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///开仓成本
        public double OpenCost;
        ///交易所保证金
        public double ExchangeMargin;
        ///组合成交形成的持仓
        public int CombPosition;
        ///组合多头冻结
        public int CombLongFrozen;
        ///组合空头冻结
        public int CombShortFrozen;
        ///逐日盯市平仓盈亏
        public double CloseProfitByDate;
        ///逐笔对冲平仓盈亏
        public double CloseProfitByTrade;
        ///今日持仓
        public int TodayPosition;
        ///保证金率
        public double MarginRateByMoney;
        ///保证金率(按手数)
        public double MarginRateByVolume;
    };

    ///合约保证金率
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentMarginRateField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///多头保证金率
        public double LongMarginRatioByMoney;
        ///多头保证金费
        public double LongMarginRatioByVolume;
        ///空头保证金率
        public double ShortMarginRatioByMoney;
        ///空头保证金费
        public double ShortMarginRatioByVolume;
        ///是否相对交易所收取
        public int IsRelative;
    };

    ///合约手续费率
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentCommissionRateField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///开仓手续费率
        public double OpenRatioByMoney;
        ///开仓手续费
        public double OpenRatioByVolume;
        ///平仓手续费率
        public double CloseRatioByMoney;
        ///平仓手续费
        public double CloseRatioByVolume;
        ///平今手续费率
        public double CloseTodayRatioByMoney;
        ///平今手续费
        public double CloseTodayRatioByVolume;
    };

    ///深度行情
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcDepthMarketDataField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///最新价
        public double LastPrice;
        ///上次结算价
        public double PreSettlementPrice;
        ///昨收盘
        public double PreClosePrice;
        ///昨持仓量
        public double PreOpenInterest;
        ///今开盘
        public double OpenPrice;
        ///最高价
        public double HighestPrice;
        ///最低价
        public double LowestPrice;
        ///数量
        public int Volume;
        ///成交金额
        public double Turnover;
        ///持仓量
        public double OpenInterest;
        ///今收盘
        public double ClosePrice;
        ///本次结算价
        public double SettlementPrice;
        ///涨停板价
        public double UpperLimitPrice;
        ///跌停板价
        public double LowerLimitPrice;
        ///昨虚实度
        public double PreDelta;
        ///今虚实度
        public double CurrDelta;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///最后修改毫秒
        public int UpdateMillisec;
        ///申买价一
        public double BidPrice1;
        ///申买量一
        public int BidVolume1;
        ///申卖价一
        public double AskPrice1;
        ///申卖量一
        public int AskVolume1;
        ///申买价二
        public double BidPrice2;
        ///申买量二
        public int BidVolume2;
        ///申卖价二
        public double AskPrice2;
        ///申卖量二
        public int AskVolume2;
        ///申买价三
        public double BidPrice3;
        ///申买量三
        public int BidVolume3;
        ///申卖价三
        public double AskPrice3;
        ///申卖量三
        public int AskVolume3;
        ///申买价四
        public double BidPrice4;
        ///申买量四
        public int BidVolume4;
        ///申卖价四
        public double AskPrice4;
        ///申卖量四
        public int AskVolume4;
        ///申买价五
        public double BidPrice5;
        ///申买量五
        public int BidVolume5;
        ///申卖价五
        public double AskPrice5;
        ///申卖量五
        public int AskVolume5;
        ///当日均价
        public double AveragePrice;
    };

    ///投资者合约交易权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentTradingRightField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易权限
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradingRight;
    };

    ///经纪公司用户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string UserName;
        ///用户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserType;
        ///是否活跃
        public int IsActive;
        ///是否使用令牌
        public int IsUsingOTP;
    };

    ///经纪公司用户口令
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserPasswordField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
    };

    ///经纪公司用户功能权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserFunctionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///经纪公司功能代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BrokerFunctionCode;
    };

    ///交易所交易员报盘机
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTraderOfferField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///交易所交易员连接状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TraderConnectStatus;
        ///发出连接请求的日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectRequestDate;
        ///发出连接请求的时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectRequestTime;
        ///上次报告日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportDate;
        ///上次报告时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportTime;
        ///完成连接日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectDate;
        ///完成连接时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectTime;
        ///启动日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string StartDate;
        ///启动时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string StartTime;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///本席位最大成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MaxTradeID;
        ///本席位最大报单备拷
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string MaxOrderMessageReference;
    };

    ///投资者结算结果
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSettlementInfoField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///序号
        public int SequenceNo;
        ///消息正文
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=501)]
		public string Content;
    };

    ///合约保证金率调整
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentMarginRateAdjustField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///多头保证金率
        public double LongMarginRatioByMoney;
        ///多头保证金费
        public double LongMarginRatioByVolume;
        ///空头保证金率
        public double ShortMarginRatioByMoney;
        ///空头保证金费
        public double ShortMarginRatioByVolume;
        ///是否相对交易所收取
        public int IsRelative;
    };

    ///交易所保证金率
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeMarginRateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///多头保证金率
        public double LongMarginRatioByMoney;
        ///多头保证金费
        public double LongMarginRatioByVolume;
        ///空头保证金率
        public double ShortMarginRatioByMoney;
        ///空头保证金费
        public double ShortMarginRatioByVolume;
    };

    ///交易所保证金率调整
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeMarginRateAdjustField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///跟随交易所投资者多头保证金率
        public double LongMarginRatioByMoney;
        ///跟随交易所投资者多头保证金费
        public double LongMarginRatioByVolume;
        ///跟随交易所投资者空头保证金率
        public double ShortMarginRatioByMoney;
        ///跟随交易所投资者空头保证金费
        public double ShortMarginRatioByVolume;
        ///交易所多头保证金率
        public double ExchLongMarginRatioByMoney;
        ///交易所多头保证金费
        public double ExchLongMarginRatioByVolume;
        ///交易所空头保证金率
        public double ExchShortMarginRatioByMoney;
        ///交易所空头保证金费
        public double ExchShortMarginRatioByVolume;
        ///不跟随交易所投资者多头保证金率
        public double NoLongMarginRatioByMoney;
        ///不跟随交易所投资者多头保证金费
        public double NoLongMarginRatioByVolume;
        ///不跟随交易所投资者空头保证金率
        public double NoShortMarginRatioByMoney;
        ///不跟随交易所投资者空头保证金费
        public double NoShortMarginRatioByVolume;
    };

    ///结算引用
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSettlementRefField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
    };

    ///当前时间
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCurrentTimeField
    {
        ///当前日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CurrDate;
        ///当前时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CurrTime;
        ///当前时间（毫秒）
        public int CurrMillisec;
    };

    ///通讯阶段
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCommPhaseField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///通讯时段编号
        public short CommPhaseNo;
    };

    ///登录信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcLoginInfoField
    {
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///登录日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LoginDate;
        ///登录时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LoginTime;
        ///IP地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string IPAddress;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///接口端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string InterfaceProductInfo;
        ///协议信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ProtocolInfo;
        ///系统名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string SystemName;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///最大报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MaxOrderRef;
        ///上期所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SHFETime;
        ///大商所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string DCETime;
        ///郑商所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CZCETime;
        ///中金所时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string FFEXTime;
        ///Mac地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MacAddress;
        ///动态密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string OneTimePassword;
    };

    ///登录信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcLogoutAllField
    {
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///系统名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string SystemName;
    };

    ///前置状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcFrontStatusField
    {
        ///前置编号
        public int FrontID;
        ///上次报告日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportDate;
        ///上次报告时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportTime;
        ///是否活跃
        public int IsActive;
    };

    ///用户口令变更
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserPasswordUpdateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///原来的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string OldPassword;
        ///新的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewPassword;
    };

    ///输入报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInputOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///用户强评标志
        public int UserForceClose;
        ///互换单标志
        public int IsSwapOrder;
    };

    ///报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///报单提交状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSubmitStatus;
        ///报单提示序号
        public int NotifySequence;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///报单来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSource;
        ///报单状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderStatus;
        ///报单类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderType;
        ///今成交数量
        public int VolumeTraded;
        ///剩余数量
        public int VolumeTotal;
        ///报单日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertDate;
        ///委托时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTime;
        ///激活时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActiveTime;
        ///挂起时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SuspendTime;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///撤销时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CancelTime;
        ///最后修改交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string ActiveTraderID;
        ///结算会员编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClearingPartID;
        ///序号
        public int SequenceNo;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///状态信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string StatusMsg;
        ///用户强评标志
        public int UserForceClose;
        ///操作用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string ActiveUserID;
        ///经纪公司报单编号
        public int BrokerOrderSeq;
        ///相关报单
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string RelativeOrderSysID;
        ///郑商所成交数量
        public int ZCETotalTradedVolume;
        ///互换单标志
        public int IsSwapOrder;
    };

    ///交易所报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeOrderField
    {
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///报单提交状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSubmitStatus;
        ///报单提示序号
        public int NotifySequence;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///报单来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSource;
        ///报单状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderStatus;
        ///报单类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderType;
        ///今成交数量
        public int VolumeTraded;
        ///剩余数量
        public int VolumeTotal;
        ///报单日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertDate;
        ///委托时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTime;
        ///激活时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActiveTime;
        ///挂起时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SuspendTime;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///撤销时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CancelTime;
        ///最后修改交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string ActiveTraderID;
        ///结算会员编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClearingPartID;
        ///序号
        public int SequenceNo;
    };

    ///交易所报单插入失败
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeOrderInsertErrorField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///输入报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInputOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///报单操作引用
        public int OrderActionRef;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///请求编号
        public int RequestID;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///操作标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ActionFlag;
        ///价格
        public double LimitPrice;
        ///数量变化
        public int VolumeChange;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///报单操作引用
        public int OrderActionRef;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///请求编号
        public int RequestID;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///操作标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ActionFlag;
        ///价格
        public double LimitPrice;
        ///数量变化
        public int VolumeChange;
        ///操作日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionDate;
        ///操作时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionTime;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///操作本地编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ActionLocalID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///报单操作状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderActionStatus;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///状态信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string StatusMsg;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///交易所报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeOrderActionField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///操作标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ActionFlag;
        ///价格
        public double LimitPrice;
        ///数量变化
        public int VolumeChange;
        ///操作日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionDate;
        ///操作时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionTime;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///操作本地编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ActionLocalID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///报单操作状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderActionStatus;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///交易所报单操作失败
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeOrderActionErrorField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///操作本地编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ActionLocalID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///交易所成交
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeTradeField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TradeID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///交易角色
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradingRole;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OffsetFlag;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///价格
        public double Price;
        ///数量
        public int Volume;
        ///成交时期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///成交时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///成交类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradeType;
        ///成交价来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PriceSource;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///结算会员编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClearingPartID;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///序号
        public int SequenceNo;
        ///成交来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradeSource;
    };

    ///成交
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TradeID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///交易角色
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradingRole;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OffsetFlag;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///价格
        public double Price;
        ///数量
        public int Volume;
        ///成交时期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///成交时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///成交类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradeType;
        ///成交价来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PriceSource;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///结算会员编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClearingPartID;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///序号
        public int SequenceNo;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///经纪公司报单编号
        public int BrokerOrderSeq;
        ///成交来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradeSource;
    };

    ///用户会话
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserSessionField
    {
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///登录日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LoginDate;
        ///登录时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LoginTime;
        ///IP地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string IPAddress;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///接口端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string InterfaceProductInfo;
        ///协议信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ProtocolInfo;
        ///Mac地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MacAddress;
    };

    ///查询最大报单数量
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQueryMaxOrderVolumeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OffsetFlag;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///最大允许报单数量
        public int MaxVolume;
    };

    ///投资者结算结果确认信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSettlementInfoConfirmField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///确认日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConfirmDate;
        ///确认时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConfirmTime;
    };

    ///出入金同步
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncDepositField
    {
        ///出入金流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=15)]
		public string DepositSeqNo;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///入金金额
        public double Deposit;
        ///是否强制进行
        public int IsForce;
    };

    ///经纪公司同步
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerSyncField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///正在同步中的投资者
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInvestorField
    {
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者分组代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorGroupID;
        ///投资者名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string InvestorName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdentifiedCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///是否活跃
        public int IsActive;
        ///联系电话
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///通讯地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///开户日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OpenDate;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Mobile;
        ///手续费率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string CommModelID;
        ///保证金率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MarginModelID;
    };

    ///正在同步中的交易代码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingTradingCodeField
    {
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///是否活跃
        public int IsActive;
        ///交易编码类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ClientIDType;
    };

    ///正在同步中的投资者分组
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInvestorGroupField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者分组代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorGroupID;
        ///投资者分组名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string InvestorGroupName;
    };

    ///正在同步中的交易账号
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingTradingAccountField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///上次质押金额
        public double PreMortgage;
        ///上次信用额度
        public double PreCredit;
        ///上次存款额
        public double PreDeposit;
        ///上次结算准备金
        public double PreBalance;
        ///上次占用的保证金
        public double PreMargin;
        ///利息基数
        public double InterestBase;
        ///利息收入
        public double Interest;
        ///入金金额
        public double Deposit;
        ///出金金额
        public double Withdraw;
        ///冻结的保证金
        public double FrozenMargin;
        ///冻结的资金
        public double FrozenCash;
        ///冻结的手续费
        public double FrozenCommission;
        ///当前保证金总额
        public double CurrMargin;
        ///资金差额
        public double CashIn;
        ///手续费
        public double Commission;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///期货结算准备金
        public double Balance;
        ///可用资金
        public double Available;
        ///可取资金
        public double WithdrawQuota;
        ///基本准备金
        public double Reserve;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///信用额度
        public double Credit;
        ///质押金额
        public double Mortgage;
        ///交易所保证金
        public double ExchangeMargin;
        ///投资者交割保证金
        public double DeliveryMargin;
        ///交易所交割保证金
        public double ExchangeDeliveryMargin;
    };

    ///正在同步中的投资者持仓
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInvestorPositionField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///持仓多空方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PosiDirection;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///持仓日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PositionDate;
        ///上日持仓
        public int YdPosition;
        ///今日持仓
        public int Position;
        ///多头冻结
        public int LongFrozen;
        ///空头冻结
        public int ShortFrozen;
        ///开仓冻结金额
        public double LongFrozenAmount;
        ///开仓冻结金额
        public double ShortFrozenAmount;
        ///开仓量
        public int OpenVolume;
        ///平仓量
        public int CloseVolume;
        ///开仓金额
        public double OpenAmount;
        ///平仓金额
        public double CloseAmount;
        ///持仓成本
        public double PositionCost;
        ///上次占用的保证金
        public double PreMargin;
        ///占用的保证金
        public double UseMargin;
        ///冻结的保证金
        public double FrozenMargin;
        ///冻结的资金
        public double FrozenCash;
        ///冻结的手续费
        public double FrozenCommission;
        ///资金差额
        public double CashIn;
        ///手续费
        public double Commission;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///上次结算价
        public double PreSettlementPrice;
        ///本次结算价
        public double SettlementPrice;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///开仓成本
        public double OpenCost;
        ///交易所保证金
        public double ExchangeMargin;
        ///组合成交形成的持仓
        public int CombPosition;
        ///组合多头冻结
        public int CombLongFrozen;
        ///组合空头冻结
        public int CombShortFrozen;
        ///逐日盯市平仓盈亏
        public double CloseProfitByDate;
        ///逐笔对冲平仓盈亏
        public double CloseProfitByTrade;
        ///今日持仓
        public int TodayPosition;
        ///保证金率
        public double MarginRateByMoney;
        ///保证金率(按手数)
        public double MarginRateByVolume;
    };

    ///正在同步中的合约保证金率
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInstrumentMarginRateField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///多头保证金率
        public double LongMarginRatioByMoney;
        ///多头保证金费
        public double LongMarginRatioByVolume;
        ///空头保证金率
        public double ShortMarginRatioByMoney;
        ///空头保证金费
        public double ShortMarginRatioByVolume;
        ///是否相对交易所收取
        public int IsRelative;
    };

    ///正在同步中的合约手续费率
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInstrumentCommissionRateField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///开仓手续费率
        public double OpenRatioByMoney;
        ///开仓手续费
        public double OpenRatioByVolume;
        ///平仓手续费率
        public double CloseRatioByMoney;
        ///平仓手续费
        public double CloseRatioByVolume;
        ///平今手续费率
        public double CloseTodayRatioByMoney;
        ///平今手续费
        public double CloseTodayRatioByVolume;
    };

    ///正在同步中的合约交易权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncingInstrumentTradingRightField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易权限
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradingRight;
    };

    ///查询报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///开始时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTimeStart;
        ///结束时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTimeEnd;
    };

    ///查询成交
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTradeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TradeID;
        ///开始时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTimeStart;
        ///结束时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTimeEnd;
    };

    ///查询投资者持仓
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInvestorPositionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///查询资金账户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTradingAccountField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///查询投资者
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInvestorField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///查询交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTradingCodeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///交易编码类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ClientIDType;
    };

    ///查询交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInvestorGroupField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///查询交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInstrumentMarginRateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
    };

    ///查询交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInstrumentCommissionRateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///查询交易编码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInstrumentTradingRightField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///查询经纪公司
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///查询交易员
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTraderField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
    };

    ///查询经纪公司会员代码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryPartBrokerField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
    };

    ///查询管理用户功能权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySuperUserFunctionField
    {
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///查询用户会话
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryUserSessionField
    {
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///查询前置状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryFrontStatusField
    {
        ///前置编号
        public int FrontID;
    };

    ///查询交易所报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryExchangeOrderField
    {
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
    };

    ///查询报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///查询交易所报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryExchangeOrderActionField
    {
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
    };

    ///查询管理用户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySuperUserField
    {
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///查询交易所
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryExchangeField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///查询产品
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryProductField
    {
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ProductID;
    };

    ///查询合约
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInstrumentField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ProductID;
    };

    ///查询行情
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryDepthMarketDataField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///查询经纪公司用户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerUserField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///查询经纪公司用户权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerUserFunctionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///查询交易员报盘机
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTraderOfferField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
    };

    ///查询出入金流水
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySyncDepositField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///出入金流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=15)]
		public string DepositSeqNo;
    };

    ///查询投资者结算结果
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySettlementInfoField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
    };

    ///查询报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryHisOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///开始时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTimeStart;
        ///结束时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTimeEnd;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
    };

    ///市场行情
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///最新价
        public double LastPrice;
        ///上次结算价
        public double PreSettlementPrice;
        ///昨收盘
        public double PreClosePrice;
        ///昨持仓量
        public double PreOpenInterest;
        ///今开盘
        public double OpenPrice;
        ///最高价
        public double HighestPrice;
        ///最低价
        public double LowestPrice;
        ///数量
        public int Volume;
        ///成交金额
        public double Turnover;
        ///持仓量
        public double OpenInterest;
        ///今收盘
        public double ClosePrice;
        ///本次结算价
        public double SettlementPrice;
        ///涨停板价
        public double UpperLimitPrice;
        ///跌停板价
        public double LowerLimitPrice;
        ///昨虚实度
        public double PreDelta;
        ///今虚实度
        public double CurrDelta;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///最后修改毫秒
        public int UpdateMillisec;
    };

    ///行情基础属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataBaseField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///上次结算价
        public double PreSettlementPrice;
        ///昨收盘
        public double PreClosePrice;
        ///昨持仓量
        public double PreOpenInterest;
        ///昨虚实度
        public double PreDelta;
    };

    ///行情静态属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataStaticField
    {
        ///今开盘
        public double OpenPrice;
        ///最高价
        public double HighestPrice;
        ///最低价
        public double LowestPrice;
        ///今收盘
        public double ClosePrice;
        ///涨停板价
        public double UpperLimitPrice;
        ///跌停板价
        public double LowerLimitPrice;
        ///本次结算价
        public double SettlementPrice;
        ///今虚实度
        public double CurrDelta;
    };

    ///行情最新成交属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataLastMatchField
    {
        ///最新价
        public double LastPrice;
        ///数量
        public int Volume;
        ///成交金额
        public double Turnover;
        ///持仓量
        public double OpenInterest;
    };

    ///行情最优价属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataBestPriceField
    {
        ///申买价一
        public double BidPrice1;
        ///申买量一
        public int BidVolume1;
        ///申卖价一
        public double AskPrice1;
        ///申卖量一
        public int AskVolume1;
    };

    ///行情申买二、三属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataBid23Field
    {
        ///申买价二
        public double BidPrice2;
        ///申买量二
        public int BidVolume2;
        ///申买价三
        public double BidPrice3;
        ///申买量三
        public int BidVolume3;
    };

    ///行情申卖二、三属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataAsk23Field
    {
        ///申卖价二
        public double AskPrice2;
        ///申卖量二
        public int AskVolume2;
        ///申卖价三
        public double AskPrice3;
        ///申卖量三
        public int AskVolume3;
    };

    ///行情申买四、五属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataBid45Field
    {
        ///申买价四
        public double BidPrice4;
        ///申买量四
        public int BidVolume4;
        ///申买价五
        public double BidPrice5;
        ///申买量五
        public int BidVolume5;
    };

    ///行情申卖四、五属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataAsk45Field
    {
        ///申卖价四
        public double AskPrice4;
        ///申卖量四
        public int AskVolume4;
        ///申卖价五
        public double AskPrice5;
        ///申卖量五
        public int AskVolume5;
    };

    ///行情更新时间属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataUpdateTimeField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///最后修改毫秒
        public int UpdateMillisec;
    };

    ///行情交易所代码属性
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataExchangeField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///指定的合约
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSpecificInstrumentField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///合约状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInstrumentStatusField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///结算组代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SettlementGroupID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///合约交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InstrumentStatus;
        ///交易阶段编号
        public int TradingSegmentSN;
        ///进入本状态时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string EnterTime;
        ///进入本状态原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string EnterReason;
    };

    ///查询合约状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInstrumentStatusField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
    };

    ///投资者账户
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorAccountField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
    };

    ///浮动盈亏算法
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcPositionProfitAlgorithmField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///盈亏算法
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Algorithm;
        ///备注
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=161)]
		public string Memo;
    };

    ///会员资金折扣
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcDiscountField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///资金折扣比例
        public double Discount;
    };

    ///查询转帐银行
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTransferBankField
    {
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
    };

    ///转帐银行
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferBankField
    {
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
        ///银行名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string BankName;
        ///是否活跃
        public int IsActive;
    };

    ///查询投资者持仓明细
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInvestorPositionDetailField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///投资者持仓明细
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorPositionDetailField
    {
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///买卖
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///开仓日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OpenDate;
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TradeID;
        ///数量
        public int Volume;
        ///开仓价
        public double OpenPrice;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///成交类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TradeType;
        ///组合合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string CombInstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///逐日盯市平仓盈亏
        public double CloseProfitByDate;
        ///逐笔对冲平仓盈亏
        public double CloseProfitByTrade;
        ///逐日盯市持仓盈亏
        public double PositionProfitByDate;
        ///逐笔对冲持仓盈亏
        public double PositionProfitByTrade;
        ///投资者保证金
        public double Margin;
        ///交易所保证金
        public double ExchMargin;
        ///保证金率
        public double MarginRateByMoney;
        ///保证金率(按手数)
        public double MarginRateByVolume;
        ///昨结算价
        public double LastSettlementPrice;
        ///结算价
        public double SettlementPrice;
        ///平仓量
        public int CloseVolume;
        ///平仓金额
        public double CloseAmount;
    };

    ///资金账户口令域
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingAccountPasswordField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
    };

    ///交易所行情报盘机
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMDTraderOfferField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///交易所交易员连接状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TraderConnectStatus;
        ///发出连接请求的日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectRequestDate;
        ///发出连接请求的时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectRequestTime;
        ///上次报告日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportDate;
        ///上次报告时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string LastReportTime;
        ///完成连接日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectDate;
        ///完成连接时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ConnectTime;
        ///启动日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string StartDate;
        ///启动时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string StartTime;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///本席位最大成交编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MaxTradeID;
        ///本席位最大报单备拷
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string MaxOrderMessageReference;
    };

    ///查询行情报盘机
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryMDTraderOfferField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
    };

    ///查询客户通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryNoticeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///客户通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcNoticeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///消息正文
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=501)]
		public string Content;
        ///经纪公司通知内容序列号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=2)]
		public string SequenceLabel;
    };

    ///用户权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserRightField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///客户权限类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserRightType;
        ///是否禁止
        public int IsForbidden;
    };

    ///查询结算信息确认域
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySettlementInfoConfirmField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///装载结算信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcLoadSettlementInfoField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///经纪公司可提资金算法表
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerWithdrawAlgorithmField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///可提资金算法
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string WithdrawAlgorithm;
        ///资金使用率
        public double UsingRatio;
        ///可提是否包含平仓盈利
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IncludeCloseProfit;
        ///本日无仓且无成交客户是否受可提比例限制
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string AllWithoutTrade;
        ///可用是否包含平仓盈利
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string AvailIncludeCloseProfit;
        ///是否启用用户事件
        public int IsBrokerUserEvent;
    };

    ///资金账户口令变更域
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingAccountPasswordUpdateV1Field
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///原来的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string OldPassword;
        ///新的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewPassword;
    };

    ///资金账户口令变更域
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingAccountPasswordUpdateField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///原来的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string OldPassword;
        ///新的口令
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewPassword;
    };

    ///查询组合合约分腿
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryCombinationLegField
    {
        ///组合合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string CombInstrumentID;
        ///单腿编号
        public int LegID;
        ///单腿合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string LegInstrumentID;
    };

    ///查询组合合约分腿
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQrySyncStatusField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
    };

    ///组合交易合约的单腿
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCombinationLegField
    {
        ///组合合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string CombInstrumentID;
        ///单腿编号
        public int LegID;
        ///单腿合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string LegInstrumentID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///单腿乘数
        public int LegMultiple;
        ///派生层数
        public int ImplyLevel;
    };

    ///数据同步状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcSyncStatusField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///数据同步状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string DataSyncStatus;
    };

    ///查询联系人
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryLinkManField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///联系人
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcLinkManField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///联系人类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string PersonType;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdentifiedCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string PersonName;
        ///联系电话
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///通讯地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮政编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///优先级
        public int Priority;
    };

    ///查询经纪公司用户事件
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerUserEventField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户事件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserEventType;
    };

    ///查询经纪公司用户事件
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserEventField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///用户事件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserEventType;
        ///用户事件序号
        public int EventSequenceNo;
        ///事件发生日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string EventDate;
        ///事件发生时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string EventTime;
        ///用户事件信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1025)]
		public string UserEventInfo;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///查询签约银行请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryContractBankField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
    };

    ///查询签约银行响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcContractBankField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分中心代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBrchID;
        ///银行名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string BankName;
    };

    ///投资者组合持仓明细
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorPositionCombineDetailField
    {
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///开仓日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OpenDate;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///结算编号
        public int SettlementID;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///组合编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string ComTradeID;
        ///撮合编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TradeID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///买卖
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///持仓量
        public int TotalAmt;
        ///投资者保证金
        public double Margin;
        ///交易所保证金
        public double ExchMargin;
        ///保证金率
        public double MarginRateByMoney;
        ///保证金率(按手数)
        public double MarginRateByVolume;
        ///单腿编号
        public int LegID;
        ///单腿乘数
        public int LegMultiple;
        ///组合持仓合约编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string CombInstrumentID;
    };

    ///预埋单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcParkedOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///用户强评标志
        public int UserForceClose;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///预埋报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ParkedOrderID;
        ///用户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserType;
        ///预埋单状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Status;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///互换单标志
        public int IsSwapOrder;
    };

    ///输入预埋单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcParkedOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///报单操作引用
        public int OrderActionRef;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///请求编号
        public int RequestID;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///操作标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ActionFlag;
        ///价格
        public double LimitPrice;
        ///数量变化
        public int VolumeChange;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///预埋撤单单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ParkedOrderActionID;
        ///用户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string UserType;
        ///预埋撤单状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Status;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///查询预埋单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryParkedOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///查询预埋撤单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryParkedOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///删除预埋单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRemoveParkedOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///预埋报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ParkedOrderID;
    };

    ///删除预埋撤单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRemoveParkedOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///预埋撤单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ParkedOrderActionID;
    };

    ///经纪公司可提资金算法表
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcInvestorWithdrawAlgorithmField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///可提资金比例
        public double UsingRatio;
    };

    ///查询组合持仓明细
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryInvestorPositionCombineDetailField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///组合持仓合约编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string CombInstrumentID;
    };

    ///成交均价
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarketDataAveragePriceField
    {
        ///当日均价
        public double AveragePrice;
    };

    ///校验投资者密码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcVerifyInvestorPasswordField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
    };

    ///用户IP
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserIPField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///IP地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string IPAddress;
        ///IP地址掩码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string IPMask;
        ///Mac地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MacAddress;
    };

    ///用户事件通知信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingNoticeInfoField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///发送时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SendTime;
        ///消息正文
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=501)]
		public string FieldContent;
        ///序列系列号
        public short SequenceSeries;
        ///序列号
        public int SequenceNo;
    };

    ///用户事件通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTradingNoticeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者范围
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string InvestorRange;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///序列系列号
        public short SequenceSeries;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///发送时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SendTime;
        ///序列号
        public int SequenceNo;
        ///消息正文
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=501)]
		public string FieldContent;
    };

    ///查询交易事件通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTradingNoticeField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///查询错误报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryErrOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///错误报单
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcErrOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///用户强评标志
        public int UserForceClose;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///互换单标志
        public int IsSwapOrder;
    };

    ///查询错误报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcErrorConditionalOrderField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///报单价格条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderPriceType;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///组合开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombOffsetFlag;
        ///组合投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string CombHedgeFlag;
        ///价格
        public double LimitPrice;
        ///数量
        public int VolumeTotalOriginal;
        ///有效期类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TimeCondition;
        ///GTD日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string GTDDate;
        ///成交量类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VolumeCondition;
        ///最小成交量
        public int MinVolume;
        ///触发条件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ContingentCondition;
        ///止损价
        public double StopPrice;
        ///强平原因
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ForceCloseReason;
        ///自动挂起标志
        public int IsAutoSuspend;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///请求编号
        public int RequestID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///合约在交易所的代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string ExchangeInstID;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///报单提交状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSubmitStatus;
        ///报单提示序号
        public int NotifySequence;
        ///交易日
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///结算编号
        public int SettlementID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///报单来源
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderSource;
        ///报单状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderStatus;
        ///报单类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderType;
        ///今成交数量
        public int VolumeTraded;
        ///剩余数量
        public int VolumeTotal;
        ///报单日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertDate;
        ///委托时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string InsertTime;
        ///激活时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActiveTime;
        ///挂起时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string SuspendTime;
        ///最后修改时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string UpdateTime;
        ///撤销时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CancelTime;
        ///最后修改交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string ActiveTraderID;
        ///结算会员编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClearingPartID;
        ///序号
        public int SequenceNo;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///用户端产品信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string UserProductInfo;
        ///状态信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string StatusMsg;
        ///用户强评标志
        public int UserForceClose;
        ///操作用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string ActiveUserID;
        ///经纪公司报单编号
        public int BrokerOrderSeq;
        ///相关报单
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string RelativeOrderSysID;
        ///郑商所成交数量
        public int ZCETotalTradedVolume;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///互换单标志
        public int IsSwapOrder;
    };

    ///查询错误报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryErrOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///错误报单操作
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcErrOrderActionField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///报单操作引用
        public int OrderActionRef;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderRef;
        ///请求编号
        public int RequestID;
        ///前置编号
        public int FrontID;
        ///会话编号
        public int SessionID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string OrderSysID;
        ///操作标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string ActionFlag;
        ///价格
        public double LimitPrice;
        ///数量变化
        public int VolumeChange;
        ///操作日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionDate;
        ///操作时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ActionTime;
        ///交易所交易员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string TraderID;
        ///安装编号
        public int InstallID;
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string OrderLocalID;
        ///操作本地编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string ActionLocalID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///客户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ClientID;
        ///业务单元
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string BusinessUnit;
        ///报单操作状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OrderActionStatus;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///状态信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string StatusMsg;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///查询交易所状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryExchangeSequenceField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///交易所状态
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcExchangeSequenceField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///序号
        public int SequenceNo;
        ///合约交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MarketStatus;
    };

    ///根据价格查询最大报单数量
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQueryMaxOrderVolumeWithPriceField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OffsetFlag;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///最大允许报单数量
        public int MaxVolume;
        ///报单价格
        public double Price;
    };

    ///查询经纪公司交易参数
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerTradingParamsField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///经纪公司交易参数
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerTradingParamsField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///保证金价格类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MarginPriceType;
        ///盈亏算法
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Algorithm;
        ///可用是否包含平仓盈利
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string AvailIncludeCloseProfit;
    };

    ///查询经纪公司交易算法
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryBrokerTradingAlgosField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///经纪公司交易算法
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerTradingAlgosField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///持仓处理算法编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HandlePositionAlgoID;
        ///寻找保证金率算法编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FindMarginRateAlgoID;
        ///资金处理算法编号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HandleTradingAccountAlgoID;
    };

    ///查询经纪公司资金
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQueryBrokerDepositField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
    };

    ///经纪公司资金
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerDepositField
    {
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///会员代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///上次结算准备金
        public double PreBalance;
        ///当前保证金总额
        public double CurrMargin;
        ///平仓盈亏
        public double CloseProfit;
        ///期货结算准备金
        public double Balance;
        ///入金金额
        public double Deposit;
        ///出金金额
        public double Withdraw;
        ///可提资金
        public double Available;
        ///基本准备金
        public double Reserve;
        ///冻结的保证金
        public double FrozenMargin;
    };

    ///查询保证金监管系统经纪公司密钥
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryCFMMCBrokerKeyField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
    };

    ///保证金监管系统经纪公司密钥
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCFMMCBrokerKeyField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///经纪公司统一编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///密钥生成日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CreateDate;
        ///密钥生成时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string CreateTime;
        ///密钥编号
        public int KeyID;
        ///动态密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CurrentKey;
        ///动态密钥类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string KeyKind;
    };

    ///保证金监管系统经纪公司资金账户密钥
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCFMMCTradingAccountKeyField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///经纪公司统一编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string ParticipantID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///密钥编号
        public int KeyID;
        ///动态密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CurrentKey;
    };

    ///请求查询保证金监管系统经纪公司资金账户密钥
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryCFMMCTradingAccountKeyField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
    };

    ///用户动态令牌参数
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserOTPParamField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///动态令牌提供商
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=2)]
		public string OTPVendorsID;
        ///动态令牌序列号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string SerialNumber;
        ///令牌密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string AuthKey;
        ///漂移值
        public int LastDrift;
        ///成功值
        public int LastSuccess;
        ///动态令牌类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OTPType;
    };

    ///手工同步用户动态令牌
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcManualSyncBrokerUserOTPField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///动态令牌类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OTPType;
        ///第一个动态密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string FirstOTP;
        ///第二个动态密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string SecondOTP;
    };

    ///投资者手续费率模板
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCommRateModelField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///手续费率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string CommModelID;
        ///模板名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=161)]
		public string CommModelName;
    };

    ///请求查询投资者手续费率模板
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryCommRateModelField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///手续费率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string CommModelID;
    };

    ///投资者保证金率模板
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcMarginModelField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///保证金率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MarginModelID;
        ///模板名称
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=161)]
		public string MarginModelName;
    };

    ///请求查询投资者保证金率模板
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryMarginModelField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///保证金率模板代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string MarginModelID;
    };

    ///仓单折抵信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcEWarrantOffsetField
    {
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
        ///买卖方向
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Direction;
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string HedgeFlag;
        ///数量
        public int Volume;
    };

    ///查询仓单折抵信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryEWarrantOffsetField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string ExchangeID;
        ///合约代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string InstrumentID;
    };

    ///转帐开户请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqOpenAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///汇钞标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CashExchangeCode;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///交易ID
        public int TID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///转帐销户请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqCancelAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///汇钞标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CashExchangeCode;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///交易ID
        public int TID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
    };

    ///变更银行账户请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqChangeAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///新银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewBankAccount;
        ///新银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewBankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易ID
        public int TID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
    };

    ///转账请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqTransferField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///期货公司流水号
        public int FutureSerial;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///期货可取金额
        public double FutureFetchAmount;
        ///费用支付标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FeePayFlag;
        ///应收客户费用
        public double CustFee;
        ///应收期货公司费用
        public double BrokerFee;
        ///发送方给接收方的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///转账交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TransferStatus;
    };

    ///银行发起银行资金转期货响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspTransferField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///期货公司流水号
        public int FutureSerial;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///期货可取金额
        public double FutureFetchAmount;
        ///费用支付标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FeePayFlag;
        ///应收客户费用
        public double CustFee;
        ///应收期货公司费用
        public double BrokerFee;
        ///发送方给接收方的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///转账交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TransferStatus;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///冲正请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqRepealField
    {
        ///冲正时间间隔
        public int RepealTimeInterval;
        ///已经冲正次数
        public int RepealedTimes;
        ///银行冲正标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankRepealFlag;
        ///期商冲正标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BrokerRepealFlag;
        ///被冲正平台流水号
        public int PlateRepealSerial;
        ///被冲正银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankRepealSerial;
        ///被冲正期货流水号
        public int FutureRepealSerial;
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///期货公司流水号
        public int FutureSerial;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///期货可取金额
        public double FutureFetchAmount;
        ///费用支付标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FeePayFlag;
        ///应收客户费用
        public double CustFee;
        ///应收期货公司费用
        public double BrokerFee;
        ///发送方给接收方的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///转账交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TransferStatus;
    };

    ///冲正响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspRepealField
    {
        ///冲正时间间隔
        public int RepealTimeInterval;
        ///已经冲正次数
        public int RepealedTimes;
        ///银行冲正标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankRepealFlag;
        ///期商冲正标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BrokerRepealFlag;
        ///被冲正平台流水号
        public int PlateRepealSerial;
        ///被冲正银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankRepealSerial;
        ///被冲正期货流水号
        public int FutureRepealSerial;
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///期货公司流水号
        public int FutureSerial;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///期货可取金额
        public double FutureFetchAmount;
        ///费用支付标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FeePayFlag;
        ///应收客户费用
        public double CustFee;
        ///应收期货公司费用
        public double BrokerFee;
        ///发送方给接收方的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///转账交易状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string TransferStatus;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///查询账户信息请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqQueryAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///期货公司流水号
        public int FutureSerial;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
    };

    ///查询账户信息响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspQueryAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///期货公司流水号
        public int FutureSerial;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///银行可用金额
        public double BankUseAmount;
        ///银行可取金额
        public double BankFetchAmount;
    };

    ///期商签到签退
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcFutureSignIOField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
    };

    ///期商签到响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspFutureSignInField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///PIN密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string PinKey;
        ///MAC密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string MacKey;
    };

    ///期商签退请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqFutureSignOutField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
    };

    ///期商签退响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspFutureSignOutField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///查询指定流水号的交易结果请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqQueryTradeResultBySerialField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///流水号
        public int Reference;
        ///本流水号发布者的机构类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string RefrenceIssureType;
        ///本流水号发布者机构编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string RefrenceIssure;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
    };

    ///查询指定流水号的交易结果响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspQueryTradeResultBySerialField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///流水号
        public int Reference;
        ///本流水号发布者的机构类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string RefrenceIssureType;
        ///本流水号发布者机构编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string RefrenceIssure;
        ///原始返回代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string OriginReturnCode;
        ///原始返回码描述
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string OriginDescrInfoForReturnCode;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///转帐金额
        public double TradeAmount;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
    };

    ///日终文件就绪请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqDayEndFileReadyField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///文件业务功能
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FileBusinessCode;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
    };

    ///返回结果
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReturnResultField
    {
        ///返回代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ReturnCode;
        ///返回码描述
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string DescrInfoForReturnCode;
    };

    ///验证期货资金密码
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcVerifyFuturePasswordField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///安装编号
        public int InstallID;
        ///交易ID
        public int TID;
    };

    ///验证客户信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcVerifyCustInfoField
    {
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
    };

    ///验证期货资金密码和客户信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcVerifyFuturePasswordAndCustInfoField
    {
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
    };

    ///验证期货资金密码和客户信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcDepositResultInformField
    {
        ///出入金流水号，该流水号为银期报盘返回的流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=15)]
		public string DepositSeqNo;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///入金金额
        public double Deposit;
        ///请求编号
        public int RequestID;
        ///返回代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ReturnCode;
        ///返回码描述
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string DescrInfoForReturnCode;
    };

    ///交易核心向银期报盘发出密钥同步请求
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcReqSyncKeyField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易核心给银期报盘的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
    };

    ///交易核心向银期报盘发出密钥同步响应
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcRspSyncKeyField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易核心给银期报盘的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///查询账户信息通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcNotifyQueryAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///期货公司流水号
        public int FutureSerial;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///银行可用金额
        public double BankUseAmount;
        ///银行可取金额
        public double BankFetchAmount;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///银期转账交易流水表
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcTransferSerialField
    {
        ///平台流水号
        public int PlateSerial;
        ///交易发起方日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///交易代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///会话编号
        public int SessionID;
        ///银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///期货公司编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///期货公司帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string FutureAccType;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///投资者代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string InvestorID;
        ///期货公司流水号
        public int FutureSerial;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///交易金额
        public double TradeAmount;
        ///应收客户费用
        public double CustFee;
        ///应收期货公司费用
        public double BrokerFee;
        ///有效标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string AvailabilityFlag;
        ///操作员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperatorCode;
        ///新银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankNewAccount;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///请求查询转帐流水
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryTransferSerialField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
    };

    ///期商签到通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcNotifyFutureSignInField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
        ///PIN密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string PinKey;
        ///MAC密钥
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string MacKey;
    };

    ///期商签退通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcNotifyFutureSignOutField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///交易核心向银期报盘发出密钥同步处理结果的通知
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcNotifySyncKeyField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///安装编号
        public int InstallID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易核心给银期报盘的消息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=129)]
		public string Message;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///请求编号
        public int RequestID;
        ///交易ID
        public int TID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///请求查询银期签约关系
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcQryAccountregisterField
    {
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
    };

    ///客户开销户信息表
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcAccountregisterField
    {
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDay;
        ///银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///期货公司编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期货公司分支机构编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///开销户类别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string OpenOrDestroy;
        ///签约日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string RegDate;
        ///解约日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string OutDate;
        ///交易ID
        public int TID;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
    };

    ///银期开户信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcOpenAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///汇钞标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CashExchangeCode;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///交易ID
        public int TID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///银期销户信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcCancelAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///汇钞标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CashExchangeCode;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///渠道标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=3)]
		public string DeviceID;
        ///期货单位帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankSecuAccType;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///期货单位帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankSecuAcc;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易柜员
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=17)]
		public string OperNo;
        ///交易ID
        public int TID;
        ///用户标识
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///银期变更银行账号信息
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcChangeAccountField
    {
        ///业务功能码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string TradeCode;
        ///银行代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string BankID;
        ///银行分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=5)]
		public string BankBranchID;
        ///期商代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///期商分支机构代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=31)]
		public string BrokerBranchID;
        ///交易日期
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeDate;
        ///交易时间
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradeTime;
        ///银行流水号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string BankSerial;
        ///交易系统日期 
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=9)]
		public string TradingDay;
        ///银期平台消息流水号
        public int PlateSerial;
        ///最后分片标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string LastFragment;
        ///会话号
        public int SessionID;
        ///客户姓名
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string CustomerName;
        ///证件类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string IdCardType;
        ///证件号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=51)]
		public string IdentifiedCardNo;
        ///性别
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string Gender;
        ///国家代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string CountryCode;
        ///客户类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string CustType;
        ///地址
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=101)]
		public string Address;
        ///邮编
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=7)]
		public string ZipCode;
        ///电话号码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Telephone;
        ///手机
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=21)]
		public string MobilePhone;
        ///传真
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Fax;
        ///电子邮件
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string EMail;
        ///资金账户状态
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string MoneyAccountStatus;
        ///银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankAccount;
        ///银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string BankPassWord;
        ///新银行帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewBankAccount;
        ///新银行密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string NewBankPassWord;
        ///投资者帐号
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=13)]
		public string AccountID;
        ///期货密码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=41)]
		public string Password;
        ///银行帐号类型
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankAccType;
        ///安装编号
        public int InstallID;
        ///验证客户证件号码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string VerifyCertNoFlag;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=4)]
		public string CurrencyID;
        ///期货公司银行编码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=33)]
		public string BrokerIDByBank;
        ///银行密码标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string BankPwdFlag;
        ///期货资金密码核对标志
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=1)]
		public string SecuPwdFlag;
        ///交易ID
        public int TID;
        ///摘要
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=36)]
		public string Digest;
        ///错误代码
        public int ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=81)]
		public string ErrorMsg;
    };

    ///灾备中心交易权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcUserRightsAssignField
    {
        ///应用单元代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=16)]
		public string UserID;
        ///交易中心代码
        public int DRIdentityID;
    };

    ///经济公司是否有在本标示的交易权限
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcBrokerUserRightAssignField
    {
        ///应用单元代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string BrokerID;
        ///交易中心代码
        public int DRIdentityID;
        ///能否交易
        public int Tradeable;
    };

    ///灾备交易转换报文
    [StructLayout(LayoutKind.Sequential)]
	public struct CThostFtdcDRTransferField
    {
        ///原交易中心代码
        public int OrigDRIdentityID;
        ///目标交易中心代码
        public int DestDRIdentityID;
        ///原应用单元代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string OrigBrokerID;
        ///目标易用单元代码
        [MarshalAs(UnmanagedType.ByValTStr,SizeConst=11)]
		public string DestBrokerID;
    };
}
