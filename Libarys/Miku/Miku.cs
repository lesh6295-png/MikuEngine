using System;
using System.Collections.Generic;
using System.Reflection;
using Miku.Interfaces;
namespace Miku
{
    /// <summary>
    /// Core class, who control all game class and 
    /// </summary>
    public class Miku
    {
        Assembly[] loadedAssemblies;
        List<Type> games;
        /// <summary>
        /// This method find all classes who inheritance from Game
        /// </summary>
        void FindAllGameDervativesClasses()
        {
            foreach(var assembly in loadedAssemblies)
            {
               foreach (var type in assembly.GetTypes())
                {
                    if (type.BaseType.Name == "Game")
                    {
                        games.Add(type);
                    }
                }
            }
        }

        public Miku(IHost host)
        {
            games = new();
            loadedAssemblies= AppDomain.CurrentDomain.GetAssemblies();
            FindAllGameDervativesClasses();
        }
    }
}
