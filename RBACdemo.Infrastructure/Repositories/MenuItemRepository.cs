﻿using RBACdemo.Core;
using RBACdemo.Core.Domain;
using RBACdemo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBACdemo.Infrastructure.Repositories
{
   public class MenuItemRepository :Repository<MenuItem>, IMenuItemRepository
    {
        public RBACdemoContext _context => Context as RBACdemoContext;
        public MenuItemRepository(IContextFactory context) : base(context)
        {

        }
    }
}
