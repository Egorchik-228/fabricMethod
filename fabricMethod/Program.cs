using System;

namespace ClothingFactoryApp
{
    // Абстрактный класс одежды
    public abstract class Clothing
    {
        public abstract string GetClothingType();
    }

    // Конкретный класс рубашки
    public class Shirt : Clothing
    {
        public override string GetClothingType()
        {
            return "Рубашка";
        }
    }

    // Конкретный класс брюк
    public class Pants : Clothing
    {
        public override string GetClothingType()
        {
            return "Брюки";
        }
    }

    // Конкретный класс куртки
    public class Jacket : Clothing
    {
        public override string GetClothingType()
        {
            return "Куртка";
        }
    }

    // Абстрактный класс фабрики
    public abstract class ClothingFactory
    {
        public abstract Clothing CreateClothing();
    }

    // Фабрика для создания рубашек
    public class ShirtFactory : ClothingFactory
    {
        public override Clothing CreateClothing()
        {
            return new Shirt();
        }
    }

    // Фабрика для создания брюк
    public class PantsFactory : ClothingFactory
    {
        public override Clothing CreateClothing()
        {
            return new Pants();
        }
    }

    // Фабрика для создания курток
    public class JacketFactory : ClothingFactory
    {
        public override Clothing CreateClothing()
        {
            return new Jacket();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите тип одежды, который хотите создать:");
                Console.WriteLine("1. Рубашка");
                Console.WriteLine("2. Брюки");
                Console.WriteLine("3. Куртка");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                // Считываем ввод пользователя
                string input = Console.ReadLine();

                ClothingFactory factory = null;

                switch (input)
                {
                    case "1":
                        factory = new ShirtFactory();
                        break;
                    case "2":
                        factory = new PantsFactory();
                        break;
                    case "3":
                        factory = new JacketFactory();
                        break;
                    case "0":
                        return; // Завершение программы
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите число от 1 до 3, или 0 для выхода.");
                        continue;
                }

                // Создаем выбранную одежду
                if (factory != null)
                {
                    Clothing clothing = factory.CreateClothing();
                    Console.WriteLine("Создан тип одежды: " + clothing.GetClothingType());
                }

                Console.WriteLine();
            }
        }
    }
}
