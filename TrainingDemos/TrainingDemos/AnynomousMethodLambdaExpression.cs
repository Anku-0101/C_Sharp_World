using System;
namespace TrainingDemos
{
    delegate void Transform(int x);
    public class AnynomousMethodLambdaExpression
    {
        /// <summary>
        /// 
        /// </summary>
        public void AnynomousMethod()
        {
            Transform t;
            t = delegate (int x)
            {
                Console.WriteLine(x * x);
            };

            t += delegate (int x)
            {
                Console.WriteLine(x * x * x);
            };

            t.Invoke(5);
        }

        public void LambdaExpression()
        {
            //var res = (int x) => { Console.WriteLine(x * x); };
            //res.Invoke(3);

            //Transform t;

            //t =

            //t += (int x) => { Console.WriteLine(x * x * x); };

            //t.Invoke(6);
        }
    }
}

