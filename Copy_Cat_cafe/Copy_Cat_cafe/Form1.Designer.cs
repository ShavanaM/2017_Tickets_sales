namespace Copy_Cat_cafe
{
    partial class frm_Copy_Cat_Cafe
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
            this.btnCost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radSuperior = new System.Windows.Forms.RadioButton();
            this.txtNoCopies = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCost
            // 
            this.btnCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCost.Location = new System.Drawing.Point(142, 447);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(147, 48);
            this.btnCost.TabIndex = 0;
            this.btnCost.Text = "Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copy Cat Cafe";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the No of Copies";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Paper Type";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStandard.Location = new System.Drawing.Point(262, 178);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(128, 22);
            this.radStandard.TabIndex = 4;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard Paper";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // radSuperior
            // 
            this.radSuperior.AutoSize = true;
            this.radSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSuperior.Location = new System.Drawing.Point(262, 221);
            this.radSuperior.Name = "radSuperior";
            this.radSuperior.Size = new System.Drawing.Size(125, 22);
            this.radSuperior.TabIndex = 5;
            this.radSuperior.TabStop = true;
            this.radSuperior.Text = "Superior Paper";
            this.radSuperior.UseVisualStyleBackColor = true;
            // 
            // txtNoCopies
            // 
            this.txtNoCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCopies.Location = new System.Drawing.Point(44, 195);
            this.txtNoCopies.Name = "txtNoCopies";
            this.txtNoCopies.Size = new System.Drawing.Size(124, 24);
            this.txtNoCopies.TabIndex = 6;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(62, 308);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(325, 118);
            this.lblDisplay.TabIndex = 7;
            // 
            // frm_Copy_Cat_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 527);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtNoCopies);
            this.Controls.Add(this.radSuperior);
            this.Controls.Add(this.radStandard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCost);
            this.Name = "frm_Copy_Cat_Cafe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radSuperior;
        private System.Windows.Forms.TextBox txtNoCopies;
        private System.Windows.Forms.Label lblDisplay;
    }
}

