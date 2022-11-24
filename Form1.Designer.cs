namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.token_text = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.t_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.t_server_addr = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.t_local_ip = new MaterialSkin.Controls.MaterialTextBox2();
            this.t_custom_domains = new MaterialSkin.Controls.MaterialTextBox2();
            this.t_local_port = new MaterialSkin.Controls.MaterialTextBox2();
            this.t_type = new MaterialSkin.Controls.MaterialTextBox2();
            this.t_server_port = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.suidao_save = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.关于 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // token_text
            // 
            this.token_text.AnimateReadOnly = false;
            this.token_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.token_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.token_text.Depth = 0;
            this.token_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.token_text.HelperText = "请输入token";
            this.token_text.HideSelection = true;
            this.token_text.LeadingIcon = null;
            this.token_text.LeaveOnEnterKey = true;
            this.token_text.Location = new System.Drawing.Point(17, 17);
            this.token_text.MaxLength = 32767;
            this.token_text.MouseState = MaterialSkin.MouseState.OUT;
            this.token_text.Name = "token_text";
            this.token_text.PasswordChar = '\0';
            this.token_text.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.token_text.PrefixSuffixText = "请输入密钥";
            this.token_text.ReadOnly = false;
            this.token_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.token_text.SelectedText = "";
            this.token_text.SelectionLength = 0;
            this.token_text.SelectionStart = 0;
            this.token_text.ShortcutsEnabled = true;
            this.token_text.Size = new System.Drawing.Size(495, 48);
            this.token_text.TabIndex = 0;
            this.token_text.TabStop = false;
            this.token_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.token_text.TrailingIcon = null;
            this.token_text.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.t_name);
            this.materialCard1.Controls.Add(this.t_server_addr);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.t_local_ip);
            this.materialCard1.Controls.Add(this.t_custom_domains);
            this.materialCard1.Controls.Add(this.t_local_port);
            this.materialCard1.Controls.Add(this.t_type);
            this.materialCard1.Controls.Add(this.t_server_port);
            this.materialCard1.Controls.Add(this.token_text);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(529, 366);
            this.materialCard1.TabIndex = 1;
            // 
            // t_name
            // 
            this.t_name.AnimateReadOnly = false;
            this.t_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_name.Depth = 0;
            this.t_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_name.HelperText = "请输入type";
            this.t_name.HideSelection = true;
            this.t_name.LeadingIcon = null;
            this.t_name.LeaveOnEnterKey = true;
            this.t_name.Location = new System.Drawing.Point(17, 309);
            this.t_name.MaxLength = 32767;
            this.t_name.MouseState = MaterialSkin.MouseState.OUT;
            this.t_name.Name = "t_name";
            this.t_name.PasswordChar = '\0';
            this.t_name.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_name.PrefixSuffixText = "请输入隧道代名";
            this.t_name.ReadOnly = false;
            this.t_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_name.SelectedText = "";
            this.t_name.SelectionLength = 0;
            this.t_name.SelectionStart = 0;
            this.t_name.ShortcutsEnabled = true;
            this.t_name.Size = new System.Drawing.Size(236, 48);
            this.t_name.TabIndex = 9;
            this.t_name.TabStop = false;
            this.t_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_name.TrailingIcon = null;
            this.t_name.UseSystemPasswordChar = false;
            // 
            // t_server_addr
            // 
            this.t_server_addr.AnimateReadOnly = false;
            this.t_server_addr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_server_addr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_server_addr.Depth = 0;
            this.t_server_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_server_addr.HelperText = "请输入type";
            this.t_server_addr.HideSelection = true;
            this.t_server_addr.LeadingIcon = null;
            this.t_server_addr.LeaveOnEnterKey = true;
            this.t_server_addr.Location = new System.Drawing.Point(17, 250);
            this.t_server_addr.MaxLength = 32767;
            this.t_server_addr.MouseState = MaterialSkin.MouseState.OUT;
            this.t_server_addr.Name = "t_server_addr";
            this.t_server_addr.PasswordChar = '\0';
            this.t_server_addr.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_server_addr.PrefixSuffixText = "请输入server_addr";
            this.t_server_addr.ReadOnly = false;
            this.t_server_addr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_server_addr.SelectedText = "";
            this.t_server_addr.SelectionLength = 0;
            this.t_server_addr.SelectionStart = 0;
            this.t_server_addr.ShortcutsEnabled = true;
            this.t_server_addr.Size = new System.Drawing.Size(495, 48);
            this.t_server_addr.TabIndex = 8;
            this.t_server_addr.TabStop = false;
            this.t_server_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_server_addr.TrailingIcon = null;
            this.t_server_addr.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(410, 307);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(85, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "开启隧道";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(258, 324);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "如何获取上述内容？";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // t_local_ip
            // 
            this.t_local_ip.AnimateReadOnly = false;
            this.t_local_ip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_local_ip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_local_ip.Depth = 0;
            this.t_local_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_local_ip.HelperText = "请输入type";
            this.t_local_ip.HideSelection = true;
            this.t_local_ip.LeadingIcon = null;
            this.t_local_ip.LeaveOnEnterKey = true;
            this.t_local_ip.Location = new System.Drawing.Point(276, 132);
            this.t_local_ip.MaxLength = 32767;
            this.t_local_ip.MouseState = MaterialSkin.MouseState.OUT;
            this.t_local_ip.Name = "t_local_ip";
            this.t_local_ip.PasswordChar = '\0';
            this.t_local_ip.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_local_ip.PrefixSuffixText = "请输入local_ip";
            this.t_local_ip.ReadOnly = false;
            this.t_local_ip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_local_ip.SelectedText = "";
            this.t_local_ip.SelectionLength = 0;
            this.t_local_ip.SelectionStart = 0;
            this.t_local_ip.ShortcutsEnabled = true;
            this.t_local_ip.Size = new System.Drawing.Size(236, 48);
            this.t_local_ip.TabIndex = 7;
            this.t_local_ip.TabStop = false;
            this.t_local_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_local_ip.TrailingIcon = null;
            this.t_local_ip.UseSystemPasswordChar = false;
            // 
            // t_custom_domains
            // 
            this.t_custom_domains.AnimateReadOnly = false;
            this.t_custom_domains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_custom_domains.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_custom_domains.Depth = 0;
            this.t_custom_domains.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_custom_domains.HelperText = "请输入type";
            this.t_custom_domains.HideSelection = true;
            this.t_custom_domains.LeadingIcon = null;
            this.t_custom_domains.LeaveOnEnterKey = true;
            this.t_custom_domains.Location = new System.Drawing.Point(17, 196);
            this.t_custom_domains.MaxLength = 32767;
            this.t_custom_domains.MouseState = MaterialSkin.MouseState.OUT;
            this.t_custom_domains.Name = "t_custom_domains";
            this.t_custom_domains.PasswordChar = '\0';
            this.t_custom_domains.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_custom_domains.PrefixSuffixText = "请输入custom_domains";
            this.t_custom_domains.ReadOnly = false;
            this.t_custom_domains.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_custom_domains.SelectedText = "";
            this.t_custom_domains.SelectionLength = 0;
            this.t_custom_domains.SelectionStart = 0;
            this.t_custom_domains.ShortcutsEnabled = true;
            this.t_custom_domains.Size = new System.Drawing.Size(495, 48);
            this.t_custom_domains.TabIndex = 6;
            this.t_custom_domains.TabStop = false;
            this.t_custom_domains.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_custom_domains.TrailingIcon = null;
            this.t_custom_domains.UseSystemPasswordChar = false;
            // 
            // t_local_port
            // 
            this.t_local_port.AnimateReadOnly = false;
            this.t_local_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_local_port.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_local_port.Depth = 0;
            this.t_local_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_local_port.HelperText = "请输入type";
            this.t_local_port.HideSelection = true;
            this.t_local_port.LeadingIcon = null;
            this.t_local_port.LeaveOnEnterKey = true;
            this.t_local_port.Location = new System.Drawing.Point(17, 132);
            this.t_local_port.MaxLength = 32767;
            this.t_local_port.MouseState = MaterialSkin.MouseState.OUT;
            this.t_local_port.Name = "t_local_port";
            this.t_local_port.PasswordChar = '\0';
            this.t_local_port.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_local_port.PrefixSuffixText = "请输入local_port";
            this.t_local_port.ReadOnly = false;
            this.t_local_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_local_port.SelectedText = "";
            this.t_local_port.SelectionLength = 0;
            this.t_local_port.SelectionStart = 0;
            this.t_local_port.ShortcutsEnabled = true;
            this.t_local_port.Size = new System.Drawing.Size(236, 48);
            this.t_local_port.TabIndex = 5;
            this.t_local_port.TabStop = false;
            this.t_local_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_local_port.TrailingIcon = null;
            this.t_local_port.UseSystemPasswordChar = false;
            // 
            // t_type
            // 
            this.t_type.AnimateReadOnly = false;
            this.t_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_type.Depth = 0;
            this.t_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_type.HelperText = "请输入type";
            this.t_type.HideSelection = true;
            this.t_type.LeadingIcon = null;
            this.t_type.LeaveOnEnterKey = true;
            this.t_type.Location = new System.Drawing.Point(276, 71);
            this.t_type.MaxLength = 32767;
            this.t_type.MouseState = MaterialSkin.MouseState.OUT;
            this.t_type.Name = "t_type";
            this.t_type.PasswordChar = '\0';
            this.t_type.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_type.PrefixSuffixText = "请输入type";
            this.t_type.ReadOnly = false;
            this.t_type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_type.SelectedText = "";
            this.t_type.SelectionLength = 0;
            this.t_type.SelectionStart = 0;
            this.t_type.ShortcutsEnabled = true;
            this.t_type.Size = new System.Drawing.Size(236, 48);
            this.t_type.TabIndex = 4;
            this.t_type.TabStop = false;
            this.t_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_type.TrailingIcon = null;
            this.t_type.UseSystemPasswordChar = false;
            // 
            // t_server_port
            // 
            this.t_server_port.AnimateReadOnly = false;
            this.t_server_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.t_server_port.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.t_server_port.Depth = 0;
            this.t_server_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.t_server_port.HelperText = "请输入server_port";
            this.t_server_port.HideSelection = true;
            this.t_server_port.LeadingIcon = null;
            this.t_server_port.LeaveOnEnterKey = true;
            this.t_server_port.Location = new System.Drawing.Point(17, 71);
            this.t_server_port.MaxLength = 32767;
            this.t_server_port.MouseState = MaterialSkin.MouseState.OUT;
            this.t_server_port.Name = "t_server_port";
            this.t_server_port.PasswordChar = '\0';
            this.t_server_port.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.t_server_port.PrefixSuffixText = "请输入server_port";
            this.t_server_port.ReadOnly = false;
            this.t_server_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.t_server_port.SelectedText = "";
            this.t_server_port.SelectionLength = 0;
            this.t_server_port.SelectionStart = 0;
            this.t_server_port.ShortcutsEnabled = true;
            this.t_server_port.Size = new System.Drawing.Size(236, 48);
            this.t_server_port.TabIndex = 3;
            this.t_server_port.TabStop = false;
            this.t_server_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.t_server_port.TrailingIcon = null;
            this.t_server_port.UseSystemPasswordChar = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialButton2);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.suidao_save);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(552, 77);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(437, 136);
            this.materialCard3.TabIndex = 3;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(329, 82);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(85, 36);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "开启隧道";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(39, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(145, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "已经保存了的隧道：";
            // 
            // suidao_save
            // 
            this.suidao_save.AutoResize = false;
            this.suidao_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suidao_save.Depth = 0;
            this.suidao_save.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.suidao_save.DropDownHeight = 174;
            this.suidao_save.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suidao_save.DropDownWidth = 121;
            this.suidao_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.suidao_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.suidao_save.FormattingEnabled = true;
            this.suidao_save.IntegralHeight = false;
            this.suidao_save.ItemHeight = 43;
            this.suidao_save.Location = new System.Drawing.Point(190, 15);
            this.suidao_save.MaxDropDownItems = 4;
            this.suidao_save.MouseState = MaterialSkin.MouseState.OUT;
            this.suidao_save.Name = "suidao_save";
            this.suidao_save.Size = new System.Drawing.Size(240, 49);
            this.suidao_save.StartIndex = 0;
            this.suidao_save.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialButton3);
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.关于);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(552, 225);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(437, 217);
            this.materialCard2.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 32);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(276, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "由罗澜制作，并引用了Material2开源库";
            // 
            // 关于
            // 
            this.关于.AutoSize = true;
            this.关于.Depth = 0;
            this.关于.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.关于.Location = new System.Drawing.Point(11, 11);
            this.关于.MouseState = MaterialSkin.MouseState.HOVER;
            this.关于.Name = "关于";
            this.关于.Size = new System.Drawing.Size(37, 19);
            this.关于.TabIndex = 0;
            this.关于.Text = "关于:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.th;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(24, 67);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "服务器列表";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 451);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard1);
            this.Name = "Form1";
            this.Text = "Mefrp客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 token_text;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 t_name;
        private MaterialSkin.Controls.MaterialTextBox2 t_server_addr;
        private MaterialSkin.Controls.MaterialTextBox2 t_local_ip;
        private MaterialSkin.Controls.MaterialTextBox2 t_custom_domains;
        private MaterialSkin.Controls.MaterialTextBox2 t_local_port;
        private MaterialSkin.Controls.MaterialTextBox2 t_type;
        private MaterialSkin.Controls.MaterialTextBox2 t_server_port;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox suidao_save;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel 关于;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}

