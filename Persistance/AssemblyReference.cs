﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class AssemblyReference
    {
        public static Assembly Assembly()
        {
            return typeof(Assembly).Assembly;
        }
    }
}
