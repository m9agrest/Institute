using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Wire
{
    /// <summary>
    /// Кол-во жил в кабеле
    /// </summary>
    public int CountCores;
    /// <summary>
    /// Диаметр кабеля в мм
    /// </summary>
    public double D;
    /// <summary>
    /// Тип кабеля
    /// </summary>
    public string Type;
    /// <summary>
    /// Качество объекта
    /// </summary>
    public double Q { get { return D / CountCores; } }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="Type">Тип кабеля</param>
    /// <param name="CountCores">Кол-во жил в кабеле</param>
    /// <param name="D">Диаметр кабеля в мм</param>
    public Wire(string Type, int CountCores, double D)
    {
        this.CountCores = CountCores;
        this.D = D;
        this.Type = Type;
    }


    public override string ToString()
    {
        return $"Тип: {Type};\nКол-во жил: {CountCores};\nДиаметр: {D}мм;\nQ: {Q};";
    }
}
