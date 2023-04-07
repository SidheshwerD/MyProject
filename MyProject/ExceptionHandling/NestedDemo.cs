using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ExceptionHandling

{
    internal class NestedDemo
    {
        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                count++;
                try
                {

                    count++;
                    try
                    {

                        try
                        {
                            count++;
                            throw new Exception();
                        }
                        catch(Exception e)
                        {
                            count++;
                            throw new Exception();

                        }
                    }
                    catch(Exception e1)
                    {
                        count++;
                        throw new Exception();
                    }
                }
                catch(Exception e2)
                {
                    count++;
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}
