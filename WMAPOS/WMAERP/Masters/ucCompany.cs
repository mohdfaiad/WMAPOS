using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL;
using WMAFW.UserControls;

namespace WMAERP.Masters
{
    public partial class ucCompany : BaseForm
    {
        private Sys proxy;
        private tbl_Company objx;
        private readonly BindingSource _bindingSource = new BindingSource();
        public ucCompany()
        {
            proxy = new Sys(new tbl_Users(), "", "");
            InitData(proxy.Company);
            Save += OnSave;
            AfterMove += OnAfterMove;
            Delete+=OnDelete;
            InitializeComponent();
            gridControl1.DataSource = _bindingSource;
        }

        private void OnDelete(ActionEventArgs actionEventArgs)
        {
            var tbl = (tbl_Company)bs.Current;
            var tbls = _bindingSource.List as List<tbl_Branch>;

            if (proxy.Company.Delete(tbl,tbls)!=TransactionResult.DeleteSuccess)
            {
                MessageBox.Show("حدث خطأ");
            }
            else
            {
                MessageBox.Show("تم الحذف");
            }
        }

        private void OnAfterMove(object sender, MoveEventArgs moveEventArgs)
        {
            var row = sender as tbl_Company;
            var listData = proxy.Company.GetBranches(row?.CompanyCode);
            _bindingSource.DataSource = listData;
        }

        private void OnSave(ActionEventArgs args)
        {
            bs.EndEdit();
            _bindingSource.EndEdit();

            var tbl = (tbl_Company)bs.Current;
            var tbls = _bindingSource.List as List<tbl_Branch>;

            args.Cancel = proxy.Company.Save(tbl, tbls) != TransactionResult.SaveSuccess;
        }

    }
}
