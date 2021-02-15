using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool valore=false;
            
            if (a!=0)
            {
                valore=true;
            }
            return valore;
        }
    }
}
