﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapEra.ScrapEngine
{
    public class Core
    {
        public static CrawlerEngine GetInstance()
        {
            return new CrawlerEngine();
        }
    }
}