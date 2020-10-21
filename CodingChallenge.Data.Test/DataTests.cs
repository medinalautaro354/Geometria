using NUnit.Framework;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Utils;

namespace CodingChallenge.Data.Test
{
    public class DataTests
    {

        [Test]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                HandlerReporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Castellano));
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                HandlerReporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Ingles));
        }

        [Test]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista de formulários vazios!</h1>",
                HandlerReporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Portugues));
        }

        [Test]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormasGeometricas.Cuadrado, 5) };

            var resumen = HandlerReporte.Imprimir(cuadrados, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [Test]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormasGeometricas.Cuadrado, 5),
                new FormaGeometrica(FormasGeometricas.Cuadrado, 1),
                new FormaGeometrica(FormasGeometricas.Cuadrado, 3)
            };

            var resumen = HandlerReporte.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [Test]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormasGeometricas.Cuadrado, 5),
                new FormaGeometrica(FormasGeometricas.Circulo, 3),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4),
                new FormaGeometrica(FormasGeometricas.Cuadrado, 2),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 9),
                new FormaGeometrica(FormasGeometricas.Circulo, 2.75m),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4.2m),
                new FormaGeometrica(FormasGeometricas.Trapecio, 2, 3, 4 ,5)
            };

            var resumen = HandlerReporte.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapeze | Area 10 | Perimeter 14 <br/>TOTAL:<br/>8 shapes Perimeter 111,66 Area 101,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormasGeometricas.Cuadrado, 5),
                new FormaGeometrica(FormasGeometricas.Circulo, 3),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4),
                new FormaGeometrica(FormasGeometricas.Cuadrado, 2),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 9),
                new FormaGeometrica(FormasGeometricas.Circulo, 2.75m),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4.2m),
                new FormaGeometrica(FormasGeometricas.Trapecio, 2, 3, 4 ,5)

            };

            var resumen = HandlerReporte.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapecio | Area 10 | Perimetro 14 <br/>TOTAL:<br/>8 formas Perimetro 111,66 Area 101,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortugues()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormasGeometricas.Cuadrado, 5),
                new FormaGeometrica(FormasGeometricas.Circulo, 3),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4),
                new FormaGeometrica(FormasGeometricas.Cuadrado, 2),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 9),
                new FormaGeometrica(FormasGeometricas.Circulo, 2.75m),
                new FormaGeometrica(FormasGeometricas.TrianguloEquilatero, 4.2m),
                new FormaGeometrica(FormasGeometricas.Trapecio, 2, 3, 4 ,5)

            };

            var resumen = HandlerReporte.Imprimir(formas, Idiomas.Portugues);

            Assert.AreEqual(
                "<h1>Relatório de Formulários</h1>2 Quadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triângulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapézio | Area 10 | Perimetro 14 <br/>TOTAL:<br/>8 formas Perimetro 111,66 Area 101,65",
                resumen);
        }
    }
}