namespace QwertyInjector
{
    partial class QwertyInjector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QwertyInjector));
            this.label1 = new System.Windows.Forms.Label();
            this.InjectBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.FileDialogButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.FileLocation = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ProcessName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.LoggerLabel = new System.Windows.Forms.Label();
            this.AnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.LinksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscordLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GithubLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "QwertyInjector";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InjectBtn
            // 
            this.InjectBtn.Animated = true;
            this.InjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.InjectBtn.BorderColor = System.Drawing.Color.Transparent;
            this.InjectBtn.BorderRadius = 20;
            this.InjectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InjectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InjectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InjectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InjectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.InjectBtn.Font = new System.Drawing.Font("Minecraft", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InjectBtn.ForeColor = System.Drawing.Color.White;
            this.InjectBtn.Location = new System.Drawing.Point(244, 148);
            this.InjectBtn.Name = "InjectBtn";
            this.InjectBtn.Size = new System.Drawing.Size(328, 87);
            this.InjectBtn.TabIndex = 2;
            this.InjectBtn.Text = "Start Inject";
            this.InjectBtn.Click += new System.EventHandler(this.StartInject);
            // 
            // FileDialogButton
            // 
            this.FileDialogButton.Animated = true;
            this.FileDialogButton.BackColor = System.Drawing.Color.Transparent;
            this.FileDialogButton.BorderRadius = 10;
            this.FileDialogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FileDialogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FileDialogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FileDialogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FileDialogButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FileDialogButton.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileDialogButton.ForeColor = System.Drawing.Color.White;
            this.FileDialogButton.Location = new System.Drawing.Point(77, 261);
            this.FileDialogButton.Name = "FileDialogButton";
            this.FileDialogButton.Size = new System.Drawing.Size(180, 110);
            this.FileDialogButton.TabIndex = 3;
            this.FileDialogButton.Text = "Select File";
            this.FileDialogButton.Click += new System.EventHandler(this.FileDialogButton_Click);
            // 
            // FileLocation
            // 
            this.FileLocation.BackColor = System.Drawing.Color.Transparent;
            this.FileLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FileLocation.BorderRadius = 10;
            this.FileLocation.DefaultText = "";
            this.FileLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FileLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileLocation.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FileLocation.ForeColor = System.Drawing.Color.White;
            this.FileLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileLocation.Location = new System.Drawing.Point(275, 261);
            this.FileLocation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.PasswordChar = '\0';
            this.FileLocation.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.FileLocation.PlaceholderText = "No Specified File...";
            this.FileLocation.SelectedText = "";
            this.FileLocation.Size = new System.Drawing.Size(456, 45);
            this.FileLocation.TabIndex = 5;
            // 
            // ProcessName
            // 
            this.ProcessName.BackColor = System.Drawing.Color.Transparent;
            this.ProcessName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ProcessName.BorderRadius = 10;
            this.ProcessName.DefaultText = "Minecraft.Windows.exe";
            this.ProcessName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProcessName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProcessName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProcessName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProcessName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ProcessName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProcessName.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProcessName.ForeColor = System.Drawing.Color.White;
            this.ProcessName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProcessName.Location = new System.Drawing.Point(275, 326);
            this.ProcessName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.PasswordChar = '\0';
            this.ProcessName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ProcessName.PlaceholderText = "";
            this.ProcessName.SelectedText = "";
            this.ProcessName.Size = new System.Drawing.Size(456, 45);
            this.ProcessName.TabIndex = 6;
            // 
            // LoggerLabel
            // 
            this.LoggerLabel.AutoSize = true;
            this.LoggerLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoggerLabel.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LoggerLabel.Location = new System.Drawing.Point(12, 415);
            this.LoggerLabel.Name = "LoggerLabel";
            this.LoggerLabel.Size = new System.Drawing.Size(167, 26);
            this.LoggerLabel.TabIndex = 8;
            this.LoggerLabel.Text = "Version 1.0.0";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Menu.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinksMenu,
            this.InjectMenu,
            this.ExitMenu});
            this.Menu.Name = "Menu";
            this.Menu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Menu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.ColorTable = null;
            this.Menu.RenderStyle.RoundedEdges = true;
            this.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Menu.Size = new System.Drawing.Size(143, 76);
            // 
            // LinksMenu
            // 
            this.LinksMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscordLinkMenu,
            this.GithubLinkMenu,
            this.WebsiteLinkMenu});
            this.LinksMenu.ForeColor = System.Drawing.Color.White;
            this.LinksMenu.Name = "linksToolStripMenuItem";
            this.LinksMenu.Size = new System.Drawing.Size(142, 24);
            this.LinksMenu.Text = "Links";
            // 
            // DiscordLinkMenu
            // 
            this.DiscordLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DiscordLinkMenu.ForeColor = System.Drawing.Color.White;
            this.DiscordLinkMenu.Name = "DiscordLinkMenu";
            this.DiscordLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.DiscordLinkMenu.Text = "Discord Server";
            this.DiscordLinkMenu.Click += new System.EventHandler(this.DiscordLink_Open);
            // 
            // GithubLinkMenu
            // 
            this.GithubLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.GithubLinkMenu.ForeColor = System.Drawing.Color.White;
            this.GithubLinkMenu.Name = "GithubLinkMenu";
            this.GithubLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.GithubLinkMenu.Text = "Github";
            this.GithubLinkMenu.Click += new System.EventHandler(this.GithubLink_Open);
            // 
            // WebsiteLinkMenu
            // 
            this.WebsiteLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.WebsiteLinkMenu.ForeColor = System.Drawing.Color.White;
            this.WebsiteLinkMenu.Name = "WebsiteLinkMenu";
            this.WebsiteLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.WebsiteLinkMenu.Text = "Website";
            this.WebsiteLinkMenu.Click += new System.EventHandler(this.WebsiteLink_Open);
            // 
            // InjectMenu
            // 
            this.InjectMenu.ForeColor = System.Drawing.Color.White;
            this.InjectMenu.Name = "InjectMenu";
            this.InjectMenu.Size = new System.Drawing.Size(142, 24);
            this.InjectMenu.Text = "Inject";
            this.InjectMenu.Click += new System.EventHandler(this.InjectViaMenu);
            // 
            // ExitMenu
            // 
            this.ExitMenu.ForeColor = System.Drawing.Color.White;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(142, 24);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.Exit);
            // 
            // QwertyInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::QwertyInjector.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoggerLabel);
            this.Controls.Add(this.ProcessName);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.FileDialogButton);
            this.Controls.Add(this.InjectBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QwertyInjector";
            this.Text = "QwertyInjector";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightClickMenu);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton InjectBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton FileDialogButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox FileLocation;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ProcessName;
        private Label label2;
        private Label LoggerLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow AnimateWindow;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private ToolStripMenuItem LinksMenu;
        private ToolStripMenuItem DiscordLinkMenu;
        private ToolStripMenuItem GithubLinkMenu;
        private ToolStripMenuItem WebsiteLinkMenu;
        private ToolStripMenuItem InjectMenu;
        private ToolStripMenuItem ExitMenu;
    }
}