using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFirstSmartphone.models
{
    public class Smartphone
    {
        List<App> apps = new List<App>();
        //List<Game> games = new List<Game>();

        //public void addApp(App app)
        //{
        //    apps.Add(app);
        //}

        //public void addGame(Game game)
        //{
        //   games.Add(game);
        //}

        public void add<T>(T generic) where T : App
        {
            apps.Add(generic);
        }

        public T Get<T>(string name) where T : App
        {
            return (T)apps.FirstOrDefault(x => x.Name.ToUpper() == name.ToUpper());
        }

        public List<T> GetList<T>() where T : App
        {
            return (List<T>)apps.Where(x => x.GetType() == typeof(T));
        }

        public App GetApp(string name)
        {
            var list = apps.Where(x => x.Name.ToUpper() == name.ToUpper());
            var app = list.ToArray();
            if (app.Length == 1)
            {
                return app[0];
            } else
            {
                return null;
            }

           
        }

        public List<App> getListApps()
        {
            var list = apps.Where(x => x.Category.ToString() != Category.GAME.ToString());
            return list.ToList();
        }

        public List<App> getListGames()
        {
            var list = apps.Where(x => x.Category.ToString() == Category.GAME.ToString());
            return list.ToList();
        }

        public List<App> getList(Category category)
        {
            return getList(new Category[]{ category});
        }

        public List<App> getList(Category[] category)
        {
            var list = apps.Where(x => category.Contains(x.Category));
            return list.ToList();
        }


    }
}
