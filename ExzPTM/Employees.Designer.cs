
namespace ExzPTM
{
    partial class Employees
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
            this.dgEmpl = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPMDataSet = new ExzPTM.PPMDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new ExzPTM.PPMDataSetTableAdapters.employeesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearche = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDateExp = new System.Windows.Forms.ComboBox();
            this.typepodgBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbVidPodg = new System.Windows.Forms.ComboBox();
            this.typepodgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.podrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatePass = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTalon = new System.Windows.Forms.TextBox();
            this.tbParentName = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.podrTableAdapter = new ExzPTM.PPMDataSetTableAdapters.podrTableAdapter();
            this.typepodgTableAdapter = new ExzPTM.PPMDataSetTableAdapters.typepodgTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtalonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vid_podg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofpassageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpodrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpl
            // 
            this.dgEmpl.AllowUserToAddRows = false;
            this.dgEmpl.AllowUserToDeleteRows = false;
            this.dgEmpl.AutoGenerateColumns = false;
            this.dgEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastname,
            this.firstnameDataGridViewTextBoxColumn,
            this.parentnameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.numtalonDataGridViewTextBoxColumn,
            this.vid_podg,
            this.dateofpassageDataGridViewTextBoxColumn,
            this.dateExpired,
            this.idpodrDataGridViewTextBoxColumn});
            this.dgEmpl.DataSource = this.employeesBindingSource;
            this.dgEmpl.Location = new System.Drawing.Point(16, 56);
            this.dgEmpl.Name = "dgEmpl";
            this.dgEmpl.ReadOnly = true;
            this.dgEmpl.Size = new System.Drawing.Size(1208, 282);
            this.dgEmpl.TabIndex = 0;
            this.dgEmpl.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpl_CellEnter);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.pPMDataSet;
            // 
            // pPMDataSet
            // 
            this.pPMDataSet.DataSetName = "PPMDataSet";
            this.pPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1108, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить данные";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(11, 77);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(123, 20);
            this.tbLastName.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(140, 77);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(123, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbSearche);
            this.groupBox1.Controls.Add(this.dgEmpl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbSearche
            // 
            this.tbSearche.Location = new System.Drawing.Point(16, 20);
            this.tbSearche.Name = "tbSearche";
            this.tbSearche.Size = new System.Drawing.Size(144, 20);
            this.tbSearche.TabIndex = 1;
            this.tbSearche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpExpDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbDateExp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbVidPodg);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dtpDatePass);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbTalon);
            this.groupBox2.Controls.Add(this.tbParentName);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Controls.Add(this.tbPosition);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1224, 186);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(909, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Действителен до...";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(909, 74);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(111, 20);
            this.dtpExpDate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1026, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Срок действия (мес.)";
            // 
            // cbDateExp
            // 
            this.cbDateExp.DataSource = this.typepodgBindingSource1;
            this.cbDateExp.DisplayMember = "expdate";
            this.cbDateExp.FormattingEnabled = true;
            this.cbDateExp.Location = new System.Drawing.Point(1029, 113);
            this.cbDateExp.Name = "cbDateExp";
            this.cbDateExp.Size = new System.Drawing.Size(111, 21);
            this.cbDateExp.TabIndex = 17;
            this.cbDateExp.ValueMember = "id";
            // 
            // typepodgBindingSource1
            // 
            this.typepodgBindingSource1.DataMember = "typepodg";
            this.typepodgBindingSource1.DataSource = this.pPMDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1026, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Вид подготовки";
            // 
            // cbVidPodg
            // 
            this.cbVidPodg.DataSource = this.typepodgBindingSource;
            this.cbVidPodg.DisplayMember = "name";
            this.cbVidPodg.FormattingEnabled = true;
            this.cbVidPodg.Location = new System.Drawing.Point(1026, 73);
            this.cbVidPodg.Name = "cbVidPodg";
            this.cbVidPodg.Size = new System.Drawing.Size(188, 21);
            this.cbVidPodg.TabIndex = 13;
            this.cbVidPodg.ValueMember = "id";
            this.cbVidPodg.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // typepodgBindingSource
            // 
            this.typepodgBindingSource.DataMember = "typepodg";
            this.typepodgBindingSource.DataSource = this.pPMDataSet;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Администратор";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(399, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Очистить поля";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Подразделение";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.podrBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(715, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id";
            // 
            // podrBindingSource
            // 
            this.podrBindingSource.DataMember = "podr";
            this.podrBindingSource.DataSource = this.pPMDataSet;
            // 
            // dtpDatePass
            // 
            this.dtpDatePass.CustomFormat = "";
            this.dtpDatePass.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePass.Location = new System.Drawing.Point(586, 77);
            this.dtpDatePass.Name = "dtpDatePass";
            this.dtpDatePass.Size = new System.Drawing.Size(123, 20);
            this.dtpDatePass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата прохождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "№ талона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // tbTalon
            // 
            this.tbTalon.Location = new System.Drawing.Point(527, 76);
            this.tbTalon.Name = "tbTalon";
            this.tbTalon.ReadOnly = true;
            this.tbTalon.Size = new System.Drawing.Size(53, 20);
            this.tbTalon.TabIndex = 6;
            // 
            // tbParentName
            // 
            this.tbParentName.Location = new System.Drawing.Point(269, 77);
            this.tbParentName.Name = "tbParentName";
            this.tbParentName.ReadOnly = true;
            this.tbParentName.Size = new System.Drawing.Size(123, 20);
            this.tbParentName.TabIndex = 6;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(398, 76);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(123, 20);
            this.tbPosition.TabIndex = 6;
            // 
            // podrTableAdapter
            // 
            this.podrTableAdapter.ClearBeforeFill = true;
            // 
            // typepodgTableAdapter
            // 
            this.typepodgTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Поиск по Фамилии";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // lastname
            // 
            this.lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Фамилия";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 81;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 54;
            // 
            // parentnameDataGridViewTextBoxColumn
            // 
            this.parentnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.parentnameDataGridViewTextBoxColumn.DataPropertyName = "parentname";
            this.parentnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.parentnameDataGridViewTextBoxColumn.Name = "parentnameDataGridViewTextBoxColumn";
            this.parentnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentnameDataGridViewTextBoxColumn.Width = 79;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 90;
            // 
            // numtalonDataGridViewTextBoxColumn
            // 
            this.numtalonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numtalonDataGridViewTextBoxColumn.DataPropertyName = "num_talon";
            this.numtalonDataGridViewTextBoxColumn.HeaderText = "№ талона";
            this.numtalonDataGridViewTextBoxColumn.Name = "numtalonDataGridViewTextBoxColumn";
            this.numtalonDataGridViewTextBoxColumn.ReadOnly = true;
            this.numtalonDataGridViewTextBoxColumn.Width = 81;
            // 
            // vid_podg
            // 
            this.vid_podg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vid_podg.DataPropertyName = "vid_podg";
            this.vid_podg.HeaderText = "Вид подготовки";
            this.vid_podg.Name = "vid_podg";
            this.vid_podg.ReadOnly = true;
            this.vid_podg.Width = 103;
            // 
            // dateofpassageDataGridViewTextBoxColumn
            // 
            this.dateofpassageDataGridViewTextBoxColumn.DataPropertyName = "date_of_passage";
            this.dateofpassageDataGridViewTextBoxColumn.HeaderText = "Дата прохождения";
            this.dateofpassageDataGridViewTextBoxColumn.Name = "dateofpassageDataGridViewTextBoxColumn";
            this.dateofpassageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateExpired
            // 
            this.dateExpired.DataPropertyName = "dateExpired";
            this.dateExpired.HeaderText = "Действителен до";
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.ReadOnly = true;
            // 
            // idpodrDataGridViewTextBoxColumn
            // 
            this.idpodrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idpodrDataGridViewTextBoxColumn.DataPropertyName = "id_podr";
            this.idpodrDataGridViewTextBoxColumn.HeaderText = "id_podr";
            this.idpodrDataGridViewTextBoxColumn.Name = "idpodrDataGridViewTextBoxColumn";
            this.idpodrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpodrDataGridViewTextBoxColumn.Width = 67;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpl;
        private System.Windows.Forms.Button button1;
        private PPMDataSet pPMDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private PPMDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParentName;
        private System.Windows.Forms.DateTimePicker dtpDatePass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTalon;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource podrBindingSource;
        private PPMDataSetTableAdapters.podrTableAdapter podrTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVidPodg;
        private System.Windows.Forms.BindingSource typepodgBindingSource;
        private PPMDataSetTableAdapters.typepodgTableAdapter typepodgTableAdapter;
        private System.Windows.Forms.TextBox tbSearche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDateExp;
        private System.Windows.Forms.BindingSource typepodgBindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtalonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vid_podg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofpassageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpodrDataGridViewTextBoxColumn;
    }
}