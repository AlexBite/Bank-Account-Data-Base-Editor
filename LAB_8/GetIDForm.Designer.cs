namespace LAB_8
{
    partial class GetIDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idUpDown = new System.Windows.Forms.NumericUpDown();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ID клиента:";
            // 
            // idUpDown
            // 
            this.idUpDown.Location = new System.Drawing.Point(30, 32);
            this.idUpDown.Name = "idUpDown";
            this.idUpDown.Size = new System.Drawing.Size(111, 22);
            this.idUpDown.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(30, 60);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(111, 29);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Продолжить";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // GetIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 100);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.idUpDown);
            this.Controls.Add(this.label1);
            this.Name = "GetIDForm";
            this.Text = "ID";
            ((System.ComponentModel.ISupportInitialize)(this.idUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown idUpDown;
        public System.Windows.Forms.Button continueButton;
    }
}