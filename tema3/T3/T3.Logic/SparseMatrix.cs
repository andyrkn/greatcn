using System;
using System.Collections.Generic;

namespace T3.Logic
{
    public class SparseMatrix
    {

        private int size;
        private List<List<(double value, int column)>> matrix;
        private List<double> vector;
        public (Boolean valid,int line) invalidMatrix { get; private set; }

        public SparseMatrix(string path)
        {
            vector = new List<double>();
            readFile(path);
            checkNullElements();
        }

        private void checkNullElements()
        {
            invalidMatrix = (false, 0);
            int index = 0;
            foreach(var line in matrix)
            {
                if (line.Count > 12)
                {
                    index++;
                    invalidMatrix = (true, index);
                    break;
                }
            }
        }

        private void readFile(string path)
        {
            int i = 0;
            string[] lines = System.IO.File.ReadAllLines(@path);
            foreach(string line in lines)
            {
                if (line == "") i++;
                else
                {
                    if (i == 0) // look for size and init matrix
                    {
                        size = (int)Decimal.Parse(line);
                        matrix = new List<List<(double value, int column)>>();
                        for (int j = 0; j < size; j++)
                        {
                            matrix.Add(new List<(double value, int column)>());
                        }
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
    }
}
