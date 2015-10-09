using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Wp_World.Models;


namespace Wp_World.Services
{
    public static class Rss
    {


        public static string RSS_adress;

        public static async  Task<List<Article>> loadArticles()
        {
            String rssContent = "";
            using (HttpClient httpClient = new HttpClient())
                rssContent = await httpClient.GetStringAsync(RSS_adress);
            XDocument document = XDocument.Parse(rssContent);


            //Namespaces 
            XNamespace dc = XNamespace.Get("http://purl.org/dc/elements/1.1/");
            XNamespace slash = XNamespace.Get("http://purl.org/rss/1.0/modules/slash/");

            List<Article> result = new List<Article>();

            foreach (XElement descendant in document.Descendants("item"))
            {
                result.Add(new Article()
                {
                    title = descendant.Element("title").Value,
                    link = descendant.Element("link").Value,
                    publishDate = DateTime.Parse(descendant.Element("pubDate").Value),
                    author = descendant.Element(dc + "creator").Value,
                    description = descendant.Element("description").Value,
                    commentCount = Int32.Parse(descendant.Element(slash + "comments").Value),
                    ID = descendant.Element("guid").Value.Substring(22)
                });

            }
            //Get list 
            /*List<Article> result = (from descendant in document.Descendants("item")
                                    select new Article()
                                    {
                                        title = descendant.Element("title").Value,
                                        link = descendant.Element("link").Value,
                                        publishDate = DateTime.Parse(descendant.Element("pubDate").Value),
                                        author = descendant.Element(dc + "creator").Value,
                                        description = descendant.Element("description").Value,
                                        commentCount = Int32.Parse(descendant.Element(slash + "comments").Value),
                                        ID = descendant.Element("guid").Value.Substring(22)
                                    }).ToList<Article>();*/
            return result;
        }
}
}
