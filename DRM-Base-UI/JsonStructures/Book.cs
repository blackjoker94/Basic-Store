using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRM_Base_UI.JsonStructures
{
    class Book
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string image_path { get; set; }
        public string path { get; set; }
        public string drm_key { get; set; }
        public string certificate { get; set; }
        public string grade { get; set; }
    }
}
