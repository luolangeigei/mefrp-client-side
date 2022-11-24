namespace WindowsFormsApp1
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
            this.fh_list = new MaterialSkin.Controls.MaterialListBox();
            this.fh_text = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // fh_list
            // 
            this.fh_list.BackColor = System.Drawing.Color.White;
            this.fh_list.BorderColor = System.Drawing.Color.LightGray;
            this.fh_list.Depth = 0;
            this.fh_list.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fh_list.Location = new System.Drawing.Point(6, 281);
            this.fh_list.MouseState = MaterialSkin.MouseState.HOVER;
            this.fh_list.Name = "fh_list";
            this.fh_list.SelectedIndex = -1;
            this.fh_list.SelectedItem = null;
            this.fh_list.Size = new System.Drawing.Size(916, 342);
            this.fh_list.TabIndex = 0;
            // 
            // fh_text
            // 
            this.fh_text.AutoSize = true;
            this.fh_text.Depth = 0;
            this.fh_text.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fh_text.Location = new System.Drawing.Point(55, 75);
            this.fh_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.fh_text.Name = "fh_text";
            this.fh_text.Size = new System.Drawing.Size(101, 19);
            this.fh_text.TabIndex = 1;
            this.fh_text.Text = "    已经运行.....";
            this.fh_text.Click += new System.EventHandler(this.fh_text_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 219);
            this.Controls.Add(this.fh_text);
            this.Controls.Add(this.fh_list);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox fh_list;
        private MaterialSkin.Controls.MaterialLabel fh_text;
    }
}