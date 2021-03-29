
namespace Delphi_StringConvert
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSQLAdd = new System.Windows.Forms.RadioButton();
            this.radsSQL = new System.Windows.Forms.RadioButton();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSQL2str = new System.Windows.Forms.Button();
            this.btnstr2SQL = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCleartxt = new System.Windows.Forms.Button();
            this.labMemo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSQLAdd);
            this.groupBox1.Controls.Add(this.radsSQL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇轉換方式";
            // 
            // radSQLAdd
            // 
            this.radSQLAdd.AutoSize = true;
            this.radSQLAdd.Location = new System.Drawing.Point(6, 37);
            this.radSQLAdd.Name = "radSQLAdd";
            this.radSQLAdd.Size = new System.Drawing.Size(96, 22);
            this.radSQLAdd.TabIndex = 3;
            this.radSQLAdd.TabStop = true;
            this.radSQLAdd.Text = "SQL.Add";
            this.radSQLAdd.UseVisualStyleBackColor = true;
            this.radSQLAdd.Click += new System.EventHandler(this.radSQLAdd_Click);
            // 
            // radsSQL
            // 
            this.radsSQL.AutoSize = true;
            this.radsSQL.Location = new System.Drawing.Point(108, 37);
            this.radsSQL.Name = "radsSQL";
            this.radsSQL.Size = new System.Drawing.Size(93, 22);
            this.radsSQL.TabIndex = 4;
            this.radsSQL.TabStop = true;
            this.radsSQL.Text = "radsSQL";
            this.radsSQL.UseVisualStyleBackColor = true;
            this.radsSQL.Click += new System.EventHandler(this.radsSQL_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(279, 12);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(1065, 286);
            this.txtSource.TabIndex = 1;
            // 
            // btnSQL2str
            // 
            this.btnSQL2str.Location = new System.Drawing.Point(12, 120);
            this.btnSQL2str.Name = "btnSQL2str";
            this.btnSQL2str.Size = new System.Drawing.Size(115, 39);
            this.btnSQL2str.TabIndex = 2;
            this.btnSQL2str.Text = "SQLtoString";
            this.btnSQL2str.UseVisualStyleBackColor = true;
            this.btnSQL2str.Click += new System.EventHandler(this.btnSQL2str_Click);
            // 
            // btnstr2SQL
            // 
            this.btnstr2SQL.Location = new System.Drawing.Point(146, 120);
            this.btnstr2SQL.Name = "btnstr2SQL";
            this.btnstr2SQL.Size = new System.Drawing.Size(112, 39);
            this.btnstr2SQL.TabIndex = 3;
            this.btnstr2SQL.Text = "str2SQL";
            this.btnstr2SQL.UseVisualStyleBackColor = true;
            this.btnstr2SQL.Click += new System.EventHandler(this.btnstr2SQL_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(279, 327);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1065, 366);
            this.txtResult.TabIndex = 4;
            // 
            // btnCleartxt
            // 
            this.btnCleartxt.Location = new System.Drawing.Point(279, 699);
            this.btnCleartxt.Name = "btnCleartxt";
            this.btnCleartxt.Size = new System.Drawing.Size(100, 57);
            this.btnCleartxt.TabIndex = 5;
            this.btnCleartxt.Text = "清除";
            this.btnCleartxt.UseVisualStyleBackColor = true;
            this.btnCleartxt.Click += new System.EventHandler(this.btnCleartxt_Click);
            // 
            // labMemo
            // 
            this.labMemo.AutoSize = true;
            this.labMemo.Location = new System.Drawing.Point(416, 738);
            this.labMemo.Name = "labMemo";
            this.labMemo.Size = new System.Drawing.Size(0, 18);
            this.labMemo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 800);
            this.Controls.Add(this.labMemo);
            this.Controls.Add(this.btnCleartxt);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnstr2SQL);
            this.Controls.Add(this.btnSQL2str);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DelpPhiSQLStringConverter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSQLAdd;
        private System.Windows.Forms.RadioButton radsSQL;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSQL2str;
        private System.Windows.Forms.Button btnstr2SQL;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCleartxt;
        private System.Windows.Forms.Label labMemo;
    }
}

