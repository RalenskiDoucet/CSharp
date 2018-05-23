using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
   public interface IStat
    {
        string Name { get; set; }
        string Discription { get; set; }
        int Value { get; set; }
        string ToString();
    }

   public interface IRace
    {
        string Name { get; set; }
        string Discription { get; set; }
        List<IStat> Stats { get; set; }
        string ToString();
    }
}
