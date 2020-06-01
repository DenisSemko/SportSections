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
	public partial class ProfessFilter : Form
	{
		public ProfessFilter()
		{
			InitializeComponent();
		}

		public ProfessFilter(MainForm mainf)
		{
			InitializeComponent();
			this.mainf = mainf;
		}
		private MainForm mainf;
		public event Action<object, EventArgs> VisibleButton;

		string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\Базы Данных\БД 2к19\SportSectionsCourseWork\SportSectionsCourseWork\SportSections.mdf;Integrated Security = True";
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		private void ProfessFilter_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Викладачі". При необходимости она может быть перемещена или удалена.
			this.викладачіTableAdapter.Fill(this.sportSectionsDataSet.Викладачі);
//
			string query = "SELECT DISTINCT [Досягнення] FROM Викладачі";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			this.comboBox1.DataSource = dt;
			this.comboBox1.DisplayMember = "Досягнення";
			this.comboBox1.ValueMember = "Досягнення";
		}


		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT *  FROM Викладачі WHERE ";
				int v = 0;
				if (comboBox1.Text != "")
				{
					query += " [Досягнення] LIKE N'" + comboBox1.Text + "' AND ";
				}

				if (Int32.TryParse(textBox1.Text, out v))
				{
					query += " ID >=" + textBox1.Text + " AND ";
				}

				if (Int32.TryParse(textBox2.Text, out v))
					query += " ID <=" + textBox2.Text + " AND ";
				mainf.Teachers();
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


		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ProfessFilter_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

			textBox1.MaxLength = 10;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

			textBox2.MaxLength = 10;
		}
	}
}
