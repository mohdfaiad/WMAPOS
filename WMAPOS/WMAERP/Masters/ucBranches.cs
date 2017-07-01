using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using DevExpress.XtraBars;

namespace WMAERP.Masters
{
    public partial class ucBranches : WMAFW.UserControls.BaseForm
    {
        public ucBranches()
        {
            InitializeComponent();
            
        }

        public new void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            base.bbiSave_ItemClick(sender, e);
        }
    }
}
