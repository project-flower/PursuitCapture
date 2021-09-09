using System;
using System.Windows.Forms;

namespace PursuitCapture.Events
{
    public class RequireDialogEventArgs : EventArgs
    {
        #region Public Fields

        public readonly MessageBoxButtons Buttons;
        public readonly MessageBoxIcon Icon;
        public DialogResult Result = 0;
        public readonly string Text;

        #endregion

        #region Public Methods

        public RequireDialogEventArgs(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Buttons = buttons;
            Icon = icon;
            Text = text;
        }

        #endregion
    }
}
