
namespace LabCalculator
{
    partial class Form1
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 12);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(100, 23);
            this.TextInput.TabIndex = 0;
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.Location = new System.Drawing.Point(118, 12);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalc.TabIndex = 1;
            this.ButtonCalc.Text = "Calc";
            this.ButtonCalc.UseVisualStyleBackColor = true;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelResult.Location = new System.Drawing.Point(12, 60);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 21);
            this.LabelResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 90);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "HW5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.Label LabelResult;
    }
}

