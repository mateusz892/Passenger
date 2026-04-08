namespace Passenger.Infrastructure.Services
{
    /*
        Jedyna opcja aby sprawdzic czy użytkownik się zalogował to ponownie wygeneowac sól i 
        na jej podstawie stworzyć hasha i dokonać porównania
    */
    public interface IEncrypter
    {
        string GetSalt(string value); // genralizując bezpieczny losowy ciag znaków
        string GetHash(string value, string salt); // na podstawie soli szyfrujemy hasło w jedna stronę
    }
}
