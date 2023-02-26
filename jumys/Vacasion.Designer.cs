namespace Loader
{
    partial class Vacasion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacasion));
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.LoginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(433, 3);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 60;
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
            this.siticoneControlBox2.Location = new System.Drawing.Point(371, 3);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 59;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(98, 19);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 58;
            this.logo.TabStop = false;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = null;
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
            this.LoginBtn.Location = new System.Drawing.Point(237, 427);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(250, 40);
            this.LoginBtn.TabIndex = 71;
            this.LoginBtn.Text = "Откликнуться";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Акимат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(30, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 27);
            this.label9.TabIndex = 73;
            this.label9.Text = "55 000 KZT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 27);
            this.label10.TabIndex = 72;
            this.label10.Text = "Дворник";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(12, 427);
            this.siticoneRoundedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(215, 40);
            this.siticoneRoundedButton1.TabIndex = 75;
            this.siticoneRoundedButton1.Text = "Назад";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(454, 222);
            this.richTextBox1.TabIndex = 76;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(234, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "Резюме успешно отправленно!";
            this.label1.Visible = false;
            // 
            // Vacasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vacasion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.PictureBox logo;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}