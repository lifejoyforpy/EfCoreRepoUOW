﻿using RBACdemo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBACdemo.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IRoleRepository Role { get; }        
        IMenuItemRepository MenuItem { get; }
        int Complete();
    }
}