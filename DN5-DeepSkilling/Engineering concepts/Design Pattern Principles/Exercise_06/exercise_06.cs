using System;


namespace ProxyPatternExample
{
    
    interface IImage
    {
        void Display();
    }

    
    class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromServer();           
        }

        private void LoadFromServer()
        {
            Console.WriteLine("Loading image from server: " + filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying: " + filename);
        }
    }

    
    class ProxyImage : IImage
    {
        private string    filename;
        private RealImage realImage = null;   

        public ProxyImage(string filename)
        {
            this.filename = filename;
            
        }

        public void Display()
        {
            
            if (realImage == null)
            {
                realImage = new RealImage(filename);  
            }
            else
            {
                Console.WriteLine("Using cached image: " + filename);
            }
            realImage.Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern - Image Viewer\n");

            IImage img1 = new ProxyImage("photo1.jpg");
            IImage img2 = new ProxyImage("photo2.jpg");

            
            Console.WriteLine(" First display of photo1 ");
            img1.Display();

            
            Console.WriteLine("\n Second display of photo1 (should use cache) ");
            img1.Display();

            
            Console.WriteLine("\n First display of photo2 ");
            img2.Display();
        }
    }
}
