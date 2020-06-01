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
	public partial class FindSectForm : Form
	{
		public FindSectForm()
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

		private void FindSectForm_Load(object sender, EventArgs e)
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
					SqlDataAdapter sda = new SqlDataAdapter("SELECT RS.* FROM [Розклад секцій] AS RS INNER JOIN[Вибрана секція студента] AS VSS ON VSS.[Назва секції] = RS.[Назва секції] INNER JOIN Студенти AS Ss	ON Ss.ID = VSS.ID_студента INNER JOIN[Розклад студента] AS RSs ON RSs.ID_студента = Ss.ID WHERE RS.[День тижня] = RSs.[День тижня] AND RSs.[Назва предмету] IS NULL AND RS.[Початок пари] = RSs.[Початок пари] AND Ss.ID = '2345'; ", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					button2.Visible = false;
					break;
				}
				case ("2356"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT RS.* FROM [Розклад секцій] AS RS INNER JOIN[Вибрана секція студента] AS VSS ON VSS.[Назва секції] = RS.[Назва секції] INNER JOIN Студенти AS Ss	ON Ss.ID = VSS.ID_студента INNER JOIN[Розклад студента] AS RSs ON RSs.ID_студента = Ss.ID WHERE RS.[День тижня] = RSs.[День тижня] AND RSs.[Назва предмету] IS NULL AND RS.[Початок пари] = RSs.[Початок пари] AND Ss.ID = '2356'; ", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					button2.Visible = false;
					break;
				}
				case ("2367"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT RS.* FROM [Розклад секцій] AS RS INNER JOIN[Вибрана секція студента] AS VSS ON VSS.[Назва секції] = RS.[Назва секції] INNER JOIN Студенти AS Ss	ON Ss.ID = VSS.ID_студента INNER JOIN[Розклад студента] AS RSs ON RSs.ID_студента = Ss.ID WHERE RS.[День тижня] = RSs.[День тижня] AND RSs.[Назва предмету] IS NULL AND RS.[Початок пари] = RSs.[Початок пари] AND Ss.ID = '2367'; ", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					button2.Visible = false;
					break;
				}
				case ("2598"):
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					SqlDataAdapter sda = new SqlDataAdapter("SELECT RS.* FROM [Розклад секцій] AS RS INNER JOIN[Вибрана секція студента] AS VSS ON VSS.[Назва секції] = RS.[Назва секції] INNER JOIN Студенти AS Ss	ON Ss.ID = VSS.ID_студента INNER JOIN[Розклад студента] AS RSs ON RSs.ID_студента = Ss.ID WHERE RS.[День тижня] = RSs.[День тижня] AND RSs.[Назва предмету] IS NULL AND RS.[Початок пари] = RSs.[Початок пари] AND Ss.ID = '2598'; ", sqlconn);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					dataGridView1.DataSource = dt;
					button2.Visible = false;
					break;

					}
			}
		}

//		public object Rand()
//		{
//			Random r = new Random();
//			int n = r.Next(0, 17);
//			return n;
//		}
		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection sqlconn = new SqlConnection(ConnectionString);
			sqlconn.Open();
			SqlCommand query = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Вересень";
			query.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query.ExecuteNonQuery();
			SqlCommand query1 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query1.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query1.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query1.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Жовтень";
			query1.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query1.ExecuteNonQuery();
			SqlCommand query2 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query2.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query2.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query2.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Листопад";
			query2.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query2.ExecuteNonQuery();
			SqlCommand query3 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query3.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query3.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query3.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Грудень";
			query3.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query3.ExecuteNonQuery();
			SqlCommand query4 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query4.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query4.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query4.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Березень";
			query4.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query4.ExecuteNonQuery();
			SqlCommand query5 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query5.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query5.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query5.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Квітень";
			query5.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query5.ExecuteNonQuery();
			SqlCommand query6 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query6.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query6.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query6.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Травень";
			query6.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query6.ExecuteNonQuery();
			SqlCommand query7 = new SqlCommand(" INSERT INTO [Журнал відвідування]([ID_студента], [Назва секції], Місяць, [Кількість разів])" + "VALUES(@p1, @p2, @Місяць, @p4)", sqlconn);
			query7.Parameters.Add("@p1", SqlDbType.NVarChar).Value = comboBox1.Text;
			query7.Parameters.Add("@p2", SqlDbType.NVarChar).Value = textBox1.Text;
			query7.Parameters.Add("@Місяць", SqlDbType.NVarChar).Value = "Червень";
			query7.Parameters.Add("@p4", SqlDbType.NVarChar).Value = 0;
			query7.ExecuteNonQuery();
			sqlconn.Close();
			MessageBox.Show("Ви вибрали секцію: " + textBox1.Text.ToLower() + "\nВи маєте змогу переглянути журнал відвідування");
			button2.Visible = true;
			textBox1.Clear();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var aj = new AttendanceJournal();
			aj.Show();
		}

		public string Section;
		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Section = dataGridView1.SelectedCells[0].Value.ToString();
			textBox1.Text = Section;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FindSectForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
