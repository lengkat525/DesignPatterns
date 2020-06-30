using System;
using Strategy.SimpleFactoryImplementation;

namespace Strategy.StrategyImplementation
{
    class CashContext
    {
        private readonly CashCharge _cashCharge;

        public CashContext(string type)
        {
            switch (type)
            {
                case "Normal charge":
                    CashNormal c1 = new CashNormal();
                    _cashCharge = c1;
                    break;
                case "300 minus 100":
                    CashReturn c2 = new CashReturn("300", "100");
                    _cashCharge = c2;
                    break;
                case "20% off":
                    CashRebate c3 = new CashRebate("0.8");
                    _cashCharge = c3;
                    break;
                default:
                    throw new Exception("error");
            }
        }

        public double GetResult(double money)
        {
            return _cashCharge.GetResult(money);
        }
    }
}