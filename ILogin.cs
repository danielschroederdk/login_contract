namespace DefaultNamespace
{
    public interface ILogin
    {
        //Will return true if the username and password entered by the user matched a valid
        //username and password in the DB, and will return false if the username
        //and password entered by the user did not match a valid username and password in the
        //DB.
        bool ValidateLogin(string username, string password, string connection_string);
        //Will return true if the username and the password fields are not empty, otherwise
        //it will return false.
        bool ValidateEmptyFields(string username, string password);
        //Will return true if the username filed only containg letters, hyphen(-) and
        //underscore(-), otherwise it will return false.
        bool ValidateUsername(string username);
        //It will return true if the password field length is more than 6 characters,
        //otherwise it will return false.
        bool ValidatePasswordLength(int password_lenght);
        //It will return true if the username and the password fields length is not more than
        //50 characters, otherwise it will return false.
        bool ValidateMaxLength(int username_lenght, int password_length);

    }
}