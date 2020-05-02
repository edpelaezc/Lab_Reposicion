using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MainProject.Cipher;
using System.IO;
using System.Text;

namespace MainProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DecipherController : ControllerBase
    {
        // POST: api/Decipher
        [HttpPost("{name}/{fileName}/{param}")]
        public string Post([FromForm(Name = "file")] IFormFile file, string name, string fileName, string param)
        {
            //lectura del archivo
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            if (name.ToLower().Equals("zigzag"))
            {
                ZigZag zigzagCipher = new ZigZag();
                zigzagCipher.decipher(int.Parse(param), result, fileName);
                return "Texto desencriptado, método: ZigZag";
            }
            else if (name.ToLower().Equals("caesar"))
            {
                Caesar caesarCipher = new Caesar(param);
                caesarCipher.buildAlphabet();
                caesarCipher.decipher(result, fileName);
                return "Texto descifrado, método: Caesar";
            }
            else if (name.ToLower().Equals("ruta"))
            {
                string[] parameters = param.Split(','); // la forma de ingresar parametro "mxn,tipo de ruta"
                string[] dimensiones = parameters[0].Split('x');
                int m = int.Parse(dimensiones[0]);
                int n = int.Parse(dimensiones[1]);
                Route routeCipher = new Route(m, n, result.ToString(), fileName);

                if (parameters[1].ToLower().Equals("vertical"))
                {
                    routeCipher.decipherVertical();
                }
                else
                {
                    routeCipher.decipherSpiral();
                }

                return "Texto descifrado, método: Ruta";
            }
            else
            {
                return "MÉTODO INCORRECTO";
            }

        }
    }
}
