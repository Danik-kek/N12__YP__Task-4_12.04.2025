namespace N12__YP__Task_4_12._04._2025
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(120, 100);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(50, 20);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.Text = "а";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(120, 170);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 2;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(120, 130);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 30);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Подсчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Строка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Символ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}