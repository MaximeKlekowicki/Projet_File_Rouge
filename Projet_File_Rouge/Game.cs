using System;
using Projet_File_Rouge.Classe;
using System.IO;
using Projet_File_Rouge.Menus;
using System.Collections.Generic;
using System.Threading;
using Projet_File_Rouge.Items;

namespace Projet_File_Rouge
{
    class Game
    {
        static void Main(string[] args)
        {
            //Initialisation des menus
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            MenuCombat menuCombat = new MenuCombat();

            //Iniatialisation de la map
            Map map = new Map();

            //Initialisation des items des personnages
            List<Item> itemJeanna = new List<Item>();
            List<Item> itemGarrosh = new List<Item>();
            List<Item> itemRexxar = new List<Item>();

            //Initialisation des items des ennemie
            List<Item> itemOrc = new List<Item>();
            List<Item> itemGobelin = new List<Item>();
            List<Item> itemGeant = new List<Item>();

            //Initialisation des personnage jouable
            Personnage perso = new Personnage("perso", map);
            Mage jeanna = new Mage("Jeanna", itemJeanna);
            Guerrier garrosh = new Guerrier("Garrosh", itemGarrosh);
            Archer rexxar = new Archer("Rexxar", itemRexxar);

            //Initialisation des Ennemies
            Orc orc = new Orc("Orc", itemOrc);
            Gobelin gobelin = new Gobelin("Gobelin", itemGobelin);
            Geant geant = new Geant("Geant", itemGeant);

            //Initilisation des differents items
            //Arme
            Item hacheADeuxMains = new Item(20, STAT.ATK);
            Item eppeEnBois = new Item(5, STAT.ATK);
            Item batonDePirmancien = new Item(30, STAT.ATK);
            Item arcDeChasseur = new Item(25, STAT.ATK);

            //Armure
            Item armureDeCuire = new Item(60, STAT.VIT);
            Item armurDePlate = new Item(50, STAT.DEF);
            Item robeDeSorcier = new Item(40, STAT.ATK);
            Item bottesLegere = new Item(30, STAT.VIT);

            
            ConsoleKey key;


            //Initialistion des differentes options du menu principal
            List<string> menuPrincipalItems = new List<string>()
            {
                "Nouvelle Partie",
                "Charger Partie",
                "Exit"
            };

            //Initialisaiton des differentes options du menu de combat
            List<string> menuCombatItem = new List<string>()
            {
                "Attaquer",
                "Fuir",
            };


            //Lancement du jeu
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                string selectedMenuItem = menuPrincipal.drawMenu(menuPrincipalItems);
                if (selectedMenuItem == "Nouvelle Partie")
                {

                    do
                    {
                        Console.Clear();
                        map.DessinerMap(perso);
                        key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.UpArrow:
                            case ConsoleKey.DownArrow:
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.RightArrow:
                                perso.deplacementPersonnage(key);
                                if (map[perso.PosX, perso.PosY] == 'M')
                                {
                                    Console.Clear();
                                    string selectedMenuCombatItem = menuCombat.drawMenu(menuCombatItem);
                                    if(selectedMenuCombatItem == "Attaquer")
                                    {
                                        jeanna.Attaquer(orc);
                                        Thread.Sleep(5000);
                                    }
                                }
                                    break;
                            default:
                                break;
                        }
                        Thread.Sleep(10);
                    } while (key != ConsoleKey.Escape);
                }
            }
        }
    }
}
