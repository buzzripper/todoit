using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace Todoit.UI
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
			components = new System.ComponentModel.Container();
			lbxReleasePkgs = new ListBox();
			statusStrip = new StatusStrip();
			stlblStatus = new ToolStripStatusLabel();
			tsbtnRefreshAppInfo = new ToolStripStatusLabel();
			label1 = new Label();
			picRefreshRelPkgList = new PictureBox();
			grdJobLogs = new DataGridView();
			todoItemBindingSource = new BindingSource(components);
			monitorTimer = new Timer(components);
			tabControl = new TabControl();
			tabJobHistory = new TabPage();
			lbxJobHistory = new ListBox();
			tabAvailReleases = new TabPage();
			tabArchives = new TabPage();
			picRefreshArchives = new PictureBox();
			label2 = new Label();
			lbxArchives = new ListBox();
			menuStrip1 = new MenuStrip();
			mnuFile = new ToolStripMenuItem();
			mnuStartApplication = new ToolStripMenuItem();
			mnuStopApplication = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			mnuExit = new ToolStripMenuItem();
			picRefreshLogs = new PictureBox();
			splitContainer1 = new SplitContainer();
			btnShowHideNav = new Button();
			statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshRelPkgList).BeginInit();
			((System.ComponentModel.ISupportInitialize)grdJobLogs).BeginInit();
			((System.ComponentModel.ISupportInitialize)todoItemBindingSource).BeginInit();
			tabControl.SuspendLayout();
			tabJobHistory.SuspendLayout();
			tabAvailReleases.SuspendLayout();
			tabArchives.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshArchives).BeginInit();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshLogs).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// lbxReleasePkgs
			// 
			lbxReleasePkgs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbxReleasePkgs.FormattingEnabled = true;
			lbxReleasePkgs.IntegralHeight = false;
			lbxReleasePkgs.ItemHeight = 25;
			lbxReleasePkgs.Location = new Point(13, 52);
			lbxReleasePkgs.Margin = new Padding(4, 5, 4, 5);
			lbxReleasePkgs.Name = "lbxReleasePkgs";
			lbxReleasePkgs.Size = new Size(440, 2112);
			lbxReleasePkgs.TabIndex = 4;
			lbxReleasePkgs.DoubleClick += lbxReleasePkgs_DoubleClick;
			// 
			// statusStrip
			// 
			statusStrip.ImageScalingSize = new Size(24, 24);
			statusStrip.Items.AddRange(new ToolStripItem[] { stlblStatus, tsbtnRefreshAppInfo });
			statusStrip.Location = new Point(0, 1472);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 20, 0);
			statusStrip.Size = new Size(1800, 36);
			statusStrip.TabIndex = 5;
			statusStrip.Text = "statusStrip1";
			// 
			// stlblStatus
			// 
			stlblStatus.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			stlblStatus.BorderStyle = Border3DStyle.SunkenOuter;
			stlblStatus.Name = "stlblStatus";
			stlblStatus.Size = new Size(1779, 29);
			stlblStatus.Spring = true;
			stlblStatus.Text = "Ready";
			stlblStatus.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tsbtnRefreshAppInfo
			// 
			tsbtnRefreshAppInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
			tsbtnRefreshAppInfo.Name = "tsbtnRefreshAppInfo";
			tsbtnRefreshAppInfo.Size = new Size(0, 29);
			tsbtnRefreshAppInfo.Text = "toolStripStatusLabel2";
			tsbtnRefreshAppInfo.Click += tsbtnRefreshAppInfo_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 17);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(154, 25);
			label1.TabIndex = 6;
			label1.Text = "Available Releases";
			// 
			// picRefreshRelPkgList
			// 
			picRefreshRelPkgList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			picRefreshRelPkgList.Cursor = Cursors.Hand;
			picRefreshRelPkgList.Location = new Point(424, 10);
			picRefreshRelPkgList.Margin = new Padding(4, 5, 4, 5);
			picRefreshRelPkgList.Name = "picRefreshRelPkgList";
			picRefreshRelPkgList.Size = new Size(36, 38);
			picRefreshRelPkgList.TabIndex = 7;
			picRefreshRelPkgList.TabStop = false;
			picRefreshRelPkgList.Click += picRefreshRelPkgList_Click;
			// 
			// grdJobLogs
			// 
			grdJobLogs.AllowUserToAddRows = false;
			grdJobLogs.AllowUserToDeleteRows = false;
			grdJobLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			grdJobLogs.AutoGenerateColumns = false;
			grdJobLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdJobLogs.DataSource = todoItemBindingSource;
			grdJobLogs.Location = new Point(4, 62);
			grdJobLogs.Margin = new Padding(4, 5, 4, 5);
			grdJobLogs.Name = "grdJobLogs";
			grdJobLogs.ReadOnly = true;
			grdJobLogs.RowHeadersWidth = 62;
			grdJobLogs.Size = new Size(1263, 1352);
			grdJobLogs.TabIndex = 17;
			// 
			// monitorTimer
			// 
			monitorTimer.Interval = 3000;
			monitorTimer.Tick += monitorTimer_Tick;
			// 
			// tabControl
			// 
			tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControl.Controls.Add(tabJobHistory);
			tabControl.Controls.Add(tabAvailReleases);
			tabControl.Controls.Add(tabArchives);
			tabControl.Location = new Point(17, 13);
			tabControl.Margin = new Padding(4, 5, 4, 5);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(479, 1405);
			tabControl.TabIndex = 24;
			// 
			// tabJobHistory
			// 
			tabJobHistory.BackColor = Color.Silver;
			tabJobHistory.Controls.Add(lbxJobHistory);
			tabJobHistory.Location = new Point(4, 34);
			tabJobHistory.Margin = new Padding(4, 5, 4, 5);
			tabJobHistory.Name = "tabJobHistory";
			tabJobHistory.Padding = new Padding(4, 5, 4, 5);
			tabJobHistory.Size = new Size(471, 1367);
			tabJobHistory.TabIndex = 0;
			tabJobHistory.Text = "Jobs";
			// 
			// lbxJobHistory
			// 
			lbxJobHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbxJobHistory.FormattingEnabled = true;
			lbxJobHistory.IntegralHeight = false;
			lbxJobHistory.ItemHeight = 25;
			lbxJobHistory.Location = new Point(13, 15);
			lbxJobHistory.Margin = new Padding(4, 5, 4, 5);
			lbxJobHistory.Name = "lbxJobHistory";
			lbxJobHistory.Size = new Size(440, 1323);
			lbxJobHistory.TabIndex = 0;
			lbxJobHistory.SelectedIndexChanged += lbxJobHistory_SelectedIndexChanged;
			// 
			// tabAvailReleases
			// 
			tabAvailReleases.BackColor = Color.Silver;
			tabAvailReleases.Controls.Add(label1);
			tabAvailReleases.Controls.Add(lbxReleasePkgs);
			tabAvailReleases.Controls.Add(picRefreshRelPkgList);
			tabAvailReleases.Location = new Point(4, 34);
			tabAvailReleases.Margin = new Padding(4, 5, 4, 5);
			tabAvailReleases.Name = "tabAvailReleases";
			tabAvailReleases.Padding = new Padding(4, 5, 4, 5);
			tabAvailReleases.Size = new Size(471, 1367);
			tabAvailReleases.TabIndex = 1;
			tabAvailReleases.Text = "Releases";
			// 
			// tabArchives
			// 
			tabArchives.BackColor = Color.Silver;
			tabArchives.Controls.Add(picRefreshArchives);
			tabArchives.Controls.Add(label2);
			tabArchives.Controls.Add(lbxArchives);
			tabArchives.Location = new Point(4, 34);
			tabArchives.Margin = new Padding(4, 5, 4, 5);
			tabArchives.Name = "tabArchives";
			tabArchives.Size = new Size(471, 1367);
			tabArchives.TabIndex = 2;
			tabArchives.Text = "Archive";
			// 
			// picRefreshArchives
			// 
			picRefreshArchives.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			picRefreshArchives.Cursor = Cursors.Hand;
			picRefreshArchives.Location = new Point(426, 10);
			picRefreshArchives.Margin = new Padding(4, 5, 4, 5);
			picRefreshArchives.Name = "picRefreshArchives";
			picRefreshArchives.Size = new Size(36, 38);
			picRefreshArchives.TabIndex = 25;
			picRefreshArchives.TabStop = false;
			picRefreshArchives.Click += picRefreshArchives_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 15);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(141, 25);
			label2.TabIndex = 24;
			label2.Text = "Release Archives";
			// 
			// lbxArchives
			// 
			lbxArchives.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbxArchives.FormattingEnabled = true;
			lbxArchives.IntegralHeight = false;
			lbxArchives.ItemHeight = 25;
			lbxArchives.Location = new Point(13, 45);
			lbxArchives.Margin = new Padding(4, 5, 4, 5);
			lbxArchives.Name = "lbxArchives";
			lbxArchives.Size = new Size(438, 2119);
			lbxArchives.TabIndex = 23;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(9, 3, 0, 3);
			menuStrip1.Size = new Size(1800, 35);
			menuStrip1.TabIndex = 26;
			menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuStartApplication, mnuStopApplication, toolStripMenuItem1, mnuExit });
			mnuFile.Name = "mnuFile";
			mnuFile.Size = new Size(54, 29);
			mnuFile.Text = "&File";
			// 
			// mnuStartApplication
			// 
			mnuStartApplication.Name = "mnuStartApplication";
			mnuStartApplication.Size = new Size(246, 34);
			mnuStartApplication.Text = "S&tart Application";
			mnuStartApplication.Click += mnuStartApplication_Click;
			// 
			// mnuStopApplication
			// 
			mnuStopApplication.Name = "mnuStopApplication";
			mnuStopApplication.Size = new Size(246, 34);
			mnuStopApplication.Text = "Sto&p Application";
			mnuStopApplication.Click += mnuStopApplication_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(243, 6);
			// 
			// mnuExit
			// 
			mnuExit.Name = "mnuExit";
			mnuExit.Size = new Size(246, 34);
			mnuExit.Text = "E&xit";
			mnuExit.Click += mnuExit_Click;
			// 
			// picRefreshLogs
			// 
			picRefreshLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			picRefreshLogs.Cursor = Cursors.Hand;
			picRefreshLogs.Location = new Point(1150, 13);
			picRefreshLogs.Margin = new Padding(4, 5, 4, 5);
			picRefreshLogs.Name = "picRefreshLogs";
			picRefreshLogs.Size = new Size(36, 38);
			picRefreshLogs.TabIndex = 30;
			picRefreshLogs.TabStop = false;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 35);
			splitContainer1.Margin = new Padding(4, 5, 4, 5);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(tabControl);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnShowHideNav);
			splitContainer1.Panel2.Controls.Add(grdJobLogs);
			splitContainer1.Panel2.Controls.Add(picRefreshLogs);
			splitContainer1.Size = new Size(1800, 1437);
			splitContainer1.SplitterDistance = 500;
			splitContainer1.SplitterWidth = 20;
			splitContainer1.TabIndex = 40;
			// 
			// btnShowHideNav
			// 
			btnShowHideNav.BackColor = Color.Silver;
			btnShowHideNav.Location = new Point(3, 7);
			btnShowHideNav.Name = "btnShowHideNav";
			btnShowHideNav.Size = new Size(53, 44);
			btnShowHideNav.TabIndex = 31;
			btnShowHideNav.Text = "<<";
			btnShowHideNav.UseVisualStyleBackColor = false;
			btnShowHideNav.Click += btnShowHideNav_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(1800, 1508);
			Controls.Add(splitContainer1);
			Controls.Add(statusStrip);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4, 5, 4, 5);
			Name = "Form1";
			Text = "Call Manager Installer";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshRelPkgList).EndInit();
			((System.ComponentModel.ISupportInitialize)grdJobLogs).EndInit();
			((System.ComponentModel.ISupportInitialize)todoItemBindingSource).EndInit();
			tabControl.ResumeLayout(false);
			tabJobHistory.ResumeLayout(false);
			tabAvailReleases.ResumeLayout(false);
			tabAvailReleases.PerformLayout();
			tabArchives.ResumeLayout(false);
			tabArchives.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshArchives).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picRefreshLogs).EndInit();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ListBox lbxVersions;
		private StatusStrip statusStrip;
		private Label label1;
		private ToolStripStatusLabel stlblStatus;
		private DataGridView grdJobLogs;
		private BindingSource todoItemBindingSource;
		private System.Windows.Forms.Timer monitorTimer;
		private ListBox lbxReleasePkgs;
		private PictureBox picRefreshRelPkgList;
		private ToolStripStatusLabel tsbtnRefreshAppInfo;
		private TabControl tabControl;
		private TabPage tabJobHistory;
		private TabPage tabAvailReleases;
		private ListBox lbxJobHistory;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem mnuFile;
		private ToolStripMenuItem mnuExit;
		private PictureBox picRefreshLogs;
		private TabPage tabArchives;
		private Label label2;
		private ListBox lbxArchives;
		private PictureBox picRefreshArchives;
		private ToolStripMenuItem mnuStartApplication;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem mnuStopApplication;
		private SplitContainer splitContainer1;
		private DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn exceptionDataGridViewTextBoxColumn;
		private Button btnShowHideNav;
	}
}
