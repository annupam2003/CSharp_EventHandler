using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventHandlerLevel05
{
    public partial class FrmStudent : Form
    {

        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = Convert.ToInt32(txt_id.Text),
                IsActive = Convert.ToBoolean(chk_isactive.Checked),
                DateIs = Convert.ToDateTime(dtp_dateis.Value),
                Name = Convert.ToString(txt_Name.Text),
                Marks = Convert.ToDecimal(txt_Marks.Text)
            };
            Form1.student = student;
        }

        public void GenrateXml(Student student)
        {
            if (File.Exists(@"C:\temp\student.xml"))
            {
                XDocument doc = XDocument.Load(@"C:\temp\student.xml");
                doc.Element("Students").Add(
                     new XElement("Student",
                        new XElement("Id", student.Id),
                        new XElement("IsActive", student.IsActive),
                        new XElement("DateIs", student.DateIs),
                        new XElement("Name", student.Name),
                        new XElement("Marks", student.Marks)
                    )
                );
                doc.Save(@"C:\temp\student.xml");
            }
            else
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Students",
                    new XElement("Student",
                        new XElement("Id", txt_id.Text),
                        new XElement("IsActive", chk_isactive.Checked),
                        new XElement("DateIs", dtp_dateis.Value),
                        new XElement("Name", txt_Name.Text),
                        new XElement("Marks", txt_Marks.Text)
                    )
                    )
                    );
                doc.Save(@"C:\temp\student.xml");
            }
        }
    }
}
