using AspNetCoreDesignPatterns.BaseProject.Models;
using System.Collections.Generic;

namespace WebApp.ObserverPattern.Observer
{
    public class UserObserverSubject
    {
        private readonly List<IUserObserver> _observers;

        public UserObserverSubject()
        {
            _observers = new List<IUserObserver>();
        }
        public void RegisterObserver(IUserObserver userObserver)
        {
            _observers.Add(userObserver);
        }
        public void RemoveObserver(IUserObserver userObserver)
        {
            _observers.Remove(userObserver);
        }
        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(observer =>
            {
                observer.UserCreated(appUser);
            });
        }
    }
}
