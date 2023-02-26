namespace Loader
{
    partial class NewAuth
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAuth));
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.email = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.LoginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.RgstrBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.status = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.showPW = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(316, 5);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 41;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(377, 5);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 42;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // email
            // 
            this.email.AllowDrop = true;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "Email ";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoveredState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(64, 101);
            this.email.Margin = new System.Windows.Forms.Padding(5);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(315, 40);
            this.email.TabIndex = 43;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            // 
            // password
            // 
            this.password.AllowDrop = true;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "Пороль";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoveredState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(64, 151);
            this.password.Margin = new System.Windows.Forms.Padding(5);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(315, 40);
            this.password.TabIndex = 44;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LoginBtn.HoveredState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(13, 250);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(201, 33);
            this.LoginBtn.TabIndex = 45;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RgstrBtn
            // 
            this.RgstrBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.RgstrBtn.BorderThickness = 1;
            this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
            this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
            this.RgstrBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.RgstrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgstrBtn.ForeColor = System.Drawing.Color.White;
            this.RgstrBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
            this.RgstrBtn.Location = new System.Drawing.Point(226, 250);
            this.RgstrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RgstrBtn.Name = "RgstrBtn";
            this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
            this.RgstrBtn.Size = new System.Drawing.Size(204, 33);
            this.RgstrBtn.TabIndex = 46;
            this.RgstrBtn.Text = "Зарегистрироваться";
            this.RgstrBtn.Click += new System.EventHandler(this.RgstrBtn_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(12, 443);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(75, 16);
            this.status.TabIndex = 47;
            this.status.Text = "Статсус: ";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(98, 19);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 48;
            this.logo.TabStop = false;
            // 
            // showPW
            // 
            this.showPW.AutoSize = true;
            this.showPW.Checked = true;
            this.showPW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPW.Location = new System.Drawing.Point(72, 209);
            this.showPW.Name = "showPW";
            this.showPW.Size = new System.Drawing.Size(142, 20);
            this.showPW.TabIndex = 49;
            this.showPW.Text = "Показать пороль";
            this.showPW.UseVisualStyleBackColor = true;
            this.showPW.CheckedChanged += new System.EventHandler(this.showPW_CheckedChanged);
            // 
            // NewAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 481);
            this.Controls.Add(this.showPW);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.RgstrBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(64, 101);
            this.Name = "NewAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumys";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox email;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox password;
        private Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox showPW;
    }
}