using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace лаб11
{
    enum Department
    {
        A,
        B,
        C,
        D,

    }

    class SiteLr
    {
        String ID { get; set; }
        public String Login { get; set; }
        String Password { get; set; }
        public Department DepartmentName { get; set; }
        public float Salary { get; set; }
        public Boolean HasCat { get; set; }
        public Boolean HasDog { get; set; }
        public Boolean HasGun { get; set; }

        public static SiteLr Create(String str)
        {
            SiteLr p = new SiteLr();
            //string[] e = str.Split(',');
            string[] e = Regex.Split(str, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            p.ID = e[0].Trim();
            p.Login = e[1].Trim();
            p.Password = e[2].Trim();
            String tmp = e[4].Trim();
            if (tmp == "A")
                p.DepartmentName = Department.A;
            else if (tmp == "B")
                p.DepartmentName = Department.B;
            else if (tmp == "C")
                p.DepartmentName = Department.C;
            else
                p.DepartmentName = Department.D;

            p.Salary = Convert.ToSingle(e[3].TrimStart('$').Replace('.', ','));
            p.HasCat = Convert.ToBoolean(e[5].Trim());
            p.HasDog = Convert.ToBoolean(e[6].Trim());
            p.HasGun = Convert.ToBoolean(e[7].Trim());

            return p;
        }

        public static String DepartmentToStr(Department c)
        {
            if (c == Department.A) return "A";
            else if (c == Department.B) return "B";
            else if (c == Department.C) return "C";
            else return "D";
        }

        public static String HasCatSt(Boolean d)
        {
            if (d == true) return "Есть кошка";
            else return "Нет кошки";
        }

        public static String HasDogSt(Boolean r)
        {
            if (r == true) return "Есть собака";
            else return "Нет собака";
        }

        public static String HasGunSt(Boolean a)
        {
            if (a == true) return "Есть оружие";
            else return "Нет оружия";
        }

        public override string ToString()
        {
            String s = string.Format(
                "*******************************************************\n" +
                "ID: {0} \n" +
                "Логин: {1}\n" +
                "Пароль: {2}\n" +
                "Зарплата: {4} $\n" +
                "Отделение: {3}\n" +
                "Наличие кошки: {5}\n" +
                "Наличие собаки: {6}\n" +
                "Наличие оружия: {7}\n" +
                "*******************************************************\n",
                ID, Login, Password, DepartmentName, Salary, HasCatSt(HasCat), HasDogSt(HasDog), HasGunSt(HasGun));
            return s; 
        }
    }
}