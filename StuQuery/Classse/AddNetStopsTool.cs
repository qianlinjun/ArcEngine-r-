﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace StuQuery
{
        /// <summary>
        /// Summary description for AddNetStopsTool.
        /// </summary>
        [Guid("e014e411-b224-4e51-b50d-8c832963a75e")]
        [ClassInterface(ClassInterfaceType.None)]
        [ProgId("最短路径分析.AddNetStopsTool")]
        public sealed class AddNetStopsTool : BaseTool
        {
            #region COM Registration Function(s)
            [ComRegisterFunction()]
            [ComVisible(false)]
            static void RegisterFunction(Type registerType)
            {
                // Required for ArcGIS Component Category Registrar support
                ArcGISCategoryRegistration(registerType);

                //
                // TODO: Add any COM registration code here
                //
            }

            [ComUnregisterFunction()]
            [ComVisible(false)]
            static void UnregisterFunction(Type registerType)
            {
                // Required for ArcGIS Component Category Registrar support
                ArcGISCategoryUnregistration(registerType);

                //
                // TODO: Add any COM unregistration code here
                //
            }

            #region ArcGIS Component Category Registrar generated code
            /// <summary>
            /// Required method for ArcGIS Component Category registration -
            /// Do not modify the contents of this method with the code editor.
            /// </summary>
            private static void ArcGISCategoryRegistration(Type registerType)
            {
                string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
                MxCommands.Register(regKey);
                ControlsCommands.Register(regKey);
            }
            /// <summary>
            /// Required method for ArcGIS Component Category unregistration -
            /// Do not modify the contents of this method with the code editor.
            /// </summary>
            private static void ArcGISCategoryUnregistration(Type registerType)
            {
                string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
                MxCommands.Unregister(regKey);
                ControlsCommands.Unregister(regKey);
            }

            #endregion
            #endregion

            private IHookHelper m_hookHelper = null;
            private IFeatureWorkspace pFWorkspace;
            private IFeatureClass inputFClass;
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            public AddNetStopsTool()
            {
                //
                // TODO: Define values for the public properties
                //
                base.m_category = "NetWorkAnalyst";
                base.m_caption = "添加站点";
                base.m_message = "鼠标在地图上单击即可";
                base.m_toolTip = "添加站点";
                base.m_name = "AddStop";
                try
                {
                    //
                    // TODO: change resource name if necessary
                    //
                    string bitmapResourceName = GetType().Name + ".bmp";
                    base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                    base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
                }
            }

            #region Overridden Class Methods

            /// <summary>
            /// Occurs when this tool is created
            /// </summary>
            /// <param name="hook">Instance of the application</param>
            public override void OnCreate(object hook)
            {
                try
                {
                    m_hookHelper = new HookHelperClass();
                    m_hookHelper.Hook = hook;
                    if (m_hookHelper.ActiveView == null)
                    {
                        m_hookHelper = null;
                    }
                }
                catch
                {
                    m_hookHelper = null;
                }

                if (m_hookHelper == null)
                    base.m_enabled = false;
                else
                    base.m_enabled = true;

                // TODO:  Add other initialization code
            }

            /// <summary>
            /// Occurs when this tool is clicked
            /// </summary>
            public override void OnClick()
            {
                // TODO: Add AddNetStopsTool.OnClick implementation
                string name = NetWorkAnalysClass.getPath(path) + "\\data\\Data\\road.gdb";
                pFWorkspace = NetWorkAnalysClass.OpenWorkspace(name) as IFeatureWorkspace;
                inputFClass = pFWorkspace.OpenFeatureClass("Stops");
                if (inputFClass.FeatureCount(null) > 0)
                {
                    ITable pTable = inputFClass as ITable;
                    pTable.DeleteSearchedRows(null);
                }
            }
            public override void OnMouseDown(int Button, int Shift, int X, int Y)
            {
                // TODO:  Add AddNetStopsTool.OnMouseDown implementation
                try
                {
                    IPoint pStopsPoint = new PointClass();
                    pStopsPoint = m_hookHelper.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);
                    IFeature newPointFeature = inputFClass.CreateFeature();
                    try
                    {
                        pStopsPoint.Z = 0;
                        newPointFeature.Shape = pStopsPoint;
                        IZAware pZAware = pStopsPoint as IZAware;
                        IMAware pMAware = pStopsPoint as IMAware;
                        pZAware.ZAware = true;
                        pMAware.MAware = true;
                    }
                    catch
                    {
                        IGeometry pGeo = pStopsPoint;
                        IZAware pZAware = pGeo as IZAware;
                        pZAware.ZAware = false;

                        newPointFeature.Shape = pGeo;
                    }
                    newPointFeature.Store();
                    IGraphicsContainer pGrap = m_hookHelper.ActiveView as IGraphicsContainer;
                    IColor pColor;
                    IRgbColor pRgbColor = new RgbColorClass();
                    pRgbColor.Red = 255;
                    pRgbColor.Green = 255;
                    pRgbColor.Blue = 255;
                    pColor = pRgbColor as IColor;
                    IPictureMarkerSymbol pms = new PictureMarkerSymbolClass();
                    pms.BitmapTransparencyColor = pColor;
                    string picturePath = NetWorkAnalysClass.getPath(path) + "\\data\\Img\\stops.bmp";
                    //添加自定义站点图片
                    pms.CreateMarkerSymbolFromFile(esriIPictureType.esriIPictureBitmap, picturePath);
                    pms.Size = 18;
                    IMarkerElement pMarkerEle = new MarkerElementClass();
                    pMarkerEle.Symbol = pms as IMarkerSymbol;
                    pStopsPoint.SpatialReference = m_hookHelper.ActiveView.FocusMap.SpatialReference;
                    IElement pEle = pMarkerEle as IElement;
                    pEle.Geometry = pStopsPoint;
                    pGrap.AddElement(pEle, 1);
                    m_hookHelper.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
                }
                catch
                {
                    MessageBox.Show("添加站点失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            public override void OnMouseMove(int Button, int Shift, int X, int Y)
            {
                // TODO:  Add AddNetStopsTool.OnMouseMove implementation
            }

            public override void OnMouseUp(int Button, int Shift, int X, int Y)
            {
                // TODO:  Add AddNetStopsTool.OnMouseUp implementation
            }
            #endregion
        }
}
