using System.ComponentModel;

namespace System.Windows.Forms
{
    public class SelectDirectoryDialog : FileOpenDialog
    {
        #region Public Properties

        [Category("データ")]
        public string DirectoryName
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }

        #endregion

        #region Public Methods

        public SelectDirectoryDialog() :
            this(false)
        {
        }

        public SelectDirectoryDialog(bool reusable) :
            base(Win32Api.FILEOPENDIALOGOPTIONS.FOS_PICKFOLDERS, reusable)
        {
        }

        #endregion
    }
}
