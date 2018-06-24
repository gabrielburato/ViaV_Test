using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Domain.Entity;

namespace ViaVarejo.Domain.Interface
{
    public interface IFriend
    {
       List<Friend> VerifyNearlyFriend(Friend actualFriend);

        List<Friend> List();

        void LogOperation(Log log); 
    }
}
