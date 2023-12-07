using StatisticsCalculator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StatisticsCalculatorTests
{
    public class GetMedianaUnitTests
    {
        /*
         Enunciado
 Escribir un programa que implemente una calculadora de estad�sticas b�sicas para una lista de n�meros. Deber�s proporcionar funciones que calculen la media, la mediana y la moda de una lista de n�meros.

 A continuaci�n, se detalla c�mo calcular cada una de estas estad�sticas:

 Media (Promedio):
 La media aritm�tica es el promedio de todos los n�meros en la lista. Para calcularla, sumar�s todos los n�meros en la lista y dividir�s esa suma por la cantidad total de n�meros en la lista.

 Mediana:
 La mediana es el valor que se encuentra en el medio de la lista cuando los n�meros est�n ordenados de menor a mayor. Para calcularla, primero ordenar�s la lista y luego, si la cantidad de n�meros en la lista es impar, tomar�s el valor en el medio. Si la cantidad es par, tomar�s el promedio de los dos valores del medio.

 Moda:
 La moda es el valor (o valores) que m�s se repite en la lista. Para calcularla, contar�s cu�ntas veces aparece cada n�mero en la lista y encontrar�s el n�mero o n�meros que tienen la mayor frecuencia de aparici�n.

 Reto adicional
 Agregar testing al programa/script

 Resultado esperado
 Partiendo de una lista/array inicial:

 const numberList = [1, 2, 3, 4, 5];

 Si llamo a la funci�n getMedia(numberList), el resultado esperado, seg�n los c�lculos explicados, debe ser 3.

 Si llamo a la funci�n getMediana(numberList), el resultado esperado, seg�n los c�lculos explicados, debe ser 3.

 Si llamo a la funci�n getModa(numberList), el resultado esperado, seg�n los c�lculos explicados, debe ser [1,2,3,4,5] dado que ning�n valor se repite m�s de una vez.


        Tests getMedia

        [1, 2, 3, 4, 5] -> 3
        [1, 2] -> 3/2
        [1] -> 1
        [] or null -> argument exception
         */



        [Test]
        public void GetMediana_WhenCalledNullValue_ReturnException()
        {
            Assert.Throws<ArgumentNullException>(() => StatiticsCaluculator.GetMediana(null));
        }

        [Test]
        public void GetMediana_WhenCalledEmptyList_ReturnException()
        {
            List<int> numbers = new List<int>();

            Assert.Throws<ArgumentOutOfRangeException>(() => StatiticsCaluculator.GetMediana(numbers));
        }

        [TestCase]
        public void GetMediana_WhenCalled_ReturnCorrectValue()
        {
            List<int> numbers = new List<int>() { 1 };

            int expectValue = 1;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 1, 3 };
            expectValue = 2;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));
            
            numbers = new List<int>() { 1, 2, 3, 4, 5 };
            expectValue = 3;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));
           
            numbers = new List<int>() { 0, 1, 3, 2, 1, 1, 0, 0 };
            expectValue = 1;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 15, 8, 12, 5 };
            expectValue = 10;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 1, 2 };
            expectValue = 1;
            Assert.That(StatiticsCaluculator.GetMediana(numbers), Is.EqualTo(expectValue));


        }

    }
}