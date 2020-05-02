using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Cipher
{
	public class Caesar2
	{
        List<char> newAlphabet = new List<char>();
        List<char> originalAlphabet = new List<char>();
        int rotaciones = 0;

        public Caesar2() { }

        private void buildAlphabet(int Shifting)
        {
            List<byte> modified = new List<byte>();
            List<byte> original = new List<byte>();

            for (int i = 97; i < 123; i++)
            {
                original.Add((byte)i);
                modified.Add((byte)i);
            }

            this.rotaciones = Shifting % original.Count();

            for (int i = 0; i < this.rotaciones; i++)
            {
                byte aux = modified[0];
                modified.RemoveAt(0);
                modified.Add(aux);
            }

            newAlphabet = new List<char>();
            originalAlphabet = new List<char>();

            for (int i = 0; i < original.Count; i++)
            {
                originalAlphabet.Add(Convert.ToChar(original[i]));
                newAlphabet.Add(Convert.ToChar(modified[i]));
            }
        }

        public void cifrarCesar(string frase, int distancia, string fileName)
        {
            buildAlphabet(distancia);

            string nuevaFrase = "";

            for (int i = 0; i < frase.Length; i++)
            {
                int aux = originalAlphabet.IndexOf(frase[i]);
                if (aux == -1)
                {
                    nuevaFrase += frase[i];
                }
                else
                {
                    nuevaFrase += newAlphabet[aux];
                }
            }

            //escribir archivo 
            string folder = string.Format(@"{0}DiffieCipherResults\", AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin")));
            string fullPath = folder + fileName;
            // crear el directorio
            DirectoryInfo directory = Directory.CreateDirectory(folder);

            using (StreamWriter file = new StreamWriter(fullPath))
            {
                file.WriteLine(nuevaFrase);
                file.Close();
            }
        }

        public void descifrarCesar(string frase, int distancia, string fileName)
        {
            buildAlphabet(distancia);

            string nuevaFrase = "";

            for (int i = 0; i < frase.Length; i++)
            {
                int aux = newAlphabet.IndexOf(frase[i]);
                if (aux == -1)
                {
                    nuevaFrase += frase[i];
                }
                else
                {
                    nuevaFrase += originalAlphabet[aux];
                }
            }

            //escribir archivo 
            string folder = string.Format(@"{0}DiffieDecipherResults\", AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin")));
            string fullPath = folder + fileName;
            // crear el directorio
            DirectoryInfo directory = Directory.CreateDirectory(folder);

            using (StreamWriter file = new StreamWriter(fullPath))
            {
                file.WriteLine(nuevaFrase);
                file.Close();
            }
        }
    }
}
