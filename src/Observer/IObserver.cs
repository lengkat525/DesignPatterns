namespace Observer
{
    interface IObserver
    {
        void Attach(Colleague colleague);
        void Detach(Colleague colleague);
        void Notify();
        string SecretaryAction { get; set; }
    } 
}
