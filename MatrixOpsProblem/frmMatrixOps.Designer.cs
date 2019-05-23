namespace MatrixOpsProblem
{
    partial class frmMatrixOps
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
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.btnMakeMatrixA = new System.Windows.Forms.Button();
            this.btnMakeMatrixB = new System.Windows.Forms.Button();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearMatrices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbSelectOperation = new System.Windows.Forms.GroupBox();
            this.rdbSubtract = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.txtRowsA = new System.Windows.Forms.TextBox();
            this.txtRowsB = new System.Windows.Forms.TextBox();
            this.txtColsA = new System.Windows.Forms.TextBox();
            this.txtColsB = new System.Windows.Forms.TextBox();
            this.grpbSelectOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(12, 34);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixA.TabIndex = 0;
            this.txtMatrixA.TabStop = false;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(212, 34);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixB.TabIndex = 1;
            this.txtMatrixB.TabStop = false;
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(409, 34);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixC.TabIndex = 2;
            this.txtMatrixC.TabStop = false;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(13, 15);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixA.TabIndex = 3;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(209, 15);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixB.TabIndex = 4;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(406, 18);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixC.TabIndex = 5;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(164, 252);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(289, 252);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(27, 13);
            this.lblCols.TabIndex = 7;
            this.lblCols.Text = "Cols";
            // 
            // btnMakeMatrixA
            // 
            this.btnMakeMatrixA.Location = new System.Drawing.Point(12, 280);
            this.btnMakeMatrixA.Name = "btnMakeMatrixA";
            this.btnMakeMatrixA.Size = new System.Drawing.Size(140, 23);
            this.btnMakeMatrixA.TabIndex = 8;
            this.btnMakeMatrixA.Text = "Make Matrix A";
            this.btnMakeMatrixA.UseVisualStyleBackColor = true;
            this.btnMakeMatrixA.Click += new System.EventHandler(this.btnMakeMatrixA_Click);
            // 
            // btnMakeMatrixB
            // 
            this.btnMakeMatrixB.Location = new System.Drawing.Point(12, 317);
            this.btnMakeMatrixB.Name = "btnMakeMatrixB";
            this.btnMakeMatrixB.Size = new System.Drawing.Size(140, 23);
            this.btnMakeMatrixB.TabIndex = 9;
            this.btnMakeMatrixB.Text = "Make Matrix B";
            this.btnMakeMatrixB.UseVisualStyleBackColor = true;
            this.btnMakeMatrixB.Click += new System.EventHandler(this.btnMakeMatrixB_Click);
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(400, 315);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(108, 23);
            this.btnMakeBIdentity.TabIndex = 10;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            this.btnMakeBIdentity.Click += new System.EventHandler(this.btnMakeBIdentity_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(12, 409);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearMatrices
            // 
            this.btnClearMatrices.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearMatrices.Location = new System.Drawing.Point(377, 409);
            this.btnClearMatrices.Name = "btnClearMatrices";
            this.btnClearMatrices.Size = new System.Drawing.Size(131, 23);
            this.btnClearMatrices.TabIndex = 12;
            this.btnClearMatrices.Text = "Clear Matrices";
            this.btnClearMatrices.UseVisualStyleBackColor = true;
            this.btnClearMatrices.Click += new System.EventHandler(this.btnClearMatrices_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(514, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpbSelectOperation
            // 
            this.grpbSelectOperation.Controls.Add(this.rdbSubtract);
            this.grpbSelectOperation.Controls.Add(this.rdbAdd);
            this.grpbSelectOperation.Controls.Add(this.rdbMultiply);
            this.grpbSelectOperation.Location = new System.Drawing.Point(12, 346);
            this.grpbSelectOperation.Name = "grpbSelectOperation";
            this.grpbSelectOperation.Size = new System.Drawing.Size(291, 44);
            this.grpbSelectOperation.TabIndex = 14;
            this.grpbSelectOperation.TabStop = false;
            this.grpbSelectOperation.Text = "Select Operation";
            // 
            // rdbSubtract
            // 
            this.rdbSubtract.AutoSize = true;
            this.rdbSubtract.Location = new System.Drawing.Point(187, 19);
            this.rdbSubtract.Name = "rdbSubtract";
            this.rdbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rdbSubtract.TabIndex = 2;
            this.rdbSubtract.TabStop = true;
            this.rdbSubtract.Text = "Subtract";
            this.rdbSubtract.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(96, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(44, 17);
            this.rdbAdd.TabIndex = 1;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(7, 20);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rdbMultiply.TabIndex = 0;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "Multiply";
            this.rdbMultiply.UseVisualStyleBackColor = true;
            // 
            // txtRowsA
            // 
            this.txtRowsA.Location = new System.Drawing.Point(167, 283);
            this.txtRowsA.Name = "txtRowsA";
            this.txtRowsA.Size = new System.Drawing.Size(100, 20);
            this.txtRowsA.TabIndex = 16;
            // 
            // txtRowsB
            // 
            this.txtRowsB.Location = new System.Drawing.Point(167, 317);
            this.txtRowsB.Name = "txtRowsB";
            this.txtRowsB.Size = new System.Drawing.Size(100, 20);
            this.txtRowsB.TabIndex = 17;
            // 
            // txtColsA
            // 
            this.txtColsA.Location = new System.Drawing.Point(292, 282);
            this.txtColsA.Name = "txtColsA";
            this.txtColsA.Size = new System.Drawing.Size(100, 20);
            this.txtColsA.TabIndex = 18;
            // 
            // txtColsB
            // 
            this.txtColsB.Location = new System.Drawing.Point(292, 317);
            this.txtColsB.Name = "txtColsB";
            this.txtColsB.Size = new System.Drawing.Size(100, 20);
            this.txtColsB.TabIndex = 19;
            // 
            // frmMatrixOps
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(601, 444);
            this.Controls.Add(this.txtColsB);
            this.Controls.Add(this.txtColsA);
            this.Controls.Add(this.txtRowsB);
            this.Controls.Add(this.txtRowsA);
            this.Controls.Add(this.grpbSelectOperation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearMatrices);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.btnMakeMatrixB);
            this.Controls.Add(this.btnMakeMatrixA);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Name = "frmMatrixOps";
            this.Text = "Matrix Ops";
            this.Load += new System.EventHandler(this.frmMatrixOps_Load);
            this.grpbSelectOperation.ResumeLayout(false);
            this.grpbSelectOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Button btnMakeMatrixA;
        private System.Windows.Forms.Button btnMakeMatrixB;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearMatrices;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbSelectOperation;
        private System.Windows.Forms.RadioButton rdbSubtract;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.TextBox txtRowsA;
        private System.Windows.Forms.TextBox txtRowsB;
        private System.Windows.Forms.TextBox txtColsA;
        private System.Windows.Forms.TextBox txtColsB;
    }
}

