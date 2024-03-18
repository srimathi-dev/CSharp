using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advanced
{
    public abstract class Teacher
    {
        public abstract string TeacherName { get; }
        public abstract string Description { get; }
        public abstract void SchoolDetails();
    }
}
