using System;

namespace Strategy.SimpleFactoryImplementation
{
    class CashFactory
    {
        public static CashCharge CreateCashAccept(string type)
        {
            CashCharge cs;
            switch (type)
            {
                case "Normal charge":
                    cs = new CashNormal();
                    break;
                case "300 minus 100":
                    var cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;
                case "20% off":
                    var cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
                default:
                    throw new Exception("error");
            }

            return cs;
        }
    }
}