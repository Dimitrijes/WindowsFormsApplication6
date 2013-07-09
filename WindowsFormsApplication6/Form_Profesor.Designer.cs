namespace WindowsFormsApplication6
{
    partial class Form_Profesor
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
            this.lb_raniji = new System.Windows.Forms.ListBox();
            this.bt_Odjava = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.rtb_tekst = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lb_raniji
            // 
            this.lb_raniji.FormattingEnabled = true;
            this.lb_raniji.Location = new System.Drawing.Point(491, 12);
            this.lb_raniji.Name = "lb_raniji";
            this.lb_raniji.Size = new System.Drawing.Size(221, 329);
            this.lb_raniji.TabIndex = 0;
            this.lb_raniji.SelectedIndexChanged += new System.EventHandler(this.lb_raniji_SelectedIndexChanged);
            // 
            // bt_Odjava
            // 
            this.bt_Odjava.Location = new System.Drawing.Point(355, 293);
            this.bt_Odjava.Name = "bt_Odjava";
            this.bt_Odjava.Size = new System.Drawing.Size(129, 39);
            this.bt_Odjava.TabIndex = 2;
            this.bt_Odjava.Text = "Odjava";
            this.bt_Odjava.UseVisualStyleBackColor = true;
            this.bt_Odjava.Click += new System.EventHandler(this.bt_Odjava_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(355, 25);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(129, 39);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(12, 12);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(336, 20);
            this.tb_naziv.TabIndex = 4;
            this.tb_naziv.Text = "Unesite naziv";
            this.tb_naziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_naziv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_naziv_MouseDown);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(354, 137);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(129, 39);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // rtb_tekst
            // 
            this.rtb_tekst.Location = new System.Drawing.Point(12, 49);
            this.rtb_tekst.Name = "rtb_tekst";
            this.rtb_tekst.Size = new System.Drawing.Size(336, 292);
            this.rtb_tekst.TabIndex = 1;
            this.rtb_tekst.Text = "";
            // 
            // Form_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_Odjava);
            this.Controls.Add(this.rtb_tekst);
            this.Controls.Add(this.lb_raniji);
            this.Name = "Form_Profesor";
            this.Text = "Form_Profesor";
            this.Load += new System.EventHandler(this.Form_Profesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_raniji;
        private System.Windows.Forms.Button bt_Odjava;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.RichTextBox rtb_tekst;
    }
}