namespace Devoir_SLAM
{
    partial class View
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.radioAbsences = new System.Windows.Forms.RadioButton();
            this.radioPersonnel = new System.Windows.Forms.RadioButton();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.listTables = new System.Windows.Forms.ListBox();
            this.addPersonelBox = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grpbAbsence = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPersA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDateF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDateD = new System.Windows.Forms.TextBox();
            this.btnShowAb = new System.Windows.Forms.Button();
            this.btnShowPers = new System.Windows.Forms.Button();
            this.grpData.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.addPersonelBox.SuspendLayout();
            this.grpbAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnSupprimer);
            this.grpData.Controls.Add(this.btnModifier);
            this.grpData.Controls.Add(this.btnAjouter);
            this.grpData.Controls.Add(this.radioAbsences);
            this.grpData.Controls.Add(this.radioPersonnel);
            this.grpData.Location = new System.Drawing.Point(213, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(236, 110);
            this.grpData.TabIndex = 0;
            this.grpData.TabStop = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(142, 76);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(142, 47);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(142, 18);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // radioAbsences
            // 
            this.radioAbsences.AutoSize = true;
            this.radioAbsences.Location = new System.Drawing.Point(30, 60);
            this.radioAbsences.Name = "radioAbsences";
            this.radioAbsences.Size = new System.Drawing.Size(72, 17);
            this.radioAbsences.TabIndex = 1;
            this.radioAbsences.TabStop = true;
            this.radioAbsences.Text = "Absences";
            this.radioAbsences.UseVisualStyleBackColor = true;
            this.radioAbsences.CheckedChanged += new System.EventHandler(this.radioAbsences_CheckedChanged);
            // 
            // radioPersonnel
            // 
            this.radioPersonnel.AutoSize = true;
            this.radioPersonnel.Location = new System.Drawing.Point(30, 31);
            this.radioPersonnel.Name = "radioPersonnel";
            this.radioPersonnel.Size = new System.Drawing.Size(72, 17);
            this.radioPersonnel.TabIndex = 0;
            this.radioPersonnel.TabStop = true;
            this.radioPersonnel.Text = "Personnel";
            this.radioPersonnel.UseVisualStyleBackColor = true;
            this.radioPersonnel.CheckedChanged += new System.EventHandler(this.radioPersonnel_CheckedChanged);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtbPassword);
            this.grpLogin.Controls.Add(this.txtbUsername);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(195, 110);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            this.grpLogin.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(103, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(78, 51);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword.TabIndex = 1;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(78, 25);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(100, 20);
            this.txtbUsername.TabIndex = 0;
            // 
            // listTables
            // 
            this.listTables.FormattingEnabled = true;
            this.listTables.Location = new System.Drawing.Point(12, 154);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(437, 173);
            this.listTables.TabIndex = 2;
            // 
            // addPersonelBox
            // 
            this.addPersonelBox.Controls.Add(this.label7);
            this.addPersonelBox.Controls.Add(this.txtMail);
            this.addPersonelBox.Controls.Add(this.label6);
            this.addPersonelBox.Controls.Add(this.txtTel);
            this.addPersonelBox.Controls.Add(this.label5);
            this.addPersonelBox.Controls.Add(this.txtPrenom);
            this.addPersonelBox.Controls.Add(this.label4);
            this.addPersonelBox.Controls.Add(this.txtNom);
            this.addPersonelBox.Controls.Add(this.label3);
            this.addPersonelBox.Controls.Add(this.txtId);
            this.addPersonelBox.Location = new System.Drawing.Point(455, 12);
            this.addPersonelBox.Name = "addPersonelBox";
            this.addPersonelBox.Size = new System.Drawing.Size(181, 159);
            this.addPersonelBox.TabIndex = 3;
            this.addPersonelBox.TabStop = false;
            this.addPersonelBox.Text = "Personnel";
            this.addPersonelBox.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "idpersonnel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(75, 48);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(75, 74);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "tel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(75, 100);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(75, 126);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 12;
            // 
            // grpbAbsence
            // 
            this.grpbAbsence.Controls.Add(this.label10);
            this.grpbAbsence.Controls.Add(this.txtPersA);
            this.grpbAbsence.Controls.Add(this.label11);
            this.grpbAbsence.Controls.Add(this.txtDateF);
            this.grpbAbsence.Controls.Add(this.label12);
            this.grpbAbsence.Controls.Add(this.txtDateD);
            this.grpbAbsence.Location = new System.Drawing.Point(455, 12);
            this.grpbAbsence.Name = "grpbAbsence";
            this.grpbAbsence.Size = new System.Drawing.Size(200, 159);
            this.grpbAbsence.TabIndex = 16;
            this.grpbAbsence.TabStop = false;
            this.grpbAbsence.Text = "Absence";
            this.grpbAbsence.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(485, 177);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(48, 52);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(588, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(48, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(-3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "personne absente";
            // 
            // txtPersA
            // 
            this.txtPersA.Location = new System.Drawing.Point(88, 97);
            this.txtPersA.Name = "txtPersA";
            this.txtPersA.Size = new System.Drawing.Size(100, 20);
            this.txtPersA.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "date de fin";
            // 
            // txtDateF
            // 
            this.txtDateF.Location = new System.Drawing.Point(88, 71);
            this.txtDateF.Name = "txtDateF";
            this.txtDateF.Size = new System.Drawing.Size(100, 20);
            this.txtDateF.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "date de début";
            // 
            // txtDateD
            // 
            this.txtDateD.Location = new System.Drawing.Point(88, 45);
            this.txtDateD.Name = "txtDateD";
            this.txtDateD.Size = new System.Drawing.Size(100, 20);
            this.txtDateD.TabIndex = 0;
            // 
            // btnShowAb
            // 
            this.btnShowAb.Location = new System.Drawing.Point(96, 129);
            this.btnShowAb.Name = "btnShowAb";
            this.btnShowAb.Size = new System.Drawing.Size(75, 23);
            this.btnShowAb.TabIndex = 17;
            this.btnShowAb.Text = "Absences";
            this.btnShowAb.UseVisualStyleBackColor = true;
            this.btnShowAb.Click += new System.EventHandler(this.btnShowAb_Click);
            // 
            // btnShowPers
            // 
            this.btnShowPers.Location = new System.Drawing.Point(15, 129);
            this.btnShowPers.Name = "btnShowPers";
            this.btnShowPers.Size = new System.Drawing.Size(75, 23);
            this.btnShowPers.TabIndex = 18;
            this.btnShowPers.Text = "Personnel";
            this.btnShowPers.UseVisualStyleBackColor = true;
            this.btnShowPers.Click += new System.EventHandler(this.button5_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 338);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShowPers);
            this.Controls.Add(this.btnShowAb);
            this.Controls.Add(this.grpbAbsence);
            this.Controls.Add(this.addPersonelBox);
            this.Controls.Add(this.listTables);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpData);
            this.Name = "View";
            this.Text = "Logiciel";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.addPersonelBox.ResumeLayout(false);
            this.addPersonelBox.PerformLayout();
            this.grpbAbsence.ResumeLayout(false);
            this.grpbAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.RadioButton radioAbsences;
        private System.Windows.Forms.RadioButton radioPersonnel;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.ListBox listTables;
        private System.Windows.Forms.MessageBox message;
        private System.Windows.Forms.GroupBox addPersonelBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grpbAbsence;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPersA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDateF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDateD;
        private System.Windows.Forms.Button btnShowAb;
        private System.Windows.Forms.Button btnShowPers;
    }
}

