using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreationalPatterns
{
    //клонирует существующие объекты.
    internal class Prototype
    {
//Когда использовать Prototype

//Когда создание объекта дорого(например, требует сложных вычислений или загрузки ресурсов)
//Когда нужно клонировать объекты с сохранением их текущего состояния
//Когда объекты создаются динамически и не подходят стандартные фабрики
    }

    //Пример
        public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Shape Clone();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle
            {
                X = this.X,
                Y = this.Y,
                Radius = this.Radius
            };
        }
    }
}
