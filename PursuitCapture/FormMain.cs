using PursuitCapture.Events;
using PursuitCapture.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PursuitCapture
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private readonly FormPreview formPreview = new FormPreview();
        private readonly int previewInterval;

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = new Size(int.MaxValue, Height);
            Settings settings = Settings.Default;
            previewInterval = settings.PreviewInterval;
            RadioButton radioButton = (settings.DateTime ? radioButtonDateTime : radioButtonIncrement);

            if (!radioButton.Checked)
            {
                radioButton.Checked = true;
            }
        }

        #endregion

        #region Private Methods

        private void DoCapture()
        {
            string fileName;
            bool increment = !radioButtonDateTime.Checked;

            if (!increment)
            {
                DateTime currentTime = DateTime.Now;
                fileName = string.Format("{0:d4}{1:d2}{2:d2}{3:d2}{4:d2}{5:d2}",
                    currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
            }
            else
            {
                try
                {
                    GetIncrementalValue();
                }
                catch (Exception exception)
                {
                    ShowErrorMessage(exception.Message);
                    return;
                }

                fileName = $"{textBoxIncrement.Text}";
            }

            try
            {
                fileName = $"{Path.Combine(comboBoxSaveTo.Text, fileName)}.png";
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
                return;
            }

            try
            {
                Image image = mainEngine.Capture(comboBoxWindow.Text, checkBoxRegex.Checked,
                    new Size((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value), fileName);

                if (image == null)
                {
                    return;
                }

                formPreview.Show(this, image, previewInterval);

                if (increment)
                {
                    Increment(1);
                }
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
                return;
            }
        }

        private int GetIncrementalValue()
        {
            string text = textBoxIncrement.Text;

            try
            {
                return int.Parse(text);
            }
            catch (Exception exception)
            {
                throw new Exception($"{text} は数値に変換できません。\r\n\r\n{exception.Message}");
            }
        }

        private void Increment(int additionalValue)
        {
            int value;

            try
            {
                value = GetIncrementalValue();
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
                return;
            }

            int maxValue = int.MaxValue;
            int nextValue = (value + additionalValue);

            if ((additionalValue > 0) && (nextValue < value))
            {
                nextValue = maxValue;
            }
            else if ((additionalValue < 0) && (nextValue < 0))
            {
                nextValue = 0;
            }
            else
            {
                nextValue = (value + additionalValue);
            }

            textBoxIncrement.Text = string.Format($"{{0:D{textBoxIncrement.Text.Length}}}", nextValue);
        }

        private void ShowErrorMessage(string message)
        {
            ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowMessage(string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, message, Text, buttons, icon);
        }

        #endregion

        // Designer's Methods

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            int interval = (int)numericUpDownDelay.Value;

            if (interval > 0)
            {
                timer.Stop();
                timer.Interval = interval;
                timer.Start();
            }
            else
            {
                DoCapture();
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Increment(-1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxIncrement.Text = textBoxInitial.Text;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            Increment(1);
        }

        private void comboBoxSaveTo_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(DataFormats.FileDrop) is string[] dropData) || (dropData.Length < 1))
            {
                return;
            }

            (sender as ComboBox).Text = dropData[0];
        }

        private void comboBoxSaveTo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }

        private void mainEngine_RequireDialog(object sender, RequireDialogEventArgs e)
        {
            e.Result = ShowMessage(e.Text, e.Buttons, e.Icon);
        }

        private void radioButtonIncrement_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = radioButtonIncrement.Checked;
            textBoxIncrement.Enabled = enabled;
            buttonReset.Enabled = enabled;
            textBoxInitial.Enabled = enabled;
        }

        private void textBoxIncrement_KeyDown(object sender, KeyEventArgs e)
        {
            int additionalValue;

            switch (e.KeyCode)
            {
                case Keys.Down:
                    additionalValue = -1;
                    break;
                case Keys.Up:
                    additionalValue = 1;
                    break;
                default:
                    return;
            }

            Increment(additionalValue);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            DoCapture();
        }
    }
}
