
namespace LoanCalculator
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
            this.components = new System.ComponentModel.Container();
            this.numTerm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridLoans = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbLoanName = new System.Windows.Forms.Label();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.LoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPoolLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // numTerm
            // 
            this.numTerm.Location = new System.Drawing.Point(182, 36);
            this.numTerm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTerm.Name = "numTerm";
            this.numTerm.Size = new System.Drawing.Size(150, 27);
            this.numTerm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance (Amount, $)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Term (Month)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rate (%)";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(338, 36);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(150, 27);
            this.numRate.TabIndex = 4;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(517, 34);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(94, 29);
            this.btnAddLoan.TabIndex = 6;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridLoans);
            this.groupBox1.Location = new System.Drawing.Point(25, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loans";
            // 
            // gridLoans
            // 
            this.gridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoans.Location = new System.Drawing.Point(16, 26);
            this.gridLoans.Name = "gridLoans";
            this.gridLoans.RowHeadersWidth = 51;
            this.gridLoans.RowTemplate.Height = 29;
            this.gridLoans.Size = new System.Drawing.Size(559, 160);
            this.gridLoans.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(517, 291);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numBalance
            // 
            this.numBalance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBalance.Location = new System.Drawing.Point(25, 36);
            this.numBalance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(150, 27);
            this.numBalance.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPoolLevel);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.lbLoanName);
            this.groupBox2.Controls.Add(this.gridResults);
            this.groupBox2.Location = new System.Drawing.Point(23, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 346);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(138, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(361, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbLoanName
            // 
            this.lbLoanName.AutoSize = true;
            this.lbLoanName.Location = new System.Drawing.Point(18, 26);
            this.lbLoanName.Name = "lbLoanName";
            this.lbLoanName.Size = new System.Drawing.Size(53, 20);
            this.lbLoanName.TabIndex = 1;
            this.lbLoanName.Text = "Loan 1";
            // 
            // gridResults
            // 
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanId,
            this.Month,
            this.Interest,
            this.Principal,
            this.RemBalance});
            this.gridResults.Location = new System.Drawing.Point(18, 57);
            this.gridResults.Name = "gridResults";
            this.gridResults.RowHeadersWidth = 51;
            this.gridResults.RowTemplate.Height = 29;
            this.gridResults.Size = new System.Drawing.Size(559, 243);
            this.gridResults.TabIndex = 0;
            // 
            // LoanId
            // 
            this.LoanId.DataPropertyName = "LoanId";
            this.LoanId.HeaderText = "LoanId";
            this.LoanId.MinimumWidth = 6;
            this.LoanId.Name = "LoanId";
            this.LoanId.ReadOnly = true;
            this.LoanId.Visible = false;
            this.LoanId.Width = 70;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 70;
            // 
            // Interest
            // 
            this.Interest.DataPropertyName = "Interest";
            this.Interest.HeaderText = "Interest";
            this.Interest.MinimumWidth = 6;
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            this.Interest.Width = 90;
            // 
            // Principal
            // 
            this.Principal.DataPropertyName = "Principal";
            this.Principal.HeaderText = "Principal";
            this.Principal.MinimumWidth = 6;
            this.Principal.Name = "Principal";
            this.Principal.ReadOnly = true;
            this.Principal.Width = 90;
            // 
            // RemBalance
            // 
            this.RemBalance.DataPropertyName = "RemBalance";
            this.RemBalance.HeaderText = "RemBalance";
            this.RemBalance.MinimumWidth = 6;
            this.RemBalance.Name = "RemBalance";
            this.RemBalance.ReadOnly = true;
            this.RemBalance.Width = 90;
            // 
            // btnPoolLevel
            // 
            this.btnPoolLevel.Location = new System.Drawing.Point(238, 307);
            this.btnPoolLevel.Name = "btnPoolLevel";
            this.btnPoolLevel.Size = new System.Drawing.Size(117, 29);
            this.btnPoolLevel.TabIndex = 4;
            this.btnPoolLevel.Text = "Pool Level";
            this.btnPoolLevel.UseVisualStyleBackColor = true;
            this.btnPoolLevel.Click += new System.EventHandler(this.btnPoolLevel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numBalance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTerm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridLoans;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbLoanName;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemBalance;
        private System.Windows.Forms.Button btnPoolLevel;
    }
}

