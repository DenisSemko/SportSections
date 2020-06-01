namespace SportSectionsCourseWork
{
	partial class StudentsScheduleForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsScheduleForm));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.студентиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sportSectionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sportSectionsDataSet = new SportSectionsCourseWork.SportSectionsDataSet();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.студентиTableAdapter = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.СтудентиTableAdapter();
			this.розклад_студентаTableAdapter = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.Розклад_студентаTableAdapter();
			this.розкладСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.panel11 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.студентиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.розкладСтудентаBindingSource)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.comboBox1.DataSource = this.студентиBindingSource;
			this.comboBox1.DisplayMember = "ID";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(0, 107);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 29);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.ValueMember = "ID";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// студентиBindingSource
			// 
			this.студентиBindingSource.DataMember = "Студенти";
			this.студентиBindingSource.DataSource = this.sportSectionsDataSetBindingSource;
			// 
			// sportSectionsDataSetBindingSource
			// 
			this.sportSectionsDataSetBindingSource.DataSource = this.sportSectionsDataSet;
			this.sportSectionsDataSetBindingSource.Position = 0;
			// 
			// sportSectionsDataSet
			// 
			this.sportSectionsDataSet.DataSetName = "SportSectionsDataSet";
			this.sportSectionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridView1.Location = new System.Drawing.Point(128, 93);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(777, 353);
			this.dataGridView1.TabIndex = 1;
			// 
			// студентиTableAdapter
			// 
			this.студентиTableAdapter.ClearBeforeFill = true;
			// 
			// розклад_студентаTableAdapter
			// 
			this.розклад_студентаTableAdapter.ClearBeforeFill = true;
			// 
			// розкладСтудентаBindingSource
			// 
			this.розкладСтудентаBindingSource.DataMember = "Розклад студента";
			this.розкладСтудентаBindingSource.DataSource = this.sportSectionsDataSetBindingSource;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(2, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID студента";
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Controls.Add(this.button1);
			this.panel11.Controls.Add(this.label11);
			this.panel11.Controls.Add(this.button4);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Margin = new System.Windows.Forms.Padding(0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(938, 54);
			this.panel11.TabIndex = 53;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 54;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(882, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 38);
			this.button1.TabIndex = 36;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(366, 17);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(235, 29);
			this.label11.TabIndex = 35;
			this.label11.Text = "Розклад студента";
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(934, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(46, 38);
			this.button4.TabIndex = 12;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// StudentsScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(938, 473);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StudentsScheduleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentsScheduleForm";
			this.Load += new System.EventHandler(this.StudentsScheduleForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentsScheduleForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.студентиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.розкладСтудентаBindingSource)).EndInit();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource sportSectionsDataSetBindingSource;
		private SportSectionsDataSet sportSectionsDataSet;
		private System.Windows.Forms.BindingSource студентиBindingSource;
		private SportSectionsDataSetTableAdapters.СтудентиTableAdapter студентиTableAdapter;
		private SportSectionsDataSetTableAdapters.Розклад_студентаTableAdapter розклад_студентаTableAdapter;
		private System.Windows.Forms.BindingSource розкладСтудентаBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.DataGridView dataGridView1;
	}
}