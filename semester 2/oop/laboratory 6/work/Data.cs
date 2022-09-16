using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Примечание:
 * Данный класс представляет из себя библиотеку с городами, облостями и странами
 * ISO - мировой стандард
 * 3166 - стандард обозначения государств и зависимых территорий, а также основных административных образований внутри государств.
 * 3166-1 - стандард обозначения государств
 * 3166-2 - стандарт обозначения областей N государтсва
 *
 * Данный класс не является полной библиотекой со всеми странами, регионами и городами.
 * Тут показана лишь вариация того, как можно системотизировать большие объемы данных в код, с дальнейшей работой.
 *
 * Так-же при желании можно доработать данный класс, добавив переводы на разные языки мира, улицы, дома.
 * Но это будет требовать огромных ресурсозатрат, которых у обычного студента попросту нет.
 */
static partial class Data
{
	static public Dictionary<ISO_3166_1, string> Country
	{
		get { return _country; }
	}
	static public Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, string>> District
	{
		get { return _district; }
	}
	static public Dictionary<ISO_3166_1, Dictionary<ISO_3166_2, List<string>>> City
	{
		get { return _city; }
	}
	static public Dictionary<ISO_3166_1, int> NumberCode
	{
		get { return _numbercode; }
	}
}