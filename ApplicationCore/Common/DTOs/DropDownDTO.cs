﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDTOs
{
    public class DropDownDTO<T> where T : class
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
