namespace Local_Noticeboard_Mvc.Sql
{
    public class User
    {
        private readonly int _uid;
        private readonly string _username;
        private readonly string _profileImageUrl;

        public User(int uid, string username, string profileImageUrl)
        {
            _uid = uid;
            _username = username;
            _profileImageUrl = profileImageUrl;
        }
    }
}