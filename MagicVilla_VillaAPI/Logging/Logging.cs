namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.WriteLine($"Error: {message}");
            }
            else if (type == "Info")
            {
                Console.WriteLine($"Info: {message}");
            }
            else
            {
                Console.WriteLine($"Unknown type: {type}, Message: {message}");
            }
        }
    }
}
