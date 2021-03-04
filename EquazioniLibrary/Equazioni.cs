using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool valore = false;

            if (a != 0)
            {
                valore = true;
            }
            return valore;
        }
        public static bool IsInconsisted(double a,double b)
        {
            bool valore = false;
            if (a==0)
            {
                if(b!=0)
                {
                    valore = true;
                }
            }
            return valore;
        }
        public static bool IsDegree2(double a)
        {
            bool valore = false;
            if (a==0)
            {
                return valore;
            }
            else
            {
                valore = true;
                return valore;
            }
        }
        public static double Delta(double a ,double b,double c)
        {
            double delta=double.NaN;
           if (IsDegree2(a)==true)
           {
                 delta = (b * b) - (4 * a * c);
           }

           

            return delta;
        }
        public static string RisoluzioneEquazioneSecondoGrado(double a,double b,double c)
        {
            double delta;
           
                delta = Delta(a,b,c);
            if (delta == 0)
            {
                double x1 = -(b) / (2 * a);
                return $"una sola soluzione che è {x1}";
            }
            else if (delta < 0)
            {
                return $"nessuna soluzione, perché è impossibile";
            }
            else if (delta > 0)
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"due soluzioni che sono {X1} e {X2}";
            }
            else
            {
                return  "non eseguibile";
            }
           
        }
        public static string EquationDegree1(double a, double b)
        {
            if(IsDetermined(a))
            {
                double x = b / a;
                return $"la soluzione dell'equazione è {x}";
            }
            else if (IsInconsisted(a,b))
            {
                return "l'equazione è IMPOSSIBILE";
            }
            else
            {
                return "l'equazione è INDETERMINATA";
            }

        }
    }
}
