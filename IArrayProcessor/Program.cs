using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        IArrayProcessor<int> arrayProcessor = new ArrayProcessor();
        IArrayProcessor<object> contravariantArrayProcessor = new ContravariantArrayProcessor(arrayProcessor);

        var intArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var targetSum = 18;

        // Преобразуем intArray в object[]
        object[] objectArray = intArray.Cast<object>().ToArray();

        contravariantArrayProcessor.ProcessArray(objectArray, targetSum);
    }
}
