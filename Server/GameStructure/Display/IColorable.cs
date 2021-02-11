using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStructure.Interfaces
{
    public interface IColorable
    {
        public void SetColor(string hex) {
            hex = hex.ToLower();
            if (hex.Length != 9 || hex[0] != '#') 
                throw new Exception("Not a valid ARGB string!");
            for (int i = 1; i <=9; i++) {
                if (hex[i] > 'f' || hex[i] < '0')
                    throw new Exception("Not a valid ARGB string!");
            }
            ColorString = hex;
        }

        public string ColorString { get; protected set; }
    }
}
