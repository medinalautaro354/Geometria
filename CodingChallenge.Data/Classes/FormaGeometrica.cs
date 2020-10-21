/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;

namespace CodingChallenge.Data.Classes
{
    public enum FormasGeometricas
    {
        Cuadrado, TrianguloEquilatero, Circulo, Trapecio
    }

    public class FormaGeometrica
    {
        #region Formas

        public FormasGeometricas TipoDeFormaGeometrica { get; set; }

        #endregion

        private readonly decimal _lado;
        private readonly decimal? _altura;
        private readonly decimal? _anchoMayor;
        private readonly decimal? _ladoDiagonal;
        public FormaGeometrica(FormasGeometricas formaGeometrica, decimal ancho, decimal? anchoMayor = null, decimal? altura = null, decimal? ladoDiagonal = null)
        {
            this.TipoDeFormaGeometrica = formaGeometrica;
            this._lado = ancho;
            
            if(formaGeometrica == FormasGeometricas.Trapecio)
            {
                this._altura = altura ?? throw new ArgumentNullException(nameof(altura));
                this._anchoMayor = anchoMayor ?? throw new ArgumentException(nameof(anchoMayor));
                this._ladoDiagonal = ladoDiagonal ?? throw new ArgumentException(nameof(ladoDiagonal));
            }
        }

        public decimal CalcularArea()
        {
            switch (TipoDeFormaGeometrica)
            {
                case FormasGeometricas.Cuadrado: return _lado * _lado;
                case FormasGeometricas.Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case FormasGeometricas.TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                case FormasGeometricas.Trapecio: return ((_anchoMayor.Value + _lado) * _altura.Value) / 2;

                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (TipoDeFormaGeometrica)
            {
                case FormasGeometricas.Cuadrado: return _lado * 4;
                case FormasGeometricas.Circulo: return (decimal)Math.PI * _lado;
                case FormasGeometricas.TrianguloEquilatero: return _lado * 3;
                case FormasGeometricas.Trapecio: return _lado + _altura.Value + _anchoMayor.Value + _ladoDiagonal.Value;

                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
