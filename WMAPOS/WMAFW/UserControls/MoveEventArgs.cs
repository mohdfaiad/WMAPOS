using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace WMAFW.UserControls
{
    public class MoveEventArgs
    {
        public MoveEventArgs(EditFormActionType actionType)
        {
            MoveType = actionType;
        }

        public EditFormActionType MoveType { get; }

    }
}
