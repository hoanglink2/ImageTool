using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrDownLoadImage.Model
{
    public class ExifDTO
    {
        public List<string> Tag { get; set; }
        public string Title { get; set; }
        public List<string> Author { get; set; }
        public string CopyRight { get; set; }
    }
}
