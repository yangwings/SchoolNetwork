namespace SchoolNetwork.Forms
{
    partial class LoginForm
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codepicture = new System.Windows.Forms.PictureBox();
            this.validcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_true = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox.Location = new System.Drawing.Point(154, 123);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(88, 20);
            this.checkBox.TabIndex = 14;
            this.checkBox.TabStop = false;
            this.checkBox.Text = "记住密码";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.codepicture);
            this.panel1.Controls.Add(this.validcode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(66, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 42);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // codepicture
            // 
            this.codepicture.Location = new System.Drawing.Point(146, 6);
            this.codepicture.Name = "codepicture";
            this.codepicture.Size = new System.Drawing.Size(80, 30);
            this.codepicture.TabIndex = 8;
            this.codepicture.TabStop = false;
            // 
            // validcode
            // 
            this.validcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validcode.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.validcode.Location = new System.Drawing.Point(65, 9);
            this.validcode.Name = "validcode";
            this.validcode.Size = new System.Drawing.Size(45, 25);
            this.validcode.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "验证码";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(135, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 25);
            this.password.TabIndex = 13;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(135, 53);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 25);
            this.username.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "账号";
            // 
            // button_true
            // 
            this.button_true.BackColor = System.Drawing.Color.Silver;
            this.button_true.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_true.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_true.FlatAppearance.BorderSize = 0;
            this.button_true.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_true.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_true.Location = new System.Drawing.Point(152, 206);
            this.button_true.Name = "button_true";
            this.button_true.Size = new System.Drawing.Size(75, 26);
            this.button_true.TabIndex = 15;
            this.button_true.TabStop = false;
            this.button_true.Text = "确定";
            this.button_true.UseVisualStyleBackColor = true;
            this.button_true.Click += new System.EventHandler(this.Button_true_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.Control;
            this.Min.BackgroundImage = global::SchoolNetwork.Properties.Resources.Min;
            this.Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Min.Cursor = System.Windows.Forms.Cursors.Default;
            this.Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Min.FlatAppearance.BorderSize = 0;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.Location = new System.Drawing.Point(280, -1);
            this.Min.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(50, 30);
            this.Min.TabIndex = 18;
            this.Min.TabStop = false;
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.BackgroundImage = global::SchoolNetwork.Properties.Resources.Close;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(330, -1);
            this.cancel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(50, 30);
            this.cancel.TabIndex = 17;
            this.cancel.TabStop = false;
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.ControlBox = false;
            this.Controls.Add(this.Min);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_true);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox codepicture;
        private System.Windows.Forms.TextBox validcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_true;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button cancel;
    }
}