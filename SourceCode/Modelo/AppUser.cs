namespace SourceCode.Modelo
{
    public class AppUser
    {
        public int idUser { get; set; }
        public string fullName { get; set;}
        public string userName { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public AppUser()
        {
            idUser = -1;
            fullName = "";
            userName = "";
            password = "";
            userType = true;
        }
    }
}