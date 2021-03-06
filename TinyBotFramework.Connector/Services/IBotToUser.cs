﻿using System.Threading.Tasks;
using TinyBotFramework.Connector.Model.Routing;

namespace TinyBotFramework.Connector.Services
{
    public interface IBotToUser
    {
        Task PostAsync(Message message);
    }
}