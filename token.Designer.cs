namespace WindowsFormsApp1
{
    partial class token
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
            this.token_text = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // token_text
            // 
            this.token_text.AnimateReadOnly = false;
            this.token_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.token_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.token_text.Depth = 0;
            this.token_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.token_text.HideSelection = true;
            this.token_text.LeadingIcon = null;
            this.token_text.Location = new System.Drawing.Point(27, 107);
            this.token_text.MaxLength = 32767;
            this.token_text.MouseState = MaterialSkin.MouseState.OUT;
            this.token_text.Name = "token_text";
            this.token_text.PasswordChar = '\0';
            this.token_text.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.token_text.PrefixSuffixText = "请输入你的token";
            this.token_text.ReadOnly = false;
            this.token_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.token_text.SelectedText = "";
            this.token_text.SelectionLength = 0;
            this.token_text.SelectionStart = 0;
            this.token_text.ShortcutsEnabled = true;
            this.token_text.Size = new System.Drawing.Size(462, 48);
            this.token_text.TabIndex = 0;
            this.token_text.TabStop = false;
            this.token_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.token_text.TrailingIcon = null;
            this.token_text.UseSystemPasswordChar = false;
            this.token_text.Click += new System.EventHandler(this.token_text_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(425, 190);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "登录";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(406, 158);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "点击获取token";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 247);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.token_text);
            this.Name = "token";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.token_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 token_text;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}