using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMAZ
{
    public interface IShift
    {
        void Codirov(string Text, out string zacodirText, out Dictionary<string, string> Diction, out int WeightZacodirText);
        void Decodirov(string zacodirText, Dictionary<string, string> Diction, out string Text);
    }    
}
