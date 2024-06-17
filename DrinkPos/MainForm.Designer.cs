namespace DrinkPos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formPanel = new Panel();
            loginBtn = new Button();
            label1 = new Label();
            saleBtn = new Button();
            addEmpBtn = new Button();
            setupBtn = new Button();
            stateText = new Label();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.Dock = DockStyle.Right;
            formPanel.Location = new Point(163, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(641, 557);
            formPanel.TabIndex = 0;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(27, 76);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(115, 37);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "登入";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 2;
            label1.Text = "功能列表";
            // 
            // saleBtn
            // 
            saleBtn.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saleBtn.Location = new Point(27, 146);
            saleBtn.Name = "saleBtn";
            saleBtn.Size = new Size(115, 37);
            saleBtn.TabIndex = 3;
            saleBtn.Text = "交易";
            saleBtn.UseVisualStyleBackColor = true;
            saleBtn.Click += saleBtn_Click;
            // 
            // addEmpBtn
            // 
            addEmpBtn.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addEmpBtn.Location = new Point(27, 216);
            addEmpBtn.Name = "addEmpBtn";
            addEmpBtn.Size = new Size(115, 37);
            addEmpBtn.TabIndex = 4;
            addEmpBtn.Text = "新增使用者";
            addEmpBtn.UseVisualStyleBackColor = true;
            addEmpBtn.Click += addEmpBtn_Click;
            // 
            // setupBtn
            // 
            setupBtn.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            setupBtn.Location = new Point(27, 286);
            setupBtn.Name = "setupBtn";
            setupBtn.Size = new Size(115, 37);
            setupBtn.TabIndex = 5;
            setupBtn.Text = "設定";
            setupBtn.UseVisualStyleBackColor = true;
            setupBtn.Click += setupBtn_Click;
            // 
            // stateText
            // 
            stateText.AutoSize = true;
            stateText.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stateText.ForeColor = Color.Red;
            stateText.Location = new Point(27, 356);
            stateText.Name = "stateText";
            stateText.Size = new Size(72, 25);
            stateText.TabIndex = 6;
            stateText.Text = "未登入";
            stateText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(804, 557);
            Controls.Add(stateText);
            Controls.Add(setupBtn);
            Controls.Add(addEmpBtn);
            Controls.Add(saleBtn);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(formPanel);
            Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "手搖飲Pos系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel formPanel;
        private Button loginBtn;
        private Label label1;
        private Button saleBtn;
        private Button addEmpBtn;
        private Button setupBtn;
        private Label stateText;
    }
}