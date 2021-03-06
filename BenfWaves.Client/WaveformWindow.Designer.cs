﻿/** \file
* \$Rev: 124 $
* 
* \$Date: 2011-05-27 02:09:29 +0000 (Fri, 27 May 2011) $
*
* \$URL: http://benfwaves.googlecode.com/svn/branches/basic-vs2012/BenfWaves.Client/WaveformWindow.Designer.cs $
*/

namespace BenfWaves.Client
{
	partial class WaveformWindow
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
			this.components = new System.ComponentModel.Container();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProfile = new System.Windows.Forms.TabPage();
			this.groupMisc = new System.Windows.Forms.GroupBox();
			this.tableMisc = new System.Windows.Forms.TableLayoutPanel();
			this.bindSrcProfile = new System.Windows.Forms.BindingSource(this.components);
			this.bindSrcWaveform = new System.Windows.Forms.BindingSource(this.components);
			this.groupTrigger = new System.Windows.Forms.GroupBox();
			this.tableTrigger = new System.Windows.Forms.TableLayoutPanel();
			this.groupVertical = new System.Windows.Forms.GroupBox();
			this.tableVertical = new System.Windows.Forms.TableLayoutPanel();
			this.groupHorizontal = new System.Windows.Forms.GroupBox();
			this.tableHorizontal = new System.Windows.Forms.TableLayoutPanel();
			this.tabPageTimeData = new System.Windows.Forms.TabPage();
			this.dataGridTime = new System.Windows.Forms.DataGridView();
			this.seqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageVoltageGraphs = new System.Windows.Forms.TabPage();
			this.vScrollPanVolt = new System.Windows.Forms.VScrollBar();
			this.vScrollZoomVolt = new System.Windows.Forms.VScrollBar();
			this.tableVoltTime = new System.Windows.Forms.TableLayoutPanel();
			this.hScrollPanVoltTime = new System.Windows.Forms.HScrollBar();
			this.hScrollZoomVoltTime = new System.Windows.Forms.HScrollBar();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelFirmware = new BenfWaves.Client.TableLabel();
			this.labelFileNo = new BenfWaves.Client.TableLabel();
			this.textFileNo = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textFirmware = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.labelTriggerIndex = new BenfWaves.Client.TableLabel();
			this.labelTriggerSens = new BenfWaves.Client.TableLabel();
			this.labelTriggerLevel = new BenfWaves.Client.TableLabel();
			this.labelTriggerKind = new BenfWaves.Client.TableLabel();
			this.labelTriggerMode = new BenfWaves.Client.TableLabel();
			this.textTriggerLevel = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textTriggerSens = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textTriggerIndex = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.comboTriggerMode = new BenfWaves.Client.ReadOnlyComboBox();
			this.comboTriggerKind = new BenfWaves.Client.ReadOnlyComboBox();
			this.labelVoltDiv = new BenfWaves.Client.TableLabel();
			this.labelAtten = new BenfWaves.Client.TableLabel();
			this.labelVSens = new BenfWaves.Client.TableLabel();
			this.labelVMax = new BenfWaves.Client.TableLabel();
			this.labelRin = new BenfWaves.Client.TableLabel();
			this.textVoltDiv = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textAtten = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textVSens = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textRin = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textVMax = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textSecDiv = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textSampDiv = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textSecSamp = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textSampSec = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textSecTot = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.labelSecDiv = new BenfWaves.Client.TableLabel();
			this.labelSampDiv = new BenfWaves.Client.TableLabel();
			this.labelSampSec = new BenfWaves.Client.TableLabel();
			this.labelSecSamp = new BenfWaves.Client.TableLabel();
			this.labelSecTot = new BenfWaves.Client.TableLabel();
			this.labelSampTot = new BenfWaves.Client.TableLabel();
			this.comboFastMode = new BenfWaves.Client.ReadOnlyComboBox();
			this.labelDivTot = new BenfWaves.Client.TableLabel();
			this.labelFastMode = new BenfWaves.Client.TableLabel();
			this.textSampTot = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.textDivTot = new BenfWaves.Client.ReadOnlyTableTextbox();
			this.panelVoltTime = new BenfWaves.Client.TriggeredWaveformPanel();
			this.tabControl.SuspendLayout();
			this.tabPageProfile.SuspendLayout();
			this.groupMisc.SuspendLayout();
			this.tableMisc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcWaveform)).BeginInit();
			this.groupTrigger.SuspendLayout();
			this.tableTrigger.SuspendLayout();
			this.groupVertical.SuspendLayout();
			this.tableVertical.SuspendLayout();
			this.groupHorizontal.SuspendLayout();
			this.tableHorizontal.SuspendLayout();
			this.tabPageTimeData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTime)).BeginInit();
			this.tabPageVoltageGraphs.SuspendLayout();
			this.tableVoltTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageProfile);
			this.tabControl.Controls.Add(this.tabPageTimeData);
			this.tabControl.Controls.Add(this.tabPageVoltageGraphs);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(430, 352);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageProfile
			// 
			this.tabPageProfile.AutoScroll = true;
			this.tabPageProfile.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageProfile.Controls.Add(this.groupMisc);
			this.tabPageProfile.Controls.Add(this.groupTrigger);
			this.tabPageProfile.Controls.Add(this.groupVertical);
			this.tabPageProfile.Controls.Add(this.groupHorizontal);
			this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
			this.tabPageProfile.Name = "tabPageProfile";
			this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProfile.Size = new System.Drawing.Size(422, 326);
			this.tabPageProfile.TabIndex = 0;
			this.tabPageProfile.Text = "Profile";
			this.tabPageProfile.ToolTipText = "Properties of the waveform.";
			// 
			// groupMisc
			// 
			this.groupMisc.Controls.Add(this.tableMisc);
			this.groupMisc.Location = new System.Drawing.Point(8, 242);
			this.groupMisc.Name = "groupMisc";
			this.groupMisc.Size = new System.Drawing.Size(214, 75);
			this.groupMisc.TabIndex = 1;
			this.groupMisc.TabStop = false;
			this.groupMisc.Text = "Misc";
			// 
			// tableMisc
			// 
			this.tableMisc.AutoSize = true;
			this.tableMisc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableMisc.ColumnCount = 2;
			this.tableMisc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableMisc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableMisc.Controls.Add(this.labelFirmware, 0, 1);
			this.tableMisc.Controls.Add(this.labelFileNo, 0, 0);
			this.tableMisc.Controls.Add(this.textFileNo, 1, 0);
			this.tableMisc.Controls.Add(this.textFirmware, 1, 1);
			this.tableMisc.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableMisc.Location = new System.Drawing.Point(3, 16);
			this.tableMisc.Name = "tableMisc";
			this.tableMisc.RowCount = 2;
			this.tableMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMisc.Size = new System.Drawing.Size(208, 52);
			this.tableMisc.TabIndex = 0;
			// 
			// bindSrcProfile
			// 
			this.bindSrcProfile.AllowNew = false;
			this.bindSrcProfile.DataMember = "Profile";
			this.bindSrcProfile.DataSource = this.bindSrcWaveform;
			// 
			// bindSrcWaveform
			// 
			this.bindSrcWaveform.AllowNew = false;
			this.bindSrcWaveform.DataSource = typeof(BenfWaves.Library.Waveform);
			// 
			// groupTrigger
			// 
			this.groupTrigger.Controls.Add(this.tableTrigger);
			this.groupTrigger.Location = new System.Drawing.Point(228, 165);
			this.groupTrigger.Name = "groupTrigger";
			this.groupTrigger.Size = new System.Drawing.Size(185, 152);
			this.groupTrigger.TabIndex = 3;
			this.groupTrigger.TabStop = false;
			this.groupTrigger.Text = "Trigger";
			// 
			// tableTrigger
			// 
			this.tableTrigger.AutoSize = true;
			this.tableTrigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableTrigger.ColumnCount = 2;
			this.tableTrigger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableTrigger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableTrigger.Controls.Add(this.labelTriggerIndex, 0, 4);
			this.tableTrigger.Controls.Add(this.labelTriggerSens, 0, 3);
			this.tableTrigger.Controls.Add(this.labelTriggerLevel, 0, 2);
			this.tableTrigger.Controls.Add(this.labelTriggerKind, 0, 1);
			this.tableTrigger.Controls.Add(this.labelTriggerMode, 0, 0);
			this.tableTrigger.Controls.Add(this.textTriggerLevel, 1, 2);
			this.tableTrigger.Controls.Add(this.textTriggerSens, 1, 3);
			this.tableTrigger.Controls.Add(this.textTriggerIndex, 1, 4);
			this.tableTrigger.Controls.Add(this.comboTriggerMode, 1, 0);
			this.tableTrigger.Controls.Add(this.comboTriggerKind, 1, 1);
			this.tableTrigger.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableTrigger.Location = new System.Drawing.Point(3, 16);
			this.tableTrigger.Name = "tableTrigger";
			this.tableTrigger.RowCount = 5;
			this.tableTrigger.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableTrigger.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableTrigger.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableTrigger.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableTrigger.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableTrigger.Size = new System.Drawing.Size(179, 132);
			this.tableTrigger.TabIndex = 0;
			// 
			// groupVertical
			// 
			this.groupVertical.Controls.Add(this.tableVertical);
			this.groupVertical.Location = new System.Drawing.Point(228, 6);
			this.groupVertical.Name = "groupVertical";
			this.groupVertical.Size = new System.Drawing.Size(185, 153);
			this.groupVertical.TabIndex = 2;
			this.groupVertical.TabStop = false;
			this.groupVertical.Text = "Vertical";
			// 
			// tableVertical
			// 
			this.tableVertical.AutoSize = true;
			this.tableVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableVertical.ColumnCount = 2;
			this.tableVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableVertical.Controls.Add(this.labelVoltDiv, 0, 0);
			this.tableVertical.Controls.Add(this.labelAtten, 0, 1);
			this.tableVertical.Controls.Add(this.labelVSens, 0, 2);
			this.tableVertical.Controls.Add(this.labelVMax, 0, 3);
			this.tableVertical.Controls.Add(this.labelRin, 0, 4);
			this.tableVertical.Controls.Add(this.textVoltDiv, 1, 0);
			this.tableVertical.Controls.Add(this.textAtten, 1, 1);
			this.tableVertical.Controls.Add(this.textVSens, 1, 2);
			this.tableVertical.Controls.Add(this.textRin, 1, 4);
			this.tableVertical.Controls.Add(this.textVMax, 1, 3);
			this.tableVertical.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableVertical.Location = new System.Drawing.Point(3, 16);
			this.tableVertical.Name = "tableVertical";
			this.tableVertical.RowCount = 5;
			this.tableVertical.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVertical.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVertical.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVertical.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVertical.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVertical.Size = new System.Drawing.Size(179, 130);
			this.tableVertical.TabIndex = 0;
			// 
			// groupHorizontal
			// 
			this.groupHorizontal.Controls.Add(this.tableHorizontal);
			this.groupHorizontal.Location = new System.Drawing.Point(8, 6);
			this.groupHorizontal.Name = "groupHorizontal";
			this.groupHorizontal.Size = new System.Drawing.Size(214, 230);
			this.groupHorizontal.TabIndex = 0;
			this.groupHorizontal.TabStop = false;
			this.groupHorizontal.Text = "Horizontal";
			// 
			// tableHorizontal
			// 
			this.tableHorizontal.AutoSize = true;
			this.tableHorizontal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableHorizontal.ColumnCount = 2;
			this.tableHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableHorizontal.Controls.Add(this.textSecDiv, 1, 0);
			this.tableHorizontal.Controls.Add(this.textSampDiv, 1, 1);
			this.tableHorizontal.Controls.Add(this.textSecSamp, 1, 3);
			this.tableHorizontal.Controls.Add(this.textSampSec, 1, 2);
			this.tableHorizontal.Controls.Add(this.textSecTot, 1, 4);
			this.tableHorizontal.Controls.Add(this.labelSecDiv, 0, 0);
			this.tableHorizontal.Controls.Add(this.labelSampDiv, 0, 1);
			this.tableHorizontal.Controls.Add(this.labelSampSec, 0, 2);
			this.tableHorizontal.Controls.Add(this.labelSecSamp, 0, 3);
			this.tableHorizontal.Controls.Add(this.labelSecTot, 0, 4);
			this.tableHorizontal.Controls.Add(this.labelSampTot, 0, 5);
			this.tableHorizontal.Controls.Add(this.comboFastMode, 1, 7);
			this.tableHorizontal.Controls.Add(this.labelDivTot, 0, 6);
			this.tableHorizontal.Controls.Add(this.labelFastMode, 0, 7);
			this.tableHorizontal.Controls.Add(this.textSampTot, 1, 5);
			this.tableHorizontal.Controls.Add(this.textDivTot, 1, 6);
			this.tableHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableHorizontal.Location = new System.Drawing.Point(3, 16);
			this.tableHorizontal.Name = "tableHorizontal";
			this.tableHorizontal.RowCount = 8;
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableHorizontal.Size = new System.Drawing.Size(208, 209);
			this.tableHorizontal.TabIndex = 0;
			// 
			// tabPageTimeData
			// 
			this.tabPageTimeData.Controls.Add(this.dataGridTime);
			this.tabPageTimeData.Location = new System.Drawing.Point(4, 22);
			this.tabPageTimeData.Name = "tabPageTimeData";
			this.tabPageTimeData.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTimeData.Size = new System.Drawing.Size(422, 326);
			this.tabPageTimeData.TabIndex = 1;
			this.tabPageTimeData.Text = "Time data";
			this.tabPageTimeData.ToolTipText = "The list of waveform points.";
			this.tabPageTimeData.UseVisualStyleBackColor = true;
			// 
			// dataGridTime
			// 
			this.dataGridTime.AllowUserToAddRows = false;
			this.dataGridTime.AllowUserToDeleteRows = false;
			this.dataGridTime.AllowUserToOrderColumns = true;
			this.dataGridTime.AutoGenerateColumns = false;
			this.dataGridTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seqDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn});
			this.dataGridTime.DataMember = "Point";
			this.dataGridTime.DataSource = this.bindSrcWaveform;
			this.dataGridTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridTime.Location = new System.Drawing.Point(3, 3);
			this.dataGridTime.Name = "dataGridTime";
			this.dataGridTime.ReadOnly = true;
			this.dataGridTime.Size = new System.Drawing.Size(416, 320);
			this.dataGridTime.TabIndex = 0;
			// 
			// seqDataGridViewTextBoxColumn
			// 
			this.seqDataGridViewTextBoxColumn.DataPropertyName = "seq";
			this.seqDataGridViewTextBoxColumn.HeaderText = "Index";
			this.seqDataGridViewTextBoxColumn.Name = "seqDataGridViewTextBoxColumn";
			this.seqDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// voltageDataGridViewTextBoxColumn
			// 
			this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
			this.voltageDataGridViewTextBoxColumn.HeaderText = "Voltage";
			this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
			this.voltageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tabPageVoltageGraphs
			// 
			this.tabPageVoltageGraphs.Controls.Add(this.tableVoltTime);
			this.tabPageVoltageGraphs.Location = new System.Drawing.Point(4, 22);
			this.tabPageVoltageGraphs.Margin = new System.Windows.Forms.Padding(0);
			this.tabPageVoltageGraphs.Name = "tabPageVoltageGraphs";
			this.tabPageVoltageGraphs.Size = new System.Drawing.Size(422, 326);
			this.tabPageVoltageGraphs.TabIndex = 2;
			this.tabPageVoltageGraphs.Text = "Voltage graphs";
			this.tabPageVoltageGraphs.ToolTipText = "The graphical waveform display.";
			this.tabPageVoltageGraphs.UseVisualStyleBackColor = true;
			// 
			// vScrollPanVolt
			// 
			this.vScrollPanVolt.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollPanVolt.Location = new System.Drawing.Point(404, 1);
			this.vScrollPanVolt.Maximum = 99999999;
			this.vScrollPanVolt.Name = "vScrollPanVolt";
			this.tableVoltTime.SetRowSpan(this.vScrollPanVolt, 3);
			this.vScrollPanVolt.Size = new System.Drawing.Size(17, 324);
			this.vScrollPanVolt.TabIndex = 3;
			this.toolTip.SetToolTip(this.vScrollPanVolt, "Vertical pan");
			// 
			// vScrollZoomVolt
			// 
			this.vScrollZoomVolt.Dock = System.Windows.Forms.DockStyle.Left;
			this.vScrollZoomVolt.LargeChange = 10000000;
			this.vScrollZoomVolt.Location = new System.Drawing.Point(1, 1);
			this.vScrollZoomVolt.Maximum = 99999999;
			this.vScrollZoomVolt.Name = "vScrollZoomVolt";
			this.tableVoltTime.SetRowSpan(this.vScrollZoomVolt, 3);
			this.vScrollZoomVolt.Size = new System.Drawing.Size(17, 324);
			this.vScrollZoomVolt.SmallChange = 1000000;
			this.vScrollZoomVolt.TabIndex = 2;
			this.vScrollZoomVolt.TabStop = true;
			this.toolTip.SetToolTip(this.vScrollZoomVolt, "Vertical zoom");
			this.vScrollZoomVolt.Value = 90000000;
			// 
			// tableVoltTime
			// 
			this.tableVoltTime.AutoSize = true;
			this.tableVoltTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableVoltTime.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableVoltTime.ColumnCount = 3;
			this.tableVoltTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableVoltTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableVoltTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableVoltTime.Controls.Add(this.hScrollPanVoltTime, 1, 2);
			this.tableVoltTime.Controls.Add(this.vScrollPanVolt, 2, 0);
			this.tableVoltTime.Controls.Add(this.vScrollZoomVolt, 0, 0);
			this.tableVoltTime.Controls.Add(this.hScrollZoomVoltTime, 1, 0);
			this.tableVoltTime.Controls.Add(this.panelVoltTime, 1, 1);
			this.tableVoltTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableVoltTime.Location = new System.Drawing.Point(0, 0);
			this.tableVoltTime.Margin = new System.Windows.Forms.Padding(0);
			this.tableVoltTime.Name = "tableVoltTime";
			this.tableVoltTime.RowCount = 3;
			this.tableVoltTime.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVoltTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableVoltTime.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVoltTime.Size = new System.Drawing.Size(422, 326);
			this.tableVoltTime.TabIndex = 1;
			// 
			// hScrollPanVoltTime
			// 
			this.hScrollPanVoltTime.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.hScrollPanVoltTime.Location = new System.Drawing.Point(19, 308);
			this.hScrollPanVoltTime.Maximum = 99999999;
			this.hScrollPanVoltTime.Name = "hScrollPanVoltTime";
			this.hScrollPanVoltTime.Size = new System.Drawing.Size(384, 17);
			this.hScrollPanVoltTime.TabIndex = 1;
			this.toolTip.SetToolTip(this.hScrollPanVoltTime, "Horizontal pan");
			// 
			// hScrollZoomVoltTime
			// 
			this.hScrollZoomVoltTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.hScrollZoomVoltTime.LargeChange = 10000000;
			this.hScrollZoomVoltTime.Location = new System.Drawing.Point(19, 1);
			this.hScrollZoomVoltTime.Maximum = 99999999;
			this.hScrollZoomVoltTime.Name = "hScrollZoomVoltTime";
			this.hScrollZoomVoltTime.Size = new System.Drawing.Size(384, 17);
			this.hScrollZoomVoltTime.SmallChange = 1000000;
			this.hScrollZoomVoltTime.TabIndex = 0;
			this.hScrollZoomVoltTime.TabStop = true;
			this.toolTip.SetToolTip(this.hScrollZoomVoltTime, "Horizontal zoom");
			this.hScrollZoomVoltTime.Value = 90000000;
			// 
			// toolTip
			// 
			this.toolTip.ShowAlways = true;
			// 
			// labelFirmware
			// 
			this.labelFirmware.AutoSize = true;
			this.labelFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFirmware.Location = new System.Drawing.Point(3, 26);
			this.labelFirmware.Name = "labelFirmware";
			this.labelFirmware.Size = new System.Drawing.Size(49, 26);
			this.labelFirmware.TabIndex = 2;
			this.labelFirmware.Text = "Firmware";
			this.labelFirmware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelFileNo
			// 
			this.labelFileNo.AutoSize = true;
			this.labelFileNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFileNo.Location = new System.Drawing.Point(3, 0);
			this.labelFileNo.Name = "labelFileNo";
			this.labelFileNo.Size = new System.Drawing.Size(49, 26);
			this.labelFileNo.TabIndex = 0;
			this.labelFileNo.Text = "File no.";
			this.labelFileNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textFileNo
			// 
			this.textFileNo.BackColor = System.Drawing.SystemColors.Window;
			this.textFileNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "fileNumber", true));
			this.textFileNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textFileNo.Location = new System.Drawing.Point(58, 3);
			this.textFileNo.Name = "textFileNo";
			this.textFileNo.ReadOnly = true;
			this.textFileNo.Size = new System.Drawing.Size(147, 20);
			this.textFileNo.TabIndex = 1;
			this.toolTip.SetToolTip(this.textFileNo, "The original filename saved from the scope.");
			// 
			// textFirmware
			// 
			this.textFirmware.BackColor = System.Drawing.SystemColors.Window;
			this.textFirmware.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "firmware", true));
			this.textFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textFirmware.Location = new System.Drawing.Point(58, 29);
			this.textFirmware.Name = "textFirmware";
			this.textFirmware.ReadOnly = true;
			this.textFirmware.Size = new System.Drawing.Size(147, 20);
			this.textFirmware.TabIndex = 3;
			this.toolTip.SetToolTip(this.textFirmware, "The scope firmware version.");
			// 
			// labelTriggerIndex
			// 
			this.labelTriggerIndex.AutoSize = true;
			this.labelTriggerIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTriggerIndex.Location = new System.Drawing.Point(3, 106);
			this.labelTriggerIndex.Name = "labelTriggerIndex";
			this.labelTriggerIndex.Size = new System.Drawing.Size(34, 26);
			this.labelTriggerIndex.TabIndex = 8;
			this.labelTriggerIndex.Text = "Index";
			this.labelTriggerIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTriggerSens
			// 
			this.labelTriggerSens.AutoSize = true;
			this.labelTriggerSens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTriggerSens.Location = new System.Drawing.Point(3, 80);
			this.labelTriggerSens.Name = "labelTriggerSens";
			this.labelTriggerSens.Size = new System.Drawing.Size(34, 26);
			this.labelTriggerSens.TabIndex = 6;
			this.labelTriggerSens.Text = "Sens.";
			this.labelTriggerSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTriggerLevel
			// 
			this.labelTriggerLevel.AutoSize = true;
			this.labelTriggerLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTriggerLevel.Location = new System.Drawing.Point(3, 54);
			this.labelTriggerLevel.Name = "labelTriggerLevel";
			this.labelTriggerLevel.Size = new System.Drawing.Size(34, 26);
			this.labelTriggerLevel.TabIndex = 4;
			this.labelTriggerLevel.Text = "Level";
			this.labelTriggerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTriggerKind
			// 
			this.labelTriggerKind.AutoSize = true;
			this.labelTriggerKind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTriggerKind.Location = new System.Drawing.Point(3, 27);
			this.labelTriggerKind.Name = "labelTriggerKind";
			this.labelTriggerKind.Size = new System.Drawing.Size(34, 27);
			this.labelTriggerKind.TabIndex = 2;
			this.labelTriggerKind.Text = "Kind";
			this.labelTriggerKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTriggerMode
			// 
			this.labelTriggerMode.AutoSize = true;
			this.labelTriggerMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTriggerMode.Location = new System.Drawing.Point(3, 0);
			this.labelTriggerMode.Name = "labelTriggerMode";
			this.labelTriggerMode.Size = new System.Drawing.Size(34, 27);
			this.labelTriggerMode.TabIndex = 0;
			this.labelTriggerMode.Text = "Mode";
			this.labelTriggerMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textTriggerLevel
			// 
			this.textTriggerLevel.BackColor = System.Drawing.SystemColors.Window;
			this.textTriggerLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "triggerLevelSI", true));
			this.textTriggerLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textTriggerLevel.Location = new System.Drawing.Point(43, 57);
			this.textTriggerLevel.Name = "textTriggerLevel";
			this.textTriggerLevel.ReadOnly = true;
			this.textTriggerLevel.Size = new System.Drawing.Size(133, 20);
			this.textTriggerLevel.TabIndex = 5;
			this.toolTip.SetToolTip(this.textTriggerLevel, "The trigger level voltage.");
			// 
			// textTriggerSens
			// 
			this.textTriggerSens.BackColor = System.Drawing.SystemColors.Window;
			this.textTriggerSens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "triggerSensSI", true));
			this.textTriggerSens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textTriggerSens.Location = new System.Drawing.Point(43, 83);
			this.textTriggerSens.Name = "textTriggerSens";
			this.textTriggerSens.ReadOnly = true;
			this.textTriggerSens.Size = new System.Drawing.Size(133, 20);
			this.textTriggerSens.TabIndex = 7;
			this.toolTip.SetToolTip(this.textTriggerSens, "The voltage difference above and below the trigger level at which a trigger will " +
					"still occur.");
			// 
			// textTriggerIndex
			// 
			this.textTriggerIndex.BackColor = System.Drawing.SystemColors.Window;
			this.textTriggerIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "triggerIndex", true));
			this.textTriggerIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textTriggerIndex.Location = new System.Drawing.Point(43, 109);
			this.textTriggerIndex.Name = "textTriggerIndex";
			this.textTriggerIndex.ReadOnly = true;
			this.textTriggerIndex.Size = new System.Drawing.Size(133, 20);
			this.textTriggerIndex.TabIndex = 9;
			this.toolTip.SetToolTip(this.textTriggerIndex, "The sample index at which the trigger occurred.");
			// 
			// comboTriggerMode
			// 
			this.comboTriggerMode.CausesValidation = false;
			this.comboTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTriggerMode.FormattingEnabled = true;
			this.comboTriggerMode.Location = new System.Drawing.Point(43, 3);
			this.comboTriggerMode.Name = "comboTriggerMode";
			this.comboTriggerMode.Size = new System.Drawing.Size(133, 21);
			this.comboTriggerMode.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboTriggerMode, "The trigger mode.");
			// 
			// comboTriggerKind
			// 
			this.comboTriggerKind.CausesValidation = false;
			this.comboTriggerKind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboTriggerKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTriggerKind.FormattingEnabled = true;
			this.comboTriggerKind.Location = new System.Drawing.Point(43, 30);
			this.comboTriggerKind.Name = "comboTriggerKind";
			this.comboTriggerKind.Size = new System.Drawing.Size(133, 21);
			this.comboTriggerKind.TabIndex = 3;
			this.toolTip.SetToolTip(this.comboTriggerKind, "The trigger kind (rising or falling edge).");
			// 
			// labelVoltDiv
			// 
			this.labelVoltDiv.AutoSize = true;
			this.labelVoltDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVoltDiv.Location = new System.Drawing.Point(3, 0);
			this.labelVoltDiv.Name = "labelVoltDiv";
			this.labelVoltDiv.Size = new System.Drawing.Size(44, 26);
			this.labelVoltDiv.TabIndex = 0;
			this.labelVoltDiv.Text = "Volt/div";
			this.labelVoltDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAtten
			// 
			this.labelAtten.AutoSize = true;
			this.labelAtten.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAtten.Location = new System.Drawing.Point(3, 26);
			this.labelAtten.Name = "labelAtten";
			this.labelAtten.Size = new System.Drawing.Size(44, 26);
			this.labelAtten.TabIndex = 2;
			this.labelAtten.Text = "Atten.";
			this.labelAtten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVSens
			// 
			this.labelVSens.AutoSize = true;
			this.labelVSens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVSens.Location = new System.Drawing.Point(3, 52);
			this.labelVSens.Name = "labelVSens";
			this.labelVSens.Size = new System.Drawing.Size(44, 26);
			this.labelVSens.TabIndex = 4;
			this.labelVSens.Text = "Sens.";
			this.labelVSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMax
			// 
			this.labelVMax.AutoSize = true;
			this.labelVMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVMax.Location = new System.Drawing.Point(3, 78);
			this.labelVMax.Name = "labelVMax";
			this.labelVMax.Size = new System.Drawing.Size(44, 26);
			this.labelVMax.TabIndex = 6;
			this.labelVMax.Text = "Vmax";
			this.labelVMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelRin
			// 
			this.labelRin.AutoSize = true;
			this.labelRin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRin.Location = new System.Drawing.Point(3, 104);
			this.labelRin.Name = "labelRin";
			this.labelRin.Size = new System.Drawing.Size(44, 26);
			this.labelRin.TabIndex = 8;
			this.labelRin.Text = "R in";
			this.labelRin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textVoltDiv
			// 
			this.textVoltDiv.BackColor = System.Drawing.SystemColors.Window;
			this.textVoltDiv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "voltageDivSI", true));
			this.textVoltDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textVoltDiv.Location = new System.Drawing.Point(53, 3);
			this.textVoltDiv.Name = "textVoltDiv";
			this.textVoltDiv.ReadOnly = true;
			this.textVoltDiv.Size = new System.Drawing.Size(123, 20);
			this.textVoltDiv.TabIndex = 1;
			this.toolTip.SetToolTip(this.textVoltDiv, "The number of volts per division.");
			// 
			// textAtten
			// 
			this.textAtten.BackColor = System.Drawing.SystemColors.Window;
			this.textAtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "attenuationString", true));
			this.textAtten.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textAtten.Location = new System.Drawing.Point(53, 29);
			this.textAtten.Name = "textAtten";
			this.textAtten.ReadOnly = true;
			this.textAtten.Size = new System.Drawing.Size(123, 20);
			this.textAtten.TabIndex = 3;
			this.toolTip.SetToolTip(this.textAtten, "The probe attenuation.");
			// 
			// textVSens
			// 
			this.textVSens.BackColor = System.Drawing.SystemColors.Window;
			this.textVSens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "vsensSI", true));
			this.textVSens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textVSens.Location = new System.Drawing.Point(53, 55);
			this.textVSens.Name = "textVSens";
			this.textVSens.ReadOnly = true;
			this.textVSens.Size = new System.Drawing.Size(123, 20);
			this.textVSens.TabIndex = 5;
			this.toolTip.SetToolTip(this.textVSens, "The voltage sensitivity (vertical resolution).");
			// 
			// textRin
			// 
			this.textRin.BackColor = System.Drawing.SystemColors.Window;
			this.textRin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "rinSI", true));
			this.textRin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textRin.Location = new System.Drawing.Point(53, 107);
			this.textRin.Name = "textRin";
			this.textRin.ReadOnly = true;
			this.textRin.Size = new System.Drawing.Size(123, 20);
			this.textRin.TabIndex = 9;
			this.toolTip.SetToolTip(this.textRin, "The DC input resistance.");
			// 
			// textVMax
			// 
			this.textVMax.BackColor = System.Drawing.SystemColors.Window;
			this.textVMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "vdiffMaxSI", true));
			this.textVMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textVMax.Location = new System.Drawing.Point(53, 81);
			this.textVMax.Name = "textVMax";
			this.textVMax.ReadOnly = true;
			this.textVMax.Size = new System.Drawing.Size(123, 20);
			this.textVMax.TabIndex = 7;
			this.toolTip.SetToolTip(this.textVMax, "The maximum differential input voltage.");
			// 
			// textSecDiv
			// 
			this.textSecDiv.BackColor = System.Drawing.SystemColors.Window;
			this.textSecDiv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "timeDivSI", true));
			this.textSecDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSecDiv.Location = new System.Drawing.Point(65, 3);
			this.textSecDiv.Name = "textSecDiv";
			this.textSecDiv.ReadOnly = true;
			this.textSecDiv.Size = new System.Drawing.Size(140, 20);
			this.textSecDiv.TabIndex = 1;
			this.toolTip.SetToolTip(this.textSecDiv, "The number of seconds per division.");
			// 
			// textSampDiv
			// 
			this.textSampDiv.BackColor = System.Drawing.SystemColors.Window;
			this.textSampDiv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "samplesPerDiv", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "0.###"));
			this.textSampDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSampDiv.Location = new System.Drawing.Point(65, 29);
			this.textSampDiv.Name = "textSampDiv";
			this.textSampDiv.ReadOnly = true;
			this.textSampDiv.Size = new System.Drawing.Size(140, 20);
			this.textSampDiv.TabIndex = 3;
			this.toolTip.SetToolTip(this.textSampDiv, "The number of samples per division.");
			// 
			// textSecSamp
			// 
			this.textSecSamp.BackColor = System.Drawing.SystemColors.Window;
			this.textSecSamp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "hsens", true));
			this.textSecSamp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSecSamp.Location = new System.Drawing.Point(65, 81);
			this.textSecSamp.Name = "textSecSamp";
			this.textSecSamp.ReadOnly = true;
			this.textSecSamp.Size = new System.Drawing.Size(140, 20);
			this.textSecSamp.TabIndex = 7;
			this.toolTip.SetToolTip(this.textSecSamp, "The number of seconds per sample (resolution).");
			// 
			// textSampSec
			// 
			this.textSampSec.BackColor = System.Drawing.SystemColors.Window;
			this.textSampSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "samplingFreq", true));
			this.textSampSec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSampSec.Location = new System.Drawing.Point(65, 55);
			this.textSampSec.Name = "textSampSec";
			this.textSampSec.ReadOnly = true;
			this.textSampSec.Size = new System.Drawing.Size(140, 20);
			this.textSampSec.TabIndex = 5;
			this.toolTip.SetToolTip(this.textSampSec, "The number of samples per second (sampling frequency).");
			// 
			// textSecTot
			// 
			this.textSecTot.BackColor = System.Drawing.SystemColors.Window;
			this.textSecTot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "timeRangeSI", true));
			this.textSecTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSecTot.Location = new System.Drawing.Point(65, 107);
			this.textSecTot.Name = "textSecTot";
			this.textSecTot.ReadOnly = true;
			this.textSecTot.Size = new System.Drawing.Size(140, 20);
			this.textSecTot.TabIndex = 9;
			this.toolTip.SetToolTip(this.textSecTot, "The total time range.");
			// 
			// labelSecDiv
			// 
			this.labelSecDiv.AutoSize = true;
			this.labelSecDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSecDiv.Location = new System.Drawing.Point(3, 0);
			this.labelSecDiv.Name = "labelSecDiv";
			this.labelSecDiv.Size = new System.Drawing.Size(56, 26);
			this.labelSecDiv.TabIndex = 0;
			this.labelSecDiv.Text = "Sec/div";
			this.labelSecDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSampDiv
			// 
			this.labelSampDiv.AutoSize = true;
			this.labelSampDiv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSampDiv.Location = new System.Drawing.Point(3, 26);
			this.labelSampDiv.Name = "labelSampDiv";
			this.labelSampDiv.Size = new System.Drawing.Size(56, 26);
			this.labelSampDiv.TabIndex = 2;
			this.labelSampDiv.Text = "Samp/div";
			this.labelSampDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSampSec
			// 
			this.labelSampSec.AutoSize = true;
			this.labelSampSec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSampSec.Location = new System.Drawing.Point(3, 52);
			this.labelSampSec.Name = "labelSampSec";
			this.labelSampSec.Size = new System.Drawing.Size(56, 26);
			this.labelSampSec.TabIndex = 4;
			this.labelSampSec.Text = "Samp/sec";
			this.labelSampSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSecSamp
			// 
			this.labelSecSamp.AutoSize = true;
			this.labelSecSamp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSecSamp.Location = new System.Drawing.Point(3, 78);
			this.labelSecSamp.Name = "labelSecSamp";
			this.labelSecSamp.Size = new System.Drawing.Size(56, 26);
			this.labelSecSamp.TabIndex = 6;
			this.labelSecSamp.Text = "Sec/samp";
			this.labelSecSamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSecTot
			// 
			this.labelSecTot.AutoSize = true;
			this.labelSecTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSecTot.Location = new System.Drawing.Point(3, 104);
			this.labelSecTot.Name = "labelSecTot";
			this.labelSecTot.Size = new System.Drawing.Size(56, 26);
			this.labelSecTot.TabIndex = 8;
			this.labelSecTot.Text = "Sec tot.";
			this.labelSecTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSampTot
			// 
			this.labelSampTot.AutoSize = true;
			this.labelSampTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSampTot.Location = new System.Drawing.Point(3, 130);
			this.labelSampTot.Name = "labelSampTot";
			this.labelSampTot.Size = new System.Drawing.Size(56, 26);
			this.labelSampTot.TabIndex = 10;
			this.labelSampTot.Text = "Samp tot.";
			this.labelSampTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboFastMode
			// 
			this.comboFastMode.CausesValidation = false;
			this.comboFastMode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcProfile, "fastSamplingModeEnum", true));
			this.comboFastMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboFastMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFastMode.FormattingEnabled = true;
			this.comboFastMode.Location = new System.Drawing.Point(65, 185);
			this.comboFastMode.Name = "comboFastMode";
			this.comboFastMode.Size = new System.Drawing.Size(140, 21);
			this.comboFastMode.TabIndex = 15;
			this.toolTip.SetToolTip(this.comboFastMode, "Whether fast sampling mode is disabled, enabled, or forced disabled due to the ti" +
					"me scale.");
			// 
			// labelDivTot
			// 
			this.labelDivTot.AutoSize = true;
			this.labelDivTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDivTot.Location = new System.Drawing.Point(3, 156);
			this.labelDivTot.Name = "labelDivTot";
			this.labelDivTot.Size = new System.Drawing.Size(56, 26);
			this.labelDivTot.TabIndex = 12;
			this.labelDivTot.Text = "Div tot.";
			this.labelDivTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelFastMode
			// 
			this.labelFastMode.AutoSize = true;
			this.labelFastMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFastMode.Location = new System.Drawing.Point(3, 182);
			this.labelFastMode.Name = "labelFastMode";
			this.labelFastMode.Size = new System.Drawing.Size(56, 27);
			this.labelFastMode.TabIndex = 14;
			this.labelFastMode.Text = "Fast mode";
			this.labelFastMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textSampTot
			// 
			this.textSampTot.BackColor = System.Drawing.SystemColors.Window;
			this.textSampTot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "sampleCount", true));
			this.textSampTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textSampTot.Location = new System.Drawing.Point(65, 133);
			this.textSampTot.Name = "textSampTot";
			this.textSampTot.ReadOnly = true;
			this.textSampTot.Size = new System.Drawing.Size(140, 20);
			this.textSampTot.TabIndex = 11;
			this.toolTip.SetToolTip(this.textSampTot, "The total number of samples.");
			// 
			// textDivTot
			// 
			this.textDivTot.BackColor = System.Drawing.SystemColors.Window;
			this.textDivTot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProfile, "divRange", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "0.###"));
			this.textDivTot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textDivTot.Location = new System.Drawing.Point(65, 159);
			this.textDivTot.Name = "textDivTot";
			this.textDivTot.ReadOnly = true;
			this.textDivTot.Size = new System.Drawing.Size(140, 20);
			this.textDivTot.TabIndex = 13;
			this.toolTip.SetToolTip(this.textDivTot, "The total number of divisions covered by the waveform.");
			// 
			// panelVoltTime
			// 
			this.panelVoltTime.AutoSize = true;
			this.panelVoltTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelVoltTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelVoltTime.hScrollPan = this.hScrollPanVoltTime;
			this.panelVoltTime.hScrollZoom = this.hScrollZoomVoltTime;
			this.panelVoltTime.Location = new System.Drawing.Point(19, 19);
			this.panelVoltTime.Margin = new System.Windows.Forms.Padding(0);
			this.panelVoltTime.Name = "panelVoltTime";
			this.panelVoltTime.Series = null;
			this.panelVoltTime.Size = new System.Drawing.Size(384, 288);
			this.panelVoltTime.TabIndex = 4;
			this.panelVoltTime.vScrollPan = this.vScrollPanVolt;
			this.panelVoltTime.vScrollZoom = this.vScrollZoomVolt;
			// 
			// WaveformWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 352);
			this.Controls.Add(this.tabControl);
			this.Icon = global::BenfWaves.Client.Properties.Resources.utilities_system_monitor_icon;
			this.Name = "WaveformWindow";
			this.ShowInTaskbar = false;
			this.Text = "WaveformWindow";
			this.tabControl.ResumeLayout(false);
			this.tabPageProfile.ResumeLayout(false);
			this.groupMisc.ResumeLayout(false);
			this.groupMisc.PerformLayout();
			this.tableMisc.ResumeLayout(false);
			this.tableMisc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcWaveform)).EndInit();
			this.groupTrigger.ResumeLayout(false);
			this.groupTrigger.PerformLayout();
			this.tableTrigger.ResumeLayout(false);
			this.tableTrigger.PerformLayout();
			this.groupVertical.ResumeLayout(false);
			this.groupVertical.PerformLayout();
			this.tableVertical.ResumeLayout(false);
			this.tableVertical.PerformLayout();
			this.groupHorizontal.ResumeLayout(false);
			this.groupHorizontal.PerformLayout();
			this.tableHorizontal.ResumeLayout(false);
			this.tableHorizontal.PerformLayout();
			this.tabPageTimeData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridTime)).EndInit();
			this.tabPageVoltageGraphs.ResumeLayout(false);
			this.tabPageVoltageGraphs.PerformLayout();
			this.tableVoltTime.ResumeLayout(false);
			this.tableVoltTime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProfile;
		private System.Windows.Forms.TabPage tabPageTimeData;
		private System.Windows.Forms.TabPage tabPageVoltageGraphs;
		private System.Windows.Forms.GroupBox groupMisc;
		private System.Windows.Forms.GroupBox groupTrigger;
		private System.Windows.Forms.GroupBox groupVertical;
		private System.Windows.Forms.GroupBox groupHorizontal;
		private System.Windows.Forms.DataGridView dataGridTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn seqDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bindSrcWaveform;
		private System.Windows.Forms.BindingSource bindSrcProfile;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TableLayoutPanel tableHorizontal;
		private System.Windows.Forms.TableLayoutPanel tableMisc;
		private System.Windows.Forms.TableLayoutPanel tableTrigger;
		private System.Windows.Forms.TableLayoutPanel tableVertical;
		private System.Windows.Forms.TableLayoutPanel tableVoltTime;
		private System.Windows.Forms.HScrollBar hScrollPanVoltTime;
		private System.Windows.Forms.HScrollBar hScrollZoomVoltTime;
		private System.Windows.Forms.VScrollBar vScrollZoomVolt;
		private System.Windows.Forms.VScrollBar vScrollPanVolt;
		private TableLabel labelSecDiv;
		private TableLabel labelSampDiv;
		private TableLabel labelSampSec;
		private TableLabel labelSecSamp;
		private TableLabel labelSecTot;
		private TableLabel labelSampTot;
		private TableLabel labelDivTot;
		private TableLabel labelFastMode;
		private TableLabel labelFirmware;
		private TableLabel labelFileNo;
		private TableLabel labelTriggerIndex;
		private TableLabel labelTriggerSens;
		private TableLabel labelTriggerLevel;
		private TableLabel labelTriggerKind;
		private TableLabel labelTriggerMode;
		private TableLabel labelVoltDiv;
		private TableLabel labelAtten;
		private TableLabel labelVSens;
		private TableLabel labelVMax;
		private TableLabel labelRin;
		private ReadOnlyComboBox comboFastMode;
		private ReadOnlyComboBox comboTriggerMode;
		private ReadOnlyComboBox comboTriggerKind;
		private ReadOnlyTableTextbox textSecDiv;
		private ReadOnlyTableTextbox textSampDiv;
		private ReadOnlyTableTextbox textSecSamp;
		private ReadOnlyTableTextbox textSampSec;
		private ReadOnlyTableTextbox textSecTot;
		private ReadOnlyTableTextbox textSampTot;
		private ReadOnlyTableTextbox textFileNo;
		private ReadOnlyTableTextbox textFirmware;
		private ReadOnlyTableTextbox textDivTot;
		private ReadOnlyTableTextbox textTriggerLevel;
		private ReadOnlyTableTextbox textTriggerSens;
		private ReadOnlyTableTextbox textTriggerIndex;
		private ReadOnlyTableTextbox textVoltDiv;
		private ReadOnlyTableTextbox textAtten;
		private ReadOnlyTableTextbox textVSens;
		private ReadOnlyTableTextbox textRin;
		private ReadOnlyTableTextbox textVMax;
		private TriggeredWaveformPanel panelVoltTime;
	}
}