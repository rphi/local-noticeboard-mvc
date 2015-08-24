using System.Collections.Generic;
using System.Linq;

namespace Local_Noticeboard_Mvc.Sql
{
    public class PostListTools
    {
        public IList<Post> SortPosts(IList<Post> postList, SortOrder order)
        {
            switch (order)
            {
                case SortOrder.Time:
                    return postList
                        .OrderByDescending(p => p.Timestamp)
                        .ToList();
                case SortOrder.Pid:
                    return postList
                        .OrderByDescending(p => p.PostId)
                        .ToList();
                case SortOrder.Title:
                    return postList
                        .OrderBy(p => p.Title)
                        .ToList();
                case SortOrder.VotesThenTime:
                    return postList
                        .OrderByDescending(p => p.Votes)
                        .ThenBy(p => p.Timestamp)
                        .ToList();
                default:
                    return postList;
            }
        }  
    }
}