using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Web;

namespace PhotoFundao.Models
{
    public class PhotoFundaoInitializer : DropCreateDatabaseAlways<PhotoFundaoContext>
    {
        protected override void Seed(PhotoFundaoContext context)
        {
            var photos = new List<Photo>();

            var photo = new Photo()
            {
                Title = "Test Photo",
                Description = "Photo bunitinha!",
                UserName = "NaokiSato",
                PhotoFile = getFileBytes("/Images/flower.JPG"),
                ImageMimeType = "image/jpeg",
                CreatedDate = DateTime.Now
            };

            var comments = new List<Comment>();

            var comment = new Comment()
            {
                UserName = "NaokiSato",
                Subject = "Teste comment",
                Body = "Comentário legal"
            };

            photo.Comments = comments;
            photos.Add(photo);

            photos.ForEach(x => context.Photos.Add(x));

            context.SaveChanges();
        }

        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }
    }
}