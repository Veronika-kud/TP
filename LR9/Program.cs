using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{

    public interface IChangable
    {
        void Growth(double pValue);
        void Fall(double pValue);
    }

    public interface IConvert
    {
        void ConvertToKmperhour();
        void ConvertToMpersec();
        void ConvertToMpermin();
    }

    public interface IDrawable
    {
        string Name { get; set; }
        void DrawObject();
    }

    public class Вертолет : IChangable, IDrawable
    {
        public Вертолет(string pType, double pFast)
        {
            Type = pType;
            Fast = pFast;
        }
        private string Type;
        private double Fast;

        public void Growth(double pValue)
        {
            Fast *= 2 * pValue;
        }

        public void Fall(double pValue)
        {
            Fast *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return Type + "Вертолет, Скорость = " + Fast.ToString();
            }
            set
            {
                Type = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine

            ("═════════╬═════════───\n" +
            "───▄▄██████████▄▄▄▄▄▄█\n" +
            "─▄▒▄▒▒▄▒▒▄▒▒▒▀▀▀▀▀▀█──\n" +
            "──▀▀▀█▀▀▀█▀▀──────────\n" +
            "──╚══╩═══╩══╝─────────\n");
            Console.WriteLine(Name);
        }
    }
    public class Истрибитель : IChangable, IDrawable
    {
        public Истрибитель(string pType, double pFast)
        {
            Type = pType;
            Fast = pFast;
        }
        private string Type;
        private double Fast;

        public void Growth(double pValue)
        {
            Fast *= 2 * pValue;
        }

        public void Fall(double pValue)
        {
            Fast *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return Type + ", Скорость = " + Fast.ToString();
            }
            set
            {
                Type = value;
            }
        }
        public void DrawObject()
        {
            Console.WriteLine
            (
            "░░░░░░░░░░▐▌░░░░░░░░░░░\n" +
            "░░░░░░░░░▄██▄░░░░░░░░░░\n" +
            "░░░░░░░░░████░░░░░░░░░░\n" +
            "░░░░░░░░░█░░█░░░░░░░░░░\n" +
            "░░░░░░░▄▄█░░█▄▄░░░░░░░░\n" +
            "░░░░░░░███░░███░░░░░░░░\n" +
            "░░░░░░▄████████▄░░░░░░░\n" +
            "░░░░░▄██████████▄░░░░░░\n" +
            "░░▄████████████████▄░░░\n" +
            "▄█████████████████████▄\n" +
            "███████████████████████\n" +
            "░░░░░████████████░░░░░░\n" +
            "░░░▄██████████████▄░░░░\n" +
            "░░░█████░░▀▀░░█████░░░░\n");
            Console.WriteLine(Name);
        }
    }

    public class Конвертер : IChangable, IConvert, IDrawable
    {
        public Конвертер(string pSpeed, double pQuantity)
        {
            Speed = pSpeed;
            Quantity = pQuantity;
            Designation = " км/ч ";
            DesignationID = 0;
        }

        public Конвертер(string pSpeed, double pQuantity, int pDesignationID)
        {
            Speed = pSpeed;
            Quantity = pQuantity;

            switch (pDesignationID)
            {
                case 0: Designation = " км/ч "; DesignationID = 0; break;
                case 1: Designation = " м/мин"; DesignationID = 1; break;
                case 2: Designation = " м/сек"; DesignationID = 2; break;
                default: Designation = " км/ч "; DesignationID = 0; break;
            }
        }
        private string Speed;
        private double Quantity;
        private string Designation;
        private int DesignationID;

        public void Growth(double pValue)
        {
            Quantity *= 2 * pValue;
        }

        public void Fall(double pValue)
        {
            Quantity *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return $"Мера скорости. {Speed}. Значение: {Quantity}{Designation}";
            }
            set
            {
                Speed = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
            (
            " S \n" +
            " P \n" +
            " E \n" +
            " E \n" +
            " D \n"
            );
            Console.WriteLine(Name);
        }

        public void ConvertToMpersec()
        {
            if (DesignationID == 1)
            {
                Quantity *= 3.281;
            }
            else if (DesignationID == 0)
            {
                Quantity *= 60;
            }
            Designation = " м/сек ";
            DesignationID = 2;
        }
        public void ConvertToMpermin()
        {
            if (DesignationID == 0)
            {
                Quantity *= 16.667;
            }
            else if (DesignationID == 2)
            {
                Quantity *= 60;
            }
            Designation = " м/мин ";
            DesignationID = 1;
        }
        public void ConvertToKmperhour()
        {
            if (DesignationID == 2)
            {
                Quantity *= 3.6;
            }
            else if (DesignationID == 1)
            {
                Quantity *= 16.667;
            }
            Designation = " км/ч";
            DesignationID = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Вертолет a = new Вертолет("Ансат", 120);
            a.Growth(2);
            a.Fall(1);
            a.DrawObject();


            Console.WriteLine("\n");


            Истрибитель g = new Истрибитель("МиГ-29", 50);
            g.Growth(3);
            g.Fall(2);
            g.DrawObject();

            Console.WriteLine("\n");

            Конвертер

            c = new Конвертер("СКОРОСТЬ", 50);
            c.Growth(4);
            c.Fall(2);
            c.DrawObject();

            c.ConvertToMpermin();
            c.DrawObject();

            Console.ReadKey();
        }
    }
    }
