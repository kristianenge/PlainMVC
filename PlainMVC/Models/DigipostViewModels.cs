using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Digipost.Api.Client.Domain.Search;


namespace PlainMVC.Models
{
    public class DigipostSearchModel
    {
        public string SearchQuery { get; set; }
        public List<ISearchDetails> SearchDetails
        {
            get;
            set;
        }
    }
}