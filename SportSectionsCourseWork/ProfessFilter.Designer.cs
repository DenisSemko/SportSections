namespace SportSectionsCourseWork
{
	partial class ProfessFilter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessFilter));
			this.викладачіBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sportSectionsDataSet = new SportSectionsCourseWork.SportSectionsDataSet();
			this.sportSectionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.викладачіTableAdapter = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.ВикладачіTableAdapter();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.викладачіBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.panel11 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.викладачіBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.викладачіBindingSource1)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// викладачіBindingSource
			// 
			this.викладачіBindingSource.DataMember = "Викладачі";
			this.викладачіBindingSource.DataSource = this.sportSectionsDataSet;
			// 
			// sportSectionsDataSet
			// 
			this.sportSectionsDataSet.DataSetName = "SportSectionsDataSet";
			this.sportSectionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sportSectionsDataSetBindingSource
			// 
			this.sportSectionsDataSetBindingSource.DataSource = this.sportSectionsDataSet;
			this.sportSectionsDataSetBindingSource.Position = 0;
			// 
			// викладачіTableAdapter
			// 
			this.викладачіTableAdapter.ClearBeforeFill = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(135, 204);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(139, 22);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(413, 208);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 22);
			this.textBox2.TabIndex = 2;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(224, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Досягнення викладачів";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(72, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Від:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(333, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "До:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(224, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(205, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Діапазон ID викладачів";
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(251, 258);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(163, 37);
			this.button1.TabIndex = 7;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(241, 115);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(163, 24);
			this.comboBox1.TabIndex = 9;
			// 
			// викладачіBindingSource1
			// 
			this.викладачіBindingSource1.DataMember = "Викладачі";
			this.викладачіBindingSource1.DataSource = this.sportSectionsDataSetBindingSource;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Controls.Add(this.button3);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Margin = new System.Windows.Forms.Padding(0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(696, 48);
			this.panel11.TabIndex = 52;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 56;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(638, 7);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 38);
			this.button3.TabIndex = 11;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel3.Location = new System.Drawing.Point(222, 100);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(204, 4);
			this.panel3.TabIndex = 54;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Location = new System.Drawing.Point(222, 181);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 4);
			this.panel1.TabIndex = 55;
			// 
			// ProfessFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(696, 311);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProfessFilter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProfessFilter";
			this.Load += new System.EventHandler(this.ProfessFilter_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfessFilter_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.викладачіBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.викладачіBindingSource1)).EndInit();
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource sportSectionsDataSetBindingSource;
		private SportSectionsDataSet sportSectionsDataSet;
		private System.Windows.Forms.BindingSource викладачіBindingSource;
		private SportSectionsDataSetTableAdapters.ВикладачіTableAdapter викладачіTableAdapter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource викладачіBindingSource1;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}