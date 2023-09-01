using Newtonsoft.Json;
using System.Text;

namespace LibreTranslate
{
    public class Translation
    {
        public async Task<string> Translate(string text, string lang)
        {
            HttpClient client = new HttpClient();
            var body =  new
            {
                q = text,
                source = "pt",
                target = lang,
                format = "text",
                api_key = ""
            };

            var bodyJson = JsonConvert.SerializeObject(body);
            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://libretranslate.org/translate", content);
            var textResponse = await response.Content.ReadAsStringAsync();

            var translatedText = JsonConvert.DeserializeObject<ApiResponse>(textResponse).TranslatedText;

            return translatedText;
        }
    }
}