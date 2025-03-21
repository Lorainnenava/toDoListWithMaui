﻿namespace ToDoList.Helpers.Services
{
    public static class ServiceHelper
    {
        public static IServiceProvider Services { get; set; }

        public static T GetService<T>() => Services.GetRequiredService<T>();
    }
}
