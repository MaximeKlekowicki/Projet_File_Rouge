using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge
{
    public class Popup
    {
        public string Message { get; set; }

        public Popup(string m)
        {
            Message = m;
        }

        public void Show()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 5)
                    for (int j = 0; j < Message.Length + 4; j++)
                    {
                        Console.Write('*');
                    }
                else
                {
                    Console.Write('*');
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 0; j < Message.Length; j++)
                    {
                        Console.Write(Message[j]);
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                }
            }
        }
    }
}
