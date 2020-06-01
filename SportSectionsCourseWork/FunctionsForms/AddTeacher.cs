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

namespace SportSectionsCourseWork.FunctionsForms
{
	public partial class AddTeacher : Form
	{
		int id;
		bool edit;
		public AddTeacher()
		{
			InitializeComponent();
			edit = false;
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

		public AddTeacher(int id, string surname, string name, string fathname, string science, string achievement)
		{
			InitializeComponent();
			textBox1.Text = surname;
			textBox2.Text = name;
			textBox3.Text = fathname;
			comboBox1.SelectedValue = science;
			textBox4.Text = achievement;
			this.id = id;
			edit = true;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (!edit && textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
			{

				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlCommand query = new SqlCommand("INSERT INTO Викладачі(Прізвище, [Ім'я], [По-батькові], [Вчене звання], Досягнення) " + "Values(@Прізвище, @p1, @p2, @p3, @Досягнення)", sqlconn);
				query.Parameters.Add("@Прізвище", SqlDbType.NVarChar).Value = textBox1.Text;
				query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = textBox2.Text;
				query.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox3.Text;
				query.Parameters.Add("@p3", SqlDbType.NVarChar).Value = comboBox1.Text;
				query.Parameters.Add("@Досягнення", SqlDbType.NVarChar).Value = textBox4.Text;
				query.ExecuteNonQuery();
				sqlconn.Close();
				this.Close();

			}
			else if (edit && textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
			{

				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				string quer = String.Format("UPDATE Викладачі Set [Прізвище] = N'{1}', [Ім'я] = N'{2}', [По-батькові] = N'{3}', [Вчене звання] = N'{4}', [Досягнення] = N'{5}' WHERE ID = '{0}' ", id.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
				SqlCommand query = new SqlCommand(quer, sqlconn);
				query.ExecuteNonQuery();
				sqlconn.Close();
				this.Close();

			}
			else MessageBox.Show("Перевірте дані", "", MessageBoxButtons.OK);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Ви справді хочете вийти?", "Вийти", MessageBoxButtons.OKCancel))
			{
				Close();
			}
		}

		private void AddTeacher_Load(object sender, EventArgs e)
		{
			string query = "SELECT DISTINCT [Вчене звання] FROM Викладачі";
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			SqlDataAdapter sda = new SqlDataAdapter(query.Substring(0), sqlconn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			this.comboBox1.DataSource = dt;
			this.comboBox1.DisplayMember = "Вчене звання";
			this.comboBox1.ValueMember = "Вчене звання";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddTeacher_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text.Replace("  ", " ");
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			textBox1.MaxLength = 40;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text.Replace("  ", " ");
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			textBox2.MaxLength = 40;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text.Replace("  ", " ");
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			textBox3.MaxLength = 40;
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			textBox4.Text = textBox4.Text.Replace("  ", " ");
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar) && (e.KeyChar != 45) && (e.KeyChar != 58))
			{
				e.Handled = true;
			}

			textBox4.MaxLength = 40;
		}
	}
}
