using System;
using NUnit.Framework;

namespace wExtensions.UnitTests {

    [TestFixture]
    public class EventTests {
        private event EventHandler TestEvent;
        private event EventHandler<EventArgs> GenericTestEvent;

        [Test]
        public void EventIsRaised() {
            int wasCalled = 0;

            TestEvent += (sender, args) => wasCalled++;

            TestEvent.Raise(null, null);

            Assert.That(wasCalled, Is.EqualTo(1));
        }

        [Test]
        public void GenericEventIsRaised() {
            int wasCalled = 0;

            GenericTestEvent += (sender, args) => wasCalled++;

            GenericTestEvent.Raise(null, null);

            Assert.That(wasCalled, Is.EqualTo(1));
        }

        [Test]
        public void RaiseEventWithEmptyArgs() {
            EventArgs eventArgs = null;

            TestEvent += (sender, args) => eventArgs = args;

            TestEvent.Raise(this);

            Assert.That(eventArgs, Is.EqualTo(EventArgs.Empty));
        }
    }
}
