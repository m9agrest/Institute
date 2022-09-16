using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Data
{
	static private Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, string>> _district = new Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, string>>()
	{
		{
			ISO_3166_1.RU, new Dictionary<ISO_3166_2, string>()
			{
				{ ISO_3166_2.RU_MOS, "Московская Область"},
				{ ISO_3166_2.RU_VLA, "Владимирская Область"},
			}
		},
		{
			ISO_3166_1.IT, new Dictionary<ISO_3166_2, string>()
			{
				{ ISO_3166_2.IT_34, "Венеция"},
				{ ISO_3166_2.IT_82, "Сицилия"},
			}
		},
		{
			ISO_3166_1.CA, new Dictionary<ISO_3166_2, string>()
			{
				{ ISO_3166_2.CA_AB, "Альберта"},
				{ ISO_3166_2.CA_BC, "Британская Колумбия"},
			}
		},
	};
}