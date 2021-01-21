using Accord.Statistics.Analysis;
using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCA_Application_wpf
{
    class PCA_Application
    {
        string input = @"D:\Dec20\Input.csv";
        string output1UN = @"D:\Dec20\Output1.csv"; // When Number of Principle component isn't specified
        string output2S = @"D:\Dec20\Output2.csv"; // When number of principle component is specified
        string eigenValuesCSV = @"D:\Dec20\EigenValues.csv";
        string eigenVectorsCSV = @"D:\Dec20\EigenVectors.csv";


        // 1. Throw Warning saying "PCA Can't be computed" if number of rows in dataset is less than 2
        // 2. Take Number of Principal component as an input, If number of principal component is more than number of columns in the dataset then set number of components to number of columns 
        public void PCAMethod()
        {
            // Convert IDataset to double[][]
            // In Accord rows is treated as columns and columns as rows

            double[][] data = new double[100][];

            // Filling Data array with random double values
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                double[] inp = new double[30];

                for (int j = 0; j < 30; j++)
                {
                    inp[j] = 100 * r.NextDouble();
                }
                data[i] = inp;
            }

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[0].Length; j++)
                {
                    Console.Write(data[i][j]);
                }
                Console.WriteLine();
            }

            ExportCSV(input, data);

            var PCA = new PrincipalComponentAnalysis()
            {
                Method = PrincipalComponentMethod.Center,
                Whiten = true
            };

            MultivariateLinearRegression transform = PCA.Learn(data);

            double[][] output1 = PCA.Transform(data);
            int len = output1.Length;
            int len1 = output1[0].Length;

            Console.WriteLine("{0} {1} \n", len, len1);

            ExportCSV(output1UN, output1);

            PCA.NumberOfOutputs = 5;
            double[][] output2 = PCA.Transform(data);
            len = output2.Length;
            len1 = output2[0].Length;
            Console.WriteLine("{0} {1} \n", len, len1);
            ExportCSV(output2S, output2);


            double[][] eigenector = PCA.ComponentVectors;
            ExportCSV(eigenVectorsCSV, eigenector);

            double[] eigenValue = PCA.Eigenvalues;
            ExportCSV1D(eigenValuesCSV, eigenValue);



            Console.Read();
        }

        public static void ExportCSV(string filepath, double[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string txt = null;
                for (int j = 0; j < arr[0].Length; j++)
                {
                    txt += arr[i][j].ToString() + '\t';
                }
                txt += "\n";
                File.AppendAllText(filepath, txt);
            }
        }

        public static void ExportCSV1D(string filepath, double[] arr)
        {
            string txt1 = null;
            for (int j = 0; j < arr.Length; j++)
            {
                txt1 += arr[j].ToString() + '\t';
            }
            txt1 += "\n";
            File.AppendAllText(filepath, txt1);
        }
    }
}

