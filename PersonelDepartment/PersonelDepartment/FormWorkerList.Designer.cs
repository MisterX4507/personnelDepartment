namespace PersonelDepartment
{
    partial class FormWorkerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkerList));
            System.Windows.Forms.Label code_sotrudnikaLabel;
            System.Windows.Forms.Label familiyaLabel;
            System.Windows.Forms.Label imyaLabel;
            System.Windows.Forms.Label otchestvoLabel;
            System.Windows.Forms.Label seriya_pasportaLabel;
            System.Windows.Forms.Label nomer_pasportaLabel;
            System.Windows.Forms.Label kvalifikaciyaLabel;
            System.Windows.Forms.Label sNILSLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label stagLabel;
            System.Windows.Forms.Label voennoobyathannostLabel;
            System.Windows.Forms.Label photoLabel;
            this.personnel_departmentDataSet = new PersonelDepartment.Personnel_departmentDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new PersonelDepartment.Personnel_departmentDataSetTableAdapters.SotrudnikTableAdapter();
            this.tableAdapterManager = new PersonelDepartment.Personnel_departmentDataSetTableAdapters.TableAdapterManager();
            this.sotrudnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sotrudnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.code_sotrudnikaTextBox = new System.Windows.Forms.TextBox();
            this.familiyaTextBox = new System.Windows.Forms.TextBox();
            this.imyaTextBox = new System.Windows.Forms.TextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.seriya_pasportaTextBox = new System.Windows.Forms.TextBox();
            this.nomer_pasportaTextBox = new System.Windows.Forms.TextBox();
            this.kvalifikaciyaTextBox = new System.Windows.Forms.TextBox();
            this.sNILSTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.stagTextBox = new System.Windows.Forms.TextBox();
            this.voennoobyathannostTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            code_sotrudnikaLabel = new System.Windows.Forms.Label();
            familiyaLabel = new System.Windows.Forms.Label();
            imyaLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            seriya_pasportaLabel = new System.Windows.Forms.Label();
            nomer_pasportaLabel = new System.Windows.Forms.Label();
            kvalifikaciyaLabel = new System.Windows.Forms.Label();
            sNILSLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            stagLabel = new System.Windows.Forms.Label();
            voennoobyathannostLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingNavigator)).BeginInit();
            this.sotrudnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // personnel_departmentDataSet
            // 
            this.personnel_departmentDataSet.DataSetName = "Personnel_departmentDataSet";
            this.personnel_departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.personnel_departmentDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cvedenia_dlya_rascheta_zarplatyTableAdapter = null;
            this.tableAdapterManager.DolgnostTableAdapter = null;
            this.tableAdapterManager.Grafik_rabotyTableAdapter = null;
            this.tableAdapterManager.RekvizityTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = this.sotrudnikTableAdapter;
            this.tableAdapterManager.Tabel_uchota_rabochego_vremeniTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonelDepartment.Personnel_departmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sotrudnikBindingNavigator
            // 
            this.sotrudnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sotrudnikBindingNavigator.BindingSource = this.sotrudnikBindingSource;
            this.sotrudnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sotrudnikBindingNavigator.CountItemFormat = "из {0}";
            this.sotrudnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sotrudnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sotrudnikBindingNavigatorSaveItem});
            this.sotrudnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sotrudnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sotrudnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sotrudnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sotrudnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sotrudnikBindingNavigator.Name = "sotrudnikBindingNavigator";
            this.sotrudnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sotrudnikBindingNavigator.Size = new System.Drawing.Size(513, 25);
            this.sotrudnikBindingNavigator.TabIndex = 0;
            this.sotrudnikBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // sotrudnikBindingNavigatorSaveItem
            // 
            this.sotrudnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sotrudnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sotrudnikBindingNavigatorSaveItem.Image")));
            this.sotrudnikBindingNavigatorSaveItem.Name = "sotrudnikBindingNavigatorSaveItem";
            this.sotrudnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sotrudnikBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sotrudnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.sotrudnikBindingNavigatorSaveItem_Click_1);
            // 
            // code_sotrudnikaLabel
            // 
            code_sotrudnikaLabel.AutoSize = true;
            code_sotrudnikaLabel.Location = new System.Drawing.Point(20, 52);
            code_sotrudnikaLabel.Name = "code_sotrudnikaLabel";
            code_sotrudnikaLabel.Size = new System.Drawing.Size(87, 13);
            code_sotrudnikaLabel.TabIndex = 1;
            code_sotrudnikaLabel.Text = "Code sotrudnika:";
            // 
            // code_sotrudnikaTextBox
            // 
            this.code_sotrudnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Code_sotrudnika", true));
            this.code_sotrudnikaTextBox.Location = new System.Drawing.Point(137, 49);
            this.code_sotrudnikaTextBox.Name = "code_sotrudnikaTextBox";
            this.code_sotrudnikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.code_sotrudnikaTextBox.TabIndex = 2;
            // 
            // familiyaLabel
            // 
            familiyaLabel.AutoSize = true;
            familiyaLabel.Location = new System.Drawing.Point(20, 78);
            familiyaLabel.Name = "familiyaLabel";
            familiyaLabel.Size = new System.Drawing.Size(47, 13);
            familiyaLabel.TabIndex = 3;
            familiyaLabel.Text = "Familiya:";
            // 
            // familiyaTextBox
            // 
            this.familiyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Familiya", true));
            this.familiyaTextBox.Location = new System.Drawing.Point(137, 75);
            this.familiyaTextBox.Name = "familiyaTextBox";
            this.familiyaTextBox.Size = new System.Drawing.Size(100, 20);
            this.familiyaTextBox.TabIndex = 4;
            // 
            // imyaLabel
            // 
            imyaLabel.AutoSize = true;
            imyaLabel.Location = new System.Drawing.Point(20, 104);
            imyaLabel.Name = "imyaLabel";
            imyaLabel.Size = new System.Drawing.Size(32, 13);
            imyaLabel.TabIndex = 5;
            imyaLabel.Text = "Imya:";
            // 
            // imyaTextBox
            // 
            this.imyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Imya", true));
            this.imyaTextBox.Location = new System.Drawing.Point(137, 101);
            this.imyaTextBox.Name = "imyaTextBox";
            this.imyaTextBox.Size = new System.Drawing.Size(100, 20);
            this.imyaTextBox.TabIndex = 6;
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Location = new System.Drawing.Point(20, 130);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(59, 13);
            otchestvoLabel.TabIndex = 7;
            otchestvoLabel.Text = "Otchestvo:";
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Otchestvo", true));
            this.otchestvoTextBox.Location = new System.Drawing.Point(137, 127);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.otchestvoTextBox.TabIndex = 8;
            // 
            // seriya_pasportaLabel
            // 
            seriya_pasportaLabel.AutoSize = true;
            seriya_pasportaLabel.Location = new System.Drawing.Point(20, 156);
            seriya_pasportaLabel.Name = "seriya_pasportaLabel";
            seriya_pasportaLabel.Size = new System.Drawing.Size(83, 13);
            seriya_pasportaLabel.TabIndex = 9;
            seriya_pasportaLabel.Text = "Seriya pasporta:";
            // 
            // seriya_pasportaTextBox
            // 
            this.seriya_pasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Seriya_pasporta", true));
            this.seriya_pasportaTextBox.Location = new System.Drawing.Point(137, 153);
            this.seriya_pasportaTextBox.Name = "seriya_pasportaTextBox";
            this.seriya_pasportaTextBox.Size = new System.Drawing.Size(100, 20);
            this.seriya_pasportaTextBox.TabIndex = 10;
            // 
            // nomer_pasportaLabel
            // 
            nomer_pasportaLabel.AutoSize = true;
            nomer_pasportaLabel.Location = new System.Drawing.Point(20, 182);
            nomer_pasportaLabel.Name = "nomer_pasportaLabel";
            nomer_pasportaLabel.Size = new System.Drawing.Size(85, 13);
            nomer_pasportaLabel.TabIndex = 11;
            nomer_pasportaLabel.Text = "Nomer pasporta:";
            // 
            // nomer_pasportaTextBox
            // 
            this.nomer_pasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Nomer_pasporta", true));
            this.nomer_pasportaTextBox.Location = new System.Drawing.Point(137, 179);
            this.nomer_pasportaTextBox.Name = "nomer_pasportaTextBox";
            this.nomer_pasportaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomer_pasportaTextBox.TabIndex = 12;
            // 
            // kvalifikaciyaLabel
            // 
            kvalifikaciyaLabel.AutoSize = true;
            kvalifikaciyaLabel.Location = new System.Drawing.Point(266, 51);
            kvalifikaciyaLabel.Name = "kvalifikaciyaLabel";
            kvalifikaciyaLabel.Size = new System.Drawing.Size(69, 13);
            kvalifikaciyaLabel.TabIndex = 13;
            kvalifikaciyaLabel.Text = "Kvalifikaciya:";
            // 
            // kvalifikaciyaTextBox
            // 
            this.kvalifikaciyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Kvalifikaciya", true));
            this.kvalifikaciyaTextBox.Location = new System.Drawing.Point(383, 48);
            this.kvalifikaciyaTextBox.Multiline = true;
            this.kvalifikaciyaTextBox.Name = "kvalifikaciyaTextBox";
            this.kvalifikaciyaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kvalifikaciyaTextBox.Size = new System.Drawing.Size(100, 32);
            this.kvalifikaciyaTextBox.TabIndex = 14;
            // 
            // sNILSLabel
            // 
            sNILSLabel.AutoSize = true;
            sNILSLabel.Location = new System.Drawing.Point(266, 89);
            sNILSLabel.Name = "sNILSLabel";
            sNILSLabel.Size = new System.Drawing.Size(41, 13);
            sNILSLabel.TabIndex = 15;
            sNILSLabel.Text = "SNILS:";
            // 
            // sNILSTextBox
            // 
            this.sNILSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "SNILS", true));
            this.sNILSTextBox.Location = new System.Drawing.Point(383, 86);
            this.sNILSTextBox.Name = "sNILSTextBox";
            this.sNILSTextBox.Size = new System.Drawing.Size(100, 20);
            this.sNILSTextBox.TabIndex = 16;
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(266, 118);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(29, 13);
            iNNLabel.TabIndex = 17;
            iNNLabel.Text = "INN:";
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(383, 115);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iNNTextBox.TabIndex = 18;
            // 
            // stagLabel
            // 
            stagLabel.AutoSize = true;
            stagLabel.Location = new System.Drawing.Point(266, 144);
            stagLabel.Name = "stagLabel";
            stagLabel.Size = new System.Drawing.Size(32, 13);
            stagLabel.TabIndex = 19;
            stagLabel.Text = "Stag:";
            // 
            // stagTextBox
            // 
            this.stagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Stag", true));
            this.stagTextBox.Location = new System.Drawing.Point(383, 141);
            this.stagTextBox.Name = "stagTextBox";
            this.stagTextBox.Size = new System.Drawing.Size(100, 20);
            this.stagTextBox.TabIndex = 20;
            // 
            // voennoobyathannostLabel
            // 
            voennoobyathannostLabel.AutoSize = true;
            voennoobyathannostLabel.Location = new System.Drawing.Point(266, 170);
            voennoobyathannostLabel.Name = "voennoobyathannostLabel";
            voennoobyathannostLabel.Size = new System.Drawing.Size(111, 13);
            voennoobyathannostLabel.TabIndex = 21;
            voennoobyathannostLabel.Text = "Voennoobyathannost:";
            // 
            // voennoobyathannostTextBox
            // 
            this.voennoobyathannostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Voennoobyathannost", true));
            this.voennoobyathannostTextBox.Location = new System.Drawing.Point(383, 167);
            this.voennoobyathannostTextBox.Name = "voennoobyathannostTextBox";
            this.voennoobyathannostTextBox.Size = new System.Drawing.Size(100, 20);
            this.voennoobyathannostTextBox.TabIndex = 22;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(269, 210);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 23;
            photoLabel.Text = "Photo:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sotrudnikBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(383, 193);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 87);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 24;
            this.photoPictureBox.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(269, 243);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(97, 23);
            this.buttonOpenPhoto.TabIndex = 25;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormWorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 445);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(code_sotrudnikaLabel);
            this.Controls.Add(this.code_sotrudnikaTextBox);
            this.Controls.Add(familiyaLabel);
            this.Controls.Add(this.familiyaTextBox);
            this.Controls.Add(imyaLabel);
            this.Controls.Add(this.imyaTextBox);
            this.Controls.Add(otchestvoLabel);
            this.Controls.Add(this.otchestvoTextBox);
            this.Controls.Add(seriya_pasportaLabel);
            this.Controls.Add(this.seriya_pasportaTextBox);
            this.Controls.Add(nomer_pasportaLabel);
            this.Controls.Add(this.nomer_pasportaTextBox);
            this.Controls.Add(kvalifikaciyaLabel);
            this.Controls.Add(this.kvalifikaciyaTextBox);
            this.Controls.Add(sNILSLabel);
            this.Controls.Add(this.sNILSTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(stagLabel);
            this.Controls.Add(this.stagTextBox);
            this.Controls.Add(voennoobyathannostLabel);
            this.Controls.Add(this.voennoobyathannostTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.sotrudnikBindingNavigator);
            this.Name = "FormWorkerList";
            this.Text = "List of workers";
            this.Load += new System.EventHandler(this.FormWorkerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnel_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingNavigator)).EndInit();
            this.sotrudnikBindingNavigator.ResumeLayout(false);
            this.sotrudnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnel_departmentDataSet personnel_departmentDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private Personnel_departmentDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private Personnel_departmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sotrudnikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sotrudnikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox code_sotrudnikaTextBox;
        private System.Windows.Forms.TextBox familiyaTextBox;
        private System.Windows.Forms.TextBox imyaTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.TextBox seriya_pasportaTextBox;
        private System.Windows.Forms.TextBox nomer_pasportaTextBox;
        private System.Windows.Forms.TextBox kvalifikaciyaTextBox;
        private System.Windows.Forms.TextBox sNILSTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox stagTextBox;
        private System.Windows.Forms.TextBox voennoobyathannostTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;

    }
}