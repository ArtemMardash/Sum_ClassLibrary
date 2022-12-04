using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_ClassLibrary
{
    public class Class1
    {
        public string summ(int a, int b)
        {
            try
            {
                if (a > b)
                {
                    return "b must be more or equal than a";
                }
                else
                {
                    int sum = 0;
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                    return sum.ToString();
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        public string Multiply(int c, int d)
        {
            try
            {
                int mult = 1;
                if (c > d)
                {
                    return "d must be more than c";
                }
                else
                {
                    for (int i = c; i <= d; i++)
                    {
                        mult *= i;
                    }
                    return mult.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string srArf(int a, int b)
        {
            try
            {
                int count = 0;
                int sum = 0;
                if (a > b)
                {
                    return "b must be more than a";
                }
                else
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                        count++;
                    }
                    double result = (double)sum / (double) count;
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string SumOfCube(int a, int b)
        {
            try
            {
                double sum = 0;
                if (a > b)
                {
                    return "b must be more than a";
                }
                else
                {
                    for(int i = a; i <= b; i++)
                    {
                        sum += Math.Pow(i, 3);
                    }
                    return sum.ToString();
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string SumOfQuadrt(int a, int b)
        {
            try
            {
                double sum = 0;
                if (a > b)
                {
                    return "b must be more than a";
                }
                else
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += Math.Pow(i, 2);
                    }
                    return sum.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
