using Newtonsoft.Json.Linq;

namespace Services
{
    public class ColorService
    {
        private static readonly string apiUrl = "https://www.thecolorapi.com/id?hex=";

        public async Task<string> GetColorNameByHex(string hex)
        {
            string url = $"{apiUrl}{hex.Trim('#')}";
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JObject jsonObject = JObject.Parse(json);
                return jsonObject["name"]["value"].ToString();
            }
            else
            {
                throw new Exception($"Erro ao acessar a API para a cor {hex}");
            }
        }
    }
}
