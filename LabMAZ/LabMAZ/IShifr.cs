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
    class TestShifr : IShift
    {
        private int OpredelitWeight (int lengthBit)
        {
            int stepen = 1;
            while (Math.Pow(2, stepen) > lengthBit)
            {
                stepen++;
            }
            return stepen;
        }
        public void Codirov(string Text, out string zacodirText, out Dictionary<string, string> Diction, out int WeightZacodirText)
        {
            zacodirText = null;
            WeightZacodirText = 0;
            Diction = new Dictionary<string, string>();
            int index = 0;
            foreach (var v in Text.ToCharArray())
            {
                if (!Diction.ContainsValue(v.ToString()))
                {
                    Diction[index.ToString()] = v.ToString();
                    index++;
                }

                foreach (var pair in Diction)
                {
                    if (v.ToString() == pair.Value)
                    {
                        zacodirText += pair.Key;
                        break;
                    }
                }
            }
            WeightZacodirText += Diction.Count * OpredelitWeight(Diction.Count);
        }

        public void Decodirov(string zacodirText, Dictionary<string, string> Diction, out string Text)
        {
            Text = null;
            foreach (var v in zacodirText.ToCharArray())
            {
                if (Diction.ContainsKey(v.ToString()))
                {
                    Text += Diction[v.ToString()];
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
