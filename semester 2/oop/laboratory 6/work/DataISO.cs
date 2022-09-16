using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static partial class Data
{
	public enum ISO_3166_1
	{
		//alpha 2
		IT = 380,
		CA = 124,
		RU = 643,
		//alpha 3
		RUS = RU,
		ITA = IT,
		CAN = CA,
	}
	public enum ISO_3166_2
	{
		RU_MOS = 1,
		RU_VLA = 2,
		IT_34 = 3,
		IT_82 = 4,
		CA_AB = 5,
		CA_BC = 6,
	}
}