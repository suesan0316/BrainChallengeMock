using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BrainChallenge.Droid
{
    // TreePage: contains image resource ID and caption for a tree:
    public class MyPagerPage
    {
        // Image ID for this tree image:
        public int imageId;

        // Caption text for this image:
        public string caption;

        // Returns the ID of the image:
        public int ImageID { get { return imageId; } }

        // Returns the caption text for the image:
        public string Caption { get { return caption; } }
    }

    // Tree catalog: holds image resource IDs and caption text:
    public class MyPagerCatalog
    {
        // Built-in tree catalog (could be replaced with a database)
		static MyPagerPage[] myPagerBuiltInCatalog = {
            new MyPagerPage { imageId = Resource.Drawable.larch,
                           caption = "No.1: The Larch" },
            new MyPagerPage { imageId = Resource.Drawable.maple,
                           caption = "No.2: Maple" },
            new MyPagerPage { imageId = Resource.Drawable.birch,
                           caption = "No.3: Birch" },
            new MyPagerPage { imageId = Resource.Drawable.coconut,
                           caption = "No.4: Coconut" },
            new MyPagerPage { imageId = Resource.Drawable.oak,
                           caption = "No.5: Oak" },
            new MyPagerPage { imageId = Resource.Drawable.fir,
                           caption = "No.6: Fir" },
            new MyPagerPage { imageId = Resource.Drawable.pine,
                           caption = "No.7: Pine" },
            new MyPagerPage { imageId = Resource.Drawable.elm,
                           caption = "No.8: Elm" },
        };

        // Array of tree pages that make up the catalog:
		private MyPagerPage[] myPagerPages;

        // Create an instance copy of the built-in tree catalog:
        public MyPagerCatalog () { myPagerPages = myPagerBuiltInCatalog; }

        // Indexer (read only) for accessing a tree page:
        public MyPagerPage this[int i] { get { return myPagerPages[i];  } }

        // Returns the number of tree pages in the catalog:
        public int NumTrees {  get { return myPagerPages.Length; } }
    }
}