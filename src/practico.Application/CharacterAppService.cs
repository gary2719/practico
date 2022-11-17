using practico.Domain;
namespace practico.Application;

public class CharacterAppService : ICharacterRepository
{
    public ICollection<Root> MetodoGet()
    {
        

        var url = "https://rickandmortyapi.com/api/character";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;

                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        // Do something with responseBody
                        Console.WriteLine(responseBody);
                    }
                }
            }
        }
        catch (WebException ex)
        {
            // Handle error
        }

        return null;
    }
}
