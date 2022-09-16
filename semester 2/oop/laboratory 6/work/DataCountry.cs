using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Data
{
	static private Dictionary<ISO_3166_1, string> _country = new Dictionary<ISO_3166_1, string>(){
		{ISO_3166_1.RU, "Россия"},
		{ISO_3166_1.IT, "Италия"},
		{ISO_3166_1.CA, "Канада"},
	};
}