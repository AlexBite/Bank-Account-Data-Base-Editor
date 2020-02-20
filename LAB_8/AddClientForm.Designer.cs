namespace LAB_8
{
    partial class AddClientForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toPositionButton = new System.Windows.Forms.RadioButton();
            this.toEndButton = new System.Windows.Forms.RadioButton();
            this.toBeginButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.creditTypeListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creditAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.positionUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.positionUpDown);
            this.groupBox2.Controls.Add(this.toPositionButton);
            this.groupBox2.Controls.Add(this.toEndButton);
            this.groupBox2.Controls.Add(this.toBeginButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.creditTypeListBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.termTextBox);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.creditAmountTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 298);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ЗАПИСЬ КЛИЕНТА";
            // 
            // toPositionButton
            // 
            this.toPositionButton.AutoSize = true;
            this.toPositionButton.Location = new System.Drawing.Point(121, 226);
            this.toPositionButton.Name = "toPositionButton";
            this.toPositionButton.Size = new System.Drawing.Size(110, 21);
            this.toPositionButton.TabIndex = 15;
            this.toPositionButton.Text = "На позиции:";
            this.toPositionButton.UseVisualStyleBackColor = true;
            // 
            // toEndButton
            // 
            this.toEndButton.AutoSize = true;
            this.toEndButton.Location = new System.Drawing.Point(121, 199);
            this.toEndButton.Name = "toEndButton";
            this.toEndButton.Size = new System.Drawing.Size(81, 21);
            this.toEndButton.TabIndex = 14;
            this.toEndButton.Text = "В конце";
            this.toEndButton.UseVisualStyleBackColor = true;
            // 
            // toBeginButton
            // 
            this.toBeginButton.AutoSize = true;
            this.toBeginButton.Checked = true;
            this.toBeginButton.Location = new System.Drawing.Point(121, 172);
            this.toBeginButton.Name = "toBeginButton";
            this.toBeginButton.Size = new System.Drawing.Size(90, 21);
            this.toBeginButton.TabIndex = 13;
            this.toBeginButton.TabStop = true;
            this.toBeginButton.Text = "В начале";
            this.toBeginButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Позиция:";
            // 
            // creditTypeListBox
            // 
            this.creditTypeListBox.FormattingEnabled = true;
            this.creditTypeListBox.ItemHeight = 16;
            this.creditTypeListBox.Items.AddRange(new object[] {
            "Ипотека",
            "Потребительский",
            "Автокредит"});
            this.creditTypeListBox.Location = new System.Drawing.Point(121, 80);
            this.creditTypeListBox.Name = "creditTypeListBox";
            this.creditTypeListBox.Size = new System.Drawing.Size(136, 52);
            this.creditTypeListBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(222, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "руб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(223, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "мес.";
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createButton.Location = new System.Drawing.Point(101, 264);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 28);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(121, 143);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 22);
            this.termTextBox.TabIndex = 7;
            this.termTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyNums_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(121, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyLetters_KeyPress);
            // 
            // creditAmountTextBox
            // 
            this.creditAmountTextBox.Location = new System.Drawing.Point(121, 49);
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.creditAmountTextBox.TabIndex = 4;
            this.creditAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOnlyNums_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(59, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Срок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид кредита:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма кредита:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // positionUpDown
            // 
            this.positionUpDown.Location = new System.Drawing.Point(239, 226);
            this.positionUpDown.Name = "positionUpDown";
            this.positionUpDown.Size = new System.Drawing.Size(76, 22);
            this.positionUpDown.TabIndex = 16;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 326);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddClientForm";
            this.Text = "Добавить запись";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox creditTypeListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox creditAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton toPositionButton;
        public System.Windows.Forms.RadioButton toEndButton;
        public System.Windows.Forms.RadioButton toBeginButton;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NumericUpDown positionUpDown;
    }
}