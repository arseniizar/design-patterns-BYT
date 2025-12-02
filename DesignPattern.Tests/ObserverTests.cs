using DesignPattern.Observer;

namespace DesignPattern.Tests
{
    public class MockObserver : IObserver
    {
        public bool UpdateWasCalled { get; private set; } = false;
        public string LastMessage { get; private set; }

        public void Update(string availability)
        {
            UpdateWasCalled = true;
            LastMessage = availability;
        }
    }

    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void NotifyObservers_WhenStateChanges_CallsUpdateOnAllRegisteredObservers()
        {
            var subject = new Subject("Test Product", 100, "Out of Stock");
            var observer1 = new MockObserver();
            var observer2 = new MockObserver();

            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            subject.SetAvailability("Available");

            Assert.That(observer1.UpdateWasCalled, Is.True);
            Assert.That(observer2.UpdateWasCalled, Is.True);
            Assert.That(observer1.LastMessage, Is.EqualTo("Available"));
        }

        [Test]
        public void NotifyObservers_AfterRemovingObserver_DoesNotCallUpdateOnRemovedObserver()
        {
            var subject = new Subject("Test Product", 100, "Out of Stock");
            var observer1 = new MockObserver(); 
            var observer2 = new MockObserver(); 

            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            subject.RemoveObserver(observer2); 
            subject.SetAvailability("Available");

            Assert.That(observer1.UpdateWasCalled, Is.True);
            Assert.That(observer2.UpdateWasCalled, Is.False);
        }
    }
}
