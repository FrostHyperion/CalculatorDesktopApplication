namespace CalculatorDesktopApplication
{
    partial class Calculator
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
            this.labelOper = new System.Windows.Forms.Label();
            this.CalcDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnDivison = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnBin = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOper
            // 
            this.labelOper.AutoSize = true;
            this.labelOper.Location = new System.Drawing.Point(89, -1);
            this.labelOper.Name = "labelOper";
            this.labelOper.Size = new System.Drawing.Size(0, 20);
            this.labelOper.TabIndex = 3;
            this.labelOper.Click += new System.EventHandler(this.labelOper_Click);
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcDisplay.Location = new System.Drawing.Point(3, 3);
            this.CalcDisplay.Multiline = true;
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(331, 97);
            this.CalcDisplay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.labeloper);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnEquals, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnNum0, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNum3, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNum2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNum1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnSub, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnNum6, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnNum5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnNum4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDivison, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnNum9, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnNum8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnNum7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnMultiply, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnBin, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDec, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.6763F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.20809F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 363);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint_1);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Location = new System.Drawing.Point(3, 243);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(76, 54);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btn_equals);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(85, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 54);
            this.button3.TabIndex = 22;
            this.button3.Text = "AC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(167, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(249, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.Location = new System.Drawing.Point(3, 303);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(76, 57);
            this.btnNum0.TabIndex = 17;
            this.btnNum0.Text = "Loc";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btn_Convert);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(249, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 49);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.oper_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.Location = new System.Drawing.Point(167, 188);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(76, 49);
            this.btnNum3.TabIndex = 14;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.Location = new System.Drawing.Point(85, 188);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(76, 49);
            this.btnNum2.TabIndex = 13;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.Location = new System.Drawing.Point(3, 188);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(76, 49);
            this.btnNum1.TabIndex = 12;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSub.Location = new System.Drawing.Point(249, 123);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(79, 59);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.oper_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.Location = new System.Drawing.Point(167, 123);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(76, 59);
            this.btnNum6.TabIndex = 10;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.Location = new System.Drawing.Point(85, 123);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(76, 59);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.Location = new System.Drawing.Point(3, 123);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(76, 59);
            this.btnNum4.TabIndex = 8;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivison
            // 
            this.btnDivison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivison.Location = new System.Drawing.Point(249, 63);
            this.btnDivison.Name = "btnDivison";
            this.btnDivison.Size = new System.Drawing.Size(79, 54);
            this.btnDivison.TabIndex = 7;
            this.btnDivison.Text = "/";
            this.btnDivison.UseVisualStyleBackColor = true;
            this.btnDivison.Click += new System.EventHandler(this.oper_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.Location = new System.Drawing.Point(167, 63);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(76, 54);
            this.btnNum9.TabIndex = 6;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.Location = new System.Drawing.Point(85, 63);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(76, 54);
            this.btnNum8.TabIndex = 5;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.Location = new System.Drawing.Point(3, 63);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(76, 54);
            this.btnNum7.TabIndex = 4;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Location = new System.Drawing.Point(249, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(79, 54);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.oper_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(167, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 54);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // BtnBin
            // 
            this.BtnBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBin.Location = new System.Drawing.Point(85, 3);
            this.BtnBin.Name = "BtnBin";
            this.BtnBin.Size = new System.Drawing.Size(76, 54);
            this.BtnBin.TabIndex = 1;
            this.BtnBin.Text = "Bin";
            this.BtnBin.UseVisualStyleBackColor = true;
            this.BtnBin.Click += new System.EventHandler(this.btn_Convert);
            // 
            // btnDec
            // 
            this.btnDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDec.Location = new System.Drawing.Point(3, 3);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(76, 54);
            this.btnDec.TabIndex = 0;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btn_Convert);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalcDisplay, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelOper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelOper;
        private TextBox CalcDisplay;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEquals;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnNum0;
        private Button btnAdd;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnSub;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnDivison;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnMultiply;
        private Button btnClear;
        private Button BtnBin;
        private Button btnDec;
        private TableLayoutPanel tableLayoutPanel1;
    }
}