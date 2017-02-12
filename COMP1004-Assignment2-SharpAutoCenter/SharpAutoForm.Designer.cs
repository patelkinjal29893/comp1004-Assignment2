namespace COMP1004_Assignment2_SharpAutoCenter
{
    partial class SharpAutoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.AutoCenterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.ComputerNavigatorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishCheckBox = new System.Windows.Forms.GroupBox();
            this.CustomizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.colorDialogBox = new System.Windows.Forms.ColorDialog();
            this.fontDialogBox = new System.Windows.Forms.FontDialog();
            this.AutoCenterMenuStrip.SuspendLayout();
            this.AdditionalItemsGroupBox.SuspendLayout();
            this.ExteriorFinishCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(7, 58);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasePriceLabel.Size = new System.Drawing.Size(64, 13);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price :";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(7, 87);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(98, 13);
            this.AdditionalOptionsLabel.TabIndex = 2;
            this.AdditionalOptionsLabel.Text = "Additional Options :";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(7, 115);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(59, 13);
            this.SubTotalLabel.TabIndex = 3;
            this.SubTotalLabel.Text = "Sub Total :";
            // 
            // AutoCenterMenuStrip
            // 
            this.AutoCenterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AutoCenterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AutoCenterMenuStrip.Name = "AutoCenterMenuStrip";
            this.AutoCenterMenuStrip.Size = new System.Drawing.Size(434, 24);
            this.AutoCenterMenuStrip.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.colorToolStripMenuItem.Text = "&Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(142, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(7, 140);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(89, 13);
            this.SalesTaxLabel.TabIndex = 3;
            this.SalesTaxLabel.Text = "Sales Tax (13%) :";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(7, 166);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total :";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(7, 225);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(72, 13);
            this.AmountDueLabel.TabIndex = 3;
            this.AmountDueLabel.Text = "Amount Due :";
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(115, 55);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 5;
            this.BasePriceTextBox.Text = "0";
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(115, 84);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.ReadOnly = true;
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalOptionsTextBox.TabIndex = 5;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(115, 112);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 5;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(115, 137);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 5;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(115, 163);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 5;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(115, 222);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 5;
            // 
            // AdditionalItemsGroupBox
            // 
            this.AdditionalItemsGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.ComputerNavigatorCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalItemsGroupBox.Location = new System.Drawing.Point(248, 44);
            this.AdditionalItemsGroupBox.Name = "AdditionalItemsGroupBox";
            this.AdditionalItemsGroupBox.Size = new System.Drawing.Size(174, 100);
            this.AdditionalItemsGroupBox.TabIndex = 6;
            this.AdditionalItemsGroupBox.TabStop = false;
            this.AdditionalItemsGroupBox.Text = "Additional Items";
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(24, 51);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.LeatherInteriorCheckBox.TabIndex = 0;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputerNavigatorCheckBox
            // 
            this.ComputerNavigatorCheckBox.AutoSize = true;
            this.ComputerNavigatorCheckBox.Location = new System.Drawing.Point(24, 75);
            this.ComputerNavigatorCheckBox.Name = "ComputerNavigatorCheckBox";
            this.ComputerNavigatorCheckBox.Size = new System.Drawing.Size(120, 17);
            this.ComputerNavigatorCheckBox.TabIndex = 0;
            this.ComputerNavigatorCheckBox.Text = "Computer Navigator";
            this.ComputerNavigatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(24, 28);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExteriorFinishCheckBox
            // 
            this.ExteriorFinishCheckBox.Controls.Add(this.CustomizedDetailingRadioButton);
            this.ExteriorFinishCheckBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishCheckBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishCheckBox.Location = new System.Drawing.Point(248, 156);
            this.ExteriorFinishCheckBox.Name = "ExteriorFinishCheckBox";
            this.ExteriorFinishCheckBox.Size = new System.Drawing.Size(174, 100);
            this.ExteriorFinishCheckBox.TabIndex = 6;
            this.ExteriorFinishCheckBox.TabStop = false;
            this.ExteriorFinishCheckBox.Text = "Exterior Finish";
            // 
            // CustomizedDetailingRadioButton
            // 
            this.CustomizedDetailingRadioButton.AutoSize = true;
            this.CustomizedDetailingRadioButton.Location = new System.Drawing.Point(24, 69);
            this.CustomizedDetailingRadioButton.Name = "CustomizedDetailingRadioButton";
            this.CustomizedDetailingRadioButton.Size = new System.Drawing.Size(123, 17);
            this.CustomizedDetailingRadioButton.TabIndex = 0;
            this.CustomizedDetailingRadioButton.Text = "Customized Detailing";
            this.CustomizedDetailingRadioButton.UseVisualStyleBackColor = true;
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(24, 43);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.PearlizedRadioButton.TabIndex = 0;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(24, 20);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(27, 318);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(184, 318);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(321, 318);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(7, 197);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(104, 13);
            this.TradeInAllowanceLabel.TabIndex = 8;
            this.TradeInAllowanceLabel.Text = "Trade-in Allowance :";
            // 
            // TradeInAllowanceTextBox
            // 
            this.TradeInAllowanceTextBox.Location = new System.Drawing.Point(115, 194);
            this.TradeInAllowanceTextBox.Name = "TradeInAllowanceTextBox";
            this.TradeInAllowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeInAllowanceTextBox.TabIndex = 5;
            this.TradeInAllowanceTextBox.Text = "0";
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 368);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishCheckBox);
            this.Controls.Add(this.AdditionalItemsGroupBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.TradeInAllowanceTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.AutoCenterMenuStrip);
            this.Name = "SharpAutoForm";
            this.Text = "Auto Center";
            this.AutoCenterMenuStrip.ResumeLayout(false);
            this.AutoCenterMenuStrip.PerformLayout();
            this.AdditionalItemsGroupBox.ResumeLayout(false);
            this.AdditionalItemsGroupBox.PerformLayout();
            this.ExteriorFinishCheckBox.ResumeLayout(false);
            this.ExteriorFinishCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.MenuStrip AutoCenterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.GroupBox AdditionalItemsGroupBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox ComputerNavigatorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.GroupBox ExteriorFinishCheckBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.TextBox TradeInAllowanceTextBox;
        private System.Windows.Forms.RadioButton CustomizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.ColorDialog colorDialogBox;
        private System.Windows.Forms.FontDialog fontDialogBox;
    }
}

