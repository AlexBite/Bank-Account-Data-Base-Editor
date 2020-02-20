namespace LAB_8
{
    partial class SortedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outputGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summCreditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindOfCreditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // outputGridView
            // 
            this.outputGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.outputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.nameColumn,
            this.summCreditColumn,
            this.kindOfCreditColumn,
            this.periodColumn});
            this.outputGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputGridView.Location = new System.Drawing.Point(0, 0);
            this.outputGridView.Name = "outputGridView";
            this.outputGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.outputGridView.RowHeadersWidth = 51;
            this.outputGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.outputGridView.RowTemplate.Height = 24;
            this.outputGridView.Size = new System.Drawing.Size(800, 438);
            this.outputGridView.TabIndex = 1;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "ФИО";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // summCreditColumn
            // 
            this.summCreditColumn.HeaderText = "Сумма кредита (руб.)";
            this.summCreditColumn.MinimumWidth = 6;
            this.summCreditColumn.Name = "summCreditColumn";
            this.summCreditColumn.ReadOnly = true;
            // 
            // kindOfCreditColumn
            // 
            this.kindOfCreditColumn.HeaderText = "Вид кредита";
            this.kindOfCreditColumn.MinimumWidth = 6;
            this.kindOfCreditColumn.Name = "kindOfCreditColumn";
            this.kindOfCreditColumn.ReadOnly = true;
            // 
            // periodColumn
            // 
            this.periodColumn.HeaderText = "Срок (мес.)";
            this.periodColumn.MinimumWidth = 6;
            this.periodColumn.Name = "periodColumn";
            this.periodColumn.ReadOnly = true;
            // 
            // SortedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputGridView);
            this.Name = "SortedForm";
            this.Text = "SortedForm";
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView outputGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summCreditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindOfCreditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodColumn;
    }
}