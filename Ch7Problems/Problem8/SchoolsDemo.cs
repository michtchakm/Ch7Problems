using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem8
{
    class School
    {
        private string schoolname;
        private int enrollmentnumber;
        private double price;

        public string SchoolName
        {
            get
            {
                return schoolname;
            }
            set
            {
                schoolname = value;
            }
        }

        public int EnrollmentNumber
        {
            get
            {
                return enrollmentnumber;
            }
            set
            {
                enrollmentnumber = value;
            }
        }
    }
}
