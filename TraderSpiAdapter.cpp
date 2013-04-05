#include "TraderSpiAdapter.h"

///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
void CTraderSpiAdapter::OnFrontConnected ()
{
	m_pfOnFrontConnected();
}

///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
///@param nReason ����ԭ��
///        0x1001 �����ʧ��
///        0x1002 ����дʧ��
///        0x2001 ����������ʱ
///        0x2002 ��������ʧ��
///        0x2003 �յ�������
void CTraderSpiAdapter::OnFrontDisconnected (int nReason)
{
	m_pfOnFrontDisconnected(nReason);
}

///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
///@param nTimeLapse �����ϴν��ձ��ĵ�ʱ��
void CTraderSpiAdapter::OnHeartBeatWarning (int nTimeLapse)
{
	m_pfOnHeartBeatWarning(nTimeLapse);
}

///�ͻ�����֤��Ӧ
void CTraderSpiAdapter::OnRspAuthenticate (CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspAuthenticate(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
}


///��¼������Ӧ
void CTraderSpiAdapter::OnRspUserLogin (CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
}

///�ǳ�������Ӧ
void CTraderSpiAdapter::OnRspUserLogout (CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
}

///�û��������������Ӧ
void CTraderSpiAdapter::OnRspUserPasswordUpdate (CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspUserPasswordUpdate(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
}

///�ʽ��˻��������������Ӧ
void CTraderSpiAdapter::OnRspTradingAccountPasswordUpdate (CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
}

///����¼��������Ӧ
void CTraderSpiAdapter::OnRspOrderInsert (CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspOrderInsert(pInputOrder, pRspInfo, nRequestID, bIsLast);
}

///Ԥ��¼��������Ӧ
void CTraderSpiAdapter::OnRspParkedOrderInsert (CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspParkedOrderInsert(pParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///Ԥ�񳷵�¼��������Ӧ
void CTraderSpiAdapter::OnRspParkedOrderAction (CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///��������������Ӧ
void CTraderSpiAdapter::OnRspOrderAction (CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspOrderAction(pInputOrderAction, pRspInfo, nRequestID, bIsLast);
}

///��ѯ��󱨵�������Ӧ
void CTraderSpiAdapter::OnRspQueryMaxOrderVolume (CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQueryMaxOrderVolume(pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
}

///Ͷ���߽�����ȷ����Ӧ
void CTraderSpiAdapter::OnRspSettlementInfoConfirm (CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspSettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
}

///ɾ��Ԥ����Ӧ
void CTraderSpiAdapter::OnRspRemoveParkedOrder (CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspRemoveParkedOrder(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///ɾ��Ԥ�񳷵���Ӧ
void CTraderSpiAdapter::OnRspRemoveParkedOrderAction (CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspRemoveParkedOrderAction(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ������Ӧ
void CTraderSpiAdapter::OnRspQryOrder (CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryOrder(pOrder, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ�ɽ���Ӧ
void CTraderSpiAdapter::OnRspQryTrade (CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTrade(pTrade, pRspInfo, nRequestID, bIsLast);
}

///�����ѯͶ���ֲ߳���Ӧ
void CTraderSpiAdapter::OnRspQryInvestorPosition (CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPosition(pInvestorPosition, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ�ʽ��˻���Ӧ
void CTraderSpiAdapter::OnRspQryTradingAccount (CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingAccount(pTradingAccount, pRspInfo, nRequestID, bIsLast);
}

///�����ѯͶ������Ӧ
void CTraderSpiAdapter::OnRspQryInvestor (CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestor(pInvestor, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ���ױ�����Ӧ
void CTraderSpiAdapter::OnRspQryTradingCode (CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingCode(pTradingCode, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ��Լ��֤������Ӧ
void CTraderSpiAdapter::OnRspQryInstrumentMarginRate (CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrumentMarginRate(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ��Լ����������Ӧ
void CTraderSpiAdapter::OnRspQryInstrumentCommissionRate (CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrumentCommissionRate(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ��������Ӧ
void CTraderSpiAdapter::OnRspQryExchange (CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryExchange(pExchange, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ��Լ��Ӧ
void CTraderSpiAdapter::OnRspQryInstrument (CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInstrument(pInstrument, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ������Ӧ
void CTraderSpiAdapter::OnRspQryDepthMarketData (CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryDepthMarketData(pDepthMarketData, pRspInfo, nRequestID, bIsLast);
}

///�����ѯͶ���߽�������Ӧ
void CTraderSpiAdapter::OnRspQrySettlementInfo (CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQrySettlementInfo(pSettlementInfo, pRspInfo, nRequestID, bIsLast);
}

///�����ѯת��������Ӧ
void CTraderSpiAdapter::OnRspQryTransferBank (CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTransferBank(pTransferBank, pRspInfo, nRequestID, bIsLast);
}

///�����ѯͶ���ֲ߳���ϸ��Ӧ
void CTraderSpiAdapter::OnRspQryInvestorPositionDetail (CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPositionDetail(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ�ͻ�֪ͨ��Ӧ
void CTraderSpiAdapter::OnRspQryNotice (CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryNotice(pNotice, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ������Ϣȷ����Ӧ
void CTraderSpiAdapter::OnRspQrySettlementInfoConfirm (CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQrySettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
}

///�����ѯͶ���ֲ߳���ϸ��Ӧ
void CTraderSpiAdapter::OnRspQryInvestorPositionCombineDetail (CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
}

///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
void CTraderSpiAdapter::OnRspQryCFMMCTradingAccountKey (CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ�ֵ��۵���Ϣ��Ӧ
void CTraderSpiAdapter::OnRspQryEWarrantOffset (CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryEWarrantOffset(pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
}

///�����ѯת����ˮ��Ӧ
void CTraderSpiAdapter::OnRspQryTransferSerial (CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTransferSerial(pTransferSerial, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ����ǩԼ��ϵ��Ӧ
void CTraderSpiAdapter::OnRspQryAccountregister (CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryAccountregister(pAccountregister, pRspInfo, nRequestID, bIsLast);
}

///����Ӧ��
void CTraderSpiAdapter::OnRspError (CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspError(pRspInfo, nRequestID, bIsLast);
}

///����֪ͨ
void CTraderSpiAdapter::OnRtnOrder (CThostFtdcOrderField *pOrder)
{
	m_pfOnRtnOrder(pOrder);
}

///�ɽ�֪ͨ
void CTraderSpiAdapter::OnRtnTrade (CThostFtdcTradeField *pTrade)
{
	m_pfOnRtnTrade(pTrade);
}

///����¼�����ر�
void CTraderSpiAdapter::OnErrRtnOrderInsert (CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnOrderInsert(pInputOrder, pRspInfo);
}

///������������ر�
void CTraderSpiAdapter::OnErrRtnOrderAction (CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnOrderAction(pOrderAction, pRspInfo);
}

///��Լ����״̬֪ͨ
void CTraderSpiAdapter::OnRtnInstrumentStatus (CThostFtdcInstrumentStatusField *pInstrumentStatus)
{
	m_pfOnRtnInstrumentStatus(pInstrumentStatus);
}

///����֪ͨ
void CTraderSpiAdapter::OnRtnTradingNotice (CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo)
{
	m_pfOnRtnTradingNotice(pTradingNoticeInfo);
}

///��ʾ������У�����
void CTraderSpiAdapter::OnRtnErrorConditionalOrder (CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder)
{
	m_pfOnRtnErrorConditionalOrder(pErrorConditionalOrder);
}

///�����ѯǩԼ������Ӧ
void CTraderSpiAdapter::OnRspQryContractBank (CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryContractBank(pContractBank, pRspInfo, nRequestID, bIsLast);
}

///�����ѯԤ����Ӧ
void CTraderSpiAdapter::OnRspQryParkedOrder (CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryParkedOrder(pParkedOrder, pRspInfo, nRequestID, bIsLast);
}

///�����ѯԤ�񳷵���Ӧ
void CTraderSpiAdapter::OnRspQryParkedOrderAction (CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ����֪ͨ��Ӧ
void CTraderSpiAdapter::OnRspQryTradingNotice (CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryTradingNotice(pTradingNotice, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ���͹�˾���ײ�����Ӧ
void CTraderSpiAdapter::OnRspQryBrokerTradingParams (CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryBrokerTradingParams(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
}

///�����ѯ���͹�˾�����㷨��Ӧ
void CTraderSpiAdapter::OnRspQryBrokerTradingAlgos (CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQryBrokerTradingAlgos(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
}

///���з��������ʽ�ת�ڻ�֪ͨ
void CTraderSpiAdapter::OnRtnFromBankToFutureByBank (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromBankToFutureByBank(pRspTransfer);
}

///���з����ڻ��ʽ�ת����֪ͨ
void CTraderSpiAdapter::OnRtnFromFutureToBankByBank (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromFutureToBankByBank(pRspTransfer);
}

///���з����������ת�ڻ�֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByBank (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByBank(pRspRepeal);
}

///���з�������ڻ�ת����֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByBank (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByBank(pRspRepeal);
}

///�ڻ����������ʽ�ת�ڻ�֪ͨ
void CTraderSpiAdapter::OnRtnFromBankToFutureByFuture (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromBankToFutureByFuture(pRspTransfer);
}

///�ڻ������ڻ��ʽ�ת����֪ͨ
void CTraderSpiAdapter::OnRtnFromFutureToBankByFuture (CThostFtdcRspTransferField *pRspTransfer)
{
	m_pfOnRtnFromFutureToBankByFuture(pRspTransfer);
}

///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByFutureManual (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
}

///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByFutureManual (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
}

///�ڻ������ѯ�������֪ͨ
void CTraderSpiAdapter::OnRtnQueryBankBalanceByFuture (CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount)
{
	m_pfOnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
}

///�ڻ����������ʽ�ת�ڻ�����ر�
void CTraderSpiAdapter::OnErrRtnBankToFutureByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnBankToFutureByFuture(pReqTransfer, pRspInfo);
}

///�ڻ������ڻ��ʽ�ת���д���ر�
void CTraderSpiAdapter::OnErrRtnFutureToBankByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnFutureToBankByFuture(pReqTransfer, pRspInfo);
}

///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
void CTraderSpiAdapter::OnErrRtnRepealBankToFutureByFutureManual (CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnRepealBankToFutureByFutureManual(pReqRepeal, pRspInfo);
}

///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
void CTraderSpiAdapter::OnErrRtnRepealFutureToBankByFutureManual (CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnRepealFutureToBankByFutureManual(pReqRepeal, pRspInfo);
}

///�ڻ������ѯ����������ر�
void CTraderSpiAdapter::OnErrRtnQueryBankBalanceByFuture (CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo)
{
	m_pfOnErrRtnQueryBankBalanceByFuture(pReqQueryAccount, pRspInfo);
}

///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromBankToFutureByFuture (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromBankToFutureByFuture(pRspRepeal);
}

///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
void CTraderSpiAdapter::OnRtnRepealFromFutureToBankByFuture (CThostFtdcRspRepealField *pRspRepeal)
{
	m_pfOnRtnRepealFromFutureToBankByFuture(pRspRepeal);
}

///�ڻ����������ʽ�ת�ڻ�Ӧ��
void CTraderSpiAdapter::OnRspFromBankToFutureByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspFromBankToFutureByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
}

///�ڻ������ڻ��ʽ�ת����Ӧ��
void CTraderSpiAdapter::OnRspFromFutureToBankByFuture (CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspFromFutureToBankByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
}

///�ڻ������ѯ�������Ӧ��
void CTraderSpiAdapter::OnRspQueryBankAccountMoneyByFuture (CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	m_pfOnRspQueryBankAccountMoneyByFuture(pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
}

///���з������ڿ���֪ͨ
void CTraderSpiAdapter::OnRtnOpenAccountByBank (CThostFtdcOpenAccountField *pOpenAccount)
{
	m_pfOnRtnOpenAccountByBank(pOpenAccount);
}

///���з�����������֪ͨ
void CTraderSpiAdapter::OnRtnCancelAccountByBank (CThostFtdcCancelAccountField *pCancelAccount)
{
	m_pfOnRtnCancelAccountByBank(pCancelAccount);
}

///���з����������˺�֪ͨ
void CTraderSpiAdapter::OnRtnChangeAccountByBank (CThostFtdcChangeAccountField *pChangeAccount)
{
	m_pfOnRtnChangeAccountByBank(pChangeAccount);
}

CTraderSpiAdapter::CTraderSpiAdapter( const STraderSpi& spi ):STraderSpi(spi)
{

}
