using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.Proxy.Easy.ImageLoader
{
    internal interface IImage
    {
        void display(string url);
    }

    internal class RealImage : IImage
    {
        public RealImage() { }
        public void display(string url)
        {
            Console.WriteLine($"Loading image {url}");
            Thread.Sleep(5000);
            Console.WriteLine($"Displaying image {url}");
        }
    }

    internal class ProxyImage : IImage
    {
        private RealImage _realImage;

        public ProxyImage() 
        {
            _realImage = null;
        }
        public void display(string url) 
        {
            Console.WriteLine("Checking if real image object exists ");
            if (_realImage == null)
            {
                Console.WriteLine("RealImage object not found, Creating real image object");
                _realImage = new RealImage();
            }
            Console.WriteLine("Adding lazy loading...");
            _realImage.display(url);
        }
    }

    // IGNORE FOR NOW (TILL I REMOVE IT

    //internal class ImageLoader
    //{
    //    protected ProxyImage proxyImage;
    //    protected string url;

    //    public ImageLoader(string url)
    //    {
    //        proxyImage = new ProxyImage();
    //        this.url = url;
    //    }

    //    public void loadImage()
    //    {
    //        proxyImage.display(url);
    //    }
    //}
}
