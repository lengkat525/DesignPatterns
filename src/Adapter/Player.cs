namespace Adapter
{
    abstract class Player
    {
        protected string Name;

        protected Player(string name)
        {
            Name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}
