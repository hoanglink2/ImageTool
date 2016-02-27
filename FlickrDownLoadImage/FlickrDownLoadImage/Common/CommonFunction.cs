using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using FlickrDownLoadImage.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using FlickrDownLoadImage.Model;
using System.Configuration;
using System.Web;
using System.Text.RegularExpressions;

namespace FlickrDownLoadImage.Common
{
    public class CommonFunction
    {
        /// <summary>
        /// get response
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string RequestMethod(string URL){
            string sDataReturn;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                Stream inputStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(inputStream, Encoding.UTF8);
                sDataReturn = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                sDataReturn = ex.Message;
            }
            return sDataReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string getSingleLargeImage(string url)
        {
            string sReturn = "false";
            string PageSource = RequestMethod(url);
            string LargeFolder = Properties.Settings.Default.LargeFolder;
                string LargeImgURL = getOriginalImaage(PageSource, "", 3);
                if (!LargeImgURL.Equals(""))
                {
                    List<ImageDTO> arrImageList = new List<ImageDTO>();
                    ImageDTO _ImageDTO = new ImageDTO();
                    _ImageDTO.sArtistName = "hoang dinh thanh";
                    _ImageDTO.sArtistUserName = "hoang dinh thanh";
                    _ImageDTO.sDescription = "";
                    _ImageDTO.sTitle = "";
                    _ImageDTO.sUrl = url;
                    _ImageDTO.sFolderName = "LargeImage";
                    //_ImageDTO.
                    arrImageList.Add(_ImageDTO);
                    long nIndex = DatabaseController.saveLargeImageInfo(arrImageList);
                    sReturn = DownloadImage(LargeImgURL, LargeFolder, nIndex + ".jpg");
                    if (sReturn == "0")
                    {
                        sReturn = "Success";
                    }
                    else
                    {
                        sReturn = "fail";
                    }
                }
                return sReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="isDlOrg"></param>
        /// <returns></returns>
        public static string getSingleOriginalImage(string url)
        {
            string sReturn = "Fail";
            string PageSource = RequestMethod(url);
            string OrgImgURL = getOriginalImaage(PageSource, "", 2);
            string shutterstockOrgFolder = Properties.Settings.Default.shutterstockFolder;
            string shutterstockLargeFolder = Properties.Settings.Default.shutterstockLargeFolder;
            try
            {

                if (!OrgImgURL.Equals(""))
                {
                    //string pattern = @"//";
                    //Regex rgx = new Regex(pattern);
                    //OrgImgURL = rgx.Replace(OrgImgURL.Trim(), "/");
                    OrgImgURL = OrgImgURL.Replace("/", "");
                    OrgImgURL = OrgImgURL.Replace("\\", "/");
                    OrgImgURL = "http://" + OrgImgURL;
                    List<ImageDTO> arrImageList = new List<ImageDTO>();
                    ImageDTO _ImageDTO = new ImageDTO();
                    _ImageDTO.sArtistName = "hoang dinh thanh";
                    _ImageDTO.sArtistUserName = "hoang dinh thanh";
                    _ImageDTO.sDescription = "";
                    _ImageDTO.sTitle = "";
                    _ImageDTO.sUrl = url;
                    _ImageDTO.sFolderName = "ShutterStock";
                    arrImageList.Add(_ImageDTO);
                    long nIndex = DatabaseController.saveShutterImageInfo(arrImageList);
                    string LargeImgURL = getOriginalImaage(PageSource, "", 3);
                    if (!LargeImgURL.Equals(""))
                    {
                        sReturn = DownloadImage(LargeImgURL, shutterstockLargeFolder, nIndex + ".jpg");
                    }
                    sReturn = DownloadImage(OrgImgURL, shutterstockOrgFolder, nIndex + ".jpg");
                    if (sReturn == "0")
                    {
                        sReturn = "Success";
                    }
                    else
                    {
                        sReturn = "Fail";
                    }
                }
            }
            catch (Exception ex)
            {
                // nothing
            }
            return sReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <param name="folder"></param>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public static string DownloadImageJSON(string json, string folderName)
        {
            string sMessage = "";
            List<ImageDTO> arrImageList = new List<ImageDTO>();
            List<ImageDTO> arrOrgImageList = new List<ImageDTO>();
            ImageDTO objImageDTO;
            ImageDTO objOrgImageDTO;
            try {
                dynamic jsonResponse = JObject.Parse(json);
                string ImageFolder = Properties.Settings.Default.ImageFolder;
                string OriginalFoder = Properties.Settings.Default.OriginalFolder;
                //string ImageFolder = @"F:\PRIVATE\MMO\images\Flickr\";
                string dir = ImageFolder + folderName;
                string orgdir = OriginalFoder + folderName;
                System.IO.Directory.CreateDirectory(dir);
                System.IO.Directory.CreateDirectory(orgdir);
                string url;
                string urlP;
                string urlO;
                string PageSource;
                int nIndex = 0;
                int nCountOrgImage = 0;
                string OrgImgURL;
                foreach (dynamic img in jsonResponse.photos._data)
                {
                    try
                    {
                        #region get Large Image
                        nIndex++;
                        try
                        {
                            url = img.sizes.l.url.Value;
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                        url = "https:" + url;
                        urlO = "https://www.flickr.com/photos/" + img.pathAlias + "/" + img.id;
                        objImageDTO = new ImageDTO();
                        DownloadImage(url, dir, nIndex + ".jpg");
                        objImageDTO.sUrl = urlO;
                        objImageDTO.sTitle = img.title;
                        objImageDTO.sArtistName = img.realname;
                        objImageDTO.sArtistUserName = img.username;
                        objImageDTO.nFaveCount = img.faveCount;
                        objImageDTO.nCommentCount = img.commentCount;
                        objImageDTO.nLicense = img.license;
                        objImageDTO.nWidth = img.sizes.l.width;
                        objImageDTO.nHeight = img.sizes.l.height;
                        objImageDTO.sDescription = img.description;
                        objImageDTO.sFolderName = folderName;
                        objImageDTO.nIndex = nIndex;
                        arrImageList.Add(objImageDTO);
                        #endregion

                        #region get Original Image

                        urlP = url.Substring(0, url.Length - 17);
                        PageSource = CommonFunction.RequestMethod(urlO);
                        OrgImgURL = getOriginalImaage(PageSource, urlP, 1);
                        if (!OrgImgURL.Equals(""))
                        {
                            //nCountOrgImage++;
                            DownloadImage(OrgImgURL, orgdir, nIndex + ".jpg");
                            //objOrgImageDTO = objImageDTO;
                            //objOrgImageDTO.sUrl = OrgImgURL;
                            //objOrgImageDTO.nIndex = nCountOrgImage;
                            //arrOrgImageList.Add(objOrgImageDTO);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                sMessage = nCountOrgImage.ToString();
                DatabaseController.saveImageInfo(arrImageList);
                //DatabaseController.saveImageInfo(arrOrgImageList, true);
            }
            catch (Exception ex)
            {
                sMessage = ConstantValue.Fail;
            }

            return sMessage;
        }
        /// <summary>
        /// get URL of Original Image
        /// </summary>
        /// <returns></returns>
        public static string getOriginalImaage(string sPageSource,string urlP, int nType)
        {
            string sOriginalURL = "";
            string pattern = "_o.jpg";
            if (nType == 3)
            {
                pattern = "_b.jpg";
            }
            string originalCode = "";
            try
            {
                if (sPageSource.Contains(pattern))
                {
                    if (nType == 1)
                    {
                        originalCode = sPageSource.Substring(sPageSource.IndexOf(pattern) - 10, 10);
                        sOriginalURL = urlP + "_" + originalCode + pattern;
                    }
                    else if(nType == 2)
                    {
                        sOriginalURL = sPageSource.Substring(sPageSource.IndexOf(pattern) - 52, 58);
                    }
                    else if (nType == 3)
                    {
                        sOriginalURL = sPageSource.Substring(sPageSource.IndexOf(pattern) - 57, 63);
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return sOriginalURL;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="folder"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string DownloadImage(string uri, string folder, string fileName)
        {
            HttpWebResponse response;
            HttpWebRequest request;
            try
            {
                uri = HttpUtility.UrlDecode(uri);
                request = (HttpWebRequest)WebRequest.Create(uri);
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                return ConstantValue.Fail;
            }

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download it
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(folder + "\\" + fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
                return ConstantValue.Success;
            }
            else
                return ConstantValue.Fail;
        }
    }
}
