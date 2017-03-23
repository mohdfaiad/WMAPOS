namespace WMAPOS
{
    partial class fmMain
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCompany = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnBranches = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnWareHouses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnOperators = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnVendorGroups = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnVendors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCustomerGroups = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemType = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemSizes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemColors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItemDefinition = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 48;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 46;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Cutomers";
            this.customersBarButtonItem.Id = 47;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 31);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("a045df26-1503-4d9a-99c1-a531310af22b");
            this.dockPanel.Location = new System.Drawing.Point(0, 143);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel.Size = new System.Drawing.Size(200, 425);
            this.dockPanel.Text = "Navigation";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionControl);
            this.dockPanel_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(191, 398);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.accordionControlElement2,
            this.accordionControlElement1});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(191, 398);
            this.accordionControl.TabIndex = 0;
            this.accordionControl.Text = "accordionControl";
            this.accordionControl.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.accordionControl_SelectedElementChanged);
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnCompany,
            this.mnBranches,
            this.mnWareHouses,
            this.mnOperators});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Master";
            // 
            // mnCompany
            // 
            this.mnCompany.Name = "mnCompany";
            this.mnCompany.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCompany.Tag = "Company";
            this.mnCompany.Text = "Company";
            // 
            // mnBranches
            // 
            this.mnBranches.Name = "mnBranches";
            this.mnBranches.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnBranches.Tag = "Branches";
            this.mnBranches.Text = "Branches";
            // 
            // mnWareHouses
            // 
            this.mnWareHouses.Name = "mnWareHouses";
            this.mnWareHouses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnWareHouses.Tag = "WareHouses";
            this.mnWareHouses.Text = "WareHouses";
            // 
            // mnOperators
            // 
            this.mnOperators.Name = "mnOperators";
            this.mnOperators.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnOperators.Tag = "Operators";
            this.mnOperators.Text = "Operators";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnVendorGroups,
            this.mnVendors,
            this.mnCustomerGroups,
            this.mnCustomers,
            this.mnItemGroup,
            this.mnItemType,
            this.mnItemCategory,
            this.mnItemSizes,
            this.mnItemColors,
            this.mnItemDefinition});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Inventory";
            // 
            // mnVendorGroups
            // 
            this.mnVendorGroups.Name = "mnVendorGroups";
            this.mnVendorGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnVendorGroups.Tag = "VendorGroups";
            this.mnVendorGroups.Text = "VendorGroups";
            // 
            // mnVendors
            // 
            this.mnVendors.Name = "mnVendors";
            this.mnVendors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnVendors.Tag = "Vendors";
            this.mnVendors.Text = "Vendors";
            // 
            // mnCustomerGroups
            // 
            this.mnCustomerGroups.Name = "mnCustomerGroups";
            this.mnCustomerGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCustomerGroups.Tag = "CustomerGroups";
            this.mnCustomerGroups.Text = "CustomerGroups";
            // 
            // mnCustomers
            // 
            this.mnCustomers.Name = "mnCustomers";
            this.mnCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCustomers.Tag = "Customers";
            this.mnCustomers.Text = "Customers";
            // 
            // mnItemGroup
            // 
            this.mnItemGroup.Name = "mnItemGroup";
            this.mnItemGroup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemGroup.Tag = "ItemGroup";
            this.mnItemGroup.Text = "ItemGroup";
            // 
            // mnItemType
            // 
            this.mnItemType.Name = "mnItemType";
            this.mnItemType.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemType.Tag = "ItemType";
            this.mnItemType.Text = "ItemType";
            // 
            // mnItemCategory
            // 
            this.mnItemCategory.Name = "mnItemCategory";
            this.mnItemCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemCategory.Tag = "ItemCategory";
            this.mnItemCategory.Text = "ItemCategory";
            // 
            // mnItemSizes
            // 
            this.mnItemSizes.Name = "mnItemSizes";
            this.mnItemSizes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemSizes.Tag = "ItemSizes";
            this.mnItemSizes.Text = "ItemSizes";
            // 
            // mnItemColors
            // 
            this.mnItemColors.Name = "mnItemColors";
            this.mnItemColors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemColors.Tag = "ItemColors";
            this.mnItemColors.Text = "ItemColors";
            // 
            // mnItemDefinition
            // 
            this.mnItemDefinition.Name = "mnItemDefinition";
            this.mnItemDefinition.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItemDefinition.Tag = "ItemDefinition";
            this.mnItemDefinition.Text = "ItemDefinition";
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            this.tabbedView.DocumentClosed += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.tabbedView_DocumentClosed);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "fmMain";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCompany;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnBranches;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnWareHouses;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnOperators;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnVendorGroups;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnVendors;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCustomerGroups;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemGroup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemType;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemSizes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemColors;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnItemDefinition;
    }
}