
namespace projekt_wip
{
    partial class addUser
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
            this.butRegister = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.newUsertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPasstxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(79, 196);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(100, 47);
            this.butRegister.TabIndex = 0;
            this.butRegister.Text = "Register";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(215, 196);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(92, 47);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // newUsertxt
            // 
            this.newUsertxt.Location = new System.Drawing.Point(173, 84);
            this.newUsertxt.Name = "newUsertxt";
            this.newUsertxt.Size = new System.Drawing.Size(134, 23);
            this.newUsertxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register new users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // newPasstxt
            // 
            this.newPasstxt.Location = new System.Drawing.Point(173, 121);
            this.newPasstxt.Name = "newPasstxt";
            this.newPasstxt.Size = new System.Drawing.Size(134, 23);
            this.newPasstxt.TabIndex = 6;
            this.newPasstxt.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.newPasstxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newUsertxt);
            this.panel1.Controls.Add(this.butBack);
            this.panel1.Controls.Add(this.butRegister);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 282);
            this.panel1.TabIndex = 7;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 275);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox newUsertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPasstxt;
        private System.Windows.Forms.Panel panel1;
    }
}