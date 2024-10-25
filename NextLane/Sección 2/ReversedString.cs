using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLane.Sección_2
{
    public static class StringManipulator
    {
        public static string ReversedString(string text)
        {
            // Utilizamos StringBuilder para almacenar el resultado de manera eficiente
            // (si usaramos una simple cadena de texto string, al ser inmutable, estaríamos
            // creando una nueva cadena de texto en cada iteración del loop). Llevando a ineficiencias en manejo de memoria
            StringBuilder reversedString = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedString.Append(text[i]);
            }

            return reversedString.ToString();
        }
    }

}
