namespace Talalkozo
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
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrIdo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(73, 85);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(108, 20);
            this.dtTmPckrDatum.TabIndex = 0;
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrIdo.Location = new System.Drawing.Point(199, 85);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.ShowUpDown = true;
            this.dtTmPckrIdo.Size = new System.Drawing.Size(74, 20);
            this.dtTmPckrIdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "A találkozó ideje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(70, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "A találkozó ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(70, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuális idő:";
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErtekeles.Location = new System.Drawing.Point(166, 248);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(148, 28);
            this.lblErtekeles.TabIndex = 5;
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTalalkozo.Location = new System.Drawing.Point(195, 126);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(0, 18);
            this.lblTalalkozo.TabIndex = 6;
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktualis.Location = new System.Drawing.Point(195, 176);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(119, 18);
            this.lblAktualis.TabIndex = 7;
            this.lblAktualis.Text = "A találkozó ideje:";
            // 
            // btnErtekel
            // 
            this.btnErtekel.Location = new System.Drawing.Point(82, 323);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(75, 23);
            this.btnErtekel.TabIndex = 8;
            this.btnErtekel.Text = "Értékel";
            this.btnErtekel.UseVisualStyleBackColor = true;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(198, 354);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 9;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(322, 323);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 10;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 389);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnErtekel);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.dtTmPckrDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.DateTimePicker dtTmPckrIdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label lblAktualis;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnTorol;
    }
}

