﻿using AspNetCoreDesignPatterns.BaseProject.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace WebApp.ObserverPattern.Observer
{
    public class UserObserverWriteToConsole : IUserObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public UserObserverWriteToConsole(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void UserCreated(AppUser appUser)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverWriteToConsole>>();
            logger.LogInformation($"User created: Id = {appUser.Id}");
        }
    }
}
