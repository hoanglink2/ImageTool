using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlickrDownLoadImage.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using FlickrDownLoadImage.Properties;


namespace FlickrDownLoadImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sMessage= "";
            string URL = "https://www.flickr.com/explore/";
            string dateTemp;
            string dateTemp2;
            string sDateTo = dtP_TimeTo.Value.ToString("yyyy/MM/dd");
            try
            {
                for (DateTime d = dtP_TimeFrom.Value; d <= dtP_TimeTo.Value; d = d.AddDays(1))
                {
                    dateTemp = d.ToString("yyyy/MM/dd");
                    dateTemp2 = d.ToString("yyyy-MM-dd");
                    string sURL_temp = URL + dateTemp;
                    string sExplorePage = CommonFunction.RequestMethod(sURL_temp);
                    string start = "modelExport: {" + @"""explore-models""" + ":[";
                    string end = @"""id""" + ": " + @"""" + dateTemp2 + @"""";
                    string end2 = @"""id""" + ":" + @"""" + dateTemp2 + @"""";
                    string json = ConstantValue.NoData;
                    string sResult;
                    int nOriginalImgCount = 0;
                    foreach (var myString in sExplorePage.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        int startIndex = myString.IndexOf(start);
                        if (startIndex == -1)
                        {
                            continue;
                        }
                        int endIndex = myString.IndexOf(end);
                        int lengthEnd = end.Length;
                        int lenthStart = start.Length;
                        startIndex = startIndex + lenthStart;
                        if (endIndex == -1)
                        {
                            endIndex = myString.IndexOf(end2);
                            lengthEnd = end2.Length;
                            endIndex = endIndex + lengthEnd;
                        }
                        json = myString.Substring(startIndex, endIndex - startIndex + 1);
                        sResult = CommonFunction.DownloadImageJSON(json, dateTemp2);
                        if (!sResult.Equals(ConstantValue.Fail))
                        {
                            nOriginalImgCount = nOriginalImgCount + Convert.ToInt32(sResult);
                        }
                    }
                    sMessage = String.Format("{0} Original Images", nOriginalImgCount);
                }

            }
            catch (Exception ex)
            {
                sMessage = ex.Message.ToString();
            }
            rtx_Message01.Text = sMessage;
            
        }

        private void btnDownload_Single_Click(object sender, EventArgs e)
        {
            string url = txtURL1.Text;
            string status = CommonFunction.getSingleOriginalImage(url);
            txtStatus.Text = status;
        }
    }
}
