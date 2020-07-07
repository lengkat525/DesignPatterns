namespace Proxy
{
    class Proxy : GiveGift
    {
        Pursuit _mm;

        public Proxy(Girl mm)
        {
            _mm = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            _mm.GiveDolls();
        }

        public void GiveFlowers()
        {
           _mm.GiveFlowers();
        }

        public void GiveChocolate()
        {
            _mm.GiveChocolate();
        }

    }
}
