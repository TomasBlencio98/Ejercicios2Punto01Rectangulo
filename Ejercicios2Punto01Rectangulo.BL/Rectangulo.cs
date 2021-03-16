using System;

namespace Ejercicios2Punto01Rectangulo.BL
{
    public class Rectangulo
    {
        public double LadoMayor { get; set; }
        public double LadoMenor { get; set; }

        public Rectangulo()
        {
                
        }
        public Rectangulo(double ladoMenor, double ladoMayor)
        {
            LadoMayor = ladoMayor;
            LadoMenor= ladoMenor;
        }

        public double GetPerimetro()
        {
            return LadoMayor * 2 + LadoMenor * 2;
        }
        public double GetSuperficie()
        {
            return LadoMayor * LadoMenor;
        }
    }
}
