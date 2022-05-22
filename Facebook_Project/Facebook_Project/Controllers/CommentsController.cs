﻿using Facebook_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Facebook_Project.Controllers
{
    public class CommentsController : ApiController
    {
        private AccountDatabaseEntities db = new AccountDatabaseEntities();
        public string post()
        {
            try
            {
                int iduser = Convert.ToInt32(HttpContext.Current.Request.Form["iduser"]);
                int idpost = Convert.ToInt32(HttpContext.Current.Request.Form["idpost"]);
                string comment = HttpContext.Current.Request.Form["comment"];

                comments comm = new comments();
                comm.idpost = idpost;
                comm.iduserinfo = iduser;
                comm.comment = comment;
                comm.userinfo = db.userinfos.Find(iduser);
                comm.post = db.posts.Find(idpost);
                db.comments.Add(comm);
                db.SaveChanges();
            }
            catch
            {
                return "badjop";
            }

            return "goodjop";
        }
    }
}
