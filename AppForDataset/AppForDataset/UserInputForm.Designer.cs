namespace AppForDataset
{
    partial class UserInputForm
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
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxPrice = new TextBox();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 78);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата сдачи";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Исходная цена";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 24);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(220, 23);
            textBoxName.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(118, 112);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(189, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(36, 156);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(76, 33);
            OKButton.TabIndex = 6;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(209, 156);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(76, 33);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // UserInputForm
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 220);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(textBoxPrice);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserInputForm";
            Text = "UserInputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxPrice;
        private Button OKButton;
        private Button CancelButton;
    }
}