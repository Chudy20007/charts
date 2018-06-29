namespace Functions
{
    partial class Form1
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
            this.rbFunction1 = new System.Windows.Forms.RadioButton();
            this.rbFunction2 = new System.Windows.Forms.RadioButton();
            this.tbValueB = new System.Windows.Forms.TextBox();
            this.tbValueA = new System.Windows.Forms.TextBox();
            this.lValueA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lValueB = new System.Windows.Forms.Label();
            this.lSelect = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbFunction1
            // 
            this.rbFunction1.AutoSize = true;
            this.rbFunction1.Location = new System.Drawing.Point(356, 77);
            this.rbFunction1.Name = "rbFunction1";
            this.rbFunction1.Size = new System.Drawing.Size(63, 17);
            this.rbFunction1.TabIndex = 0;
            this.rbFunction1.TabStop = true;
            this.rbFunction1.Text = "y=a*x^2";
            this.rbFunction1.UseVisualStyleBackColor = true;
            // 
            // rbFunction2
            // 
            this.rbFunction2.AutoSize = true;
            this.rbFunction2.Location = new System.Drawing.Point(356, 100);
            this.rbFunction2.Name = "rbFunction2";
            this.rbFunction2.Size = new System.Drawing.Size(60, 17);
            this.rbFunction2.TabIndex = 1;
            this.rbFunction2.TabStop = true;
            this.rbFunction2.Text = "y=a*x-b";
            this.rbFunction2.UseVisualStyleBackColor = true;
            // 
            // tbValueB
            // 
            this.tbValueB.Location = new System.Drawing.Point(126, 94);
            this.tbValueB.Name = "tbValueB";
            this.tbValueB.Size = new System.Drawing.Size(100, 20);
            this.tbValueB.TabIndex = 2;
            // 
            // tbValueA
            // 
            this.tbValueA.Location = new System.Drawing.Point(126, 57);
            this.tbValueA.Name = "tbValueA";
            this.tbValueA.Size = new System.Drawing.Size(100, 20);
            this.tbValueA.TabIndex = 3;
            // 
            // lValueA
            // 
            this.lValueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lValueA.Location = new System.Drawing.Point(12, 58);
            this.lValueA.Name = "lValueA";
            this.lValueA.Size = new System.Drawing.Size(108, 20);
            this.lValueA.TabIndex = 4;
            this.lValueA.Text = "Enter a value a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // lValueB
            // 
            this.lValueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lValueB.Location = new System.Drawing.Point(12, 97);
            this.lValueB.Name = "lValueB";
            this.lValueB.Size = new System.Drawing.Size(108, 20);
            this.lValueB.TabIndex = 6;
            this.lValueB.Text = "Enter a value b:";
            // 
            // lSelect
            // 
            this.lSelect.AutoSize = true;
            this.lSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSelect.Location = new System.Drawing.Point(353, 56);
            this.lSelect.Name = "lSelect";
            this.lSelect.Size = new System.Drawing.Size(125, 18);
            this.lSelect.TabIndex = 7;
            this.lSelect.Text = "Select function.";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(356, 134);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(111, 23);
            this.bGenerate.TabIndex = 8;
            this.bGenerate.Text = "Generate function";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 247);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.lSelect);
            this.Controls.Add(this.lValueB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lValueA);
            this.Controls.Add(this.tbValueA);
            this.Controls.Add(this.tbValueB);
            this.Controls.Add(this.rbFunction2);
            this.Controls.Add(this.rbFunction1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbValueB;
        private System.Windows.Forms.TextBox tbValueA;
        private System.Windows.Forms.Label lValueA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lValueB;
        private System.Windows.Forms.Label lSelect;
        private System.Windows.Forms.Button bGenerate;
        public System.Windows.Forms.RadioButton rbFunction1;
        public System.Windows.Forms.RadioButton rbFunction2;
    }
}

