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
	public partial class SectionsFilter : Form
	{
		public SectionsFilter()
		{
			InitializeComponent();
		}

		MainForm mainf;

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

		public SectionsFilter(MainForm mainf)
		{
			InitializeComponent();
			this.mainf = mainf;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT * FROM [Спортивні секції] WHERE ";
				int f = 0;
				if (Int32.TryParse(textBox1.Text, out f))
				{
					query += " ID_викладача >=" + textBox1.Text + " AND ";
				}

				if (Int32.TryParse(textBox2.Text, out f))
				{
					query += " ID_викладача <=" + textBox2.Text + " AND ";
				}

				mainf.Section();
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0, query.Length - 4), sqlconn);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				mainf.dataGridView1.DataSource = dt;
				VisibleButton.Invoke(this, EventArgs.Empty);
				Close();
			}
			catch (ArgumentOutOfRangeException f)
			{
				Console.WriteLine(f);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Ви справді хочете відмінити фільтрацію?", "Фільтр", MessageBoxButtons.OKCancel))
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Спортивні секції]", sqlconn);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				mainf.dataGridView1.DataSource = dt;
				Close();
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SectionsFilter_MouseDown(object sender, MouseEventArgs e)
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
	}
}
