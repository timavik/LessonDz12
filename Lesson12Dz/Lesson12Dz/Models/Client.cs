using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IClient
{
    void ReceiveNews(string news);
}
namespace Lesson12Dz.Models
{
    public class Client : IClient
    {
        private string name;
        private NewsProvider newsProvider;
        private string[] subscribedCategories;

        public Client(string name, NewsProvider newsProvider, string[] subscribedCategories)
        {
            this.name = name;
            this.newsProvider = newsProvider;
            this.subscribedCategories = subscribedCategories;

            foreach (var category in subscribedCategories)
            {
                newsProvider.SubscribeClient(category, this);
            }
        }

        public void ReceiveNews(string news)
        {
            Console.WriteLine($"{name} получил новости: {news}");
        }
        public void GetWeather(string news)
        {
            Console.WriteLine($"{name} получил новости погоды: {news}");
        }

        public void Unsubscribe(string category)
        {
            newsProvider.UnsubscribeClient(category, this);
        }
    }
}
