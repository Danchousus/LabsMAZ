using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMAZ
{
    public class LinCode5_2 : IShift
    {
        public LinCode5_2() { }

        int[,] ReadMatrix = new int[,]
        {
            {1,0,1,1,1 },
            {0,1,0,1, 1 }
        };
        int[,] ToSindrom = new int[,]
        {
            {1,0,1,0,0 },
            {1,1,0,1,0 },
            {1,1,0,0,1 }
        };
        int[,] Smeznosti = new int[,]
        {
            {0,0,0,0,0 },
            {1,0,0,0,0 },
            {0,1,0,0,0 },
            {0,0,1,0,0 },
            {0,0,0,1,0 },
            {0,0,0,0,1 },
            {1,0,0,0,1 },
            {1,0,0,1,0 },
        };
        int[,] Sindroms;
        public int[] Method(int a, int b)
        {
            Sindroms = new int[8, 3];
            for (int i = 0; i < 8; i++)
            {
                int[] current = new int[3];
                for (int j = 0; j < 5; j++)
                {
                    if (Smeznosti[i,j] == 1)
                    {
                        for (int k = 0;k < 3; k++)
                        {
                            current[k] += ToSindrom[k,j];
                        }
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    Sindroms[i,j] = current[j] % 2;
                }
            }

            int[] code = new int[5];
            for (int i = 0; i < 5; i++)
            {
                code[i] = (a * ReadMatrix[0,i] + b * ReadMatrix[1,i]) % 2;
            }

            return code;
        }
        public int[] FixCode(int[] code)
        {
            int[] curSindrom = new int[3];
            for (int j = 0; j < 5; j++)
            {
                if (code[j] == 1)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        curSindrom[k] += ToSindrom[k, j];
                    }
                }
            }
            for (int j = 0; j < 3; j++)
            {
                curSindrom[j] = curSindrom[j] % 2;
            }

            int indexCurrent = -1;
            for (int i = 0; i < 8; i++)
            {
                bool Equals = true;
                for (int j = 0; j < 3; j++)
                {
                    if (curSindrom[j] != Sindroms[i, j])
                    {
                        Equals = false;
                        break;
                    }
                }
                if (Equals)
                {
                    indexCurrent = i;
                    break;
                }
            }

            int[] oshibka = new int[5];
            for (int i = 0; i < 5; i++)
            {
                oshibka[i] = Smeznosti[indexCurrent, i];
            }

            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                result[i] = code[i] - oshibka[i];
                if (result[i] < 0) result[i] += 2;
            }

            return result;
        }

        public void Codirov(string Text, out string zacodirText, out Dictionary<string, string> Diction, out int WeightZacodirText)
        {
            string[] ints = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] result = Method(int.Parse(ints[0]), int.Parse(ints[1]));
            zacodirText = "";
            foreach (var v in result)
            {
                zacodirText += $"{v} ";
            }
            Diction = new Dictionary<string, string>();
            WeightZacodirText = result.Length;
        }

        public void Decodirov(string zacodirText, Dictionary<string, string> Diction, out string Text)
        {
            string[] ints = zacodirText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] ints1 = new int[ints.Length];
            for (int i = 0; i < ints.Length; i++)
                ints1[i] = int.Parse(ints[i]);

            int[] result = FixCode(ints1);
            Text = "";
            foreach (var v in result)
            {
                Text += $"{v} ";
            }
        }
    }
}