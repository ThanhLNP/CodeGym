using System;

namespace ObjectOrientedProgramming
{
    class PhotoAlbumTarea
    {
        static void Main()
        {
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());
        }
    }
    public class PhotoAlbum
    {
        protected int numberOfPages;
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int value)
        {
            numberOfPages = value;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    public class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum() : base()
        {
            numberOfPages = 64;
        }
    }
}
