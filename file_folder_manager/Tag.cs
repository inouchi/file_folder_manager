using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_folder_manager
{
    internal class Tag
    {
        public List<string> Keywords { get; set; }
        public bool IsFavorited { get; set; }

        public Tag()
        {
            Keywords = new List<string>();
            IsFavorited = false;
        }

        public Tag(List<string> keywords, bool isFavorited)
        {
            Keywords = keywords;
            IsFavorited = isFavorited;
        }

    }
}
