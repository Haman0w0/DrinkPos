namespace DrinkPos
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
            label1 = new Label();
            idText = new TextBox();
            pwdText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginBtn = new Button();
            resetBtn = new Button();
            addEmployeeLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 76);
            label1.TabIndex = 0;
            label1.Text = "使用者登入";
            // 
            // idText
            // 
            idText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(227, 115);
            idText.Name = "idText";
            idText.Size = new Size(367, 47);
            idText.TabIndex = 0;
            // 
            // pwdText
            // 
            pwdText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pwdText.Location = new Point(227, 202);
            pwdText.Name = "pwdText";
            pwdText.PasswordChar = '*';
            pwdText.Size = new Size(367, 47);
            pwdText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 114);
            label2.Name = "label2";
            label2.Size = new Size(142, 50);
            label2.TabIndex = 0;
            label2.Text = "帳號：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(108, 201);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 1;
            label3.Text = "密碼：";
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(349, 474);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(132, 61);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "登入";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(487, 474);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(132, 61);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "重設";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // addEmployeeLink
            // 
            addEmployeeLink.AutoSize = true;
            addEmployeeLink.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addEmployeeLink.Location = new Point(210, 492);
            addEmployeeLink.Name = "addEmployeeLink";
            addEmployeeLink.Size = new Size(167, 38);
            addEmployeeLink.TabIndex = 4;
            addEmployeeLink.TabStop = true;
            addEmployeeLink.Text = "新增使用者";
            addEmployeeLink.LinkClicked += addEmployeeLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(631, 547);
            Controls.Add(addEmployeeLink);
            Controls.Add(resetBtn);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pwdText);
            Controls.Add(idText);
            Controls.Add(label1);
            Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idText;
        private TextBox pwdText;
        private Label label2;
        private Label label3;
        private Button loginBtn;
        private Button resetBtn;
        private LinkLabel addEmployeeLink;
    }
}