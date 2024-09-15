//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.IdentityModel.Tokens.Jwt;
//using Todoit.UI.Config;
//using Todoit.UI;
//using System.Windows.Forms;
//using System.Net.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Todoit.UI
//{
//	public partial class Form2 : Form
//	{
//		private readonly AppConfig _appConfig;
//		private readonly IHttpClientFactory _httpClientFactory;

//		public Form2(AppConfig appConfig, IHttpClientFactory httpClientFactory)
//		{
//			InitializeComponent();

//			_appConfig = appConfig;
//			_httpClientFactory = httpClientFactory;
//		}

//		private void Form1_Load(object sender, EventArgs e)
//		{
//			//_appConfig.ClientApps.ForEach(ca => cmbClientApps.Items.Add(ca));
//			//_appConfig.ResourceApps.ForEach(ca => cmbResourceApps.Items.Add(ca));

//			ApplySettings();
//		}

//		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//		{
//			SaveSettings();
//		}

//		private void btnGetToken_Click(object sender, EventArgs e)
//		{
//			if (cmbClientApps.SelectedIndex == -1)
//			{
//				MessageBox.Show("No app client selected.");
//				return;
//			}

//			if (cmbResourceApps.SelectedIndex == -1)
//			{
//				MessageBox.Show("No API selected.");
//				return;
//			}

//			txtToken.Text = null;
//			txtDecodedToken.Text = null;

//			var clientApp = _appConfig.ClientApps[cmbClientApps.SelectedIndex];
//			var resourceApp = _appConfig.ResourceApps[cmbResourceApps.SelectedIndex];

//			this.BeginInvoke(new Action(async () =>
//			{
//				this.Cursor = Cursors.WaitCursor;
//				try
//				{
//					using var httpClient = _httpClientFactory.CreateClient();

//					var request = new HttpRequestMessage(HttpMethod.Post, txtUrl.Text);

//					request.Content = new FormUrlEncodedContent(
//						new Dictionary<string, string>
//						{
//							{ "grant_type", "client_credentials" },
//							{ "client_id", clientApp.ClientId },
//							{ "client_secret", clientApp.ClientSecret },
//							{ "scope", $"https://{_appConfig.B2CTenantName}.onmicrosoft.com/{resourceApp.Id}/.default" },
//						});

//					var response = await httpClient.SendAsync(request);
//					response.EnsureSuccessStatusCode();

//					string content = await response.Content.ReadAsStringAsync();
//					var respObj = JsonSerializer.Deserialize<TokenResponse>(content);
//					string accessToken = respObj.AccessToken;

//					txtToken.Text = accessToken;
//					Clipboard.SetText(txtToken.Text);

//					txtDecodedToken.Text = DecodeToken(accessToken);
//				}
//				catch (Exception ex)
//				{
//					txtToken.Text = $"Error:{Environment.NewLine}{ex.Message}";
//				}
//				finally
//				{
//					this.Cursor = Cursors.Default;
//				}
//			}));
//		}

//		internal class TokenResponse
//		{
//			[JsonPropertyName("access_token")]
//			public string AccessToken { get; set; }

//			[JsonPropertyName("expires_in")]
//			public int ExpiresIn { get; set; }

//			[JsonPropertyName("scope")]
//			public string Scope { get; set; }
//		}

//		private string ComputeHash(string username, string clientId, string clientSecret)
//		{
//			var message = $"{username}{clientId}";

//			byte[] clientSecretBytes = Encoding.UTF8.GetBytes(clientSecret);

//			var hmac = new System.Security.Cryptography.HMACSHA256(clientSecretBytes);

//			var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(message));

//			return Convert.ToBase64String(hash);
//		}

//		#region Settings

//		private void ApplySettings()
//		{
//			// Url

//			if (!string.IsNullOrWhiteSpace(Settings.Default.MRU_Url))
//				txtUrl.Text = Settings.Default.MRU_Url;
//			else
//				txtUrl.Text = _appConfig.TokenRequestUrl;

//			// Dropdowns

//			if (cmbClientApps.Items.Count > 0 && _appConfig.ClientApps.Count > 0 && (Settings.Default.MRU_AppIdx < _appConfig.ClientApps.Count))
//				cmbClientApps.SelectedIndex = Settings.Default.MRU_AppIdx;
//			if (cmbResourceApps.Items.Count > 0 && _appConfig.ResourceApps.Count > 0 && (Settings.Default.MRU_AppIdx < _appConfig.ResourceApps.Count))
//				cmbResourceApps.SelectedIndex = Settings.Default.MRU_ApiIdx;

//			// Window size/position

//			var x = Settings.Default.Size;
//			if (Settings.Default.Maximized)
//			{
//				Location = Settings.Default.Location;
//				WindowState = FormWindowState.Maximized;
//			}
//			else if (Settings.Default.Maximized)
//			{
//				// Don't save minimized state
//			}
//			else
//			{
//				Location = Settings.Default.Location;
//				Size = Settings.Default.Size;
//			}
//		}

//		private void SaveSettings()
//		{
//			// Url

//			Settings.Default.MRU_Url = txtUrl.Text;

//			// Window size/position

//			Settings.Default.MRU_AppIdx = cmbClientApps.SelectedIndex;
//			Settings.Default.MRU_ApiIdx = cmbResourceApps.SelectedIndex;

//			if (WindowState == FormWindowState.Maximized)
//			{
//				Settings.Default.Location = this.Location;
//				Settings.Default.Maximized = true;
//			}
//			else if (WindowState == FormWindowState.Minimized)
//			{
//				// Ignore minimized state
//			}
//			else
//			{
//				Settings.Default.Location = this.Location;
//				Settings.Default.Size = this.Size; //new Size(this.Width, this.Height);
//				Settings.Default.Maximized = false;
//			}
//			Settings.Default.Save();
//		}

//		#endregion

//		private void btnCopy_Click(object sender, EventArgs e)
//		{
//			Clipboard.SetText(txtToken.Text);
//		}

//		private void btnValidateToken_Click(object sender, EventArgs e)
//		{
//			if (txtToken.Text.Length == 0)
//			{
//				MessageBox.Show("No token.");
//				return;
//			}

//			var accessToken = txtToken.Text;

//			this.BeginInvoke(new Action(async () =>
//			{
//				this.Cursor = Cursors.WaitCursor;
//				try
//				{
//					//var jwtValidator = new JwtValidator();
//					//var validatedToken = await JwtValidator.ValidateTokenAsync(accessToken, "us-east-1", _appConfig.UserPoolId, _appConfig.ClientId);

//					txtToken.Text = null;
//					//validatedToken.Claims.ToList().ForEach(c => txtToken.Text += $"{c.Type} : {c.Value}{Environment.NewLine}");
//				}
//				catch (Exception ex)
//				{
//					MessageBox.Show($"Error:{Environment.NewLine}{ex.Message}", "Token Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//				}
//				finally
//				{
//					this.Cursor = Cursors.Default;
//				}
//			}));
//		}

//		private string DecodeToken(string jwt)
//		{
//			if (string.IsNullOrWhiteSpace(jwt))
//				return null;

//			var handler = new JwtSecurityTokenHandler();
//			var jwtSecurityToken = handler.ReadJwtToken(jwt);

//			var keyId = jwtSecurityToken.Header.Kid;
//			var audience = jwtSecurityToken.Audiences.ToList()?.FirstOrDefault();
//			var claims = jwtSecurityToken.Claims.Select(claim => (claim.Type, claim.Value)).ToList();

//			var sb = new StringBuilder();

//			sb.AppendLine("Claims:");
//			foreach (var claim in claims)
//				sb.AppendLine($"\t{claim.Type} = {claim.Value}");

//			sb.AppendLine($"ValidTo: {jwtSecurityToken.ValidTo}");
//			sb.AppendLine($"ValidFrom: {jwtSecurityToken.ValidFrom}");
//			sb.AppendLine($"Audience: {audience}");
//			sb.AppendLine($"Issuer: {jwtSecurityToken.Issuer}");
//			sb.AppendLine($"Subject: {jwtSecurityToken.Subject}");

//			return sb.ToString();

//			//return new DecodedToken(
//			//	keyId,
//			//	jwtSecurityToken.Issuer,
//			//	audience,
//			//	claims,
//			//	jwtSecurityToken.ValidTo,
//			//	jwtSecurityToken.SignatureAlgorithm,
//			//	jwtSecurityToken.RawData,
//			//	jwtSecurityToken.Subject,
//			//	jwtSecurityToken.ValidFrom,
//			//	jwtSecurityToken.EncodedHeader,
//			//	jwtSecurityToken.EncodedPayload
//			//);
//		}
//	}
//}
