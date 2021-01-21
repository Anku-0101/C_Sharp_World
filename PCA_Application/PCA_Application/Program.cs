using Agilent.MHDA.Dataset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCA_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //InputDataSet inputDataSet = new InputDataSet();
            //inputDataSet.PCAMethod();

            List<string> list = new List<string>();
            list.Add("AMAN");
            list.Add("SOHAN");
            list.Add("KARTIK");
            list.Add("KARTIK");
            list.Add("SOHAN");
            list.Add("SOHAN");
            list.Add("SOHAN");

            //foreach(string str in list)
            //{
            //    Console.WriteLine(str);
            //}

            IDataset dataset;
            IColumn sample, column1, column2, column3;
            string[] Sdata = { "S1", "S2", "S3", "S4", "S5" };
            string[] c1 = { "C", "N", "C", "C", "N" };
            string[] c2 = { "10", "10", "15", "10", "15"};
            string[] c3 = { "Air", "Water", "Air", "Air", "Water" };

            sample = ColumnFactory.CreateStringColumn("sample", Sdata);
            column1 = ColumnFactory.CreateStringColumn("Virus", c1);
            ColumnMetaData columnMetaData = new ColumnMetaData();
            columnMetaData.SetSource("ABC");
            column1.SetMetaData(columnMetaData);

            column2 = ColumnFactory.CreateStringColumn("Age", c2);
            column3 = ColumnFactory.CreateStringColumn("Mode", c3);

            IColumn[] columns = { sample, column1, column2, column3 };
            dataset = DatasetFactory.CreateDataset("Experiment1", columns);
            
            for(int i = 0; i < dataset.GetColumnCount(); i++)
            {
                IColumn col = dataset.GetColumn(i);
                Console.WriteLine(col.GetName());
                for (int j = 0; j < col.GetSize(); j++)
                {
                    Console.WriteLine(col.Get(j));
                }
                
            }
            
            Program program = new Program();
            List<string> vs_ = new List<string>();
            vs_.Add("Virus");
            vs_.Add("Age");
            vs_.Add("Mode");
            Console.WriteLine("PRINTING META DATA INFO  --- ");
            var val = column1.GetMetaData();
            var val1 = val.GetSource();
            Console.WriteLine(val1);
            Console.WriteLine("SEE THE ABOVE LINE FOR OP");


            program.DOMethod(vs_, dataset);
            
               
            Console.ReadKey();
        }

        public void DOMethod(List<string> parameters, IDataset dataset)
        {

            int n = parameters.Count;
            int rowCount = dataset.GetRowCount();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            
            for(int i = 0; i < rowCount; i++)
            {
                string str = "";
                for (int j = 0; j < n; j++)
                {
                    str += dataset.GetColumn(parameters[j]).Get(i);
                    str += ",";

                }
                str += "\b";

                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, new List<string>());
                    dict[str].Add(dataset.GetColumn(0).Get(i) + "");
                }
                else
                {
                    dict[str].Add(dataset.GetColumn(0).Get(i) + "");
                }
                
            }

            foreach(KeyValuePair<string,List<string>> ele in dict)
            {
                Console.WriteLine(ele.Key + " -> "); 
                foreach(string s in ele.Value)
                {
                    Console.WriteLine(s);
                }
            }

            
        }
        public List<string> GetSources(IDataset dataset)
        {
            IColumn sourcesColumn = dataset.GetColumn(0);
            string[] sources = DatasetUtil.GetStringArray(sourcesColumn);
            List<string> retval = new List<string>();

            foreach (string source in sources)
                retval.Add(source);

            return retval;
        }

        public List<string> GetParamValues(string parameterName, IDataset dataset)
        {
            IColumn parameterColumn = dataset.GetColumn(parameterName);
            if (parameterColumn == null) return new List<string>();

            List<string> values = new List<string>();
            for (int i = 0; i < parameterColumn.GetSize(); i++)
            {
                values.Add(parameterColumn.Get(i).ToString());
            }
            return values;
        }

        public string GetValue(string sourceName, string parameterName, IDataset dataset)
        {
            IColumn parameterColumn = dataset.GetColumn(parameterName);

            if (parameterColumn == null)
                return null;

            IColumn sourcesColumn = dataset.GetColumn(0);

            for (int i = 0; i < sourcesColumn.GetSize(); i++)
            {
                object source = sourcesColumn.Get(i);
                if (source.Equals(sourceName))
                    return parameterColumn.IsMissingValue(i) ? null : parameterColumn.Get(i).ToString();
            }

            return null;
        }
    }
}
