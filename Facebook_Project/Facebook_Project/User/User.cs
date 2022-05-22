using Facebook_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facebook_Project.User
{
    public class User1
    {
        private AccountDatabaseEntities db = new AccountDatabaseEntities();

        public userinfo userinfo = new userinfo();

        public userinfo login(string email, string pass)
        {
            if (email == "" || pass == "")
            {
                return null;
            }
            userinfo = db.userinfos.Where(x => x.email == email && x.password == pass).FirstOrDefault();
            if (userinfo == null)
            {
                return null;
            }
            return userinfo;
        }

        public post write(string postcon, int id)
        {
            try
            {
                post post = new post();
                post.postone = postcon;
                post.userinfo.Id = id;
                db.posts.Add(post);
                db.SaveChanges();
                return post;
            }
            catch
            {
                return null;
            }
        }

        public userinfo GetUserinfo(string id)
        {
            return db.userinfos.Find(Convert.ToInt32(id));
        }

    }
}