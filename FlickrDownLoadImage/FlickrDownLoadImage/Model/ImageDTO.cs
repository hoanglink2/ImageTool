using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrDownLoadImage.Model
{
    public class ImageDTO
    {
        public long lID { get; set; }
        public string sTitle { get; set; }
        public string sArtistName { get; set; }
        public string sArtistUserName { get; set; }
        public int nFaveCount { get; set; }
        public int nCommentCount { get; set; }
        public int nLicense { get; set; }
        public int nWidth { get; set; }
        public int nHeight { get; set; }
        public string sUrl { get; set; }
        public string sDescription { get; set; }
        public string sFolderName { get; set; }
        public int nIndex { get; set; }
        
    }
}
