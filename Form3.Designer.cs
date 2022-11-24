namespace WindowsFormsApp1
{
    partial class Form3
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
            this.list_1 = new MaterialSkin.Controls.MaterialLabel();
            this.ListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // list_1
            // 
            this.list_1.AutoSize = true;
            this.list_1.Depth = 0;
            this.list_1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.list_1.Location = new System.Drawing.Point(81, 131);
            this.list_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.list_1.Name = "list_1";
            this.list_1.Size = new System.Drawing.Size(107, 19);
            this.list_1.TabIndex = 0;
            this.list_1.Text = "materialLabel1";
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.Color.White;
            this.ListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.ListBox1.Depth = 0;
            this.ListBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox1.Location = new System.Drawing.Point(29, 172);
            this.ListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectedIndex = -1;
            this.ListBox1.SelectedItem = null;
            this.ListBox1.Size = new System.Drawing.Size(1104, 242);
            this.ListBox1.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.list_1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel list_1;
        private MaterialSkin.Controls.MaterialListBox ListBox1;
    }
}