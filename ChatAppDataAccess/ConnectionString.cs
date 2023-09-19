namespace ChatAppDataAccess
{
    internal class ConnectionString
    {
        public static string Connection
        {
            get
            {
                return "Data Source=.;Initial Catalog=ChatApp;Integrated Security=True;";
            }
        }
    }
}
