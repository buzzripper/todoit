using Serilog;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todoit.UI;
using Todoit.UI.Data;

namespace Todoit.UI
{
	public partial class Form1 : Form
	{
		private readonly ILogger _logger;
		private readonly Db _db;

		public Form1(Db db, ILogger logger)
		{
			InitializeComponent();
			this.SuspendLayout();

			_db = db;
			_logger = logger;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//lkbServer.Text = null;
			//PopulateJobDetails(null, false);

			//monitorTimer.Start();
			//this.BeginInvoke(new Action(async () => await UpdateJobHistoryList()));
			//this.UpdateReleasePkgs();
			//this.UpdateArchives();

			this.ResumeLayout(false);
			ApplySettings();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void monitorTimer_Tick(object sender, EventArgs e)
		{
		}

		//private void PopulateAppInfo(AppInfo appInfo)
		//{
		//	if (appInfo != null)
		//	{
		//		lkbServer.Visible = true;
		//		lkbServer.Text = appInfo.ServerName;

		//		lblAppVer.Visible = true;
		//		lblAppVer.Text = appInfo.AppVersion.Version;
		//		if (!string.IsNullOrEmpty(appInfo.AppVersion.ShaVersion))
		//			lblAppVer.Text += $" ({appInfo.AppVersion.ShaVersion})";

		//		lblDbVer.Visible = true;
		//		lblDbVer.Text = appInfo?.AppVersion.DbVersion;

		//		lblReleaseMode.Text = appInfo?.ReleaseServiceMode.ToString();
		//	}
		//	else
		//	{
		//		lkbServer.Text = "--";
		//		lblAppVer.Text = "--";
		//		lblDbVer.Text = "--";
		//		lblReleaseMode.Text = "--";
		//	}
		//}

		//private void PopulateJobDetails(Job job, bool isRunning)
		//{
		//	try
		//	{
		//		if (job != null)
		//		{
		//			lblJobId.Text = job.Id.ToString();
		//			lblJobType.Text = job.JobType.ToString();
		//			lblJobVersion.Text = string.IsNullOrEmpty(job.Version) ? "--" : job.Version;
		//			lblJobStart.Text = job.StartTime.ToLocalTime().ToString("g");
		//			lblJobEnd.Text = job.EndTime?.ToLocalTime().ToString("g");
		//			lblJobStatus.Text = job.Status.ToString();

		//			picWaiting.Visible = isRunning;
		//			tabControl.Enabled = !isRunning;
		//		}
		//		else
		//		{
		//			lblJobId.Text = "--";
		//			lblJobType.Text = "--";
		//			lblJobVersion.Text = "--";
		//			lblJobStart.Text = "--";
		//			lblJobEnd.Text = "--";
		//			lblJobStatus.Text = "--";

		//			picWaiting.Visible = false;
		//			tabControl.Enabled = true;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		WriteStatusMsg($"{ex.GetType().Name} calling PopulateSelectedJob(): {ex.Message}");
		//	}
		//}

		#region Ping

		private void lkbServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//this.BeginInvoke(new Action(async () => await Ping()));
		}

		private async Task Ping()
		{
			//try
			//{
			//	var sb = new StringBuilder();

			//	var systemSvcPingResult = await _systemApiClient.Ping();
			//	sb.AppendLine($"{systemSvcPingResult.ControllerName} - {systemSvcPingResult.Message} ({systemSvcPingResult.LocalTime})");

			//	var installSvcPingResult = await _installApiClient.Ping();
			//	sb.AppendLine($"{installSvcPingResult.ControllerName} - {installSvcPingResult.Message} ({installSvcPingResult.LocalTime})");

			//	MessageBox.Show(sb.ToString(), "Ping Result");
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show($"{ex.GetType().Name} calling Ping(): {ex.Message}");
			//}
		}

		#endregion

		#region Start Install

		private void lbxReleasePkgs_DoubleClick(object sender, EventArgs e)
		{
			//this.BeginInvoke(new Action(async () => await StartDeploy()));
		}

		private async Task StartDeploy()
		{
			//var version = lbxReleasePkgs.SelectedItem.ToString();

			//if (MessageBox.Show($"Install version {version} now?", "Confirm Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			//	return;
			//try
			//{
			//	var response = await _installApiClient.Deploy(version);
			//	stlblStatus.Text = response.ResponseCode.ToString();
			//	if (response.ResponseCode == CommandResponseCode.Success)
			//		monitorTimer_Tick(null, null);
			//}
			//catch (Exception ex)
			//{
			//	WriteStatusMsg($"{ex.GetType().Name} calling StartInstall(): {ex.Message}");
			//}
		}

		#endregion

		#region Job History

		//private async Task UpdateJobHistoryList()
		//{
		//	lbxJobHistory.SuspendLayout();
		//	var jobs = await _systemApiClient.GetJobs();
		//	lbxJobHistory.DataSource = jobs;
		//}

		private void picRefreshJobs_Click(object sender, EventArgs e)
		{
			//UpdateJobHistoryList();
		}

		private void lbxJobHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			//this.BeginInvoke(new Action(() =>
			//{
			//	if (lbxJobHistory.SelectedIndex > -1)
			//	{
			//		var selectedJob = (Job)lbxJobHistory.SelectedItems[0];
			//		PopulateJobDetails(selectedJob, false);
			//		UpdateJobLogs(selectedJob.Id);
			//	}
			//	else
			//	{
			//		PopulateJobDetails(null, false);
			//		UpdateJobLogs(0);
			//	}
			//}));
		}

		#endregion

		private void tsbtnRefreshAppInfo_Click(object sender, EventArgs e)
		{
			//UpdateAppInfo();
		}

		private void picRefreshRelPkgList_Click(object sender, EventArgs e)
		{
			//UpdateReleasePkgs();
		}

		//private void UpdateReleasePkgs()
		//{
		//	this.BeginInvoke(new Action(async () =>
		//	{
		//		try
		//		{
		//			lbxReleasePkgs.SuspendLayout();

		//			var versions = await _systemApiClient.GetAvailableReleases();

		//			var orderedVersions = versions.OrderByDescending(v => v).ToList();

		//			foreach (var version in orderedVersions)
		//				if (!lbxReleasePkgs.Items.Contains(version))
		//					lbxReleasePkgs.Items.Add(version);

		//			foreach (var version in lbxReleasePkgs.Items)
		//				if (!orderedVersions.Contains(version))
		//					lbxReleasePkgs.Items.Remove(version);
		//		}
		//		catch (Exception ex)
		//		{
		//			stlblStatus.Text = $"Error retrieving available release versions - {ex.GetType().Name}: {ex.Message}";
		//			_logger.Error(stlblStatus.Text);
		//		}
		//		finally
		//		{
		//			lbxReleasePkgs.ResumeLayout();
		//		}
		//	}));
		//}

		//private void UpdateArchives()
		//{
		//	this.BeginInvoke(new Action(async () =>
		//	{
		//		try
		//		{
		//			lbxArchives.SuspendLayout();

		//			var filenames = await _systemApiClient.GetArchivedReleases();

		//			var orderedFilenames = filenames.OrderByDescending(v => v).ToList();

		//			foreach (var filename in orderedFilenames)
		//				if (!lbxArchives.Items.Contains(filename))
		//					lbxArchives.Items.Add(filename);

		//			foreach (var version in lbxArchives.Items)
		//				if (!orderedFilenames.Contains(version))
		//					lbxArchives.Items.Remove(version);
		//		}
		//		catch (Exception ex)
		//		{
		//			_logger.Error($"Error retrieving archives - {ex.GetType().Name}: {ex.Message}");
		//		}
		//		finally
		//		{
		//			lbxArchives.ResumeLayout();
		//		}
		//	}));
		//}

		//private void UpdateJobLogs(int jobId)
		//{
		//	this.BeginInvoke(new Action(async () =>
		//	{
		//		try
		//		{
		//			if (jobId <= 0)
		//			{
		//				grdJobLogs.DataSource = null;
		//				return;
		//			}

		//			var jobLogQuery = new JobLogQuery();
		//			jobLogQuery.JobId = jobId;

		//			var jobLogs = await _systemApiClient.QueryJobLogs(jobLogQuery);

		//			grdJobLogs.SuspendLayout();
		//			grdJobLogs.DataSource = jobLogs;
		//			grdJobLogs.ResetBindings();
		//			grdJobLogs.FirstDisplayedScrollingRowIndex = grdJobLogs.RowCount - 1;
		//		}
		//		catch (Exception ex)
		//		{
		//			WriteStatusMsg($"{ex.GetType().Name} calling UpdateJobLogs(): {ex.Message}");
		//		}
		//		finally
		//		{
		//			grdJobLogs.ResumeLayout(true);
		//		}
		//	}));
		//}

		private void picRefreshJobLogs_Click(object sender, EventArgs e)
		{
			//UpdateJobLogs(SelectedJob.Id);
		}

		private void picRefreshCurrJob_Click(object sender, EventArgs e)
		{
			//UpdateSelectedJob();
		}

		private void WriteStatusMsg(string message)
		{
			//stlblStatus.Text = message;
		}

		private void ckbAutoRefresh_CheckedChanged(object sender, EventArgs e)
		{
			//if (monitorTimer.Enabled)
			//{
			//	monitorTimer.Stop();
			//}
			//else
			//{
			//	monitorTimer.Start();
			//}
		}

		#region Logs

		//private void logsTimer_Tick(object sender, EventArgs e)
		//{
		//	this.BeginInvoke(new Action(async () =>
		//	{
		//		await this.UpdateJobLogs();
		//	}));
		//}

		#endregion

		private void picRefreshLogs_Click(object sender, EventArgs e)
		{
			//if (this.SelectedJob != null)
			//this.UpdateJobLogs(SelectedJob.Id);
		}

		#region Settings

		private void ApplySettings()
		{
			// Window
			if (Settings.Default.Maximized)
			{
				Location = Settings.Default.Location;
				WindowState = FormWindowState.Maximized;
			}
			else if (Settings.Default.Maximized)
			{
				// Don't save minimized state
			}
			else
			{
				Location = Settings.Default.Location;
				Size = Settings.Default.Size;
			}

			splitContainer1.SplitterDistance = Settings.Default.SplitterDistance;
		}

		private void SaveSettings()
		{
			if (WindowState == FormWindowState.Maximized)
			{
				Settings.Default.Location = RestoreBounds.Location;
				Settings.Default.Maximized = true;
			}
			else if (WindowState == FormWindowState.Minimized)
			{
				// Ignore minimized state
			}
			else
			{
				Settings.Default.Location = RestoreBounds.Location;
				Settings.Default.Size = RestoreBounds.Size;
				Settings.Default.Maximized = false;
			}

			Settings.Default.SplitterDistance = splitContainer1.SplitterDistance;

			Settings.Default.Save();
		}

		#endregion

		//private void mnuAutoMonitor_Click(object sender, EventArgs e)
		//{
		//	if (_appInfo == null)
		//	{
		//		MessageBox.Show("App info not present. Can't update auto-monitoring.");
		//		return;
		//	}

		//	var updateActionDescr = mnuAutoMonitor.Checked ? "Disable" : "Enable";

		//	if (MessageBox.Show($"{updateActionDescr} auto-monitoring for release packages?", "Auto-Monitoring", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		this.BeginInvoke(new Action(async () =>
		//		{
		//			await _systemApiClient.SetAutoMonitor(!mnuAutoMonitor.Checked);
		//			this.UpdateAppInfo();

		//			stlblStatus.Text = "Auto monitor set successfully.";
		//		}));
		//	}
		//}

		private void SelectJobHistory(int jobId)
		{
			//for (var i = 0; i < lbxJobHistory.Items.Count; i++)
			//{
			//	var job = (Job)lbxJobHistory.Items[i];
			//	if (job.Id == jobId)
			//	{
			//		lbxJobHistory.SelectedIndex = i;
			//		break;
			//	}
			//}
		}

		private void picRefreshArchives_Click(object sender, EventArgs e)
		{
			//UpdateArchives();
		}

		private void mnuStartApplication_Click(object sender, EventArgs e)
		{
			//if (MessageBox.Show($"Start web application and all services now?", "Confirm Start", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			//	return;

			//this.BeginInvoke(new Action(async () =>
			//{
			//	var response = await _installApiClient.StartApplication();
			//	stlblStatus.Text = response.ResponseCode.ToString();
			//	if (response.ResponseCode == CommandResponseCode.Success)
			//		monitorTimer_Tick(null, null);
			//}));
		}

		private void mnuStopApplication_Click(object sender, EventArgs e)
		{
			//if (MessageBox.Show($"Stop web application and all services now?", "Confirm Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			//	return;

			//this.BeginInvoke(new Action(async () =>
			//{
			//	var response = await _installApiClient.StopApplication();
			//	stlblStatus.Text = response.ResponseCode.ToString();
			//	if (response.ResponseCode == CommandResponseCode.Success)
			//		monitorTimer_Tick(null, null);
			//}));
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnShowHideNav_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
			btnShowHideNav.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
		}
	}
}
