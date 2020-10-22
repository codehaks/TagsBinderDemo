using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagsBinderDemo.Common;

namespace TagsBinderDemo.Models
{
    public class Video
    {
        public string Name { get; set; }

        [ModelBinder(typeof(TagsModelBinder))]
        public string[] Tags { get; set; }
    }
}
