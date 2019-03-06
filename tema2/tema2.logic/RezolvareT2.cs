using MathNet.Numerics.LinearAlgebra;
using System;

namespace tema2.logic
{
    public class RezolvareT2
    {

        public RezolvareT2(int n, int e)
        {
            SolX = new double[N];
            A = new double[n, n];
            Ainit = new double[n, n];
            N = n;
            Preciz = Math.Pow(10, -e);
            Decomposable = true;
            DivisionByZeroInSystem = false;
        }

        public int N { get; }
        public double Preciz { get; }
        public double[,] A { get; set; }
        public double[,] Ainit { get; set; }
        public double[] SolX { get; set; }
        public Boolean Decomposable { get; set; }
        public Boolean DivisionByZeroInSystem { get; set; }

        public string GetString(int m)
        {
            string result = "";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    result = result + (m == 1 ? A[i, j] : Ainit[i, j]) + " ";
                }
                result = result + "\n";
            }
            return result;
        }

        public double EuclideanNorm(double[] B)
        {
            double S = 0;
            double[] result = new double[N];
            //A* x - B
            for(int i = 0; i <N; i++)
            {
                for(int j = 0; j< N; j++)
                {
                    S += Ainit[i, j] * SolX[j];  
                }
                result[i] = S - B[i];
                S = 0;
            }
            S = 0;
            for(int i =0; i<N; i++)
            {
                S += result[i] * result[i];
            }
            S = Math.Sqrt(S);

            return S;
        }


        public Matrix<double> InveresedMatrix()
        {
            var M = Matrix<double>.Build;
            var res = M.DenseOfArray(Ainit).Inverse();
            return res;
        }

        public Vector<double> ComputeLibraryX(double[] B)
        {
            var matrix = Matrix<double>.Build.DenseOfArray(Ainit);
            var res = matrix.Solve(Vector<double>.Build.DenseOfArray(B));
            return res;
        }

        public double ComputeNorm2(double[] B)
        {
            var matrix = Matrix<double>.Build.DenseOfArray(Ainit).Inverse();
            var bVector = matrix.Solve(Vector<double>.Build.DenseOfArray(B));
            var multiplyRes = matrix.Multiply(bVector);
            double S = 0;
            for (int i = 0; i < N; i++)
            {
                S += (B[i] - multiplyRes[i]) * (B[i] - multiplyRes[i]);
            }
            S = Math.Sqrt(2);
            return S;
        }

        public double Determinant()
        {
            double S = 1;
            for(int i = 0; i < N; i++)
            {
                S *= A[i, i];
            }
            return S;
        }

        public double[] ComputeAxB(double[] b) // Ax = b
        {
            double[] SolY = new double[N];
            //Ly = b;
            //Ux = y;
            //return x;
            SolY = ComputeY(b);
            SolX = ComputeX(SolY);
            return SolX;
        }

        private double[] ComputeY(double[] b)
        {
            double[] Sol = new double[N];
            Sol[0] = b[0] / A[0, 0];

            for (int i = 1; i < N; i++)
            {
                Sol[i] = (b[i] - ComputeLowerLinearEc(i, Sol)) / A[i, i];
                if (Math.Abs(Sol[i]) < Preciz)
                    DivisionByZeroInSystem = true;
            }
            return Sol;
        }

        private double[] ComputeX(double[] y)
        {
            double[] Sol = new double[N];
            Sol[N - 1] = y[N - 1];

            for (int i = N - 2; i >= 0; i--)
            {
                Sol[i] = y[i] - ComputeUpperLinearEc(i, Sol);
                if (Math.Abs(Sol[i]) < Preciz)
                    DivisionByZeroInSystem = true;
            }
            return Sol;
        }

        private double ComputeLowerLinearEc(int index,double[] solutions)
        {
            double S = 0;
            for (int i = 0; i < index; i++)
            {
                S += A[index, i] * solutions[i];
            }
            return S;
        }

        private double ComputeUpperLinearEc(int index,double[] solutions)
        {
            double S = 0;
            for (int i = index; i < N; i++)
            {
                S += i == index ? solutions[i] : A[index, i] * solutions[i];
            }
            return S;
        }

        public void Decompose()
        {
            ComputeFirstLineAndDiagonal();
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    if (Math.Abs(A[i, i]) < Preciz) // division by 0
                    {
                        Decomposable = false;
                        return;
                    }
                    else
                    {
                        ComputeCell(i, j);
                    }
                }
            }
        }

        private void ComputeCell(int x, int y)
        {
            double S = 0;
            for (int i = 0; i <= x; i++)
            {
                S += y <= x ? i == y || i > y ? 0 : A[i, y] * A[x, i] : i == x || i > x ? 0 : A[i, y] * A[x, i];
            }
            A[x, y] = x >= y ? Ainit[x, y] - S : (Ainit[x, y] - S) / A[x, x];
        }
    
        private void ComputeFirstLineAndDiagonal()
        {
            for (int i = 1; i < N; i++)
            {
                A[0, i] = Ainit[0, i] / A[0, 0];
            }
        }
    }
}
