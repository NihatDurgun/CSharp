using FireSharp.Config;

namespace yazlab11
{
    class credential
    {
        public static string db_Name = "https://yazlab-52a9a-default-rtdb.europe-west1.firebasedatabase.app/";
        public static string db_Credential = "qLLoV0sxTYYzvfL7zjHShC1keztm7scIZdsK61cD";

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = db_Credential,
            BasePath = db_Name
        };
    }
}
