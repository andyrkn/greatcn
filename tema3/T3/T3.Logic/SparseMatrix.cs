using System;
using System.Collections.Generic;
using System.Linq;

namespace T3.Logic
{
    public class SparseMatrix
    {
        public int Size { get; private set; }
        public List<List<(double value, int column)>> Matrix { get; set; }
        public List<double> Vector { get; private set; }
        public (Boolean valid, String message) InvalidMatrix { get; private set; }

        public SparseMatrix(int n)
        {
            Size = n;
            InitMatrix();
            InvalidMatrix = (valid: true, message: "");
            Vector = new List<double>();
        }

        public SparseMatrix(string path)
        {
            Vector = new List<double>();
            ReadFile(path);
            SortLines();
            CheckNullElements();
        }

        public void checkMatrix()
        {
            CheckNullElements();
        }

        public static SparseMatrix operator +(SparseMatrix M1, SparseMatrix M2)
        {
            SparseMatrix M3 = new SparseMatrix(M1.Size);

            for (int j = 0; j < M1.Size; j++)
            {
                int im1 = 0, im2 = 0;
                while (true)
                {
                    if (M1[j, im1].column < M2.Matrix[j][im2].column)
                    {
                        M3.Matrix[j].Add(M1[j, im1]);
                        im1++;
                    }
                    else if (M1[j, im1].column == M2.Matrix[j][im2].column)
                    {
                        M3.Matrix[j].Add((M1[j, im1].value + M2[j, im2].value, M1[j, im1].column));
                        im1++; im2++;
                    }
                    else
                    {
                        M3.Matrix[j].Add(M2[j, im2]);
                        im2++;
                    }
                    if (im1 >= M1.Matrix[j].Count || im2 >= M2.Matrix[j].Count) break;
                }

                if (im1 < M1.Matrix[j].Count)
                {
                    for (; im1 < M1.Matrix[j].Count; im1++)
                    {
                        M3.Matrix[j].Add(M1[j, im1]);
                    }
                }
                if (im2 < M2.Matrix[j].Count)
                {
                    for (; im2 < M2.Matrix[j].Count; im2++)
                    {
                        M3.Matrix[j].Add(M2[j, im2]);
                    }
                }
            }

            return M3;
        }

        public static List<double> operator *(SparseMatrix M1, Vector X)
        {
            var result = new double[M1.Size];
            for (int line = 0; line < M1.Size; line++)
            {
                result[line] = 0;
                for (var col = 0; col < M1.Matrix[line].Count; col++)
                {
                    result[line] += X.XVector[M1[line, col].column] * M1[line, col].value;
                }
            }
            return result.ToList();
        }

        public static SparseMatrix operator *(SparseMatrix M1, SparseMatrix M2)
        {
            //var result = new SparseMatrix(M1.Size);
            //double aux;
            //for (int i = 0; i < M1.Size; i++)
            //{
            //    for (int j = 0; j < M1.Matrix[i].Count; j++)
            //    {
            //        aux = 0;
            //        for (int k = 0; k < M1.Matrix[i].Count; k++)
            //        {
            //            var col = M1[i, k].column;
            //            //double elm1 = M1[i, k].column ? M1[i, k].value : 0;
            //            aux += M1[i, col].value * M2[col, i].value;
            //        }
            //        result.Matrix[i].Add((aux, M1[i, j].column));
            //    }
            //}

            // 1 2 3  a 0 c x11 = 1*a + 2*d + 3*g
            // 4 5 6  d e f x12 = 1*0 + 2*e + 3*h
            // 7 8 9  g h i

            var result = new SparseMatrix(M1.Size);

            for(int i=0;i<M1.Size;i++)
            {
                for(int j=0;j<M1.Size;j++)
                {

                }
            }

            foreach (var line in M1.Matrix)
            {
                foreach(var cell in line)
                {
                    
                }
            }

            // for (var i = 0; i < M1.Size; i++)
            // {
            //     for(var j = 0; j < M2.Matrix[i].Count; j++)
            //     {
            //         var col = M2[i, j].column;
            //         var val = 0d;
            //         for (var k = 0; k < M1.Matrix[i].Count; k++)
            //         {
            //             val += M1[i, k].value * M2[k, col].value;
            //         }
            //         if (val > 0)
            //             result.Matrix[i].Add((val, col));
            //     }
            // }


            return result;
        }

        public (double value, int column) this[int i, int j]
        {
            get
            {
                if (j >= Matrix[i].Count)
                {
                    return (0, j);
                }

                return Matrix[i][j];
            }
        }

        public string GetString()
        {
            List<string> result = new List<string>();
            int index = 0;

            result.Add("" + Size);
            result.Add("\n");

            foreach (var line in Matrix)
            {
                foreach (var tuple in line)
                {
                    result.Add(String.Format("{0},  {1},  {2}", tuple.value, index, tuple.column));
                }
                index++;
            }
            return String.Join("\n", result);
        }

        private void ReadFile(string path)
        {
            int i = 0;
            string[] lines = System.IO.File.ReadAllLines(@path);
            foreach (string line in lines)
            {
                if (line == "") i++;
                else
                {
                    if (i == 0) // look for size and init matrix
                    {
                        Size = int.Parse(line);
                        InitMatrix();
                    }
                    if (i == 1) // add values and look for same i,j
                    {
                        Boolean succes = false;
                        var rawLine = line.Replace(",", "").Split(' ');
                        var materialisedLine = (value: double.Parse(rawLine[0]), column: int.Parse(rawLine[2]));
                        var lineIndex = int.Parse(rawLine[1]);

                        for (int j = 0; j < Matrix[lineIndex].Count; j++)
                        {
                            if (Matrix[lineIndex][j].column == materialisedLine.column)
                            {
                                Matrix[lineIndex][j] = (Matrix[lineIndex][j].value + materialisedLine.value, Matrix[lineIndex][j].column);
                                succes = true;
                                break;
                            }
                        }
                        if (!succes)
                        {
                            Matrix[lineIndex].Add(materialisedLine);
                        }
                    }
                    if (i == 2) // add vector elements
                    {
                        Vector.Add(Double.Parse(line));
                    }

                }
            }
        }

        private void SortLines() // sort columns by index
        {
            for (int j = 0; j < Matrix.Count; j++)
            {
                Matrix[j].Sort((c1, c2) => c1.column.CompareTo(c2.column));
            }
        }

        private void CheckNullElements()
        {
            InvalidMatrix = (true, "");
            int index = 0;
            foreach (var line in Matrix)
            {
                if (line.Count > 12)
                {
                    InvalidMatrix = (false, String.Format("Line {0}  with a count of {1}.", index, line.Count));
                    index++;
                    break;
                }
            }
        }

        private void InitMatrix()
        {
            Matrix = new List<List<(double value, int column)>>();
            for (int j = 0; j < Size; j++)
            {
                Matrix.Add(new List<(double value, int column)>());
            }
        }
    }
}
