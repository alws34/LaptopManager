namespace InventoryManager
{
    partial class UCLaptop
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
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbNumInSystem = new System.Windows.Forms.TextBox();
            this.tbSuppliedTo = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblNumInLaptopSystems = new System.Windows.Forms.Label();
            this.lblSuppliedTo = new System.Windows.Forms.Label();
            this.lblIsInStock = new System.Windows.Forms.Label();
            this.cbIsInStock = new System.Windows.Forms.CheckBox();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlStockIndicator = new System.Windows.Forms.Panel();
            this.lblisInStockIndicator = new System.Windows.Forms.Label();
            this.pnlStockIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbModel
            // 
            this.tbModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(139, 32);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(155, 19);
            this.tbModel.TabIndex = 0;
            this.tbModel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_KeyUp);
            // 
            // tbSN
            // 
            this.tbSN.BackColor = System.Drawing.SystemColors.Window;
            this.tbSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSN.Location = new System.Drawing.Point(139, 6);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(155, 19);
            this.tbSN.TabIndex = 1;
            this.tbSN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_KeyUp);
            // 
            // tbNumInSystem
            // 
            this.tbNumInSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumInSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumInSystem.Location = new System.Drawing.Point(139, 58);
            this.tbNumInSystem.Name = "tbNumInSystem";
            this.tbNumInSystem.Size = new System.Drawing.Size(155, 19);
            this.tbNumInSystem.TabIndex = 2;
            this.tbNumInSystem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_KeyUp);
            // 
            // tbSuppliedTo
            // 
            this.tbSuppliedTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSuppliedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuppliedTo.Location = new System.Drawing.Point(139, 83);
            this.tbSuppliedTo.Name = "tbSuppliedTo";
            this.tbSuppliedTo.Size = new System.Drawing.Size(155, 19);
            this.tbSuppliedTo.TabIndex = 3;
            this.tbSuppliedTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_KeyUp);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(3, 27);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 20);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(3, 2);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(122, 20);
            this.lblSN.TabIndex = 6;
            this.lblSN.Text = "Serial Number";
            // 
            // lblNumInLaptopSystems
            // 
            this.lblNumInLaptopSystems.AutoSize = true;
            this.lblNumInLaptopSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInLaptopSystems.Location = new System.Drawing.Point(3, 52);
            this.lblNumInLaptopSystems.Name = "lblNumInLaptopSystems";
            this.lblNumInLaptopSystems.Size = new System.Drawing.Size(80, 20);
            this.lblNumInLaptopSystems.TabIndex = 7;
            this.lblNumInLaptopSystems.Text = "Num 100";
            // 
            // lblSuppliedTo
            // 
            this.lblSuppliedTo.AutoSize = true;
            this.lblSuppliedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliedTo.Location = new System.Drawing.Point(3, 78);
            this.lblSuppliedTo.Name = "lblSuppliedTo";
            this.lblSuppliedTo.Size = new System.Drawing.Size(104, 20);
            this.lblSuppliedTo.TabIndex = 8;
            this.lblSuppliedTo.Text = "Supplied To";
            // 
            // lblIsInStock
            // 
            this.lblIsInStock.AutoSize = true;
            this.lblIsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsInStock.Location = new System.Drawing.Point(3, 104);
            this.lblIsInStock.Name = "lblIsInStock";
            this.lblIsInStock.Size = new System.Drawing.Size(76, 20);
            this.lblIsInStock.TabIndex = 9;
            this.lblIsInStock.Text = "In Stock";
            // 
            // cbIsInStock
            // 
            this.cbIsInStock.AutoSize = true;
            this.cbIsInStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cbIsInStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.cbIsInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsInStock.ForeColor = System.Drawing.Color.White;
            this.cbIsInStock.Location = new System.Drawing.Point(139, 114);
            this.cbIsInStock.Name = "cbIsInStock";
            this.cbIsInStock.Size = new System.Drawing.Size(12, 11);
            this.cbIsInStock.TabIndex = 10;
            this.cbIsInStock.UseVisualStyleBackColor = true;
            this.cbIsInStock.CheckedChanged += new System.EventHandler(this.cbIsInStock_CheckedChanged);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.ForeColor = System.Drawing.Color.Black;
            this.btnEditSave.Location = new System.Drawing.Point(8, 132);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(92, 28);
            this.btnEditSave.TabIndex = 11;
            this.btnEditSave.Text = "Edit";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(202, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlStockIndicator
            // 
            this.pnlStockIndicator.BackColor = System.Drawing.Color.Red;
            this.pnlStockIndicator.Controls.Add(this.lblisInStockIndicator);
            this.pnlStockIndicator.ForeColor = System.Drawing.Color.White;
            this.pnlStockIndicator.Location = new System.Drawing.Point(158, 108);
            this.pnlStockIndicator.Name = "pnlStockIndicator";
            this.pnlStockIndicator.Size = new System.Drawing.Size(136, 20);
            this.pnlStockIndicator.TabIndex = 13;
            // 
            // lblisInStockIndicator
            // 
            this.lblisInStockIndicator.AutoSize = true;
            this.lblisInStockIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblisInStockIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisInStockIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblisInStockIndicator.Name = "lblisInStockIndicator";
            this.lblisInStockIndicator.Size = new System.Drawing.Size(109, 20);
            this.lblisInStockIndicator.TabIndex = 0;
            this.lblisInStockIndicator.Text = "Not In Stock";
            // 
            // UCLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.pnlStockIndicator);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.cbIsInStock);
            this.Controls.Add(this.lblIsInStock);
            this.Controls.Add(this.lblSuppliedTo);
            this.Controls.Add(this.lblNumInLaptopSystems);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.tbSuppliedTo);
            this.Controls.Add(this.tbNumInSystem);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.tbModel);
            this.ForeColor = System.Drawing.Color.White;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximumSize = new System.Drawing.Size(300, 165);
            this.MinimumSize = new System.Drawing.Size(300, 165);
            this.Name = "UCLaptop";
            this.Size = new System.Drawing.Size(300, 165);
            this.pnlStockIndicator.ResumeLayout(false);
            this.pnlStockIndicator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbNumInSystem;
        private System.Windows.Forms.TextBox tbSuppliedTo;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblNumInLaptopSystems;
        private System.Windows.Forms.Label lblSuppliedTo;
        private System.Windows.Forms.Label lblIsInStock;
        private System.Windows.Forms.CheckBox cbIsInStock;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlStockIndicator;
        private System.Windows.Forms.Label lblisInStockIndicator;
    }
}
