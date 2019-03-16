using System;
using System.Collections.Generic;

namespace T3.Logic
{
    public class SparseMatrix
    {

        public int size { get; private set; }
        public List<List<(double value, int column)>> matrix { get; set; }
        public List<double> vector { get; private set; }
        public (Boolean valid,int line) invalidMatrix { get; private set; }


        public SparseMatrix(int n)
        {
            size = n;
            initMatrix();
            vector = new List<double>();
        }

        public SparseMatrix(string path)
        {
            vector = new List<double>();
            readFile(path);
            sortLines();
            checkNullElements();
        }

        public void checkMatrix()
        {
            checkNullElements();
        }

        public static SparseMatrix operator +(SparseMatrix M1, SparseMatrix M2)
        {
            SparseMatrix M3 = new SparseMatrix(M1.size);

            for (int j = 0; j < M1.size; j++)
            {
                int im1 = 0, im2 = 0;
                while(true)
                {
                    if (M1[j, im1].column < M2.matrix[j][im2].column)
                    {
                        M3.matrix[j].Add(M1[j, im1]);
                        im1++;
                    }
                    else if (M1[j, im1].column == M2.matrix[j][im2].column)
                    {
                        M3.matrix[j].Add((M1[j, im1].value + M2[j, im2].value, M1[j, im1].column));
                        im1++; im2++;
                    }
                    else
                    {
                        M3.matrix[j].Add(M2[j, im2]);
                        im2++;
                    }
                    if (im1 >= M1.matrix[j].Count || im2 >= M2.matrix[j].Count) break;
                }

                if(im1 < M1.matrix[j].Count)
                {
                    for (; im1 < M1.matrix[j].Count; im1++)
                    {
                        M3.matrix[j].Add(M1[j, im1]);
                    }
                }
                if (im2 < M2.matrix[j].Count)
                {
                    for (; im2 < M2.matrix[j].Count; im2++)
                    {
                        M3.matrix[j].Add(M2[j, im2]);
                    }
                }
            }

            return M3;
        }

        public (double value,int column) this[int i,int j]
        {
            get
            {
                return matrix[i][j];
            }
        }

        public string getString()
        {
            List<string> result = new List<string>();
            int index = 0;

            result.Add("" + size);
            result.Add("\n");

            foreach (var line in matrix)
            {
                foreach (var tuple in line)
                {
                    result.Add(String.Format("{0},  {1},  {2}", tuple.value, index, tuple.column));
                }
                index++;
            }
            return String.Join("\n", result);
        }

        private void readFile(string path)
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
                        size = (int)Decimal.Parse(line);
                        initMatrix();
                    }
                    if (i == 1) // add values and look for same i,j
                    {
                        Boolean succes = false;
                        var rawLine = line.Replace(",", "").Split(' ');
                        var materialisedLine = (value: double.Parse(rawLine[0]), column: int.Parse(rawLine[2]));
                        var lineIndex = int.Parse(rawLine[1]);

                        for (int j = 0; j < matrix[lineIndex].Count; j++)
                        {
                            if (matrix[lineIndex][j].column == materialisedLine.column)
                            {
                                matrix[lineIndex][j] = (matrix[lineIndex][j].value + materialisedLine.value, matrix[lineIndex][j].column);
                                succes = true;
                                break;
                            }
                        }
                        if (!succes)
                        {
                            matrix[lineIndex].Add(materialisedLine);
                        }
                    }
                    if (i == 2) // add vector elements
                    {
                        vector.Add(Double.Parse(line));
                    }

                }
            }
        }

        private void sortLines() // sort column elements by index
        {
            for (int j = 0; j < matrix.Count; j++)
            {
                matrix[j].Sort((c1, c2) => c1.column.CompareTo(c2.column));
            }
        }

        private void checkNullElements()
        {
            invalidMatrix = (false, 0);
            int index = 0;
            foreach (var line in matrix)
            {
                if (line.Count > 12)
                {
                    invalidMatrix = (true, index);
                    index++;
                    break;
                }
            }
        }

        private void initMatrix()
        {
            matrix = new List<List<(double value, int column)>>();
            for (int j = 0; j < size; j++)
            {
                matrix.Add(new List<(double value, int column)>());
            }
        }
    }
}
