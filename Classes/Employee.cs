﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    class Employee
    {
        public Employee()
        {

        }

        String _firstName;
        String _lastName;
        String _id;

        public String FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public String Lastname
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public String ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
