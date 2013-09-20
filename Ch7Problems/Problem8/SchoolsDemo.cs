using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem8
{
    class School : IComparable
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
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            School temp = (School)o;
            if (this.EnrollmentNumber > temp.EnrollmentNumber)
                returnVal = 1;
            else
                if (this.EnrollmentNumber < temp.EnrollmentNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}
