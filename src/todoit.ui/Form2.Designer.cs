//using System.Drawing;
//using System.Windows.Forms;

//namespace Todoit.UI
//{
//	partial class Form2
//	{
//		/// <summary>
//		///  Required designer variable.
//		/// </summary>
//		private System.ComponentModel.IContainer components = null;

//		/// <summary>
//		///  Clean up any resources being used.
//		/// </summary>
//		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//		protected override void Dispose(bool disposing)
//		{
//			if (disposing && (components != null))
//			{
//				components.Dispose();
//			}
//			base.Dispose(disposing);
//		}

//		#region Windows Form Designer generated code

//		/// <summary>
//		///  Required method for Designer support - do not modify
//		///  the contents of this method with the code editor.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
//			btnGetToken = new Button();
//			label1 = new Label();
//			label2 = new Label();
//			btnCopy = new Button();
//			txtDecodedToken = new TextBox();
//			cmbClientApps = new ComboBox();
//			txtToken = new TextBox();
//			cmbResourceApps = new ComboBox();
//			label3 = new Label();
//			txtUrl = new TextBox();
//			label4 = new Label();
//			SuspendLayout();
//			// 
//			// btnGetToken
//			// 
//			btnGetToken.Location = new Point(237, 130);
//			btnGetToken.Margin = new Padding(4, 5, 4, 5);
//			btnGetToken.Name = "btnGetToken";
//			btnGetToken.Size = new Size(143, 59);
//			btnGetToken.TabIndex = 0;
//			btnGetToken.Text = "Get Token";
//			btnGetToken.UseVisualStyleBackColor = true;
//			btnGetToken.Click += btnGetToken_Click;
//			// 
//			// label1
//			// 
//			label1.AutoSize = true;
//			label1.ForeColor = SystemColors.ButtonFace;
//			label1.Location = new Point(26, 215);
//			label1.Margin = new Padding(4, 0, 4, 0);
//			label1.Name = "label1";
//			label1.Size = new Size(62, 25);
//			label1.TabIndex = 3;
//			label1.Text = "Token:";
//			// 
//			// label2
//			// 
//			label2.AutoSize = true;
//			label2.ForeColor = SystemColors.ButtonFace;
//			label2.Location = new Point(19, 78);
//			label2.Margin = new Padding(4, 0, 4, 0);
//			label2.Name = "label2";
//			label2.Size = new Size(99, 25);
//			label2.TabIndex = 5;
//			label2.Text = "Client App:";
//			// 
//			// btnCopy
//			// 
//			btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//			btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
//			btnCopy.Location = new Point(795, 207);
//			btnCopy.Margin = new Padding(4, 5, 4, 5);
//			btnCopy.Name = "btnCopy";
//			btnCopy.Size = new Size(44, 50);
//			btnCopy.TabIndex = 7;
//			btnCopy.UseVisualStyleBackColor = true;
//			btnCopy.Click += btnCopy_Click;
//			// 
//			// txtDecodedToken
//			// 
//			txtDecodedToken.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
//			txtDecodedToken.BackColor = SystemColors.WindowFrame;
//			txtDecodedToken.ForeColor = SystemColors.ControlLightLight;
//			txtDecodedToken.Location = new Point(17, 280);
//			txtDecodedToken.Margin = new Padding(4, 5, 4, 5);
//			txtDecodedToken.Multiline = true;
//			txtDecodedToken.Name = "txtDecodedToken";
//			txtDecodedToken.ScrollBars = ScrollBars.Vertical;
//			txtDecodedToken.Size = new Size(819, 366);
//			txtDecodedToken.TabIndex = 9;
//			// 
//			// cmbClientApps
//			// 
//			cmbClientApps.BackColor = SystemColors.ButtonHighlight;
//			cmbClientApps.DropDownStyle = ComboBoxStyle.DropDownList;
//			cmbClientApps.FormattingEnabled = true;
//			cmbClientApps.Location = new Point(122, 73);
//			cmbClientApps.Margin = new Padding(4, 5, 4, 5);
//			cmbClientApps.Name = "cmbClientApps";
//			cmbClientApps.Size = new Size(207, 33);
//			cmbClientApps.TabIndex = 13;
//			// 
//			// txtToken
//			// 
//			txtToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
//			txtToken.BackColor = SystemColors.WindowFrame;
//			txtToken.ForeColor = SystemColors.ControlLightLight;
//			txtToken.Location = new Point(93, 212);
//			txtToken.Margin = new Padding(4, 5, 4, 5);
//			txtToken.Name = "txtToken";
//			txtToken.Size = new Size(679, 31);
//			txtToken.TabIndex = 14;
//			// 
//			// cmbResourceApps
//			// 
//			cmbResourceApps.BackColor = SystemColors.ButtonHighlight;
//			cmbResourceApps.DropDownStyle = ComboBoxStyle.DropDownList;
//			cmbResourceApps.FormattingEnabled = true;
//			cmbResourceApps.Location = new Point(403, 73);
//			cmbResourceApps.Margin = new Padding(4, 5, 4, 5);
//			cmbResourceApps.Name = "cmbResourceApps";
//			cmbResourceApps.Size = new Size(207, 33);
//			cmbResourceApps.TabIndex = 16;
//			// 
//			// label3
//			// 
//			label3.AutoSize = true;
//			label3.ForeColor = SystemColors.ButtonFace;
//			label3.Location = new Point(355, 78);
//			label3.Margin = new Padding(4, 0, 4, 0);
//			label3.Name = "label3";
//			label3.Size = new Size(43, 25);
//			label3.TabIndex = 15;
//			label3.Text = "Api:";
//			// 
//			// txtUrl
//			// 
//			txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
//			txtUrl.BackColor = SystemColors.WindowFrame;
//			txtUrl.ForeColor = SystemColors.ControlLightLight;
//			txtUrl.Location = new Point(72, 17);
//			txtUrl.Margin = new Padding(4, 5, 4, 5);
//			txtUrl.Name = "txtUrl";
//			txtUrl.Size = new Size(764, 31);
//			txtUrl.TabIndex = 18;
//			// 
//			// label4
//			// 
//			label4.AutoSize = true;
//			label4.ForeColor = SystemColors.ButtonFace;
//			label4.Location = new Point(26, 17);
//			label4.Margin = new Padding(4, 0, 4, 0);
//			label4.Name = "label4";
//			label4.Size = new Size(38, 25);
//			label4.TabIndex = 17;
//			label4.Text = "Url:";
//			// 
//			// Form2
//			// 
//			AcceptButton = btnGetToken;
//			AutoScaleDimensions = new SizeF(10F, 25F);
//			AutoScaleMode = AutoScaleMode.Font;
//			BackColor = SystemColors.ControlDarkDark;
//			ClientSize = new Size(855, 671);
//			Controls.Add(txtUrl);
//			Controls.Add(label4);
//			Controls.Add(cmbResourceApps);
//			Controls.Add(label3);
//			Controls.Add(txtToken);
//			Controls.Add(txtDecodedToken);
//			Controls.Add(btnCopy);
//			Controls.Add(cmbClientApps);
//			Controls.Add(label2);
//			Controls.Add(label1);
//			Controls.Add(btnGetToken);
//			Margin = new Padding(4, 5, 4, 5);
//			Name = "Form2";
//			Text = "ToDoIt";
//			FormClosing += Form1_FormClosing;
//			Load += Form1_Load;
//			ResumeLayout(false);
//			PerformLayout();
//		}

//		#endregion

//		private Button btnGetToken;
//		private Button btnSetPassword;
//		private Label label1;
//		private Label label2;
//		private Button btnCopy;
//		private TextBox txtDecodedToken;
//		private ComboBox cmbClientApps;
//		private TextBox txtToken;
//		private ComboBox cmbResourceApps;
//		private Label label3;
//		private TextBox txtUrl;
//		private Label label4;
//	}
//}
