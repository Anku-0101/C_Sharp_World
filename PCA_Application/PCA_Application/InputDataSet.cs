using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Analysis;
using Accord.Statistics.Analysis.Base;
using Accord.Statistics.Models.Regression.Linear;

namespace PCA_Application
{
    class InputDataSet
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
            double[][] data = new double[30][];

            // Filling Data array with random double values
            for (int i = 0; i < 30; i++)
            {
                Random r = new Random();
                double[] inp = new double[100];

                for (int j = 0; j < 100; j++)
                {
                    inp[j] = 100 * r.NextDouble();
                }
                data[i] = inp;
            }

            for (int i = 0; i < 30; i++)
            {
                string txt = null;
                for (int j = 0; j < 100; j++)
                {
                    txt += data[i][j].ToString() + '\t';
                }
                txt += "\n";
                File.AppendAllText(input, txt);
            }

            // Only C
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
            
            for (int i = 0; i < len; i++)
            {
                string txt = null;
                for (int j = 0; j < len1; j++)
                {
                    txt += output1[i][j].ToString() + '\t';
                }
                txt += "\n";
                File.AppendAllText(output1UN, txt);
            }

            PCA.NumberOfOutputs = 5;
            double[][] output2 = PCA.Transform(data);
            len = output2.Length;
            len1 = output2[0].Length;
            Console.WriteLine("{0} {1} \n", len, len1);
            
            for (int i = 0; i < len; i++)
            {
                string txt = null;
                for (int j = 0; j < len1; j++)
                {
                    txt += data[i][j].ToString() + '\t';
                }
                txt += "\n"; 
                File.AppendAllText(output2S, txt);
            }

            double[][] eigenector = PCA.ComponentVectors;
            
            for (int i = 0; i < eigenector.Length; i++)
            {
                string txt = null;
                for (int j = 0; j < eigenector[0].Length; j++)
                {
                    txt += eigenector[i][j].ToString() + '\t';
                }
                txt += "\n";
                File.AppendAllText(eigenVectorsCSV, txt);
            }
            
            
            double[] eigenValue = PCA.Eigenvalues;
            string txt1 = null;
            for (int j = 0; j < eigenValue.Length; j++)
            {
                txt1 += eigenValue[j].ToString() + '\t';
            }
            txt1 += "\n";
            File.AppendAllText(eigenValuesCSV, txt1);


            Console.Read();
            //for (int i = 0; i < output1.Length; i++)
            //{
            //    string txt = null;
            //    for (int j = 0; j < 100; j++)
            //    {
            //        txt += data[i][j].ToString() + '\t';
            //    }
            //    txt += "\n";
            //    File.AppendAllText(input, txt);
            //}

        }
    }

    
}




//var method = PrincipalComponentMethod.Center;