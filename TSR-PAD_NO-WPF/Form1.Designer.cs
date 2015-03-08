namespace TSR_PAD_NO_WPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.AppQuit_btn = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonTabmemo = new System.Windows.Forms.RibbonTab();
            this.TSRpan = new System.Windows.Forms.RibbonPanel();
            this.open_rbtn = new System.Windows.Forms.RibbonButton();
            this.close_rbtn = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ExtApp_pan = new System.Windows.Forms.RibbonPanel();
            this.extAppTools8grp = new System.Windows.Forms.RibbonItemGroup();
            this.Calc_btn = new System.Windows.Forms.RibbonButton();
            this.Mspaint_btn = new System.Windows.Forms.RibbonButton();
            this.extAppWordproc_grp = new System.Windows.Forms.RibbonItemGroup();
            this.notepad_btn = new System.Windows.Forms.RibbonButton();
            this.msword_btn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTabns = new System.Windows.Forms.RibbonTab();
            this.ds = new System.Data.DataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timemgmtST_itmdrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExceptionsTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.clickToStartTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.clickToEndTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.BreakTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.setupTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.coffee1TS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.lunchTS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.coffee2TS_MnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.AppQuit_btn);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(921, 125);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTabmemo);
            this.ribbon1.Tabs.Add(this.ribbonTabns);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // AppQuit_btn
            // 
            this.AppQuit_btn.Image = ((System.Drawing.Image)(resources.GetObject("AppQuit_btn.Image")));
            this.AppQuit_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("AppQuit_btn.SmallImage")));
            this.AppQuit_btn.Text = "Exit";
            this.AppQuit_btn.ToolTip = "Add power off btn";
            this.AppQuit_btn.ToolTipImage = global::TSR_PAD_NO_WPF.Properties.Resources.subindex16;
            // 
            // ribbonTabmemo
            // 
            this.ribbonTabmemo.Panels.Add(this.TSRpan);
            this.ribbonTabmemo.Panels.Add(this.ExtApp_pan);
            this.ribbonTabmemo.Panels.Add(this.ribbonPanel1);
            this.ribbonTabmemo.Text = "Calls";
            this.ribbonTabmemo.ToolTip = "add phone ico";
            this.ribbonTabmemo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ribbonTabmemo.ToolTipImage = global::TSR_PAD_NO_WPF.Properties.Resources.list_view;
            // 
            // TSRpan
            // 
            this.TSRpan.ButtonMoreEnabled = false;
            this.TSRpan.ButtonMoreVisible = false;
            this.TSRpan.Items.Add(this.open_rbtn);
            this.TSRpan.Items.Add(this.close_rbtn);
            this.TSRpan.Text = "TSR";
            // 
            // open_rbtn
            // 
            this.open_rbtn.Image = global::TSR_PAD_NO_WPF.Properties.Resources.open16;
            this.open_rbtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("open_rbtn.SmallImage")));
            this.open_rbtn.Text = "Current Calls";
            this.open_rbtn.ToolTip = "Add flash document";
            this.open_rbtn.Click += new System.EventHandler(this.open_rbtn_mainfrm_Click);
            // 
            // close_rbtn
            // 
            this.close_rbtn.DropDownItems.Add(this.ribbonButton1);
            this.close_rbtn.Image = global::TSR_PAD_NO_WPF.Properties.Resources.subindex16;
            this.close_rbtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("close_rbtn.SmallImage")));
            this.close_rbtn.Text = "Calls History";
            this.close_rbtn.ToolTip = "Add flash document with clock";
            this.close_rbtn.Click += new System.EventHandler(this.close_rbtn_mainfrm_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ExtApp_pan
            // 
            this.ExtApp_pan.ButtonMoreEnabled = false;
            this.ExtApp_pan.ButtonMoreVisible = false;
            this.ExtApp_pan.Items.Add(this.extAppTools8grp);
            this.ExtApp_pan.Items.Add(this.extAppWordproc_grp);
            this.ExtApp_pan.Text = "External Apps";
            // 
            // extAppTools8grp
            // 
            this.extAppTools8grp.Items.Add(this.Calc_btn);
            this.extAppTools8grp.Items.Add(this.Mspaint_btn);
            this.extAppTools8grp.Tag = "extApp_grp1";
            this.extAppTools8grp.Text = "Tools";
            // 
            // Calc_btn
            // 
            this.Calc_btn.Image = ((System.Drawing.Image)(resources.GetObject("Calc_btn.Image")));
            this.Calc_btn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.Calc_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("Calc_btn.SmallImage")));
            this.Calc_btn.Tag = "extApp";
            this.Calc_btn.Text = "Calculator";
            this.Calc_btn.ToolTip = "add calc ico";
            // 
            // Mspaint_btn
            // 
            this.Mspaint_btn.Image = ((System.Drawing.Image)(resources.GetObject("Mspaint_btn.Image")));
            this.Mspaint_btn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.Mspaint_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("Mspaint_btn.SmallImage")));
            this.Mspaint_btn.Tag = "extApp";
            this.Mspaint_btn.Text = "MS-Paint";
            this.Mspaint_btn.ToolTip = "add mspaint ico";
            // 
            // extAppWordproc_grp
            // 
            this.extAppWordproc_grp.Items.Add(this.notepad_btn);
            this.extAppWordproc_grp.Items.Add(this.msword_btn);
            this.extAppWordproc_grp.Tag = "extApp_grp2";
            this.extAppWordproc_grp.Text = "Word process";
            // 
            // notepad_btn
            // 
            this.notepad_btn.Image = ((System.Drawing.Image)(resources.GetObject("notepad_btn.Image")));
            this.notepad_btn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.notepad_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("notepad_btn.SmallImage")));
            this.notepad_btn.Tag = "extApp";
            this.notepad_btn.Text = "Notepad";
            this.notepad_btn.ToolTip = "add notepad ico";
            // 
            // msword_btn
            // 
            this.msword_btn.Image = ((System.Drawing.Image)(resources.GetObject("msword_btn.Image")));
            this.msword_btn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.msword_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("msword_btn.SmallImage")));
            this.msword_btn.Tag = "extApp";
            this.msword_btn.Text = "MS-Word";
            this.msword_btn.ToolTip = "add msword ico";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton2);
            this.ribbonPanel1.Text = "Internal Tools";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Tech status";
            // 
            // ribbonTabns
            // 
            this.ribbonTabns.Text = "NS";
            this.ribbonTabns.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ribbonTabns.ToolTipImage = global::TSR_PAD_NO_WPF.Properties.Resources.pen;
            // 
            // ds
            // 
            this.ds.DataSetName = "CallLog_ds";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timemgmtST_itmdrop});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "InteractionTime h:mm:ss";
            // 
            // timemgmtST_itmdrop
            // 
            this.timemgmtST_itmdrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExceptionsTS_MnuItm,
            this.BreakTS_MnuItm});
            this.timemgmtST_itmdrop.Image = ((System.Drawing.Image)(resources.GetObject("timemgmtST_itmdrop.Image")));
            this.timemgmtST_itmdrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timemgmtST_itmdrop.Name = "timemgmtST_itmdrop";
            this.timemgmtST_itmdrop.Size = new System.Drawing.Size(117, 20);
            this.timemgmtST_itmdrop.Text = "Time managment";
            this.timemgmtST_itmdrop.ToolTipText = "add sablier ico";
            // 
            // ExceptionsTS_MnuItm
            // 
            this.ExceptionsTS_MnuItm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToStartTS_MnuItm,
            this.clickToEndTS_MnuItm});
            this.ExceptionsTS_MnuItm.Name = "ExceptionsTS_MnuItm";
            this.ExceptionsTS_MnuItm.Size = new System.Drawing.Size(126, 22);
            this.ExceptionsTS_MnuItm.Text = "Exceptions";
            // 
            // clickToStartTS_MnuItm
            // 
            this.clickToStartTS_MnuItm.Name = "clickToStartTS_MnuItm";
            this.clickToStartTS_MnuItm.Size = new System.Drawing.Size(134, 22);
            this.clickToStartTS_MnuItm.Tag = "expST";
            this.clickToStartTS_MnuItm.Text = "Click to start";
            // 
            // clickToEndTS_MnuItm
            // 
            this.clickToEndTS_MnuItm.Name = "clickToEndTS_MnuItm";
            this.clickToEndTS_MnuItm.Size = new System.Drawing.Size(134, 22);
            this.clickToEndTS_MnuItm.Tag = "expST";
            this.clickToEndTS_MnuItm.Text = "Click to end";
            // 
            // BreakTS_MnuItm
            // 
            this.BreakTS_MnuItm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupTS_MnuItm,
            this.coffee1TS_MnuItm,
            this.lunchTS_MnuItm,
            this.coffee2TS_MnuItm});
            this.BreakTS_MnuItm.Name = "BreakTS_MnuItm";
            this.BreakTS_MnuItm.Size = new System.Drawing.Size(126, 22);
            this.BreakTS_MnuItm.Text = "Break";
            // 
            // setupTS_MnuItm
            // 
            this.setupTS_MnuItm.Name = "setupTS_MnuItm";
            this.setupTS_MnuItm.Size = new System.Drawing.Size(116, 22);
            this.setupTS_MnuItm.Tag = "breakST";
            this.setupTS_MnuItm.Text = "Setup";
            // 
            // coffee1TS_MnuItm
            // 
            this.coffee1TS_MnuItm.CheckOnClick = true;
            this.coffee1TS_MnuItm.Name = "coffee1TS_MnuItm";
            this.coffee1TS_MnuItm.Size = new System.Drawing.Size(116, 22);
            this.coffee1TS_MnuItm.Tag = "breakST";
            this.coffee1TS_MnuItm.Text = "Coffee 1";
            // 
            // lunchTS_MnuItm
            // 
            this.lunchTS_MnuItm.CheckOnClick = true;
            this.lunchTS_MnuItm.Name = "lunchTS_MnuItm";
            this.lunchTS_MnuItm.Size = new System.Drawing.Size(116, 22);
            this.lunchTS_MnuItm.Tag = "breakST";
            this.lunchTS_MnuItm.Text = "Lunch";
            // 
            // coffee2TS_MnuItm
            // 
            this.coffee2TS_MnuItm.CheckOnClick = true;
            this.coffee2TS_MnuItm.Name = "coffee2TS_MnuItm";
            this.coffee2TS_MnuItm.Size = new System.Drawing.Size(116, 22);
            this.coffee2TS_MnuItm.Tag = "breakST";
            this.coffee2TS_MnuItm.Text = "Coffee 2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 125);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(921, 330);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(173, 330);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.ds;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 330);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 477);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "TSR-pad";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTabmemo;
        private System.Windows.Forms.RibbonTab ribbonTabns;
        private System.Windows.Forms.RibbonPanel TSRpan;
        private System.Windows.Forms.RibbonButton close_rbtn;
        private System.Windows.Forms.RibbonButton open_rbtn;
        private System.Windows.Forms.RibbonOrbOptionButton AppQuit_btn;
        private System.Windows.Forms.RibbonPanel ExtApp_pan;
        private System.Windows.Forms.RibbonItemGroup extAppTools8grp;
        private System.Windows.Forms.RibbonButton Calc_btn;
        private System.Windows.Forms.RibbonButton Mspaint_btn;
        private System.Windows.Forms.RibbonItemGroup extAppWordproc_grp;
        private System.Windows.Forms.RibbonButton notepad_btn;
        private System.Windows.Forms.RibbonButton msword_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton timemgmtST_itmdrop;
        private System.Windows.Forms.ToolStripMenuItem BreakTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem ExceptionsTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem clickToStartTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem clickToEndTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem setupTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem coffee1TS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem lunchTS_MnuItm;
        private System.Windows.Forms.ToolStripMenuItem coffee2TS_MnuItm;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Data.DataSet ds;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

