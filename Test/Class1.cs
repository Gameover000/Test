namespace Test
{
    public class Class1
    {
        public double triangle(double a, double b, double c) // площадь треугольника
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Данного трегольника не существует!");
                return 0;
            }
            else
            {
                double PoluP = (a + b + c) / 2;
                return Math.Sqrt(PoluP * (PoluP - a) * (PoluP - b) * (PoluP - c));
            }
            
        }
        public double circle(double R) // площадь круга
        {
            return (R * R) * 3.14;
        }
        public bool prymougtriangle(double a, double b, double c) // проверка на прямоугольнсть треугольника
        {
            if(a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Данного трегольника не существует!");
                return false;
            }
            else
            {
                double f;
                if (a > b && a > c)
                {
                    f = a;
                    a = c;
                    c = f;

                }
                else if (b > a && b > c)
                {
                    f = b;
                    b = c;
                    c = f;
                }
                if (c * c == a * a + b * b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }


        //далее идет вычиление площади фигуры без знания типа фигуры
        public int figure(double[][] koor) //вводить нужно координаты углов. Пример:new double[][] { new double[] { 0.6, 2.1 }, new double[] { 1.8, 3.6 }, new double[] { 2.2, 2.3 }, new double[] { 3.6, 2.4 }, new double[] { 3.1, 0.5 } }
        {
            double S = 0;
            int i = 0;
            while(i != koor.Length)
            {
                if (i == koor.Length - 1)
                {
                    S += (koor[i][0] * koor[0][1]) - (koor[i][1] * koor[0][0]);
                    
                }
                else
                {
                    S += (koor[i][0] * koor[i + 1][1]) - (koor[i][1] * koor[i + 1][0]);
                    
                }
                if(S < 0)
                {
                    Console.WriteLine(-S/2);
                }
                else
                {
                    Console.WriteLine(S/2);
                }
                
                i++;
            }
            
            
            return 0;
        }

        
    }
    
}
