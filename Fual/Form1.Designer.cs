namespace Fual
{
    partial class Form1
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
            this.txtDrivername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicalno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoliter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDiesel = new System.Windows.Forms.RadioButton();
            this.rdPetrol95 = new System.Windows.Forms.RadioButton();
            this.rdPetrol92 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPriceofliter = new System.Windows.Forms.Label();
            this.lblAmounttopay = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLiter = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDrivername
            // 
            this.txtDrivername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrivername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDrivername.Location = new System.Drawing.Point(240, 32);
            this.txtDrivername.Margin = new System.Windows.Forms.Padding(2);
            this.txtDrivername.Name = "txtDrivername";
            this.txtDrivername.Size = new System.Drawing.Size(194, 23);
            this.txtDrivername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehical No";
            // 
            // txtVehicalno
            // 
            this.txtVehicalno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicalno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVehicalno.Location = new System.Drawing.Point(240, 67);
            this.txtVehicalno.Margin = new System.Windows.Forms.Padding(2);
            this.txtVehicalno.Name = "txtVehicalno";
            this.txtVehicalno.Size = new System.Drawing.Size(154, 23);
            this.txtVehicalno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "No of Liters of Required";
            // 
            // txtNoliter
            // 
            this.txtNoliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoliter.Location = new System.Drawing.Point(240, 108);
            this.txtNoliter.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoliter.Name = "txtNoliter";
            this.txtNoliter.Size = new System.Drawing.Size(154, 23);
            this.txtNoliter.TabIndex = 4;
            this.txtNoliter.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDiesel);
            this.groupBox1.Controls.Add(this.rdPetrol95);
            this.groupBox1.Controls.Add(this.rdPetrol92);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(423, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fual Type Details";
            // 
            // rdDiesel
            // 
            this.rdDiesel.AutoSize = true;
            this.rdDiesel.Location = new System.Drawing.Point(221, 96);
            this.rdDiesel.Margin = new System.Windows.Forms.Padding(2);
            this.rdDiesel.Name = "rdDiesel";
            this.rdDiesel.Size = new System.Drawing.Size(71, 21);
            this.rdDiesel.TabIndex = 10;
            this.rdDiesel.TabStop = true;
            this.rdDiesel.Text = "Diesel";
            this.rdDiesel.UseVisualStyleBackColor = true;
            // 
            // rdPetrol95
            // 
            this.rdPetrol95.AutoSize = true;
            this.rdPetrol95.Location = new System.Drawing.Point(221, 61);
            this.rdPetrol95.Margin = new System.Windows.Forms.Padding(2);
            this.rdPetrol95.Name = "rdPetrol95";
            this.rdPetrol95.Size = new System.Drawing.Size(92, 21);
            this.rdPetrol95.TabIndex = 9;
            this.rdPetrol95.TabStop = true;
            this.rdPetrol95.Text = "Petrol 95";
            this.rdPetrol95.UseVisualStyleBackColor = true;
            // 
            // rdPetrol92
            // 
            this.rdPetrol92.AutoSize = true;
            this.rdPetrol92.Location = new System.Drawing.Point(221, 21);
            this.rdPetrol92.Margin = new System.Windows.Forms.Padding(2);
            this.rdPetrol92.Name = "rdPetrol92";
            this.rdPetrol92.Size = new System.Drawing.Size(92, 21);
            this.rdPetrol92.TabIndex = 8;
            this.rdPetrol92.TabStop = true;
            this.rdPetrol92.Text = "Petrol 92";
            this.rdPetrol92.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Fual Type";
            // 
            // lblPriceofliter
            // 
            this.lblPriceofliter.AutoSize = true;
            this.lblPriceofliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceofliter.Location = new System.Drawing.Point(43, 301);
            this.lblPriceofliter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceofliter.Name = "lblPriceofliter";
            this.lblPriceofliter.Size = new System.Drawing.Size(100, 17);
            this.lblPriceofliter.TabIndex = 7;
            this.lblPriceofliter.Text = "Price of a Liter";
            this.lblPriceofliter.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAmounttopay
            // 
            this.lblAmounttopay.AutoSize = true;
            this.lblAmounttopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmounttopay.Location = new System.Drawing.Point(43, 336);
            this.lblAmounttopay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmounttopay.Name = "lblAmounttopay";
            this.lblAmounttopay.Size = new System.Drawing.Size(100, 17);
            this.lblAmounttopay.TabIndex = 8;
            this.lblAmounttopay.Text = "Amount to Pay";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(309, 360);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(424, 360);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLiter
            // 
            this.lblLiter.AutoSize = true;
            this.lblLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiter.Location = new System.Drawing.Point(237, 301);
            this.lblLiter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(0, 17);
            this.lblLiter.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(237, 336);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 17);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 420);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblLiter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAmounttopay);
            this.Controls.Add(this.lblPriceofliter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoliter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehicalno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrivername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fual Allocation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrivername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicalno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoliter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDiesel;
        private System.Windows.Forms.RadioButton rdPetrol95;
        private System.Windows.Forms.RadioButton rdPetrol92;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPriceofliter;
        private System.Windows.Forms.Label lblAmounttopay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLiter;
        private System.Windows.Forms.Label lblAmount;
    }
}

