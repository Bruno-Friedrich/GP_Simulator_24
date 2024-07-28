using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPManager_Editor.Operation
{
    public class ComboBoxItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ComboBoxItem(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name; // Exibe o nome no ComboBox
        }
    }

    public class StringFormat
    {
        public static string FormatTime(decimal minutes, decimal seconds, decimal milliseconds)
        {
            // Verifica se os valores fornecidos estão dentro dos limites válidos
            if (minutes < 0 || seconds < 0 || seconds >= 60 || milliseconds < 0 || milliseconds >= 1)
            {
                throw new ArgumentException("Valores de tempo inválidos.");
            }

            // Converte minutos e segundos para inteiros
            int minutesInt = (int)Math.Floor(minutes);
            int secondsInt = (int)Math.Floor(seconds);

            // Converte milissegundos para um valor inteiro
            int millis = (int)(milliseconds * 1000);

            // Formata os valores para o formato "00:MM:SS.mmm"
            string formattedTime = $"00:{minutesInt:D2}:{secondsInt:D2}.{millis:D3}";

            return formattedTime;
        }
    }
}
