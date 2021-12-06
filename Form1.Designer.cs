
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
            this.button_SendRepeatStop = new System.Windows.Forms.Button();
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
            this.buttonStringFilterConvert = new System.Windows.Forms.Button();
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
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.checkBox_LogData = new System.Windows.Forms.CheckBox();
            this.checkBox_LogToNewFile = new System.Windows.Forms.CheckBox();
            this.textBox_NewFileName = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox_Temperature = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox_BatteryVoltageRTC = new System.Windows.Forms.TextBox();
            this.textBox_LoopCycles = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.textBox_BatteryVoltage = new System.Windows.Forms.TextBox();
            this.textBox_MISCData = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.textBox_ReactiveTimeDeviation = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox_ReactiveTimeDelay = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.textBox_ReactiveTimer = new System.Windows.Forms.TextBox();
            this.textBox_ReactiveSamples = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
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
            this.label66 = new System.Windows.Forms.Label();
            this.textBox_MetrologyTimer = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox_AngleNeuVector = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox_CurrNeuVector = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox_SamplesN = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox_CurrN = new System.Windows.Forms.TextBox();
            this.textBox_CurrNdc = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.textBox_FEnergyWhExportTotal = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhExportR = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhExportY = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhExportB = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox_FEnergyWhImportR = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhImportY = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhImportB = new System.Windows.Forms.TextBox();
            this.textBox_FEnergyWhImportTotal = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox_EnergyVAhExportTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhExportR = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhExportY = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhExportB = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhImportTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhImportR = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhImportY = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVAhImportB = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ4Total = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ4R = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ4Y = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ4B = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ3Total = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ3R = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ3Y = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ3B = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ2Total = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ2R = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ2Y = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ2B = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ1Total = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ1R = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ1Y = new System.Windows.Forms.TextBox();
            this.textBox_EnergyVARhQ1B = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhExportTotal = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhExportR = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhExportY = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhExportB = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox_EnergyWhImportR = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhImportY = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhImportB = new System.Windows.Forms.TextBox();
            this.textBox_EnergyWhImportTotal = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox_TamperStatus = new System.Windows.Forms.TextBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.radioButton_InputModeNet = new System.Windows.Forms.RadioButton();
            this.radioButton_InputModeFwd = new System.Windows.Forms.RadioButton();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
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
            this.label171 = new System.Windows.Forms.Label();
            this.textBox_ErrorActR = new System.Windows.Forms.TextBox();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.textBox_InputPFFwd = new System.Windows.Forms.TextBox();
            this.label153 = new System.Windows.Forms.Label();
            this.textBox_NeuCurrentAngleCalculated = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.textBox_NeuCurrentCalculated = new System.Windows.Forms.TextBox();
            this.button_InputUpdate = new System.Windows.Forms.Button();
            this.checkBox_ErrorCalculateEnable = new System.Windows.Forms.CheckBox();
            this.textBox_InputFreq = new System.Windows.Forms.TextBox();
            this.label155 = new System.Windows.Forms.Label();
            this.textBox_InputAngRB = new System.Windows.Forms.TextBox();
            this.textBox_ErrorAvg = new System.Windows.Forms.TextBox();
            this.textBox_InputAngRY = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.textBox_InputPFNet = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.textBox_InputVATotalNet = new System.Windows.Forms.TextBox();
            this.textBox_InputVARTotalNet = new System.Windows.Forms.TextBox();
            this.textBox_InputWattTotalNet = new System.Windows.Forms.TextBox();
            this.label160 = new System.Windows.Forms.Label();
            this.textBox_InputVATotalFwd = new System.Windows.Forms.TextBox();
            this.textBox_InputVARTotalFwd = new System.Windows.Forms.TextBox();
            this.textBox_InputWattTotalFwd = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.textBox_InputVAB = new System.Windows.Forms.TextBox();
            this.label162 = new System.Windows.Forms.Label();
            this.textBox_InputVARB = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.textBox_InputWattB = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.textBox_InputVAY = new System.Windows.Forms.TextBox();
            this.textBox_InputVARY = new System.Windows.Forms.TextBox();
            this.textBox_InputWattY = new System.Windows.Forms.TextBox();
            this.textBox_InputVAR = new System.Windows.Forms.TextBox();
            this.textBox_InputVARR = new System.Windows.Forms.TextBox();
            this.textBox_InputWattR = new System.Windows.Forms.TextBox();
            this.textBox_InputAngb = new System.Windows.Forms.TextBox();
            this.textBox_InputAngy = new System.Windows.Forms.TextBox();
            this.textBox_InputAngr = new System.Windows.Forms.TextBox();
            this.label165 = new System.Windows.Forms.Label();
            this.textBox_InputPFB = new System.Windows.Forms.TextBox();
            this.textBox_InputIb = new System.Windows.Forms.TextBox();
            this.textBox_InputVb = new System.Windows.Forms.TextBox();
            this.textBox_InputPFY = new System.Windows.Forms.TextBox();
            this.textBox_InputIy = new System.Windows.Forms.TextBox();
            this.textBox_InputVy = new System.Windows.Forms.TextBox();
            this.textBox_InputPFR = new System.Windows.Forms.TextBox();
            this.textBox_InputIr = new System.Windows.Forms.TextBox();
            this.textBox_InputVr = new System.Windows.Forms.TextBox();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.textBox_THDIb = new System.Windows.Forms.TextBox();
            this.textBox_THDIy = new System.Windows.Forms.TextBox();
            this.textBox_THDIr = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.textBox_THDVb = new System.Windows.Forms.TextBox();
            this.textBox_THDVy = new System.Windows.Forms.TextBox();
            this.textBox_THDVr = new System.Windows.Forms.TextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.textBox_SamplesPerSec = new System.Windows.Forms.TextBox();
            this.textBox_AnglePFBph = new System.Windows.Forms.TextBox();
            this.textBox_AnglePFYph = new System.Windows.Forms.TextBox();
            this.textBox_AnglePFRph = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.textBox_SamplesB = new System.Windows.Forms.TextBox();
            this.textBox_SamplesY = new System.Windows.Forms.TextBox();
            this.textBox_SamplesR = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.textBox_QuadB = new System.Windows.Forms.TextBox();
            this.textBox_FreqB = new System.Windows.Forms.TextBox();
            this.textBox_VAB = new System.Windows.Forms.TextBox();
            this.textBox_VARB = new System.Windows.Forms.TextBox();
            this.textBox_WattB = new System.Windows.Forms.TextBox();
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
            this.textBox_PFR = new System.Windows.Forms.TextBox();
            this.textBox_CurrRdc = new System.Windows.Forms.TextBox();
            this.textBox_CurrR = new System.Windows.Forms.TextBox();
            this.textBox_VolRdc = new System.Windows.Forms.TextBox();
            this.textBox_VolR = new System.Windows.Forms.TextBox();
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
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.checkBox_EnergyMeterShowVectorDiagram = new System.Windows.Forms.CheckBox();
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
            this.timer500ms = new System.Windows.Forms.Timer(this.components);
            this.timer100ms = new System.Windows.Forms.Timer(this.components);
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
            this.tabPage11.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.tabPage10.SuspendLayout();
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
            this.ToolStripMenuItem_Connect.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItem_Connect.Text = "Connect";
            this.ToolStripMenuItem_Connect.Click += new System.EventHandler(this.ToolStripMenuItem_Connect_Click);
            // 
            // ToolStripMenuItem_Disconnect
            // 
            this.ToolStripMenuItem_Disconnect.Name = "ToolStripMenuItem_Disconnect";
            this.ToolStripMenuItem_Disconnect.Size = new System.Drawing.Size(133, 22);
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
            this.label8.Location = new System.Drawing.Point(351, 558);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rx Bytes:";
            // 
            // textBox_DataTrafficRxBytesTotal
            // 
            this.textBox_DataTrafficRxBytesTotal.Location = new System.Drawing.Point(412, 555);
            this.textBox_DataTrafficRxBytesTotal.Name = "textBox_DataTrafficRxBytesTotal";
            this.textBox_DataTrafficRxBytesTotal.Size = new System.Drawing.Size(69, 23);
            this.textBox_DataTrafficRxBytesTotal.TabIndex = 17;
            this.textBox_DataTrafficRxBytesTotal.Text = "0";
            this.textBox_DataTrafficRxBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 557);
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
            this.textBox_DataTrafficTxBytesTotal.Location = new System.Drawing.Point(285, 554);
            this.textBox_DataTrafficTxBytesTotal.Name = "textBox_DataTrafficTxBytesTotal";
            this.textBox_DataTrafficTxBytesTotal.Size = new System.Drawing.Size(60, 23);
            this.textBox_DataTrafficTxBytesTotal.TabIndex = 8;
            this.textBox_DataTrafficTxBytesTotal.Text = "0";
            this.textBox_DataTrafficTxBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton_DataTrafficFormatHEXSpaced
            // 
            this.radioButton_DataTrafficFormatHEXSpaced.AutoSize = true;
            this.radioButton_DataTrafficFormatHEXSpaced.Checked = true;
            this.radioButton_DataTrafficFormatHEXSpaced.Location = new System.Drawing.Point(120, 553);
            this.radioButton_DataTrafficFormatHEXSpaced.Name = "radioButton_DataTrafficFormatHEXSpaced";
            this.radioButton_DataTrafficFormatHEXSpaced.Size = new System.Drawing.Size(100, 21);
            this.radioButton_DataTrafficFormatHEXSpaced.TabIndex = 15;
            this.radioButton_DataTrafficFormatHEXSpaced.TabStop = true;
            this.radioButton_DataTrafficFormatHEXSpaced.Text = "HEX SPACED";
            this.radioButton_DataTrafficFormatHEXSpaced.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTrafficFormatASCII
            // 
            this.radioButton_DataTrafficFormatASCII.AutoSize = true;
            this.radioButton_DataTrafficFormatASCII.Location = new System.Drawing.Point(6, 553);
            this.radioButton_DataTrafficFormatASCII.Name = "radioButton_DataTrafficFormatASCII";
            this.radioButton_DataTrafficFormatASCII.Size = new System.Drawing.Size(61, 21);
            this.radioButton_DataTrafficFormatASCII.TabIndex = 14;
            this.radioButton_DataTrafficFormatASCII.Text = "ASCII";
            this.radioButton_DataTrafficFormatASCII.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTrafficFormatHEX
            // 
            this.radioButton_DataTrafficFormatHEX.AutoSize = true;
            this.radioButton_DataTrafficFormatHEX.Location = new System.Drawing.Point(67, 553);
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
            this.textBox_DataTraffic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.groupBox1.Controls.Add(this.button_SendRepeatStop);
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
            // button_SendRepeatStop
            // 
            this.button_SendRepeatStop.Enabled = false;
            this.button_SendRepeatStop.Location = new System.Drawing.Point(427, 19);
            this.button_SendRepeatStop.Name = "button_SendRepeatStop";
            this.button_SendRepeatStop.Size = new System.Drawing.Size(73, 28);
            this.button_SendRepeatStop.TabIndex = 8;
            this.button_SendRepeatStop.Text = "Stop";
            this.button_SendRepeatStop.UseVisualStyleBackColor = true;
            this.button_SendRepeatStop.Click += new System.EventHandler(this.button_SendRepeatStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Counter: ";
            // 
            // textBox_SendRepeatSentCounter
            // 
            this.textBox_SendRepeatSentCounter.Location = new System.Drawing.Point(374, 21);
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
            this.label3.Location = new System.Drawing.Point(222, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "times: ";
            // 
            // textBox_SendRepeatNoOfTimes
            // 
            this.textBox_SendRepeatNoOfTimes.Location = new System.Drawing.Point(267, 20);
            this.textBox_SendRepeatNoOfTimes.Name = "textBox_SendRepeatNoOfTimes";
            this.textBox_SendRepeatNoOfTimes.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatNoOfTimes.TabIndex = 4;
            this.textBox_SendRepeatNoOfTimes.Text = "86400";
            this.textBox_SendRepeatNoOfTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "time (ms):";
            // 
            // textBox_SendRepeatTime
            // 
            this.textBox_SendRepeatTime.Location = new System.Drawing.Point(177, 21);
            this.textBox_SendRepeatTime.Name = "textBox_SendRepeatTime";
            this.textBox_SendRepeatTime.Size = new System.Drawing.Size(43, 23);
            this.textBox_SendRepeatTime.TabIndex = 2;
            this.textBox_SendRepeatTime.Text = "1000";
            this.textBox_SendRepeatTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_SendRepeat
            // 
            this.checkBox_SendRepeat.AutoSize = true;
            this.checkBox_SendRepeat.Checked = true;
            this.checkBox_SendRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SendRepeat.Location = new System.Drawing.Point(8, 23);
            this.checkBox_SendRepeat.Name = "checkBox_SendRepeat";
            this.checkBox_SendRepeat.Size = new System.Drawing.Size(98, 21);
            this.checkBox_SendRepeat.TabIndex = 1;
            this.checkBox_SendRepeat.Text = "Send Repeat";
            this.checkBox_SendRepeat.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(506, 18);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(73, 28);
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
            this.groupBox5.Controls.Add(this.buttonStringFilterConvert);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveTab);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveLF);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveCR);
            this.groupBox5.Controls.Add(this.checkBoxStringFilterRemoveSpace);
            this.groupBox5.Location = new System.Drawing.Point(14, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 151);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "String Filter";
            // 
            // buttonStringFilterConvert
            // 
            this.buttonStringFilterConvert.Location = new System.Drawing.Point(6, 106);
            this.buttonStringFilterConvert.Name = "buttonStringFilterConvert";
            this.buttonStringFilterConvert.Size = new System.Drawing.Size(117, 35);
            this.buttonStringFilterConvert.TabIndex = 8;
            this.buttonStringFilterConvert.Text = "Convert";
            this.buttonStringFilterConvert.UseVisualStyleBackColor = true;
            this.buttonStringFilterConvert.Click += new System.EventHandler(this.buttonStringFilterConvert_Click);
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
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage11.Controls.Add(this.groupBox17);
            this.tabPage11.Controls.Add(this.textBox_MISCData);
            this.tabPage11.Controls.Add(this.groupBox21);
            this.tabPage11.Controls.Add(this.groupBox18);
            this.tabPage11.Controls.Add(this.label66);
            this.tabPage11.Controls.Add(this.textBox_MetrologyTimer);
            this.tabPage11.Controls.Add(this.label55);
            this.tabPage11.Controls.Add(this.textBox_Time);
            this.tabPage11.Controls.Add(this.groupBox16);
            this.tabPage11.Controls.Add(this.groupBox15);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhExportTotal);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhExportR);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhExportY);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhExportB);
            this.tabPage11.Controls.Add(this.label44);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhImportR);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhImportY);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhImportB);
            this.tabPage11.Controls.Add(this.textBox_FEnergyWhImportTotal);
            this.tabPage11.Controls.Add(this.label46);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhExportTotal);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhExportR);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhExportY);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhExportB);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhImportTotal);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhImportR);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhImportY);
            this.tabPage11.Controls.Add(this.textBox_EnergyVAhImportB);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ4Total);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ4R);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ4Y);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ4B);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ3Total);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ3R);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ3Y);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ3B);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ2Total);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ2R);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ2Y);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ2B);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ1Total);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ1R);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ1Y);
            this.tabPage11.Controls.Add(this.textBox_EnergyVARhQ1B);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhExportTotal);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhExportR);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhExportY);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhExportB);
            this.tabPage11.Controls.Add(this.label61);
            this.tabPage11.Controls.Add(this.label54);
            this.tabPage11.Controls.Add(this.label53);
            this.tabPage11.Controls.Add(this.label52);
            this.tabPage11.Controls.Add(this.label51);
            this.tabPage11.Controls.Add(this.label50);
            this.tabPage11.Controls.Add(this.label49);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhImportR);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhImportY);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhImportB);
            this.tabPage11.Controls.Add(this.textBox_EnergyWhImportTotal);
            this.tabPage11.Controls.Add(this.label45);
            this.tabPage11.Controls.Add(this.textBox_TamperStatus);
            this.tabPage11.Controls.Add(this.groupBox30);
            this.tabPage11.Controls.Add(this.textBox_THDIb);
            this.tabPage11.Controls.Add(this.textBox_THDIy);
            this.tabPage11.Controls.Add(this.textBox_THDIr);
            this.tabPage11.Controls.Add(this.label126);
            this.tabPage11.Controls.Add(this.textBox_THDVb);
            this.tabPage11.Controls.Add(this.textBox_THDVy);
            this.tabPage11.Controls.Add(this.textBox_THDVr);
            this.tabPage11.Controls.Add(this.label133);
            this.tabPage11.Controls.Add(this.textBox_SamplesPerSec);
            this.tabPage11.Controls.Add(this.textBox_AnglePFBph);
            this.tabPage11.Controls.Add(this.textBox_AnglePFYph);
            this.tabPage11.Controls.Add(this.textBox_AnglePFRph);
            this.tabPage11.Controls.Add(this.label134);
            this.tabPage11.Controls.Add(this.textBox_SamplesB);
            this.tabPage11.Controls.Add(this.textBox_SamplesY);
            this.tabPage11.Controls.Add(this.textBox_SamplesR);
            this.tabPage11.Controls.Add(this.label135);
            this.tabPage11.Controls.Add(this.textBox_QuadB);
            this.tabPage11.Controls.Add(this.textBox_FreqB);
            this.tabPage11.Controls.Add(this.textBox_VAB);
            this.tabPage11.Controls.Add(this.textBox_VARB);
            this.tabPage11.Controls.Add(this.textBox_WattB);
            this.tabPage11.Controls.Add(this.textBox_PFB);
            this.tabPage11.Controls.Add(this.textBox_CurrBdc);
            this.tabPage11.Controls.Add(this.textBox_CurrB);
            this.tabPage11.Controls.Add(this.textBox_VolBdc);
            this.tabPage11.Controls.Add(this.textBox_VolB);
            this.tabPage11.Controls.Add(this.textBox_QuadY);
            this.tabPage11.Controls.Add(this.textBox_FreqY);
            this.tabPage11.Controls.Add(this.textBox_VAY);
            this.tabPage11.Controls.Add(this.textBox_VARY);
            this.tabPage11.Controls.Add(this.textBox_WattY);
            this.tabPage11.Controls.Add(this.textBox_PFY);
            this.tabPage11.Controls.Add(this.textBox_CurrYdc);
            this.tabPage11.Controls.Add(this.textBox_CurrY);
            this.tabPage11.Controls.Add(this.textBox_VolYdc);
            this.tabPage11.Controls.Add(this.textBox_VolY);
            this.tabPage11.Controls.Add(this.textBox_QuadNet);
            this.tabPage11.Controls.Add(this.textBox_FreqNet);
            this.tabPage11.Controls.Add(this.textBox_VANet);
            this.tabPage11.Controls.Add(this.textBox_VARNet);
            this.tabPage11.Controls.Add(this.textBox_WattNet);
            this.tabPage11.Controls.Add(this.textBox_PFNet);
            this.tabPage11.Controls.Add(this.textBox_QuadR);
            this.tabPage11.Controls.Add(this.textBox_FreqR);
            this.tabPage11.Controls.Add(this.textBox_VAR);
            this.tabPage11.Controls.Add(this.textBox_VARR);
            this.tabPage11.Controls.Add(this.textBox_WattR);
            this.tabPage11.Controls.Add(this.textBox_PFR);
            this.tabPage11.Controls.Add(this.textBox_CurrRdc);
            this.tabPage11.Controls.Add(this.textBox_CurrR);
            this.tabPage11.Controls.Add(this.textBox_VolRdc);
            this.tabPage11.Controls.Add(this.textBox_VolR);
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
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1206, 562);
            this.tabPage11.TabIndex = 5;
            this.tabPage11.Text = "Instant data";
            // 
            // checkBox_LogData
            // 
            this.checkBox_LogData.AutoSize = true;
            this.checkBox_LogData.Checked = true;
            this.checkBox_LogData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LogData.Enabled = false;
            this.checkBox_LogData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_LogData.Location = new System.Drawing.Point(6, 19);
            this.checkBox_LogData.Name = "checkBox_LogData";
            this.checkBox_LogData.Size = new System.Drawing.Size(70, 17);
            this.checkBox_LogData.TabIndex = 304;
            this.checkBox_LogData.Text = "Log Data";
            this.checkBox_LogData.UseVisualStyleBackColor = true;
            // 
            // checkBox_LogToNewFile
            // 
            this.checkBox_LogToNewFile.AutoSize = true;
            this.checkBox_LogToNewFile.Enabled = false;
            this.checkBox_LogToNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_LogToNewFile.Location = new System.Drawing.Point(82, 19);
            this.checkBox_LogToNewFile.Name = "checkBox_LogToNewFile";
            this.checkBox_LogToNewFile.Size = new System.Drawing.Size(67, 17);
            this.checkBox_LogToNewFile.TabIndex = 306;
            this.checkBox_LogToNewFile.Text = "New File";
            this.checkBox_LogToNewFile.UseVisualStyleBackColor = true;
            // 
            // textBox_NewFileName
            // 
            this.textBox_NewFileName.Enabled = false;
            this.textBox_NewFileName.Location = new System.Drawing.Point(5, 38);
            this.textBox_NewFileName.Name = "textBox_NewFileName";
            this.textBox_NewFileName.Size = new System.Drawing.Size(239, 22);
            this.textBox_NewFileName.TabIndex = 307;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_Temperature);
            this.groupBox17.Controls.Add(this.label68);
            this.groupBox17.Controls.Add(this.label67);
            this.groupBox17.Controls.Add(this.textBox_BatteryVoltageRTC);
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
            // 
            // textBox_Temperature
            // 
            this.textBox_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Temperature.Location = new System.Drawing.Point(94, 15);
            this.textBox_Temperature.Name = "textBox_Temperature";
            this.textBox_Temperature.ReadOnly = true;
            this.textBox_Temperature.Size = new System.Drawing.Size(63, 20);
            this.textBox_Temperature.TabIndex = 667;
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
            // textBox_BatteryVoltageRTC
            // 
            this.textBox_BatteryVoltageRTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BatteryVoltageRTC.Location = new System.Drawing.Point(94, 91);
            this.textBox_BatteryVoltageRTC.Name = "textBox_BatteryVoltageRTC";
            this.textBox_BatteryVoltageRTC.ReadOnly = true;
            this.textBox_BatteryVoltageRTC.Size = new System.Drawing.Size(63, 20);
            this.textBox_BatteryVoltageRTC.TabIndex = 676;
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
            // textBox_MISCData
            // 
            this.textBox_MISCData.Location = new System.Drawing.Point(819, 428);
            this.textBox_MISCData.Multiline = true;
            this.textBox_MISCData.Name = "textBox_MISCData";
            this.textBox_MISCData.Size = new System.Drawing.Size(381, 67);
            this.textBox_MISCData.TabIndex = 673;
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
            // textBox_MetrologyTimer
            // 
            this.textBox_MetrologyTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MetrologyTimer.Location = new System.Drawing.Point(1113, 35);
            this.textBox_MetrologyTimer.Name = "textBox_MetrologyTimer";
            this.textBox_MetrologyTimer.ReadOnly = true;
            this.textBox_MetrologyTimer.Size = new System.Drawing.Size(84, 23);
            this.textBox_MetrologyTimer.TabIndex = 665;
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
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label48);
            this.groupBox16.Controls.Add(this.textBox_AngleNeuVector);
            this.groupBox16.Controls.Add(this.label62);
            this.groupBox16.Controls.Add(this.textBox_CurrNeuVector);
            this.groupBox16.Controls.Add(this.label63);
            this.groupBox16.Controls.Add(this.textBox_SamplesN);
            this.groupBox16.Controls.Add(this.label64);
            this.groupBox16.Controls.Add(this.label65);
            this.groupBox16.Controls.Add(this.textBox_CurrN);
            this.groupBox16.Controls.Add(this.textBox_CurrNdc);
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
            // textBox_AngleNeuVector
            // 
            this.textBox_AngleNeuVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AngleNeuVector.Location = new System.Drawing.Point(86, 101);
            this.textBox_AngleNeuVector.Name = "textBox_AngleNeuVector";
            this.textBox_AngleNeuVector.ReadOnly = true;
            this.textBox_AngleNeuVector.Size = new System.Drawing.Size(61, 20);
            this.textBox_AngleNeuVector.TabIndex = 421;
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
            // textBox_CurrNeuVector
            // 
            this.textBox_CurrNeuVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrNeuVector.Location = new System.Drawing.Point(86, 80);
            this.textBox_CurrNeuVector.Name = "textBox_CurrNeuVector";
            this.textBox_CurrNeuVector.ReadOnly = true;
            this.textBox_CurrNeuVector.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrNeuVector.TabIndex = 419;
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
            // textBox_SamplesN
            // 
            this.textBox_SamplesN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesN.Location = new System.Drawing.Point(86, 59);
            this.textBox_SamplesN.Name = "textBox_SamplesN";
            this.textBox_SamplesN.ReadOnly = true;
            this.textBox_SamplesN.Size = new System.Drawing.Size(61, 20);
            this.textBox_SamplesN.TabIndex = 417;
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
            // textBox_CurrN
            // 
            this.textBox_CurrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrN.Location = new System.Drawing.Point(86, 18);
            this.textBox_CurrN.Name = "textBox_CurrN";
            this.textBox_CurrN.ReadOnly = true;
            this.textBox_CurrN.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrN.TabIndex = 365;
            // 
            // textBox_CurrNdc
            // 
            this.textBox_CurrNdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrNdc.Location = new System.Drawing.Point(86, 39);
            this.textBox_CurrNdc.Name = "textBox_CurrNdc";
            this.textBox_CurrNdc.ReadOnly = true;
            this.textBox_CurrNdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrNdc.TabIndex = 366;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox_NewFileName);
            this.groupBox15.Controls.Add(this.checkBox_LogToNewFile);
            this.groupBox15.Controls.Add(this.checkBox_LogData);
            this.groupBox15.Controls.Add(this.button_Read);
            this.groupBox15.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(6, 379);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(399, 64);
            this.groupBox15.TabIndex = 660;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Read Setup";
            // 
            // button_Read
            // 
            this.button_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Read.Location = new System.Drawing.Point(249, 12);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(146, 48);
            this.button_Read.TabIndex = 303;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // textBox_FEnergyWhExportTotal
            // 
            this.textBox_FEnergyWhExportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhExportTotal.Location = new System.Drawing.Point(734, 519);
            this.textBox_FEnergyWhExportTotal.Name = "textBox_FEnergyWhExportTotal";
            this.textBox_FEnergyWhExportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhExportTotal.TabIndex = 659;
            // 
            // textBox_FEnergyWhExportR
            // 
            this.textBox_FEnergyWhExportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_FEnergyWhExportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhExportR.Location = new System.Drawing.Point(486, 519);
            this.textBox_FEnergyWhExportR.Name = "textBox_FEnergyWhExportR";
            this.textBox_FEnergyWhExportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhExportR.TabIndex = 656;
            // 
            // textBox_FEnergyWhExportY
            // 
            this.textBox_FEnergyWhExportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_FEnergyWhExportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhExportY.Location = new System.Drawing.Point(568, 519);
            this.textBox_FEnergyWhExportY.Name = "textBox_FEnergyWhExportY";
            this.textBox_FEnergyWhExportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhExportY.TabIndex = 657;
            // 
            // textBox_FEnergyWhExportB
            // 
            this.textBox_FEnergyWhExportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_FEnergyWhExportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhExportB.Location = new System.Drawing.Point(652, 519);
            this.textBox_FEnergyWhExportB.Name = "textBox_FEnergyWhExportB";
            this.textBox_FEnergyWhExportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhExportB.TabIndex = 658;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(405, 518);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 655;
            this.label44.Text = "FEnergy(2.8.0):";
            // 
            // textBox_FEnergyWhImportR
            // 
            this.textBox_FEnergyWhImportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_FEnergyWhImportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhImportR.Location = new System.Drawing.Point(486, 496);
            this.textBox_FEnergyWhImportR.Name = "textBox_FEnergyWhImportR";
            this.textBox_FEnergyWhImportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhImportR.TabIndex = 651;
            // 
            // textBox_FEnergyWhImportY
            // 
            this.textBox_FEnergyWhImportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_FEnergyWhImportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhImportY.Location = new System.Drawing.Point(568, 496);
            this.textBox_FEnergyWhImportY.Name = "textBox_FEnergyWhImportY";
            this.textBox_FEnergyWhImportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhImportY.TabIndex = 653;
            // 
            // textBox_FEnergyWhImportB
            // 
            this.textBox_FEnergyWhImportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_FEnergyWhImportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhImportB.Location = new System.Drawing.Point(652, 496);
            this.textBox_FEnergyWhImportB.Name = "textBox_FEnergyWhImportB";
            this.textBox_FEnergyWhImportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhImportB.TabIndex = 654;
            // 
            // textBox_FEnergyWhImportTotal
            // 
            this.textBox_FEnergyWhImportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FEnergyWhImportTotal.Location = new System.Drawing.Point(734, 496);
            this.textBox_FEnergyWhImportTotal.Name = "textBox_FEnergyWhImportTotal";
            this.textBox_FEnergyWhImportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_FEnergyWhImportTotal.TabIndex = 652;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(404, 496);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(79, 13);
            this.label46.TabIndex = 650;
            this.label46.Text = "FEnergy(1.8.0):";
            // 
            // textBox_EnergyVAhExportTotal
            // 
            this.textBox_EnergyVAhExportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhExportTotal.Location = new System.Drawing.Point(735, 474);
            this.textBox_EnergyVAhExportTotal.Name = "textBox_EnergyVAhExportTotal";
            this.textBox_EnergyVAhExportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhExportTotal.TabIndex = 649;
            // 
            // textBox_EnergyVAhExportR
            // 
            this.textBox_EnergyVAhExportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVAhExportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhExportR.Location = new System.Drawing.Point(487, 474);
            this.textBox_EnergyVAhExportR.Name = "textBox_EnergyVAhExportR";
            this.textBox_EnergyVAhExportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhExportR.TabIndex = 646;
            // 
            // textBox_EnergyVAhExportY
            // 
            this.textBox_EnergyVAhExportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVAhExportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhExportY.Location = new System.Drawing.Point(569, 474);
            this.textBox_EnergyVAhExportY.Name = "textBox_EnergyVAhExportY";
            this.textBox_EnergyVAhExportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhExportY.TabIndex = 647;
            // 
            // textBox_EnergyVAhExportB
            // 
            this.textBox_EnergyVAhExportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVAhExportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhExportB.Location = new System.Drawing.Point(653, 474);
            this.textBox_EnergyVAhExportB.Name = "textBox_EnergyVAhExportB";
            this.textBox_EnergyVAhExportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhExportB.TabIndex = 648;
            // 
            // textBox_EnergyVAhImportTotal
            // 
            this.textBox_EnergyVAhImportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhImportTotal.Location = new System.Drawing.Point(735, 453);
            this.textBox_EnergyVAhImportTotal.Name = "textBox_EnergyVAhImportTotal";
            this.textBox_EnergyVAhImportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhImportTotal.TabIndex = 645;
            // 
            // textBox_EnergyVAhImportR
            // 
            this.textBox_EnergyVAhImportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVAhImportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhImportR.Location = new System.Drawing.Point(487, 453);
            this.textBox_EnergyVAhImportR.Name = "textBox_EnergyVAhImportR";
            this.textBox_EnergyVAhImportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhImportR.TabIndex = 642;
            // 
            // textBox_EnergyVAhImportY
            // 
            this.textBox_EnergyVAhImportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVAhImportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhImportY.Location = new System.Drawing.Point(569, 453);
            this.textBox_EnergyVAhImportY.Name = "textBox_EnergyVAhImportY";
            this.textBox_EnergyVAhImportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhImportY.TabIndex = 643;
            // 
            // textBox_EnergyVAhImportB
            // 
            this.textBox_EnergyVAhImportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVAhImportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVAhImportB.Location = new System.Drawing.Point(653, 453);
            this.textBox_EnergyVAhImportB.Name = "textBox_EnergyVAhImportB";
            this.textBox_EnergyVAhImportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVAhImportB.TabIndex = 644;
            // 
            // textBox_EnergyVARhQ4Total
            // 
            this.textBox_EnergyVARhQ4Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ4Total.Location = new System.Drawing.Point(736, 431);
            this.textBox_EnergyVARhQ4Total.Name = "textBox_EnergyVARhQ4Total";
            this.textBox_EnergyVARhQ4Total.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ4Total.TabIndex = 641;
            // 
            // textBox_EnergyVARhQ4R
            // 
            this.textBox_EnergyVARhQ4R.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVARhQ4R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ4R.Location = new System.Drawing.Point(488, 431);
            this.textBox_EnergyVARhQ4R.Name = "textBox_EnergyVARhQ4R";
            this.textBox_EnergyVARhQ4R.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ4R.TabIndex = 638;
            // 
            // textBox_EnergyVARhQ4Y
            // 
            this.textBox_EnergyVARhQ4Y.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVARhQ4Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ4Y.Location = new System.Drawing.Point(570, 431);
            this.textBox_EnergyVARhQ4Y.Name = "textBox_EnergyVARhQ4Y";
            this.textBox_EnergyVARhQ4Y.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ4Y.TabIndex = 639;
            // 
            // textBox_EnergyVARhQ4B
            // 
            this.textBox_EnergyVARhQ4B.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVARhQ4B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ4B.Location = new System.Drawing.Point(654, 431);
            this.textBox_EnergyVARhQ4B.Name = "textBox_EnergyVARhQ4B";
            this.textBox_EnergyVARhQ4B.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ4B.TabIndex = 640;
            // 
            // textBox_EnergyVARhQ3Total
            // 
            this.textBox_EnergyVARhQ3Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ3Total.Location = new System.Drawing.Point(736, 410);
            this.textBox_EnergyVARhQ3Total.Name = "textBox_EnergyVARhQ3Total";
            this.textBox_EnergyVARhQ3Total.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ3Total.TabIndex = 637;
            // 
            // textBox_EnergyVARhQ3R
            // 
            this.textBox_EnergyVARhQ3R.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVARhQ3R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ3R.Location = new System.Drawing.Point(488, 410);
            this.textBox_EnergyVARhQ3R.Name = "textBox_EnergyVARhQ3R";
            this.textBox_EnergyVARhQ3R.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ3R.TabIndex = 634;
            // 
            // textBox_EnergyVARhQ3Y
            // 
            this.textBox_EnergyVARhQ3Y.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVARhQ3Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ3Y.Location = new System.Drawing.Point(570, 410);
            this.textBox_EnergyVARhQ3Y.Name = "textBox_EnergyVARhQ3Y";
            this.textBox_EnergyVARhQ3Y.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ3Y.TabIndex = 635;
            // 
            // textBox_EnergyVARhQ3B
            // 
            this.textBox_EnergyVARhQ3B.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVARhQ3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ3B.Location = new System.Drawing.Point(654, 410);
            this.textBox_EnergyVARhQ3B.Name = "textBox_EnergyVARhQ3B";
            this.textBox_EnergyVARhQ3B.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ3B.TabIndex = 636;
            // 
            // textBox_EnergyVARhQ2Total
            // 
            this.textBox_EnergyVARhQ2Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ2Total.Location = new System.Drawing.Point(736, 388);
            this.textBox_EnergyVARhQ2Total.Name = "textBox_EnergyVARhQ2Total";
            this.textBox_EnergyVARhQ2Total.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ2Total.TabIndex = 633;
            // 
            // textBox_EnergyVARhQ2R
            // 
            this.textBox_EnergyVARhQ2R.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVARhQ2R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ2R.Location = new System.Drawing.Point(488, 388);
            this.textBox_EnergyVARhQ2R.Name = "textBox_EnergyVARhQ2R";
            this.textBox_EnergyVARhQ2R.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ2R.TabIndex = 630;
            // 
            // textBox_EnergyVARhQ2Y
            // 
            this.textBox_EnergyVARhQ2Y.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVARhQ2Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ2Y.Location = new System.Drawing.Point(570, 388);
            this.textBox_EnergyVARhQ2Y.Name = "textBox_EnergyVARhQ2Y";
            this.textBox_EnergyVARhQ2Y.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ2Y.TabIndex = 631;
            // 
            // textBox_EnergyVARhQ2B
            // 
            this.textBox_EnergyVARhQ2B.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVARhQ2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ2B.Location = new System.Drawing.Point(654, 388);
            this.textBox_EnergyVARhQ2B.Name = "textBox_EnergyVARhQ2B";
            this.textBox_EnergyVARhQ2B.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ2B.TabIndex = 632;
            // 
            // textBox_EnergyVARhQ1Total
            // 
            this.textBox_EnergyVARhQ1Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ1Total.Location = new System.Drawing.Point(736, 365);
            this.textBox_EnergyVARhQ1Total.Name = "textBox_EnergyVARhQ1Total";
            this.textBox_EnergyVARhQ1Total.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ1Total.TabIndex = 629;
            // 
            // textBox_EnergyVARhQ1R
            // 
            this.textBox_EnergyVARhQ1R.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyVARhQ1R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ1R.Location = new System.Drawing.Point(488, 365);
            this.textBox_EnergyVARhQ1R.Name = "textBox_EnergyVARhQ1R";
            this.textBox_EnergyVARhQ1R.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ1R.TabIndex = 626;
            // 
            // textBox_EnergyVARhQ1Y
            // 
            this.textBox_EnergyVARhQ1Y.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyVARhQ1Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ1Y.Location = new System.Drawing.Point(570, 365);
            this.textBox_EnergyVARhQ1Y.Name = "textBox_EnergyVARhQ1Y";
            this.textBox_EnergyVARhQ1Y.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ1Y.TabIndex = 627;
            // 
            // textBox_EnergyVARhQ1B
            // 
            this.textBox_EnergyVARhQ1B.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyVARhQ1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyVARhQ1B.Location = new System.Drawing.Point(654, 365);
            this.textBox_EnergyVARhQ1B.Name = "textBox_EnergyVARhQ1B";
            this.textBox_EnergyVARhQ1B.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyVARhQ1B.TabIndex = 628;
            // 
            // textBox_EnergyWhExportTotal
            // 
            this.textBox_EnergyWhExportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhExportTotal.Location = new System.Drawing.Point(736, 343);
            this.textBox_EnergyWhExportTotal.Name = "textBox_EnergyWhExportTotal";
            this.textBox_EnergyWhExportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhExportTotal.TabIndex = 625;
            // 
            // textBox_EnergyWhExportR
            // 
            this.textBox_EnergyWhExportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyWhExportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhExportR.Location = new System.Drawing.Point(488, 343);
            this.textBox_EnergyWhExportR.Name = "textBox_EnergyWhExportR";
            this.textBox_EnergyWhExportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhExportR.TabIndex = 621;
            // 
            // textBox_EnergyWhExportY
            // 
            this.textBox_EnergyWhExportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyWhExportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhExportY.Location = new System.Drawing.Point(570, 343);
            this.textBox_EnergyWhExportY.Name = "textBox_EnergyWhExportY";
            this.textBox_EnergyWhExportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhExportY.TabIndex = 623;
            // 
            // textBox_EnergyWhExportB
            // 
            this.textBox_EnergyWhExportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyWhExportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhExportB.Location = new System.Drawing.Point(654, 343);
            this.textBox_EnergyWhExportB.Name = "textBox_EnergyWhExportB";
            this.textBox_EnergyWhExportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhExportB.TabIndex = 624;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(401, 473);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(79, 13);
            this.label61.TabIndex = 620;
            this.label61.Text = "Energy(10.8.0):";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(407, 452);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(73, 13);
            this.label54.TabIndex = 619;
            this.label54.Text = "Energy(9.8.0):";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(407, 430);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(73, 13);
            this.label53.TabIndex = 618;
            this.label53.Text = "Energy(8.8.0):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(407, 409);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(73, 13);
            this.label52.TabIndex = 617;
            this.label52.Text = "Energy(7.8.0):";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(407, 387);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 13);
            this.label51.TabIndex = 616;
            this.label51.Text = "Energy(6.8.0):";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(407, 364);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 13);
            this.label50.TabIndex = 615;
            this.label50.Text = "Energy(5.8.0):";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(407, 342);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 13);
            this.label49.TabIndex = 614;
            this.label49.Text = "Energy(2.8.0):";
            // 
            // textBox_EnergyWhImportR
            // 
            this.textBox_EnergyWhImportR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_EnergyWhImportR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhImportR.Location = new System.Drawing.Point(488, 321);
            this.textBox_EnergyWhImportR.Name = "textBox_EnergyWhImportR";
            this.textBox_EnergyWhImportR.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhImportR.TabIndex = 602;
            // 
            // textBox_EnergyWhImportY
            // 
            this.textBox_EnergyWhImportY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_EnergyWhImportY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhImportY.Location = new System.Drawing.Point(570, 321);
            this.textBox_EnergyWhImportY.Name = "textBox_EnergyWhImportY";
            this.textBox_EnergyWhImportY.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhImportY.TabIndex = 604;
            // 
            // textBox_EnergyWhImportB
            // 
            this.textBox_EnergyWhImportB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_EnergyWhImportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhImportB.Location = new System.Drawing.Point(654, 321);
            this.textBox_EnergyWhImportB.Name = "textBox_EnergyWhImportB";
            this.textBox_EnergyWhImportB.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhImportB.TabIndex = 605;
            // 
            // textBox_EnergyWhImportTotal
            // 
            this.textBox_EnergyWhImportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EnergyWhImportTotal.Location = new System.Drawing.Point(736, 321);
            this.textBox_EnergyWhImportTotal.Name = "textBox_EnergyWhImportTotal";
            this.textBox_EnergyWhImportTotal.Size = new System.Drawing.Size(78, 20);
            this.textBox_EnergyWhImportTotal.TabIndex = 603;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(409, 321);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(73, 13);
            this.label45.TabIndex = 601;
            this.label45.Text = "Energy(1.8.0):";
            // 
            // textBox_TamperStatus
            // 
            this.textBox_TamperStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_TamperStatus.Location = new System.Drawing.Point(819, 501);
            this.textBox_TamperStatus.Multiline = true;
            this.textBox_TamperStatus.Name = "textBox_TamperStatus";
            this.textBox_TamperStatus.Size = new System.Drawing.Size(381, 55);
            this.textBox_TamperStatus.TabIndex = 406;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.groupBox19);
            this.groupBox30.Controls.Add(this.groupBox31);
            this.groupBox30.Controls.Add(this.textBox_InputPFFwd);
            this.groupBox30.Controls.Add(this.label153);
            this.groupBox30.Controls.Add(this.textBox_NeuCurrentAngleCalculated);
            this.groupBox30.Controls.Add(this.label154);
            this.groupBox30.Controls.Add(this.textBox_NeuCurrentCalculated);
            this.groupBox30.Controls.Add(this.button_InputUpdate);
            this.groupBox30.Controls.Add(this.checkBox_ErrorCalculateEnable);
            this.groupBox30.Controls.Add(this.textBox_InputFreq);
            this.groupBox30.Controls.Add(this.label155);
            this.groupBox30.Controls.Add(this.textBox_InputAngRB);
            this.groupBox30.Controls.Add(this.textBox_ErrorAvg);
            this.groupBox30.Controls.Add(this.textBox_InputAngRY);
            this.groupBox30.Controls.Add(this.label156);
            this.groupBox30.Controls.Add(this.label157);
            this.groupBox30.Controls.Add(this.label158);
            this.groupBox30.Controls.Add(this.textBox_InputPFNet);
            this.groupBox30.Controls.Add(this.label159);
            this.groupBox30.Controls.Add(this.textBox_InputVATotalNet);
            this.groupBox30.Controls.Add(this.textBox_InputVARTotalNet);
            this.groupBox30.Controls.Add(this.textBox_InputWattTotalNet);
            this.groupBox30.Controls.Add(this.label160);
            this.groupBox30.Controls.Add(this.textBox_InputVATotalFwd);
            this.groupBox30.Controls.Add(this.textBox_InputVARTotalFwd);
            this.groupBox30.Controls.Add(this.textBox_InputWattTotalFwd);
            this.groupBox30.Controls.Add(this.label161);
            this.groupBox30.Controls.Add(this.textBox_InputVAB);
            this.groupBox30.Controls.Add(this.label162);
            this.groupBox30.Controls.Add(this.textBox_InputVARB);
            this.groupBox30.Controls.Add(this.label163);
            this.groupBox30.Controls.Add(this.textBox_InputWattB);
            this.groupBox30.Controls.Add(this.label164);
            this.groupBox30.Controls.Add(this.textBox_InputVAY);
            this.groupBox30.Controls.Add(this.textBox_InputVARY);
            this.groupBox30.Controls.Add(this.textBox_InputWattY);
            this.groupBox30.Controls.Add(this.textBox_InputVAR);
            this.groupBox30.Controls.Add(this.textBox_InputVARR);
            this.groupBox30.Controls.Add(this.textBox_InputWattR);
            this.groupBox30.Controls.Add(this.textBox_InputAngb);
            this.groupBox30.Controls.Add(this.textBox_InputAngy);
            this.groupBox30.Controls.Add(this.textBox_InputAngr);
            this.groupBox30.Controls.Add(this.label165);
            this.groupBox30.Controls.Add(this.textBox_InputPFB);
            this.groupBox30.Controls.Add(this.textBox_InputIb);
            this.groupBox30.Controls.Add(this.textBox_InputVb);
            this.groupBox30.Controls.Add(this.textBox_InputPFY);
            this.groupBox30.Controls.Add(this.textBox_InputIy);
            this.groupBox30.Controls.Add(this.textBox_InputVy);
            this.groupBox30.Controls.Add(this.textBox_InputPFR);
            this.groupBox30.Controls.Add(this.textBox_InputIr);
            this.groupBox30.Controls.Add(this.textBox_InputVr);
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
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.radioButton_InputModeNet);
            this.groupBox19.Controls.Add(this.radioButton_InputModeFwd);
            this.groupBox19.Location = new System.Drawing.Point(262, 29);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(126, 59);
            this.groupBox19.TabIndex = 534;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Mode";
            // 
            // radioButton_InputModeNet
            // 
            this.radioButton_InputModeNet.AutoSize = true;
            this.radioButton_InputModeNet.Checked = true;
            this.radioButton_InputModeNet.Location = new System.Drawing.Point(6, 34);
            this.radioButton_InputModeNet.Name = "radioButton_InputModeNet";
            this.radioButton_InputModeNet.Size = new System.Drawing.Size(93, 20);
            this.radioButton_InputModeNet.TabIndex = 1;
            this.radioButton_InputModeNet.TabStop = true;
            this.radioButton_InputModeNet.Text = "Net Metering";
            this.radioButton_InputModeNet.UseVisualStyleBackColor = true;
            // 
            // radioButton_InputModeFwd
            // 
            this.radioButton_InputModeFwd.AutoSize = true;
            this.radioButton_InputModeFwd.Location = new System.Drawing.Point(6, 15);
            this.radioButton_InputModeFwd.Name = "radioButton_InputModeFwd";
            this.radioButton_InputModeFwd.Size = new System.Drawing.Size(96, 20);
            this.radioButton_InputModeFwd.TabIndex = 0;
            this.radioButton_InputModeFwd.Text = "Fwd Metering";
            this.radioButton_InputModeFwd.UseVisualStyleBackColor = true;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.textBox_ErrorAppB);
            this.groupBox31.Controls.Add(this.textBox_ErrorAppY);
            this.groupBox31.Controls.Add(this.textBox_ErrorAppTotal);
            this.groupBox31.Controls.Add(this.textBox_ErrorAppR);
            this.groupBox31.Controls.Add(this.textBox_ErrorReactB);
            this.groupBox31.Controls.Add(this.textBox_ErrorReactY);
            this.groupBox31.Controls.Add(this.textBox_ErrorReactTotal);
            this.groupBox31.Controls.Add(this.textBox_ErrorReactR);
            this.groupBox31.Controls.Add(this.textBox_ErrorActB);
            this.groupBox31.Controls.Add(this.textBox_ErrorActY);
            this.groupBox31.Controls.Add(this.textBox_ErrorActTotal);
            this.groupBox31.Controls.Add(this.label171);
            this.groupBox31.Controls.Add(this.textBox_ErrorActR);
            this.groupBox31.Controls.Add(this.label172);
            this.groupBox31.Controls.Add(this.label173);
            this.groupBox31.Location = new System.Drawing.Point(3, 265);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(390, 100);
            this.groupBox31.TabIndex = 533;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Accuracy";
            // 
            // textBox_ErrorAppB
            // 
            this.textBox_ErrorAppB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorAppB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppB.Location = new System.Drawing.Point(191, 64);
            this.textBox_ErrorAppB.Name = "textBox_ErrorAppB";
            this.textBox_ErrorAppB.ReadOnly = true;
            this.textBox_ErrorAppB.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorAppB.TabIndex = 521;
            // 
            // textBox_ErrorAppY
            // 
            this.textBox_ErrorAppY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorAppY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppY.Location = new System.Drawing.Point(125, 64);
            this.textBox_ErrorAppY.Name = "textBox_ErrorAppY";
            this.textBox_ErrorAppY.ReadOnly = true;
            this.textBox_ErrorAppY.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorAppY.TabIndex = 520;
            // 
            // textBox_ErrorAppTotal
            // 
            this.textBox_ErrorAppTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppTotal.Location = new System.Drawing.Point(256, 64);
            this.textBox_ErrorAppTotal.Name = "textBox_ErrorAppTotal";
            this.textBox_ErrorAppTotal.ReadOnly = true;
            this.textBox_ErrorAppTotal.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorAppTotal.TabIndex = 519;
            // 
            // textBox_ErrorAppR
            // 
            this.textBox_ErrorAppR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorAppR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAppR.Location = new System.Drawing.Point(60, 64);
            this.textBox_ErrorAppR.Name = "textBox_ErrorAppR";
            this.textBox_ErrorAppR.ReadOnly = true;
            this.textBox_ErrorAppR.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorAppR.TabIndex = 518;
            // 
            // textBox_ErrorReactB
            // 
            this.textBox_ErrorReactB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorReactB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactB.Location = new System.Drawing.Point(192, 39);
            this.textBox_ErrorReactB.Name = "textBox_ErrorReactB";
            this.textBox_ErrorReactB.ReadOnly = true;
            this.textBox_ErrorReactB.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorReactB.TabIndex = 517;
            // 
            // textBox_ErrorReactY
            // 
            this.textBox_ErrorReactY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorReactY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactY.Location = new System.Drawing.Point(126, 39);
            this.textBox_ErrorReactY.Name = "textBox_ErrorReactY";
            this.textBox_ErrorReactY.ReadOnly = true;
            this.textBox_ErrorReactY.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorReactY.TabIndex = 516;
            // 
            // textBox_ErrorReactTotal
            // 
            this.textBox_ErrorReactTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactTotal.Location = new System.Drawing.Point(257, 39);
            this.textBox_ErrorReactTotal.Name = "textBox_ErrorReactTotal";
            this.textBox_ErrorReactTotal.ReadOnly = true;
            this.textBox_ErrorReactTotal.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorReactTotal.TabIndex = 515;
            // 
            // textBox_ErrorReactR
            // 
            this.textBox_ErrorReactR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorReactR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorReactR.Location = new System.Drawing.Point(61, 39);
            this.textBox_ErrorReactR.Name = "textBox_ErrorReactR";
            this.textBox_ErrorReactR.ReadOnly = true;
            this.textBox_ErrorReactR.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorReactR.TabIndex = 514;
            // 
            // textBox_ErrorActB
            // 
            this.textBox_ErrorActB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_ErrorActB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActB.Location = new System.Drawing.Point(192, 16);
            this.textBox_ErrorActB.Name = "textBox_ErrorActB";
            this.textBox_ErrorActB.ReadOnly = true;
            this.textBox_ErrorActB.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorActB.TabIndex = 513;
            // 
            // textBox_ErrorActY
            // 
            this.textBox_ErrorActY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_ErrorActY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActY.Location = new System.Drawing.Point(126, 16);
            this.textBox_ErrorActY.Name = "textBox_ErrorActY";
            this.textBox_ErrorActY.ReadOnly = true;
            this.textBox_ErrorActY.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorActY.TabIndex = 512;
            // 
            // textBox_ErrorActTotal
            // 
            this.textBox_ErrorActTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActTotal.Location = new System.Drawing.Point(257, 16);
            this.textBox_ErrorActTotal.Name = "textBox_ErrorActTotal";
            this.textBox_ErrorActTotal.ReadOnly = true;
            this.textBox_ErrorActTotal.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorActTotal.TabIndex = 511;
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
            // textBox_ErrorActR
            // 
            this.textBox_ErrorActR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_ErrorActR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorActR.Location = new System.Drawing.Point(61, 16);
            this.textBox_ErrorActR.Name = "textBox_ErrorActR";
            this.textBox_ErrorActR.ReadOnly = true;
            this.textBox_ErrorActR.Size = new System.Drawing.Size(61, 20);
            this.textBox_ErrorActR.TabIndex = 510;
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
            // textBox_InputPFFwd
            // 
            this.textBox_InputPFFwd.BackColor = System.Drawing.Color.White;
            this.textBox_InputPFFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPFFwd.Location = new System.Drawing.Point(260, 161);
            this.textBox_InputPFFwd.Name = "textBox_InputPFFwd";
            this.textBox_InputPFFwd.ReadOnly = true;
            this.textBox_InputPFFwd.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputPFFwd.TabIndex = 532;
            this.textBox_InputPFFwd.Text = "0";
            this.textBox_InputPFFwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(114, 217);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(94, 13);
            this.label153.TabIndex = 529;
            this.label153.Text = "Neu Vector Angle:";
            // 
            // textBox_NeuCurrentAngleCalculated
            // 
            this.textBox_NeuCurrentAngleCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NeuCurrentAngleCalculated.Location = new System.Drawing.Point(212, 217);
            this.textBox_NeuCurrentAngleCalculated.Name = "textBox_NeuCurrentAngleCalculated";
            this.textBox_NeuCurrentAngleCalculated.ReadOnly = true;
            this.textBox_NeuCurrentAngleCalculated.Size = new System.Drawing.Size(61, 20);
            this.textBox_NeuCurrentAngleCalculated.TabIndex = 528;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(120, 196);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(86, 13);
            this.label154.TabIndex = 527;
            this.label154.Text = "Neu Vector Curr:";
            // 
            // textBox_NeuCurrentCalculated
            // 
            this.textBox_NeuCurrentCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NeuCurrentCalculated.Location = new System.Drawing.Point(212, 194);
            this.textBox_NeuCurrentCalculated.Name = "textBox_NeuCurrentCalculated";
            this.textBox_NeuCurrentCalculated.ReadOnly = true;
            this.textBox_NeuCurrentCalculated.Size = new System.Drawing.Size(61, 20);
            this.textBox_NeuCurrentCalculated.TabIndex = 526;
            // 
            // button_InputUpdate
            // 
            this.button_InputUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InputUpdate.Location = new System.Drawing.Point(279, 235);
            this.button_InputUpdate.Name = "button_InputUpdate";
            this.button_InputUpdate.Size = new System.Drawing.Size(106, 31);
            this.button_InputUpdate.TabIndex = 525;
            this.button_InputUpdate.Text = "Update";
            this.button_InputUpdate.UseVisualStyleBackColor = true;
            this.button_InputUpdate.Click += new System.EventHandler(this.button_InputUpdate_Click);
            // 
            // checkBox_ErrorCalculateEnable
            // 
            this.checkBox_ErrorCalculateEnable.AutoSize = true;
            this.checkBox_ErrorCalculateEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_ErrorCalculateEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ErrorCalculateEnable.Location = new System.Drawing.Point(296, 219);
            this.checkBox_ErrorCalculateEnable.Name = "checkBox_ErrorCalculateEnable";
            this.checkBox_ErrorCalculateEnable.Size = new System.Drawing.Size(89, 17);
            this.checkBox_ErrorCalculateEnable.TabIndex = 524;
            this.checkBox_ErrorCalculateEnable.Text = "Cal Accuracy";
            this.checkBox_ErrorCalculateEnable.UseVisualStyleBackColor = true;
            // 
            // textBox_InputFreq
            // 
            this.textBox_InputFreq.BackColor = System.Drawing.Color.Gold;
            this.textBox_InputFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputFreq.Location = new System.Drawing.Point(64, 239);
            this.textBox_InputFreq.Name = "textBox_InputFreq";
            this.textBox_InputFreq.Size = new System.Drawing.Size(41, 20);
            this.textBox_InputFreq.TabIndex = 523;
            this.textBox_InputFreq.Text = "50";
            this.textBox_InputFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputFreq.Click += new System.EventHandler(this.textBox_InputFreq_Click);
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(2, 242);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(60, 13);
            this.label155.TabIndex = 522;
            this.label155.Text = "Frequency:";
            // 
            // textBox_InputAngRB
            // 
            this.textBox_InputAngRB.BackColor = System.Drawing.Color.Gold;
            this.textBox_InputAngRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputAngRB.Location = new System.Drawing.Point(63, 216);
            this.textBox_InputAngRB.Name = "textBox_InputAngRB";
            this.textBox_InputAngRB.Size = new System.Drawing.Size(42, 20);
            this.textBox_InputAngRB.TabIndex = 521;
            this.textBox_InputAngRB.Text = "-120";
            this.textBox_InputAngRB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputAngRB.Click += new System.EventHandler(this.textBox_InputAngRB_Click);
            // 
            // textBox_ErrorAvg
            // 
            this.textBox_ErrorAvg.BackColor = System.Drawing.Color.Gold;
            this.textBox_ErrorAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ErrorAvg.Location = new System.Drawing.Point(356, 194);
            this.textBox_ErrorAvg.Name = "textBox_ErrorAvg";
            this.textBox_ErrorAvg.Size = new System.Drawing.Size(30, 20);
            this.textBox_ErrorAvg.TabIndex = 432;
            this.textBox_ErrorAvg.Text = "5";
            this.textBox_ErrorAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ErrorAvg.Click += new System.EventHandler(this.textBox_ErrorAvg_Click);
            // 
            // textBox_InputAngRY
            // 
            this.textBox_InputAngRY.BackColor = System.Drawing.Color.Gold;
            this.textBox_InputAngRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputAngRY.Location = new System.Drawing.Point(64, 194);
            this.textBox_InputAngRY.Name = "textBox_InputAngRY";
            this.textBox_InputAngRY.Size = new System.Drawing.Size(42, 20);
            this.textBox_InputAngRY.TabIndex = 520;
            this.textBox_InputAngRY.Text = "120";
            this.textBox_InputAngRY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputAngRY.Click += new System.EventHandler(this.textBox_InputAngRY_Click);
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(6, 219);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(58, 13);
            this.label156.TabIndex = 519;
            this.label156.Text = "Angle R-B:";
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
            // textBox_InputPFNet
            // 
            this.textBox_InputPFNet.BackColor = System.Drawing.Color.White;
            this.textBox_InputPFNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPFNet.Location = new System.Drawing.Point(326, 160);
            this.textBox_InputPFNet.Name = "textBox_InputPFNet";
            this.textBox_InputPFNet.ReadOnly = true;
            this.textBox_InputPFNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputPFNet.TabIndex = 502;
            this.textBox_InputPFNet.Text = "0";
            this.textBox_InputPFNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox_InputVATotalNet
            // 
            this.textBox_InputVATotalNet.BackColor = System.Drawing.Color.White;
            this.textBox_InputVATotalNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVATotalNet.Location = new System.Drawing.Point(326, 138);
            this.textBox_InputVATotalNet.Name = "textBox_InputVATotalNet";
            this.textBox_InputVATotalNet.ReadOnly = true;
            this.textBox_InputVATotalNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVATotalNet.TabIndex = 500;
            this.textBox_InputVATotalNet.Text = "0";
            this.textBox_InputVATotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputVARTotalNet
            // 
            this.textBox_InputVARTotalNet.BackColor = System.Drawing.Color.White;
            this.textBox_InputVARTotalNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVARTotalNet.Location = new System.Drawing.Point(326, 116);
            this.textBox_InputVARTotalNet.Name = "textBox_InputVARTotalNet";
            this.textBox_InputVARTotalNet.ReadOnly = true;
            this.textBox_InputVARTotalNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVARTotalNet.TabIndex = 499;
            this.textBox_InputVARTotalNet.Text = "0";
            this.textBox_InputVARTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputWattTotalNet
            // 
            this.textBox_InputWattTotalNet.BackColor = System.Drawing.Color.White;
            this.textBox_InputWattTotalNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputWattTotalNet.Location = new System.Drawing.Point(327, 94);
            this.textBox_InputWattTotalNet.Name = "textBox_InputWattTotalNet";
            this.textBox_InputWattTotalNet.ReadOnly = true;
            this.textBox_InputWattTotalNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputWattTotalNet.TabIndex = 498;
            this.textBox_InputWattTotalNet.Text = "0";
            this.textBox_InputWattTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.ForeColor = System.Drawing.Color.Black;
            this.label160.Location = new System.Drawing.Point(331, 14);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(51, 13);
            this.label160.TabIndex = 497;
            this.label160.Text = "Total Net";
            // 
            // textBox_InputVATotalFwd
            // 
            this.textBox_InputVATotalFwd.BackColor = System.Drawing.Color.White;
            this.textBox_InputVATotalFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVATotalFwd.Location = new System.Drawing.Point(260, 138);
            this.textBox_InputVATotalFwd.Name = "textBox_InputVATotalFwd";
            this.textBox_InputVATotalFwd.ReadOnly = true;
            this.textBox_InputVATotalFwd.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVATotalFwd.TabIndex = 496;
            this.textBox_InputVATotalFwd.Text = "0";
            this.textBox_InputVATotalFwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputVARTotalFwd
            // 
            this.textBox_InputVARTotalFwd.BackColor = System.Drawing.Color.White;
            this.textBox_InputVARTotalFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVARTotalFwd.Location = new System.Drawing.Point(260, 116);
            this.textBox_InputVARTotalFwd.Name = "textBox_InputVARTotalFwd";
            this.textBox_InputVARTotalFwd.ReadOnly = true;
            this.textBox_InputVARTotalFwd.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVARTotalFwd.TabIndex = 495;
            this.textBox_InputVARTotalFwd.Text = "0";
            this.textBox_InputVARTotalFwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputWattTotalFwd
            // 
            this.textBox_InputWattTotalFwd.BackColor = System.Drawing.Color.White;
            this.textBox_InputWattTotalFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputWattTotalFwd.Location = new System.Drawing.Point(261, 94);
            this.textBox_InputWattTotalFwd.Name = "textBox_InputWattTotalFwd";
            this.textBox_InputWattTotalFwd.ReadOnly = true;
            this.textBox_InputWattTotalFwd.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputWattTotalFwd.TabIndex = 494;
            this.textBox_InputWattTotalFwd.Text = "0";
            this.textBox_InputWattTotalFwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.ForeColor = System.Drawing.Color.Black;
            this.label161.Location = new System.Drawing.Point(265, 13);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(54, 13);
            this.label161.TabIndex = 493;
            this.label161.Text = "Total Fwd";
            // 
            // textBox_InputVAB
            // 
            this.textBox_InputVAB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputVAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVAB.Location = new System.Drawing.Point(195, 138);
            this.textBox_InputVAB.Name = "textBox_InputVAB";
            this.textBox_InputVAB.ReadOnly = true;
            this.textBox_InputVAB.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVAB.TabIndex = 492;
            this.textBox_InputVAB.Text = "0";
            this.textBox_InputVAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox_InputVARB
            // 
            this.textBox_InputVARB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputVARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVARB.Location = new System.Drawing.Point(195, 116);
            this.textBox_InputVARB.Name = "textBox_InputVARB";
            this.textBox_InputVARB.ReadOnly = true;
            this.textBox_InputVARB.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVARB.TabIndex = 491;
            this.textBox_InputVARB.Text = "0";
            this.textBox_InputVARB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox_InputWattB
            // 
            this.textBox_InputWattB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputWattB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputWattB.Location = new System.Drawing.Point(195, 94);
            this.textBox_InputWattB.Name = "textBox_InputWattB";
            this.textBox_InputWattB.ReadOnly = true;
            this.textBox_InputWattB.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputWattB.TabIndex = 490;
            this.textBox_InputWattB.Text = "0";
            this.textBox_InputWattB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox_InputVAY
            // 
            this.textBox_InputVAY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputVAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVAY.Location = new System.Drawing.Point(129, 138);
            this.textBox_InputVAY.Name = "textBox_InputVAY";
            this.textBox_InputVAY.ReadOnly = true;
            this.textBox_InputVAY.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVAY.TabIndex = 488;
            this.textBox_InputVAY.Text = "0";
            this.textBox_InputVAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputVARY
            // 
            this.textBox_InputVARY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputVARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVARY.Location = new System.Drawing.Point(129, 116);
            this.textBox_InputVARY.Name = "textBox_InputVARY";
            this.textBox_InputVARY.ReadOnly = true;
            this.textBox_InputVARY.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVARY.TabIndex = 486;
            this.textBox_InputVARY.Text = "0";
            this.textBox_InputVARY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputWattY
            // 
            this.textBox_InputWattY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputWattY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputWattY.Location = new System.Drawing.Point(129, 94);
            this.textBox_InputWattY.Name = "textBox_InputWattY";
            this.textBox_InputWattY.ReadOnly = true;
            this.textBox_InputWattY.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputWattY.TabIndex = 484;
            this.textBox_InputWattY.Text = "0";
            this.textBox_InputWattY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputVAR
            // 
            this.textBox_InputVAR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVAR.Location = new System.Drawing.Point(64, 138);
            this.textBox_InputVAR.Name = "textBox_InputVAR";
            this.textBox_InputVAR.ReadOnly = true;
            this.textBox_InputVAR.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVAR.TabIndex = 482;
            this.textBox_InputVAR.Text = "0";
            this.textBox_InputVAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputVARR
            // 
            this.textBox_InputVARR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputVARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVARR.Location = new System.Drawing.Point(64, 116);
            this.textBox_InputVARR.Name = "textBox_InputVARR";
            this.textBox_InputVARR.ReadOnly = true;
            this.textBox_InputVARR.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVARR.TabIndex = 481;
            this.textBox_InputVARR.Text = "0";
            this.textBox_InputVARR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputWattR
            // 
            this.textBox_InputWattR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputWattR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputWattR.Location = new System.Drawing.Point(64, 95);
            this.textBox_InputWattR.Name = "textBox_InputWattR";
            this.textBox_InputWattR.ReadOnly = true;
            this.textBox_InputWattR.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputWattR.TabIndex = 478;
            this.textBox_InputWattR.Text = "0";
            this.textBox_InputWattR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputAngb
            // 
            this.textBox_InputAngb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputAngb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputAngb.Location = new System.Drawing.Point(195, 72);
            this.textBox_InputAngb.Name = "textBox_InputAngb";
            this.textBox_InputAngb.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputAngb.TabIndex = 470;
            this.textBox_InputAngb.Text = "0";
            this.textBox_InputAngb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputAngb.Click += new System.EventHandler(this.textBox_InputAngb_Click);
            // 
            // textBox_InputAngy
            // 
            this.textBox_InputAngy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputAngy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputAngy.Location = new System.Drawing.Point(129, 72);
            this.textBox_InputAngy.Name = "textBox_InputAngy";
            this.textBox_InputAngy.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputAngy.TabIndex = 469;
            this.textBox_InputAngy.Text = "0";
            this.textBox_InputAngy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputAngy.Click += new System.EventHandler(this.textBox_InputAngy_Click);
            // 
            // textBox_InputAngr
            // 
            this.textBox_InputAngr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputAngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputAngr.Location = new System.Drawing.Point(64, 72);
            this.textBox_InputAngr.Name = "textBox_InputAngr";
            this.textBox_InputAngr.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputAngr.TabIndex = 468;
            this.textBox_InputAngr.Text = "0";
            this.textBox_InputAngr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputAngr.Click += new System.EventHandler(this.textBox_InputAngr_Click);
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
            // textBox_InputPFB
            // 
            this.textBox_InputPFB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputPFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPFB.Location = new System.Drawing.Point(195, 160);
            this.textBox_InputPFB.Name = "textBox_InputPFB";
            this.textBox_InputPFB.ReadOnly = true;
            this.textBox_InputPFB.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputPFB.TabIndex = 466;
            this.textBox_InputPFB.Text = "0";
            this.textBox_InputPFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputIb
            // 
            this.textBox_InputIb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputIb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputIb.Location = new System.Drawing.Point(195, 50);
            this.textBox_InputIb.Name = "textBox_InputIb";
            this.textBox_InputIb.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputIb.TabIndex = 465;
            this.textBox_InputIb.Text = "10";
            this.textBox_InputIb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputIb.Click += new System.EventHandler(this.textBox_InputIb_Click);
            // 
            // textBox_InputVb
            // 
            this.textBox_InputVb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_InputVb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVb.Location = new System.Drawing.Point(195, 29);
            this.textBox_InputVb.Name = "textBox_InputVb";
            this.textBox_InputVb.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVb.TabIndex = 464;
            this.textBox_InputVb.Text = "240";
            this.textBox_InputVb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputVb.Click += new System.EventHandler(this.textBox_InputVb_Click);
            // 
            // textBox_InputPFY
            // 
            this.textBox_InputPFY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputPFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPFY.Location = new System.Drawing.Point(129, 160);
            this.textBox_InputPFY.Name = "textBox_InputPFY";
            this.textBox_InputPFY.ReadOnly = true;
            this.textBox_InputPFY.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputPFY.TabIndex = 463;
            this.textBox_InputPFY.Text = "0";
            this.textBox_InputPFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputIy
            // 
            this.textBox_InputIy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputIy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputIy.Location = new System.Drawing.Point(129, 50);
            this.textBox_InputIy.Name = "textBox_InputIy";
            this.textBox_InputIy.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputIy.TabIndex = 462;
            this.textBox_InputIy.Text = "10";
            this.textBox_InputIy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputIy.Click += new System.EventHandler(this.textBox_InputIy_Click);
            // 
            // textBox_InputVy
            // 
            this.textBox_InputVy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_InputVy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVy.Location = new System.Drawing.Point(129, 29);
            this.textBox_InputVy.Name = "textBox_InputVy";
            this.textBox_InputVy.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVy.TabIndex = 461;
            this.textBox_InputVy.Text = "240";
            this.textBox_InputVy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputVy.Click += new System.EventHandler(this.textBox_InputVy_Click);
            // 
            // textBox_InputPFR
            // 
            this.textBox_InputPFR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputPFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputPFR.Location = new System.Drawing.Point(64, 160);
            this.textBox_InputPFR.Name = "textBox_InputPFR";
            this.textBox_InputPFR.ReadOnly = true;
            this.textBox_InputPFR.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputPFR.TabIndex = 460;
            this.textBox_InputPFR.Text = "0";
            this.textBox_InputPFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_InputIr
            // 
            this.textBox_InputIr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputIr.Location = new System.Drawing.Point(64, 50);
            this.textBox_InputIr.Name = "textBox_InputIr";
            this.textBox_InputIr.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputIr.TabIndex = 459;
            this.textBox_InputIr.Text = "10";
            this.textBox_InputIr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputIr.Click += new System.EventHandler(this.textBox_InputIr_Click);
            // 
            // textBox_InputVr
            // 
            this.textBox_InputVr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_InputVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputVr.Location = new System.Drawing.Point(64, 29);
            this.textBox_InputVr.Name = "textBox_InputVr";
            this.textBox_InputVr.Size = new System.Drawing.Size(61, 20);
            this.textBox_InputVr.TabIndex = 458;
            this.textBox_InputVr.Text = "240";
            this.textBox_InputVr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_InputVr.Click += new System.EventHandler(this.textBox_InputVr_Click);
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
            // textBox_THDIb
            // 
            this.textBox_THDIb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_THDIb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIb.Location = new System.Drawing.Point(646, 299);
            this.textBox_THDIb.Name = "textBox_THDIb";
            this.textBox_THDIb.ReadOnly = true;
            this.textBox_THDIb.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDIb.TabIndex = 599;
            // 
            // textBox_THDIy
            // 
            this.textBox_THDIy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_THDIy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIy.Location = new System.Drawing.Point(570, 299);
            this.textBox_THDIy.Name = "textBox_THDIy";
            this.textBox_THDIy.ReadOnly = true;
            this.textBox_THDIy.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDIy.TabIndex = 598;
            // 
            // textBox_THDIr
            // 
            this.textBox_THDIr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_THDIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDIr.Location = new System.Drawing.Point(489, 299);
            this.textBox_THDIr.Name = "textBox_THDIr";
            this.textBox_THDIr.ReadOnly = true;
            this.textBox_THDIr.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDIr.TabIndex = 597;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(426, 296);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(58, 13);
            this.label126.TabIndex = 596;
            this.label126.Text = "THD(Curr):";
            // 
            // textBox_THDVb
            // 
            this.textBox_THDVb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_THDVb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVb.Location = new System.Drawing.Point(646, 278);
            this.textBox_THDVb.Name = "textBox_THDVb";
            this.textBox_THDVb.ReadOnly = true;
            this.textBox_THDVb.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDVb.TabIndex = 595;
            // 
            // textBox_THDVy
            // 
            this.textBox_THDVy.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_THDVy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVy.Location = new System.Drawing.Point(570, 278);
            this.textBox_THDVy.Name = "textBox_THDVy";
            this.textBox_THDVy.ReadOnly = true;
            this.textBox_THDVy.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDVy.TabIndex = 594;
            // 
            // textBox_THDVr
            // 
            this.textBox_THDVr.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_THDVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_THDVr.Location = new System.Drawing.Point(489, 278);
            this.textBox_THDVr.Name = "textBox_THDVr";
            this.textBox_THDVr.ReadOnly = true;
            this.textBox_THDVr.Size = new System.Drawing.Size(61, 20);
            this.textBox_THDVr.TabIndex = 593;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(430, 276);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(54, 13);
            this.label133.TabIndex = 592;
            this.label133.Text = "THD(Vol):";
            // 
            // textBox_SamplesPerSec
            // 
            this.textBox_SamplesPerSec.BackColor = System.Drawing.Color.White;
            this.textBox_SamplesPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesPerSec.Location = new System.Drawing.Point(717, 258);
            this.textBox_SamplesPerSec.Name = "textBox_SamplesPerSec";
            this.textBox_SamplesPerSec.ReadOnly = true;
            this.textBox_SamplesPerSec.Size = new System.Drawing.Size(61, 20);
            this.textBox_SamplesPerSec.TabIndex = 591;
            // 
            // textBox_AnglePFBph
            // 
            this.textBox_AnglePFBph.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_AnglePFBph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFBph.Location = new System.Drawing.Point(646, 129);
            this.textBox_AnglePFBph.Name = "textBox_AnglePFBph";
            this.textBox_AnglePFBph.ReadOnly = true;
            this.textBox_AnglePFBph.Size = new System.Drawing.Size(61, 20);
            this.textBox_AnglePFBph.TabIndex = 590;
            // 
            // textBox_AnglePFYph
            // 
            this.textBox_AnglePFYph.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_AnglePFYph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFYph.Location = new System.Drawing.Point(570, 129);
            this.textBox_AnglePFYph.Name = "textBox_AnglePFYph";
            this.textBox_AnglePFYph.ReadOnly = true;
            this.textBox_AnglePFYph.Size = new System.Drawing.Size(61, 20);
            this.textBox_AnglePFYph.TabIndex = 589;
            // 
            // textBox_AnglePFRph
            // 
            this.textBox_AnglePFRph.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_AnglePFRph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnglePFRph.Location = new System.Drawing.Point(489, 127);
            this.textBox_AnglePFRph.Name = "textBox_AnglePFRph";
            this.textBox_AnglePFRph.ReadOnly = true;
            this.textBox_AnglePFRph.Size = new System.Drawing.Size(61, 20);
            this.textBox_AnglePFRph.TabIndex = 588;
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
            // textBox_SamplesB
            // 
            this.textBox_SamplesB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_SamplesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesB.Location = new System.Drawing.Point(646, 257);
            this.textBox_SamplesB.Name = "textBox_SamplesB";
            this.textBox_SamplesB.ReadOnly = true;
            this.textBox_SamplesB.Size = new System.Drawing.Size(61, 20);
            this.textBox_SamplesB.TabIndex = 586;
            // 
            // textBox_SamplesY
            // 
            this.textBox_SamplesY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_SamplesY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesY.Location = new System.Drawing.Point(570, 257);
            this.textBox_SamplesY.Name = "textBox_SamplesY";
            this.textBox_SamplesY.ReadOnly = true;
            this.textBox_SamplesY.Size = new System.Drawing.Size(61, 20);
            this.textBox_SamplesY.TabIndex = 585;
            // 
            // textBox_SamplesR
            // 
            this.textBox_SamplesR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_SamplesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SamplesR.Location = new System.Drawing.Point(489, 257);
            this.textBox_SamplesR.Name = "textBox_SamplesR";
            this.textBox_SamplesR.ReadOnly = true;
            this.textBox_SamplesR.Size = new System.Drawing.Size(61, 20);
            this.textBox_SamplesR.TabIndex = 584;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(434, 254);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(50, 13);
            this.label135.TabIndex = 583;
            this.label135.Text = "Samples:";
            // 
            // textBox_QuadB
            // 
            this.textBox_QuadB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_QuadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadB.Location = new System.Drawing.Point(646, 235);
            this.textBox_QuadB.Name = "textBox_QuadB";
            this.textBox_QuadB.ReadOnly = true;
            this.textBox_QuadB.Size = new System.Drawing.Size(61, 20);
            this.textBox_QuadB.TabIndex = 578;
            // 
            // textBox_FreqB
            // 
            this.textBox_FreqB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_FreqB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqB.Location = new System.Drawing.Point(646, 214);
            this.textBox_FreqB.Name = "textBox_FreqB";
            this.textBox_FreqB.ReadOnly = true;
            this.textBox_FreqB.Size = new System.Drawing.Size(61, 20);
            this.textBox_FreqB.TabIndex = 577;
            // 
            // textBox_VAB
            // 
            this.textBox_VAB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAB.Location = new System.Drawing.Point(646, 193);
            this.textBox_VAB.Name = "textBox_VAB";
            this.textBox_VAB.ReadOnly = true;
            this.textBox_VAB.Size = new System.Drawing.Size(61, 20);
            this.textBox_VAB.TabIndex = 576;
            // 
            // textBox_VARB
            // 
            this.textBox_VARB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VARB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARB.Location = new System.Drawing.Point(646, 172);
            this.textBox_VARB.Name = "textBox_VARB";
            this.textBox_VARB.ReadOnly = true;
            this.textBox_VARB.Size = new System.Drawing.Size(61, 20);
            this.textBox_VARB.TabIndex = 575;
            // 
            // textBox_WattB
            // 
            this.textBox_WattB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_WattB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattB.Location = new System.Drawing.Point(646, 150);
            this.textBox_WattB.Name = "textBox_WattB";
            this.textBox_WattB.ReadOnly = true;
            this.textBox_WattB.Size = new System.Drawing.Size(61, 20);
            this.textBox_WattB.TabIndex = 574;
            // 
            // textBox_PFB
            // 
            this.textBox_PFB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_PFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFB.Location = new System.Drawing.Point(646, 108);
            this.textBox_PFB.Name = "textBox_PFB";
            this.textBox_PFB.ReadOnly = true;
            this.textBox_PFB.Size = new System.Drawing.Size(61, 20);
            this.textBox_PFB.TabIndex = 572;
            // 
            // textBox_CurrBdc
            // 
            this.textBox_CurrBdc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CurrBdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrBdc.Location = new System.Drawing.Point(646, 87);
            this.textBox_CurrBdc.Name = "textBox_CurrBdc";
            this.textBox_CurrBdc.ReadOnly = true;
            this.textBox_CurrBdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrBdc.TabIndex = 571;
            // 
            // textBox_CurrB
            // 
            this.textBox_CurrB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_CurrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrB.Location = new System.Drawing.Point(646, 66);
            this.textBox_CurrB.Name = "textBox_CurrB";
            this.textBox_CurrB.ReadOnly = true;
            this.textBox_CurrB.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrB.TabIndex = 570;
            // 
            // textBox_VolBdc
            // 
            this.textBox_VolBdc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VolBdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolBdc.Location = new System.Drawing.Point(646, 45);
            this.textBox_VolBdc.Name = "textBox_VolBdc";
            this.textBox_VolBdc.ReadOnly = true;
            this.textBox_VolBdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolBdc.TabIndex = 569;
            // 
            // textBox_VolB
            // 
            this.textBox_VolB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_VolB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolB.Location = new System.Drawing.Point(646, 23);
            this.textBox_VolB.Name = "textBox_VolB";
            this.textBox_VolB.ReadOnly = true;
            this.textBox_VolB.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolB.TabIndex = 568;
            // 
            // textBox_QuadY
            // 
            this.textBox_QuadY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_QuadY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadY.Location = new System.Drawing.Point(570, 235);
            this.textBox_QuadY.Name = "textBox_QuadY";
            this.textBox_QuadY.ReadOnly = true;
            this.textBox_QuadY.Size = new System.Drawing.Size(61, 20);
            this.textBox_QuadY.TabIndex = 567;
            // 
            // textBox_FreqY
            // 
            this.textBox_FreqY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_FreqY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqY.Location = new System.Drawing.Point(570, 214);
            this.textBox_FreqY.Name = "textBox_FreqY";
            this.textBox_FreqY.ReadOnly = true;
            this.textBox_FreqY.Size = new System.Drawing.Size(61, 20);
            this.textBox_FreqY.TabIndex = 566;
            // 
            // textBox_VAY
            // 
            this.textBox_VAY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAY.Location = new System.Drawing.Point(570, 193);
            this.textBox_VAY.Name = "textBox_VAY";
            this.textBox_VAY.ReadOnly = true;
            this.textBox_VAY.Size = new System.Drawing.Size(61, 20);
            this.textBox_VAY.TabIndex = 565;
            // 
            // textBox_VARY
            // 
            this.textBox_VARY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARY.Location = new System.Drawing.Point(570, 172);
            this.textBox_VARY.Name = "textBox_VARY";
            this.textBox_VARY.ReadOnly = true;
            this.textBox_VARY.Size = new System.Drawing.Size(61, 20);
            this.textBox_VARY.TabIndex = 564;
            // 
            // textBox_WattY
            // 
            this.textBox_WattY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_WattY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattY.Location = new System.Drawing.Point(570, 150);
            this.textBox_WattY.Name = "textBox_WattY";
            this.textBox_WattY.ReadOnly = true;
            this.textBox_WattY.Size = new System.Drawing.Size(61, 20);
            this.textBox_WattY.TabIndex = 563;
            // 
            // textBox_PFY
            // 
            this.textBox_PFY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_PFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFY.Location = new System.Drawing.Point(570, 108);
            this.textBox_PFY.Name = "textBox_PFY";
            this.textBox_PFY.ReadOnly = true;
            this.textBox_PFY.Size = new System.Drawing.Size(61, 20);
            this.textBox_PFY.TabIndex = 561;
            // 
            // textBox_CurrYdc
            // 
            this.textBox_CurrYdc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CurrYdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrYdc.Location = new System.Drawing.Point(570, 87);
            this.textBox_CurrYdc.Name = "textBox_CurrYdc";
            this.textBox_CurrYdc.ReadOnly = true;
            this.textBox_CurrYdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrYdc.TabIndex = 560;
            // 
            // textBox_CurrY
            // 
            this.textBox_CurrY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_CurrY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrY.Location = new System.Drawing.Point(570, 66);
            this.textBox_CurrY.Name = "textBox_CurrY";
            this.textBox_CurrY.ReadOnly = true;
            this.textBox_CurrY.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrY.TabIndex = 559;
            // 
            // textBox_VolYdc
            // 
            this.textBox_VolYdc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VolYdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolYdc.Location = new System.Drawing.Point(570, 45);
            this.textBox_VolYdc.Name = "textBox_VolYdc";
            this.textBox_VolYdc.ReadOnly = true;
            this.textBox_VolYdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolYdc.TabIndex = 558;
            // 
            // textBox_VolY
            // 
            this.textBox_VolY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox_VolY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolY.Location = new System.Drawing.Point(570, 23);
            this.textBox_VolY.Name = "textBox_VolY";
            this.textBox_VolY.ReadOnly = true;
            this.textBox_VolY.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolY.TabIndex = 557;
            // 
            // textBox_QuadNet
            // 
            this.textBox_QuadNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadNet.Location = new System.Drawing.Point(717, 236);
            this.textBox_QuadNet.Name = "textBox_QuadNet";
            this.textBox_QuadNet.ReadOnly = true;
            this.textBox_QuadNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_QuadNet.TabIndex = 556;
            // 
            // textBox_FreqNet
            // 
            this.textBox_FreqNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqNet.Location = new System.Drawing.Point(717, 215);
            this.textBox_FreqNet.Name = "textBox_FreqNet";
            this.textBox_FreqNet.ReadOnly = true;
            this.textBox_FreqNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_FreqNet.TabIndex = 555;
            // 
            // textBox_VANet
            // 
            this.textBox_VANet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VANet.Location = new System.Drawing.Point(717, 193);
            this.textBox_VANet.Name = "textBox_VANet";
            this.textBox_VANet.ReadOnly = true;
            this.textBox_VANet.Size = new System.Drawing.Size(61, 20);
            this.textBox_VANet.TabIndex = 554;
            // 
            // textBox_VARNet
            // 
            this.textBox_VARNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARNet.Location = new System.Drawing.Point(717, 172);
            this.textBox_VARNet.Name = "textBox_VARNet";
            this.textBox_VARNet.ReadOnly = true;
            this.textBox_VARNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_VARNet.TabIndex = 553;
            // 
            // textBox_WattNet
            // 
            this.textBox_WattNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattNet.Location = new System.Drawing.Point(717, 151);
            this.textBox_WattNet.Name = "textBox_WattNet";
            this.textBox_WattNet.ReadOnly = true;
            this.textBox_WattNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_WattNet.TabIndex = 552;
            // 
            // textBox_PFNet
            // 
            this.textBox_PFNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFNet.Location = new System.Drawing.Point(717, 110);
            this.textBox_PFNet.Name = "textBox_PFNet";
            this.textBox_PFNet.ReadOnly = true;
            this.textBox_PFNet.Size = new System.Drawing.Size(61, 20);
            this.textBox_PFNet.TabIndex = 551;
            // 
            // textBox_QuadR
            // 
            this.textBox_QuadR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_QuadR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QuadR.Location = new System.Drawing.Point(489, 232);
            this.textBox_QuadR.Name = "textBox_QuadR";
            this.textBox_QuadR.ReadOnly = true;
            this.textBox_QuadR.Size = new System.Drawing.Size(61, 20);
            this.textBox_QuadR.TabIndex = 550;
            // 
            // textBox_FreqR
            // 
            this.textBox_FreqR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_FreqR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FreqR.Location = new System.Drawing.Point(489, 211);
            this.textBox_FreqR.Name = "textBox_FreqR";
            this.textBox_FreqR.ReadOnly = true;
            this.textBox_FreqR.Size = new System.Drawing.Size(61, 20);
            this.textBox_FreqR.TabIndex = 549;
            // 
            // textBox_VAR
            // 
            this.textBox_VAR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VAR.Location = new System.Drawing.Point(489, 190);
            this.textBox_VAR.Name = "textBox_VAR";
            this.textBox_VAR.ReadOnly = true;
            this.textBox_VAR.Size = new System.Drawing.Size(61, 20);
            this.textBox_VAR.TabIndex = 548;
            // 
            // textBox_VARR
            // 
            this.textBox_VARR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VARR.Location = new System.Drawing.Point(489, 169);
            this.textBox_VARR.Name = "textBox_VARR";
            this.textBox_VARR.ReadOnly = true;
            this.textBox_VARR.Size = new System.Drawing.Size(61, 20);
            this.textBox_VARR.TabIndex = 547;
            // 
            // textBox_WattR
            // 
            this.textBox_WattR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_WattR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WattR.Location = new System.Drawing.Point(489, 148);
            this.textBox_WattR.Name = "textBox_WattR";
            this.textBox_WattR.ReadOnly = true;
            this.textBox_WattR.Size = new System.Drawing.Size(61, 20);
            this.textBox_WattR.TabIndex = 546;
            // 
            // textBox_PFR
            // 
            this.textBox_PFR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_PFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFR.Location = new System.Drawing.Point(489, 106);
            this.textBox_PFR.Name = "textBox_PFR";
            this.textBox_PFR.ReadOnly = true;
            this.textBox_PFR.Size = new System.Drawing.Size(61, 20);
            this.textBox_PFR.TabIndex = 544;
            // 
            // textBox_CurrRdc
            // 
            this.textBox_CurrRdc.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CurrRdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrRdc.Location = new System.Drawing.Point(489, 85);
            this.textBox_CurrRdc.Name = "textBox_CurrRdc";
            this.textBox_CurrRdc.ReadOnly = true;
            this.textBox_CurrRdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrRdc.TabIndex = 543;
            // 
            // textBox_CurrR
            // 
            this.textBox_CurrR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_CurrR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrR.Location = new System.Drawing.Point(489, 64);
            this.textBox_CurrR.Name = "textBox_CurrR";
            this.textBox_CurrR.ReadOnly = true;
            this.textBox_CurrR.Size = new System.Drawing.Size(61, 20);
            this.textBox_CurrR.TabIndex = 542;
            // 
            // textBox_VolRdc
            // 
            this.textBox_VolRdc.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VolRdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolRdc.Location = new System.Drawing.Point(489, 43);
            this.textBox_VolRdc.Name = "textBox_VolRdc";
            this.textBox_VolRdc.ReadOnly = true;
            this.textBox_VolRdc.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolRdc.TabIndex = 541;
            // 
            // textBox_VolR
            // 
            this.textBox_VolR.BackColor = System.Drawing.Color.LightCoral;
            this.textBox_VolR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VolR.Location = new System.Drawing.Point(489, 22);
            this.textBox_VolR.Name = "textBox_VolR";
            this.textBox_VolR.ReadOnly = true;
            this.textBox_VolR.Size = new System.Drawing.Size(61, 20);
            this.textBox_VolR.TabIndex = 540;
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
            // timer500ms
            // 
            this.timer500ms.Interval = 500;
            this.timer500ms.Tick += new System.EventHandler(this.timerText500ms_Tick);
            // 
            // timer100ms
            // 
            this.timer100ms.Tick += new System.EventHandler(this.timer100ms_Tick);
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
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_FEnergyWhExportTotal;
        private System.Windows.Forms.TextBox textBox_FEnergyWhExportR;
        private System.Windows.Forms.TextBox textBox_FEnergyWhExportY;
        private System.Windows.Forms.TextBox textBox_FEnergyWhExportB;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox_FEnergyWhImportR;
        private System.Windows.Forms.TextBox textBox_FEnergyWhImportY;
        private System.Windows.Forms.TextBox textBox_FEnergyWhImportB;
        private System.Windows.Forms.TextBox textBox_FEnergyWhImportTotal;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox_EnergyVAhExportTotal;
        private System.Windows.Forms.TextBox textBox_EnergyVAhExportR;
        private System.Windows.Forms.TextBox textBox_EnergyVAhExportY;
        private System.Windows.Forms.TextBox textBox_EnergyVAhExportB;
        private System.Windows.Forms.TextBox textBox_EnergyVAhImportTotal;
        private System.Windows.Forms.TextBox textBox_EnergyVAhImportR;
        private System.Windows.Forms.TextBox textBox_EnergyVAhImportY;
        private System.Windows.Forms.TextBox textBox_EnergyVAhImportB;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ4Total;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ4R;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ4Y;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ4B;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ3Total;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ3R;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ3Y;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ3B;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ2Total;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ2R;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ2Y;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ2B;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ1Total;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ1R;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ1Y;
        private System.Windows.Forms.TextBox textBox_EnergyVARhQ1B;
        private System.Windows.Forms.TextBox textBox_EnergyWhExportTotal;
        private System.Windows.Forms.TextBox textBox_EnergyWhExportR;
        private System.Windows.Forms.TextBox textBox_EnergyWhExportY;
        private System.Windows.Forms.TextBox textBox_EnergyWhExportB;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox_EnergyWhImportR;
        private System.Windows.Forms.TextBox textBox_EnergyWhImportY;
        private System.Windows.Forms.TextBox textBox_EnergyWhImportB;
        private System.Windows.Forms.TextBox textBox_EnergyWhImportTotal;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox_TamperStatus;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.GroupBox groupBox31;
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
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.TextBox textBox_ErrorActR;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.TextBox textBox_InputPFFwd;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox textBox_NeuCurrentAngleCalculated;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.TextBox textBox_NeuCurrentCalculated;
        private System.Windows.Forms.Button button_InputUpdate;
        private System.Windows.Forms.CheckBox checkBox_ErrorCalculateEnable;
        private System.Windows.Forms.TextBox textBox_InputFreq;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TextBox textBox_InputAngRB;
        private System.Windows.Forms.TextBox textBox_ErrorAvg;
        private System.Windows.Forms.TextBox textBox_InputAngRY;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.TextBox textBox_InputPFNet;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.TextBox textBox_InputVATotalNet;
        private System.Windows.Forms.TextBox textBox_InputVARTotalNet;
        private System.Windows.Forms.TextBox textBox_InputWattTotalNet;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox textBox_InputVATotalFwd;
        private System.Windows.Forms.TextBox textBox_InputVARTotalFwd;
        private System.Windows.Forms.TextBox textBox_InputWattTotalFwd;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.TextBox textBox_InputVAB;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TextBox textBox_InputVARB;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.TextBox textBox_InputWattB;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox textBox_InputVAY;
        private System.Windows.Forms.TextBox textBox_InputVARY;
        private System.Windows.Forms.TextBox textBox_InputWattY;
        private System.Windows.Forms.TextBox textBox_InputVAR;
        private System.Windows.Forms.TextBox textBox_InputVARR;
        private System.Windows.Forms.TextBox textBox_InputWattR;
        private System.Windows.Forms.TextBox textBox_InputAngb;
        private System.Windows.Forms.TextBox textBox_InputAngy;
        private System.Windows.Forms.TextBox textBox_InputAngr;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.TextBox textBox_InputPFB;
        private System.Windows.Forms.TextBox textBox_InputIb;
        private System.Windows.Forms.TextBox textBox_InputVb;
        private System.Windows.Forms.TextBox textBox_InputPFY;
        private System.Windows.Forms.TextBox textBox_InputIy;
        private System.Windows.Forms.TextBox textBox_InputVy;
        private System.Windows.Forms.TextBox textBox_InputPFR;
        private System.Windows.Forms.TextBox textBox_InputIr;
        private System.Windows.Forms.TextBox textBox_InputVr;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox textBox_THDIb;
        private System.Windows.Forms.TextBox textBox_THDIy;
        private System.Windows.Forms.TextBox textBox_THDIr;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox textBox_THDVb;
        private System.Windows.Forms.TextBox textBox_THDVy;
        private System.Windows.Forms.TextBox textBox_THDVr;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TextBox textBox_SamplesPerSec;
        private System.Windows.Forms.TextBox textBox_AnglePFBph;
        private System.Windows.Forms.TextBox textBox_AnglePFYph;
        private System.Windows.Forms.TextBox textBox_AnglePFRph;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.TextBox textBox_SamplesB;
        private System.Windows.Forms.TextBox textBox_SamplesY;
        private System.Windows.Forms.TextBox textBox_SamplesR;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.TextBox textBox_QuadB;
        private System.Windows.Forms.TextBox textBox_FreqB;
        private System.Windows.Forms.TextBox textBox_VAB;
        private System.Windows.Forms.TextBox textBox_VARB;
        private System.Windows.Forms.TextBox textBox_WattB;
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
        private System.Windows.Forms.TextBox textBox_PFR;
        private System.Windows.Forms.TextBox textBox_CurrRdc;
        private System.Windows.Forms.TextBox textBox_CurrR;
        private System.Windows.Forms.TextBox textBox_VolRdc;
        private System.Windows.Forms.TextBox textBox_VolR;
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
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_Temperature;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBox_BatteryVoltageRTC;
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
        private System.Windows.Forms.TextBox textBox_MetrologyTimer;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox_AngleNeuVector;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox_CurrNeuVector;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox_SamplesN;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBox_CurrN;
        private System.Windows.Forms.TextBox textBox_CurrNdc;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox textBox_NewFileName;
        private System.Windows.Forms.CheckBox checkBox_LogToNewFile;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.CheckBox checkBox_LogData;
        private System.Windows.Forms.Timer timer500ms;
        private System.Windows.Forms.Timer timer100ms;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton radioButton_InputModeNet;
        private System.Windows.Forms.RadioButton radioButton_InputModeFwd;
        private System.Windows.Forms.Button button_SendRepeatStop;
    }
}

