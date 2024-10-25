using System;

namespace NextLane.Sección_2
{
    public static class ErrorHandler
    {
        public static void SomeMethod(string text)
        {
            try
            {
                if (text == null)
                {
                    throw new ArgumentNullException(nameof(text));
                }

                if (text.Length > 0)
                {
                    Console.WriteLine("All good");
                }   
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }
        }
    }
}
