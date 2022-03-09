
namespace SSIP.UserformControls
{
    partial class SalesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prodGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gridMainPanel = new System.Windows.Forms.Panel();
            this.tb_searchProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_viewProducts = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.product_panel = new System.Windows.Forms.Panel();
            this.cmb_prodCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_addProduct = new Guna.UI2.WinForms.Guna2Button();
            this.tb_prodDescr = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.tb_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_prodPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_prodDetails = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_prodName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).BeginInit();
            this.gridMainPanel.SuspendLayout();
            this.product_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodGrid
            // 
            this.prodGrid.AllowUserToAddRows = false;
            this.prodGrid.AllowUserToDeleteRows = false;
            this.prodGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.prodGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.prodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodGrid.BackgroundColor = System.Drawing.Color.White;
            this.prodGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.prodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodGrid.EnableHeadersVisualStyles = false;
            this.prodGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.prodGrid.Location = new System.Drawing.Point(11, 79);
            this.prodGrid.Name = "prodGrid";
            this.prodGrid.ReadOnly = true;
            this.prodGrid.RowHeadersVisible = false;
            this.prodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodGrid.Size = new System.Drawing.Size(383, 201);
            this.prodGrid.TabIndex = 0;
            this.prodGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.prodGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.prodGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.prodGrid.ThemeStyle.ReadOnly = true;
            this.prodGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.prodGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.prodGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prodGrid.ThemeStyle.RowsStyle.Height = 22;
            this.prodGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.prodGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gridMainPanel
            // 
            this.gridMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridMainPanel.Controls.Add(this.tb_searchProd);
            this.gridMainPanel.Controls.Add(this.prodGrid);
            this.gridMainPanel.Controls.Add(this.label7);
            this.gridMainPanel.Location = new System.Drawing.Point(25, 33);
            this.gridMainPanel.Name = "gridMainPanel";
            this.gridMainPanel.Size = new System.Drawing.Size(413, 395);
            this.gridMainPanel.TabIndex = 18;
            // 
            // tb_searchProd
            // 
            this.tb_searchProd.BackColor = System.Drawing.Color.Transparent;
            this.tb_searchProd.BorderRadius = 4;
            this.tb_searchProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchProd.DefaultText = "";
            this.tb_searchProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchProd.DisabledState.Parent = this.tb_searchProd;
            this.tb_searchProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchProd.FocusedState.Parent = this.tb_searchProd;
            this.tb_searchProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchProd.HoverState.Parent = this.tb_searchProd;
            this.tb_searchProd.Location = new System.Drawing.Point(11, 37);
            this.tb_searchProd.Name = "tb_searchProd";
            this.tb_searchProd.PasswordChar = '\0';
            this.tb_searchProd.PlaceholderText = "Type here";
            this.tb_searchProd.SelectedText = "";
            this.tb_searchProd.ShadowDecoration.Parent = this.tb_searchProd;
            this.tb_searchProd.Size = new System.Drawing.Size(156, 36);
            this.tb_searchProd.TabIndex = 10;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BorderRadius = 4;
            this.btn_remove.CheckedState.Parent = this.btn_remove;
            this.btn_remove.CustomImages.Parent = this.btn_remove;
            this.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_remove.DisabledState.Parent = this.btn_remove;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.Parent = this.btn_remove;
            this.btn_remove.Location = new System.Drawing.Point(648, 453);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShadowDecoration.Parent = this.btn_remove;
            this.btn_remove.Size = new System.Drawing.Size(138, 33);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "REMOVE";
            // 
            // btn_viewProducts
            // 
            this.btn_viewProducts.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewProducts.BorderRadius = 4;
            this.btn_viewProducts.CheckedState.Parent = this.btn_viewProducts;
            this.btn_viewProducts.CustomImages.Parent = this.btn_viewProducts;
            this.btn_viewProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewProducts.DisabledState.Parent = this.btn_viewProducts;
            this.btn_viewProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewProducts.ForeColor = System.Drawing.Color.White;
            this.btn_viewProducts.HoverState.Parent = this.btn_viewProducts;
            this.btn_viewProducts.Location = new System.Drawing.Point(504, 453);
            this.btn_viewProducts.Name = "btn_viewProducts";
            this.btn_viewProducts.ShadowDecoration.Parent = this.btn_viewProducts;
            this.btn_viewProducts.Size = new System.Drawing.Size(138, 32);
            this.btn_viewProducts.TabIndex = 9;
            this.btn_viewProducts.Text = "ADD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Search:";
            // 
            // product_panel
            // 
            this.product_panel.BackColor = System.Drawing.Color.Transparent;
            this.product_panel.Controls.Add(this.cmb_prodCategory);
            this.product_panel.Controls.Add(this.btn_addProduct);
            this.product_panel.Controls.Add(this.tb_prodDescr);
            this.product_panel.Controls.Add(this.btn_update);
            this.product_panel.Controls.Add(this.tb_code);
            this.product_panel.Controls.Add(this.tb_prodPrice);
            this.product_panel.Controls.Add(this.tb_id);
            this.product_panel.Controls.Add(this.tb_productName);
            this.product_panel.Controls.Add(this.lbl_prodDetails);
            this.product_panel.Controls.Add(this.label9);
            this.product_panel.Controls.Add(this.label8);
            this.product_panel.Controls.Add(this.lbl_code);
            this.product_panel.Controls.Add(this.label11);
            this.product_panel.Controls.Add(this.label12);
            this.product_panel.Controls.Add(this.lbl_prodName);
            this.product_panel.Location = new System.Drawing.Point(455, 32);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(371, 395);
            this.product_panel.TabIndex = 19;
            // 
            // cmb_prodCategory
            // 
            this.cmb_prodCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmb_prodCategory.BorderRadius = 4;
            this.cmb_prodCategory.DisabledState.Parent = this.cmb_prodCategory;
            this.cmb_prodCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_prodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prodCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_prodCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_prodCategory.FocusedState.Parent = this.cmb_prodCategory;
            this.cmb_prodCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_prodCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_prodCategory.HoverState.Parent = this.cmb_prodCategory;
            this.cmb_prodCategory.ItemHeight = 30;
            this.cmb_prodCategory.Items.AddRange(new object[] {
            "",
            "Aircon",
            "Parts"});
            this.cmb_prodCategory.ItemsAppearance.Parent = this.cmb_prodCategory;
            this.cmb_prodCategory.Location = new System.Drawing.Point(189, 192);
            this.cmb_prodCategory.Name = "cmb_prodCategory";
            this.cmb_prodCategory.ShadowDecoration.Parent = this.cmb_prodCategory;
            this.cmb_prodCategory.Size = new System.Drawing.Size(156, 36);
            this.cmb_prodCategory.TabIndex = 13;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_addProduct.BorderRadius = 4;
            this.btn_addProduct.CheckedState.Parent = this.btn_addProduct;
            this.btn_addProduct.CustomImages.Parent = this.btn_addProduct;
            this.btn_addProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addProduct.DisabledState.Parent = this.btn_addProduct;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.HoverState.Parent = this.btn_addProduct;
            this.btn_addProduct.Location = new System.Drawing.Point(195, 270);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.ShadowDecoration.Parent = this.btn_addProduct;
            this.btn_addProduct.Size = new System.Drawing.Size(138, 32);
            this.btn_addProduct.TabIndex = 9;
            this.btn_addProduct.Text = "ADD PRODUCT";
            // 
            // tb_prodDescr
            // 
            this.tb_prodDescr.BackColor = System.Drawing.Color.Transparent;
            this.tb_prodDescr.BorderRadius = 4;
            this.tb_prodDescr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_prodDescr.DefaultText = "";
            this.tb_prodDescr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_prodDescr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_prodDescr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_prodDescr.DisabledState.Parent = this.tb_prodDescr;
            this.tb_prodDescr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_prodDescr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_prodDescr.FocusedState.Parent = this.tb_prodDescr;
            this.tb_prodDescr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_prodDescr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_prodDescr.HoverState.Parent = this.tb_prodDescr;
            this.tb_prodDescr.Location = new System.Drawing.Point(19, 270);
            this.tb_prodDescr.Name = "tb_prodDescr";
            this.tb_prodDescr.PasswordChar = '\0';
            this.tb_prodDescr.PlaceholderText = "Description";
            this.tb_prodDescr.SelectedText = "";
            this.tb_prodDescr.ShadowDecoration.Parent = this.tb_prodDescr;
            this.tb_prodDescr.Size = new System.Drawing.Size(151, 105);
            this.tb_prodDescr.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 4;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.DisabledState.Parent = this.btn_update;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Location = new System.Drawing.Point(195, 308);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(138, 33);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE PRODUCT";
            // 
            // tb_code
            // 
            this.tb_code.BackColor = System.Drawing.Color.Transparent;
            this.tb_code.BorderRadius = 4;
            this.tb_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_code.DefaultText = "";
            this.tb_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_code.DisabledState.Parent = this.tb_code;
            this.tb_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_code.FocusedState.Parent = this.tb_code;
            this.tb_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_code.HoverState.Parent = this.tb_code;
            this.tb_code.Location = new System.Drawing.Point(189, 131);
            this.tb_code.Name = "tb_code";
            this.tb_code.PasswordChar = '\0';
            this.tb_code.PlaceholderText = "Code";
            this.tb_code.ReadOnly = true;
            this.tb_code.SelectedText = "";
            this.tb_code.ShadowDecoration.Parent = this.tb_code;
            this.tb_code.Size = new System.Drawing.Size(151, 36);
            this.tb_code.TabIndex = 11;
            // 
            // tb_prodPrice
            // 
            this.tb_prodPrice.BackColor = System.Drawing.Color.Transparent;
            this.tb_prodPrice.BorderRadius = 4;
            this.tb_prodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_prodPrice.DefaultText = "0";
            this.tb_prodPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_prodPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_prodPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_prodPrice.DisabledState.Parent = this.tb_prodPrice;
            this.tb_prodPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_prodPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_prodPrice.FocusedState.Parent = this.tb_prodPrice;
            this.tb_prodPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_prodPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_prodPrice.HoverState.Parent = this.tb_prodPrice;
            this.tb_prodPrice.Location = new System.Drawing.Point(18, 195);
            this.tb_prodPrice.Name = "tb_prodPrice";
            this.tb_prodPrice.PasswordChar = '\0';
            this.tb_prodPrice.PlaceholderText = "Price here";
            this.tb_prodPrice.SelectedText = "";
            this.tb_prodPrice.ShadowDecoration.Parent = this.tb_prodPrice;
            this.tb_prodPrice.Size = new System.Drawing.Size(151, 36);
            this.tb_prodPrice.TabIndex = 11;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.Transparent;
            this.tb_id.BorderRadius = 4;
            this.tb_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_id.DefaultText = "0";
            this.tb_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_id.DisabledState.Parent = this.tb_id;
            this.tb_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_id.FocusedState.Parent = this.tb_id;
            this.tb_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_id.HoverState.Parent = this.tb_id;
            this.tb_id.Location = new System.Drawing.Point(14, 69);
            this.tb_id.Name = "tb_id";
            this.tb_id.PasswordChar = '\0';
            this.tb_id.PlaceholderText = "";
            this.tb_id.ReadOnly = true;
            this.tb_id.SelectedText = "";
            this.tb_id.ShadowDecoration.Parent = this.tb_id;
            this.tb_id.Size = new System.Drawing.Size(81, 36);
            this.tb_id.TabIndex = 11;
            // 
            // tb_productName
            // 
            this.tb_productName.BackColor = System.Drawing.Color.Transparent;
            this.tb_productName.BorderRadius = 4;
            this.tb_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_productName.DefaultText = "";
            this.tb_productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_productName.DisabledState.Parent = this.tb_productName;
            this.tb_productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_productName.FocusedState.Parent = this.tb_productName;
            this.tb_productName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_productName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_productName.HoverState.Parent = this.tb_productName;
            this.tb_productName.Location = new System.Drawing.Point(16, 131);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.PasswordChar = '\0';
            this.tb_productName.PlaceholderText = "Name here";
            this.tb_productName.SelectedText = "";
            this.tb_productName.ShadowDecoration.Parent = this.tb_productName;
            this.tb_productName.Size = new System.Drawing.Size(153, 36);
            this.tb_productName.TabIndex = 11;
            // 
            // lbl_prodDetails
            // 
            this.lbl_prodDetails.AutoSize = true;
            this.lbl_prodDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prodDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodDetails.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_prodDetails.Location = new System.Drawing.Point(13, 9);
            this.lbl_prodDetails.Name = "lbl_prodDetails";
            this.lbl_prodDetails.Size = new System.Drawing.Size(223, 31);
            this.lbl_prodDetails.TabIndex = 8;
            this.lbl_prodDetails.Text = "Product Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(15, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(185, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Product Category";
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.BackColor = System.Drawing.Color.Transparent;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_code.Location = new System.Drawing.Point(185, 108);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(123, 20);
            this.lbl_code.TabIndex = 8;
            this.lbl_code.Text = "Product Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Unit Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(10, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "ID";
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_prodName.Location = new System.Drawing.Point(11, 108);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(127, 20);
            this.lbl_prodName.TabIndex = 8;
            this.lbl_prodName.Text = "Product Name:";
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.product_panel);
            this.Controls.Add(this.gridMainPanel);
            this.Controls.Add(this.btn_viewProducts);
            this.Controls.Add(this.btn_remove);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(1210, 569);
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).EndInit();
            this.gridMainPanel.ResumeLayout(false);
            this.gridMainPanel.PerformLayout();
            this.product_panel.ResumeLayout(false);
            this.product_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView prodGrid;
        private System.Windows.Forms.Panel gridMainPanel;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchProd;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2Button btn_viewProducts;
        private System.Windows.Forms.Panel product_panel;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_prodCategory;
        private Guna.UI2.WinForms.Guna2Button btn_addProduct;
        private Guna.UI2.WinForms.Guna2TextBox tb_prodDescr;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2TextBox tb_code;
        private Guna.UI2.WinForms.Guna2TextBox tb_prodPrice;
        private Guna.UI2.WinForms.Guna2TextBox tb_id;
        private Guna.UI2.WinForms.Guna2TextBox tb_productName;
        private System.Windows.Forms.Label lbl_prodDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_prodName;
    }
}
