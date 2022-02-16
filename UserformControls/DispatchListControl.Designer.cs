
namespace SSIP.UserformControls
{
    partial class DispatchListControl
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
            this.dispatchGrid = new System.Windows.Forms.DataGridView();
            this.btn_viewDispatches = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dispatchGrid
            // 
            this.dispatchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispatchGrid.Location = new System.Drawing.Point(16, 30);
            this.dispatchGrid.Name = "dispatchGrid";
            this.dispatchGrid.Size = new System.Drawing.Size(361, 214);
            this.dispatchGrid.TabIndex = 0;
            // 
            // btn_viewDispatches
            // 
            this.btn_viewDispatches.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewDispatches.BorderRadius = 4;
            this.btn_viewDispatches.CheckedState.Parent = this.btn_viewDispatches;
            this.btn_viewDispatches.CustomImages.Parent = this.btn_viewDispatches;
            this.btn_viewDispatches.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewDispatches.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewDispatches.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewDispatches.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewDispatches.DisabledState.Parent = this.btn_viewDispatches;
            this.btn_viewDispatches.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewDispatches.ForeColor = System.Drawing.Color.White;
            this.btn_viewDispatches.HoverState.Parent = this.btn_viewDispatches;
            this.btn_viewDispatches.Location = new System.Drawing.Point(383, 30);
            this.btn_viewDispatches.Name = "btn_viewDispatches";
            this.btn_viewDispatches.ShadowDecoration.Parent = this.btn_viewDispatches;
            this.btn_viewDispatches.Size = new System.Drawing.Size(120, 45);
            this.btn_viewDispatches.TabIndex = 106;
            this.btn_viewDispatches.Text = "CREATE NEW";
            this.btn_viewDispatches.UseTransparentBackground = true;
            this.btn_viewDispatches.Click += new System.EventHandler(this.btn_viewDispatches_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.723735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.59533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87549F));
            this.tableLayoutPanel1.Controls.Add(this.dispatchGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_viewDispatches, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.297297F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.81081F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 370);
            this.tableLayoutPanel1.TabIndex = 107;
            // 
            // DispatchListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DispatchListControl";
            this.Size = new System.Drawing.Size(530, 370);
            this.Load += new System.EventHandler(this.DispatchListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispatchGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dispatchGrid;
        private Guna.UI2.WinForms.Guna2Button btn_viewDispatches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
