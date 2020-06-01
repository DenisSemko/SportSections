using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using SportSectionsCourseWork.FunctionsForms;
using System.Runtime.InteropServices;

namespace SportSectionsCourseWork
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			SidePanel.Height = button2.Height;
			SidePanel.Top = button2.Top;
		
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Розклад_секцій". При необходимости она может быть перемещена или удалена.
			this.розклад_секційTableAdapter.Fill(this.sportSectionsDataSet.Розклад_секцій);
			this.спортивні_секціїTableAdapter.Fill(this.sportSectionsDataSet.Спортивні_секції);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Викладачі". При необходимости она может быть перемещена или удалена.
			this.викладачіTableAdapter.Fill(this.sportSectionsDataSet.Викладачі);
			this.студентиTableAdapter.Fill(this.sportSectionsDataSet.Студенти);
			dataGridView1.AutoGenerateColumns = true;
			Section();

		}
		string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\Базы Данных\БД 2к19\SportSectionsCourseWork\SportSectionsCourseWork\SportSections.mdf;Integrated Security = True";

		private bool IsButton;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void ShowFilterButton(object sender, EventArgs e)
		{
			IsButton = !IsButton;
			deletefilterToolStripMenuItem.Visible = IsButton;
		}

		public void Section()
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Спортивні секції]", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
			searchTextBox.Enabled = true;
			button1.Enabled = true;
			button1.Text = "Шукати згідно назви секції";
			toolStripMenuItem1.Text = "Згідно назви секції";
			toolStripMenuItem2.Text = "Згідно ID";
			addToolStripMenuItem.Text = "Додати спортивну секцію";
			editingToolStripMenuItem.Text = "Редагувати спортивну секцію";
			deleteToolStripMenuItem.Text = "Видалити спортивну секцію";
		}

		public void Teachers()
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Викладачі", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
			searchTextBox.Enabled = true;
			button1.Enabled = true;
			button1.Text = "Шукати згідно прізвища викладача";
			toolStripMenuItem1.Text = "Згідно прізвища викладача";
			toolStripMenuItem2.Text = "Згідно вченого звання викладача";
			addToolStripMenuItem.Text = "Додати дані про викладача";
			editingToolStripMenuItem.Text = "Редагувати дані про викладача";
			deleteToolStripMenuItem.Text = "Видалити дані про викладача";

		}

		public void Students()
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Студенти", sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
			searchTextBox.Enabled = true;
			button1.Enabled = true;
			button1.Text = "Шукати згідно групи студента";
			toolStripMenuItem1.Text = "Згідно прізвища студента";
			toolStripMenuItem2.Text = "Згідно групи студента";
			addToolStripMenuItem.Text = "Додати дані про студента";
			editingToolStripMenuItem.Text = "Редагувати дані про студента";
			deleteToolStripMenuItem.Text = "Видалити дані про студента";
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			спортивні_секціїTableAdapter.Update(sportSectionsDataSet);
			викладачіTableAdapter.Update(sportSectionsDataSet);
			студентиTableAdapter.Update(sportSectionsDataSet);
		}

		private void sportSectionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Text = "Спортивні секції";
			Section();
			searchTextBox.Clear();
		}

		private void professorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Text = "Викладачі";
			Teachers();
			searchTextBox.Clear();
		}

		private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Text = "Студенти";
			Students();
			searchTextBox.Clear();
		}



		private void button1_Click(object sender, EventArgs e)
		{
			switch(label1.Text)
			{
				case ("Спортивні секції"):
				{
						string selectString =
							"[Назва секції] LIKE '" + searchTextBox.Text.Trim() + "%'";

						DataRowCollection allRows =
							((DataTable)dataGridView1.DataSource).Rows;

						DataRow[] searchedRows =
							((DataTable)dataGridView1.DataSource).
							Select(selectString);

						int rowIndex = allRows.IndexOf(searchedRows[0]);

						dataGridView1.CurrentCell =
							dataGridView1[0, rowIndex];
						break;
				}
				case ("Викладачі"):
				{
					string selectString =
						"Прізвище LIKE '" + searchTextBox.Text.Trim() + "%'";

					DataRowCollection allRows =
						((DataTable)dataGridView1.DataSource).Rows;

					DataRow[] searchedRows =
						((DataTable)dataGridView1.DataSource).
						Select(selectString);

					int rowIndex = allRows.IndexOf(searchedRows[0]);

					dataGridView1.CurrentCell =
						dataGridView1[0, rowIndex];
					break;
				}
				case ("Студенти"):
				{
					string selectString =
						"Група LIKE '" + searchTextBox.Text.Trim() + "%'";

					DataRowCollection allRows =
						((DataTable)dataGridView1.DataSource).Rows;

					DataRow[] searchedRows =
						((DataTable)dataGridView1.DataSource).
						Select(selectString);

					int rowIndex = allRows.IndexOf(searchedRows[0]);

					dataGridView1.CurrentCell =
						dataGridView1[0, rowIndex];
					break;
				}
			}
		}

		private void sportSchedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var ss = new Розклад_секцій();
			ss.ShowDialog();
			спортивні_секціїTableAdapter.Fill(sportSectionsDataSet.Спортивні_секції);
			викладачіTableAdapter.Fill(sportSectionsDataSet.Викладачі);
			студентиTableAdapter.Fill(sportSectionsDataSet.Студенти);
			розклад_секційTableAdapter.Fill(sportSectionsDataSet.Розклад_секцій);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Спортивні секції] ORDER BY [Назва секції];", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;
				}
				case ("Викладачі"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Викладачі ORDER BY Прізвище;", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;
					}
				case ("Студенти"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Студенти ORDER BY Прізвище;", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;

					}
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Спортивні секції] ORDER BY ID_викладача;", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;
				}
				case ("Викладачі"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Викладачі ORDER BY [Вчене звання];", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;
				}
				case ("Студенти"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Студенти ORDER BY Група;", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					break;

				}

			}
		}



		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var ss = new Розклад_секцій();
			ss.ShowDialog();
			спортивні_секціїTableAdapter.Fill(sportSectionsDataSet.Спортивні_секції);
			викладачіTableAdapter.Fill(sportSectionsDataSet.Викладачі);
			студентиTableAdapter.Fill(sportSectionsDataSet.Студенти);
			розклад_секційTableAdapter.Fill(sportSectionsDataSet.Розклад_секцій);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			OpenStudents();
		}

		private void OpenStudents()
		{
			var stsc = new StudentsScheduleForm();
			stsc.Show();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					var ad = new AddSections();
					ad.ShowDialog();
					Section();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
				case ("Викладачі"):
				{
					var at = new AddTeacher();
					at.ShowDialog();
					Teachers();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
				case ("Студенти"):
				{
					var astu = new AddStudent();
					astu.ShowDialog();
					Students();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
			}

		}

		private void editingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					DataGridViewRow temp = dataGridView1.SelectedRows[0];
					var ep = new AddSections(Convert.ToString(temp.Cells[0].Value), Convert.ToInt32(temp.Cells[1].Value));
					ep.ShowDialog();
					Section();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
				case ("Викладачі"):
				{
					DataGridViewRow temp = dataGridView1.SelectedRows[0];
					var ep = new AddTeacher(Convert.ToInt32(temp.Cells[0].Value), Convert.ToString(temp.Cells[1].Value), Convert.ToString(temp.Cells[2].Value), Convert.ToString(temp.Cells[3].Value), Convert.ToString(temp.Cells[4].Value), Convert.ToString(temp.Cells[5].Value));
					ep.ShowDialog();
					Teachers();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
				case ("Студенти"):
				{
					DataGridViewRow temp = dataGridView1.SelectedRows[0];
					var ep = new AddStudent(Convert.ToInt32(temp.Cells[0].Value), Convert.ToString(temp.Cells[1].Value), Convert.ToString(temp.Cells[2].Value), Convert.ToString(temp.Cells[3].Value), Convert.ToString(temp.Cells[4].Value));
					ep.ShowDialog();
					Students();
					sportSectionsDataSet1.AcceptChanges();
					break;
				}
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете видалити дані?", "Видалення",
						    MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						sqlconn.Open();
						SqlCommand query =
							new SqlCommand(
								"DELETE FROM [Спортивні секції] WHERE ID_викладача =" +
								dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), sqlconn);
						query.ExecuteNonQuery();
						sqlconn.Close();
						Section();
						sportSectionsDataSet1.AcceptChanges();
					}

					break;
				}
				case ("Викладачі"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете видалити дані?", "Видалення",
						    MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						sqlconn.Open();
						SqlCommand query =
							new SqlCommand(
								"DELETE FROM Викладачі WHERE ID =" +
								dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
						query.ExecuteNonQuery();
						sqlconn.Close();
						Teachers();
						sportSectionsDataSet1.AcceptChanges();
					}

					break;
				}
				case ("Студенти"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете видалити дані?", "Видалення",
						    MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						sqlconn.Open();
						SqlCommand query =
							new SqlCommand(
								"DELETE FROM Студенти WHERE ID =" +
								dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), sqlconn);
						query.ExecuteNonQuery();
						sqlconn.Close();
						Students();
						sportSectionsDataSet1.AcceptChanges();
					}

					break;
				}
			}
		}

		private void automButton_Click(object sender, EventArgs e)
		{
			SidePanel.Height = automButton.Height;
			SidePanel.Top = automButton.Top;
			var fsf = new FindSectForm();
			fsf.Show();
		}

		private void filterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					var sf = new SectionsFilter(this);
					sf.VisibleButton += ShowFilterButton;
					sf.Show();
					break;
				}
				case ("Викладачі"):
				{
					var pf = new ProfessFilter(this);
					pf.VisibleButton += ShowFilterButton;
					pf.Show();
					break;
				}
				case ("Студенти"):
				{
					var stf = new StudentsFilter(this);
					stf.VisibleButton += ShowFilterButton;
					stf.Show();
					break;
				}
			}
		}

		private void deletefilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (label1.Text)
			{
				case ("Спортивні секції"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете відмінити фільтрацію?", "Фільтр", MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Спортивні секції]", sqlconn);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						dataGridView1.DataSource = dt;
						IsButton = !IsButton;
						deletefilterToolStripMenuItem.Visible = IsButton;
					}

					break;
				}
				case ("Викладачі"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете відмінити фільтрацію?", "Фільтр", MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Викладачі", sqlconn);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						dataGridView1.DataSource = dt;
						IsButton = !IsButton;
						deletefilterToolStripMenuItem.Visible = IsButton;
					}

					break;
				}
				case ("Студенти"):
				{
					if (DialogResult.OK == MessageBox.Show("Ви справді хочете відмінити фільтрацію?", "Фільтр", MessageBoxButtons.OKCancel))
					{
						SqlConnection sqlconn = new SqlConnection(ConnectionString);
						SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Студенти", sqlconn);
						DataTable dt = new DataTable();
						sda.Fill(dt);
						dataGridView1.DataSource = dt;
						IsButton = !IsButton;
						deletefilterToolStripMenuItem.Visible = IsButton;
					}

					break;
				}
			}
		}

		private void uploadDataButton_Click(object sender, EventArgs e)
		{
			SidePanel.Height = uploadDataButton.Height;
			SidePanel.Top = uploadDataButton.Top;
			switch (label1.Text)
			{
				case ("Спортивні секції"):
					{
						OpenFileDialog od = new OpenFileDialog();
						if (od.ShowDialog() != DialogResult.Cancel)
						{
							using (StreamReader sr = new StreamReader(od.FileName))
							{
								while (!sr.EndOfStream)
								{
									string[] temp = sr.ReadLine().Split();
									try
									{
										SqlConnection sqlconn = new SqlConnection(ConnectionString);
										sqlconn.Open();
										SqlCommand query = new SqlCommand(
											"INSERT INTO [Спортивні секції] ([Назва секції]) " + "VALUES (@p1)", sqlconn);

										query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = temp[0];
										query.ExecuteNonQuery();
										sqlconn.Close();
									}
									catch (Exception ex)
									{
										Console.WriteLine(ex);
									}
								}
							}
							sportSectionsDataSet.AcceptChanges();
							Section();
						}
						break;
					}
				case ("Викладачі"):
					{
						OpenFileDialog od = new OpenFileDialog();
						if (od.ShowDialog() != DialogResult.Cancel)
						{
							using (StreamReader sr = new StreamReader(od.FileName))
							{
								while (!sr.EndOfStream)
								{
									string[] temp = sr.ReadLine().Split();
									try
									{
										SqlConnection sqlconn = new SqlConnection(ConnectionString);
										sqlconn.Open();
										SqlCommand query = new SqlCommand(
											"INSERT INTO Викладачі (Прізвище, [Ім'я], [По-батькові], [Вчене звання], Досягнення) " +
											"VALUES (@Прізвище, @p1, @p2, @p3, @Досягнення)", sqlconn);

										query.Parameters.Add("@Прізвище", SqlDbType.NVarChar).Value = temp[0];
										query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = temp[1];
										query.Parameters.Add("@p2", SqlDbType.NVarChar).Value = temp[2];
										query.Parameters.Add("@p3", SqlDbType.NVarChar).Value = temp[3];
										query.Parameters.Add("@Досягнення", SqlDbType.NVarChar).Value = temp[4];
										query.ExecuteNonQuery();
										sqlconn.Close();
									}
									catch (Exception ex)
									{
										Console.WriteLine(ex);
									}
								}
							}
							sportSectionsDataSet.AcceptChanges();
							Teachers();
						}
						break;
					}
				case ("Студенти"):
					{
						OpenFileDialog od = new OpenFileDialog();
						if (od.ShowDialog() != DialogResult.Cancel)
						{
							using (StreamReader sr = new StreamReader(od.FileName))
							{
								while (!sr.EndOfStream)
								{
									string[] temp = sr.ReadLine().Split();
									try
									{
										SqlConnection sqlconn = new SqlConnection(ConnectionString);
										sqlconn.Open();
										SqlCommand query = new SqlCommand(
											"INSERT INTO Студенти (Прізвище, [Ім'я], [По-батькові], Група) " +
											"VALUES (@Прізвище, @p1, @p3, @Група)", sqlconn);

										query.Parameters.Add("@Прізвище", SqlDbType.NVarChar).Value = temp[0];
										query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = temp[1];
										query.Parameters.Add("@p3", SqlDbType.NVarChar).Value = temp[2];
										query.Parameters.Add("@Група", SqlDbType.NVarChar).Value = temp[3];
										query.ExecuteNonQuery();
										sqlconn.Close();
									}
									catch (Exception ex)
									{
										Console.WriteLine(ex);
									}
								}
							}
							sportSectionsDataSet.AcceptChanges();
							Students();
						}
						break;
					}

			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			SidePanel.Height = exitButton.Height;
			SidePanel.Top = exitButton.Top;
			Close();
		}

		private void sqlButton_Click(object sender, EventArgs e)
		{
			SidePanel.Height = sqlButton.Height;
			SidePanel.Top = sqlButton.Top;
			var quer = new QueryEdit();
			quer.Show();
		}

		private void statrepButton_Click(object sender, EventArgs e)
		{
			SidePanel.Height = statrepButton.Height;
			SidePanel.Top = statrepButton.Top;
			var statrep = new StatReportForm();
			statrep.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SidePanel.Height = button2.Height;
			SidePanel.Top = button2.Top;
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

	}
}
