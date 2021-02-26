using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_Antonio.Controllers
{
    public class ProductController : Controller
    {
        //Métodos
        //GET: /Product
        public string Index()
        {
            return "Escola SENAI Suiço-Brasileira Paulo Ernesto Tolle";
        }
        public string Welcome()
        {
            return "Seja bem-vindo!";
        }
        public string Contato()
        {
            return "Rua Bento Branco de Andrade Filho, 379 - Santo Amaro \nTelefone: (11) 5642-3400 \nE-mail: secretaria115@sp.senai.br";
        }
    }
}