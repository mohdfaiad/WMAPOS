using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMAFW.Controls
{
    public partial class POBarCodeControl : BarCodeControl
    {
        public POBarCodeControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
