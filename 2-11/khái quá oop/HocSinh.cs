using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khái_quá_oop
{
    internal class HocSinh
    {
        // auto-implemented properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // phương thức toString để xuất giá trị
        public override string ToString()
        {
            return this.Name+ "\t" + this.Email + "\t" + this.Phone  ;

        }
    }
}
