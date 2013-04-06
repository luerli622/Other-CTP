#pragma once

#include "FuncDef.h"

struct STraderSpi
{
	///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
	FPOnFrontConnected m_pfOnFrontConnected;

	///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
	///@param nReason ����ԭ��
	///        0x1001 �����ʧ��
	///        0x1002 ����дʧ��
	///        0x2001 ����������ʱ
	///        0x2002 ��������ʧ��
	///        0x2003 �յ�������
	FPOnFrontDisconnected m_pfOnFrontDisconnected;

	///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
	///@param nTimeLapse �����ϴν��ձ��ĵ�ʱ��
	FPOnHeartBeatWarning m_pfOnHeartBeatWarning;

	///�ͻ�����֤��Ӧ
	FPOnRspAuthenticate m_pfOnRspAuthenticate;


	///��¼������Ӧ
	FPOnRspUserLogin m_pfOnRspUserLogin;

	///�ǳ�������Ӧ
	FPOnRspUserLogout m_pfOnRspUserLogout;

	///�û��������������Ӧ
	FPOnRspUserPasswordUpdate m_pfOnRspUserPasswordUpdate;

	///�ʽ��˻��������������Ӧ
	FPOnRspTradingAccountPasswordUpdate m_pfOnRspTradingAccountPasswordUpdate;

	///����¼��������Ӧ
	FPOnRspOrderInsert m_pfOnRspOrderInsert;

	///Ԥ��¼��������Ӧ
	FPOnRspParkedOrderInsert m_pfOnRspParkedOrderInsert;

	///Ԥ�񳷵�¼��������Ӧ
	FPOnRspParkedOrderAction m_pfOnRspParkedOrderAction;

	///��������������Ӧ
	FPOnRspOrderAction m_pfOnRspOrderAction;

	///��ѯ��󱨵�������Ӧ
	FPOnRspQueryMaxOrderVolume m_pfOnRspQueryMaxOrderVolume;

	///Ͷ���߽�����ȷ����Ӧ
	FPOnRspSettlementInfoConfirm m_pfOnRspSettlementInfoConfirm;

	///ɾ��Ԥ����Ӧ
	FPOnRspRemoveParkedOrder m_pfOnRspRemoveParkedOrder;

	///ɾ��Ԥ�񳷵���Ӧ
	FPOnRspRemoveParkedOrderAction m_pfOnRspRemoveParkedOrderAction;

	///�����ѯ������Ӧ
	FPOnRspQryOrder m_pfOnRspQryOrder;

	///�����ѯ�ɽ���Ӧ
	FPOnRspQryTrade m_pfOnRspQryTrade;

	///�����ѯͶ���ֲ߳���Ӧ
	FPOnRspQryInvestorPosition m_pfOnRspQryInvestorPosition;

	///�����ѯ�ʽ��˻���Ӧ
	FPOnRspQryTradingAccount m_pfOnRspQryTradingAccount;

	///�����ѯͶ������Ӧ
	FPOnRspQryInvestor m_pfOnRspQryInvestor;

	///�����ѯ���ױ�����Ӧ
	FPOnRspQryTradingCode m_pfOnRspQryTradingCode;

	///�����ѯ��Լ��֤������Ӧ
	FPOnRspQryInstrumentMarginRate m_pfOnRspQryInstrumentMarginRate;

	///�����ѯ��Լ����������Ӧ
	FPOnRspQryInstrumentCommissionRate m_pfOnRspQryInstrumentCommissionRate;

	///�����ѯ��������Ӧ
	FPOnRspQryExchange m_pfOnRspQryExchange;

	///�����ѯ��Լ��Ӧ
	FPOnRspQryInstrument m_pfOnRspQryInstrument;

	///�����ѯ������Ӧ
	FPOnRspQryDepthMarketData m_pfOnRspQryDepthMarketData;

	///�����ѯͶ���߽�������Ӧ
	FPOnRspQrySettlementInfo m_pfOnRspQrySettlementInfo;

	///�����ѯת��������Ӧ
	FPOnRspQryTransferBank m_pfOnRspQryTransferBank;

	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	FPOnRspQryInvestorPositionDetail m_pfOnRspQryInvestorPositionDetail;

	///�����ѯ�ͻ�֪ͨ��Ӧ
	FPOnRspQryNotice m_pfOnRspQryNotice;

	///�����ѯ������Ϣȷ����Ӧ
	FPOnRspQrySettlementInfoConfirm m_pfOnRspQrySettlementInfoConfirm;

	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	FPOnRspQryInvestorPositionCombineDetail m_pfOnRspQryInvestorPositionCombineDetail;

	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
	FPOnRspQryCFMMCTradingAccountKey m_pfOnRspQryCFMMCTradingAccountKey;

	///�����ѯ�ֵ��۵���Ϣ��Ӧ
	FPOnRspQryEWarrantOffset m_pfOnRspQryEWarrantOffset;

	///�����ѯת����ˮ��Ӧ
	FPOnRspQryTransferSerial m_pfOnRspQryTransferSerial;

	///�����ѯ����ǩԼ��ϵ��Ӧ
	FPOnRspQryAccountregister m_pfOnRspQryAccountregister;

	///����Ӧ��
	FPOnRspError m_pfOnRspError;

	///����֪ͨ
	FPOnRtnOrder m_pfOnRtnOrder;

	///�ɽ�֪ͨ
	FPOnRtnTrade m_pfOnRtnTrade;

	///����¼�����ر�
	FPOnErrRtnOrderInsert m_pfOnErrRtnOrderInsert;

	///������������ر�
	FPOnErrRtnOrderAction m_pfOnErrRtnOrderAction;

	///��Լ����״̬֪ͨ
	FPOnRtnInstrumentStatus m_pfOnRtnInstrumentStatus;

	///����֪ͨ
	FPOnRtnTradingNotice m_pfOnRtnTradingNotice;

	///��ʾ������У�����
	FPOnRtnErrorConditionalOrder m_pfOnRtnErrorConditionalOrder;

	///�����ѯǩԼ������Ӧ
	FPOnRspQryContractBank m_pfOnRspQryContractBank;

	///�����ѯԤ����Ӧ
	FPOnRspQryParkedOrder m_pfOnRspQryParkedOrder;

	///�����ѯԤ�񳷵���Ӧ
	FPOnRspQryParkedOrderAction m_pfOnRspQryParkedOrderAction;

	///�����ѯ����֪ͨ��Ӧ
	FPOnRspQryTradingNotice m_pfOnRspQryTradingNotice;

	///�����ѯ���͹�˾���ײ�����Ӧ
	FPOnRspQryBrokerTradingParams m_pfOnRspQryBrokerTradingParams;

	///�����ѯ���͹�˾�����㷨��Ӧ
	FPOnRspQryBrokerTradingAlgos m_pfOnRspQryBrokerTradingAlgos;

	///���з��������ʽ�ת�ڻ�֪ͨ
	FPOnRtnFromBankToFutureByBank m_pfOnRtnFromBankToFutureByBank;

	///���з����ڻ��ʽ�ת����֪ͨ
	FPOnRtnFromFutureToBankByBank m_pfOnRtnFromFutureToBankByBank;

	///���з����������ת�ڻ�֪ͨ
	FPOnRtnRepealFromBankToFutureByBank m_pfOnRtnRepealFromBankToFutureByBank;

	///���з�������ڻ�ת����֪ͨ
	FPOnRtnRepealFromFutureToBankByBank m_pfOnRtnRepealFromFutureToBankByBank;

	///�ڻ����������ʽ�ת�ڻ�֪ͨ
	FPOnRtnFromBankToFutureByFuture m_pfOnRtnFromBankToFutureByFuture;

	///�ڻ������ڻ��ʽ�ת����֪ͨ
	FPOnRtnFromFutureToBankByFuture m_pfOnRtnFromFutureToBankByFuture;

	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	FPOnRtnRepealFromBankToFutureByFutureManual m_pfOnRtnRepealFromBankToFutureByFutureManual;

	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	FPOnRtnRepealFromFutureToBankByFutureManual m_pfOnRtnRepealFromFutureToBankByFutureManual;

	///�ڻ������ѯ�������֪ͨ
	FPOnRtnQueryBankBalanceByFuture m_pfOnRtnQueryBankBalanceByFuture;

	///�ڻ����������ʽ�ת�ڻ�����ر�
	FPOnErrRtnBankToFutureByFuture m_pfOnErrRtnBankToFutureByFuture;

	///�ڻ������ڻ��ʽ�ת���д���ر�
	FPOnErrRtnFutureToBankByFuture m_pfOnErrRtnFutureToBankByFuture;

	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
	FPOnErrRtnRepealBankToFutureByFutureManual m_pfOnErrRtnRepealBankToFutureByFutureManual;

	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
	FPOnErrRtnRepealFutureToBankByFutureManual m_pfOnErrRtnRepealFutureToBankByFutureManual;

	///�ڻ������ѯ����������ر�
	FPOnErrRtnQueryBankBalanceByFuture m_pfOnErrRtnQueryBankBalanceByFuture;

	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	FPOnRtnRepealFromBankToFutureByFuture m_pfOnRtnRepealFromBankToFutureByFuture;

	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	FPOnRtnRepealFromFutureToBankByFuture m_pfOnRtnRepealFromFutureToBankByFuture;

	///�ڻ����������ʽ�ת�ڻ�Ӧ��
	FPOnRspFromBankToFutureByFuture m_pfOnRspFromBankToFutureByFuture;

	///�ڻ������ڻ��ʽ�ת����Ӧ��
	FPOnRspFromFutureToBankByFuture m_pfOnRspFromFutureToBankByFuture;

	///�ڻ������ѯ�������Ӧ��
	FPOnRspQueryBankAccountMoneyByFuture m_pfOnRspQueryBankAccountMoneyByFuture;

	///���з������ڿ���֪ͨ
	FPOnRtnOpenAccountByBank m_pfOnRtnOpenAccountByBank;

	///���з�����������֪ͨ
	FPOnRtnCancelAccountByBank m_pfOnRtnCancelAccountByBank;

	///���з����������˺�֪ͨ
	FPOnRtnChangeAccountByBank m_pfOnRtnChangeAccountByBank;
};


extern "C"
{	
	///����TraderApi
	///@param pszFlowPath ����������Ϣ�ļ���Ŀ¼��Ĭ��Ϊ��ǰĿ¼
	///@return ��������UserApi
	//modify for udp marketdata
	__declspec(dllexport) CThostFtdcTraderApi * __stdcall CreateFtdcTraderApi(const char *pszFlowPath, const bool bIsUsingUdp);

	///ɾ���ӿڶ�����
	///@remark ����ʹ�ñ��ӿڶ���ʱ,���øú���ɾ���ӿڶ���
	__declspec(dllexport) void __stdcall Release(CThostFtdcTraderApi* pTraderApi) ;

	///��ʼ��
	///@remark ��ʼ�����л���,ֻ�е��ú�,�ӿڲſ�ʼ����
	__declspec(dllexport) void __stdcall Init(CThostFtdcTraderApi* pTraderApi) ;

	///�ȴ��ӿ��߳̽�������
	///@return �߳��˳�����
	__declspec(dllexport) int __stdcall Join(CThostFtdcTraderApi* pTraderApi) ;

	///��ȡ��ǰ������
	///@retrun ��ȡ���Ľ�����
	///@remark ֻ�е�¼�ɹ���,���ܵõ���ȷ�Ľ�����
	__declspec(dllexport) const char * __stdcall GetTradingDay(CThostFtdcTraderApi* pTraderApi) ;

	///ע��ǰ�û������ַ
	///@param pszFrontAddress��ǰ�û������ַ��
	///@remark �����ַ�ĸ�ʽΪ����protocol://ipaddress:port�����磺��tcp://127.0.0.1:17001���� 
	///@remark ��tcp��������Э�飬��127.0.0.1�������������ַ����17001������������˿ںš�
	__declspec(dllexport) void __stdcall RegisterFront(CThostFtdcTraderApi* pTraderApi, char *pszFrontAddress) ;

	///ע�����ַ����������ַ
	///@param pszNsAddress�����ַ����������ַ��
	///@remark �����ַ�ĸ�ʽΪ����protocol://ipaddress:port�����磺��tcp://127.0.0.1:12001���� 
	///@remark ��tcp��������Э�飬��127.0.0.1�������������ַ����12001������������˿ںš�
	///@remark RegisterNameServer������RegisterFront
	__declspec(dllexport) void __stdcall RegisterNameServer(CThostFtdcTraderApi* pTraderApi, char *pszNsAddress) ;

	///ע��ص��ӿ�
	///@param pSpi �����Իص��ӿ����ʵ��
	__declspec(dllexport) void __stdcall RegisterSpi(CThostFtdcTraderApi* pTraderApi, STraderSpi *pSpi) ;

	///����˽������
	///@param nResumeType ˽�����ش���ʽ  
	///        THOST_TERT_RESTART:�ӱ������տ�ʼ�ش�
	///        THOST_TERT_RESUME:���ϴ��յ�������
	///        THOST_TERT_QUICK:ֻ���͵�¼��˽����������
	///@remark �÷���Ҫ��Init����ǰ���á����������򲻻��յ�˽���������ݡ�
	__declspec(dllexport) void __stdcall SubscribePrivateTopic(CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType) ;

	///���Ĺ�������
	///@param nResumeType �������ش���ʽ  
	///        THOST_TERT_RESTART:�ӱ������տ�ʼ�ش�
	///        THOST_TERT_RESUME:���ϴ��յ�������
	///        THOST_TERT_QUICK:ֻ���͵�¼�󹫹���������
	///@remark �÷���Ҫ��Init����ǰ���á����������򲻻��յ������������ݡ�
	__declspec(dllexport) void __stdcall SubscribePublicTopic(CThostFtdcTraderApi* pTraderApi, THOST_TE_RESUME_TYPE nResumeType) ;

	///�ͻ�����֤����
	__declspec(dllexport) int __stdcall ReqAuthenticate(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqAuthenticateField *pReqAuthenticateField, int nRequestID) ;

	///�û���¼����
	__declspec(dllexport) int __stdcall ReqUserLogin(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID) ;


	///�ǳ�����
	__declspec(dllexport) int __stdcall ReqUserLogout(CThostFtdcTraderApi* pTraderApi, CThostFtdcUserLogoutField *pUserLogout, int nRequestID) ;

	///�û������������
	__declspec(dllexport) int __stdcall ReqUserPasswordUpdate(CThostFtdcTraderApi* pTraderApi, CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, int nRequestID) ;

	///�ʽ��˻������������
	__declspec(dllexport) int __stdcall ReqTradingAccountPasswordUpdate(CThostFtdcTraderApi* pTraderApi, CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, int nRequestID) ;

	///����¼������
	__declspec(dllexport) int __stdcall ReqOrderInsert(CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderField *pInputOrder, int nRequestID) ;

	///Ԥ��¼������
	__declspec(dllexport) int __stdcall ReqParkedOrderInsert(CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderField *pParkedOrder, int nRequestID) ;

	///Ԥ�񳷵�¼������
	__declspec(dllexport) int __stdcall ReqParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcParkedOrderActionField *pParkedOrderAction, int nRequestID) ;

	///������������
	__declspec(dllexport) int __stdcall ReqOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcInputOrderActionField *pInputOrderAction, int nRequestID) ;

	///��ѯ��󱨵���������
	__declspec(dllexport) int __stdcall ReqQueryMaxOrderVolume(CThostFtdcTraderApi* pTraderApi, CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, int nRequestID) ;

	///Ͷ���߽�����ȷ��
	__declspec(dllexport) int __stdcall ReqSettlementInfoConfirm(CThostFtdcTraderApi* pTraderApi, CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, int nRequestID) ;

	///����ɾ��Ԥ��
	__declspec(dllexport) int __stdcall ReqRemoveParkedOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, int nRequestID) ;

	///����ɾ��Ԥ�񳷵�
	__declspec(dllexport) int __stdcall ReqRemoveParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, int nRequestID) ;

	///�����ѯ����
	__declspec(dllexport) int __stdcall ReqQryOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryOrderField *pQryOrder, int nRequestID) ;

	///�����ѯ�ɽ�
	__declspec(dllexport) int __stdcall ReqQryTrade(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradeField *pQryTrade, int nRequestID) ;

	///�����ѯͶ���ֲ߳�
	__declspec(dllexport) int __stdcall ReqQryInvestorPosition(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionField *pQryInvestorPosition, int nRequestID) ;

	///�����ѯ�ʽ��˻�
	__declspec(dllexport) int __stdcall ReqQryTradingAccount(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingAccountField *pQryTradingAccount, int nRequestID) ;

	///�����ѯͶ����
	__declspec(dllexport) int __stdcall ReqQryInvestor(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorField *pQryInvestor, int nRequestID) ;

	///�����ѯ���ױ���
	__declspec(dllexport) int __stdcall ReqQryTradingCode(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingCodeField *pQryTradingCode, int nRequestID) ;

	///�����ѯ��Լ��֤����
	__declspec(dllexport) int __stdcall ReqQryInstrumentMarginRate(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentMarginRateField *pQryInstrumentMarginRate, int nRequestID) ;

	///�����ѯ��Լ��������
	__declspec(dllexport) int __stdcall ReqQryInstrumentCommissionRate(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentCommissionRateField *pQryInstrumentCommissionRate, int nRequestID) ;

	///�����ѯ������
	__declspec(dllexport) int __stdcall ReqQryExchange(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryExchangeField *pQryExchange, int nRequestID) ;

	///�����ѯ��Լ
	__declspec(dllexport) int __stdcall ReqQryInstrument(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInstrumentField *pQryInstrument, int nRequestID) ;

	///�����ѯ����
	__declspec(dllexport) int __stdcall ReqQryDepthMarketData(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryDepthMarketDataField *pQryDepthMarketData, int nRequestID) ;

	///�����ѯͶ���߽�����
	__declspec(dllexport) int __stdcall ReqQrySettlementInfo(CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoField *pQrySettlementInfo, int nRequestID) ;

	///�����ѯת������
	__declspec(dllexport) int __stdcall ReqQryTransferBank(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferBankField *pQryTransferBank, int nRequestID) ;

	///�����ѯͶ���ֲ߳���ϸ
	__declspec(dllexport) int __stdcall ReqQryInvestorPositionDetail(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionDetailField *pQryInvestorPositionDetail, int nRequestID) ;

	///�����ѯ�ͻ�֪ͨ
	__declspec(dllexport) int __stdcall ReqQryNotice(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryNoticeField *pQryNotice, int nRequestID) ;

	///�����ѯ������Ϣȷ��
	__declspec(dllexport) int __stdcall ReqQrySettlementInfoConfirm(CThostFtdcTraderApi* pTraderApi, CThostFtdcQrySettlementInfoConfirmField *pQrySettlementInfoConfirm, int nRequestID) ;

	///�����ѯͶ���ֲ߳���ϸ
	__declspec(dllexport) int __stdcall ReqQryInvestorPositionCombineDetail(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryInvestorPositionCombineDetailField *pQryInvestorPositionCombineDetail, int nRequestID) ;

	///�����ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ
	__declspec(dllexport) int __stdcall ReqQryCFMMCTradingAccountKey(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryCFMMCTradingAccountKeyField *pQryCFMMCTradingAccountKey, int nRequestID) ;

	///�����ѯ�ֵ��۵���Ϣ
	__declspec(dllexport) int __stdcall ReqQryEWarrantOffset(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryEWarrantOffsetField *pQryEWarrantOffset, int nRequestID) ;

	///�����ѯת����ˮ
	__declspec(dllexport) int __stdcall ReqQryTransferSerial(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTransferSerialField *pQryTransferSerial, int nRequestID) ;

	///�����ѯ����ǩԼ��ϵ
	__declspec(dllexport) int __stdcall ReqQryAccountregister(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryAccountregisterField *pQryAccountregister, int nRequestID) ;

	///�����ѯǩԼ����
	__declspec(dllexport) int __stdcall ReqQryContractBank(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryContractBankField *pQryContractBank, int nRequestID) ;

	///�����ѯԤ��
	__declspec(dllexport) int __stdcall ReqQryParkedOrder(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderField *pQryParkedOrder, int nRequestID) ;

	///�����ѯԤ�񳷵�
	__declspec(dllexport) int __stdcall ReqQryParkedOrderAction(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryParkedOrderActionField *pQryParkedOrderAction, int nRequestID) ;

	///�����ѯ����֪ͨ
	__declspec(dllexport) int __stdcall ReqQryTradingNotice(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryTradingNoticeField *pQryTradingNotice, int nRequestID) ;

	///�����ѯ���͹�˾���ײ���
	__declspec(dllexport) int __stdcall ReqQryBrokerTradingParams(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingParamsField *pQryBrokerTradingParams, int nRequestID) ;

	///�����ѯ���͹�˾�����㷨
	__declspec(dllexport) int __stdcall ReqQryBrokerTradingAlgos(CThostFtdcTraderApi* pTraderApi, CThostFtdcQryBrokerTradingAlgosField *pQryBrokerTradingAlgos, int nRequestID) ;

	///�ڻ����������ʽ�ת�ڻ�����
	__declspec(dllexport) int __stdcall ReqFromBankToFutureByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID) ;

	///�ڻ������ڻ��ʽ�ת��������
	__declspec(dllexport) int __stdcall ReqFromFutureToBankByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqTransferField *pReqTransfer, int nRequestID) ;

	///�ڻ������ѯ�����������
	__declspec(dllexport) int __stdcall ReqQueryBankAccountMoneyByFuture(CThostFtdcTraderApi* pTraderApi, CThostFtdcReqQueryAccountField *pReqQueryAccount, int nRequestID) ;
};