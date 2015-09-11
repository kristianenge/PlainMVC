using System.Threading.Tasks;
using Digipost.Api.Client.Domain.Search;


namespace PlainMVC.Services.Digipost
{
    public interface IDigipostService
    {
        ISearchDetailsResult Search(string searchText);
    }
}