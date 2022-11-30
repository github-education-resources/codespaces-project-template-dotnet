using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class AboutMe
    {
        public virtual string Description { get; set; } = string.Empty;
        public virtual List<string> Skills { get; set; } = new List<string>();
        public virtual string DetailOrQuote { get; set; } = string.Empty;
    }
}