namespace DIPS3
{
    partial class MainForm
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
            this.fioLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Tabel = new System.Windows.Forms.DataGridView();
            this.WordBtn = new System.Windows.Forms.Button();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(12, 9);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(54, 26);
            this.fioLabel.TabIndex = 0;
            this.fioLabel.Text = "ФИО";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 48);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(112, 26);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Телефон +7";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(12, 88);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 26);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Адрес";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(130, 45);
            this.phoneTextBox.Mask = "(999) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(129, 29);
            this.phoneTextBox.TabIndex = 4;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.Location = new System.Drawing.Point(82, 9);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(177, 26);
            this.fioTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(82, 89);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(177, 26);
            this.addressTextBox.TabIndex = 6;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.ExcelBtn);
            this.splitContainer.Panel1.Controls.Add(this.WordBtn);
            this.splitContainer.Panel1.Controls.Add(this.addressLabel);
            this.splitContainer.Panel1.Controls.Add(this.phoneLabel);
            this.splitContainer.Panel1.Controls.Add(this.fioLabel);
            this.splitContainer.Panel1.Controls.Add(this.addressTextBox);
            this.splitContainer.Panel1.Controls.Add(this.fioTextBox);
            this.splitContainer.Panel1.Controls.Add(this.phoneTextBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.Tabel);
            this.splitContainer.Size = new System.Drawing.Size(271, 401);
            this.splitContainer.SplitterDistance = 150;
            this.splitContainer.TabIndex = 7;
            // 
            // Tabel
            // 
            this.Tabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Предмет,
            this.Оценка});
            this.Tabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabel.Location = new System.Drawing.Point(0, 0);
            this.Tabel.Name = "Tabel";
            this.Tabel.Size = new System.Drawing.Size(271, 247);
            this.Tabel.TabIndex = 0;
            this.Tabel.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabel_RowValidated);
            // 
            // WordBtn
            // 
            this.WordBtn.Location = new System.Drawing.Point(34, 124);
            this.WordBtn.Name = "WordBtn";
            this.WordBtn.Size = new System.Drawing.Size(75, 23);
            this.WordBtn.TabIndex = 7;
            this.WordBtn.Text = "Word";
            this.WordBtn.UseVisualStyleBackColor = true;
            this.WordBtn.Click += new System.EventHandler(this.WordBtn_Click);
            // 
            // Предмет
            // 
            this.Предмет.HeaderText = "Предмет";
            this.Предмет.Name = "Предмет";
            // 
            // Оценка
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Оценка.DefaultCellStyle = dataGridViewCellStyle1;
            this.Оценка.HeaderText = "Оценка";
            this.Оценка.MaxInputLength = 100;
            this.Оценка.Name = "Оценка";
            this.Оценка.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(142, 121);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(75, 23);
            this.ExcelBtn.TabIndex = 8;
            this.ExcelBtn.Text = "Excel";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 401);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "DIPS3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView Tabel;
        private System.Windows.Forms.Button WordBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценка;
        private System.Windows.Forms.Button ExcelBtn;
    }
}

