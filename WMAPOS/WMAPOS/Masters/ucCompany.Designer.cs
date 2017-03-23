namespace WMAPOS.Masters
{
    partial class ucCompany
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
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TxtCompanyCode = new DevExpress.XtraEditors.TextEdit();
            this.tblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCompanyNameAr = new DevExpress.XtraEditors.TextEdit();
            this.TxtCompanyNameEn = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCompanyNameAr = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyNameEn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyNameAr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyNameEn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyNameAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyNameEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.button2);
            this.dataLayoutControl1.Controls.Add(this.TxtCompanyCode);
            this.dataLayoutControl1.Controls.Add(this.TxtCompanyNameAr);
            this.dataLayoutControl1.Controls.Add(this.TxtCompanyNameEn);
            this.dataLayoutControl1.DataMember = null;
            this.dataLayoutControl1.DataSource = this.tblCompanyBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(303, 197, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(346, 219);
            this.dataLayoutControl1.TabIndex = 3;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TxtCompanyCode
            // 
            this.TxtCompanyCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblCompanyBindingSource, "CompanyCode", true));
            this.TxtCompanyCode.Location = new System.Drawing.Point(105, 12);
            this.TxtCompanyCode.Name = "TxtCompanyCode";
            this.TxtCompanyCode.Size = new System.Drawing.Size(229, 20);
            this.TxtCompanyCode.StyleController = this.dataLayoutControl1;
            this.TxtCompanyCode.TabIndex = 4;
            // 
            // tblCompanyBindingSource
            // 
            this.tblCompanyBindingSource.DataSource = typeof(DAL.tbl_Company);
            // 
            // TxtCompanyNameAr
            // 
            this.TxtCompanyNameAr.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblCompanyBindingSource, "CompanyNameAr", true));
            this.TxtCompanyNameAr.Location = new System.Drawing.Point(105, 36);
            this.TxtCompanyNameAr.Name = "TxtCompanyNameAr";
            this.TxtCompanyNameAr.Size = new System.Drawing.Size(229, 20);
            this.TxtCompanyNameAr.StyleController = this.dataLayoutControl1;
            this.TxtCompanyNameAr.TabIndex = 5;
            // 
            // TxtCompanyNameEn
            // 
            this.TxtCompanyNameEn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblCompanyBindingSource, "CompanyNameEn", true));
            this.TxtCompanyNameEn.Location = new System.Drawing.Point(105, 60);
            this.TxtCompanyNameEn.Name = "TxtCompanyNameEn";
            this.TxtCompanyNameEn.Size = new System.Drawing.Size(205, 20);
            this.TxtCompanyNameEn.StyleController = this.dataLayoutControl1;
            this.TxtCompanyNameEn.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(346, 219);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompanyNameAr,
            this.ItemForCompanyNameEn,
            this.ItemForCompanyCode,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(326, 199);
            // 
            // ItemForCompanyNameAr
            // 
            this.ItemForCompanyNameAr.Control = this.TxtCompanyNameAr;
            this.ItemForCompanyNameAr.Location = new System.Drawing.Point(0, 24);
            this.ItemForCompanyNameAr.Name = "ItemForCompanyNameAr";
            this.ItemForCompanyNameAr.Size = new System.Drawing.Size(326, 24);
            this.ItemForCompanyNameAr.Text = "Company Name Ar";
            this.ItemForCompanyNameAr.TextSize = new System.Drawing.Size(90, 13);
            // 
            // ItemForCompanyNameEn
            // 
            this.ItemForCompanyNameEn.Control = this.TxtCompanyNameEn;
            this.ItemForCompanyNameEn.Location = new System.Drawing.Point(0, 48);
            this.ItemForCompanyNameEn.Name = "ItemForCompanyNameEn";
            this.ItemForCompanyNameEn.Size = new System.Drawing.Size(302, 151);
            this.ItemForCompanyNameEn.Text = "Company Name En";
            this.ItemForCompanyNameEn.TextSize = new System.Drawing.Size(90, 13);
            // 
            // ItemForCompanyCode
            // 
            this.ItemForCompanyCode.Control = this.TxtCompanyCode;
            this.ItemForCompanyCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompanyCode.Name = "ItemForCompanyCode";
            this.ItemForCompanyCode.Size = new System.Drawing.Size(326, 24);
            this.ItemForCompanyCode.Text = "Company Code";
            this.ItemForCompanyCode.TextSize = new System.Drawing.Size(90, 13);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 147);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.button2;
            this.layoutControlItem1.Location = new System.Drawing.Point(302, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(24, 151);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ucCompany";
            this.Size = new System.Drawing.Size(346, 257);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyNameAr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyNameEn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyNameAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyNameEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtCompanyCode;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource;
        private DevExpress.XtraEditors.TextEdit TxtCompanyNameAr;
        private DevExpress.XtraEditors.TextEdit TxtCompanyNameEn;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyNameAr;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyNameEn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyCode;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Button button1;
    }
}
