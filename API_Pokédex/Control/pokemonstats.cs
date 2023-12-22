using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using API_Pokédex.Model;

namespace API_Pokédex.Control
{
    internal class pokemonstats
    {
        public async Task<Root> getpokemon()
        {
            HttpClient client = new HttpClient();
            try
            {
                string city = liste_v.SelectedItem as string;
                //Attend la réponse de l'API
                HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + nom_pokemon);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    Root root = JsonConvert.DeserializeObject<Root>(responseBody);
                    //Gere les erreurs sans fermer le programme
                    if (responseBody.Contains("error"))
                    {
                        MessageBox.Show("Choissisez une ville valide !");
                        return null;
                    }
                    return root;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }
}
