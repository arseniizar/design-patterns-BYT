namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; } = userName;

        public void Update(string availability)
        {
            Console.WriteLine($"Hello, {UserName}! Product is now {availability}.");
        }
        
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
    }
}
