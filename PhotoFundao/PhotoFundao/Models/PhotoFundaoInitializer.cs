using System;
using System.Collections.Generic;
using System.Data.Entity;

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
                //PhotoFile = getFileBits("")
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
    }
}