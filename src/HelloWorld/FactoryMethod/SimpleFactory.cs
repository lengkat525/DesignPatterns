namespace FactoryMethod
{
    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "Undergraduate":
                    result = new Undergraduate();
                    break;
                case "Volunteer":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }
}
