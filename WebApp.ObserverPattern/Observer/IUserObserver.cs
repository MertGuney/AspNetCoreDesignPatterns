using AspNetCoreDesignPatterns.BaseProject.Models;

namespace WebApp.ObserverPattern.Observer
{
    public interface IUserObserver
    {
        void UserCreated(AppUser appUser);
    }
}
