﻿namespace eGym.UI.Desktop
{
    partial class frmEditDiet
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 545);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 36);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Items.AddRange(new object[] {
            "Dorucak",
            "Rucak",
            "Vecera"});
            this.cmbMeal.Location = new System.Drawing.Point(126, 245);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(320, 28);
            this.cmbMeal.TabIndex = 57;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Nedjelja",
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Cetvrtak",
            "Petak",
            "Subota"});
            this.cmbDay.Location = new System.Drawing.Point(126, 189);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(320, 28);
            this.cmbDay.TabIndex = 56;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(126, 318);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(320, 197);
            this.rtxtDescription.TabIndex = 54;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescription_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 128);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(320, 27);
            this.txtName.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Obrok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Dan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Plan ishrane";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // frmEditDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 592);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbMeal);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmEditDiet";
            this.Text = "Edit Dijete";
            this.Load += new System.EventHandler(this.frmEditDiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private ComboBox cmbMeal;
        private ComboBox cmbDay;
        private Button btnSave;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider errorProviderApp;
    }
}