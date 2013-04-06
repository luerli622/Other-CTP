#pragma once

#include "ThostFtdcTraderApi.h"

///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
typedef void (__stdcall * FPOnFrontConnected)();

///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
///@param nReason ����ԭ��
///        0x1001 �����ʧ��
///        0x1002 ����дʧ��
///        0x2001 ����������ʱ
///        0x2002 ��������ʧ��
///        0x2003 �յ�������
typedef void (__stdcall * FPOnFrontDisconnected)(int nReason);

///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
///@param nTimeLapse �����ϴν��ձ��ĵ�ʱ��
typedef void (__stdcall * FPOnHeartBeatWarning)(int nTimeLapse);

///�ͻ�����֤��Ӧ
typedef void (__stdcall * FPOnRspAuthenticate)(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;


///��¼������Ӧ
typedef void (__stdcall * FPOnRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�ǳ�������Ӧ
typedef void (__stdcall * FPOnRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�û��������������Ӧ
typedef void (__stdcall * FPOnRspUserPasswordUpdate)(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�ʽ��˻��������������Ӧ
typedef void (__stdcall * FPOnRspTradingAccountPasswordUpdate)(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///����¼��������Ӧ
typedef void (__stdcall * FPOnRspOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///Ԥ��¼��������Ӧ
typedef void (__stdcall * FPOnRspParkedOrderInsert)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///Ԥ�񳷵�¼��������Ӧ
typedef void (__stdcall * FPOnRspParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///��������������Ӧ
typedef void (__stdcall * FPOnRspOrderAction)(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///��ѯ��󱨵�������Ӧ
typedef void (__stdcall * FPOnRspQueryMaxOrderVolume)(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///Ͷ���߽�����ȷ����Ӧ
typedef void (__stdcall * FPOnRspSettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///ɾ��Ԥ����Ӧ
typedef void (__stdcall * FPOnRspRemoveParkedOrder)(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///ɾ��Ԥ�񳷵���Ӧ
typedef void (__stdcall * FPOnRspRemoveParkedOrderAction)(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ������Ӧ
typedef void (__stdcall * FPOnRspQryOrder)(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ�ɽ���Ӧ
typedef void (__stdcall * FPOnRspQryTrade)(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯͶ���ֲ߳���Ӧ
typedef void (__stdcall * FPOnRspQryInvestorPosition)(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ�ʽ��˻���Ӧ
typedef void (__stdcall * FPOnRspQryTradingAccount)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯͶ������Ӧ
typedef void (__stdcall * FPOnRspQryInvestor)(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ���ױ�����Ӧ
typedef void (__stdcall * FPOnRspQryTradingCode)(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ��Լ��֤������Ӧ
typedef void (__stdcall * FPOnRspQryInstrumentMarginRate)(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ��Լ����������Ӧ
typedef void (__stdcall * FPOnRspQryInstrumentCommissionRate)(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ��������Ӧ
typedef void (__stdcall * FPOnRspQryExchange)(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ��Լ��Ӧ
typedef void (__stdcall * FPOnRspQryInstrument)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ������Ӧ
typedef void (__stdcall * FPOnRspQryDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯͶ���߽�������Ӧ
typedef void (__stdcall * FPOnRspQrySettlementInfo)(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯת��������Ӧ
typedef void (__stdcall * FPOnRspQryTransferBank)(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯͶ���ֲ߳���ϸ��Ӧ
typedef void (__stdcall * FPOnRspQryInvestorPositionDetail)(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ�ͻ�֪ͨ��Ӧ
typedef void (__stdcall * FPOnRspQryNotice)(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ������Ϣȷ����Ӧ
typedef void (__stdcall * FPOnRspQrySettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯͶ���ֲ߳���ϸ��Ӧ
typedef void (__stdcall * FPOnRspQryInvestorPositionCombineDetail)(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
typedef void (__stdcall * FPOnRspQryCFMMCTradingAccountKey)(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ�ֵ��۵���Ϣ��Ӧ
typedef void (__stdcall * FPOnRspQryEWarrantOffset)(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯת����ˮ��Ӧ
typedef void (__stdcall * FPOnRspQryTransferSerial)(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ����ǩԼ��ϵ��Ӧ
typedef void (__stdcall * FPOnRspQryAccountregister)(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///����Ӧ��
typedef void (__stdcall * FPOnRspError)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///����֪ͨ
typedef void (__stdcall * FPOnRtnOrder)(CThostFtdcOrderField *pOrder) ;

///�ɽ�֪ͨ
typedef void (__stdcall * FPOnRtnTrade)(CThostFtdcTradeField *pTrade) ;

///����¼�����ر�
typedef void (__stdcall * FPOnErrRtnOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) ;

///������������ر�
typedef void (__stdcall * FPOnErrRtnOrderAction)(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) ;

///��Լ����״̬֪ͨ
typedef void (__stdcall * FPOnRtnInstrumentStatus)(CThostFtdcInstrumentStatusField *pInstrumentStatus) ;

///����֪ͨ
typedef void (__stdcall * FPOnRtnTradingNotice)(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) ;

///��ʾ������У�����
typedef void (__stdcall * FPOnRtnErrorConditionalOrder)(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) ;

///�����ѯǩԼ������Ӧ
typedef void (__stdcall * FPOnRspQryContractBank)(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯԤ����Ӧ
typedef void (__stdcall * FPOnRspQryParkedOrder)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯԤ�񳷵���Ӧ
typedef void (__stdcall * FPOnRspQryParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ����֪ͨ��Ӧ
typedef void (__stdcall * FPOnRspQryTradingNotice)(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ���͹�˾���ײ�����Ӧ
typedef void (__stdcall * FPOnRspQryBrokerTradingParams)(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�����ѯ���͹�˾�����㷨��Ӧ
typedef void (__stdcall * FPOnRspQryBrokerTradingAlgos)(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///���з��������ʽ�ת�ڻ�֪ͨ
typedef void (__stdcall * FPOnRtnFromBankToFutureByBank)(CThostFtdcRspTransferField *pRspTransfer) ;

///���з����ڻ��ʽ�ת����֪ͨ
typedef void (__stdcall * FPOnRtnFromFutureToBankByBank)(CThostFtdcRspTransferField *pRspTransfer) ;

///���з����������ת�ڻ�֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByBank)(CThostFtdcRspRepealField *pRspRepeal) ;

///���з�������ڻ�ת����֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByBank)(CThostFtdcRspRepealField *pRspRepeal) ;

///�ڻ����������ʽ�ת�ڻ�֪ͨ
typedef void (__stdcall * FPOnRtnFromBankToFutureByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;

///�ڻ������ڻ��ʽ�ת����֪ͨ
typedef void (__stdcall * FPOnRtnFromFutureToBankByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;

///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;

///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;

///�ڻ������ѯ�������֪ͨ
typedef void (__stdcall * FPOnRtnQueryBankBalanceByFuture)(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) ;

///�ڻ����������ʽ�ת�ڻ�����ر�
typedef void (__stdcall * FPOnErrRtnBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

///�ڻ������ڻ��ʽ�ת���д���ر�
typedef void (__stdcall * FPOnErrRtnFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
typedef void (__stdcall * FPOnErrRtnRepealBankToFutureByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
typedef void (__stdcall * FPOnErrRtnRepealFutureToBankByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

///�ڻ������ѯ����������ر�
typedef void (__stdcall * FPOnErrRtnQueryBankBalanceByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) ;

///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromBankToFutureByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;

///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
typedef void (__stdcall * FPOnRtnRepealFromFutureToBankByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;

///�ڻ����������ʽ�ת�ڻ�Ӧ��
typedef void (__stdcall * FPOnRspFromBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�ڻ������ڻ��ʽ�ת����Ӧ��
typedef void (__stdcall * FPOnRspFromFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///�ڻ������ѯ�������Ӧ��
typedef void (__stdcall * FPOnRspQueryBankAccountMoneyByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

///���з������ڿ���֪ͨ
typedef void (__stdcall * FPOnRtnOpenAccountByBank)(CThostFtdcOpenAccountField *pOpenAccount) ;

///���з�����������֪ͨ
typedef void (__stdcall * FPOnRtnCancelAccountByBank)(CThostFtdcCancelAccountField *pCancelAccount) ;

///���з����������˺�֪ͨ
typedef void (__stdcall * FPOnRtnChangeAccountByBank)(CThostFtdcChangeAccountField *pChangeAccount) ;