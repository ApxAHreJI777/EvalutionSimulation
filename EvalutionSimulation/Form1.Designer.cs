namespace EvalutionSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.micsCountTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.sdBtn = new System.Windows.Forms.Button();
            this.ffBtn = new System.Windows.Forms.Button();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.mutRuleComboBox = new System.Windows.Forms.ComboBox();
            this.micCountLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.mutRuleLabel = new System.Windows.Forms.Label();
            this.speedGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedMicDataGridView = new System.Windows.Forms.DataGridView();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodRuleLabel = new System.Windows.Forms.Label();
            this.foodRuleComboBox = new System.Windows.Forms.ComboBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.selectedMicPicBox = new System.Windows.Forms.PictureBox();
            this.mainPicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleMicrobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnoseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microbesChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.speedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicDataGridView)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // micsCountTextBox
            // 
            this.micsCountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.micsCountTextBox.Location = new System.Drawing.Point(78, 3);
            this.micsCountTextBox.Name = "micsCountTextBox";
            this.micsCountTextBox.ReadOnly = true;
            this.micsCountTextBox.Size = new System.Drawing.Size(99, 20);
            this.micsCountTextBox.TabIndex = 1;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(36, 18);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(105, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Play";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // sdBtn
            // 
            this.sdBtn.Location = new System.Drawing.Point(1, 18);
            this.sdBtn.Name = "sdBtn";
            this.sdBtn.Size = new System.Drawing.Size(30, 23);
            this.sdBtn.TabIndex = 3;
            this.sdBtn.Text = "<<";
            this.sdBtn.UseVisualStyleBackColor = true;
            this.sdBtn.Click += new System.EventHandler(this.sdBtn_Click);
            // 
            // ffBtn
            // 
            this.ffBtn.Location = new System.Drawing.Point(145, 18);
            this.ffBtn.Name = "ffBtn";
            this.ffBtn.Size = new System.Drawing.Size(30, 23);
            this.ffBtn.TabIndex = 4;
            this.ffBtn.Text = ">>";
            this.ffBtn.UseVisualStyleBackColor = true;
            this.ffBtn.Click += new System.EventHandler(this.ffBtn_Click);
            // 
            // speedTextBox
            // 
            this.speedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.speedTextBox.Location = new System.Drawing.Point(96, 77);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(77, 20);
            this.speedTextBox.TabIndex = 5;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.AutoSize = false;
            this.speedTrackBar.LargeChange = 1;
            this.speedTrackBar.Location = new System.Drawing.Point(2, 47);
            this.speedTrackBar.Maximum = 4;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(171, 23);
            this.speedTrackBar.TabIndex = 6;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedTrackBar.Value = 2;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // mutRuleComboBox
            // 
            this.mutRuleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mutRuleComboBox.FormattingEnabled = true;
            this.mutRuleComboBox.Location = new System.Drawing.Point(77, 138);
            this.mutRuleComboBox.Name = "mutRuleComboBox";
            this.mutRuleComboBox.Size = new System.Drawing.Size(100, 21);
            this.mutRuleComboBox.TabIndex = 7;
            this.mutRuleComboBox.SelectedValueChanged += new System.EventHandler(this.mutRuleComboBox_SelectedValueChanged);
            // 
            // micCountLabel
            // 
            this.micCountLabel.AutoSize = true;
            this.micCountLabel.Location = new System.Drawing.Point(3, 6);
            this.micCountLabel.Name = "micCountLabel";
            this.micCountLabel.Size = new System.Drawing.Size(53, 13);
            this.micCountLabel.TabIndex = 8;
            this.micCountLabel.Text = "Microbes:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(1, 80);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(78, 13);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "Current Speed:";
            // 
            // mutRuleLabel
            // 
            this.mutRuleLabel.AutoSize = true;
            this.mutRuleLabel.Location = new System.Drawing.Point(3, 141);
            this.mutRuleLabel.Name = "mutRuleLabel";
            this.mutRuleLabel.Size = new System.Drawing.Size(76, 13);
            this.mutRuleLabel.TabIndex = 10;
            this.mutRuleLabel.Text = "Mutation Rule:";
            // 
            // speedGroupBox
            // 
            this.speedGroupBox.Controls.Add(this.startBtn);
            this.speedGroupBox.Controls.Add(this.sdBtn);
            this.speedGroupBox.Controls.Add(this.speedLabel);
            this.speedGroupBox.Controls.Add(this.ffBtn);
            this.speedGroupBox.Controls.Add(this.speedTextBox);
            this.speedGroupBox.Controls.Add(this.speedTrackBar);
            this.speedGroupBox.Location = new System.Drawing.Point(1, 29);
            this.speedGroupBox.Name = "speedGroupBox";
            this.speedGroupBox.Size = new System.Drawing.Size(176, 106);
            this.speedGroupBox.TabIndex = 11;
            this.speedGroupBox.TabStop = false;
            this.speedGroupBox.Text = "Speed:";
            // 
            // selectedMicDataGridView
            // 
            this.selectedMicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataColumn,
            this.ValueColumn});
            this.selectedMicDataGridView.Location = new System.Drawing.Point(2, 192);
            this.selectedMicDataGridView.Name = "selectedMicDataGridView";
            this.selectedMicDataGridView.RowHeadersVisible = false;
            this.selectedMicDataGridView.RowHeadersWidth = 10;
            this.selectedMicDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.selectedMicDataGridView.Size = new System.Drawing.Size(175, 245);
            this.selectedMicDataGridView.TabIndex = 12;
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Data";
            this.DataColumn.Name = "DataColumn";
            this.DataColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.Width = 70;
            // 
            // foodRuleLabel
            // 
            this.foodRuleLabel.AutoSize = true;
            this.foodRuleLabel.Location = new System.Drawing.Point(3, 168);
            this.foodRuleLabel.Name = "foodRuleLabel";
            this.foodRuleLabel.Size = new System.Drawing.Size(59, 13);
            this.foodRuleLabel.TabIndex = 13;
            this.foodRuleLabel.Text = "Food Rule:";
            // 
            // foodRuleComboBox
            // 
            this.foodRuleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodRuleComboBox.FormattingEnabled = true;
            this.foodRuleComboBox.Location = new System.Drawing.Point(77, 165);
            this.foodRuleComboBox.Name = "foodRuleComboBox";
            this.foodRuleComboBox.Size = new System.Drawing.Size(100, 21);
            this.foodRuleComboBox.TabIndex = 14;
            this.foodRuleComboBox.SelectedValueChanged += new System.EventHandler(this.foodRuleComboBox_SelectedValueChanged);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.leftPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainPicBox, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(812, 626);
            this.mainTableLayoutPanel.TabIndex = 15;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.selectedMicPicBox);
            this.leftPanel.Controls.Add(this.micsCountTextBox);
            this.leftPanel.Controls.Add(this.foodRuleComboBox);
            this.leftPanel.Controls.Add(this.mutRuleComboBox);
            this.leftPanel.Controls.Add(this.foodRuleLabel);
            this.leftPanel.Controls.Add(this.micCountLabel);
            this.leftPanel.Controls.Add(this.selectedMicDataGridView);
            this.leftPanel.Controls.Add(this.mutRuleLabel);
            this.leftPanel.Controls.Add(this.speedGroupBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(177, 620);
            this.leftPanel.TabIndex = 0;
            // 
            // selectedMicPicBox
            // 
            this.selectedMicPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedMicPicBox.Location = new System.Drawing.Point(3, 443);
            this.selectedMicPicBox.Name = "selectedMicPicBox";
            this.selectedMicPicBox.Size = new System.Drawing.Size(174, 174);
            this.selectedMicPicBox.TabIndex = 15;
            this.selectedMicPicBox.TabStop = false;
            this.selectedMicPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedMicPicBox_Paint);
            // 
            // mainPicBox
            // 
            this.mainPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicBox.Location = new System.Drawing.Point(186, 3);
            this.mainPicBox.Name = "mainPicBox";
            this.mainPicBox.Size = new System.Drawing.Size(623, 620);
            this.mainPicBox.TabIndex = 0;
            this.mainPicBox.TabStop = false;
            this.mainPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPicBox_Paint);
            this.mainPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPicBox_MouseClick);
            this.mainPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPicBox_MouseDown);
            this.mainPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPicBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldToolStripMenuItem,
            this.diagnosticsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.playPauseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.worldToolStripMenuItem.Text = "Simulation";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // diagnosticsToolStripMenuItem
            // 
            this.diagnosticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.diagnoseAllToolStripMenuItem,
            this.microbesChartToolStripMenuItem});
            this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.diagnosticsToolStripMenuItem.Text = "Diagnostics";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleMicrobeToolStripMenuItem,
            this.goupeToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.modeToolStripMenuItem.Text = "Selection Mode";
            // 
            // singleMicrobeToolStripMenuItem
            // 
            this.singleMicrobeToolStripMenuItem.Checked = true;
            this.singleMicrobeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.singleMicrobeToolStripMenuItem.Name = "singleMicrobeToolStripMenuItem";
            this.singleMicrobeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.singleMicrobeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.singleMicrobeToolStripMenuItem.Text = "Single Microbe";
            this.singleMicrobeToolStripMenuItem.Click += new System.EventHandler(this.singleMicrobeToolStripMenuItem_Click);
            // 
            // goupeToolStripMenuItem
            // 
            this.goupeToolStripMenuItem.Name = "goupeToolStripMenuItem";
            this.goupeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goupeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.goupeToolStripMenuItem.Text = "Goupe";
            this.goupeToolStripMenuItem.Click += new System.EventHandler(this.goupeToolStripMenuItem_Click);
            // 
            // diagnoseAllToolStripMenuItem
            // 
            this.diagnoseAllToolStripMenuItem.Name = "diagnoseAllToolStripMenuItem";
            this.diagnoseAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.diagnoseAllToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.diagnoseAllToolStripMenuItem.Text = "Diagnose All Microbes";
            this.diagnoseAllToolStripMenuItem.Click += new System.EventHandler(this.diagnoseAllToolStripMenuItem_Click);
            // 
            // microbesChartToolStripMenuItem
            // 
            this.microbesChartToolStripMenuItem.Name = "microbesChartToolStripMenuItem";
            this.microbesChartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.microbesChartToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.microbesChartToolStripMenuItem.Text = "Number of Microbes Diagram";
            this.microbesChartToolStripMenuItem.Click += new System.EventHandler(this.microbesChartToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeSettingsToolStripMenuItem
            // 
            this.changeSettingsToolStripMenuItem.Name = "changeSettingsToolStripMenuItem";
            this.changeSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.changeSettingsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeSettingsToolStripMenuItem.Text = "Change Settings";
            this.changeSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeSettingsToolStripMenuItem_Click);
            // 
            // chartTimer
            // 
            this.chartTimer.Enabled = true;
            this.chartTimer.Interval = 160;
            this.chartTimer.Tick += new System.EventHandler(this.chartTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 650);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(820, 684);
            this.Name = "Form1";
            this.Text = "Evalution Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.speedGroupBox.ResumeLayout(false);
            this.speedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicDataGridView)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicBox;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TextBox micsCountTextBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button sdBtn;
        private System.Windows.Forms.Button ffBtn;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.ComboBox mutRuleComboBox;
        private System.Windows.Forms.Label micCountLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label mutRuleLabel;
        private System.Windows.Forms.GroupBox speedGroupBox;
        private System.Windows.Forms.DataGridView selectedMicDataGridView;
        private System.Windows.Forms.Label foodRuleLabel;
        private System.Windows.Forms.ComboBox foodRuleComboBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox selectedMicPicBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleMicrobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnoseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.ToolStripMenuItem microbesChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSettingsToolStripMenuItem;
    }
}

