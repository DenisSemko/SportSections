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
using System.Runtime.InteropServices;

namespace SportSectionsCourseWork
{
	public partial class StatReportForm : Form
	{
		public StatReportForm()
		{
			InitializeComponent();
		}
		string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\Базы Данных\БД 2к19\SportSectionsCourseWork\SportSectionsCourseWork\SportSections.mdf;Integrated Security = True";
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		// Звіти:
		private void button1_Click(object sender, EventArgs e)
		{
			label3.Text = button1.Text;
			string query = "SELECT ID AS [Номер перепустки], Прізвище, [Ім'я], [По-батькові], Досягнення AS [Спортивне звання] FROM Викладачі";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			label3.Text = button2.Text;
			string query = "SELECT [Назва секції], [День тижня] AS [День проведення], [Початок пари] AS [Початок змагання], [Кінець пари] AS [Кінець змагання], [Місце проведення] FROM [Розклад секцій]";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		//Статистика
		private void button3_Click(object sender, EventArgs e)
		{
			label3.Text = button3.Text;
			string query = "SELECT DISTINCT [День тижня], COUNT([День тижня]) AS [Кількість проведених занять] FROM [Розклад секцій] GROUP BY [День тижня]";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt); 
			dataGridView1.DataSource = dt;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label3.Text = button5.Text;
			string query = "SELECT DISTINCT dbo.[Спортивні секції].[Назва секції], dbo.[Розклад секцій].[Місце проведення], COUNT(dbo.[Розклад секцій].[Назва секції]) AS [Використання секцією приміщення за тиждень] FROM dbo.[Спортивні секції], dbo.[Розклад секцій] WHERE dbo.[Спортивні секції].[Назва секції] = dbo.[Розклад секцій].[Назва секції] GROUP BY dbo.[Спортивні секції].[Назва секції], dbo.[Розклад секцій].[Місце проведення];";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label3.Text = button4.Text;
			string query = "SELECT dbo.[Спортивні секції].ID_викладача, dbo.Викладачі.Прізвище, dbo.Викладачі.[Ім'я], dbo.Викладачі.[По-батькові], COUNT(dbo.[Розклад секцій].[Назва секції]) * 2 AS [Кількість робочих годин] FROM dbo.[Спортивні секції], dbo.[Викладачі], dbo.[Розклад секцій] WHERE dbo.[Викладачі].ID = dbo.[Спортивні секції].ID_викладача AND dbo.[Спортивні секції].[Назва секції] = dbo.[Розклад секцій].[Назва секції] GROUP BY dbo.[Спортивні секції].ID_викладача, dbo.Викладачі.Прізвище, dbo.Викладачі.[Ім'я], dbo.Викладачі.[По-батькові];";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label3.Text = button6.Text;
			string query = "SELECT ID_студента, [Початок пари] AS [Час пари], COUNT([Назва предмету]) AS [Кількість пар на тиждень в такий проміжок часу] FROM [Розклад студента] GROUP BY ID_студента, [Початок пари] ORDER BY ID_студента;";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		//Друк
		private void button7_Click(object sender, EventArgs e)
		{
			switch (label3.Text)
			{
				case ("Перепустка викладача"):
				{
					DataTable dt = (DataTable) dataGridView1.DataSource;
					DateTime date = DateTime.Now;

					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\report1.txt", false))
					{
//						x.WriteLine(label3.Text);
//						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("			Харьківський національний університет радіоелектроніки");
							x.WriteLine("					Перепустка викладача:");
							x.WriteLine("Номер перепустки: " + y[0].ToString());
							x.WriteLine("Прізвище: " + y[1].ToString());
							x.WriteLine("Ім'я: " + y[2].ToString());
							x.WriteLine("По-батькові: " + y[3].ToString());
							x.WriteLine("Спортивне звання: " + y[4].ToString());
							x.WriteLine("-----------------------------------------------------------------------------------------------------------");
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\report1.txt");
					break;
				}
				case ("Розклад змагань"):
				{
					DataTable dt = (DataTable)dataGridView1.DataSource;
					DateTime date = DateTime.Now;
					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\report2.txt", false))
					{
//						x.WriteLine(label3.Text);
//						x.WriteLine();
						x.WriteLine("		Розклад змагань серед студентів Харьківского національного університету радіоелектроніки ");
						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("Назва секції: " + y[0].ToString());
							x.WriteLine("День проведення: " + y[1].ToString());
							x.WriteLine("Початок змагання: " + y[2].ToString());
							x.WriteLine("Кінець змагання: " + y[3].ToString());
							x.WriteLine("Місце проведення: " + y[4].ToString());
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\report2.txt");
					break;
				}
				case ("Кількість днів проведення секції"):
				{
					DataTable dt = (DataTable)dataGridView1.DataSource;
					DateTime date = DateTime.Now;
					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\stat1.txt", false))
					{
						x.WriteLine(label3.Text);
						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("День тижня: " + y[0].ToString());
							x.WriteLine("Кількість проведених занять: " + y[1].ToString());
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\stat1.txt");
					break;
				}
				case ("Кількість робочих годин кожного викладача"):
				{
					DataTable dt = (DataTable)dataGridView1.DataSource;
					DateTime date = DateTime.Now;
					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\stat2.txt", false))
					{
						x.WriteLine(label3.Text);
						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("ID: " + y[0].ToString());
							x.WriteLine("Прізвище: " + y[1].ToString());
							x.WriteLine("Ім'я: " + y[2].ToString());
							x.WriteLine("По-батькові: " + y[3].ToString());
							x.WriteLine("Кількість робочих годин: " + y[4].ToString());
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\stat2.txt");
					break;
				}
				case ("Кількість використання секцією приміщення за тиждень"):
				{
					DataTable dt = (DataTable)dataGridView1.DataSource;
					DateTime date = DateTime.Now;
					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\stat3.txt", false))
					{
						x.WriteLine(label3.Text);
						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("Назва секції: " + y[0].ToString());
							x.WriteLine("Місце проведення: " + y[1].ToString());
							x.WriteLine("Використання секцією приміщення за тиждень: " + y[2].ToString());
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\stat3.txt");
					break;
				}
				case ("Кількість пар на тиждень в певний час"):
				{
					DataTable dt = (DataTable)dataGridView1.DataSource;
					DateTime date = DateTime.Now;
					using (StreamWriter x = new StreamWriter(Directory.GetCurrentDirectory() + @"\stat4.txt", false))
					{
						x.WriteLine(label3.Text);
						x.WriteLine();
						foreach (DataRow y in dt.Rows)
						{
							x.WriteLine("ID_студента: " + y[0].ToString());
							x.WriteLine("Час пари: " + y[1].ToString());
							x.WriteLine("Кількість пар на тиждень: " + y[2].ToString());
							x.WriteLine();
						}
						x.WriteLine("Дата формування: " + date);
					}

					System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\stat4.txt");
					break;
				}
			}
		}

		private void StatReportForm_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoGenerateColumns = true;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StatReportForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
