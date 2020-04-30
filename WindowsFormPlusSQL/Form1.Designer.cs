namespace WindowsFormPlusSQL
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanelHeader = new System.Windows.Forms.Panel();
            this.BtnCloseLF = new System.Windows.Forms.Label();
            this.HedaerPanelText = new System.Windows.Forms.Label();
            this.MainPanelBody = new System.Windows.Forms.Panel();
            this.BtnLinkForm = new System.Windows.Forms.Button();
            this.TBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelMainImgS = new System.Windows.Forms.PictureBox();
            this.TBoxF = new System.Windows.Forms.TextBox();
            this.PanelBodyImgF = new System.Windows.Forms.PictureBox();
            this.MainPanelHeader.SuspendLayout();
            this.MainPanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMainImgS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBodyImgF)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelHeader
            // 
            this.MainPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(184)))));
            this.MainPanelHeader.Controls.Add(this.BtnCloseLF);
            this.MainPanelHeader.Controls.Add(this.HedaerPanelText);
            this.MainPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.MainPanelHeader.Name = "MainPanelHeader";
            this.MainPanelHeader.Size = new System.Drawing.Size(277, 100);
            this.MainPanelHeader.TabIndex = 0;
            this.MainPanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelHeader_MouseDown);
            this.MainPanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelHeader_MouseMove);
            // 
            // BtnCloseLF
            // 
            this.BtnCloseLF.AutoSize = true;
            this.BtnCloseLF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseLF.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCloseLF.ForeColor = System.Drawing.Color.Red;
            this.BtnCloseLF.Location = new System.Drawing.Point(238, 0);
            this.BtnCloseLF.Name = "BtnCloseLF";
            this.BtnCloseLF.Size = new System.Drawing.Size(39, 38);
            this.BtnCloseLF.TabIndex = 1;
            this.BtnCloseLF.Text = "X";
            this.BtnCloseLF.Click += new System.EventHandler(this.BtnCloseLF_Click);
            // 
            // HedaerPanelText
            // 
            this.HedaerPanelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(184)))));
            this.HedaerPanelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HedaerPanelText.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HedaerPanelText.ForeColor = System.Drawing.Color.White;
            this.HedaerPanelText.Location = new System.Drawing.Point(34, 30);
            this.HedaerPanelText.Name = "HedaerPanelText";
            this.HedaerPanelText.Size = new System.Drawing.Size(212, 42);
            this.HedaerPanelText.TabIndex = 0;
            this.HedaerPanelText.Text = "Авторизация";
            this.HedaerPanelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HedaerPanelText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HedaerPanelText_MouseDown);
            this.HedaerPanelText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HedaerPanelText_MouseMove);
            // 
            // MainPanelBody
            // 
            this.MainPanelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(185)))), ((int)(((byte)(145)))));
            this.MainPanelBody.Controls.Add(this.BtnLinkForm);
            this.MainPanelBody.Controls.Add(this.TBoxPassword);
            this.MainPanelBody.Controls.Add(this.PanelMainImgS);
            this.MainPanelBody.Controls.Add(this.TBoxF);
            this.MainPanelBody.Controls.Add(this.PanelBodyImgF);
            this.MainPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelBody.Location = new System.Drawing.Point(0, 100);
            this.MainPanelBody.Name = "MainPanelBody";
            this.MainPanelBody.Size = new System.Drawing.Size(277, 321);
            this.MainPanelBody.TabIndex = 1;
            this.MainPanelBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelBody_MouseDown);
            this.MainPanelBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelBody_MouseMove);
            // 
            // BtnLinkForm
            // 
            this.BtnLinkForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(232)))), ((int)(((byte)(189)))));
            this.BtnLinkForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLinkForm.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BtnLinkForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLinkForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLinkForm.Location = new System.Drawing.Point(52, 222);
            this.BtnLinkForm.Name = "BtnLinkForm";
            this.BtnLinkForm.Size = new System.Drawing.Size(168, 48);
            this.BtnLinkForm.TabIndex = 4;
            this.BtnLinkForm.Text = "Войти";
            this.BtnLinkForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLinkForm.UseVisualStyleBackColor = false;
            // 
            // TBoxPassword
            // 
            this.TBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxPassword.Location = new System.Drawing.Point(86, 130);
            this.TBoxPassword.Name = "TBoxPassword";
            this.TBoxPassword.Size = new System.Drawing.Size(179, 38);
            this.TBoxPassword.TabIndex = 3;
            this.TBoxPassword.UseSystemPasswordChar = true;
            // 
            // PanelMainImgS
            // 
            this.PanelMainImgS.Image = global::WindowsFormPlusSQL.Properties.Resources.restricted;
            this.PanelMainImgS.Location = new System.Drawing.Point(12, 130);
            this.PanelMainImgS.Name = "PanelMainImgS";
            this.PanelMainImgS.Size = new System.Drawing.Size(75, 61);
            this.PanelMainImgS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PanelMainImgS.TabIndex = 2;
            this.PanelMainImgS.TabStop = false;
            // 
            // TBoxF
            // 
            this.TBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxF.Location = new System.Drawing.Point(86, 38);
            this.TBoxF.Multiline = true;
            this.TBoxF.Name = "TBoxF";
            this.TBoxF.Size = new System.Drawing.Size(179, 61);
            this.TBoxF.TabIndex = 1;
            // 
            // PanelBodyImgF
            // 
            this.PanelBodyImgF.Image = global::WindowsFormPlusSQL.Properties.Resources.social;
            this.PanelBodyImgF.Location = new System.Drawing.Point(12, 38);
            this.PanelBodyImgF.Name = "PanelBodyImgF";
            this.PanelBodyImgF.Size = new System.Drawing.Size(75, 61);
            this.PanelBodyImgF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PanelBodyImgF.TabIndex = 0;
            this.PanelBodyImgF.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 421);
            this.Controls.Add(this.MainPanelBody);
            this.Controls.Add(this.MainPanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.MainPanelHeader.ResumeLayout(false);
            this.MainPanelHeader.PerformLayout();
            this.MainPanelBody.ResumeLayout(false);
            this.MainPanelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMainImgS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBodyImgF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanelHeader;
        private System.Windows.Forms.Panel MainPanelBody;
        private System.Windows.Forms.Label HedaerPanelText;
        private System.Windows.Forms.TextBox TBoxPassword;
        private System.Windows.Forms.PictureBox PanelMainImgS;
        private System.Windows.Forms.TextBox TBoxF;
        private System.Windows.Forms.PictureBox PanelBodyImgF;
        private System.Windows.Forms.Button BtnLinkForm;
        private System.Windows.Forms.Label BtnCloseLF;
    }
}

