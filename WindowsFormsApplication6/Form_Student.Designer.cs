namespace WindowsFormsApplication6
{
    partial class Form_Student
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
            this.bt_Odjava = new System.Windows.Forms.Button();
            this.rtb_tekst = new System.Windows.Forms.RichTextBox();
            this.lb_raniji = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_Odjava
            // 
            this.bt_Odjava.Location = new System.Drawing.Point(354, 12);
            this.bt_Odjava.Name = "bt_Odjava";
            this.bt_Odjava.Size = new System.Drawing.Size(131, 39);
            this.bt_Odjava.TabIndex = 7;
            this.bt_Odjava.Text = "Odjava";
            this.bt_Odjava.UseVisualStyleBackColor = true;
            this.bt_Odjava.Click += new System.EventHandler(this.bt_Odjava_Click);
            // 
            // rtb_tekst
            // 
            this.rtb_tekst.Location = new System.Drawing.Point(12, 12);
            this.rtb_tekst.Name = "rtb_tekst";
            this.rtb_tekst.ReadOnly = true;
            this.rtb_tekst.Size = new System.Drawing.Size(336, 342);
            this.rtb_tekst.TabIndex = 6;
            this.rtb_tekst.Text = "";
            // 
            // lb_raniji
            // 
            this.lb_raniji.FormattingEnabled = true;
            this.lb_raniji.Location = new System.Drawing.Point(491, 12);
            this.lb_raniji.Name = "lb_raniji";
            this.lb_raniji.Size = new System.Drawing.Size(221, 342);
            this.lb_raniji.TabIndex = 5;
            this.lb_raniji.SelectedIndexChanged += new System.EventHandler(this.lb_raniji_SelectedIndexChanged);
            // 
            // Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.bt_Odjava);
            this.Controls.Add(this.rtb_tekst);
            this.Controls.Add(this.lb_raniji);
            this.Name = "Form_Student";
            this.Text = "Form_Student";
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Odjava;
        private System.Windows.Forms.RichTextBox rtb_tekst;
        private System.Windows.Forms.ListBox lb_raniji;
    }
}