using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASUForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            
            var loginModel = new
            {
                Email = userName,
                Password = password
            };

            using (var client = new HttpClient())
            {
                //POST запрос с JSON
                var response = client.PostAsJsonAsync(textBoxUrl.Text + "/api/token", loginModel).Result;

                //Получаем в ответ JSON
                var result = response.Content.ReadAsStringAsync().Result;
                // Десериализация полученного JSON-объекта
                Dictionary<string, string> tokenDictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                textBoxToken.Text = tokenDictionary["token"];
            }
        }

        private void buttonCreateDeclarant_Click(object sender, EventArgs e)
        {
            string token = textBoxToken.Text;

            var declarant = new
            {
                Name = textBoxDeclarantName.Text,
                Address = textBoxDeclarantAdr.Text,
                Phone = textBoxDeclarantPhone.Text,
                IIN = textBoxDeclarantIIN.Text
            };

            using (var client = CreateClient(token))
            {
                try
                {
                    var response = client.PostAsJsonAsync(textBoxUrl.Text + "/api/declarants", declarant).Result;

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        textBoxResult.Text = "Unauthorized";
                        return;
                    }

                    var result = response.Content.ReadAsStringAsync().Result;

                    textBoxResult.Text = result;
                }
                catch(Exception exp)
                {
                    textBoxResult.Text = exp.Message;
                }

            }
        }


        /// <summary>
        /// Создаем httpClient с Header Authorization
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        static HttpClient CreateClient(string token = "")
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.Authorization = 
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
            return client;
        }

        private void buttonGetDeclarant_Click(object sender, EventArgs e)
        {
            string token = textBoxToken.Text;

            using (var client = CreateClient(token))
            {
                try
                {
                    var response = client.GetAsync(textBoxUrl.Text + "/api/declarants/" + textBoxDeclarantID.Text).Result;

                    if(response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        textBoxResult.Text = "Unauthorized";
                        return;
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        textBoxResult.Text = "Not Found";
                        return;
                    }

                    textBoxResult.Text = response.Content.ReadAsStringAsync().Result;
                }
                catch (Exception exp)
                {
                    textBoxResult.Text = exp.Message;
                }

            }
        }

        private void buttonPutDeclarant_Click(object sender, EventArgs e)
        {
            string token = textBoxToken.Text;

            var declarant = new
            {
                Id = textBoxDeclarantID.Text,
                Name = textBoxDeclarantName.Text,
                Address = textBoxDeclarantAdr.Text,
                Phone = textBoxDeclarantPhone.Text,
                IIN = textBoxDeclarantIIN.Text
            };


            using (var client = CreateClient(token))
            {
                try
                {
                    var response = client.PutAsJsonAsync(textBoxUrl.Text + "/api/declarants/" + textBoxDeclarantID.Text, declarant).Result;

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        textBoxResult.Text = "Unauthorized";
                        return;
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        textBoxResult.Text = "Not Found";
                        return;
                    }

                    textBoxResult.Text = response.Content.ReadAsStringAsync().Result;
                }
                catch (Exception exp)
                {
                    textBoxResult.Text = exp.Message;
                }

            }
        }

        private void buttonDeleteDeclarant_Click(object sender, EventArgs e)
        {
            string token = textBoxToken.Text;

            using (var client = CreateClient(token))
            {
                try
                {
                    var response = client.DeleteAsync(textBoxUrl.Text + "/api/declarants/" + textBoxDeclarantID.Text).Result;

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        textBoxResult.Text = "Unauthorized";
                        return;
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        textBoxResult.Text = "Not Found";
                        return;
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        textBoxResult.Text = "No Content";
                }
                catch (Exception exp)
                {
                    textBoxResult.Text = exp.Message;
                }

            }
        }
    }
}
