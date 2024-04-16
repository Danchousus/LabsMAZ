using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LabMAZ
{
    public partial class Form1 : Form
    {
        public IShift[] Shifrs = new IShift[]
        {
            null, //хафмен
            new FanoShennon(), //Фано Шеннон
            new ArifmeticCodir(),
            new BWT_RLE(),
            new LZ77(), //ЛЗ77
            null, //хемминг
            null,  //лин код 5,2
            new TestShifr(),
        };
        public Form1()
        {
            InitializeComponent();
        }
        private string DictionaryToString(Dictionary<string, string> Slovar)
        {
            string retur = "";
            foreach (var v in Slovar)
            {
                retur += $"{v.Key}<=>{v.Value}$";
            }
            return retur;
        }
        private Dictionary<string, string> StringToDictionary(string Slovar)
        {
            Dictionary<string, string> retur = new Dictionary<string, string>();
            string[] PairKeyValue = Slovar.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in PairKeyValue)
            {
                if (pair.Contains("<=>"))
                {
                    string[] split = new string[] { "<=>" };
                    string[] keyValue = pair.Split(split, StringSplitOptions.RemoveEmptyEntries);
                    retur.Add(keyValue[0], keyValue[1]);
                }
            }
            return retur;
        }
        private void BtnZacodirov_Click(object sender, EventArgs e)
        {
            if (ComboVariantShifr.SelectedIndex != -1)
            {
                Shifrs[ComboVariantShifr.SelectedIndex].Codirov(TextDecodir.Text, out string Codir, out Dictionary<string, string> Slovar, out int WeightZacodirText);
                TextCodir.Text = Codir;
                TextSlovar.Text = DictionaryToString(Slovar);
                double k = Convert.ToDouble(TextDecodir.Text.Length * 8) / Convert.ToDouble(WeightZacodirText);
                MessageBox.Show($"Сжатие прошло успешно. Коэффициент сжатия = {k}");
            }
        }
        private void BtnDecodirov_Click(object sender, EventArgs e)
        {
            if (ComboVariantShifr.SelectedIndex != -1)
            {
                Shifrs[ComboVariantShifr.SelectedIndex].Decodirov(TextCodir.Text, StringToDictionary(TextSlovar.Text), out string Decodir);
                TextDecodir.Text = Decodir;
                MessageBox.Show("Расшифровка прошла успешно");
            }
        }
    }
}
