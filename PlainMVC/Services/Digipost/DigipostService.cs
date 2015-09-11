using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Digipost.Api.Client;
using Digipost.Api.Client.Api;
using Digipost.Api.Client.Domain.Enums;
using Digipost.Api.Client.Domain.Identify;
using Digipost.Api.Client.Domain.Search;
using log4net.Repository.Hierarchy;


namespace PlainMVC.Services.Digipost
{
    public sealed class DigipostService : IDigipostService
    {
        static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static DigipostClient digipostClient;

        public ISearchDetailsResult Search(string searchText)
        {
            ISearchDetailsResult result = null;
            logger.Debug("inside Search(" + searchText + ")");
            try
            {
                logger.Debug("Search async init()");

                result = GetClient().Search("kristian");
                logger.Debug("Search async done()");
            }
            catch (Exception e)
            {
                logger.Error(e.Message, e);
                throw;
            }

            return result;
        }

        private void testConnectivity()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://www.vg.no").Result;
        }

        private void testDigipost()
        {
            var identification = new Identification(IdentificationChoiceType.PersonalidentificationNumber, "31108446911");
            try
            {
                var response = GetClient().Identify(identification);
            }
            catch (Exception e)
            {
                logger.Error(TraceEventType.Error, e);
                throw;
            }
        }

        private static DigipostClient GetClient()
        {
            return digipostClient ?? InitClient();
        }

        private static DigipostClient InitClient()
        {
            const string thumbprint = "d6 5e 6c 4c 77 fc 0e 0d c5 f5 ac 32 bc 43 70 1f a8 b0 3d 21";
            const string senderId = "779052";
            const string url = "https://api.digipost.no";

            var config = new ClientConfig(senderId, url, 10000, false)
            {
                Logger = Logging.Log()

            };


            digipostClient = new DigipostClient(config, thumbprint);

            return digipostClient;
        }


    }

    
}