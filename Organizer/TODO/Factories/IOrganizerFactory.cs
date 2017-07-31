﻿using TODO.Contracts;

namespace TODO.Factories
{
    interface IOrganizerFactory
    {
        IUser CreateUser(string username, string password);
    }
}
