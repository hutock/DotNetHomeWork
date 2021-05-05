﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;

        private Queue<string> pending = new Queue<string>();

        private Dictionary<string, bool> urls = new Dictionary<string, bool>();

        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";

        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
        
        public string startUrl { get; set; }

        //public int count { get; set; }

        public Encoding encoding { get; set; }

        public int Maxpage { get; set; }

        public string HostFilter { get; set; }

        public string FileFilter { get; set; } 

        public Crawler()
        {
            Maxpage = 100;
            this.encoding = Encoding.UTF8;
        }

        public void Craw()
        {
            urls.Clear();
            pending.Clear();
            pending.Enqueue(this.startUrl);

            while (this.urls.Count < this.Maxpage && pending.Count > 0)
            {
                string current = pending.Dequeue();
                try
                {
                    string html = DownLoad(current);
                    urls[current] = true;
                    PageDownloaded(this, current, "OK");
                    Parse(html, current);
                }
                catch(Exception ex)
                {
                    PageDownloaded(this, current, "Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }

        public string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = this.encoding;
            string html = webClient.DownloadString(url);
            string fileName = urls.Count.ToString();
            File.WriteAllText(fileName, html, this.encoding);
            return html;
        }

        public void Parse(string html, string url)
        {
            var matches = new Regex(this.urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, url);

                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                    urls.Add(linkUrl, false);
                }
            }
        }

        public string FixUrl(string url, string page)
        {
            if(url.Contains("://"))
            {
                return url;
            }

            if(url.StartsWith("://"))
            {
                return "http" + url;
            }

            if(url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(page, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if(url.StartsWith("../"))
            {
                int i = page.LastIndexOf('/');
                return FixUrl(url.Substring(3), page.Substring(0, i));
            }

            if(url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), page);
            }

            int end = page.LastIndexOf("/");
            return page.Substring(0, end) + "/" + url;
        }
    }
}
