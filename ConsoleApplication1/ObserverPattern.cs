using System;
using BasicDataStructure;
using System.Collections.Generic;
using System.Web.Mail;
/// <summary>
/// Observer pattern
/// Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 
/// </summary>
///
/*
 * Subject  (Stock)
knows its observers. Any number of Observer objects may observe a subject
provides an interface for attaching and detaching Observer objects.
ConcreteSubject  (IBM)
stores state of interest to ConcreteObserver
sends a notification to its observers when its state changes
Observer  (IInvestor)
defines an updating interface for objects that should be notified of changes in a subject.
ConcreteObserver  (Investor)
maintains a reference to a ConcreteSubject object
stores state that should stay consistent with the subject's
implements the Observer updating interface to keep its state consistent with the subject's

 */




namespace MyNamespace
{

    #region Simple Observer Pattern
    public abstract class Observer
    {
        public abstract void Update();
    }

    public abstract class Subject 
    {
        private List<Observer> _observsers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observsers.Add(observer);
        }

        public void Dettach(Observer observer) 
        {
            _observsers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observsers) 
            {
                Console.WriteLine("test point");
                o.Update();
            }
        }
    }

    public class ConcreteSubject : Subject 
    {
        public string SubjectState { get; set; }
       
    }

    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        public ConcreteSubject _subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
          _observerState = _subject.SubjectState;
          Console.WriteLine("Observer {0}'s new state is {1}", _name,  _observerState);
        }

    }
    #endregion
    
    
    /*
 * An event is a member that enables an object or class to provide notifications. Clients can attach executable code for events by supplying event handlers.
 * An event can have many handlers. With the event handler syntax in the C# language, we create a notification system. In this way we attach additional methods without changing other parts of the code. This makes programs easier to maintain.
 * The delegate keyword is used to specify the EventHandler type.
 * The event keyword is used to create an instance of an event that can store methods in its invocation list.
 * */

    #region  Observer Pattern with Delegate and Event
  
    public delegate void myEventHandler();

    public abstract class Publisher
    {
        public event myEventHandler myEvent;

        public void Attach(myEventHandler myHandler)
        {
            myEvent += myHandler;
        }

        public void Dettach(myEventHandler myHandler)
        {
            myEvent -= myHandler;
        }

        public void notify() 
        {
            if (myEvent != null)
            {
                myEvent.Invoke();
            }
        }
    }

    public abstract class Subscriber
    {
        public abstract void PrintOut();

    }

    public class ConcretePublisher : Publisher
    {
        public string sPublisherName { get; set; }
        public string sPublisherStatus { get; set; }

    }

    public class ConcreteSubscriber : Subscriber 
    {
        public string sSubscriberName { get; set; }
        
        public ConcreteSubscriber(ConcretePublisher aPulisher, string name) 
        {
            sSubscriberName = name;
            aPulisher.Attach(PrintOut);
        }

        public override void PrintOut() {
            Console.Write("I{0} will print this out.",sSubscriberName);
         
        }

    }
    #endregion


}
