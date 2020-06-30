using System;

namespace Strategy.SimpleFactoryImplementation
{
    abstract class CashCharge
    {
        public abstract double GetResult(double money);
    }

    class CashNormal : CashCharge
    {
        public override double GetResult(double money)
        {
            return money;
        }
    }

    class CashRebate : CashCharge
    {
        private readonly double _moneyRebate;
        public CashRebate(string moneyRebate)
        {
            _moneyRebate = double.Parse(moneyRebate);
        }

        public override double GetResult(double money)
        {
            return money * _moneyRebate;
        }
    }

    class CashReturn : CashCharge
    {
        private readonly double _moneyCondition;
        private readonly double _moneyReturn;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            _moneyCondition = double.Parse(moneyCondition);
            _moneyReturn = double.Parse(moneyReturn);
        }

        public override double GetResult(double money)
        {
            var result = money;
            if (money > _moneyCondition)
            {
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }

            return result;
        }
    }
}