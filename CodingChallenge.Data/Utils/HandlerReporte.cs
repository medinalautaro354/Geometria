using CodingChallenge.Data.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Utils
{
    public class HandlerReporte
    {
        //private readonly Idiomas _idioma;

        //public HandlerReporte(Idiomas idioma)
        //{
        //    this._idioma = idioma;
        //}

        public static string Imprimir(List<FormaGeometrica> formas, Idiomas idioma)
        {
            var sb = new StringBuilder();
            var metricasFormasGeometricas = new HandlerMetricaFormaGeometrica();

            if (!formas.Any())
            {
                sb.Append(HandlerTraductor.DevolverMensajeListaVaciaPorIdioma(idioma));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(HandlerTraductor.DevolverHeaderPorIdioma(idioma));

                for (var i = 0; i < formas.Count; i++)
                {
                    metricasFormasGeometricas.AcumularMetricasPorFormaGeometrica(formas[i].TipoDeFormaGeometrica, formas[i].CalcularArea(), formas[i].CalcularPerimetro());
                }

                sb.Append(ObtenerLinea(metricasFormasGeometricas.Cuadrados, metricasFormasGeometricas.AreaCuadrados, metricasFormasGeometricas.PerimetroCuadrados, FormasGeometricas.Cuadrado, idioma));
                sb.Append(ObtenerLinea(metricasFormasGeometricas.Circulos, metricasFormasGeometricas.AreaCirculos, metricasFormasGeometricas.PerimetroCirculos, FormasGeometricas.Circulo, idioma));
                sb.Append(ObtenerLinea(metricasFormasGeometricas.Triangulos, metricasFormasGeometricas.AreaTriangulos, metricasFormasGeometricas.PerimetroTriangulos, FormasGeometricas.TrianguloEquilatero, idioma));
                sb.Append(ObtenerLinea(metricasFormasGeometricas.Trapecio, metricasFormasGeometricas.AreaTrapecio, metricasFormasGeometricas.PerimetroTrapecio, FormasGeometricas.Trapecio, idioma));


                // FOOTER
                HandlerTraductor.ArmarFooterPorIdioma(sb, metricasFormasGeometricas, idioma);
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormasGeometricas tipo, Idiomas idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Idiomas.Castellano)
                    return $"{cantidad} {HandlerTraductor.TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                if (idioma == Idiomas.Ingles)
                    return $"{cantidad} {HandlerTraductor.TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

                return $"{cantidad} {HandlerTraductor.TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
