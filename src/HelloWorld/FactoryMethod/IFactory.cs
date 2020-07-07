namespace FactoryMethod
{
    interface IFactory
    {
        Operation CreateOperation();
    }

    class  AddFactory: IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }

    class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }

    class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return  new OperationMul();
        }
    }

    class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
