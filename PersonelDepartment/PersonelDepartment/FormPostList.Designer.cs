namespace PersonelDepartment
{
    partial class FormPostList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostList));
            this.personnel_departmentDataSet = new PersonelDepartment.Personnel_departmentDataSet();
            this.dolgnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolgnostTableAdapter = new PersonelDepartment.Personnel_departmentDataSetTableAdapters.DolgnostTableAdapter();
            this.tableAdapterManager = new PersonelDepartment.Personnel_departmentDataSetTableAdapters.TableAdapterManager();
            this.dolgnostBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dolgnostDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnOtdel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.dolgnostBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingNavigator)).BeginInit();
            this.dolgnostBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personnel_departmentDataSet
            // 
            this.personnel_departmentDataSet.DataSetName = "Personnel_departmentDataSet";
            this.personnel_departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolgnostBindingSource
            // 
            this.dolgnostBindingSource.DataMember = "Dolgnost";
            this.dolgnostBindingSource.DataSource = this.personnel_departmentDataSet;
            // 
            // dolgnostTableAdapter
            // 
            this.dolgnostTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cvedenia_dlya_rascheta_zarplatyTableAdapter = null;
            this.tableAdapterManager.DolgnostTableAdapter = this.dolgnostTableAdapter;
            this.tableAdapterManager.Grafik_rabotyTableAdapter = null;
            this.tableAdapterManager.RekvizityTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.Tabel_uchota_rabochego_vremeniTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonelDepartment.Personnel_departmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dolgnostBindingNavigator
            // 
            this.dolgnostBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dolgnostBindingNavigator.BindingSource = this.dolgnostBindingSource;
            this.dolgnostBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dolgnostBindingNavigator.CountItemFormat = "из {0}";
            this.dolgnostBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dolgnostBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dolgnostBindingNavigatorSaveItem});
            this.dolgnostBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dolgnostBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dolgnostBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dolgnostBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dolgnostBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dolgnostBindingNavigator.Name = "dolgnostBindingNavigator";
            this.dolgnostBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dolgnostBindingNavigator.Size = new System.Drawing.Size(429, 25);
            this.dolgnostBindingNavigator.TabIndex = 0;
            this.dolgnostBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dolgnostDataGridView
            // 
            this.dolgnostDataGridView.AutoGenerateColumns = false;
            this.dolgnostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dolgnostDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumnOtdel});
            this.dolgnostDataGridView.DataSource = this.dolgnostBindingSource;
            this.dolgnostDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dolgnostDataGridView.Location = new System.Drawing.Point(0, 25);
            this.dolgnostDataGridView.Name = "dolgnostDataGridView";
            this.dolgnostDataGridView.Size = new System.Drawing.Size(429, 280);
            this.dolgnostDataGridView.TabIndex = 1;
            this.dolgnostDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dolgnostDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Trud_dogovor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Trud_dogovor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazvanie_dolgnosti";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazvanie_dolgnosti";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumnOtdel
            // 
            this.dataGridViewTextBoxColumnOtdel.DataPropertyName = "Struct_podrazdelenie";
            this.dataGridViewTextBoxColumnOtdel.HeaderText = "Struct_podrazdelenie";
            this.dataGridViewTextBoxColumnOtdel.Items.AddRange(new object[] {
            "Отдел кадров",
            "Администрация",
            "Экономический отдел",
            "Хозяйственный отдел",
            "Учебный отдел"});
            this.dataGridViewTextBoxColumnOtdel.Name = "dataGridViewTextBoxColumnOtdel";
            this.dataGridViewTextBoxColumnOtdel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumnOtdel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // dolgnostBindingNavigatorSaveItem
            // 
            this.dolgnostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dolgnostBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dolgnostBindingNavigatorSaveItem.Image")));
            this.dolgnostBindingNavigatorSaveItem.Name = "dolgnostBindingNavigatorSaveItem";
            this.dolgnostBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dolgnostBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dolgnostBindingNavigatorSaveItem.Click += new System.EventHandler(this.dolgnostBindingNavigatorSaveItem_Click_1);
            // 
            // FormPostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 305);
            this.Controls.Add(this.dolgnostDataGridView);
            this.Controls.Add(this.dolgnostBindingNavigator);
            this.Name = "FormPostList";
            this.Text = "List of posts";
            this.Load += new System.EventHandler(this.FormPostList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnel_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingNavigator)).EndInit();
            this.dolgnostBindingNavigator.ResumeLayout(false);
            this.dolgnostBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnel_departmentDataSet personnel_departmentDataSet;
        private System.Windows.Forms.BindingSource dolgnostBindingSource;
        private Personnel_departmentDataSetTableAdapters.DolgnostTableAdapter dolgnostTableAdapter;
        private Personnel_departmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dolgnostBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dolgnostBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dolgnostDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumnOtdel;

    }
}