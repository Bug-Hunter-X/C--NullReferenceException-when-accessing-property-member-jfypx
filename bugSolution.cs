public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        if (MyProperty != null) //In this case we are assuming MyProperty is an object with a method called SomeMethod. 
        {
            int value = MyProperty.SomeMethod(); //This line is now safe to execute
        }
        else
        {
            // Handle the case where MyProperty is null appropriately (e.g., log a message, use a default value, throw a custom exception)
            Console.WriteLine("MyProperty is null.");
        }
    }
}