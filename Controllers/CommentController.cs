using CommentBoxServiceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CommentBoxServiceAPI.Controllers
{
    public class CommentController : ApiController
    {

        CommentRepo commentRepo = new CommentRepo();

        public HttpResponseMessage Get()
        {
            var comments = commentRepo.GetAllComments();
            return Request.CreateResponse(HttpStatusCode.OK, comments);
        }

        public Comments Get(int id)
        {
            return commentRepo.GetCommentById(id);
        }

        public Comments Post(Comments comment)
        {
            return commentRepo.CreateComments(comment);
        }

        public Comments Put(int id,Comments comment)
        {
            return commentRepo.UpdateComment(id, comment);
        }

        public void Delete(int id)
        {
            commentRepo.DeleteComment(id);
        }

    }
}
