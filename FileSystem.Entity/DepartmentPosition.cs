using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.Entity
{
    public class DepartmentPosition:BaseEntity
    {
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
    }
}
