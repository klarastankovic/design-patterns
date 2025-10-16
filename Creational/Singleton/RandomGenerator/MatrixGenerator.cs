using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.RandomGenerator
{
    public class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private RandomGenerator generator;
        private MatrixGenerator()
        {
            generator = RandomGenerator.GetInstance();
        }
        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] GenerateMatrix(int rows, int columns)
        {
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[columns];
                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
