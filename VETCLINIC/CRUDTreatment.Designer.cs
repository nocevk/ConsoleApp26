namespace VetClinic
{
    partial class CRUDTreatment
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTreatment = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPet = new System.Windows.Forms.ComboBox();
            this.cbVet = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbPreventive = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNextDoseDue = new System.Windows.Forms.TextBox();
            this.dtpVaccineName = new System.Windows.Forms.DateTimePicker();
            this.gbMedical = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDosage = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbMedicationName = new System.Windows.Forms.TextBox();
            this.gbCheckUp = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProblemDescription = new System.Windows.Forms.TextBox();
            this.gbSurgery = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbAnastezia = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPreventive.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gbMedical.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbCheckUp.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbSurgery.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTreatment);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основні властивості";
            // 
            // cbTreatment
            // 
            this.cbTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTreatment.FormattingEnabled = true;
            this.cbTreatment.Items.AddRange(new object[] {
            "Хірургічне втручання",
            "Огляд",
            "Медичне лікування",
            "Превентимне лікування"});
            this.cbTreatment.Location = new System.Drawing.Point(329, 16);
            this.cbTreatment.Name = "cbTreatment";
            this.cbTreatment.Size = new System.Drawing.Size(169, 21);
            this.cbTreatment.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(329, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.00613F));
            this.tableLayoutPanel1.Controls.Add(this.cbPet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbVet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbPet
            // 
            this.cbPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPet.FormattingEnabled = true;
            this.cbPet.Location = new System.Drawing.Point(91, 3);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(232, 21);
            this.cbPet.TabIndex = 0;
            // 
            // cbVet
            // 
            this.cbVet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVet.FormattingEnabled = true;
            this.cbVet.Location = new System.Drawing.Point(91, 28);
            this.cbVet.Name = "cbVet";
            this.cbVet.Size = new System.Drawing.Size(232, 21);
            this.cbVet.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(91, 57);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(232, 59);
            this.tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тварина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ветеринар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Опис процедури";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbPreventive);
            this.groupBox2.Controls.Add(this.gbMedical);
            this.groupBox2.Controls.Add(this.gbCheckUp);
            this.groupBox2.Controls.Add(this.gbSurgery);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткові властивості";
            // 
            // gbPreventive
            // 
            this.gbPreventive.Controls.Add(this.tableLayoutPanel5);
            this.gbPreventive.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPreventive.Location = new System.Drawing.Point(932, 16);
            this.gbPreventive.Name = "gbPreventive";
            this.gbPreventive.Size = new System.Drawing.Size(328, 137);
            this.gbPreventive.TabIndex = 3;
            this.gbPreventive.TabStop = false;
            this.gbPreventive.Text = "Превентимне лікування";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.41237F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.58763F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbNextDoseDue, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtpVaccineName, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(322, 52);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Назва вакцини";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Дійсна до";
            // 
            // tbNextDoseDue
            // 
            this.tbNextDoseDue.Location = new System.Drawing.Point(100, 3);
            this.tbNextDoseDue.Name = "tbNextDoseDue";
            this.tbNextDoseDue.Size = new System.Drawing.Size(219, 20);
            this.tbNextDoseDue.TabIndex = 2;
            // 
            // dtpVaccineName
            // 
            this.dtpVaccineName.Location = new System.Drawing.Point(100, 29);
            this.dtpVaccineName.Name = "dtpVaccineName";
            this.dtpVaccineName.Size = new System.Drawing.Size(219, 20);
            this.dtpVaccineName.TabIndex = 3;
            // 
            // gbMedical
            // 
            this.gbMedical.Controls.Add(this.tableLayoutPanel4);
            this.gbMedical.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMedical.Location = new System.Drawing.Point(649, 16);
            this.gbMedical.Name = "gbMedical";
            this.gbMedical.Size = new System.Drawing.Size(283, 137);
            this.gbMedical.TabIndex = 2;
            this.gbMedical.TabStop = false;
            this.gbMedical.Text = "Медичне лікування";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.04332F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.95668F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbDosage, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbDuration, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbMedicationName, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(277, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дозування";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Тривалість вживання";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // tbDosage
            // 
            this.tbDosage.Location = new System.Drawing.Point(125, 3);
            this.tbDosage.Name = "tbDosage";
            this.tbDosage.Size = new System.Drawing.Size(149, 20);
            this.tbDosage.TabIndex = 3;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(125, 27);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(149, 20);
            this.tbDuration.TabIndex = 4;
            // 
            // tbMedicationName
            // 
            this.tbMedicationName.Location = new System.Drawing.Point(125, 53);
            this.tbMedicationName.Name = "tbMedicationName";
            this.tbMedicationName.Size = new System.Drawing.Size(149, 20);
            this.tbMedicationName.TabIndex = 5;
            // 
            // gbCheckUp
            // 
            this.gbCheckUp.Controls.Add(this.tableLayoutPanel3);
            this.gbCheckUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCheckUp.Location = new System.Drawing.Point(284, 16);
            this.gbCheckUp.Name = "gbCheckUp";
            this.gbCheckUp.Size = new System.Drawing.Size(365, 137);
            this.gbCheckUp.TabIndex = 1;
            this.gbCheckUp.TabStop = false;
            this.gbCheckUp.Text = "Огляд";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28866F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.71134F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbProblemDescription, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(359, 80);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Опис проблеми";
            // 
            // tbProblemDescription
            // 
            this.tbProblemDescription.Location = new System.Drawing.Point(97, 3);
            this.tbProblemDescription.Multiline = true;
            this.tbProblemDescription.Name = "tbProblemDescription";
            this.tbProblemDescription.Size = new System.Drawing.Size(259, 74);
            this.tbProblemDescription.TabIndex = 1;
            // 
            // gbSurgery
            // 
            this.gbSurgery.Controls.Add(this.tableLayoutPanel2);
            this.gbSurgery.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSurgery.Location = new System.Drawing.Point(3, 16);
            this.gbSurgery.Name = "gbSurgery";
            this.gbSurgery.Size = new System.Drawing.Size(281, 137);
            this.gbSurgery.TabIndex = 0;
            this.gbSurgery.TabStop = false;
            this.gbSurgery.Text = "Хірургічне втручання";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47423F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.52577F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkbAnastezia, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Назва операції";
            // 
            // chkbAnastezia
            // 
            this.chkbAnastezia.AutoSize = true;
            this.chkbAnastezia.Location = new System.Drawing.Point(92, 43);
            this.chkbAnastezia.Name = "chkbAnastezia";
            this.chkbAnastezia.Size = new System.Drawing.Size(123, 17);
            this.chkbAnastezia.TabIndex = 1;
            this.chkbAnastezia.Text = "Потрібна анастезія";
            this.chkbAnastezia.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 2;
            // 
            // CRUDTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CRUDTreatment";
            this.Text = "Керуваггя процедурою";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbPreventive.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.gbMedical.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gbCheckUp.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbSurgery.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbPet;
        private System.Windows.Forms.ComboBox cbVet;
        private System.Windows.Forms.ComboBox cbTreatment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPreventive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNextDoseDue;
        private System.Windows.Forms.GroupBox gbMedical;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDosage;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbMedicationName;
        private System.Windows.Forms.GroupBox gbCheckUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProblemDescription;
        private System.Windows.Forms.GroupBox gbSurgery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbAnastezia;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpVaccineName;
    }
}