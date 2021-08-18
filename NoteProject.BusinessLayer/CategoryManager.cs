using NoteProject.BusinessLayer.Abstract;
using NoteProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.BusinessLayer
{
    public class CategoryManager:ManagerBase<Category>
    {        
        //public override int Delete(Category category)
        //{
        //    NoteManager noteManager = new NoteManager();
        //    LikedManager likedManager = new LikedManager();
        //    CommentManager commentManager = new CommentManager();
        //    // Kategori ile ilişkili notların silinmesi gerekiyor

        //    foreach (Note note in category.Notes.ToList())
        //    {
        //        //Note ile ilişkili likeların silinmesi gerekiyor
        //        foreach (Liked like in note.Likes.ToList())
        //        {
        //            likedManager.Delete(like);
        //        }

        //        //Note ile ilişkili commentleri silinmesi gerekiyor
        //        foreach (Comment comment in note.Comments.ToList())
        //        {
        //            commentManager.Delete(comment);
        //        }

        //        noteManager.Delete(note);
        //    }

        //    return base.Delete(category);
        //}

        /*Category Silmek için ilk olarak notlarını => notu silmek için ise yorum ve likelarını silememiz gerekiyor
        3 Yöntem var
            1-Yukarıdaki gibi kod ile çözüm
            2-Database üzerinden ilişki özellikleri menüsünden InsertANDUpdate Specification => Cascade
            3-DatabaseContext dosyasına OnModelCreating methodunu yazıyoruz.
         */
    }
}
