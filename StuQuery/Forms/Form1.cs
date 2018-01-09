using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;

using ESRI.ArcGIS.NetworkAnalysis;
using ESRI.ArcGIS.NetworkAnalyst;
using ESRI.ArcGIS.DataSourcesGDB;
using StuQuery.Classse;

using System.Media;
using System.Reflection;
using stdole;

namespace StuQuery
{
    public partial class Form1 : Form
    {
        private ILayer pLayer;
        private string pMapUnits;

        public Form1()
        {
            InitializeComponent();
            if (axMapControl1.LayerCount > 0)
            {
               // axMapControl2.Map = new MapClass();
                for (int i = 0; i <= axMapControl1.Map.LayerCount - 1; i++)
                {
                 //   axMapControl2.AddLayer(axMapControl1.get_Layer(i));
                }
                //axMapControl2.Extent = axMapControl1.Extent;
                // axMapControl2.Refresh();
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMapUnits = "Unknown";
            //axMapControl2.SetBuddyControl(axMapControl1);
            //this.axMapControl2.MapScale = 20000;
            //CreateBindSource();
        }


        //打开地图
        private void openMap_Click(object sender, EventArgs e)
        {
             OpenFileDialog OpenMXD = new OpenFileDialog(); //可实例化类
            // Gets or sets the file dialog box title. (Inherited from FileDialog.)
            OpenMXD.Title = "打开地图"; // OpenFileDialog类的属性Title
            // Gets or sets the initial directory displayed by the file dialog box. 
            OpenMXD.InitialDirectory = "C:"; 
            // Gets or sets the current file name filter string ,Save as file type
            OpenMXD.Filter ="Map Documents (*.mxd)|*.mxd"; 
            if (OpenMXD.ShowDialog() == DialogResult.OK) //ShowDialog是类的方法
            { 
            //FileName:Gets or sets a string containing the file name selected in the file dialog box
            string MxdPath = OpenMXD.FileName; 
            axMapControl1.LoadMxFile(MxdPath); //IMapControl2的方法
            } 
        }

        //地图1放大缩小关联鹰眼
        //private void axMapControl1_OnExtentUpdated(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnExtentUpdatedEvent e)
        //{
        //    // 得到新范围
        //    IEnvelope pEnvelope = (IEnvelope)e.newEnvelope;
        //    //IGraphicsContainer pGraphicsContainer = axMapControl2.Map as IGraphicsContainer;
        //    IActiveView pActiveView = pGraphicsContainer as IActiveView;
        //    //在绘制前，清除axMapControl2中的任何图形元素
        //    pGraphicsContainer.DeleteAllElements();
        //    IRectangleElement pRectangleEle = new RectangleElementClass();
        //    IElement pElement = pRectangleEle as IElement;
        //    pElement.Geometry = pEnvelope;
        //    //设置鹰眼图中的红线框
        //    IRgbColor pColor = new RgbColorClass();
        //    pColor.Red = 255; pColor.Green = 0; pColor.Blue = 0; pColor.Transparency = 255;
        //    //产生一个线符号对象
        //    ILineSymbol pOutline = new SimpleLineSymbolClass();
        //    pOutline.Width = 3; pOutline.Color = pColor;
        //    //设置颜色属性
        //    pColor = new RgbColorClass();
        //    pColor.Red = 255; pColor.Green = 0; pColor.Blue = 0; pColor.Transparency = 0;
        //    //设置填充符号的属性
        //    IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
        //    pFillSymbol.Color = pColor; pFillSymbol.Outline = pOutline;
        //    IFillShapeElement pFillShapeEle = pElement as IFillShapeElement;
        //    pFillShapeEle.Symbol = pFillSymbol;
        //   // pGraphicsContainer.AddElement((IElement)pFillShapeEle, 0);
        //    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);//部分刷新

        //}

        //地图1改变
        private void axMapControl1_OnMapReplaced(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMapReplacedEvent e)
        {
            if (axMapControl1.LayerCount > 0)
            {
               // axMapControl2.Map = new MapClass();
                for (int i = 0; i <= axMapControl1.Map.LayerCount - 1; i++)
                {
                //    axMapControl2.AddLayer(axMapControl1.get_Layer(i));
                }
               // axMapControl2.Extent = axMapControl1.Extent;
               // axMapControl2.Refresh();
            }
            esriUnits mapUnits = axMapControl1.MapUnits;
            switch (mapUnits)
            {
                case esriUnits.esriCentimeters:
                    pMapUnits = "Centimeters";
                    break;
                case esriUnits.esriDecimalDegrees:
                    pMapUnits = "Decimal Degrees";
                    break;
                case esriUnits.esriDecimeters:
                    pMapUnits = "Decimeters";
                    break;
                case esriUnits.esriFeet:
                    pMapUnits = "Feet";
                    break;
                case esriUnits.esriInches:
                    pMapUnits = "Inches";
                    break;
                case esriUnits.esriKilometers:
                    pMapUnits = "Kilometers";
                    break;
                case esriUnits.esriMeters:
                    pMapUnits = "Meters";
                    break;
                case esriUnits.esriMiles:
                    pMapUnits = "Miles";
                    break;
                case esriUnits.esriMillimeters:
                    pMapUnits = "Millimeters";
                    break;
                case esriUnits.esriNauticalMiles:
                    pMapUnits = "NauticalMiles";
                    break;
                case esriUnits.esriPoints:
                    pMapUnits = "Points";
                    break;
                case esriUnits.esriUnknownUnits:
                    pMapUnits = "Unknown";
                    break;
                case esriUnits.esriYards:
                    pMapUnits = "Yards";
                    break;
            }
        }

        //地图1鼠标移动
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            scaleLabel.Text = " 比例尺 1:" + ((long)this.axMapControl1.MapScale).ToString();
            coordinateLabel.Text = " 当前坐标 X = " + e.mapX.ToString() + " Y = " + e.mapY.ToString() + " " + pMapUnits.ToString();

        }
        

        ////鹰眼地图点击事件
        //private void axMapControl2_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        //{
        //    if (axMapControl2.Map.LayerCount > 0)
        //    {
        //        if (e.button == 1)
        //        {
        //            IPoint pPoint = new PointClass();
        //            pPoint.PutCoords(e.mapX, e.mapY);
        //            axMapControl1.CenterAt(pPoint);
        //            axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        //        }
        //        else if (e.button == 2)
        //        {
        //            IEnvelope pEnv = axMapControl2.TrackRectangle();
        //            axMapControl1.Extent = pEnv;
        //            axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        //        }
        //    }

        //}
        
        //鹰眼地图鼠标移动事件
        private void axMapControl2_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 1)
            {
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                axMapControl1.CenterAt(pPoint);
                axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
            }

        }

        //目录树点击事件
        private void axTOCControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {
            if (axMapControl1.LayerCount > 0)
            {
                esriTOCControlItem pItem = new esriTOCControlItem();
                pLayer = new FeatureLayerClass();
                IBasicMap pBasicMap = new MapClass();
                object pOther = new object();
                object pIndex = new object();
                // Returns the item in the TOCControl at the specified coordinates.
                axTOCControl1.HitTest(e.x, e.y, ref pItem, ref pBasicMap, ref pLayer, ref pOther, ref pIndex);
            }//TOCControl类的ITOCControl接口的HitTest方法
            if (e.button == 2)
            {
                contextMenuStrip.Show(axTOCControl1, e.x, e.y);
            }

        }

        //目录栏右击事件
        private void 打开属性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //传入图层，在右击事件里返回的图层
            FrmAttribute frm1 = new FrmAttribute(pLayer as IFeatureLayer);
            frm1.Show();

        }
        private void 缩放至图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ILayer layer = axMapControl1.get_Layer(0);
            IEnvelope envelope = layer.AreaOfInterest;
            axMapControl1.ActiveView.Extent = envelope;
            axMapControl1.Refresh();
        }

        //工具栏移动
        private void axToolbarControl1_OnMouseMove(object sender, IToolbarControlEvents_OnMouseMoveEvent e)
        {
            // 取得鼠标所在工具的索引号  
            int index = axToolbarControl1.HitTest(e.x, e.y, false);
            if (index != -1)
            {
                // 取得鼠标所在工具的 ToolbarItem  
                IToolbarItem toolbarItem = axToolbarControl1.GetItem(index);
                // 设置状态栏信息  
                StatusLabel.Text = toolbarItem.Command.Message;
            }
            else
            {
                StatusLabel.Text = " 就绪 ";
            } 

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _720degree f = new _720degree();
            f.ShowDialog();
        }



        /*--------------------------------------------基本功能--------------------------------------------*/
        //个人信息查询
        private void personalInfo_Click(object sender, EventArgs e)
        {
            PersonalInfor f = new PersonalInfor();
            f.ShowDialog();
        }

        //学校信息查询
        private void schoolInfor_Click(object sender, EventArgs e)
        {
            SchoolInfor f = new SchoolInfor();
            f.ShowDialog();
        }


        //中心放大
        private void menuFixedZoomIn_Click(object sender, EventArgs e)
        {
            //声明与初始化 
            FixedZoomIn fixedZoomin = new FixedZoomIn();
            //与MapControl关联 
            fixedZoomin.OnCreate(this.axMapControl1.Object); 
            fixedZoomin.OnClick();
        }

        //中心缩小
        private void menuFixedZoomOut_Click(object sender, EventArgs e)
        {
            ICommand command = new ControlsMapZoomOutFixedCommandClass();
            command.OnCreate(this.axMapControl1.Object);
            command.OnClick();
        }

        //加载站点
        private void addStops_Click(object sender, EventArgs e)
        {
            ICommand pCommand;
            pCommand = new AddNetStopsTool();
            pCommand.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = pCommand as ITool;
            pCommand = null;
        }

        //最短路径分析
        private void routeSolver_Click(object sender, EventArgs e)
        {
            ICommand pCommand;
            pCommand = new ShortPathSolveCommand();
            pCommand.OnCreate(axMapControl1.Object);
            pCommand.OnClick();
            pCommand = null;
        }

        //空间查询
        private void SpatialQuery_Click(object sender, EventArgs e)
        {
            ICommand pCommand = null;
            pCommand = new ControlsMapIdentifyToolClass();
            pCommand.OnCreate(axMapControl1.Object);
            axMapControl1.CurrentTool = (ITool)pCommand;
            ////初始化空间查询窗体  
            //SpatialQueryForm pspatialQueryForm = new SpatialQueryForm(axMapControl1);
            //if (pspatialQueryForm.ShowDialog() == DialogResult.OK)
            //{
            //    this.mTool = "SpatialQuery";
            //    //获取查询方式和图层信息  
            //    this.mQueryModel = pspatialQueryForm.mQueryModel;
            //    this.mLayerIndex = pspatialQueryForm.mLayerIndex;
            //    //设置鼠标形状  
            //    this.axMapControl1.MousePointer = ESRI.ArcGIS.Controls.esriControlsMousePointer.esriPointerCrosshair;
            //}  
        }

        //属性查询
        private DataTable LoadQueryResult(ESRI.ArcGIS.Controls.AxMapControl mapControl, ESRI.ArcGIS.Carto.IFeatureLayer featureLayer, ESRI.ArcGIS.Geometry.IGeometry geometry)
        {
            ESRI.ArcGIS.Geodatabase.IFeatureClass pFeatureClass = featureLayer.FeatureClass;
            //根据图层属性字段初始化DataTable  
            ESRI.ArcGIS.Geodatabase.IFields pFields = pFeatureClass.Fields;
            DataTable pDataTable = new DataTable();
            for (int i = 0; i < pFields.FieldCount; ++i)
            {
                pDataTable.Columns.Add(pFields.get_Field(i).AliasName);
            }
            //空间过滤器  
            ESRI.ArcGIS.Geodatabase.ISpatialFilter pSpatialFilter = new ESRI.ArcGIS.Geodatabase.SpatialFilterClass();
            pSpatialFilter.Geometry = geometry;
            //根据图层类型选择缓冲方式  
            switch (pFeatureClass.ShapeType)
            {
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryMultipoint:
                    pSpatialFilter.SpatialRel = ESRI.ArcGIS.Geodatabase.esriSpatialRelEnum.esriSpatialRelContains;
                    break;
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolyline:
                    pSpatialFilter.SpatialRel = ESRI.ArcGIS.Geodatabase.esriSpatialRelEnum.esriSpatialRelCrosses;
                    break;
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolygon:
                    pSpatialFilter.SpatialRel = ESRI.ArcGIS.Geodatabase.esriSpatialRelEnum.esriSpatialRelIntersects;
                    break;
            }
            //定义空间过滤器的空间字段  
            pSpatialFilter.GeometryField = pFeatureClass.ShapeFieldName;
            ESRI.ArcGIS.Geodatabase.IQueryFilter pQueryFilter;
            ESRI.ArcGIS.Geodatabase.IFeatureCursor pFeatureCursor;
            ESRI.ArcGIS.Geodatabase.IFeature pFeature;
            //利用要素过滤器查询要素  
            pQueryFilter = pSpatialFilter as ESRI.ArcGIS.Geodatabase.IQueryFilter;
            pFeatureCursor = featureLayer.Search(pQueryFilter, true);
            pFeature = pFeatureCursor.NextFeature();
            while (pFeature != null)
            {
                string strFldValue = null;
                DataRow dr = pDataTable.NewRow();
                //遍历图层属性表字段值，并加入pDataTable  
                for (int i = 0; i < pFields.FieldCount; i++)
                {
                    string strFldName = pFields.get_Field(i).Name;
                    if (strFldName == "Shape")
                    {
                        strFldValue = Convert.ToString(pFeature.Shape.GeometryType);
                    }
                    else
                        strFldValue = Convert.ToString(pFeature.get_Value(i));
                    dr[i] = strFldValue;
                }
                pDataTable.Rows.Add(dr);
                //高亮选择要素  
                mapControl.Map.SelectFeature((ESRI.ArcGIS.Carto.ILayer)featureLayer, pFeature);
                mapControl.ActiveView.Refresh();
                pFeature = pFeatureCursor.NextFeature();
            }

            return pDataTable;

        }

        //属性查询
        private void AttributeQuery_Click(object sender, EventArgs e)
        {
            StuQuery.Forms.AttributeQueryForm frmattributequery = new StuQuery.Forms.AttributeQueryForm(this.axMapControl1);
            frmattributequery.Show(); 
        }




        /*--------------------------------------------编辑制图--------------------------------------------*/
        private void MenuItem_添加柱状图_Click(object sender, EventArgs e)
        {
            List<string> renderFields = new List<string>();
            renderFields.Add("area_草地");
            renderFields.Add("园地");
            renderFields.Add("城镇及工矿");
            renderFields.Add("耕地");
            renderFields.Add("林地");
            renderFields.Add("其他用地");
            renderFields.Add("水域及水利");
            //对应颜色
            List<IColor> renderColor = new List<IColor>();
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));
            renderColor.Add(getRGB(1, 2, 3));

            IColor BgColor = getRGB();//背景颜色使用默认颜色（我的是255，）
            createBarChart("XZQ_C", renderFields, renderColor, BgColor);
        }

        private void MenuItem_添加饼状图_Click(object sender, EventArgs e)
        {
            List<string> renderFields = new List<string>();
            renderFields.Add("area_草地");
            renderFields.Add("园地");
            renderFields.Add("城镇及工矿");
            renderFields.Add("耕地");
            renderFields.Add("林地");
            renderFields.Add("其他用地");
            renderFields.Add("水域及水利");
            //对应颜色
            List<IColor> renderColor = new List<IColor>();
            renderColor.Add(getRGB(160, 200, 80));
            renderColor.Add(getRGB(0, 165, 60));
            renderColor.Add(getRGB(235, 150, 180));
            renderColor.Add(getRGB(255, 255, 150));
            renderColor.Add(getRGB(85, 180, 100));
            renderColor.Add(getRGB(235, 130, 130));
            renderColor.Add(getRGB(225, 255, 255));

            IColor BgColor = getRGB();//背景颜色使用默认颜色（我的是255，）
            createPieChart("XZQ_C", renderFields, renderColor, BgColor);
        }

        private void MenuItem_添加雷达图_Click(object sender, EventArgs e)
        {

        }
        //未画出
        private void MenuItem_添加图廓_Click_1(object sender, EventArgs e)
        {
            //创建线元素  
            IElement lineElement = new LineElementClass();

            IEnvelope pEnvelope = null;
            pEnvelope = axMapControl1.FullExtent;
            if (pEnvelope == null)
                return;

            //用地图外部范围创建图廓
            IPolyline pl = new PolylineClass();
            IPointCollection pPointCollection = pl as IPointCollection;
            object missing = Type.Missing;

            IPoint pt1 = pEnvelope.UpperLeft as IPoint;
            IPoint pt2 = pEnvelope.LowerLeft as IPoint;
            IPoint pt3 = pEnvelope.LowerRight as IPoint;
            IPoint pt4 = pEnvelope.UpperRight as IPoint;
            pPointCollection.AddPoint(pt1, ref missing, ref missing);
            pPointCollection.AddPoint(pt2, ref missing, ref missing);
            pPointCollection.AddPoint(pt3, ref missing, ref missing);
            pPointCollection.AddPoint(pt4, ref missing, ref missing);
            IPolyline pPolyline = (IPolyline)pPointCollection;
            lineElement.Geometry = pPolyline;

            ////从符号库中获取图框的符号  
            //ISymbol pLineSymbol = SymbolFactory.CreateObject().GetSymbolfromSytleFile(@"C:\Users\admin\Desktop\workspace\data\符号库\fh.style", "Line Symbols", "图框");
            //(neatlineElement as ILineElement).Symbol = pLineSymbol as ILineSymbol;
            //手动设置线状符号
            ISimpleLineSymbol pLineSymbol = new SimpleLineSymbolClass();  //设置Symbol属性
            pLineSymbol.Color = getRGB(250, 0, 0);
            pLineSymbol.Width = 10;
            (lineElement as ILineElement).Symbol = pLineSymbol as ILineSymbol;

            //将线元素添加到地图中  
            IGraphicsContainer container = axMapControl1.Map as IGraphicsContainer;
            container.AddElement(lineElement, 0);

            //Console.WriteLine("here");

            //刷新地图  
            IActiveView activeView = axMapControl1.Map as IActiveView;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
            //pActiveView.Refresh();
        }

        private void MenuItem_添加标题_Click(object sender, EventArgs e)
        {
            //AddTitle(axMapControl1.get_Layer(0), "专题图");
        }
        


        //根据名称获得图层
        private IGeoFeatureLayer getGeoLayer(string layerName)
        {
            ILayer layer;
            IGeoFeatureLayer geoFeatureLayer;
            for (int i = 0; i < axMapControl1.LayerCount; i++)
            {
                layer = axMapControl1.get_Layer(i);
                if (layer != null && layer.Name == layerName)
                {
                    geoFeatureLayer = layer as IGeoFeatureLayer;
                    return geoFeatureLayer;
                }
            }
            return null;
        }

        //获取RGB颜色 @默认为地图底色
        static public IColor getRGB(int r = 245, int g = 235, int b= 186)
        {
            IRgbColor pColor = new RgbColorClass();

            pColor.Red = r;
            pColor.Green = g;
            pColor.Blue = b;
            return pColor as IColor;
        }



        //分级设色
        static public IGeoFeatureLayer GetLevelMap(IGeoFeatureLayer geoFeatureLayer, string field, int classCount)
        {

            ITableHistogram tableHistogram;
            IBasicHistogram basicHistogram;
            ITable table;

            ILayer layer = geoFeatureLayer as ILayer;//类型转换
            table = layer as ITable;//层转为表
            tableHistogram = new BasicTableHistogramClass();
            //按照 数值字段分级  
            tableHistogram.Table = table;
            tableHistogram.Field = field;
            basicHistogram = tableHistogram as IBasicHistogram;
            object values;
            object frequencys;

            //先统计每个值和各个值出现的次数  
            basicHistogram.GetHistogram(out values, out frequencys);
            //创建平均分级对象  
            IClassifyGEN classifyGEN = new QuantileClass();
            //用统计结果进行分级 ，级别数目为classCount  
            classifyGEN.Classify(values, frequencys, ref classCount);
            //获得分级结果,是个 双精度类型数组   
            double[] classes;
            classes = classifyGEN.ClassBreaks as double[];

            IEnumColors enumColors = CreateAlgorithmicColorRamp(classes.Length).Colors;
            IColor color;

            IClassBreaksRenderer classBreaksRenderer = new ClassBreaksRendererClass();
            classBreaksRenderer.Field = field;
            classBreaksRenderer.BreakCount = classCount;
            classBreaksRenderer.SortClassesAscending = true;

            ISimpleFillSymbol simpleFillSymbol;

            for (int i = 0; i < classes.Length - 1; i++)
            {
                color = enumColors.Next();
                simpleFillSymbol = new SimpleFillSymbolClass();
                simpleFillSymbol.Color = color;
                simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;
                classBreaksRenderer.set_Symbol(i, simpleFillSymbol as ISymbol);
                classBreaksRenderer.set_Break(i, classes[i + 1]);

                //构造显示的文字  
                classBreaksRenderer.set_Label(i, classes[i].ToString() + "——" + classes[i + 1].ToString());
                classBreaksRenderer.set_Description(i, "sfhskdfks");
                //着色对象的断点 
            }

            if (geoFeatureLayer != null)
            {
                geoFeatureLayer.Renderer = classBreaksRenderer as IFeatureRenderer;
            }
            return geoFeatureLayer;
        }

         /*
          * 添加饼状图
         * @layerName要图层名
         * @renderFields字段
         * @renderColor对应的填充颜色
         * @BgColor地图填充色
         */
        public void createPieChart(string layerName, List<string> renderFields, List<IColor> renderColor, IColor BgColor)
        {
            IGeoFeatureLayer geoFeatureLayer;
            IFeatureLayer featureLayer;
            ITable table;
            ICursor cursor;
            IRowBuffer rowBuffer;

            //获取渲染图层
            geoFeatureLayer = getGeoLayer(layerName);
            featureLayer = geoFeatureLayer as IFeatureLayer;
            table = featureLayer as ITable;
            geoFeatureLayer.ScaleSymbols = true;
            IChartRenderer chartRenderer = new ChartRendererClass();
            IPieChartRenderer pieChartRenderer = chartRenderer as IPieChartRenderer;
            IRendererFields rendererFields = chartRenderer as IRendererFields;
            for (int i = 0; i < renderFields.Count; i++)
            {
                rendererFields.AddField(renderFields[i], renderFields[i]);
            }
            //获取渲染要素的最大值
            double fieldValue = 0.0, maxValue = 0.0;
            cursor = table.Search(null, true);
            rowBuffer = cursor.NextRow();
            while (rowBuffer != null)
            {
                for (int i = 0; i < renderFields.Count; i++)
                {
                    int index = table.FindField(renderFields[i]);
                    fieldValue = double.Parse(rowBuffer.get_Value(index).ToString());
                    if (fieldValue > maxValue)
                    {
                        maxValue = fieldValue;
                    }
                }
                rowBuffer = cursor.NextRow();
            }
            //设置饼图符号
            IPieChartSymbol pieChartSymbol = new PieChartSymbolClass();
            pieChartSymbol.Clockwise = true;
            pieChartSymbol.UseOutline = true;
            IChartSymbol chartSymbol = pieChartSymbol as IChartSymbol;
            chartSymbol.MaxValue = maxValue;
            ILineSymbol lineSymbol = new SimpleLineSymbolClass();
            lineSymbol.Color = getRGB(255, 192, 203);//默认和背景一致
            lineSymbol.Width = 1.5;
            pieChartSymbol.Outline = lineSymbol;
            IMarkerSymbol markerSymbol = pieChartSymbol as IMarkerSymbol;
            markerSymbol.Size = 30;

            //添加渲染符号
            ISymbolArray symbolArray = pieChartSymbol as ISymbolArray;
            IFillSymbol[] fillsymbol = new IFillSymbol[renderFields.Count];
            for (int i = 0; i < renderFields.Count; i++)
            {
                fillsymbol[i] = new SimpleFillSymbolClass();
                fillsymbol[i].Color = renderColor[i];
                symbolArray.AddSymbol(fillsymbol[i] as ISymbol);
            }

            //设置背景
            chartRenderer.ChartSymbol = pieChartSymbol as IChartSymbol;
            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = BgColor;
            chartRenderer.BaseSymbol = pFillSymbol as ISymbol;
            chartRenderer.UseOverposter = false;
            //创建图例
            chartRenderer.CreateLegend();
            geoFeatureLayer.Renderer = chartRenderer as IFeatureRenderer;

            IActiveView pActiveView = axMapControl1.Map as IActiveView;
            pActiveView.Refresh();
            axTOCControl1.Update();
        }

        /*
         * 添加柱状图
         * @layerName图层名
         * @renderFields字段
         * @alias别名
         * @renderColor对应的填充颜色
         * @BgColor地图填充色
         */
        public void createBarChart(string layerName, List<string> renderFields, List<IColor> renderColor, IColor BgColor, List<string> alias = null)
        {
            IGeoFeatureLayer geoFeatureLayer;
            IFeatureLayer featureLayer;
            ITable table;

            geoFeatureLayer = getGeoLayer(layerName);
            featureLayer = geoFeatureLayer as IFeatureLayer;
            table = featureLayer as ITable;
            geoFeatureLayer.ScaleSymbols = true;
            IChartRenderer chartRenderer = new ChartRendererClass();
            IBarChartSymbol barChartSymbol = new BarChartSymbolClass();
            IRendererFields rendererFields = chartRenderer as IRendererFields;
            for (int i = 0; i < renderFields.Count; i++)
            {
                if(null != alias)
                    rendererFields.AddField(renderFields[i], alias[i]);
                else
                    rendererFields.AddField(renderFields[i], renderFields[i]);
            }

            //找到所有地物类中的最大值
            double maxValue = 0;
            ICursor cursor = table.Search(null, true);
            IRowBuffer rowBuffer = cursor.NextRow();
            while (rowBuffer != null)
            {
                for (int i = 0; i < renderFields.Count; i++)
                {
                    double fieldValue;
                    try{
                        fieldValue = double.Parse(rowBuffer.get_Value(table.FindField(renderFields[i])).ToString());
                    }catch (Exception ex){
                        fieldValue = 0;
                    }
                    maxValue = Math.Max(maxValue, fieldValue);
                }
                rowBuffer = cursor.NextRow();
            }
            
            barChartSymbol.Width = 5;
            IMarkerSymbol markerSymbol = barChartSymbol as IMarkerSymbol;
            markerSymbol.Size = 50;
            IChartSymbol chartSymbol = barChartSymbol as IChartSymbol;
            chartSymbol.MaxValue = maxValue;

            //添加渲染符号  
            ISymbolArray symbolArray = barChartSymbol as ISymbolArray;
            IFillSymbol fillSymbol;
            IColorRamp colors = CreateRandomColorRamp(renderFields.Count);//ramp舷梯
            for (int i = 0; i < renderFields.Count; i++)
            {
                fillSymbol = new SimpleFillSymbolClass();
                fillSymbol.Color = colors.get_Color(i);
                symbolArray.AddSymbol(fillSymbol as ISymbol);
            }
            //设置柱状图符号  
            chartRenderer.ChartSymbol = barChartSymbol as IChartSymbol;

            //行政区填充
            fillSymbol = new SimpleFillSymbolClass();
            fillSymbol.Color = getRGB(245, 235, 186);
            fillSymbol.Color.Transparency = 2;
            chartRenderer.BaseSymbol = fillSymbol as ISymbol;

            chartRenderer.UseOverposter = false;

            //创建图例  
            chartRenderer.CreateLegend();
            geoFeatureLayer.Renderer = chartRenderer as IFeatureRenderer;
            geoFeatureLayer.DisplayField = "LOCALID";

            IActiveView pActiveView = axMapControl1.Map as IActiveView;
            pActiveView.Refresh();
            axTOCControl1.Update();
        }

        /*
         * 添加雷达图
         * @layerName图层名
         * @renderFields字段
         * @renderColor线条颜色
         * @BgColor雷达图背景色
         */
        public void creatRadarChart(string layerName, List<string> renderFields, IColor renderColor, IColor BgColor)
        {
            IGeoFeatureLayer geoFeatureLayer;
            IFeatureLayer featureLayer;
            IFeatureClass featureClass;//IFeatureClass 控制要访问的要素类
            IFeatureCursor featureCursor;//游标，用于访问要素
            IFeature feature;//每一个要素
            ITable table;

            IGraphicsContainer pGraContainer = axMapControl1.Map as IGraphicsContainer;

            geoFeatureLayer = getGeoLayer(layerName);
            featureLayer = geoFeatureLayer as IFeatureLayer;
            table = featureLayer as ITable;

            //找到所有地物类中的最大值
            double maxValue = 0;
            ICursor cursor = table.Search(null, true);
            IRowBuffer rowBuffer = cursor.NextRow();
            while (rowBuffer != null)
            {
                for (int i = 0; i < renderFields.Count; i++)
                {
                    double fieldValue;
                    try
                    {
                        fieldValue = double.Parse(rowBuffer.get_Value(table.FindField(renderFields[i])).ToString());
                    }
                    catch (Exception ex)
                    {
                        fieldValue = 0;
                    }
                    maxValue = Math.Max(maxValue, fieldValue);
                }
                rowBuffer = cursor.NextRow();
            }


            featureClass = featureLayer.FeatureClass;
            featureCursor = featureClass.Search(null, false);
            feature = featureCursor.NextFeature();

            List<int> index = new List<int>();//储存字段索引
            for (int i = 0; i < renderFields.Count; i++)
                index.Add(feature.Fields.FindField(renderFields[i]));//FindField返回要标注字段的索引值

            IEnvelope pEnv = null;
            ITextElement pTextElment = null;
            IElement pEle = null;
            //对要素进行循环
            while (feature != null)
            {
                //使用地理对象的中心作为标注的位置
                pEnv = feature.Extent;
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(pEnv.XMin + pEnv.Width * 0.5, pEnv.YMin + pEnv.Height * 0.5);



                //pTextElment = new TextElementClass()
                //{
                //    Symbol = pTextSymbol,
                //    ScaleText = true,
                //    Text = feature.get_Value(index).ToString()
                //};
                //pEle = pTextElment as IElement;
                //pEle.Geometry = pPoint;
                ////添加标注
                //pGraContainer.AddElement(pEle, 0);
                //feature = feature.NextFeature();
            }
          //(axMapControl.Map as IActiveView).PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, axMapControl1.Extent);
        }
        private void addRadarGraph()
        {
            IPoint centerPt = new PointClass();
            centerPt.X = 534055;
            centerPt.Y = 3379019;
            //IGeometry ellipseGeometry = CreateElliptic(centerPt, 100, 100, 0.5);//创建椭圆几何

            IPoint p1 = new PointClass();
            IPoint p2 = new PointClass();
            IPoint p3 = new PointClass();
            IPoint p4 = new PointClass();
            p1.X = centerPt.X - 100;
            p1.Y = centerPt.Y - 100;

            p2.X = centerPt.X - 100;
            p2.Y = centerPt.Y + 100;

            p3.X = centerPt.X + 100;
            p3.Y = centerPt.Y + 100;

            p4.X = centerPt.X + 100;
            p4.Y = centerPt.Y - 100;
            IPointCollection pPointCollection = new PolygonClass();
            object missing = Type.Missing;
            pPointCollection.AddPoint(p1, ref missing, ref missing);
            pPointCollection.AddPoint(p4, ref missing, ref missing);
            pPointCollection.AddPoint(p3, ref missing, ref missing);
            pPointCollection.AddPoint(p2, ref missing, ref missing);
            IPolygon pPolygon = (IPolygon)pPointCollection;

            ////Geometry
            //IEllipticArc pEllipse = new EllipticArcClass();
            //pEllipse.PutCoordsByAngle(false, centerPt, 3, 2 * Math.PI, 0, 200, 0.3);

            //symbol
            ISimpleFillSymbol fillsymbol = new SimpleFillSymbolClass();
            fillsymbol.Style = esriSimpleFillStyle.esriSFSDiagonalCross;
            fillsymbol.Color = getRGB(240, 240, 240);

            ////Element
            //IFillShapeElement ellipseElement = new EllipseElementClass();
            IFillShapeElement ePolygon = new PolygonElementClass();
            ePolygon.Symbol = fillsymbol;
            IElement pEle = ePolygon as IElement;
            pEle.Geometry = pPolygon as IGeometry;




            //Console.WriteLine(pEllipse.GetType());
            //ellipseElement.Symbol = fillsymbol;
            /*-------------------------------鼠标画多边形ok-------------------------*/
            /*
            IMap pMap = axMapControl1.Map;
            IActiveView pActiveView = pMap as IActiveView;
            IGeometry pGeo = axMapControl1.TrackPolygon();

            IFillShapeElement pFillElement = new PolygonElementClass();
            pFillElement.Symbol = fillsymbol;
            IElement pEle = pFillElement as IElement;
            pEle.Geometry = pGeo;*/
            /*-------------------------------鼠标画多边形ok------------------------*/

            /*-------------------------------鼠标画线ok---------------------------------*/
            //ISimpleLineSymbol pLineSymbol = new SimpleLineSymbolClass(); //设置Symbol属性
            //pLineSymbol.Color = getRGB(0, 255, 0);
            //pLineSymbol.Width = 3;

            //IGeometry pGeo = axMapControl1.TrackLine();
            //ILineElement pLineElement = new LineElementClass();
            //IElement pEle = pLineElement as IElement;
            //pLineElement.Symbol = pLineSymbol;
            //pEle.Geometry = pGeo;
            /*-------------------------------鼠标画线ok---------------------------------*/

            /*-------------------------------注记ok---------------------------------*/
            //ITextElement pText = new TextElementClass();
            //pText.Text = "从今天开始你就是我的了就像驴子一样给你盖个章";
            //IElement pEle = pText as IElement;
            //IPoint point = new PointClass();
            //point.PutCoords(centerPt.X, centerPt.Y);

            //IFormattedTextSymbol pTextSymbol = new TextSymbolClass();
            //ICallout pCallout = new BalloonCalloutClass();
            //pCallout.AnchorPoint = point;
            //pTextSymbol.Background = pCallout as ITextBackground;
            //pText.Symbol = pTextSymbol;
            //pEle.Geometry = point;
            /*-------------------------------注记ok---------------------------------*/

            ////将元素添加到地图中  
            IGraphicsContainer container = axMapControl1.Map as IGraphicsContainer;
            container.AddElement(pEle, 0);

            IActiveView activeView = axMapControl1.Map as IActiveView;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        //鼠标绘圆
        private void AddCircle()
        {
            IActiveView m_ActiveView = axMapControl1.Map as IActiveView;
            //m_ActiveView = m_hookHelper.ActiveView;

            IScreenDisplay pScreenDisplay = m_ActiveView.ScreenDisplay;
            IRubberBand pRubberCircle = new RubberCircleClass();
            ISimpleFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = getRGB(255, 255, 0);
            IGeometry pCircle = pRubberCircle.TrackNew(pScreenDisplay, (ISymbol)pFillSymbol) as IGeometry;
            IPolygon pPolygon = new PolygonClass();    //空的多边形
            ISegmentCollection pSegmentCollection = pPolygon as ISegmentCollection;  //段集合
            ISegment pSegment = pCircle as ISegment;  //将圆赋值给段
            object missing = Type.Missing;  //显示默认值
            pSegmentCollection.AddSegment(pSegment, ref missing, ref missing);  //给空多边形加入圆
            pFillSymbol.Style = esriSimpleFillStyle.esriSFSDiagonalCross;
            pFillSymbol.Color = getRGB(0, 255, 255);
            IFillShapeElement pPolygonEle = new PolygonElementClass();
            pPolygonEle.Symbol = pFillSymbol;
            IElement pEle = pPolygonEle as IElement;
            pEle.Geometry = pPolygon;
            IGraphicsContainer pGraphicsContainer = axMapControl1.Map as IGraphicsContainer;
            pGraphicsContainer.AddElement(pEle, 0);
            m_ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        static public IColorRamp CreateAlgorithmicColorRamp(int count)
        {
            //IUniqueValueRenderer pUniqueValueR;  
            IEnumColors pEnumRamp;
            AlgorithmicColorRamp pColorRamp;
            //pUniqueValueR = new UniqueValueRendererClass();  
            //pUniqueValueR.FieldCount = 1;  
            //pUniqueValueR.set_Field(0, FielName);  

            pColorRamp = new AlgorithmicColorRampClass();
            pColorRamp.FromColor = getRGB(255, 255, 255);
            pColorRamp.ToColor = getRGB(32, 200, 150);
            pColorRamp.Size = count;

            bool ok = true;
            pColorRamp.CreateRamp(out ok);
            pEnumRamp = pColorRamp.Colors;
            return pColorRamp;
        }

        //生成颜色带    
        static public IColorRamp CreateRandomColorRamp(int count)
        {
            //IUniqueValueRenderer pUniqueValueR;  
            IEnumColors pEnumRamp;
            IRandomColorRamp pColorRamp;
            //pUniqueValueR = new UniqueValueRendererClass();  
            //pUniqueValueR.FieldCount = 1;  
            //pUniqueValueR.set_Field(0, FielName);  

            pColorRamp = new RandomColorRampClass();
            pColorRamp.StartHue = 0;
            pColorRamp.MinValue = 99;
            pColorRamp.MinSaturation = 15;
            pColorRamp.EndHue = 360;
            pColorRamp.MaxValue = 100;
            pColorRamp.MaxSaturation = 30;
            pColorRamp.Size = count * 2;

            bool ok = true;
            pColorRamp.CreateRamp(out ok);
            pEnumRamp = pColorRamp.Colors;
            return pColorRamp;
        }

        //简单填充符号
        static public IGeoFeatureLayer GetSimpleSymbolLayer(IGeoFeatureLayer geoFeatureLayer, string field)
        {
            //  getGeoLayer("sichuan_county_landuse");  
            IUniqueValueRenderer uniqueValueRenderer = new UniqueValueRendererClass();
            uniqueValueRenderer.FieldCount = 1;
            uniqueValueRenderer.set_Field(0, field);  

            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;
            int areaNum = geoFeatureLayer.FeatureClass.FeatureCount(null);
            IFeatureCursor featureCursor = geoFeatureLayer.FeatureClass.Search(null, false);
            IFeature feature;
            if (featureCursor != null)
            {
                IEnumColors enumColors = CreateRandomColorRamp(areaNum).Colors;
                int fieldIndex = geoFeatureLayer.FeatureClass.Fields.FindField(field);
                feature = featureCursor.NextFeature();
                while (feature != null)
                {
                    string nameValue = feature.get_Value(fieldIndex).ToString();
                    simpleFillSymbol = new SimpleFillSymbolClass();
                    simpleFillSymbol.Color = enumColors.Next();
                    uniqueValueRenderer.AddValue(nameValue, field, simpleFillSymbol as ISymbol);
                    feature = featureCursor.NextFeature();
                }
            }
            geoFeatureLayer.Renderer = uniqueValueRenderer as IFeatureRenderer;
            return geoFeatureLayer;
        }

        //添加标题
        public void AddTitle(IPageLayout layout, string mapTitle)
        {
            IGraphicsContainer container = layout as IGraphicsContainer;
            IActiveView activeView = layout as IActiveView;
            IMapFrame mapFrame = container.FindFrame(activeView.FocusMap) as IMapFrame;
            IElement mapElement = mapFrame as IElement;
            IEnvelope mapEnvelope = mapElement.Geometry.Envelope;
            IPoint point = new PointClass();
            point.X = mapEnvelope.XMin + mapEnvelope.Width / 2;
            point.Y = mapEnvelope.YMax + 2.5;

            ITextElement txtElement = new TextElementClass();
            IFontDisp pFont = new StdFont(){Name = "宋体",Size = 5} as IFontDisp;

            ITextSymbol pTextSymbol = new TextSymbolClass()
            {
                Color = getRGB(255,0,0),
                Font = pFont,
                Size = 11
            };

            txtElement.Symbol = pTextSymbol;
            txtElement.ScaleText = true;
            txtElement.Text = mapTitle;

            IElement element = txtElement as IElement;
            element.Geometry = point;
            container.AddElement(element, 0);
        }

        //添加注记
        public static void AddLable(AxMapControl axMapControl, ILayer layer, string fieldName)
        {
            IRgbColor pColor = new RgbColorClass()
            {
                Red = 255,
                Blue = 0,
                Green = 0
            };
            IFontDisp pFont = new StdFont()
            {
                Name = "宋体",
                Size = 5
            } as IFontDisp;

            ITextSymbol pTextSymbol = new TextSymbolClass()
            {
                Color = pColor,
                Font = pFont,
                Size = 11
            };


            IGraphicsContainer pGraContainer = axMapControl.Map as IGraphicsContainer;


            //遍历要标注的要素
            IFeatureLayer pFeaLayer = layer as IFeatureLayer;
            IFeatureClass pFeaClass = pFeaLayer.FeatureClass;
            IFeatureCursor pFeatCur = pFeaClass.Search(null, false);
            IFeature pFeature = pFeatCur.NextFeature();
            int index = pFeature.Fields.FindField(fieldName);//要标注的字段的索引
            IEnvelope pEnv = null;
            ITextElement pTextElment = null;
            IElement pEle = null;
            while (pFeature != null)
            {
                //使用地理对象的中心作为标注的位置
                pEnv = pFeature.Extent;
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(pEnv.XMin + pEnv.Width * 0.5, pEnv.YMin + pEnv.Height * 0.5);


                pTextElment = new TextElementClass()
                {
                    Symbol = pTextSymbol,
                    ScaleText = true,
                    Text = pFeature.get_Value(index).ToString()
                };
                pEle = pTextElment as IElement;
                pEle.Geometry = pPoint;
                //添加标注
                pGraContainer.AddElement(pEle, 0);
                pFeature = pFeatCur.NextFeature();
            }
            (axMapControl.Map as IActiveView).PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, axMapControl.Extent);
        }

        //椭圆
        public static IGeometry CreateElliptic(IPoint centerPoint, double longeraxis, double shorteraxis, double angle)
        {
            double centerx = centerPoint.X;
            double centery = centerPoint.Y;
            double Xmax = centerx + longeraxis;
            double Xmin = centerx - longeraxis;
            double Ymax = centery + shorteraxis;
            double Ymin = centery - shorteraxis;
            IEnvelope pEnv = new EnvelopeClass();
            pEnv.XMax = Xmax;
            pEnv.XMin = Xmin;
            pEnv.YMax = Ymax;
            pEnv.YMin = Ymin;
            pEnv.Width = longeraxis * 2;
            pEnv.Height = shorteraxis * 2;
            //借助旋转

            IEllipticArc pEllipse = new EllipticArcClass();
            pEllipse.PutCoordsByAngle(false, centerPoint, 3, 2 * Math.PI, 0, 200, 0.3);

            //IConstructEllipticArc pconstructEllipse = new EllipticArcClass();
            //pconstructEllipse.ConstructEnvelope(pEnv);
            //ITransform2D pTransform = pconstructEllipse as ITransform2D;
            //pTransform.Rotate(centerpoint, angle);
            //return pconstructEllipse as IGeometry;
            return pEllipse as IGeometry;
        }

        //private void AddLegend(IActiveView pActiveView, IEnvelope pEnv)
        //{
        //    IGraphicsContainer pGraphicsContainer = pActiveView.GraphicsContainer;
        //    UID pID = new UID();
        //    pID.Value = "esriCarto.Legend";

        //    IMapFrame pMapFrame = pGraphicsContainer.FindFrame(pActiveView.FocusMap) as IMapFrame;
        //    IMapSurroundFrame pMapSurroundFrame = pMapFrame.CreateSurroundFrame(pID, null);//根据唯一标示符，创建与之对应MapSurroundFrame

        //    IElement pDeletElement = axPageControl.FindElementByName("Legend");//获取PageLayout中的图例元素
        //    if (pDeletElement != null)
        //    {
        //        pGraphicsContainer.DeleteElement(pDeletElement);  //如果已经存在图例，删除已经存在的图例
        //    }
        //    //设置MapSurroundFrame背景
        //    ISymbolBackground pSymbolBackground = new SymbolBackgroundClass();
        //    ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
        //    pLineSymbol.Color = ColorUtilty.GetRgbColor(0, 0, 0);
        //    IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
        //    pFillSymbol.Color = ColorUtilty.GetRgbColor(240, 240, 240);
        //    pFillSymbol.Outline = pLineSymbol;
        //    pSymbolBackground.FillSymbol = pFillSymbol;
        //    pMapSurroundFrame.Background = pSymbolBackground;
        //    //添加图例
        //    IElement pElement = pMapSurroundFrame as IElement;
        //    pElement.Geometry = pEnv as IGeometry;
        //    IMapSurround pMapSurround = pMapSurroundFrame.MapSurround;
        //    ILegend pLegend = pMapSurround as ILegend;
        //    pLegend.ClearItems();
        //    pLegend.Title = "图例";

        //    for (int i = 0; i < pActiveView.FocusMap.LayerCount; i++)
        //    {
        //        ILayer pLayer = pActiveView.FocusMap.get_Layer(i);
        //        if (pLayer.Visible == true)
        //        {
        //            if (pLayer is IGroupLayer || pLayer is ICompositeLayer)
        //            {
        //                ICompositeLayer pCompositeLayer = (ICompositeLayer)pLayer;
        //                for (int j = pCompositeLayer.Count - 1; j >= 0; j--)
        //                {
        //                    ILayer pSubLayer = pCompositeLayer.get_Layer(j);
        //                    ILegendItem pItem = SetItemStyle(pSubLayer);
        //                    pLegend.AddItem(pItem);//添加图例内容
        //                }
        //            }
        //            else
        //            {
        //                ILegendItem pItem = SetItemStyle(pLayer);
        //                pLegend.AddItem(pItem);//添加图例内容
        //            }
        //        }
        //    }

        //    pGraphicsContainer.AddElement(pElement, 0);
        //    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        //}

        //private ILegendItem SetItemStyle(ILayer layer)
        //{
        //    StdFont myFont = new stdole.StdFontClass();
        //    myFont.Name = "宋体";
        //    myFont.Size = 10;

        //    ITextSymbol txtSymbol = new TextSymbolClass();
        //    txtSymbol.Font = (IFontDisp)myFont;

        //    ILegendItem pLegendItem = new HorizontalLegendItemClass();
        //    pLegendItem.Layer = layer;//获取添加图例关联图层             
        //    pLegendItem.ShowDescriptions = false;
        //    pLegendItem.Columns = 1;
        //    pLegendItem.LayerNameSymbol = txtSymbol;
        //    pLegendItem.ShowHeading = true;
        //    pLegendItem.ShowLabels = true;

        //    return pLegendItem;
        //}




        //IGeometry selectGeometry = null;
        //private void pointSelect(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e) //点选  
        //{
        //    IEnvelope pEnv;
        //    IActiveView pActiveView = axMapControl1.ActiveView;
        //    IMap pMap = axMapControl1.Map;
        //    pEnv = axMapControl1.TrackRectangle();
        //    if (pEnv.IsEmpty == true)
        //    {
        //        ESRI.ArcGIS.esriSystem.tagRECT r;
        //        r.bottom = e.y + 5;
        //        r.top = e.y - 5;
        //        r.left = e.x - 5;
        //        r.right = e.x + 5;
        //        pActiveView.ScreenDisplay.DisplayTransformation.TransformRect(pEnv, ref r, 4);
        //        pEnv.SpatialReference = pActiveView.FocusMap.SpatialReference;
        //    }
        //    selectGeometry = pEnv as IGeometry;
        //    axMapControl1.Map.SelectByShape(selectGeometry, null, false);
        //    axMapControl1.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
        //}


    }//class
}//namespace
