using System;
using System.Collections.Generic;

namespace Patterns.CreationalPatterns
{
    //создает семейства связанных объектов.
    internal class AbstractFactory
    {
        //Когда использовать Abstract Factory

        //Когда нужно создавать семейства связанных объектов (например, UI для разных ОС: Windows, macOS, Web)
        //Когда нужно гарантировать совместимость создаваемых объектов между собой
        //Когда объектам одного семейства нужно создаваться и использоваться вместе
        //Когда нужно избавиться от привязки к конкретным классам продуктов в клиентском коде
    }

    //Пример

    //Абстрактные продукты
    public interface IButton
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Render();
    }

    //Конкретные продукты (семейство Windows)
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Рисуем кнопку в стиле Windows");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Рисуем чекбокс в стиле Windows");
        }
    }

    //Конкретные продукты (семейство Mac)
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Рисуем кнопку в стиле macOS");
        }
    }

    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Рисуем чекбокс в стиле macOS");
        }
    }

    //Абстрактная фабрика
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    //Конкретные фабрики
    public class WindowsGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

    public class MacGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    //Клиентский код, который работает только с абстракциями
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGuiFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Render()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}
