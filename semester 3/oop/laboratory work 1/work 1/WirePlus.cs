using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WirePlus : Wire
{
    /// <summary>
    /// Наличие оплетки на кабеле
    /// </summary>
    public bool P;
    /// <summary>
    /// Качество объекта
    /// </summary>
    public double Qp { get { if (P) return 2 * Q; return 0.7 * Q;  } }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="Type">Тип кабеля</param>
    /// <param name="CountCores">Кол-во жил в кабеле</param>
    /// <param name="D">Диаметр кабеля в мм</param>
    /// <param name="P">Наличие оплетки на кабеле</param>
    public WirePlus(string Type, int CountCores, double D, bool P) : base(Type, CountCores, D)
    {
        this.P = P;
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nНаличие оплетки: {(P ? "+" : "-")};\nQp: {Qp};";
    }
}
