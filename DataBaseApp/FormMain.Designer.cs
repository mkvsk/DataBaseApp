
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
            System.Windows.Forms.Label tariff_planLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label second_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label phone_number_mainLabel;
            System.Windows.Forms.Label phone_number_additionalLabel;
            System.Windows.Forms.Label registration_dateLabel;
            System.Windows.Forms.Label activityLabel;
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelDataToEnter = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.panelRightSight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.abonentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DataBaseApp.DataSet1();
            this.abonentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.activityCheckBox = new System.Windows.Forms.CheckBox();
            this.phone_number_mainTextBox = new System.Windows.Forms.TextBox();
            this.tariff_planTextBox = new System.Windows.Forms.TextBox();
            this.second_nameTextBox = new System.Windows.Forms.TextBox();
            this.registration_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phone_number_additionalTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.abonentsTableAdapter = new DataBaseApp.DataSet1TableAdapters.abonentsTableAdapter();
            this.tableAdapterManager = new DataBaseApp.DataSet1TableAdapters.TableAdapterManager();
            this.buttonSaveAndUpdate = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            tariff_planLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            second_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            phone_number_mainLabel = new System.Windows.Forms.Label();
            phone_number_additionalLabel = new System.Windows.Forms.Label();
            registration_dateLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelDataToEnter.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(45, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 27;
            idLabel.Text = "id:";
            // 
            // tariff_planLabel
            // 
            tariff_planLabel.AutoSize = true;
            tariff_planLabel.Location = new System.Drawing.Point(45, 56);
            tariff_planLabel.Name = "tariff_planLabel";
            tariff_planLabel.Size = new System.Drawing.Size(53, 13);
            tariff_planLabel.TabIndex = 29;
            tariff_planLabel.Text = "tariff plan:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(45, 82);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 31;
            first_nameLabel.Text = "first name:";
            // 
            // second_nameLabel
            // 
            second_nameLabel.AutoSize = true;
            second_nameLabel.Location = new System.Drawing.Point(45, 108);
            second_nameLabel.Name = "second_nameLabel";
            second_nameLabel.Size = new System.Drawing.Size(74, 13);
            second_nameLabel.TabIndex = 33;
            second_nameLabel.Text = "second name:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new System.Drawing.Point(45, 134);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(69, 13);
            middle_nameLabel.TabIndex = 35;
            middle_nameLabel.Text = "middle name:";
            // 
            // phone_number_mainLabel
            // 
            phone_number_mainLabel.AutoSize = true;
            phone_number_mainLabel.Location = new System.Drawing.Point(45, 160);
            phone_number_mainLabel.Name = "phone_number_mainLabel";
            phone_number_mainLabel.Size = new System.Drawing.Size(103, 13);
            phone_number_mainLabel.TabIndex = 37;
            phone_number_mainLabel.Text = "phone number main:";
            // 
            // phone_number_additionalLabel
            // 
            phone_number_additionalLabel.AutoSize = true;
            phone_number_additionalLabel.Location = new System.Drawing.Point(45, 186);
            phone_number_additionalLabel.Name = "phone_number_additionalLabel";
            phone_number_additionalLabel.Size = new System.Drawing.Size(126, 13);
            phone_number_additionalLabel.TabIndex = 39;
            phone_number_additionalLabel.Text = "phone number additional:";
            // 
            // registration_dateLabel
            // 
            registration_dateLabel.AutoSize = true;
            registration_dateLabel.Location = new System.Drawing.Point(45, 213);
            registration_dateLabel.Name = "registration_dateLabel";
            registration_dateLabel.Size = new System.Drawing.Size(85, 13);
            registration_dateLabel.TabIndex = 41;
            registration_dateLabel.Text = "registration date:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Location = new System.Drawing.Point(45, 240);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(43, 13);
            activityLabel.TabIndex = 43;
            activityLabel.Text = "activity:";
            // 
            // abonentsBindingSource
            // 
            this.abonentsBindingSource.DataMember = "abonents";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.panelHeader.Controls.Add(this.panelDataToEnter);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1248, 90);
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
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(12, 6);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 28;
            this.buttonAddNew.Text = "Add";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // panelRightSight
            // 
            this.panelRightSight.BackColor = System.Drawing.Color.LightGray;
            this.panelRightSight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSight.Location = new System.Drawing.Point(1148, 90);
            this.panelRightSight.Name = "panelRightSight";
            this.panelRightSight.Size = new System.Drawing.Size(100, 695);
            this.panelRightSight.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.abonentsDataGridView);
            this.panel2.Controls.Add(phone_number_mainLabel);
            this.panel2.Controls.Add(tariff_planLabel);
            this.panel2.Controls.Add(this.middle_nameTextBox);
            this.panel2.Controls.Add(this.activityCheckBox);
            this.panel2.Controls.Add(this.phone_number_mainTextBox);
            this.panel2.Controls.Add(this.tariff_planTextBox);
            this.panel2.Controls.Add(middle_nameLabel);
            this.panel2.Controls.Add(activityLabel);
            this.panel2.Controls.Add(phone_number_additionalLabel);
            this.panel2.Controls.Add(first_nameLabel);
            this.panel2.Controls.Add(this.second_nameTextBox);
            this.panel2.Controls.Add(this.registration_dateDateTimePicker);
            this.panel2.Controls.Add(this.phone_number_additionalTextBox);
            this.panel2.Controls.Add(this.first_nameTextBox);
            this.panel2.Controls.Add(second_nameLabel);
            this.panel2.Controls.Add(registration_dateLabel);
            this.panel2.Location = new System.Drawing.Point(106, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 444);
            this.panel2.TabIndex = 27;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(177, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 28;
            // 
            // abonentsBindingSource1
            // 
            this.abonentsBindingSource1.DataMember = "abonents";
            this.abonentsBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.abonentsDataGridView.DataSource = this.abonentsBindingSource1;
            this.abonentsDataGridView.Location = new System.Drawing.Point(518, 108);
            this.abonentsDataGridView.Name = "abonentsDataGridView";
            this.abonentsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.abonentsDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tariff_plan";
            this.dataGridViewTextBoxColumn2.HeaderText = "tariff_plan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "second_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "second_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "middle_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "middle_name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone_number_main";
            this.dataGridViewTextBoxColumn6.HeaderText = "phone_number_main";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone_number_additional";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone_number_additional";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "registration_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "registration_date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "activity";
            this.dataGridViewCheckBoxColumn1.HeaderText = "activity";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "middle_name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(177, 131);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.middle_nameTextBox.TabIndex = 36;
            // 
            // activityCheckBox
            // 
            this.activityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.abonentsBindingSource1, "activity", true));
            this.activityCheckBox.Location = new System.Drawing.Point(177, 235);
            this.activityCheckBox.Name = "activityCheckBox";
            this.activityCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activityCheckBox.TabIndex = 44;
            this.activityCheckBox.Text = "checkBox1";
            this.activityCheckBox.UseVisualStyleBackColor = true;
            // 
            // phone_number_mainTextBox
            // 
            this.phone_number_mainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "phone_number_main", true));
            this.phone_number_mainTextBox.Location = new System.Drawing.Point(177, 157);
            this.phone_number_mainTextBox.Name = "phone_number_mainTextBox";
            this.phone_number_mainTextBox.Size = new System.Drawing.Size(200, 20);
            this.phone_number_mainTextBox.TabIndex = 38;
            // 
            // tariff_planTextBox
            // 
            this.tariff_planTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "tariff_plan", true));
            this.tariff_planTextBox.Location = new System.Drawing.Point(177, 53);
            this.tariff_planTextBox.Name = "tariff_planTextBox";
            this.tariff_planTextBox.Size = new System.Drawing.Size(200, 20);
            this.tariff_planTextBox.TabIndex = 30;
            // 
            // second_nameTextBox
            // 
            this.second_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "second_name", true));
            this.second_nameTextBox.Location = new System.Drawing.Point(177, 105);
            this.second_nameTextBox.Name = "second_nameTextBox";
            this.second_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.second_nameTextBox.TabIndex = 34;
            // 
            // registration_dateDateTimePicker
            // 
            this.registration_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonentsBindingSource1, "registration_date", true));
            this.registration_dateDateTimePicker.Location = new System.Drawing.Point(177, 209);
            this.registration_dateDateTimePicker.Name = "registration_dateDateTimePicker";
            this.registration_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registration_dateDateTimePicker.TabIndex = 42;
            // 
            // phone_number_additionalTextBox
            // 
            this.phone_number_additionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "phone_number_additional", true));
            this.phone_number_additionalTextBox.Location = new System.Drawing.Point(177, 183);
            this.phone_number_additionalTextBox.Name = "phone_number_additionalTextBox";
            this.phone_number_additionalTextBox.Size = new System.Drawing.Size(200, 20);
            this.phone_number_additionalTextBox.TabIndex = 40;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentsBindingSource1, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(177, 79);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 32;
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
            // buttonSaveAndUpdate
            // 
            this.buttonSaveAndUpdate.Location = new System.Drawing.Point(309, 173);
            this.buttonSaveAndUpdate.Name = "buttonSaveAndUpdate";
            this.buttonSaveAndUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAndUpdate.TabIndex = 29;
            this.buttonSaveAndUpdate.Text = "Save";
            this.buttonSaveAndUpdate.UseVisualStyleBackColor = true;
            this.buttonSaveAndUpdate.Click += new System.EventHandler(this.buttonSaveAndUpdate_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1248, 785);
            this.Controls.Add(this.buttonSaveAndUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRightSight);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelDataToEnter.ResumeLayout(false);
            this.panelDataToEnter.PerformLayout();
            this.panelLeftSide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.BindingSource abonentsBindingSource;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelDataToEnter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelRightSight;
        private System.Windows.Forms.Panel panel2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource abonentsBindingSource1;
        private DataSet1TableAdapters.abonentsTableAdapter abonentsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView abonentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.CheckBox activityCheckBox;
        private System.Windows.Forms.TextBox phone_number_mainTextBox;
        private System.Windows.Forms.TextBox tariff_planTextBox;
        private System.Windows.Forms.TextBox second_nameTextBox;
        private System.Windows.Forms.DateTimePicker registration_dateDateTimePicker;
        private System.Windows.Forms.TextBox phone_number_additionalTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSaveAndUpdate;
    }
    #endregion
}