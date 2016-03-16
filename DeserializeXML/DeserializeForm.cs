using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Path = System.IO.Path;
using Point = ESRI.ArcGIS.Geometry.Point;

namespace DeserializeXML
{
    public partial class DeserializeForm : Form
    {
        public DeserializeForm()
        {
            InitializeComponent();
        }

        private void xmlDocLoc_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {Multiselect = false, Filter = "XML Documents (*.xml)|*.xml", Title = "Select XML Document", FilterIndex = 1};

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathOfXMLFile = Path.GetFullPath(openFileDialog.FileName);
                xmlDocLoc_txtBox.Text = pathOfXMLFile.ToString();
            };

        }

        private void gdbloc_btn_Click(object sender, EventArgs e)
        {
            IEnumGxObject gxEnumGxObject;
            IGxObjectFilter gxObjectFilter = new GxFilterFileGeodatabases();

            IGxDialog gxDialog = new GxDialog {AllowMultiSelect = false, Title = "Select Output GDB", ButtonCaption = "Open"};
            gxDialog.ObjectFilter = gxObjectFilter;

            if (gxDialog.DoModalOpen(0, out gxEnumGxObject) && gxEnumGxObject != null)
            {
                IGxObject gxObj = gxEnumGxObject.Next();
                gdbToSaveToTxtBox.Text = gxObj.FullName.ToString();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string fcName = featureClass_txtbox.Text;
                Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
                IWorkspaceFactory workspaceFactory = (WorkspaceFactory) Activator.CreateInstance(factoryType);
                IFeatureWorkspace featureWorkspace = (IFeatureWorkspace) workspaceFactory.OpenFromFile(gdbToSaveToTxtBox.Text, 0);

                System.Object objectFromXml = DeserializeAnXMLFile(xmlDocLoc_txtBox.Text);

                ISpatialReference sr;

                if (((IGeometry)objectFromXml).GeometryType == esriGeometryType.esriGeometryPolygon)
                {
                    Polygon feature = objectFromXml as Polygon;
                    IPolygon4 newPolygon = objectFromXml as IPolygon4;
                    sr = newPolygon.SpatialReference;
                }
                else if (((IGeometry)objectFromXml).GeometryType == esriGeometryType.esriGeometryPolyline)
                {
                    Polyline feature = objectFromXml as Polyline;
                    IPolyline4 newPolygon = objectFromXml as IPolyline4;
                    sr = newPolygon.SpatialReference;
                }
                else
                {
                    Point feature = objectFromXml as Point;
                    IPoint newPoint = feature as IPoint;
                    sr = feature.SpatialReference;
                }
                

                    IFeatureClassDescription fcDescription = new FeatureClassDescriptionClass();
                    IObjectClassDescription ocDescription = (IObjectClassDescription) fcDescription;
                    IFields fields = ocDescription.RequiredFields;

                    IField field = fields.get_Field(fields.FindField(fcDescription.ShapeFieldName));
                    IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit) field.GeometryDef;
                //geometryDefEdit.HasZ_2 = ((IGeometry)objectFromXml).

                if (((IZAware)objectFromXml).ZAware)
                {
                    geometryDefEdit.HasZ_2 = true;
                }

                    if (((IGeometry)objectFromXml).GeometryType == esriGeometryType.esriGeometryPolygon)
                    {
                        geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
                    }
                    else if (((IGeometry)objectFromXml).GeometryType == esriGeometryType.esriGeometryPolyline)
                    {
                        geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolyline;
                    }
                    else
                    {
                        geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
                    }

                    geometryDefEdit.SpatialReference_2 = sr;

                    IFeatureClass featureClass = featureWorkspace.CreateFeatureClass(featureClass_txtbox.Text, fields, ocDescription.InstanceCLSID,
                        ocDescription.ClassExtensionCLSID, esriFeatureType.esriFTSimple, fcDescription.ShapeFieldName,
                        "");

                IFeatureCursor featureCursor = featureClass.Insert(true);
                IFeatureBuffer featureBuffer = featureClass.CreateFeatureBuffer();
                featureBuffer.Shape = (IGeometry)objectFromXml;
                featureCursor.InsertFeature(featureBuffer);

                status_txtBox.Text = "DONE";
            }
            catch (Exception ex)
            {
                status_txtBox.Text = ex.ToString();
            }
        }

        public System.Object DeserializeAnXMLFile(System.String xmlPathFile)
        {
            // Create xmlStream and load in the .XML file
            ESRI.ArcGIS.esriSystem.IXMLStream xmlStream = new ESRI.ArcGIS.esriSystem.XMLStreamClass();
            xmlStream.LoadFromFile(xmlPathFile);

            // Create xmlReader and read the XML stream
            ESRI.ArcGIS.esriSystem.IXMLReader xmlReader = new ESRI.ArcGIS.esriSystem.XMLReaderClass();
            xmlReader.ReadFrom((ESRI.ArcGIS.esriSystem.IStream)xmlStream); // Explicit Cast

            // Create a serializer
            ESRI.ArcGIS.esriSystem.IXMLSerializer xmlSerializer = new ESRI.ArcGIS.esriSystem.XMLSerializerClass();

            // Return the XML contents
            return xmlSerializer.ReadObject(xmlReader, null, null);
        }
    }
}
