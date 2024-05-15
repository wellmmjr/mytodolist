using Microsoft.AspNetCore.Mvc;
using mytodolist.Data.DTO;
using mytodolist.Hypermedia.Constants;
using mytodolist.Hypermedia;
using System.Text;
using System.Threading.Tasks;

namespace mytodolist.Hypermedia.Enricher
{
    public class ListaTarefaEnricher : ContentResponseEnricher<ListaTarefaDTO>
    {
        private readonly object _locker = new object();

        protected override Task EnrichModel(ListaTarefaDTO content, IUrlHelper urlHelper)
        {
            var path = "v1/api/tasklist";
            string link = getLink(content.Id, urlHelper, path);

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPut
            });
            
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.PATCH,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPatch
            });
            
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.DELETE,
                Href = link,
                Rel = RelationType.self,
                Type = "int"
            });

            return null;
        }

        private string getLink(long id, IUrlHelper urlHelper, string path)
        {
            lock (_locker)
            {
                var url = new
                {
                    controller = path,
                    id = id,
                };
                return new StringBuilder(urlHelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            }
        }
    }
}
