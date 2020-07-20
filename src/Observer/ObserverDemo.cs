using System;

namespace Observer
{
    class ObserverDemo
    {
        static void Main(string[] args)
        {
            // NewMethod();
            // NewMethod1();
            // NewMethod2();
        }

        private static void NewMethod2()
        {
            var boss = new Boss();

            var colleague1 = new StockColleague("colleague1", boss);
            var colleague2 = new NbaColleague("colleague2", boss);

            boss.Attach(colleague1);
            boss.Attach(colleague2);

            boss.SecretaryAction = "boss come in\n";
            boss.Notify();

            Console.Read();
        }

        private static void NewMethod1()
        {
            var secretary = new Secretary();
            var stock1 = new StockColleague("stock1", secretary);
            var nba = new NbaColleague("nba", secretary);

            secretary.Attach(stock1);
            secretary.Attach(nba);
            secretary.SecretaryAction = "Close Window";
            secretary.Notify();
            Console.Read();
        }

        private static void NewMethod()
        {
            var secretary = new Secretary();
            var stock1 = new StockColleague("stock1", secretary);
            var stock2 = new StockColleague("stock2", secretary);

            secretary.Attach(stock1);
            secretary.Attach(stock2);
            secretary.SecretaryAction = "Close Window";
            secretary.Notify();
            Console.Read();
        }
    }
}
