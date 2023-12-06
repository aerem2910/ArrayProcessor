public class ContravariantArrayProcessor : IArrayProcessor<object>
{
    private readonly IArrayProcessor<int> _arrayProcessor;

    public ContravariantArrayProcessor(IArrayProcessor<int> arrayProcessor)
    {
        _arrayProcessor = arrayProcessor;
    }

    public void ProcessArray(object[] array, int targetSum)
    {
        if (array.All(item => item is int))
        {
            var intArray = array.Cast<int>().ToArray();
            _arrayProcessor.ProcessArray(intArray, targetSum);
        }
        else
        {
            Console.WriteLine("Invalid array type");
        }
    }
}



