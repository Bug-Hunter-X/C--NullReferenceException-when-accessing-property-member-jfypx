public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null reference here will throw a NullReferenceException
        int value = MyProperty.SomeMethod(); // Assuming SomeMethod() exists on a type related to MyProperty
    }
}