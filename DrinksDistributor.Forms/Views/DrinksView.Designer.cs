namespace DrinksDistributor.Forms.Views
{
    partial class DrinksView
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
            this.dgrdDrinks = new System.Windows.Forms.DataGridView();
            this.lblForGridDrinks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdDrinks
            // 
            this.dgrdDrinks.AllowUserToDeleteRows = false;
            this.dgrdDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdDrinks.Location = new System.Drawing.Point(3, 30);
            this.dgrdDrinks.Name = "dgrdDrinks";
            this.dgrdDrinks.ReadOnly = true;
            this.dgrdDrinks.RowTemplate.Height = 28;
            this.dgrdDrinks.Size = new System.Drawing.Size(1094, 364);
            this.dgrdDrinks.TabIndex = 5;
            // 
            // lblForGridDrinks
            // 
            this.lblForGridDrinks.AutoSize = true;
            this.lblForGridDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForGridDrinks.Location = new System.Drawing.Point(3, 7);
            this.lblForGridDrinks.Name = "lblForGridDrinks";
            this.lblForGridDrinks.Size = new System.Drawing.Size(195, 20);
            this.lblForGridDrinks.TabIndex = 4;
            this.lblForGridDrinks.Text = "List of Drinks available:";
            // 
            // DrinksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgrdDrinks);
            this.Controls.Add(this.lblForGridDrinks);
            this.Name = "DrinksView";
            this.Size = new System.Drawing.Size(1100, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdDrinks;
        private System.Windows.Forms.Label lblForGridDrinks;
    }
}
