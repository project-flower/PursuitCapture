
namespace PursuitCapture
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWindow = new System.Windows.Forms.Label();
            this.comboBoxWindow = new System.Windows.Forms.ComboBox();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.labelSaveTo = new System.Windows.Forms.Label();
            this.comboBoxSaveTo = new System.Windows.Forms.ComboBox();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.radioButtonDateTime = new System.Windows.Forms.RadioButton();
            this.radioButtonIncrement = new System.Windows.Forms.RadioButton();
            this.textBoxIncrement = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxInitial = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.mainEngine = new PursuitCapture.MainEngine();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWindow
            // 
            this.labelWindow.AutoSize = true;
            this.labelWindow.Location = new System.Drawing.Point(12, 15);
            this.labelWindow.Name = "labelWindow";
            this.labelWindow.Size = new System.Drawing.Size(45, 12);
            this.labelWindow.TabIndex = 0;
            this.labelWindow.Text = "&Window:";
            // 
            // comboBoxWindow
            // 
            this.comboBoxWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWindow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PursuitCapture.Properties.Settings.Default, "Window", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxWindow.FormattingEnabled = true;
            this.comboBoxWindow.Location = new System.Drawing.Point(63, 12);
            this.comboBoxWindow.Name = "comboBoxWindow";
            this.comboBoxWindow.Size = new System.Drawing.Size(658, 20);
            this.comboBoxWindow.TabIndex = 1;
            this.comboBoxWindow.Text = global::PursuitCapture.Properties.Settings.Default.Window;
            // 
            // checkBoxRegex
            // 
            this.checkBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRegex.AutoSize = true;
            this.checkBoxRegex.Checked = global::PursuitCapture.Properties.Settings.Default.RegEx;
            this.checkBoxRegex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PursuitCapture.Properties.Settings.Default, "RegEx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRegex.Location = new System.Drawing.Point(727, 14);
            this.checkBoxRegex.Name = "checkBoxRegex";
            this.checkBoxRegex.Size = new System.Drawing.Size(61, 16);
            this.checkBoxRegex.TabIndex = 2;
            this.checkBoxRegex.Text = "Reg.Ex.";
            this.checkBoxRegex.UseVisualStyleBackColor = true;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 40);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 12);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "W&idth:";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PursuitCapture.Properties.Settings.Default, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownWidth.Location = new System.Drawing.Point(63, 38);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownWidth.TabIndex = 4;
            this.numericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownWidth.Value = global::PursuitCapture.Properties.Settings.Default.Width;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 68);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(40, 12);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "&Height:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PursuitCapture.Properties.Settings.Default, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownHeight.Location = new System.Drawing.Point(63, 66);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownHeight.TabIndex = 6;
            this.numericUpDownHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownHeight.Value = global::PursuitCapture.Properties.Settings.Default.Height;
            // 
            // labelSaveTo
            // 
            this.labelSaveTo.AutoSize = true;
            this.labelSaveTo.Location = new System.Drawing.Point(129, 43);
            this.labelSaveTo.Name = "labelSaveTo";
            this.labelSaveTo.Size = new System.Drawing.Size(49, 12);
            this.labelSaveTo.TabIndex = 7;
            this.labelSaveTo.Text = "&Save &To:";
            // 
            // comboBoxSaveTo
            // 
            this.comboBoxSaveTo.AllowDrop = true;
            this.comboBoxSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSaveTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PursuitCapture.Properties.Settings.Default, "SaveTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxSaveTo.FormattingEnabled = true;
            this.comboBoxSaveTo.Location = new System.Drawing.Point(184, 40);
            this.comboBoxSaveTo.Name = "comboBoxSaveTo";
            this.comboBoxSaveTo.Size = new System.Drawing.Size(523, 20);
            this.comboBoxSaveTo.TabIndex = 8;
            this.comboBoxSaveTo.Text = global::PursuitCapture.Properties.Settings.Default.SaveTo;
            this.comboBoxSaveTo.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSaveTo_DragDrop);
            this.comboBoxSaveTo.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxSaveTo_DragEnter);
            // 
            // buttonExplore
            // 
            this.buttonExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExplore.Location = new System.Drawing.Point(713, 38);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(75, 23);
            this.buttonExplore.TabIndex = 9;
            this.buttonExplore.Text = "&Explore";
            this.buttonExplore.UseVisualStyleBackColor = true;
            this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
            // 
            // radioButtonDateTime
            // 
            this.radioButtonDateTime.AutoSize = true;
            this.radioButtonDateTime.Checked = global::PursuitCapture.Properties.Settings.Default.DateTime;
            this.radioButtonDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PursuitCapture.Properties.Settings.Default, "DateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButtonDateTime.Location = new System.Drawing.Point(129, 70);
            this.radioButtonDateTime.Name = "radioButtonDateTime";
            this.radioButtonDateTime.Size = new System.Drawing.Size(72, 16);
            this.radioButtonDateTime.TabIndex = 10;
            this.radioButtonDateTime.TabStop = true;
            this.radioButtonDateTime.Text = "&DateTime";
            this.radioButtonDateTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncrement
            // 
            this.radioButtonIncrement.AutoSize = true;
            this.radioButtonIncrement.Location = new System.Drawing.Point(207, 70);
            this.radioButtonIncrement.Name = "radioButtonIncrement";
            this.radioButtonIncrement.Size = new System.Drawing.Size(73, 16);
            this.radioButtonIncrement.TabIndex = 11;
            this.radioButtonIncrement.Text = "&Increment";
            this.radioButtonIncrement.UseVisualStyleBackColor = true;
            this.radioButtonIncrement.CheckedChanged += new System.EventHandler(this.radioButtonIncrement_CheckedChanged);
            // 
            // textBoxIncrement
            // 
            this.textBoxIncrement.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PursuitCapture.Properties.Settings.Default, "Increment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxIncrement.Enabled = false;
            this.textBoxIncrement.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxIncrement.Location = new System.Drawing.Point(286, 69);
            this.textBoxIncrement.Name = "textBoxIncrement";
            this.textBoxIncrement.Size = new System.Drawing.Size(50, 19);
            this.textBoxIncrement.TabIndex = 12;
            this.textBoxIncrement.Text = global::PursuitCapture.Properties.Settings.Default.Increment;
            this.textBoxIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIncrement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIncrement_KeyDown);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(342, 67);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(23, 23);
            this.buttonUp.TabIndex = 13;
            this.buttonUp.Text = "▲";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(371, 67);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(23, 23);
            this.buttonDown.TabIndex = 14;
            this.buttonDown.Text = "▼";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(400, 67);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "&Reset To";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxInitial
            // 
            this.textBoxInitial.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PursuitCapture.Properties.Settings.Default, "Initial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxInitial.Enabled = false;
            this.textBoxInitial.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxInitial.Location = new System.Drawing.Point(481, 69);
            this.textBoxInitial.Name = "textBoxInitial";
            this.textBoxInitial.Size = new System.Drawing.Size(50, 19);
            this.textBoxInitial.TabIndex = 16;
            this.textBoxInitial.Text = global::PursuitCapture.Properties.Settings.Default.Initial;
            this.textBoxInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(537, 72);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(59, 12);
            this.labelDelay.TabIndex = 17;
            this.labelDelay.Text = "&Delay(ms):";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PursuitCapture.Properties.Settings.Default, "Delay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownDelay.Location = new System.Drawing.Point(602, 70);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownDelay.TabIndex = 18;
            this.numericUpDownDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDelay.Value = global::PursuitCapture.Properties.Settings.Default.Delay;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCapture.Location = new System.Drawing.Point(713, 67);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(75, 23);
            this.buttonCapture.TabIndex = 19;
            this.buttonCapture.Text = "&Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // mainEngine
            // 
            this.mainEngine.RequireDialog += new PursuitCapture.Events.RequireDialogEventHandler(this.mainEngine_RequireDialog);
            // 
            // openFileDialog
            // 
            this.openFileDialog.CheckFileExists = false;
            this.openFileDialog.FileName = "Folder Selection.";
            this.openFileDialog.Filter = "All Files|*.*";
            this.openFileDialog.Title = "Open";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 102);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.textBoxInitial);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBoxIncrement);
            this.Controls.Add(this.radioButtonIncrement);
            this.Controls.Add(this.radioButtonDateTime);
            this.Controls.Add(this.buttonExplore);
            this.Controls.Add(this.comboBoxSaveTo);
            this.Controls.Add(this.labelSaveTo);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.checkBoxRegex);
            this.Controls.Add(this.comboBoxWindow);
            this.Controls.Add(this.labelWindow);
            this.Name = "FormMain";
            this.Text = "PursuitCapture";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWindow;
        private System.Windows.Forms.ComboBox comboBoxWindow;
        private System.Windows.Forms.CheckBox checkBoxRegex;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label labelSaveTo;
        private System.Windows.Forms.ComboBox comboBoxSaveTo;
        private System.Windows.Forms.Button buttonExplore;
        private System.Windows.Forms.RadioButton radioButtonDateTime;
        private System.Windows.Forms.RadioButton radioButtonIncrement;
        private System.Windows.Forms.TextBox textBoxIncrement;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxInitial;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private MainEngine mainEngine;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
    }
}

