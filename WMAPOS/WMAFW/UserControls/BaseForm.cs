using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using BLL.Helper;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace WMAFW.UserControls
{
    public partial class BaseForm : XtraUserControl
    {
        #region Properties

        public delegate void OnBeforeMove(object sender, MoveEventArgs e);

        public event OnBeforeMove BeforeMove;
        public delegate void OnAfterMove(object sender, MoveEventArgs e);

        public event OnAfterMove AfterMove;

        public delegate void OnSave(ActionEventArgs e);
        public event OnSave Save;

        public delegate void OnDelete(ActionEventArgs e);
        public event OnDelete Delete;

        public delegate void OnAfterChangeControlReadOnlyState();
        public event OnAfterChangeControlReadOnlyState AfterChangeControlReadOnlyState;

        public EditFormActionType ActionType { get; set; }
        #endregion

        #region Methods
        public BaseForm()
        {
            InitializeComponent();
            bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = false;
        }

        private dynamic MasterData { get; set; }
        public void InitData<T>(MasterData<T> masterData) where T : class, new()
        {
            MasterData = masterData;
        }


        private void PerformMove(EditFormActionType moveType)
        {
            BeforeMove?.Invoke(bs.Current, new MoveEventArgs(moveType));
            bbiDelete.Enabled = true;
            switch (moveType)
            {
                case EditFormActionType.Next: bs.DataSource = MasterData.Next(bs.Current); break;
                case EditFormActionType.Previous: bs.DataSource = MasterData.Previous(bs.Current); break;
                case EditFormActionType.First: bs.DataSource = MasterData.First(bs.Current); break;
                case EditFormActionType.Last: bs.DataSource = MasterData.Last(bs.Current); break;
                case EditFormActionType.New:
                    bs.DataSource = MasterData.New(bs.Current);
                    bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = true;
                    bbiNext.Enabled = bbiLast.Enabled = bbiPrev.Enabled = bbiFirst.Enabled = false;
                    bbiReset.Enabled = true;
                    bbiAddNew.Enabled = false;
                    bbiEdit.Enabled = false;
                    bbiDelete.Enabled = false;
                    ChangeControlsReadOnly(false);
                    key.Enabled = true;
                    break;
            }
            AfterMove?.Invoke(bs.Current, new MoveEventArgs(moveType));
        }

        private bool PerformSave(EditFormActionType actionType)
        {
            if (Save == null) return true;

            ActionEventArgs args = new ActionEventArgs(actionType);
            Save.Invoke(args);
            if (args.Cancel)
            {
                args.Message.ForEach(msg =>
                {
                    MessageBox.Show(msg);
                });
            }
            else
            {
                bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = false;
                MessageBox.Show("تم الحفظ");
            }
            return args.Cancel;
        }

        private bool PerformDelete(EditFormActionType actionType)
        {
            if (Delete == null) return true;

            ActionEventArgs args = new ActionEventArgs(actionType);
            Delete.Invoke(args);
            if (args.Cancel)
            {
                args.Message.ForEach(msg =>
                {
                    MessageBox.Show(msg);
                });
            }
            else
                bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = false;

            return args.Cancel;
        }
        #endregion


        public void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformSave(EditFormActionType.Save);
        }

        public void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PerformSave(EditFormActionType.Save))
            {
                bbiClose_ItemClick(sender, e);
            }
        }

        public void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PerformSave(EditFormActionType.Save))
            {
                bbiAddNew_ItemClick(sender, e);
            }
        }

        public void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformMove(EditFormActionType.New);
        }

        public void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bs.CancelEdit();
            bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = false;
            bbiNext.Enabled = bbiLast.Enabled = bbiPrev.Enabled = bbiFirst.Enabled = true;
            bbiReset.Enabled = false;
            bbiEdit.Enabled = true;
            bbiAddNew.Enabled = true;
            ChangeControlsReadOnly(true);
        }

        public void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformDelete(EditFormActionType.Delete);
        }

        public void bbiLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformMove(EditFormActionType.Last);
        }

        public void bbiPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformMove(EditFormActionType.Previous);
        }

        public void bbiNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformMove(EditFormActionType.Next);
        }

        public void bbiFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformMove(EditFormActionType.First);
        }
        public void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        public void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PerformChangeControlsReadOnly(false);
            bbiSave.Enabled = bbiSaveAndClose.Enabled = bbiSaveAndNew.Enabled = true;
            bbiNext.Enabled = bbiLast.Enabled = bbiPrev.Enabled = bbiFirst.Enabled = false;
            bbiReset.Enabled = true;
            bbiEdit.Enabled = false;
            bbiDelete.Enabled = false;
            bbiAddNew.Enabled = false;
            
            //layoutControlItemkey.Enabled = true;
            //layoutControlItemkey.is = false;
            //dataLayoutControl1.RestoreDefaultLayout();
            //key.ReadOnly = key.Properties.ReadOnly = true;
            //
            //
            //(dataLayoutControl1.GetControlByName("key") as TextEdit).Properties.UseReadOnlyAppearance = true;
            //(dataLayoutControl1.GetControlByName("key") as TextEdit).Properties.ReadOnly = true;
            //(dataLayoutControl1.GetControlByName("key") as TextEdit).ReadOnly = true;

            key.Enabled = false;

        }
        private void PerformChangeControlsReadOnly(bool readOnly = true)
        {
            ChangeControlsReadOnly(readOnly);
            AfterChangeControlReadOnlyState?.Invoke();
        }
        public virtual void ChangeControlsReadOnly(bool readOnly)
        {
            dataLayoutControl1.OptionsView.IsReadOnly = readOnly ? DefaultBoolean.True : DefaultBoolean.False;
            foreach (var ctrl in dataLayoutControl1.Controls)
            {
                if (ctrl is GridControl)
                {
                    var gridControl = (ctrl as GridControl);
                    var grid = gridControl.Views[0] as GridView;
                    if (grid != null)
                        grid.OptionsBehavior.ReadOnly = readOnly;
                }
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            PerformChangeControlsReadOnly();
        }

    }
}
