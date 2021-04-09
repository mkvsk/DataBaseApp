
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label second_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label phone_number_mainLabel;
            System.Windows.Forms.Label phone_number_additionalLabel;
            System.Windows.Forms.Label registration_dateLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label tariff_planLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataSet1 = new DataBaseApp.DataSet1();
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsTableAdapter = new DataBaseApp.DataSet1TableAdapters.abonentsTableAdapter();
            this.tableAdapterManager = new DataBaseApp.DataSet1TableAdapters.TableAdapterManager();
            this.abonentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelDataToEnter = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRightSight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panelHeader.SuspendLayout();
            this.panelDataToEnter.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(100, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(98, 19);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(77, 18);
            first_nameLabel.TabIndex = 5;
            first_nameLabel.Text = "first name:";
            // 
            // second_nameLabel
            // 
            second_nameLabel.AutoSize = true;
            second_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            second_nameLabel.Location = new System.Drawing.Point(98, 45);
            second_nameLabel.Name = "second_nameLabel";
            second_nameLabel.Size = new System.Drawing.Size(102, 18);
            second_nameLabel.TabIndex = 7;
            second_nameLabel.Text = "second name:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(98, 71);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(96, 18);
            middle_nameLabel.TabIndex = 9;
            middle_nameLabel.Text = "middle name:";
            // 
            // phone_number_mainLabel
            // 
            phone_number_mainLabel.AutoSize = true;
            phone_number_mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_number_mainLabel.Location = new System.Drawing.Point(98, 97);
            phone_number_mainLabel.Name = "phone_number_mainLabel";
            phone_number_mainLabel.Size = new System.Drawing.Size(143, 18);
            phone_number_mainLabel.TabIndex = 11;
            phone_number_mainLabel.Text = "phone number main:";
            // 
            // phone_number_additionalLabel
            // 
            phone_number_additionalLabel.AutoSize = true;
            phone_number_additionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_number_additionalLabel.Location = new System.Drawing.Point(520, 15);
            phone_number_additionalLabel.Name = "phone_number_additionalLabel";
            phone_number_additionalLabel.Size = new System.Drawing.Size(173, 18);
            phone_number_additionalLabel.TabIndex = 13;
            phone_number_additionalLabel.Text = "phone number additional:";
            // 
            // registration_dateLabel
            // 
            registration_dateLabel.AutoSize = true;
            registration_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registration_dateLabel.Location = new System.Drawing.Point(520, 42);
            registration_dateLabel.Name = "registration_dateLabel";
            registration_dateLabel.Size = new System.Drawing.Size(117, 18);
            registration_dateLabel.TabIndex = 15;
            registration_dateLabel.Text = "registration date:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activityLabel.Location = new System.Drawing.Point(520, 69);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(56, 18);
            activityLabel.TabIndex = 17;
            activityLabel.Text = "activity:";
            // 
            // tariff_planLabel
            // 
            tariff_planLabel.AutoSize = true;
            tariff_planLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tariff_planLabel.Location = new System.Drawing.Point(520, 97);
            tariff_planLabel.Name = "tariff_planLabel";
            tariff_planLabel.Size = new System.Drawing.Size(71, 18);
            tariff_planLabel.TabIndex = 19;
            tariff_planLabel.Text = "tariff plan:";
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
            this.abonentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.abonentsBindingNavigator.Location = new System.Drawing.Point(629, 38);
            this.abonentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.abonentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.abonentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.abonentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.abonentsBindingNavigator.Name = "abonentsBindingNavigator";
            this.abonentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.abonentsBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.abonentsBindingNavigator.TabIndex = 1;
            this.abonentsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.abonentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.abonentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.abonentsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.abonentsDataGridView.Location = new System.Drawing.Point(4, 3);
            this.abonentsDataGridView.Name = "abonentsDataGridView";
            this.abonentsDataGridView.Size = new System.Drawing.Size(943, 424);
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(232, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Visible = false;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(247, 13);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.first_nameTextBox.TabIndex = 6;
            // 
            // second_nameTextBox
            // 
            this.second_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "second_name", true));
            this.second_nameTextBox.Location = new System.Drawing.Point(247, 39);
            this.second_nameTextBox.Name = "second_nameTextBox";
            this.second_nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.second_nameTextBox.TabIndex = 8;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "middle_name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(247, 65);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.middle_nameTextBox.TabIndex = 10;
            // 
            // phone_number_mainTextBox
            // 
            this.phone_number_mainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "phone_number_main", true));
            this.phone_number_mainTextBox.Location = new System.Drawing.Point(247, 91);
            this.phone_number_mainTextBox.Name = "phone_number_mainTextBox";
            this.phone_number_mainTextBox.Size = new System.Drawing.Size(200, 24);
            this.phone_number_mainTextBox.TabIndex = 12;
            // 
            // phone_number_additionalTextBox
            // 
            this.phone_number_additionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "phone_number_additional", true));
            this.phone_number_additionalTextBox.Location = new System.Drawing.Point(699, 9);
            this.phone_number_additionalTextBox.Name = "phone_number_additionalTextBox";
            this.phone_number_additionalTextBox.Size = new System.Drawing.Size(200, 24);
            this.phone_number_additionalTextBox.TabIndex = 14;
            // 
            // registration_dateDateTimePicker
            // 
            this.registration_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonentsBindingSource, "registration_date", true));
            this.registration_dateDateTimePicker.Location = new System.Drawing.Point(699, 35);
            this.registration_dateDateTimePicker.Name = "registration_dateDateTimePicker";
            this.registration_dateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.registration_dateDateTimePicker.TabIndex = 16;
            // 
            // activityCheckBox
            // 
            this.activityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.abonentsBindingSource, "activity", true));
            this.activityCheckBox.Location = new System.Drawing.Point(699, 61);
            this.activityCheckBox.Name = "activityCheckBox";
            this.activityCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activityCheckBox.TabIndex = 18;
            this.activityCheckBox.Text = "checkBox1";
            this.activityCheckBox.UseVisualStyleBackColor = true;
            // 
            // tariff_planTextBox
            // 
            this.tariff_planTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource, "tariff_plan", true));
            this.tariff_planTextBox.Location = new System.Drawing.Point(699, 91);
            this.tariff_planTextBox.Name = "tariff_planTextBox";
            this.tariff_planTextBox.Size = new System.Drawing.Size(200, 24);
            this.tariff_planTextBox.TabIndex = 20;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(12, 36);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 21;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.Location = new System.Drawing.Point(920, 67);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNew.TabIndex = 22;
            this.buttonSaveNew.Text = "SAVE";
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.panelHeader.Controls.Add(this.panelDataToEnter);
            this.panelHeader.Controls.Add(this.abonentsBindingNavigator);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1235, 90);
            this.panelHeader.TabIndex = 23;
            // 
            // panelDataToEnter
            // 
            this.panelDataToEnter.BackColor = System.Drawing.Color.White;
            this.panelDataToEnter.Controls.Add(this.textBoxSearch);
            this.panelDataToEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDataToEnter.Location = new System.Drawing.Point(71, 38);
            this.panelDataToEnter.Name = "panelDataToEnter";
            this.panelDataToEnter.Size = new System.Drawing.Size(440, 32);
            this.panelDataToEnter.TabIndex = 25;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSearch.Location = new System.Drawing.Point(32, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(405, 22);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.Text = "search data ";
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(92)))), ((int)(((byte)(195)))));
            this.panelLeftSide.Controls.Add(this.buttonAddNew);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 90);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(100, 695);
            this.panelLeftSide.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tariff_planTextBox);
            this.panel1.Controls.Add(this.buttonSaveNew);
            this.panel1.Controls.Add(tariff_planLabel);
            this.panel1.Controls.Add(this.activityCheckBox);
            this.panel1.Controls.Add(activityLabel);
            this.panel1.Controls.Add(first_nameLabel);
            this.panel1.Controls.Add(this.registration_dateDateTimePicker);
            this.panel1.Controls.Add(this.first_nameTextBox);
            this.panel1.Controls.Add(registration_dateLabel);
            this.panel1.Controls.Add(second_nameLabel);
            this.panel1.Controls.Add(this.phone_number_additionalTextBox);
            this.panel1.Controls.Add(this.second_nameTextBox);
            this.panel1.Controls.Add(phone_number_additionalLabel);
            this.panel1.Controls.Add(middle_nameLabel);
            this.panel1.Controls.Add(this.phone_number_mainTextBox);
            this.panel1.Controls.Add(this.middle_nameTextBox);
            this.panel1.Controls.Add(phone_number_mainLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(106, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 132);
            this.panel1.TabIndex = 25;
            // 
            // panelRightSight
            // 
            this.panelRightSight.BackColor = System.Drawing.Color.LightGray;
            this.panelRightSight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSight.Location = new System.Drawing.Point(1135, 90);
            this.panelRightSight.Name = "panelRightSight";
            this.panelRightSight.Size = new System.Drawing.Size(100, 695);
            this.panelRightSight.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.abonentsDataGridView);
            this.panel2.Location = new System.Drawing.Point(106, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 444);
            this.panel2.TabIndex = 27;
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1235, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRightSight);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingNavigator)).EndInit();
            this.abonentsBindingNavigator.ResumeLayout(false);
            this.abonentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsDataGridView)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDataToEnter.ResumeLayout(false);
            this.panelDataToEnter.PerformLayout();
            this.panelLeftSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
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
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelDataToEnter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRightSight;
        private System.Windows.Forms.Panel panel2;
    }
    #endregion
}