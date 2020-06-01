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
using SportSectionsCourseWork.SportSectionsDataSetTableAdapters;
using System.Runtime.InteropServices;


namespace SportSectionsCourseWork
{
	public partial class AddSections : Form
	{
		int id;
	    bool edit;

		string ConnectionString =
			@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Мои работы и т.д\Всё\2 курс\Базы Данных\БД 2к19\SportSectionsCourseWork\SportSectionsCourseWork\SportSections.mdf;Integrated Security = True";
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		public AddSections()
		{
			InitializeComponent();
			edit = false;
		}

		public AddSections(string name, int id)
		{
			InitializeComponent();
			textBoxName.Text = name;
			this.id = id;
			edit = true;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			
			if (!edit && textBoxName.Text.Trim() != "")
			{
				
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					sqlconn.Open();
					SqlCommand query = new SqlCommand("Insert Into [Спортивні секції]([Назва секції]) " + "Values(@p1)", sqlconn);
					query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = textBoxName.Text;
					query.ExecuteNonQuery();
					sqlconn.Close();
					this.Close();
				
			} else if (edit && textBoxName.Text.Trim() != "")
			{
				
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					sqlconn.Open();
					string quer = String.Format("Update [Спортивні секції] Set [Назва секції] = N'{0}' WHERE ID_викладача = '{1}' ",
						textBoxName.Text, id.ToString());
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

		private void AddSections_Load(object sender, EventArgs e)
		{


		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddSections_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			textBoxName.MaxLength = 40;
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			textBoxName.Text = textBoxName.Text.Replace("  ", " ");
		}
	}
}
