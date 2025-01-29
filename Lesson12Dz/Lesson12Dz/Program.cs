using Lesson12Dz.Models;

namespace Lesson12Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newsProvider = new NewsProvider();
            var clientList = new List<Client>();

            var client1 = new Client("Паша", newsProvider, new[] { "юмор", "погода", });
            var client2 = new Client("Антон", newsProvider, new[] { "юмор" });
            var client3 = new Client("Игорь", newsProvider, new[] { "спорт", "новости" });

            newsProvider.PublishNews("новости", "новые новости");
            newsProvider.PublishNews("погода", "целый день будет солнце");
            newsProvider.PublishNews("спорт", "ваша любимая команда в финале");
            newsProvider.PublishNews("происшествия", "сегодня вечером призошла авария на проспекте Жукова");
            newsProvider.PublishNews("юмор", "сегодня в 21:00 юмарестическая программа");

            Console.ReadKey();
        }
    }
}
