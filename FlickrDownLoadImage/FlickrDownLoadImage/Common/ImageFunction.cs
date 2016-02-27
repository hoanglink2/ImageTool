using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Media.Imaging;
using FlickrDownLoadImage.Model;
using System.Data.SqlClient;
using System.Data;

namespace FlickrDownLoadImage.Common
{
    public static class ImageFunction
    {

        public static readonly string FlickrImageConnection = Properties.Settings.Default.flickrImageConnection;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_exif"></param>
        /// <param name="path"></param>
        public static void WriteProperties(ExifDTO _exif, string path)
        {
            using (TagLib.File tagFile = TagLib.File.Create(path))
            {
                var image = tagFile as TagLib.Image.File;
                image.ImageTag.Exif.Keywords = _exif.Tag.ToArray();
                image.ImageTag.Keywords = _exif.Tag.ToArray();
                image.ImageTag.AlbumArtists = _exif.Author.ToArray();
                image.ImageTag.Copyright = _exif.CopyRight;
                image.ImageTag.Title = _exif.Title;
                image.Save();
            }

        }
        public static void writeDataImages(string path, string database, string indexFrom, string indexTo)
        {
            try
            {
                int nIndexFrom = Convert.ToInt32(indexFrom);
                int nIndexTo = Convert.ToInt32(indexTo);
                ExifDTO _exif;
                string sql = String.Format("select * from shutterimage where ID >= {0} and ID <= {1}", indexFrom, indexTo);
                DataSet ds = DatabaseController.GetDataSet(sql);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string ID = Convert.ToString(row["ID"]);
                        string finalPath = path + "\\" + ID + ".jpg";
                        _exif = new ExifDTO();
                        _exif.Author = new List<string>();
                        _exif.Author.Add("Hoang Dinh Thanh");
                        _exif.CopyRight = "©2016 Hoang Dinh Thanh";
                        _exif.Title = Convert.ToString(row["title"]);
                        string tags = Convert.ToString(row["tag"]);
                        List<string> tagsa = tags.Split(new[] { "," }, StringSplitOptions.None).ToList<string>();
                        _exif.Tag = tagsa;
                        WriteProperties(_exif, finalPath);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
