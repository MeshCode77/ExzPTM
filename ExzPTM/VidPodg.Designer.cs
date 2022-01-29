
namespace ExzPTM
{
    partial class VidPodg
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
            this.dgVidPodg = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepodgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPMDataSet = new ExzPTM.PPMDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.typepodgTableAdapter = new ExzPTM.PPMDataSetTableAdapters.typepodgTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbVidPodg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDateExp = new System.Windows.Forms.TextBox();
            this.tbSearche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVidPodg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVidPodg
            // 
            this.dgVidPodg.AllowUserToAddRows = false;
            this.dgVidPodg.AllowUserToDeleteRows = false;
            this.dgVidPodg.AutoGenerateColumns = false;
            this.dgVidPodg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVidPodg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.name,
            this.expdate});
            this.dgVidPodg.DataSource = this.typepodgBindingSource;
            this.dgVidPodg.Location = new System.Drawing.Point(6, 19);
            this.dgVidPodg.Name = "dgVidPodg";
            this.dgVidPodg.ReadOnly = true;
            this.dgVidPodg.Size = new System.Drawing.Size(515, 242);
            this.dgVidPodg.TabIndex = 0;
            this.dgVidPodg.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVidPodg_CellEnter);
            // 
            // id1
            // 
            this.id1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "id";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Width = 40;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Вид подготовки";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // expdate
            // 
            this.expdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expdate.DataPropertyName = "expdate";
            this.expdate.HeaderText = "Срок действия  (месяцы)";
            this.expdate.Name = "expdate";
            this.expdate.ReadOnly = true;
            // 
            // typepodgBindingSource
            // 
            this.typepodgBindingSource.DataMember = "typepodg";
            this.typepodgBindingSource.DataSource = this.pPMDataSet;
            // 
            // pPMDataSet
            // 
            this.pPMDataSet.DataSetName = "PPMDataSet";
            this.pPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typepodgTableAdapter
            // 
            this.typepodgTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить ВП";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить ВП";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Редактирова ВП";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить ВП";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbVidPodg
            // 
            this.tbVidPodg.Location = new System.Drawing.Point(12, 288);
            this.tbVidPodg.Name = "tbVidPodg";
            this.tbVidPodg.Size = new System.Drawing.Size(185, 20);
            this.tbVidPodg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вид подготовки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Срок действия";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDateExp);
            this.groupBox1.Controls.Add(this.dgVidPodg);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tbVidPodg);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 359);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tbDateExp
            // 
            this.tbDateExp.Location = new System.Drawing.Point(217, 289);
            this.tbDateExp.Name = "tbDateExp";
            this.tbDateExp.Size = new System.Drawing.Size(100, 20);
            this.tbDateExp.TabIndex = 11;
            // 
            // tbSearche
            // 
            this.tbSearche.Location = new System.Drawing.Point(12, 23);
            this.tbSearche.Name = "tbSearche";
            this.tbSearche.Size = new System.Drawing.Size(100, 20);
            this.tbSearche.TabIndex = 12;
            this.tbSearche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Поиск";
            // 
            // VidPodg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSearche);
            this.Controls.Add(this.groupBox1);
            this.Name = "VidPodg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виды подготовки";
            this.Load += new System.EventHandler(this.VidPodg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVidPodg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepodgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPMDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVidPodg;
        private System.Windows.Forms.Button button1;
        private PPMDataSet pPMDataSet;
        private System.Windows.Forms.BindingSource typepodgBindingSource;
        private PPMDataSetTableAdapters.typepodgTableAdapter typepodgTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbVidPodg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearche;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn expdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDateExp;
    }
}