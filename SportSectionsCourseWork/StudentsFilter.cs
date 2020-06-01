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
using System.Runtime.InteropServices;

namespace SportSectionsCourseWork
{
	public partial class StudentsFilter : Form
	{
		public StudentsFilter()
		{
			InitializeComponent();
		}

		private MainForm mainf;
		string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\Базы Данных\БД 2к19\SportSectionsCourseWork\SportSectionsCourseWork\SportSections.mdf;Integrated Security = True";
		public event Action<object, EventArgs> VisibleButton;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public StudentsFilter(MainForm mainf)
		{
			InitializeComponent();
			this.mainf = mainf;
		}

		private void StudentsFilter_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Студенти". При необходимости она может быть перемещена или удалена.
			this.студентиTableAdapter.Fill(this.sportSectionsDataSet.Студенти);

			string query = "SELECT DISTINCT [Група] FROM Студенти";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			this.comboBox1.DataSource = dt;
			this.comboBox1.DisplayMember = "Група";
			this.comboBox1.ValueMember = "Група";

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT *  FROM Студенти WHERE ";
				if (comboBox1.Text != "")
				{
					query += " [Група] LIKE N'" + comboBox1.Text + "' AND ";
				}
				mainf.Students();
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0, query.Length - 4), sqlconn);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				mainf.dataGridView1.DataSource = dt;
				VisibleButton.Invoke(this, EventArgs.Empty);
				Close();

			}
			catch (ArgumentOutOfRangeException t)
			{
				Console.WriteLine(t);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Ви справді хочете відмінити фільтрацію?", "Фільтр", MessageBoxButtons.OKCancel))
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Студенти", sqlconn);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				mainf.dataGridView1.DataSource = dt;
				Close();
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StudentsFilter_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
