namespace DrinksDistributor.Forms.Views
{
    partial class ClientView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblForGridDrinks = new System.Windows.Forms.Label();
            this.dgrdDrinks = new System.Windows.Forms.DataGridView();
            this.lblSelectDrink = new System.Windows.Forms.Label();
            this.cbxSelectDrink = new System.Windows.Forms.ComboBox();
            this.lblAmountMoneyDrink = new System.Windows.Forms.Label();
            this.tbxAmountMoneyDrink = new System.Windows.Forms.TextBox();
            this.lblPutMoney = new System.Windows.Forms.Label();
            this.tbxInputMoney = new System.Windows.Forms.TextBox();
            this.btnPayDrink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForGridDrinks
            // 
            this.lblForGridDrinks.AutoSize = true;
            this.lblForGridDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForGridDrinks.Location = new System.Drawing.Point(3, 16);
            this.lblForGridDrinks.Name = "lblForGridDrinks";
            this.lblForGridDrinks.Size = new System.Drawing.Size(195, 20);
            this.lblForGridDrinks.TabIndex = 0;
            this.lblForGridDrinks.Text = "List of Drinks available:";
            // 
            // dgrdDrinks
            // 
            this.dgrdDrinks.AllowUserToDeleteRows = false;
            this.dgrdDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdDrinks.Location = new System.Drawing.Point(3, 39);
            this.dgrdDrinks.Name = "dgrdDrinks";
            this.dgrdDrinks.ReadOnly = true;
            this.dgrdDrinks.RowTemplate.Height = 28;
            this.dgrdDrinks.Size = new System.Drawing.Size(1094, 227);
            this.dgrdDrinks.TabIndex = 1;
            // 
            // lblSelectDrink
            // 
            this.lblSelectDrink.AutoSize = true;
            this.lblSelectDrink.Location = new System.Drawing.Point(2, 286);
            this.lblSelectDrink.Name = "lblSelectDrink";
            this.lblSelectDrink.Size = new System.Drawing.Size(112, 20);
            this.lblSelectDrink.TabIndex = 2;
            this.lblSelectDrink.Text = "Select a Drink:";
            // 
            // cbxSelectDrink
            // 
            this.cbxSelectDrink.FormattingEnabled = true;
            this.cbxSelectDrink.Location = new System.Drawing.Point(265, 283);
            this.cbxSelectDrink.Name = "cbxSelectDrink";
            this.cbxSelectDrink.Size = new System.Drawing.Size(433, 28);
            this.cbxSelectDrink.TabIndex = 3;
            this.cbxSelectDrink.SelectedIndexChanged += new System.EventHandler(this.cbxSelectDrink_SelectedIndexChanged);
            // 
            // lblAmountMoneyDrink
            // 
            this.lblAmountMoneyDrink.AutoSize = true;
            this.lblAmountMoneyDrink.Location = new System.Drawing.Point(2, 325);
            this.lblAmountMoneyDrink.Name = "lblAmountMoneyDrink";
            this.lblAmountMoneyDrink.Size = new System.Drawing.Size(231, 20);
            this.lblAmountMoneyDrink.TabIndex = 4;
            this.lblAmountMoneyDrink.Text = "Amount of money for this Drink:";
            // 
            // tbxAmountMoneyDrink
            // 
            this.tbxAmountMoneyDrink.Enabled = false;
            this.tbxAmountMoneyDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmountMoneyDrink.Location = new System.Drawing.Point(384, 322);
            this.tbxAmountMoneyDrink.Name = "tbxAmountMoneyDrink";
            this.tbxAmountMoneyDrink.Size = new System.Drawing.Size(314, 26);
            this.tbxAmountMoneyDrink.TabIndex = 5;
            this.tbxAmountMoneyDrink.Text = "(Select a Drink)";
            this.tbxAmountMoneyDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPutMoney
            // 
            this.lblPutMoney.AutoSize = true;
            this.lblPutMoney.Location = new System.Drawing.Point(2, 362);
            this.lblPutMoney.Name = "lblPutMoney";
            this.lblPutMoney.Size = new System.Drawing.Size(122, 20);
            this.lblPutMoney.TabIndex = 6;
            this.lblPutMoney.Text = "Put your money:";
            // 
            // tbxInputMoney
            // 
            this.tbxInputMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInputMoney.Location = new System.Drawing.Point(384, 359);
            this.tbxInputMoney.Name = "tbxInputMoney";
            this.tbxInputMoney.Size = new System.Drawing.Size(314, 26);
            this.tbxInputMoney.TabIndex = 7;
            this.tbxInputMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayDrink
            // 
            this.btnPayDrink.Location = new System.Drawing.Point(813, 283);
            this.btnPayDrink.Name = "btnPayDrink";
            this.btnPayDrink.Size = new System.Drawing.Size(200, 102);
            this.btnPayDrink.TabIndex = 8;
            this.btnPayDrink.Text = "Pay Drink";
            this.btnPayDrink.UseVisualStyleBackColor = true;
            this.btnPayDrink.Click += new System.EventHandler(this.btnPayDrink_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnPayDrink);
            this.Controls.Add(this.tbxInputMoney);
            this.Controls.Add(this.lblPutMoney);
            this.Controls.Add(this.tbxAmountMoneyDrink);
            this.Controls.Add(this.lblAmountMoneyDrink);
            this.Controls.Add(this.cbxSelectDrink);
            this.Controls.Add(this.lblSelectDrink);
            this.Controls.Add(this.dgrdDrinks);
            this.Controls.Add(this.lblForGridDrinks);
            this.Name = "ClientView";
            this.Size = new System.Drawing.Size(1100, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForGridDrinks;
        private System.Windows.Forms.DataGridView dgrdDrinks;
        private System.Windows.Forms.Label lblSelectDrink;
        private System.Windows.Forms.ComboBox cbxSelectDrink;
        private System.Windows.Forms.Label lblAmountMoneyDrink;
        private System.Windows.Forms.TextBox tbxAmountMoneyDrink;
        private System.Windows.Forms.Label lblPutMoney;
        private System.Windows.Forms.TextBox tbxInputMoney;
        private System.Windows.Forms.Button btnPayDrink;
    }
}
