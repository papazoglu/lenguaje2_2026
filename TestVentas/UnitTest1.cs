using Model;

namespace TestVentas
{
    public class UnitTest1
    {
        [Fact]
        public void pruebaResta()
        {
            // Arrange
            var socios1 = new Socios();

            int precio = 100;
            int cantidad = 3;

            // Act
            int resultado = socios1.Resta(precio, cantidad);

            // Assert
            Assert.Equal(97, resultado);
        }
        [Fact]
        public void pruebaResta2()
        {
            // Arrange
            var socios1 = new Socios();

            int precio = -2;
            int cantidad = -4;

            // Act
            int resultado = socios1.Resta(precio, cantidad);

            // Assert
            Assert.Equal(4, resultado);
        }

        //[Theory]
        [InlineData(100, 3, 97)]
        [InlineData(50, 20, 30)]
        [InlineData(10, 5, 5)]
        public void pruebaResta3(int numero1, int numero2, int esperado)
        {
            // Arrange
            var socios1 = new Socios();

            // Act
            int resultado = socios1.Resta(numero1, numero2);

            // Assert
            Assert.Equal(esperado, resultado);
        }


    }
}
