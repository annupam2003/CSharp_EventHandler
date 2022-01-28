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
    public partial class Form1 : Form
    {
        FrmStudent frm = null;
        List <Student> students = null;
        StudentPublisher studentPublisher=null;
        public static Student student { get; set; }
        public Form1()
        {
            InitializeComponent();

            studentPublisher = new StudentPublisher();
            frm = new FrmStudent();
            studentPublisher.StudentHandler += frm.GenrateXml;
            studentPublisher.StudentHandler += GetData;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData(new Student());
        }
        void GetData(Student student)
        {
            if (File.Exists(@"C:\temp\student.xml"))
            {
                students = (from std in XDocument.Load(@"C:\temp\student.xml")
                             .Descendants("Student")
                            select new Student
                            {
                                Id = Convert.ToInt32(std.Element("Id").Value),
                                IsActive = Convert.ToBoolean(std.Element("IsActive").Value),
                                DateIs = Convert.ToDateTime(std.Element("DateIs").Value),
                                Name = Convert.ToString(std.Element("Name").Value),
                                Marks = Convert.ToDecimal(std.Element("Marks").Value)
                            }).ToList();
            }
            dgv_load();
        }

        void dgv_load()
        {
            if (students != null && students.Count > 0)
            {
                dgv_Show.AutoGenerateColumns = false;
                dgv_Show.DataSource = students;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (student != null)
            {
                studentPublisher?.StudentRises(student);
                student = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
