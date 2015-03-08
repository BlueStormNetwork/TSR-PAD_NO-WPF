using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data;

using System.Linq;
using System.Xml.Linq;

using CallsDB;
using Common.Library;

namespace TSR_PAD_NO_WPF
{
    public partial class Form1 : RibbonForm
    {

        public Form1()
        {
            InitializeComponent();
            ///*TODO: - create xml file to hold data use attribute ofen to speed up read/write process
            //- create a class to map properties to each column/attribute is case of complexe data structure use
            //  several class to keep a object.property like structure 
            //- implement the INotifyPropertyChanged event if needed to ensure controls will bind and update
            //  correctly to the datasource:XMLFILE
            //- create the linq to xml query >> check data code fails if if invalide xml file/nul attributes
            //- Create extension methods to perform null-checking and valid values when using LINQ to XML to read
            //  XML data
            //- use key/value to store data on isolated storage each user will have his own data folder 
            //  using System.IO.IsolatedStorage can check for key existance using contains methode of the
            //  ApplicationSettings property of the IsolatedStorageSettings class
            //- add insert/update/delete methods to data changes XML file
            //- create service/to read data from Sharepoint/Lists(Database server)
            //- consume the data as xml/upload the data as Share point Lists
            //            * http://www.codemag.com/Article/1210021
            // http://www.c-sharpcorner.com/uploadfile/vimalkandasamy/xml-a-simple-database/
            //            https://www.youtube.com/watch?v=JY4y43FRkDM
            //            http://www.codeproject.com/Articles/13854/Using-XML-as-Database-with-Dataset
            //            https://msdn.microsoft.com/en-us/library/fx29c3yd.aspx */
        }
        private void Form1_load(object sender, EventArgs e)
        {
            //TODO:load xml file
            LoadDayCalls();
        }

        #region private methodes
        private void LoadDayCalls()
        {
            //TODO:complete load procedure
            XElement xElem = null;

            try
            {
                xElem = XElement.Load(Calls.XmlFile);

                // The following will NOT work if you have missing attributes
                var calls =
                    from elem in xElem.Descendants("Tday")
                    orderby elem.Attribute("CallID").Value
                    select new Calls
                    {
                        CallID = Convert.ToInt32(
                          elem.Attribute("CallID").Value),
                        CallType = (elem.Attribute("CallType").Value == "Residential") ? (int)CallType_enum.Residential : (int)CallType_enum.Commercial,
                        //IntroductionDate = Convert.ToDateTime(
                        //  elem.Attribute("IntroductionDate").Value),
                        //Price = Convert.ToDecimal(elem.Attribute("Price").Value)
                    };

                //lstData.DataContext = calls;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private DataView ldata()
        {
            DataView dv = new DataView();
            ds.Clear();
            //ds.ReadXml("..\\..\\resources\\cxbklg.xsd", XmlReadMode.ReadSchema);
            try
            {
                ds.ReadXml("..\\..\\resources\\cxbklg.xml");
                ds.WriteXmlSchema("..\\..\\resources\\cxbklg-schem.xsd");

            }
            catch (ConstraintException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                throw;
            }
            dv = ds.Tables[0].DefaultView;
            return dv;
        }
        private void open_rbtn_mainfrm_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Cxfile_frm))
                {
                    f.Activate();
                    return;
                }
            }

            Form child1_frm = new Cxfile_frm();
            // child1_frm.MdiParent = this;
            //child1_frm.Show();

            ds.ReadXml("..\\..\\resources\\cxbklg.xml");
            dataGridView1.DataSource = ldata();

            Console.WriteLine(dataGridView1.DataMember);
        }

        private void close_rbtn_mainfrm_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }


    }


}
