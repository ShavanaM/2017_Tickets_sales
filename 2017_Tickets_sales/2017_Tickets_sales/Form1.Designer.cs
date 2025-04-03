namespace _2017_Tickets_sales
{
    partial class frm_2017_Tickets_sales
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtoNoTickets = new System.Windows.Forms.TextBox();
            this.txtoPrice = new System.Windows.Forms.TextBox();
            this.txtiNoTickets = new System.Windows.Forms.TextBox();
            this.txtiPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(137, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 44);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of outdoor tickets sold:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price of each outdoor ticket:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of indoor ticket sold: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price of each indoor ticket:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(62, 261);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(337, 23);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // txtoNoTickets
            // 
            this.txtoNoTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoNoTickets.Location = new System.Drawing.Point(284, 38);
            this.txtoNoTickets.Name = "txtoNoTickets";
            this.txtoNoTickets.Size = new System.Drawing.Size(100, 22);
            this.txtoNoTickets.TabIndex = 6;
            // 
            // txtoPrice
            // 
            this.txtoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoPrice.Location = new System.Drawing.Point(284, 76);
            this.txtoPrice.Name = "txtoPrice";
            this.txtoPrice.Size = new System.Drawing.Size(100, 22);
            this.txtoPrice.TabIndex = 7;
            // 
            // txtiNoTickets
            // 
            this.txtiNoTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiNoTickets.Location = new System.Drawing.Point(284, 116);
            this.txtiNoTickets.Name = "txtiNoTickets";
            this.txtiNoTickets.Size = new System.Drawing.Size(100, 22);
            this.txtiNoTickets.TabIndex = 8;
            // 
            // txtiPrice
            // 
            this.txtiPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiPrice.Location = new System.Drawing.Point(284, 156);
            this.txtiPrice.Name = "txtiPrice";
            this.txtiPrice.Size = new System.Drawing.Size(100, 22);
            this.txtiPrice.TabIndex = 9;
            // 
            // frm_2017_Tickets_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 299);
            this.Controls.Add(this.txtiPrice);
            this.Controls.Add(this.txtiNoTickets);
            this.Controls.Add(this.txtoPrice);
            this.Controls.Add(this.txtoNoTickets);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frm_2017_Tickets_sales";
            this.Text = "2017 Tickets sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtoNoTickets;
        private System.Windows.Forms.TextBox txtoPrice;
        private System.Windows.Forms.TextBox txtiNoTickets;
        private System.Windows.Forms.TextBox txtiPrice;
    }
}

