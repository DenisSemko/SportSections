using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SportSectionsCourseWork
{
	public partial class Розклад_секцій : Form
	{
		public Розклад_секцій()
		{
			InitializeComponent();
		}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
			int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void розклад_секційBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.розклад_секційBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.sportSectionsDataSet);

		}

		private void спортивні_секціїBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.спортивні_секціїBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.sportSectionsDataSet);

		}

		private void Розклад_секцій_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Розклад_секцій". При необходимости она может быть перемещена или удалена.
			this.розклад_секційTableAdapter.Fill(this.sportSectionsDataSet.Розклад_секцій);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "sportSectionsDataSet.Спортивні_секції". При необходимости она может быть перемещена или удалена.
			this.спортивні_секціїTableAdapter.Fill(this.sportSectionsDataSet.Спортивні_секції);

		}

		private void acceptChangeButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви дійсно хочете внести зміни?", "Зміна даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				розклад_секційTableAdapter.Update(sportSectionsDataSet);
			}
		}

		private void розклад_секційDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			acceptChangeButton.Visible = true;
		}

		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{
			acceptChangeButton.Visible = false;
		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{
			acceptChangeButton.Visible = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Розклад_секцій_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
