using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using WMAPOS.Masters;
using System.Configuration;

namespace WMAPOS
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region

        #endregion
        public fmMain()
        {
            InitializeComponent();
        }
        void OpenForm(XtraUserControl frm, string Caption = "")
        {
            frm.Text = Caption;
            tabbedView.AddDocument(frm);
            tabbedView.ActivateDocument(frm);
        }
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            switch (e.Element.Tag.ToString().ToString())
            {
                case "Company":
                    OpenForm(new ucCompany(), "Company");
                    break;

                case "Branches":
                    OpenForm(new ucBranches(), "Branches");
                    break;
                case "WareHouses":
                    OpenForm(new ucWareHouses(), "WareHouses");
                    break;
                case "Operators":
                    OpenForm(new ucOperators(), "Operators");
                    break;
                case "VendorGroups":
                    OpenForm(new ucVendorGroups(), "VendorGroups");
                    break;
                case "Vendors":
                    OpenForm(new ucVendors(), "Vendors");
                    break;
                case "CustomerGroups":
                    OpenForm(new ucCustomerGroups(), "CustomerGroups");
                    break;
                case "Customers":
                    OpenForm(new ucCustomers(), "Customers");
                    break;
                case "ItemGroup":
                    OpenForm(new ucItemGroups(), "ItemGroup");
                    break;
                case "ItemType":
                    OpenForm(new ucItemTypes(), "ItemType");
                    break;
                case "ItemCategory":
                    OpenForm(new ucItemCategories(), "ItemCategory");
                    break;
                case "ItemSizes":
                    OpenForm(new ucItemSizes(), "ItemSizes");
                    break;
                case "ItemColors":
                    OpenForm(new ucItemColors(), "ItemColors");
                    break;
                case "ItemDefinition":
                    OpenForm(new ucItemDefinition(), "ItemDefinition");
                    break;

                default:
                    break;
            }

        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            //if (tabbedView.Documents.Count == 0)
            //{
            //    accordionControl.SelectedElement = null;
            //    return;
            //}
            //if (e.Document.Caption == "Company")
            //    accordionControl.SelectedElement = mnCompany;
            //else if (e.Document.Caption == "Branches")
            //    accordionControl.SelectedElement = mnBranches;
            //else if (e.Document.Caption == "WareHouses")
            //    accordionControl.SelectedElement = mnWareHouses;
            //else if (e.Document.Caption == "Operators")
            //    accordionControl.SelectedElement = mnOperators;
            //else if (e.Document.Caption == "VendorGroups")
            //    accordionControl.SelectedElement = mnVendorGroups;
            //else if (e.Document.Caption == "Vendors")
            //    accordionControl.SelectedElement = mnVendors;
            //else if (e.Document.Caption == "CustomerGroups")
            //    accordionControl.SelectedElement = mnCustomerGroups;
            //else if (e.Document.Caption == "Customers")
            //    accordionControl.SelectedElement = mnCustomers;
            //else if (e.Document.Caption == "ItemGroup")
            //    accordionControl.SelectedElement = mnItemGroup;
            //else if (e.Document.Caption == "ItemType")
            //    accordionControl.SelectedElement = mnItemType;
            //else if (e.Document.Caption == "ItemCategory")
            //    accordionControl.SelectedElement = mnItemCategory;
            //else if (e.Document.Caption == "ItemSizes")
            //    accordionControl.SelectedElement = mnItemSizes;
            //else if (e.Document.Caption == "ItemColors")
            //    accordionControl.SelectedElement = mnItemColors;
            //else if (e.Document.Caption == "ItemDefinition")
            //    accordionControl.SelectedElement = mnItemDefinition;
        }
    }
}