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
    }
}
