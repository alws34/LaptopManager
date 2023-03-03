namespace InventoryManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flpLaptops = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNewLaptop = new System.Windows.Forms.Button();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.flpBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpLaptops
            // 
            this.flpLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpLaptops.AutoScroll = true;
            this.flpLaptops.BackColor = System.Drawing.Color.Transparent;
            this.flpLaptops.Location = new System.Drawing.Point(3, 2);
            this.flpLaptops.Name = "flpLaptops";
            this.flpLaptops.Size = new System.Drawing.Size(343, 517);
            this.flpLaptops.TabIndex = 0;
            // 
            // flpBtns
            // 
            this.flpBtns.Controls.Add(this.btnNewLaptop);
            this.flpBtns.Controls.Add(this.btnSave);
            this.flpBtns.Controls.Add(this.btnReload);
            this.flpBtns.Location = new System.Drawing.Point(349, 2);
            this.flpBtns.Name = "flpBtns";
            this.flpBtns.Size = new System.Drawing.Size(82, 154);
            this.flpBtns.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(3, 105);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 45);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNewLaptop
            // 
            this.btnNewLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLaptop.Location = new System.Drawing.Point(3, 3);
            this.btnNewLaptop.Name = "btnNewLaptop";
            this.btnNewLaptop.Size = new System.Drawing.Size(75, 45);
            this.btnNewLaptop.TabIndex = 2;
            this.btnNewLaptop.Text = "New Laptop";
            this.btnNewLaptop.UseVisualStyleBackColor = true;
            this.btnNewLaptop.Click += new System.EventHandler(this.btnNewLaptop_Click);
            // 
            // lbConsole
            // 
            this.lbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(3, 525);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(428, 134);
            this.lbConsole.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.flpBtns);
            this.Controls.Add(this.flpLaptops);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 700);
            this.MinimumSize = new System.Drawing.Size(450, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laptop Manager";
            this.flpBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLaptops;
        private System.Windows.Forms.FlowLayoutPanel flpBtns;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNewLaptop;
        private System.Windows.Forms.ListBox lbConsole;
    }
}

