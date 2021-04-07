
namespace DataBaseApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label second_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label phone_number_mainLabel;
            System.Windows.Forms.Label phone_number_additionalLabel;
            System.Windows.Forms.Label registration_dateLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label tariff_planLabel;
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dataSet1 = new DataBaseApp.DataSet1();
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsTableAdapter = new DataBaseApp.DataSet1TableAdapters.abonentsTableAdapter();
            this.tableAdapterManager = new DataBaseApp.DataSet1TableAdapters.TableAdapterManager();
            this.abonentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.abonentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.abonentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.second_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.phone_number_mainTextBox = new System.Windows.Forms.TextBox();
            this.phone_number_additionalTextBox = new System.Windows.Forms.TextBox();
            this.registration_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityCheckBox = new System.Windows.Forms.CheckBox();
            this.tariff_planTextBox = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelFillData = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            second_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            phone_number_mainLabel = new System.Windows.Forms.Label();
            phone_number_additionalLabel = new System.Windows.Forms.Label();
            registration_dateLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            tariff_planLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingNavigator)).BeginInit();
            this.abonentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsDataGridView)).BeginInit();
            this.panelFillData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(42, 50);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "ADD NEW";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonentsBindingSource
            // 
            this.abonentsBindingSource.DataMember = "abonents";
            this.abonentsBindingSource.DataSource = this.dataSet1;
            // 
            // abonentsTableAdapter
            // 
            this.abonentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.abonentsTableAdapter = this.abonentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataBaseApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // abonentsBindingNavigator
            // 
            this.abonentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.abonentsBindingNavigator.BindingSource = this.abonentsBindingSource;
            this.abonentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.abonentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.abonentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.abonentsBindingNavigatorSaveItem});
            this.abonentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.abonentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.abonentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.abonentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.abonentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.abonentsBindingNavigator.Name = "abonentsBindingNavigator";
            this.abonentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.abonentsBindingNavigator.Size = new System.Drawing.Size(1040, 25);
            this.abonentsBindingNavigator.TabIndex = 1;
            this.abonentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // abonentsBindingNavigatorSaveItem
            // 
            this.abonentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abonentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("abonentsBindingNavigatorSaveItem.Image")));
            this.abonentsBindingNavigatorSaveItem.Name = "abonentsBindingNavigatorSaveItem";
            this.abonentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.abonentsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.abonentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.abonentsBindingNavigatorSaveItem_Click);
            // 
            // abonentsDataGridView
            // 
            this.abonentsDataGridView.AutoGenerateColumns = false;
            this.abonentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8});
            this.abonentsDataGridView.DataSource = this.abonentsBindingSource;
            this.abonentsDataGridView.Location = new System.Drawing.Point(42, 438);
            this.abonentsDataGridView.Name = "abonentsDataGridView";
            this.abonentsDataGridView.Size = new System.Drawing.Size(937, 220);
            this.abonentsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "second_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "second_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "middle_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "middle_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone_number_main";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone_number_main";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone_number_additional";
            this.dataGridViewTextBoxColumn6.HeaderText = "phone_number_additional";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "registration_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "registration_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "activity";
            this.dataGridViewCheckBoxColumn1.HeaderText = "activity";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tariff_plan";
            this.dataGridViewTextBoxColumn8.HeaderText = "tariff_plan";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(38, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(170, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Visible = false;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(38, 32);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 5;
            first_nameLabel.Text = "first name:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(170, 29);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 6;
            // 
            // second_nameLabel
            // 
            second_nameLabel.AutoSize = true;
            second_nameLabel.Location = new System.Drawing.Point(38, 58);
            second_nameLabel.Name = "second_nameLabel";
            second_nameLabel.Size = new System.Drawing.Size(74, 13);
            second_nameLabel.TabIndex = 7;
            second_nameLabel.Text = "second name:";
            // 
            // second_nameTextBox
            // 
            this.second_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "second_name", true));
            this.second_nameTextBox.Location = new System.Drawing.Point(170, 55);
            this.second_nameTextBox.Name = "second_nameTextBox";
            this.second_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.second_nameTextBox.TabIndex = 8;
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new System.Drawing.Point(38, 84);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(69, 13);
            middle_nameLabel.TabIndex = 9;
            middle_nameLabel.Text = "middle name:";
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "middle_name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(170, 81);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.middle_nameTextBox.TabIndex = 10;
            // 
            // phone_number_mainLabel
            // 
            phone_number_mainLabel.AutoSize = true;
            phone_number_mainLabel.Location = new System.Drawing.Point(38, 110);
            phone_number_mainLabel.Name = "phone_number_mainLabel";
            phone_number_mainLabel.Size = new System.Drawing.Size(103, 13);
            phone_number_mainLabel.TabIndex = 11;
            phone_number_mainLabel.Text = "phone number main:";
            // 
            // phone_number_mainTextBox
            // 
            this.phone_number_mainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "phone_number_main", true));
            this.phone_number_mainTextBox.Location = new System.Drawing.Point(170, 107);
            this.phone_number_mainTextBox.Name = "phone_number_mainTextBox";
            this.phone_number_mainTextBox.Size = new System.Drawing.Size(200, 20);
            this.phone_number_mainTextBox.TabIndex = 12;
            // 
            // phone_number_additionalLabel
            // 
            phone_number_additionalLabel.AutoSize = true;
            phone_number_additionalLabel.Location = new System.Drawing.Point(406, 32);
            phone_number_additionalLabel.Name = "phone_number_additionalLabel";
            phone_number_additionalLabel.Size = new System.Drawing.Size(126, 13);
            phone_number_additionalLabel.TabIndex = 13;
            phone_number_additionalLabel.Text = "phone number additional:";
            // 
            // phone_number_additionalTextBox
            // 
            this.phone_number_additionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "phone_number_additional", true));
            this.phone_number_additionalTextBox.Location = new System.Drawing.Point(538, 29);
            this.phone_number_additionalTextBox.Name = "phone_number_additionalTextBox";
            this.phone_number_additionalTextBox.Size = new System.Drawing.Size(200, 20);
            this.phone_number_additionalTextBox.TabIndex = 14;
            // 
            // registration_dateLabel
            // 
            registration_dateLabel.AutoSize = true;
            registration_dateLabel.Location = new System.Drawing.Point(406, 59);
            registration_dateLabel.Name = "registration_dateLabel";
            registration_dateLabel.Size = new System.Drawing.Size(85, 13);
            registration_dateLabel.TabIndex = 15;
            registration_dateLabel.Text = "registration date:";
            // 
            // registration_dateDateTimePicker
            // 
            this.registration_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonentsBindingSource, "registration_date", true));
            this.registration_dateDateTimePicker.Location = new System.Drawing.Point(538, 55);
            this.registration_dateDateTimePicker.Name = "registration_dateDateTimePicker";
            this.registration_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registration_dateDateTimePicker.TabIndex = 16;
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Location = new System.Drawing.Point(406, 86);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(43, 13);
            activityLabel.TabIndex = 17;
            activityLabel.Text = "activity:";
            // 
            // activityCheckBox
            // 
            this.activityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.abonentsBindingSource, "activity", true));
            this.activityCheckBox.Location = new System.Drawing.Point(538, 81);
            this.activityCheckBox.Name = "activityCheckBox";
            this.activityCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activityCheckBox.TabIndex = 18;
            this.activityCheckBox.Text = "checkBox1";
            this.activityCheckBox.UseVisualStyleBackColor = true;
            // 
            // tariff_planLabel
            // 
            tariff_planLabel.AutoSize = true;
            tariff_planLabel.Location = new System.Drawing.Point(406, 114);
            tariff_planLabel.Name = "tariff_planLabel";
            tariff_planLabel.Size = new System.Drawing.Size(53, 13);
            tariff_planLabel.TabIndex = 19;
            tariff_planLabel.Text = "tariff plan:";
            // 
            // tariff_planTextBox
            // 
            this.tariff_planTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "tariff_plan", true));
            this.tariff_planTextBox.Location = new System.Drawing.Point(538, 111);
            this.tariff_planTextBox.Name = "tariff_planTextBox";
            this.tariff_planTextBox.Size = new System.Drawing.Size(200, 20);
            this.tariff_planTextBox.TabIndex = 20;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(947, 44);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 31);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelFillData
            // 
            this.panelFillData.BackColor = System.Drawing.Color.White;
            this.panelFillData.Controls.Add(this.buttonSave);
            this.panelFillData.Controls.Add(idLabel);
            this.panelFillData.Controls.Add(this.tariff_planTextBox);
            this.panelFillData.Controls.Add(tariff_planLabel);
            this.panelFillData.Controls.Add(this.idTextBox);
            this.panelFillData.Controls.Add(this.activityCheckBox);
            this.panelFillData.Controls.Add(first_nameLabel);
            this.panelFillData.Controls.Add(activityLabel);
            this.panelFillData.Controls.Add(this.first_nameTextBox);
            this.panelFillData.Controls.Add(this.registration_dateDateTimePicker);
            this.panelFillData.Controls.Add(second_nameLabel);
            this.panelFillData.Controls.Add(registration_dateLabel);
            this.panelFillData.Controls.Add(this.second_nameTextBox);
            this.panelFillData.Controls.Add(this.phone_number_additionalTextBox);
            this.panelFillData.Controls.Add(middle_nameLabel);
            this.panelFillData.Controls.Add(phone_number_additionalLabel);
            this.panelFillData.Controls.Add(this.middle_nameTextBox);
            this.panelFillData.Controls.Add(this.phone_number_mainTextBox);
            this.panelFillData.Controls.Add(phone_number_mainLabel);
            this.panelFillData.Location = new System.Drawing.Point(42, 83);
            this.panelFillData.Name = "panelFillData";
            this.panelFillData.Size = new System.Drawing.Size(878, 216);
            this.panelFillData.TabIndex = 22;
            this.panelFillData.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(362, 169);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1040, 764);
            this.Controls.Add(this.panelFillData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.abonentsDataGridView);
            this.Controls.Add(this.abonentsBindingNavigator);
            this.Controls.Add(this.buttonAddNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingNavigator)).EndInit();
            this.abonentsBindingNavigator.ResumeLayout(false);
            this.abonentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsDataGridView)).EndInit();
            this.panelFillData.ResumeLayout(false);
            this.panelFillData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion              
        private System.Windows.Forms.Button buttonAddNew;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource abonentsBindingSource;
        private DataSet1TableAdapters.abonentsTableAdapter abonentsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator abonentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton abonentsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView abonentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox second_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox phone_number_mainTextBox;
        private System.Windows.Forms.TextBox phone_number_additionalTextBox;
        private System.Windows.Forms.DateTimePicker registration_dateDateTimePicker;
        private System.Windows.Forms.CheckBox activityCheckBox;
        private System.Windows.Forms.TextBox tariff_planTextBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelFillData;
        private System.Windows.Forms.Button buttonSave;
    }
}