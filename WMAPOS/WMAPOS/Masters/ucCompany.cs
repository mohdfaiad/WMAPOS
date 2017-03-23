using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BLL;

namespace WMAPOS.Masters
{
    public partial class ucCompany : ucMain
    {
        public ucCompany()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           using (Company obj = new Company())
            {

                obj.NewCompany(TxtCompanyCode.Text,
                    TxtCompanyNameAr.Text,
                    TxtCompanyNameEn.Text
                );
            }
        }
    }
}
