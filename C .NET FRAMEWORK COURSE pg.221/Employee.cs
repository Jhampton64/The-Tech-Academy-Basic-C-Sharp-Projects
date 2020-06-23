﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._221
{
    class Employee
    {
        public int id;
        public string name;
        public Employee() : this(0, "") { }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Employee(int id) : this(id, "") { }
        public Employee(string name) : this(0, name) { }
    }
}
