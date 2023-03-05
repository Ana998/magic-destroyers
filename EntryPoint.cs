using MagicDestroyers;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

public class EntryPoint
{
    static void Main()
    {
        bool gameOver = false;

        Random random = new Random();

        Melee currentMelee;
        Spellcaster currentSpellcaster;

        List<Character> characters = new List<Character>
        {
            new Warrior(),
            new Assassin(),
            new Knight(),
            new Mage(),
            new Druid(),
            new Necromancer()
        };

        List<Melee> meleeTeam = new List<Melee>();
        List<Spellcaster> spellcasterTeam = new List<Spellcaster>();

        foreach (var character in characters)
        {
            if (character is Melee)
            {
                meleeTeam.Add((Melee)character);
            }
            else if (character is Spellcaster)
            {
                spellcasterTeam.Add((Spellcaster)character);
            }
        }

        PlayersInfo.Initialize(characters);

        while (!gameOver)
        {
            currentMelee = meleeTeam[random.Next(0, meleeTeam.Count)];
            currentSpellcaster = spellcasterTeam[random.Next(0, spellcasterTeam.Count)];


            currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentSpellcaster.GetType().ToString());
           
            if (!currentSpellcaster.IsAlive)
            {
                currentMelee.WonBattle();
                spellcasterTeam.Remove(currentSpellcaster);

                if (spellcasterTeam.Count == 0)
                {
                    Tools.ColorfulWriteLine("Melee team has won!", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentSpellcaster = spellcasterTeam[random.Next(0, spellcasterTeam.Count)];
                }
            }

            currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentMelee.GetType().ToString());
            if (!currentMelee.IsAlive)
            {
                currentSpellcaster.WonBattle();
                meleeTeam.Remove(currentMelee);

                if (meleeTeam.Count == 0)
                {
                    Tools.ColorfulWriteLine("Spellcaster team has won!", ConsoleColor.Green);
                    break;
                }
                else
                {
                    currentMelee = meleeTeam[random.Next(0, meleeTeam.Count)];
                }
            }

            PlayersInfo.UpdateFullInfo(characters);
            PlayersInfo.Save(characters);
            PlayersInfo.PrintFullInfo();
        }

    }
}

