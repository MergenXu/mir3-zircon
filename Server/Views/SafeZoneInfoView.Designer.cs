﻿namespace Server.Views
{
    partial class SafeZoneInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeZoneInfoView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SaveButton = new DevExpress.XtraBars.BarButtonItem();
            this.SafeZoneGridControl = new DevExpress.XtraGrid.GridControl();
            this.SafeZoneGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegionLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafeZoneGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafeZoneGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(788, 144);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "主页";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "保存";
            // 
            // SaveButton
            // 
            this.SaveButton.Caption = "保存";
            this.SaveButton.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveButton.Glyph")));
            this.SaveButton.Id = 1;
            this.SaveButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveButton.LargeGlyph")));
            this.SaveButton.LargeWidth = 60;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveButton_ItemClick);
            // 
            // SafeZoneGridControl
            // 
            this.SafeZoneGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SafeZoneGridControl.Location = new System.Drawing.Point(0, 144);
            this.SafeZoneGridControl.MainView = this.SafeZoneGridView;
            this.SafeZoneGridControl.MenuManager = this.ribbon;
            this.SafeZoneGridControl.Name = "SafeZoneGridControl";
            this.SafeZoneGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RegionLookUpEdit});
            this.SafeZoneGridControl.Size = new System.Drawing.Size(788, 415);
            this.SafeZoneGridControl.TabIndex = 2;
            this.SafeZoneGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SafeZoneGridView});
            // 
            // SafeZoneGridView
            // 
            this.SafeZoneGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.SafeZoneGridView.GridControl = this.SafeZoneGridControl;
            this.SafeZoneGridView.Name = "SafeZoneGridView";
            this.SafeZoneGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.SafeZoneGridView.OptionsView.EnableAppearanceOddRow = true;
            this.SafeZoneGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.SafeZoneGridView.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.SafeZoneGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.RegionLookUpEdit;
            this.gridColumn1.FieldName = "Region";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.ColumnEdit = this.RegionLookUpEdit;
            this.gridColumn2.FieldName = "BindRegion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "StartClass";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "RedZone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // RegionLookUpEdit
            // 
            this.RegionLookUpEdit.AutoHeight = false;
            this.RegionLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.RegionLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RegionLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Index", "Index"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServerDescription", "Server Description"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size", "Size")});
            this.RegionLookUpEdit.DisplayMember = "ServerDescription";
            this.RegionLookUpEdit.Name = "RegionLookUpEdit";
            this.RegionLookUpEdit.NullText = "[Region is null]";
            // 
            // SafeZoneInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 559);
            this.Controls.Add(this.SafeZoneGridControl);
            this.Controls.Add(this.ribbon);
            this.Name = "SafeZoneInfoView";
            this.Ribbon = this.ribbon;
            this.Text = "SafeZoneInfoView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafeZoneGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafeZoneGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem SaveButton;
        private DevExpress.XtraGrid.GridControl SafeZoneGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SafeZoneGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RegionLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}