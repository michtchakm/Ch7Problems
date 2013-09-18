using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Friend
    {
        private string name;
        private int phonenumber;
        private int birthdayyear;
        private int birthdaymonth;
        private int birthdayday;
        public static string FriendList = "Name, Birthday Month and Year and Day, Phone Number";

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                name = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }
        public int BirthdayYear
        {
            get
            {
                return birthdayyear;
            }
            set
            {
                birthdayyear = value;
            }
        }
        public int BirthdayMonth
        {
            get
            {
                return birthdaymonth;
            }
            set
            {
                birthdaymonth = value;
            }

        }
             public int BirthdayDay
        {
            get
            {
                return birthdayday;
            }
            set
            {
                birthdayday = value;
            }
        }
    }
}
