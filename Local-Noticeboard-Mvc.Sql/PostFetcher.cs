using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Local_Noticeboard_Mvc.Sql
{
    public class PostFetcher
    {
        // This class should handle all of the post-fetching SQL duties
        // and produce a list of posts

        public Table<Post> FetchPosts(int limit, PostCategory category)
        {
            // SQL magic goes here

            var context = new DataClassesDataContext();

            var posts = context.Posts;

            var post = posts.FirstOrDefault().Title;

            return posts;
        } 
    }
}