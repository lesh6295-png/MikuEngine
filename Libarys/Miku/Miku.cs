using System;
using System.Collections.Generic;
using System.Reflection;
using Miku.Interfaces;
using Miku.Types.Base;
namespace Miku
{
    /// <summary>
    /// Core class, who control all game class and 
    /// </summary>
    public class Miku
    {
        Assembly[] loadedAssemblies;
        List<dynamic> games;
        List<GameInfo> info;
        public IEnumerator<GameInfo> Scenarios
        {
            get
            {
                return info?.GetEnumerator();
            }
        }
        IHost host;
        /// <summary>
        /// This method find all classes who inheritance from Game
        /// </summary>
        void FindAllGameDervativesClasses()
        {
            foreach(var assembly in loadedAssemblies)
            {
               foreach (var type in assembly.GetTypes())
                {
                    if (type.BaseType == null) continue;
                    if (type.BaseType.Name == "Game")
                    {
                        games.Add(Convert.ChangeType(Activator.CreateInstance(type, host,host),type));
                    }
                }
            }
        }
        void ExtraactInfoAboutTypes()
        {
            info = new();
            foreach(dynamic d in games)
            {
                GameInfo info = new GameInfo();
                d.Info(info);
                this.info.Add(info);
            }
        }

        public Miku(IHost host)
        {
            this.host = host;
            games = new();
            loadedAssemblies= AppDomain.CurrentDomain.GetAssemblies();
            FindAllGameDervativesClasses();
            ExtraactInfoAboutTypes();
        }
        public void EnableScenario(string name)
        {
            for(int i = 0; i < info.Count; i++)
            {
                if (info[i].RenderName == name)
                {
                    games[i].Play();
                }
            }            
        }
    }
}
