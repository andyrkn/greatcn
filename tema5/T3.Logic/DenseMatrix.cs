using CenterSpace.NMath.Core;
using CenterSpace.NMath.Matrix;

namespace T3.Logic
{
    public class DenseMatrix
    {
        public Vector Vector;
        public int Size;
        private readonly DoubleMatrix Matrix;
        private DoubleSVDecomp MatrixSVDecomp;

        public DenseMatrix(string path)
        {
            (Matrix, Size) = ReadMatrix(path);
            MatrixSVDecomp = null;
        }
        public DoubleSVDecomp SVDecomp()
        {
            if (MatrixSVDecomp == null)
            {
                var decompServer = new DoubleSVDecompServer
                {
                    ComputeLeftVectors = true,
                    ComputeRightVectors = true,
                    ComputeFull = true
                };
                MatrixSVDecomp = decompServer.GetDecomp(Matrix);
            }

            return MatrixSVDecomp;
        }

        public static uint Rank(DoubleVector values)
        {
            uint nr = 0;

            foreach (double x in values) { if (x > 0) { nr++; } }

            return nr;
        }
        public uint Rank()
        {
            return Rank(MatrixSVDecomp.SingularValues);
        }
        public static double ConditionalNumberFromSV(DoubleVector singularValues)
        {
            double max = singularValues[0];
            double min = double.MaxValue;
            for (int i = singularValues.Length - 1; i > 0; i--)
            {
                if (singularValues[i] > 0) { min = singularValues[i]; break; }
            }

            return max / min;
        }
        public double ConditionalNumberFromSV()
        {
            return ConditionalNumberFromSV(MatrixSVDecomp.SingularValues);
        }
        public DoubleMatrix PseudoMooreInverse()
        {
            var S = new DoubleMatrix(Size, Size, 0);
            int j = 0;
            for(int i = 0; i < MatrixSVDecomp.SingularValues.Length; i++)
            {
                if (MatrixSVDecomp.SingularValues[i] > 0) { S[j, j] = MatrixSVDecomp.SingularValues[i];j++; }
            }
            return MatrixSVDecomp.RightVectors * S * MatrixSVDecomp.LeftVectors.Transpose();
        }

        public DoubleVector Solve(DoubleVector v)
        {
            return NMathFunctions.Solve(Matrix, v);
        }

        public double ComputeNormAgainst(DoubleVector b,DoubleVector xRes)
        {
            return (new DoubleVector(b - NMathFunctions.Product(Matrix, xRes)).TwoNorm());
        }
        
        public double this[int i,int j]
        {
            get => Matrix[i, j];
            set => Matrix[i, j] = value;
        }
        private static (DoubleMatrix, int) ReadMatrix(string path)
        {
            uint i = 0, size = 0;
            string[] lines = System.IO.File.ReadAllLines(@path);
            double[,] matrix = new double[1, 1];

            foreach (var line in lines)
            {
                if (line == "") { i++; }
                else
                {
                    if (i == 0)
                    {
                        size = uint.Parse(line);
                        matrix = new double[size, size];
                    }
                    else if (i == 1)
                    {
                        var rawLine = line.Replace(" ", "").Replace(",", " ").Split(' ');
                        matrix[int.Parse(rawLine[1]), int.Parse(rawLine[2])] = double.Parse(rawLine[0]);
                    }
                }
            }
            return (new DoubleMatrix(matrix),(int)size);
        }
       
    }
}
