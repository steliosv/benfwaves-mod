﻿/** \file
* \$Rev: 82 $
* 
* \$Date: 2011-04-02 23:40:01 +0000 (Sat, 02 Apr 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/MainForm.Designer.cs $
*/

namespace BenfWaves.Client
{
	partial class MainForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowToolbar = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowStatus = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTileVert = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTileHorz = new System.Windows.Forms.ToolStripMenuItem();
			this.menuArrange = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHomepage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWiki = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFirmwareManual = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolbarOpen = new System.Windows.Forms.ToolStripButton();
			this.toolbarSaveAs = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolbarPrint = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.windowsMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.MdiWindowListItem = this.windowsMenu;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(561, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSaveAs,
            this.toolStripSeparator4,
            this.menuPrint,
            this.menuPrintPreview,
            this.menuPrintSetup,
            this.toolStripSeparator5,
            this.menuExit});
			this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "&File";
			// 
			// menuOpen
			// 
			this.menuOpen.Image = global::BenfWaves.Client.Properties.Resources.document_open;
			this.menuOpen.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuOpen.Size = new System.Drawing.Size(163, 22);
			this.menuOpen.Text = "&Open...";
			this.menuOpen.Click += new System.EventHandler(this.OpenFile_Click);
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Image = global::BenfWaves.Client.Properties.Resources.document_save;
			this.menuSaveAs.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuSaveAs.Name = "menuSaveAs";
			this.menuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuSaveAs.Size = new System.Drawing.Size(163, 22);
			this.menuSaveAs.Text = "&Save As...";
			this.menuSaveAs.Click += new System.EventHandler(this.SaveFile_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
			// 
			// menuPrint
			// 
			this.menuPrint.Image = global::BenfWaves.Client.Properties.Resources.document_print;
			this.menuPrint.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuPrint.Name = "menuPrint";
			this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.menuPrint.Size = new System.Drawing.Size(163, 22);
			this.menuPrint.Text = "&Print...";
			// 
			// menuPrintPreview
			// 
			this.menuPrintPreview.Image = global::BenfWaves.Client.Properties.Resources.document_print_preview;
			this.menuPrintPreview.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuPrintPreview.Name = "menuPrintPreview";
			this.menuPrintPreview.Size = new System.Drawing.Size(163, 22);
			this.menuPrintPreview.Text = "Print Pre&view...";
			// 
			// menuPrintSetup
			// 
			this.menuPrintSetup.Image = global::BenfWaves.Client.Properties.Resources.document_properties;
			this.menuPrintSetup.Name = "menuPrintSetup";
			this.menuPrintSetup.Size = new System.Drawing.Size(163, 22);
			this.menuPrintSetup.Text = "Print Setup...";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(160, 6);
			// 
			// menuExit
			// 
			this.menuExit.Image = global::BenfWaves.Client.Properties.Resources.system_log_out;
			this.menuExit.Name = "menuExit";
			this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.menuExit.Size = new System.Drawing.Size(163, 22);
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.toolStripSeparator7,
            this.menuSelectAll});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "&Edit";
			// 
			// menuCopy
			// 
			this.menuCopy.Image = global::BenfWaves.Client.Properties.Resources.edit_copy;
			this.menuCopy.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuCopy.Name = "menuCopy";
			this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.menuCopy.Size = new System.Drawing.Size(164, 22);
			this.menuCopy.Text = "&Copy";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
			// 
			// menuSelectAll
			// 
			this.menuSelectAll.Name = "menuSelectAll";
			this.menuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.menuSelectAll.Size = new System.Drawing.Size(164, 22);
			this.menuSelectAll.Text = "Select &All";
			// 
			// viewMenu
			// 
			this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShowToolbar,
            this.menuShowStatus});
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new System.Drawing.Size(44, 20);
			this.viewMenu.Text = "&View";
			// 
			// menuShowToolbar
			// 
			this.menuShowToolbar.Checked = true;
			this.menuShowToolbar.CheckOnClick = true;
			this.menuShowToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuShowToolbar.Name = "menuShowToolbar";
			this.menuShowToolbar.Size = new System.Drawing.Size(126, 22);
			this.menuShowToolbar.Text = "&Toolbar";
			this.menuShowToolbar.Click += new System.EventHandler(this.ShowToolbar_Click);
			// 
			// menuShowStatus
			// 
			this.menuShowStatus.Checked = true;
			this.menuShowStatus.CheckOnClick = true;
			this.menuShowStatus.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuShowStatus.Name = "menuShowStatus";
			this.menuShowStatus.Size = new System.Drawing.Size(126, 22);
			this.menuShowStatus.Text = "&Status Bar";
			this.menuShowStatus.Click += new System.EventHandler(this.ShowStatusbar_Click);
			// 
			// windowsMenu
			// 
			this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuTileVert,
            this.menuTileHorz,
            this.menuArrange,
            this.toolStripSeparator2,
            this.menuCloseAll});
			this.windowsMenu.Name = "windowsMenu";
			this.windowsMenu.Size = new System.Drawing.Size(68, 20);
			this.windowsMenu.Text = "&Windows";
			// 
			// menuCascade
			// 
			this.menuCascade.Image = global::BenfWaves.Client.Properties.Resources.preferences_system_windows;
			this.menuCascade.Name = "menuCascade";
			this.menuCascade.Size = new System.Drawing.Size(151, 22);
			this.menuCascade.Text = "&Cascade";
			this.menuCascade.Click += new System.EventHandler(this.Cascade_Click);
			// 
			// menuTileVert
			// 
			this.menuTileVert.Name = "menuTileVert";
			this.menuTileVert.Size = new System.Drawing.Size(151, 22);
			this.menuTileVert.Text = "Tile &Vertical";
			this.menuTileVert.Click += new System.EventHandler(this.TileVertical_Click);
			// 
			// menuTileHorz
			// 
			this.menuTileHorz.Name = "menuTileHorz";
			this.menuTileHorz.Size = new System.Drawing.Size(151, 22);
			this.menuTileHorz.Text = "Tile &Horizontal";
			this.menuTileHorz.Click += new System.EventHandler(this.TileHorizontal_Click);
			// 
			// menuArrange
			// 
			this.menuArrange.Name = "menuArrange";
			this.menuArrange.Size = new System.Drawing.Size(151, 22);
			this.menuArrange.Text = "&Arrange Icons";
			this.menuArrange.Click += new System.EventHandler(this.ArrangeIcons_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
			// 
			// menuCloseAll
			// 
			this.menuCloseAll.Name = "menuCloseAll";
			this.menuCloseAll.Size = new System.Drawing.Size(151, 22);
			this.menuCloseAll.Text = "C&lose All";
			this.menuCloseAll.Click += new System.EventHandler(this.CloseAll_Click);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHomepage,
            this.menuWiki,
            this.menuFirmwareManual});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "&Help";
			// 
			// menuHomepage
			// 
			this.menuHomepage.Image = global::BenfWaves.Client.Properties.Resources.go_home;
			this.menuHomepage.ImageTransparentColor = System.Drawing.Color.Black;
			this.menuHomepage.Name = "menuHomepage";
			this.menuHomepage.Size = new System.Drawing.Size(166, 22);
			this.menuHomepage.Text = "Homepage";
			this.menuHomepage.Click += new System.EventHandler(this.Homepage_Click);
			// 
			// menuWiki
			// 
			this.menuWiki.Image = global::BenfWaves.Client.Properties.Resources.help_browser;
			this.menuWiki.Name = "menuWiki";
			this.menuWiki.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.menuWiki.Size = new System.Drawing.Size(166, 22);
			this.menuWiki.Text = "Wiki";
			this.menuWiki.Click += new System.EventHandler(this.Wiki_Click);
			// 
			// menuFirmwareManual
			// 
			this.menuFirmwareManual.Image = global::BenfWaves.Client.Properties.Resources.internet_web_browser;
			this.menuFirmwareManual.Name = "menuFirmwareManual";
			this.menuFirmwareManual.Size = new System.Drawing.Size(166, 22);
			this.menuFirmwareManual.Text = "Firmware Manual";
			this.menuFirmwareManual.Click += new System.EventHandler(this.FirmwareManual_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarOpen,
            this.toolbarSaveAs,
            this.toolStripSeparator1,
            this.toolbarPrint});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(561, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			// 
			// toolbarOpen
			// 
			this.toolbarOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolbarOpen.Image = global::BenfWaves.Client.Properties.Resources.document_open;
			this.toolbarOpen.ImageTransparentColor = System.Drawing.Color.Black;
			this.toolbarOpen.Name = "toolbarOpen";
			this.toolbarOpen.Size = new System.Drawing.Size(23, 22);
			this.toolbarOpen.Text = "Open...";
			this.toolbarOpen.ToolTipText = "Open...";
			this.toolbarOpen.Click += new System.EventHandler(this.OpenFile_Click);
			// 
			// toolbarSaveAs
			// 
			this.toolbarSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolbarSaveAs.Image = global::BenfWaves.Client.Properties.Resources.document_save;
			this.toolbarSaveAs.ImageTransparentColor = System.Drawing.Color.Black;
			this.toolbarSaveAs.Name = "toolbarSaveAs";
			this.toolbarSaveAs.Size = new System.Drawing.Size(23, 22);
			this.toolbarSaveAs.Text = "Save As...";
			this.toolbarSaveAs.ToolTipText = "Save As...";
			this.toolbarSaveAs.Click += new System.EventHandler(this.SaveFile_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolbarPrint
			// 
			this.toolbarPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolbarPrint.Image = global::BenfWaves.Client.Properties.Resources.document_print;
			this.toolbarPrint.ImageTransparentColor = System.Drawing.Color.Black;
			this.toolbarPrint.Name = "toolbarPrint";
			this.toolbarPrint.Size = new System.Drawing.Size(23, 22);
			this.toolbarPrint.Text = "Print...";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 528);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(561, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Ready";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 550);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = global::BenfWaves.Client.Properties.Resources.utilities_system_monitor_icon;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "BenfWaves";
			this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem menuPrintSetup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripMenuItem menuTileHorz;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
		private System.Windows.Forms.ToolStripMenuItem menuPrint;
		private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem menuCopy;
		private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
		private System.Windows.Forms.ToolStripMenuItem viewMenu;
		private System.Windows.Forms.ToolStripMenuItem menuShowToolbar;
		private System.Windows.Forms.ToolStripMenuItem menuShowStatus;
		private System.Windows.Forms.ToolStripMenuItem windowsMenu;
		private System.Windows.Forms.ToolStripMenuItem menuCascade;
		private System.Windows.Forms.ToolStripMenuItem menuTileVert;
		private System.Windows.Forms.ToolStripMenuItem menuCloseAll;
		private System.Windows.Forms.ToolStripMenuItem menuArrange;
		private System.Windows.Forms.ToolStripButton toolbarOpen;
		private System.Windows.Forms.ToolStripButton toolbarSaveAs;
		private System.Windows.Forms.ToolStripButton toolbarPrint;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem menuHomepage;
		private System.Windows.Forms.ToolStripMenuItem menuWiki;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuFirmwareManual;
	}
}



