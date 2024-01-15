
const string fileName = @"C:\Users\juant\OneDrive\Escritorio\Dorset\7 - OOP\FileWriterDemo\FileDemoWriter\sample-writer.txt";

try
{
    
    var writer = new StreamWriter(fileName, true);
    writer.WriteLine("Hello World");
    writer.WriteLine("From the stream writer");

    for (int i = 0; i < 10; i++)
    {
        writer.WriteLine($"Line {i}");
    }
    
    writer.Close();
}
catch(Exception e)
{
    Console.WriteLine("Failed: " + e.Message);
}
finally
{
    Console.WriteLine("Finally block");
}
