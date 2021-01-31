using System.Linq;
namespace Lecture5
{
    static class ArrayHelper
    {
        //********* Начало инициализации Pop с методом переопределения ********* //
        public static int Pop(ref int[] arrayOfIntegers)
        {
            var tempArray = arrayOfIntegers.ToList();
            var lastObject = arrayOfIntegers[arrayOfIntegers.Length - 1];
            tempArray.RemoveAt(arrayOfIntegers.Length - 1);
            arrayOfIntegers = tempArray.ToArray();
            return lastObject;
        }
        public static string Pop(ref string[] arrayOfStrings)
        {
            var tempArray = arrayOfStrings.ToList();
            var lastObject = arrayOfStrings[arrayOfStrings.Length - 1];
            tempArray.RemoveAt(arrayOfStrings.Length - 1);
            arrayOfStrings = tempArray.ToArray();
            return lastObject;
        }
        public static double Pop(ref double[] arrayOfDouble)
        {
            var tempArray = arrayOfDouble.ToList();
            var lastObject = arrayOfDouble[arrayOfDouble.Length - 1];
            tempArray.RemoveAt(arrayOfDouble.Length - 1);
            arrayOfDouble = tempArray.ToArray();
            return lastObject;
        }
        public static decimal Pop(ref decimal[] arrayOfDecimal)
        {
            var tempArray = arrayOfDecimal.ToList();
            var lastObject = arrayOfDecimal[arrayOfDecimal.Length - 1];
            tempArray.RemoveAt(arrayOfDecimal.Length - 1);
            arrayOfDecimal = tempArray.ToArray();
            return lastObject;
        }
        public static float Pop(ref float[] arrayOfFloat)
        {
            var tempArray = arrayOfFloat.ToList();
            var lastObject = arrayOfFloat[arrayOfFloat.Length - 1];
            tempArray.RemoveAt(arrayOfFloat.Length - 1);
            arrayOfFloat = tempArray.ToArray();
            return lastObject;
        }
        //********* Конец инициализации метода Pop ********* //

        // ******** Начало инициализации метода Push ****** //

        public static int Push(ref int[] arrayOfIntegers, int tempInt)
        {
            var tempArray = arrayOfIntegers.ToList();
            tempArray.Add(tempInt);
            arrayOfIntegers = tempArray.ToArray();
            return arrayOfIntegers.Length;
        }
        public static int Push(ref string[] arrayOfStrings, string tempString)
        {
            var tempArray = arrayOfStrings.ToList();
            tempArray.Add(tempString);
            arrayOfStrings = tempArray.ToArray();
            return arrayOfStrings.Length;
        }
        public static int Push(ref double[] arrayOfDouble, double tempDouble)
        {
            var tempArray = arrayOfDouble.ToList();
            tempArray.Add(tempDouble);
            arrayOfDouble = tempArray.ToArray();
            return arrayOfDouble.Length;
        }
        public static int Push(ref decimal[] arrayOfDecimal, decimal tempDecimal)
        {
            var tempArray = arrayOfDecimal.ToList();
            tempArray.Add(tempDecimal);
            arrayOfDecimal = tempArray.ToArray();
            return arrayOfDecimal.Length;
        }
        public static int Push(ref float[] arrayOfFloat, float tempFloat)
        {
            var tempArray = arrayOfFloat.ToList();
            tempArray.Add(tempFloat);
            arrayOfFloat = tempArray.ToArray();
            return arrayOfFloat.Length;
        }

        // ******** Конец инициализации метода Push ****** //

        //********* Начало инициализации метода Shift ******//

        public static int Shift(ref int[] arrayOfIntegers)
        {

            var firstObject = arrayOfIntegers[0];
            var tempArray = arrayOfIntegers.ToList();
            tempArray.RemoveAt(0);
            arrayOfIntegers = tempArray.ToArray();
            return firstObject;
        }
        public static string Shift(ref string[] arrayOfStrings)
        {
            var firstObject = arrayOfStrings[0];
            var tempArray = arrayOfStrings.ToList();
            tempArray.RemoveAt(0);
            arrayOfStrings = tempArray.ToArray();
            return firstObject;
        }
        public static double Shift(ref double[] arrayOfDouble)
        {
            var firstObject = arrayOfDouble[0];
            var tempArray = arrayOfDouble.ToList();
            tempArray.RemoveAt(0);
            arrayOfDouble = tempArray.ToArray();
            return firstObject;
        }
        public static decimal Shift(ref decimal[] arrayOfDecimal)
        {
            var firstObject = arrayOfDecimal[0];
            var tempArray = arrayOfDecimal.ToList();
            tempArray.RemoveAt(0);
            arrayOfDecimal = tempArray.ToArray();
            return firstObject;
        }
        public static float Shift(ref float[] arrayOfFloat)
        {
            var firstObject = arrayOfFloat[0];
            var tempArray = arrayOfFloat.ToList();
            tempArray.RemoveAt(0);
            arrayOfFloat = tempArray.ToArray();
            return firstObject;
        }

        //********* Конец инициализации метода Shift ******//

        //********* Начало инициализации метода UnShift *****//

        public static int UnShift(ref int[] arrayOfIntegers, int tempInt)
        {
            var tempArray = arrayOfIntegers.ToList();
            tempArray.Reverse();
            tempArray.Add(tempInt);
            arrayOfIntegers = tempArray.ToArray();
            return arrayOfIntegers.Length;

        }
        public static int UnShift(ref string[] arrayOfStrings, string tempString)
        {
            var tempArray = arrayOfStrings.ToList();
            tempArray.Reverse();
            tempArray.Add(tempString);
            arrayOfStrings = tempArray.ToArray();
            return arrayOfStrings.Length;
        }
        public static int UnShift(ref double[] arrayOfDouble, double tempDouble)
        {
            var tempArray = arrayOfDouble.ToList();
            tempArray.Reverse();
            tempArray.Add(tempDouble);
            arrayOfDouble = tempArray.ToArray();
            return arrayOfDouble.Length;
        }
        public static int UnShift(ref decimal[] arrayOfDecimal, decimal tempDecimal)
        {
            var tempArray = arrayOfDecimal.ToList();
            tempArray.Reverse();
            tempArray.Add(tempDecimal);
            arrayOfDecimal = tempArray.ToArray();
            return arrayOfDecimal.Length;
        }
        public static int UnShift(ref float[] arrayOfFloat, float tempFloat)
        {
            var tempArray = arrayOfFloat.ToList();
            tempArray.Reverse();
            tempArray.Add(tempFloat);
            arrayOfFloat = tempArray.ToArray();
            return arrayOfFloat.Length;
        }
        //********* Конец инициализации метода UnShift   *****//
    }
}

