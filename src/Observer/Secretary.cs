using System.Collections.Generic;

namespace Observer
{
    class Secretary : IObserver
    {
        private readonly IList<Colleague> _colleague = new List<Colleague>();

        public void Attach(Colleague colleague)
        {
            _colleague.Add(colleague);
        }

        public void Detach(Colleague colleague) {
            _colleague.Remove(colleague);
        }

        public void Notify()
        {
            foreach (Colleague o in _colleague)
            {
                o.Update();
            }
        }

        public string SecretaryAction { get; set; }
    }

    class Boss : IObserver
    {
        private readonly IList<Colleague> _colleague = new List<Colleague>();
        public void Attach(Colleague colleague)
        {
            _colleague.Add(colleague);
        }

        public void Detach(Colleague colleague)
        {
            _colleague.Remove(colleague);
        }

        public void Notify()
        {
            foreach (Colleague o in _colleague)
            {
                o.Update();
            }
        }

        public string SecretaryAction { get; set; }
    }
}
