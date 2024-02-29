namespace OrdeRy
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrcs6 = new System.Windows.Forms.Button();
            this.dataGW = new System.Windows.Forms.DataGridView();
            this.txtbQty = new System.Windows.Forms.NumericUpDown();
            this.txtbQtyP6 = new System.Windows.Forms.NumericUpDown();
            this.txtbQtyP2 = new System.Windows.Forms.NumericUpDown();
            this.txtbQtyP3 = new System.Windows.Forms.NumericUpDown();
            this.txtbQtyP4 = new System.Windows.Forms.NumericUpDown();
            this.txtbQtyP5 = new System.Windows.Forms.NumericUpDown();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5Iced = new System.Windows.Forms.CheckBox();
            this.txtbQtyP5Iced = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.idToVoid = new System.Windows.Forms.TextBox();
            this.toVoid = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GW_Voids = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.dataGW_Invertory = new System.Windows.Forms.DataGridView();
            this.cbRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP5Iced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GW_Voids)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW_Invertory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrcs6
            // 
            this.btnPrcs6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrcs6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrcs6.Location = new System.Drawing.Point(330, 356);
            this.btnPrcs6.Name = "btnPrcs6";
            this.btnPrcs6.Size = new System.Drawing.Size(75, 23);
            this.btnPrcs6.TabIndex = 5;
            this.btnPrcs6.Text = "Process";
            this.btnPrcs6.UseVisualStyleBackColor = true;
            this.btnPrcs6.Click += new System.EventHandler(this.btnPrcs6_Click_1);
            // 
            // dataGW
            // 
            this.dataGW.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGW.BackgroundColor = System.Drawing.Color.White;
            this.dataGW.CausesValidation = false;
            this.dataGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGW.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGW.GridColor = System.Drawing.Color.White;
            this.dataGW.Location = new System.Drawing.Point(439, 78);
            this.dataGW.Name = "dataGW";
            this.dataGW.ReadOnly = true;
            this.dataGW.Size = new System.Drawing.Size(735, 369);
            this.dataGW.TabIndex = 41;
            this.dataGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGW_CellDoubleClick);
            // 
            // txtbQty
            // 
            this.txtbQty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQty.Location = new System.Drawing.Point(336, 82);
            this.txtbQty.Name = "txtbQty";
            this.txtbQty.Size = new System.Drawing.Size(40, 23);
            this.txtbQty.TabIndex = 42;
            // 
            // txtbQtyP6
            // 
            this.txtbQtyP6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP6.Location = new System.Drawing.Point(336, 325);
            this.txtbQtyP6.Name = "txtbQtyP6";
            this.txtbQtyP6.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP6.TabIndex = 43;
            // 
            // txtbQtyP2
            // 
            this.txtbQtyP2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP2.Location = new System.Drawing.Point(336, 122);
            this.txtbQtyP2.Name = "txtbQtyP2";
            this.txtbQtyP2.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP2.TabIndex = 44;
            // 
            // txtbQtyP3
            // 
            this.txtbQtyP3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP3.Location = new System.Drawing.Point(336, 163);
            this.txtbQtyP3.Name = "txtbQtyP3";
            this.txtbQtyP3.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP3.TabIndex = 45;
            // 
            // txtbQtyP4
            // 
            this.txtbQtyP4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP4.Location = new System.Drawing.Point(336, 204);
            this.txtbQtyP4.Name = "txtbQtyP4";
            this.txtbQtyP4.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP4.TabIndex = 46;
            // 
            // txtbQtyP5
            // 
            this.txtbQtyP5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP5.Location = new System.Drawing.Point(336, 243);
            this.txtbQtyP5.Name = "txtbQtyP5";
            this.txtbQtyP5.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP5.TabIndex = 47;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.ForeColor = System.Drawing.Color.Black;
            this.cb1.Location = new System.Drawing.Point(22, 81);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(202, 20);
            this.cb1.TabIndex = 60;
            this.cb1.Text = "1) Lanzones Wine Php 305";
            this.cb1.UseVisualStyleBackColor = false;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.ForeColor = System.Drawing.Color.Black;
            this.cb2.Location = new System.Drawing.Point(22, 122);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(189, 20);
            this.cb2.TabIndex = 61;
            this.cb2.Text = "2) Banana Wine Php 163";
            this.cb2.UseVisualStyleBackColor = false;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.BackColor = System.Drawing.Color.Transparent;
            this.cb3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.ForeColor = System.Drawing.Color.Black;
            this.cb3.Location = new System.Drawing.Point(22, 163);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(169, 20);
            this.cb3.TabIndex = 62;
            this.cb3.Text = "3) Rice Wine Php 177";
            this.cb3.UseVisualStyleBackColor = false;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.BackColor = System.Drawing.Color.Transparent;
            this.cb4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.ForeColor = System.Drawing.Color.Black;
            this.cb4.Location = new System.Drawing.Point(22, 203);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(233, 20);
            this.cb4.TabIndex = 63;
            this.cb4.Text = "4) RC Lanzones Frappe Php 71";
            this.cb4.UseVisualStyleBackColor = false;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.BackColor = System.Drawing.Color.Transparent;
            this.cb5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.ForeColor = System.Drawing.Color.Black;
            this.cb5.Location = new System.Drawing.Point(22, 243);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(210, 20);
            this.cb5.TabIndex = 64;
            this.cb5.Text = "5) Rice Coffee(Hot)  Php 21";
            this.cb5.UseVisualStyleBackColor = false;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.BackColor = System.Drawing.Color.Transparent;
            this.cb6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb6.ForeColor = System.Drawing.Color.Black;
            this.cb6.Location = new System.Drawing.Point(22, 325);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(180, 20);
            this.cb6.TabIndex = 65;
            this.cb6.Text = "7) Banana Frizz Php 76";
            this.cb6.UseVisualStyleBackColor = false;
            this.cb6.CheckedChanged += new System.EventHandler(this.cb6_CheckedChanged);
            // 
            // cb5Iced
            // 
            this.cb5Iced.AutoSize = true;
            this.cb5Iced.BackColor = System.Drawing.Color.Transparent;
            this.cb5Iced.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5Iced.ForeColor = System.Drawing.Color.Black;
            this.cb5Iced.Location = new System.Drawing.Point(22, 285);
            this.cb5Iced.Name = "cb5Iced";
            this.cb5Iced.Size = new System.Drawing.Size(215, 20);
            this.cb5Iced.TabIndex = 67;
            this.cb5Iced.Text = "6) Rice Coffee(Iced)  Php 31";
            this.cb5Iced.UseVisualStyleBackColor = false;
            this.cb5Iced.CheckedChanged += new System.EventHandler(this.cb5Iced_CheckedChanged);
            // 
            // txtbQtyP5Iced
            // 
            this.txtbQtyP5Iced.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQtyP5Iced.Location = new System.Drawing.Point(336, 285);
            this.txtbQtyP5Iced.Name = "txtbQtyP5Iced";
            this.txtbQtyP5Iced.Size = new System.Drawing.Size(40, 23);
            this.txtbQtyP5Iced.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(867, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Double click to select";
            // 
            // idToVoid
            // 
            this.idToVoid.Location = new System.Drawing.Point(1016, 453);
            this.idToVoid.Name = "idToVoid";
            this.idToVoid.Size = new System.Drawing.Size(70, 20);
            this.idToVoid.TabIndex = 69;
            // 
            // toVoid
            // 
            this.toVoid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toVoid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toVoid.Location = new System.Drawing.Point(1090, 453);
            this.toVoid.Name = "toVoid";
            this.toVoid.Size = new System.Drawing.Size(84, 23);
            this.toVoid.TabIndex = 68;
            this.toVoid.Text = "Invalid";
            this.toVoid.UseVisualStyleBackColor = true;
            this.toVoid.Click += new System.EventHandler(this.toVoid_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1065, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Summary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GW_Voids
            // 
            this.GW_Voids.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GW_Voids.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GW_Voids.BackgroundColor = System.Drawing.Color.White;
            this.GW_Voids.CausesValidation = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GW_Voids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.GW_Voids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GW_Voids.DefaultCellStyle = dataGridViewCellStyle12;
            this.GW_Voids.GridColor = System.Drawing.Color.White;
            this.GW_Voids.Location = new System.Drawing.Point(438, 497);
            this.GW_Voids.Name = "GW_Voids";
            this.GW_Voids.ReadOnly = true;
            this.GW_Voids.Size = new System.Drawing.Size(734, 114);
            this.GW_Voids.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 73);
            this.panel1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 56);
            this.label1.TabIndex = 71;
            this.label1.Text = "CAFE VINUM";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(241, 618);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Reload";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenForm.Location = new System.Drawing.Point(330, 618);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm.TabIndex = 51;
            this.btnOpenForm.Text = "Update Stocks";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // dataGW_Invertory
            // 
            this.dataGW_Invertory.AllowUserToOrderColumns = true;
            this.dataGW_Invertory.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGW_Invertory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGW_Invertory.BackgroundColor = System.Drawing.Color.White;
            this.dataGW_Invertory.CausesValidation = false;
            this.dataGW_Invertory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGW_Invertory.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGW_Invertory.GridColor = System.Drawing.Color.White;
            this.dataGW_Invertory.Location = new System.Drawing.Point(12, 400);
            this.dataGW_Invertory.Name = "dataGW_Invertory";
            this.dataGW_Invertory.ReadOnly = true;
            this.dataGW_Invertory.Size = new System.Drawing.Size(393, 211);
            this.dataGW_Invertory.TabIndex = 58;
            // 
            // cbRef
            // 
            this.cbRef.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbRef.Location = new System.Drawing.Point(241, 356);
            this.cbRef.Name = "cbRef";
            this.cbRef.Size = new System.Drawing.Size(75, 23);
            this.cbRef.TabIndex = 71;
            this.cbRef.Text = "Refresh";
            this.cbRef.UseVisualStyleBackColor = true;
            this.cbRef.Click += new System.EventHandler(this.cbRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 653);
            this.Controls.Add(this.cbRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGW_Invertory);
            this.Controls.Add(this.idToVoid);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.toVoid);
            this.Controls.Add(this.GW_Voids);
            this.Controls.Add(this.dataGW);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cb5Iced);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbQtyP5Iced);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.txtbQtyP6);
            this.Controls.Add(this.txtbQty);
            this.Controls.Add(this.btnPrcs6);
            this.Controls.Add(this.txtbQtyP5);
            this.Controls.Add(this.txtbQtyP2);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.txtbQtyP3);
            this.Controls.Add(this.txtbQtyP4);
            this.Controls.Add(this.cb3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cavin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbQtyP5Iced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GW_Voids)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW_Invertory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrcs6;
        private System.Windows.Forms.DataGridView dataGW;
        private System.Windows.Forms.NumericUpDown txtbQty;
        private System.Windows.Forms.NumericUpDown txtbQtyP6;
        private System.Windows.Forms.NumericUpDown txtbQtyP2;
        private System.Windows.Forms.NumericUpDown txtbQtyP3;
        private System.Windows.Forms.NumericUpDown txtbQtyP4;
        private System.Windows.Forms.NumericUpDown txtbQtyP5;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb5Iced;
        private System.Windows.Forms.NumericUpDown txtbQtyP5Iced;
        private System.Windows.Forms.DataGridView GW_Voids;
        private System.Windows.Forms.Button toVoid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idToVoid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.DataGridView dataGW_Invertory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cbRef;
    }
}

