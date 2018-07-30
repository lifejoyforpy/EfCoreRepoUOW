﻿using RBACdemo.Core.Domain;
using RBACdemo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBACdemo.Infrastructure.Persistence.Repositories
{
   public class MenuItemRepository :Repository<MenuItem>, IMenuItemRepository
    {
        public RBACdemoContext _context => Context as RBACdemoContext;
        public MenuItemRepository(RBACdemoContext context) : base(context)
        {

        }
    }
}
