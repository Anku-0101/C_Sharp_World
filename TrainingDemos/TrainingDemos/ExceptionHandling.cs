using System;
namespace TrainingDemos
{
    public class ExceptionHandling
    {
        int[] arr;
        private void InitializeArray(int length)
        {
            arr = new int[length];

            for(int i =0; i <= length; i++)
            {
                arr[i] = (i * i)/(i-1);
            }
        }

        public void ExceptionDemo()
        {
            try
            {
                InitializeArray(5);
            }
            

            catch (IndexOutOfRangeException exp)
            {
                Console.WriteLine("Catching specific exception" + " " + exp.Message);
            }
            /*
            catch(DivideByZeroException exp)
            {
                Console.WriteLine("catching specific exception" + " "+ exp.Message);
            }*/
            catch (Exception e)
            {
                Console.WriteLine("Catching any exception that may have occured" + " " + e.Message);
            }


            finally
            {
                Console.WriteLine("Array initialization is completed");
            }

        }
    }
}

