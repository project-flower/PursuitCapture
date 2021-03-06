using System;
using System.Drawing;
using System.Windows.Forms;

namespace PursuitCapture
{
    public partial class FormPreview : Form
    {
        #region Private Fieldss

        private Image image = null;

        #endregion

        #region Public Methods

        public FormPreview()
        {
            InitializeComponent();
        }

        public void Show(IWin32Window owner, Image image, int time)
        {
            timer.Stop();

            if (this.image != null)
            {
                DisposeImage();
            }

            this.image = image;
            pictureBox.Image = this.image;
            Size = image.Size;

            try
            {
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Left = (bounds.Width / 2 - Width / 2);
                Top = (bounds.Height / 2 - Height / 2);
            }
            catch
            {
            }

            if (!Visible)
            {
                pictureBox.Visible = false;
                Show(owner);
            }

            timer.Interval = time;
            timer.Start();
        }

        #endregion

        #region Private Methods

        private void DisposeImage()
        {
            pictureBox.Image = null;

            if (image != null)
            {
                image.Dispose();
                image = null;
            }
        }

        #endregion

        // Designer's Methods

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            DisposeImage();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Hide();
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                pictureBox.Visible = true;
            }
            else
            {
                DisposeImage();
            }
        }
    }
}
