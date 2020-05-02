using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Cipher;
using MainProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiffieController : ControllerBase
    {
        // GET: api/Diffie/9/7        
        [HttpPost("{a}/{b}"), ActionName("GetPublicKey")]
        public void GetPublicKey(string a, string b)
        {
            Diffie secretKey = new Diffie(int.Parse(a), int.Parse(b));
            DataCompressions.Instance.secretKey = secretKey.generateKey();
        }


        // POST: api/Diffie
        [HttpPost("{method}")]
        public void caesar2([FromForm(Name = "file")] IFormFile file, string method)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            if (method == "cipher")
            {
                //elimina caracteres extra que stringbuilder coloca al final de la cadena
                string text = result.ToString();
                text = text.Remove(text.Length - 1);
                text = text.Remove(text.Length - 1);
                DataCompressions.Instance.caesarCipher.cifrarCesar(text, DataCompressions.Instance.secretKey, "DiffieCiph" + file.FileName);
            }
            else if (method == "decipher")
            {
                //elimina caracteres extra que stringbuilder coloca al final de la cadena
                string text = result.ToString();
                text = text.Remove(text.Length - 1);
                text = text.Remove(text.Length - 1);
                DataCompressions.Instance.caesarCipher.descifrarCesar(text, DataCompressions.Instance.secretKey, "DiffieDeciph" + file.FileName);
            }
            
        }
    }
}
