namespace VetClinic
{
    partial class Main
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
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbDescriptionTreatment = new System.Windows.Forms.ComboBox();
            this.cbVetTreatment = new System.Windows.Forms.ComboBox();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.cbPetTreatment = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dtpDateAppointment = new System.Windows.Forms.DateTimePicker();
            this.cbTreatmentAppointment = new System.Windows.Forms.ComboBox();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.cbPetAppointment = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.cbPersonPerson = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.cbPetPet = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPetKind = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAppointmentsByVet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowAppointmentsByPet = new System.Windows.Forms.Button();
            this.btnShowPetsOfOwner = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTableSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnShowAppointments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShowVets = new System.Windows.Forms.Button();
            this.btnShowOwners = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowDogs = new System.Windows.Forms.Button();
            this.btnShowHamsters = new System.Windows.Forms.Button();
            this.btnShowCats = new System.Windows.Forms.Button();
            this.btnShowGoldfisshes = new System.Windows.Forms.Button();
            this.gvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbDelete);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.groupBox12);
            this.gbDelete.Controls.Add(this.groupBox11);
            this.gbDelete.Controls.Add(this.groupBox10);
            this.gbDelete.Controls.Add(this.groupBox9);
            this.gbDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDelete.Location = new System.Drawing.Point(203, 16);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(708, 136);
            this.gbDelete.TabIndex = 3;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Видалити";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbDescriptionTreatment);
            this.groupBox12.Controls.Add(this.cbVetTreatment);
            this.groupBox12.Controls.Add(this.btnDeleteTreatment);
            this.groupBox12.Controls.Add(this.cbPetTreatment);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.Location = new System.Drawing.Point(512, 16);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(171, 117);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Treatment";
            // 
            // cbDescriptionTreatment
            // 
            this.cbDescriptionTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDescriptionTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescriptionTreatment.FormattingEnabled = true;
            this.cbDescriptionTreatment.Location = new System.Drawing.Point(3, 58);
            this.cbDescriptionTreatment.Name = "cbDescriptionTreatment";
            this.cbDescriptionTreatment.Size = new System.Drawing.Size(165, 21);
            this.cbDescriptionTreatment.TabIndex = 5;
            // 
            // cbVetTreatment
            // 
            this.cbVetTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVetTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVetTreatment.FormattingEnabled = true;
            this.cbVetTreatment.Location = new System.Drawing.Point(3, 37);
            this.cbVetTreatment.Name = "cbVetTreatment";
            this.cbVetTreatment.Size = new System.Drawing.Size(165, 21);
            this.cbVetTreatment.TabIndex = 4;
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteTreatment.Location = new System.Drawing.Point(3, 91);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(165, 23);
            this.btnDeleteTreatment.TabIndex = 3;
            this.btnDeleteTreatment.Text = "Видалити";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // cbPetTreatment
            // 
            this.cbPetTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPetTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPetTreatment.FormattingEnabled = true;
            this.cbPetTreatment.Location = new System.Drawing.Point(3, 16);
            this.cbPetTreatment.Name = "cbPetTreatment";
            this.cbPetTreatment.Size = new System.Drawing.Size(165, 21);
            this.cbPetTreatment.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dtpDateAppointment);
            this.groupBox11.Controls.Add(this.cbTreatmentAppointment);
            this.groupBox11.Controls.Add(this.btnDeleteAppointment);
            this.groupBox11.Controls.Add(this.cbPetAppointment);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox11.Location = new System.Drawing.Point(299, 16);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(213, 117);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Appointment";
            // 
            // dtpDateAppointment
            // 
            this.dtpDateAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDateAppointment.Location = new System.Drawing.Point(3, 58);
            this.dtpDateAppointment.Name = "dtpDateAppointment";
            this.dtpDateAppointment.Size = new System.Drawing.Size(207, 20);
            this.dtpDateAppointment.TabIndex = 5;
            // 
            // cbTreatmentAppointment
            // 
            this.cbTreatmentAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTreatmentAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTreatmentAppointment.FormattingEnabled = true;
            this.cbTreatmentAppointment.Location = new System.Drawing.Point(3, 37);
            this.cbTreatmentAppointment.Name = "cbTreatmentAppointment";
            this.cbTreatmentAppointment.Size = new System.Drawing.Size(207, 21);
            this.cbTreatmentAppointment.TabIndex = 4;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(3, 91);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(207, 23);
            this.btnDeleteAppointment.TabIndex = 3;
            this.btnDeleteAppointment.Text = "Видалити";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // cbPetAppointment
            // 
            this.cbPetAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPetAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPetAppointment.FormattingEnabled = true;
            this.cbPetAppointment.Location = new System.Drawing.Point(3, 16);
            this.cbPetAppointment.Name = "cbPetAppointment";
            this.cbPetAppointment.Size = new System.Drawing.Size(207, 21);
            this.cbPetAppointment.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnDeletePerson);
            this.groupBox10.Controls.Add(this.cbPersonPerson);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox10.Location = new System.Drawing.Point(151, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(148, 117);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Person";
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeletePerson.Location = new System.Drawing.Point(3, 91);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(142, 23);
            this.btnDeletePerson.TabIndex = 3;
            this.btnDeletePerson.Text = "Видалити";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // cbPersonPerson
            // 
            this.cbPersonPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPersonPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonPerson.FormattingEnabled = true;
            this.cbPersonPerson.Location = new System.Drawing.Point(3, 16);
            this.cbPersonPerson.Name = "cbPersonPerson";
            this.cbPersonPerson.Size = new System.Drawing.Size(142, 21);
            this.cbPersonPerson.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnDeletePet);
            this.groupBox9.Controls.Add(this.cbPetPet);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox9.Location = new System.Drawing.Point(3, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(148, 117);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pet";
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeletePet.Location = new System.Drawing.Point(3, 91);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(142, 23);
            this.btnDeletePet.TabIndex = 3;
            this.btnDeletePet.Text = "Видалити";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // cbPetPet
            // 
            this.cbPetPet.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPetPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPetPet.FormattingEnabled = true;
            this.cbPetPet.Location = new System.Drawing.Point(3, 16);
            this.cbPetPet.Name = "cbPetPet";
            this.cbPetPet.Size = new System.Drawing.Size(142, 21);
            this.cbPetPet.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel4);
            this.groupBox8.Controls.Add(this.btnShowAppointmentsByVet);
            this.groupBox8.Controls.Add(this.panel3);
            this.groupBox8.Controls.Add(this.btnShowAppointmentsByPet);
            this.groupBox8.Controls.Add(this.btnShowPetsOfOwner);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox8.Location = new System.Drawing.Point(914, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(236, 136);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Вибірка даних";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbPetKind);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 23);
            this.panel4.TabIndex = 4;
            // 
            // tbPetKind
            // 
            this.tbPetKind.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPetKind.FormattingEnabled = true;
            this.tbPetKind.Items.AddRange(new object[] {
            "Рибка",
            "Кіт",
            "Хом\'як",
            "Собака"});
            this.tbPetKind.Location = new System.Drawing.Point(71, 0);
            this.tbPetKind.Name = "tbPetKind";
            this.tbPetKind.Size = new System.Drawing.Size(159, 21);
            this.tbPetKind.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тип тварини";
            // 
            // btnShowAppointmentsByVet
            // 
            this.btnShowAppointmentsByVet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowAppointmentsByVet.Location = new System.Drawing.Point(3, 64);
            this.btnShowAppointmentsByVet.Name = "btnShowAppointmentsByVet";
            this.btnShowAppointmentsByVet.Size = new System.Drawing.Size(230, 23);
            this.btnShowAppointmentsByVet.TabIndex = 2;
            this.btnShowAppointmentsByVet.Text = "Показати всі записи за лікарем";
            this.btnShowAppointmentsByVet.UseVisualStyleBackColor = true;
            this.btnShowAppointmentsByVet.Click += new System.EventHandler(this.btnShowAppointmentsByVet_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 23);
            this.panel3.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbName.Location = new System.Drawing.Point(71, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 20);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ім\'я";
            // 
            // btnShowAppointmentsByPet
            // 
            this.btnShowAppointmentsByPet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowAppointmentsByPet.Location = new System.Drawing.Point(3, 87);
            this.btnShowAppointmentsByPet.Name = "btnShowAppointmentsByPet";
            this.btnShowAppointmentsByPet.Size = new System.Drawing.Size(230, 23);
            this.btnShowAppointmentsByPet.TabIndex = 1;
            this.btnShowAppointmentsByPet.Text = "Показати всіх записи певної тварини";
            this.btnShowAppointmentsByPet.UseVisualStyleBackColor = true;
            this.btnShowAppointmentsByPet.Click += new System.EventHandler(this.btnShowAppointmentsByPet_Click);
            // 
            // btnShowPetsOfOwner
            // 
            this.btnShowPetsOfOwner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowPetsOfOwner.Location = new System.Drawing.Point(3, 110);
            this.btnShowPetsOfOwner.Name = "btnShowPetsOfOwner";
            this.btnShowPetsOfOwner.Size = new System.Drawing.Size(230, 23);
            this.btnShowPetsOfOwner.TabIndex = 0;
            this.btnShowPetsOfOwner.Text = "Показати всіх тварин власника";
            this.btnShowPetsOfOwner.UseVisualStyleBackColor = true;
            this.btnShowPetsOfOwner.Click += new System.EventHandler(this.btnShowPetsOfOwner_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAdd);
            this.groupBox6.Controls.Add(this.cbTableSelect);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(3, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 136);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Додати данні";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(3, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTableSelect
            // 
            this.cbTableSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableSelect.FormattingEnabled = true;
            this.cbTableSelect.Items.AddRange(new object[] {
            "Рибка",
            "Кіт",
            "Хом\'як",
            "Собака",
            "Власник",
            "Ветеринар",
            "Запис",
            "Лікування"});
            this.cbTableSelect.Location = new System.Drawing.Point(3, 16);
            this.cbTableSelect.Name = "cbTableSelect";
            this.cbTableSelect.Size = new System.Drawing.Size(194, 21);
            this.cbTableSelect.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показати Дані";
            // 
            // groupBox5
            // 
            this.groupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.groupBox5.Controls.Add(this.btnShowAppointments);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 125);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Записи";
            // 
            // btnShowAppointments
            // 
            this.btnShowAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAppointments.Location = new System.Drawing.Point(3, 66);
            this.btnShowAppointments.Name = "btnShowAppointments";
            this.btnShowAppointments.Size = new System.Drawing.Size(224, 23);
            this.btnShowAppointments.TabIndex = 5;
            this.btnShowAppointments.Text = "Записи в проміжку";
            this.btnShowAppointments.UseVisualStyleBackColor = true;
            this.btnShowAppointments.Click += new System.EventHandler(this.btnShowAppointments_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 25);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // dtpTo
            // 
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpTo.Location = new System.Drawing.Point(24, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 25);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Від";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpFrom.Location = new System.Drawing.Point(24, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShowVets);
            this.groupBox4.Controls.Add(this.btnShowOwners);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Люди";
            // 
            // btnShowVets
            // 
            this.btnShowVets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowVets.Location = new System.Drawing.Point(3, 39);
            this.btnShowVets.Name = "btnShowVets";
            this.btnShowVets.Size = new System.Drawing.Size(224, 23);
            this.btnShowVets.TabIndex = 1;
            this.btnShowVets.Text = "Ветеринари";
            this.btnShowVets.UseVisualStyleBackColor = true;
            this.btnShowVets.Click += new System.EventHandler(this.btnShowVets_Click);
            // 
            // btnShowOwners
            // 
            this.btnShowOwners.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowOwners.Location = new System.Drawing.Point(3, 16);
            this.btnShowOwners.Name = "btnShowOwners";
            this.btnShowOwners.Size = new System.Drawing.Size(224, 23);
            this.btnShowOwners.TabIndex = 0;
            this.btnShowOwners.Text = "Власники";
            this.btnShowOwners.UseVisualStyleBackColor = true;
            this.btnShowOwners.Click += new System.EventHandler(this.btnShowOwners_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowDogs);
            this.groupBox3.Controls.Add(this.btnShowHamsters);
            this.groupBox3.Controls.Add(this.btnShowCats);
            this.groupBox3.Controls.Add(this.btnShowGoldfisshes);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тварини";
            // 
            // btnShowDogs
            // 
            this.btnShowDogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowDogs.Location = new System.Drawing.Point(3, 85);
            this.btnShowDogs.Name = "btnShowDogs";
            this.btnShowDogs.Size = new System.Drawing.Size(224, 23);
            this.btnShowDogs.TabIndex = 0;
            this.btnShowDogs.Text = "Собаки";
            this.btnShowDogs.UseVisualStyleBackColor = true;
            this.btnShowDogs.Click += new System.EventHandler(this.btnShowDogs_Click);
            // 
            // btnShowHamsters
            // 
            this.btnShowHamsters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowHamsters.Location = new System.Drawing.Point(3, 62);
            this.btnShowHamsters.Name = "btnShowHamsters";
            this.btnShowHamsters.Size = new System.Drawing.Size(224, 23);
            this.btnShowHamsters.TabIndex = 3;
            this.btnShowHamsters.Text = "Хом\'яки";
            this.btnShowHamsters.UseVisualStyleBackColor = true;
            this.btnShowHamsters.Click += new System.EventHandler(this.btnShowHamsters_Click);
            // 
            // btnShowCats
            // 
            this.btnShowCats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCats.Location = new System.Drawing.Point(3, 39);
            this.btnShowCats.Name = "btnShowCats";
            this.btnShowCats.Size = new System.Drawing.Size(224, 23);
            this.btnShowCats.TabIndex = 1;
            this.btnShowCats.Text = "Коти";
            this.btnShowCats.UseVisualStyleBackColor = true;
            this.btnShowCats.Click += new System.EventHandler(this.btnShowCats_Click);
            // 
            // btnShowGoldfisshes
            // 
            this.btnShowGoldfisshes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowGoldfisshes.Location = new System.Drawing.Point(3, 16);
            this.btnShowGoldfisshes.Name = "btnShowGoldfisshes";
            this.btnShowGoldfisshes.Size = new System.Drawing.Size(224, 23);
            this.btnShowGoldfisshes.TabIndex = 2;
            this.btnShowGoldfisshes.Text = "Рибки";
            this.btnShowGoldfisshes.UseVisualStyleBackColor = true;
            this.btnShowGoldfisshes.Click += new System.EventHandler(this.btnShowGoldfisshes_Click);
            // 
            // gvMain
            // 
            this.gvMain.AllowUserToAddRows = false;
            this.gvMain.AllowUserToDeleteRows = false;
            this.gvMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain.Location = new System.Drawing.Point(236, 155);
            this.gvMain.Name = "gvMain";
            this.gvMain.ReadOnly = true;
            this.gvMain.Size = new System.Drawing.Size(917, 353);
            this.gvMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 508);
            this.Controls.Add(this.gvMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Ветеринарна клініка";
            this.groupBox1.ResumeLayout(false);
            this.gbDelete.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowHamsters;
        private System.Windows.Forms.Button btnShowGoldfisshes;
        private System.Windows.Forms.Button btnShowCats;
        private System.Windows.Forms.Button btnShowDogs;
        private System.Windows.Forms.DataGridView gvMain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShowVets;
        private System.Windows.Forms.Button btnShowOwners;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTableSelect;
        private System.Windows.Forms.Button btnShowAppointmentsByVet;
        private System.Windows.Forms.Button btnShowAppointmentsByPet;
        private System.Windows.Forms.Button btnShowPetsOfOwner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox tbPetKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.ComboBox cbPetTreatment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.ComboBox cbPetAppointment;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.ComboBox cbPersonPerson;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.ComboBox cbPetPet;
        private System.Windows.Forms.ComboBox cbTreatmentAppointment;
        private System.Windows.Forms.DateTimePicker dtpDateAppointment;
        private System.Windows.Forms.ComboBox cbDescriptionTreatment;
        private System.Windows.Forms.ComboBox cbVetTreatment;
    }
}

