using CodingChallenge.Data.Classes;
using System;
using System.Text;

namespace CodingChallenge.Data.Utils
{
    public enum Idiomas
    {
        Castellano, Ingles, Portugues
    }
    public class HandlerTraductor
    {
        public static string DevolverMensajeListaVaciaPorIdioma(Idiomas idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "<h1>Lista vacía de formas!</h1>";
                case Idiomas.Ingles:
                    return "<h1>Empty list of shapes!</h1>";
                case Idiomas.Portugues:
                    return "<h1>Lista de formulários vazios!</h1>";

                default:
                    throw new ArgumentOutOfRangeException(nameof(idioma));
            }
        }

        public static string DevolverHeaderPorIdioma(Idiomas idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "<h1>Reporte de Formas</h1>";
                case Idiomas.Ingles:
                    return "<h1>Shapes report</h1>";
                case Idiomas.Portugues:
                    return "<h1>Relatório de Formulários</h1>";

                default:
                    throw new ArgumentOutOfRangeException(nameof(idioma));
            }
        }

        public static string TraducirForma(FormasGeometricas tipo, int cantidad, Idiomas idioma)
        {
            switch (tipo)
            {
                case FormasGeometricas.Cuadrado:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    if (idioma == Idiomas.Ingles) return cantidad == 1 ? "Square" : "Squares";
                    return cantidad == 1 ? "Quadrado" : "Quadrados";
                case FormasGeometricas.Circulo:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                    if (idioma == Idiomas.Ingles) return cantidad == 1 ? "Circle" : "Circles";
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case FormasGeometricas.TrianguloEquilatero:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    if (idioma == Idiomas.Ingles) return cantidad == 1 ? "Triangle" : "Triangles";
                    return cantidad == 1 ? "Triângulo" : "Triângulos";
                case FormasGeometricas.Trapecio:
                    if (idioma == Idiomas.Castellano) return cantidad == 1 ? "Trapecio" : "Trapecios";
                    if (idioma == Idiomas.Ingles) return cantidad == 1 ? "Trapeze" : "Trapezes";
                    return cantidad == 1 ? "Trapézio" : "Trapézios";
            }

            return string.Empty;
        }

        public static void ArmarFooterPorIdioma(StringBuilder stringBuilder, HandlerMetricaFormaGeometrica metricasFormasGeometricas, Idiomas idioma)
        {
            stringBuilder.Append("TOTAL:<br/>");
            stringBuilder.Append(metricasFormasGeometricas.Cuadrados + metricasFormasGeometricas.Circulos + metricasFormasGeometricas.Triangulos + metricasFormasGeometricas.Trapecio + " " + (idioma == Idiomas.Castellano || idioma == Idiomas.Portugues ? "formas" : "shapes") + " ");
            stringBuilder.Append((idioma == Idiomas.Castellano || idioma == Idiomas.Portugues ? "Perimetro " : "Perimeter ") + (metricasFormasGeometricas.PerimetroCuadrados + metricasFormasGeometricas.PerimetroTriangulos + metricasFormasGeometricas.PerimetroCirculos + metricasFormasGeometricas.PerimetroTrapecio).ToString("#.##") + " ");
            stringBuilder.Append("Area " + (metricasFormasGeometricas.AreaCuadrados + metricasFormasGeometricas.AreaCirculos + metricasFormasGeometricas.AreaTriangulos + metricasFormasGeometricas.AreaTrapecio).ToString("#.##"));
        }
    }
}
