using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometria;

namespace PruebasUnitariasGeometriaTests
{
    [TestClass]
    public class GeometriaTests
    {
        // Prueba para calcular el área de un cuadrado
        [TestMethod]
        public void CalcularAreaCuadrado_Lado_Valido()
        {
            // Arrange
            int ladoCuadrado = 4;
            int areaEsperada = 16;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.areacuadrado(ladoCuadrado);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un círculo
        [TestMethod]
        public void CalcularAreaCirculo_Radio_Valido()
        {
            // Arrange
            int radioCirculo = 5;
            double areaEsperada = Math.PI * Math.Pow(radioCirculo, 2);
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            double areaCalculada = geometria.areaCirculo(radioCirculo);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada, 0.001);
        }

        // Prueba para calcular el área de un triángulo
        [TestMethod]
        public void CalcularAreaTriangulo_BaseYAltura_Valido()
        {
            // Arrange
            int baseTriangulo = 6;
            int alturaTriangulo = 8;
            int areaEsperada = (baseTriangulo * alturaTriangulo) / 2;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.areatriangulo(baseTriangulo, alturaTriangulo);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un rectángulo
        [TestMethod]
        public void CalcularAreaRectangulo_BaseYAltura_Valido()
        {
            // Arrange
            int baseRectangulo = 6;
            int alturaRectangulo = 8;
            int areaEsperada = baseRectangulo * alturaRectangulo;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.arearectangulo(baseRectangulo, alturaRectangulo);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un pentágono
        [TestMethod]
        public void CalcularAreaPentagono_PerimetroYApotema_Valido()
        {
            // Arrange
            int perimetroPentagono = 20;
            int apotemaPentagono = 6;
            int areaEsperada = (perimetroPentagono * apotemaPentagono) / 2;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.areapentagono(perimetroPentagono, apotemaPentagono);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un rombo
        [TestMethod]
        public void CalcularAreaRombo_Diagonales_Valido()
        {
            // Arrange
            int diagonalMayor = 10;
            int diagonalMenor = 6;
            int areaEsperada = (diagonalMayor * diagonalMenor) / 2;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.arearombo(diagonalMayor, diagonalMenor);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un romboide
        [TestMethod]
        public void CalcularAreaRomboide_BaseYAltura_Valido()
        {
            // Arrange
            int baseRomboide = 8;
            int alturaRomboide = 12;
            int areaEsperada = baseRomboide * alturaRomboide;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.arearomboide(baseRomboide, alturaRomboide);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        // Prueba para calcular el área de un trapecio
        [TestMethod]
        public void CalcularAreaTrapecio_BasesYAltura_Valido()
        {
            // Arrange
            int baseMayor = 10;
            int baseMenor = 6;
            int alturaTrapecio = 4;
            int areaEsperada = ((baseMayor + baseMenor) / 2) * alturaTrapecio;
            Geometria.Geometria geometria = new Geometria.Geometria();

            // Act
            int areaCalculada = geometria.areatrapecio(baseMayor, baseMenor, alturaTrapecio);

            // Assert
            Assert.AreEqual(areaEsperada, areaCalculada);
        }
    }
}
