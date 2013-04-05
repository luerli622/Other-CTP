#pragma once

#include "FuncDef.h"

struct STraderSpi
{
	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	FPOnFrontConnected m_pfOnFrontConnected;

	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	FPOnFrontDisconnected m_pfOnFrontDisconnected;

	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	FPOnHeartBeatWarning m_pfOnHeartBeatWarning;

	///客户端认证响应
	FPOnRspAuthenticate m_pfOnRspAuthenticate;


	///登录请求响应
	FPOnRspUserLogin m_pfOnRspUserLogin;

	///登出请求响应
	FPOnRspUserLogout m_pfOnRspUserLogout;

	///用户口令更新请求响应
	FPOnRspUserPasswordUpdate m_pfOnRspUserPasswordUpdate;

	///资金账户口令更新请求响应
	FPOnRspTradingAccountPasswordUpdate m_pfOnRspTradingAccountPasswordUpdate;

	///报单录入请求响应
	FPOnRspOrderInsert m_pfOnRspOrderInsert;

	///预埋单录入请求响应
	FPOnRspParkedOrderInsert m_pfOnRspParkedOrderInsert;

	///预埋撤单录入请求响应
	FPOnRspParkedOrderAction m_pfOnRspParkedOrderAction;

	///报单操作请求响应
	FPOnRspOrderAction m_pfOnRspOrderAction;

	///查询最大报单数量响应
	FPOnRspQueryMaxOrderVolume m_pfOnRspQueryMaxOrderVolume;

	///投资者结算结果确认响应
	FPOnRspSettlementInfoConfirm m_pfOnRspSettlementInfoConfirm;

	///删除预埋单响应
	FPOnRspRemoveParkedOrder m_pfOnRspRemoveParkedOrder;

	///删除预埋撤单响应
	FPOnRspRemoveParkedOrderAction m_pfOnRspRemoveParkedOrderAction;

	///请求查询报单响应
	FPOnRspQryOrder m_pfOnRspQryOrder;

	///请求查询成交响应
	FPOnRspQryTrade m_pfOnRspQryTrade;

	///请求查询投资者持仓响应
	FPOnRspQryInvestorPosition m_pfOnRspQryInvestorPosition;

	///请求查询资金账户响应
	FPOnRspQryTradingAccount m_pfOnRspQryTradingAccount;

	///请求查询投资者响应
	FPOnRspQryInvestor m_pfOnRspQryInvestor;

	///请求查询交易编码响应
	FPOnRspQryTradingCode m_pfOnRspQryTradingCode;

	///请求查询合约保证金率响应
	FPOnRspQryInstrumentMarginRate m_pfOnRspQryInstrumentMarginRate;

	///请求查询合约手续费率响应
	FPOnRspQryInstrumentCommissionRate m_pfOnRspQryInstrumentCommissionRate;

	///请求查询交易所响应
	FPOnRspQryExchange m_pfOnRspQryExchange;

	///请求查询合约响应
	FPOnRspQryInstrument m_pfOnRspQryInstrument;

	///请求查询行情响应
	FPOnRspQryDepthMarketData m_pfOnRspQryDepthMarketData;

	///请求查询投资者结算结果响应
	FPOnRspQrySettlementInfo m_pfOnRspQrySettlementInfo;

	///请求查询转帐银行响应
	FPOnRspQryTransferBank m_pfOnRspQryTransferBank;

	///请求查询投资者持仓明细响应
	FPOnRspQryInvestorPositionDetail m_pfOnRspQryInvestorPositionDetail;

	///请求查询客户通知响应
	FPOnRspQryNotice m_pfOnRspQryNotice;

	///请求查询结算信息确认响应
	FPOnRspQrySettlementInfoConfirm m_pfOnRspQrySettlementInfoConfirm;

	///请求查询投资者持仓明细响应
	FPOnRspQryInvestorPositionCombineDetail m_pfOnRspQryInvestorPositionCombineDetail;

	///查询保证金监管系统经纪公司资金账户密钥响应
	FPOnRspQryCFMMCTradingAccountKey m_pfOnRspQryCFMMCTradingAccountKey;

	///请求查询仓单折抵信息响应
	FPOnRspQryEWarrantOffset m_pfOnRspQryEWarrantOffset;

	///请求查询转帐流水响应
	FPOnRspQryTransferSerial m_pfOnRspQryTransferSerial;

	///请求查询银期签约关系响应
	FPOnRspQryAccountregister m_pfOnRspQryAccountregister;

	///错误应答
	FPOnRspError m_pfOnRspError;

	///报单通知
	FPOnRtnOrder m_pfOnRtnOrder;

	///成交通知
	FPOnRtnTrade m_pfOnRtnTrade;

	///报单录入错误回报
	FPOnErrRtnOrderInsert m_pfOnErrRtnOrderInsert;

	///报单操作错误回报
	FPOnErrRtnOrderAction m_pfOnErrRtnOrderAction;

	///合约交易状态通知
	FPOnRtnInstrumentStatus m_pfOnRtnInstrumentStatus;

	///交易通知
	FPOnRtnTradingNotice m_pfOnRtnTradingNotice;

	///提示条件单校验错误
	FPOnRtnErrorConditionalOrder m_pfOnRtnErrorConditionalOrder;

	///请求查询签约银行响应
	FPOnRspQryContractBank m_pfOnRspQryContractBank;

	///请求查询预埋单响应
	FPOnRspQryParkedOrder m_pfOnRspQryParkedOrder;

	///请求查询预埋撤单响应
	FPOnRspQryParkedOrderAction m_pfOnRspQryParkedOrderAction;

	///请求查询交易通知响应
	FPOnRspQryTradingNotice m_pfOnRspQryTradingNotice;

	///请求查询经纪公司交易参数响应
	FPOnRspQryBrokerTradingParams m_pfOnRspQryBrokerTradingParams;

	///请求查询经纪公司交易算法响应
	FPOnRspQryBrokerTradingAlgos m_pfOnRspQryBrokerTradingAlgos;

	///银行发起银行资金转期货通知
	FPOnRtnFromBankToFutureByBank m_pfOnRtnFromBankToFutureByBank;

	///银行发起期货资金转银行通知
	FPOnRtnFromFutureToBankByBank m_pfOnRtnFromFutureToBankByBank;

	///银行发起冲正银行转期货通知
	FPOnRtnRepealFromBankToFutureByBank m_pfOnRtnRepealFromBankToFutureByBank;

	///银行发起冲正期货转银行通知
	FPOnRtnRepealFromFutureToBankByBank m_pfOnRtnRepealFromFutureToBankByBank;

	///期货发起银行资金转期货通知
	FPOnRtnFromBankToFutureByFuture m_pfOnRtnFromBankToFutureByFuture;

	///期货发起期货资金转银行通知
	FPOnRtnFromFutureToBankByFuture m_pfOnRtnFromFutureToBankByFuture;

	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	FPOnRtnRepealFromBankToFutureByFutureManual m_pfOnRtnRepealFromBankToFutureByFutureManual;

	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	FPOnRtnRepealFromFutureToBankByFutureManual m_pfOnRtnRepealFromFutureToBankByFutureManual;

	///期货发起查询银行余额通知
	FPOnRtnQueryBankBalanceByFuture m_pfOnRtnQueryBankBalanceByFuture;

	///期货发起银行资金转期货错误回报
	FPOnErrRtnBankToFutureByFuture m_pfOnErrRtnBankToFutureByFuture;

	///期货发起期货资金转银行错误回报
	FPOnErrRtnFutureToBankByFuture m_pfOnErrRtnFutureToBankByFuture;

	///系统运行时期货端手工发起冲正银行转期货错误回报
	FPOnErrRtnRepealBankToFutureByFutureManual m_pfOnErrRtnRepealBankToFutureByFutureManual;

	///系统运行时期货端手工发起冲正期货转银行错误回报
	FPOnErrRtnRepealFutureToBankByFutureManual m_pfOnErrRtnRepealFutureToBankByFutureManual;

	///期货发起查询银行余额错误回报
	FPOnErrRtnQueryBankBalanceByFuture m_pfOnErrRtnQueryBankBalanceByFuture;

	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	FPOnRtnRepealFromBankToFutureByFuture m_pfOnRtnRepealFromBankToFutureByFuture;

	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	FPOnRtnRepealFromFutureToBankByFuture m_pfOnRtnRepealFromFutureToBankByFuture;

	///期货发起银行资金转期货应答
	FPOnRspFromBankToFutureByFuture m_pfOnRspFromBankToFutureByFuture;

	///期货发起期货资金转银行应答
	FPOnRspFromFutureToBankByFuture m_pfOnRspFromFutureToBankByFuture;

	///期货发起查询银行余额应答
	FPOnRspQueryBankAccountMoneyByFuture m_pfOnRspQueryBankAccountMoneyByFuture;

	///银行发起银期开户通知
	FPOnRtnOpenAccountByBank m_pfOnRtnOpenAccountByBank;

	///银行发起银期销户通知
	FPOnRtnCancelAccountByBank m_pfOnRtnCancelAccountByBank;

	///银行发起变更银行账号通知
	FPOnRtnChangeAccountByBank m_pfOnRtnChangeAccountByBank;
};


extern "C"
{	
	///创建TraderApi
	///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
	///@return 创建出的UserApi
	//modify for udp marketdata
	__declspec(dllexport) CThostFtdcTraderApi * __stdcall CreateFtdcTraderApi(const char *pszFlowPath, const bool bIsUsingUdp);

	///删除接口对象本身
	///@remark 不再使用本接口对象时,调用该函数删除接口对象
	__declspec(dllexport) void __stdcall Release(CThostFtdcTraderApi* pTraderApi) ;

	///初始化
	///@remark 初始化运行环境,只有调用后,接口才开始工作
	__declspec(dllexport) void __stdcall Init(CThostFtdcTraderApi* pTraderApi) ;

	///等待接口线程结束运行
	///@return 线程退出代码
	__declspec(dllexport) int __stdcall Join(CThostFtdcTraderApi* pTraderApi) ;

	///获取当前交易日
	///@retrun 获取到的交易日
	///@remark 只有登录成功后,才能得到正确的交易日
	__declspec(dllexport) const char * __stdcall GetTradingDay(CThostFtdcTraderApi* pTraderApi) ;

	///注册前置机网络地址
	///@param pszFrontAddress：前置机网络地址。
	///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。 
	///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
	__declspec(dllexport) void __stdcall RegisterFront(CThostFtdcTraderApi* pTraderApi, char *pszFrontAddress) ;

	///注册名字服务器网络地址
	///@param pszNsAddress：名字服务器网络地址。
	///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。 
	///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
	///@remark RegisterNameServer优先于RegisterFront
	__declspec(dllexport) void __stdcall RegisterNameServer(CThostFtdcTraderApi* pTraderApi, char *pszNsAddress) ;

	///注册回调接口
	///@param pSpi 派生自回调接口类的实例
	__declspec(dllexport) void __stdcall RegisterSpi(CThostFtdcTraderApi* pTraderApi, STraderSpi *pSpi) ;

	///订阅私有流。
	///@param nResumeType 私有流重传方式  
	///        THOST_TERT_RESTART:从本交易日开始重传
	///        THOST_TERT_RESUME:从上次收到的续传
	///        THOST_TERT_QUICK:只传送登录后私有流的内容
	///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
	__declspec(dllexport) void __stdcall SubscribePrivateTopic(CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType) ;

	///订阅公共流。
	///@param nResumeType 公共流重传方式  
	///        THOST_TERT_RESTART:从本交易日开始重传
	///        THOST_TERT_RESUME:从上次收到的续传
	///        THOST_TERT_QUICK:只传送登录后公共流的内容
	///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
	__declspec(dllexport) void __stdcall SubscribePublicTopic(CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType) ;

	///客户端认证请求
	__declspec(dllexport) int __stdcall ReqAuthenticate(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqAuthenticateField *pReqAuthenticateField, int nRequestID) ;

	///用户登录请求
	__declspec(dllexport) int __stdcall ReqUserLogin(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID) ;


	///登出请求
	__declspec(dllexport) int __stdcall ReqUserLogout(CThostFtdcTraderApi* pTraderApi, CThostFtdcUserLogoutField *pUserLogout, int nRequestID) ;

	///用户口令更新请求
	__declspec(dllexport) int __stdcall ReqUserPasswordUpdate(CThostFtdcTraderApi* pTraderApi, CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, int nRequestID) ;

	///资金账户口令更新请求
	__declspec(dllexport) int __stdcall ReqTradingAccountPasswordUpdate(CThostFtdcTraderApi* pTraderApi, CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, int nRequestID) ;

	///报单录入请求
	__declspec(dllexport) int __stdcall ReqOrderInsert(CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderField *pInputOrder, int nRequestID) ;

	///预埋单录入请求
	__declspec(dllexport) int __stdcall ReqParkedOrderInsert(CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderField *pParkedOrder, int nRequestID) ;

	///预埋撤单录入请求
	__declspec(dllexport) int __stdcall ReqParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderActionField *pParkedOrderAction, int nRequestID) ;

	///报单操作请求
	__declspec(dllexport) int __stdcall ReqOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderActionField *pInputOrderAction, int nRequestID) ;

	///查询最大报单数量请求
	__declspec(dllexport) int __stdcall ReqQueryMaxOrderVolume(CThostFtdcTraderApi* pTraderApi, CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, int nRequestID) ;

	///投资者结算结果确认
	__declspec(dllexport) int __stdcall ReqSettlementInfoConfirm(CThostFtdcTraderApi* pTraderApi, CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, int nRequestID) ;

	///请求删除预埋单
	__declspec(dllexport) int __stdcall ReqRemoveParkedOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, int nRequestID) ;

	///请求删除预埋撤单
	__declspec(dllexport) int __stdcall ReqRemoveParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, int nRequestID) ;

	///请求查询报单
	__declspec(dllexport) int __stdcall ReqQryOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryOrderField *pQryOrder, int nRequestID) ;

	///请求查询成交
	__declspec(dllexport) int __stdcall ReqQryTrade(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradeField *pQryTrade, int nRequestID) ;

	///请求查询投资者持仓
	__declspec(dllexport) int __stdcall ReqQryInvestorPosition(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionField *pQryInvestorPosition, int nRequestID) ;

	///请求查询资金账户
	__declspec(dllexport) int __stdcall ReqQryTradingAccount(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingAccountField *pQryTradingAccount, int nRequestID) ;

	///请求查询投资者
	__declspec(dllexport) int __stdcall ReqQryInvestor(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorField *pQryInvestor, int nRequestID) ;

	///请求查询交易编码
	__declspec(dllexport) int __stdcall ReqQryTradingCode(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingCodeField *pQryTradingCode, int nRequestID) ;

	///请求查询合约保证金率
	__declspec(dllexport) int __stdcall ReqQryInstrumentMarginRate(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentMarginRateField *pQryInstrumentMarginRate, int nRequestID) ;

	///请求查询合约手续费率
	__declspec(dllexport) int __stdcall ReqQryInstrumentCommissionRate(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentCommissionRateField *pQryInstrumentCommissionRate, int nRequestID) ;

	///请求查询交易所
	__declspec(dllexport) int __stdcall ReqQryExchange(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryExchangeField *pQryExchange, int nRequestID) ;

	///请求查询合约
	__declspec(dllexport) int __stdcall ReqQryInstrument(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentField *pQryInstrument, int nRequestID) ;

	///请求查询行情
	__declspec(dllexport) int __stdcall ReqQryDepthMarketData(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryDepthMarketDataField *pQryDepthMarketData, int nRequestID) ;

	///请求查询投资者结算结果
	__declspec(dllexport) int __stdcall ReqQrySettlementInfo(CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoField *pQrySettlementInfo, int nRequestID) ;

	///请求查询转帐银行
	__declspec(dllexport) int __stdcall ReqQryTransferBank(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferBankField *pQryTransferBank, int nRequestID) ;

	///请求查询投资者持仓明细
	__declspec(dllexport) int __stdcall ReqQryInvestorPositionDetail(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionDetailField *pQryInvestorPositionDetail, int nRequestID) ;

	///请求查询客户通知
	__declspec(dllexport) int __stdcall ReqQryNotice(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryNoticeField *pQryNotice, int nRequestID) ;

	///请求查询结算信息确认
	__declspec(dllexport) int __stdcall ReqQrySettlementInfoConfirm(CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoConfirmField *pQrySettlementInfoConfirm, int nRequestID) ;

	///请求查询投资者持仓明细
	__declspec(dllexport) int __stdcall ReqQryInvestorPositionCombineDetail(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionCombineDetailField *pQryInvestorPositionCombineDetail, int nRequestID) ;

	///请求查询保证金监管系统经纪公司资金账户密钥
	__declspec(dllexport) int __stdcall ReqQryCFMMCTradingAccountKey(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryCFMMCTradingAccountKeyField *pQryCFMMCTradingAccountKey, int nRequestID) ;

	///请求查询仓单折抵信息
	__declspec(dllexport) int __stdcall ReqQryEWarrantOffset(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryEWarrantOffsetField *pQryEWarrantOffset, int nRequestID) ;

	///请求查询转帐流水
	__declspec(dllexport) int __stdcall ReqQryTransferSerial(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferSerialField *pQryTransferSerial, int nRequestID) ;

	///请求查询银期签约关系
	__declspec(dllexport) int __stdcall ReqQryAccountregister(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryAccountregisterField *pQryAccountregister, int nRequestID) ;

	///请求查询签约银行
	__declspec(dllexport) int __stdcall ReqQryContractBank(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryContractBankField *pQryContractBank, int nRequestID) ;

	///请求查询预埋单
	__declspec(dllexport) int __stdcall ReqQryParkedOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderField *pQryParkedOrder, int nRequestID) ;

	///请求查询预埋撤单
	__declspec(dllexport) int __stdcall ReqQryParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderActionField *pQryParkedOrderAction, int nRequestID) ;

	///请求查询交易通知
	__declspec(dllexport) int __stdcall ReqQryTradingNotice(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingNoticeField *pQryTradingNotice, int nRequestID) ;

	///请求查询经纪公司交易参数
	__declspec(dllexport) int __stdcall ReqQryBrokerTradingParams(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingParamsField *pQryBrokerTradingParams, int nRequestID) ;

	///请求查询经纪公司交易算法
	__declspec(dllexport) int __stdcall ReqQryBrokerTradingAlgos(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingAlgosField *pQryBrokerTradingAlgos, int nRequestID) ;

	///期货发起银行资金转期货请求
	__declspec(dllexport) int __stdcall ReqFromBankToFutureByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID) ;

	///期货发起期货资金转银行请求
	__declspec(dllexport) int __stdcall ReqFromFutureToBankByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID) ;

	///期货发起查询银行余额请求
	__declspec(dllexport) int __stdcall ReqQueryBankAccountMoneyByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqQueryAccountField *pReqQueryAccount, int nRequestID) ;
};