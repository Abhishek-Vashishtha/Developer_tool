
namespace Developer_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarSerialConnection = new System.Windows.Forms.ProgressBar();
            this.timer10ms = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_DataTrafficCopy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DataTrafficRxBytesTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_DataTrafficClear = new System.Windows.Forms.Button();
            this.textBox_DataTrafficTxBytesTotal = new System.Windows.Forms.TextBox();
            this.radioButton_DataTrafficFormatHEXSpaced = new System.Windows.Forms.RadioButton();
            this.radioButton_DataTrafficFormatASCII = new System.Windows.Forms.RadioButton();
            this.radioButton_DataTrafficFormatHEX = new System.Windows.Forms.RadioButton();
            this.textBox_DataTraffic = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton_SendFrameFormatASCII = new System.Windows.Forms.RadioButton();
            this.radioButton_SendFrameFormatHex = new System.Windows.Forms.RadioButton();
            this.textBox_SendFrame = new System.Windows.Forms.TextBox();
            this.checkBox_SendFrameHDLC = new System.Windows.Forms.CheckBox();
            this.button_SendFrameClear = new System.Windows.Forms.Button();
            this.button_SendFramePaste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SendRepeatSentCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SendRepeatNoOfTimes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SendRepeatTime = new System.Windows.Forms.TextBox();
            this.checkBox_SendRepeat = new System.Windows.Forms.CheckBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ToolsCalculateChecksum = new System.Windows.Forms.Button();
            this.textBox_ToolsChecksumCRC16 = new System.Windows.Forms.TextBox();
            this.textBox_ToolsChecksumBCCXOR = new System.Windows.Forms.TextBox();
            this.textBox_ToolsChecksumMemory = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonWordwrapConvert = new System.Windows.Forms.Button();
            this.textBoxWordwrapLength = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxStringFilterRemoveHEX = new System.Windows.Forms.TextBox();
            this.buttonStringFilterConvert = new System.Windows.Forms.Button();
            this.checkBoxStringFilterRemoveHEX = new System.Windows.Forms.CheckBox();
            this.checkBoxStringFilterRemoveTab = new System.Windows.Forms.CheckBox();
            this.checkBoxStringFilterRemoveLF = new System.Windows.Forms.CheckBox();
            this.checkBoxStringFilterRemoveCR = new System.Windows.Forms.CheckBox();
            this.checkBoxStringFilterRemoveSpace = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonToolsOutputTextBoxCopy = new System.Windows.Forms.Button();
            this.buttonToolsOutputTextBoxClear = new System.Windows.Forms.Button();
            this.radiobuttonToolsOutputTextBoxHEXSpaced = new System.Windows.Forms.RadioButton();
            this.radiobuttonToolsOutputTextBoxASCII = new System.Windows.Forms.RadioButton();
            this.radiobuttonToolsOutputTextBoxHEX = new System.Windows.Forms.RadioButton();
            this.textBox_ToolsOutputString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonToolsInputTextBoxPaste = new System.Windows.Forms.Button();
            this.buttonToolsInputTextBoxClear = new System.Windows.Forms.Button();
            this.radioButtonToolsInputTextBoxHEXSpaced = new System.Windows.Forms.RadioButton();
            this.radioButtonToolsInputTextBoxASCII = new System.Windows.Forms.RadioButton();
            this.radioButtonToolsInputTextBoxHEX = new System.Windows.Forms.RadioButton();
            this.textBox_ToolsInputString = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox_TamperStatus = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label116 = new System.Windows.Forms.Label();
            this.textBox_EnergyWhTotalFunda = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox_EnergyWhR = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhY = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhB = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhLagTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhLeadTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhTotal = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox_MISCData = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.textBox_LoopCycles = new System.Windows.Forms.TextBox();
            this.textBox_THDIb = new System.Windows.Forms.TextBox();
            this.textBox_THDIy = new System.Windows.Forms.TextBox();
            this.textBox_THDIr = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.textBox_THDVb = new System.Windows.Forms.TextBox();
            this.textBox_THDVy = new System.Windows.Forms.TextBox();
            this.textBox_THDVr = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.textBox_ReactiveTimeDeviation = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox_ReactiveTimeDelay = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.textBox_ReactiveTimer = new System.Windows.Forms.TextBox();
            this.textBox_ReactiveSamples = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.textBox_BatteryVoltage = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.textBox_TempTLV = new System.Windows.Forms.TextBox();
            this.labelMetrologyTimer = new System.Windows.Forms.Label();
            this.textBox_SamplesPerSec = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox_VolRY = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox_AngleBR = new System.Windows.Forms.TextBox();
            this.textBox_VolBR = new System.Windows.Forms.TextBox();
            this.textBox_AngleYB = new System.Windows.Forms.TextBox();
            this.textBox_VolYB = new System.Windows.Forms.TextBox();
            this.textBox_AngleRY = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox_ErrorAppB = new System.Windows.Forms.TextBox();
            this.textBox_ErrorAppY = new System.Windows.Forms.TextBox();
            this.textBox_ErrorAppTotal = new System.Windows.Forms.TextBox();
            this.textBox_ErrorAppR = new System.Windows.Forms.TextBox();
            this.textBox_ErrorReactB = new System.Windows.Forms.TextBox();
            this.textBox_ErrorReactY = new System.Windows.Forms.TextBox();
            this.textBox_ErrorReactTotal = new System.Windows.Forms.TextBox();
            this.textBox_ErrorReactR = new System.Windows.Forms.TextBox();
            this.textBox_ErrorActB = new System.Windows.Forms.TextBox();
            this.textBox_ErrorActY = new System.Windows.Forms.TextBox();
            this.textBox_ErrorActTotal = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox_ErrorActR = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.button_ShowVectorDiagram = new System.Windows.Forms.Button();
            this.textBox_AnglePFBph = new System.Windows.Forms.TextBox();
            this.textBox_AnglePFYph = new System.Windows.Forms.TextBox();
            this.textBox_AnglePFRph = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox_SamplesB = new System.Windows.Forms.TextBox();
            this.textBox_SamplesY = new System.Windows.Forms.TextBox();
            this.textBox_SamplesR = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox_AngleNeuVector = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox_CurrNeuVector = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.textBox_SamplesN = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox_CurrN = new System.Windows.Forms.TextBox();
            this.textBox_CurrNdc = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleReactB = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleReactY = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleReactR = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_QuadB = new System.Windows.Forms.TextBox();
            this.textBox_FreqB = new System.Windows.Forms.TextBox();
            this.textBox_VAB = new System.Windows.Forms.TextBox();
            this.textBox_VARB = new System.Windows.Forms.TextBox();
            this.textBox_WattB = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleActB = new System.Windows.Forms.TextBox();
            this.textBox_PFB = new System.Windows.Forms.TextBox();
            this.textBox_CurrBdc = new System.Windows.Forms.TextBox();
            this.textBox_CurrB = new System.Windows.Forms.TextBox();
            this.textBox_VolBdc = new System.Windows.Forms.TextBox();
            this.textBox_VolB = new System.Windows.Forms.TextBox();
            this.textBox_QuadY = new System.Windows.Forms.TextBox();
            this.textBox_FreqY = new System.Windows.Forms.TextBox();
            this.textBox_VAY = new System.Windows.Forms.TextBox();
            this.textBox_VARY = new System.Windows.Forms.TextBox();
            this.textBox_WattY = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleActY = new System.Windows.Forms.TextBox();
            this.textBox_PFY = new System.Windows.Forms.TextBox();
            this.textBox_CurrYdc = new System.Windows.Forms.TextBox();
            this.textBox_CurrY = new System.Windows.Forms.TextBox();
            this.textBox_VolYdc = new System.Windows.Forms.TextBox();
            this.textBox_VolY = new System.Windows.Forms.TextBox();
            this.textBox_QuadNet = new System.Windows.Forms.TextBox();
            this.textBox_FreqNet = new System.Windows.Forms.TextBox();
            this.textBox_VANet = new System.Windows.Forms.TextBox();
            this.textBox_VARNet = new System.Windows.Forms.TextBox();
            this.textBox_WattNet = new System.Windows.Forms.TextBox();
            this.textBox_PFNet = new System.Windows.Forms.TextBox();
            this.textBox_QuadR = new System.Windows.Forms.TextBox();
            this.textBox_FreqR = new System.Windows.Forms.TextBox();
            this.textBox_VAR = new System.Windows.Forms.TextBox();
            this.textBox_VARR = new System.Windows.Forms.TextBox();
            this.textBox_WattR = new System.Windows.Forms.TextBox();
            this.textBox_CalAngleActR = new System.Windows.Forms.TextBox();
            this.textBox_PFR = new System.Windows.Forms.TextBox();
            this.textBox_CurrRdc = new System.Windows.Forms.TextBox();
            this.textBox_CurrR = new System.Windows.Forms.TextBox();
            this.textBox_VolRdc = new System.Windows.Forms.TextBox();
            this.textBox_VolR = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.textBox_inputAngleYB = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox_inputNeutralVectorAngle = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox_inputNeutralVectorCurrent = new System.Windows.Forms.TextBox();
            this.button_inputUpdate = new System.Windows.Forms.Button();
            this.checkBox_CalculateAccuracy = new System.Windows.Forms.CheckBox();
            this.textBox_inputFreq = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox_inputAngleBR = new System.Windows.Forms.TextBox();
            this.textBox_AvgAccuracySamples = new System.Windows.Forms.TextBox();
            this.textBox_inputAngleRY = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox_inputPFNet = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.textBox_inputVANet = new System.Windows.Forms.TextBox();
            this.textBox_inputVARNet = new System.Windows.Forms.TextBox();
            this.textBox_inputWattNet = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.textBox_inputVATotal = new System.Windows.Forms.TextBox();
            this.textBox_inputVARTotal = new System.Windows.Forms.TextBox();
            this.textBox_inputWattTotal = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.textBox_inputVAB = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            this.textBox_inputVARB = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.textBox_inputWattB = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox_inputVAY = new System.Windows.Forms.TextBox();
            this.textBox_inputVARY = new System.Windows.Forms.TextBox();
            this.textBox_inputWattY = new System.Windows.Forms.TextBox();
            this.textBox_inputVAR = new System.Windows.Forms.TextBox();
            this.textBox_inputVARR = new System.Windows.Forms.TextBox();
            this.textBox_inputWattR = new System.Windows.Forms.TextBox();
            this.textBox_inputAngleB = new System.Windows.Forms.TextBox();
            this.textBox_inputAngleY = new System.Windows.Forms.TextBox();
            this.textBox_inputAngleR = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox_inputPFB = new System.Windows.Forms.TextBox();
            this.textBox_inputCurrB = new System.Windows.Forms.TextBox();
            this.textBox_inputVolB = new System.Windows.Forms.TextBox();
            this.textBox_inputPFY = new System.Windows.Forms.TextBox();
            this.textBox_inputCurrY = new System.Windows.Forms.TextBox();
            this.textBox_inputVolY = new System.Windows.Forms.TextBox();
            this.textBox_inputPFR = new System.Windows.Forms.TextBox();
            this.textBox_inputCurrR = new System.Windows.Forms.TextBox();
            this.textBox_inputVolR = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.button_iStop = new System.Windows.Forms.Button();
            this.textBox_NewFileName = new System.Windows.Forms.TextBox();
            this.checkBox_LogToNewFile = new System.Windows.Forms.CheckBox();
            this.button_iRead = new System.Windows.Forms.Button();
            this.checkBox_iAutoRead = new System.Windows.Forms.CheckBox();
            this.label_iAutoreadLabel = new System.Windows.Forms.Label();
            this.checkBox_LogData = new System.Windows.Forms.CheckBox();
            this.textBox_iAutoReadTime = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label119 = new System.Windows.Forms.Label();
            this.textBoxCalPhaseCorrSamplesR = new System.Windows.Forms.TextBox();
            this.button_SaveCalData = new System.Windows.Forms.Button();
            this.textBoxCalPhaseCorrSamplesB = new System.Windows.Forms.TextBox();
            this.textBox_SaveCalDataFileName = new System.Windows.Forms.TextBox();
            this.textBoxCalPhaseCorrSamplesY = new System.Windows.Forms.TextBox();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.textBoxNeuCalButtonPressTime = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.textBoxNeuCalDisplayTime = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxNeuCalCounter = new System.Windows.Forms.TextBox();
            this.textBoxNeuCalTime = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.buttonPasteData = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBoxRTCPPMSigned = new System.Windows.Forms.TextBox();
            this.textBoxRTCCalSec = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxRTCRADJ = new System.Windows.Forms.TextBox();
            this.textBoxRTCCalSign = new System.Windows.Forms.TextBox();
            this.textBoxRTCCalTime = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxRTCCalDoneF = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.textBoxCalTempPhase = new System.Windows.Forms.TextBox();
            this.textBoxPhaseCalbuttonPressTime = new System.Windows.Forms.TextBox();
            this.textBoxPhaseCalDisplayTime = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxCalDoneF = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxPhaseCalTime = new System.Windows.Forms.TextBox();
            this.textBoxPhaseCalCounter = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBoxMeasFreqNet = new System.Windows.Forms.TextBox();
            this.textBoxMeasFreqY = new System.Windows.Forms.TextBox();
            this.textBoxMeasFreqB = new System.Windows.Forms.TextBox();
            this.textBoxMeasFreqR = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxMeasV90IY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxMeasV90IB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMeasV90IR = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxMeasVIY = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxMeasVIB = new System.Windows.Forms.TextBox();
            this.textBoxMeasVIR = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxMeasVolR = new System.Windows.Forms.TextBox();
            this.textBoxMeasVolB = new System.Windows.Forms.TextBox();
            this.textBoxMeasVolY = new System.Windows.Forms.TextBox();
            this.textBoxMeasCurrR = new System.Windows.Forms.TextBox();
            this.textBoxMeasCurrB = new System.Windows.Forms.TextBox();
            this.textBoxMeasCurrY = new System.Windows.Forms.TextBox();
            this.textBoxMeasPFR = new System.Windows.Forms.TextBox();
            this.textBoxMeasPFB = new System.Windows.Forms.TextBox();
            this.textBoxMeasPFY = new System.Windows.Forms.TextBox();
            this.textBoxMeasWattR = new System.Windows.Forms.TextBox();
            this.textBoxMeasWattB = new System.Windows.Forms.TextBox();
            this.textBoxMeasCurrN = new System.Windows.Forms.TextBox();
            this.textBoxMeasWattY = new System.Windows.Forms.TextBox();
            this.textBoxMeasVARR = new System.Windows.Forms.TextBox();
            this.textBoxMeasVAY = new System.Windows.Forms.TextBox();
            this.textBoxMeasVARB = new System.Windows.Forms.TextBox();
            this.textBoxMeasVARY = new System.Windows.Forms.TextBox();
            this.textBoxMeasVAB = new System.Windows.Forms.TextBox();
            this.textBoxMeasVAR = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxCalVolR = new System.Windows.Forms.TextBox();
            this.textBoxCalVolB = new System.Windows.Forms.TextBox();
            this.textBoxCalVolY = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrR = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrB = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrY = new System.Windows.Forms.TextBox();
            this.textBoxCalPowR = new System.Windows.Forms.TextBox();
            this.textBoxCalPowB = new System.Windows.Forms.TextBox();
            this.textBoxCalPowY = new System.Windows.Forms.TextBox();
            this.textBoxCalVolOffR = new System.Windows.Forms.TextBox();
            this.textBoxCalVolOffB = new System.Windows.Forms.TextBox();
            this.textBoxCalVolOffY = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrOffR = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrOffB = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrOffY = new System.Windows.Forms.TextBox();
            this.textBoxCalPhaseR = new System.Windows.Forms.TextBox();
            this.textBoxCalPhaseB = new System.Windows.Forms.TextBox();
            this.textBoxCalPhaseY = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrN = new System.Windows.Forms.TextBox();
            this.textBoxCalCurrOffN = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.textBoxWFLegendCh6 = new System.Windows.Forms.TextBox();
            this.textBox_WFScaling6 = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.textBoxWFLegendCh5 = new System.Windows.Forms.TextBox();
            this.textBoxWFLegendCh4 = new System.Windows.Forms.TextBox();
            this.textBoxWFLegendCh3 = new System.Windows.Forms.TextBox();
            this.textBox_WFScaling5 = new System.Windows.Forms.TextBox();
            this.label129 = new System.Windows.Forms.Label();
            this.textBox_WFScaling4 = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.textBox_WFScaling3 = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.textBoxWFLegendCh2 = new System.Windows.Forms.TextBox();
            this.textBoxWFLegendCh1 = new System.Windows.Forms.TextBox();
            this.textBoxWFLegendCh0 = new System.Windows.Forms.TextBox();
            this.buttonWFPlot = new System.Windows.Forms.Button();
            this.textBox_WFScaling2 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.textBox_WFScaling1 = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.textBox_WFScaling0 = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.button_WFSave = new System.Windows.Forms.Button();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.textBox_WFSaveText = new System.Windows.Forms.TextBox();
            this.textBox_WFSaveFileName = new System.Windows.Forms.TextBox();
            this.textBox_WFSamples = new System.Windows.Forms.TextBox();
            this.textBox_WFFrame = new System.Windows.Forms.TextBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.comboBox_WFSelChannel6 = new System.Windows.Forms.ComboBox();
            this.checkBox_WFCh6TypeSel = new System.Windows.Forms.CheckBox();
            this.comboBox_WFSelChannel5 = new System.Windows.Forms.ComboBox();
            this.comboBox_WFSelChannel4 = new System.Windows.Forms.ComboBox();
            this.comboBox_WFSelChannel3 = new System.Windows.Forms.ComboBox();
            this.checkBox_WFCh5TypeSel = new System.Windows.Forms.CheckBox();
            this.checkBox_WFCh4TypeSel = new System.Windows.Forms.CheckBox();
            this.checkBox_WFCh3TypeSel = new System.Windows.Forms.CheckBox();
            this.comboBox_WFSelChannel2 = new System.Windows.Forms.ComboBox();
            this.comboBox_WFSelChannel1 = new System.Windows.Forms.ComboBox();
            this.textBox_WFNoOfSamples = new System.Windows.Forms.TextBox();
            this.comboBox_WFSelChannel0 = new System.Windows.Forms.ComboBox();
            this.checkBox_WFCh2TypeSel = new System.Windows.Forms.CheckBox();
            this.label128 = new System.Windows.Forms.Label();
            this.checkBox_WFCh1TypeSel = new System.Windows.Forms.CheckBox();
            this.checkBox_WFCh0TypeSel = new System.Windows.Forms.CheckBox();
            this.button_WFDecode = new System.Windows.Forms.Button();
            this.button_WFCapture = new System.Windows.Forms.Button();
            this.pictureBoxWaveform = new System.Windows.Forms.PictureBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxRTCOUTTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRTCOUT = new System.Windows.Forms.Button();
            this.buttonRTCCalibration = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPPM = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonDisableLCDTest = new System.Windows.Forms.Button();
            this.buttonAllSeg = new System.Windows.Forms.Button();
            this.buttonOddComOddSeg = new System.Windows.Forms.Button();
            this.buttonEvenComOddSeg = new System.Windows.Forms.Button();
            this.buttonOddComEvenSeg = new System.Windows.Forms.Button();
            this.buttonEvenComEvenSeg = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelFirmwareFileSize = new System.Windows.Forms.Label();
            this.labelBootloaderFileSize = new System.Windows.Forms.Label();
            this.textBoxFirmwarePath = new System.Windows.Forms.TextBox();
            this.textBoxBootloaderPath = new System.Windows.Forms.TextBox();
            this.buttonBootCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveJSONFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openJSONFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1sec = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveform)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.connectionToolStripMenuItem1,
            this.logToolStripMenuItem,
            this.miscelleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1234, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.connectionToolStripMenuItem.Text = "Configurations";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem1
            // 
            this.connectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem});
            this.connectionToolStripMenuItem1.Name = "connectionToolStripMenuItem1";
            this.connectionToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem1.Text = "Connection";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.clearToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // miscelleToolStripMenuItem
            // 
            this.miscelleToolStripMenuItem.Name = "miscelleToolStripMenuItem";
            this.miscelleToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.miscelleToolStripMenuItem.Text = "Miscellaneous";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webPageToolStripMenuItem,
            this.writeUsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // webPageToolStripMenuItem
            // 
            this.webPageToolStripMenuItem.Name = "webPageToolStripMenuItem";
            this.webPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webPageToolStripMenuItem.Text = "Project Page";
            this.webPageToolStripMenuItem.Click += new System.EventHandler(this.webPageToolStripMenuItem_Click);
            // 
            // writeUsToolStripMenuItem
            // 
            this.writeUsToolStripMenuItem.Name = "writeUsToolStripMenuItem";
            this.writeUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeUsToolStripMenuItem.Text = "Write Us";
            this.writeUsToolStripMenuItem.Click += new System.EventHandler(this.writeUsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progressBarSerialConnection
            // 
            this.progressBarSerialConnection.Location = new System.Drawing.Point(1054, 0);
            this.progressBarSerialConnection.Name = "progressBarSerialConnection";
            this.progressBarSerialConnection.Size = new System.Drawing.Size(179, 23);
            this.progressBarSerialConnection.TabIndex = 1;
            // 
            // timer10ms
            // 
            this.timer10ms.Interval = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 630);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Communication";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_DataTrafficCopy);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox_DataTrafficRxBytesTotal);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button_DataTrafficClear);
            this.groupBox6.Controls.Add(this.textBox_DataTrafficTxBytesTotal);
            this.groupBox6.Controls.Add(this.radioButton_DataTrafficFormatHEXSpaced);
            this.groupBox6.Controls.Add(this.radioButton_DataTrafficFormatASCII);
            this.groupBox6.Controls.Add(this.radioButton_DataTrafficFormatHEX);
            this.groupBox6.Controls.Add(this.textBox_DataTraffic);
            this.groupBox6.Location = new System.Drawing.Point(613, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(605, 589);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Transfer Traffic";
            // 
            // button_DataTrafficCopy
            // 
            this.button_DataTrafficCopy.Location = new System.Drawing.Point(487, 555);
            this.button_DataTrafficCopy.Name = "button_DataTrafficCopy";
            this.button_DataTrafficCopy.Size = new System.Drawing.Size(58, 22);
            this.button_DataTrafficCopy.TabIndex = 22;
            this.button_DataTrafficCopy.Text = "Copy";
            this.button_DataTrafficCopy.UseVisualStyleBackColor = true;
            this.button_DataTrafficCopy.Click += new System.EventHandler(this.buttonDataTrafficCopy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rx Bytes:";
            // 
            // textBox_DataTrafficRxBytesTotal
            // 
            this.textBox_DataTrafficRxBytesTotal.Location = new System.Drawing.Point(411, 554);
            this.textBox_DataTrafficRxBytesTotal.Name = "textBox_DataTrafficRxBytesTotal";
            this.textBox_DataTrafficRxBytesTotal.Size = new System.Drawing.Size(43, 23);
            this.textBox_DataTrafficRxBytesTotal.TabIndex = 17;
            this.textBox_DataTrafficRxBytesTotal.Text = "0";
            this.textBox_DataTrafficRxBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tx Bytes:";
            // 
            // button_DataTrafficClear
            // 
            this.button_DataTrafficClear.Location = new System.Drawing.Point(551, 554);
            this.button_DataTrafficClear.Name = "button_DataTrafficClear";
            this.button_DataTrafficClear.Size = new System.Drawing.Size(48, 23);
            this.button_DataTrafficClear.TabIndex = 16;
            this.button_DataTrafficClear.Text = "Clear";
            this.button_DataTrafficClear.UseVisualStyleBackColor = true;
            this.button_DataTrafficClear.Click += new System.EventHandler(this.buttonDataTrafficClear_Click);
            // 
            // textBox_DataTrafficTxBytesTotal
            // 
            this.textBox_DataTrafficTxBytesTotal.Location = new System.Drawing.Point(298, 553);
            this.textBox_DataTrafficTxBytesTotal.Name = "textBox_DataTrafficTxBytesTotal";
            this.textBox_DataTrafficTxBytesTotal.Size = new System.Drawing.Size(43, 23);
            this.textBox_DataTrafficTxBytesTotal.TabIndex = 8;
            this.textBox_DataTrafficTxBytesTotal.Text = "0";
            this.textBox_DataTrafficTxBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton_DataTrafficFormatHEXSpaced
            // 
            this.radioButton_DataTrafficFormatHEXSpaced.AutoSize = true;
            this.radioButton_DataTrafficFormatHEXSpaced.Location = new System.Drawing.Point(129, 553);
            this.radioButton_DataTrafficFormatHEXSpaced.Name = "radioButton_DataTrafficFormatHEXSpaced";
            this.radioButton_DataTrafficFormatHEXSpaced.Size = new System.Drawing.Size(100, 21);
            this.radioButton_DataTrafficFormatHEXSpaced.TabIndex = 15;
            this.radioButton_DataTrafficFormatHEXSpaced.Text = "HEX SPACED";
            this.radioButton_DataTrafficFormatHEXSpaced.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTrafficFormatASCII
            // 
            this.radioButton_DataTrafficFormatASCII.AutoSize = true;
            this.radioButton_DataTrafficFormatASCII.Checked = true;
            this.radioButton_DataTrafficFormatASCII.Location = new System.Drawing.Point(6, 553);
            this.radioButton_DataTrafficFormatASCII.Name = "radioButton_DataTrafficFormatASCII";
            this.radioButton_DataTrafficFormatASCII.Size = new System.Drawing.Size(61, 21);
            this.radioButton_DataTrafficFormatASCII.TabIndex = 14;
            this.radioButton_DataTrafficFormatASCII.TabStop = true;
            this.radioButton_DataTrafficFormatASCII.Text = "ASCII";
            this.radioButton_DataTrafficFormatASCII.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTrafficFormatHEX
            // 
            this.radioButton_DataTrafficFormatHEX.AutoSize = true;
            this.radioButton_DataTrafficFormatHEX.Location = new System.Drawing.Point(73, 553);
            this.radioButton_DataTrafficFormatHEX.Name = "radioButton_DataTrafficFormatHEX";
            this.radioButton_DataTrafficFormatHEX.Size = new System.Drawing.Size(50, 21);
            this.radioButton_DataTrafficFormatHEX.TabIndex = 13;
            this.radioButton_DataTrafficFormatHEX.Text = "HEX";
            this.radioButton_DataTrafficFormatHEX.UseVisualStyleBackColor = true;
            // 
            // textBox_DataTraffic
            // 
            this.textBox_DataTraffic.Location = new System.Drawing.Point(6, 19);
            this.textBox_DataTraffic.Multiline = true;
            this.textBox_DataTraffic.Name = "textBox_DataTraffic";
            this.textBox_DataTraffic.Size = new System.Drawing.Size(593, 529);
            this.textBox_DataTraffic.TabIndex = 12;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(607, 595);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(599, 566);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Serial";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton_SendFrameFormatASCII);
            this.groupBox7.Controls.Add(this.radioButton_SendFrameFormatHex);
            this.groupBox7.Controls.Add(this.textBox_SendFrame);
            this.groupBox7.Controls.Add(this.checkBox_SendFrameHDLC);
            this.groupBox7.Controls.Add(this.button_SendFrameClear);
            this.groupBox7.Controls.Add(this.button_SendFramePaste);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(587, 227);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Framing";
            // 
            // radioButton_SendFrameFormatASCII
            // 
            this.radioButton_SendFrameFormatASCII.AutoSize = true;
            this.radioButton_SendFrameFormatASCII.Checked = true;
            this.radioButton_SendFrameFormatASCII.Location = new System.Drawing.Point(10, 199);
            this.radioButton_SendFrameFormatASCII.Name = "radioButton_SendFrameFormatASCII";
            this.radioButton_SendFrameFormatASCII.Size = new System.Drawing.Size(61, 21);
            this.radioButton_SendFrameFormatASCII.TabIndex = 24;
            this.radioButton_SendFrameFormatASCII.TabStop = true;
            this.radioButton_SendFrameFormatASCII.Text = "ASCII";
            this.radioButton_SendFrameFormatASCII.UseVisualStyleBackColor = true;
            // 
            // radioButton_SendFrameFormatHex
            // 
            this.radioButton_SendFrameFormatHex.AutoSize = true;
            this.radioButton_SendFrameFormatHex.Location = new System.Drawing.Point(77, 199);
            this.radioButton_SendFrameFormatHex.Name = "radioButton_SendFrameFormatHex";
            this.radioButton_SendFrameFormatHex.Size = new System.Drawing.Size(50, 21);
            this.radioButton_SendFrameFormatHex.TabIndex = 23;
            this.radioButton_SendFrameFormatHex.Text = "HEX";
            this.radioButton_SendFrameFormatHex.UseVisualStyleBackColor = true;
            // 
            // textBox_SendFrame
            // 
            this.textBox_SendFrame.Location = new System.Drawing.Point(10, 21);
            this.textBox_SendFrame.Multiline = true;
            this.textBox_SendFrame.Name = "textBox_SendFrame";
            this.textBox_SendFrame.Size = new System.Drawing.Size(571, 173);
            this.textBox_SendFrame.TabIndex = 0;
            // 
            // checkBox_SendFrameHDLC
            // 
            this.checkBox_SendFrameHDLC.AutoSize = true;
            this.checkBox_SendFrameHDLC.Location = new System.Drawing.Point(133, 200);
            this.checkBox_SendFrameHDLC.Name = "checkBox_SendFrameHDLC";
            this.checkBox_SendFrameHDLC.Size = new System.Drawing.Size(121, 21);
            this.checkBox_SendFrameHDLC.TabIndex = 16;
            this.checkBox_SendFrameHDLC.Text = "Is HDLC Frame?";
            this.checkBox_SendFrameHDLC.UseVisualStyleBackColor = true;
            // 
            // button_SendFrameClear
            // 
            this.button_SendFrameClear.Location = new System.Drawing.Point(506, 197);
            this.button_SendFrameClear.Name = "button_SendFrameClear";
            this.button_SendFrameClear.Size = new System.Drawing.Size(75, 24);
            this.button_SendFrameClear.TabIndex = 13;
            this.button_SendFrameClear.Text = "Clear";
            this.button_SendFrameClear.UseVisualStyleBackColor = true;
            this.button_SendFrameClear.Click += new System.EventHandler(this.button_SendFrameClear_Click);
            // 
            // button_SendFramePaste
            // 
            this.button_SendFramePaste.Location = new System.Drawing.Point(425, 197);
            this.button_SendFramePaste.Name = "button_SendFramePaste";
            this.button_SendFramePaste.Size = new System.Drawing.Size(75, 24);
            this.button_SendFramePaste.TabIndex = 15;
            this.button_SendFramePaste.Text = "Paste";
            this.button_SendFramePaste.UseVisualStyleBackColor = true;
            this.button_SendFramePaste.Click += new System.EventHandler(this.button_SendFramePaste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_SendRepeatSentCounter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SendRepeatNoOfTimes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_SendRepeatTime);
            this.groupBox1.Controls.Add(this.checkBox_SendRepeat);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Location = new System.Drawing.Point(6, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Counter: ";
            this.label5.Visible = false;
            // 
            // textBox_SendRepeatSentCounter
            // 
            this.textBox_SendRepeatSentCounter.Location = new System.Drawing.Point(444, 22);
            this.textBox_SendRepeatSentCounter.Name = "textBox_SendRepeatSentCounter";
            this.textBox_SendRepeatSentCounter.ReadOnly = true;
            this.textBox_SendRepeatSentCounter.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatSentCounter.TabIndex = 6;
            this.textBox_SendRepeatSentCounter.Text = "0";
            this.textBox_SendRepeatSentCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SendRepeatSentCounter.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "times: ";
            this.label3.Visible = false;
            // 
            // textBox_SendRepeatNoOfTimes
            // 
            this.textBox_SendRepeatNoOfTimes.Location = new System.Drawing.Point(295, 21);
            this.textBox_SendRepeatNoOfTimes.Name = "textBox_SendRepeatNoOfTimes";
            this.textBox_SendRepeatNoOfTimes.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatNoOfTimes.TabIndex = 4;
            this.textBox_SendRepeatNoOfTimes.Text = "100";
            this.textBox_SendRepeatNoOfTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SendRepeatNoOfTimes.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "time (ms):";
            this.label2.Visible = false;
            // 
            // textBox_SendRepeatTime
            // 
            this.textBox_SendRepeatTime.Location = new System.Drawing.Point(193, 21);
            this.textBox_SendRepeatTime.Name = "textBox_SendRepeatTime";
            this.textBox_SendRepeatTime.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatTime.TabIndex = 2;
            this.textBox_SendRepeatTime.Text = "1000";
            this.textBox_SendRepeatTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SendRepeatTime.Visible = false;
            // 
            // checkBox_SendRepeat
            // 
            this.checkBox_SendRepeat.AutoSize = true;
            this.checkBox_SendRepeat.Location = new System.Drawing.Point(19, 23);
            this.checkBox_SendRepeat.Name = "checkBox_SendRepeat";
            this.checkBox_SendRepeat.Size = new System.Drawing.Size(98, 21);
            this.checkBox_SendRepeat.TabIndex = 1;
            this.checkBox_SendRepeat.Text = "Send Repeat";
            this.checkBox_SendRepeat.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(504, 18);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 28);
            this.button_Send.TabIndex = 0;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox25);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label113);
            this.groupBox25.Controls.Add(this.label4);
            this.groupBox25.Controls.Add(this.label1);
            this.groupBox25.Controls.Add(this.button_ToolsCalculateChecksum);
            this.groupBox25.Controls.Add(this.textBox_ToolsChecksumCRC16);
            this.groupBox25.Controls.Add(this.textBox_ToolsChecksumBCCXOR);
            this.groupBox25.Controls.Add(this.textBox_ToolsChecksumMemory);
            this.groupBox25.Location = new System.Drawing.Point(298, 214);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(161, 140);
            this.groupBox25.TabIndex = 15;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Checksum";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(7, 70);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(76, 17);
            this.label113.TabIndex = 12;
            this.label113.Text = "CRC16/FCS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "BCC XOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Memory: ";
            // 
            // button_ToolsCalculateChecksum
            // 
            this.button_ToolsCalculateChecksum.Location = new System.Drawing.Point(10, 96);
            this.button_ToolsCalculateChecksum.Name = "button_ToolsCalculateChecksum";
            this.button_ToolsCalculateChecksum.Size = new System.Drawing.Size(141, 35);
            this.button_ToolsCalculateChecksum.TabIndex = 10;
            this.button_ToolsCalculateChecksum.Text = "Calculate";
            this.button_ToolsCalculateChecksum.UseVisualStyleBackColor = true;
            this.button_ToolsCalculateChecksum.Click += new System.EventHandler(this.button_ToolsCalculateChecksum_Click);
            // 
            // textBox_ToolsChecksumCRC16
            // 
            this.textBox_ToolsChecksumCRC16.Location = new System.Drawing.Point(88, 67);
            this.textBox_ToolsChecksumCRC16.Name = "textBox_ToolsChecksumCRC16";
            this.textBox_ToolsChecksumCRC16.Size = new System.Drawing.Size(63, 23);
            this.textBox_ToolsChecksumCRC16.TabIndex = 2;
            // 
            // textBox_ToolsChecksumBCCXOR
            // 
            this.textBox_ToolsChecksumBCCXOR.Location = new System.Drawing.Point(88, 42);
            this.textBox_ToolsChecksumBCCXOR.Name = "textBox_ToolsChecksumBCCXOR";
            this.textBox_ToolsChecksumBCCXOR.Size = new System.Drawing.Size(63, 23);
            this.textBox_ToolsChecksumBCCXOR.TabIndex = 1;
            // 
            // textBox_ToolsChecksumMemory
            // 
            this.textBox_ToolsChecksumMemory.Location = new System.Drawing.Point(88, 17);
            this.textBox_ToolsChecksumMemory.Name = "textBox_ToolsChecksumMemory";
            this.textBox_ToolsChecksumMemory.Size = new System.Drawing.Size(63, 23);
            this.textBox_ToolsChecksumMemory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonWordwrapConvert);
            this.groupBox3.Controls.Add(this.textBoxWordwrapLength);
            this.groupBox3.Location = new System.Drawing.Point(156, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 88);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Word wrap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Length: ";
            // 
            // buttonWordwrapConvert
            // 
            this.buttonWordwrapConvert.Location = new System.Drawing.Point(6, 50);
            this.buttonWordwrapConvert.Name = "buttonWordwrapConvert";
            this.buttonWordwrapConvert.Size = new System.Drawing.Size(124, 35);
            this.buttonWordwrapConvert.TabIndex = 8;
            this.buttonWordwrapConvert.Text = "Convert";
            this.buttonWordwrapConvert.UseVisualStyleBackColor = true;
            this.buttonWordwrapConvert.Click += new System.EventHandler(this.buttonWordwrapConvert_Click);
            // 
            // textBoxWordwrapLength
            // 
            this.textBoxWordwrapLength.Location = new System.Drawing.Point(86, 22);
            this.textBoxWordwrapLength.Name = "textBoxWordwrapLength";
            this.textBoxWordwrapLength.Size = new System.Drawing.Size(37, 23);
            this.textBoxWordwrapLength.TabIndex = 7;
            this.textBoxWordwrapLength.Text = "2";
            this.textBoxWordwrapLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxStringFilterRemoveHEX);
            this.groupBox5.Controls.Add(this.buttonStringFilterConvert);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveHEX);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveTab);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveLF);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveCR);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveSpace);
            this.groupBox5.Location = new System.Drawing.Point(14, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 163);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "String Filter";
            // 
            // textBoxStringFilterRemoveHEX
            // 
            this.textBoxStringFilterRemoveHEX.Enabled = false;
            this.textBoxStringFilterRemoveHEX.Location = new System.Drawing.Point(107, 94);
            this.textBoxStringFilterRemoveHEX.Name = "textBoxStringFilterRemoveHEX";
            this.textBoxStringFilterRemoveHEX.Size = new System.Drawing.Size(23, 23);
            this.textBoxStringFilterRemoveHEX.TabIndex = 9;
            // 
            // buttonStringFilterConvert
            // 
            this.buttonStringFilterConvert.Location = new System.Drawing.Point(6, 123);
            this.buttonStringFilterConvert.Name = "buttonStringFilterConvert";
            this.buttonStringFilterConvert.Size = new System.Drawing.Size(117, 35);
            this.buttonStringFilterConvert.TabIndex = 8;
            this.buttonStringFilterConvert.Text = "Convert";
            this.buttonStringFilterConvert.UseVisualStyleBackColor = true;
            this.buttonStringFilterConvert.Click += new System.EventHandler(this.buttonStringFilterConvert_Click);
            // 
            // checkBoxStringFilterRemoveHEX
            // 
            this.checkBoxStringFilterRemoveHEX.AutoSize = true;
            this.checkBoxStringFilterRemoveHEX.Location = new System.Drawing.Point(6, 96);
            this.checkBoxStringFilterRemoveHEX.Name = "checkBoxStringFilterRemoveHEX";
            this.checkBoxStringFilterRemoveHEX.Size = new System.Drawing.Size(101, 21);
            this.checkBoxStringFilterRemoveHEX.TabIndex = 6;
            this.checkBoxStringFilterRemoveHEX.Text = "Remove HEX";
            this.checkBoxStringFilterRemoveHEX.UseVisualStyleBackColor = true;
            this.checkBoxStringFilterRemoveHEX.CheckedChanged += new System.EventHandler(this.checkBoxStringFilterRemoveHEX_CheckedChanged);
            // 
            // checkBoxStringFilterRemoveTab
            // 
            this.checkBoxStringFilterRemoveTab.AutoSize = true;
            this.checkBoxStringFilterRemoveTab.Location = new System.Drawing.Point(6, 79);
            this.checkBoxStringFilterRemoveTab.Name = "checkBoxStringFilterRemoveTab";
            this.checkBoxStringFilterRemoveTab.Size = new System.Drawing.Size(97, 21);
            this.checkBoxStringFilterRemoveTab.TabIndex = 5;
            this.checkBoxStringFilterRemoveTab.Text = "Remove Tab";
            this.checkBoxStringFilterRemoveTab.UseVisualStyleBackColor = true;
            // 
            // checkBoxStringFilterRemoveLF
            // 
            this.checkBoxStringFilterRemoveLF.AutoSize = true;
            this.checkBoxStringFilterRemoveLF.Location = new System.Drawing.Point(6, 60);
            this.checkBoxStringFilterRemoveLF.Name = "checkBoxStringFilterRemoveLF";
            this.checkBoxStringFilterRemoveLF.Size = new System.Drawing.Size(91, 21);
            this.checkBoxStringFilterRemoveLF.TabIndex = 4;
            this.checkBoxStringFilterRemoveLF.Text = "Remove LF";
            this.checkBoxStringFilterRemoveLF.UseVisualStyleBackColor = true;
            // 
            // checkBoxStringFilterRemoveCR
            // 
            this.checkBoxStringFilterRemoveCR.AutoSize = true;
            this.checkBoxStringFilterRemoveCR.Location = new System.Drawing.Point(6, 42);
            this.checkBoxStringFilterRemoveCR.Name = "checkBoxStringFilterRemoveCR";
            this.checkBoxStringFilterRemoveCR.Size = new System.Drawing.Size(94, 21);
            this.checkBoxStringFilterRemoveCR.TabIndex = 3;
            this.checkBoxStringFilterRemoveCR.Text = "Remove CR";
            this.checkBoxStringFilterRemoveCR.UseVisualStyleBackColor = true;
            // 
            // checkBoxStringFilterRemoveSpace
            // 
            this.checkBoxStringFilterRemoveSpace.AutoSize = true;
            this.checkBoxStringFilterRemoveSpace.Location = new System.Drawing.Point(6, 22);
            this.checkBoxStringFilterRemoveSpace.Name = "checkBoxStringFilterRemoveSpace";
            this.checkBoxStringFilterRemoveSpace.Size = new System.Drawing.Size(111, 21);
            this.checkBoxStringFilterRemoveSpace.TabIndex = 2;
            this.checkBoxStringFilterRemoveSpace.Text = "Remove Space";
            this.checkBoxStringFilterRemoveSpace.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonToolsOutputTextBoxCopy);
            this.groupBox4.Controls.Add(this.buttonToolsOutputTextBoxClear);
            this.groupBox4.Controls.Add(this.radiobuttonToolsOutputTextBoxHEXSpaced);
            this.groupBox4.Controls.Add(this.radiobuttonToolsOutputTextBoxASCII);
            this.groupBox4.Controls.Add(this.radiobuttonToolsOutputTextBoxHEX);
            this.groupBox4.Controls.Add(this.textBox_ToolsOutputString);
            this.groupBox4.Location = new System.Drawing.Point(641, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 209);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output String";
            // 
            // buttonToolsOutputTextBoxCopy
            // 
            this.buttonToolsOutputTextBoxCopy.Location = new System.Drawing.Point(472, 177);
            this.buttonToolsOutputTextBoxCopy.Name = "buttonToolsOutputTextBoxCopy";
            this.buttonToolsOutputTextBoxCopy.Size = new System.Drawing.Size(46, 23);
            this.buttonToolsOutputTextBoxCopy.TabIndex = 9;
            this.buttonToolsOutputTextBoxCopy.Text = "Copy";
            this.buttonToolsOutputTextBoxCopy.UseVisualStyleBackColor = true;
            this.buttonToolsOutputTextBoxCopy.Click += new System.EventHandler(this.buttonToolsOutputTextBoxCopy_Click);
            // 
            // buttonToolsOutputTextBoxClear
            // 
            this.buttonToolsOutputTextBoxClear.Location = new System.Drawing.Point(520, 177);
            this.buttonToolsOutputTextBoxClear.Name = "buttonToolsOutputTextBoxClear";
            this.buttonToolsOutputTextBoxClear.Size = new System.Drawing.Size(48, 23);
            this.buttonToolsOutputTextBoxClear.TabIndex = 7;
            this.buttonToolsOutputTextBoxClear.Text = "Clear";
            this.buttonToolsOutputTextBoxClear.UseVisualStyleBackColor = true;
            this.buttonToolsOutputTextBoxClear.Click += new System.EventHandler(this.buttonToolsOutputTextBoxClear_Click);
            // 
            // radiobuttonToolsOutputTextBoxHEXSpaced
            // 
            this.radiobuttonToolsOutputTextBoxHEXSpaced.AutoSize = true;
            this.radiobuttonToolsOutputTextBoxHEXSpaced.Location = new System.Drawing.Point(129, 180);
            this.radiobuttonToolsOutputTextBoxHEXSpaced.Name = "radiobuttonToolsOutputTextBoxHEXSpaced";
            this.radiobuttonToolsOutputTextBoxHEXSpaced.Size = new System.Drawing.Size(100, 21);
            this.radiobuttonToolsOutputTextBoxHEXSpaced.TabIndex = 3;
            this.radiobuttonToolsOutputTextBoxHEXSpaced.Text = "HEX SPACED";
            this.radiobuttonToolsOutputTextBoxHEXSpaced.UseVisualStyleBackColor = true;
            // 
            // radiobuttonToolsOutputTextBoxASCII
            // 
            this.radiobuttonToolsOutputTextBoxASCII.AutoSize = true;
            this.radiobuttonToolsOutputTextBoxASCII.Checked = true;
            this.radiobuttonToolsOutputTextBoxASCII.Location = new System.Drawing.Point(6, 180);
            this.radiobuttonToolsOutputTextBoxASCII.Name = "radiobuttonToolsOutputTextBoxASCII";
            this.radiobuttonToolsOutputTextBoxASCII.Size = new System.Drawing.Size(61, 21);
            this.radiobuttonToolsOutputTextBoxASCII.TabIndex = 2;
            this.radiobuttonToolsOutputTextBoxASCII.TabStop = true;
            this.radiobuttonToolsOutputTextBoxASCII.Text = "ASCII";
            this.radiobuttonToolsOutputTextBoxASCII.UseVisualStyleBackColor = true;
            // 
            // radiobuttonToolsOutputTextBoxHEX
            // 
            this.radiobuttonToolsOutputTextBoxHEX.AutoSize = true;
            this.radiobuttonToolsOutputTextBoxHEX.Location = new System.Drawing.Point(73, 180);
            this.radiobuttonToolsOutputTextBoxHEX.Name = "radiobuttonToolsOutputTextBoxHEX";
            this.radiobuttonToolsOutputTextBoxHEX.Size = new System.Drawing.Size(50, 21);
            this.radiobuttonToolsOutputTextBoxHEX.TabIndex = 1;
            this.radiobuttonToolsOutputTextBoxHEX.Text = "HEX";
            this.radiobuttonToolsOutputTextBoxHEX.UseVisualStyleBackColor = true;
            // 
            // textBox_ToolsOutputString
            // 
            this.textBox_ToolsOutputString.Location = new System.Drawing.Point(6, 22);
            this.textBox_ToolsOutputString.Multiline = true;
            this.textBox_ToolsOutputString.Name = "textBox_ToolsOutputString";
            this.textBox_ToolsOutputString.ReadOnly = true;
            this.textBox_ToolsOutputString.Size = new System.Drawing.Size(565, 153);
            this.textBox_ToolsOutputString.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonToolsInputTextBoxPaste);
            this.groupBox2.Controls.Add(this.buttonToolsInputTextBoxClear);
            this.groupBox2.Controls.Add(this.radioButtonToolsInputTextBoxHEXSpaced);
            this.groupBox2.Controls.Add(this.radioButtonToolsInputTextBoxASCII);
            this.groupBox2.Controls.Add(this.radioButtonToolsInputTextBoxHEX);
            this.groupBox2.Controls.Add(this.textBox_ToolsInputString);
            this.groupBox2.Location = new System.Drawing.Point(14, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input String";
            // 
            // buttonToolsInputTextBoxPaste
            // 
            this.buttonToolsInputTextBoxPaste.Location = new System.Drawing.Point(511, 177);
            this.buttonToolsInputTextBoxPaste.Name = "buttonToolsInputTextBoxPaste";
            this.buttonToolsInputTextBoxPaste.Size = new System.Drawing.Size(50, 23);
            this.buttonToolsInputTextBoxPaste.TabIndex = 5;
            this.buttonToolsInputTextBoxPaste.Text = "Paste";
            this.buttonToolsInputTextBoxPaste.UseVisualStyleBackColor = true;
            this.buttonToolsInputTextBoxPaste.Click += new System.EventHandler(this.buttonToolsInputTextBoxPaste_Click);
            // 
            // buttonToolsInputTextBoxClear
            // 
            this.buttonToolsInputTextBoxClear.Location = new System.Drawing.Point(567, 177);
            this.buttonToolsInputTextBoxClear.Name = "buttonToolsInputTextBoxClear";
            this.buttonToolsInputTextBoxClear.Size = new System.Drawing.Size(48, 23);
            this.buttonToolsInputTextBoxClear.TabIndex = 4;
            this.buttonToolsInputTextBoxClear.Text = "Clear";
            this.buttonToolsInputTextBoxClear.UseVisualStyleBackColor = true;
            this.buttonToolsInputTextBoxClear.Click += new System.EventHandler(this.buttonToolsInputTextBoxClear_Click);
            // 
            // radioButtonToolsInputTextBoxHEXSpaced
            // 
            this.radioButtonToolsInputTextBoxHEXSpaced.AutoSize = true;
            this.radioButtonToolsInputTextBoxHEXSpaced.Location = new System.Drawing.Point(129, 179);
            this.radioButtonToolsInputTextBoxHEXSpaced.Name = "radioButtonToolsInputTextBoxHEXSpaced";
            this.radioButtonToolsInputTextBoxHEXSpaced.Size = new System.Drawing.Size(100, 21);
            this.radioButtonToolsInputTextBoxHEXSpaced.TabIndex = 3;
            this.radioButtonToolsInputTextBoxHEXSpaced.Text = "HEX SPACED";
            this.radioButtonToolsInputTextBoxHEXSpaced.UseVisualStyleBackColor = true;
            // 
            // radioButtonToolsInputTextBoxASCII
            // 
            this.radioButtonToolsInputTextBoxASCII.AutoSize = true;
            this.radioButtonToolsInputTextBoxASCII.Checked = true;
            this.radioButtonToolsInputTextBoxASCII.Location = new System.Drawing.Point(6, 179);
            this.radioButtonToolsInputTextBoxASCII.Name = "radioButtonToolsInputTextBoxASCII";
            this.radioButtonToolsInputTextBoxASCII.Size = new System.Drawing.Size(61, 21);
            this.radioButtonToolsInputTextBoxASCII.TabIndex = 2;
            this.radioButtonToolsInputTextBoxASCII.TabStop = true;
            this.radioButtonToolsInputTextBoxASCII.Text = "ASCII";
            this.radioButtonToolsInputTextBoxASCII.UseVisualStyleBackColor = true;
            // 
            // radioButtonToolsInputTextBoxHEX
            // 
            this.radioButtonToolsInputTextBoxHEX.AutoSize = true;
            this.radioButtonToolsInputTextBoxHEX.Location = new System.Drawing.Point(73, 179);
            this.radioButtonToolsInputTextBoxHEX.Name = "radioButtonToolsInputTextBoxHEX";
            this.radioButtonToolsInputTextBoxHEX.Size = new System.Drawing.Size(50, 21);
            this.radioButtonToolsInputTextBoxHEX.TabIndex = 1;
            this.radioButtonToolsInputTextBoxHEX.Text = "HEX";
            this.radioButtonToolsInputTextBoxHEX.UseVisualStyleBackColor = true;
            // 
            // textBox_ToolsInputString
            // 
            this.textBox_ToolsInputString.Location = new System.Drawing.Point(6, 22);
            this.textBox_ToolsInputString.Multiline = true;
            this.textBox_ToolsInputString.Name = "textBox_ToolsInputString";
            this.textBox_ToolsInputString.Size = new System.Drawing.Size(609, 153);
            this.textBox_ToolsInputString.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Energy Meter";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1214, 591);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage5.Controls.Add(this.textBox_TamperStatus);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.groupBox19);
            this.tabPage5.Controls.Add(this.groupBox22);
            this.tabPage5.Controls.Add(this.groupBox23);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1206, 562);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Instant Data";
            // 
            // textBox_TamperStatus
            // 
            this.textBox_TamperStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_TamperStatus.Location = new System.Drawing.Point(7, 551);
            this.textBox_TamperStatus.Multiline = true;
            this.textBox_TamperStatus.Name = "textBox_TamperStatus";
            this.textBox_TamperStatus.Size = new System.Drawing.Size(1170, 34);
            this.textBox_TamperStatus.TabIndex = 406;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label116);
            this.groupBox15.Controls.Add(this.textBox_EnergyWhTotalFunda);
            this.groupBox15.Controls.Add(this.label62);
            this.groupBox15.Controls.Add(this.label67);
            this.groupBox15.Controls.Add(this.label69);
            this.groupBox15.Controls.Add(this.label68);
            this.groupBox15.Controls.Add(this.textBox_EnergyWhR);
            this.groupBox15.Controls.Add(this.textBox_EnergyWhY);
            this.groupBox15.Controls.Add(this.textBox_EnergyWhB);
            this.groupBox15.Controls.Add(this.textBox_EnergyWhTotal);
            this.groupBox15.Controls.Add(this.textBox_EnergyVARhLagTotal);
            this.groupBox15.Controls.Add(this.textBox_EnergyVARhLeadTotal);
            this.groupBox15.Controls.Add(this.textBox_EnergyVAhTotal);
            this.groupBox15.Controls.Add(this.label63);
            this.groupBox15.Controls.Add(this.label66);
            this.groupBox15.Controls.Add(this.label64);
            this.groupBox15.Controls.Add(this.label65);
            this.groupBox15.Location = new System.Drawing.Point(6, 382);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(479, 163);
            this.groupBox15.TabIndex = 405;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Read Energy";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.Location = new System.Drawing.Point(6, 138);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(94, 17);
            this.label116.TabIndex = 519;
            this.label116.Text = "Fundamental:";
            // 
            // textBox_EnergyWhTotalFunda
            // 
            this.textBox_EnergyWhTotalFunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhTotalFunda.Location = new System.Drawing.Point(383, 135);
            this.textBox_EnergyWhTotalFunda.Name = "textBox_EnergyWhTotalFunda";
            this.textBox_EnergyWhTotalFunda.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyWhTotalFunda.TabIndex = 518;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(384, 14);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(75, 17);
            this.label62.TabIndex = 517;
            this.label62.Text = "Net/Total";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.Red;
            this.label67.Location = new System.Drawing.Point(102, 13);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(69, 17);
            this.label67.TabIndex = 514;
            this.label67.Text = "R Phase";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.Blue;
            this.label69.Location = new System.Drawing.Point(285, 15);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(68, 17);
            this.label69.TabIndex = 516;
            this.label69.Text = "B Phase";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.Yellow;
            this.label68.Location = new System.Drawing.Point(195, 15);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(68, 17);
            this.label68.TabIndex = 515;
            this.label68.Text = "Y Phase";
            // 
            // textBox_EnergyWhR
            // 
            this.textBox_EnergyWhR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyWhR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhR.Location = new System.Drawing.Point(93, 38);
            this.textBox_EnergyWhR.Name = "textBox_EnergyWhR";
            this.textBox_EnergyWhR.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyWhR.TabIndex = 504;
            // 
            // textBox_EnergyWhY
            // 
            this.textBox_EnergyWhY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyWhY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhY.Location = new System.Drawing.Point(191, 38);
            this.textBox_EnergyWhY.Name = "textBox_EnergyWhY";
            this.textBox_EnergyWhY.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyWhY.TabIndex = 506;
            // 
            // textBox_EnergyWhB
            // 
            this.textBox_EnergyWhB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyWhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhB.Location = new System.Drawing.Point(282, 38);
            this.textBox_EnergyWhB.Name = "textBox_EnergyWhB";
            this.textBox_EnergyWhB.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyWhB.TabIndex = 507;
            // 
            // textBox_EnergyWhTotal
            // 
            this.textBox_EnergyWhTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhTotal.Location = new System.Drawing.Point(383, 38);
            this.textBox_EnergyWhTotal.Name = "textBox_EnergyWhTotal";
            this.textBox_EnergyWhTotal.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyWhTotal.TabIndex = 505;
            // 
            // textBox_EnergyVARhLagTotal
            // 
            this.textBox_EnergyVARhLagTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhLagTotal.Location = new System.Drawing.Point(383, 62);
            this.textBox_EnergyVARhLagTotal.Name = "textBox_EnergyVARhLagTotal";
            this.textBox_EnergyVARhLagTotal.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyVARhLagTotal.TabIndex = 509;
            // 
            // textBox_EnergyVARhLeadTotal
            // 
            this.textBox_EnergyVARhLeadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhLeadTotal.Location = new System.Drawing.Point(383, 86);
            this.textBox_EnergyVARhLeadTotal.Name = "textBox_EnergyVARhLeadTotal";
            this.textBox_EnergyVARhLeadTotal.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyVARhLeadTotal.TabIndex = 511;
            // 
            // textBox_EnergyVAhTotal
            // 
            this.textBox_EnergyVAhTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhTotal.Location = new System.Drawing.Point(383, 110);
            this.textBox_EnergyVAhTotal.Name = "textBox_EnergyVAhTotal";
            this.textBox_EnergyVAhTotal.Size = new System.Drawing.Size(78, 23);
            this.textBox_EnergyVAhTotal.TabIndex = 513;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(10, 41);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(87, 17);
            this.label63.TabIndex = 503;
            this.label63.Text = "Energy(Act):";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(5, 113);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(92, 17);
            this.label66.TabIndex = 512;
            this.label66.Text = "Energy(App):";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(6, 65);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(91, 17);
            this.label64.TabIndex = 508;
            this.label64.Text = "Energy(Lag):";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(-2, 89);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(99, 17);
            this.label65.TabIndex = 510;
            this.label65.Text = "Energy(Lead):";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox_MISCData);
            this.groupBox19.Controls.Add(this.label117);
            this.groupBox19.Controls.Add(this.textBox_LoopCycles);
            this.groupBox19.Controls.Add(this.textBox_THDIb);
            this.groupBox19.Controls.Add(this.textBox_THDIy);
            this.groupBox19.Controls.Add(this.textBox_THDIr);
            this.groupBox19.Controls.Add(this.label114);
            this.groupBox19.Controls.Add(this.textBox_THDVb);
            this.groupBox19.Controls.Add(this.textBox_THDVy);
            this.groupBox19.Controls.Add(this.textBox_THDVr);
            this.groupBox19.Controls.Add(this.label115);
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Controls.Add(this.label108);
            this.groupBox19.Controls.Add(this.textBox_BatteryVoltage);
            this.groupBox19.Controls.Add(this.label107);
            this.groupBox19.Controls.Add(this.textBox_TempTLV);
            this.groupBox19.Controls.Add(this.labelMetrologyTimer);
            this.groupBox19.Controls.Add(this.textBox_SamplesPerSec);
            this.groupBox19.Controls.Add(this.groupBox18);
            this.groupBox19.Controls.Add(this.groupBox16);
            this.groupBox19.Controls.Add(this.button_ShowVectorDiagram);
            this.groupBox19.Controls.Add(this.textBox_AnglePFBph);
            this.groupBox19.Controls.Add(this.textBox_AnglePFYph);
            this.groupBox19.Controls.Add(this.textBox_AnglePFRph);
            this.groupBox19.Controls.Add(this.label73);
            this.groupBox19.Controls.Add(this.textBox_SamplesB);
            this.groupBox19.Controls.Add(this.textBox_SamplesY);
            this.groupBox19.Controls.Add(this.textBox_SamplesR);
            this.groupBox19.Controls.Add(this.label50);
            this.groupBox19.Controls.Add(this.groupBox17);
            this.groupBox19.Controls.Add(this.textBox_CalAngleReactB);
            this.groupBox19.Controls.Add(this.textBox_CalAngleReactY);
            this.groupBox19.Controls.Add(this.textBox_CalAngleReactR);
            this.groupBox19.Controls.Add(this.label61);
            this.groupBox19.Controls.Add(this.label55);
            this.groupBox19.Controls.Add(this.textBox_Time);
            this.groupBox19.Controls.Add(this.textBox_QuadB);
            this.groupBox19.Controls.Add(this.textBox_FreqB);
            this.groupBox19.Controls.Add(this.textBox_VAB);
            this.groupBox19.Controls.Add(this.textBox_VARB);
            this.groupBox19.Controls.Add(this.textBox_WattB);
            this.groupBox19.Controls.Add(this.textBox_CalAngleActB);
            this.groupBox19.Controls.Add(this.textBox_PFB);
            this.groupBox19.Controls.Add(this.textBox_CurrBdc);
            this.groupBox19.Controls.Add(this.textBox_CurrB);
            this.groupBox19.Controls.Add(this.textBox_VolBdc);
            this.groupBox19.Controls.Add(this.textBox_VolB);
            this.groupBox19.Controls.Add(this.textBox_QuadY);
            this.groupBox19.Controls.Add(this.textBox_FreqY);
            this.groupBox19.Controls.Add(this.textBox_VAY);
            this.groupBox19.Controls.Add(this.textBox_VARY);
            this.groupBox19.Controls.Add(this.textBox_WattY);
            this.groupBox19.Controls.Add(this.textBox_CalAngleActY);
            this.groupBox19.Controls.Add(this.textBox_PFY);
            this.groupBox19.Controls.Add(this.textBox_CurrYdc);
            this.groupBox19.Controls.Add(this.textBox_CurrY);
            this.groupBox19.Controls.Add(this.textBox_VolYdc);
            this.groupBox19.Controls.Add(this.textBox_VolY);
            this.groupBox19.Controls.Add(this.textBox_QuadNet);
            this.groupBox19.Controls.Add(this.textBox_FreqNet);
            this.groupBox19.Controls.Add(this.textBox_VANet);
            this.groupBox19.Controls.Add(this.textBox_VARNet);
            this.groupBox19.Controls.Add(this.textBox_WattNet);
            this.groupBox19.Controls.Add(this.textBox_PFNet);
            this.groupBox19.Controls.Add(this.textBox_QuadR);
            this.groupBox19.Controls.Add(this.textBox_FreqR);
            this.groupBox19.Controls.Add(this.textBox_VAR);
            this.groupBox19.Controls.Add(this.textBox_VARR);
            this.groupBox19.Controls.Add(this.textBox_WattR);
            this.groupBox19.Controls.Add(this.textBox_CalAngleActR);
            this.groupBox19.Controls.Add(this.textBox_PFR);
            this.groupBox19.Controls.Add(this.textBox_CurrRdc);
            this.groupBox19.Controls.Add(this.textBox_CurrR);
            this.groupBox19.Controls.Add(this.textBox_VolRdc);
            this.groupBox19.Controls.Add(this.textBox_VolR);
            this.groupBox19.Controls.Add(this.label44);
            this.groupBox19.Controls.Add(this.label54);
            this.groupBox19.Controls.Add(this.label53);
            this.groupBox19.Controls.Add(this.label52);
            this.groupBox19.Controls.Add(this.label51);
            this.groupBox19.Controls.Add(this.label47);
            this.groupBox19.Controls.Add(this.label48);
            this.groupBox19.Controls.Add(this.label49);
            this.groupBox19.Controls.Add(this.label45);
            this.groupBox19.Controls.Add(this.label46);
            this.groupBox19.Controls.Add(this.label76);
            this.groupBox19.Controls.Add(this.label78);
            this.groupBox19.Controls.Add(this.label79);
            this.groupBox19.Controls.Add(this.label80);
            this.groupBox19.Controls.Add(this.label81);
            this.groupBox19.Location = new System.Drawing.Point(491, 6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(687, 539);
            this.groupBox19.TabIndex = 403;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Read Instant Data";
            // 
            // textBox_MISCData
            // 
            this.textBox_MISCData.Location = new System.Drawing.Point(420, 339);
            this.textBox_MISCData.Multiline = true;
            this.textBox_MISCData.Name = "textBox_MISCData";
            this.textBox_MISCData.Size = new System.Drawing.Size(238, 67);
            this.textBox_MISCData.TabIndex = 527;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(413, 448);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(44, 17);
            this.label117.TabIndex = 525;
            this.label117.Text = "Loop:";
            // 
            // textBox_LoopCycles
            // 
            this.textBox_LoopCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoopCycles.Location = new System.Drawing.Point(462, 445);
            this.textBox_LoopCycles.Name = "textBox_LoopCycles";
            this.textBox_LoopCycles.ReadOnly = true;
            this.textBox_LoopCycles.Size = new System.Drawing.Size(56, 23);
            this.textBox_LoopCycles.TabIndex = 526;
            // 
            // textBox_THDIb
            // 
            this.textBox_THDIb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_THDIb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIb.Location = new System.Drawing.Point(259, 418);
            this.textBox_THDIb.Name = "textBox_THDIb";
            this.textBox_THDIb.ReadOnly = true;
            this.textBox_THDIb.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDIb.TabIndex = 524;
            // 
            // textBox_THDIy
            // 
            this.textBox_THDIy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_THDIy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIy.Location = new System.Drawing.Point(183, 418);
            this.textBox_THDIy.Name = "textBox_THDIy";
            this.textBox_THDIy.ReadOnly = true;
            this.textBox_THDIy.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDIy.TabIndex = 523;
            // 
            // textBox_THDIr
            // 
            this.textBox_THDIr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_THDIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIr.Location = new System.Drawing.Point(107, 417);
            this.textBox_THDIr.Name = "textBox_THDIr";
            this.textBox_THDIr.ReadOnly = true;
            this.textBox_THDIr.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDIr.TabIndex = 522;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(27, 419);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(78, 17);
            this.label114.TabIndex = 521;
            this.label114.Text = "THD(Curr):";
            // 
            // textBox_THDVb
            // 
            this.textBox_THDVb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_THDVb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVb.Location = new System.Drawing.Point(259, 393);
            this.textBox_THDVb.Name = "textBox_THDVb";
            this.textBox_THDVb.ReadOnly = true;
            this.textBox_THDVb.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDVb.TabIndex = 520;
            // 
            // textBox_THDVy
            // 
            this.textBox_THDVy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_THDVy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVy.Location = new System.Drawing.Point(183, 393);
            this.textBox_THDVy.Name = "textBox_THDVy";
            this.textBox_THDVy.ReadOnly = true;
            this.textBox_THDVy.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDVy.TabIndex = 519;
            // 
            // textBox_THDVr
            // 
            this.textBox_THDVr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_THDVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVr.Location = new System.Drawing.Point(107, 392);
            this.textBox_THDVr.Name = "textBox_THDVr";
            this.textBox_THDVr.ReadOnly = true;
            this.textBox_THDVr.Size = new System.Drawing.Size(61, 23);
            this.textBox_THDVr.TabIndex = 518;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(30, 395);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(71, 17);
            this.label115.TabIndex = 517;
            this.label115.Text = "THD(Vol):";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.textBox_ReactiveTimeDeviation);
            this.groupBox21.Controls.Add(this.label112);
            this.groupBox21.Controls.Add(this.textBox_ReactiveTimeDelay);
            this.groupBox21.Controls.Add(this.label111);
            this.groupBox21.Controls.Add(this.textBox_ReactiveTimer);
            this.groupBox21.Controls.Add(this.textBox_ReactiveSamples);
            this.groupBox21.Controls.Add(this.label110);
            this.groupBox21.Controls.Add(this.label109);
            this.groupBox21.Location = new System.Drawing.Point(524, 414);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(151, 117);
            this.groupBox21.TabIndex = 516;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Reactive";
            // 
            // textBox_ReactiveTimeDeviation
            // 
            this.textBox_ReactiveTimeDeviation.Location = new System.Drawing.Point(86, 91);
            this.textBox_ReactiveTimeDeviation.Name = "textBox_ReactiveTimeDeviation";
            this.textBox_ReactiveTimeDeviation.Size = new System.Drawing.Size(62, 23);
            this.textBox_ReactiveTimeDeviation.TabIndex = 7;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(8, 91);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(88, 17);
            this.label112.TabIndex = 6;
            this.label112.Text = "time deviation";
            // 
            // textBox_ReactiveTimeDelay
            // 
            this.textBox_ReactiveTimeDelay.Location = new System.Drawing.Point(86, 66);
            this.textBox_ReactiveTimeDelay.Name = "textBox_ReactiveTimeDelay";
            this.textBox_ReactiveTimeDelay.Size = new System.Drawing.Size(62, 23);
            this.textBox_ReactiveTimeDelay.TabIndex = 5;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(8, 66);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(67, 17);
            this.label111.TabIndex = 4;
            this.label111.Text = "time delay";
            // 
            // textBox_ReactiveTimer
            // 
            this.textBox_ReactiveTimer.Location = new System.Drawing.Point(86, 40);
            this.textBox_ReactiveTimer.Name = "textBox_ReactiveTimer";
            this.textBox_ReactiveTimer.Size = new System.Drawing.Size(62, 23);
            this.textBox_ReactiveTimer.TabIndex = 3;
            // 
            // textBox_ReactiveSamples
            // 
            this.textBox_ReactiveSamples.Location = new System.Drawing.Point(86, 16);
            this.textBox_ReactiveSamples.Name = "textBox_ReactiveSamples";
            this.textBox_ReactiveSamples.Size = new System.Drawing.Size(62, 23);
            this.textBox_ReactiveSamples.TabIndex = 2;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(8, 40);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(41, 17);
            this.label110.TabIndex = 1;
            this.label110.Text = "Timer";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(5, 17);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(56, 17);
            this.label109.TabIndex = 0;
            this.label109.Text = "Samples";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(401, 477);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(76, 17);
            this.label108.TabIndex = 514;
            this.label108.Text = "Battery(V):";
            // 
            // textBox_BatteryVoltage
            // 
            this.textBox_BatteryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BatteryVoltage.Location = new System.Drawing.Point(478, 474);
            this.textBox_BatteryVoltage.Name = "textBox_BatteryVoltage";
            this.textBox_BatteryVoltage.ReadOnly = true;
            this.textBox_BatteryVoltage.Size = new System.Drawing.Size(41, 23);
            this.textBox_BatteryVoltage.TabIndex = 515;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(407, 422);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(67, 17);
            this.label107.TabIndex = 512;
            this.label107.Text = "Temp(C):";
            // 
            // textBox_TempTLV
            // 
            this.textBox_TempTLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TempTLV.Location = new System.Drawing.Point(477, 419);
            this.textBox_TempTLV.Name = "textBox_TempTLV";
            this.textBox_TempTLV.ReadOnly = true;
            this.textBox_TempTLV.Size = new System.Drawing.Size(41, 23);
            this.textBox_TempTLV.TabIndex = 513;
            // 
            // labelMetrologyTimer
            // 
            this.labelMetrologyTimer.AutoSize = true;
            this.labelMetrologyTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetrologyTimer.Location = new System.Drawing.Point(496, 213);
            this.labelMetrologyTimer.Name = "labelMetrologyTimer";
            this.labelMetrologyTimer.Size = new System.Drawing.Size(49, 17);
            this.labelMetrologyTimer.TabIndex = 511;
            this.labelMetrologyTimer.Text = "Timer";
            // 
            // textBox_SamplesPerSec
            // 
            this.textBox_SamplesPerSec.BackColor = System.Drawing.Color.White;
            this.textBox_SamplesPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesPerSec.Location = new System.Drawing.Point(333, 367);
            this.textBox_SamplesPerSec.Name = "textBox_SamplesPerSec";
            this.textBox_SamplesPerSec.ReadOnly = true;
            this.textBox_SamplesPerSec.Size = new System.Drawing.Size(61, 23);
            this.textBox_SamplesPerSec.TabIndex = 510;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label57);
            this.groupBox18.Controls.Add(this.label56);
            this.groupBox18.Controls.Add(this.textBox_VolRY);
            this.groupBox18.Controls.Add(this.label58);
            this.groupBox18.Controls.Add(this.label60);
            this.groupBox18.Controls.Add(this.textBox_AngleBR);
            this.groupBox18.Controls.Add(this.textBox_VolBR);
            this.groupBox18.Controls.Add(this.textBox_AngleYB);
            this.groupBox18.Controls.Add(this.textBox_VolYB);
            this.groupBox18.Controls.Add(this.textBox_AngleRY);
            this.groupBox18.Controls.Add(this.label59);
            this.groupBox18.Location = new System.Drawing.Point(435, 243);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(234, 86);
            this.groupBox18.TabIndex = 509;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Phase to Phase";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(4, 36);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(60, 17);
            this.label57.TabIndex = 445;
            this.label57.Text = "Voltage:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(2, 58);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(61, 17);
            this.label56.TabIndex = 444;
            this.label56.Text = "V Angle:";
            // 
            // textBox_VolRY
            // 
            this.textBox_VolRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolRY.Location = new System.Drawing.Point(65, 32);
            this.textBox_VolRY.Name = "textBox_VolRY";
            this.textBox_VolRY.ReadOnly = true;
            this.textBox_VolRY.Size = new System.Drawing.Size(50, 23);
            this.textBox_VolRY.TabIndex = 457;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Red;
            this.label58.Location = new System.Drawing.Point(72, 13);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 17);
            this.label58.TabIndex = 469;
            this.label58.Text = "R-Y";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Blue;
            this.label60.Location = new System.Drawing.Point(181, 13);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(35, 17);
            this.label60.TabIndex = 471;
            this.label60.Text = "B-R";
            // 
            // textBox_AngleBR
            // 
            this.textBox_AngleBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleBR.Location = new System.Drawing.Point(174, 56);
            this.textBox_AngleBR.Name = "textBox_AngleBR";
            this.textBox_AngleBR.ReadOnly = true;
            this.textBox_AngleBR.Size = new System.Drawing.Size(50, 23);
            this.textBox_AngleBR.TabIndex = 462;
            // 
            // textBox_VolBR
            // 
            this.textBox_VolBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolBR.Location = new System.Drawing.Point(174, 32);
            this.textBox_VolBR.Name = "textBox_VolBR";
            this.textBox_VolBR.ReadOnly = true;
            this.textBox_VolBR.Size = new System.Drawing.Size(50, 23);
            this.textBox_VolBR.TabIndex = 461;
            // 
            // textBox_AngleYB
            // 
            this.textBox_AngleYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleYB.Location = new System.Drawing.Point(120, 56);
            this.textBox_AngleYB.Name = "textBox_AngleYB";
            this.textBox_AngleYB.ReadOnly = true;
            this.textBox_AngleYB.Size = new System.Drawing.Size(50, 23);
            this.textBox_AngleYB.TabIndex = 460;
            // 
            // textBox_VolYB
            // 
            this.textBox_VolYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolYB.Location = new System.Drawing.Point(120, 32);
            this.textBox_VolYB.Name = "textBox_VolYB";
            this.textBox_VolYB.ReadOnly = true;
            this.textBox_VolYB.Size = new System.Drawing.Size(50, 23);
            this.textBox_VolYB.TabIndex = 459;
            // 
            // textBox_AngleRY
            // 
            this.textBox_AngleRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleRY.Location = new System.Drawing.Point(65, 56);
            this.textBox_AngleRY.Name = "textBox_AngleRY";
            this.textBox_AngleRY.ReadOnly = true;
            this.textBox_AngleRY.Size = new System.Drawing.Size(50, 23);
            this.textBox_AngleRY.TabIndex = 458;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Yellow;
            this.label59.Location = new System.Drawing.Point(127, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(34, 17);
            this.label59.TabIndex = 470;
            this.label59.Text = "Y-B";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.textBox_ErrorAppB);
            this.groupBox16.Controls.Add(this.textBox_ErrorAppY);
            this.groupBox16.Controls.Add(this.textBox_ErrorAppTotal);
            this.groupBox16.Controls.Add(this.textBox_ErrorAppR);
            this.groupBox16.Controls.Add(this.textBox_ErrorReactB);
            this.groupBox16.Controls.Add(this.textBox_ErrorReactY);
            this.groupBox16.Controls.Add(this.textBox_ErrorReactTotal);
            this.groupBox16.Controls.Add(this.textBox_ErrorReactR);
            this.groupBox16.Controls.Add(this.textBox_ErrorActB);
            this.groupBox16.Controls.Add(this.textBox_ErrorActY);
            this.groupBox16.Controls.Add(this.textBox_ErrorActTotal);
            this.groupBox16.Controls.Add(this.label86);
            this.groupBox16.Controls.Add(this.textBox_ErrorActR);
            this.groupBox16.Controls.Add(this.label85);
            this.groupBox16.Controls.Add(this.label77);
            this.groupBox16.Location = new System.Drawing.Point(18, 445);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(384, 97);
            this.groupBox16.TabIndex = 508;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Accuracy";
            // 
            // textBox_ErrorAppB
            // 
            this.textBox_ErrorAppB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorAppB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppB.Location = new System.Drawing.Point(241, 69);
            this.textBox_ErrorAppB.Name = "textBox_ErrorAppB";
            this.textBox_ErrorAppB.ReadOnly = true;
            this.textBox_ErrorAppB.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorAppB.TabIndex = 521;
            // 
            // textBox_ErrorAppY
            // 
            this.textBox_ErrorAppY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorAppY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppY.Location = new System.Drawing.Point(165, 69);
            this.textBox_ErrorAppY.Name = "textBox_ErrorAppY";
            this.textBox_ErrorAppY.ReadOnly = true;
            this.textBox_ErrorAppY.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorAppY.TabIndex = 520;
            // 
            // textBox_ErrorAppTotal
            // 
            this.textBox_ErrorAppTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppTotal.Location = new System.Drawing.Point(315, 69);
            this.textBox_ErrorAppTotal.Name = "textBox_ErrorAppTotal";
            this.textBox_ErrorAppTotal.ReadOnly = true;
            this.textBox_ErrorAppTotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorAppTotal.TabIndex = 519;
            // 
            // textBox_ErrorAppR
            // 
            this.textBox_ErrorAppR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorAppR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppR.Location = new System.Drawing.Point(89, 68);
            this.textBox_ErrorAppR.Name = "textBox_ErrorAppR";
            this.textBox_ErrorAppR.ReadOnly = true;
            this.textBox_ErrorAppR.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorAppR.TabIndex = 518;
            // 
            // textBox_ErrorReactB
            // 
            this.textBox_ErrorReactB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorReactB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactB.Location = new System.Drawing.Point(241, 43);
            this.textBox_ErrorReactB.Name = "textBox_ErrorReactB";
            this.textBox_ErrorReactB.ReadOnly = true;
            this.textBox_ErrorReactB.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorReactB.TabIndex = 517;
            // 
            // textBox_ErrorReactY
            // 
            this.textBox_ErrorReactY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorReactY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactY.Location = new System.Drawing.Point(165, 43);
            this.textBox_ErrorReactY.Name = "textBox_ErrorReactY";
            this.textBox_ErrorReactY.ReadOnly = true;
            this.textBox_ErrorReactY.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorReactY.TabIndex = 516;
            // 
            // textBox_ErrorReactTotal
            // 
            this.textBox_ErrorReactTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactTotal.Location = new System.Drawing.Point(315, 43);
            this.textBox_ErrorReactTotal.Name = "textBox_ErrorReactTotal";
            this.textBox_ErrorReactTotal.ReadOnly = true;
            this.textBox_ErrorReactTotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorReactTotal.TabIndex = 515;
            // 
            // textBox_ErrorReactR
            // 
            this.textBox_ErrorReactR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorReactR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactR.Location = new System.Drawing.Point(89, 42);
            this.textBox_ErrorReactR.Name = "textBox_ErrorReactR";
            this.textBox_ErrorReactR.ReadOnly = true;
            this.textBox_ErrorReactR.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorReactR.TabIndex = 514;
            // 
            // textBox_ErrorActB
            // 
            this.textBox_ErrorActB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorActB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActB.Location = new System.Drawing.Point(241, 17);
            this.textBox_ErrorActB.Name = "textBox_ErrorActB";
            this.textBox_ErrorActB.ReadOnly = true;
            this.textBox_ErrorActB.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorActB.TabIndex = 513;
            // 
            // textBox_ErrorActY
            // 
            this.textBox_ErrorActY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorActY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActY.Location = new System.Drawing.Point(165, 17);
            this.textBox_ErrorActY.Name = "textBox_ErrorActY";
            this.textBox_ErrorActY.ReadOnly = true;
            this.textBox_ErrorActY.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorActY.TabIndex = 512;
            // 
            // textBox_ErrorActTotal
            // 
            this.textBox_ErrorActTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActTotal.Location = new System.Drawing.Point(315, 17);
            this.textBox_ErrorActTotal.Name = "textBox_ErrorActTotal";
            this.textBox_ErrorActTotal.ReadOnly = true;
            this.textBox_ErrorActTotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorActTotal.TabIndex = 511;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(9, 71);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(70, 17);
            this.label86.TabIndex = 420;
            this.label86.Text = "Apparent:";
            // 
            // textBox_ErrorActR
            // 
            this.textBox_ErrorActR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorActR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActR.Location = new System.Drawing.Point(89, 16);
            this.textBox_ErrorActR.Name = "textBox_ErrorActR";
            this.textBox_ErrorActR.ReadOnly = true;
            this.textBox_ErrorActR.Size = new System.Drawing.Size(61, 23);
            this.textBox_ErrorActR.TabIndex = 510;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(12, 45);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(67, 17);
            this.label85.TabIndex = 417;
            this.label85.Text = "Reactive:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(30, 19);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(50, 17);
            this.label77.TabIndex = 416;
            this.label77.Text = "Active:";
            // 
            // button_ShowVectorDiagram
            // 
            this.button_ShowVectorDiagram.Location = new System.Drawing.Point(573, 204);
            this.button_ShowVectorDiagram.Name = "button_ShowVectorDiagram";
            this.button_ShowVectorDiagram.Size = new System.Drawing.Size(96, 31);
            this.button_ShowVectorDiagram.TabIndex = 507;
            this.button_ShowVectorDiagram.Text = "Vector Diagram";
            this.button_ShowVectorDiagram.UseVisualStyleBackColor = true;
            // 
            // textBox_AnglePFBph
            // 
            this.textBox_AnglePFBph.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_AnglePFBph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFBph.Location = new System.Drawing.Point(259, 164);
            this.textBox_AnglePFBph.Name = "textBox_AnglePFBph";
            this.textBox_AnglePFBph.ReadOnly = true;
            this.textBox_AnglePFBph.Size = new System.Drawing.Size(61, 23);
            this.textBox_AnglePFBph.TabIndex = 506;
            // 
            // textBox_AnglePFYph
            // 
            this.textBox_AnglePFYph.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_AnglePFYph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFYph.Location = new System.Drawing.Point(183, 164);
            this.textBox_AnglePFYph.Name = "textBox_AnglePFYph";
            this.textBox_AnglePFYph.ReadOnly = true;
            this.textBox_AnglePFYph.Size = new System.Drawing.Size(61, 23);
            this.textBox_AnglePFYph.TabIndex = 505;
            // 
            // textBox_AnglePFRph
            // 
            this.textBox_AnglePFRph.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_AnglePFRph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFRph.Location = new System.Drawing.Point(107, 163);
            this.textBox_AnglePFRph.Name = "textBox_AnglePFRph";
            this.textBox_AnglePFRph.ReadOnly = true;
            this.textBox_AnglePFRph.Size = new System.Drawing.Size(61, 23);
            this.textBox_AnglePFRph.TabIndex = 504;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(50, 168);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(48, 17);
            this.label73.TabIndex = 503;
            this.label73.Text = "Angle:";
            // 
            // textBox_SamplesB
            // 
            this.textBox_SamplesB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_SamplesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesB.Location = new System.Drawing.Point(259, 368);
            this.textBox_SamplesB.Name = "textBox_SamplesB";
            this.textBox_SamplesB.ReadOnly = true;
            this.textBox_SamplesB.Size = new System.Drawing.Size(61, 23);
            this.textBox_SamplesB.TabIndex = 502;
            // 
            // textBox_SamplesY
            // 
            this.textBox_SamplesY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_SamplesY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesY.Location = new System.Drawing.Point(183, 368);
            this.textBox_SamplesY.Name = "textBox_SamplesY";
            this.textBox_SamplesY.ReadOnly = true;
            this.textBox_SamplesY.Size = new System.Drawing.Size(61, 23);
            this.textBox_SamplesY.TabIndex = 501;
            // 
            // textBox_SamplesR
            // 
            this.textBox_SamplesR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_SamplesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesR.Location = new System.Drawing.Point(107, 367);
            this.textBox_SamplesR.Name = "textBox_SamplesR";
            this.textBox_SamplesR.ReadOnly = true;
            this.textBox_SamplesR.Size = new System.Drawing.Size(61, 23);
            this.textBox_SamplesR.TabIndex = 500;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(32, 371);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(66, 17);
            this.label50.TabIndex = 499;
            this.label50.Text = "Samples:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label75);
            this.groupBox17.Controls.Add(this.textBox_AngleNeuVector);
            this.groupBox17.Controls.Add(this.label74);
            this.groupBox17.Controls.Add(this.textBox_CurrNeuVector);
            this.groupBox17.Controls.Add(this.label72);
            this.groupBox17.Controls.Add(this.textBox_SamplesN);
            this.groupBox17.Controls.Add(this.label70);
            this.groupBox17.Controls.Add(this.label71);
            this.groupBox17.Controls.Add(this.textBox_CurrN);
            this.groupBox17.Controls.Add(this.textBox_CurrNdc);
            this.groupBox17.Location = new System.Drawing.Point(474, 16);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(201, 156);
            this.groupBox17.TabIndex = 498;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Neutral Related";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(33, 125);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(93, 17);
            this.label75.TabIndex = 422;
            this.label75.Text = "Vector Angle:";
            // 
            // textBox_AngleNeuVector
            // 
            this.textBox_AngleNeuVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleNeuVector.Location = new System.Drawing.Point(129, 124);
            this.textBox_AngleNeuVector.Name = "textBox_AngleNeuVector";
            this.textBox_AngleNeuVector.ReadOnly = true;
            this.textBox_AngleNeuVector.Size = new System.Drawing.Size(61, 23);
            this.textBox_AngleNeuVector.TabIndex = 421;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(22, 100);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(104, 17);
            this.label74.TabIndex = 420;
            this.label74.Text = "Vector Current:";
            // 
            // textBox_CurrNeuVector
            // 
            this.textBox_CurrNeuVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrNeuVector.Location = new System.Drawing.Point(129, 98);
            this.textBox_CurrNeuVector.Name = "textBox_CurrNeuVector";
            this.textBox_CurrNeuVector.ReadOnly = true;
            this.textBox_CurrNeuVector.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrNeuVector.TabIndex = 419;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(60, 75);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(66, 17);
            this.label72.TabIndex = 418;
            this.label72.Text = "Samples:";
            // 
            // textBox_SamplesN
            // 
            this.textBox_SamplesN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesN.Location = new System.Drawing.Point(129, 72);
            this.textBox_SamplesN.Name = "textBox_SamplesN";
            this.textBox_SamplesN.ReadOnly = true;
            this.textBox_SamplesN.Size = new System.Drawing.Size(61, 23);
            this.textBox_SamplesN.TabIndex = 417;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(34, 50);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(92, 17);
            this.label70.TabIndex = 416;
            this.label70.Text = "Current (DC):";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(67, 25);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(59, 17);
            this.label71.TabIndex = 415;
            this.label71.Text = "Current:";
            // 
            // textBox_CurrN
            // 
            this.textBox_CurrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrN.Location = new System.Drawing.Point(129, 20);
            this.textBox_CurrN.Name = "textBox_CurrN";
            this.textBox_CurrN.ReadOnly = true;
            this.textBox_CurrN.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrN.TabIndex = 365;
            // 
            // textBox_CurrNdc
            // 
            this.textBox_CurrNdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrNdc.Location = new System.Drawing.Point(129, 47);
            this.textBox_CurrNdc.Name = "textBox_CurrNdc";
            this.textBox_CurrNdc.ReadOnly = true;
            this.textBox_CurrNdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrNdc.TabIndex = 366;
            // 
            // textBox_CalAngleReactB
            // 
            this.textBox_CalAngleReactB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CalAngleReactB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleReactB.Location = new System.Drawing.Point(259, 343);
            this.textBox_CalAngleReactB.Name = "textBox_CalAngleReactB";
            this.textBox_CalAngleReactB.ReadOnly = true;
            this.textBox_CalAngleReactB.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleReactB.TabIndex = 497;
            // 
            // textBox_CalAngleReactY
            // 
            this.textBox_CalAngleReactY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CalAngleReactY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleReactY.Location = new System.Drawing.Point(183, 343);
            this.textBox_CalAngleReactY.Name = "textBox_CalAngleReactY";
            this.textBox_CalAngleReactY.ReadOnly = true;
            this.textBox_CalAngleReactY.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleReactY.TabIndex = 496;
            // 
            // textBox_CalAngleReactR
            // 
            this.textBox_CalAngleReactR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CalAngleReactR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleReactR.Location = new System.Drawing.Point(107, 342);
            this.textBox_CalAngleReactR.Name = "textBox_CalAngleReactR";
            this.textBox_CalAngleReactR.ReadOnly = true;
            this.textBox_CalAngleReactR.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleReactR.TabIndex = 495;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(30, 346);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(68, 17);
            this.label61.TabIndex = 494;
            this.label61.Text = "Angle(R):";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(475, 178);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(43, 17);
            this.label55.TabIndex = 441;
            this.label55.Text = "Time:";
            // 
            // textBox_Time
            // 
            this.textBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Time.Location = new System.Drawing.Point(531, 175);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.ReadOnly = true;
            this.textBox_Time.Size = new System.Drawing.Size(133, 23);
            this.textBox_Time.TabIndex = 442;
            // 
            // textBox_QuadB
            // 
            this.textBox_QuadB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_QuadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadB.Location = new System.Drawing.Point(259, 293);
            this.textBox_QuadB.Name = "textBox_QuadB";
            this.textBox_QuadB.ReadOnly = true;
            this.textBox_QuadB.Size = new System.Drawing.Size(61, 23);
            this.textBox_QuadB.TabIndex = 493;
            // 
            // textBox_FreqB
            // 
            this.textBox_FreqB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_FreqB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqB.Location = new System.Drawing.Point(259, 267);
            this.textBox_FreqB.Name = "textBox_FreqB";
            this.textBox_FreqB.ReadOnly = true;
            this.textBox_FreqB.Size = new System.Drawing.Size(61, 23);
            this.textBox_FreqB.TabIndex = 492;
            // 
            // textBox_VAB
            // 
            this.textBox_VAB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAB.Location = new System.Drawing.Point(259, 241);
            this.textBox_VAB.Name = "textBox_VAB";
            this.textBox_VAB.ReadOnly = true;
            this.textBox_VAB.Size = new System.Drawing.Size(61, 23);
            this.textBox_VAB.TabIndex = 491;
            // 
            // textBox_VARB
            // 
            this.textBox_VARB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARB.Location = new System.Drawing.Point(259, 215);
            this.textBox_VARB.Name = "textBox_VARB";
            this.textBox_VARB.ReadOnly = true;
            this.textBox_VARB.Size = new System.Drawing.Size(61, 23);
            this.textBox_VARB.TabIndex = 490;
            // 
            // textBox_WattB
            // 
            this.textBox_WattB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_WattB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattB.Location = new System.Drawing.Point(259, 189);
            this.textBox_WattB.Name = "textBox_WattB";
            this.textBox_WattB.ReadOnly = true;
            this.textBox_WattB.Size = new System.Drawing.Size(61, 23);
            this.textBox_WattB.TabIndex = 489;
            // 
            // textBox_CalAngleActB
            // 
            this.textBox_CalAngleActB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CalAngleActB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleActB.Location = new System.Drawing.Point(259, 318);
            this.textBox_CalAngleActB.Name = "textBox_CalAngleActB";
            this.textBox_CalAngleActB.ReadOnly = true;
            this.textBox_CalAngleActB.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleActB.TabIndex = 488;
            // 
            // textBox_PFB
            // 
            this.textBox_PFB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_PFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFB.Location = new System.Drawing.Point(259, 138);
            this.textBox_PFB.Name = "textBox_PFB";
            this.textBox_PFB.ReadOnly = true;
            this.textBox_PFB.Size = new System.Drawing.Size(61, 23);
            this.textBox_PFB.TabIndex = 487;
            // 
            // textBox_CurrBdc
            // 
            this.textBox_CurrBdc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CurrBdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrBdc.Location = new System.Drawing.Point(259, 112);
            this.textBox_CurrBdc.Name = "textBox_CurrBdc";
            this.textBox_CurrBdc.ReadOnly = true;
            this.textBox_CurrBdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrBdc.TabIndex = 486;
            // 
            // textBox_CurrB
            // 
            this.textBox_CurrB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CurrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrB.Location = new System.Drawing.Point(259, 86);
            this.textBox_CurrB.Name = "textBox_CurrB";
            this.textBox_CurrB.ReadOnly = true;
            this.textBox_CurrB.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrB.TabIndex = 485;
            // 
            // textBox_VolBdc
            // 
            this.textBox_VolBdc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VolBdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolBdc.Location = new System.Drawing.Point(259, 60);
            this.textBox_VolBdc.Name = "textBox_VolBdc";
            this.textBox_VolBdc.ReadOnly = true;
            this.textBox_VolBdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolBdc.TabIndex = 484;
            // 
            // textBox_VolB
            // 
            this.textBox_VolB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolB.Location = new System.Drawing.Point(259, 34);
            this.textBox_VolB.Name = "textBox_VolB";
            this.textBox_VolB.ReadOnly = true;
            this.textBox_VolB.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolB.TabIndex = 483;
            // 
            // textBox_QuadY
            // 
            this.textBox_QuadY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_QuadY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadY.Location = new System.Drawing.Point(183, 293);
            this.textBox_QuadY.Name = "textBox_QuadY";
            this.textBox_QuadY.ReadOnly = true;
            this.textBox_QuadY.Size = new System.Drawing.Size(61, 23);
            this.textBox_QuadY.TabIndex = 482;
            // 
            // textBox_FreqY
            // 
            this.textBox_FreqY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_FreqY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqY.Location = new System.Drawing.Point(183, 267);
            this.textBox_FreqY.Name = "textBox_FreqY";
            this.textBox_FreqY.ReadOnly = true;
            this.textBox_FreqY.Size = new System.Drawing.Size(61, 23);
            this.textBox_FreqY.TabIndex = 481;
            // 
            // textBox_VAY
            // 
            this.textBox_VAY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAY.Location = new System.Drawing.Point(183, 241);
            this.textBox_VAY.Name = "textBox_VAY";
            this.textBox_VAY.ReadOnly = true;
            this.textBox_VAY.Size = new System.Drawing.Size(61, 23);
            this.textBox_VAY.TabIndex = 480;
            // 
            // textBox_VARY
            // 
            this.textBox_VARY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARY.Location = new System.Drawing.Point(183, 215);
            this.textBox_VARY.Name = "textBox_VARY";
            this.textBox_VARY.ReadOnly = true;
            this.textBox_VARY.Size = new System.Drawing.Size(61, 23);
            this.textBox_VARY.TabIndex = 479;
            // 
            // textBox_WattY
            // 
            this.textBox_WattY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_WattY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattY.Location = new System.Drawing.Point(183, 189);
            this.textBox_WattY.Name = "textBox_WattY";
            this.textBox_WattY.ReadOnly = true;
            this.textBox_WattY.Size = new System.Drawing.Size(61, 23);
            this.textBox_WattY.TabIndex = 478;
            // 
            // textBox_CalAngleActY
            // 
            this.textBox_CalAngleActY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CalAngleActY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleActY.Location = new System.Drawing.Point(183, 318);
            this.textBox_CalAngleActY.Name = "textBox_CalAngleActY";
            this.textBox_CalAngleActY.ReadOnly = true;
            this.textBox_CalAngleActY.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleActY.TabIndex = 477;
            // 
            // textBox_PFY
            // 
            this.textBox_PFY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_PFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFY.Location = new System.Drawing.Point(183, 138);
            this.textBox_PFY.Name = "textBox_PFY";
            this.textBox_PFY.ReadOnly = true;
            this.textBox_PFY.Size = new System.Drawing.Size(61, 23);
            this.textBox_PFY.TabIndex = 476;
            // 
            // textBox_CurrYdc
            // 
            this.textBox_CurrYdc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CurrYdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrYdc.Location = new System.Drawing.Point(183, 112);
            this.textBox_CurrYdc.Name = "textBox_CurrYdc";
            this.textBox_CurrYdc.ReadOnly = true;
            this.textBox_CurrYdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrYdc.TabIndex = 475;
            // 
            // textBox_CurrY
            // 
            this.textBox_CurrY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CurrY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrY.Location = new System.Drawing.Point(183, 86);
            this.textBox_CurrY.Name = "textBox_CurrY";
            this.textBox_CurrY.ReadOnly = true;
            this.textBox_CurrY.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrY.TabIndex = 474;
            // 
            // textBox_VolYdc
            // 
            this.textBox_VolYdc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VolYdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolYdc.Location = new System.Drawing.Point(183, 60);
            this.textBox_VolYdc.Name = "textBox_VolYdc";
            this.textBox_VolYdc.ReadOnly = true;
            this.textBox_VolYdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolYdc.TabIndex = 473;
            // 
            // textBox_VolY
            // 
            this.textBox_VolY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VolY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolY.Location = new System.Drawing.Point(183, 34);
            this.textBox_VolY.Name = "textBox_VolY";
            this.textBox_VolY.ReadOnly = true;
            this.textBox_VolY.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolY.TabIndex = 472;
            // 
            // textBox_QuadNet
            // 
            this.textBox_QuadNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadNet.Location = new System.Drawing.Point(333, 293);
            this.textBox_QuadNet.Name = "textBox_QuadNet";
            this.textBox_QuadNet.ReadOnly = true;
            this.textBox_QuadNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_QuadNet.TabIndex = 468;
            // 
            // textBox_FreqNet
            // 
            this.textBox_FreqNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqNet.Location = new System.Drawing.Point(333, 267);
            this.textBox_FreqNet.Name = "textBox_FreqNet";
            this.textBox_FreqNet.ReadOnly = true;
            this.textBox_FreqNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_FreqNet.TabIndex = 467;
            // 
            // textBox_VANet
            // 
            this.textBox_VANet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VANet.Location = new System.Drawing.Point(333, 241);
            this.textBox_VANet.Name = "textBox_VANet";
            this.textBox_VANet.ReadOnly = true;
            this.textBox_VANet.Size = new System.Drawing.Size(61, 23);
            this.textBox_VANet.TabIndex = 466;
            // 
            // textBox_VARNet
            // 
            this.textBox_VARNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARNet.Location = new System.Drawing.Point(333, 215);
            this.textBox_VARNet.Name = "textBox_VARNet";
            this.textBox_VARNet.ReadOnly = true;
            this.textBox_VARNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_VARNet.TabIndex = 465;
            // 
            // textBox_WattNet
            // 
            this.textBox_WattNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattNet.Location = new System.Drawing.Point(333, 189);
            this.textBox_WattNet.Name = "textBox_WattNet";
            this.textBox_WattNet.ReadOnly = true;
            this.textBox_WattNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_WattNet.TabIndex = 464;
            // 
            // textBox_PFNet
            // 
            this.textBox_PFNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFNet.Location = new System.Drawing.Point(334, 138);
            this.textBox_PFNet.Name = "textBox_PFNet";
            this.textBox_PFNet.ReadOnly = true;
            this.textBox_PFNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_PFNet.TabIndex = 463;
            // 
            // textBox_QuadR
            // 
            this.textBox_QuadR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_QuadR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadR.Location = new System.Drawing.Point(107, 292);
            this.textBox_QuadR.Name = "textBox_QuadR";
            this.textBox_QuadR.ReadOnly = true;
            this.textBox_QuadR.Size = new System.Drawing.Size(61, 23);
            this.textBox_QuadR.TabIndex = 456;
            // 
            // textBox_FreqR
            // 
            this.textBox_FreqR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_FreqR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqR.Location = new System.Drawing.Point(107, 266);
            this.textBox_FreqR.Name = "textBox_FreqR";
            this.textBox_FreqR.ReadOnly = true;
            this.textBox_FreqR.Size = new System.Drawing.Size(61, 23);
            this.textBox_FreqR.TabIndex = 455;
            // 
            // textBox_VAR
            // 
            this.textBox_VAR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAR.Location = new System.Drawing.Point(107, 240);
            this.textBox_VAR.Name = "textBox_VAR";
            this.textBox_VAR.ReadOnly = true;
            this.textBox_VAR.Size = new System.Drawing.Size(61, 23);
            this.textBox_VAR.TabIndex = 454;
            // 
            // textBox_VARR
            // 
            this.textBox_VARR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARR.Location = new System.Drawing.Point(107, 214);
            this.textBox_VARR.Name = "textBox_VARR";
            this.textBox_VARR.ReadOnly = true;
            this.textBox_VARR.Size = new System.Drawing.Size(61, 23);
            this.textBox_VARR.TabIndex = 453;
            // 
            // textBox_WattR
            // 
            this.textBox_WattR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_WattR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattR.Location = new System.Drawing.Point(107, 188);
            this.textBox_WattR.Name = "textBox_WattR";
            this.textBox_WattR.ReadOnly = true;
            this.textBox_WattR.Size = new System.Drawing.Size(61, 23);
            this.textBox_WattR.TabIndex = 452;
            // 
            // textBox_CalAngleActR
            // 
            this.textBox_CalAngleActR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CalAngleActR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CalAngleActR.Location = new System.Drawing.Point(107, 317);
            this.textBox_CalAngleActR.Name = "textBox_CalAngleActR";
            this.textBox_CalAngleActR.ReadOnly = true;
            this.textBox_CalAngleActR.Size = new System.Drawing.Size(61, 23);
            this.textBox_CalAngleActR.TabIndex = 451;
            // 
            // textBox_PFR
            // 
            this.textBox_PFR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_PFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFR.Location = new System.Drawing.Point(107, 137);
            this.textBox_PFR.Name = "textBox_PFR";
            this.textBox_PFR.ReadOnly = true;
            this.textBox_PFR.Size = new System.Drawing.Size(61, 23);
            this.textBox_PFR.TabIndex = 450;
            // 
            // textBox_CurrRdc
            // 
            this.textBox_CurrRdc.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CurrRdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrRdc.Location = new System.Drawing.Point(107, 111);
            this.textBox_CurrRdc.Name = "textBox_CurrRdc";
            this.textBox_CurrRdc.ReadOnly = true;
            this.textBox_CurrRdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrRdc.TabIndex = 449;
            // 
            // textBox_CurrR
            // 
            this.textBox_CurrR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CurrR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrR.Location = new System.Drawing.Point(107, 85);
            this.textBox_CurrR.Name = "textBox_CurrR";
            this.textBox_CurrR.ReadOnly = true;
            this.textBox_CurrR.Size = new System.Drawing.Size(61, 23);
            this.textBox_CurrR.TabIndex = 448;
            // 
            // textBox_VolRdc
            // 
            this.textBox_VolRdc.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VolRdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolRdc.Location = new System.Drawing.Point(107, 59);
            this.textBox_VolRdc.Name = "textBox_VolRdc";
            this.textBox_VolRdc.ReadOnly = true;
            this.textBox_VolRdc.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolRdc.TabIndex = 447;
            // 
            // textBox_VolR
            // 
            this.textBox_VolR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VolR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolR.Location = new System.Drawing.Point(107, 33);
            this.textBox_VolR.Name = "textBox_VolR";
            this.textBox_VolR.ReadOnly = true;
            this.textBox_VolR.Size = new System.Drawing.Size(61, 23);
            this.textBox_VolR.TabIndex = 446;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(26, 295);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(72, 17);
            this.label44.TabIndex = 443;
            this.label44.Text = "Quadrant:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(26, 270);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(72, 17);
            this.label54.TabIndex = 440;
            this.label54.Text = "Freq (Hz):";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(16, 114);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(81, 17);
            this.label53.TabIndex = 439;
            this.label53.Text = "Curr Offset:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(34, 61);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(63, 17);
            this.label52.TabIndex = 438;
            this.label52.Text = "V Offset:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(327, 14);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(75, 17);
            this.label51.TabIndex = 437;
            this.label51.Text = "Net/Total";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Red;
            this.label47.Location = new System.Drawing.Point(103, 14);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(69, 17);
            this.label47.TabIndex = 434;
            this.label47.Text = "R Phase";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Yellow;
            this.label48.Location = new System.Drawing.Point(180, 14);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(68, 17);
            this.label48.TabIndex = 435;
            this.label48.Text = "Y Phase";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Blue;
            this.label49.Location = new System.Drawing.Point(252, 14);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(68, 17);
            this.label49.TabIndex = 436;
            this.label49.Text = "B Phase";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(38, 34);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(60, 17);
            this.label45.TabIndex = 427;
            this.label45.Text = "Voltage:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(39, 88);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 17);
            this.label46.TabIndex = 428;
            this.label46.Text = "Current:";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(69, 140);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(29, 17);
            this.label76.TabIndex = 429;
            this.label76.Text = "PF:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(20, 192);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(78, 17);
            this.label78.TabIndex = 430;
            this.label78.Text = "Power (W):";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(5, 218);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(93, 17);
            this.label79.TabIndex = 431;
            this.label79.Text = "Power (VAR):";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(15, 243);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(83, 17);
            this.label80.TabIndex = 432;
            this.label80.Text = "Power (VA):";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(31, 321);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(67, 17);
            this.label81.TabIndex = 433;
            this.label81.Text = "Angle(A):";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.textBox_inputAngleYB);
            this.groupBox22.Controls.Add(this.label92);
            this.groupBox22.Controls.Add(this.label83);
            this.groupBox22.Controls.Add(this.textBox_inputNeutralVectorAngle);
            this.groupBox22.Controls.Add(this.label91);
            this.groupBox22.Controls.Add(this.textBox_inputNeutralVectorCurrent);
            this.groupBox22.Controls.Add(this.button_inputUpdate);
            this.groupBox22.Controls.Add(this.checkBox_CalculateAccuracy);
            this.groupBox22.Controls.Add(this.textBox_inputFreq);
            this.groupBox22.Controls.Add(this.label103);
            this.groupBox22.Controls.Add(this.textBox_inputAngleBR);
            this.groupBox22.Controls.Add(this.textBox_AvgAccuracySamples);
            this.groupBox22.Controls.Add(this.textBox_inputAngleRY);
            this.groupBox22.Controls.Add(this.label101);
            this.groupBox22.Controls.Add(this.label100);
            this.groupBox22.Controls.Add(this.label84);
            this.groupBox22.Controls.Add(this.textBox_inputPFNet);
            this.groupBox22.Controls.Add(this.label99);
            this.groupBox22.Controls.Add(this.textBox_inputVANet);
            this.groupBox22.Controls.Add(this.textBox_inputVARNet);
            this.groupBox22.Controls.Add(this.textBox_inputWattNet);
            this.groupBox22.Controls.Add(this.label98);
            this.groupBox22.Controls.Add(this.textBox_inputVATotal);
            this.groupBox22.Controls.Add(this.textBox_inputVARTotal);
            this.groupBox22.Controls.Add(this.textBox_inputWattTotal);
            this.groupBox22.Controls.Add(this.label97);
            this.groupBox22.Controls.Add(this.textBox_inputVAB);
            this.groupBox22.Controls.Add(this.label96);
            this.groupBox22.Controls.Add(this.textBox_inputVARB);
            this.groupBox22.Controls.Add(this.label95);
            this.groupBox22.Controls.Add(this.textBox_inputWattB);
            this.groupBox22.Controls.Add(this.label94);
            this.groupBox22.Controls.Add(this.textBox_inputVAY);
            this.groupBox22.Controls.Add(this.textBox_inputVARY);
            this.groupBox22.Controls.Add(this.textBox_inputWattY);
            this.groupBox22.Controls.Add(this.textBox_inputVAR);
            this.groupBox22.Controls.Add(this.textBox_inputVARR);
            this.groupBox22.Controls.Add(this.textBox_inputWattR);
            this.groupBox22.Controls.Add(this.textBox_inputAngleB);
            this.groupBox22.Controls.Add(this.textBox_inputAngleY);
            this.groupBox22.Controls.Add(this.textBox_inputAngleR);
            this.groupBox22.Controls.Add(this.label82);
            this.groupBox22.Controls.Add(this.textBox_inputPFB);
            this.groupBox22.Controls.Add(this.textBox_inputCurrB);
            this.groupBox22.Controls.Add(this.textBox_inputVolB);
            this.groupBox22.Controls.Add(this.textBox_inputPFY);
            this.groupBox22.Controls.Add(this.textBox_inputCurrY);
            this.groupBox22.Controls.Add(this.textBox_inputVolY);
            this.groupBox22.Controls.Add(this.textBox_inputPFR);
            this.groupBox22.Controls.Add(this.textBox_inputCurrR);
            this.groupBox22.Controls.Add(this.textBox_inputVolR);
            this.groupBox22.Controls.Add(this.label87);
            this.groupBox22.Controls.Add(this.label88);
            this.groupBox22.Controls.Add(this.label89);
            this.groupBox22.Controls.Add(this.label90);
            this.groupBox22.Controls.Add(this.label102);
            this.groupBox22.Location = new System.Drawing.Point(6, 6);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(479, 308);
            this.groupBox22.TabIndex = 402;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Input Data";
            // 
            // textBox_inputAngleYB
            // 
            this.textBox_inputAngleYB.BackColor = System.Drawing.Color.White;
            this.textBox_inputAngleYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleYB.Location = new System.Drawing.Point(93, 234);
            this.textBox_inputAngleYB.Name = "textBox_inputAngleYB";
            this.textBox_inputAngleYB.Size = new System.Drawing.Size(42, 23);
            this.textBox_inputAngleYB.TabIndex = 531;
            this.textBox_inputAngleYB.Text = "-120";
            this.textBox_inputAngleYB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(15, 237);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(75, 17);
            this.label92.TabIndex = 530;
            this.label92.Text = "Angle Y-B:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(137, 272);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(123, 17);
            this.label83.TabIndex = 529;
            this.label83.Text = "Neu Vector Angle:";
            // 
            // textBox_inputNeutralVectorAngle
            // 
            this.textBox_inputNeutralVectorAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputNeutralVectorAngle.Location = new System.Drawing.Point(261, 270);
            this.textBox_inputNeutralVectorAngle.Name = "textBox_inputNeutralVectorAngle";
            this.textBox_inputNeutralVectorAngle.ReadOnly = true;
            this.textBox_inputNeutralVectorAngle.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputNeutralVectorAngle.TabIndex = 528;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(145, 247);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(114, 17);
            this.label91.TabIndex = 527;
            this.label91.Text = "Neu Vector Curr:";
            // 
            // textBox_inputNeutralVectorCurrent
            // 
            this.textBox_inputNeutralVectorCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputNeutralVectorCurrent.Location = new System.Drawing.Point(261, 246);
            this.textBox_inputNeutralVectorCurrent.Name = "textBox_inputNeutralVectorCurrent";
            this.textBox_inputNeutralVectorCurrent.ReadOnly = true;
            this.textBox_inputNeutralVectorCurrent.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputNeutralVectorCurrent.TabIndex = 526;
            // 
            // button_inputUpdate
            // 
            this.button_inputUpdate.Location = new System.Drawing.Point(387, 270);
            this.button_inputUpdate.Name = "button_inputUpdate";
            this.button_inputUpdate.Size = new System.Drawing.Size(86, 29);
            this.button_inputUpdate.TabIndex = 525;
            this.button_inputUpdate.Text = "Update";
            this.button_inputUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBox_CalculateAccuracy
            // 
            this.checkBox_CalculateAccuracy.AutoSize = true;
            this.checkBox_CalculateAccuracy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_CalculateAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CalculateAccuracy.Location = new System.Drawing.Point(354, 251);
            this.checkBox_CalculateAccuracy.Name = "checkBox_CalculateAccuracy";
            this.checkBox_CalculateAccuracy.Size = new System.Drawing.Size(109, 21);
            this.checkBox_CalculateAccuracy.TabIndex = 524;
            this.checkBox_CalculateAccuracy.Text = "Cal Accuracy";
            this.checkBox_CalculateAccuracy.UseVisualStyleBackColor = true;
            // 
            // textBox_inputFreq
            // 
            this.textBox_inputFreq.BackColor = System.Drawing.Color.White;
            this.textBox_inputFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputFreq.Location = new System.Drawing.Point(93, 281);
            this.textBox_inputFreq.Name = "textBox_inputFreq";
            this.textBox_inputFreq.Size = new System.Drawing.Size(42, 23);
            this.textBox_inputFreq.TabIndex = 523;
            this.textBox_inputFreq.Text = "50";
            this.textBox_inputFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(13, 284);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(79, 17);
            this.label103.TabIndex = 522;
            this.label103.Text = "Frequency:";
            // 
            // textBox_inputAngleBR
            // 
            this.textBox_inputAngleBR.BackColor = System.Drawing.Color.White;
            this.textBox_inputAngleBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleBR.Location = new System.Drawing.Point(93, 256);
            this.textBox_inputAngleBR.Name = "textBox_inputAngleBR";
            this.textBox_inputAngleBR.Size = new System.Drawing.Size(42, 23);
            this.textBox_inputAngleBR.TabIndex = 521;
            this.textBox_inputAngleBR.Text = "-120";
            this.textBox_inputAngleBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_AvgAccuracySamples
            // 
            this.textBox_AvgAccuracySamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AvgAccuracySamples.Location = new System.Drawing.Point(436, 222);
            this.textBox_AvgAccuracySamples.Name = "textBox_AvgAccuracySamples";
            this.textBox_AvgAccuracySamples.Size = new System.Drawing.Size(30, 23);
            this.textBox_AvgAccuracySamples.TabIndex = 432;
            this.textBox_AvgAccuracySamples.Text = "5";
            this.textBox_AvgAccuracySamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputAngleRY
            // 
            this.textBox_inputAngleRY.BackColor = System.Drawing.Color.White;
            this.textBox_inputAngleRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleRY.Location = new System.Drawing.Point(93, 212);
            this.textBox_inputAngleRY.Name = "textBox_inputAngleRY";
            this.textBox_inputAngleRY.Size = new System.Drawing.Size(42, 23);
            this.textBox_inputAngleRY.TabIndex = 520;
            this.textBox_inputAngleRY.Text = "120";
            this.textBox_inputAngleRY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(15, 259);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(76, 17);
            this.label101.TabIndex = 519;
            this.label101.Text = "Angle B-R:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(15, 216);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(76, 17);
            this.label100.TabIndex = 518;
            this.label100.Text = "Angle R-Y:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(336, 225);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(94, 17);
            this.label84.TabIndex = 431;
            this.label84.Text = "Avg Samples:";
            // 
            // textBox_inputPFNet
            // 
            this.textBox_inputPFNet.BackColor = System.Drawing.Color.White;
            this.textBox_inputPFNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputPFNet.Location = new System.Drawing.Point(402, 183);
            this.textBox_inputPFNet.Name = "textBox_inputPFNet";
            this.textBox_inputPFNet.ReadOnly = true;
            this.textBox_inputPFNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputPFNet.TabIndex = 502;
            this.textBox_inputPFNet.Text = "0";
            this.textBox_inputPFNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(35, 186);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(29, 17);
            this.label99.TabIndex = 501;
            this.label99.Text = "PF:";
            // 
            // textBox_inputVANet
            // 
            this.textBox_inputVANet.BackColor = System.Drawing.Color.White;
            this.textBox_inputVANet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVANet.Location = new System.Drawing.Point(402, 158);
            this.textBox_inputVANet.Name = "textBox_inputVANet";
            this.textBox_inputVANet.ReadOnly = true;
            this.textBox_inputVANet.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVANet.TabIndex = 500;
            this.textBox_inputVANet.Text = "0";
            this.textBox_inputVANet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVARNet
            // 
            this.textBox_inputVARNet.BackColor = System.Drawing.Color.White;
            this.textBox_inputVARNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVARNet.Location = new System.Drawing.Point(402, 133);
            this.textBox_inputVARNet.Name = "textBox_inputVARNet";
            this.textBox_inputVARNet.ReadOnly = true;
            this.textBox_inputVARNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVARNet.TabIndex = 499;
            this.textBox_inputVARNet.Text = "0";
            this.textBox_inputVARNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputWattNet
            // 
            this.textBox_inputWattNet.BackColor = System.Drawing.Color.White;
            this.textBox_inputWattNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputWattNet.Location = new System.Drawing.Point(403, 107);
            this.textBox_inputWattNet.Name = "textBox_inputWattNet";
            this.textBox_inputWattNet.ReadOnly = true;
            this.textBox_inputWattNet.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputWattNet.TabIndex = 498;
            this.textBox_inputWattNet.Text = "0";
            this.textBox_inputWattNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(411, 17);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(33, 17);
            this.label98.TabIndex = 497;
            this.label98.Text = "Net";
            // 
            // textBox_inputVATotal
            // 
            this.textBox_inputVATotal.BackColor = System.Drawing.Color.White;
            this.textBox_inputVATotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVATotal.Location = new System.Drawing.Point(323, 158);
            this.textBox_inputVATotal.Name = "textBox_inputVATotal";
            this.textBox_inputVATotal.ReadOnly = true;
            this.textBox_inputVATotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVATotal.TabIndex = 496;
            this.textBox_inputVATotal.Text = "0";
            this.textBox_inputVATotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVARTotal
            // 
            this.textBox_inputVARTotal.BackColor = System.Drawing.Color.White;
            this.textBox_inputVARTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVARTotal.Location = new System.Drawing.Point(323, 133);
            this.textBox_inputVARTotal.Name = "textBox_inputVARTotal";
            this.textBox_inputVARTotal.ReadOnly = true;
            this.textBox_inputVARTotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVARTotal.TabIndex = 495;
            this.textBox_inputVARTotal.Text = "0";
            this.textBox_inputVARTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputWattTotal
            // 
            this.textBox_inputWattTotal.BackColor = System.Drawing.Color.White;
            this.textBox_inputWattTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputWattTotal.Location = new System.Drawing.Point(324, 107);
            this.textBox_inputWattTotal.Name = "textBox_inputWattTotal";
            this.textBox_inputWattTotal.ReadOnly = true;
            this.textBox_inputWattTotal.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputWattTotal.TabIndex = 494;
            this.textBox_inputWattTotal.Text = "0";
            this.textBox_inputWattTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.Black;
            this.label97.Location = new System.Drawing.Point(327, 16);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(45, 17);
            this.label97.TabIndex = 493;
            this.label97.Text = "Total";
            // 
            // textBox_inputVAB
            // 
            this.textBox_inputVAB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputVAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVAB.Location = new System.Drawing.Point(244, 157);
            this.textBox_inputVAB.Name = "textBox_inputVAB";
            this.textBox_inputVAB.ReadOnly = true;
            this.textBox_inputVAB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVAB.TabIndex = 492;
            this.textBox_inputVAB.Text = "0";
            this.textBox_inputVAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(26, 132);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(40, 17);
            this.label96.TabIndex = 489;
            this.label96.Text = "VAR:";
            // 
            // textBox_inputVARB
            // 
            this.textBox_inputVARB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputVARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVARB.Location = new System.Drawing.Point(244, 132);
            this.textBox_inputVARB.Name = "textBox_inputVARB";
            this.textBox_inputVARB.ReadOnly = true;
            this.textBox_inputVARB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVARB.TabIndex = 491;
            this.textBox_inputVARB.Text = "0";
            this.textBox_inputVARB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(36, 158);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(30, 17);
            this.label95.TabIndex = 487;
            this.label95.Text = "VA:";
            // 
            // textBox_inputWattB
            // 
            this.textBox_inputWattB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputWattB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputWattB.Location = new System.Drawing.Point(244, 107);
            this.textBox_inputWattB.Name = "textBox_inputWattB";
            this.textBox_inputWattB.ReadOnly = true;
            this.textBox_inputWattB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputWattB.TabIndex = 490;
            this.textBox_inputWattB.Text = "0";
            this.textBox_inputWattB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(27, 109);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(41, 17);
            this.label94.TabIndex = 485;
            this.label94.Text = "Watt:";
            // 
            // textBox_inputVAY
            // 
            this.textBox_inputVAY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputVAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVAY.Location = new System.Drawing.Point(160, 157);
            this.textBox_inputVAY.Name = "textBox_inputVAY";
            this.textBox_inputVAY.ReadOnly = true;
            this.textBox_inputVAY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVAY.TabIndex = 488;
            this.textBox_inputVAY.Text = "0";
            this.textBox_inputVAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVARY
            // 
            this.textBox_inputVARY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputVARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVARY.Location = new System.Drawing.Point(160, 132);
            this.textBox_inputVARY.Name = "textBox_inputVARY";
            this.textBox_inputVARY.ReadOnly = true;
            this.textBox_inputVARY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVARY.TabIndex = 486;
            this.textBox_inputVARY.Text = "0";
            this.textBox_inputVARY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputWattY
            // 
            this.textBox_inputWattY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputWattY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputWattY.Location = new System.Drawing.Point(160, 107);
            this.textBox_inputWattY.Name = "textBox_inputWattY";
            this.textBox_inputWattY.ReadOnly = true;
            this.textBox_inputWattY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputWattY.TabIndex = 484;
            this.textBox_inputWattY.Text = "0";
            this.textBox_inputWattY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVAR
            // 
            this.textBox_inputVAR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVAR.Location = new System.Drawing.Point(72, 156);
            this.textBox_inputVAR.Name = "textBox_inputVAR";
            this.textBox_inputVAR.ReadOnly = true;
            this.textBox_inputVAR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVAR.TabIndex = 482;
            this.textBox_inputVAR.Text = "0";
            this.textBox_inputVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVARR
            // 
            this.textBox_inputVARR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputVARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVARR.Location = new System.Drawing.Point(72, 131);
            this.textBox_inputVARR.Name = "textBox_inputVARR";
            this.textBox_inputVARR.ReadOnly = true;
            this.textBox_inputVARR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVARR.TabIndex = 481;
            this.textBox_inputVARR.Text = "0";
            this.textBox_inputVARR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputWattR
            // 
            this.textBox_inputWattR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputWattR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputWattR.Location = new System.Drawing.Point(72, 107);
            this.textBox_inputWattR.Name = "textBox_inputWattR";
            this.textBox_inputWattR.ReadOnly = true;
            this.textBox_inputWattR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputWattR.TabIndex = 478;
            this.textBox_inputWattR.Text = "0";
            this.textBox_inputWattR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputAngleB
            // 
            this.textBox_inputAngleB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputAngleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleB.Location = new System.Drawing.Point(244, 84);
            this.textBox_inputAngleB.Name = "textBox_inputAngleB";
            this.textBox_inputAngleB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputAngleB.TabIndex = 470;
            this.textBox_inputAngleB.Text = "0";
            this.textBox_inputAngleB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputAngleY
            // 
            this.textBox_inputAngleY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputAngleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleY.Location = new System.Drawing.Point(160, 84);
            this.textBox_inputAngleY.Name = "textBox_inputAngleY";
            this.textBox_inputAngleY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputAngleY.TabIndex = 469;
            this.textBox_inputAngleY.Text = "0";
            this.textBox_inputAngleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputAngleR
            // 
            this.textBox_inputAngleR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputAngleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputAngleR.Location = new System.Drawing.Point(72, 83);
            this.textBox_inputAngleR.Name = "textBox_inputAngleR";
            this.textBox_inputAngleR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputAngleR.TabIndex = 468;
            this.textBox_inputAngleR.Text = "0";
            this.textBox_inputAngleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(20, 85);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(48, 17);
            this.label82.TabIndex = 467;
            this.label82.Text = "Angle:";
            // 
            // textBox_inputPFB
            // 
            this.textBox_inputPFB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputPFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputPFB.Location = new System.Drawing.Point(244, 184);
            this.textBox_inputPFB.Name = "textBox_inputPFB";
            this.textBox_inputPFB.ReadOnly = true;
            this.textBox_inputPFB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputPFB.TabIndex = 466;
            this.textBox_inputPFB.Text = "0";
            this.textBox_inputPFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputCurrB
            // 
            this.textBox_inputCurrB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputCurrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputCurrB.Location = new System.Drawing.Point(244, 59);
            this.textBox_inputCurrB.Name = "textBox_inputCurrB";
            this.textBox_inputCurrB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputCurrB.TabIndex = 465;
            this.textBox_inputCurrB.Text = "10";
            this.textBox_inputCurrB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVolB
            // 
            this.textBox_inputVolB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_inputVolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVolB.Location = new System.Drawing.Point(244, 34);
            this.textBox_inputVolB.Name = "textBox_inputVolB";
            this.textBox_inputVolB.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVolB.TabIndex = 464;
            this.textBox_inputVolB.Text = "240";
            this.textBox_inputVolB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputPFY
            // 
            this.textBox_inputPFY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputPFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputPFY.Location = new System.Drawing.Point(160, 184);
            this.textBox_inputPFY.Name = "textBox_inputPFY";
            this.textBox_inputPFY.ReadOnly = true;
            this.textBox_inputPFY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputPFY.TabIndex = 463;
            this.textBox_inputPFY.Text = "0";
            this.textBox_inputPFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputCurrY
            // 
            this.textBox_inputCurrY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputCurrY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputCurrY.Location = new System.Drawing.Point(160, 59);
            this.textBox_inputCurrY.Name = "textBox_inputCurrY";
            this.textBox_inputCurrY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputCurrY.TabIndex = 462;
            this.textBox_inputCurrY.Text = "10";
            this.textBox_inputCurrY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVolY
            // 
            this.textBox_inputVolY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_inputVolY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVolY.Location = new System.Drawing.Point(160, 34);
            this.textBox_inputVolY.Name = "textBox_inputVolY";
            this.textBox_inputVolY.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVolY.TabIndex = 461;
            this.textBox_inputVolY.Text = "240";
            this.textBox_inputVolY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputPFR
            // 
            this.textBox_inputPFR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputPFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputPFR.Location = new System.Drawing.Point(72, 183);
            this.textBox_inputPFR.Name = "textBox_inputPFR";
            this.textBox_inputPFR.ReadOnly = true;
            this.textBox_inputPFR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputPFR.TabIndex = 460;
            this.textBox_inputPFR.Text = "0";
            this.textBox_inputPFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputCurrR
            // 
            this.textBox_inputCurrR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputCurrR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputCurrR.Location = new System.Drawing.Point(72, 58);
            this.textBox_inputCurrR.Name = "textBox_inputCurrR";
            this.textBox_inputCurrR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputCurrR.TabIndex = 459;
            this.textBox_inputCurrR.Text = "10";
            this.textBox_inputCurrR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_inputVolR
            // 
            this.textBox_inputVolR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_inputVolR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputVolR.Location = new System.Drawing.Point(72, 33);
            this.textBox_inputVolR.Name = "textBox_inputVolR";
            this.textBox_inputVolR.Size = new System.Drawing.Size(61, 23);
            this.textBox_inputVolR.TabIndex = 458;
            this.textBox_inputVolR.Text = "240";
            this.textBox_inputVolR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.Red;
            this.label87.Location = new System.Drawing.Point(68, 14);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(69, 17);
            this.label87.TabIndex = 455;
            this.label87.Text = "R Phase";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.Yellow;
            this.label88.Location = new System.Drawing.Point(157, 14);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(68, 17);
            this.label88.TabIndex = 456;
            this.label88.Text = "Y Phase";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.Blue;
            this.label89.Location = new System.Drawing.Point(237, 14);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(68, 17);
            this.label89.TabIndex = 457;
            this.label89.Text = "B Phase";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(8, 35);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(60, 17);
            this.label90.TabIndex = 452;
            this.label90.Text = "Voltage:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(9, 59);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(59, 17);
            this.label102.TabIndex = 453;
            this.label102.Text = "Current:";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.button_iStop);
            this.groupBox23.Controls.Add(this.textBox_NewFileName);
            this.groupBox23.Controls.Add(this.checkBox_LogToNewFile);
            this.groupBox23.Controls.Add(this.button_iRead);
            this.groupBox23.Controls.Add(this.checkBox_iAutoRead);
            this.groupBox23.Controls.Add(this.label_iAutoreadLabel);
            this.groupBox23.Controls.Add(this.checkBox_LogData);
            this.groupBox23.Controls.Add(this.textBox_iAutoReadTime);
            this.groupBox23.Location = new System.Drawing.Point(6, 314);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(479, 71);
            this.groupBox23.TabIndex = 404;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Read Setup";
            // 
            // button_iStop
            // 
            this.button_iStop.Enabled = false;
            this.button_iStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iStop.Location = new System.Drawing.Point(384, 37);
            this.button_iStop.Name = "button_iStop";
            this.button_iStop.Size = new System.Drawing.Size(89, 26);
            this.button_iStop.TabIndex = 308;
            this.button_iStop.Text = "Stop";
            this.button_iStop.UseVisualStyleBackColor = true;
            // 
            // textBox_NewFileName
            // 
            this.textBox_NewFileName.Location = new System.Drawing.Point(93, 41);
            this.textBox_NewFileName.Name = "textBox_NewFileName";
            this.textBox_NewFileName.Size = new System.Drawing.Size(100, 23);
            this.textBox_NewFileName.TabIndex = 307;
            // 
            // checkBox_LogToNewFile
            // 
            this.checkBox_LogToNewFile.AutoSize = true;
            this.checkBox_LogToNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_LogToNewFile.Location = new System.Drawing.Point(6, 40);
            this.checkBox_LogToNewFile.Name = "checkBox_LogToNewFile";
            this.checkBox_LogToNewFile.Size = new System.Drawing.Size(80, 21);
            this.checkBox_LogToNewFile.TabIndex = 306;
            this.checkBox_LogToNewFile.Text = "New File";
            this.checkBox_LogToNewFile.UseVisualStyleBackColor = true;
            // 
            // button_iRead
            // 
            this.button_iRead.Enabled = false;
            this.button_iRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iRead.Location = new System.Drawing.Point(384, 13);
            this.button_iRead.Name = "button_iRead";
            this.button_iRead.Size = new System.Drawing.Size(89, 26);
            this.button_iRead.TabIndex = 303;
            this.button_iRead.Text = "Read";
            this.button_iRead.UseVisualStyleBackColor = true;
            // 
            // checkBox_iAutoRead
            // 
            this.checkBox_iAutoRead.AutoSize = true;
            this.checkBox_iAutoRead.Checked = true;
            this.checkBox_iAutoRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_iAutoRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_iAutoRead.Location = new System.Drawing.Point(211, 13);
            this.checkBox_iAutoRead.Name = "checkBox_iAutoRead";
            this.checkBox_iAutoRead.Size = new System.Drawing.Size(94, 21);
            this.checkBox_iAutoRead.TabIndex = 305;
            this.checkBox_iAutoRead.Text = "Auto Read";
            this.checkBox_iAutoRead.UseVisualStyleBackColor = true;
            // 
            // label_iAutoreadLabel
            // 
            this.label_iAutoreadLabel.AutoSize = true;
            this.label_iAutoreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iAutoreadLabel.Location = new System.Drawing.Point(211, 40);
            this.label_iAutoreadLabel.Name = "label_iAutoreadLabel";
            this.label_iAutoreadLabel.Size = new System.Drawing.Size(113, 17);
            this.label_iAutoreadLabel.TabIndex = 301;
            this.label_iAutoreadLabel.Text = "Read Time (ms):";
            // 
            // checkBox_LogData
            // 
            this.checkBox_LogData.AutoSize = true;
            this.checkBox_LogData.Checked = true;
            this.checkBox_LogData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LogData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_LogData.Location = new System.Drawing.Point(6, 18);
            this.checkBox_LogData.Name = "checkBox_LogData";
            this.checkBox_LogData.Size = new System.Drawing.Size(85, 21);
            this.checkBox_LogData.TabIndex = 304;
            this.checkBox_LogData.Text = "Log Data";
            this.checkBox_LogData.UseVisualStyleBackColor = true;
            // 
            // textBox_iAutoReadTime
            // 
            this.textBox_iAutoReadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iAutoReadTime.Location = new System.Drawing.Point(330, 37);
            this.textBox_iAutoReadTime.Name = "textBox_iAutoReadTime";
            this.textBox_iAutoReadTime.Size = new System.Drawing.Size(42, 23);
            this.textBox_iAutoReadTime.TabIndex = 302;
            this.textBox_iAutoReadTime.Text = "750";
            this.textBox_iAutoReadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage6.Controls.Add(this.label119);
            this.tabPage6.Controls.Add(this.textBoxCalPhaseCorrSamplesR);
            this.tabPage6.Controls.Add(this.button_SaveCalData);
            this.tabPage6.Controls.Add(this.textBoxCalPhaseCorrSamplesB);
            this.tabPage6.Controls.Add(this.textBox_SaveCalDataFileName);
            this.tabPage6.Controls.Add(this.textBoxCalPhaseCorrSamplesY);
            this.tabPage6.Controls.Add(this.buttonReadData);
            this.tabPage6.Controls.Add(this.groupBox20);
            this.tabPage6.Controls.Add(this.buttonPasteData);
            this.tabPage6.Controls.Add(this.groupBox12);
            this.tabPage6.Controls.Add(this.groupBox11);
            this.tabPage6.Controls.Add(this.groupBox13);
            this.tabPage6.Controls.Add(this.groupBox14);
            this.tabPage6.Controls.Add(this.buttonDecode);
            this.tabPage6.Controls.Add(this.textBoxInput);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1206, 562);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Calibration Data";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(734, 466);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(122, 17);
            this.label119.TabIndex = 155;
            this.label119.Text = "Phase Corr Samples";
            // 
            // textBoxCalPhaseCorrSamplesR
            // 
            this.textBoxCalPhaseCorrSamplesR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalPhaseCorrSamplesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalPhaseCorrSamplesR.Location = new System.Drawing.Point(846, 463);
            this.textBoxCalPhaseCorrSamplesR.Multiline = true;
            this.textBoxCalPhaseCorrSamplesR.Name = "textBoxCalPhaseCorrSamplesR";
            this.textBoxCalPhaseCorrSamplesR.Size = new System.Drawing.Size(40, 66);
            this.textBoxCalPhaseCorrSamplesR.TabIndex = 156;
            // 
            // button_SaveCalData
            // 
            this.button_SaveCalData.Location = new System.Drawing.Point(425, 446);
            this.button_SaveCalData.Name = "button_SaveCalData";
            this.button_SaveCalData.Size = new System.Drawing.Size(75, 23);
            this.button_SaveCalData.TabIndex = 168;
            this.button_SaveCalData.Text = "Save Data";
            this.button_SaveCalData.UseVisualStyleBackColor = true;
            // 
            // textBoxCalPhaseCorrSamplesB
            // 
            this.textBoxCalPhaseCorrSamplesB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalPhaseCorrSamplesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalPhaseCorrSamplesB.Location = new System.Drawing.Point(1017, 463);
            this.textBoxCalPhaseCorrSamplesB.Multiline = true;
            this.textBoxCalPhaseCorrSamplesB.Name = "textBoxCalPhaseCorrSamplesB";
            this.textBoxCalPhaseCorrSamplesB.Size = new System.Drawing.Size(40, 66);
            this.textBoxCalPhaseCorrSamplesB.TabIndex = 157;
            // 
            // textBox_SaveCalDataFileName
            // 
            this.textBox_SaveCalDataFileName.Location = new System.Drawing.Point(7, 448);
            this.textBox_SaveCalDataFileName.Name = "textBox_SaveCalDataFileName";
            this.textBox_SaveCalDataFileName.Size = new System.Drawing.Size(412, 23);
            this.textBox_SaveCalDataFileName.TabIndex = 167;
            // 
            // textBoxCalPhaseCorrSamplesY
            // 
            this.textBoxCalPhaseCorrSamplesY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalPhaseCorrSamplesY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalPhaseCorrSamplesY.Location = new System.Drawing.Point(932, 463);
            this.textBoxCalPhaseCorrSamplesY.Multiline = true;
            this.textBoxCalPhaseCorrSamplesY.Name = "textBoxCalPhaseCorrSamplesY";
            this.textBoxCalPhaseCorrSamplesY.Size = new System.Drawing.Size(40, 66);
            this.textBoxCalPhaseCorrSamplesY.TabIndex = 158;
            // 
            // buttonReadData
            // 
            this.buttonReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadData.Location = new System.Drawing.Point(7, 388);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(165, 53);
            this.buttonReadData.TabIndex = 166;
            this.buttonReadData.Text = "READ";
            this.buttonReadData.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.textBoxNeuCalButtonPressTime);
            this.groupBox20.Controls.Add(this.label93);
            this.groupBox20.Controls.Add(this.textBoxNeuCalDisplayTime);
            this.groupBox20.Controls.Add(this.label104);
            this.groupBox20.Controls.Add(this.label21);
            this.groupBox20.Controls.Add(this.textBoxNeuCalCounter);
            this.groupBox20.Controls.Add(this.textBoxNeuCalTime);
            this.groupBox20.Controls.Add(this.label105);
            this.groupBox20.Location = new System.Drawing.Point(506, 374);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(215, 125);
            this.groupBox20.TabIndex = 165;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Neutral Calibration Info";
            // 
            // textBoxNeuCalButtonPressTime
            // 
            this.textBoxNeuCalButtonPressTime.Location = new System.Drawing.Point(95, 66);
            this.textBoxNeuCalButtonPressTime.Name = "textBoxNeuCalButtonPressTime";
            this.textBoxNeuCalButtonPressTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxNeuCalButtonPressTime.TabIndex = 49;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(7, 95);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(101, 17);
            this.label93.TabIndex = 46;
            this.label93.Text = "Calibration Time";
            // 
            // textBoxNeuCalDisplayTime
            // 
            this.textBoxNeuCalDisplayTime.Location = new System.Drawing.Point(95, 41);
            this.textBoxNeuCalDisplayTime.Name = "textBoxNeuCalDisplayTime";
            this.textBoxNeuCalDisplayTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxNeuCalDisplayTime.TabIndex = 48;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(7, 21);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(54, 17);
            this.label104.TabIndex = 47;
            this.label104.Text = "Counter";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 17);
            this.label21.TabIndex = 47;
            this.label21.Text = "Button Press time";
            // 
            // textBoxNeuCalCounter
            // 
            this.textBoxNeuCalCounter.Location = new System.Drawing.Point(95, 18);
            this.textBoxNeuCalCounter.Name = "textBoxNeuCalCounter";
            this.textBoxNeuCalCounter.Size = new System.Drawing.Size(114, 23);
            this.textBoxNeuCalCounter.TabIndex = 48;
            // 
            // textBoxNeuCalTime
            // 
            this.textBoxNeuCalTime.Location = new System.Drawing.Point(95, 92);
            this.textBoxNeuCalTime.Name = "textBoxNeuCalTime";
            this.textBoxNeuCalTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxNeuCalTime.TabIndex = 49;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(7, 44);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(100, 17);
            this.label105.TabIndex = 46;
            this.label105.Text = "Cal Display time";
            // 
            // buttonPasteData
            // 
            this.buttonPasteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPasteData.Location = new System.Drawing.Point(178, 388);
            this.buttonPasteData.Name = "buttonPasteData";
            this.buttonPasteData.Size = new System.Drawing.Size(150, 53);
            this.buttonPasteData.TabIndex = 164;
            this.buttonPasteData.Text = "PASTE";
            this.buttonPasteData.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.label37);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.textBoxRTCPPMSigned);
            this.groupBox12.Controls.Add(this.textBoxRTCCalSec);
            this.groupBox12.Controls.Add(this.label40);
            this.groupBox12.Controls.Add(this.textBoxRTCRADJ);
            this.groupBox12.Controls.Add(this.textBoxRTCCalSign);
            this.groupBox12.Controls.Add(this.textBoxRTCCalTime);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.textBoxRTCCalDoneF);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Location = new System.Drawing.Point(506, -2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(215, 184);
            this.groupBox12.TabIndex = 163;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "RTC Calibration Info";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 26);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(97, 17);
            this.label39.TabIndex = 116;
            this.label39.Text = "Calibration Sign";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(16, 52);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(93, 17);
            this.label38.TabIndex = 115;
            this.label38.Text = "Calibration Sec";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 78);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(39, 17);
            this.label37.TabIndex = 114;
            this.label37.Text = "RADJ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 108);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 17);
            this.label36.TabIndex = 113;
            this.label36.Text = "cal_done_f";
            // 
            // textBoxRTCPPMSigned
            // 
            this.textBoxRTCPPMSigned.Location = new System.Drawing.Point(102, 130);
            this.textBoxRTCPPMSigned.Name = "textBoxRTCPPMSigned";
            this.textBoxRTCPPMSigned.Size = new System.Drawing.Size(100, 23);
            this.textBoxRTCPPMSigned.TabIndex = 136;
            // 
            // textBoxRTCCalSec
            // 
            this.textBoxRTCCalSec.Location = new System.Drawing.Point(102, 49);
            this.textBoxRTCCalSec.Name = "textBoxRTCCalSec";
            this.textBoxRTCCalSec.Size = new System.Drawing.Size(101, 23);
            this.textBoxRTCCalSec.TabIndex = 128;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 134);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(79, 17);
            this.label40.TabIndex = 135;
            this.label40.Text = "PPM(Signed)";
            // 
            // textBoxRTCRADJ
            // 
            this.textBoxRTCRADJ.Location = new System.Drawing.Point(102, 75);
            this.textBoxRTCRADJ.Name = "textBoxRTCRADJ";
            this.textBoxRTCRADJ.Size = new System.Drawing.Size(101, 23);
            this.textBoxRTCRADJ.TabIndex = 129;
            // 
            // textBoxRTCCalSign
            // 
            this.textBoxRTCCalSign.Location = new System.Drawing.Point(102, 23);
            this.textBoxRTCCalSign.Name = "textBoxRTCCalSign";
            this.textBoxRTCCalSign.Size = new System.Drawing.Size(101, 23);
            this.textBoxRTCCalSign.TabIndex = 127;
            // 
            // textBoxRTCCalTime
            // 
            this.textBoxRTCCalTime.Location = new System.Drawing.Point(102, 157);
            this.textBoxRTCCalTime.Name = "textBoxRTCCalTime";
            this.textBoxRTCCalTime.Size = new System.Drawing.Size(101, 23);
            this.textBoxRTCCalTime.TabIndex = 133;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(155, 1);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(0, 17);
            this.label35.TabIndex = 112;
            // 
            // textBoxRTCCalDoneF
            // 
            this.textBoxRTCCalDoneF.Location = new System.Drawing.Point(102, 101);
            this.textBoxRTCCalDoneF.Name = "textBoxRTCCalDoneF";
            this.textBoxRTCCalDoneF.Size = new System.Drawing.Size(101, 23);
            this.textBoxRTCCalDoneF.TabIndex = 130;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(14, 160);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 17);
            this.label41.TabIndex = 118;
            this.label41.Text = "Calibration Time";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label118);
            this.groupBox11.Controls.Add(this.textBoxCalTempPhase);
            this.groupBox11.Controls.Add(this.textBoxPhaseCalbuttonPressTime);
            this.groupBox11.Controls.Add(this.textBoxPhaseCalDisplayTime);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.textBoxCalDoneF);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.textBoxPhaseCalTime);
            this.groupBox11.Controls.Add(this.textBoxPhaseCalCounter);
            this.groupBox11.Location = new System.Drawing.Point(506, 188);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(215, 176);
            this.groupBox11.TabIndex = 162;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Phase Calibration Info";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(7, 152);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(81, 17);
            this.label118.TabIndex = 46;
            this.label118.Text = "Temperature";
            // 
            // textBoxCalTempPhase
            // 
            this.textBoxCalTempPhase.Location = new System.Drawing.Point(95, 150);
            this.textBoxCalTempPhase.Name = "textBoxCalTempPhase";
            this.textBoxCalTempPhase.Size = new System.Drawing.Size(114, 23);
            this.textBoxCalTempPhase.TabIndex = 47;
            // 
            // textBoxPhaseCalbuttonPressTime
            // 
            this.textBoxPhaseCalbuttonPressTime.Location = new System.Drawing.Point(95, 48);
            this.textBoxPhaseCalbuttonPressTime.Name = "textBoxPhaseCalbuttonPressTime";
            this.textBoxPhaseCalbuttonPressTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxPhaseCalbuttonPressTime.TabIndex = 45;
            // 
            // textBoxPhaseCalDisplayTime
            // 
            this.textBoxPhaseCalDisplayTime.Location = new System.Drawing.Point(95, 23);
            this.textBoxPhaseCalDisplayTime.Name = "textBoxPhaseCalDisplayTime";
            this.textBoxPhaseCalDisplayTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxPhaseCalDisplayTime.TabIndex = 44;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 17);
            this.label25.TabIndex = 43;
            this.label25.Text = "Button Press time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Cal Display time";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Calibration Time";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 17);
            this.label22.TabIndex = 15;
            this.label22.Text = "cal_done_f";
            // 
            // textBoxCalDoneF
            // 
            this.textBoxCalDoneF.Location = new System.Drawing.Point(95, 124);
            this.textBoxCalDoneF.Name = "textBoxCalDoneF";
            this.textBoxCalDoneF.Size = new System.Drawing.Size(114, 23);
            this.textBoxCalDoneF.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "Counter";
            // 
            // textBoxPhaseCalTime
            // 
            this.textBoxPhaseCalTime.Location = new System.Drawing.Point(95, 74);
            this.textBoxPhaseCalTime.Name = "textBoxPhaseCalTime";
            this.textBoxPhaseCalTime.Size = new System.Drawing.Size(114, 23);
            this.textBoxPhaseCalTime.TabIndex = 41;
            // 
            // textBoxPhaseCalCounter
            // 
            this.textBoxPhaseCalCounter.Location = new System.Drawing.Point(95, 99);
            this.textBoxPhaseCalCounter.Name = "textBoxPhaseCalCounter";
            this.textBoxPhaseCalCounter.Size = new System.Drawing.Size(114, 23);
            this.textBoxPhaseCalCounter.TabIndex = 40;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBoxMeasFreqNet);
            this.groupBox13.Controls.Add(this.textBoxMeasFreqY);
            this.groupBox13.Controls.Add(this.textBoxMeasFreqB);
            this.groupBox13.Controls.Add(this.textBoxMeasFreqR);
            this.groupBox13.Controls.Add(this.label106);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.textBoxMeasV90IY);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Controls.Add(this.textBoxMeasV90IB);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.textBoxMeasV90IR);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Controls.Add(this.label43);
            this.groupBox13.Controls.Add(this.label28);
            this.groupBox13.Controls.Add(this.textBoxMeasVIY);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.textBoxMeasVIB);
            this.groupBox13.Controls.Add(this.textBoxMeasVIR);
            this.groupBox13.Controls.Add(this.label42);
            this.groupBox13.Controls.Add(this.textBoxMeasVolR);
            this.groupBox13.Controls.Add(this.textBoxMeasVolB);
            this.groupBox13.Controls.Add(this.textBoxMeasVolY);
            this.groupBox13.Controls.Add(this.textBoxMeasCurrR);
            this.groupBox13.Controls.Add(this.textBoxMeasCurrB);
            this.groupBox13.Controls.Add(this.textBoxMeasCurrY);
            this.groupBox13.Controls.Add(this.textBoxMeasPFR);
            this.groupBox13.Controls.Add(this.textBoxMeasPFB);
            this.groupBox13.Controls.Add(this.textBoxMeasPFY);
            this.groupBox13.Controls.Add(this.textBoxMeasWattR);
            this.groupBox13.Controls.Add(this.textBoxMeasWattB);
            this.groupBox13.Controls.Add(this.textBoxMeasCurrN);
            this.groupBox13.Controls.Add(this.textBoxMeasWattY);
            this.groupBox13.Controls.Add(this.textBoxMeasVARR);
            this.groupBox13.Controls.Add(this.textBoxMeasVAY);
            this.groupBox13.Controls.Add(this.textBoxMeasVARB);
            this.groupBox13.Controls.Add(this.textBoxMeasVARY);
            this.groupBox13.Controls.Add(this.textBoxMeasVAB);
            this.groupBox13.Controls.Add(this.textBoxMeasVAR);
            this.groupBox13.Location = new System.Drawing.Point(727, 196);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(429, 261);
            this.groupBox13.TabIndex = 161;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Measured Data";
            // 
            // textBoxMeasFreqNet
            // 
            this.textBoxMeasFreqNet.Location = new System.Drawing.Point(373, 230);
            this.textBoxMeasFreqNet.Name = "textBoxMeasFreqNet";
            this.textBoxMeasFreqNet.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasFreqNet.TabIndex = 149;
            // 
            // textBoxMeasFreqY
            // 
            this.textBoxMeasFreqY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasFreqY.Location = new System.Drawing.Point(205, 230);
            this.textBoxMeasFreqY.Name = "textBoxMeasFreqY";
            this.textBoxMeasFreqY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasFreqY.TabIndex = 148;
            // 
            // textBoxMeasFreqB
            // 
            this.textBoxMeasFreqB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasFreqB.Location = new System.Drawing.Point(290, 230);
            this.textBoxMeasFreqB.Name = "textBoxMeasFreqB";
            this.textBoxMeasFreqB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasFreqB.TabIndex = 147;
            // 
            // textBoxMeasFreqR
            // 
            this.textBoxMeasFreqR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasFreqR.Location = new System.Drawing.Point(119, 230);
            this.textBoxMeasFreqR.Name = "textBoxMeasFreqR";
            this.textBoxMeasFreqR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasFreqR.TabIndex = 146;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(67, 233);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(34, 17);
            this.label106.TabIndex = 145;
            this.label106.Text = "Freq";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(52, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 17);
            this.label26.TabIndex = 44;
            this.label26.Text = "Voltage";
            // 
            // textBoxMeasV90IY
            // 
            this.textBoxMeasV90IY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasV90IY.Location = new System.Drawing.Point(205, 204);
            this.textBoxMeasV90IY.Name = "textBoxMeasV90IY";
            this.textBoxMeasV90IY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasV90IY.TabIndex = 144;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 17);
            this.label20.TabIndex = 48;
            this.label20.Text = "Current";
            // 
            // textBoxMeasV90IB
            // 
            this.textBoxMeasV90IB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasV90IB.Location = new System.Drawing.Point(290, 204);
            this.textBoxMeasV90IB.Name = "textBoxMeasV90IB";
            this.textBoxMeasV90IB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasV90IB.TabIndex = 143;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "PF";
            // 
            // textBoxMeasV90IR
            // 
            this.textBoxMeasV90IR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasV90IR.Location = new System.Drawing.Point(119, 204);
            this.textBoxMeasV90IR.Name = "textBoxMeasV90IR";
            this.textBoxMeasV90IR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasV90IR.TabIndex = 142;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(39, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 17);
            this.label27.TabIndex = 57;
            this.label27.Text = "Power(W)";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(36, 207);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(79, 17);
            this.label43.TabIndex = 141;
            this.label43.Text = "Angle(V90-I)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(28, 129);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 17);
            this.label28.TabIndex = 61;
            this.label28.Text = "Power(VAR)";
            // 
            // textBoxMeasVIY
            // 
            this.textBoxMeasVIY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasVIY.Location = new System.Drawing.Point(205, 178);
            this.textBoxMeasVIY.Name = "textBoxMeasVIY";
            this.textBoxMeasVIY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVIY.TabIndex = 140;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(36, 155);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 17);
            this.label29.TabIndex = 65;
            this.label29.Text = "Power(VA)";
            // 
            // textBoxMeasVIB
            // 
            this.textBoxMeasVIB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasVIB.Location = new System.Drawing.Point(290, 178);
            this.textBoxMeasVIB.Name = "textBoxMeasVIB";
            this.textBoxMeasVIB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVIB.TabIndex = 139;
            // 
            // textBoxMeasVIR
            // 
            this.textBoxMeasVIR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasVIR.Location = new System.Drawing.Point(119, 178);
            this.textBoxMeasVIR.Name = "textBoxMeasVIR";
            this.textBoxMeasVIR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVIR.TabIndex = 138;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(36, 181);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(67, 17);
            this.label42.TabIndex = 137;
            this.label42.Text = "Angle(V-I)";
            // 
            // textBoxMeasVolR
            // 
            this.textBoxMeasVolR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasVolR.Location = new System.Drawing.Point(119, 22);
            this.textBoxMeasVolR.Name = "textBoxMeasVolR";
            this.textBoxMeasVolR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVolR.TabIndex = 91;
            // 
            // textBoxMeasVolB
            // 
            this.textBoxMeasVolB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasVolB.Location = new System.Drawing.Point(290, 22);
            this.textBoxMeasVolB.Name = "textBoxMeasVolB";
            this.textBoxMeasVolB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVolB.TabIndex = 92;
            // 
            // textBoxMeasVolY
            // 
            this.textBoxMeasVolY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasVolY.Location = new System.Drawing.Point(205, 22);
            this.textBoxMeasVolY.Name = "textBoxMeasVolY";
            this.textBoxMeasVolY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVolY.TabIndex = 93;
            // 
            // textBoxMeasCurrR
            // 
            this.textBoxMeasCurrR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasCurrR.Location = new System.Drawing.Point(119, 48);
            this.textBoxMeasCurrR.Name = "textBoxMeasCurrR";
            this.textBoxMeasCurrR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasCurrR.TabIndex = 94;
            // 
            // textBoxMeasCurrB
            // 
            this.textBoxMeasCurrB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasCurrB.Location = new System.Drawing.Point(290, 48);
            this.textBoxMeasCurrB.Name = "textBoxMeasCurrB";
            this.textBoxMeasCurrB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasCurrB.TabIndex = 95;
            // 
            // textBoxMeasCurrY
            // 
            this.textBoxMeasCurrY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasCurrY.Location = new System.Drawing.Point(205, 48);
            this.textBoxMeasCurrY.Name = "textBoxMeasCurrY";
            this.textBoxMeasCurrY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasCurrY.TabIndex = 96;
            // 
            // textBoxMeasPFR
            // 
            this.textBoxMeasPFR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasPFR.Location = new System.Drawing.Point(119, 74);
            this.textBoxMeasPFR.Name = "textBoxMeasPFR";
            this.textBoxMeasPFR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasPFR.TabIndex = 97;
            // 
            // textBoxMeasPFB
            // 
            this.textBoxMeasPFB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasPFB.Location = new System.Drawing.Point(290, 74);
            this.textBoxMeasPFB.Name = "textBoxMeasPFB";
            this.textBoxMeasPFB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasPFB.TabIndex = 98;
            // 
            // textBoxMeasPFY
            // 
            this.textBoxMeasPFY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasPFY.Location = new System.Drawing.Point(205, 74);
            this.textBoxMeasPFY.Name = "textBoxMeasPFY";
            this.textBoxMeasPFY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasPFY.TabIndex = 99;
            // 
            // textBoxMeasWattR
            // 
            this.textBoxMeasWattR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasWattR.Location = new System.Drawing.Point(119, 100);
            this.textBoxMeasWattR.Name = "textBoxMeasWattR";
            this.textBoxMeasWattR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasWattR.TabIndex = 100;
            // 
            // textBoxMeasWattB
            // 
            this.textBoxMeasWattB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasWattB.Location = new System.Drawing.Point(290, 100);
            this.textBoxMeasWattB.Name = "textBoxMeasWattB";
            this.textBoxMeasWattB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasWattB.TabIndex = 101;
            // 
            // textBoxMeasCurrN
            // 
            this.textBoxMeasCurrN.Location = new System.Drawing.Point(373, 48);
            this.textBoxMeasCurrN.Name = "textBoxMeasCurrN";
            this.textBoxMeasCurrN.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasCurrN.TabIndex = 109;
            // 
            // textBoxMeasWattY
            // 
            this.textBoxMeasWattY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasWattY.Location = new System.Drawing.Point(205, 100);
            this.textBoxMeasWattY.Name = "textBoxMeasWattY";
            this.textBoxMeasWattY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasWattY.TabIndex = 102;
            // 
            // textBoxMeasVARR
            // 
            this.textBoxMeasVARR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasVARR.Location = new System.Drawing.Point(119, 126);
            this.textBoxMeasVARR.Name = "textBoxMeasVARR";
            this.textBoxMeasVARR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVARR.TabIndex = 103;
            // 
            // textBoxMeasVAY
            // 
            this.textBoxMeasVAY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasVAY.Location = new System.Drawing.Point(205, 152);
            this.textBoxMeasVAY.Name = "textBoxMeasVAY";
            this.textBoxMeasVAY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVAY.TabIndex = 108;
            // 
            // textBoxMeasVARB
            // 
            this.textBoxMeasVARB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasVARB.Location = new System.Drawing.Point(290, 126);
            this.textBoxMeasVARB.Name = "textBoxMeasVARB";
            this.textBoxMeasVARB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVARB.TabIndex = 104;
            // 
            // textBoxMeasVARY
            // 
            this.textBoxMeasVARY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxMeasVARY.Location = new System.Drawing.Point(205, 126);
            this.textBoxMeasVARY.Name = "textBoxMeasVARY";
            this.textBoxMeasVARY.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVARY.TabIndex = 105;
            // 
            // textBoxMeasVAB
            // 
            this.textBoxMeasVAB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMeasVAB.Location = new System.Drawing.Point(290, 152);
            this.textBoxMeasVAB.Name = "textBoxMeasVAB";
            this.textBoxMeasVAB.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVAB.TabIndex = 107;
            // 
            // textBoxMeasVAR
            // 
            this.textBoxMeasVAR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxMeasVAR.Location = new System.Drawing.Point(119, 152);
            this.textBoxMeasVAR.Name = "textBoxMeasVAR";
            this.textBoxMeasVAR.Size = new System.Drawing.Size(40, 23);
            this.textBoxMeasVAR.TabIndex = 106;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label14);
            this.groupBox14.Controls.Add(this.label16);
            this.groupBox14.Controls.Add(this.label17);
            this.groupBox14.Controls.Add(this.label18);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Controls.Add(this.label30);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Controls.Add(this.textBoxCalVolR);
            this.groupBox14.Controls.Add(this.textBoxCalVolB);
            this.groupBox14.Controls.Add(this.textBoxCalVolY);
            this.groupBox14.Controls.Add(this.textBoxCalCurrR);
            this.groupBox14.Controls.Add(this.textBoxCalCurrB);
            this.groupBox14.Controls.Add(this.textBoxCalCurrY);
            this.groupBox14.Controls.Add(this.textBoxCalPowR);
            this.groupBox14.Controls.Add(this.textBoxCalPowB);
            this.groupBox14.Controls.Add(this.textBoxCalPowY);
            this.groupBox14.Controls.Add(this.textBoxCalVolOffR);
            this.groupBox14.Controls.Add(this.textBoxCalVolOffB);
            this.groupBox14.Controls.Add(this.textBoxCalVolOffY);
            this.groupBox14.Controls.Add(this.textBoxCalCurrOffR);
            this.groupBox14.Controls.Add(this.textBoxCalCurrOffB);
            this.groupBox14.Controls.Add(this.textBoxCalCurrOffY);
            this.groupBox14.Controls.Add(this.textBoxCalPhaseR);
            this.groupBox14.Controls.Add(this.textBoxCalPhaseB);
            this.groupBox14.Controls.Add(this.textBoxCalPhaseY);
            this.groupBox14.Controls.Add(this.textBoxCalCurrN);
            this.groupBox14.Controls.Add(this.textBoxCalCurrOffN);
            this.groupBox14.Location = new System.Drawing.Point(727, -5);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(429, 199);
            this.groupBox14.TabIndex = 160;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Calibration Coefficient";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(110, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "R Phase";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(199, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Y Phase";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(283, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "B Phase";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(370, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Neutral";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(60, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 17);
            this.label24.TabIndex = 6;
            this.label24.Text = "Voltage";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(60, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 17);
            this.label30.TabIndex = 7;
            this.label30.Text = "Current";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(60, 89);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 17);
            this.label31.TabIndex = 9;
            this.label31.Text = "Power";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(23, 141);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 17);
            this.label32.TabIndex = 10;
            this.label32.Text = "Current Offset";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(23, 115);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 17);
            this.label33.TabIndex = 11;
            this.label33.Text = "Voltage Offset";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 164);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 17);
            this.label34.TabIndex = 17;
            this.label34.Text = "Phase Correction";
            // 
            // textBoxCalVolR
            // 
            this.textBoxCalVolR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalVolR.Location = new System.Drawing.Point(119, 34);
            this.textBoxCalVolR.Name = "textBoxCalVolR";
            this.textBoxCalVolR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolR.TabIndex = 18;
            // 
            // textBoxCalVolB
            // 
            this.textBoxCalVolB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalVolB.Location = new System.Drawing.Point(290, 34);
            this.textBoxCalVolB.Name = "textBoxCalVolB";
            this.textBoxCalVolB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolB.TabIndex = 67;
            // 
            // textBoxCalVolY
            // 
            this.textBoxCalVolY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalVolY.Location = new System.Drawing.Point(205, 34);
            this.textBoxCalVolY.Name = "textBoxCalVolY";
            this.textBoxCalVolY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolY.TabIndex = 68;
            // 
            // textBoxCalCurrR
            // 
            this.textBoxCalCurrR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalCurrR.Location = new System.Drawing.Point(119, 60);
            this.textBoxCalCurrR.Name = "textBoxCalCurrR";
            this.textBoxCalCurrR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrR.TabIndex = 69;
            // 
            // textBoxCalCurrB
            // 
            this.textBoxCalCurrB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalCurrB.Location = new System.Drawing.Point(290, 60);
            this.textBoxCalCurrB.Name = "textBoxCalCurrB";
            this.textBoxCalCurrB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrB.TabIndex = 70;
            // 
            // textBoxCalCurrY
            // 
            this.textBoxCalCurrY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalCurrY.Location = new System.Drawing.Point(205, 60);
            this.textBoxCalCurrY.Name = "textBoxCalCurrY";
            this.textBoxCalCurrY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrY.TabIndex = 71;
            // 
            // textBoxCalPowR
            // 
            this.textBoxCalPowR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalPowR.Location = new System.Drawing.Point(119, 86);
            this.textBoxCalPowR.Name = "textBoxCalPowR";
            this.textBoxCalPowR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPowR.TabIndex = 72;
            // 
            // textBoxCalPowB
            // 
            this.textBoxCalPowB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalPowB.Location = new System.Drawing.Point(290, 86);
            this.textBoxCalPowB.Name = "textBoxCalPowB";
            this.textBoxCalPowB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPowB.TabIndex = 73;
            // 
            // textBoxCalPowY
            // 
            this.textBoxCalPowY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalPowY.Location = new System.Drawing.Point(205, 86);
            this.textBoxCalPowY.Name = "textBoxCalPowY";
            this.textBoxCalPowY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPowY.TabIndex = 74;
            // 
            // textBoxCalVolOffR
            // 
            this.textBoxCalVolOffR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalVolOffR.Location = new System.Drawing.Point(119, 112);
            this.textBoxCalVolOffR.Name = "textBoxCalVolOffR";
            this.textBoxCalVolOffR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolOffR.TabIndex = 75;
            // 
            // textBoxCalVolOffB
            // 
            this.textBoxCalVolOffB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalVolOffB.Location = new System.Drawing.Point(290, 112);
            this.textBoxCalVolOffB.Name = "textBoxCalVolOffB";
            this.textBoxCalVolOffB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolOffB.TabIndex = 76;
            // 
            // textBoxCalVolOffY
            // 
            this.textBoxCalVolOffY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalVolOffY.Location = new System.Drawing.Point(205, 112);
            this.textBoxCalVolOffY.Name = "textBoxCalVolOffY";
            this.textBoxCalVolOffY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalVolOffY.TabIndex = 77;
            // 
            // textBoxCalCurrOffR
            // 
            this.textBoxCalCurrOffR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalCurrOffR.Location = new System.Drawing.Point(119, 138);
            this.textBoxCalCurrOffR.Name = "textBoxCalCurrOffR";
            this.textBoxCalCurrOffR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrOffR.TabIndex = 78;
            // 
            // textBoxCalCurrOffB
            // 
            this.textBoxCalCurrOffB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalCurrOffB.Location = new System.Drawing.Point(290, 138);
            this.textBoxCalCurrOffB.Name = "textBoxCalCurrOffB";
            this.textBoxCalCurrOffB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrOffB.TabIndex = 79;
            // 
            // textBoxCalCurrOffY
            // 
            this.textBoxCalCurrOffY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalCurrOffY.Location = new System.Drawing.Point(205, 138);
            this.textBoxCalCurrOffY.Name = "textBoxCalCurrOffY";
            this.textBoxCalCurrOffY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrOffY.TabIndex = 80;
            // 
            // textBoxCalPhaseR
            // 
            this.textBoxCalPhaseR.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCalPhaseR.Location = new System.Drawing.Point(119, 164);
            this.textBoxCalPhaseR.Name = "textBoxCalPhaseR";
            this.textBoxCalPhaseR.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPhaseR.TabIndex = 81;
            // 
            // textBoxCalPhaseB
            // 
            this.textBoxCalPhaseB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxCalPhaseB.Location = new System.Drawing.Point(290, 164);
            this.textBoxCalPhaseB.Name = "textBoxCalPhaseB";
            this.textBoxCalPhaseB.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPhaseB.TabIndex = 82;
            // 
            // textBoxCalPhaseY
            // 
            this.textBoxCalPhaseY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCalPhaseY.Location = new System.Drawing.Point(205, 164);
            this.textBoxCalPhaseY.Name = "textBoxCalPhaseY";
            this.textBoxCalPhaseY.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalPhaseY.TabIndex = 83;
            // 
            // textBoxCalCurrN
            // 
            this.textBoxCalCurrN.Location = new System.Drawing.Point(373, 60);
            this.textBoxCalCurrN.Name = "textBoxCalCurrN";
            this.textBoxCalCurrN.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrN.TabIndex = 84;
            // 
            // textBoxCalCurrOffN
            // 
            this.textBoxCalCurrOffN.Location = new System.Drawing.Point(373, 138);
            this.textBoxCalCurrOffN.Name = "textBoxCalCurrOffN";
            this.textBoxCalCurrOffN.Size = new System.Drawing.Size(40, 23);
            this.textBoxCalCurrOffN.TabIndex = 86;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecode.Location = new System.Drawing.Point(334, 388);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(166, 53);
            this.buttonDecode.TabIndex = 159;
            this.buttonDecode.Text = "DECODE";
            this.buttonDecode.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(6, 6);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(494, 376);
            this.textBoxInput.TabIndex = 154;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage7.Controls.Add(this.groupBox29);
            this.tabPage7.Controls.Add(this.groupBox27);
            this.tabPage7.Controls.Add(this.textBox_WFSamples);
            this.tabPage7.Controls.Add(this.textBox_WFFrame);
            this.tabPage7.Controls.Add(this.groupBox24);
            this.tabPage7.Controls.Add(this.pictureBoxWaveform);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1206, 562);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Waveform Capture";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh6);
            this.groupBox29.Controls.Add(this.textBox_WFScaling6);
            this.groupBox29.Controls.Add(this.label132);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh5);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh4);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh3);
            this.groupBox29.Controls.Add(this.textBox_WFScaling5);
            this.groupBox29.Controls.Add(this.label129);
            this.groupBox29.Controls.Add(this.textBox_WFScaling4);
            this.groupBox29.Controls.Add(this.label130);
            this.groupBox29.Controls.Add(this.textBox_WFScaling3);
            this.groupBox29.Controls.Add(this.label131);
            this.groupBox29.Controls.Add(this.label127);
            this.groupBox29.Controls.Add(this.label125);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh2);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh1);
            this.groupBox29.Controls.Add(this.textBoxWFLegendCh0);
            this.groupBox29.Controls.Add(this.buttonWFPlot);
            this.groupBox29.Controls.Add(this.textBox_WFScaling2);
            this.groupBox29.Controls.Add(this.label122);
            this.groupBox29.Controls.Add(this.textBox_WFScaling1);
            this.groupBox29.Controls.Add(this.label123);
            this.groupBox29.Controls.Add(this.textBox_WFScaling0);
            this.groupBox29.Controls.Add(this.label124);
            this.groupBox29.Location = new System.Drawing.Point(18, 215);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(286, 217);
            this.groupBox29.TabIndex = 12;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Plot Settings";
            // 
            // textBoxWFLegendCh6
            // 
            this.textBoxWFLegendCh6.Location = new System.Drawing.Point(95, 188);
            this.textBoxWFLegendCh6.Name = "textBoxWFLegendCh6";
            this.textBoxWFLegendCh6.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh6.TabIndex = 27;
            this.textBoxWFLegendCh6.Text = "Current N";
            this.textBoxWFLegendCh6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WFScaling6
            // 
            this.textBox_WFScaling6.Location = new System.Drawing.Point(42, 188);
            this.textBox_WFScaling6.Name = "textBox_WFScaling6";
            this.textBox_WFScaling6.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling6.TabIndex = 26;
            this.textBox_WFScaling6.Text = "1";
            this.textBox_WFScaling6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(7, 191);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(33, 17);
            this.label132.TabIndex = 25;
            this.label132.Text = "Ch 6";
            // 
            // textBoxWFLegendCh5
            // 
            this.textBoxWFLegendCh5.Location = new System.Drawing.Point(95, 162);
            this.textBoxWFLegendCh5.Name = "textBoxWFLegendCh5";
            this.textBoxWFLegendCh5.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh5.TabIndex = 24;
            this.textBoxWFLegendCh5.Text = "Current B";
            this.textBoxWFLegendCh5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWFLegendCh4
            // 
            this.textBoxWFLegendCh4.Location = new System.Drawing.Point(95, 136);
            this.textBoxWFLegendCh4.Name = "textBoxWFLegendCh4";
            this.textBoxWFLegendCh4.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh4.TabIndex = 23;
            this.textBoxWFLegendCh4.Text = "Current Y";
            this.textBoxWFLegendCh4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWFLegendCh3
            // 
            this.textBoxWFLegendCh3.Location = new System.Drawing.Point(95, 110);
            this.textBoxWFLegendCh3.Name = "textBoxWFLegendCh3";
            this.textBoxWFLegendCh3.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh3.TabIndex = 22;
            this.textBoxWFLegendCh3.Text = "Current R";
            this.textBoxWFLegendCh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_WFScaling5
            // 
            this.textBox_WFScaling5.Location = new System.Drawing.Point(42, 162);
            this.textBox_WFScaling5.Name = "textBox_WFScaling5";
            this.textBox_WFScaling5.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling5.TabIndex = 21;
            this.textBox_WFScaling5.Text = "1";
            this.textBox_WFScaling5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(7, 165);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(33, 17);
            this.label129.TabIndex = 16;
            this.label129.Text = "Ch 5";
            // 
            // textBox_WFScaling4
            // 
            this.textBox_WFScaling4.Location = new System.Drawing.Point(42, 136);
            this.textBox_WFScaling4.Name = "textBox_WFScaling4";
            this.textBox_WFScaling4.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling4.TabIndex = 20;
            this.textBox_WFScaling4.Text = "1";
            this.textBox_WFScaling4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(7, 113);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(33, 17);
            this.label130.TabIndex = 17;
            this.label130.Text = "Ch 3";
            // 
            // textBox_WFScaling3
            // 
            this.textBox_WFScaling3.Location = new System.Drawing.Point(42, 110);
            this.textBox_WFScaling3.Name = "textBox_WFScaling3";
            this.textBox_WFScaling3.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling3.TabIndex = 19;
            this.textBox_WFScaling3.Text = "1";
            this.textBox_WFScaling3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(7, 139);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(33, 17);
            this.label131.TabIndex = 18;
            this.label131.Text = "Ch 4";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(109, 16);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(50, 17);
            this.label127.TabIndex = 15;
            this.label127.Text = "Legend";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(49, 16);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(38, 17);
            this.label125.TabIndex = 14;
            this.label125.Text = "Scale";
            // 
            // textBoxWFLegendCh2
            // 
            this.textBoxWFLegendCh2.Location = new System.Drawing.Point(95, 84);
            this.textBoxWFLegendCh2.Name = "textBoxWFLegendCh2";
            this.textBoxWFLegendCh2.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh2.TabIndex = 13;
            this.textBoxWFLegendCh2.Text = "Voltage B";
            this.textBoxWFLegendCh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWFLegendCh1
            // 
            this.textBoxWFLegendCh1.Location = new System.Drawing.Point(95, 58);
            this.textBoxWFLegendCh1.Name = "textBoxWFLegendCh1";
            this.textBoxWFLegendCh1.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh1.TabIndex = 12;
            this.textBoxWFLegendCh1.Text = "Voltage Y";
            this.textBoxWFLegendCh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWFLegendCh0
            // 
            this.textBoxWFLegendCh0.Location = new System.Drawing.Point(95, 32);
            this.textBoxWFLegendCh0.Name = "textBoxWFLegendCh0";
            this.textBoxWFLegendCh0.Size = new System.Drawing.Size(75, 23);
            this.textBoxWFLegendCh0.TabIndex = 11;
            this.textBoxWFLegendCh0.Text = "Voltage R";
            this.textBoxWFLegendCh0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonWFPlot
            // 
            this.buttonWFPlot.Location = new System.Drawing.Point(176, 32);
            this.buttonWFPlot.Name = "buttonWFPlot";
            this.buttonWFPlot.Size = new System.Drawing.Size(98, 176);
            this.buttonWFPlot.TabIndex = 4;
            this.buttonWFPlot.Text = "Plot";
            this.buttonWFPlot.UseVisualStyleBackColor = true;
            // 
            // textBox_WFScaling2
            // 
            this.textBox_WFScaling2.Location = new System.Drawing.Point(42, 84);
            this.textBox_WFScaling2.Name = "textBox_WFScaling2";
            this.textBox_WFScaling2.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling2.TabIndex = 10;
            this.textBox_WFScaling2.Text = "0.25";
            this.textBox_WFScaling2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(7, 87);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(33, 17);
            this.label122.TabIndex = 4;
            this.label122.Text = "Ch 2";
            // 
            // textBox_WFScaling1
            // 
            this.textBox_WFScaling1.Location = new System.Drawing.Point(42, 58);
            this.textBox_WFScaling1.Name = "textBox_WFScaling1";
            this.textBox_WFScaling1.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling1.TabIndex = 9;
            this.textBox_WFScaling1.Text = "0.25";
            this.textBox_WFScaling1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(7, 35);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(33, 17);
            this.label123.TabIndex = 5;
            this.label123.Text = "Ch 0";
            // 
            // textBox_WFScaling0
            // 
            this.textBox_WFScaling0.Location = new System.Drawing.Point(42, 32);
            this.textBox_WFScaling0.Name = "textBox_WFScaling0";
            this.textBox_WFScaling0.Size = new System.Drawing.Size(47, 23);
            this.textBox_WFScaling0.TabIndex = 8;
            this.textBox_WFScaling0.Text = "0.25";
            this.textBox_WFScaling0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(7, 61);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(33, 17);
            this.label124.TabIndex = 6;
            this.label124.Text = "Ch 1";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.button_WFSave);
            this.groupBox27.Controls.Add(this.label121);
            this.groupBox27.Controls.Add(this.label120);
            this.groupBox27.Controls.Add(this.textBox_WFSaveText);
            this.groupBox27.Controls.Add(this.textBox_WFSaveFileName);
            this.groupBox27.Location = new System.Drawing.Point(18, 438);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(286, 78);
            this.groupBox27.TabIndex = 11;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Saving Image";
            // 
            // button_WFSave
            // 
            this.button_WFSave.Location = new System.Drawing.Point(193, 23);
            this.button_WFSave.Name = "button_WFSave";
            this.button_WFSave.Size = new System.Drawing.Size(80, 46);
            this.button_WFSave.TabIndex = 5;
            this.button_WFSave.Text = "Save";
            this.button_WFSave.UseVisualStyleBackColor = true;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(6, 49);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(74, 17);
            this.label121.TabIndex = 4;
            this.label121.Text = "Image Text:";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(6, 23);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(63, 17);
            this.label120.TabIndex = 3;
            this.label120.Text = "Filename:";
            // 
            // textBox_WFSaveText
            // 
            this.textBox_WFSaveText.Location = new System.Drawing.Point(90, 46);
            this.textBox_WFSaveText.Name = "textBox_WFSaveText";
            this.textBox_WFSaveText.Size = new System.Drawing.Size(97, 23);
            this.textBox_WFSaveText.TabIndex = 1;
            // 
            // textBox_WFSaveFileName
            // 
            this.textBox_WFSaveFileName.Location = new System.Drawing.Point(90, 22);
            this.textBox_WFSaveFileName.Name = "textBox_WFSaveFileName";
            this.textBox_WFSaveFileName.Size = new System.Drawing.Size(97, 23);
            this.textBox_WFSaveFileName.TabIndex = 0;
            // 
            // textBox_WFSamples
            // 
            this.textBox_WFSamples.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_WFSamples.Location = new System.Drawing.Point(740, -2);
            this.textBox_WFSamples.Multiline = true;
            this.textBox_WFSamples.Name = "textBox_WFSamples";
            this.textBox_WFSamples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_WFSamples.Size = new System.Drawing.Size(449, 133);
            this.textBox_WFSamples.TabIndex = 9;
            // 
            // textBox_WFFrame
            // 
            this.textBox_WFFrame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_WFFrame.Location = new System.Drawing.Point(310, -2);
            this.textBox_WFFrame.Multiline = true;
            this.textBox_WFFrame.Name = "textBox_WFFrame";
            this.textBox_WFFrame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_WFFrame.Size = new System.Drawing.Size(424, 133);
            this.textBox_WFFrame.TabIndex = 8;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel6);
            this.groupBox24.Controls.Add(this.checkBox_WFCh6TypeSel);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel5);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel4);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel3);
            this.groupBox24.Controls.Add(this.checkBox_WFCh5TypeSel);
            this.groupBox24.Controls.Add(this.checkBox_WFCh4TypeSel);
            this.groupBox24.Controls.Add(this.checkBox_WFCh3TypeSel);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel2);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel1);
            this.groupBox24.Controls.Add(this.textBox_WFNoOfSamples);
            this.groupBox24.Controls.Add(this.comboBox_WFSelChannel0);
            this.groupBox24.Controls.Add(this.checkBox_WFCh2TypeSel);
            this.groupBox24.Controls.Add(this.label128);
            this.groupBox24.Controls.Add(this.checkBox_WFCh1TypeSel);
            this.groupBox24.Controls.Add(this.checkBox_WFCh0TypeSel);
            this.groupBox24.Controls.Add(this.button_WFDecode);
            this.groupBox24.Controls.Add(this.button_WFCapture);
            this.groupBox24.Location = new System.Drawing.Point(18, -2);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(286, 211);
            this.groupBox24.TabIndex = 7;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Waveform Capture";
            // 
            // comboBox_WFSelChannel6
            // 
            this.comboBox_WFSelChannel6.FormattingEnabled = true;
            this.comboBox_WFSelChannel6.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel6.Location = new System.Drawing.Point(11, 179);
            this.comboBox_WFSelChannel6.Name = "comboBox_WFSelChannel6";
            this.comboBox_WFSelChannel6.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel6.TabIndex = 26;
            this.comboBox_WFSelChannel6.Text = "Channel 6";
            // 
            // checkBox_WFCh6TypeSel
            // 
            this.checkBox_WFCh6TypeSel.AutoSize = true;
            this.checkBox_WFCh6TypeSel.Location = new System.Drawing.Point(99, 181);
            this.checkBox_WFCh6TypeSel.Name = "checkBox_WFCh6TypeSel";
            this.checkBox_WFCh6TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh6TypeSel.TabIndex = 25;
            this.checkBox_WFCh6TypeSel.Text = "Raw";
            this.checkBox_WFCh6TypeSel.UseVisualStyleBackColor = true;
            // 
            // comboBox_WFSelChannel5
            // 
            this.comboBox_WFSelChannel5.FormattingEnabled = true;
            this.comboBox_WFSelChannel5.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel5.Location = new System.Drawing.Point(11, 152);
            this.comboBox_WFSelChannel5.Name = "comboBox_WFSelChannel5";
            this.comboBox_WFSelChannel5.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel5.TabIndex = 24;
            this.comboBox_WFSelChannel5.Text = "Channel 5";
            // 
            // comboBox_WFSelChannel4
            // 
            this.comboBox_WFSelChannel4.FormattingEnabled = true;
            this.comboBox_WFSelChannel4.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel4.Location = new System.Drawing.Point(11, 125);
            this.comboBox_WFSelChannel4.Name = "comboBox_WFSelChannel4";
            this.comboBox_WFSelChannel4.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel4.TabIndex = 23;
            this.comboBox_WFSelChannel4.Text = "Channel 4";
            // 
            // comboBox_WFSelChannel3
            // 
            this.comboBox_WFSelChannel3.FormattingEnabled = true;
            this.comboBox_WFSelChannel3.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel3.Location = new System.Drawing.Point(11, 98);
            this.comboBox_WFSelChannel3.Name = "comboBox_WFSelChannel3";
            this.comboBox_WFSelChannel3.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel3.TabIndex = 22;
            this.comboBox_WFSelChannel3.Text = "Channel 3";
            // 
            // checkBox_WFCh5TypeSel
            // 
            this.checkBox_WFCh5TypeSel.AutoSize = true;
            this.checkBox_WFCh5TypeSel.Location = new System.Drawing.Point(99, 154);
            this.checkBox_WFCh5TypeSel.Name = "checkBox_WFCh5TypeSel";
            this.checkBox_WFCh5TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh5TypeSel.TabIndex = 21;
            this.checkBox_WFCh5TypeSel.Text = "Raw";
            this.checkBox_WFCh5TypeSel.UseVisualStyleBackColor = true;
            // 
            // checkBox_WFCh4TypeSel
            // 
            this.checkBox_WFCh4TypeSel.AutoSize = true;
            this.checkBox_WFCh4TypeSel.Location = new System.Drawing.Point(99, 129);
            this.checkBox_WFCh4TypeSel.Name = "checkBox_WFCh4TypeSel";
            this.checkBox_WFCh4TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh4TypeSel.TabIndex = 20;
            this.checkBox_WFCh4TypeSel.Text = "Raw";
            this.checkBox_WFCh4TypeSel.UseVisualStyleBackColor = true;
            // 
            // checkBox_WFCh3TypeSel
            // 
            this.checkBox_WFCh3TypeSel.AutoSize = true;
            this.checkBox_WFCh3TypeSel.Location = new System.Drawing.Point(99, 102);
            this.checkBox_WFCh3TypeSel.Name = "checkBox_WFCh3TypeSel";
            this.checkBox_WFCh3TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh3TypeSel.TabIndex = 19;
            this.checkBox_WFCh3TypeSel.Text = "Raw";
            this.checkBox_WFCh3TypeSel.UseVisualStyleBackColor = true;
            // 
            // comboBox_WFSelChannel2
            // 
            this.comboBox_WFSelChannel2.FormattingEnabled = true;
            this.comboBox_WFSelChannel2.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel2.Location = new System.Drawing.Point(11, 71);
            this.comboBox_WFSelChannel2.Name = "comboBox_WFSelChannel2";
            this.comboBox_WFSelChannel2.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel2.TabIndex = 18;
            this.comboBox_WFSelChannel2.Text = "Channel 2";
            // 
            // comboBox_WFSelChannel1
            // 
            this.comboBox_WFSelChannel1.FormattingEnabled = true;
            this.comboBox_WFSelChannel1.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel1.Location = new System.Drawing.Point(11, 44);
            this.comboBox_WFSelChannel1.Name = "comboBox_WFSelChannel1";
            this.comboBox_WFSelChannel1.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel1.TabIndex = 17;
            this.comboBox_WFSelChannel1.Text = "Channel 1";
            // 
            // textBox_WFNoOfSamples
            // 
            this.textBox_WFNoOfSamples.Location = new System.Drawing.Point(230, 36);
            this.textBox_WFNoOfSamples.Name = "textBox_WFNoOfSamples";
            this.textBox_WFNoOfSamples.Size = new System.Drawing.Size(29, 23);
            this.textBox_WFNoOfSamples.TabIndex = 16;
            this.textBox_WFNoOfSamples.Text = "80";
            this.textBox_WFNoOfSamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_WFSelChannel0
            // 
            this.comboBox_WFSelChannel0.FormattingEnabled = true;
            this.comboBox_WFSelChannel0.Items.AddRange(new object[] {
            "None",
            "Vol R",
            "Vol Y",
            "Vol B",
            "Curr R",
            "Curr Y",
            "Curr B",
            "Curr N",
            "Vol90 R",
            "Vol90 Y",
            "Vol90 B"});
            this.comboBox_WFSelChannel0.Location = new System.Drawing.Point(11, 17);
            this.comboBox_WFSelChannel0.Name = "comboBox_WFSelChannel0";
            this.comboBox_WFSelChannel0.Size = new System.Drawing.Size(82, 24);
            this.comboBox_WFSelChannel0.TabIndex = 16;
            this.comboBox_WFSelChannel0.Text = "Channel 0";
            // 
            // checkBox_WFCh2TypeSel
            // 
            this.checkBox_WFCh2TypeSel.AutoSize = true;
            this.checkBox_WFCh2TypeSel.Location = new System.Drawing.Point(99, 75);
            this.checkBox_WFCh2TypeSel.Name = "checkBox_WFCh2TypeSel";
            this.checkBox_WFCh2TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh2TypeSel.TabIndex = 10;
            this.checkBox_WFCh2TypeSel.Text = "Raw";
            this.checkBox_WFCh2TypeSel.UseVisualStyleBackColor = true;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(221, 20);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(56, 17);
            this.label128.TabIndex = 17;
            this.label128.Text = "Samples";
            // 
            // checkBox_WFCh1TypeSel
            // 
            this.checkBox_WFCh1TypeSel.AutoSize = true;
            this.checkBox_WFCh1TypeSel.Location = new System.Drawing.Point(99, 48);
            this.checkBox_WFCh1TypeSel.Name = "checkBox_WFCh1TypeSel";
            this.checkBox_WFCh1TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh1TypeSel.TabIndex = 9;
            this.checkBox_WFCh1TypeSel.Text = "Raw";
            this.checkBox_WFCh1TypeSel.UseVisualStyleBackColor = true;
            // 
            // checkBox_WFCh0TypeSel
            // 
            this.checkBox_WFCh0TypeSel.AutoSize = true;
            this.checkBox_WFCh0TypeSel.Location = new System.Drawing.Point(99, 21);
            this.checkBox_WFCh0TypeSel.Name = "checkBox_WFCh0TypeSel";
            this.checkBox_WFCh0TypeSel.Size = new System.Drawing.Size(51, 21);
            this.checkBox_WFCh0TypeSel.TabIndex = 8;
            this.checkBox_WFCh0TypeSel.Text = "Raw";
            this.checkBox_WFCh0TypeSel.UseVisualStyleBackColor = true;
            // 
            // button_WFDecode
            // 
            this.button_WFDecode.Location = new System.Drawing.Point(193, 164);
            this.button_WFDecode.Name = "button_WFDecode";
            this.button_WFDecode.Size = new System.Drawing.Size(87, 41);
            this.button_WFDecode.TabIndex = 3;
            this.button_WFDecode.Text = "Decode";
            this.button_WFDecode.UseVisualStyleBackColor = true;
            // 
            // button_WFCapture
            // 
            this.button_WFCapture.Location = new System.Drawing.Point(193, 60);
            this.button_WFCapture.Name = "button_WFCapture";
            this.button_WFCapture.Size = new System.Drawing.Size(87, 39);
            this.button_WFCapture.TabIndex = 2;
            this.button_WFCapture.Text = "Capture";
            this.button_WFCapture.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWaveform
            // 
            this.pictureBoxWaveform.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxWaveform.Location = new System.Drawing.Point(310, 137);
            this.pictureBoxWaveform.Name = "pictureBoxWaveform";
            this.pictureBoxWaveform.Size = new System.Drawing.Size(879, 427);
            this.pictureBoxWaveform.TabIndex = 10;
            this.pictureBoxWaveform.TabStop = false;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage8.Controls.Add(this.groupBox10);
            this.tabPage8.Controls.Add(this.groupBox9);
            this.tabPage8.Controls.Add(this.groupBox8);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1206, 562);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Meter tools";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxRTCOUTTime);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.buttonRTCOUT);
            this.groupBox10.Controls.Add(this.buttonRTCCalibration);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.textBoxPPM);
            this.groupBox10.Location = new System.Drawing.Point(180, 87);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(202, 72);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "RTC";
            // 
            // textBoxRTCOUTTime
            // 
            this.textBoxRTCOUTTime.Location = new System.Drawing.Point(149, 20);
            this.textBoxRTCOUTTime.Name = "textBoxRTCOUTTime";
            this.textBoxRTCOUTTime.Size = new System.Drawing.Size(42, 23);
            this.textBoxRTCOUTTime.TabIndex = 5;
            this.textBoxRTCOUTTime.Text = "300";
            this.textBoxRTCOUTTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Time (sec)";
            // 
            // buttonRTCOUT
            // 
            this.buttonRTCOUT.Location = new System.Drawing.Point(87, 45);
            this.buttonRTCOUT.Name = "buttonRTCOUT";
            this.buttonRTCOUT.Size = new System.Drawing.Size(104, 23);
            this.buttonRTCOUT.TabIndex = 3;
            this.buttonRTCOUT.Text = "RTCOUT";
            this.buttonRTCOUT.UseVisualStyleBackColor = true;
            // 
            // buttonRTCCalibration
            // 
            this.buttonRTCCalibration.Location = new System.Drawing.Point(6, 45);
            this.buttonRTCCalibration.Name = "buttonRTCCalibration";
            this.buttonRTCCalibration.Size = new System.Drawing.Size(75, 23);
            this.buttonRTCCalibration.TabIndex = 2;
            this.buttonRTCCalibration.Text = "Calibrate";
            this.buttonRTCCalibration.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "PPM";
            // 
            // textBoxPPM
            // 
            this.textBoxPPM.Location = new System.Drawing.Point(42, 19);
            this.textBoxPPM.Name = "textBoxPPM";
            this.textBoxPPM.Size = new System.Drawing.Size(39, 23);
            this.textBoxPPM.TabIndex = 0;
            this.textBoxPPM.Text = "0";
            this.textBoxPPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonDisableLCDTest);
            this.groupBox9.Controls.Add(this.buttonAllSeg);
            this.groupBox9.Controls.Add(this.buttonOddComOddSeg);
            this.groupBox9.Controls.Add(this.buttonEvenComOddSeg);
            this.groupBox9.Controls.Add(this.buttonOddComEvenSeg);
            this.groupBox9.Controls.Add(this.buttonEvenComEvenSeg);
            this.groupBox9.Location = new System.Drawing.Point(6, 87);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(168, 93);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "LCD Test";
            // 
            // buttonDisableLCDTest
            // 
            this.buttonDisableLCDTest.Location = new System.Drawing.Point(89, 67);
            this.buttonDisableLCDTest.Name = "buttonDisableLCDTest";
            this.buttonDisableLCDTest.Size = new System.Drawing.Size(75, 23);
            this.buttonDisableLCDTest.TabIndex = 5;
            this.buttonDisableLCDTest.Text = "Disable";
            this.buttonDisableLCDTest.UseVisualStyleBackColor = true;
            // 
            // buttonAllSeg
            // 
            this.buttonAllSeg.Location = new System.Drawing.Point(7, 66);
            this.buttonAllSeg.Name = "buttonAllSeg";
            this.buttonAllSeg.Size = new System.Drawing.Size(75, 23);
            this.buttonAllSeg.TabIndex = 4;
            this.buttonAllSeg.Text = "All Segment";
            this.buttonAllSeg.UseVisualStyleBackColor = true;
            // 
            // buttonOddComOddSeg
            // 
            this.buttonOddComOddSeg.Location = new System.Drawing.Point(89, 42);
            this.buttonOddComOddSeg.Name = "buttonOddComOddSeg";
            this.buttonOddComOddSeg.Size = new System.Drawing.Size(75, 23);
            this.buttonOddComOddSeg.TabIndex = 3;
            this.buttonOddComOddSeg.Text = "OCOS";
            this.buttonOddComOddSeg.UseVisualStyleBackColor = true;
            // 
            // buttonEvenComOddSeg
            // 
            this.buttonEvenComOddSeg.Location = new System.Drawing.Point(89, 18);
            this.buttonEvenComOddSeg.Name = "buttonEvenComOddSeg";
            this.buttonEvenComOddSeg.Size = new System.Drawing.Size(75, 23);
            this.buttonEvenComOddSeg.TabIndex = 2;
            this.buttonEvenComOddSeg.Text = "ECOS";
            this.buttonEvenComOddSeg.UseVisualStyleBackColor = true;
            // 
            // buttonOddComEvenSeg
            // 
            this.buttonOddComEvenSeg.Location = new System.Drawing.Point(7, 42);
            this.buttonOddComEvenSeg.Name = "buttonOddComEvenSeg";
            this.buttonOddComEvenSeg.Size = new System.Drawing.Size(75, 23);
            this.buttonOddComEvenSeg.TabIndex = 1;
            this.buttonOddComEvenSeg.Text = "OCES";
            this.buttonOddComEvenSeg.UseVisualStyleBackColor = true;
            // 
            // buttonEvenComEvenSeg
            // 
            this.buttonEvenComEvenSeg.Location = new System.Drawing.Point(7, 18);
            this.buttonEvenComEvenSeg.Name = "buttonEvenComEvenSeg";
            this.buttonEvenComEvenSeg.Size = new System.Drawing.Size(75, 23);
            this.buttonEvenComEvenSeg.TabIndex = 0;
            this.buttonEvenComEvenSeg.Text = "ECES";
            this.buttonEvenComEvenSeg.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelFirmwareFileSize);
            this.groupBox8.Controls.Add(this.labelBootloaderFileSize);
            this.groupBox8.Controls.Add(this.textBoxFirmwarePath);
            this.groupBox8.Controls.Add(this.textBoxBootloaderPath);
            this.groupBox8.Controls.Add(this.buttonBootCreate);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(4, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(365, 75);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Boot File Creator";
            // 
            // labelFirmwareFileSize
            // 
            this.labelFirmwareFileSize.AutoSize = true;
            this.labelFirmwareFileSize.Location = new System.Drawing.Point(205, 49);
            this.labelFirmwareFileSize.Name = "labelFirmwareFileSize";
            this.labelFirmwareFileSize.Size = new System.Drawing.Size(54, 17);
            this.labelFirmwareFileSize.TabIndex = 8;
            this.labelFirmwareFileSize.Text = "File Size";
            // 
            // labelBootloaderFileSize
            // 
            this.labelBootloaderFileSize.AutoSize = true;
            this.labelBootloaderFileSize.Location = new System.Drawing.Point(205, 24);
            this.labelBootloaderFileSize.Name = "labelBootloaderFileSize";
            this.labelBootloaderFileSize.Size = new System.Drawing.Size(54, 17);
            this.labelBootloaderFileSize.TabIndex = 7;
            this.labelBootloaderFileSize.Text = "File Size";
            // 
            // textBoxFirmwarePath
            // 
            this.textBoxFirmwarePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFirmwarePath.Location = new System.Drawing.Point(81, 46);
            this.textBoxFirmwarePath.Name = "textBoxFirmwarePath";
            this.textBoxFirmwarePath.Size = new System.Drawing.Size(116, 23);
            this.textBoxFirmwarePath.TabIndex = 6;
            this.textBoxFirmwarePath.Text = "double click";
            this.textBoxFirmwarePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBootloaderPath
            // 
            this.textBoxBootloaderPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxBootloaderPath.Location = new System.Drawing.Point(81, 20);
            this.textBoxBootloaderPath.Name = "textBoxBootloaderPath";
            this.textBoxBootloaderPath.Size = new System.Drawing.Size(116, 23);
            this.textBoxBootloaderPath.TabIndex = 5;
            this.textBoxBootloaderPath.Text = "double click";
            this.textBoxBootloaderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBootCreate
            // 
            this.buttonBootCreate.Location = new System.Drawing.Point(282, 20);
            this.buttonBootCreate.Name = "buttonBootCreate";
            this.buttonBootCreate.Size = new System.Drawing.Size(75, 49);
            this.buttonBootCreate.TabIndex = 4;
            this.buttonBootCreate.Text = "Create";
            this.buttonBootCreate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Firmware";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bootloader";
            // 
            // timer1sec
            // 
            this.timer1sec.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBarSerialConnection);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Developers Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveform)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeUsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarSerialConnection;
        private System.Windows.Forms.Timer timer10ms;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_SendFrame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.CheckBox checkBox_SendRepeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SendRepeatTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SendRepeatNoOfTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SendRepeatSentCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ToolsInputString;
        private System.Windows.Forms.RadioButton radioButtonToolsInputTextBoxASCII;
        private System.Windows.Forms.RadioButton radioButtonToolsInputTextBoxHEX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radiobuttonToolsOutputTextBoxHEXSpaced;
        private System.Windows.Forms.RadioButton radiobuttonToolsOutputTextBoxASCII;
        private System.Windows.Forms.RadioButton radiobuttonToolsOutputTextBoxHEX;
        private System.Windows.Forms.TextBox textBox_ToolsOutputString;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonStringFilterConvert;
        private System.Windows.Forms.CheckBox checkBoxStringFilterRemoveHEX;
        private System.Windows.Forms.CheckBox checkBoxStringFilterRemoveTab;
        private System.Windows.Forms.CheckBox checkBoxStringFilterRemoveLF;
        private System.Windows.Forms.CheckBox checkBoxStringFilterRemoveCR;
        private System.Windows.Forms.CheckBox checkBoxStringFilterRemoveSpace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonWordwrapConvert;
        private System.Windows.Forms.TextBox textBoxWordwrapLength;
        private System.Windows.Forms.Button buttonToolsInputTextBoxPaste;
        private System.Windows.Forms.Button buttonToolsInputTextBoxClear;
        private System.Windows.Forms.Button buttonToolsOutputTextBoxCopy;
        private System.Windows.Forms.Button buttonToolsOutputTextBoxClear;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_DataTraffic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_DataTrafficClear;
        private System.Windows.Forms.TextBox textBox_DataTrafficTxBytesTotal;
        private System.Windows.Forms.RadioButton radioButton_DataTrafficFormatHEXSpaced;
        private System.Windows.Forms.RadioButton radioButton_DataTrafficFormatASCII;
        private System.Windows.Forms.RadioButton radioButton_DataTrafficFormatHEX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DataTrafficRxBytesTotal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox_SendFrameHDLC;
        private System.Windows.Forms.Button button_SendFrameClear;
        private System.Windows.Forms.Button button_SendFramePaste;
        private System.Windows.Forms.Button button_DataTrafficCopy;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labelFirmwareFileSize;
        private System.Windows.Forms.Label labelBootloaderFileSize;
        private System.Windows.Forms.TextBox textBoxFirmwarePath;
        private System.Windows.Forms.TextBox textBoxBootloaderPath;
        private System.Windows.Forms.Button buttonBootCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox textBoxCalPhaseCorrSamplesR;
        private System.Windows.Forms.Button button_SaveCalData;
        private System.Windows.Forms.TextBox textBoxCalPhaseCorrSamplesB;
        private System.Windows.Forms.TextBox textBox_SaveCalDataFileName;
        private System.Windows.Forms.TextBox textBoxCalPhaseCorrSamplesY;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox textBoxNeuCalButtonPressTime;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox textBoxNeuCalDisplayTime;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxNeuCalCounter;
        private System.Windows.Forms.TextBox textBoxNeuCalTime;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Button buttonPasteData;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBoxRTCPPMSigned;
        private System.Windows.Forms.TextBox textBoxRTCCalSec;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxRTCRADJ;
        private System.Windows.Forms.TextBox textBoxRTCCalSign;
        private System.Windows.Forms.TextBox textBoxRTCCalTime;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxRTCCalDoneF;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox textBoxCalTempPhase;
        private System.Windows.Forms.TextBox textBoxPhaseCalbuttonPressTime;
        private System.Windows.Forms.TextBox textBoxPhaseCalDisplayTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxCalDoneF;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxPhaseCalTime;
        private System.Windows.Forms.TextBox textBoxPhaseCalCounter;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox textBoxMeasFreqNet;
        private System.Windows.Forms.TextBox textBoxMeasFreqY;
        private System.Windows.Forms.TextBox textBoxMeasFreqB;
        private System.Windows.Forms.TextBox textBoxMeasFreqR;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxMeasV90IY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxMeasV90IB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMeasV90IR;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxMeasVIY;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxMeasVIB;
        private System.Windows.Forms.TextBox textBoxMeasVIR;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxMeasVolR;
        private System.Windows.Forms.TextBox textBoxMeasVolB;
        private System.Windows.Forms.TextBox textBoxMeasVolY;
        private System.Windows.Forms.TextBox textBoxMeasCurrR;
        private System.Windows.Forms.TextBox textBoxMeasCurrB;
        private System.Windows.Forms.TextBox textBoxMeasCurrY;
        private System.Windows.Forms.TextBox textBoxMeasPFR;
        private System.Windows.Forms.TextBox textBoxMeasPFB;
        private System.Windows.Forms.TextBox textBoxMeasPFY;
        private System.Windows.Forms.TextBox textBoxMeasWattR;
        private System.Windows.Forms.TextBox textBoxMeasWattB;
        private System.Windows.Forms.TextBox textBoxMeasCurrN;
        private System.Windows.Forms.TextBox textBoxMeasWattY;
        private System.Windows.Forms.TextBox textBoxMeasVARR;
        private System.Windows.Forms.TextBox textBoxMeasVAY;
        private System.Windows.Forms.TextBox textBoxMeasVARB;
        private System.Windows.Forms.TextBox textBoxMeasVARY;
        private System.Windows.Forms.TextBox textBoxMeasVAB;
        private System.Windows.Forms.TextBox textBoxMeasVAR;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxCalVolR;
        private System.Windows.Forms.TextBox textBoxCalVolB;
        private System.Windows.Forms.TextBox textBoxCalVolY;
        private System.Windows.Forms.TextBox textBoxCalCurrR;
        private System.Windows.Forms.TextBox textBoxCalCurrB;
        private System.Windows.Forms.TextBox textBoxCalCurrY;
        private System.Windows.Forms.TextBox textBoxCalPowR;
        private System.Windows.Forms.TextBox textBoxCalPowB;
        private System.Windows.Forms.TextBox textBoxCalPowY;
        private System.Windows.Forms.TextBox textBoxCalVolOffR;
        private System.Windows.Forms.TextBox textBoxCalVolOffB;
        private System.Windows.Forms.TextBox textBoxCalVolOffY;
        private System.Windows.Forms.TextBox textBoxCalCurrOffR;
        private System.Windows.Forms.TextBox textBoxCalCurrOffB;
        private System.Windows.Forms.TextBox textBoxCalCurrOffY;
        private System.Windows.Forms.TextBox textBoxCalPhaseR;
        private System.Windows.Forms.TextBox textBoxCalPhaseB;
        private System.Windows.Forms.TextBox textBoxCalPhaseY;
        private System.Windows.Forms.TextBox textBoxCalCurrN;
        private System.Windows.Forms.TextBox textBoxCalCurrOffN;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.TextBox textBoxWFLegendCh6;
        private System.Windows.Forms.TextBox textBox_WFScaling6;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox textBoxWFLegendCh5;
        private System.Windows.Forms.TextBox textBoxWFLegendCh4;
        private System.Windows.Forms.TextBox textBoxWFLegendCh3;
        private System.Windows.Forms.TextBox textBox_WFScaling5;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.TextBox textBox_WFScaling4;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.TextBox textBox_WFScaling3;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.TextBox textBoxWFLegendCh2;
        private System.Windows.Forms.TextBox textBoxWFLegendCh1;
        private System.Windows.Forms.TextBox textBoxWFLegendCh0;
        private System.Windows.Forms.Button buttonWFPlot;
        private System.Windows.Forms.TextBox textBox_WFScaling2;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox textBox_WFScaling1;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox textBox_WFScaling0;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button button_WFSave;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.TextBox textBox_WFSaveText;
        private System.Windows.Forms.TextBox textBox_WFSaveFileName;
        private System.Windows.Forms.PictureBox pictureBoxWaveform;
        private System.Windows.Forms.TextBox textBox_WFSamples;
        private System.Windows.Forms.TextBox textBox_WFFrame;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel6;
        private System.Windows.Forms.CheckBox checkBox_WFCh6TypeSel;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel5;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel4;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel3;
        private System.Windows.Forms.CheckBox checkBox_WFCh5TypeSel;
        private System.Windows.Forms.CheckBox checkBox_WFCh4TypeSel;
        private System.Windows.Forms.CheckBox checkBox_WFCh3TypeSel;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel2;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel1;
        private System.Windows.Forms.TextBox textBox_WFNoOfSamples;
        private System.Windows.Forms.ComboBox comboBox_WFSelChannel0;
        private System.Windows.Forms.CheckBox checkBox_WFCh2TypeSel;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.CheckBox checkBox_WFCh1TypeSel;
        private System.Windows.Forms.CheckBox checkBox_WFCh0TypeSel;
        private System.Windows.Forms.Button button_WFDecode;
        private System.Windows.Forms.Button button_WFCapture;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxRTCOUTTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRTCOUT;
        private System.Windows.Forms.Button buttonRTCCalibration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPPM;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonDisableLCDTest;
        private System.Windows.Forms.Button buttonAllSeg;
        private System.Windows.Forms.Button buttonOddComOddSeg;
        private System.Windows.Forms.Button buttonEvenComOddSeg;
        private System.Windows.Forms.Button buttonOddComEvenSeg;
        private System.Windows.Forms.Button buttonEvenComEvenSeg;
        private System.Windows.Forms.TextBox textBox_TamperStatus;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox textBox_EnergyWhTotalFunda;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox textBox_EnergyWhR;
        private System.Windows.Forms.TextBox textBox_EnergyWhY;
        private System.Windows.Forms.TextBox textBox_EnergyWhB;
        private System.Windows.Forms.TextBox textBox_EnergyWhTotal;
        private System.Windows.Forms.TextBox textBox_EnergyVARhLagTotal;
        private System.Windows.Forms.TextBox textBox_EnergyVARhLeadTotal;
        private System.Windows.Forms.TextBox textBox_EnergyVAhTotal;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.TextBox textBox_MISCData;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox textBox_LoopCycles;
        private System.Windows.Forms.TextBox textBox_THDIb;
        private System.Windows.Forms.TextBox textBox_THDIy;
        private System.Windows.Forms.TextBox textBox_THDIr;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox textBox_THDVb;
        private System.Windows.Forms.TextBox textBox_THDVy;
        private System.Windows.Forms.TextBox textBox_THDVr;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TextBox textBox_ReactiveTimeDeviation;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox textBox_ReactiveTimeDelay;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox textBox_ReactiveTimer;
        private System.Windows.Forms.TextBox textBox_ReactiveSamples;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textBox_BatteryVoltage;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox textBox_TempTLV;
        private System.Windows.Forms.Label labelMetrologyTimer;
        private System.Windows.Forms.TextBox textBox_SamplesPerSec;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox_VolRY;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox textBox_AngleBR;
        private System.Windows.Forms.TextBox textBox_VolBR;
        private System.Windows.Forms.TextBox textBox_AngleYB;
        private System.Windows.Forms.TextBox textBox_VolYB;
        private System.Windows.Forms.TextBox textBox_AngleRY;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox textBox_ErrorAppB;
        private System.Windows.Forms.TextBox textBox_ErrorAppY;
        private System.Windows.Forms.TextBox textBox_ErrorAppTotal;
        private System.Windows.Forms.TextBox textBox_ErrorAppR;
        private System.Windows.Forms.TextBox textBox_ErrorReactB;
        private System.Windows.Forms.TextBox textBox_ErrorReactY;
        private System.Windows.Forms.TextBox textBox_ErrorReactTotal;
        private System.Windows.Forms.TextBox textBox_ErrorReactR;
        private System.Windows.Forms.TextBox textBox_ErrorActB;
        private System.Windows.Forms.TextBox textBox_ErrorActY;
        private System.Windows.Forms.TextBox textBox_ErrorActTotal;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox textBox_ErrorActR;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button button_ShowVectorDiagram;
        private System.Windows.Forms.TextBox textBox_AnglePFBph;
        private System.Windows.Forms.TextBox textBox_AnglePFYph;
        private System.Windows.Forms.TextBox textBox_AnglePFRph;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox textBox_SamplesB;
        private System.Windows.Forms.TextBox textBox_SamplesY;
        private System.Windows.Forms.TextBox textBox_SamplesR;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox textBox_AngleNeuVector;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox textBox_CurrNeuVector;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox textBox_SamplesN;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox textBox_CurrN;
        private System.Windows.Forms.TextBox textBox_CurrNdc;
        private System.Windows.Forms.TextBox textBox_CalAngleReactB;
        private System.Windows.Forms.TextBox textBox_CalAngleReactY;
        private System.Windows.Forms.TextBox textBox_CalAngleReactR;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_QuadB;
        private System.Windows.Forms.TextBox textBox_FreqB;
        private System.Windows.Forms.TextBox textBox_VAB;
        private System.Windows.Forms.TextBox textBox_VARB;
        private System.Windows.Forms.TextBox textBox_WattB;
        private System.Windows.Forms.TextBox textBox_CalAngleActB;
        private System.Windows.Forms.TextBox textBox_PFB;
        private System.Windows.Forms.TextBox textBox_CurrBdc;
        private System.Windows.Forms.TextBox textBox_CurrB;
        private System.Windows.Forms.TextBox textBox_VolBdc;
        private System.Windows.Forms.TextBox textBox_VolB;
        private System.Windows.Forms.TextBox textBox_QuadY;
        private System.Windows.Forms.TextBox textBox_FreqY;
        private System.Windows.Forms.TextBox textBox_VAY;
        private System.Windows.Forms.TextBox textBox_VARY;
        private System.Windows.Forms.TextBox textBox_WattY;
        private System.Windows.Forms.TextBox textBox_CalAngleActY;
        private System.Windows.Forms.TextBox textBox_PFY;
        private System.Windows.Forms.TextBox textBox_CurrYdc;
        private System.Windows.Forms.TextBox textBox_CurrY;
        private System.Windows.Forms.TextBox textBox_VolYdc;
        private System.Windows.Forms.TextBox textBox_VolY;
        private System.Windows.Forms.TextBox textBox_QuadNet;
        private System.Windows.Forms.TextBox textBox_FreqNet;
        private System.Windows.Forms.TextBox textBox_VANet;
        private System.Windows.Forms.TextBox textBox_VARNet;
        private System.Windows.Forms.TextBox textBox_WattNet;
        private System.Windows.Forms.TextBox textBox_PFNet;
        private System.Windows.Forms.TextBox textBox_QuadR;
        private System.Windows.Forms.TextBox textBox_FreqR;
        private System.Windows.Forms.TextBox textBox_VAR;
        private System.Windows.Forms.TextBox textBox_VARR;
        private System.Windows.Forms.TextBox textBox_WattR;
        private System.Windows.Forms.TextBox textBox_CalAngleActR;
        private System.Windows.Forms.TextBox textBox_PFR;
        private System.Windows.Forms.TextBox textBox_CurrRdc;
        private System.Windows.Forms.TextBox textBox_CurrR;
        private System.Windows.Forms.TextBox textBox_VolRdc;
        private System.Windows.Forms.TextBox textBox_VolR;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox textBox_inputAngleYB;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox textBox_inputNeutralVectorAngle;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox textBox_inputNeutralVectorCurrent;
        private System.Windows.Forms.Button button_inputUpdate;
        private System.Windows.Forms.CheckBox checkBox_CalculateAccuracy;
        private System.Windows.Forms.TextBox textBox_inputFreq;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox textBox_inputAngleBR;
        private System.Windows.Forms.TextBox textBox_AvgAccuracySamples;
        private System.Windows.Forms.TextBox textBox_inputAngleRY;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox textBox_inputPFNet;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox textBox_inputVANet;
        private System.Windows.Forms.TextBox textBox_inputVARNet;
        private System.Windows.Forms.TextBox textBox_inputWattNet;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox textBox_inputVATotal;
        private System.Windows.Forms.TextBox textBox_inputVARTotal;
        private System.Windows.Forms.TextBox textBox_inputWattTotal;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TextBox textBox_inputVAB;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox textBox_inputVARB;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox textBox_inputWattB;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox textBox_inputVAY;
        private System.Windows.Forms.TextBox textBox_inputVARY;
        private System.Windows.Forms.TextBox textBox_inputWattY;
        private System.Windows.Forms.TextBox textBox_inputVAR;
        private System.Windows.Forms.TextBox textBox_inputVARR;
        private System.Windows.Forms.TextBox textBox_inputWattR;
        private System.Windows.Forms.TextBox textBox_inputAngleB;
        private System.Windows.Forms.TextBox textBox_inputAngleY;
        private System.Windows.Forms.TextBox textBox_inputAngleR;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox textBox_inputPFB;
        private System.Windows.Forms.TextBox textBox_inputCurrB;
        private System.Windows.Forms.TextBox textBox_inputVolB;
        private System.Windows.Forms.TextBox textBox_inputPFY;
        private System.Windows.Forms.TextBox textBox_inputCurrY;
        private System.Windows.Forms.TextBox textBox_inputVolY;
        private System.Windows.Forms.TextBox textBox_inputPFR;
        private System.Windows.Forms.TextBox textBox_inputCurrR;
        private System.Windows.Forms.TextBox textBox_inputVolR;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button button_iStop;
        private System.Windows.Forms.TextBox textBox_NewFileName;
        private System.Windows.Forms.CheckBox checkBox_LogToNewFile;
        private System.Windows.Forms.Button button_iRead;
        private System.Windows.Forms.CheckBox checkBox_iAutoRead;
        private System.Windows.Forms.Label label_iAutoreadLabel;
        private System.Windows.Forms.CheckBox checkBox_LogData;
        private System.Windows.Forms.TextBox textBox_iAutoReadTime;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveJSONFileDialog;
        private System.Windows.Forms.OpenFileDialog openJSONFileDialog;
        private System.Windows.Forms.TextBox textBoxStringFilterRemoveHEX;
        private System.Windows.Forms.ToolStripMenuItem miscelleToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_SendFrameFormatASCII;
        private System.Windows.Forms.RadioButton radioButton_SendFrameFormatHex;
        private System.Windows.Forms.Timer timer1sec;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ToolsCalculateChecksum;
        private System.Windows.Forms.TextBox textBox_ToolsChecksumCRC16;
        private System.Windows.Forms.TextBox textBox_ToolsChecksumBCCXOR;
        private System.Windows.Forms.TextBox textBox_ToolsChecksumMemory;
        private System.Windows.Forms.RadioButton radioButtonToolsInputTextBoxHEXSpaced;
    }
}

