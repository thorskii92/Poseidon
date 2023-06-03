Imports MySql.Data.MySqlClient
Module ViewModule
    Public arrAccountUpdateClassID() As Integer
    Public loggedID As Integer
    Public selectedUtypeID As Integer
    Public arrProvID() As Integer
    Public arrMunID() As Integer
    Public arrBrgyID() As Integer
    Public arrZoneID() As Integer
    Public arrClusterID() As Integer
    Public selectedProvID As Integer
    Public selectedMunID As Integer
    Public selectedBrgyID As Integer
    Public selectedZoneID As Integer
    Public selectedClusterID As Integer
    Public selectedAcctIDLedger As Integer
    Public selectedAcctIChangeConsumer As Integer
    Public selectedComProvID As Integer
    Public selectedComMunID As Integer
    Public selectedComBrgyID As Integer
    Public arrComProvID() As Integer
    Public arrComMunID() As Integer
    Public arrComBrgyID() As Integer

    Public arrBillRepClusterID() As Integer
    Public arrBillRepBrgyID() As Integer
    Public arrBillRepMonth() As String
    Public arrBillRepYear() As Integer
    Public arrBillRepBillID() As Integer

    Public arrtempClientName(19) As String
    Public arrtempClass(19) As String
    Public arrtempPrevRead(19) As Integer
    Public arrtempCurRead(19) As Integer
    Public arrtempCubitsMet(19) As Integer
    Public arrtempTotAmount(19) As Double

    Public arrCustID() As Integer
    Public BrowsedID As Integer

    Public arrCusProvID() As Integer
    Public arrCusMunID() As Integer
    Public arrCusBrgyID() As Integer

    Public arrClassSetID() As Integer

    Public arrCusID() As Integer
    Public arrViewClassRateID() As Integer

    Public tempArrMinCub(99) As Integer
    Public tempArrRate(99) As Double
    Public tempArrIsBulk(99) As Integer
    Public tempArrCubits(99) As Integer
    Dim cubitLabel As String
    Dim nextCubit As String
    Public lastCub As Integer
    Public tempArrRateID() As Integer

    Public getClassID As Integer

    'CONSUMERLIST
    Public arrConsumerID() As Integer
    Public arrSelectedAcctID() As Integer

    Public arrPendAcctID() As Integer
    Public selectedPendingAccountID As Integer

    'METER READING ARRAYS
    Public arrTempAcctID() As Integer
    Public arrTempAccountNum() As String
    Public arrTempSeqNum() As Integer
    Public arrTempConsName() As String
    Public arrTempClassType() As String
    Public arrTempClassID() As Integer
    Public arrTempRef() As Long
    Public arrTempCurReading() As Long
    Public arrTempConsumed() As Integer
    Public arrTempPartAmount() As Double
    Public arrTempPrevBalance() As Double
    Public arrTempTotalAmount() As Double
    Public arrTempAmountDue() As Double
    Public arrTempConsumerID() As Integer
    Public arrTempPrevMetID() As Integer
    Public accountCount As Integer
    Public pageCount As Integer
    Public intDiv As Integer
    Public intMod As Integer
    Public addPage As Integer
    Public MetReadSelectedBrgyID As Integer
    Public MetReadSelectedCluster As Integer
    Public readingDate As String
    Public readingDue As String
    Public accessDate As String
    Public mZone As Integer
    Public mCluster As Integer
    Public MonthReadFrom As String
    Public MonthReadTo As String
    Public MonthReadYear As String
    Public perFromDate As Date
    Public perToDate As Date
    Public arrTempAppFee() As Decimal

    Public arrPrevConsump() As Integer
    Public arrPrevEnv() As Double
    Public arrPrevAdj() As Double
    Public arrPrevAdjRate() As Double
    Public arrPrevPenalty() As Double
    Public arrPrevAmountDue() As Double
    Public arrPrevTotal() As Double

    'METER READING ARRAYS

    Public arrNewReadProvID() As Integer
    Public arrNewReadMunID() As Integer
    Public arrNewReadZoneID() As Integer
    Public arrNewReadBrgyID() As Integer
    Public arrNewReadCluster() As Integer
    Public curPage As Integer
    Public arrUnpaidCount() As Integer
    Public classListCount As Integer
    Public selectedClassListID As Integer

    Public arrSeqProvID() As Integer
    Public arrSeqMunID() As Integer
    Public arrSeqZoneID() As Integer
    Public arrSeqBrgyID() As Integer
    Public arrSeqCluster() As Integer
    Public arrSeqAccID() As Integer

    Public arrAcctListProvID() As Integer
    Public arrAcctListMunID() As Integer
    Public arrAcctListZoneID() As Integer
    Public arrAcctListBrgyID() As Integer
    Public arrAcctListClusterID() As Integer

    Public selSeqAcctID As Integer

    Public maxSeqNum As Integer
    Public allAccountID() As Integer

    Public ledgetAcctID As Integer

    Public arrConsWaterID() As Integer
    Public arrWaterBillMetID() As Integer
    Public arrWaterBillAccID() As Integer
    Public arrWaterBillAmountReq() As Double
    Public getTotAmountWaterBill As Double
    Public myDueStatus As String

    Public arrAccountListAcctID() As Integer
    Public arrAccountListConsID() As Integer
    Public editProvID As Integer

    Public arrSelectedUTypeID() As Integer

    Public arrBillProvID() As Integer
    Public arrBillMunID() As Integer
    Public arrBillZoneID() As Integer
    Public arrBillBrgyID() As Integer
    Public arrBillClusID() As Integer

    Public arrBillMetID() As Integer
    Public arrBillAcctID() As Integer

    Public selBillMetID As Integer
    Public selBillAccID As Integer
    Public strQueryBill As String

    Public arrBillingMetID() As Integer
    Public billPrintPageCount As Integer
    Public billCurPage As Integer
    Public arrBillIDLedger() As Integer
    Public selBillIDLedger As Integer

    Public selSetZoneID As Integer
    Public selSetMunID As Integer
    Public selSetBarID As Integer
    Public arrUTypeID() As Integer
    Public arrSysUID() As Integer
    Public authenticatingPassword As String
    Public enteredPassword As String
    Public authenticate As Boolean

    Public rrFrom As String
    Public rrTo As String
    Public rrYear As String
    Public rbrgID As Integer
    Public rclID As Integer
    Public memosequence As Integer

    Public selAdjBillID As Integer
    Public selAdjPrep As Integer
    Public selAdjApprover As String
    Public AdjustPrevMonthTotal As Double
    Public selConsUpID As Integer
    Public SelectedAccountIDTransfer As Integer
    Public NewConsumerTransferID As Integer
    Public consBalance As Double
    Public TypeNewCons As Integer
    Public SelectedConsumerIDTransfer As Integer
    Public GoodForOwnerTransfer As Boolean
    Public GoodForMeterTransfer As Boolean
    Public GoodForReconnection As Boolean
    'New Consumer 1
    'New Consumer on Transfer Owner 2
    Public arrTransConsID() As Integer

    'TRANSFER METER
    Public arrProvMeterTransID() As Integer
    Public arrMunMeterTransID() As Integer
    Public arrZoneMeterTransID() As Integer
    Public arrBarMeterTransID() As Integer
    'TRANSFER METER
    Public metTranBrgyID As Integer
    Public metTranClusID As Integer
    Public metTranConsID As Integer
    Public metTranSeqID As Integer
    Public metTranAcctID As Integer

    Public RecAcctID As Integer
    Public RecConsID As Integer

    Public paymentID As Integer
    Public ORUseID As Integer
    Public uaID As Integer
    Public ucID As Integer

    Public arrBillPayID() As Integer

    Public SerFee As Double
    Public AdvFee As Double
    Public MeterFee As Double
    Public OwnerFee As Double
    Public ReconFee As Double
    Public ORNum As String

    Public billAdjustForm As Integer
    Public billRowCount As Integer
    Public adjConID As Integer
    Public adjAcctID As Integer
    Public adjBillID As Integer
    Public selectedAcctLedgerID As Integer
    Public closingSelect As Integer
    Public strMonthlySalesQuery As String
    Public discNote As String
    Public currentORNum As Integer
    Public reqPayment() As Double
    Public discPayment() As Double
    Public SelectedPendingConsumerID As Integer
    Public countIndex As Integer

    'METER READING ARRAYS
    Public arrTextRead(19) As Integer
    Public disconDate As Date

    Public arrAccCodeGID() As Integer

    Public arrBaraID() As Integer
    Public arrClasID() As Integer
    Public selBaraID As Integer
    Public selClasID As Integer

    Public AnnualSqlStr As String
    Public discountedAmount() As Double

    Public clus As String

    Public strQueryAdjusted As String
    Public qAdjCount As Integer

    Public arrAppBillID() As Integer
    Public arrAppAcctID() As Integer
    Public MeterReadingBool As Boolean
    Public selectedNoteID As Integer
    Public noteIDs() As Integer

    Public arrBillAdjMemo() As Integer
    Public adjIndex As Integer

    Public dispConID As Integer
    Public dispAcctID As Integer
    Public dispBillID As Integer

    Public strQueryDisputed As String
    Public qDispCount As Integer
    Public arrBillDispMemo() As Integer
    Public strQuertyEnvi As String
    Public enFeeCount As Integer

    Public chkBoolExemp() As Boolean

    'SYSTEM PENDING STATUS
    Public statCon As Integer
    Public statDiscon As Integer
    Public statInstall As Integer
    Public statDisconnection As Integer
    Public statMetTrans As Integer
    Public statNameTrans As Integer
    Public statRecon As Integer
    'SYSTEM PENDING STATUS

    Public SelectedAdjMemoID As Integer
    Public selectedAcctIDReferenceChange As Integer

    Public formReportIndex As Integer
    Public oldConsID As Integer

    'OTHER REPORTS
    ''Installation Daily Report
    Public sqlstrDailyInstall As String
    Public sqlStrDailyTransMet As String
    Public sqlStrDailyTransOwn As String
    Public sqlStrDailyReconnect As String

    Public sqlstrMonthlyInstall As String
    Public sqlstrMonthlyTransmet As String
    Public sqlstrMonthlyTransOwn As String
    Public sqlstrMonthlyReconnect As String

    Public sqlstrAnnualInstall As String
    Public sqlstrAnnualTransmet As String
    Public sqlstrAnnualTransOwn As String
    Public sqlstrAnnualReconnect As String

    Public sqlstrPendingItems As String
    Public repType As Integer
    Public sqlstrMonRepor As String
    Public sqlstrAnnualRepor As String
    Public gotConsump As Integer
    Public acFilter As String

    'billReport
    Public BdateGen As String
    Public BmonthFrom As String
    Public BmonthTo As String
    Public BBYear As Integer
    Public BCount As Integer
    Public BBillDate As Date
    Public BBgyID As Integer
    Public BClus As Integer
    'billReport
    Public arrBrBillRepID() As Integer
    Public arrMFromRep() As String
    Public arrMToRep() As String
    Public arrMyearRep() As Integer
    Public arrMCluster() As Integer
    Public arrRepIDBill() As Integer
    Public selUTID As Integer

    Public arrReadClusterID() As Integer
    Public strSenior() As String
    Public senID() As String
    Public prevEnviFee() As Double
    Public billperiod As String
    Public meterReaderID() As Integer
    Public selectedMetReadID As Integer

    Public arrBillCLusterID() As Integer

    Public arrFConsump() As Integer
    Public arrSConsump() As Integer
    Public arrFExcess() As Double
    Public arrSExcess() As Double
    Public arrFLabel() As String
    Public arrSLabel() As String
    Public arrFAmtPerCub() As Double
    Public arrSAmtPerCub() As Double
    Public arrMinCons() As Integer
    Public arrPrevSCDis() As Double
    Public arrCheckSC() As String
    Public arrSenIDCons() As String
    Public arrAgency() As String
    Public arrBillMonthPay() As String
    Public arrBillYearPay() As Integer
    Public outstandingStat() As String
    Public outstandingBalance() As Double
    Public arrBillPrevDIscount() As Double

    Public arrSettingsMetReaderID() As Integer
    Public selSettingsMetReaderID As Integer

    Public meterReaderSettingSavingType As Integer
    Public PDtotalAmountToPay As Double
    Public arrClusterSeqID() As Integer
    Public selClusterSeqID As Integer

    Public arrBillChangePrevID As Integer
    Public arrBillEditorClassID() As Integer
    Public selBillEditorClassID As Integer
    Public selectedBillLedgerID As Integer

    Public arrPendingBillID() As Integer
    Public selectedPendingBIllID As Integer
    Public arrPendingBillStatID() As Integer
    Public prepareeID As Integer

    Public arrBillApprovalID() As Integer
    Public selectedBillApprovalID As Integer
    Public ConsumerDatatable As DataTable

    Public totalConsumerPage As Integer
    Public totalConsumerCount As Integer
    Public lastItemsCOunt As Integer
    Public curPageNumConsumer As Integer

    Public billOutstandBal() As Double
    Public billOutstandTotal() As Double
    Public billOutstandPenalty() As Double
    Public billOutstandEF() As Double
    Public billOutstandDiscount() As Double
    Public billOutstandAdjustedRate() As Double


    'Public EnteredRD As String

    Public TotalPreviousToPay As Double

    Public editORFromForm As Integer

    Public pHistoryID() As Integer

    Public selectedAccountLedgerID As Integer
    Public readBrgyID As Integer

    Public arrDiscAcctID() As Integer
    Public EnteredRD As String
    Public arrApplicationAccountID() As Integer
    Public appOpenForm As Integer

    Public AppFeeEditID As Integer
    Public AppFeeEditConsID As Integer
    Public OverpayEditID As Integer
    Public OverpayID As Integer
    Public isNew As Boolean

    Public RevConsumpDatatable As DataTable

    Public textRead() As TextBox = {frmMeterReading.txtRead1, frmMeterReading.txtRead2, frmMeterReading.txtRead3, frmMeterReading.txtRead4, frmMeterReading.txtRead5, frmMeterReading.txtRead6, frmMeterReading.txtRead7, frmMeterReading.txtRead8, frmMeterReading.txtRead9, frmMeterReading.txtRead10, frmMeterReading.txtRead11, frmMeterReading.txtRead12, frmMeterReading.txtRead13, frmMeterReading.txtRead14, frmMeterReading.txtRead15, frmMeterReading.txtRead16, frmMeterReading.txtRead17, frmMeterReading.txtRead18, frmMeterReading.txtRead19, frmMeterReading.txtRead20}
    Public lblSeq() As Label = {frmMeterReading.lblseq1, frmMeterReading.lblseq2, frmMeterReading.lblseq3, frmMeterReading.lblseq4, frmMeterReading.lblseq5, frmMeterReading.lblseq6, frmMeterReading.lblseq7, frmMeterReading.lblseq8, frmMeterReading.lblseq9, frmMeterReading.lblseq10, frmMeterReading.lblseq11, frmMeterReading.lblseq12, frmMeterReading.lblseq13, frmMeterReading.lblseq14, frmMeterReading.lblseq15, frmMeterReading.lblseq16, frmMeterReading.lblseq17, frmMeterReading.lblseq18, frmMeterReading.lblseq19, frmMeterReading.lblseq20}
    Public lblName() As Label = {frmMeterReading.lblName1, frmMeterReading.lblName2, frmMeterReading.lblName3, frmMeterReading.lblName4, frmMeterReading.lblName5, frmMeterReading.lblName6, frmMeterReading.lblName7, frmMeterReading.lblName8, frmMeterReading.lblName9, frmMeterReading.lblName10, frmMeterReading.lblName11, frmMeterReading.lblName12, frmMeterReading.lblName13, frmMeterReading.lblName14, frmMeterReading.lblName15, frmMeterReading.lblName16, frmMeterReading.lblName17, frmMeterReading.lblName18, frmMeterReading.lblName19, frmMeterReading.lblName20}
    Public lblAcc() As Label = {frmMeterReading.lblAcc1, frmMeterReading.lblAcc2, frmMeterReading.lblAcc3, frmMeterReading.lblAcc4, frmMeterReading.lblAcc5, frmMeterReading.lblAcc6, frmMeterReading.lblAcc7, frmMeterReading.lblAcc8, frmMeterReading.lblAcc9, frmMeterReading.lblAcc10, frmMeterReading.lblAcc11, frmMeterReading.lblAcc12, frmMeterReading.lblAcc13, frmMeterReading.lblAcc14, frmMeterReading.lblAcc15, frmMeterReading.lblAcc16, frmMeterReading.lblAcc17, frmMeterReading.lblAcc18, frmMeterReading.lblAcc19, frmMeterReading.lblAcc20}
    Public lblClass() As Label = {frmMeterReading.lblClass1, frmMeterReading.lblClass2, frmMeterReading.lblClass3, frmMeterReading.lblClass4, frmMeterReading.lblClass5, frmMeterReading.lblClass6, frmMeterReading.lblClass7, frmMeterReading.lblClass8, frmMeterReading.lblClass9, frmMeterReading.lblClass10, frmMeterReading.lblClass11, frmMeterReading.lblClass12, frmMeterReading.lblClass13, frmMeterReading.lblClass14, frmMeterReading.lblClass15, frmMeterReading.lblClass16, frmMeterReading.lblClass17, frmMeterReading.lblClass18, frmMeterReading.lblClass19, frmMeterReading.lblClass20}
    Public lblCid() As Label = {frmMeterReading.lblcid1, frmMeterReading.lblcid2, frmMeterReading.lblcid3, frmMeterReading.lblcid4, frmMeterReading.lblcid5, frmMeterReading.lblcid6, frmMeterReading.lblcid7, frmMeterReading.lblcid8, frmMeterReading.lblcid9, frmMeterReading.lblcid10, frmMeterReading.lblcid11, frmMeterReading.lblcid12, frmMeterReading.lblcid13, frmMeterReading.lblcid14, frmMeterReading.lblcid15, frmMeterReading.lblcid16, frmMeterReading.lblcid17, frmMeterReading.lblcid18, frmMeterReading.lblcid19, frmMeterReading.lblcid20}
    Public lblPrevRead() As Label = {frmMeterReading.lblPrevRead1, frmMeterReading.lblPrevRead2, frmMeterReading.lblPrevRead3, frmMeterReading.lblPrevRead4, frmMeterReading.lblPrevRead5, frmMeterReading.lblPrevRead6, frmMeterReading.lblPrevRead7, frmMeterReading.lblPrevRead8, frmMeterReading.lblPrevRead9, frmMeterReading.lblPrevRead10, frmMeterReading.lblPrevRead11, frmMeterReading.lblPrevRead12, frmMeterReading.lblPrevRead13, frmMeterReading.lblPrevRead14, frmMeterReading.lblPrevRead15, frmMeterReading.lblPrevRead16, frmMeterReading.lblPrevRead17, frmMeterReading.lblPrevRead18, frmMeterReading.lblPrevRead19, frmMeterReading.lblPrevRead20}
    Public lblMet() As Label = {frmMeterReading.lblMet1, frmMeterReading.lblMet2, frmMeterReading.lblMet3, frmMeterReading.lblMet4, frmMeterReading.lblMet5, frmMeterReading.lblMet6, frmMeterReading.lblMet7, frmMeterReading.lblMet8, frmMeterReading.lblMet9, frmMeterReading.lblMet10, frmMeterReading.lblMet11, frmMeterReading.lblMet12, frmMeterReading.lblMet13, frmMeterReading.lblMet14, frmMeterReading.lblMet15, frmMeterReading.lblMet16, frmMeterReading.lblMet17, frmMeterReading.lblMet18, frmMeterReading.lblMet19, frmMeterReading.lblMet20}
    Public lblAmount() As Label = {frmMeterReading.lblAmount1, frmMeterReading.lblAmount2, frmMeterReading.lblAmount3, frmMeterReading.lblAmount4, frmMeterReading.lblAmount5, frmMeterReading.lblAmount6, frmMeterReading.lblAmount7, frmMeterReading.lblAmount8, frmMeterReading.lblAmount9, frmMeterReading.lblAmount10, frmMeterReading.lblAmount11, frmMeterReading.lblAmount12, frmMeterReading.lblAmount13, frmMeterReading.lblAmount14, frmMeterReading.lblAmount15, frmMeterReading.lblAmount16, frmMeterReading.lblAmount17, frmMeterReading.lblAmount18, frmMeterReading.lblAmount19, frmMeterReading.lblAmount20}
    Public lblPrevBal() As Label = {frmMeterReading.lblprevbal1, frmMeterReading.lblprevbal2, frmMeterReading.lblprevbal3, frmMeterReading.lblprevbal4, frmMeterReading.lblprevbal5, frmMeterReading.lblprevbal6, frmMeterReading.lblprevbal7, frmMeterReading.lblprevbal8, frmMeterReading.lblprevbal9, frmMeterReading.lblprevbal10, frmMeterReading.lblprevbal11, frmMeterReading.lblprevbal12, frmMeterReading.lblprevbal13, frmMeterReading.lblprevbal14, frmMeterReading.lblprevbal15, frmMeterReading.lblprevbal16, frmMeterReading.lblprevbal17, frmMeterReading.lblprevbal18, frmMeterReading.lblprevbal19, frmMeterReading.lblprevbal20}
    Public lblTotAmount() As Label = {frmMeterReading.lbltotamount1, frmMeterReading.lbltotamount2, frmMeterReading.lbltotamount3, frmMeterReading.lbltotamount4, frmMeterReading.lbltotamount5, frmMeterReading.lbltotamount6, frmMeterReading.lbltotamount7, frmMeterReading.lbltotamount8, frmMeterReading.lbltotamount9, frmMeterReading.lbltotamount10, frmMeterReading.lbltotamount11, frmMeterReading.lbltotamount12, frmMeterReading.lbltotamount13, frmMeterReading.lbltotamount14, frmMeterReading.lbltotamount15, frmMeterReading.lbltotamount16, frmMeterReading.lbltotamount17, frmMeterReading.lbltotamount18, frmMeterReading.lbltotamount19, frmMeterReading.lbltotamount20}
    Public lblAmountDue() As Label = {frmMeterReading.lblamountdue1, frmMeterReading.lblamountdue2, frmMeterReading.lblamountdue3, frmMeterReading.lblamountdue4, frmMeterReading.lblamountdue5, frmMeterReading.lblamountdue6, frmMeterReading.lblamountdue7, frmMeterReading.lblamountdue8, frmMeterReading.lblamountdue9, frmMeterReading.lblamountdue10, frmMeterReading.lblamountdue11, frmMeterReading.lblamountdue12, frmMeterReading.lblamountdue13, frmMeterReading.lblamountdue14, frmMeterReading.lblamountdue15, frmMeterReading.lblamountdue16, frmMeterReading.lblamountdue17, frmMeterReading.lblamountdue18, frmMeterReading.lblamountdue19, frmMeterReading.lblamountdue20}
    'Public lblAdj() As Label = {frmMeterReading.lblAdj1, frmMeterReading.lblAdj2, frmMeterReading.lblAdj3, frmMeterReading.lblAdj4, frmMeterReading.lblAdj5, frmMeterReading.lblAdj6, frmMeterReading.lblAdj7, frmMeterReading.lblAdj8, frmMeterReading.lblAdj9, frmMeterReading.lblAdj10, frmMeterReading.lblAdj11, frmMeterReading.lblAdj12, frmMeterReading.lblAdj13, frmMeterReading.lblAdj14, frmMeterReading.lblAdj15, frmMeterReading.lblAdj16, frmMeterReading.lblAdj17, frmMeterReading.lblAdj18, frmMeterReading.lblAdj19, frmMeterReading.lblAdj20}
    'Public lblAdjAmt() As Label = {frmMeterReading.lblAdjAmt1, frmMeterReading.lblAdjAmt2, frmMeterReading.lblAdjAmt3, frmMeterReading.lblAdjAmt4, frmMeterReading.lblAdjAmt5, frmMeterReading.lblAdjAmt6, frmMeterReading.lblAdjAmt7, frmMeterReading.lblAdjAmt8, frmMeterReading.lblAdjAmt9, frmMeterReading.lblAdjAmt10, frmMeterReading.lblAdjAmt11, frmMeterReading.lblAdjAmt12, frmMeterReading.lblAdjAmt13, frmMeterReading.lblAdjAmt14, frmMeterReading.lblAdjAmt15, frmMeterReading.lblAdjAmt16, frmMeterReading.lblAdjAmt17, frmMeterReading.lblAdjAmt18, frmMeterReading.lblAdjAmt19, frmMeterReading.lblAdjAmt20}
    Public lblEF() As Label = {frmMeterReading.lblEF1, frmMeterReading.lblEF2, frmMeterReading.lblEF3, frmMeterReading.lblEF4, frmMeterReading.lblEF5, frmMeterReading.lblEF6, frmMeterReading.lblEF7, frmMeterReading.lblEF8, frmMeterReading.lblEF9, frmMeterReading.lblEF10, frmMeterReading.lblEF11, frmMeterReading.lblEF12, frmMeterReading.lblEF13, frmMeterReading.lblEF14, frmMeterReading.lblEF15, frmMeterReading.lblEF16, frmMeterReading.lblEF17, frmMeterReading.lblEF18, frmMeterReading.lblEF19, frmMeterReading.lblEF20}
    Public lblSCDis() As Label = {frmMeterReading.lblSCDis1, frmMeterReading.lblSCDis2, frmMeterReading.lblSCDis3, frmMeterReading.lblSCDis4, frmMeterReading.lblSCDis5, frmMeterReading.lblSCDis6, frmMeterReading.lblSCDis7, frmMeterReading.lblSCDis8, frmMeterReading.lblSCDis9, frmMeterReading.lblSCDis10, frmMeterReading.lblSCDis11, frmMeterReading.lblSCDis12, frmMeterReading.lblSCDis13, frmMeterReading.lblSCDis14, frmMeterReading.lblSCDis15, frmMeterReading.lblSCDis16, frmMeterReading.lblSCDis17, frmMeterReading.lblSCDis18, frmMeterReading.lblSCDis19, frmMeterReading.lblSCDis20}
    Public lblSC() As Label = {frmMeterReading.lblSC1, frmMeterReading.lblSC2, frmMeterReading.lblSC3, frmMeterReading.lblSC4, frmMeterReading.lblSC5, frmMeterReading.lblSC6, frmMeterReading.lblSC7, frmMeterReading.lblSC8, frmMeterReading.lblSC9, frmMeterReading.lblSC10, frmMeterReading.lblSC11, frmMeterReading.lblSC12, frmMeterReading.lblSC13, frmMeterReading.lblSC14, frmMeterReading.lblSC15, frmMeterReading.lblSC16, frmMeterReading.lblSC17, frmMeterReading.lblSC18, frmMeterReading.lblSC19, frmMeterReading.lblSC20}
    Public lblPenalty() As Label = {frmMeterReading.lblPenalty1, frmMeterReading.lblPenalty2, frmMeterReading.lblPenalty3, frmMeterReading.lblPenalty4, frmMeterReading.lblPenalty5, frmMeterReading.lblPenalty6, frmMeterReading.lblPenalty7, frmMeterReading.lblPenalty8, frmMeterReading.lblPenalty9, frmMeterReading.lblPenalty10, frmMeterReading.lblPenalty11, frmMeterReading.lblPenalty12, frmMeterReading.lblPenalty13, frmMeterReading.lblPenalty14, frmMeterReading.lblPenalty15, frmMeterReading.lblPenalty16, frmMeterReading.lblPenalty17, frmMeterReading.lblPenalty18, frmMeterReading.lblPenalty19, frmMeterReading.lblPenalty20}
    'Public lblPrevIEnvi() As Label = {frmMeterReading.lblPrevEnvi1, frmMeterReading.lblPrevEnvi2, frmMeterReading.lblPrevEnvi3, frmMeterReading.lblPrevEnvi4, frmMeterReading.lblPrevEnvi5, frmMeterReading.lblPrevEnvi6, frmMeterReading.lblPrevEnvi7, frmMeterReading.lblPrevEnvi8, frmMeterReading.lblPrevEnvi9, frmMeterReading.lblPrevEnvi10, frmMeterReading.lblPrevEnvi11, frmMeterReading.lblPrevEnvi12, frmMeterReading.lblPrevEnvi13, frmMeterReading.lblPrevEnvi14, frmMeterReading.lblPrevEnvi15, frmMeterReading.lblPrevEnvi16, frmMeterReading.lblPrevEnvi17, frmMeterReading.lblPrevEnvi18, frmMeterReading.lblPrevEnvi19, frmMeterReading.lblPrevEnvi20}
    'Public lblBR() As Label = {frmMeterReading.lblBR1, frmMeterReading.lblBR2, frmMeterReading.lblBR3, frmMeterReading.lblBR4, frmMeterReading.lblBR5, frmMeterReading.lblBR6, frmMeterReading.lblBR7, frmMeterReading.lblBR8, frmMeterReading.lblBR9, frmMeterReading.lblBR10, frmMeterReading.lblBR11, frmMeterReading.lblBR12, frmMeterReading.lblBR13, frmMeterReading.lblBR14, frmMeterReading.lblBR15, frmMeterReading.lblBR16, frmMeterReading.lblBR17, frmMeterReading.lblBR18, frmMeterReading.lblBR19, frmMeterReading.lblBR20}
    Public chkEx() As CheckBox = {frmMeterReading.chkEx1, frmMeterReading.chkEx2, frmMeterReading.chkEx3, frmMeterReading.chkEx4, frmMeterReading.chkEx5, frmMeterReading.chkEx6, frmMeterReading.chkEx7, frmMeterReading.chkEx8, frmMeterReading.chkEx9, frmMeterReading.chkEx10, frmMeterReading.chkEx11, frmMeterReading.chkEx12, frmMeterReading.chkEx13, frmMeterReading.chkEx14, frmMeterReading.chkEx15, frmMeterReading.chkEx16, frmMeterReading.chkEx17, frmMeterReading.chkEx18, frmMeterReading.chkEx19, frmMeterReading.chkEx20}
    Public lblAppFee() As Label = {frmMeterReading.lblAppFee1, frmMeterReading.lblAppFee2, frmMeterReading.lblAppFee3, frmMeterReading.lblAppFee4, frmMeterReading.lblAppFee5, frmMeterReading.lblAppFee6, frmMeterReading.lblAppFee7, frmMeterReading.lblAppFee8, frmMeterReading.lblAppFee9, frmMeterReading.lblAppFee10, frmMeterReading.lblAppFee11, frmMeterReading.lblAppFee12, frmMeterReading.lblAppFee13, frmMeterReading.lblAppFee14, frmMeterReading.lblAppFee15, frmMeterReading.lblAppFee16, frmMeterReading.lblAppFee17, frmMeterReading.lblAppFee18, frmMeterReading.lblAppFee19, frmMeterReading.lblAppFee20}
    Public chkAmt() As CheckBox = {frmApplicationBalance.chkInitial, frmApplicationBalance.chk1, frmApplicationBalance.chk2, frmApplicationBalance.chk3, frmApplicationBalance.chk4, frmApplicationBalance.chk5, frmApplicationBalance.chk6, frmApplicationBalance.chk7, frmApplicationBalance.chk8, frmApplicationBalance.chk9, frmApplicationBalance.chk10, frmApplicationBalance.chk11, frmApplicationBalance.chk12}
    Public lblCurrentBill() As Label = {frmMeterReading.lblCurBill1, frmMeterReading.lblCurBill2, frmMeterReading.lblCurBill3, frmMeterReading.lblCurBill4, frmMeterReading.lblCurBill5, frmMeterReading.lblCurBill6, frmMeterReading.lblCurBill7, frmMeterReading.lblCurBill8, frmMeterReading.lblCurBill9, frmMeterReading.lblCurBill10, frmMeterReading.lblCurBill11, frmMeterReading.lblCurBill12, frmMeterReading.lblCurBill13, frmMeterReading.lblCurBill14, frmMeterReading.lblCurBill15, frmMeterReading.lblCurBill16, frmMeterReading.lblCurBill17, frmMeterReading.lblCurBill18, frmMeterReading.lblCurBill19, frmMeterReading.lblCurBill20}

    Public applicationFeePaidAmount As Decimal
    Public AppFeeAmt() As Decimal
    Public applicationAcctID As Integer

    Public InstallmentCount As Integer
    Public selectedChangeClassID As Integer
    Public arrChangeClassID() As Integer
    Public accountListIndex As Integer

    Public acctTempCloseID As Integer

    Public scbrgyID() As Integer
    Public scAddBrgy() As String
    Public sczoneID() As Integer
    Public scPlantName() As String
    Public scTotalAccounts() As Integer
    Public scActiveTotal() As Integer
    Public scActiveInstalled() As Integer
    Public scActiveReconnected() As Integer
    Public scActiveDirect() As Integer
    Public scUninstalledTotal() As Integer
    Public scUninstalledBacklog() As Integer
    Public scUninstalledNew() As Integer
    Public scDisTotal() As Integer
    Public scDisNonPay() As Integer
    Public scDisVoluntary() As Integer
    Public scTotalRes() As Integer
    Public scTotalIns() As Integer
    Public scTotalCom() As Integer
    Public scTotalInd() As Integer
    Public scactiveRes() As Integer
    Public scactiveIns() As Integer
    Public scactiveCom() As Integer
    Public scactiveInd() As Integer
    Public scRegular() As Integer
    Public scSenior() As Integer
    Public scMonth() As String
    Public scYear() As Integer

    Public ccManBill() As Integer
    Public selCCManBill As Integer
    Public Sub ViewProvListSettings()
        Cons()
        frmAddressList.lvwProv.Items.Clear()
        frmAddressList.lvwMun.Items.Clear()
        frmAddressList.lvwBrgy.Items.Clear()
        frmAddressList.lvwZone.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                Dim seeDef As Integer = Val(dt.Rows(x).Item(2).ToString)
                If seeDef = 1 Then
                    lst.Text = "Yes"
                Else
                    lst.Text = ""
                End If
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                frmAddressList.lvwProv.Items.Add(lst)
            Next
            'frmAddressList.lvwProv.Items(indexOfDefault).Focused = True
            'frmAddressList.lvwProv.Items(indexOfDefault).Selected = True
        End If
    End Sub
    Public Sub ViewMunListSettings(index As Integer)
        Cons()
        frmAddressList.lvwMun.Items.Clear()
        frmAddressList.lvwZone.Items.Clear()
        frmAddressList.lvwBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                Dim seeDef As Integer = Val(dt.Rows(x).Item(3).ToString)
                If seeDef = 1 Then
                    lst.Text = "Yes"
                Else
                    lst.Text = ""
                End If
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                frmAddressList.lvwMun.Items.Add(lst)
            Next
        End If
    End Sub
    Public Sub ViewZoneSettings(index As Integer)
        Cons()
        frmAddressList.lvwZone.Items.Clear()
        frmAddressList.lvwBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE addmunid=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrZoneID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(4).ToString
                frmAddressList.lvwZone.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ViewBrgySettings(index As Integer)
        Cons()
        frmAddressList.lvwBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneID=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBrgyID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(2).ToString
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                frmAddressList.lvwBrgy.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ViewClusterSettings(index As Integer)
        Cons()
        frmAddressList.lvwCluster.Items.Clear()
        frmAddressList.btnEditCluster.Enabled = False
        frmAddressList.btnDeleteCluster.Enabled = False
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrClusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrClusterID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(2).ToString
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                frmAddressList.lvwCluster.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ComboMunList(index As Integer)
        Cons()
        frmNewApplicant.cboMun.Items.Clear()
        frmNewCustomer.cboMun.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrComMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrComMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmNewApplicant.cboMun.Items.Add(dt.Rows(x).Item(2).ToString)
                frmNewCustomer.cboMun.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub
    Public Sub ComboBrgyList(index As Integer)
        Cons()
        frmNewApplicant.cboBrgy.Items.Clear()
        frmNewCustomer.cboBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE addmunid=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrComBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrComBrgyID(x) = dt.Rows(x).Item(0)
                frmNewApplicant.cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
                frmNewCustomer.cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub MeterReadingViewer()

    End Sub

    Public Sub LoadCustomerList()
        frmCustomers.lvwCustomerList.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM customerlist AS C Left Join brgylist AS B ON C.brgyid=B.brgyid LEFT JOIN classifications AS Cl ON C.classification=Cl.classID", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCustID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrCustID(x) = dt.Rows(x).Item(0)
                Try
                    lst.Text = Format(dt.Rows(x).Item(12), "MM-dd-yyyy")
                Catch ex As Exception
                End Try
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString & " " & Mid(dt.Rows(x).Item(2).ToString, 1, 1) & " " & dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(15).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(18).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(10).ToString)
                lst.SubItems.Add("")
                lst.SubItems.Add(dt.Rows(x).Item(11).ToString)
                frmCustomers.lvwCustomerList.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub BrowseCustomerList()
        Cons()
        frmBrowseCustomer.lvwCustomer.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                frmBrowseCustomer.lvwCustomer.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub CustomerList(ByVal bgyID As Integer, sname As String)
        Cons()
        frmCustomers.lvwCustomerList.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblCustomer WHERE brgyid=" & bgyID & " and (fname like '%" & sname & "%' or mname like '%" & sname & "%' or lname like '%" & sname & "%')", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCusID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrCusID(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString & " " & Mid(dt.Rows(x).Item(2).ToString, 1, 1) & ". " & dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                frmCustomers.lvwCustomerList.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ComboProvCustomers()
        Cons()
        frmCustomers.cboProv.Items.Clear()
        frmCustomers.cboBrgy.Items.Clear()
        frmCustomers.cboMun.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCusProvID(dt.Rows.Count - 1)
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrCusProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmCustomers.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
            frmCustomers.cboProv.SelectedIndex = indexOfDefault
        End If
    End Sub
    Public Sub ComboMunCustomers(ByVal cusProvID As Integer)
        Cons()
        frmCustomers.cboMun.Items.Clear()
        frmCustomers.cboBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & cusProvID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCusMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrCusMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmCustomers.cboMun.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub comboBrgyCustomers(ByVal cusmunID As Integer)
        Cons()
        frmCustomers.cboBrgy.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE addmunid=" & cusmunID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCusBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrCusBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmCustomers.cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub classificationList()
        Cons()
        frmClassifications.lvwClass.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("Select * From classifications", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            classListCount = dt.Rows.Count - 1
            ReDim arrClassSetID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrClassSetID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                frmClassifications.lvwClass.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub classRate(ByVal cID As Integer)
        Cons()
        frmViewClassRate.lvwRates.Items.Clear()
        Dim dtC As New DataTable
        Dim daC As New MySqlDataAdapter("SELECT * from classifications WHERE classid=" & cID, con)
        daC.Fill(dtC)
        If dtC.Rows.Count > 0 Then
            frmViewClassRate.lblClassName.Text = dtC.Rows(0).Item(1).ToString
            frmViewClassRate.lblClassCode.Text = dtC.Rows(0).Item(2).ToString
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select * From tblclassrates WHERE classID=" & cID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmViewClassRate.lvwRates.Items.Clear()
                ReDim arrViewClassRateID(dt.Rows.Count - 1)
                Dim totCount As Integer = dt.Rows.Count - 1
                For x As Integer = 0 To dt.Rows.Count - 1
                    arrViewClassRateID(x) = Val(dt.Rows(x).Item(0).ToString)
                    Dim lst As New ListViewItem
                    Dim y As Integer = Val(dt.Rows(x).Item(3).ToString)
                    If y = 1 Then
                        cubitLabel = "1 to " & Val(dt.Rows(x).Item(4).ToString)
                    ElseIf y = 0 Then
                        If x = totCount Then
                            nextCubit = " > "
                        Else
                            Dim z As Integer = Val(dt.Rows(x + 1).Item(4).ToString)
                            Dim compz As Integer = z - 1
                            nextCubit = " to " & compz
                        End If
                        cubitLabel = Val(dt.Rows(x).Item(4).ToString) & nextCubit
                    End If
                    lst.Text = cubitLabel
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(2).ToString), "0.#0"))
                    frmViewClassRate.lvwRates.Items.Add(lst)
                Next
            End If
        End If
    End Sub

    Public Sub tempClassRate()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("Select * From tempclassrate", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            frmRateValues.lvwCubits.Items.Clear()
            ReDim tempArrRateID(dt.Rows.Count - 1)
            Dim totCount As Integer = dt.Rows.Count - 1
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                Dim y As Integer = Val(dt.Rows(x).Item(2).ToString)
                If y = 1 Then
                    cubitLabel = "1 to " & Val(dt.Rows(x).Item(3).ToString)
                ElseIf y = 0 Then
                    If x = totCount Then
                        nextCubit = " > "
                    Else
                        Dim z As Integer = Val(dt.Rows(x + 1).Item(3).ToString)
                        Dim compz As Integer = z - 1
                        nextCubit = " to " & compz
                    End If
                    cubitLabel = Val(dt.Rows(x).Item(3).ToString) & nextCubit
                End If
                lastCub = Val(dt.Rows(x).Item(3).ToString)
                tempArrRateID(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = cubitLabel
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(1).ToString), "0.#0"))
                frmRateValues.lvwCubits.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ViewConsumerList(ByVal sear As String)
        Cons()
        'Dim dt As New DataTable
        ConsumerDatatable = New DataTable
        ConsumerDatatable.Clear()
        Dim da As New MySqlDataAdapter("SELECT Count(A.acctID), C.consID, C.consumername FROM consumerlist AS C LEFT JOIN consumerAccounts AS A ON C.consID=A.consID WHERE C.consumername LIKE '%" & sear & "%' GROUP BY C.consID ORDER BY C.consumername", con)
        da.Fill(ConsumerDatatable)
        frmConsumerList.lvwConsumerList.Items.Clear()
        frmConsumerList.lvwAccountList.Items.Clear()
        If ConsumerDatatable.Rows.Count > 0 Then
            totalConsumerCount = ConsumerDatatable.Rows.Count
            'MessageBox.Show("SHOW ME")
            totalConsumerPage = (totalConsumerCount \ 100) + 1
            lastItemsCOunt = totalConsumerCount Mod 100
            ReDim arrConsumerID(ConsumerDatatable.Rows.Count - 1)
            For x As Integer = 0 To ConsumerDatatable.Rows.Count - 1
                arrConsumerID(x) = Val(ConsumerDatatable.Rows(x).Item(1).ToString)
            Next
            ViewConsumerPage(curPageNumConsumer)
        End If
    End Sub

    Public Sub ViewConsumerPage(i As Integer)
        frmConsumerList.lvwConsumerList.Items.Clear()
        frmConsumerList.lvwAccountList.Items.Clear()
        'ConsumerDatatable.Clear()
        Dim pNum As Integer = i + 1
        frmConsumerList.lblPage.Text = pNum & " of " & totalConsumerPage
        If pNum = totalConsumerPage Then
            For x As Integer = (0 + (i * 99)) To totalConsumerCount - 1
                Dim lst As New ListViewItem
                lst.Text = ConsumerDatatable.Rows(x).Item(2).ToString()
                lst.SubItems.Add(ConsumerDatatable.Rows(x).Item(0).ToString)
                lst.SubItems.Add(x + 1)
                frmConsumerList.lvwConsumerList.Items.Add(lst)
            Next
        Else
            For x As Integer = (0 + (i * 100)) To (99 + (i * 100))
                Dim lst As New ListViewItem
                lst.Text = ConsumerDatatable.Rows(x).Item(2).ToString()
                lst.SubItems.Add(ConsumerDatatable.Rows(x).Item(0).ToString)
                lst.SubItems.Add(x + 1)
                frmConsumerList.lvwConsumerList.Items.Add(lst)
            Next
        End If
        If i = 0 Then
            frmConsumerList.btnPrev.Enabled = False
        Else
            frmConsumerList.btnPrev.Enabled = True
        End If

        If i = totalConsumerPage - 1 Then
            frmConsumerList.btnNext.Enabled = False
        Else
            frmConsumerList.btnNext.Enabled = True
        End If
    End Sub



    Public Sub ViewAccountList()

        frmConsumerList.lvwAccountList.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, A.Sequence, S.StatusName, BR.addbrgy, CL.clusterName, A.AccountName, CF.classification  FROM consumeraccounts AS A LEFT JOIN accountstatus AS S ON AcctStatus=staID LEFT JOIN clusterlist AS CL ON A.clusterid=CL.clusterID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN classifications AS CF ON A.classid=CF.classid WHERE consID=" & selConsumerID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSelectedAcctID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim curBal As Double = 0
                arrSelectedAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                Dim strStat As String = dt.Rows(x).Item(3).ToString
                If strStat = "Connected" Then
                    lst.BackColor = Color.White
                ElseIf strStat = "Disconnected" Then
                    lst.BackColor = Color.Red
                ElseIf strStat = "Installation" Then
                    lst.BackColor = Color.Green
                ElseIf strStat = "Disconnection" Then
                    lst.BackColor = Color.Orange
                ElseIf strStat = "Meter Transfer" Then
                    lst.BackColor = Color.Yellow
                ElseIf strStat = "Name Transfer" Then
                    lst.BackColor = Color.Yellow
                ElseIf strStat = "Reconnection" Then
                    lst.BackColor = Color.Blue
                ElseIf strStat = "Temporary Close" Then
                    lst.BackColor = Color.Gray
                End If

                Dim dtBill As New DataTable
                Dim daBill As New MySqlDataAdapter("SELECT useAmount, useAdue, duedate FROM billing WHERE (billstat='UNPAID' OR billstat='LAPSE') AND acctID=" & arrSelectedAcctID(x), con)
                daBill.Fill(dtBill)
                If dtBill.Rows.Count > 0 Then
                    For y As Integer = 0 To dtBill.Rows.Count - 1
                        'Dim chkAdj As String = dtB.Rows(y).Item(4).ToString
                        Dim chkDue As Date = dtBill.Rows(y).Item(2)
                        Dim nowDate As Date = Now.Date
                        Dim ComputeDays As TimeSpan = chkDue - nowDate
                        Dim intDays As Integer = ComputeDays.Days
                        Dim selAmount As Double = 0
                        If intDays <= 0 Then
                            selAmount = Val(dtBill.Rows(y).Item(1).ToString)
                        Else
                            selAmount = Val(dtBill.Rows(y).Item(0).ToString)
                        End If
                        curBal = curBal + selAmount
                    Next
                End If
                lst.SubItems.Add(Format(curBal, "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                frmConsumerList.lvwAccountList.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ViewPendingList(ByVal Filter As String, ByVal acctNum As String)
        frmPendingList.lvwPendList.Items.Clear()
        Cons()
        sqlstrPendingItems = "SELECT A.acctID, A.AccountNO, C.ConsumerName, S.StatusName, A.StreetAddress, B.AddBrgy, C.contactNum FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN brgylist as B ON A.brgyID=B.brgyID LEFT JOIN accountstatus AS S ON A.AcctStatus=S.staID WHERE NOT (S.StatusName='Connected' OR S.StatusName='Disconnected' OR S.StatusName='Disabled' OR S.StatusName='Temporary Closed') AND S.StatusName LIKE '%" & Filter & "%' AND A.AccountNo LIKE '%" & acctNum & "%' ORDER BY acctstatus ASC"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlstrPendingItems, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrPendAcctID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrPendAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                frmPendingList.lvwPendList.Items.Add(lst)
            Next
        End If
        'PENDING LIST FOR BILL ADJUSTMENT REQUEST
        Dim dtB As New DataTable
        Dim daB As New MySqlDataAdapter("SELECT", con)
    End Sub

    Public Sub MeterReadList(ByVal bID As Integer, ByVal perFrom As String, ByVal perTo As String, perYear As String)
        Cons()
        MetReadForValsClear()
        Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, A.sequence, CL.ConsumerName, C.classification, A.classID, A.meterReference, A.consID, ifnull((SELECT SUM(dueamount) FROM meterreading WHERE acctID=A.AcctID AND (metstatus='UNPAID' or metStatus='LAPSE') GROUP BY acctID),0) AS prevAmount, (SELECT Mm.MetID FROM meterreading AS mM WHERE Mm.AcctID=A.AcctID AND  (mM.metstatus='UNPAID' or mM.metStatus='LAPSE') GROUP BY Mm.AcctID) AS mettID, (SELECT COUNT(*) FROM meterReading WHERE AcctID=A.AcctID AND (metstatus='LAPSE' OR metStatus ='UNPAID')) AS countAccount FROM consumeraccounts AS A LEFT JOIN consumerlist AS CL ON A.consID=CL.consID LEFT JOIN classifications AS C ON A.classID=C.classID LEFT JOIN meterreading AS M ON A.acctID=M.acctID WHERE A.brgyID=" & bID & " AND A.clusterID=" & clusterID & " AND A.AcctStatus=1 AND NOT (SELECT COUNT(*) FROM meterreading AS M WHERE M.AcctID=A.AcctID AND M.readperfrom ='" & perFrom & "' AND M.readperto='" & perTo & "' AND M.readperyear='" & perYear & "') >0 AND NOT (SELECT COUNT(*) FROM meterReading WHERE AcctID=A.AcctID AND (metstatus='LAPSE' OR metStatus ='UNPAID'))>=3 GROUP BY A.AccountNo ORDER BY SEQUENCE ASC", con)
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, A.sequence, A.accountName, C.classification, A.classID, A.meterReference, A.consID, ifnull((SELECT SUM(useAmount) FROM billing WHERE acctID=A.AcctID AND (billstat='UNPAID' or billstat='LAPSE')  GROUP BY acctID),0) AS prevAmount,ifnull((SELECT SUM(penalty) FROM billing WHERE acctID=A.AcctID AND (billstat='UNPAID' or billstat='LAPSE')  GROUP BY acctID),0) AS prevPenalty, (SELECT COUNT(*) FROM billing WHERE AcctID=A.AcctID AND (billstat='LAPSE' OR billstat='UNPAID')) AS countAccount, CL.isSC, ifnull((SELECT SUM(useAdue) FROM billing WHERE acctID=A.AcctID AND (billstat='UNPAID' or billstat='LAPSE') GROUP BY acctID),0) AS prevAfterDue, A.seniorID, ifnull((SELECT prevOutstanding FROM billing WHERE acctID=A.AcctID GROUP BY acctID),0) AS outstandBal, ifnull((SELECT prevOutPenalty FROM billing WHERE acctID=A.AcctID GROUP BY acctID),0) AS outstandPenalty, IF((SELECT remmonths FROM applicationfeetotalbalance WHERE acctID=A.acctID GROUP BY acctID) > 0, 240, 0) AS AppFee FROM consumeraccounts AS A LEFT JOIN consumerlist as CL ON A.consID=CL.consID LEFT JOIN classifications AS C ON A.classID=C.classID LEFT JOIN billing as B ON A.AcctID=B.acctID WHERE A.brgyID=" & bID & " AND A.AcctStatus=1 AND NOT (SELECT COUNT(*) FROM billing AS B WHERE B.AcctID=A.AcctID AND B.billmonth='" & perFrom & "' AND B.billyear=" & perYear & ") > 0 AND NOT (SELECT COUNT(*) FROM billing WHERE AcctID=A.AcctID AND (billstat='LAPSE' OR billstat='UNPAID'))>=99 GROUP BY A.AccountNo ORDER BY CL.ConsumerName ASC", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            accountCount = dt.Rows.Count
            countIndex = dt.Rows.Count - 1
            intDiv = accountCount \ 20
            intMod = accountCount Mod 20
            If intMod > 0 Then
                addPage = 1
            Else
                addPage = 0
            End If
            MetReadSelectedBrgyID = bID
            'MetReadSelectedCluster = clusterID
            ReDim arrTempAcctID(countIndex)
            ReDim arrTempAccountNum(countIndex)
            ReDim arrTempSeqNum(countIndex)
            ReDim arrTempConsName(countIndex)
            ReDim arrTempClassType(countIndex)
            ReDim arrTempClassID(countIndex)
            ReDim arrTempRef(countIndex)
            ReDim arrTempCurReading(countIndex)
            ReDim arrTempConsumed(countIndex)
            ReDim arrTempPartAmount(countIndex)
            ReDim arrTempPrevBalance(countIndex)
            ReDim arrTempTotalAmount(countIndex)
            ReDim arrTempAmountDue(countIndex)
            ReDim arrTempConsumerID(countIndex)
            ReDim arrTempPrevMetID(countIndex)
            ReDim arrUnpaidCount(countIndex)
            ReDim strSenior(countIndex)
            ReDim senID(countIndex)
            ReDim prevEnviFee(countIndex)
            ReDim arrPrevSCDis(countIndex)
            ReDim chkBoolExemp(countIndex)
            ReDim arrTempAppFee(countIndex)

            ReDim arrFConsump(countIndex)
            ReDim arrFExcess(countIndex)
            ReDim arrFLabel(countIndex)
            ReDim arrSConsump(countIndex)
            ReDim arrSExcess(countIndex)
            ReDim arrSLabel(countIndex)
            ReDim arrFAmtPerCub(countIndex)
            ReDim arrSAmtPerCub(countIndex)

            ReDim arrPrevConsump(countIndex)
            ReDim arrPrevEnv(countIndex)
            ReDim arrPrevAdj(countIndex)
            ReDim arrPrevAdjRate(countIndex)
            ReDim arrPrevPenalty(countIndex)
            ReDim arrPrevAmountDue(countIndex)
            ReDim arrPrevTotal(countIndex)
            ReDim arrMinCons(countIndex)
            ReDim arrFcubCons(countIndex)
            ReDim arrScubCons(countIndex)

            ReDim billOutstandBal(countIndex)
            ReDim billOutstandEF(countIndex)
            ReDim billOutstandPenalty(countIndex)
            ReDim billOutstandTotal(countIndex)
            ReDim billOutstandAdjustedRate(countIndex)
            ReDim billOutstandDiscount(countIndex)
            ReDim arrBillPrevDIscount(countIndex)
            ConsCount(countIndex)
            pageCount = intDiv + addPage
            For x As Integer = 0 To countIndex
                arrTempAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrTempSeqNum(x) = Val(dt.Rows(x).Item(2).ToString)
                arrTempAccountNum(x) = dt.Rows(x).Item(1).ToString
                arrTempConsName(x) = dt.Rows(x).Item(3).ToString
                arrTempClassType(x) = dt.Rows(x).Item(4).ToString
                arrTempClassID(x) = Val(dt.Rows(x).Item(5).ToString)
                arrTempRef(x) = Val(dt.Rows(x).Item(6).ToString)
                arrTempCurReading(x) = Val(dt.Rows(x).Item(6).ToString)
                arrTempPartAmount(x) = 0
                arrTempPrevBalance(x) = Val(dt.Rows(x).Item(12).ToString) + Val(dt.Rows(x).Item(14).ToString)
                arrTempTotalAmount(x) = 0
                arrTempAmountDue(x) = 0
                arrTempConsumerID(x) = Val(dt.Rows(x).Item(7).ToString)
                arrTempAppFee(x) = Val(dt.Rows(x).Item(16).ToString)
                arrUnpaidCount(x) = Val(dt.Rows(x).Item(10).ToString)
                strSenior(x) = dt.Rows(x).Item(11).ToString
                senID(x) = dt.Rows(x).Item(13).ToString
                chkBoolExemp(x) = False
                arrPrevPenalty(x) = Val(dt.Rows(x).Item(9).ToString)
                arrPrevAmountDue(x) = Val(dt.Rows(x).Item(8).ToString)
                arrPrevTotal(x) = Val(dt.Rows(x).Item(12).ToString)
                billOutstandBal(x) = Val(dt.Rows(x).Item(14).ToString) - Val(dt.Rows(x).Item(15).ToString)
                billOutstandPenalty(x) = Val(dt.Rows(x).Item(15).ToString)
                billOutstandTotal(x) = Val(dt.Rows(x).Item(14).ToString)
                metComputation(x, arrTempConsumed(x), arrTempPartAmount(x), strSenior(x), arrTempPrevBalance(x))
                FirstRead(x)
            Next
            curPage = 1
            MeterPage(1)
        Else
            MeterPage(0)
        End If
    End Sub

    Public Sub FirstRead(i As Integer)
        Try
            Dim curIndex As Integer = i
            arrTempConsumed(curIndex) = 0
            arrTempPartAmount(curIndex) = DirectRate(Val(arrTempConsumed(curIndex)), arrTempClassID(curIndex), 2)
            metComputation(curIndex, arrTempConsumed(curIndex), arrTempPartAmount(curIndex), strSenior(curIndex), arrTempPrevBalance(curIndex))

            arrTempTotalAmount(curIndex) = arrTempPrevBalance(curIndex) + arrTempPartAmount(curIndex)
            arrTempAmountDue(curIndex) = getDueAmount(arrTempTotalAmount(curIndex), arrTempPrevBalance(curIndex))
            ConsumptionExcessLabel(curIndex, arrTempConsumed(curIndex))
        Catch ex As Exception

        End Try
    End Sub

    Public Sub txtReadValues(i As Integer)

        Dim curIndex As Integer = ((curPage - 1) * 20) + i
        arrTempCurReading(curIndex) = Val(textRead(i).Text)
        arrTempConsumed(curIndex) = Val(textRead(i).Text) - Val(lblPrevRead(i).Text)
        arrTempPartAmount(curIndex) = DirectRate(Val(arrTempConsumed(curIndex)), Val(lblCid(i).Text), 2)
        metComputation(curIndex, arrTempConsumed(curIndex), arrTempPartAmount(curIndex), strSenior(curIndex), arrTempPrevBalance(curIndex))
        lblAmount(i).Text = Format(arrTempPartAmount(curIndex) - Val(metEF(curIndex)), "#,##0.#0")
        'arrTempPrevBalance(curIndex) = Format(arrPrevBal(curIndex) + Val(billOutstandTotal(curIndex)))
        lblPrevBal(i).Text = Format(arrTempPrevBalance(curIndex), "#,##0.#0") 'DONE
        arrTempTotalAmount(curIndex) = arrTempPrevBalance(curIndex) + arrTempPartAmount(curIndex)
        lblTotAmount(i).Text = Format((arrTempPartAmount(curIndex) - metSC(curIndex) + arrTempPrevBalance(curIndex) + arrTempAppFee(curIndex)), "#,##0.#0")
        arrTempAmountDue(curIndex) = getDueAmount(arrTempTotalAmount(curIndex), arrTempPrevBalance(curIndex))
        lblAmountDue(i).Text = Format((arrTempPartAmount(curIndex) - metSC(curIndex) + arrTempPrevBalance(curIndex) + metP(curIndex) + arrTempAppFee(curIndex)), "#,##0.#0")
        lblPenalty(i).Text = Format(metP(curIndex), "#,##0.#0")
        lblCurrentBill(i).Text = Format(arrTempPartAmount(curIndex), "#,##0.#0")
        'lblAdj(i).Text = Format(metAdj(curIndex), "#,##0.#0")
        'lblAdjAmt(i).Text = Format(metAR(curIndex), "#,##0.#0")
        'MessageBox.Show(metEF(curIndex))
        lblEF(i).Text = Format(metEF(curIndex), "#,##0.#0")
        lblSCDis(i).Text = Format(metSC(curIndex), "#,##0.#0")
        'lblBR(i).Text = Format(metNR(curIndex), "#,##0.#0")
        chkBoolExemp(curIndex) = chkEx(i).CheckState
        'MessageBox.Show(metSCTot(i))
        'MessageBox.Show(textRead(i).Text)
        'MessageBox.Show(arrTempConsumed(curIndex).ToString())
        ConsumptionExcessLabel(curIndex, arrTempConsumed(curIndex))

    End Sub
    Public Sub MeterPage(ByVal pageNum As Integer)
        'MetReadForValsClear()
        'MetReadEnabler()
        frmMeterReading.lblPage.Text = pageNum & " | " & pageCount
        If pageNum = pageCount Then
            frmMeterReading.btnNext.Enabled = False
        Else
            frmMeterReading.btnNext.Enabled = True
        End If
        If pageNum = 1 Then
            frmMeterReading.btnBack.Enabled = False
        Else
            frmMeterReading.btnBack.Enabled = True
        End If
        RowMake(pageNum)

    End Sub


    Public Sub RowMake(pageNum As Integer)
        Dim curIndex As Integer = ((pageNum - 1) * 20)
        If curIndex >= 0 Then
            For x As Integer = 0 To 19
                Dim iCOunt As Integer = curIndex + x
                If iCOunt <= accountCount - 1 Then

                    textRead(x).Text = arrTempCurReading(curIndex + x)
                    arrTextRead(0) = arrTempCurReading(curIndex + x)
                    lblSeq(x).Text = arrTempSeqNum(curIndex + x)
                    lblName(x).Text = arrTempConsName(curIndex + x)
                    lblAcc(x).Text = arrTempAccountNum(curIndex + x)
                    lblClass(x).Text = arrTempClassType(curIndex + x)
                    lblCid(x).Text = arrTempClassID(curIndex + x)
                    lblPrevRead(x).Text = arrTempRef(curIndex + x)
                    lblMet(x).Text = arrTempConsumed(curIndex + x)
                    lblAmount(x).Text = Format(metAmt(curIndex + x) - metEF(curIndex + x), "#,##0.#0")
                    lblPrevBal(x).Text = Format(arrTempPrevBalance(curIndex + x), "#,##0.#0") 'DONE
                    lblTotAmount(x).Text = Format((arrTempPartAmount(curIndex + x) - metSC(curIndex + x) + arrTempPrevBalance(curIndex + x) + arrTempAppFee(curIndex + x)), "#,##0.#0")
                    lblAmountDue(x).Text = Format((arrTempPartAmount(curIndex + x) - metSC(curIndex + x) + arrTempPrevBalance(curIndex + x) + metP(curIndex + x) + arrTempAppFee(curIndex + x)), "#,##0.#0")
                    lblCurrentBill(x).Text = Format(arrTempPartAmount(curIndex + x), "#,##0.#0")
                    lblAppFee(x).Text = Format(arrTempAppFee(curIndex + x), "#,##0.#0")
                    'lblAdj(x).Text = Format(metAdj(curIndex + x), "#,##0.#0")
                    'lblAdjAmt(x).Text = Format(metAR(curIndex + x), "#,##0.#0")
                    lblEF(x).Text = Format(metEF(curIndex + x), "#,##0.#0")
                    lblSCDis(x).Text = Format(metSC(curIndex + x), "#,##0.#0")
                    lblSC(x).Text = strSenior(curIndex + x)
                    lblPenalty(x).Text = Format(metP(curIndex + x), "#,##0.#0")
                    'lblPrevIEnvi(x).Text = Format(prevEnviFee(curIndex + x) + billOutstandEF(curIndex + x), "#,##0.#0") 'DONE
                    'MessageBox.Show(metNR(curIndex + x).ToString())
                    'lblBR(x).Text = Format(metNR(curIndex + x), "#,##0.#0")
                    chkEx(x).Checked = chkBoolExemp(curIndex + x)
                    lblSeq(x).Visible = True
                    lblName(x).Visible = True
                    lblAcc(x).Visible = True
                    lblClass(x).Visible = True
                    lblCid(x).Visible = True
                    lblPrevRead(x).Visible = True
                    textRead(x).Visible = True
                    lblMet(x).Visible = True
                    lblAmount(x).Visible = True
                    lblPrevBal(x).Visible = True
                    lblTotAmount(x).Visible = True
                    lblAmountDue(x).Visible = True
                    lblAppFee(x).Visible = True
                    lblCurrentBill(x).Visible = True
                    'lblAdj(x).Visible = True
                    'lblAdjAmt(x).Visible = True
                    lblEF(x).Visible = True
                    lblSCDis(x).Visible = True
                    lblSC(x).Visible = True
                    lblPenalty(x).Visible = True
                    'lblPrevIEnvi(x).Visible = True
                    'lblBR(x).Visible = True
                    chkEx(x).Visible = True
                Else
                    lblSeq(x).Visible = False
                    lblName(x).Visible = False
                    lblAcc(x).Visible = False
                    lblClass(x).Visible = False
                    lblCid(x).Visible = False
                    lblPrevRead(x).Visible = False
                    textRead(x).Visible = False
                    lblMet(x).Visible = False
                    lblAmount(x).Visible = False
                    lblPrevBal(x).Visible = False
                    lblTotAmount(x).Visible = False
                    lblAmountDue(x).Visible = False
                    lblAppFee(x).Visible = False
                    lblCurrentBill(x).Visible = False
                    'lblAdj(x).Visible = False
                    'lblAdjAmt(x).Visible = False
                    lblEF(x).Visible = False
                    lblSCDis(x).Visible = False
                    lblSC(x).Visible = False
                    lblPenalty(x).Visible = False
                    'lblPrevIEnvi(x).Visible = False
                    'lblBR(x).Visible = False
                    chkEx(x).Visible = False
                End If

            Next
        End If
    End Sub

    Public Sub MetReadForValsClear()
        For x As Integer = 0 To 19
            lblSeq(x).Text = ""
            lblName(x).Text = ""
            lblAcc(x).Text = ""
            lblClass(x).Text = ""
            lblCid(x).Text = ""
            lblPrevRead(x).Text = ""
            textRead(x).Text = ""
            lblMet(x).Text = ""
            lblAmount(x).Text = ""
            lblPrevBal(x).Text = ""
            lblTotAmount(x).Text = ""
            lblAmountDue(x).Text = ""
            lblAppFee(x).Text = ""
            lblCurrentBill(x).Text = ""
            'lblAdj(x).Text = ""
            'lblAdjAmt(x).Text = ""
            lblEF(x).Text = ""
            lblSCDis(x).Text = ""
            lblSC(x).Text = ""
            lblPenalty(x).Text = ""
            'lblPrevIEnvi(x).Text = ""
            'lblBR(x).Text = ""
            chkEx(x).Checked = False
        Next
        With frmMeterReading


        End With
    End Sub

    Public Sub MetReadEnabler()


        With frmMeterReading
            'SEQUENCE
            .btnNext.Enabled = False
            .btnBack.Enabled = False
            .lblPage.Text = "0|0"
            For x As Integer = 0 To 19
                lblSeq(x).Visible = False
                lblName(x).Visible = False
                lblAcc(x).Visible = False
                lblClass(x).Visible = False
                lblCid(x).Visible = False
                lblPrevRead(x).Visible = False
                textRead(x).Visible = False
                lblMet(x).Visible = False
                lblAmount(x).Visible = False
                lblPrevBal(x).Visible = False
                lblTotAmount(x).Visible = False
                lblAmountDue(x).Visible = False
                lblCurrentBill(x).Visible = False
                lblAppFee(x).Visible = False
                'lblAdj(x).Visible = False
                'lblAdjAmt(x).Visible = False
                lblEF(x).Visible = False
                lblSCDis(x).Visible = False
                lblSC(x).Visible = False
                lblPenalty(x).Visible = False
                'lblPrevIEnvi(x).Visible = False
                'lblBR(x).Visible = False
                chkEx(x).Visible = False
            Next
        End With
    End Sub

    Public Sub NewReadProvList()
        Cons()
        NewReadingSelection.cboProvince.Items.Clear()
        NewReadingSelection.cboMunicipality.Items.Clear()
        NewReadingSelection.cboZone.Items.Clear()
        NewReadingSelection.cboBarangay.Items.Clear()
        NewReadingSelection.cboCluster.Items.Clear()

        NewReadingSelection.cboProvince.Text = ""
        NewReadingSelection.cboMunicipality.Text = ""
        NewReadingSelection.cboZone.Text = ""
        NewReadingSelection.cboBarangay.Text = ""
        NewReadingSelection.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrNewReadProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrNewReadProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                NewReadingSelection.cboProvince.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
            NewReadingSelection.cboProvince.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub NewReadMunList(i As Integer)
        NewReadingSelection.cboMunicipality.Items.Clear()
        NewReadingSelection.cboZone.Items.Clear()
        NewReadingSelection.cboBarangay.Items.Clear()
        NewReadingSelection.cboCluster.Items.Clear()
        NewReadingSelection.cboMunicipality.Text = ""
        NewReadingSelection.cboZone.Text = ""
        NewReadingSelection.cboBarangay.Text = ""
        NewReadingSelection.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getdefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrNewReadMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getdefault = Val(dt.Rows(x).Item(3).ToString)
                If getdefault = 1 Then
                    indexOfDefault = x
                End If
                arrNewReadMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                NewReadingSelection.cboMunicipality.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            NewReadingSelection.cboMunicipality.SelectedIndex = indexOfDefault
        End If

    End Sub

    Public Sub NewReadZoneList(i As Integer)
        NewReadingSelection.cboZone.Items.Clear()
        NewReadingSelection.cboBarangay.Items.Clear()
        NewReadingSelection.cboCluster.Items.Clear()
        NewReadingSelection.cboZone.Text = ""
        NewReadingSelection.cboBarangay.Text = ""
        NewReadingSelection.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE addmunid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrNewReadZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrNewReadZoneID(x) = Val(dt.Rows(x).Item(0).ToString)
                NewReadingSelection.cboZone.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub NewReadBrgyList(i As Integer)
        NewReadingSelection.cboBarangay.Items.Clear()
        NewReadingSelection.cboCluster.Items.Clear()
        NewReadingSelection.cboBarangay.Text = ""
        NewReadingSelection.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrNewReadBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrNewReadBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                NewReadingSelection.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub


    Public Sub NewReadClusterList(i As Integer)
        NewReadingSelection.cboCluster.Items.Clear()
        NewReadingSelection.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM ClusterList WHERE brgyid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            'ReDim arrNewReadCluster(dt.Rows.Count - 1)
            ReDim arrReadClusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                'arrNewReadBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrReadClusterID(x) = Val(dt.Rows(x).Item(0).ToString())
                NewReadingSelection.cboCluster.Items.Add(dt.Rows(x).Item(2).ToString())
            Next
        End If
    End Sub

    Public Sub SeqProvCombo()
        frmSequencing.cboProvince.Items.Clear()
        frmSequencing.cboMunicipality.Items.Clear()
        frmSequencing.cboZone.Items.Clear()
        frmSequencing.cboBarangay.Items.Clear()
        'frmSequencing.cboCluster.Items.Clear()
        frmSequencing.cboProvince.Text = ""
        frmSequencing.cboMunicipality.Text = ""
        frmSequencing.cboZone.Text = ""
        frmSequencing.cboBarangay.Text = ""
        'frmSequencing.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim indexOfDefault As Integer
            Dim getDefault As Integer
            ReDim arrSeqProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrSeqProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmSequencing.cboProvince.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
            frmSequencing.cboProvince.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub SeqMunCombo(i As Integer)
        frmSequencing.cboMunicipality.Items.Clear()
        frmSequencing.cboZone.Items.Clear()
        frmSequencing.cboBarangay.Items.Clear()
        'frmSequencing.cboCluster.Items.Clear()
        frmSequencing.cboMunicipality.Text = ""
        frmSequencing.cboZone.Text = ""
        frmSequencing.cboBarangay.Text = ""
        'frmSequencing.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist where addprovid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim indexOfDefault As Integer
            Dim getDefault As Integer
            ReDim arrSeqMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(3).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrSeqMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmSequencing.cboMunicipality.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            frmSequencing.cboMunicipality.SelectedIndex = indexOfDefault
        End If

    End Sub

    Public Sub SeqZoneCombo(i As Integer)
        frmSequencing.cboZone.Items.Clear()
        frmSequencing.cboBarangay.Items.Clear()
        ' frmSequencing.cboCluster.Items.Clear()
        frmSequencing.cboZone.Text = ""
        frmSequencing.cboBarangay.Text = ""
        'frmSequencing.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones where addmunid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSeqZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrSeqZoneID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmSequencing.cboZone.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub SeqBarangayCombo(i As Integer)
        frmSequencing.cboBarangay.Items.Clear()
        'frmSequencing.cboCluster.Items.Clear()
        frmSequencing.cboBarangay.Text = ""
        ' frmSequencing.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneID=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSeqBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrSeqBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmSequencing.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub SeqClusterCombo(i As Integer)
        'frmSequencing.cboCluster.Items.Clear()
        'frmSequencing.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT clusterID, clustername FROM clusterlist WHERE brgyid=" & i, con)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            ReDim arrClusterSeqID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrClusterSeqID(x) = Val(dt.Rows(x).Item(0).ToString)
                'frmSequencing.cboCluster.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Public Sub SeqList(ByVal bryID As Integer)
        frmSequencing.lvwSeq.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.consID, A.brgyID, A.clusterID, A.Sequence, A.AccountNO, A.streetAddress, C.ConsumerName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.brgyID=" & bryID & " ORDER BY sequence ASC", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSeqAccID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrSeqAccID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(4).ToString
                maxSeqNum = Val(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(0).ToString)
                frmSequencing.lvwSeq.Items.Add(lst)
            Next
            frmSequencing.txtCurSeq.Enabled = True
            frmSequencing.txtNewSeqNum.Enabled = True
            frmSequencing.btnSet.Enabled = True
        Else
            frmSequencing.txtCurSeq.Enabled = False
            frmSequencing.txtNewSeqNum.Enabled = False
            frmSequencing.btnSet.Enabled = False
        End If
    End Sub

    Public Sub ViewAllAcounts()
        frmAccountsList.lvwAccounts.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim allAccountID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1

            Next
        End If
    End Sub

    Public Sub WaterBillConsumerList()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist ORDER BY consumername ASC", con)
        da.Fill(dt)
        WaterBillPayment.cboConsumerName.Items.Clear()
        WaterBillPayment.cboConsumerName.AutoCompleteCustomSource.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrConsWaterID(dt.Rows.Count - 1)
            ReDim arrCheckSC(dt.Rows.Count - 1)
            ReDim arrSenIDCons(dt.Rows.Count - 1)
            ReDim arrAgency(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrConsWaterID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrCheckSC(x) = dt.Rows(x).Item(4).ToString
                arrSenIDCons(x) = dt.Rows(x).Item(5).ToString
                arrAgency(x) = dt.Rows(x).Item(6).ToString
                WaterBillPayment.cboConsumerName.Items.Add(dt.Rows(x).Item(1).ToString)
                WaterBillPayment.cboConsumerName.AutoCompleteCustomSource.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Public arrPaymentBillID() As Integer
    Public arrPaymentAcctID() As Integer
    Public arrPaymentBillMonth() As String
    Public arrPaymentBillyear() As Integer
    Public arrCollectionType() As String
    Public arrPaymentType() As String
    Public arrPaymentBillWSF() As Decimal
    Public arrPaymentBillAmt() As Decimal
    Public arrPaymentBillPen() As Decimal
    Public arrPaymentBillEF() As Decimal
    Public arrPaymentBillDis() As Decimal
    Public arrPaymentBillApp() As Decimal
    Public arrPaymentReqPay() As Decimal
    Public arrPaymentReqAmt() As Decimal
    Public arrPaymentBillDue() As Decimal
    Public arrPaymentBillADue() As Decimal
    Public arrPaymentBillCurrentRemark() As String
    Public arrPaymentDueDate() As Date
    Public countBillsPayment As Integer
    Public paymentIsSC As String
    Public arrPrevOutstandBillAmt() As Decimal
    Public arrPrevOutstandInstallment() As Decimal
    Public arrPaymentReadDate() As Date
    Public arrPaymentBillDate() As Date
    Public arrPaymentPrevRead() As Integer
    Public arrPaymentPresRead() As Integer
    Public arrPaymentConsump() As Integer

    Public arrPaySelMetReader() As String
    Public arrPaySelBillNum() As Integer


    Public Sub WaterBillAccountsList(ByVal consumerID As Integer)
        Dim isAdj As String
        Cons()
        Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT M.metID, M.acctID, A.AccountNo, M.readperfrom, M.ReadPerTo, M.readperyear, M.totamount, M.dueDate, M.dueAmount, M.uID FROM meterreading AS M LEFT JOIN consumeraccounts AS A ON M.acctID=A.acctID WHERE A.acctStatus=1 AND M.MetStatus='UNPAID' AND A.consID=" & consumerID, con)
        'Dim sqlstr As String = "SELECT B.billid, B.billNo, B.acctID, CA.AccountNo, B.billmonth, B.billyear, B.billPeriod, B.totalAmountDue, B.SCDiscount,B.AmountADue , B.SCPenalty, B.duedate, B.useAmount, B.useADue, B.uID, B.adjRemark, B.envifee, CA.isSenior, CA.seniorID, M.metName, M.metid, B.penalty, B.adjusted, B.isAdjusted, CL.agency, CL.ConsumerName, B.prevOutstandingStat, B.prevOutstanding, CA.AccountName FROM billing AS B LEFT JOIN consumeraccounts AS CA ON B.AcctID=CA.AcctID LEFT JOIN meterreader AS M ON B.metreadid =M.metID LEFT JOIN consumerlist AS CL ON B.consID=CL.consID WHERE (B.billstat='UNPAID' or B.billstat='LAPSE') AND B.consID=" & consumerID
        Dim sqlstr As String = "SELECT B.billID, CA.AcctID, CA.AccountNo, CA.AccountName, B.billPeriod, B.billMonth, B.billYear, B.amount, B.enviFee, B.SCDiscount, B.applicationFee, B.penalty, B.dueDate, B.isAdjusted, B.adjRemark, CL.isSC, B.prevOutstanding, B.readDate, B.billDate, B.prevRead, B.presRead, B.consump, B.outstandinginstallmentfee, B.overpayment, B.useAmount, B.useADue FROM billing AS B LEFT JOIN consumeraccounts AS CA ON B.AcctID=CA.AcctID LEFT JOIN meterreader AS M ON B.metreadid =M.metID LEFT JOIN consumerlist AS CL ON B.consID=CL.consID WHERE (B.billstat='UNPAID' or B.billstat='LAPSE') AND B.consID=" & consumerID
        Dim da As New MySqlDataAdapter(sqlstr, con)
        da.Fill(dt)
        WaterBillPayment.lvwAccounts.Items.Clear()
        InstallmentCount = 12
        If dt.Rows.Count > 0 Then
            countBillsPayment = dt.Rows.Count - 1
            ReDim arrCollectionType(dt.Rows.Count - 1)
            ReDim arrPaymentBillID(dt.Rows.Count - 1)
            ReDim arrPaymentAcctID(dt.Rows.Count - 1)
            ReDim arrPaymentBillMonth(dt.Rows.Count - 1)
            ReDim arrPaymentBillyear(dt.Rows.Count - 1)
            ReDim arrPaymentType(dt.Rows.Count - 1)
            ReDim arrPaymentBillAmt(dt.Rows.Count - 1)
            ReDim arrPaymentBillWSF(dt.Rows.Count - 1)
            ReDim arrPaymentBillPen(dt.Rows.Count - 1)
            ReDim arrPaymentBillEF(dt.Rows.Count - 1)
            ReDim arrPaymentBillDis(dt.Rows.Count - 1)
            ReDim arrPaymentBillApp(dt.Rows.Count - 1)
            ReDim arrPaymentReqAmt(dt.Rows.Count - 1)
            ReDim arrPaymentBillDue(dt.Rows.Count - 1)
            ReDim arrPaymentBillADue(dt.Rows.Count - 1)
            ReDim arrPrevOutstandBillAmt(dt.Rows.Count - 1)
            ReDim arrPaymentDueDate(dt.Rows.Count - 1)
            ReDim arrPrevOutstandInstallment(dt.Rows.Count - 1)
            ReDim arrPaymentReadDate(dt.Rows.Count - 1)
            ReDim arrPaymentBillDate(dt.Rows.Count - 1)
            ReDim arrPaymentPrevRead(dt.Rows.Count - 1)
            ReDim arrPaymentPresRead(dt.Rows.Count - 1)
            ReDim arrPaymentConsump(dt.Rows.Count - 1)
            'ReDim arrPaymentIsSC(dt.Rows.Count - 1)
            ReDim arrPaymentBillCurrentRemark(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrPaymentBillMonth(x) = dt.Rows(x).Item(5).ToString
                arrPaymentBillyear(x) = dt.Rows(x).Item(6).ToString
                arrPaymentBillAmt(x) = Val(dt.Rows(x).Item(24).ToString)
                arrPaymentBillEF(x) = Val(dt.Rows(x).Item(8).ToString)
                arrPaymentBillWSF(x) = arrPaymentBillAmt(x) - arrPaymentBillEF(x)
                arrPaymentBillDis(x) = Val(dt.Rows(x).Item(9).ToString)
                arrPaymentBillApp(x) = Val(dt.Rows(x).Item(10).ToString)
                arrPaymentBillPen(x) = Val(dt.Rows(x).Item(11).ToString)
                arrPaymentBillDue(x) = Val(dt.Rows(x).Item(24).ToString)
                arrPaymentBillADue(x) = Val(dt.Rows(x).Item(25).ToString)
                arrPaymentReadDate(x) = dt.Rows(x).Item(17)
                arrPaymentBillDate(x) = dt.Rows(x).Item(18)
                arrPaymentPrevRead(x) = Val(dt.Rows(x).Item(19).ToString)
                arrPaymentPresRead(x) = Val(dt.Rows(x).Item(20).ToString)
                arrPaymentConsump(x) = Val(dt.Rows(x).Item(21).ToString)
                arrPrevOutstandInstallment(x) = Val(dt.Rows(x).Item(22).ToString)
                paymentIsSC = dt.Rows(x).Item(15).ToString
                arrPrevOutstandBillAmt(x) = Val(dt.Rows(x).Item(16).ToString)
                arrPaymentBillCurrentRemark(x) = "Current Bill"
                arrPaymentDueDate(x) = dt.Rows(x).Item(12)
                'COMPUTE DUE===========================================
                Dim gDate As Date = Format(dt.Rows(x).Item(12), "MM/dd/yyyy")
                'Dim nowDate As Date = Now.Date
                Dim nowDate As Date = WaterBillPayment.dtp.Value.Date
                Dim ComputeDays As TimeSpan = gDate - nowDate
                Dim intDays As Integer = ComputeDays.Days

                'Dim amountRequired As Double
                'MessageBox.Show(intDays)
                If intDays >= 0 Then
                    arrPaymentBillPen(x) = 0
                Else
                    arrPaymentBillPen(x) = Val(dt.Rows(x).Item(11).ToString)
                    'arrPaymentReqAmt(x) = arrPaymentBillAmt(x) + arrPaymentBillApp(x)
                End If
                arrPaymentReqAmt(x) = arrPaymentBillDue(x) + arrPaymentBillPen(x)
                If paymentIsSC = "YES" Then
                    arrPaymentBillDis(x) = arrPaymentBillDis(x)
                Else
                    arrPaymentBillDis(x) = 0
                End If
                arrPaymentReqAmt(x) = arrPaymentReqAmt(x)
                'If WaterBillPayment.chkDiscount.Checked = True Then

                'End If
                'COMPUTE DUE===========================================
                Dim lst As New ListViewItem
                lst.Text = ""
                arrCollectionType(x) = "Bill"
                arrPaymentBillID(x) = dt.Rows(x).Item(0)
                arrPaymentAcctID(x) = dt.Rows(x).Item(1)
                lst.SubItems.Add("Water Bill")
                lst.SubItems.Add(arrPaymentBillID(x))
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString & " " & dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(Format(arrPaymentBillWSF(x), "#,##0.#0"))
                lst.SubItems.Add(Format(arrPaymentBillEF(x), "#,##0.#0"))
                lst.SubItems.Add(Format(arrPaymentBillDis(x), "#,##0.#0"))
                lst.SubItems.Add(Format(arrPaymentBillApp(x), "#,##0.#0"))
                lst.SubItems.Add(Format(arrPaymentBillPen(x), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(12))
                lst.SubItems.Add(Format(arrPaymentReqAmt(x) + arrPrevOutstandBillAmt(x), "#,##0.#0"))
                'lst.SubItems(x). = Color.Green
                lst.SubItems.Add(dt.Rows(x).Item(13).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(14).ToString)
                lst.SubItems.Add(Format(arrPrevOutstandBillAmt(x), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(23).ToString), "#,##0.#0"))
                WaterBillPayment.lvwAccounts.Items.Add(lst)
                WaterBillPayment.lvwAccounts.Items(x).SubItems(13).BackColor = Color.Green
                WaterBillPayment.lvwAccounts.Items(x).SubItems(16).BackColor = Color.Red
            Next

            Dim dtIns As New DataTable
            Dim daIns As New MySqlDataAdapter("SELECT B.afeetotID, A.accountno, A.accountname, B.acctID, B.balance FROM applicationfeetotalbalance B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE C.consID=" & consumerID, con)
            daIns.Fill(dtIns)
            If dt.Rows.Count > 0 Then
                For y As Integer = 0 To dtIns.Rows.Count - 1
                    Dim amt As Double = Val(dtIns(y).Item(4).ToString)
                    If amt > 0 Then
                        Dim lstInstall As New ListViewItem
                        lstInstall.Text = ""
                        lstInstall.SubItems.Add("Installment Fee")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add(dtIns(y).Item(1).ToString)
                        lstInstall.SubItems.Add(dtIns(y).Item(2).ToString)
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add(Format(amt, "#,##0.#0"))
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        lstInstall.SubItems.Add("")
                        WaterBillPayment.lvwAccounts.Items.Add(lstInstall)
                    End If
                Next

            End If

        End If

    End Sub

    Public Sub LoadForDisconnectionList(brgyID As Integer)
        Cons()
        Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT B.acctID, A.accountno, A.AccountName, SUM(ifnull(B.useAmount,0)) AS TotalBalance, A.AcctStatus, (select count(*) FROM billing AS BA WHERE BA.acctID=B.acctID AND (BA.billstat='UNPAID') GROUP BY BA.acctID) AS CountBills, A.streetaddress, C.clustername, BR.addbrgy FROM billing AS B left join consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN clusterlist AS C ON A.clusterID=C.clusterID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID and (select count(*) FROM billing AS BA WHERE BA.acctID=B.acctID AND (BA.billstat='UNPAID')  GROUP BY BA.acctID)>=3 AND billstat='UNPAID' AND (datediff(now(), B.duedate))>=6 and A.acctstatus=1 And A.brgyID=" & brgyID & " GROUP BY B.acctID ORDER BY TotalBalance DESC", con)
        Dim daA As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, A.AccountName, Sum(B.useAmount + ifnull(B.prevOutstanding,0)) AS Balance, A.AcctStatus, COUNT(*) AS BillCount, A.StreetAddress, R.addbrgy FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID WHERE B.brgyID=" & brgyID & " and B.billstat='UNPAID' GROUP BY B.acctID ORDER BY Balance DESC", con)
        daA.Fill(dt)
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            'MessageBox.Show(i)
            Dim dr As DataRow = dt.Rows(i)
            If dr(5) <= 2 Then
                'MessageBox.Show(dr(5))
                dt.Rows.Remove(dr)
            End If
        Next
        dt.AcceptChanges()
        Dim nDT As New DataTable
        nDT = dt
        frmDisconnectionList.dtDisc.Clear()
        frmDisconnectionList.dtDisc = dt
        frmDisconnectionList.lvw.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrDiscAcctID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = ""
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(0).ToString)
                frmDisconnectionList.lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub WaterBillSpecNum(ByVal billID As Integer)
        Dim isAdj As String
        Cons()
        Dim dt As New DataTable

        Dim sqlstr As String = "SELECT B.billid, B.acctID, CA.AccountNo, B.monthFrom, B.monthTo, B.billyear, B.amountbilled, B.duedate, B.dueamounttotal, B.uID, B.dueamount, B.AdjustedAmount, B.AdjDueAmount, B.AdjOrDispRmk, UL.fullname, B.consID, B.enviFee, CC.consumername FROM tblbills AS B LEFT JOIN consumeraccounts AS CA ON B.AcctID=CA.AcctID LEFT JOIN userlist AS UL ON B.metReadID=UL.uID LEFT JOIN consumerlist AS CC ON CA.consID=CC.consID WHERE CA.acctStatus=1 AND (B.billstatus='UNPAID' or B.billstatus='LAPSE') AND B.billID=" & billID
        Dim da As New MySqlDataAdapter(sqlstr, con)
        da.Fill(dt)
        WaterBillPayment.lvwAccounts.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim discountedAmount(dt.Rows.Count - 1)
            ReDim arrWaterBillAccID(dt.Rows.Count - 1)
            ReDim arrWaterBillMetID(dt.Rows.Count - 1)
            ReDim arrWaterBillAmountReq(dt.Rows.Count - 1)
            ReDim reqPayment(dt.Rows.Count - 1)
            ReDim discPayment(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                WaterBillPayment.lblConsumerID.Text = Val(dt.Rows(x).Item(15).ToString)
                Dim surC As Double = 0
                isAdj = dt.Rows(x).Item(13).ToString
                arrWaterBillMetID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrWaterBillAccID(x) = Val(dt.Rows(x).Item(1).ToString)
                Dim lst As New ListViewItem
                lst.Text = ""
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString & " - " & dt.Rows(x).Item(4).ToString & " " & dt.Rows(x).Item(5).ToString)
                If isAdj = "None" Then
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
                Else
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(11).ToString), "#,##0.#0"))
                End If
                lst.SubItems.Add(Format(dt.Rows(x).Item(7), "yyyy-MM-dd"))
                If isAdj = "None" Then
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(10).ToString), "#,##0.#0"))
                Else
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(12).ToString), "#,##0.#0"))
                End If
                Dim gDate As Date = dt.Rows(x).Item(7)
                Dim nowDate As Date = Now.Date
                Dim ComputeDays As TimeSpan = gDate - nowDate
                Dim intDays As Integer = ComputeDays.Days
                Dim amountRequired As Double
                If isAdj = "None" Then
                    If intDays <= 0 Then
                        amountRequired = Val(dt.Rows(x).Item(10).ToString)
                        surC = Val(dt.Rows(x).Item(10).ToString) - Val(dt.Rows(x).Item(6).ToString)
                    Else
                        amountRequired = Val(dt.Rows(x).Item(6).ToString)
                        surC = 0
                    End If
                Else
                    If intDays <= 0 Then
                        amountRequired = Val(dt.Rows(x).Item(12).ToString)
                        surC = Val(dt.Rows(x).Item(12).ToString) - Val(dt.Rows(x).Item(11).ToString)
                    Else
                        amountRequired = Val(dt.Rows(x).Item(11).ToString)
                        surC = 0
                    End If
                End If
                arrWaterBillAmountReq(x) = amountRequired
                reqPayment(x) = amountRequired
                lst.SubItems.Add(Format(arrWaterBillAmountReq(x), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(14).ToString)
                lst.SubItems.Add(isAdj)
                lst.SubItems.Add(Format(surC, "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(16).ToString), "#,##0.#0"))
                WaterBillPayment.lvwAccounts.Items.Add(lst)
            Next
            WaterBillPayment.cboConsumerName.Text = dt.Rows(0).Item(17).ToString
        End If
    End Sub

    Public Sub WaterBillSpecNum2(ByVal billID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT C.consumername, B.billstat FROM consumerlist AS C LEFT JOIN billing AS B ON C.consID=B.consID WHERE B.billID=" & billID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim checkStat As String = dt.Rows(0).Item(1).ToString
            If checkStat = "PAID" Then
                MsgBox("Bill with Bill Number " & billID & " already Paid")
            End If
            WaterBillPayment.lblConsumerID.Text = arrConsWaterID(WaterBillPayment.cboConsumerName.SelectedIndex)
            WaterBillPayment.cboConsumerName.Text = dt.Rows(0).Item(0).ToString
        Else
            MsgBox("Bill Number Unexisting", MsgBoxStyle.Exclamation, "")
        End If

    End Sub

    Public Function DateRange(date1 As Date, date2 As Date) As Integer
        Dim gDate As Date = date1
        Dim nowDate As Date = date2
        Dim ComputeDays As TimeSpan = gDate - nowDate
        Dim intDays As Integer = ComputeDays.Days
        Dim strDueStatus As String
        'Dim amountRequired As Double
        If intDays <= 0 Then
            strDueStatus = "Due"
        Else
            strDueStatus = "Not Due"
        End If
        DateRange = intDays
        myDueStatus = strDueStatus
    End Function

    Public Sub acctFormProvListCombo()
        frmAccountsList.cboProvince.Items.Clear()
        frmAccountsList.cboMunicipality.Items.Clear()
        frmAccountsList.cboZone.Items.Clear()
        frmAccountsList.cboBarangay.Items.Clear()
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboProvince.Text = ""
        frmAccountsList.cboMunicipality.Text = ""
        frmAccountsList.cboZone.Text = ""
        frmAccountsList.cboBarangay.Text = ""
        frmAccountsList.cboCluster.Text = ""
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim indexOfDefault As Integer
            Dim getDefault As Integer
            ReDim arrAcctListProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrAcctListProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmAccountsList.cboProvince.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
            frmAccountsList.cboProvince.SelectedIndex = indexOfDefault
        End If

    End Sub

    Public Sub acctFormMunListCombo(i As Integer)
        frmAccountsList.cboMunicipality.Items.Clear()
        frmAccountsList.cboZone.Items.Clear()
        frmAccountsList.cboBarangay.Items.Clear()
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboMunicipality.Text = ""
        frmAccountsList.cboZone.Text = ""
        frmAccountsList.cboBarangay.Text = ""
        frmAccountsList.cboCluster.Text = ""
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getdefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrAcctListMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getdefault = Val(dt.Rows(x).Item(3).ToString)
                If getdefault = 1 Then
                    indexOfDefault = x
                End If
                arrAcctListMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmAccountsList.cboMunicipality.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            frmAccountsList.cboMunicipality.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub accFormClusterList(i As Integer)
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboCluster.Text = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrAcctListClusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAcctListClusterID(x) = (Val(dt.Rows(x).Item(0).ToString()))
                frmAccountsList.cboCluster.Items.Add(dt.Rows(x).Item(2).ToString())
            Next
        End If
    End Sub

    Public Sub acctFormZoneListCombo(i As Integer)
        frmAccountsList.cboZone.Items.Clear()
        frmAccountsList.cboBarangay.Items.Clear()
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboZone.Text = ""
        frmAccountsList.cboBarangay.Text = ""
        frmAccountsList.cboCluster.Text = ""
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones where addmunid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrAcctListZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAcctListZoneID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmAccountsList.cboZone.Items.Add(dt.Rows(x).Item(5).ToString)
            Next
            frmAccountsList.cboZone.SelectedIndex = 0
        End If
    End Sub

    Public Sub acctFormBrgyListCombo(i As Integer)
        frmAccountsList.cboBarangay.Items.Clear()
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboBarangay.Text = ""
        frmAccountsList.cboCluster.Text = ""
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneID=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrAcctListBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAcctListBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmAccountsList.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub acctFormClusterListCombo(i As Integer)
        frmAccountsList.cboCluster.Items.Clear()
        frmAccountsList.cboCluster.Text = ""
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT clusterSize FROM brgylist WHERE brgyid=" & i, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 1 To Val(dt.Rows(0).Item(0).ToString)
                frmAccountsList.cboCluster.Items.Add(x)
            Next
        End If
    End Sub

    Public Sub AccountFormList(ByVal brD As Integer, ByVal sear As String, ByVal filt As String)
        Cons()
        Dim curbal As Double
        'If clID = 0 Then
        '    clus = ""
        'Else
        '    clus = "and A.clusterID=" & clID
        'End If
        frmAccountsList.lvwAccounts.Items.Clear()
        Dim strQuer As String = "SELECT A.acctID, A.AccountNo, L.ConsumerName, A.StreetAddress, B.AddBrgy, Z.Abbrv, Clist.clustername, S.statusName, A.ConnectionDate, Clas.classification, format(OP.balamt, 2), format(AF.balance, 2), A.consID  FROM consumeraccounts AS A LEFT JOIN consumerlist as L ON A.consID=L.consID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN zones AS Z ON B.zoneID=Z.zoneID LEFT JOIN clusterlist AS Clist ON A.ClusterID=Clist.ClusterID LEFT JOIN accountstatus AS S ON A.AcctStatus=S.staID LEFT JOIN classifications AS Clas ON A.classID=Clas.ClassID LEFT JOIN tbloverpayment AS OP ON A.acctID=OP.acctID LEFT JOIN applicationfeetotalbalance AS AF ON A.acctID=AF.acctID WHERE A.brgyID=" & brD & " and (A.AccountNo LIKE '%" & sear & "%' OR L.ConsumerName LIKE '%" & sear & "%') " & filt & " ORDER BY A.AccountNo"
        'MessageBox.Show(strQuer)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strQuer, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrAccountListAcctID(dt.Rows.Count - 1)
            ReDim arrAccountListConsID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAccountListAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrAccountListConsID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                Dim cStat As String = dt.Rows(x).Item(7).ToString
                If cStat = "Connected" Then
                    lst.BackColor = Color.White
                ElseIf cStat = "Disconnected" Then
                    lst.BackColor = Color.Red
                ElseIf cStat = "Installation" Then
                    lst.BackColor = Color.Green
                ElseIf cStat = "Disconnection" Then
                    lst.BackColor = Color.Orange
                ElseIf cStat = "Meter Transfer" Then
                    lst.BackColor = Color.Yellow
                ElseIf cStat = "Name Transfer" Then
                    lst.BackColor = Color.Yellow
                ElseIf cStat = "Reconnection" Then
                    lst.BackColor = Color.Blue
                ElseIf cStat = "Temporary Close" Then
                    lst.BackColor = Color.Gray
                End If

                Dim dtB As New DataTable
                Dim daB As New MySqlDataAdapter("SELECT useAmount, useADue, dueDate, prevOutstanding, prevOutstandingStat FROM billing WHERE ((billStat='UNPAID' OR billStat='LAPSE') OR (prevOutstandingStat='UNPAID')) AND acctID= " & arrAccountListAcctID(x), con)
                daB.Fill(dtB)
                curbal = 0
                If dtB.Rows.Count > 0 Then
                    For y As Integer = 0 To dtB.Rows.Count - 1
                        Dim chkDue As Date = dtB.Rows(y).Item(2)
                        Dim nowDate As Date = Now.Date
                        Dim computeDays As TimeSpan = chkDue - nowDate
                        Dim intDays As Integer = computeDays.Days
                        Dim selAmount As Double = 0
                        If intDays < 0 Then
                            selAmount = Val(dtB.Rows(y).Item(1).ToString)
                        Else
                            selAmount = Val(dtB.Rows(y).Item(0).ToString)
                        End If
                        Dim prevOutstand As Double = 0
                        Dim prevStat As String = dtB.Rows(y).Item(4).ToString
                        If prevStat = "UNPAID" Then
                            prevOutstand = Val(dtB.Rows(y).Item(3).ToString)
                        Else
                            prevOutstand = 0
                        End If
                        curbal = curbal + selAmount + prevOutstand
                    Next
                End If
                'Dim dtB As New DataTable
                'Dim daB As New MySqlDataAdapter("SELECT amountbilled, dueamount, AdjustedAmount, AdjDueAmount, AdjOrDispRmk, duedate FROM tblbills WHERE (billstatus='UNPAID' OR billstatus='LAPSE') AND acctID=" & arrAccountListAcctID(x), con)
                'daB.Fill(dtB)
                'If dtB.Rows.Count > 0 Then
                '    curbal = 0
                '    For y As Integer = 0 To dtB.Rows.Count - 1
                '        Dim chkAdj As String = dtB.Rows(y).Item(4).ToString
                '        Dim chkDue As Date = dtB.Rows(y).Item(5)
                '        Dim nowDate As Date = Now.Date
                '        Dim ComputeDays As TimeSpan = chkDue - nowDate
                '        Dim intDays As Integer = ComputeDays.Days
                '        Dim selAmount As Double = 0
                '        If chkAdj = "None" Then
                '            If intDays <= 0 Then
                '                selAmount = Val(dtB.Rows(y).Item(1).ToString)
                '            Else
                '                selAmount = Val(dtB.Rows(y).Item(0).ToString)
                '            End If
                '        Else
                '            If intDays <= 0 Then
                '                selAmount = Val(dtB.Rows(y).Item(3).ToString)
                '            Else
                '                selAmount = Val(dtB.Rows(y).Item(2).ToString)
                '            End If
                '        End If
                '        curbal = curbal + selAmount
                '    Next
                'Else
                '    curbal = 0
                'End If
                lst.SubItems.Add(Format(curbal, "#,##0.#0"))
                Try
                    lst.SubItems.Add(Format(dt.Rows(x).Item(8), "MM-dd-yyyy"))
                Catch ex As Exception
                    lst.SubItems.Add("")
                End Try
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(10).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(11).ToString)
                'lst.SubItems.Add(Format(dt.Rows(x).Item(8), "MM-dd-yyyy"))
                frmAccountsList.lblTotalAccounts.Text = "Total Accounts: " & dt.Rows.Count
                frmAccountsList.lvwAccounts.Items.Add(lst)
            Next
        End If
    End Sub
    Public Sub ViewUserTypes()
        Cons()
        userTypes.lvw.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM usertypes", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSelectedUTypeID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrSelectedUTypeID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(0)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                userTypes.lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub UserAccessCheckList(uID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM usertypes AS t LEFT JOIN accesslevel AS A ON t.utypeID=A.utypeID WHERE t.utypeid=" & uID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            With accessCheckList

                Dim checkTool As Integer = Val(dt.Rows(0).Item(4).ToString)
                Dim checkAccounting As Integer = Val(dt.Rows(0).Item(5).ToString)
                Dim checkBilling As Integer = Val(dt.Rows(0).Item(6).ToString)
                Dim checkCollection As Integer = Val(dt.Rows(0).Item(7).ToString)
                Dim checkMeter As Integer = Val(dt.Rows(0).Item(8).ToString)
                Dim checkReports As Integer = Val(dt.Rows(0).Item(9).ToString)
                Dim checkConsumers As Integer = Val(dt.Rows(0).Item(10).ToString)
                Dim checkAccounts As Integer = Val(dt.Rows(0).Item(11).ToString)
                Dim checkPending As Integer = Val(dt.Rows(0).Item(12).ToString)
                Dim checkSequence As Integer = Val(dt.Rows(0).Item(13).ToString)
                .lblUserType.Text = dt.Rows(0).Item(1).ToString
                If checkTool = 1 Then
                    .chkTools.Checked = True
                Else
                    .chkTools.Checked = False
                End If

                If checkAccounting = 1 Then
                    .chkAccountingTab.Checked = True
                Else
                    .chkAccountingTab.Checked = False
                End If

                If checkBilling = 1 Then
                    .chkBilling.Checked = True
                Else
                    .chkBilling.Checked = False
                End If

                If checkCollection = 1 Then
                    .chkCollection.Checked = True
                Else
                    .chkCollection.Checked = False
                End If

                If checkMeter = 1 Then
                    .chkMeterReading.Checked = True
                Else
                    .chkMeterReading.Checked = False
                End If

                If checkReports = 1 Then
                    .chkReports.Checked = True
                Else
                    .chkReports.Checked = False
                End If

                If checkConsumers = 1 Then
                    .chkConsumers.Checked = True
                Else
                    .chkConsumers.Checked = False
                End If

                If checkAccounts = 1 Then
                    .chkAccounts.Checked = True
                Else
                    .chkAccounts.Checked = False
                End If

                If checkPending = 1 Then
                    .chkPending.Checked = True
                Else
                    .chkPending.Checked = False
                End If

                If checkSequence = 1 Then
                    .chkSequencing.Checked = True
                Else
                    .chkSequencing.Checked = False
                End If
            End With
        Else
            With accessCheckList
                .chkTools.Checked = False
                .chkAccountingTab.Checked = False
                .chkBilling.Checked = False
                .chkCollection.Checked = False
                .chkMeterReading.Checked = False
                .chkReports.Checked = False
                .chkConsumers.Checked = False
                .chkAccounts.Checked = False
                .chkPending.Checked = False
                .chkSequencing.Checked = False
            End With
        End If
    End Sub

    Public Sub AccessEnabler(uID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM usertypes AS T LEFT JOIN accesslevel AS A ON T.utypeid=A.utypeID WHERE T.utypeid=" & uID, con)
        da.Fill(dt)
        With frmAdminPanel
            Dim btools As Integer = Val(dt.Rows(0).Item(4).ToString)
            Dim baccounting As Integer = Val(dt.Rows(0).Item(5).ToString)
            Dim bbilling As Integer = Val(dt.Rows(0).Item(6).ToString)
            Dim bcollection As Integer = Val(dt.Rows(0).Item(7).ToString)
            Dim bmeter As Integer = Val(dt.Rows(0).Item(8).ToString)
            Dim breports As Integer = Val(dt.Rows(0).Item(9).ToString)
            Dim bconsumers As Integer = Val(dt.Rows(0).Item(10).ToString)
            Dim baccounts As Integer = Val(dt.Rows(0).Item(11).ToString)
            Dim bpending As Integer = Val(dt.Rows(0).Item(12).ToString)
            Dim bsequencing As Integer = Val(dt.Rows(0).Item(13).ToString)
            Dim bApprvls As Integer = Val(dt.Rows(0).Item(14).ToString)
            Dim bSettings As Integer = Val(dt.Rows(0).Item(15).ToString)
            .menTools.Visible = CBool(btools)
            .btnAccounting.Visible = False 'CBool(baccounting)
            .btnBilling.Visible = CBool(bbilling)
            .btnCollection.Visible = CBool(bcollection)
            .btnMeterReading.Visible = CBool(bmeter)
            .btnReports.Visible = CBool(breports)
            .btnConsumers.Visible = CBool(bconsumers)
            .btnConsumerAccounts.Visible = CBool(baccounts)
            .btnPendList.Visible = CBool(bpending)
            .btnSequencing.Visible = CBool(bsequencing)
            .btnApprovalReq.Visible = CBool(bApprvls)
            .menSettings.Visible = CBool(bSettings)
            If uID = 1 Then
                .menAdmin.Visible = True
            Else
                .menAdmin.Visible = False
            End If
        End With

    End Sub

    Public Sub ViewWaterBilling(rFrom As String, rTo As String, rYear As String, brgID As Integer)
        Cons()
        rrFrom = rFrom
        rrTo = rTo
        rrYear = rYear
        rbrgID = brgID
        'rclID = clID
        'strQueryBill = "SELECT B.billiD, B.acctID, B.consID, B.classID, B.zoneID, BR.brgyID, B.clusterID, C.ConsumerName, A.StreetAddress,A.MeterNo, A.AccountNo, A.Sequence, A.isSenior, CL.classification, B.dueDate, B.fromDate, B.toDate, B.billMonth, B.billYear, B.prevRead, B.presRead, B.prevBal, B.prevConsump, B.prevEnv, B.prevAdj, B.prevAdjustedRate, B.prevPenalty, B.prevAmountDue, B.prevTotal, B.consump, B.amount, B.flatrate, B.excess, B.adjusted, B.adjustedRate, B.EnviFee, B.totalAmountDue, B.useAmount, B.useADue, B.penalty, B.AmountADue, B.isSC, B.SCDiscount, B.SCPenalty, B.seqNum, B.isAdjusted, B.adjReason, B.adjPrep, AJ.fullname AS PrepAdjName, B.adjDate, B.adjApprov, AA.fullname AS ApprovAdjName, B.adjRemark, B.adjApprovStat, B.billstat, B.ORNumPaid, B.AmountPaid, B.MoneyAmount, B.mChange, B.metReadID, MR.metName, B.billNote, B.uID, u.fullname AS UserFullName,B.billperiod,B.billdate,B.Fconsump,B.SConsump,B.Fexcess,B.SExcess,B.FLabel,B.SLabel,CS.clustername, BR.addBrgy, B.readDate, B.adjConsump, B.minconsump, B.Fratepercub, B.SRatepercub, B.prevSCDis, A.AccountName, C.ContactNum, B.applicationfee, MM.municipality FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS CL ON B.classID=CL.classID LEFT JOIN clusterlist AS CS ON B.clusterID=CS.clusterID LEFT JOIN brgylist AS BR ON CS.brgyID=BR.brgyID LEFT JOIN meterreader AS MR ON B.metreadID=MR.metID LEFT JOIN userlist AS U ON B.uID=U.uID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN userlist AS AJ ON B.adjPrep=AJ.uID LEFT JOIN userlist AS AA ON B.adjApprov=AA.uID LEFT JOIN zones AS ZZ ON ZZ.zoneID=BR.zoneID LEFT JOIN munlist AS MM ON MM.addmunID=ZZ.addmunID WHERE B.billMonth='" & rFrom & "'  AND B.billyear='" & rYear & "' AND A.brgyID=" & brgID & " AND A.AcctStatus=1"
        strQueryBill = "SELECT B.billID, A.acctID, C.consID, CC.classID, Z.zoneID, BR.brgyID, 1, M.addmunid, M.municipality, BR.addbrgy, '', A.StreetAddress, A.AccountName, C.contactNum, A.AccountNo, A.MeterNo, B.billMonth, B.billYear, B.billPeriod, B.dueDate, B.prevread, B.presRead, B.consump, B.amount, B.EnviFee, B.isSC, B.SCDiscount, B.prevAmountDue, B.prevPenalty, B.prevTotal, B.applicationfee, B.penalty, B.billNote, B.readDate, B.fromDate, B.toDate, B.overpayment, B.useAmount, B.useADue, B.billDate, A.standpipe FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CC ON B.classID=CC.classID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN zones AS Z ON Z.zoneID=BR.zoneID LEFT JOIN munlist AS M ON M.addmunID=Z.addmunID where B.billmonth='" & rFrom & "' and B.billyear=" & rYear & " AND A.clusterID=" & brgID & " ORDER BY A.standpipe"
        frmBilling.lvw.Items.Clear()
        BdateGen = Now.Date
        BmonthFrom = rFrom
        BmonthTo = rTo
        BBYear = Val(rYear)
        BBgyID = brgID
        'BClus = clID
        WaterBillingQuery(strQueryBill)

    End Sub

    Public Sub BillSelectProvList()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        LoadWaterBilling.cboProvince.Items.Clear()
        LoadWaterBilling.cboMunicipality.Items.Clear()
        LoadWaterBilling.cboZone.Items.Clear()
        LoadWaterBilling.cboBarangay.Items.Clear()
        LoadWaterBilling.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            Dim indexOfDefault As Integer
            Dim getDefault As Integer
            ReDim arrBillProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillProvID(x) = Val(dt.Rows(x).Item(0).ToString)
                LoadWaterBilling.cboProvince.Items.Add(dt.Rows(x).Item(1).ToString)
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
            Next
            LoadWaterBilling.cboProvince.SelectedIndex = indexOfDefault
        End If
    End Sub
    Public Sub BillSelectMunList(proID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & proID, con)
        da.Fill(dt)
        LoadWaterBilling.cboMunicipality.Items.Clear()
        LoadWaterBilling.cboZone.Items.Clear()
        LoadWaterBilling.cboBarangay.Items.Clear()
        LoadWaterBilling.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            Dim getdefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrBillMunID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getdefault = Val(dt.Rows(x).Item(3).ToString)
                If getdefault = 1 Then
                    indexOfDefault = x
                End If
                arrBillMunID(x) = Val(dt.Rows(x).Item(0).ToString)
                LoadWaterBilling.cboMunicipality.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            LoadWaterBilling.cboMunicipality.SelectedIndex = indexOfDefault
        End If
    End Sub
    Public Sub BillSelectZoneList(MunID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE addmunid=" & MunID, con)
        da.Fill(dt)
        LoadWaterBilling.cboZone.Items.Clear()
        LoadWaterBilling.cboBarangay.Items.Clear()
        LoadWaterBilling.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillZoneID(x) = Val(dt.Rows(x).Item(0).ToString)
                LoadWaterBilling.cboZone.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            LoadWaterBilling.cboZone.SelectedIndex = 0
        End If
    End Sub
    Public Sub BillSelectBrgyList()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        LoadWaterBilling.cboBarangay.Items.Clear()
        LoadWaterBilling.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                LoadWaterBilling.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub BillSelectClusterList(BrgyID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & BrgyID, con)
        da.Fill(dt)
        LoadWaterBilling.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillCLusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillCLusterID(x) = dt.Rows(x).Item(0)
                LoadWaterBilling.cboCluster.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub CollectionNoticeReport(stQ As String)
        Dim da As New MySqlDataAdapter(stQ, con)
        'da.Fill(frmBillPrintNew.reportingdataset.BillNotice)
        'frmBillPrint.reportingdataset.BillNotice.Clear
        da.Fill(frmBillPrint.reportingdataset.BillNotice)
        'da.Fill(frmBillPrint.)
        'da.Fill(frmBillPrint.reportingdataset.BillNotice)
        frmBillPrint.ReportViewer1.RefreshReport()
        'da.Fill(frmCollectionNotice.reportingdataset.CollectionNotice)
        'frmCollectionNotice.ReportViewer1.RefreshReport()
    End Sub

    Public Sub CollectionNoticeSelected(mID As Integer)
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreading AS MR LEFT JOIN consumeraccounts AS A ON MR.acctID=A.AcctID LEFT JOIN consumerlist AS C ON A.consID=C.ConsID LEFT JOIN classifications AS CL ON A.classID=CL.classID WHERE MR.metID=" & mID & " ORDER BY A.Sequence", con)
        da.Fill(frmCollectionNotice.reportingdataset.CollectionNotice)
        frmCollectionNotice.ReportViewer1.RefreshReport()
    End Sub

    Public Sub CollectionNoticeSpecificBill(mID As Integer)
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreading AS MR LEFT JOIN consumeraccounts AS A ON MR.acctID=A.AcctID LEFT JOIN consumerlist AS C ON A.consID=C.ConsID LEFT JOIN classifications AS CL ON A.classID=CL.classID WHERE MR.metID=" & mID & " ORDER BY A.Sequence", con)
        da.Fill(frmBillPrint.reportingdataset.CollectionNotice)
        frmBillPrint.ReportViewer1.RefreshReport()
    End Sub

    Public Sub BillPage(pID As Integer)
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreading AS MR LEFT JOIN consumeraccounts AS A ON MR.acctID=A.AcctID LEFT JOIN consumerlist AS C ON A.consID=C.ConsID LEFT JOIN classifications AS CL ON A.classID=CL.classID WHERE MR.metID=" & arrBillMetID(pID - 1) & " ORDER BY A.Sequence", con)
        da.Fill(frmBillPrint.reportingdataset.CollectionNotice)
        frmBillPrint.ReportViewer1.RefreshReport()
        frmBillPrint.ReportViewer1.RefreshReport()
    End Sub

    Public Sub StatCounter()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Count(*), acctstatus FROM consumeraccounts AS C GROUP BY acctstatus", con)
        da.Fill(dt)
    End Sub

    Public Sub loadComboUTypes()
        Cons()
        frmNewUser.cboUType.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM usertypes", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrUTypeID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrUTypeID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmNewUser.cboUType.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Public Sub loadSystemUsers()
        Cons()
        frmSystemUsers.lvw.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM userlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrSysUID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrSysUID(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = arrSysUID(x)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT * FROM userlogs WHERE uLogID=(SELECT max(uLogID) FROM userlogs WHERE uID=" & arrSysUID(x) & ")", con)
                daLog.Fill(dtLog)
                If dtLog.Rows.Count > 0 Then
                    lst.SubItems.Add(Format(dtLog.Rows(0).Item(3), "yyyy-MM-dd") & " " & dtLog.Rows(0).Item(2))
                    lst.SubItems.Add(dtLog.Rows(0).Item(4).ToString)
                Else
                    lst.SubItems.Add("")
                    lst.SubItems.Add("")
                End If
                frmSystemUsers.lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub myAccountInfo(ByVal userID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM userlist AS L LEFT JOIN usertypes AS T ON L.utypeid=T.utypeID WHERE L.uID=" & userID, con)
        da.Fill(dt)
        frmUserAccount.lblFullName.Text = dt.Rows(0).Item(3).ToString
        frmUserAccount.lblPosition.Text = dt.Rows(0).Item(5).ToString
        frmUserAccount.lblUsername.Text = dt.Rows(0).Item(1).ToString
        frmUserAccount.lblUserType.Text = dt.Rows(0).Item(9).ToString
    End Sub

    Public Function memoSeq(ByVal thisYear As Integer) As String
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblmemonumseq WHERE memYear=" & thisYear, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            memoSeq = thisYear & Format((Val(dt.Rows(0).Item(2)) + 1), "000#")
            memosequence = Val(dt.Rows(0).Item(2))
        Else
            Dim cmd As New MySqlCommand("INSERT INTO tblmemonumseq(memYear, memSeq) VALUES(" & thisYear & ",0)", con)
            cmd.ExecuteNonQuery()
            memosequence = 0
            memoSeq = thisYear & "0001"
        End If
    End Function
    Public Sub updateMemo(ByVal thisYear)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblmemonumseq WHERE memYear=" & thisYear, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            memosequence = memosequence + 1
            Dim cmd As New MySqlCommand("UPDATE tblmemonumseq SET memSeq=" & memosequence & " WHERE memYear=" & thisYear, con)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New MySqlCommand("INSERT INTO tblmemonumseq(memYear, memSeq) VALUES(" & thisYear & ",0)", con)
            cmd.ExecuteNonQuery()
            memosequence = 0
        End If
    End Sub

    Public Sub AccountsAndConsumerCount()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT COUNT()", con)
        da.Fill(dt)
    End Sub

    Public Sub UserLogData(userID As Integer, LogType As String)
        Cons()
        Dim cmd As New MySqlCommand("INSERT INTO userlogs(uID, logtime, logDate, logType) VALUES(" & userID & ",'" & Format(Now, "hh:mm:ss tt") & "',current_date(),'" & LogType & "')", con)
        cmd.ExecuteNonQuery()
        'MsgBox("")
        Exit Sub
    End Sub

    Public Sub ShowORReport(ORNum As String)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblORRecord AS O LEFT JOIN tblpayment AS P ON O.ORNum=P.ORNumber LEFT JOIN consumerlist AS C ON P.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & ORNum & "'", con)
        'da.Fill(dt)
        da.Fill(frmORReport.reportingdataset.ORDataTable)
        frmORReport.ORReport.RefreshReport()
    End Sub

    Public Sub BillAdjustmentLoad(ByVal aBillID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, C.ConsumerName, A.AccountNo, B.billID, B.useAmount, B.prevTotal, A.AcctID, C.consID, B.isAdjusted, B.envifee, B.classID, B.consump FROM billing AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN userlist AS U ON B.uID=U.uID WHERE B.billID=" & aBillID, con)
        da.Fill(dt)
        adjConID = Val(dt.Rows(0).Item(7).ToString)
        adjAcctID = Val(dt.Rows(0).Item(6).ToString)
        adjBillID = Val(dt.Rows(0).Item(0).ToString)
        frmBillAdjustment.lblConsName.Text = dt.Rows(0).Item(1).ToString
        frmBillAdjustment.lblAccNum.Text = dt.Rows(0).Item(2).ToString
        frmBillAdjustment.lblDate.Text = Format(Now.Date, "MM-dd-yyyy")
        frmBillAdjustment.lblBillNum.Text = dt.Rows(0).Item(0).ToString
        frmBillAdjustment.lblBillAmount.Text = Format(Val(dt.Rows(0).Item(4).ToString), "#,##0.#0")
        frmBillAdjustment.lblPrevMonthBalance.Text = Format(Val(dt.Rows(0).Item(5).ToString), "#,##0.#0")
        frmBillAdjustment.lblEnvi.Text = Val(dt.Rows(0).Item(9).ToString)
        frmBillAdjustment.lblClass.Text = Val(dt.Rows(0).Item(10).ToString)
        AdjustPrevMonthTotal = Val(dt.Rows(0).Item(5).ToString)
        gotConsump = Val(dt.Rows(0).Item(11).ToString)
        frmBillAdjustment.lblPrepared.Text = getUserFullName(loggedUserID)

    End Sub

    Public Sub BillDisputeLoad(ByVal aBillID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, C.ConsumerName, A.AccountNo, B.billID, B.amountBilled, B.prevMonthtotal, A.AcctID, C.consID, B.AdjOrDispRmk, envifee, B.classID FROM tblBills AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN userlist AS U ON B.uID=U.uID WHERE B.billID=" & aBillID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            dispConID = Val(dt.Rows(0).Item(7).ToString)
            dispAcctID = Val(dt.Rows(0).Item(6).ToString)
            dispBillID = Val(dt.Rows(0).Item(0).ToString)
            With frmDisputeForm
                .lblConsName.Text = dt.Rows(0).Item(1).ToString
                .lblAccNum.Text = dt.Rows(0).Item(2).ToString
                .lblDate.Text = Format(Now.Date, "MM-dd-yyyy")
                .lblBillNum.Text = dt.Rows(0).Item(0).ToString
                .lblClass.Text = Val(dt.Rows(0).Item(10).ToString)
                .lblBillAmount.Text = Format(Val(dt.Rows(0).Item(4).ToString), "#,##0.#0")
                .lblPrevMonthBalance.Text = Format(Val(dt.Rows(0).Item(5).ToString), "#,##0.#0")
                .lblPrepared.Text = getUserFullName(loggedUserID)
            End With
            Dim dtDisp As New DataTable
            'Dim daDisp As New MySqlDataAdapter("SELECT billID, max(amountbilled) as MaxAmount, consumption FROM (SELECT * FROM tblbills where acctid=" & dispAcctID & " AND billID != (SELECT max(billID) FROM tblBills WHERE acctID=" & dispAcctID & ") ORDER BY billID DESC LIMIT 3) SUB WHERE amountbilled=(SELECT max(amountbilled) FROM tblbills where acctid=" & dispAcctID & " and billID != (SELECT max(billID) FROM tblbills WHERE acctID=" & dispAcctID & "))", con)
            'Dim daDisp As New MySqlDataAdapter("SELECT billID, max(amountbilled) as MaxAmount, consumption FROM (SELECT * FROM tblbills where acctid=" & dispAcctID & " AND billID < " & aBillID & " ORDER BY billID DESC LIMIT 3) SUB WHERE amountbilled=(SELECT max(amountbilled) FROM tblbills where acctid=" & dispAcctID & " and billID < " & aBillID & ")", con)
            Dim daDisp As New MySqlDataAdapter("SELECT billID, max(amountbilled) as MaxAmount, consumption FROM (SELECT * FROM tblbills where acctid=" & dispAcctID & " AND billID < " & aBillID & " ORDER BY billID DESC LIMIT 3) SUB", con)
            daDisp.Fill(dtDisp)
            If dtDisp.Rows.Count > 0 Then
                Dim checkBill As String = dtDisp.Rows(0).Item(0).ToString
                If checkBill = "" Then
                    MsgBox("Nothing to compare for Dispute", MsgBoxStyle.Exclamation, "No Reference Bill")
                Else
                    With frmDisputeForm
                        .lblEnvi.Text = Format(Val(dtDisp.Rows(0).Item(2).ToString), "#,##0.#0")
                        .lblConsumption.Text = Val(dtDisp.Rows(0).Item(2).ToString)
                        .lblNewAmount.Text = Format(Val(dtDisp.Rows(0).Item(1).ToString), "#,##0.#0")
                        Dim newAmount As Double = Val(dtDisp.Rows(0).Item(1).ToString)
                        Dim disPrevBal As Double = Val(dt.Rows(0).Item(5).ToString)
                        .lblDueAmount.Text = Format(((newAmount + disPrevBal) * 1.1) - disPrevBal, "#,##0.#0")
                        .lblSurcharge.Text = Format((newAmount + disPrevBal) * 0.1, "#,##0.#0")
                    End With
                    frmDisputeForm.StartPosition = FormStartPosition.CenterScreen
                    frmDisputeForm.ShowDialog()
                End If

            Else
                MsgBox("Nothing to compare for Dispute", MsgBoxStyle.Exclamation, "No Reference Bill")
                Exit Sub
            End If

        Else
            MsgBox("Nothing to compare for Dispute", MsgBoxStyle.Exclamation, "No Reference Bill")
            Exit Sub
        End If


    End Sub

    Public Function getUserFullName(ByVal usersID As Integer) As String
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fullname FROM userlist WHERE uID=" & usersID, con)
        da.Fill(dt)
        getUserFullName = dt.Rows(0).Item(0).ToString
    End Function

    Public Sub LoadConsListTransferOwner()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT consID, consumername FROM consumerlist ORDER BY consumername", con)
        da.Fill(dt)
        frmTransferOwner.cboNewOwner.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrTransConsID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrTransConsID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmTransferOwner.cboNewOwner.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If

    End Sub

    Public Sub LoadProvMeterCombo()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        frmTransferMeter.cboProv.Items.Clear()
        frmTransferMeter.cboMun.Items.Clear()
        frmTransferMeter.cboZone.Items.Clear()
        frmTransferMeter.cboBar.Items.Clear()
        frmTransferMeter.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrProvMeterTransID(dt.Rows.Count - 1)
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            For x As Integer = 0 To dt.Rows.Count - 1
                arrProvMeterTransID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmTransferMeter.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
            Next
            frmTransferMeter.cboProv.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub LoadMunMeterCombo(ByVal proID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovID=" & proID, con)
        da.Fill(dt)
        frmTransferMeter.cboMun.Items.Clear()
        frmTransferMeter.cboZone.Items.Clear()
        frmTransferMeter.cboBar.Items.Clear()
        frmTransferMeter.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrMunMeterTransID(dt.Rows.Count - 1)
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            For x As Integer = 0 To dt.Rows.Count - 1
                arrMunMeterTransID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmTransferMeter.cboMun.Items.Add(dt.Rows(x).Item(2).ToString)
                getDefault = Val(dt.Rows(x).Item(3).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
            Next
            frmTransferMeter.cboMun.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub LoadZoneMeterCombo(ByVal muID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE addmunID=" & muID, con)
        da.Fill(dt)
        frmTransferMeter.cboZone.Items.Clear()
        frmTransferMeter.cboBar.Items.Clear()
        frmTransferMeter.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrZoneMeterTransID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrZoneMeterTransID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmTransferMeter.cboZone.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub LoadBarMeterCombo(ByVal zoID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE ZoneID=" & zoID, con)
        da.Fill(dt)
        frmTransferMeter.cboBar.Items.Clear()
        frmTransferMeter.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBarMeterTransID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBarMeterTransID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmTransferMeter.cboBar.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub LoadClusMeterCombo(ByVal brID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT clustersize FROM brgylist WHERE brgyID=" & brID, con)
        da.Fill(dt)
        frmTransferMeter.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 1 To Val(dt.Rows(0).Item(0).ToString)
                frmTransferMeter.cboCluster.Items.Add(x)
            Next
        End If
    End Sub

    Public Function CheckAccountBalance(ByVal aID As Integer, ByVal lvwAccountNo As String) As Boolean
        Dim curBal As Double = 0
        Cons()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("SELECT amountbilled, dueamount, AdjustedAmount, AdjDueAmount, AdjOrDispRmk, duedate FROM tblbills WHERE (billstatus='UNPAID' OR billstatus='LAPSE') AND acctID=" & aID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim chkAdj As String = dt.Rows(x).Item(4).ToString
                Dim chkDue As Date = dt.Rows(x).Item(5)
                Dim nowDate As Date = Now.Date
                Dim ComputeDays As TimeSpan = chkDue - nowDate
                Dim intDays As Integer = ComputeDays.Days
                Dim selAmount As Double = 0
                If chkAdj = "None" Then
                    If intDays <= 0 Then
                        selAmount = Val(dt.Rows(x).Item(1).ToString)
                    Else
                        selAmount = Val(dt.Rows(x).Item(0).ToString)
                    End If
                Else
                    If intDays <= 0 Then
                        selAmount = Val(dt.Rows(x).Item(3).ToString)
                    Else
                        selAmount = Val(dt.Rows(x).Item(2).ToString)
                    End If
                End If
                curBal = curBal + selAmount
            Next
        Else
            curBal = 0
        End If
        consBalance = curBal
        If consBalance = 0 Then
            CheckAccountBalance = True
        Else
            CheckAccountBalance = False
        End If
    End Function

    Public Sub WaterBillingQuery(strQuery As String)
        Cons()
        Dim newQuery As String = strQuery
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(newQuery, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            frmBilling.lvw.Items.Clear()
            billRowCount = dt.Rows.Count
            ReDim arrBillMetID(dt.Rows.Count - 1)
            ReDim arrBillingMetID(dt.Rows.Count - 1)
            ReDim arrBillAcctID(dt.Rows.Count - 1)
            billPrintPageCount = dt.Rows.Count
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillMetID(x) = dt.Rows(x).Item(0)
                arrBillingMetID(x) = dt.Rows(x).Item(0)
                arrBillAcctID(x) = dt.Rows(x).Item(1)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(14).ToString
                lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(20).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(21).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(22).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(18).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(19), "MM-dd-yyyy"))
                lst.SubItems.Add(Format((Val(dt.Rows(x).Item(23).ToString) - Val(dt.Rows(x).Item(26).ToString)), "#,##0.#0"))
                lst.SubItems.Add(Format((Val(dt.Rows(x).Item(23).ToString) - Val(dt.Rows(x).Item(26).ToString) + Val(dt.Rows(x).Item(31).ToString)), "#,##0.#0"))
                frmBilling.lvw.Items.Add(lst)
            Next
            BCount = dt.Rows.Count
            'BBillDate = dt.Rows(0).Item(65)
            BdateGen = "TODAY"
        Else
            billRowCount = 0
        End If
    End Sub

    Public Sub MonthlySalesReport(strMonth As String, strYear As String)
        Dim totBillCol As Double
        Dim totInstall As Double
        Dim totTrans As Double
        Dim totOwn As Double
        Dim totRec As Double
        Dim totEnvi As Double
        Cons()
        strMonthlySalesQuery = "SELECT datepayment, sum(billpayment), sum(installpayment), sum(meterpayment), sum(ownerpayment), sum(reconnectpayment), sum(servicepayment), sum(advancepayment), sum(enviFee) FROM poseidondb.tblpaymentlogs WHERE monthpayment='" & strMonth & "' AND yearpayment='" & strYear & "' GROUP BY datepayment"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strMonthlySalesQuery, con)
        da.Fill(dt)
        frmMonthlySalesReport.lvwMonthly.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = Format(dt.Rows(x).Item(0), "dd")
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(1).ToString), "#,##0.#0"))
                totBillCol = totBillCol + Val(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(2).ToString), "#,##0.#0"))
                totInstall = totInstall + Val(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                totTrans = totTrans + Val(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(4).ToString), "#,##0.#0"))
                totOwn = totOwn + Val(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(5).ToString), "#,##0.#0"))
                totRec = totRec + Val(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(8).ToString), "#,##0.#0"))
                totEnvi = totEnvi + Val(dt.Rows(x).Item(8).ToString)
                frmMonthlySalesReport.lvwMonthly.Items.Add(lst)
            Next
            Dim lst1 As New ListViewItem
            lst1.Text = ""
            lst1.SubItems.Add(Format(totBillCol, "#,##0.#0"))
            lst1.SubItems.Add(Format(totInstall, "#,##0.#0"))
            lst1.SubItems.Add(Format(totTrans, "#,##0.#0"))
            lst1.SubItems.Add(Format(totOwn, "#,##0.#0"))
            lst1.SubItems.Add(Format(totRec, "#,##0.#0"))
            lst1.SubItems.Add(Format(totEnvi, "#,##0.#0"))
            frmMonthlySalesReport.lvwMonthly.Items.Add(lst1)

            Dim lst2 As New ListViewItem
            lst2.Text = ""
            lst2.SubItems.Add("")
            lst2.SubItems.Add("")
            lst2.SubItems.Add("")
            lst2.SubItems.Add("")
            lst2.SubItems.Add("Total")
            lst2.SubItems.Add(Format(totBillCol + totInstall + totTrans + totOwn + totRec - totEnvi, "#,##0.#0"))
            frmMonthlySalesReport.lvwMonthly.Items.Add(lst2)
        End If
    End Sub

    Public Sub DisconnectionNotice()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT discnote FROM disconnectionnote WHERE discID=1", con)
        da.Fill(dt)
        discNote = dt.Rows(0).Item(0).ToString
        frmDisconnectionNoticeSetting.txtNote.Text = discNote
    End Sub

    Public Function currentOR(uID As Integer) As String
        Dim checkCurOR As String
        Dim checkCurNum As Integer
        'Dim checkORCount As Integer
        Dim newCurNum As Integer
        Dim newCurOR As String
        Cons()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblcurrentor WHERE uID=" & uID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            checkCurNum = dt.Rows(0).Item(1)
            checkCurOR = Format(checkCurNum, "000000#")
            newCurNum = checkCurNum + 1
            currentOR = Format(newCurNum, "000000#")
        Else
            Dim cmd As New MySqlCommand("INSERT INTO tblcurrentor(currentornum, uID) VALUES(0, " & uID & ")", con)
            cmd.ExecuteNonQuery()
            checkCurNum = 0
            checkCurOR = Format(checkCurNum, "000000#")
        End If

    End Function

    Public Function GetCurrentOR(userID As Integer) As String
        Dim checkCurOR As Integer = 0
    End Function


    Public Sub updateCurOR(curNum As Integer)
        Cons()
        curNum = curNum
        Dim cmd As New MySqlCommand("UPDATE tblcurrentor SET currentornum=" & curNum & " WHERE uID=" & loggedUserID, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SeniorDisc(amount As Double, index As Integer)
        discPayment(index) = amount - (amount * 0.05)
    End Sub

    Public Sub LoadAccountSeries()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT G.acctcodeid, B.brgyID, B.addbrgy, G.series FROM acctcodegen AS G LEFT JOIN brgylist AS B ON G.brgyID=B.brgyID", con)
        da.Fill(dt)
        frmAccountNumberSeries.lvw.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrAccCodeGID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAccCodeGID(x) = Val(dt.Rows(x).Item(0).ToString)
                Dim brgID As Integer = Val(dt.Rows(x).Item(1).ToString)
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(AccountCode(brgID))
                'lst.SubItems.Add(LatestAcctCode(brgID))
                frmAccountNumberSeries.lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub loadAllBars()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist ORDER BY addbrgy", con)
        da.Fill(dt)
        frmAddAccountSeries.cboBarangay.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBaraID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBaraID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmAddAccountSeries.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub


    Public Sub LoadAnnualSalesReport(sqlstr As String)
        AnnualSqlStr = sqlstr
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlstr, con)
        da.Fill(dt)
        frmAnnualSales.lvwMonthly.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(7).ToString
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(0).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(1).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(2).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(4).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(10).ToString), "#,##0.#0"))
                frmAnnualSales.lvwMonthly.Items.Add(lst)
            Next
        End If
    End Sub
    Public Function checkAdjustment(billID As Integer) As Boolean
        Dim getRmk As String
        Dim getstat As String
        Dim checked As Boolean
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT billID, isAdjusted, billstat FROM billing WHERE billID=" & billID, con)
        da.Fill(dt)
        getRmk = dt.Rows(0).Item(1).ToString
        getstat = dt.Rows(0).Item(2).ToString
        If getRmk = "No" Then
            If getstat = "PAID" Then
                MsgBox("Bill has already been settled", MsgBoxStyle.Exclamation, "Can't Adjust Bill")
            Else
                checked = True
            End If
        ElseIf getRmk = "Adjusted" Then
            MsgBox("Already Adjusted", MsgBoxStyle.Exclamation, "Can't Adjust Bill")
            checked = False
        ElseIf getRmk = "Disputed" Then
            MsgBox("Already Disputed", MsgBoxStyle.Exclamation, "Can't Adjust Bill")
            checked = False
        End If
        checkAdjustment = checked
    End Function

    Public Sub LoadLatestApplicants()
        Cons()
        frmApplicantsStatus.lvwAppli.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.brgyid, B.AddBrgy, count(*) AS totals, (SELECT count(brgyid) FROM consumeraccounts WHERE (acctstatus=1 or acctstatus=4 or acctstatus=5 or acctstatus=6) and brgyid=B.brgyid) AS Installed, (SELECT count(brgyid) FROM consumeraccounts WHERE (acctstatus=2 or acctstatus=3 or acctstatus=7) and brgyid=B.brgyid) AS Uninstalled, (SELECT count(brgyid) FROM consumeraccounts WHERE brgyid=B.brgyid) AS TotalAppl  FROM poseidondb.consumeraccounts AS A LEFT JOIN brgylist AS B ON A.brgyID=A.brgyID GROUP BY B.addbrgy", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem()
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                frmApplicantsStatus.lvwAppli.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub LoadAdjustedBillsReport(vFrom As Date, vTo As Date)
        Cons()
        Dim strQ As String = "SELECT B.billID, A.acctID, C.consID, A.accountNO, C.consumername, B.billstatus, B.amountbilled, B.AdjustedAmount, B.amountpaid, P.Surcharge, B.billpaymentdate, B.adjDate, U.fullname AS Prep, V.fullname AS Approv  FROM tblbills AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN tblpayment AS P ON B.billID=P.billID LEFT JOIN userlist AS U ON B.adjPrep=U.uID LEFT JOIN userlist AS V ON B.adjApprover=V.uID WHERE AdjOrDispRmk='Adjustment' AND (b.adjdate BETWEEN '" & Format(vFrom, "yyyy-MM-dd") & "' AND '" & Format(vTo, "yyyy-MM-dd") & "')"
        strQueryAdjusted = strQ
        frmAdjustedBillsList.lvwAdjustedBills.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strQ, con)
        da.Fill(dt)
        qAdjCount = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            ReDim arrBillAdjMemo(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrBillAdjMemo(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(8).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(9).ToString), "#,##0.#0"))
                Try
                    lst.SubItems.Add(Format(dt.Rows(x).Item(10), "MM-dd-yyyy"))
                Catch ex As Exception
                    lst.SubItems.Add("")
                End Try
                Try
                    lst.SubItems.Add(Format(dt.Rows(x).Item(11), "MM-dd-yyyy"))
                Catch ex As Exception
                    lst.SubItems.Add("")
                End Try
                lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(13).ToString)
                frmAdjustedBillsList.lvwAdjustedBills.Items.Add(lst)
            Next
            InsertLog(loggedUserID, "Generated Report", "Adjust Bills List", "Generated Report of Adjusted Bills Dated from " & vFrom & " to " & vTo)
        End If
    End Sub

    Public Sub LoadDisputedListReport(vFrom As Date, vTo As Date)
        Cons()
        Dim strQ As String = "SELECT B.billID, A.acctID, C.consID, A.accountNO, C.consumername, B.billstatus, B.amountbilled, B.AdjustedAmount, B.amountpaid, P.Surcharge, B.billpaymentdate, B.adjDate, U.fullname AS Prep, V.fullname AS Approv  FROM tblbills AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN tblpayment AS P ON B.billID=P.billID LEFT JOIN userlist AS U ON B.adjPrep=U.uID LEFT JOIN userlist AS V ON B.adjApprover=V.uID WHERE AdjOrDispRmk='Dispute' AND (b.adjdate BETWEEN '" & Format(vFrom, "yyyy-MM-dd") & "' AND '" & Format(vTo, "yyyy-MM-dd") & "')"
        strQueryDisputed = strQ
        frmDisputedBillsList.lvwDisputedBills.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strQ, con)
        da.Fill(dt)
        qDispCount = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            ReDim arrBillDispMemo(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrBillDispMemo(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(8).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(9).ToString), "#,##0.#0"))
                Try
                    lst.SubItems.Add(Format(dt.Rows(x).Item(10), "MM-dd-yyyy"))
                Catch ex As Exception
                    lst.SubItems.Add("")
                End Try
                Try
                    lst.SubItems.Add(Format(dt.Rows(x).Item(11), "MM-dd-yyyy"))
                Catch ex As Exception
                    lst.SubItems.Add("")
                End Try
                lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(13).ToString)
                frmDisputedBillsList.lvwDisputedBills.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ApprovalRequests(iIndex As Integer)
        Dim choi As String = ""
        If iIndex = 1 Then
            choi = "Adjustment"
            adjIndex = iIndex
        ElseIf iIndex = 2 Then
            choi = "Dispute"
            adjIndex = iIndex
        End If
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, A.AccountNO, C.consumername, B.billDate, B.origamount, B.adjustedamount, B.adjDate  FROM tblBills AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID WHERE adjConf='Pending' AND AdjOrDispRmk='" & choi & "'", con)
        da.Fill(dt)
        frmApprovalRequests.lvwRequests.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrAppAcctID(dt.Rows.Count - 1)
            ReDim arrAppBillID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrAppBillID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrAppAcctID(x) = Val(dt.Rows(x).Item(1).ToString)
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(4), "MM-dd-yyyy"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(5).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(dt.Rows(x).Item(7), "MM-dd-yyyy"))
                frmApprovalRequests.lvwRequests.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub LoadNotes(userID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblNotes WHERE uID=" & userID, con)
        da.Fill(dt)
        frmNotes.lvwNotes.Items.Clear()

        If dt.Rows.Count > 0 Then
            ReDim noteIDs(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                noteIDs(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString.Replace("''", "'"))
                lst.SubItems.Add(Format(dt.Rows(x).Item(6), "MM-dd-yyyy"))
                frmNotes.lvwNotes.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub LoadSystemHistory()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT S.syslogid, s.uID, u.fullname, S.logtime, S.logdate, S.logtransaction, S.formaccessed, S.remarks FROM tblsystemlogs AS S LEFT JOIN userlist AS U ON S.uID=U.uID ORDER BY S.syslogid DESC", con)
        da.Fill(dt)
        frmSystemHistory.lvwLogs.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = Val(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(4), "MM/dd/yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                frmSystemHistory.lvwLogs.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub InsertLog(ByVal uID As Integer, transact As String, formaccess As String, remarks As String)
        Cons()
        Dim cmd As New MySqlCommand("INSERT INTO tblsystemlogs(uID, logtime, logdate, logdatetime,logtransaction, formaccessed, remarks) VALUES(" & loggedUserID & ",current_time(),current_date(),now(),'" & transact & "','" & formaccess & "','" & remarks & "')", con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub ViewEnviFeeReport(eFrom As Date, eTo As Date)
        Dim eQuer As String = "SELECT bl.brgyid, bl.addbrgy, sum(envifee) as TotalEnvi, Sum(if(billstatus='PAID',envifee,0)) as Collected, SUM(if(billstatus='UNPAID' or billstatus='LAPSE',envifee,0)) AS Collectibles FROM brgylist AS BL LEFT JOIN consumeraccounts AS A ON BL.brgyID=A.brgyID LEFT JOIN tblbills AS B ON B.acctID=A.acctID WHERE B.billdate BETWEEN '" & Format(eFrom, "yyyy-MM-dd") & "' AND '" & Format(eTo, "yyyy-MM-dd") & "' GROUP BY BL.brgyID"
        Cons()
        strQuertyEnvi = eQuer
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(eQuer, con)
        da.Fill(dt)
        frmEnviFeeReport.lvwEnviFee.Items.Clear()
        enFeeCount = 0

        If dt.Rows.Count > 0 Then
            enFeeCount = dt.Rows.Count
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(4).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(2).ToString), "#,##0.#0"))
                frmEnviFeeReport.lvwEnviFee.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ViewLedger(acID As Integer)
        Cons()
        selectedAcctLedgerID = acID
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.AccountNo, C.Consumername, Z.ZoneNum, CT.clusterName, A.StreetAddress, B.addbrgy, Cl.Classification, A.MeterNo, A.MeterSize, A.MeterBrand, A.ConnectionDate, A.meterreference, A.AccountName, A.AcctStatus, Sta.StatusName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN zones AS Z ON B.zoneID=Z.zoneID LEFT JOIN classifications AS CL ON A.classID=CL.classID LEFT JOIN clusterlist AS CT ON A.clusterID=CT.clusterID LEFT JOIN accountstatus AS Sta ON A.AcctStatus=Sta.staID WHERE A.AcctID=" & acID, con)
        da.Fill(dt)
        With frmAccountLedger
            .lblAccount.Text = dt.Rows(0).Item(0).ToString
            .lblAccountName.Text = dt.Rows(0).Item(12).ToString
            .lblName.Text = dt.Rows(0).Item(1).ToString
            .lblZone.Text = dt.Rows(0).Item(2).ToString
            .lblCluster.Text = dt.Rows(0).Item(3).ToString
            .lblAddress.Text = dt.Rows(0).Item(4).ToString & ", " & dt.Rows(0).Item(5).ToString
            .lblClass.Text = dt.Rows(0).Item(6).ToString
            .lblMetNum.Text = dt.Rows(0).Item(7).ToString
            .lblMetSize.Text = dt.Rows(0).Item(8).ToString
            .lblMetBrand.Text = dt.Rows(0).Item(9).ToString
            .lblCurRead.Text = dt.Rows(0).Item(11).ToString
            .lblStat.Text = dt.Rows(0).Item(14).ToString
            Dim staNam As String = dt.Rows(0).Item(14).ToString
            If staNam = "Connected" Then
                .lblStat.BackColor = Color.Green
            ElseIf staNam = "Disconnected" Then
                .lblStat.BackColor = Color.Red
            ElseIf staNam = "Installation" Then
                .lblStat.BackColor = Color.Blue
            ElseIf staNam = "Disconnection" Then
                .lblStat.BackColor = Color.Gray
            ElseIf staNam = "Meter Transfer" Then
                .lblStat.BackColor = Color.Yellow
            ElseIf staNam = "Name Transfer" Then
                .lblStat.BackColor = Color.Yellow
            ElseIf staNam = "Temporary Close" Then
                .lblStat.BackColor = Color.Orange
            End If
            Try
                .lblConDate.Text = Format(dt.Rows(0).Item(10), "MMM dd, yyyy")
            Catch ex As Exception
                .lblConDate.Text = ""
            End Try
            Dim dtTrans As New DataTable
            Dim daTrans As New MySqlDataAdapter("SELECT B.billID, B.billNo, B.billPeriod, B.dueDate, B.paymentDate, B.prevRead, B.presRead, B.consump, B.useAmount, B.penalty, B.useADue, B.AmountPaid, B.ORNumPaid, B.billstat FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CL ON B.classID=CL.classID LEFT JOIN brgylist AS BG ON A.brgyID=BG.brgyID LEFT JOIN userlist AS U ON B.uID=U.uID WHERE B.acctID=" & acID, con)
            daTrans.Fill(dtTrans)
            frmAccountLedger.lvwLedger.Items.Clear()
            If dtTrans.Rows.Count > 0 Then
                ReDim arrBillIDLedger(dtTrans.Rows.Count - 1)
                For x As Integer = 0 To dtTrans.Rows.Count - 1
                    Dim lst As New ListViewItem
                    Dim chargess As Double
                    Dim dueDate As Date = Format(dtTrans.Rows(x).Item(3), "yyyy-MM-dd")
                    Dim todayDate As Date = Format(Today.Date, "yyyy-MM-dd")
                    Dim lapseDays As Integer = DateDiff(DateInterval.Day, dueDate, todayDate)
                    'MsgBox(lapseDays)
                    arrBillIDLedger(x) = Val(dtTrans.Rows(x).Item(0).ToString)
                    lst.Text = dtTrans.Rows(x).Item(0).ToString() '0 BILL NO
                    lst.SubItems.Add(dtTrans.Rows(x).Item(2).ToString) '1 BILL PERIOD
                    lst.SubItems.Add(Format(dtTrans.Rows(x).Item(3), "yyyy-MM-dd")) '2 DUE DATE
                    Dim transDate As String
                    Try
                        transDate = Format(dtTrans.Rows(x).Item(4), "yyyy-MM-dd")
                    Catch ex As Exception
                        transDate = ""
                    End Try
                    lst.SubItems.Add(transDate) '3 PAYMENT DATE
                    lst.SubItems.Add(dtTrans.Rows(x).Item(5).ToString()) '4 PREVIOUS READING
                    lst.SubItems.Add(dtTrans.Rows(x).Item(6).ToString()) '5 PRESENT READING
                    lst.SubItems.Add(dtTrans.Rows(x).Item(7).ToString()) '6 CONSUMPTION
                    lst.SubItems.Add(Format(Val(dtTrans.Rows(x).Item(8).ToString()), "#,##0.#0")) '7 BILL AMOUNT
                    chargess = Val(dtTrans.Rows(x).Item(9).ToString())
                    lst.SubItems.Add(Format(chargess, "#,##0.#0")) '8 PENALTY
                    Dim mPayment As Double = 0
                    Dim mBalance As Double = 0
                    Dim mAdjustment As Double = 0
                    Dim checkPaid As String = dtTrans.Rows(x).Item(13).ToString()
                    If checkPaid = "PAID" Then
                        mPayment = Val(dtTrans.Rows(x).Item(11).ToString())
                        'mAdjustment = Val(dtTrans.Rows(x).Item(32).ToString())
                    ElseIf checkPaid = "UNPAID" And lapseDays >= 0 Then
                        mBalance = Val(dtTrans.Rows(x).Item(8).ToString())
                    ElseIf checkPaid = "UNPAID" And lapseDays < 0 Then
                        mBalance = Val(dtTrans.Rows(x).Item(10).ToString())
                    ElseIf checkPaid = "LAPSE" Then
                        mBalance = Val(dtTrans.Rows(x).Item(10).ToString())
                    End If
                    lst.SubItems.Add(Format(mPayment, "#,##0.#0")) '9 PAYMENT
                    lst.SubItems.Add(Format(mBalance, "#,##0.#0")) '10 BALANCE
                    Dim getStrOR As String = Format(Val(dtTrans.Rows(x).Item(12).ToString()), "000000#")
                    Dim newstrOR As String = ""
                    If getStrOR = "0000000" Then
                        newstrOR = ""
                    Else
                        newstrOR = Format(Val(dtTrans.Rows(x).Item(12).ToString()), "000000#")
                    End If
                    lst.SubItems.Add(newstrOR) '11 OR Number
                    lst.SubItems.Add(dtTrans.Rows(x).Item(13).ToString())
                    .lvwLedger.Items.Add(lst)
                Next
            End If

        End With

    End Sub

    Public Sub TransferShow(ByVal aID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, C.consumername, A.AccountNo FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE acctID=" & aID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            SelectedAccountIDTransfer = Val(dt.Rows(0).Item(0).ToString)
            SelectedConsumerIDTransfer = Val(dt.Rows(0).Item(1).ToString)
            With frmTransferOwner
                .lblCurrent.Text = dt.Rows(0).Item(2).ToString
                .lblAccount.Text = dt.Rows(0).Item(3).ToString
                .txtOR.Text = ""
                .StartPosition = FormStartPosition.CenterScreen
                frmTransferOwner.lblCheckOR.Visible = False
                GoodForOwnerTransfer = False
                .ShowDialog()
            End With
        End If
    End Sub

    Public Sub TransMeterShow(ByVal aID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, C.consID, A.accountNo, A.brgyID, A.clusterID, C.Consumername, A.sequence FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE a.acctID=" & aID, con)
        da.Fill(dt)
        frmTransferMeter.lblConsName.Text = dt.Rows(0).Item(5).ToString
        frmTransferMeter.lblAccount.Text = dt.Rows(0).Item(2).ToString
        metTranBrgyID = Val(dt.Rows(0).Item(3).ToString)
        metTranClusID = Val(dt.Rows(0).Item(4).ToString)
        metTranConsID = Val(dt.Rows(0).Item(1).ToString)
        metTranSeqID = Val(dt.Rows(0).Item(6).ToString)
        metTranAcctID = dt.Rows(0).Item(0).ToString
        frmTransferMeter.StartPosition = FormStartPosition.CenterScreen
        frmTransferMeter.ShowIcon = False
        frmTransferMeter.ShowInTaskbar = False
        frmTransferMeter.ShowDialog()
    End Sub

    Public Sub PendingStatus()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT count(if(acctstatus=1,1,null)) AS Connected, count(if(acctstatus=2,1,null)) AS Disconnected,count(if(acctstatus=3,1,null)) AS Installation, count(if(acctstatus=4,1,null)) AS Disconnection, count(if(acctstatus=5,1,null)) AS MetTransfer, count(if(acctstatus=6,1,null)) AS NameTransfer, count(if(acctstatus=7,1,null)) AS Reconnection FROM consumeraccounts", con)
        da.Fill(dt)
        statCon = Val(dt.Rows(0).Item(0).ToString)
        statDiscon = Val(dt.Rows(0).Item(1).ToString)
        statInstall = Val(dt.Rows(0).Item(2).ToString)
        statDisconnection = Val(dt.Rows(0).Item(3).ToString)
        statMetTrans = Val(dt.Rows(0).Item(4).ToString)
        statNameTrans = Val(dt.Rows(0).Item(5).ToString)
        statRecon = Val(dt.Rows(0).Item(6).ToString)
        frmAdminPanel.lblPendingStatus.Text = "Pending Accounts (|Instalaltion: " & statInstall & " |Disconnection: " & statDisconnection & " |Meter Transfer: " & statMetTrans & " |Name Transfer: " & statNameTrans & " |Reconnection: " & statRecon & " |)"

        Dim dtA As New DataTable
        Dim daA As New MySqlDataAdapter("SELECT count(*) FROM consumeraccounts", con)
        daA.Fill(dtA)

        Dim dtC As New DataTable
        Dim daC As New MySqlDataAdapter("SELECT count(*) FROM consumerlist", con)
        daC.Fill(dtC)

        frmAdminPanel.lblAccConsCount.Text = "Accounts: " & Format(Val(dtA.Rows(0).Item(0).ToString), "#,##0") & " | Consumers: " & Format(Val(dtC.Rows(0).Item(0).ToString), "#,##0")

    End Sub

    Public Sub CollectiblesReport()
        Cons()
        Dim col1 As Double = 0
        Dim col2 As Double = 0
        Dim col3 As Double = 0
        Dim env1 As Double = 0
        Dim env2 As Double = 0
        Dim env3 As Double = 0

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT BR.addbrgy, SUM(B.amountPaid) AS Collected, SUM(IF(billstatus='UNPAID' OR billstatus='LAPSE',IF(B.DueDate>current_date(),if(B.AdjOrDispRmk='None',B.dueamount,B.adjdueamount), if(B.adjordisprmk='None',B.amountbilled,B.adjustedamount)),0)) AS Collectible, SUM(IF(B.billstatus='PAID',B.enviFee,0)) AS CollectedEnviFee, SUM(IF(B.billstatus='UNPAID' OR b.billstatus='LAPSE',B.enviFee,0)) AS CollectibleEnviFee FROM brgylist AS BR LEFT JOIN consumeraccounts AS A ON BR.brgyID=A.brgyID LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN tblBills as B ON A.acctID=B.acctID GROUP BY BR.brgyid", con)
        da.Fill(dt)
        frmCollectiblesReport.lvwCollectiblesReport.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count
                Dim lst As New ListViewItem
                If x < dt.Rows.Count Then
                    lst.Text = dt.Rows(x).Item(0).ToString
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(1).ToString), "#,##0.#0"))
                    col1 = col1 + Val(dt.Rows(x).Item(1).ToString)
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(2).ToString), "#,##0.#0"))
                    col2 = col2 + Val(dt.Rows(x).Item(2).ToString)
                    lst.SubItems.Add(Format((Val(dt.Rows(x).Item(1).ToString) + Val(dt.Rows(x).Item(2).ToString)), "#,##0.#0"))
                    col3 = col3 + Val(dt.Rows(x).Item(1).ToString) + Val(dt.Rows(x).Item(2).ToString)
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                    env1 = env1 + Val(dt.Rows(x).Item(3).ToString)
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(4).ToString), "#,##0.#0"))
                    env2 = env2 + Val(dt.Rows(x).Item(4).ToString)
                    lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString) + Val(dt.Rows(x).Item(4).ToString), "#,##0.#0"))
                    env3 = env3 + Val(dt.Rows(x).Item(3).ToString) + Val(dt.Rows(x).Item(4).ToString)
                End If
                If x = dt.Rows.Count Then
                    lst.Text = "Total"
                    lst.SubItems.Add(Format(col1, "#,##0.#0"))
                    lst.SubItems.Add(Format(col2, "#,##0.#0"))
                    lst.SubItems.Add(Format(col3, "#,##0.#0"))
                    lst.SubItems.Add(Format(env1, "#,##0.#0"))
                    lst.SubItems.Add(Format(env2, "#,##0.#0"))
                    lst.SubItems.Add(Format(env3, "#,##0.#0"))
                End If
                frmCollectiblesReport.lvwCollectiblesReport.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ReportFilterSelector(filterIndex As Integer, formIndex As Integer)
        repType = formIndex
        If filterIndex = 2 Then
            monthlytransactName(repType)
        ElseIf filterIndex = 3 Then
            annualtransactname(repType)
        End If
        If formIndex = 1 Then
            'Installation
            If filterIndex = 1 Then
                sqlstrDailyInstall = ""
                frmInstallationReportDaily.lvwDailyReport.Items.Clear()
                frmInstallationReportDaily.ShowInTaskbar = False
                frmInstallationReportDaily.StartPosition = FormStartPosition.CenterScreen
                frmInstallationReportDaily.WindowState = FormWindowState.Maximized
                frmInstallationReportDaily.ShowDialog()
            ElseIf filterIndex = 2 Then
                sqlstrMonRepor = ""
                frmMonthlyTransactionReport.lvwTransact.Items.Clear()
                frmMonthlyTransactionReport.ShowInTaskbar = False
                frmMonthlyTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmMonthlyTransactionReport.WindowState = FormWindowState.Maximized
                frmMonthlyTransactionReport.ShowDialog()
            ElseIf filterIndex = 3 Then
                sqlstrAnnualRepor = ""
                frmAnnualTransactionReport.lvwTransact.Items.Clear()
                frmAnnualTransactionReport.ShowInTaskbar = False
                frmAnnualTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmAnnualTransactionReport.WindowState = FormWindowState.Maximized
                frmAnnualTransactionReport.ShowDialog()
            End If
        ElseIf formIndex = 2 Then
            'Transfer Meter
            If filterIndex = 1 Then
                sqlStrDailyTransMet = ""
                frmTransferMeterDailyReport.lvwDailyReport.Items.Clear()
                frmTransferMeterDailyReport.ShowInTaskbar = False
                frmTransferMeterDailyReport.StartPosition = FormStartPosition.CenterScreen
                frmTransferMeterDailyReport.WindowState = FormWindowState.Maximized
                frmTransferMeterDailyReport.ShowDialog()
            ElseIf filterIndex = 2 Then
                sqlstrMonRepor = ""
                frmMonthlyTransactionReport.lvwTransact.Items.Clear()
                frmMonthlyTransactionReport.ShowInTaskbar = False
                frmMonthlyTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmMonthlyTransactionReport.WindowState = FormWindowState.Maximized
                frmMonthlyTransactionReport.ShowDialog()
            ElseIf filterIndex = 3 Then
                sqlstrAnnualRepor = ""
                frmAnnualTransactionReport.lvwTransact.Items.Clear()
                frmAnnualTransactionReport.ShowInTaskbar = False
                frmAnnualTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmAnnualTransactionReport.WindowState = FormWindowState.Maximized
                frmAnnualTransactionReport.ShowDialog()
            End If
        ElseIf formIndex = 3 Then
            'Transfer Owner

            If filterIndex = 1 Then
                sqlStrDailyTransOwn = ""
                frmTransferOwnerDailyReport.lvwDailyReport.Items.Clear()
                frmTransferOwnerDailyReport.ShowInTaskbar = False
                frmTransferOwnerDailyReport.StartPosition = FormStartPosition.CenterScreen
                frmTransferOwnerDailyReport.WindowState = FormWindowState.Maximized
                frmTransferOwnerDailyReport.ShowDialog()
            ElseIf filterIndex = 2 Then
                sqlstrMonRepor = ""
                frmMonthlyTransactionReport.lvwTransact.Items.Clear()
                frmMonthlyTransactionReport.ShowInTaskbar = False
                frmMonthlyTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmMonthlyTransactionReport.WindowState = FormWindowState.Maximized
                frmMonthlyTransactionReport.ShowDialog()
            ElseIf filterIndex = 3 Then
                sqlstrAnnualRepor = ""
                frmAnnualTransactionReport.lvwTransact.Items.Clear()
                frmAnnualTransactionReport.ShowInTaskbar = False
                frmAnnualTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmAnnualTransactionReport.WindowState = FormWindowState.Maximized
                frmAnnualTransactionReport.ShowDialog()
            End If
        ElseIf formIndex = 4 Then
            'Reconnection

            If filterIndex = 1 Then
                sqlStrDailyReconnect = ""
                frmReconnectDailyReport.lvwDailyReport.Items.Clear()
                frmReconnectDailyReport.ShowInTaskbar = False
                frmReconnectDailyReport.StartPosition = FormStartPosition.CenterScreen
                frmReconnectDailyReport.WindowState = FormWindowState.Maximized
                frmReconnectDailyReport.ShowDialog()
            ElseIf filterIndex = 2 Then
                sqlstrMonRepor = ""
                frmMonthlyTransactionReport.lvwTransact.Items.Clear()
                frmMonthlyTransactionReport.ShowInTaskbar = False
                frmMonthlyTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmMonthlyTransactionReport.WindowState = FormWindowState.Maximized
                frmMonthlyTransactionReport.ShowDialog()
            ElseIf filterIndex = 3 Then
                sqlstrAnnualRepor = ""
                frmAnnualTransactionReport.lvwTransact.Items.Clear()
                frmAnnualTransactionReport.ShowInTaskbar = False
                frmAnnualTransactionReport.StartPosition = FormStartPosition.CenterScreen
                frmAnnualTransactionReport.WindowState = FormWindowState.Maximized
                frmAnnualTransactionReport.ShowDialog()
            End If
        End If
    End Sub

    Public Sub DailyInstallationReport(myDate As Date)
        Cons()
        sqlstrDailyInstall = "SELECT L.insID, L.acctID, L.consID, L.uID, C.consumername, A.AccountNo, L.InstallDate, U.fullname, L.transactDate FROM tblinstallationlog AS L LEFT JOIN consumeraccounts AS A ON L.acctID=A.acctID LEFT JOIN consumerlist AS C ON L.consID=C.consID LEFT JOIN userlist AS U ON L.uID=U.uID WHERE installdate='" & Format(myDate, "yyyy-MM-dd") & "'"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlstrDailyInstall, con)
        da.Fill(dt)
        frmInstallationReportDaily.lvwDailyReport.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString)
                frmInstallationReportDaily.lvwDailyReport.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub DailyTransferMeterReport(myDate As Date)
        Cons()
        sqlStrDailyTransMet = "SELECT L.transMetID, L.acctID, L.uID, C.consumername, A.accountNO, L.dateoftransfer, L.previousaddress, B.addbrgy, L.prevclusterID, L.presentaddress, BR.addbrgy, L.presclusterID, u.fullname  FROM tbltransfermeterlog AS L LEFT JOIN consumeraccounts AS A ON L.acctID=A.acctID LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN userlist AS U ON L.uID=U.uID LEFT JOIN brgylist AS B ON L.prevbrgyID=B.brgyID LEFT JOIN brgylist AS BR ON L.presentbrgyID=BR.brgyID WHERE L.dateoftransfer='" & Format(myDate, "yyyy-MM-dd") & "'"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlStrDailyTransMet, con)
        da.Fill(dt)
        frmTransferMeterDailyReport.lvwDailyReport.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(5), "MM-dd-yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString & " / " & dt.Rows(x).Item(7).ToString & " / " & dt.Rows(x).Item(8).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString & " / " & dt.Rows(x).Item(10).ToString & " / " & dt.Rows(x).Item(11).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                frmTransferMeterDailyReport.lvwDailyReport.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub DailyTransferOwnReport(myDate As Date)
        Cons()
        sqlStrDailyTransOwn = "SELECT TL.troID, A.acctID, CN.consID, CO.consID, CN.consumerName, A.accountNO, TL.dateTrans, CO.consumername, TL.confirmeddate, U.fullname, UT.fullname  FROM tblTransferOwnLog AS TL LEFT JOIN consumerlist AS CN ON TL.newConsID=CN.consID LEFT JOIN consumerlist AS CO ON TL.prevConsID=CO.consID LEFT JOIN consumeraccounts AS A ON TL.acctID=A.acctID LEFT JOIN userlist AS U ON TL.uID=U.uID LEFT JOIN userlist AS UT ON TL.transbyID=UT.uID WHERE TL.currentdate='" & Format(myDate, "yyyy-MM-dd") & "' AND TL.transstat=1"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlStrDailyTransOwn, con)
        da.Fill(dt)
        frmTransferOwnerDailyReport.lvwDailyReport.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(6), "MM-dd-yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(8), "MM-dd-yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(10).ToString)
                frmTransferOwnerDailyReport.lvwDailyReport.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub DailyReconnect(myDate As Date)
        Cons()
        sqlStrDailyReconnect = "SELECT C.ConsumerName, A.accountNo, R.recondate, R.transactrecondate, U.fullname, v.fullname FROM tblreconnectionlog AS R LEFT JOIN consumerlist as C ON R.consID=C.consID LEFT JOIN consumeraccounts AS A ON R.acctID=A.acctID LEFT JOIN userlist AS U ON R.uID=U.uID LEFT JOIN userlist AS V ON R.recUID=V.uID WHERE transactdate='" & Format(myDate, "yyyy-MM-dd") & "' AND R.recstat=1"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(sqlStrDailyReconnect, con)
        da.Fill(dt)
        frmReconnectDailyReport.lvwDailyReport.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(2), "MM-dd-yyyy"))
                lst.SubItems.Add(Format(dt.Rows(x).Item(3), "MM-dd-yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                frmReconnectDailyReport.lvwDailyReport.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub MonthlyTransactionRerortViewer(mont As String, year As String, reporttype As Integer)
        Dim dt As New DataTable
        dt.Clear()
        frmMonthlyTransactionReport.lvwTransact.Items.Clear()
        sqlstrMonRepor = ""
        If reporttype = 1 Then
            'installation
            sqlstrMonRepor = "SELECT day(installdate), count(*) FROM tblinstallationlog WHERE MONTH(installdate)=" & mont & " and year(installdate)=" & year & " GROUP by day(installdate), month(installdate), year(installdate)"
            Cons()
            Dim da As New MySqlDataAdapter(sqlstrMonRepor, con)
            da.Fill(dt)
        ElseIf reporttype = 2 Then
            'transfer met
            sqlstrMonRepor = "SELECT day(dateoftransfer), count(*) FROM poseidondb.tbltransfermeterlog WHERE MONTH(dateoftransfer)=" & mont & " and year(dateoftransfer)=" & year & " GROUP by day(dateoftransfer), month(dateoftransfer), year(dateoftransfer)"
            Cons()
            Dim da As New MySqlDataAdapter(sqlstrMonRepor, con)
            da.Fill(dt)
        ElseIf reporttype = 3 Then
            'transfer own
            sqlstrMonRepor = "SELECT day(currentdate), count(*) FROM tbltransferownlog WHERE MONTH(currentdate)=" & mont & " and year(currentdate)=" & year & " GROUP by day(currentdate), month(currentdate), year(currentdate)"
            Cons()
            Dim da As New MySqlDataAdapter(sqlstrMonRepor, con)
            da.Fill(dt)
        ElseIf reporttype = 4 Then
            'reconnect
            sqlstrMonRepor = "SELECT day(transactDate), count(*) FROM poseidondb.tblreconnectionlog WHERE MONTH(transactdate)=" & mont & " and year(transactdate)=" & year & " GROUP by day(transactdate), month(transactDate), year(transactdate)"
            Cons()
            Dim da As New MySqlDataAdapter(sqlstrMonRepor, con)
            da.Fill(dt)
        End If
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                frmMonthlyTransactionReport.lvwTransact.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub AnnualTransactionReport(Year As String, reporttype As Integer)
        Cons()
        Dim dt As New DataTable
        dt.Clear()
        frmAnnualTransactionReport.lvwTransact.Items.Clear()
        sqlstrAnnualRepor = ""
        If reporttype = 1 Then
            sqlstrAnnualRepor = "SELECT monthname(installdate), count(*) FROM tblinstallationlog WHERE year(installdate)=" & Year & " GROUP by month(installdate)"
        ElseIf reporttype = 2 Then
            sqlstrAnnualRepor = "SELECT monthname(dateoftransfer), count(*) FROM tbltransfermeterlog WHERE year(dateoftransfer)=" & Year & " GROUP BY month(dateoftransfer);"
        ElseIf reporttype = 3 Then
            sqlstrAnnualRepor = "SELECT monthname(currentdate), count(*) FROM tbltransferownlog WHERE year(currentdate)=" & Year & " GROUP by month(currentdate)"
        ElseIf reporttype = 4 Then
            sqlstrAnnualRepor = "SELECT monthname(transactDate), count(*) FROM tblreconnectionlog WHERE year(transactdate)=" & Year & " GROUP by month(transactdate)"
        End If
        Dim da As New MySqlDataAdapter(sqlstrAnnualRepor, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                frmAnnualTransactionReport.lvwTransact.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub monthlytransactName(reporttype As String)
        If reporttype = 1 Then
            frmMonthlyTransactionReport.Text = "Monthly Installation Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Installation"
        ElseIf reporttype = 2 Then
            frmMonthlyTransactionReport.Text = "Monthly Meter Transfer Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Meter Transfer"
        ElseIf reporttype = 3 Then
            frmMonthlyTransactionReport.Text = "Monthly Owner Transfer Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Owner Transfer"
        ElseIf reporttype = 4 Then
            frmMonthlyTransactionReport.Text = "Monthly Reconnection Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Reconnection"
        End If
    End Sub

    Public Sub annualtransactname(reporttype As Integer)
        If reporttype = 1 Then
            frmMonthlyTransactionReport.Text = "Annual Installation Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Installation"
        ElseIf reporttype = 2 Then
            frmMonthlyTransactionReport.Text = "Annual Meter Transfer Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Meter Transfer"
        ElseIf reporttype = 3 Then
            frmMonthlyTransactionReport.Text = "Annual Owner Transfer Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Owner Transfer"
        ElseIf reporttype = 4 Then
            frmMonthlyTransactionReport.Text = "Annual Reconnection Report"
            frmMonthlyTransactionReport.clmCount.Text = "No. of Reconnection"
        End If
    End Sub

    Public Sub ORNumSelected(ORNum As String)

        Cons()
        Dim totAm As Double = 0
        With frmORList
            .lblOR.Text = ""
            .lblConsumer.Text = ""
            .lblDate.Text = ""
            .lvw.Items.Clear()
            .lblType.Text = ""
            .lblDraweeNum.Text = ""
            .lblDrawee.Text = ""
            .lblDraweeDate.Text = ""
            .lblAmount.Text = ""
            .lblWords.Text = ""
            .lblDiscType.Text = ""
            .lblHolder.Text = ""
            .lblID.Text = ""
            .lblDiscount.Text = ""
            .lblOfficer.Text = ""

        End With

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE ORNum='" & ORNum & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            With frmORList
                Dim orRmk As String = dt.Rows(0).Item(45).ToString
                If orRmk = "Cancelled" Then
                    .lvw.BackgroundImage = My.Resources.cancelled_white
                    frmORList.btnPrint.Visible = False
                    frmORList.btnCancel.Visible = False
                    frmORList.btnEditOR.Visible = False
                Else
                    .lvw.BackgroundImage = Nothing
                    frmORList.btnPrint.Visible = True
                    frmORList.btnCancel.Visible = True
                    frmORList.btnEditOR.Visible = True
                End If

                .btnDelete.Visible = True
                .lblOR.Text = dt.Rows(0).Item(1).ToString
                .lblDate.Text = dt.Rows(0).Item(10).ToString
                .lblConsumer.Text = dt.Rows(0).Item(55).ToString
                .lblType.Text = dt.Rows(0).Item(3).ToString
                .lblAmount.Text = Format(Val(dt.Rows(0).Item(2).ToString), "#,##0.#0")
                .lblWords.Text = dt.Rows(0).Item(7).ToString & " " & dt.Rows(0).Item(8).ToString
                .lblDraweeNum.Text = dt.Rows(0).Item(5).ToString & dt.Rows(0).Item(43).ToString
                .lblDraweeDate.Text = dt.Rows(0).Item(6).ToString & dt.Rows(0).Item(44).ToString
                .lblDrawee.Text = dt.Rows(0).Item(4).ToString
                .lvw.Items.Clear()
                'First Row
                Dim lst1 As New ListViewItem
                lst1.Text = dt.Rows(0).Item(15).ToString
                lst1.SubItems.Add(dt.Rows(0).Item(23).ToString)
                lst1.SubItems.Add(dt.Rows(0).Item(31).ToString)
                .lvw.Items.Add(lst1)

                'Second Row
                Dim lst2 As New ListViewItem
                lst2.Text = dt.Rows(0).Item(16).ToString
                lst2.SubItems.Add(dt.Rows(0).Item(24).ToString)
                lst2.SubItems.Add(dt.Rows(0).Item(32).ToString)
                .lvw.Items.Add(lst2)

                'Third Row
                Dim lst3 As New ListViewItem
                lst3.Text = dt.Rows(0).Item(17).ToString
                lst3.SubItems.Add(dt.Rows(0).Item(25).ToString)
                lst3.SubItems.Add(dt.Rows(0).Item(33).ToString)
                .lvw.Items.Add(lst3)

                'Fourth Row
                Dim lst4 As New ListViewItem
                lst4.Text = dt.Rows(0).Item(18).ToString
                lst4.SubItems.Add(dt.Rows(0).Item(26).ToString)
                lst4.SubItems.Add(dt.Rows(0).Item(34).ToString)
                .lvw.Items.Add(lst4)

                'Fifth Row
                Dim lst5 As New ListViewItem
                lst5.Text = dt.Rows(0).Item(19).ToString
                lst5.SubItems.Add(dt.Rows(0).Item(27).ToString)
                lst5.SubItems.Add(dt.Rows(0).Item(35).ToString)
                .lvw.Items.Add(lst5)

                'Sixth Row
                Dim lst6 As New ListViewItem
                lst6.Text = dt.Rows(0).Item(20).ToString
                lst6.SubItems.Add(dt.Rows(0).Item(28).ToString)
                lst6.SubItems.Add(dt.Rows(0).Item(36).ToString)
                .lvw.Items.Add(lst6)

                'Seventh Row
                Dim lst7 As New ListViewItem
                lst7.Text = dt.Rows(0).Item(21).ToString
                lst7.SubItems.Add(dt.Rows(0).Item(29).ToString)
                lst7.SubItems.Add(dt.Rows(0).Item(37).ToString)
                .lvw.Items.Add(lst7)

                'Eighth Row
                Dim lst8 As New ListViewItem
                lst8.Text = dt.Rows(0).Item(22).ToString
                lst8.SubItems.Add(dt.Rows(0).Item(30).ToString)
                lst8.SubItems.Add(dt.Rows(0).Item(38).ToString)
                .lvw.Items.Add(lst8)

                '.lvw.Items.AddRange(New ListViewItem() {dt.Rows(0).Item(15).ToString, dt.Rows(0).Item(23).ToString, dt.Rows(0).Item(31).ToString})
                '.lvw.Items.Add(dt.Rows(0).Item(16).ToString, dt.Rows(0).Item(24).ToString, dt.Rows(0).Item(32).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(17).ToString, dt.Rows(0).Item(25).ToString, dt.Rows(0).Item(33).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(18).ToString, dt.Rows(0).Item(26).ToString, dt.Rows(0).Item(34).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(19).ToString, dt.Rows(0).Item(27).ToString, dt.Rows(0).Item(35).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(20).ToString, dt.Rows(0).Item(28).ToString, dt.Rows(0).Item(36).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(21).ToString, dt.Rows(0).Item(29).ToString, dt.Rows(0).Item(37).ToString)
                '.lvw.Items.Add(dt.Rows(0).Item(22).ToString, dt.Rows(0).Item(30).ToString, dt.Rows(0).Item(38).ToString)

                Dim discType As String = dt.Rows(0).Item(12).ToString
                If discType = "YES" Then
                    .lblDiscType.Text = "Senior/PWD"
                Else
                    .lblDiscType.Text = "None"
                End If
                .lblHolder.Text = dt.Rows(0).Item(55).ToString
                .lblID.Text = dt.Rows(0).Item(13).ToString
                .lblDiscount.Text = Format(Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")
                .lblOfficer.Text = dt.Rows(0).Item(39).ToString
            End With
        Else
            frmORList.btnPrint.Visible = False
            frmORList.btnCancel.Visible = False
            frmORList.btnEditOR.Visible = False
            frmORList.btnDelete.Visible = False
            'MessageBox.Show("O.R. Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT O.ORNum, O.pDate, C.consumername, P.collectionnature, P.acctcode, ((P.pAmount) - ifnull(P.surcharge,0) - ifnull(P.enviFee,0)) AS paymentAmount, P.pAmount, P.Surcharge, O.amountinwords, O.pType, O.Numpayment, O.datepayment, O.draweepayment,O.seniorDiscountRmk, O.seniorName, O.seniorID, O.totalDiscount, O.totalPayment, U.fullname, P.enviFee, P.PaymentType, P.billID FROM tblORRecord AS O LEFT JOIN tblpayment AS P ON O.ORNum=P.ORNumber LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & ORNum & "'", con)
        'da.Fill(dt)
        'If dt.Rows.Count > 0 Then
        '    With frmORList

        '        .lblOR.Text = dt.Rows(0).Item(0).ToString
        '        .lblConsumer.Text = dt.Rows(0).Item(2).ToString
        '        .lblDate.Text = dt.Rows(0).Item(1).ToString
        '        For x As Integer = 0 To dt.Rows.Count - 1
        '            Dim checkPType As String = dt.Rows(x).Item(20).ToString
        '            Dim checkDiscount As String = dt.Rows(x).Item(13).ToString
        '            Dim lst As New ListViewItem
        '            If checkPType = "Bill Payment" Then
        '                Dim dtBi As New DataTable
        '                Dim daBi As New MySqlDataAdapter("SELECT monthfrom, monthto, billyear FROM tblBills WHERE billID=" & dt.Rows(x).Item(21).ToString, con)
        '                daBi.Fill(dtBi)
        '                lst.Text = dt.Rows(x).Item(3).ToString & " for " & UCase(dtBi.Rows(0).Item(0).ToString) & " to " & UCase(dtBi.Rows(0).Item(1).ToString) & " " & dtBi.Rows(0).Item(2).ToString
        '            Else
        '                lst.Text = dt.Rows(x).Item(3).ToString
        '            End If

        '            lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
        '            lst.SubItems.Add(Format(Val(dt.Rows(x).Item(5).ToString), "#,##0.#0"))
        '            'lst.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
        '            'totAm = totAm + Val(dt.Rows(x).Item(6).ToString)
        '            .lvw.Items.Add(lst)
        '            If checkPType = "Bill Payment" Then
        '                Dim lstC As New ListViewItem
        '                lstC.Text = "         CONSUMPTION: " & Format(Val(dt.Rows(x).Item(19).ToString), "#,##0")
        '                lstC.SubItems.Add("")
        '                lstC.SubItems.Add("")
        '                .lvw.Items.Add(lstC)
        '                Dim lst1 As New ListViewItem
        '                lst1.Text = "     SURCHARGE"
        '                lst1.SubItems.Add("")
        '                lst1.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
        '                .lvw.Items.Add(lst1)
        '                Dim lst2 As New ListViewItem
        '                lst2.Text = "     ENVIRONMENTAL FEE"
        '                lst2.SubItems.Add("")
        '                lst2.SubItems.Add(Format(Val(dt.Rows(x).Item(19).ToString), "#,##0.#0"))
        '                .lvw.Items.Add(lst2)
        '                If checkDiscount <> "" Then
        '                    Dim lst3 As New ListViewItem
        '                    lst3.Text = "     " & checkDiscount & " Discount"
        '                    lst3.SubItems.Add("")
        '                    lst3.SubItems.Add("-" & Format(Val(dt.Rows(0).Item(16).ToString), "#,##0.#0"))
        '                    .lvw.Items.Add(lst3)
        '                End If
        '                Dim lst4 As New ListViewItem
        '                lst4.Text = "          TOTAL"
        '                lst4.SubItems.Add("")
        '                lst4.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
        '                .lvw.Items.Add(lst4)
        '            End If
        '        Next
        '        .lblType.Text = dt.Rows(0).Item(9).ToString
        '        .lblDraweeNum.Text = dt.Rows(0).Item(10).ToString
        '        .lblDrawee.Text = dt.Rows(0).Item(12).ToString
        '        .lblDraweeDate.Text = dt.Rows(0).Item(11).ToString
        '        .lblAmount.Text = Format(Val(dt.Rows(0).Item(17).ToString), "#,##0.#0")
        '        .lblWords.Text = dt.Rows(0).Item(8).ToString
        '        .lblDiscType.Text = dt.Rows(0).Item(13).ToString
        '        .lblHolder.Text = dt.Rows(0).Item(14).ToString
        '        .lblID.Text = dt.Rows(0).Item(15).ToString
        '        .lblDiscount.Text = Format(Val(dt.Rows(0).Item(16).ToString), "#,##0.#0")
        '        .lblOfficer.Text = dt.Rows(0).Item(18).ToString
        '    End With
        'End If
    End Sub

    Public Sub LoadGeneratedBills()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT BR.brgyID, BA.addbrgy, BR.clusterID, BR.dategenerated, BR.monthfrom, BR.monthTo, BR.billyear, BR.billdate, BR.billCount, U.fullname, BR.repID FROM tblbillreport AS BR LEFT JOIN brgylist AS BA ON BR.brgyID=BA.brgyID LEFT JOIN userlist AS U ON BR.uID=U.uID ORDER BY BR.billGenID DESC", con)
        da.Fill(dt)
        frmBillReport.lvwGenList.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBrBillRepID(dt.Rows.Count - 1)
            ReDim arrMFromRep(dt.Rows.Count - 1)
            ReDim arrMToRep(dt.Rows.Count - 1)
            ReDim arrMyearRep(dt.Rows.Count - 1)
            ReDim arrMCluster(dt.Rows.Count - 1)
            ReDim arrRepIDBill(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                arrBrBillRepID(x) = Val(dt.Rows(x).Item(0).ToString)
                arrMFromRep(x) = dt.Rows(x).Item(4).ToString
                arrMToRep(x) = dt.Rows(x).Item(5).ToString
                arrMyearRep(x) = Val(dt.Rows(x).Item(6).ToString)
                arrRepIDBill(x) = Val(dt.Rows(x).Item(10).ToString)
                arrMCluster(x) = Val(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(Format(dt.Rows(x).Item(3), "MM-dd-yyyy"))
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString & " to " & dt.Rows(x).Item(5).ToString & " " & dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString)
                frmBillReport.lvwGenList.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub SelectGeneratedBill(bgID As Integer, bclus As Integer, bMFrom As String, bMTo As String, bMYear As Integer, bRepID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT C.consumername, A.AccountNo, B.billstatus, B.amountBilled, B.consumption, CL.classification FROM billing AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS CL ON B.classID=CL.classID WHERE A.brgyID=" & bgID & " AND B.cluster=" & bclus & " AND monthFrom='" & bMFrom & "' AND monthTo='" & bMTo & "' AND billyear='" & bMYear & "' AND billRepID=" & bRepID, con)
        da.Fill(dt)
        frmBillReport.lvwBills.Items.Clear()
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(3).ToString), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                frmBillReport.lvwBills.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub LoadMeterReaders()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreader", con)
        da.Fill(dt)
        frmMeterReaders.lvwMet.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrSettingsMetReaderID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrSettingsMetReaderID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString()
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString())
                frmMeterReaders.lvwMet.Items.Add(lst)
            Next
        End If
    End Sub
    Public SELacctZoneID As Integer
    Public ARRacctZoneID() As Integer
    Public SELacctBrgyID As Integer
    Public ARRacctBrgyID() As Integer
    Public SELacctClusterID As Integer
    Public ARRacctClusterID() As Integer
    Public Sub AccountEditorZones()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM zones AS Z left join munlist AS M ON Z.addMunID=M.addMunID WHERE M.mundefault=1", con)
        da.Fill(dt)
        frmUpdateAccountDetails.cboZone.Items.Clear()
        frmUpdateAccountDetails.cboBarangay.Items.Clear()
        frmUpdateAccountDetails.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim ARRacctZoneID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                ARRacctZoneID(x) = Val(dt.Rows(x).Item(0))
                frmUpdateAccountDetails.cboZone.Items.Add(dt.Rows(x).Item(5).ToString)
            Next
        End If
    End Sub

    Public Sub AccountEditorBrgy(zoneID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneID=" & zoneID, con)
        da.Fill(dt)
        frmUpdateAccountDetails.cboBarangay.Items.Clear()
        frmUpdateAccountDetails.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim ARRacctBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                ARRacctBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmUpdateAccountDetails.cboBarangay.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub AccountEditorCluster(brgyID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & brgyID, con)
        da.Fill(dt)
        frmUpdateAccountDetails.cboCluster.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim ARRacctClusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                ARRacctClusterID(x) = Val(dt.Rows(x).Item(0))
                frmUpdateAccountDetails.cboCluster.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub ShowSelectedBillReport(brgyID As Integer, clusterID As Integer, billmonth As String, billyear As Integer)
        Cons()
        'MessageBox.Show(brgyID & " | " & clusterID & " | " & billmonth & " | " & billyear)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, CT.brgyID, CT.clusterID, CL.classID, A.AccountNo, A.AccountName, B.billstat, B.consump, B.totalamountdue, B.EnviFee, CL.classification, B.billNo, B.isSC, B.SCDiscount FROM billing AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS CL ON B.classID=CL.classID LEFT JOIN clusterlist AS CT ON B.clusterID=CT.clusterID WHERE B.clusterID=" & clusterID & " and CT.brgyID=" & brgyID & " and B.billmonth='" & billmonth & "' and B.billyear=" & billyear, con)
        da.Fill(dt)
        frmBillReport.lvwBills.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillRepBillID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillRepBillID(x) = dt.Rows(x).Item(0)
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(12).ToString
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(9)), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(10)), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(11).ToString)
                lst.SubItems.Add(If(dt.Rows(x).Item(13).ToString = "YES", "Senior/PWD", "Regular"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(14)), "#,##0.#0"))
                frmBillReport.lvwBills.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub ShowBillsForRequest()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, B.billNo, CL.consumername, A.accountname, A.accountno, B.consump, B.totalamountdue, A.streetaddress, BR.addbrgy, C.clustername, B.isAdjusted, B.adjRemark FROM billing AS B LEFT JOIN consumerlist AS CL ON B.consID=CL.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN clusterlist AS C ON B.clusterID=C.clusterID LEFT JOIN brgylist AS BR ON C.brgyID=BR.brgyID WHERE B.isAdjusted='Yes' and (B.adjRemark='Marked' or B.adjRemark='Pending')", con)
        da.Fill(dt)
        frmBillAdjustmentRequestForm.lvw.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrPendingBillID(dt.Rows.Count - 1)
            ReDim arrPendingBillStatID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrPendingBillID(x) = Val(dt.Rows(x).Item(0))
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString)
                Dim strGetRemark As String
                strGetRemark = dt.Rows(x).Item(11).ToString
                If strGetRemark = "Marked" Then
                    arrPendingBillStatID(x) = 1 'FOR REQUEST
                    lst.SubItems.Add("REQUEST FORM")
                ElseIf strGetRemark = "Pending" Then
                    arrPendingBillStatID(x) = 2 'FOR ADJUSTMENT
                    lst.SubItems.Add("ADJUSTMENT")
                End If
                frmBillAdjustmentRequestForm.lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Public arrGrORID() As Integer

    Public Sub LoadORGroup()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblorgroup ORDER BY Initial ASC", con)
        da.Fill(dt)
        frmORList.cboGroup.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrGrORID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrGrORID(x) = Val(dt.Rows(x).Item(0))
                frmORList.cboGroup.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Public Sub ViewPaymentHistory(conID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT P.pID, P.consID, P.ORNumber, P.pAmount, P.collectionnature, P.paymentType, P.surcharge, P.enviFee, P.paymentdate, P.discount, P.billID, B.billMonth, B.billYear FROM tblpayment AS P LEFT JOIN billing AS B ON P.billID=B.billID WHERE P.consID=" & conID & " ORDER BY P.paymentDate", con)
        da.Fill(dt)
        frmConsumerList.lvwPaymentHistory.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim pHistoryID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                pHistoryID(x) = Val(dt.Rows(x).Item(0).ToString)
                Try
                    lst.Text = Format(dt.Rows(x).Item(8), "MM-dd-yyyy")
                Catch ex As Exception
                    lst.Text = ""
                End Try

                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(Val(dt.Rows(x).Item(3).ToString))
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(9).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(11).ToString & " " & dt.Rows(x).Item(12).ToString)
                frmConsumerList.lvwPaymentHistory.Items.Add(lst)
            Next
        End If
    End Sub

    Public Sub LoadUncollectibles(mon As String, yea As Integer, brgyID As Integer)
        Cons()
        Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT B.AcctID, B.ConsID, C.consumername, BR.AddBrgy, Clus.clustername, ((SELECT SUM(useAmount) FROM billing WHERE billMonth <> '" & mon & "' AND billyear <> " & yea & " and (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID) + (SELECT SUM(ifnull(prevOutstanding,0)) - SUM(ifnull(prevOutPenalty,0)) FROM billing WHERE prevOutstandingStat='UNPAID' AND acctID=B.acctID)) AS UNPAID,(ifnull((SELECT SUM(penalty) FROM billing WHERE billMonth <> '" & mon & "' AND billyear <> " & yea & " and (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID),0) + ifnull((SELECT SUM(prevOutPenalty) FROM billing WHERE prevOutstandingStat='UNPAID' AND acctID=B.acctID),0)) AS TotalPenalty, (SELECT SUM(totalPayment) FROM tblOR WHERE monthname(pDate) = '" & mon & "' and year(pDate)=" & yea & " and consID=C.consID) as Payment, (SELECT GROUP_CONCAT(DISTINCT ORNum SEPARATOR '/\n') FROM tblOR WHERE monthname(pDate) = '" & mon & "' and year(pDate) = " & yea & " and consID=C.consID GROUP BY consID) as ORNumber, useAmount AS CurrentBill, (SELECT SUM(ifnull(useAmount,0)) + SUM(ifnull(prevOutstanding,0)) + SUM(ifnull(prevOutPenalty,0)) FROM billing WHERE (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID) AS OutstandingBal, billMonth, billYear FROM poseidondb.billing AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN clusterlist AS Clus ON B.clusterID=Clus.clusterID LEFT JOIN brgylist AS BR ON Clus.brgyID=BR.brgyID WHERE B.billMonth='" & mon & "' and B.billYear=" & yea & " and BR.brgyID=" & brgyID, con)
        Dim strQ As String = "SELECT B.AcctID, B.ConsID, BR.brgyID, Clus.clusterID, C.consumername, BR.AddBrgy, Clus.clustername, ((SELECT ifnull(SUM(useAmount),0) FROM billing WHERE billMonth <> '" & mon & "' AND billyear <> " & yea & " and (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID) + (SELECT (ifnull(SUM(prevOutstanding),0) - ifnull(SUM(prevOutPenalty),0) - ifnull(SUM(prevOutEF),0)) FROM billing WHERE prevOutstandingStat='UNPAID' AND acctID=B.acctID)) AS UNPAID,(ifnull((SELECT SUM(penalty) FROM billing WHERE billMonth <> '" & mon & "' AND billyear <> " & yea & " and (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID),0) + ifnull((SELECT SUM(prevOutPenalty) FROM billing WHERE prevOutstandingStat='UNPAID' AND acctID=B.acctID),0)) AS TotalPenalty, (SELECT SUM(totalPayment) FROM tblOR WHERE monthname(pDate) = '" & mon & "' and consID=C.consID) as Payment, (SELECT GROUP_CONCAT(DISTINCT ORNum SEPARATOR '/\n') FROM tblOR WHERE monthname(pDate) = '" & mon & "' and year(pDate)=" & yea & " and  consID=C.consID GROUP BY consID) as ORNumber, useAmount AS CurrentBill, (ifnull((SELECT SUM(ifnull(useAmount,0)) + SUM(ifnull(prevOutstanding,0)) + SUM(ifnull(prevOutPenalty,0)) + SUM(ifnull(penalty,0)) FROM billing WHERE billMonth <> '" & mon & "' AND billyear <> " & yea & " and (billstat='UNPAID' or billStat='LAPSE') AND acctID=B.acctID),0) + (SELECT ifnull(useAmount,0) FROM billing WHERE billMonth='" & mon & "' and billyear=" & yea & " and acctID=B.acctID)) AS OutstandingBal, billMonth, billYear FROM poseidondb.billing AS B LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN clusterlist AS Clus ON B.clusterID=Clus.clusterID LEFT JOIN brgylist AS BR ON Clus.brgyID=BR.brgyID WHERE B.billMonth='" & mon & "' and B.billYear=" & yea & " and BR.brgyID=" & brgyID
        Dim da As New MySqlDataAdapter(strQ, con)
        da.Fill(dt)
        Dim report As New crptMUncollectibles
        report.SetDataSource(dt)
        frmUncollectiblesMonthlyReport.CrystalReportViewer1.ReportSource = report
        frmUncollectiblesMonthlyReport.CrystalReportViewer1.Zoom(100%)
        frmUncollectiblesMonthlyReport.CrystalReportViewer1.Refresh()
        frmUncollectiblesMonthlyReport.WindowState = FormWindowState.Maximized
        frmUncollectiblesMonthlyReport.ShowDialog()
    End Sub

    Public Sub LoadApplicationBalance(aID As Integer)
        applicationFeePaidAmount = 0
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.accountName, A.accountNo, ATB.balance, FB.amount, ATB.remmonths FROM applicationfeetotalbalance AS ATB LEFT JOIN applicationfeebalance AS FB ON ATB.afeetotid=FB.afeetotid LEFT JOIN consumeraccounts AS A ON ATB.acctID=A.acctID WHERE ATB.acctID=" & aID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim AppFeeAmt(12)
            For y As Integer = 0 To 12
                chkAmt(y).Checked = False
                chkAmt(y).Enabled = True
                If y = 0 Then
                    AppFeeAmt(y) = 720
                Else
                    AppFeeAmt(y) = 240
                End If

            Next
            For x As Integer = 0 To dt.Rows.Count - 1
                chkAmt(x).Checked = True
                chkAmt(x).Enabled = False

                applicationFeePaidAmount = applicationFeePaidAmount + AppFeeAmt(x)
            Next
            If appOpenForm = 1 Then
                frmApplicationBalance.btnSave.Text = "Save"
            ElseIf appOpenForm = 2 Then
                frmApplicationBalance.btnSave.Text = "Done"
            End If
            frmApplicationBalance.lblAccountName.Text = dt.Rows(0).Item(1).ToString
            frmApplicationBalance.lblAccountNo.Text = dt.Rows(0).Item(2).ToString
            applicationAcctID = aID
            frmApplicationBalance.lblPaid.Text = Format(applicationFeePaidAmount, "#,##0.#0")
            frmApplicationBalance.lblRemBal.Text = Format((3600 - applicationFeePaidAmount), "#,##0.#0")
        End If
        frmApplicationBalance.StartPosition = FormStartPosition.CenterScreen
        frmApplicationBalance.ShowDialog()
    End Sub

    Public Function SCDS(mon As String, yea As Integer) As DataTable
        Dim intMon As Integer = 0
        Dim minMon As Integer = 0
        Dim plusMon As Integer = 0
        Dim minYear As Integer = 0
        Dim plusYear As Integer = 0

        Select Case mon
            Case "January"
                intMon = 1
                plusMon = 2
                plusYear = yea
            Case "February"
                intMon = 2
                plusMon = 3
                plusYear = yea
            Case "March"
                intMon = 3
                plusMon = 4
                plusYear = yea
            Case "April"
                intMon = 4
                plusMon = 5
                plusYear = yea
            Case "May"
                intMon = 5
                plusMon = 6
                plusYear = yea
            Case "June"
                intMon = 6
                plusMon = 7
                plusYear = yea
            Case "July"
                intMon = 7
                plusMon = 8
                plusYear = yea
            Case "August"
                intMon = 8
                plusMon = 9
                plusYear = yea
            Case "September"
                intMon = 9
                plusMon = 10
                plusYear = yea
            Case "October"
                intMon = 10
                plusMon = 11
                plusYear = yea
            Case "November"
                intMon = 11
                plusMon = 12
                plusYear = yea
            Case "December"
                intMon = 12
                plusMon = 1
                plusYear = yea + 1
        End Select
        Dim lastDay As Integer = Date.DaysInMonth(yea, intMon)
        Cons()
        Dim dtAll As New DataTable
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("select R.brgyID, R.AddBrgy, Z.zoneID, Z.PlantName, count(*) AS TotalAccounts from consumeraccounts AS A LEFT JOIN brgylist as R ON A.brgyID=R.brgyID left join zones as Z ON R.zoneID=Z.zoneID where A.ConnectionDate < '" & plusYear & "-" & plusMon & "-01'  group by R.brgyID order by Z.zoneID", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim scbrgyID(dt.Rows.Count - 1) 'OK
            ReDim scAddBrgy(dt.Rows.Count - 1) 'OK
            ReDim sczoneID(dt.Rows.Count - 1) 'OK
            ReDim scPlantName(dt.Rows.Count - 1) 'OK
            ReDim scTotalAccounts(dt.Rows.Count - 1) 'OK
            ReDim scActiveTotal(dt.Rows.Count - 1) 'OK
            ReDim scActiveInstalled(dt.Rows.Count - 1) 'OK
            ReDim scActiveReconnected(dt.Rows.Count - 1)
            ReDim scActiveDirect(dt.Rows.Count - 1) 'OK
            ReDim scUninstalledTotal(dt.Rows.Count - 1) 'OK
            ReDim scUninstalledBacklog(dt.Rows.Count - 1) 'REMOVED
            ReDim scUninstalledNew(dt.Rows.Count - 1) 'REMOVED
            ReDim scDisTotal(dt.Rows.Count - 1) 'OK
            ReDim scDisNonPay(dt.Rows.Count - 1)
            ReDim scDisVoluntary(dt.Rows.Count - 1)
            ReDim scTotalRes(dt.Rows.Count - 1) 'OK
            ReDim scTotalIns(dt.Rows.Count - 1) 'OK
            ReDim scTotalCom(dt.Rows.Count - 1) 'OK
            ReDim scTotalInd(dt.Rows.Count - 1) 'OK
            ReDim scactiveRes(dt.Rows.Count - 1) 'OK
            ReDim scactiveIns(dt.Rows.Count - 1) 'OK
            ReDim scactiveCom(dt.Rows.Count - 1) 'OK
            ReDim scactiveInd(dt.Rows.Count - 1) 'OK
            ReDim scRegular(dt.Rows.Count - 1) 'OK
            ReDim scSenior(dt.Rows.Count - 1) 'OK
            ReDim scMonth(dt.Rows.Count - 1) 'OK
            ReDim scYear(dt.Rows.Count - 1) 'OK
            For x As Integer = 0 To dt.Rows.Count - 1
                scbrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                scAddBrgy(x) = dt.Rows(x).Item(1).ToString
                sczoneID(x) = Val(dt.Rows(x).Item(2).ToString)
                scPlantName(x) = dt.Rows(x).Item(3).ToString
                scTotalAccounts(x) = Val(dt.Rows(x).Item(4).ToString)
                scMonth(x) = mon
                scYear(x) = yea
            Next



            Dim dtAct As New DataTable
            Dim daAct As New MySqlDataAdapter("SELECT brgyID, count(*) as ActiveCount FROM consumeraccounts where AcctStatus=1 AND ConnectionDate < '" & plusYear & "-" & plusMon & "-01' GROUP BY brgyID", con)
            daAct.Fill(dtAct)
            If dtAct.Rows.Count > 0 Then
                For y As Integer = 0 To dtAct.Rows.Count - 1
                    Dim intBID As Integer = Val(dtAct.Rows(y).Item(0).ToString)
                    Dim intCount As Integer = Val(dtAct.Rows(y).Item(1).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            scActiveTotal(i) = intCount
                        End If
                    Next
                Next
            End If

            Dim dtSen As New DataTable
            Dim daSen As New MySqlDataAdapter("SELECT DISTINCT brgyID, isSenior, count(*) FROM consumeraccounts WHERE ConnectionDate < '" & plusYear & "-" & plusMon & "-01' GROUP BY isSenior, brgyID", con)
            daSen.Fill(dtSen)
            If dtSen.Rows.Count > 0 Then
                For y As Integer = 0 To dtSen.Rows.Count - 1
                    Dim intBID As Integer = Val(dtSen.Rows(y).Item(0).ToString)
                    Dim strSen As String = dtSen.Rows(y).Item(1).ToString
                    Dim intCount As Integer = Val(dtSen.Rows(y).Item(2).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            If strSen = "YES" Then
                                scSenior(i) = intCount
                            Else
                                scRegular(i) = intCount
                            End If
                        End If
                    Next
                Next
            End If

            'Dim dtInst As New DataTable
            'Dim daInst As New MySqlDataAdapter("SELECT distinct brgyID, count(*) FROM consumeraccounts where acctstatus=3 GROUP BY brgyID", con)
            'daInst.Fill(dtInst)
            'If dtInst.Rows.Count > 0 Then
            '    For y As Integer = 0 To dtInst.Rows.Count - 1
            '        Dim intBID As Integer = Val(dtInst.Rows(y).Item(0).ToString)
            '        Dim intCount As Integer = Val(dtInst.Rows(y).Item(1).ToString)
            '        For i As Integer = 0 To dt.Rows.Count - 1
            '            If intBID = scbrgyID(i) Then
            '                scUninstalledTotal(i) = intCount
            '            End If
            '        Next
            '    Next
            'End If

            Dim dtDisc As New DataTable
            Dim daDisc As New MySqlDataAdapter("select brgyID, count(*) from consumeraccounts where (acctstatus=2 or acctstatus=7 or acctstatus=8) and ConnectionDate < '" & plusYear & "-" & plusMon & "-01' GROUP BY brgyID", con)
            daDisc.Fill(dtDisc)
            If dtDisc.Rows.Count > 0 Then
                For y As Integer = 0 To dt.Rows.Count - 1
                    Dim intBID As Integer = Val(dtDisc.Rows(y).Item(0).ToString)
                    Dim intCount As Integer = Val(dtDisc.Rows(y).Item(1).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            scDisTotal(i) = intCount
                        End If
                    Next
                Next
            End If

            Dim dtClass As New DataTable
            Dim daClass As New MySqlDataAdapter("SELECT distinct A.brgyID, C.classification, A.classID, count(*) FROM consumeraccounts AS A left join classifications AS C ON A.classID=C.classID WHERE ConnectionDate < '" & plusYear & "-" & plusMon & "-01' GROUP BY A.brgyID, A.classID ", con)
            daClass.Fill(dtClass)
            If dtClass.Rows.Count > 0 Then
                For y As Integer = 0 To dtClass.Rows.Count - 1
                    Dim intBID As Integer = Val(dtClass.Rows(y).Item(0).ToString)
                    Dim intCID As Integer = Val(dtClass.Rows(y).Item(2).ToString)
                    Dim intCount As Integer = Val(dtClass.Rows(y).Item(3).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            If intCID = 1 Or intCID = 6 Then
                                scTotalRes(i) = scTotalRes(i) + intCount
                            ElseIf intCID = 2 Or intCID = 3 Then
                                scTotalIns(i) = scTotalIns(i) + intCount
                            ElseIf intCID = 4 Then
                                scTotalCom(i) = intCount
                            ElseIf intCID = 5 Then
                                scTotalInd(i) = intCount
                            End If
                        End If
                    Next
                Next
            End If

            Dim dtAClass As New DataTable
            Dim daAClass As New MySqlDataAdapter("SELECT distinct A.brgyID, C.classification, A.classID, count(*) FROM consumeraccounts AS A left join classifications AS C ON A.classID=C.classID WHERE ConnectionDate < '" & plusYear & "-" & plusMon & "-01' and (acctstatus=1 or acctstatus=4 or acctstatus=5 or acctstatus=6) GROUP BY A.brgyID, A.classID", con)
            daAClass.Fill(dtAClass)
            If dtAClass.Rows.Count > 0 Then
                For y As Integer = 0 To dtAClass.Rows.Count - 1
                    Dim intBID As Integer = Val(dtAClass.Rows(y).Item(0).ToString)
                    Dim intCID As Integer = Val(dtAClass.Rows(y).Item(2).ToString)
                    Dim intCount As Integer = Val(dtAClass.Rows(y).Item(3).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            If intCID = 1 Or intCID = 6 Then
                                scactiveRes(i) = scactiveRes(i) + intCount
                            ElseIf intCID = 2 Or intCID = 3 Then
                                scactiveIns(i) = scactiveIns(i) + intCount
                            ElseIf intCID = 4 Then
                                scactiveCom(i) = intCount
                            ElseIf intCID = 5 Then
                                scactiveInd(i) = intCount
                            End If
                        End If
                    Next
                Next
            End If

            Dim dtADirect As New DataTable
            Dim daADirect As New MySqlDataAdapter("SELECT brgyID, count(*) FROM consumeraccounts WHERE classid=6 and acctstatus=1 GROUP BY brgyID", con)
            daADirect.Fill(dtADirect)
            If dtADirect.Rows.Count > 0 Then
                For y As Integer = 0 To dtADirect.Rows.Count - 1
                    Dim intBID As Integer = Val(dtADirect.Rows(y).Item(0).ToString)
                    Dim intCount As Integer = Val(dtADirect.Rows(y).Item(1).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            scActiveDirect(i) = intCount
                        End If
                    Next
                Next
            End If

            Dim dtNewApp As New DataTable
            Dim daNewApp As New MySqlDataAdapter("SELECT brgyID, Count(*) FROM  consumeraccounts where AcctStatus=3 GROUP BY brgyID", con)
            daNewApp.Fill(dtNewApp)
            If dtNewApp.Rows.Count > 0 Then
                For y As Integer = 0 To dtNewApp.Rows.Count - 1
                    Dim intBID As Integer = Val(dtNewApp.Rows(y).Item(0).ToString)
                    Dim intCount As Integer = Val(dtNewApp.Rows(y).Item(1).ToString)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If intBID = scbrgyID(i) Then
                            scUninstalledTotal(i) = intCount
                        End If
                    Next
                Next
            End If

            For j As Integer = 0 To dt.Rows.Count - 1
                scActiveInstalled(j) = scActiveTotal(j) - scActiveDirect(j) - scActiveReconnected(j)
            Next

            dtAll.Columns.AddRange(New DataColumn() {New DataColumn("brgyID", GetType(Integer)), New DataColumn("AddBrgy", GetType(String)), New DataColumn("zoneID", GetType(Integer)), New DataColumn("PlantName", GetType(String)), New DataColumn("TotalAccounts", GetType(Integer)), New DataColumn("ActiveTotal", GetType(Integer)), New DataColumn("ActiveInstalled", GetType(Integer)), New DataColumn("ActiveReconnected", GetType(Integer)), New DataColumn("ActiveDirect", GetType(Integer)), New DataColumn("UninstalledTotal", GetType(Integer)), New DataColumn("UninstalledBacklogs", GetType(Integer)), New DataColumn("UninstalledNew", GetType(Integer)), New DataColumn("DisconnectedTotal", GetType(Integer)), New DataColumn("DisconnectedNonPay", GetType(Integer)), New DataColumn("DisconnectedVoluntary", GetType(Integer)), New DataColumn("TotalAccountsRes", GetType(Integer)), New DataColumn("TotalAccountsIns", GetType(Integer)), New DataColumn("TotalAccountsCom", GetType(Integer)), New DataColumn("TotalAccountsInd", GetType(Integer)), New DataColumn("ActiveRes", GetType(Integer)), New DataColumn("ActiveIns", GetType(Integer)), New DataColumn("ActiveCom", GetType(Integer)), New DataColumn("ActiveInd", GetType(Integer)), New DataColumn("Regular", GetType(Integer)), New DataColumn("Senior", GetType(Integer)), New DataColumn("repMonth", GetType(String)), New DataColumn("repYear", GetType(Integer))})
            For z As Integer = 0 To dt.Rows.Count - 1
                dtAll.Rows.Add(scbrgyID(z), scAddBrgy(z), sczoneID(z), scPlantName(z), scTotalAccounts(z), scActiveTotal(z), scActiveInstalled(z), scActiveReconnected(z), scActiveDirect(z), scUninstalledTotal(z), scUninstalledNew(z), scUninstalledBacklog(z), scDisTotal(z), scDisNonPay(z), scDisVoluntary(z), scTotalRes(z), scTotalIns(z), scTotalCom(z), scTotalInd(z), scactiveRes(z), scactiveIns(z), scactiveCom(z), scactiveInd(z), scRegular(z), scSenior(z), scMonth(z), scYear(z))
            Next
        End If
        Return dtAll
    End Function

    Public Sub NewBillClassList()
        frmManuallyAddBill.cboClassification.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM classifications", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim ccManBill(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                ccManBill(x) = Val(dt.Rows(x).Item(0).ToString)
                frmManuallyAddBill.cboClassification.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

End Module


