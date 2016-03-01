using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using FlickrDownLoadImage.Common;
using FlickrDownLoadImage.Model;
using System.Data.SqlClient;
using System.Data;


namespace FlickrDownLoadImage.Common
{
    public class DatabaseController
    {
        public static readonly string FlickrImageConnection = Properties.Settings.Default.flickrImageConnection;

        public static string saveImageInfo(List<ImageDTO> ImageList)
        {
            string sMessage = "";
            try
            {
                var connection = new MySqlConnection(FlickrImageConnection);
                //Open connection
                connection.Open();
                var sqlCommand = "";
                long nIndex = 0;
                //Compose query using sql parameters
                sqlCommand = "INSERT INTO imagelist VALUES(NULL,@title,@artist_Name,@artist_UserName,@faveCount,@commentCount,?@license,@width,@height,@url,@description,@folderName,@Index)";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sqlCommand;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@title", "title");
                cmd.Parameters.AddWithValue("@artist_Name", "artist_Name");
                cmd.Parameters.AddWithValue("@artist_UserName", "artist_UserName");
                cmd.Parameters.AddWithValue("@faveCount", 1);
                cmd.Parameters.AddWithValue("@commentCount", 1);
                cmd.Parameters.AddWithValue("@license", 0);
                cmd.Parameters.AddWithValue("@width", 300);
                cmd.Parameters.AddWithValue("@height", 300);
                cmd.Parameters.AddWithValue("@url", "url");
                cmd.Parameters.AddWithValue("@description", "description");
                cmd.Parameters.AddWithValue("@folderName", "folderName");
                cmd.Parameters.AddWithValue("@Index", 1);
                for (int i = 0; i < ImageList.Count ; i++)
                {
                    cmd.Parameters["@title"].Value = ImageList[i].sTitle;
                    cmd.Parameters["@artist_Name"].Value = ImageList[i].sArtistName == null ? "" : ImageList[i].sArtistName;
                    cmd.Parameters["@artist_UserName"].Value = ImageList[i].sArtistUserName == null ? "" : ImageList[i].sArtistUserName;
                    cmd.Parameters["@faveCount"].Value = ImageList[i].nFaveCount;
                    cmd.Parameters["@commentCount"].Value = ImageList[i].nCommentCount;
                    cmd.Parameters["@license"].Value = ImageList[i].nLicense;
                    cmd.Parameters["@width"].Value = ImageList[i].nWidth;
                    cmd.Parameters["@height"].Value = ImageList[i].nHeight;
                    cmd.Parameters["@url"].Value = ImageList[i].sUrl == null ? "" : ImageList[i].sUrl;
                    cmd.Parameters["@description"].Value = ImageList[i].sDescription == null ? "" : ImageList[i].sDescription;
                    cmd.Parameters["@folderName"].Value = ImageList[i].sFolderName;
                    cmd.Parameters["@Index"].Value = ImageList[i].nIndex;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                sMessage = ConstantValue.Fail;
            }
            return sMessage;
        }
        public static long saveLargeImageInfo(List<ImageDTO> ImageList)
        {
            string sMessage = "";
            long nIndex = 0;
            try
            {
                var connection = new MySqlConnection(FlickrImageConnection);
                //Open connection
                connection.Open();
                var sqlCommand = "";
                sqlCommand = "INSERT INTO largeimage VALUES(NULL,@title,@artist_Name,@artist_UserName,@width,@height,@url,@description,@folderName,@tag); SELECT last_insert_id();";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sqlCommand;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@title", "title");
                cmd.Parameters.AddWithValue("@artist_Name", "artist_Name");
                cmd.Parameters.AddWithValue("@artist_UserName", "artist_UserName");
                cmd.Parameters.AddWithValue("@width", 300);
                cmd.Parameters.AddWithValue("@height", 300);
                cmd.Parameters.AddWithValue("@url", "url");
                cmd.Parameters.AddWithValue("@description", "description");
                cmd.Parameters.AddWithValue("@folderName", "folderName");
                cmd.Parameters.AddWithValue("@tag", "");
                for (int i = 0; i < ImageList.Count; i++)
                {
                    cmd.Parameters["@title"].Value = ImageList[i].sTitle;
                    cmd.Parameters["@artist_Name"].Value = ImageList[i].sArtistName == null ? "" : ImageList[i].sArtistName;
                    cmd.Parameters["@artist_UserName"].Value = ImageList[i].sArtistUserName == null ? "" : ImageList[i].sArtistUserName;
                    cmd.Parameters["@width"].Value = ImageList[i].nWidth;
                    cmd.Parameters["@height"].Value = ImageList[i].nHeight;
                    cmd.Parameters["@url"].Value = ImageList[i].sUrl == null ? "" : ImageList[i].sUrl;
                    cmd.Parameters["@description"].Value = ImageList[i].sDescription == null ? "" : ImageList[i].sDescription;
                    cmd.Parameters["@folderName"].Value = ImageList[i].sFolderName;
                    cmd.Parameters["@tag"].Value = "";
                    nIndex = Convert.ToInt64(cmd.ExecuteScalar());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                nIndex = 0;
            }
            return nIndex;
        }

        public static long saveShutterImageInfo(List<ImageDTO> ImageList)
        {
            string sMessage = "";
            long nIndex = 0;
            try
            {
                var connection = new MySqlConnection(FlickrImageConnection);
                //Open connection
                connection.Open();
                var sqlCommand = "";
                sqlCommand = "INSERT INTO shutterimage VALUES(NULL,@title,@artist_Name,@artist_UserName,@width,@height,@url,@description,@folderName,@tag,@shutterID); SELECT last_insert_id();";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sqlCommand;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@title", "title");
                cmd.Parameters.AddWithValue("@artist_Name", "artist_Name");
                cmd.Parameters.AddWithValue("@artist_UserName", "artist_UserName");               
                cmd.Parameters.AddWithValue("@width", 300);
                cmd.Parameters.AddWithValue("@height", 300);
                cmd.Parameters.AddWithValue("@url", "url");
                cmd.Parameters.AddWithValue("@description", "description");
                cmd.Parameters.AddWithValue("@folderName", "folderName");
                cmd.Parameters.AddWithValue("@tag", "");
                cmd.Parameters.AddWithValue("@shutterID", "");
                for (int i = 0; i < ImageList.Count; i++)
                {
                    cmd.Parameters["@title"].Value = ImageList[i].sTitle;
                    cmd.Parameters["@artist_Name"].Value = ImageList[i].sArtistName == null ? "" : ImageList[i].sArtistName;
                    cmd.Parameters["@artist_UserName"].Value = ImageList[i].sArtistUserName == null ? "" : ImageList[i].sArtistUserName;                    
                    cmd.Parameters["@width"].Value = ImageList[i].nWidth;
                    cmd.Parameters["@height"].Value = ImageList[i].nHeight;
                    cmd.Parameters["@url"].Value = ImageList[i].sUrl == null ? "" : ImageList[i].sUrl;
                    cmd.Parameters["@description"].Value = ImageList[i].sDescription == null ? "" : ImageList[i].sDescription;
                    cmd.Parameters["@folderName"].Value = ImageList[i].sFolderName;
                    cmd.Parameters["@tag"].Value = "";
                    cmd.Parameters["@shutterID"].Value = "";
                    nIndex = Convert.ToInt64(cmd.ExecuteScalar());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                nIndex = 0;
            }
            return nIndex;
        }



        public static DataSet GetDataSet(string SQL)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(FlickrImageConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(SQL, conn);
                da.SelectCommand.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
