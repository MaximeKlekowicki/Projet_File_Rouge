using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Menus
{
    public class MenuPrincipale
    {
        public string str_Titre;
        public char chr_CarSouligne;
        public void CentrerEncadrerTitre(string str_Titre, char chr_CarSouligne)            // Méthode CentrerEncadrerTitre
        {
            Console.CursorVisible = false;
            int int_NbCar, int_NbEspaces, i;
            int_NbCar = str_Titre.Length;                                                   // Compte le nombre de caractères du titre
            int_NbEspaces = (Console.WindowWidth - int_NbCar) / 2;                          // Le nombre d'espaces est égal à la longueur de la console moins le nombre de caractères du titre, divisé par 2
            for (i = 0; i < int_NbEspaces; i++)                                             // Centrage du soulignement
                Console.Write(" ");
            for (i = 0; i < int_NbCar; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(chr_CarSouligne);
                Console.ResetColor();
            }
            Console.WriteLine();
            for (i = 0; i < int_NbEspaces; i++)                                             // Centrage du titre
                Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(str_Titre);
            Console.ResetColor();
            for (i = 0; i < int_NbEspaces; i++)                                             // Centrage du soulignement
                Console.Write(" ");
            for (i = 0; i < int_NbCar; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(chr_CarSouligne);
                Console.ResetColor();
            }
            Console.SetCursorPosition(33, 5);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("|");
            Console.SetCursorPosition(46, 5);
            Console.Write("|");
            Console.ResetColor();
        }

        public void EffacerEcrireEcran(int int_Vies, int int_ScoreAct, int int_BestScore)   // Méthode EffacerEcrireEcran
        {
            int i, j;
            char[] tab_chrVies = new char[5];
            Console.Clear();                                                                // Efface l'écran de la console
            Console.Write("\nVies ");
            for (i = 0; i < int_Vies; i++)                                                  // Mets une vie dans les cases du tableau des vies et affiche le tableau
            {
                tab_chrVies[i] = '♥';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(tab_chrVies[i]);
                Console.ResetColor();
            }
            Console.SetCursorPosition(33, 1);
            Console.Write("Score actuel ");                                                 // Affiche le score actuel
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(int_ScoreAct);
            Console.ResetColor();
            Console.SetCursorPosition(59, 1);
            Console.Write("Meilleur score ");                                               // Affiche le meilleur score
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(int_BestScore);
            Console.ResetColor();
            Console.WriteLine("\n-------------------------------------------------------------------------------");
            for (j = 3; j < 25; j++)                                                        // Affiche la limite gauche du déplacement de la corbeille et de l'apparition des boules de papier
            {
                i = 14;
                Console.SetCursorPosition(i, j);
                Console.Write("|");
            }
            for (j = 3; j < 25; j++)                                                        // Affiche la limite droite du déplacement de la corbeille et de l'apparition des boules de papier
            {
                i = 66;
                Console.SetCursorPosition(i, j);
                Console.Write("|");
            }
        }

        public void Main(string[] args)
        {
            ////////////// DECLARATIONS //////////////////////////
            int i, j, k, l, int_ScoreAct, int_BestScore, int_Vies;
            
            char chr_Rep, chr_Boule;
            char[] tab_chrVies = new char[5];
            char[] tab_chrCorbeille = new char[66];
            int[] tab_intDecompte = new int[1];
            ConsoleKeyInfo cki_Dir;

            ///////////// PROGRAMME PRINCIPAL ////////////////////

            ////////// MENU D'INTRODUCTION //////////
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("                                                                                ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("                                   ■■■■■■■■■                                    ");
            Console.Write("                                ■■■         ■■■                                 ");
            Console.Write("                              ■■               ■■                               ");
            Console.Write("                             ■                   ■                              ");
            Console.Write("                            ■                     ■                             ");
            Console.Write("                           ■       "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■     ■■■■■■■■  "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                            ");
            Console.Write("                           ■      "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■       ■        "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                            ");
            Console.Write("                          ■      "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■       ■          "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                           ");
            Console.Write("                          ■     "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■       ■           "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                           ");
            Console.Write("                         ■     "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■       ■             "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                          ");
            Console.Write("                         ■    "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■       ■              "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                          ");
            Console.Write("                         ■   "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("■■■■■■■■■  ■■■■■■■      "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                          ");
            Console.Write("                          ■  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" ■■   ■  ■ ■ ■■■  ■■   "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                           ");
            Console.Write("                          ■  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" ■■■ ■■■ ■■■ ■■   ■    "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                           ");
            Console.Write("                           ■ "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" ■■■ ■ ■ ■ ■ ■■■ ■■   "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("■                            ");
            Console.Write("                           ■                       ■                            ");
            Console.Write("                            ■                     ■                             ");
            Console.Write("                             ■                   ■                              ");
            Console.Write("                              ■■               ■■                               ");
            Console.Write("                                ■■■         ■■■                                 ");
            Console.Write("                                   ■■■■■■■■■                                    ");
            Console.Write("                                                                                ");
            Console.ResetColor();
            System.Threading.Thread.Sleep(4000);


            ////////// MENU D'ACCUEIL //////////
            Console.Clear();                                                                // Efface l'écran de la console
            str_Titre = "  TRASH RUSH  ";                                                   // Affiche le titre
            chr_CarSouligne = '-';                                                          // Caractère d'encadrement
            Console.WriteLine("\n\n\n");
            CentrerEncadrerTitre(str_Titre, chr_CarSouligne);                               // Appel de la méthode CentrerEncadrerTitre
            Console.Write("\n\n\n\n\n\t\tAppuyez sur la touche Enter pour démarrer le jeu");
            Console.ReadLine();                                                             // Bloque l'écran de la console


            ////////// DECOMPTE //////////

            do
            {
                int_ScoreAct = 0;
                int_BestScore = 0;
                int_Vies = 3;
                for (i = 3; i > 0; i--)                                                     // Efface l'écran de la console et la réaffiche avec le chiffre suivant du décompte
                {
                    EffacerEcrireEcran(int_Vies, int_ScoreAct, int_BestScore);              // Appel de la méthode EffacerEcrireEcran
                    tab_intDecompte[0] = i;
                    Console.SetCursorPosition(40, 10);
                    Console.Write(tab_intDecompte[0]);                                      // Affiche le décompte avant le commencement du jeu
                    System.Threading.Thread.Sleep(1000);                                    // Intervalle d'affichage entre deux chiffres du décompte
                }
                EffacerEcrireEcran(int_Vies, int_ScoreAct, int_BestScore);
                Console.SetCursorPosition(39, 10);
                Console.Write("GO");
                System.Threading.Thread.Sleep(1000);


                ////////// ECRAN DE JEU //////////
                EffacerEcrireEcran(int_Vies, int_ScoreAct, int_BestScore);                  // Appel de la méthode EffacerEcrireEcran
                k = 40;                                                                     // Longueur de l'écran dans lequel les boules de papier tombent et dans lequel la corbeille se déplace
                l = 23;
                Console.SetCursorPosition(k, l);                                            // Place la corbeille au milieu de l'écran en début de partie
                Console.Write("W");
                Console.SetCursorPosition(k, l);                                            // Place le curseur sur la position de la corbeille
                do
                {
                    Random Colonne = new Random();
                    i = Colonne.Next(15, 66);                                               // Définit une colonne aléatoire pour l'apparition des boules de papier
                    chr_Boule = 'O';
                    j = 3;
                    if (j == 3)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 4)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 5)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 6)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 7)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 8)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 9)                                                             // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 10)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 11)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 12)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 13)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 14)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 15)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 16)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 17)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 18)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 19)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 20)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 21)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 22)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        Console.SetCursorPosition(i, j - 1);                                // Efface la boule de la ligne précédente
                        Console.Write(" ");
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        j++;
                    }
                    if (j == 23)                                                            // Parcourt chaque ligne de la console
                    {
                        if (i == k && j == l)                                               // Si la corbeille est à la même place que la boule de papier, incrémente le score de 10 points et affiche la corbeille
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write("W");
                            Console.SetCursorPosition(i, j - 1);                            // Efface la boule de la ligne précédente
                            Console.Write(" ");
                            if (int_ScoreAct < 99)                                          // Définit la vitesse de déplacement des boules selon le score du joueur
                                System.Threading.Thread.Sleep(200);
                            if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                                System.Threading.Thread.Sleep(150);
                            if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                                System.Threading.Thread.Sleep(120);
                            if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                                System.Threading.Thread.Sleep(100);
                            if (int_ScoreAct >= 1000)
                                System.Threading.Thread.Sleep(80);
                            int_ScoreAct += 10;
                            Console.SetCursorPosition(46, 1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(int_ScoreAct);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.SetCursorPosition(i, j);                                // Affiche la boule
                            Console.Write(chr_Boule);
                            Console.SetCursorPosition(i, j - 1);                            // Efface la boule de la ligne précédente
                            Console.Write(" ");
                            if (int_ScoreAct < 99)                                          // Définit la vitesse de déplacement des boules selon le score du joueur
                                System.Threading.Thread.Sleep(200);
                            if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                                System.Threading.Thread.Sleep(150);
                            if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                                System.Threading.Thread.Sleep(120);
                            if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                                System.Threading.Thread.Sleep(100);
                            if (int_ScoreAct >= 1000)
                                System.Threading.Thread.Sleep(80);
                            j++;
                        }
                    }
                    if (j == 24)                                                            // Parcourt chaque ligne de la console
                    {
                        Console.SetCursorPosition(i, j);                                    // Affiche la boule
                        Console.Write(chr_Boule);
                        if (k != j - 1)                                                     // Si la corbeille ne se trouve pas au dessus de la boule non attrapée
                        {
                            Console.SetCursorPosition(i, j - 1);                            // Efface la boule de la ligne précédente
                            Console.Write(" ");
                        }
                        if (int_ScoreAct < 99)                                              // Définit la vitesse de déplacement des boules selon le score du joueur
                            System.Threading.Thread.Sleep(200);
                        if (int_ScoreAct >= 100 && int_ScoreAct < 199)
                            System.Threading.Thread.Sleep(150);
                        if (int_ScoreAct >= 200 && int_ScoreAct < 499)
                            System.Threading.Thread.Sleep(120);
                        if (int_ScoreAct >= 500 && int_ScoreAct < 999)
                            System.Threading.Thread.Sleep(100);
                        if (int_ScoreAct >= 1000)
                            System.Threading.Thread.Sleep(80);
                        Console.SetCursorPosition(i, j);
                        Console.Write(" ");
                        int_Vies--;                                                         // Déduit une vie si la boule n'est pas attrapée
                        Console.SetCursorPosition(5 + int_Vies, 1);
                        Console.Write(" ");
                    }
                    cki_Dir = Console.ReadKey();
                    if (cki_Dir.Key == ConsoleKey.LeftArrow && k > 15)                      // Si la corbeille est déplacée sur la gauche et qu'elle reste dans les limites
                    {
                        Console.SetCursorPosition(k, l);                                    // Efface l'ancienne position de la corbeille (à droite)
                        Console.Write(" ");
                        Console.SetCursorPosition(k - 1, l);                                // Décale la corbeille d'un caractère sur la gauche
                        Console.Write("W");                                                 // Affiche la corbeille
                        Console.SetCursorPosition(k - 1, l);                                // Place le curseur sur la position de la corbeille
                        k--;
                    }
                    else
                    {

                        if (cki_Dir.Key == ConsoleKey.RightArrow && k < 65)                 // Si la corbeille est déplacée sur la droite et qu'elle reste dans les limites
                        {
                            Console.SetCursorPosition(k, l);                                // Efface l'ancienne position de la corbeille (à gauche)
                            Console.Write(" ");
                            Console.SetCursorPosition(k + 1, l);                            // Décale la corbeille d'un caractère sur la droite
                            Console.Write("W");                                             // Affiche la corbeille
                            Console.SetCursorPosition(k + 1, l);                            // Place le curseur sur la position de la corbeille
                            k++;
                        }
                        else                                                                // Si une autre touche est appuyée, laisse la corbeille la où elle est et n'affiche pas la touche appuyée
                        {
                            Console.SetCursorPosition(k, l);
                            Console.Write("W");
                            Console.SetCursorPosition(k, l);
                        }
                    }
                }
                while (int_Vies != 0);                                                      // Tant qu'il reste des vies


                ////////// ECRAN DE FIN DE JEU //////////
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(36, 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("GAME OVER");
                Console.ResetColor();
                System.Threading.Thread.Sleep(1500);
                Console.SetCursorPosition(29, 10);
                Console.Write("Nouvelle partie ? <O/N>: ");                                 // Demande de recommencer
                chr_Rep = Convert.ToChar(Console.ReadLine());
            }
            while (chr_Rep == 'o' || chr_Rep == 'O');                                       // Tant que chr_Rep est égal à o ou O
        }
    }
}
