
namespace projekt_wip
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.butSettings = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show all tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Taken Tables";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Unbooked Tables";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(863, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "Booked Tables";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "Change to taken";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(956, 432);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "Log out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btLogOut);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(863, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 55);
            this.button7.TabIndex = 9;
            this.button7.Text = "Change to vacant";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 7);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(583, 448);
            this.dgv1.TabIndex = 10;
            this.dgv1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv1_DataBindingComplete);
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(861, 432);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(79, 31);
            this.butSettings.TabIndex = 12;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(651, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 55);
            this.button8.TabIndex = 13;
            this.button8.Text = "Book this table";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(863, 271);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 55);
            this.button9.TabIndex = 14;
            this.button9.Text = "Unbook this table";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(651, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 53);
            this.button10.TabIndex = 15;
            this.button10.Text = "Vacant Tables";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TableManager.Properties.Resources.Form2_banner;
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 113);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::TableManager.Properties.Resources.tileable_wood_texture_by_ftourini_stock_d1hnki3_fullview;
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.butSettings);
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 483);
            this.panel2.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}