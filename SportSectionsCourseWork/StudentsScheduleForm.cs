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
	public partial class StudentsScheduleForm : Form
	{
		public StudentsScheduleForm()
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
		private void StudentsScheduleForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Студенти". При необходимости она может быть перемещена или удалена.
			this.студентиTableAdapter.Fill(this.sportSectionsDataSet.Студенти);

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
						switch (comboBox1.Text)
						{
							case ("2345"):
							{
								SqlConnection sqlconn = new SqlConnection(ConnectionString);
								SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Розклад студента] WHERE ID_студента = '2345';", sqlconn);
								DataTable dt = new DataTable();
								sda.Fill(dt);
								dataGridView1.DataSource = dt;
								break;
							}
							case ("2356"):
							{
								SqlConnection sqlconn = new SqlConnection(ConnectionString);
								SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Розклад студента] WHERE ID_студента = '2356';", sqlconn);
								DataTable dt = new DataTable();
								sda.Fill(dt);
								dataGridView1.DataSource = dt;
								break;
							}
							case ("2367"):
							{
								SqlConnection sqlconn = new SqlConnection(ConnectionString);
								SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Розклад студента] WHERE ID_студента = '2367';", sqlconn);
								DataTable dt = new DataTable();
								sda.Fill(dt);
								dataGridView1.DataSource = dt;
								break;
							}
							case ("2598"):
							{

								SqlConnection sqlconn = new SqlConnection(ConnectionString);
								SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Розклад студента] WHERE ID_студента = '2598';", sqlconn);
								DataTable dt = new DataTable();
								sda.Fill(dt);
								dataGridView1.DataSource = dt;
								break;
							}
						}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StudentsScheduleForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
