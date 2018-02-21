namespace DrinksDistributor.Forms.Views
{
    partial class AdminView
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
            this.dgrdCoinStocks = new System.Windows.Forms.DataGridView();
            this.lblForGridCoinStocks = new System.Windows.Forms.Label();
            this.btnRefreshCoinStocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCoinStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdCoinStocks
            // 
            this.dgrdCoinStocks.AllowUserToDeleteRows = false;
            this.dgrdCoinStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdCoinStocks.Location = new System.Drawing.Point(3, 33);
            this.dgrdCoinStocks.Name = "dgrdCoinStocks";
            this.dgrdCoinStocks.ReadOnly = true;
            this.dgrdCoinStocks.RowTemplate.Height = 28;
            this.dgrdCoinStocks.Size = new System.Drawing.Size(1094, 364);
            this.dgrdCoinStocks.TabIndex = 3;
            // 
            // lblForGridCoinStocks
            // 
            this.lblForGridCoinStocks.AutoSize = true;
            this.lblForGridCoinStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForGridCoinStocks.Location = new System.Drawing.Point(3, 10);
            this.lblForGridCoinStocks.Name = "lblForGridCoinStocks";
            this.lblForGridCoinStocks.Size = new System.Drawing.Size(237, 20);
            this.lblForGridCoinStocks.TabIndex = 2;
            this.lblForGridCoinStocks.Text = "List of Coin stocks available:";
            // 
            // btnRefreshCoinStocks
            // 
            this.btnRefreshCoinStocks.Location = new System.Drawing.Point(454, 403);
            this.btnRefreshCoinStocks.Name = "btnRefreshCoinStocks";
            this.btnRefreshCoinStocks.Size = new System.Drawing.Size(200, 50);
            this.btnRefreshCoinStocks.TabIndex = 4;
            this.btnRefreshCoinStocks.Text = "Refresh";
            this.btnRefreshCoinStocks.UseVisualStyleBackColor = true;
            this.btnRefreshCoinStocks.Click += new System.EventHandler(this.btnRefreshCoinStocks_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRefreshCoinStocks);
            this.Controls.Add(this.dgrdCoinStocks);
            this.Controls.Add(this.lblForGridCoinStocks);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(1100, 466);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCoinStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdCoinStocks;
        private System.Windows.Forms.Label lblForGridCoinStocks;
        private System.Windows.Forms.Button btnRefreshCoinStocks;
    }
}
