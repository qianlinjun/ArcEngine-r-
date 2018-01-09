namespace StuQuery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openMap = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.navigation = new System.Windows.Forms.ToolStripMenuItem();
            this.addStops = new System.Windows.Forms.ToolStripMenuItem();
            this.routeSolver = new System.Windows.Forms.ToolStripMenuItem();
            this.SpatialQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.AttributeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_AttributesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加柱状图 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加饼状图 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加雷达图 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加色带 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加图例 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_添加图廓 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放至图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.blank = new System.Windows.Forms.ToolStripStatusLabel();
            this.scaleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.MenuItem_添加标题 = new System.Windows.Forms.ToolStripMenuItem();
            this.数据分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.聚类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平行坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(558, 24);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMap,
            this.personalInfo,
            this.schoolInfor,
            this.navigation,
            this.SpatialQuery,
            this.AttributeQuery,
            this.ToolStrip_AttributesEdit,
            this.数据分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openMap
            // 
            this.openMap.Name = "openMap";
            this.openMap.Size = new System.Drawing.Size(44, 21);
            this.openMap.Text = "打开";
            this.openMap.Click += new System.EventHandler(this.openMap_Click);
            // 
            // personalInfo
            // 
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(68, 21);
            this.personalInfo.Text = "个人信息";
            this.personalInfo.Click += new System.EventHandler(this.personalInfo_Click);
            // 
            // schoolInfor
            // 
            this.schoolInfor.Name = "schoolInfor";
            this.schoolInfor.Size = new System.Drawing.Size(68, 21);
            this.schoolInfor.Text = "学校信息";
            this.schoolInfor.Click += new System.EventHandler(this.schoolInfor_Click);
            // 
            // navigation
            // 
            this.navigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStops,
            this.routeSolver});
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(68, 21);
            this.navigation.Text = "路径查询";
            // 
            // addStops
            // 
            this.addStops.Name = "addStops";
            this.addStops.Size = new System.Drawing.Size(124, 22);
            this.addStops.Text = "添加站点";
            this.addStops.Click += new System.EventHandler(this.addStops_Click);
            // 
            // routeSolver
            // 
            this.routeSolver.Name = "routeSolver";
            this.routeSolver.Size = new System.Drawing.Size(124, 22);
            this.routeSolver.Text = "开始查询";
            this.routeSolver.Click += new System.EventHandler(this.routeSolver_Click);
            // 
            // SpatialQuery
            // 
            this.SpatialQuery.Name = "SpatialQuery";
            this.SpatialQuery.Size = new System.Drawing.Size(68, 21);
            this.SpatialQuery.Text = "目标查询";
            this.SpatialQuery.Click += new System.EventHandler(this.SpatialQuery_Click);
            // 
            // AttributeQuery
            // 
            this.AttributeQuery.Name = "AttributeQuery";
            this.AttributeQuery.Size = new System.Drawing.Size(68, 21);
            this.AttributeQuery.Text = "属性查询";
            this.AttributeQuery.Click += new System.EventHandler(this.AttributeQuery_Click);
            // 
            // ToolStrip_AttributesEdit
            // 
            this.ToolStrip_AttributesEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_添加柱状图,
            this.MenuItem_添加饼状图,
            this.MenuItem_添加雷达图,
            this.MenuItem_添加色带,
            this.MenuItem_添加图例,
            this.MenuItem_添加图廓,
            this.MenuItem_添加标题});
            this.ToolStrip_AttributesEdit.Name = "ToolStrip_AttributesEdit";
            this.ToolStrip_AttributesEdit.ShowShortcutKeys = false;
            this.ToolStrip_AttributesEdit.Size = new System.Drawing.Size(68, 21);
            this.ToolStrip_AttributesEdit.Text = "属性编辑";
            // 
            // MenuItem_添加柱状图
            // 
            this.MenuItem_添加柱状图.Name = "MenuItem_添加柱状图";
            this.MenuItem_添加柱状图.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加柱状图.Text = "添加柱状图";
            this.MenuItem_添加柱状图.Click += new System.EventHandler(this.MenuItem_添加柱状图_Click);
            // 
            // MenuItem_添加饼状图
            // 
            this.MenuItem_添加饼状图.Name = "MenuItem_添加饼状图";
            this.MenuItem_添加饼状图.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加饼状图.Text = "添加饼状图";
            this.MenuItem_添加饼状图.Click += new System.EventHandler(this.MenuItem_添加饼状图_Click);
            // 
            // MenuItem_添加雷达图
            // 
            this.MenuItem_添加雷达图.Name = "MenuItem_添加雷达图";
            this.MenuItem_添加雷达图.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加雷达图.Text = "添加雷达图";
            this.MenuItem_添加雷达图.Click += new System.EventHandler(this.MenuItem_添加雷达图_Click);
            // 
            // MenuItem_添加色带
            // 
            this.MenuItem_添加色带.Name = "MenuItem_添加色带";
            this.MenuItem_添加色带.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加色带.Text = "添加色带";
            // 
            // MenuItem_添加图例
            // 
            this.MenuItem_添加图例.Name = "MenuItem_添加图例";
            this.MenuItem_添加图例.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加图例.Text = "添加图例";
            // 
            // MenuItem_添加图廓
            // 
            this.MenuItem_添加图廓.Name = "MenuItem_添加图廓";
            this.MenuItem_添加图廓.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加图廓.Text = "添加图廓";
            this.MenuItem_添加图廓.Click += new System.EventHandler(this.MenuItem_添加图廓_Click_1);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开属性表ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.缩放至图层ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip2";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 70);
            // 
            // 打开属性表ToolStripMenuItem
            // 
            this.打开属性表ToolStripMenuItem.Name = "打开属性表ToolStripMenuItem";
            this.打开属性表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开属性表ToolStripMenuItem.Text = "打开属性表";
            this.打开属性表ToolStripMenuItem.Click += new System.EventHandler(this.打开属性表ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 缩放至图层ToolStripMenuItem
            // 
            this.缩放至图层ToolStripMenuItem.Name = "缩放至图层ToolStripMenuItem";
            this.缩放至图层ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缩放至图层ToolStripMenuItem.Text = "缩放至图层";
            this.缩放至图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放至图层ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.blank,
            this.scaleLabel,
            this.coordinateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // blank
            // 
            this.blank.Name = "blank";
            this.blank.Size = new System.Drawing.Size(0, 17);
            // 
            // scaleLabel
            // 
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(37, 17);
            this.scaleLabel.Text = "scale";
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(78, 17);
            this.coordinateLabel.Text = "coordianate";
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(12, 28);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(375, 28);
            this.axToolbarControl1.TabIndex = 4;
            this.axToolbarControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnMouseMoveEventHandler(this.axToolbarControl1_OnMouseMove);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(268, 51);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(778, 600);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axTOCControl1.Location = new System.Drawing.Point(12, 70);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(250, 600);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // MenuItem_添加标题
            // 
            this.MenuItem_添加标题.Name = "MenuItem_添加标题";
            this.MenuItem_添加标题.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_添加标题.Text = "添加标题";
            this.MenuItem_添加标题.Click += new System.EventHandler(this.MenuItem_添加标题_Click);
            // 
            // 数据分析ToolStripMenuItem
            // 
            this.数据分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.聚类ToolStripMenuItem,
            this.平行坐标ToolStripMenuItem});
            this.数据分析ToolStripMenuItem.Name = "数据分析ToolStripMenuItem";
            this.数据分析ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据分析ToolStripMenuItem.Text = "数据分析";
            // 
            // 聚类ToolStripMenuItem
            // 
            this.聚类ToolStripMenuItem.Name = "聚类ToolStripMenuItem";
            this.聚类ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.聚类ToolStripMenuItem.Text = "聚类";
            // 
            // 平行坐标ToolStripMenuItem
            // 
            this.平行坐标ToolStripMenuItem.Name = "平行坐标ToolStripMenuItem";
            this.平行坐标ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.平行坐标ToolStripMenuItem.Text = "平行坐标";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 676);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axTOCControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Welcome to Whu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openMap;
        private System.Windows.Forms.ToolStripMenuItem personalInfo;
        private System.Windows.Forms.ToolStripMenuItem schoolInfor;
        private System.Windows.Forms.ToolStripMenuItem navigation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 打开属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel blank;
        private System.Windows.Forms.ToolStripStatusLabel scaleLabel;
        private System.Windows.Forms.ToolStripStatusLabel coordinateLabel;
        private System.Windows.Forms.ToolStripMenuItem addStops;
        private System.Windows.Forms.ToolStripMenuItem routeSolver;
        private System.Windows.Forms.ToolStripMenuItem SpatialQuery;
        private System.Windows.Forms.ToolStripMenuItem AttributeQuery;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_AttributesEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加柱状图;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加雷达图;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加色带;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加图例;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加图廓;
        private System.Windows.Forms.ToolStripMenuItem 缩放至图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加饼状图;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_添加标题;
        private System.Windows.Forms.ToolStripMenuItem 数据分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 聚类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平行坐标ToolStripMenuItem;
    }
}

