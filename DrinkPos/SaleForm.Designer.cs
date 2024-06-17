namespace DrinkPos
{
    partial class SaleForm
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
            detailDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            drinkNameCBox = new ComboBox();
            label3 = new Label();
            countCBox = new ComboBox();
            label7 = new Label();
            sizeCBox = new ComboBox();
            addBtn = new Button();
            computeBtn = new Button();
            labPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)detailDGV).BeginInit();
            SuspendLayout();
            // 
            // detailDGV
            // 
            detailDGV.AllowUserToAddRows = false;
            detailDGV.AllowUserToResizeColumns = false;
            detailDGV.AllowUserToResizeRows = false;
            detailDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            detailDGV.Location = new Point(12, 225);
            detailDGV.Name = "detailDGV";
            detailDGV.RowHeadersWidth = 51;
            detailDGV.RowTemplate.Height = 25;
            detailDGV.Size = new Size(607, 310);
            detailDGV.TabIndex = 1;
            detailDGV.TabStop = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "項次";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "名稱";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.HeaderText = "容量";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.HeaderText = "數量";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "金額";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 76);
            label1.TabIndex = 3;
            label1.Text = "飲料交易處理";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(121, 50);
            label2.TabIndex = 9;
            label2.Text = "飲料 :";
            // 
            // drinkNameCBox
            // 
            drinkNameCBox.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            drinkNameCBox.FormattingEnabled = true;
            drinkNameCBox.Location = new Point(114, 86);
            drinkNameCBox.Name = "drinkNameCBox";
            drinkNameCBox.Size = new Size(194, 46);
            drinkNameCBox.TabIndex = 17;
            drinkNameCBox.TabStop = false;
            drinkNameCBox.SelectionChangeCommitted += drinkNameCBox_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(314, 85);
            label3.Name = "label3";
            label3.Size = new Size(121, 50);
            label3.TabIndex = 18;
            label3.Text = "數量 :";
            // 
            // countCBox
            // 
            countCBox.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            countCBox.FormattingEnabled = true;
            countCBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            countCBox.Location = new Point(416, 86);
            countCBox.Name = "countCBox";
            countCBox.Size = new Size(97, 46);
            countCBox.TabIndex = 19;
            countCBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 152);
            label7.Name = "label7";
            label7.Size = new Size(121, 50);
            label7.TabIndex = 20;
            label7.Text = "容量 :";
            // 
            // sizeCBox
            // 
            sizeCBox.Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sizeCBox.FormattingEnabled = true;
            sizeCBox.Location = new Point(114, 153);
            sizeCBox.Name = "sizeCBox";
            sizeCBox.Size = new Size(194, 46);
            sizeCBox.TabIndex = 21;
            sizeCBox.TabStop = false;
            sizeCBox.SelectionChangeCommitted += sizeCBox_SelectionChangeCommitted;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(314, 149);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(132, 46);
            addBtn.TabIndex = 28;
            addBtn.Text = "加入";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // computeBtn
            // 
            computeBtn.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            computeBtn.Location = new Point(458, 149);
            computeBtn.Name = "computeBtn";
            computeBtn.Size = new Size(132, 46);
            computeBtn.TabIndex = 29;
            computeBtn.Text = "結帳";
            computeBtn.UseVisualStyleBackColor = true;
            computeBtn.Click += computeBtn_Click;
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labPrice.ForeColor = Color.Red;
            labPrice.Location = new Point(519, 85);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(68, 50);
            labPrice.TabIndex = 30;
            labPrice.Text = "$0";
            // 
            // SaleForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(631, 547);
            Controls.Add(labPrice);
            Controls.Add(computeBtn);
            Controls.Add(addBtn);
            Controls.Add(sizeCBox);
            Controls.Add(label7);
            Controls.Add(countCBox);
            Controls.Add(label3);
            Controls.Add(drinkNameCBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(detailDGV);
            Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)detailDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView detailDGV;
        private Label label1;
        private Label label2;
        private ComboBox drinkNameCBox;
        private Label label3;
        private ComboBox countCBox;
        private Label label7;
        private ComboBox sizeCBox;
        private Button addBtn;
        private Button computeBtn;
        private Label labPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}