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
            string txt = "";
            Console.SetCursorPosition(10, 10);
            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    txt += "  ";
                    for (int j = 0; j < Message.Length + 4; j++)
                    {
                        txt += '*';
                    }
                    txt += "  ";
                }
                else if (i == 2)
                {
                    txt += '*';
                    for (int j = 0; j < 3; j++)
                    {
                        txt += ' ';
                    }
                    txt += Message;
                    for (int j = 0; j < 3; j++)
                    {
                        txt += ' ';
                    }
                    txt += '*';
                }
                else
                {
                    txt += '*';
                    for (int j = 0; j < Message.Length + 6; j++)
                    {
                        txt += ' ';
                    }
                    txt += '*';
                }
                txt += '\n';
            }
            Console.SetCursorPosition(0, 0);
            Console.Write(txt);
        }
    }
}
