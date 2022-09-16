using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Data
{

	private static Dictionary<ISO_3166_1, int> _numbercode = new Dictionary<ISO_3166_1, int>()
	{
		{ISO_3166_1.CA, 1},
		{ISO_3166_1.RU, 7},
		{ISO_3166_1.IT, 39},
	};
}
