namespace ErrorMessageGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorsList = new System.Windows.Forms.ListBox();
            this.lMacro = new System.Windows.Forms.Label();
            this.messageCaption = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.lMsgIcon = new System.Windows.Forms.Label();
            this.messageIconPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorBullet = new System.Windows.Forms.RadioButton();
            this.warningBullet = new System.Windows.Forms.RadioButton();
            this.infoBullet = new System.Windows.Forms.RadioButton();
            this.questionBullet = new System.Windows.Forms.RadioButton();
            this.noIconBullet = new System.Windows.Forms.RadioButton();
            this.messageButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.okOnlyBullet = new System.Windows.Forms.RadioButton();
            this.okCancelBullet = new System.Windows.Forms.RadioButton();
            this.ignoreRetryAbortBullet = new System.Windows.Forms.RadioButton();
            this.retryCancelBullet = new System.Windows.Forms.RadioButton();
            this.yesNoBullet = new System.Windows.Forms.RadioButton();
            this.continueTryCancelBullet = new System.Windows.Forms.RadioButton();
            this.lMsgButtons = new System.Windows.Forms.Label();
            this.lDefault = new System.Windows.Forms.Label();
            this.defaultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.oneBullet = new System.Windows.Forms.RadioButton();
            this.twoBullet = new System.Windows.Forms.RadioButton();
            this.threeBullet = new System.Windows.Forms.RadioButton();
            this.lCaptionMessage = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.conditionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cNoneBullet = new System.Windows.Forms.RadioButton();
            this.cOKBullet = new System.Windows.Forms.RadioButton();
            this.cYesBullet = new System.Windows.Forms.RadioButton();
            this.cNoBullet = new System.Windows.Forms.RadioButton();
            this.cCancelBullet = new System.Windows.Forms.RadioButton();
            this.cRetryBullet = new System.Windows.Forms.RadioButton();
            this.cIgnoreBullet = new System.Windows.Forms.RadioButton();
            this.cAbortBullet = new System.Windows.Forms.RadioButton();
            this.cTryBullet = new System.Windows.Forms.RadioButton();
            this.cContinueBullet = new System.Windows.Forms.RadioButton();
            this.lCondition = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.lActivities = new System.Windows.Forms.Label();
            this.activitiesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.openErrorFile = new System.Windows.Forms.OpenFileDialog();
            this.saveErrorFile = new System.Windows.Forms.SaveFileDialog();
            this.messageIconPanel.SuspendLayout();
            this.messageButtonsPanel.SuspendLayout();
            this.defaultPanel.SuspendLayout();
            this.conditionPanel.SuspendLayout();
            this.activitiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorsList
            // 
            this.errorsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsList.FormattingEnabled = true;
            this.errorsList.ItemHeight = 15;
            this.errorsList.Location = new System.Drawing.Point(573, 31);
            this.errorsList.Name = "errorsList";
            this.errorsList.Size = new System.Drawing.Size(215, 229);
            this.errorsList.TabIndex = 7;
            this.errorsList.SelectedIndexChanged += new System.EventHandler(this.errorsList_SelectedIndexChanged);
            // 
            // lMacro
            // 
            this.lMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMacro.AutoSize = true;
            this.lMacro.Location = new System.Drawing.Point(573, 9);
            this.lMacro.Name = "lMacro";
            this.lMacro.Size = new System.Drawing.Size(41, 15);
            this.lMacro.TabIndex = 1;
            this.lMacro.Text = "Macro";
            // 
            // messageCaption
            // 
            this.messageCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageCaption.Location = new System.Drawing.Point(12, 31);
            this.messageCaption.Name = "messageCaption";
            this.messageCaption.PlaceholderText = "Message Caption";
            this.messageCaption.Size = new System.Drawing.Size(555, 23);
            this.messageCaption.TabIndex = 1;
            this.messageCaption.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // messageText
            // 
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Location = new System.Drawing.Point(12, 60);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.PlaceholderText = "Message Text";
            this.messageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageText.Size = new System.Drawing.Size(555, 179);
            this.messageText.TabIndex = 2;
            this.messageText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lMsgIcon
            // 
            this.lMsgIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lMsgIcon.AutoSize = true;
            this.lMsgIcon.Location = new System.Drawing.Point(12, 245);
            this.lMsgIcon.Name = "lMsgIcon";
            this.lMsgIcon.Size = new System.Drawing.Size(79, 15);
            this.lMsgIcon.TabIndex = 6;
            this.lMsgIcon.Text = "Message Icon";
            // 
            // messageIconPanel
            // 
            this.messageIconPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageIconPanel.Controls.Add(this.errorBullet);
            this.messageIconPanel.Controls.Add(this.warningBullet);
            this.messageIconPanel.Controls.Add(this.infoBullet);
            this.messageIconPanel.Controls.Add(this.questionBullet);
            this.messageIconPanel.Controls.Add(this.noIconBullet);
            this.messageIconPanel.Location = new System.Drawing.Point(12, 263);
            this.messageIconPanel.Name = "messageIconPanel";
            this.messageIconPanel.Size = new System.Drawing.Size(555, 29);
            this.messageIconPanel.TabIndex = 3;
            // 
            // errorBullet
            // 
            this.errorBullet.AutoSize = true;
            this.errorBullet.Location = new System.Drawing.Point(3, 3);
            this.errorBullet.Name = "errorBullet";
            this.errorBullet.Size = new System.Drawing.Size(92, 19);
            this.errorBullet.TabIndex = 0;
            this.errorBullet.Text = "Error/Critical";
            this.errorBullet.UseVisualStyleBackColor = true;
            this.errorBullet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // warningBullet
            // 
            this.warningBullet.AutoSize = true;
            this.warningBullet.Location = new System.Drawing.Point(101, 3);
            this.warningBullet.Name = "warningBullet";
            this.warningBullet.Size = new System.Drawing.Size(140, 19);
            this.warningBullet.TabIndex = 1;
            this.warningBullet.Text = "Warning/Exclamation";
            this.warningBullet.UseVisualStyleBackColor = true;
            this.warningBullet.CheckedChanged += new System.EventHandler(this.warningBullet_CheckedChanged);
            // 
            // infoBullet
            // 
            this.infoBullet.AutoSize = true;
            this.infoBullet.Location = new System.Drawing.Point(247, 3);
            this.infoBullet.Name = "infoBullet";
            this.infoBullet.Size = new System.Drawing.Size(88, 19);
            this.infoBullet.TabIndex = 2;
            this.infoBullet.Text = "Information";
            this.infoBullet.UseVisualStyleBackColor = true;
            this.infoBullet.CheckedChanged += new System.EventHandler(this.infoBullet_CheckedChanged);
            // 
            // questionBullet
            // 
            this.questionBullet.AutoSize = true;
            this.questionBullet.Location = new System.Drawing.Point(341, 3);
            this.questionBullet.Name = "questionBullet";
            this.questionBullet.Size = new System.Drawing.Size(73, 19);
            this.questionBullet.TabIndex = 3;
            this.questionBullet.Text = "Question";
            this.questionBullet.UseVisualStyleBackColor = true;
            this.questionBullet.CheckedChanged += new System.EventHandler(this.questionBullet_CheckedChanged);
            // 
            // noIconBullet
            // 
            this.noIconBullet.AutoSize = true;
            this.noIconBullet.Checked = true;
            this.noIconBullet.Location = new System.Drawing.Point(420, 3);
            this.noIconBullet.Name = "noIconBullet";
            this.noIconBullet.Size = new System.Drawing.Size(67, 19);
            this.noIconBullet.TabIndex = 4;
            this.noIconBullet.TabStop = true;
            this.noIconBullet.Text = "No icon";
            this.noIconBullet.UseVisualStyleBackColor = true;
            this.noIconBullet.CheckedChanged += new System.EventHandler(this.noIconBullet_CheckedChanged);
            // 
            // messageButtonsPanel
            // 
            this.messageButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageButtonsPanel.Controls.Add(this.okOnlyBullet);
            this.messageButtonsPanel.Controls.Add(this.okCancelBullet);
            this.messageButtonsPanel.Controls.Add(this.ignoreRetryAbortBullet);
            this.messageButtonsPanel.Controls.Add(this.retryCancelBullet);
            this.messageButtonsPanel.Controls.Add(this.yesNoBullet);
            this.messageButtonsPanel.Controls.Add(this.continueTryCancelBullet);
            this.messageButtonsPanel.Location = new System.Drawing.Point(12, 313);
            this.messageButtonsPanel.Name = "messageButtonsPanel";
            this.messageButtonsPanel.Size = new System.Drawing.Size(555, 49);
            this.messageButtonsPanel.TabIndex = 4;
            // 
            // okOnlyBullet
            // 
            this.okOnlyBullet.AutoSize = true;
            this.okOnlyBullet.Checked = true;
            this.okOnlyBullet.Location = new System.Drawing.Point(3, 3);
            this.okOnlyBullet.Name = "okOnlyBullet";
            this.okOnlyBullet.Size = new System.Drawing.Size(67, 19);
            this.okOnlyBullet.TabIndex = 0;
            this.okOnlyBullet.TabStop = true;
            this.okOnlyBullet.Text = "OK only";
            this.okOnlyBullet.UseVisualStyleBackColor = true;
            this.okOnlyBullet.CheckedChanged += new System.EventHandler(this.okOnlyBullet_CheckedChanged);
            // 
            // okCancelBullet
            // 
            this.okCancelBullet.AutoSize = true;
            this.okCancelBullet.Location = new System.Drawing.Point(76, 3);
            this.okCancelBullet.Name = "okCancelBullet";
            this.okCancelBullet.Size = new System.Drawing.Size(103, 19);
            this.okCancelBullet.TabIndex = 1;
            this.okCancelBullet.Text = "OK and Cancel";
            this.okCancelBullet.UseVisualStyleBackColor = true;
            this.okCancelBullet.CheckedChanged += new System.EventHandler(this.okCancelBullet_CheckedChanged);
            // 
            // ignoreRetryAbortBullet
            // 
            this.ignoreRetryAbortBullet.AutoSize = true;
            this.ignoreRetryAbortBullet.Location = new System.Drawing.Point(185, 3);
            this.ignoreRetryAbortBullet.Name = "ignoreRetryAbortBullet";
            this.ignoreRetryAbortBullet.Size = new System.Drawing.Size(151, 19);
            this.ignoreRetryAbortBullet.TabIndex = 2;
            this.ignoreRetryAbortBullet.Text = "Abort, Retry, and Ignore";
            this.ignoreRetryAbortBullet.UseVisualStyleBackColor = true;
            this.ignoreRetryAbortBullet.CheckedChanged += new System.EventHandler(this.okCancelBullet_CheckedChanged);
            // 
            // retryCancelBullet
            // 
            this.retryCancelBullet.AutoSize = true;
            this.retryCancelBullet.Location = new System.Drawing.Point(342, 3);
            this.retryCancelBullet.Name = "retryCancelBullet";
            this.retryCancelBullet.Size = new System.Drawing.Size(114, 19);
            this.retryCancelBullet.TabIndex = 3;
            this.retryCancelBullet.Text = "Retry and Cancel";
            this.retryCancelBullet.UseVisualStyleBackColor = true;
            this.retryCancelBullet.CheckedChanged += new System.EventHandler(this.okCancelBullet_CheckedChanged);
            // 
            // yesNoBullet
            // 
            this.yesNoBullet.AutoSize = true;
            this.yesNoBullet.Location = new System.Drawing.Point(462, 3);
            this.yesNoBullet.Name = "yesNoBullet";
            this.yesNoBullet.Size = new System.Drawing.Size(84, 19);
            this.yesNoBullet.TabIndex = 4;
            this.yesNoBullet.Text = "Yes and No";
            this.yesNoBullet.UseVisualStyleBackColor = true;
            this.yesNoBullet.CheckedChanged += new System.EventHandler(this.okCancelBullet_CheckedChanged);
            // 
            // continueTryCancelBullet
            // 
            this.continueTryCancelBullet.AutoSize = true;
            this.continueTryCancelBullet.Location = new System.Drawing.Point(3, 28);
            this.continueTryCancelBullet.Name = "continueTryCancelBullet";
            this.continueTryCancelBullet.Size = new System.Drawing.Size(194, 19);
            this.continueTryCancelBullet.TabIndex = 5;
            this.continueTryCancelBullet.Text = "Continue, Try Again, and Cancel";
            this.continueTryCancelBullet.UseVisualStyleBackColor = true;
            this.continueTryCancelBullet.CheckedChanged += new System.EventHandler(this.okCancelBullet_CheckedChanged);
            // 
            // lMsgButtons
            // 
            this.lMsgButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lMsgButtons.AutoSize = true;
            this.lMsgButtons.Location = new System.Drawing.Point(12, 295);
            this.lMsgButtons.Name = "lMsgButtons";
            this.lMsgButtons.Size = new System.Drawing.Size(97, 15);
            this.lMsgButtons.TabIndex = 8;
            this.lMsgButtons.Text = "Message Buttons";
            // 
            // lDefault
            // 
            this.lDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDefault.AutoSize = true;
            this.lDefault.Location = new System.Drawing.Point(15, 365);
            this.lDefault.Name = "lDefault";
            this.lDefault.Size = new System.Drawing.Size(96, 15);
            this.lDefault.TabIndex = 10;
            this.lDefault.Text = "Default Selection";
            // 
            // defaultPanel
            // 
            this.defaultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultPanel.Controls.Add(this.oneBullet);
            this.defaultPanel.Controls.Add(this.twoBullet);
            this.defaultPanel.Controls.Add(this.threeBullet);
            this.defaultPanel.Location = new System.Drawing.Point(12, 383);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(555, 29);
            this.defaultPanel.TabIndex = 5;
            // 
            // oneBullet
            // 
            this.oneBullet.AutoSize = true;
            this.oneBullet.Checked = true;
            this.oneBullet.Location = new System.Drawing.Point(3, 3);
            this.oneBullet.Name = "oneBullet";
            this.oneBullet.Size = new System.Drawing.Size(41, 19);
            this.oneBullet.TabIndex = 0;
            this.oneBullet.TabStop = true;
            this.oneBullet.Text = "OK";
            this.oneBullet.UseVisualStyleBackColor = true;
            this.oneBullet.CheckedChanged += new System.EventHandler(this.oneBullet_CheckedChanged);
            // 
            // twoBullet
            // 
            this.twoBullet.AutoSize = true;
            this.twoBullet.Enabled = false;
            this.twoBullet.Location = new System.Drawing.Point(50, 3);
            this.twoBullet.Name = "twoBullet";
            this.twoBullet.Size = new System.Drawing.Size(47, 19);
            this.twoBullet.TabIndex = 2;
            this.twoBullet.Text = "N/A";
            this.twoBullet.UseVisualStyleBackColor = true;
            this.twoBullet.CheckedChanged += new System.EventHandler(this.oneBullet_CheckedChanged);
            // 
            // threeBullet
            // 
            this.threeBullet.AutoSize = true;
            this.threeBullet.Enabled = false;
            this.threeBullet.Location = new System.Drawing.Point(103, 3);
            this.threeBullet.Name = "threeBullet";
            this.threeBullet.Size = new System.Drawing.Size(47, 19);
            this.threeBullet.TabIndex = 4;
            this.threeBullet.Text = "N/A";
            this.threeBullet.UseVisualStyleBackColor = true;
            this.threeBullet.CheckedChanged += new System.EventHandler(this.oneBullet_CheckedChanged);
            // 
            // lCaptionMessage
            // 
            this.lCaptionMessage.AutoSize = true;
            this.lCaptionMessage.Location = new System.Drawing.Point(12, 9);
            this.lCaptionMessage.Name = "lCaptionMessage";
            this.lCaptionMessage.Size = new System.Drawing.Size(96, 15);
            this.lCaptionMessage.TabIndex = 12;
            this.lCaptionMessage.Text = "Current Message";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(3, 61);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(215, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "R&emove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(3, 90);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(215, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(3, 119);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(215, 23);
            this.previewButton.TabIndex = 5;
            this.previewButton.Text = "&Preview (ignore conditions)";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // conditionPanel
            // 
            this.conditionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionPanel.Controls.Add(this.cNoneBullet);
            this.conditionPanel.Controls.Add(this.cOKBullet);
            this.conditionPanel.Controls.Add(this.cYesBullet);
            this.conditionPanel.Controls.Add(this.cNoBullet);
            this.conditionPanel.Controls.Add(this.cCancelBullet);
            this.conditionPanel.Controls.Add(this.cRetryBullet);
            this.conditionPanel.Controls.Add(this.cIgnoreBullet);
            this.conditionPanel.Controls.Add(this.cAbortBullet);
            this.conditionPanel.Controls.Add(this.cTryBullet);
            this.conditionPanel.Controls.Add(this.cContinueBullet);
            this.conditionPanel.Location = new System.Drawing.Point(12, 433);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(555, 59);
            this.conditionPanel.TabIndex = 6;
            // 
            // cNoneBullet
            // 
            this.cNoneBullet.AutoSize = true;
            this.cNoneBullet.Checked = true;
            this.cNoneBullet.Location = new System.Drawing.Point(3, 3);
            this.cNoneBullet.Name = "cNoneBullet";
            this.cNoneBullet.Size = new System.Drawing.Size(54, 19);
            this.cNoneBullet.TabIndex = 0;
            this.cNoneBullet.TabStop = true;
            this.cNoneBullet.Text = "None";
            this.cNoneBullet.UseVisualStyleBackColor = true;
            this.cNoneBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cOKBullet
            // 
            this.cOKBullet.AutoSize = true;
            this.cOKBullet.Location = new System.Drawing.Point(63, 3);
            this.cOKBullet.Name = "cOKBullet";
            this.cOKBullet.Size = new System.Drawing.Size(41, 19);
            this.cOKBullet.TabIndex = 1;
            this.cOKBullet.Text = "OK";
            this.cOKBullet.UseVisualStyleBackColor = true;
            this.cOKBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cYesBullet
            // 
            this.cYesBullet.AutoSize = true;
            this.cYesBullet.Location = new System.Drawing.Point(110, 3);
            this.cYesBullet.Name = "cYesBullet";
            this.cYesBullet.Size = new System.Drawing.Size(42, 19);
            this.cYesBullet.TabIndex = 2;
            this.cYesBullet.Text = "Yes";
            this.cYesBullet.UseVisualStyleBackColor = true;
            this.cYesBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cNoBullet
            // 
            this.cNoBullet.AutoSize = true;
            this.cNoBullet.Location = new System.Drawing.Point(158, 3);
            this.cNoBullet.Name = "cNoBullet";
            this.cNoBullet.Size = new System.Drawing.Size(41, 19);
            this.cNoBullet.TabIndex = 3;
            this.cNoBullet.Text = "No";
            this.cNoBullet.UseVisualStyleBackColor = true;
            this.cNoBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cCancelBullet
            // 
            this.cCancelBullet.AutoSize = true;
            this.cCancelBullet.Location = new System.Drawing.Point(205, 3);
            this.cCancelBullet.Name = "cCancelBullet";
            this.cCancelBullet.Size = new System.Drawing.Size(61, 19);
            this.cCancelBullet.TabIndex = 4;
            this.cCancelBullet.Text = "Cancel";
            this.cCancelBullet.UseVisualStyleBackColor = true;
            this.cCancelBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cRetryBullet
            // 
            this.cRetryBullet.AutoSize = true;
            this.cRetryBullet.Location = new System.Drawing.Point(272, 3);
            this.cRetryBullet.Name = "cRetryBullet";
            this.cRetryBullet.Size = new System.Drawing.Size(52, 19);
            this.cRetryBullet.TabIndex = 5;
            this.cRetryBullet.Text = "Retry";
            this.cRetryBullet.UseVisualStyleBackColor = true;
            this.cRetryBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cIgnoreBullet
            // 
            this.cIgnoreBullet.AutoSize = true;
            this.cIgnoreBullet.Location = new System.Drawing.Point(330, 3);
            this.cIgnoreBullet.Name = "cIgnoreBullet";
            this.cIgnoreBullet.Size = new System.Drawing.Size(59, 19);
            this.cIgnoreBullet.TabIndex = 6;
            this.cIgnoreBullet.Text = "Ignore";
            this.cIgnoreBullet.UseVisualStyleBackColor = true;
            this.cIgnoreBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cAbortBullet
            // 
            this.cAbortBullet.AutoSize = true;
            this.cAbortBullet.Location = new System.Drawing.Point(395, 3);
            this.cAbortBullet.Name = "cAbortBullet";
            this.cAbortBullet.Size = new System.Drawing.Size(55, 19);
            this.cAbortBullet.TabIndex = 8;
            this.cAbortBullet.Text = "Abort";
            this.cAbortBullet.UseVisualStyleBackColor = true;
            this.cAbortBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cTryBullet
            // 
            this.cTryBullet.AutoSize = true;
            this.cTryBullet.Location = new System.Drawing.Point(456, 3);
            this.cTryBullet.Name = "cTryBullet";
            this.cTryBullet.Size = new System.Drawing.Size(74, 19);
            this.cTryBullet.TabIndex = 9;
            this.cTryBullet.Text = "Try Again";
            this.cTryBullet.UseVisualStyleBackColor = true;
            this.cTryBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // cContinueBullet
            // 
            this.cContinueBullet.AutoSize = true;
            this.cContinueBullet.Location = new System.Drawing.Point(3, 28);
            this.cContinueBullet.Name = "cContinueBullet";
            this.cContinueBullet.Size = new System.Drawing.Size(74, 19);
            this.cContinueBullet.TabIndex = 10;
            this.cContinueBullet.Text = "Continue";
            this.cContinueBullet.UseVisualStyleBackColor = true;
            this.cContinueBullet.CheckedChanged += new System.EventHandler(this.cNoneBullet_CheckedChanged);
            // 
            // lCondition
            // 
            this.lCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lCondition.AutoSize = true;
            this.lCondition.Location = new System.Drawing.Point(12, 415);
            this.lCondition.Name = "lCondition";
            this.lCondition.Size = new System.Drawing.Size(60, 15);
            this.lCondition.TabIndex = 17;
            this.lCondition.Text = "Condition";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(3, 148);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(215, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "&Import macro";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(3, 177);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(215, 23);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "E&xport macro";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // lActivities
            // 
            this.lActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lActivities.AutoSize = true;
            this.lActivities.Location = new System.Drawing.Point(573, 270);
            this.lActivities.Name = "lActivities";
            this.lActivities.Size = new System.Drawing.Size(55, 15);
            this.lActivities.TabIndex = 21;
            this.lActivities.Text = "Activities";
            // 
            // activitiesPanel
            // 
            this.activitiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.activitiesPanel.Controls.Add(this.runButton);
            this.activitiesPanel.Controls.Add(this.addButton);
            this.activitiesPanel.Controls.Add(this.removeButton);
            this.activitiesPanel.Controls.Add(this.updateButton);
            this.activitiesPanel.Controls.Add(this.previewButton);
            this.activitiesPanel.Controls.Add(this.importButton);
            this.activitiesPanel.Controls.Add(this.exportButton);
            this.activitiesPanel.Location = new System.Drawing.Point(573, 288);
            this.activitiesPanel.Name = "activitiesPanel";
            this.activitiesPanel.Size = new System.Drawing.Size(225, 204);
            this.activitiesPanel.TabIndex = 8;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(215, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "&Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // openErrorFile
            // 
            this.openErrorFile.Filter = "Error Message Macro files|*.emm";
            // 
            // saveErrorFile
            // 
            this.saveErrorFile.Filter = "Error Message Macro files|*.emm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.activitiesPanel);
            this.Controls.Add(this.lActivities);
            this.Controls.Add(this.conditionPanel);
            this.Controls.Add(this.lCondition);
            this.Controls.Add(this.lCaptionMessage);
            this.Controls.Add(this.defaultPanel);
            this.Controls.Add(this.lDefault);
            this.Controls.Add(this.messageButtonsPanel);
            this.Controls.Add(this.lMsgButtons);
            this.Controls.Add(this.messageIconPanel);
            this.Controls.Add(this.lMsgIcon);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageCaption);
            this.Controls.Add(this.lMacro);
            this.Controls.Add(this.errorsList);
            this.MinimumSize = new System.Drawing.Size(816, 543);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Generate an error message";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.messageIconPanel.ResumeLayout(false);
            this.messageIconPanel.PerformLayout();
            this.messageButtonsPanel.ResumeLayout(false);
            this.messageButtonsPanel.PerformLayout();
            this.defaultPanel.ResumeLayout(false);
            this.defaultPanel.PerformLayout();
            this.conditionPanel.ResumeLayout(false);
            this.conditionPanel.PerformLayout();
            this.activitiesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox errorsList;
        private Label lMacro;
        private TextBox messageCaption;
        private TextBox messageText;
        private Label lMsgIcon;
        private FlowLayoutPanel messageIconPanel;
        private RadioButton errorBullet;
        private RadioButton warningBullet;
        private RadioButton infoBullet;
        private RadioButton questionBullet;
        private RadioButton noIconBullet;
        private FlowLayoutPanel messageButtonsPanel;
        private RadioButton okOnlyBullet;
        private RadioButton okCancelBullet;
        private RadioButton ignoreRetryAbortBullet;
        private RadioButton retryCancelBullet;
        private RadioButton yesNoBullet;
        private Label lMsgButtons;
        private RadioButton continueTryCancelBullet;
        private Label lDefault;
        private FlowLayoutPanel defaultPanel;
        private RadioButton oneBullet;
        private RadioButton twoBullet;
        private RadioButton threeBullet;
        private Label lCaptionMessage;
        private Button addButton;
        private Button removeButton;
        private Button updateButton;
        private Button previewButton;
        private FlowLayoutPanel conditionPanel;
        private RadioButton cNoneBullet;
        private RadioButton cOKBullet;
        private RadioButton cYesBullet;
        private RadioButton cNoBullet;
        private RadioButton cCancelBullet;
        private RadioButton cRetryBullet;
        private RadioButton cIgnoreBullet;
        private RadioButton cAbortBullet;
        private RadioButton cTryBullet;
        private RadioButton cContinueBullet;
        private Label lCondition;
        private Button importButton;
        private Button exportButton;
        private Label lActivities;
        private FlowLayoutPanel activitiesPanel;
        private Button runButton;
        private OpenFileDialog openErrorFile;
        private SaveFileDialog saveErrorFile;
    }
}