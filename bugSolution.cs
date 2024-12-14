public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty in the constructor
        MyProperty = 0; // Or assign a more meaningful default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // This now prints the initialized value
    }
}