using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentBoxServiceAPI.Models
{
    public class CommentRepo
    {
        CommentBoxServiceEntities db = new CommentBoxServiceEntities();


        //Select All
        public IEnumerable<Comments> GetAllComments()
        {
            return db.Comments;
        }

        //Select by id
        public Comments GetCommentById(int id)
        {
            return db.Comments.Find(id);
        }

        //Insert
        public Comments CreateComments(Comments comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return comment;
        }

        //Update
        public Comments UpdateComment(int id,Comments comment)
        {
            db.Entry(comment).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return comment;

           
        }

        //Delete
        public void DeleteComment(int id)
        {
            db.Comments.Remove(db.Comments.Find(id));
            db.SaveChanges();
        }

    }
}