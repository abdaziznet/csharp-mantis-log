using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Serilog;
using System.Configuration;
using System.Diagnostics;

namespace MantisLog
{
	public partial class FrmInquiryLog : MaterialForm
	{
		private List<LogFiles> listLogFile = null;
		private int pageSize = 0; // Number of items per page
		private int currentPageIndex = 1; // Current page index
		private List<LogFiles> pagedData = null;
		private List<LogFiles> tempData = null;

		private int getPageSize
		{
			get
			{
				if (pageSize == 0)
				{
					pageSize = Convert.ToInt16(ConfigurationManager.AppSettings["PageSize"]);
				}
				return pageSize;
			}
		}

		public FrmInquiryLog()
		{
			InitializeComponent();

			Log.Information("Mantislog initialized.");

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green500, Accent.Green400, TextShade.WHITE);


			txtCurrentPage.KeyDown += txtCurrentPage_KeyDown;
		}

		private void updateDateTimePicker()
		{
			string minDate = listLogFile.Select(log => log.Date).Distinct().First();

			dtStart.Value = castDateTime(minDate);
			dtEnd.Value = DateTime.Now;

			dtStart.Format = DateTimePickerFormat.Custom;
			dtStart.CustomFormat = "dd/MM/yyyy";

			dtEnd.Format = DateTimePickerFormat.Custom;
			dtEnd.CustomFormat = "dd/MM/yyyy";
		}

		private void updateComboBoxInfo()
		{
			cmboxInfo.DataSource = listLogFile.Select(log => log.Info).Distinct().ToList();
			cmboxInfo.DisplayMember = "Info";
		}

		private void updateDataGridView()
		{
			// Clear the existing rows in the DataGridView
			dataGridView.Rows.Clear();

			// Calculate the start index and end index of the current page
			int startIndex = (currentPageIndex - 1) * getPageSize;
			int endIndex = Math.Min(startIndex + getPageSize - 1, listLogFile.Count - 1);

			// Create a sublist containing the data for the current page
			pagedData = listLogFile.GetRange(startIndex, endIndex - startIndex + 1);

			// Add the data to the DataGridView
			foreach (var item in pagedData)
			{
				dataGridView.Rows.Add(item.LogName, item.Date, item.Time, item.GuidThreadId, item.AppName, item.AppVersion, item.Info, item.Message);
			}

			txtCurrentPage.Text = currentPageIndex.ToString();
		}

		private void createGridview()
		{
			// Add columns programmatically
			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "LogName",
				HeaderText = "Log Name",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
				Width = 230
			});// Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "Date",
				HeaderText = "Date",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
				Width = 100
			}); // Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "Time",
				HeaderText = "Time",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
				Width = 100

			}); // Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "GuidThreadId",
				HeaderText = "Guid ThreadId",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
				Width = 150
			}); // Auto-sized text column


			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "AppName",
				HeaderText = "App Name",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
				Width = 120
			}); // Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "AppVersion",
				HeaderText = "App Version",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			}); // Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "Info",
				HeaderText = "Info",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			}); // Auto-sized text column

			dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
			{
				Name = "Message",
				HeaderText = "Message",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			}); ; // Auto-sized text column
		}

		private DateTime castDateTime(string srcDate)
		{
			DateTime date = DateTime.MinValue;
			if (DateTime.TryParseExact(srcDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime result))
			{
				date = result;
			}
			return date.Date;
		}

		private void FrmInquiryLog_Load(object sender, EventArgs e)
		{
			if (!CheckSelfAppIsRunning("MantisLog"))
			{
				createGridview();
				activateControl(false);
				txtCurrentPage.Text = currentPageIndex.ToString();
			}
			else
			{
				MessageBox.Show("Mantis Log is already in use, please close mantis log application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				this.Close();
			}

			
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			try
			{
				Log.Information("Start browse file.");

				Cursor = Cursors.WaitCursor;
				activateControl(false);
				string selectedPath = string.Empty;
				lblTotalPage.Text = "1";

				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					selectedPath = folderBrowserDialog.SelectedPath;
				}
				else
				{
					return;
				}
				Log.Information("End browse file.");

				Log.Information("Start extract log to list.");

				string[] dirFiles = Directory.GetFiles(selectedPath, "*.LOG", SearchOption.AllDirectories);
				if (dirFiles.Count() > 0)
				{
					listLogFile = new List<LogFiles>();
					foreach (string filePath in dirFiles)
					{
						using (StreamReader reader = new StreamReader(filePath))
						{
							string logName = Path.GetFileName(filePath);
							string line;
							while ((line = reader.ReadLine()) != null)
							{
								try
								{
									string[] arrLine = line.Split('|');
									if (arrLine.Length > 0)
									{
										LogFiles logFiles = new LogFiles();
										logFiles.LogName = logName;
										logFiles.Date = arrLine[0].Split(' ')[0];
										logFiles.Time = arrLine[0].Split(' ')[1];
										logFiles.GuidThreadId = string.Format("{0}-{1}", arrLine[1], arrLine[2]);
										logFiles.AppName = arrLine[3];
										logFiles.AppVersion = arrLine[4];
										logFiles.Info = arrLine[5];
										logFiles.Message = arrLine[6];
										listLogFile.Add(logFiles);
									}
								}
								catch (Exception ex)
								{
									if (ex.Message.Contains("Index was outside the bounds of the array."))
									{
										continue;
									}
									else
									{
										Log.Error(ex.Message);
									}
								}
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Log files not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Log.Warning("Log files not found.");
					Cursor = Cursors.Arrow;
					return;
				}

				updateDataGridView();
				updateDateTimePicker();
				updateComboBoxInfo();
				activateControl(true);
				btnPrev.Enabled = false;
				btnNext.Enabled = false;
				txtCurrentPage.Enabled = false;
				Cursor = Cursors.Arrow;
				Log.Information("Extract log to list succeeded.");
				Log.Information("End extract log to list.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Log.Warning(ex.Message);
				Cursor = Cursors.Arrow;
				return;
			}
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Log.Information("Start inquiry log.");

			Cursor = Cursors.WaitCursor;

			string infoCiteria = cmboxInfo.Text;
			string msgCriteria = txtMessage.Text;
			DateTime fromDate = dtStart.Value.Date;
			DateTime toDate = dtEnd.Value.Date;

			tempData = new List<LogFiles>();
			tempData = listLogFile.Where(find => find.Info == infoCiteria && find.Message.Contains(msgCriteria) && castDateTime(find.Date) >= fromDate && castDateTime(find.Date) <= toDate).ToList();

			if (tempData.Count > 0)
			{
				// Calculate the start index and end index of the current page
				int startIndex = (currentPageIndex - 1) * getPageSize;
				int endIndex = Math.Min(startIndex + getPageSize - 1, tempData.Count - 1);
				int totalPage = (Int32)Math.Ceiling((double)tempData.Count / getPageSize);

				if (currentPageIndex > totalPage)
				{
					MessageBox.Show("Current page cannot be greater than Total page", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Log.Warning("Current page cannot be greater than Total page.");
					Cursor = Cursors.Arrow;

					return;
				}

				pagedData = new List<LogFiles>();
				// Create a sublist containing the data for the current page
				pagedData = tempData.GetRange(startIndex, endIndex - startIndex + 1);

				// Clear the existing rows in the DataGridView
				dataGridView.Rows.Clear();

				// Add the data to the DataGridView
				foreach (var item in pagedData)
				{
					dataGridView.Rows.Add(item.LogName, item.Date, item.Time, item.GuidThreadId, item.AppName, item.AppVersion, item.Info, item.Message);
				}
				// Update the navigation buttons' enabled/disabled status based on the current page index
				btnPrev.Enabled = (currentPageIndex - 1) > 0;
				btnNext.Enabled = endIndex < tempData.Count - 1; //currentPageIndex < (tempData.Count - 1) / pageSize;//endIndex < tempData.Count - 1;
				txtCurrentPage.Enabled = true;
				txtCurrentPage.Text = currentPageIndex.ToString();
				lblTotalPage.Text = totalPage.ToString();

			}
			else
			{
				// Clear the existing rows in the DataGridView
				dataGridView.Rows.Clear();

				// Update the navigation buttons' enabled/disabled status based on the current page index
				btnPrev.Enabled = false;
				btnNext.Enabled = false;
				txtCurrentPage.Text = "1";

				MessageBox.Show("Data not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Log.Information("Data not found.");

			}
			Cursor = Cursors.Arrow;
			Log.Information("Inquiry log succeeded.");
			Log.Information("End inquiry log.");
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (currentPageIndex > 0)
			{
				currentPageIndex--;
				btnSearch_Click(sender, e);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currentPageIndex < Convert.ToInt32(lblTotalPage.Text))//currentPageIndex < (tempData.Count - 1) / pageSize)
			{
				currentPageIndex++;
				btnSearch_Click(sender, e);
			}
		}

		private void activateControl(bool status)
		{
			dtStart.Enabled = status;
			dtEnd.Enabled = status;
			cmboxInfo.Enabled = status;
			txtMessage.Enabled = status;
			btnSearch.Enabled = status;
			btnPrev.Enabled = status;
			btnNext.Enabled = status;
			txtCurrentPage.Enabled = status;

		}

		private void txtCurrentPage_KeyDown(object sender, KeyEventArgs e)
		{
			// Check if the Enter key is pressed
			if (e.KeyCode == Keys.Enter)
			{
				if (string.IsNullOrEmpty(txtCurrentPage.Text) || Convert.ToInt16(txtCurrentPage.Text) <= 0)
				{
					txtCurrentPage.Text = "1";
				}
				currentPageIndex = Convert.ToInt32(txtCurrentPage.Text);
				// Call your function here
				btnSearch_Click(sender, e);

				// Prevent the key press from being processed further
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				return;
			}

			if (!string.IsNullOrEmpty(txtCurrentPage.Text))
			{
				if (Convert.ToInt32(txtCurrentPage.Text) <= 0)
				{
					txtCurrentPage.Text = "1";
				}
			}

		}

		public bool CheckSelfAppIsRunning(string appName)
		{
			bool result = false;
			int count = 0;
			Process[] processCollection = Process.GetProcesses();
			foreach (Process p in processCollection)
			{
				if (p.ProcessName.ToLower() == appName.ToLower())
				{
					count++;
				}
			}
			if (count > 1)
			{
				result = true;
			}
			return result;
		}
	}
}
