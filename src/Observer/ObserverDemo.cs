using System;

namespace Observer
{
    class ObserverDemo
    {
        static void Main(string[] args)
        {
            // NewMethod();
            // NewMethod1();
        }

        private static void NewMethod1()
        {
            var secretary = new Secretary();
            var stock1 = new StockObserver("stock1", secretary);
            var nba = new NBAObserver("nba", secretary);

            secretary.Attach(stock1);
            secretary.Attach(nba);
            secretary.SecretaryAction = "Close Window";
            secretary.Notify();
            Console.Read();
        }

        private static void NewMethod()
        {
            var secretary = new Secretary();
            var stock1 = new StockObserver("stock1", secretary);
            var stock2 = new StockObserver("stock2", secretary);

            secretary.Attach(stock1);
            secretary.Attach(stock2);
            secretary.SecretaryAction = "Close Window";
            secretary.Notify();
            Console.Read();
        }
    }
}
