namespace WMAFW.UserControls
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLast = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFirst = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNext = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrev = new DevExpress.XtraBars.BarButtonItem();
            this.beiComboReports = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbiPreview = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rgpTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemkey = new DevExpress.XtraLayout.LayoutControlItem();
            this.key = new DevExpress.XtraEditors.TextEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.bs = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.barButtonItem1,
            this.bbiAddNew,
            this.bbiLast,
            this.bbiFirst,
            this.bbiNext,
            this.bbiPrev,
            this.beiComboReports,
            this.bbiPrint,
            this.skinRibbonGalleryBarItem1,
            this.bbiPreview,
            this.skinRibbonGalleryBarItem2,
            this.bbiEdit});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 23;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1268, 145);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            this.bbiSaveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndNew_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiAddNew
            // 
            this.bbiAddNew.Caption = "Add New";
            this.bbiAddNew.Id = 11;
            this.bbiAddNew.ImageOptions.ImageUri.Uri = "AddItem";
            this.bbiAddNew.Name = "bbiAddNew";
            this.bbiAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNew_ItemClick);
            // 
            // bbiLast
            // 
            this.bbiLast.Caption = "Last";
            this.bbiLast.Id = 12;
            this.bbiLast.ImageOptions.ImageUri.Uri = "Last";
            this.bbiLast.Name = "bbiLast";
            this.bbiLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLast_ItemClick);
            // 
            // bbiFirst
            // 
            this.bbiFirst.Caption = "First";
            this.bbiFirst.Id = 13;
            this.bbiFirst.ImageOptions.ImageUri.Uri = "First";
            this.bbiFirst.Name = "bbiFirst";
            this.bbiFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFirst_ItemClick);
            // 
            // bbiNext
            // 
            this.bbiNext.Caption = "Next";
            this.bbiNext.Id = 14;
            this.bbiNext.ImageOptions.ImageUri.Uri = "DoubleNext";
            this.bbiNext.Name = "bbiNext";
            this.bbiNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNext_ItemClick);
            // 
            // bbiPrev
            // 
            this.bbiPrev.Caption = "Prev";
            this.bbiPrev.Id = 15;
            this.bbiPrev.ImageOptions.ImageUri.Uri = "DoublePrev";
            this.bbiPrev.Name = "bbiPrev";
            this.bbiPrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrev_ItemClick);
            // 
            // beiComboReports
            // 
            this.beiComboReports.Edit = this.repositoryItemComboBox1;
            this.beiComboReports.Id = 16;
            this.beiComboReports.Name = "beiComboReports";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "Print";
            this.bbiPrint.Id = 17;
            this.bbiPrint.ImageOptions.ImageUri.Uri = "Print";
            this.bbiPrint.Name = "bbiPrint";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 19;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bbiPreview
            // 
            this.bbiPreview.Caption = "Preview";
            this.bbiPreview.Id = 20;
            this.bbiPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPreview.Name = "bbiPreview";
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 21;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 22;
            this.bbiEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEdit.ImageOptions.Image")));
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rgpTasks,
            this.rpgReport});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // rgpTasks
            // 
            this.rgpTasks.AllowTextClipping = false;
            this.rgpTasks.ItemLinks.Add(this.bbiSave);
            this.rgpTasks.ItemLinks.Add(this.bbiSaveAndClose);
            this.rgpTasks.ItemLinks.Add(this.bbiSaveAndNew);
            this.rgpTasks.ItemLinks.Add(this.bbiAddNew);
            this.rgpTasks.ItemLinks.Add(this.bbiReset);
            this.rgpTasks.ItemLinks.Add(this.bbiDelete);
            this.rgpTasks.ItemLinks.Add(this.bbiLast);
            this.rgpTasks.ItemLinks.Add(this.bbiPrev);
            this.rgpTasks.ItemLinks.Add(this.bbiNext);
            this.rgpTasks.ItemLinks.Add(this.bbiFirst);
            this.rgpTasks.ItemLinks.Add(this.bbiClose);
            this.rgpTasks.ItemLinks.Add(this.bbiEdit);
            this.rgpTasks.Name = "rgpTasks";
            this.rgpTasks.ShowCaptionButton = false;
            this.rgpTasks.Text = "Tasks";
            // 
            // rpgReport
            // 
            this.rpgReport.ItemLinks.Add(this.beiComboReports);
            this.rpgReport.ItemLinks.Add(this.bbiPrint);
            this.rpgReport.ItemLinks.Add(this.bbiPreview);
            this.rpgReport.Name = "rpgReport";
            this.rpgReport.Text = "Report";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemkey});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1268, 593);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemkey
            // 
            this.layoutControlItemkey.Control = this.key;
            this.layoutControlItemkey.CustomizationFormText = "key";
            this.layoutControlItemkey.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemkey.Name = "layoutControlItemkey";
            this.layoutControlItemkey.Size = new System.Drawing.Size(1242, 567);
            this.layoutControlItemkey.Text = "key";
            this.layoutControlItemkey.TextSize = new System.Drawing.Size(19, 16);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(38, 16);
            this.key.MenuManager = this.mainRibbonControl;
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(1214, 22);
            this.key.StyleController = this.dataLayoutControl1;
            this.key.TabIndex = 4;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.key);
            this.dataLayoutControl1.DataSource = this.bs;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 145);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(652, 390, 562, 500);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1268, 593);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Size = new System.Drawing.Size(1268, 738);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rgpTasks;
        public DevExpress.XtraBars.BarButtonItem bbiPreview;
        public DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        public DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        public DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        public DevExpress.XtraBars.BarButtonItem bbiSave;
        public DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        public DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        public DevExpress.XtraBars.BarButtonItem bbiReset;
        public DevExpress.XtraBars.BarButtonItem bbiDelete;
        public DevExpress.XtraBars.BarButtonItem bbiClose;
        public DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem bbiAddNew;
        public DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        public DevExpress.XtraBars.BarButtonItem bbiLast;
        public DevExpress.XtraBars.BarButtonItem bbiFirst;
        public DevExpress.XtraBars.BarButtonItem bbiNext;
        public DevExpress.XtraBars.BarButtonItem bbiPrev;
        public DevExpress.XtraBars.BarEditItem beiComboReports;
        public DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        public DevExpress.XtraBars.BarButtonItem bbiPrint;
        public DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReport;
        public System.Windows.Forms.BindingSource bs;
        public DevExpress.XtraBars.BarButtonItem bbiEdit;
        public DevExpress.XtraEditors.TextEdit key;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItemkey;
    }
}
