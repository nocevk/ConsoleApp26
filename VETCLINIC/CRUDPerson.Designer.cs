namespace VetClinic
{
    partial class CRUDPerson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbOwner = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCertifiedOwner1 = new System.Windows.Forms.ComboBox();
            this.cbCertifiedOwner2 = new System.Windows.Forms.ComboBox();
            this.cbCertifiedOwner3 = new System.Windows.Forms.ComboBox();
            this.gbVet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbCertifiedHamster = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedDog = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedGoldfish = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedCat = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedCheckup = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedPreventive = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedSurgery = new System.Windows.Forms.CheckBox();
            this.chkbCertifiedMedical = new System.Windows.Forms.CheckBox();
            this.dtpEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbOwner.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbVet.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(372, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(567, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpBirthDay, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ім\'я";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Прізвище";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата народження";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(111, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(255, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(111, 37);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(255, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(111, 78);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(255, 20);
            this.dtpBirthDay.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbOwner);
            this.groupBox2.Controls.Add(this.gbVet);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткова інформація";
            // 
            // gbOwner
            // 
            this.gbOwner.Controls.Add(this.tableLayoutPanel3);
            this.gbOwner.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOwner.Location = new System.Drawing.Point(387, 16);
            this.gbOwner.Name = "gbOwner";
            this.gbOwner.Size = new System.Drawing.Size(310, 201);
            this.gbOwner.TabIndex = 1;
            this.gbOwner.TabStop = false;
            this.gbOwner.Text = "Власник";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbCertifiedOwner1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbCertifiedOwner2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbCertifiedOwner3, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(304, 131);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Довірений власник 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Довірений власник 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Довірений власник 3";
            // 
            // cbCertifiedOwner1
            // 
            this.cbCertifiedOwner1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertifiedOwner1.FormattingEnabled = true;
            this.cbCertifiedOwner1.Location = new System.Drawing.Point(155, 3);
            this.cbCertifiedOwner1.Name = "cbCertifiedOwner1";
            this.cbCertifiedOwner1.Size = new System.Drawing.Size(146, 21);
            this.cbCertifiedOwner1.TabIndex = 3;
            // 
            // cbCertifiedOwner2
            // 
            this.cbCertifiedOwner2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertifiedOwner2.FormattingEnabled = true;
            this.cbCertifiedOwner2.Location = new System.Drawing.Point(155, 30);
            this.cbCertifiedOwner2.Name = "cbCertifiedOwner2";
            this.cbCertifiedOwner2.Size = new System.Drawing.Size(146, 21);
            this.cbCertifiedOwner2.TabIndex = 4;
            // 
            // cbCertifiedOwner3
            // 
            this.cbCertifiedOwner3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertifiedOwner3.FormattingEnabled = true;
            this.cbCertifiedOwner3.Location = new System.Drawing.Point(155, 56);
            this.cbCertifiedOwner3.Name = "cbCertifiedOwner3";
            this.cbCertifiedOwner3.Size = new System.Drawing.Size(146, 21);
            this.cbCertifiedOwner3.TabIndex = 5;
            // 
            // gbVet
            // 
            this.gbVet.Controls.Add(this.tableLayoutPanel2);
            this.gbVet.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbVet.Location = new System.Drawing.Point(3, 16);
            this.gbVet.Name = "gbVet";
            this.gbVet.Size = new System.Drawing.Size(384, 201);
            this.gbVet.TabIndex = 0;
            this.gbVet.TabStop = false;
            this.gbVet.Text = "Ветеринар";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedHamster, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedDog, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedGoldfish, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedCat, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedCheckup, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedPreventive, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedSurgery, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.chkbCertifiedMedical, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.dtpEmploymentDate, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.32258F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.67742F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 182);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кваліфікований до тварин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кваліфікований до процедур";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата працевлаштування";
            // 
            // chkbCertifiedHamster
            // 
            this.chkbCertifiedHamster.AutoSize = true;
            this.chkbCertifiedHamster.Location = new System.Drawing.Point(3, 22);
            this.chkbCertifiedHamster.Name = "chkbCertifiedHamster";
            this.chkbCertifiedHamster.Size = new System.Drawing.Size(61, 17);
            this.chkbCertifiedHamster.TabIndex = 4;
            this.chkbCertifiedHamster.Text = "Хом\'як";
            this.chkbCertifiedHamster.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedDog
            // 
            this.chkbCertifiedDog.AutoSize = true;
            this.chkbCertifiedDog.Location = new System.Drawing.Point(190, 22);
            this.chkbCertifiedDog.Name = "chkbCertifiedDog";
            this.chkbCertifiedDog.Size = new System.Drawing.Size(63, 17);
            this.chkbCertifiedDog.TabIndex = 5;
            this.chkbCertifiedDog.Text = "Собака";
            this.chkbCertifiedDog.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedGoldfish
            // 
            this.chkbCertifiedGoldfish.AutoSize = true;
            this.chkbCertifiedGoldfish.Location = new System.Drawing.Point(3, 50);
            this.chkbCertifiedGoldfish.Name = "chkbCertifiedGoldfish";
            this.chkbCertifiedGoldfish.Size = new System.Drawing.Size(95, 17);
            this.chkbCertifiedGoldfish.TabIndex = 6;
            this.chkbCertifiedGoldfish.Text = "Золота рибка";
            this.chkbCertifiedGoldfish.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedCat
            // 
            this.chkbCertifiedCat.AutoSize = true;
            this.chkbCertifiedCat.Location = new System.Drawing.Point(190, 50);
            this.chkbCertifiedCat.Name = "chkbCertifiedCat";
            this.chkbCertifiedCat.Size = new System.Drawing.Size(40, 17);
            this.chkbCertifiedCat.TabIndex = 7;
            this.chkbCertifiedCat.Text = "Кіт";
            this.chkbCertifiedCat.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedCheckup
            // 
            this.chkbCertifiedCheckup.AutoSize = true;
            this.chkbCertifiedCheckup.Location = new System.Drawing.Point(3, 102);
            this.chkbCertifiedCheckup.Name = "chkbCertifiedCheckup";
            this.chkbCertifiedCheckup.Size = new System.Drawing.Size(57, 17);
            this.chkbCertifiedCheckup.TabIndex = 8;
            this.chkbCertifiedCheckup.Text = "Огляд";
            this.chkbCertifiedCheckup.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedPreventive
            // 
            this.chkbCertifiedPreventive.AutoSize = true;
            this.chkbCertifiedPreventive.Location = new System.Drawing.Point(190, 102);
            this.chkbCertifiedPreventive.Name = "chkbCertifiedPreventive";
            this.chkbCertifiedPreventive.Size = new System.Drawing.Size(69, 17);
            this.chkbCertifiedPreventive.TabIndex = 9;
            this.chkbCertifiedPreventive.Text = "Вакцина";
            this.chkbCertifiedPreventive.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedSurgery
            // 
            this.chkbCertifiedSurgery.AutoSize = true;
            this.chkbCertifiedSurgery.Location = new System.Drawing.Point(3, 128);
            this.chkbCertifiedSurgery.Name = "chkbCertifiedSurgery";
            this.chkbCertifiedSurgery.Size = new System.Drawing.Size(72, 17);
            this.chkbCertifiedSurgery.TabIndex = 10;
            this.chkbCertifiedSurgery.Text = "Операція";
            this.chkbCertifiedSurgery.UseVisualStyleBackColor = true;
            // 
            // chkbCertifiedMedical
            // 
            this.chkbCertifiedMedical.AutoSize = true;
            this.chkbCertifiedMedical.Location = new System.Drawing.Point(190, 128);
            this.chkbCertifiedMedical.Name = "chkbCertifiedMedical";
            this.chkbCertifiedMedical.Size = new System.Drawing.Size(97, 17);
            this.chkbCertifiedMedical.TabIndex = 11;
            this.chkbCertifiedMedical.Text = "Виписати ліки";
            this.chkbCertifiedMedical.UseVisualStyleBackColor = true;
            // 
            // dtpEmploymentDate
            // 
            this.dtpEmploymentDate.Location = new System.Drawing.Point(190, 155);
            this.dtpEmploymentDate.Name = "dtpEmploymentDate";
            this.dtpEmploymentDate.Size = new System.Drawing.Size(182, 20);
            this.dtpEmploymentDate.TabIndex = 12;
            // 
            // CRUDPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CRUDPerson";
            this.Text = "Керування людьми";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbOwner.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbVet.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbOwner;
        private System.Windows.Forms.GroupBox gbVet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCertifiedOwner1;
        private System.Windows.Forms.ComboBox cbCertifiedOwner2;
        private System.Windows.Forms.ComboBox cbCertifiedOwner3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbCertifiedHamster;
        private System.Windows.Forms.CheckBox chkbCertifiedDog;
        private System.Windows.Forms.CheckBox chkbCertifiedGoldfish;
        private System.Windows.Forms.CheckBox chkbCertifiedCat;
        private System.Windows.Forms.CheckBox chkbCertifiedCheckup;
        private System.Windows.Forms.CheckBox chkbCertifiedPreventive;
        private System.Windows.Forms.CheckBox chkbCertifiedSurgery;
        private System.Windows.Forms.CheckBox chkbCertifiedMedical;
        private System.Windows.Forms.DateTimePicker dtpEmploymentDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
    }
}