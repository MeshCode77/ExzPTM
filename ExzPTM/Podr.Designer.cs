
namespace ExzPTM
{
    partial class Podr
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
            this.dgPodr = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPMDataSet = new ExzPTM.PPMDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.podrTableAdapter = new ExzPTM.PPMDataSetTableAdapters.podrTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPodr = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSearche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPodr
            // 
            this.dgPodr.AllowUserToAddRows = false;
            this.dgPodr.AllowUserToDeleteRows = false;
            this.dgPodr.AutoGenerateColumns = false;
            this.dgPodr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgPodr.DataSource = this.podrBindingSource;
            this.dgPodr.Location = new System.Drawing.Point(7, 51);
            this.dgPodr.Name = "dgPodr";
            this.dgPodr.ReadOnly = true;
            this.dgPodr.Size = new System.Drawing.Size(545, 203);
            this.dgPodr.TabIndex = 0;
            this.dgPodr.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPodr_CellEnter);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // podrBindingSource
            // 
            this.podrBindingSource.DataMember = "podr";
            this.podrBindingSource.DataSource = this.pPMDataSet;
            // 
            // pPMDataSet
            // 
            this.pPMDataSet.DataSetName = "PPMDataSet";
            this.pPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // podrTableAdapter
            // 
            this.podrTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPodr);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbSearche);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgPodr);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbPodr
            // 
            this.tbPodr.Location = new System.Drawing.Point(7, 275);
            this.tbPodr.Name = "tbPodr";
            this.tbPodr.Size = new System.Drawing.Size(156, 20);
            this.tbPodr.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSearche
            // 
            this.tbSearche.Location = new System.Drawing.Point(7, 20);
            this.tbSearche.Name = "tbSearche";
            this.tbSearche.Size = new System.Drawing.Size(100, 20);
            this.tbSearche.TabIndex = 1;
            this.tbSearche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск";
            // 
            // Podr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 369);
            this.Controls.Add(this.groupBox1);
            this.Name = "Podr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.Podr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPodr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPodr;
        private System.Windows.Forms.Button button1;
        private PPMDataSet pPMDataSet;
        private System.Windows.Forms.BindingSource podrBindingSource;
        private PPMDataSetTableAdapters.podrTableAdapter podrTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSearche;
        private System.Windows.Forms.TextBox tbPodr;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label1;
    }
}