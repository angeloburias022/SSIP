
namespace SSIP.UserformControls
{
    partial class EquipInvControl
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
            this.productMainPanel = new System.Windows.Forms.Panel();
            this.product_panel = new System.Windows.Forms.Panel();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.tb_prodDescr = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.tb_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_equipDetails = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.gridMainPanel = new System.Windows.Forms.Panel();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_viewEquip = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datepurchased = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showSales = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showEquip = new Guna.UI2.WinForms.Guna2Button();
            this.productMainPanel.SuspendLayout();
            this.product_panel.SuspendLayout();
            this.gridMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.confirmAccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productMainPanel
            // 
            this.productMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.productMainPanel.Controls.Add(this.product_panel);
            this.productMainPanel.Controls.Add(this.gridMainPanel);
            this.productMainPanel.Location = new System.Drawing.Point(3, 18);
            this.productMainPanel.Name = "productMainPanel";
            this.productMainPanel.Size = new System.Drawing.Size(784, 420);
            this.productMainPanel.TabIndex = 138;
            // 
            // product_panel
            // 
            this.product_panel.BackColor = System.Drawing.Color.Transparent;
            this.product_panel.Controls.Add(this.datepurchased);
            this.product_panel.Controls.Add(this.label18);
            this.product_panel.Controls.Add(this.btn_add);
            this.product_panel.Controls.Add(this.tb_prodDescr);
            this.product_panel.Controls.Add(this.btn_update);
            this.product_panel.Controls.Add(this.tb_code);
            this.product_panel.Controls.Add(this.tb_price);
            this.product_panel.Controls.Add(this.tb_id);
            this.product_panel.Controls.Add(this.tb_productName);
            this.product_panel.Controls.Add(this.lbl_equipDetails);
            this.product_panel.Controls.Add(this.label9);
            this.product_panel.Controls.Add(this.lbl_code);
            this.product_panel.Controls.Add(this.label11);
            this.product_panel.Controls.Add(this.label12);
            this.product_panel.Controls.Add(this.lbl_prodName);
            this.product_panel.Location = new System.Drawing.Point(13, 14);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(355, 395);
            this.product_panel.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 4;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.DisabledState.Parent = this.btn_add;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(202, 286);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(138, 32);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "ADD ITEM";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_update.Location = new System.Drawing.Point(202, 324);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(138, 33);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE ITEM";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.Transparent;
            this.tb_price.BorderRadius = 4;
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.DefaultText = "0";
            this.tb_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.DisabledState.Parent = this.tb_price;
            this.tb_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.FocusedState.Parent = this.tb_price;
            this.tb_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.HoverState.Parent = this.tb_price;
            this.tb_price.Location = new System.Drawing.Point(18, 195);
            this.tb_price.Name = "tb_price";
            this.tb_price.PasswordChar = '\0';
            this.tb_price.PlaceholderText = "Price here";
            this.tb_price.SelectedText = "";
            this.tb_price.ShadowDecoration.Parent = this.tb_price;
            this.tb_price.Size = new System.Drawing.Size(151, 36);
            this.tb_price.TabIndex = 11;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_prodPrice_TextChanged);
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
            // lbl_equipDetails
            // 
            this.lbl_equipDetails.AutoSize = true;
            this.lbl_equipDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbl_equipDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipDetails.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_equipDetails.Location = new System.Drawing.Point(13, 9);
            this.lbl_equipDetails.Name = "lbl_equipDetails";
            this.lbl_equipDetails.Size = new System.Drawing.Size(260, 31);
            this.lbl_equipDetails.TabIndex = 8;
            this.lbl_equipDetails.Text = "Equipment Details:";
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
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.BackColor = System.Drawing.Color.Transparent;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_code.Location = new System.Drawing.Point(185, 108);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(97, 20);
            this.lbl_code.TabIndex = 8;
            this.lbl_code.Text = "Item Code:";
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
            this.lbl_prodName.Size = new System.Drawing.Size(101, 20);
            this.lbl_prodName.TabIndex = 8;
            this.lbl_prodName.Text = "Item Name:";
            // 
            // gridMainPanel
            // 
            this.gridMainPanel.Controls.Add(this.itemGrid);
            this.gridMainPanel.Controls.Add(this.tb_search);
            this.gridMainPanel.Controls.Add(this.btn_remove);
            this.gridMainPanel.Controls.Add(this.btn_viewEquip);
            this.gridMainPanel.Controls.Add(this.label7);
            this.gridMainPanel.Location = new System.Drawing.Point(374, 14);
            this.gridMainPanel.Name = "gridMainPanel";
            this.gridMainPanel.Size = new System.Drawing.Size(401, 395);
            this.gridMainPanel.TabIndex = 17;
            // 
            // itemGrid
            // 
            this.itemGrid.BackgroundColor = System.Drawing.Color.Ivory;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Location = new System.Drawing.Point(11, 79);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Size = new System.Drawing.Size(383, 201);
            this.itemGrid.TabIndex = 1;
            this.itemGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellDoubleClick);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.Transparent;
            this.tb_search.BorderRadius = 4;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.Parent = this.tb_search;
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.FocusedState.Parent = this.tb_search;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.HoverState.Parent = this.tb_search;
            this.tb_search.Location = new System.Drawing.Point(11, 37);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Type here";
            this.tb_search.SelectedText = "";
            this.tb_search.ShadowDecoration.Parent = this.tb_search;
            this.tb_search.Size = new System.Drawing.Size(156, 36);
            this.tb_search.TabIndex = 10;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
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
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.Parent = this.btn_remove;
            this.btn_remove.Location = new System.Drawing.Point(259, 324);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShadowDecoration.Parent = this.btn_remove;
            this.btn_remove.Size = new System.Drawing.Size(135, 33);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "REMOVE ITEM";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_viewEquip
            // 
            this.btn_viewEquip.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewEquip.BorderRadius = 4;
            this.btn_viewEquip.CheckedState.Parent = this.btn_viewEquip;
            this.btn_viewEquip.CustomImages.Parent = this.btn_viewEquip;
            this.btn_viewEquip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewEquip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewEquip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewEquip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewEquip.DisabledState.Parent = this.btn_viewEquip;
            this.btn_viewEquip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewEquip.ForeColor = System.Drawing.Color.White;
            this.btn_viewEquip.HoverState.Parent = this.btn_viewEquip;
            this.btn_viewEquip.Location = new System.Drawing.Point(259, 286);
            this.btn_viewEquip.Name = "btn_viewEquip";
            this.btn_viewEquip.ShadowDecoration.Parent = this.btn_viewEquip;
            this.btn_viewEquip.Size = new System.Drawing.Size(135, 32);
            this.btn_viewEquip.TabIndex = 9;
            this.btn_viewEquip.Text = "VIEW ITEMS";
            this.btn_viewEquip.Click += new System.EventHandler(this.btn_viewEquip_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Search:";
            // 
            // datepurchased
            // 
            this.datepurchased.BackColor = System.Drawing.Color.Transparent;
            this.datepurchased.BorderRadius = 4;
            this.datepurchased.Checked = true;
            this.datepurchased.CheckedState.Parent = this.datepurchased;
            this.datepurchased.FillColor = System.Drawing.Color.LimeGreen;
            this.datepurchased.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.datepurchased.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepurchased.HoverState.Parent = this.datepurchased;
            this.datepurchased.Location = new System.Drawing.Point(189, 195);
            this.datepurchased.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepurchased.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepurchased.Name = "datepurchased";
            this.datepurchased.ShadowDecoration.Parent = this.datepurchased;
            this.datepurchased.Size = new System.Drawing.Size(151, 34);
            this.datepurchased.TabIndex = 15;
            this.datepurchased.UseTransparentBackground = true;
            this.datepurchased.Value = new System.DateTime(2022, 9, 8, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(185, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "Date purchased:";
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(793, 192);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(183, 120);
            this.confirmAccessPanel.TabIndex = 142;
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(24, 5);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(134, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "Confirm Access";
            // 
            // tb_unameAccess
            // 
            this.tb_unameAccess.BackColor = System.Drawing.Color.Transparent;
            this.tb_unameAccess.BorderRadius = 4;
            this.tb_unameAccess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_unameAccess.DefaultText = "";
            this.tb_unameAccess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_unameAccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_unameAccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_unameAccess.DisabledState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_unameAccess.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_unameAccess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.FocusedState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_unameAccess.ForeColor = System.Drawing.Color.Black;
            this.tb_unameAccess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.HoverState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Location = new System.Drawing.Point(9, 28);
            this.tb_unameAccess.Name = "tb_unameAccess";
            this.tb_unameAccess.PasswordChar = '\0';
            this.tb_unameAccess.PlaceholderText = "Username";
            this.tb_unameAccess.SelectedText = "";
            this.tb_unameAccess.ShadowDecoration.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Size = new System.Drawing.Size(165, 36);
            this.tb_unameAccess.TabIndex = 124;
            this.tb_unameAccess.TextChanged += new System.EventHandler(this.tb_unameAccess_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Transparent;
            this.tb_pass.BorderRadius = 4;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.DefaultText = "";
            this.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.DisabledState.Parent = this.tb_pass;
            this.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.Enabled = false;
            this.tb_pass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.FocusedState.Parent = this.tb_pass;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.ForeColor = System.Drawing.Color.Black;
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.HoverState.Parent = this.tb_pass;
            this.tb_pass.Location = new System.Drawing.Point(9, 73);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.ShadowDecoration.Parent = this.tb_pass;
            this.tb_pass.Size = new System.Drawing.Size(165, 36);
            this.tb_pass.TabIndex = 123;
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(796, 18);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(174, 45);
            this.guna2Button1.TabIndex = 139;
            this.guna2Button1.Text = "SALES";
            // 
            // btn_showSales
            // 
            this.btn_showSales.BackColor = System.Drawing.Color.Transparent;
            this.btn_showSales.BorderRadius = 4;
            this.btn_showSales.CheckedState.Parent = this.btn_showSales;
            this.btn_showSales.CustomImages.Parent = this.btn_showSales;
            this.btn_showSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showSales.DisabledState.Parent = this.btn_showSales;
            this.btn_showSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showSales.ForeColor = System.Drawing.Color.White;
            this.btn_showSales.HoverState.Parent = this.btn_showSales;
            this.btn_showSales.Location = new System.Drawing.Point(796, 69);
            this.btn_showSales.Name = "btn_showSales";
            this.btn_showSales.ShadowDecoration.Parent = this.btn_showSales;
            this.btn_showSales.Size = new System.Drawing.Size(174, 45);
            this.btn_showSales.TabIndex = 140;
            this.btn_showSales.Text = "PRODUCTS";
            // 
            // btn_showEquip
            // 
            this.btn_showEquip.BackColor = System.Drawing.Color.Transparent;
            this.btn_showEquip.BorderRadius = 4;
            this.btn_showEquip.CheckedState.Parent = this.btn_showEquip;
            this.btn_showEquip.CustomImages.Parent = this.btn_showEquip;
            this.btn_showEquip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showEquip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showEquip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showEquip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showEquip.DisabledState.Parent = this.btn_showEquip;
            this.btn_showEquip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showEquip.ForeColor = System.Drawing.Color.White;
            this.btn_showEquip.HoverState.Parent = this.btn_showEquip;
            this.btn_showEquip.Location = new System.Drawing.Point(796, 120);
            this.btn_showEquip.Name = "btn_showEquip";
            this.btn_showEquip.ShadowDecoration.Parent = this.btn_showEquip;
            this.btn_showEquip.Size = new System.Drawing.Size(174, 45);
            this.btn_showEquip.TabIndex = 141;
            this.btn_showEquip.Text = "EQUIPMENTS";
            // 
            // EquipInvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_showSales);
            this.Controls.Add(this.btn_showEquip);
            this.Controls.Add(this.productMainPanel);
            this.Name = "EquipInvControl";
            this.Size = new System.Drawing.Size(983, 458);
            this.productMainPanel.ResumeLayout(false);
            this.product_panel.ResumeLayout(false);
            this.product_panel.PerformLayout();
            this.gridMainPanel.ResumeLayout(false);
            this.gridMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productMainPanel;
        private System.Windows.Forms.Panel product_panel;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox tb_prodDescr;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2TextBox tb_code;
        private Guna.UI2.WinForms.Guna2TextBox tb_price;
        private Guna.UI2.WinForms.Guna2TextBox tb_id;
        private Guna.UI2.WinForms.Guna2TextBox tb_productName;
        private System.Windows.Forms.Label lbl_equipDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.Panel gridMainPanel;
        private System.Windows.Forms.DataGridView itemGrid;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2Button btn_viewEquip;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepurchased;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_showSales;
        private Guna.UI2.WinForms.Guna2Button btn_showEquip;
    }
}
