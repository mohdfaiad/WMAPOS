using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace WMAFW.UserControls
{
    public class ActionEventArgs
    {
        public ActionEventArgs(EditFormActionType actionType)
        {
            ActionType = actionType;
        }

        public EditFormActionType ActionType { get; }
        public bool Cancel { get; set; } = false;

        public List<string> Message { get; set; } = new List<string>();

    }
}
