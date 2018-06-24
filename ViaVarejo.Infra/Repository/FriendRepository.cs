using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViaVarejo.Domain.Entity;
using ViaVarejo.Domain.Interface;
using ViaVarejo.Infra.Config;

namespace ViaVarejo.Infra.Repository
{
    public class FriendRepository : IFriend
    {

        private ContextBase context;

        public FriendRepository(ContextBase context)
        {
            this.context = context;
        }

      
        public List<Friend> List()
        {
            return context.Friend.ToList();
        }

        public void LogOperation(Log log)
        {
            context.Log.Add(log);
            context.Entry(log).State = EntityState.Added;
            context.SaveChanges();
        }

        List<Friend> IFriend.VerifyNearlyFriend(Friend actualFriend)
        {
            throw new NotImplementedException();
        }
    }
}
