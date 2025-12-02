
namespace DesignPattern.Observer
{
    // The ConcreteSubject class
    // The Subject have states and notifies all observers when the state changes.
    public class Subject(string productName, int productPrice, string availability) : ISubject
    {
        private readonly List<IObserver> observers = [];

        private string ProductName { get; set; } = productName;
        private int ProductPrice { get; set; } = productPrice;
        private string Availability { get; set; } = availability;

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((ConcreteObserver)observer).UserName);
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((ConcreteObserver)observer).UserName);
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So, notifying all Registered users ");

            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);
            }
        }
    }
}
