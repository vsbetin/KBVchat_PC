﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using DataAccess.Repositories.Base;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class GroupRepository
        : IGroupRepository
    {
        KVBchatDbContext _context = null;

        public GroupRepository(KVBchatDbContext context)
        {
            _context = context;
        }

        public Group GetGroup(int id)
        {
            return _context.Groups.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Group> GetGroups()
        {
            return _context.Groups.ToArray();
        }

        public IEnumerable<Group> GetGroups(Expression<Func<Group, bool>> func)
        {
            return _context.Groups.Where(func).ToArray();

        }
    }
}