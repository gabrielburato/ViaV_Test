using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViaVarejo.Domain.Entity;
using ViaVarejo.Domain.Interface;

namespace ViaVarejo.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/Friend")]
    [Microsoft.AspNetCore.Cors.EnableCors("CorsPolicy")]
    public class FriendController : Controller
    {
        private readonly IFriend _IFriend;

        public FriendController(IFriend IFriend)
        {
            this._IFriend = IFriend;
        }

        [Microsoft.AspNetCore.Mvc.Route("List")]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public List<Friend> List()
        {
            return _IFriend.List(); 
        }

        [Microsoft.AspNetCore.Mvc.Route("ListNearFriend")]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Friend ListNearFriend(int idFriend)
        {
            var all = _IFriend.List();
            var actual = all.Where(x => x.Id == idFriend).FirstOrDefault();
            all.RemoveAll(x => x.Id == idFriend);
            Log logOp = new Log();
            decimal distance = 0;
            Friend near = new Friend();
            foreach(var friend in all)
            {
                var lat = friend.Latitude > actual.Latitude ? friend.Latitude - actual.Latitude : actual.Latitude - friend.Latitude;
                logOp.Calculo = "Diferença da latitude do amigo: " + friend.Name + " para a minha latitude atual: ";
                logOp.Resultado = lat.ToString();
                _IFriend.LogOperation(logOp);

                var lon = friend.Longitude > actual.Longitude ? friend.Longitude - actual.Longitude : actual.Longitude - friend.Longitude;
                logOp = new Log();
                logOp.Calculo = "Diferença da longitude do amigo: " + friend.Name + " para a minha longitude atual: ";
                logOp.Resultado = lon.ToString();
                _IFriend.LogOperation(logOp);

                if (distance > (lat+lon) || distance ==0)
                {
                    distance = (lat + lon);
                    near = friend;
                }

                logOp = new Log();
                logOp.Calculo = "Menor diferença de latitude e longitude";
                logOp.Resultado = "Amigo mais próximo:" + near.Name;
                _IFriend.LogOperation(logOp);
            }
            return near; 
        }

    }
}