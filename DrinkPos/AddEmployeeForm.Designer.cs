namespace DrinkPos
{
    partial class AddEmployeeForm
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
            label3 = new Label();
            label2 = new Label();
            pwdText = new TextBox();
            idText = new TextBox();
            label4 = new Label();
            label5 = new Label();
            repwdText = new TextBox();
            nameText = new TextBox();
            resetBtn = new Button();
            addBtn = new Button();
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
            label1.TabIndex = 1;
            label1.Text = "新增使用者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(108, 289);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 8;
            label3.Text = "密碼：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 114);
            label2.Name = "label2";
            label2.Size = new Size(142, 50);
            label2.TabIndex = 7;
            label2.Text = "帳號：";
            // 
            // pwdText
            // 
            pwdText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pwdText.Location = new Point(227, 289);
            pwdText.Name = "pwdText";
            pwdText.PasswordChar = '*';
            pwdText.Size = new Size(359, 47);
            pwdText.TabIndex = 2;
            // 
            // idText
            // 
            idText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(227, 115);
            idText.Name = "idText";
            idText.Size = new Size(359, 47);
            idText.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 375);
            label4.Name = "label4";
            label4.Size = new Size(262, 50);
            label4.TabIndex = 12;
            label4.Text = "再輸入密碼：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(108, 201);
            label5.Name = "label5";
            label5.Size = new Size(142, 50);
            label5.TabIndex = 11;
            label5.Text = "姓名：";
            // 
            // repwdText
            // 
            repwdText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repwdText.Location = new Point(227, 380);
            repwdText.Name = "repwdText";
            repwdText.PasswordChar = '*';
            repwdText.Size = new Size(359, 47);
            repwdText.TabIndex = 3;
            // 
            // nameText
            // 
            nameText.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(227, 206);
            nameText.Name = "nameText";
            nameText.Size = new Size(359, 47);
            nameText.TabIndex = 1;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(487, 474);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(132, 61);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "重設";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(349, 474);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(132, 61);
            addBtn.TabIndex = 4;
            addBtn.Text = "新增";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(631, 547);
            Controls.Add(resetBtn);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(repwdText);
            Controls.Add(nameText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pwdText);
            Controls.Add(idText);
            Controls.Add(label1);
            Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox pwdText;
        private TextBox idText;
        private Label label4;
        private Label label5;
        private TextBox repwdText;
        private TextBox nameText;
        private Button resetBtn;
        private Button addBtn;
    }
}