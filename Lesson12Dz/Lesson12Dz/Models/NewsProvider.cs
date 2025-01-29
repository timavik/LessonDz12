using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Dz.Models
{
    public class NewsProvider
    {
        private Dictionary<string, List<IClient>> subscribers;

        public NewsProvider()
        {
            subscribers = new Dictionary<string, List<IClient>>();
        }

        public void SubscribeClient(string category, IClient client)
        {
            if (!subscribers.ContainsKey(category))
            {
                subscribers[category] = new List<IClient>();
            }

            subscribers[category].Add(client);
        }

        public void UnsubscribeClient(string category, IClient client)
        {
            if (subscribers.ContainsKey(category))
            {
                subscribers[category].Remove(client);
            }
        }

        public void PublishNews(string category, string news)
        {
            if (subscribers.ContainsKey(category))
            {
                foreach (var client in subscribers[category])
                {
                    client.ReceiveNews(news);
                }
            }
        }
    }
}
