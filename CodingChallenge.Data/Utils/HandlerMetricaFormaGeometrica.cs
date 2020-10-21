namespace CodingChallenge.Data.Classes
{
    public class HandlerMetricaFormaGeometrica
    {
        public int Cuadrados { get; set; }
        public int Circulos { get; set; }
        public int Triangulos { get; set; }
        public int Trapecio { get; set; }

        public decimal AreaCuadrados { get; set; }
        public decimal AreaCirculos { get; set; }
        public decimal AreaTriangulos { get; set; }
        public decimal AreaTrapecio { get; set; }

        public decimal PerimetroCuadrados { get; set; }
        public decimal PerimetroCirculos { get; set; }
        public decimal PerimetroTriangulos { get; set; }
        public decimal PerimetroTrapecio { get; set; }


        public void AcumularMetricasPorFormaGeometrica(FormasGeometricas formaGeometrica, decimal area, decimal perimetro)
        {
            switch (formaGeometrica)
            {
                case FormasGeometricas.Circulo:
                    AcumularMetricasCirculo(area, perimetro);
                    break;
                case FormasGeometricas.Cuadrado:
                    AcumularMetricasCuadrado(area, perimetro);
                    break;
                case FormasGeometricas.Trapecio:
                    AcumularMetricasTrapecio(area, perimetro);
                    break;
                case FormasGeometricas.TrianguloEquilatero:
                    AcumularMetricasTriangulo(area, perimetro);
                    break;
            }
        }

        private void AcumularMetricasCuadrado(decimal areaCuadrado, decimal perimetroCuadrado)
        {
            Cuadrados++;
            AreaCuadrados += areaCuadrado;
            PerimetroCuadrados += perimetroCuadrado;
        }

        private void AcumularMetricasCirculo(decimal areaCirculo, decimal perimetroCirculo)
        {
            Circulos++;
            AreaCirculos += areaCirculo;
            PerimetroCirculos += perimetroCirculo;
        }

        private void AcumularMetricasTriangulo(decimal areaTriangulo, decimal perimetroTriangulo)
        {
            Triangulos++;
            AreaTriangulos += areaTriangulo;
            PerimetroTriangulos += perimetroTriangulo;
        }

        private void AcumularMetricasTrapecio(decimal areaTrapecio, decimal perimetroTrapecio)
        {
            Trapecio++;
            AreaTrapecio += areaTrapecio;
            PerimetroTrapecio += perimetroTrapecio;
        }
    }
}
