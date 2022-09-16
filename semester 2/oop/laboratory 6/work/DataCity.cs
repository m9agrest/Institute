using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Data
{
	static private Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, List<string>>> _city = new Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, List<string>>>()
	{
		{
			ISO_3166_1.RU, new Dictionary<ISO_3166_2, List<string>>()
			{
				{ ISO_3166_2.RU_MOS, new List<string>() { "Москва", "Внуково" } },
				{ ISO_3166_2.RU_VLA, new List<string>() { "Владимир", "Муром" } }
			}
		},
		{
			ISO_3166_1.IT, new Dictionary<ISO_3166_2, List<string>>()
			{
				{ ISO_3166_2.IT_34, new List<string>() { "Венеция", "Беллуно" } },
				{ ISO_3166_2.IT_82, new List<string>() { "Палермо", "Рагуза" } },
			}
		},
		{
			ISO_3166_1.CA, new Dictionary<ISO_3166_2, List<string>>()
			{
				{ ISO_3166_2.CA_AB, new List<string>() { "Эдмонтон", "Калгари" } },
				{ ISO_3166_2.CA_BC, new List<string>() { "Виктория", "Ванкувер" } },
			}
		},
	};
}