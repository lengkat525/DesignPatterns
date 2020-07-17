using System.Collections.Generic;

namespace Observer
{
    class Secretary
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer) {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        public string SecretaryAction { get; set; }
    }
}
