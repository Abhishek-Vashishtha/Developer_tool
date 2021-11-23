
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
            this.ToolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar_connectionStatus = new System.Windows.Forms.ProgressBar();
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
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.comboBox_SerialSingleBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_SerialSingleCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton_CommunicationSerial = new System.Windows.Forms.RadioButton();
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
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.checkBox_EnergyMeterShowVectorDiagram = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label155 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label160 = new System.Windows.Forms.Label();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label162 = new System.Windows.Forms.Label();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label165 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.label171 = new System.Windows.Forms.Label();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.textBox105 = new System.Windows.Forms.TextBox();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.textBox117 = new System.Windows.Forms.TextBox();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.textBox119 = new System.Windows.Forms.TextBox();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.textBox125 = new System.Windows.Forms.TextBox();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.textBox127 = new System.Windows.Forms.TextBox();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.textBox130 = new System.Windows.Forms.TextBox();
            this.textBox131 = new System.Windows.Forms.TextBox();
            this.textBox132 = new System.Windows.Forms.TextBox();
            this.textBox133 = new System.Windows.Forms.TextBox();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.textBox138 = new System.Windows.Forms.TextBox();
            this.textBox139 = new System.Windows.Forms.TextBox();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.textBox141 = new System.Windows.Forms.TextBox();
            this.textBox142 = new System.Windows.Forms.TextBox();
            this.textBox143 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox144 = new System.Windows.Forms.TextBox();
            this.textBox145 = new System.Windows.Forms.TextBox();
            this.textBox146 = new System.Windows.Forms.TextBox();
            this.textBox147 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox148 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox149 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox152 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox153 = new System.Windows.Forms.TextBox();
            this.textBox154 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.textBox_MISCData = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.textBox_LoopCycles = new System.Windows.Forms.TextBox();
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
            this.textBox_TempTLV = new System.Windows.Forms.TextBox();
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
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
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
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
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
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem1
            // 
            this.connectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Connect,
            this.ToolStripMenuItem_Disconnect});
            this.connectionToolStripMenuItem1.Name = "connectionToolStripMenuItem1";
            this.connectionToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem1.Text = "Connection";
            // 
            // ToolStripMenuItem_Connect
            // 
            this.ToolStripMenuItem_Connect.Name = "ToolStripMenuItem_Connect";
            this.ToolStripMenuItem_Connect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Connect.Text = "Connect";
            this.ToolStripMenuItem_Connect.Click += new System.EventHandler(this.ToolStripMenuItem_Connect_Click);
            // 
            // ToolStripMenuItem_Disconnect
            // 
            this.ToolStripMenuItem_Disconnect.Name = "ToolStripMenuItem_Disconnect";
            this.ToolStripMenuItem_Disconnect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Disconnect.Text = "Disconnect";
            this.ToolStripMenuItem_Disconnect.Click += new System.EventHandler(this.ToolStripMenuItem_Disconnect_Click);
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
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.webPageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.webPageToolStripMenuItem.Text = "Project Page";
            this.webPageToolStripMenuItem.Click += new System.EventHandler(this.webPageToolStripMenuItem_Click);
            // 
            // writeUsToolStripMenuItem
            // 
            this.writeUsToolStripMenuItem.Name = "writeUsToolStripMenuItem";
            this.writeUsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.writeUsToolStripMenuItem.Text = "Write Us";
            this.writeUsToolStripMenuItem.Click += new System.EventHandler(this.writeUsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progressBar_connectionStatus
            // 
            this.progressBar_connectionStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_connectionStatus.Location = new System.Drawing.Point(967, 1);
            this.progressBar_connectionStatus.Name = "progressBar_connectionStatus";
            this.progressBar_connectionStatus.Size = new System.Drawing.Size(255, 23);
            this.progressBar_connectionStatus.TabIndex = 1;
            // 
            // timer10ms
            // 
            this.timer10ms.Interval = 10;
            this.timer10ms.Tick += new System.EventHandler(this.timer10ms_Tick);
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
            this.tabControl2.Controls.Add(this.tabPage9);
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
            this.checkBox_SendFrameHDLC.Size = new System.Drawing.Size(149, 21);
            this.checkBox_SendFrameHDLC.TabIndex = 16;
            this.checkBox_SendFrameHDLC.Text = "Create HDLC Frame?";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "times: ";
            // 
            // textBox_SendRepeatNoOfTimes
            // 
            this.textBox_SendRepeatNoOfTimes.Location = new System.Drawing.Point(295, 21);
            this.textBox_SendRepeatNoOfTimes.Name = "textBox_SendRepeatNoOfTimes";
            this.textBox_SendRepeatNoOfTimes.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatNoOfTimes.TabIndex = 4;
            this.textBox_SendRepeatNoOfTimes.Text = "100";
            this.textBox_SendRepeatNoOfTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "time (ms):";
            // 
            // textBox_SendRepeatTime
            // 
            this.textBox_SendRepeatTime.Location = new System.Drawing.Point(193, 21);
            this.textBox_SendRepeatTime.Name = "textBox_SendRepeatTime";
            this.textBox_SendRepeatTime.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatTime.TabIndex = 2;
            this.textBox_SendRepeatTime.Text = "1000";
            this.textBox_SendRepeatTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage9.Controls.Add(this.groupBox28);
            this.tabPage9.Controls.Add(this.groupBox26);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(599, 566);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Setup";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.comboBox_SerialSingleBaudRate);
            this.groupBox28.Controls.Add(this.comboBox_SerialSingleCOMPORT);
            this.groupBox28.Location = new System.Drawing.Point(7, 95);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(586, 62);
            this.groupBox28.TabIndex = 1;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Serial (Single Port)";
            // 
            // comboBox_SerialSingleBaudRate
            // 
            this.comboBox_SerialSingleBaudRate.FormattingEnabled = true;
            this.comboBox_SerialSingleBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_SerialSingleBaudRate.Location = new System.Drawing.Point(86, 22);
            this.comboBox_SerialSingleBaudRate.Name = "comboBox_SerialSingleBaudRate";
            this.comboBox_SerialSingleBaudRate.Size = new System.Drawing.Size(73, 24);
            this.comboBox_SerialSingleBaudRate.TabIndex = 1;
            this.comboBox_SerialSingleBaudRate.Text = "9600";
            // 
            // comboBox_SerialSingleCOMPORT
            // 
            this.comboBox_SerialSingleCOMPORT.FormattingEnabled = true;
            this.comboBox_SerialSingleCOMPORT.Location = new System.Drawing.Point(7, 22);
            this.comboBox_SerialSingleCOMPORT.Name = "comboBox_SerialSingleCOMPORT";
            this.comboBox_SerialSingleCOMPORT.Size = new System.Drawing.Size(73, 24);
            this.comboBox_SerialSingleCOMPORT.TabIndex = 0;
            this.comboBox_SerialSingleCOMPORT.Text = "Select";
            this.comboBox_SerialSingleCOMPORT.Click += new System.EventHandler(this.comboBox_SerialSingleCOMPORT_Click);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.radioButton1);
            this.groupBox26.Controls.Add(this.radioButton_CommunicationSerial);
            this.groupBox26.Location = new System.Drawing.Point(7, 7);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(586, 82);
            this.groupBox26.TabIndex = 0;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Communication mode";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(7, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Serial (Multi Port)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton_CommunicationSerial
            // 
            this.radioButton_CommunicationSerial.AutoSize = true;
            this.radioButton_CommunicationSerial.Checked = true;
            this.radioButton_CommunicationSerial.Location = new System.Drawing.Point(7, 23);
            this.radioButton_CommunicationSerial.Name = "radioButton_CommunicationSerial";
            this.radioButton_CommunicationSerial.Size = new System.Drawing.Size(129, 21);
            this.radioButton_CommunicationSerial.TabIndex = 0;
            this.radioButton_CommunicationSerial.TabStop = true;
            this.radioButton_CommunicationSerial.Text = "Serial (Single Port)";
            this.radioButton_CommunicationSerial.UseVisualStyleBackColor = true;
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
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1214, 591);
            this.tabControl3.TabIndex = 0;
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
            this.timer1sec.Tick += new System.EventHandler(this.timer1sec_Tick);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage10.Controls.Add(this.checkBox_EnergyMeterShowVectorDiagram);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1206, 562);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "Vector Diagram";
            // 
            // checkBox_EnergyMeterShowVectorDiagram
            // 
            this.checkBox_EnergyMeterShowVectorDiagram.AutoSize = true;
            this.checkBox_EnergyMeterShowVectorDiagram.Location = new System.Drawing.Point(8, 7);
            this.checkBox_EnergyMeterShowVectorDiagram.Name = "checkBox_EnergyMeterShowVectorDiagram";
            this.checkBox_EnergyMeterShowVectorDiagram.Size = new System.Drawing.Size(149, 21);
            this.checkBox_EnergyMeterShowVectorDiagram.TabIndex = 0;
            this.checkBox_EnergyMeterShowVectorDiagram.Text = "Show Vector Diagram";
            this.checkBox_EnergyMeterShowVectorDiagram.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage11.Controls.Add(this.groupBox17);
            this.tabPage11.Controls.Add(this.textBox_MISCData);
            this.tabPage11.Controls.Add(this.groupBox21);
            this.tabPage11.Controls.Add(this.groupBox18);
            this.tabPage11.Controls.Add(this.label66);
            this.tabPage11.Controls.Add(this.textBox155);
            this.tabPage11.Controls.Add(this.label55);
            this.tabPage11.Controls.Add(this.textBox_Time);
            this.tabPage11.Controls.Add(this.groupBox16);
            this.tabPage11.Controls.Add(this.groupBox15);
            this.tabPage11.Controls.Add(this.textBox140);
            this.tabPage11.Controls.Add(this.textBox141);
            this.tabPage11.Controls.Add(this.textBox142);
            this.tabPage11.Controls.Add(this.textBox143);
            this.tabPage11.Controls.Add(this.label44);
            this.tabPage11.Controls.Add(this.textBox144);
            this.tabPage11.Controls.Add(this.textBox145);
            this.tabPage11.Controls.Add(this.textBox146);
            this.tabPage11.Controls.Add(this.textBox147);
            this.tabPage11.Controls.Add(this.label46);
            this.tabPage11.Controls.Add(this.textBox136);
            this.tabPage11.Controls.Add(this.textBox137);
            this.tabPage11.Controls.Add(this.textBox138);
            this.tabPage11.Controls.Add(this.textBox139);
            this.tabPage11.Controls.Add(this.textBox132);
            this.tabPage11.Controls.Add(this.textBox133);
            this.tabPage11.Controls.Add(this.textBox134);
            this.tabPage11.Controls.Add(this.textBox135);
            this.tabPage11.Controls.Add(this.textBox128);
            this.tabPage11.Controls.Add(this.textBox129);
            this.tabPage11.Controls.Add(this.textBox130);
            this.tabPage11.Controls.Add(this.textBox131);
            this.tabPage11.Controls.Add(this.textBox124);
            this.tabPage11.Controls.Add(this.textBox125);
            this.tabPage11.Controls.Add(this.textBox126);
            this.tabPage11.Controls.Add(this.textBox127);
            this.tabPage11.Controls.Add(this.textBox120);
            this.tabPage11.Controls.Add(this.textBox121);
            this.tabPage11.Controls.Add(this.textBox122);
            this.tabPage11.Controls.Add(this.textBox123);
            this.tabPage11.Controls.Add(this.textBox113);
            this.tabPage11.Controls.Add(this.textBox114);
            this.tabPage11.Controls.Add(this.textBox115);
            this.tabPage11.Controls.Add(this.textBox119);
            this.tabPage11.Controls.Add(this.textBox108);
            this.tabPage11.Controls.Add(this.textBox116);
            this.tabPage11.Controls.Add(this.textBox117);
            this.tabPage11.Controls.Add(this.textBox118);
            this.tabPage11.Controls.Add(this.label61);
            this.tabPage11.Controls.Add(this.label54);
            this.tabPage11.Controls.Add(this.label53);
            this.tabPage11.Controls.Add(this.label52);
            this.tabPage11.Controls.Add(this.label51);
            this.tabPage11.Controls.Add(this.label50);
            this.tabPage11.Controls.Add(this.label49);
            this.tabPage11.Controls.Add(this.textBox109);
            this.tabPage11.Controls.Add(this.textBox110);
            this.tabPage11.Controls.Add(this.textBox111);
            this.tabPage11.Controls.Add(this.textBox112);
            this.tabPage11.Controls.Add(this.label45);
            this.tabPage11.Controls.Add(this.textBox56);
            this.tabPage11.Controls.Add(this.groupBox30);
            this.tabPage11.Controls.Add(this.textBox1);
            this.tabPage11.Controls.Add(this.textBox2);
            this.tabPage11.Controls.Add(this.textBox3);
            this.tabPage11.Controls.Add(this.label126);
            this.tabPage11.Controls.Add(this.textBox4);
            this.tabPage11.Controls.Add(this.textBox5);
            this.tabPage11.Controls.Add(this.textBox6);
            this.tabPage11.Controls.Add(this.label133);
            this.tabPage11.Controls.Add(this.textBox7);
            this.tabPage11.Controls.Add(this.textBox8);
            this.tabPage11.Controls.Add(this.textBox9);
            this.tabPage11.Controls.Add(this.textBox10);
            this.tabPage11.Controls.Add(this.label134);
            this.tabPage11.Controls.Add(this.textBox11);
            this.tabPage11.Controls.Add(this.textBox12);
            this.tabPage11.Controls.Add(this.textBox13);
            this.tabPage11.Controls.Add(this.label135);
            this.tabPage11.Controls.Add(this.textBox14);
            this.tabPage11.Controls.Add(this.textBox15);
            this.tabPage11.Controls.Add(this.textBox16);
            this.tabPage11.Controls.Add(this.label136);
            this.tabPage11.Controls.Add(this.textBox17);
            this.tabPage11.Controls.Add(this.textBox18);
            this.tabPage11.Controls.Add(this.textBox19);
            this.tabPage11.Controls.Add(this.textBox20);
            this.tabPage11.Controls.Add(this.textBox21);
            this.tabPage11.Controls.Add(this.textBox22);
            this.tabPage11.Controls.Add(this.textBox23);
            this.tabPage11.Controls.Add(this.textBox24);
            this.tabPage11.Controls.Add(this.textBox25);
            this.tabPage11.Controls.Add(this.textBox26);
            this.tabPage11.Controls.Add(this.textBox27);
            this.tabPage11.Controls.Add(this.textBox28);
            this.tabPage11.Controls.Add(this.textBox29);
            this.tabPage11.Controls.Add(this.textBox30);
            this.tabPage11.Controls.Add(this.textBox31);
            this.tabPage11.Controls.Add(this.textBox32);
            this.tabPage11.Controls.Add(this.textBox33);
            this.tabPage11.Controls.Add(this.textBox34);
            this.tabPage11.Controls.Add(this.textBox35);
            this.tabPage11.Controls.Add(this.textBox36);
            this.tabPage11.Controls.Add(this.textBox37);
            this.tabPage11.Controls.Add(this.textBox38);
            this.tabPage11.Controls.Add(this.textBox39);
            this.tabPage11.Controls.Add(this.textBox40);
            this.tabPage11.Controls.Add(this.textBox41);
            this.tabPage11.Controls.Add(this.textBox42);
            this.tabPage11.Controls.Add(this.textBox43);
            this.tabPage11.Controls.Add(this.textBox44);
            this.tabPage11.Controls.Add(this.textBox45);
            this.tabPage11.Controls.Add(this.textBox46);
            this.tabPage11.Controls.Add(this.textBox47);
            this.tabPage11.Controls.Add(this.textBox48);
            this.tabPage11.Controls.Add(this.textBox49);
            this.tabPage11.Controls.Add(this.textBox50);
            this.tabPage11.Controls.Add(this.textBox51);
            this.tabPage11.Controls.Add(this.textBox52);
            this.tabPage11.Controls.Add(this.textBox53);
            this.tabPage11.Controls.Add(this.textBox54);
            this.tabPage11.Controls.Add(this.textBox55);
            this.tabPage11.Controls.Add(this.label137);
            this.tabPage11.Controls.Add(this.label138);
            this.tabPage11.Controls.Add(this.label139);
            this.tabPage11.Controls.Add(this.label140);
            this.tabPage11.Controls.Add(this.label141);
            this.tabPage11.Controls.Add(this.label142);
            this.tabPage11.Controls.Add(this.label143);
            this.tabPage11.Controls.Add(this.label144);
            this.tabPage11.Controls.Add(this.label145);
            this.tabPage11.Controls.Add(this.label146);
            this.tabPage11.Controls.Add(this.label147);
            this.tabPage11.Controls.Add(this.label148);
            this.tabPage11.Controls.Add(this.label149);
            this.tabPage11.Controls.Add(this.label150);
            this.tabPage11.Controls.Add(this.label151);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1206, 562);
            this.tabPage11.TabIndex = 5;
            this.tabPage11.Text = "Instant data";
            this.tabPage11.Click += new System.EventHandler(this.tabPage11_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(646, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 599;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(570, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 598;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightCoral;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(489, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 597;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(426, 338);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(58, 13);
            this.label126.TabIndex = 596;
            this.label126.Text = "THD(Curr):";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(646, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(61, 20);
            this.textBox4.TabIndex = 595;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(570, 316);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 594;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LightCoral;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(489, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 593;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(430, 318);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(54, 13);
            this.label133.TabIndex = 592;
            this.label133.Text = "THD(Vol):";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(717, 296);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(61, 20);
            this.textBox7.TabIndex = 591;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(646, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(61, 20);
            this.textBox8.TabIndex = 590;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(570, 129);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(61, 20);
            this.textBox9.TabIndex = 589;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.LightCoral;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(489, 127);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(61, 20);
            this.textBox10.TabIndex = 588;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(447, 129);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(37, 13);
            this.label134.TabIndex = 587;
            this.label134.Text = "Angle:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(646, 295);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(61, 20);
            this.textBox11.TabIndex = 586;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(570, 295);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(61, 20);
            this.textBox12.TabIndex = 585;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.LightCoral;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(489, 295);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(61, 20);
            this.textBox13.TabIndex = 584;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(434, 296);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(50, 13);
            this.label135.TabIndex = 583;
            this.label135.Text = "Samples:";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(646, 275);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(61, 20);
            this.textBox14.TabIndex = 582;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(570, 275);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(61, 20);
            this.textBox15.TabIndex = 581;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.LightCoral;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(489, 274);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(61, 20);
            this.textBox16.TabIndex = 580;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(434, 277);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(51, 13);
            this.label136.TabIndex = 579;
            this.label136.Text = "Angle(R):";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(646, 235);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(61, 20);
            this.textBox17.TabIndex = 578;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(646, 214);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(61, 20);
            this.textBox18.TabIndex = 577;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(646, 193);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(61, 20);
            this.textBox19.TabIndex = 576;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(646, 172);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(61, 20);
            this.textBox20.TabIndex = 575;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(646, 150);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(61, 20);
            this.textBox21.TabIndex = 574;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(646, 255);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(61, 20);
            this.textBox22.TabIndex = 573;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(646, 108);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(61, 20);
            this.textBox23.TabIndex = 572;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(646, 87);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(61, 20);
            this.textBox24.TabIndex = 571;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(646, 66);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(61, 20);
            this.textBox25.TabIndex = 570;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(646, 45);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(61, 20);
            this.textBox26.TabIndex = 569;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.Location = new System.Drawing.Point(646, 23);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(61, 20);
            this.textBox27.TabIndex = 568;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(570, 235);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(61, 20);
            this.textBox28.TabIndex = 567;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(570, 214);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(61, 20);
            this.textBox29.TabIndex = 566;
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(570, 193);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(61, 20);
            this.textBox30.TabIndex = 565;
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.Location = new System.Drawing.Point(570, 172);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(61, 20);
            this.textBox31.TabIndex = 564;
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(570, 150);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(61, 20);
            this.textBox32.TabIndex = 563;
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.Location = new System.Drawing.Point(570, 255);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(61, 20);
            this.textBox33.TabIndex = 562;
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.Location = new System.Drawing.Point(570, 108);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(61, 20);
            this.textBox34.TabIndex = 561;
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.Location = new System.Drawing.Point(570, 87);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(61, 20);
            this.textBox35.TabIndex = 560;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.Location = new System.Drawing.Point(570, 66);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(61, 20);
            this.textBox36.TabIndex = 559;
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.Location = new System.Drawing.Point(570, 45);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(61, 20);
            this.textBox37.TabIndex = 558;
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.Location = new System.Drawing.Point(570, 23);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(61, 20);
            this.textBox38.TabIndex = 557;
            // 
            // textBox39
            // 
            this.textBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox39.Location = new System.Drawing.Point(717, 236);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(61, 20);
            this.textBox39.TabIndex = 556;
            // 
            // textBox40
            // 
            this.textBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox40.Location = new System.Drawing.Point(717, 215);
            this.textBox40.Name = "textBox40";
            this.textBox40.ReadOnly = true;
            this.textBox40.Size = new System.Drawing.Size(61, 20);
            this.textBox40.TabIndex = 555;
            // 
            // textBox41
            // 
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(717, 193);
            this.textBox41.Name = "textBox41";
            this.textBox41.ReadOnly = true;
            this.textBox41.Size = new System.Drawing.Size(61, 20);
            this.textBox41.TabIndex = 554;
            // 
            // textBox42
            // 
            this.textBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox42.Location = new System.Drawing.Point(717, 172);
            this.textBox42.Name = "textBox42";
            this.textBox42.ReadOnly = true;
            this.textBox42.Size = new System.Drawing.Size(61, 20);
            this.textBox42.TabIndex = 553;
            // 
            // textBox43
            // 
            this.textBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox43.Location = new System.Drawing.Point(717, 151);
            this.textBox43.Name = "textBox43";
            this.textBox43.ReadOnly = true;
            this.textBox43.Size = new System.Drawing.Size(61, 20);
            this.textBox43.TabIndex = 552;
            // 
            // textBox44
            // 
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(717, 110);
            this.textBox44.Name = "textBox44";
            this.textBox44.ReadOnly = true;
            this.textBox44.Size = new System.Drawing.Size(61, 20);
            this.textBox44.TabIndex = 551;
            // 
            // textBox45
            // 
            this.textBox45.BackColor = System.Drawing.Color.LightCoral;
            this.textBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox45.Location = new System.Drawing.Point(489, 232);
            this.textBox45.Name = "textBox45";
            this.textBox45.ReadOnly = true;
            this.textBox45.Size = new System.Drawing.Size(61, 20);
            this.textBox45.TabIndex = 550;
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.Color.LightCoral;
            this.textBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox46.Location = new System.Drawing.Point(489, 211);
            this.textBox46.Name = "textBox46";
            this.textBox46.ReadOnly = true;
            this.textBox46.Size = new System.Drawing.Size(61, 20);
            this.textBox46.TabIndex = 549;
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.Color.LightCoral;
            this.textBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox47.Location = new System.Drawing.Point(489, 190);
            this.textBox47.Name = "textBox47";
            this.textBox47.ReadOnly = true;
            this.textBox47.Size = new System.Drawing.Size(61, 20);
            this.textBox47.TabIndex = 548;
            // 
            // textBox48
            // 
            this.textBox48.BackColor = System.Drawing.Color.LightCoral;
            this.textBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox48.Location = new System.Drawing.Point(489, 169);
            this.textBox48.Name = "textBox48";
            this.textBox48.ReadOnly = true;
            this.textBox48.Size = new System.Drawing.Size(61, 20);
            this.textBox48.TabIndex = 547;
            // 
            // textBox49
            // 
            this.textBox49.BackColor = System.Drawing.Color.LightCoral;
            this.textBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox49.Location = new System.Drawing.Point(489, 148);
            this.textBox49.Name = "textBox49";
            this.textBox49.ReadOnly = true;
            this.textBox49.Size = new System.Drawing.Size(61, 20);
            this.textBox49.TabIndex = 546;
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.Color.LightCoral;
            this.textBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox50.Location = new System.Drawing.Point(489, 253);
            this.textBox50.Name = "textBox50";
            this.textBox50.ReadOnly = true;
            this.textBox50.Size = new System.Drawing.Size(61, 20);
            this.textBox50.TabIndex = 545;
            // 
            // textBox51
            // 
            this.textBox51.BackColor = System.Drawing.Color.LightCoral;
            this.textBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox51.Location = new System.Drawing.Point(489, 106);
            this.textBox51.Name = "textBox51";
            this.textBox51.ReadOnly = true;
            this.textBox51.Size = new System.Drawing.Size(61, 20);
            this.textBox51.TabIndex = 544;
            // 
            // textBox52
            // 
            this.textBox52.BackColor = System.Drawing.Color.LightCoral;
            this.textBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox52.Location = new System.Drawing.Point(489, 85);
            this.textBox52.Name = "textBox52";
            this.textBox52.ReadOnly = true;
            this.textBox52.Size = new System.Drawing.Size(61, 20);
            this.textBox52.TabIndex = 543;
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.Color.LightCoral;
            this.textBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox53.Location = new System.Drawing.Point(489, 64);
            this.textBox53.Name = "textBox53";
            this.textBox53.ReadOnly = true;
            this.textBox53.Size = new System.Drawing.Size(61, 20);
            this.textBox53.TabIndex = 542;
            // 
            // textBox54
            // 
            this.textBox54.BackColor = System.Drawing.Color.LightCoral;
            this.textBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox54.Location = new System.Drawing.Point(489, 43);
            this.textBox54.Name = "textBox54";
            this.textBox54.ReadOnly = true;
            this.textBox54.Size = new System.Drawing.Size(61, 20);
            this.textBox54.TabIndex = 541;
            // 
            // textBox55
            // 
            this.textBox55.BackColor = System.Drawing.Color.LightCoral;
            this.textBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox55.Location = new System.Drawing.Point(489, 22);
            this.textBox55.Name = "textBox55";
            this.textBox55.ReadOnly = true;
            this.textBox55.Size = new System.Drawing.Size(61, 20);
            this.textBox55.TabIndex = 540;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(430, 235);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(54, 13);
            this.label137.TabIndex = 539;
            this.label137.Text = "Quadrant:";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.Location = new System.Drawing.Point(431, 214);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(53, 13);
            this.label138.TabIndex = 538;
            this.label138.Text = "Freq (Hz):";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.Location = new System.Drawing.Point(424, 86);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(60, 13);
            this.label139.TabIndex = 537;
            this.label139.Text = "Curr Offset:";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.Location = new System.Drawing.Point(436, 45);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(48, 13);
            this.label140.TabIndex = 536;
            this.label140.Text = "V Offset:";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(714, 3);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(62, 13);
            this.label141.TabIndex = 535;
            this.label141.Text = "Net/Total";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.ForeColor = System.Drawing.Color.Red;
            this.label142.Location = new System.Drawing.Point(490, 3);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(55, 13);
            this.label142.TabIndex = 532;
            this.label142.Text = "R Phase";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.ForeColor = System.Drawing.Color.Yellow;
            this.label143.Location = new System.Drawing.Point(567, 3);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(54, 13);
            this.label143.TabIndex = 533;
            this.label143.Text = "Y Phase";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.ForeColor = System.Drawing.Color.Blue;
            this.label144.Location = new System.Drawing.Point(639, 3);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(54, 13);
            this.label144.TabIndex = 534;
            this.label144.Text = "B Phase";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.Location = new System.Drawing.Point(438, 20);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(46, 13);
            this.label145.TabIndex = 525;
            this.label145.Text = "Voltage:";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(440, 65);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(44, 13);
            this.label146.TabIndex = 526;
            this.label146.Text = "Current:";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(461, 110);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(23, 13);
            this.label147.TabIndex = 527;
            this.label147.Text = "PF:";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(424, 151);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(60, 13);
            this.label148.TabIndex = 528;
            this.label148.Text = "Power (W):";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(413, 170);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(71, 13);
            this.label149.TabIndex = 529;
            this.label149.Text = "Power (VAR):";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(421, 192);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(63, 13);
            this.label150.TabIndex = 530;
            this.label150.Text = "Power (VA):";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(434, 256);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(50, 13);
            this.label151.TabIndex = 531;
            this.label151.Text = "Angle(A):";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.groupBox31);
            this.groupBox30.Controls.Add(this.textBox92);
            this.groupBox30.Controls.Add(this.textBox57);
            this.groupBox30.Controls.Add(this.label152);
            this.groupBox30.Controls.Add(this.label153);
            this.groupBox30.Controls.Add(this.textBox58);
            this.groupBox30.Controls.Add(this.label154);
            this.groupBox30.Controls.Add(this.textBox59);
            this.groupBox30.Controls.Add(this.button1);
            this.groupBox30.Controls.Add(this.checkBox1);
            this.groupBox30.Controls.Add(this.textBox60);
            this.groupBox30.Controls.Add(this.label155);
            this.groupBox30.Controls.Add(this.textBox61);
            this.groupBox30.Controls.Add(this.textBox62);
            this.groupBox30.Controls.Add(this.textBox63);
            this.groupBox30.Controls.Add(this.label156);
            this.groupBox30.Controls.Add(this.label157);
            this.groupBox30.Controls.Add(this.label158);
            this.groupBox30.Controls.Add(this.textBox64);
            this.groupBox30.Controls.Add(this.label159);
            this.groupBox30.Controls.Add(this.textBox65);
            this.groupBox30.Controls.Add(this.textBox66);
            this.groupBox30.Controls.Add(this.textBox67);
            this.groupBox30.Controls.Add(this.label160);
            this.groupBox30.Controls.Add(this.textBox68);
            this.groupBox30.Controls.Add(this.textBox69);
            this.groupBox30.Controls.Add(this.textBox70);
            this.groupBox30.Controls.Add(this.label161);
            this.groupBox30.Controls.Add(this.textBox71);
            this.groupBox30.Controls.Add(this.label162);
            this.groupBox30.Controls.Add(this.textBox72);
            this.groupBox30.Controls.Add(this.label163);
            this.groupBox30.Controls.Add(this.textBox73);
            this.groupBox30.Controls.Add(this.label164);
            this.groupBox30.Controls.Add(this.textBox74);
            this.groupBox30.Controls.Add(this.textBox75);
            this.groupBox30.Controls.Add(this.textBox76);
            this.groupBox30.Controls.Add(this.textBox77);
            this.groupBox30.Controls.Add(this.textBox78);
            this.groupBox30.Controls.Add(this.textBox79);
            this.groupBox30.Controls.Add(this.textBox80);
            this.groupBox30.Controls.Add(this.textBox81);
            this.groupBox30.Controls.Add(this.textBox82);
            this.groupBox30.Controls.Add(this.label165);
            this.groupBox30.Controls.Add(this.textBox83);
            this.groupBox30.Controls.Add(this.textBox84);
            this.groupBox30.Controls.Add(this.textBox85);
            this.groupBox30.Controls.Add(this.textBox86);
            this.groupBox30.Controls.Add(this.textBox87);
            this.groupBox30.Controls.Add(this.textBox88);
            this.groupBox30.Controls.Add(this.textBox89);
            this.groupBox30.Controls.Add(this.textBox90);
            this.groupBox30.Controls.Add(this.textBox91);
            this.groupBox30.Controls.Add(this.label166);
            this.groupBox30.Controls.Add(this.label167);
            this.groupBox30.Controls.Add(this.label168);
            this.groupBox30.Controls.Add(this.label169);
            this.groupBox30.Controls.Add(this.label170);
            this.groupBox30.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox30.Location = new System.Drawing.Point(6, 6);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(399, 371);
            this.groupBox30.TabIndex = 600;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Accuracy Calculation";
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox56.Location = new System.Drawing.Point(819, 501);
            this.textBox56.Multiline = true;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(381, 55);
            this.textBox56.TabIndex = 406;
            // 
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.Color.Gold;
            this.textBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox57.Location = new System.Drawing.Point(64, 215);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(42, 20);
            this.textBox57.TabIndex = 531;
            this.textBox57.Text = "-120";
            this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(5, 217);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(57, 13);
            this.label152.TabIndex = 530;
            this.label152.Text = "Angle Y-B:";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(112, 239);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(94, 13);
            this.label153.TabIndex = 529;
            this.label153.Text = "Neu Vector Angle:";
            // 
            // textBox58
            // 
            this.textBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox58.Location = new System.Drawing.Point(210, 239);
            this.textBox58.Name = "textBox58";
            this.textBox58.ReadOnly = true;
            this.textBox58.Size = new System.Drawing.Size(61, 20);
            this.textBox58.TabIndex = 528;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(118, 218);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(86, 13);
            this.label154.TabIndex = 527;
            this.label154.Text = "Neu Vector Curr:";
            // 
            // textBox59
            // 
            this.textBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox59.Location = new System.Drawing.Point(210, 216);
            this.textBox59.Name = "textBox59";
            this.textBox59.ReadOnly = true;
            this.textBox59.Size = new System.Drawing.Size(61, 20);
            this.textBox59.TabIndex = 526;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(279, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 525;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(296, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 524;
            this.checkBox1.Text = "Cal Accuracy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox60
            // 
            this.textBox60.BackColor = System.Drawing.Color.Gold;
            this.textBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox60.Location = new System.Drawing.Point(210, 194);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(61, 20);
            this.textBox60.TabIndex = 523;
            this.textBox60.Text = "50";
            this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(144, 197);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(60, 13);
            this.label155.TabIndex = 522;
            this.label155.Text = "Frequency:";
            // 
            // textBox61
            // 
            this.textBox61.BackColor = System.Drawing.Color.Gold;
            this.textBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox61.Location = new System.Drawing.Point(64, 236);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(42, 20);
            this.textBox61.TabIndex = 521;
            this.textBox61.Text = "-120";
            this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox62
            // 
            this.textBox62.BackColor = System.Drawing.Color.Gold;
            this.textBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox62.Location = new System.Drawing.Point(356, 194);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(30, 20);
            this.textBox62.TabIndex = 432;
            this.textBox62.Text = "5";
            this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox63
            // 
            this.textBox63.BackColor = System.Drawing.Color.Gold;
            this.textBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox63.Location = new System.Drawing.Point(64, 194);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(42, 20);
            this.textBox63.TabIndex = 520;
            this.textBox63.Text = "120";
            this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(7, 239);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(58, 13);
            this.label156.TabIndex = 519;
            this.label156.Text = "Angle B-R:";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.Location = new System.Drawing.Point(6, 197);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(58, 13);
            this.label157.TabIndex = 518;
            this.label157.Text = "Angle R-Y:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(282, 197);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(72, 13);
            this.label158.TabIndex = 431;
            this.label158.Text = "Avg Samples:";
            // 
            // textBox64
            // 
            this.textBox64.BackColor = System.Drawing.Color.White;
            this.textBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox64.Location = new System.Drawing.Point(326, 160);
            this.textBox64.Name = "textBox64";
            this.textBox64.ReadOnly = true;
            this.textBox64.Size = new System.Drawing.Size(61, 20);
            this.textBox64.TabIndex = 502;
            this.textBox64.Text = "0";
            this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.Location = new System.Drawing.Point(34, 163);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(23, 13);
            this.label159.TabIndex = 501;
            this.label159.Text = "PF:";
            // 
            // textBox65
            // 
            this.textBox65.BackColor = System.Drawing.Color.White;
            this.textBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox65.Location = new System.Drawing.Point(326, 138);
            this.textBox65.Name = "textBox65";
            this.textBox65.ReadOnly = true;
            this.textBox65.Size = new System.Drawing.Size(61, 20);
            this.textBox65.TabIndex = 500;
            this.textBox65.Text = "0";
            this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.Color.White;
            this.textBox66.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox66.Location = new System.Drawing.Point(326, 116);
            this.textBox66.Name = "textBox66";
            this.textBox66.ReadOnly = true;
            this.textBox66.Size = new System.Drawing.Size(61, 20);
            this.textBox66.TabIndex = 499;
            this.textBox66.Text = "0";
            this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox67
            // 
            this.textBox67.BackColor = System.Drawing.Color.White;
            this.textBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox67.Location = new System.Drawing.Point(327, 94);
            this.textBox67.Name = "textBox67";
            this.textBox67.ReadOnly = true;
            this.textBox67.Size = new System.Drawing.Size(61, 20);
            this.textBox67.TabIndex = 498;
            this.textBox67.Text = "0";
            this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.ForeColor = System.Drawing.Color.Black;
            this.label160.Location = new System.Drawing.Point(351, 14);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(24, 13);
            this.label160.TabIndex = 497;
            this.label160.Text = "Net";
            // 
            // textBox68
            // 
            this.textBox68.BackColor = System.Drawing.Color.White;
            this.textBox68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox68.Location = new System.Drawing.Point(260, 138);
            this.textBox68.Name = "textBox68";
            this.textBox68.ReadOnly = true;
            this.textBox68.Size = new System.Drawing.Size(61, 20);
            this.textBox68.TabIndex = 496;
            this.textBox68.Text = "0";
            this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox69
            // 
            this.textBox69.BackColor = System.Drawing.Color.White;
            this.textBox69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox69.Location = new System.Drawing.Point(260, 116);
            this.textBox69.Name = "textBox69";
            this.textBox69.ReadOnly = true;
            this.textBox69.Size = new System.Drawing.Size(61, 20);
            this.textBox69.TabIndex = 495;
            this.textBox69.Text = "0";
            this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox70
            // 
            this.textBox70.BackColor = System.Drawing.Color.White;
            this.textBox70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox70.Location = new System.Drawing.Point(261, 94);
            this.textBox70.Name = "textBox70";
            this.textBox70.ReadOnly = true;
            this.textBox70.Size = new System.Drawing.Size(61, 20);
            this.textBox70.TabIndex = 494;
            this.textBox70.Text = "0";
            this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.ForeColor = System.Drawing.Color.Black;
            this.label161.Location = new System.Drawing.Point(277, 13);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(31, 13);
            this.label161.TabIndex = 493;
            this.label161.Text = "Total";
            // 
            // textBox71
            // 
            this.textBox71.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox71.Location = new System.Drawing.Point(195, 138);
            this.textBox71.Name = "textBox71";
            this.textBox71.ReadOnly = true;
            this.textBox71.Size = new System.Drawing.Size(61, 20);
            this.textBox71.TabIndex = 492;
            this.textBox71.Text = "0";
            this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(26, 119);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(32, 13);
            this.label162.TabIndex = 489;
            this.label162.Text = "VAR:";
            // 
            // textBox72
            // 
            this.textBox72.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox72.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox72.Location = new System.Drawing.Point(195, 116);
            this.textBox72.Name = "textBox72";
            this.textBox72.ReadOnly = true;
            this.textBox72.Size = new System.Drawing.Size(61, 20);
            this.textBox72.TabIndex = 491;
            this.textBox72.Text = "0";
            this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(34, 141);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(24, 13);
            this.label163.TabIndex = 487;
            this.label163.Text = "VA:";
            // 
            // textBox73
            // 
            this.textBox73.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox73.Location = new System.Drawing.Point(195, 94);
            this.textBox73.Name = "textBox73";
            this.textBox73.ReadOnly = true;
            this.textBox73.Size = new System.Drawing.Size(61, 20);
            this.textBox73.TabIndex = 490;
            this.textBox73.Text = "0";
            this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(26, 99);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(33, 13);
            this.label164.TabIndex = 485;
            this.label164.Text = "Watt:";
            // 
            // textBox74
            // 
            this.textBox74.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox74.Location = new System.Drawing.Point(129, 138);
            this.textBox74.Name = "textBox74";
            this.textBox74.ReadOnly = true;
            this.textBox74.Size = new System.Drawing.Size(61, 20);
            this.textBox74.TabIndex = 488;
            this.textBox74.Text = "0";
            this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox75
            // 
            this.textBox75.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox75.Location = new System.Drawing.Point(129, 116);
            this.textBox75.Name = "textBox75";
            this.textBox75.ReadOnly = true;
            this.textBox75.Size = new System.Drawing.Size(61, 20);
            this.textBox75.TabIndex = 486;
            this.textBox75.Text = "0";
            this.textBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox76
            // 
            this.textBox76.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox76.Location = new System.Drawing.Point(129, 94);
            this.textBox76.Name = "textBox76";
            this.textBox76.ReadOnly = true;
            this.textBox76.Size = new System.Drawing.Size(61, 20);
            this.textBox76.TabIndex = 484;
            this.textBox76.Text = "0";
            this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox77
            // 
            this.textBox77.BackColor = System.Drawing.Color.LightCoral;
            this.textBox77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox77.Location = new System.Drawing.Point(64, 138);
            this.textBox77.Name = "textBox77";
            this.textBox77.ReadOnly = true;
            this.textBox77.Size = new System.Drawing.Size(61, 20);
            this.textBox77.TabIndex = 482;
            this.textBox77.Text = "0";
            this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox78
            // 
            this.textBox78.BackColor = System.Drawing.Color.LightCoral;
            this.textBox78.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox78.Location = new System.Drawing.Point(64, 116);
            this.textBox78.Name = "textBox78";
            this.textBox78.ReadOnly = true;
            this.textBox78.Size = new System.Drawing.Size(61, 20);
            this.textBox78.TabIndex = 481;
            this.textBox78.Text = "0";
            this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox79
            // 
            this.textBox79.BackColor = System.Drawing.Color.LightCoral;
            this.textBox79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox79.Location = new System.Drawing.Point(64, 95);
            this.textBox79.Name = "textBox79";
            this.textBox79.ReadOnly = true;
            this.textBox79.Size = new System.Drawing.Size(61, 20);
            this.textBox79.TabIndex = 478;
            this.textBox79.Text = "0";
            this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox80
            // 
            this.textBox80.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox80.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox80.Location = new System.Drawing.Point(195, 72);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(61, 20);
            this.textBox80.TabIndex = 470;
            this.textBox80.Text = "0";
            this.textBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox81
            // 
            this.textBox81.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox81.Location = new System.Drawing.Point(129, 72);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(61, 20);
            this.textBox81.TabIndex = 469;
            this.textBox81.Text = "0";
            this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox82
            // 
            this.textBox82.BackColor = System.Drawing.Color.LightCoral;
            this.textBox82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox82.Location = new System.Drawing.Point(64, 72);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(61, 20);
            this.textBox82.TabIndex = 468;
            this.textBox82.Text = "0";
            this.textBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(21, 74);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(37, 13);
            this.label165.TabIndex = 467;
            this.label165.Text = "Angle:";
            // 
            // textBox83
            // 
            this.textBox83.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox83.Location = new System.Drawing.Point(195, 160);
            this.textBox83.Name = "textBox83";
            this.textBox83.ReadOnly = true;
            this.textBox83.Size = new System.Drawing.Size(61, 20);
            this.textBox83.TabIndex = 466;
            this.textBox83.Text = "0";
            this.textBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox84
            // 
            this.textBox84.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox84.Location = new System.Drawing.Point(195, 50);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(61, 20);
            this.textBox84.TabIndex = 465;
            this.textBox84.Text = "10";
            this.textBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox85
            // 
            this.textBox85.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox85.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox85.Location = new System.Drawing.Point(195, 29);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(61, 20);
            this.textBox85.TabIndex = 464;
            this.textBox85.Text = "240";
            this.textBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox86
            // 
            this.textBox86.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox86.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox86.Location = new System.Drawing.Point(129, 160);
            this.textBox86.Name = "textBox86";
            this.textBox86.ReadOnly = true;
            this.textBox86.Size = new System.Drawing.Size(61, 20);
            this.textBox86.TabIndex = 463;
            this.textBox86.Text = "0";
            this.textBox86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox87
            // 
            this.textBox87.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox87.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox87.Location = new System.Drawing.Point(129, 50);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(61, 20);
            this.textBox87.TabIndex = 462;
            this.textBox87.Text = "10";
            this.textBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox88
            // 
            this.textBox88.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox88.Location = new System.Drawing.Point(129, 29);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(61, 20);
            this.textBox88.TabIndex = 461;
            this.textBox88.Text = "240";
            this.textBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox89
            // 
            this.textBox89.BackColor = System.Drawing.Color.LightCoral;
            this.textBox89.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox89.Location = new System.Drawing.Point(64, 160);
            this.textBox89.Name = "textBox89";
            this.textBox89.ReadOnly = true;
            this.textBox89.Size = new System.Drawing.Size(61, 20);
            this.textBox89.TabIndex = 460;
            this.textBox89.Text = "0";
            this.textBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox90
            // 
            this.textBox90.BackColor = System.Drawing.Color.LightCoral;
            this.textBox90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox90.Location = new System.Drawing.Point(64, 50);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(61, 20);
            this.textBox90.TabIndex = 459;
            this.textBox90.Text = "10";
            this.textBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox91
            // 
            this.textBox91.BackColor = System.Drawing.Color.LightCoral;
            this.textBox91.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox91.Location = new System.Drawing.Point(64, 29);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(61, 20);
            this.textBox91.TabIndex = 458;
            this.textBox91.Text = "240";
            this.textBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.ForeColor = System.Drawing.Color.Red;
            this.label166.Location = new System.Drawing.Point(68, 14);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(48, 13);
            this.label166.TabIndex = 455;
            this.label166.Text = "R Phase";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label167.ForeColor = System.Drawing.Color.Yellow;
            this.label167.Location = new System.Drawing.Point(134, 13);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(47, 13);
            this.label167.TabIndex = 456;
            this.label167.Text = "Y Phase";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label168.ForeColor = System.Drawing.Color.Blue;
            this.label168.Location = new System.Drawing.Point(196, 13);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(47, 13);
            this.label168.TabIndex = 457;
            this.label168.Text = "B Phase";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label169.Location = new System.Drawing.Point(15, 32);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(46, 13);
            this.label169.TabIndex = 452;
            this.label169.Text = "Voltage:";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.Location = new System.Drawing.Point(17, 53);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(44, 13);
            this.label170.TabIndex = 453;
            this.label170.Text = "Current:";
            // 
            // textBox92
            // 
            this.textBox92.BackColor = System.Drawing.Color.White;
            this.textBox92.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox92.Location = new System.Drawing.Point(260, 161);
            this.textBox92.Name = "textBox92";
            this.textBox92.ReadOnly = true;
            this.textBox92.Size = new System.Drawing.Size(61, 20);
            this.textBox92.TabIndex = 532;
            this.textBox92.Text = "0";
            this.textBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.textBox105);
            this.groupBox31.Controls.Add(this.textBox106);
            this.groupBox31.Controls.Add(this.textBox107);
            this.groupBox31.Controls.Add(this.textBox93);
            this.groupBox31.Controls.Add(this.textBox94);
            this.groupBox31.Controls.Add(this.textBox95);
            this.groupBox31.Controls.Add(this.textBox96);
            this.groupBox31.Controls.Add(this.textBox97);
            this.groupBox31.Controls.Add(this.textBox98);
            this.groupBox31.Controls.Add(this.textBox99);
            this.groupBox31.Controls.Add(this.textBox100);
            this.groupBox31.Controls.Add(this.textBox101);
            this.groupBox31.Controls.Add(this.textBox102);
            this.groupBox31.Controls.Add(this.textBox103);
            this.groupBox31.Controls.Add(this.label171);
            this.groupBox31.Controls.Add(this.textBox104);
            this.groupBox31.Controls.Add(this.label172);
            this.groupBox31.Controls.Add(this.label173);
            this.groupBox31.Location = new System.Drawing.Point(3, 265);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(390, 100);
            this.groupBox31.TabIndex = 533;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Accuracy";
            // 
            // textBox93
            // 
            this.textBox93.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox93.Location = new System.Drawing.Point(191, 64);
            this.textBox93.Name = "textBox93";
            this.textBox93.ReadOnly = true;
            this.textBox93.Size = new System.Drawing.Size(61, 20);
            this.textBox93.TabIndex = 521;
            // 
            // textBox94
            // 
            this.textBox94.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox94.Location = new System.Drawing.Point(125, 64);
            this.textBox94.Name = "textBox94";
            this.textBox94.ReadOnly = true;
            this.textBox94.Size = new System.Drawing.Size(61, 20);
            this.textBox94.TabIndex = 520;
            // 
            // textBox95
            // 
            this.textBox95.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox95.Location = new System.Drawing.Point(256, 64);
            this.textBox95.Name = "textBox95";
            this.textBox95.ReadOnly = true;
            this.textBox95.Size = new System.Drawing.Size(61, 20);
            this.textBox95.TabIndex = 519;
            // 
            // textBox96
            // 
            this.textBox96.BackColor = System.Drawing.Color.LightCoral;
            this.textBox96.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox96.Location = new System.Drawing.Point(60, 64);
            this.textBox96.Name = "textBox96";
            this.textBox96.ReadOnly = true;
            this.textBox96.Size = new System.Drawing.Size(61, 20);
            this.textBox96.TabIndex = 518;
            // 
            // textBox97
            // 
            this.textBox97.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox97.Location = new System.Drawing.Point(192, 39);
            this.textBox97.Name = "textBox97";
            this.textBox97.ReadOnly = true;
            this.textBox97.Size = new System.Drawing.Size(61, 20);
            this.textBox97.TabIndex = 517;
            // 
            // textBox98
            // 
            this.textBox98.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox98.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox98.Location = new System.Drawing.Point(126, 39);
            this.textBox98.Name = "textBox98";
            this.textBox98.ReadOnly = true;
            this.textBox98.Size = new System.Drawing.Size(61, 20);
            this.textBox98.TabIndex = 516;
            // 
            // textBox99
            // 
            this.textBox99.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox99.Location = new System.Drawing.Point(257, 39);
            this.textBox99.Name = "textBox99";
            this.textBox99.ReadOnly = true;
            this.textBox99.Size = new System.Drawing.Size(61, 20);
            this.textBox99.TabIndex = 515;
            // 
            // textBox100
            // 
            this.textBox100.BackColor = System.Drawing.Color.LightCoral;
            this.textBox100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox100.Location = new System.Drawing.Point(61, 39);
            this.textBox100.Name = "textBox100";
            this.textBox100.ReadOnly = true;
            this.textBox100.Size = new System.Drawing.Size(61, 20);
            this.textBox100.TabIndex = 514;
            // 
            // textBox101
            // 
            this.textBox101.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox101.Location = new System.Drawing.Point(192, 16);
            this.textBox101.Name = "textBox101";
            this.textBox101.ReadOnly = true;
            this.textBox101.Size = new System.Drawing.Size(61, 20);
            this.textBox101.TabIndex = 513;
            // 
            // textBox102
            // 
            this.textBox102.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox102.Location = new System.Drawing.Point(126, 16);
            this.textBox102.Name = "textBox102";
            this.textBox102.ReadOnly = true;
            this.textBox102.Size = new System.Drawing.Size(61, 20);
            this.textBox102.TabIndex = 512;
            // 
            // textBox103
            // 
            this.textBox103.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox103.Location = new System.Drawing.Point(257, 16);
            this.textBox103.Name = "textBox103";
            this.textBox103.ReadOnly = true;
            this.textBox103.Size = new System.Drawing.Size(61, 20);
            this.textBox103.TabIndex = 511;
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label171.Location = new System.Drawing.Point(8, 68);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(53, 13);
            this.label171.TabIndex = 420;
            this.label171.Text = "Apparent:";
            // 
            // textBox104
            // 
            this.textBox104.BackColor = System.Drawing.Color.LightCoral;
            this.textBox104.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox104.Location = new System.Drawing.Point(61, 16);
            this.textBox104.Name = "textBox104";
            this.textBox104.ReadOnly = true;
            this.textBox104.Size = new System.Drawing.Size(61, 20);
            this.textBox104.TabIndex = 510;
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.Location = new System.Drawing.Point(3, 43);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(53, 13);
            this.label172.TabIndex = 417;
            this.label172.Text = "Reactive:";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.Location = new System.Drawing.Point(19, 20);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(40, 13);
            this.label173.TabIndex = 416;
            this.label173.Text = "Active:";
            // 
            // textBox105
            // 
            this.textBox105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox105.Location = new System.Drawing.Point(320, 64);
            this.textBox105.Name = "textBox105";
            this.textBox105.ReadOnly = true;
            this.textBox105.Size = new System.Drawing.Size(61, 20);
            this.textBox105.TabIndex = 524;
            // 
            // textBox106
            // 
            this.textBox106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox106.Location = new System.Drawing.Point(321, 39);
            this.textBox106.Name = "textBox106";
            this.textBox106.ReadOnly = true;
            this.textBox106.Size = new System.Drawing.Size(61, 20);
            this.textBox106.TabIndex = 523;
            // 
            // textBox107
            // 
            this.textBox107.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox107.Location = new System.Drawing.Point(321, 16);
            this.textBox107.Name = "textBox107";
            this.textBox107.ReadOnly = true;
            this.textBox107.Size = new System.Drawing.Size(61, 20);
            this.textBox107.TabIndex = 522;
            // 
            // textBox109
            // 
            this.textBox109.BackColor = System.Drawing.Color.LightCoral;
            this.textBox109.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox109.Location = new System.Drawing.Point(488, 359);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(78, 20);
            this.textBox109.TabIndex = 602;
            // 
            // textBox110
            // 
            this.textBox110.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox110.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox110.Location = new System.Drawing.Point(570, 359);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(78, 20);
            this.textBox110.TabIndex = 604;
            // 
            // textBox111
            // 
            this.textBox111.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox111.Location = new System.Drawing.Point(654, 359);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(78, 20);
            this.textBox111.TabIndex = 605;
            // 
            // textBox112
            // 
            this.textBox112.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox112.Location = new System.Drawing.Point(736, 359);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(78, 20);
            this.textBox112.TabIndex = 603;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(409, 363);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(73, 13);
            this.label45.TabIndex = 601;
            this.label45.Text = "Energy(1.8.0):";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(407, 382);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 13);
            this.label49.TabIndex = 614;
            this.label49.Text = "Energy(2.8.0):";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(407, 402);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 13);
            this.label50.TabIndex = 615;
            this.label50.Text = "Energy(5.8.0):";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(407, 423);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 13);
            this.label51.TabIndex = 616;
            this.label51.Text = "Energy(6.8.0):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(407, 443);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(73, 13);
            this.label52.TabIndex = 617;
            this.label52.Text = "Energy(7.8.0):";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(407, 462);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(73, 13);
            this.label53.TabIndex = 618;
            this.label53.Text = "Energy(8.8.0):";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(407, 482);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(73, 13);
            this.label54.TabIndex = 619;
            this.label54.Text = "Energy(9.8.0):";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(401, 501);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(79, 13);
            this.label61.TabIndex = 620;
            this.label61.Text = "Energy(10.8.0):";
            // 
            // textBox116
            // 
            this.textBox116.BackColor = System.Drawing.Color.LightCoral;
            this.textBox116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox116.Location = new System.Drawing.Point(488, 379);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(78, 20);
            this.textBox116.TabIndex = 621;
            // 
            // textBox117
            // 
            this.textBox117.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox117.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox117.Location = new System.Drawing.Point(570, 379);
            this.textBox117.Name = "textBox117";
            this.textBox117.Size = new System.Drawing.Size(78, 20);
            this.textBox117.TabIndex = 623;
            // 
            // textBox118
            // 
            this.textBox118.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox118.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox118.Location = new System.Drawing.Point(654, 379);
            this.textBox118.Name = "textBox118";
            this.textBox118.Size = new System.Drawing.Size(78, 20);
            this.textBox118.TabIndex = 624;
            // 
            // textBox108
            // 
            this.textBox108.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox108.Location = new System.Drawing.Point(736, 379);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(78, 20);
            this.textBox108.TabIndex = 625;
            // 
            // textBox113
            // 
            this.textBox113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox113.Location = new System.Drawing.Point(736, 399);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(78, 20);
            this.textBox113.TabIndex = 629;
            // 
            // textBox114
            // 
            this.textBox114.BackColor = System.Drawing.Color.LightCoral;
            this.textBox114.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox114.Location = new System.Drawing.Point(488, 399);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(78, 20);
            this.textBox114.TabIndex = 626;
            // 
            // textBox115
            // 
            this.textBox115.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox115.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox115.Location = new System.Drawing.Point(570, 399);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(78, 20);
            this.textBox115.TabIndex = 627;
            // 
            // textBox119
            // 
            this.textBox119.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox119.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox119.Location = new System.Drawing.Point(654, 399);
            this.textBox119.Name = "textBox119";
            this.textBox119.Size = new System.Drawing.Size(78, 20);
            this.textBox119.TabIndex = 628;
            // 
            // textBox120
            // 
            this.textBox120.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox120.Location = new System.Drawing.Point(736, 420);
            this.textBox120.Name = "textBox120";
            this.textBox120.Size = new System.Drawing.Size(78, 20);
            this.textBox120.TabIndex = 633;
            // 
            // textBox121
            // 
            this.textBox121.BackColor = System.Drawing.Color.LightCoral;
            this.textBox121.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox121.Location = new System.Drawing.Point(488, 420);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(78, 20);
            this.textBox121.TabIndex = 630;
            // 
            // textBox122
            // 
            this.textBox122.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox122.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox122.Location = new System.Drawing.Point(570, 420);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(78, 20);
            this.textBox122.TabIndex = 631;
            // 
            // textBox123
            // 
            this.textBox123.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox123.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox123.Location = new System.Drawing.Point(654, 420);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(78, 20);
            this.textBox123.TabIndex = 632;
            // 
            // textBox124
            // 
            this.textBox124.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox124.Location = new System.Drawing.Point(736, 440);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(78, 20);
            this.textBox124.TabIndex = 637;
            // 
            // textBox125
            // 
            this.textBox125.BackColor = System.Drawing.Color.LightCoral;
            this.textBox125.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox125.Location = new System.Drawing.Point(488, 440);
            this.textBox125.Name = "textBox125";
            this.textBox125.Size = new System.Drawing.Size(78, 20);
            this.textBox125.TabIndex = 634;
            // 
            // textBox126
            // 
            this.textBox126.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox126.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox126.Location = new System.Drawing.Point(570, 440);
            this.textBox126.Name = "textBox126";
            this.textBox126.Size = new System.Drawing.Size(78, 20);
            this.textBox126.TabIndex = 635;
            // 
            // textBox127
            // 
            this.textBox127.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox127.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox127.Location = new System.Drawing.Point(654, 440);
            this.textBox127.Name = "textBox127";
            this.textBox127.Size = new System.Drawing.Size(78, 20);
            this.textBox127.TabIndex = 636;
            // 
            // textBox128
            // 
            this.textBox128.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox128.Location = new System.Drawing.Point(736, 459);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(78, 20);
            this.textBox128.TabIndex = 641;
            // 
            // textBox129
            // 
            this.textBox129.BackColor = System.Drawing.Color.LightCoral;
            this.textBox129.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox129.Location = new System.Drawing.Point(488, 459);
            this.textBox129.Name = "textBox129";
            this.textBox129.Size = new System.Drawing.Size(78, 20);
            this.textBox129.TabIndex = 638;
            // 
            // textBox130
            // 
            this.textBox130.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox130.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox130.Location = new System.Drawing.Point(570, 459);
            this.textBox130.Name = "textBox130";
            this.textBox130.Size = new System.Drawing.Size(78, 20);
            this.textBox130.TabIndex = 639;
            // 
            // textBox131
            // 
            this.textBox131.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox131.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox131.Location = new System.Drawing.Point(654, 459);
            this.textBox131.Name = "textBox131";
            this.textBox131.Size = new System.Drawing.Size(78, 20);
            this.textBox131.TabIndex = 640;
            // 
            // textBox132
            // 
            this.textBox132.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox132.Location = new System.Drawing.Point(735, 479);
            this.textBox132.Name = "textBox132";
            this.textBox132.Size = new System.Drawing.Size(78, 20);
            this.textBox132.TabIndex = 645;
            // 
            // textBox133
            // 
            this.textBox133.BackColor = System.Drawing.Color.LightCoral;
            this.textBox133.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox133.Location = new System.Drawing.Point(487, 479);
            this.textBox133.Name = "textBox133";
            this.textBox133.Size = new System.Drawing.Size(78, 20);
            this.textBox133.TabIndex = 642;
            // 
            // textBox134
            // 
            this.textBox134.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox134.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox134.Location = new System.Drawing.Point(569, 479);
            this.textBox134.Name = "textBox134";
            this.textBox134.Size = new System.Drawing.Size(78, 20);
            this.textBox134.TabIndex = 643;
            // 
            // textBox135
            // 
            this.textBox135.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox135.Location = new System.Drawing.Point(653, 479);
            this.textBox135.Name = "textBox135";
            this.textBox135.Size = new System.Drawing.Size(78, 20);
            this.textBox135.TabIndex = 644;
            // 
            // textBox136
            // 
            this.textBox136.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox136.Location = new System.Drawing.Point(735, 498);
            this.textBox136.Name = "textBox136";
            this.textBox136.Size = new System.Drawing.Size(78, 20);
            this.textBox136.TabIndex = 649;
            // 
            // textBox137
            // 
            this.textBox137.BackColor = System.Drawing.Color.LightCoral;
            this.textBox137.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox137.Location = new System.Drawing.Point(487, 498);
            this.textBox137.Name = "textBox137";
            this.textBox137.Size = new System.Drawing.Size(78, 20);
            this.textBox137.TabIndex = 646;
            // 
            // textBox138
            // 
            this.textBox138.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox138.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox138.Location = new System.Drawing.Point(569, 498);
            this.textBox138.Name = "textBox138";
            this.textBox138.Size = new System.Drawing.Size(78, 20);
            this.textBox138.TabIndex = 647;
            // 
            // textBox139
            // 
            this.textBox139.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox139.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox139.Location = new System.Drawing.Point(653, 498);
            this.textBox139.Name = "textBox139";
            this.textBox139.Size = new System.Drawing.Size(78, 20);
            this.textBox139.TabIndex = 648;
            // 
            // textBox140
            // 
            this.textBox140.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox140.Location = new System.Drawing.Point(734, 539);
            this.textBox140.Name = "textBox140";
            this.textBox140.Size = new System.Drawing.Size(78, 20);
            this.textBox140.TabIndex = 659;
            // 
            // textBox141
            // 
            this.textBox141.BackColor = System.Drawing.Color.LightCoral;
            this.textBox141.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox141.Location = new System.Drawing.Point(486, 539);
            this.textBox141.Name = "textBox141";
            this.textBox141.Size = new System.Drawing.Size(78, 20);
            this.textBox141.TabIndex = 656;
            // 
            // textBox142
            // 
            this.textBox142.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox142.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox142.Location = new System.Drawing.Point(568, 539);
            this.textBox142.Name = "textBox142";
            this.textBox142.Size = new System.Drawing.Size(78, 20);
            this.textBox142.TabIndex = 657;
            // 
            // textBox143
            // 
            this.textBox143.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox143.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox143.Location = new System.Drawing.Point(652, 539);
            this.textBox143.Name = "textBox143";
            this.textBox143.Size = new System.Drawing.Size(78, 20);
            this.textBox143.TabIndex = 658;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(405, 542);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 655;
            this.label44.Text = "FEnergy(2.8.0):";
            // 
            // textBox144
            // 
            this.textBox144.BackColor = System.Drawing.Color.LightCoral;
            this.textBox144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox144.Location = new System.Drawing.Point(486, 518);
            this.textBox144.Name = "textBox144";
            this.textBox144.Size = new System.Drawing.Size(78, 20);
            this.textBox144.TabIndex = 651;
            // 
            // textBox145
            // 
            this.textBox145.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox145.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox145.Location = new System.Drawing.Point(568, 518);
            this.textBox145.Name = "textBox145";
            this.textBox145.Size = new System.Drawing.Size(78, 20);
            this.textBox145.TabIndex = 653;
            // 
            // textBox146
            // 
            this.textBox146.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox146.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox146.Location = new System.Drawing.Point(652, 518);
            this.textBox146.Name = "textBox146";
            this.textBox146.Size = new System.Drawing.Size(78, 20);
            this.textBox146.TabIndex = 654;
            // 
            // textBox147
            // 
            this.textBox147.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox147.Location = new System.Drawing.Point(734, 518);
            this.textBox147.Name = "textBox147";
            this.textBox147.Size = new System.Drawing.Size(78, 20);
            this.textBox147.TabIndex = 652;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(404, 522);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(79, 13);
            this.label46.TabIndex = 650;
            this.label46.Text = "FEnergy(1.8.0):";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Controls.Add(this.textBox148);
            this.groupBox15.Controls.Add(this.checkBox2);
            this.groupBox15.Controls.Add(this.button3);
            this.groupBox15.Controls.Add(this.checkBox3);
            this.groupBox15.Controls.Add(this.label47);
            this.groupBox15.Controls.Add(this.checkBox4);
            this.groupBox15.Controls.Add(this.textBox149);
            this.groupBox15.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(6, 379);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(399, 77);
            this.groupBox15.TabIndex = 660;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Read Setup";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(304, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 308;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox148
            // 
            this.textBox148.Location = new System.Drawing.Point(71, 39);
            this.textBox148.Name = "textBox148";
            this.textBox148.Size = new System.Drawing.Size(89, 22);
            this.textBox148.TabIndex = 307;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 306;
            this.checkBox2.Text = "New File";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 26);
            this.button3.TabIndex = 303;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(221, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 305;
            this.checkBox3.Text = "Auto Read";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(166, 43);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(84, 13);
            this.label47.TabIndex = 301;
            this.label47.Text = "Read Time (ms):";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(6, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 304;
            this.checkBox4.Text = "Log Data";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox149
            // 
            this.textBox149.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox149.Location = new System.Drawing.Point(256, 40);
            this.textBox149.Name = "textBox149";
            this.textBox149.Size = new System.Drawing.Size(42, 20);
            this.textBox149.TabIndex = 302;
            this.textBox149.Text = "750";
            this.textBox149.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label48);
            this.groupBox16.Controls.Add(this.textBox150);
            this.groupBox16.Controls.Add(this.label62);
            this.groupBox16.Controls.Add(this.textBox151);
            this.groupBox16.Controls.Add(this.label63);
            this.groupBox16.Controls.Add(this.textBox152);
            this.groupBox16.Controls.Add(this.label64);
            this.groupBox16.Controls.Add(this.label65);
            this.groupBox16.Controls.Add(this.textBox153);
            this.groupBox16.Controls.Add(this.textBox154);
            this.groupBox16.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(1041, 66);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(156, 126);
            this.groupBox16.TabIndex = 661;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Neutral Related";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(13, 101);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(71, 13);
            this.label48.TabIndex = 422;
            this.label48.Text = "Vector Angle:";
            // 
            // textBox150
            // 
            this.textBox150.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox150.Location = new System.Drawing.Point(86, 101);
            this.textBox150.Name = "textBox150";
            this.textBox150.ReadOnly = true;
            this.textBox150.Size = new System.Drawing.Size(61, 20);
            this.textBox150.TabIndex = 421;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(6, 81);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(78, 13);
            this.label62.TabIndex = 420;
            this.label62.Text = "Vector Current:";
            // 
            // textBox151
            // 
            this.textBox151.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox151.Location = new System.Drawing.Point(86, 80);
            this.textBox151.Name = "textBox151";
            this.textBox151.ReadOnly = true;
            this.textBox151.Size = new System.Drawing.Size(61, 20);
            this.textBox151.TabIndex = 419;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(34, 61);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(50, 13);
            this.label63.TabIndex = 418;
            this.label63.Text = "Samples:";
            // 
            // textBox152
            // 
            this.textBox152.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox152.Location = new System.Drawing.Point(86, 59);
            this.textBox152.Name = "textBox152";
            this.textBox152.ReadOnly = true;
            this.textBox152.Size = new System.Drawing.Size(61, 20);
            this.textBox152.TabIndex = 417;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(16, 41);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(68, 13);
            this.label64.TabIndex = 416;
            this.label64.Text = "Current (DC):";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(40, 22);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 13);
            this.label65.TabIndex = 415;
            this.label65.Text = "Current:";
            // 
            // textBox153
            // 
            this.textBox153.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox153.Location = new System.Drawing.Point(86, 18);
            this.textBox153.Name = "textBox153";
            this.textBox153.ReadOnly = true;
            this.textBox153.Size = new System.Drawing.Size(61, 20);
            this.textBox153.TabIndex = 365;
            // 
            // textBox154
            // 
            this.textBox154.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox154.Location = new System.Drawing.Point(86, 39);
            this.textBox154.Name = "textBox154";
            this.textBox154.ReadOnly = true;
            this.textBox154.Size = new System.Drawing.Size(61, 20);
            this.textBox154.TabIndex = 366;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(1008, 12);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(43, 17);
            this.label55.TabIndex = 662;
            this.label55.Text = "Time:";
            // 
            // textBox_Time
            // 
            this.textBox_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Time.Location = new System.Drawing.Point(1064, 9);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.ReadOnly = true;
            this.textBox_Time.Size = new System.Drawing.Size(133, 23);
            this.textBox_Time.TabIndex = 663;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(1008, 38);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(101, 17);
            this.label66.TabIndex = 664;
            this.label66.Text = "Power Up Sec:";
            // 
            // textBox155
            // 
            this.textBox155.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox155.Location = new System.Drawing.Point(1113, 35);
            this.textBox155.Name = "textBox155";
            this.textBox155.ReadOnly = true;
            this.textBox155.Size = new System.Drawing.Size(84, 23);
            this.textBox155.TabIndex = 665;
            // 
            // textBox_MISCData
            // 
            this.textBox_MISCData.Location = new System.Drawing.Point(819, 428);
            this.textBox_MISCData.Multiline = true;
            this.textBox_MISCData.Name = "textBox_MISCData";
            this.textBox_MISCData.Size = new System.Drawing.Size(381, 67);
            this.textBox_MISCData.TabIndex = 673;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(20, 42);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(68, 13);
            this.label117.TabIndex = 671;
            this.label117.Text = "Loop Cycles:";
            // 
            // textBox_LoopCycles
            // 
            this.textBox_LoopCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoopCycles.Location = new System.Drawing.Point(94, 39);
            this.textBox_LoopCycles.Name = "textBox_LoopCycles";
            this.textBox_LoopCycles.ReadOnly = true;
            this.textBox_LoopCycles.Size = new System.Drawing.Size(63, 20);
            this.textBox_LoopCycles.TabIndex = 672;
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
            this.groupBox21.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox21.Location = new System.Drawing.Point(1041, 193);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(157, 117);
            this.groupBox21.TabIndex = 670;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Reactive";
            // 
            // textBox_ReactiveTimeDeviation
            // 
            this.textBox_ReactiveTimeDeviation.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReactiveTimeDeviation.Location = new System.Drawing.Point(85, 86);
            this.textBox_ReactiveTimeDeviation.Name = "textBox_ReactiveTimeDeviation";
            this.textBox_ReactiveTimeDeviation.Size = new System.Drawing.Size(62, 22);
            this.textBox_ReactiveTimeDeviation.TabIndex = 7;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(16, 88);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(58, 16);
            this.label112.TabIndex = 6;
            this.label112.Text = "Time dev:";
            // 
            // textBox_ReactiveTimeDelay
            // 
            this.textBox_ReactiveTimeDelay.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReactiveTimeDelay.Location = new System.Drawing.Point(85, 62);
            this.textBox_ReactiveTimeDelay.Name = "textBox_ReactiveTimeDelay";
            this.textBox_ReactiveTimeDelay.Size = new System.Drawing.Size(62, 22);
            this.textBox_ReactiveTimeDelay.TabIndex = 5;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(8, 64);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(66, 16);
            this.label111.TabIndex = 4;
            this.label111.Text = "Time delay:";
            // 
            // textBox_ReactiveTimer
            // 
            this.textBox_ReactiveTimer.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReactiveTimer.Location = new System.Drawing.Point(85, 39);
            this.textBox_ReactiveTimer.Name = "textBox_ReactiveTimer";
            this.textBox_ReactiveTimer.Size = new System.Drawing.Size(62, 22);
            this.textBox_ReactiveTimer.TabIndex = 3;
            // 
            // textBox_ReactiveSamples
            // 
            this.textBox_ReactiveSamples.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReactiveSamples.Location = new System.Drawing.Point(85, 16);
            this.textBox_ReactiveSamples.Name = "textBox_ReactiveSamples";
            this.textBox_ReactiveSamples.Size = new System.Drawing.Size(62, 22);
            this.textBox_ReactiveSamples.TabIndex = 2;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(34, 41);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(40, 16);
            this.label110.TabIndex = 1;
            this.label110.Text = "Timer:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(22, 19);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(52, 16);
            this.label109.TabIndex = 0;
            this.label109.Text = "Samples:";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(32, 70);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(56, 13);
            this.label108.TabIndex = 668;
            this.label108.Text = "Battery(V):";
            // 
            // textBox_BatteryVoltage
            // 
            this.textBox_BatteryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BatteryVoltage.Location = new System.Drawing.Point(94, 65);
            this.textBox_BatteryVoltage.Name = "textBox_BatteryVoltage";
            this.textBox_BatteryVoltage.ReadOnly = true;
            this.textBox_BatteryVoltage.Size = new System.Drawing.Size(63, 20);
            this.textBox_BatteryVoltage.TabIndex = 669;
            // 
            // textBox_TempTLV
            // 
            this.textBox_TempTLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TempTLV.Location = new System.Drawing.Point(94, 15);
            this.textBox_TempTLV.Name = "textBox_TempTLV";
            this.textBox_TempTLV.ReadOnly = true;
            this.textBox_TempTLV.Size = new System.Drawing.Size(63, 20);
            this.textBox_TempTLV.TabIndex = 667;
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
            this.groupBox18.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox18.Location = new System.Drawing.Point(980, 313);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(208, 86);
            this.groupBox18.TabIndex = 666;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Phase to Phase";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(7, 35);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(46, 13);
            this.label57.TabIndex = 445;
            this.label57.Text = "Voltage:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(5, 55);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(47, 13);
            this.label56.TabIndex = 444;
            this.label56.Text = "V Angle:";
            // 
            // textBox_VolRY
            // 
            this.textBox_VolRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolRY.Location = new System.Drawing.Point(52, 31);
            this.textBox_VolRY.Name = "textBox_VolRY";
            this.textBox_VolRY.ReadOnly = true;
            this.textBox_VolRY.Size = new System.Drawing.Size(50, 20);
            this.textBox_VolRY.TabIndex = 457;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Red;
            this.label58.Location = new System.Drawing.Point(65, 15);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(28, 13);
            this.label58.TabIndex = 469;
            this.label58.Text = "R-Y";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Blue;
            this.label60.Location = new System.Drawing.Point(166, 14);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(28, 13);
            this.label60.TabIndex = 471;
            this.label60.Text = "B-R";
            // 
            // textBox_AngleBR
            // 
            this.textBox_AngleBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleBR.Location = new System.Drawing.Point(155, 52);
            this.textBox_AngleBR.Name = "textBox_AngleBR";
            this.textBox_AngleBR.ReadOnly = true;
            this.textBox_AngleBR.Size = new System.Drawing.Size(50, 20);
            this.textBox_AngleBR.TabIndex = 462;
            // 
            // textBox_VolBR
            // 
            this.textBox_VolBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolBR.Location = new System.Drawing.Point(155, 31);
            this.textBox_VolBR.Name = "textBox_VolBR";
            this.textBox_VolBR.ReadOnly = true;
            this.textBox_VolBR.Size = new System.Drawing.Size(50, 20);
            this.textBox_VolBR.TabIndex = 461;
            // 
            // textBox_AngleYB
            // 
            this.textBox_AngleYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleYB.Location = new System.Drawing.Point(104, 52);
            this.textBox_AngleYB.Name = "textBox_AngleYB";
            this.textBox_AngleYB.ReadOnly = true;
            this.textBox_AngleYB.Size = new System.Drawing.Size(50, 20);
            this.textBox_AngleYB.TabIndex = 460;
            // 
            // textBox_VolYB
            // 
            this.textBox_VolYB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolYB.Location = new System.Drawing.Point(104, 31);
            this.textBox_VolYB.Name = "textBox_VolYB";
            this.textBox_VolYB.ReadOnly = true;
            this.textBox_VolYB.Size = new System.Drawing.Size(50, 20);
            this.textBox_VolYB.TabIndex = 459;
            // 
            // textBox_AngleRY
            // 
            this.textBox_AngleRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleRY.Location = new System.Drawing.Point(52, 52);
            this.textBox_AngleRY.Name = "textBox_AngleRY";
            this.textBox_AngleRY.ReadOnly = true;
            this.textBox_AngleRY.Size = new System.Drawing.Size(50, 20);
            this.textBox_AngleRY.TabIndex = 458;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Yellow;
            this.label59.Location = new System.Drawing.Point(114, 14);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(27, 13);
            this.label59.TabIndex = 470;
            this.label59.Text = "Y-B";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(51, 18);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(37, 13);
            this.label67.TabIndex = 674;
            this.label67.Text = "Temp:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(7, 94);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(81, 13);
            this.label68.TabIndex = 675;
            this.label68.Text = "Battery RTC(V):";
            // 
            // textBox156
            // 
            this.textBox156.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox156.Location = new System.Drawing.Point(94, 91);
            this.textBox156.Name = "textBox156";
            this.textBox156.ReadOnly = true;
            this.textBox156.Size = new System.Drawing.Size(63, 20);
            this.textBox156.TabIndex = 676;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_TempTLV);
            this.groupBox17.Controls.Add(this.label68);
            this.groupBox17.Controls.Add(this.label67);
            this.groupBox17.Controls.Add(this.textBox156);
            this.groupBox17.Controls.Add(this.textBox_LoopCycles);
            this.groupBox17.Controls.Add(this.label117);
            this.groupBox17.Controls.Add(this.label108);
            this.groupBox17.Controls.Add(this.textBox_BatteryVoltage);
            this.groupBox17.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(872, 68);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(163, 241);
            this.groupBox17.TabIndex = 677;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "MISC";
            this.groupBox17.Enter += new System.EventHandler(this.groupBox17_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar_connectionStatus);
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
            this.tabPage9.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
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
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeUsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar_connectionStatus;
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
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.RadioButton radioButton_CommunicationSerial;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Disconnect;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox_SerialSingleBaudRate;
        private System.Windows.Forms.ComboBox comboBox_SerialSingleCOMPORT;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.CheckBox checkBox_EnergyMeterShowVectorDiagram;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TextBox textBox140;
        private System.Windows.Forms.TextBox textBox141;
        private System.Windows.Forms.TextBox textBox142;
        private System.Windows.Forms.TextBox textBox143;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox144;
        private System.Windows.Forms.TextBox textBox145;
        private System.Windows.Forms.TextBox textBox146;
        private System.Windows.Forms.TextBox textBox147;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox136;
        private System.Windows.Forms.TextBox textBox137;
        private System.Windows.Forms.TextBox textBox138;
        private System.Windows.Forms.TextBox textBox139;
        private System.Windows.Forms.TextBox textBox132;
        private System.Windows.Forms.TextBox textBox133;
        private System.Windows.Forms.TextBox textBox134;
        private System.Windows.Forms.TextBox textBox135;
        private System.Windows.Forms.TextBox textBox128;
        private System.Windows.Forms.TextBox textBox129;
        private System.Windows.Forms.TextBox textBox130;
        private System.Windows.Forms.TextBox textBox131;
        private System.Windows.Forms.TextBox textBox124;
        private System.Windows.Forms.TextBox textBox125;
        private System.Windows.Forms.TextBox textBox126;
        private System.Windows.Forms.TextBox textBox127;
        private System.Windows.Forms.TextBox textBox120;
        private System.Windows.Forms.TextBox textBox121;
        private System.Windows.Forms.TextBox textBox122;
        private System.Windows.Forms.TextBox textBox123;
        private System.Windows.Forms.TextBox textBox113;
        private System.Windows.Forms.TextBox textBox114;
        private System.Windows.Forms.TextBox textBox115;
        private System.Windows.Forms.TextBox textBox119;
        private System.Windows.Forms.TextBox textBox108;
        private System.Windows.Forms.TextBox textBox116;
        private System.Windows.Forms.TextBox textBox117;
        private System.Windows.Forms.TextBox textBox118;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox109;
        private System.Windows.Forms.TextBox textBox110;
        private System.Windows.Forms.TextBox textBox111;
        private System.Windows.Forms.TextBox textBox112;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TextBox textBox105;
        private System.Windows.Forms.TextBox textBox106;
        private System.Windows.Forms.TextBox textBox107;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.TextBox textBox104;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.TextBox textBox92;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.TextBox textBox87;
        private System.Windows.Forms.TextBox textBox88;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_TempTLV;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBox156;
        private System.Windows.Forms.TextBox textBox_LoopCycles;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textBox_BatteryVoltage;
        private System.Windows.Forms.TextBox textBox_MISCData;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TextBox textBox_ReactiveTimeDeviation;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox textBox_ReactiveTimeDelay;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox textBox_ReactiveTimer;
        private System.Windows.Forms.TextBox textBox_ReactiveSamples;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
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
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox155;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox150;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox151;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox152;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBox153;
        private System.Windows.Forms.TextBox textBox154;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox148;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox149;
    }
}

