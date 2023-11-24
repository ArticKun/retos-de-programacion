using StatisticsCalculator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StatisticsCalculatorTests
{
    public class GetModaUnitTests
    {
        /*
         Enunciado
 Escribir un programa que implemente una calculadora de estad�sticas b�sicas para una lista de n�meros. Deber�s proporcionar funciones que calculen la media, la mediana y la moda de una lista de n�meros.

 Moda:
 La moda es el valor (o valores) que m�s se repite en la lista. Para calcularla, contar�s cu�ntas veces aparece cada n�mero en la lista y encontrar�s el n�mero o n�meros que tienen la mayor frecuencia de aparici�n.

 Reto adicional
 Agregar testing al programa/script

 Resultado esperado
 Partiendo de una lista/array inicial:

 const numberList = [1, 2, 3, 4, 5];

 Si llamo a la funci�n getModa(numberList), el resultado esperado, seg�n los c�lculos explicados, debe ser [1,2,3,4,5] dado que ning�n valor se repite m�s de una vez.


        Tests getModa

        [1, 2, 3, 4, 5] -> [1, 2, 3, 4, 5]
        [1, 2, 1] -> 1
        [0, 0, 1] -> 0
        [1] -> 1
        [] or null -> argument exception
         */



        [Test]
        public void GetModa_WhenCalledNullValue_ReturnException()
        {
            Assert.Throws<ArgumentNullException>(() => StatiticsCaluculator.GetModa(null));
        }

        [Test]
        public void GetModa_WhenCalledEmptyList_ReturnException()
        {
            List<int> numbers = new List<int>();

            Assert.Throws<ArgumentOutOfRangeException>(() => StatiticsCaluculator.GetModa(numbers));
        }

        [TestCase]
        public void GetModa_WhenCalled_ReturnCorrectValue()
        {
            List<int> numbers = new List<int>() { 1 };

            List<int> expectValue = new List<int>() { 1 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 1, 3 };
            expectValue = new List<int>() { 1, 3 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));
            
            numbers = new List<int>() { 1, 2, 3, 4, 5 };
            expectValue = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 0, 1, 3, 2, 1, 1, 0, 0 };
            expectValue = new List<int>() { 0, 1 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 5, 5, 8, 12, 15 };
            expectValue = new List<int>() { 5 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));

            numbers = new List<int>() { 5, 5, 8,8,9,9,9, 12, 15 };
            expectValue = new List<int>() { 9 };
            Assert.That(StatiticsCaluculator.GetModa(numbers), Is.EqualTo(expectValue));


        }

    }
}