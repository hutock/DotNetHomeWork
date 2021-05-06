using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{

    //http://www.cnblogs.com/dstang2000/
    public partial class Form1 : Form
    {
        public BindingSource urlSource = new BindingSource();
        Crawler crawler = new Crawler();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = urlSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = urlSource.Count + 1, URL = url, Status = info };
            Action action = () => { urlSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
            
        }
        private void CrawThisBtn_Click(object sender, EventArgs e)
        {
            urlSource.Clear();
            crawler.startUrl = UrlTxt.Text;

            Match host = Regex.Match(crawler.startUrl, Crawler.urlParseRegex);
            crawler.HostFilter = "^" + host.Groups["host"].Value + "$";
            crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";

            new Thread(crawler.Craw).Start();
            
        }
    }
}
