namespace BusquedaBinaria
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
            this.tbNumbersList = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblNumbersList = new System.Windows.Forms.Label();
            this.lblNumToSort = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNumbersList
            // 
            this.tbNumbersList.Location = new System.Drawing.Point(200, 97);
            this.tbNumbersList.Name = "tbNumbersList";
            this.tbNumbersList.Size = new System.Drawing.Size(242, 20);
            this.tbNumbersList.TabIndex = 0;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(200, 163);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // lblNumbersList
            // 
            this.lblNumbersList.AutoSize = true;
            this.lblNumbersList.Location = new System.Drawing.Point(197, 71);
            this.lblNumbersList.Name = "lblNumbersList";
            this.lblNumbersList.Size = new System.Drawing.Size(245, 13);
            this.lblNumbersList.TabIndex = 2;
            this.lblNumbersList.Text = "Ingrese la lista de números (separados por comas):";
            this.lblNumbersList.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumToSort
            // 
            this.lblNumToSort.AutoSize = true;
            this.lblNumToSort.Location = new System.Drawing.Point(197, 133);
            this.lblNumToSort.Name = "lblNumToSort";
            this.lblNumToSort.Size = new System.Drawing.Size(91, 13);
            this.lblNumToSort.TabIndex = 3;
            this.lblNumToSort.Text = "Número a buscar:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 204);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Encontrar Vaor";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(197, 255);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado:";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(200, 280);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(242, 20);
            this.tbResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNumToSort);
            this.Controls.Add(this.lblNumbersList);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbNumbersList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumbersList;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblNumbersList;
        private System.Windows.Forms.Label lblNumToSort;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

