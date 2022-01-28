using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel05
{
    public class StudentPublisher
    {
        public event StudentDelegate StudentHandler;

        public void StudentRises(Student student)
        {
            Student sa = new Student();
            sa.Id = student.Id;
            sa.Name = student.Name;
            sa.DateIs = student.DateIs;
            sa.IsActive = student.IsActive;
            sa.Marks = student.Marks;

            StudentHandler?.Invoke(sa);
        }
    }
}
