using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyAspNet.Models
{
    public class Department
    {
        public int Ide { get; set; }
        public string Name { get; set; }
        public int Id { get; internal set; }
    }
}
