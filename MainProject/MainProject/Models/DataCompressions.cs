using MainProject.Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models
{
    public class DataCompressions
    {
		private static DataCompressions instance = null;
		public static DataCompressions Instance
		{
			get
			{
				if (instance == null) instance = new DataCompressions();
				return instance;
			}
		}

		public List<CompressionsCollection> archivos = new List<CompressionsCollection>();
		public int secretKey { get; set; }
		public Caesar2 caesarCipher = new Caesar2();
	}
}
