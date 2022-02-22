using LibraryWPF.Model.Member;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF.AppConfig
{
    class OnLoadCommandMember
    {
        public System.Net.Http.HttpClient client = new HttpClient();
        public async Task<Root> GetAPIAsync(string path)
        {
            Root root = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)

            {

                root = await response.Content.ReadAsAsync<Root>();

            }

            return root;

        }

    }
}
