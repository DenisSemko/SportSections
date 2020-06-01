namespace SportSectionsCourseWork
{
	partial class Розклад_секцій
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
			System.Windows.Forms.Label назва_секціїLabel;
			System.Windows.Forms.Label iD_викладачаLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Розклад_секцій));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.sportSectionsDataSet = new SportSectionsCourseWork.SportSectionsDataSet();
			this.спортивні_секціїBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.спортивні_секціїTableAdapter = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.Спортивні_секціїTableAdapter();
			this.tableAdapterManager = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.TableAdapterManager();
			this.розклад_секційTableAdapter = new SportSectionsCourseWork.SportSectionsDataSetTableAdapters.Розклад_секційTableAdapter();
			this.спортивні_секціїBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.спортивні_секціїBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.назва_секціїTextBox = new System.Windows.Forms.TextBox();
			this.iD_викладачаTextBox = new System.Windows.Forms.TextBox();
			this.розклад_секційBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.розклад_секційDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.acceptChangeButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			назва_секціїLabel = new System.Windows.Forms.Label();
			iD_викладачаLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.спортивні_секціїBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.спортивні_секціїBindingNavigator)).BeginInit();
			this.спортивні_секціїBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.розклад_секційBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.розклад_секційDataGridView)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// назва_секціїLabel
			// 
			назва_секціїLabel.AutoSize = true;
			назва_секціїLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			назва_секціїLabel.Location = new System.Drawing.Point(12, 122);
			назва_секціїLabel.Name = "назва_секціїLabel";
			назва_секціїLabel.Size = new System.Drawing.Size(119, 21);
			назва_секціїLabel.TabIndex = 1;
			назва_секціїLabel.Text = "Назва секції:";
			// 
			// iD_викладачаLabel
			// 
			iD_викладачаLabel.AutoSize = true;
			iD_викладачаLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			iD_викладачаLabel.Location = new System.Drawing.Point(3, 161);
			iD_викладачаLabel.Name = "iD_викладачаLabel";
			iD_викладачаLabel.Size = new System.Drawing.Size(128, 21);
			iD_викладачаLabel.TabIndex = 3;
			iD_викладачаLabel.Text = "ID викладача:";
			// 
			// sportSectionsDataSet
			// 
			this.sportSectionsDataSet.DataSetName = "SportSectionsDataSet";
			this.sportSectionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// спортивні_секціїBindingSource
			// 
			this.спортивні_секціїBindingSource.DataMember = "Спортивні секції";
			this.спортивні_секціїBindingSource.DataSource = this.sportSectionsDataSet;
			// 
			// спортивні_секціїTableAdapter
			// 
			this.спортивні_секціїTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = SportSectionsCourseWork.SportSectionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.Вибрана_секція_студентаTableAdapter = null;
			this.tableAdapterManager.ВикладачіTableAdapter = null;
			this.tableAdapterManager.Журнал_відвідуванняTableAdapter = null;
			this.tableAdapterManager.Місце_париTableAdapter = null;
			this.tableAdapterManager.Предмети_студентівTableAdapter = null;
			this.tableAdapterManager.Розклад_секційTableAdapter = this.розклад_секційTableAdapter;
			this.tableAdapterManager.Розклад_студентаTableAdapter = null;
			this.tableAdapterManager.Спортивні_секціїTableAdapter = this.спортивні_секціїTableAdapter;
			this.tableAdapterManager.СтудентиTableAdapter = null;
			// 
			// розклад_секційTableAdapter
			// 
			this.розклад_секційTableAdapter.ClearBeforeFill = true;
			// 
			// спортивні_секціїBindingNavigator
			// 
			this.спортивні_секціїBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.спортивні_секціїBindingNavigator.BindingSource = this.спортивні_секціїBindingSource;
			this.спортивні_секціїBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.спортивні_секціїBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.спортивні_секціїBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.спортивні_секціїBindingNavigator.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.спортивні_секціїBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.спортивні_секціїBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.спортивні_секціїBindingNavigatorSaveItem});
			this.спортивні_секціїBindingNavigator.Location = new System.Drawing.Point(224, 445);
			this.спортивні_секціїBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.спортивні_секціїBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.спортивні_секціїBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.спортивні_секціїBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.спортивні_секціїBindingNavigator.Name = "спортивні_секціїBindingNavigator";
			this.спортивні_секціїBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.спортивні_секціїBindingNavigator.Size = new System.Drawing.Size(314, 27);
			this.спортивні_секціїBindingNavigator.TabIndex = 0;
			this.спортивні_секціїBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(64, 24);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// спортивні_секціїBindingNavigatorSaveItem
			// 
			this.спортивні_секціїBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.спортивні_секціїBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("спортивні_секціїBindingNavigatorSaveItem.Image")));
			this.спортивні_секціїBindingNavigatorSaveItem.Name = "спортивні_секціїBindingNavigatorSaveItem";
			this.спортивні_секціїBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.спортивні_секціїBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.спортивні_секціїBindingNavigatorSaveItem.Click += new System.EventHandler(this.спортивні_секціїBindingNavigatorSaveItem_Click);
			// 
			// назва_секціїTextBox
			// 
			this.назва_секціїTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.назва_секціїTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.назва_секціїTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивні_секціїBindingSource, "Назва секції", true));
			this.назва_секціїTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.назва_секціїTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.назва_секціїTextBox.Location = new System.Drawing.Point(153, 122);
			this.назва_секціїTextBox.Name = "назва_секціїTextBox";
			this.назва_секціїTextBox.Size = new System.Drawing.Size(204, 23);
			this.назва_секціїTextBox.TabIndex = 2;
			// 
			// iD_викладачаTextBox
			// 
			this.iD_викладачаTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.iD_викладачаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.iD_викладачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивні_секціїBindingSource, "ID_викладача", true));
			this.iD_викладачаTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iD_викладачаTextBox.Location = new System.Drawing.Point(153, 162);
			this.iD_викладачаTextBox.Name = "iD_викладачаTextBox";
			this.iD_викладачаTextBox.Size = new System.Drawing.Size(204, 23);
			this.iD_викладачаTextBox.TabIndex = 4;
			// 
			// розклад_секційBindingSource
			// 
			this.розклад_секційBindingSource.DataMember = "FK_Розклад секцій_ToTable_1";
			this.розклад_секційBindingSource.DataSource = this.спортивні_секціїBindingSource;
			// 
			// розклад_секційDataGridView
			// 
			this.розклад_секційDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.розклад_секційDataGridView.AutoGenerateColumns = false;
			this.розклад_секційDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.розклад_секційDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.розклад_секційDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.розклад_секційDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.розклад_секційDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.розклад_секційDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.розклад_секційDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.розклад_секційDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.розклад_секційDataGridView.DataSource = this.розклад_секційBindingSource;
			this.розклад_секційDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.розклад_секційDataGridView.Location = new System.Drawing.Point(66, 222);
			this.розклад_секційDataGridView.Name = "розклад_секційDataGridView";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
			this.розклад_секційDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.розклад_секційDataGridView.RowTemplate.Height = 24;
			this.розклад_секційDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.розклад_секційDataGridView.Size = new System.Drawing.Size(636, 220);
			this.розклад_секційDataGridView.TabIndex = 5;
			this.розклад_секційDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.розклад_секційDataGridView_CellMouseDoubleClick);
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "День тижня";
			this.dataGridViewTextBoxColumn2.HeaderText = "День тижня";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 127;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Початок пари";
			this.dataGridViewTextBoxColumn3.HeaderText = "Початок пари";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 149;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Кінець пари";
			this.dataGridViewTextBoxColumn4.HeaderText = "Кінець пари";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 133;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Місце проведення";
			this.dataGridViewTextBoxColumn5.HeaderText = "Місце проведення";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 185;
			// 
			// acceptChangeButton
			// 
			this.acceptChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.acceptChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.acceptChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.acceptChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptChangeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.acceptChangeButton.Location = new System.Drawing.Point(584, 116);
			this.acceptChangeButton.Name = "acceptChangeButton";
			this.acceptChangeButton.Size = new System.Drawing.Size(160, 69);
			this.acceptChangeButton.TabIndex = 6;
			this.acceptChangeButton.Text = "Підтвердити зміни";
			this.acceptChangeButton.UseVisualStyleBackColor = true;
			this.acceptChangeButton.Visible = false;
			this.acceptChangeButton.Click += new System.EventHandler(this.acceptChangeButton_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel3.Location = new System.Drawing.Point(153, 141);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(204, 4);
			this.panel3.TabIndex = 54;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Location = new System.Drawing.Point(153, 181);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 4);
			this.panel1.TabIndex = 55;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Controls.Add(this.label11);
			this.panel11.Controls.Add(this.button3);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Margin = new System.Windows.Forms.Padding(0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(773, 49);
			this.panel11.TabIndex = 56;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(288, 8);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(204, 29);
			this.label11.TabIndex = 36;
			this.label11.Text = "Розклад секцій";
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(715, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 38);
			this.button3.TabIndex = 11;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(53, 49);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 57;
			this.pictureBox1.TabStop = false;
			// 
			// Розклад_секцій
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(773, 496);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.acceptChangeButton);
			this.Controls.Add(this.розклад_секційDataGridView);
			this.Controls.Add(назва_секціїLabel);
			this.Controls.Add(this.назва_секціїTextBox);
			this.Controls.Add(iD_викладачаLabel);
			this.Controls.Add(this.iD_викладачаTextBox);
			this.Controls.Add(this.спортивні_секціїBindingNavigator);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Розклад_секцій";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SectionsSchedule";
			this.Load += new System.EventHandler(this.Розклад_секцій_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Розклад_секцій_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.sportSectionsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.спортивні_секціїBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.спортивні_секціїBindingNavigator)).EndInit();
			this.спортивні_секціїBindingNavigator.ResumeLayout(false);
			this.спортивні_секціїBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.розклад_секційBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.розклад_секційDataGridView)).EndInit();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SportSectionsDataSet sportSectionsDataSet;
		private System.Windows.Forms.BindingSource спортивні_секціїBindingSource;
		private SportSectionsDataSetTableAdapters.Спортивні_секціїTableAdapter спортивні_секціїTableAdapter;
		private SportSectionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator спортивні_секціїBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton спортивні_секціїBindingNavigatorSaveItem;
		private SportSectionsDataSetTableAdapters.Розклад_секційTableAdapter розклад_секційTableAdapter;
		private System.Windows.Forms.TextBox назва_секціїTextBox;
		private System.Windows.Forms.TextBox iD_викладачаTextBox;
		private System.Windows.Forms.BindingSource розклад_секційBindingSource;
		private System.Windows.Forms.DataGridView розклад_секційDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button acceptChangeButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}