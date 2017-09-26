using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Form
    {
        private string _brand, _wheels, _size;


        public string builder()
        {
            string brand = _brand;
            string wheels = _wheels;
            string size = _size;

            StringBuilder build = new StringBuilder();
            build.Append(brand + " " + wheels + " " + size);
            return build.ToString();
        }

        public string Wheels { get => _wheels; set => _wheels = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Size { get => _size; set => _size = value; }

    }
}
