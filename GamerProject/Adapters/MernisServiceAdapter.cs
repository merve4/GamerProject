using GamerProject.Abstract;
using GamerProject.Entity;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient((KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12));
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.YearOfBirth);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
