using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Wp_World.Models
{
    public class Article
    {
        public string title { get; set; }
        public string link { get; set; }
        public DateTime publishDate { get; set; }
        public String ParsedDateTime { get; set; }
        public string publishDateStr { get; set; }
        public string author { get; set; }
        public string description
        {
            get { return _description; }
            set
            {
                _description = value;
                int first = _description.IndexOf("src=") + 5;
                int length = _description.IndexOf("class") - 2 - first;
                if (length < 0)
                {
                    image = null;
                }
                else
                {
                    string url = _description.Substring(first, length);
                    image = new BitmapImage(new Uri(url, UriKind.Absolute));
                }
            }

        }
        public int commentCount { get; set; }
        public BitmapImage image { get; set; }
        public string ID { get; set; }

        private string _description;

        public Article(string _t, string _l, DateTime _p, string _a, string _d, int _c, string _id)
        {
            title = _t;
            link = _l;
            publishDate = _p;
            author = _a;
            description = _d;
            commentCount = _c;
            ID = _id;
            ParsedDateTime = _p.ToString("G", DateTimeFormatInfo.InvariantInfo);
        }

        public Article() { }
    }
}
