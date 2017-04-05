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
using System.Data.SqlClient;
using System.Configuration;


namespace WMAPOS
{
    public partial class fmLogin : DevExpress.XtraEditors.XtraForm
    {
        public fmLogin()
        {
            InitializeComponent();
            
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmMain fm1 = new fmMain();
            fm1.Show();
            return;

            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("أدخل إسم المستخدم وكلمة المرور");
                return;
            }
            try
            {
                
                var connection = ConfigurationManager.ConnectionStrings["WMAPOSConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Users where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapt.Fill(DT);
                con.Close();
                
                if (DT.Rows.Count == 1)
                {
                    this.Hide();
                    fmMain fm = new fmMain();
                    fm.Show();
                    
                }
                else
                {
                    MessageBox.Show("خطأ");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}