using System.Security.Cryptography.X509Certificates;

namespace FactoryMethod
{
    interface IFactory
    {
        Operation CreateOperation();
        LeiFeng CreateLeiFeng();
    }

    class  AddFactory: IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }

        public LeiFeng CreateLeiFeng()
        {
            throw new System.NotImplementedException();
        }
    }

    class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
        public LeiFeng CreateLeiFeng()
        {
            throw new System.NotImplementedException();
        }
    }

    class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return  new OperationMul();
        }
        public LeiFeng CreateLeiFeng()
        {
            throw new System.NotImplementedException();
        }
    }

    class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
        public LeiFeng CreateLeiFeng()
        {
            throw new System.NotImplementedException();
        }
    }

    class  UndergraduateFactory: IFactory
    {
        public Operation CreateOperation()
        {
            throw new System.NotImplementedException();
        }

        public LeiFeng CreateLeiFeng()
        {
            return  new Undergraduate();
        }
    }

    class VolunteerFactory : IFactory
    {
        public Operation CreateOperation()
        {
            throw new System.NotImplementedException();
        }

        public LeiFeng CreateLeiFeng()
        {
            return  new Volunteer();
        }
    }

}
