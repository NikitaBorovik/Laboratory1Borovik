using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1.Models
{
    internal class User
    {
        private DateTime birthday = DateTime.Today;
        public DateTime Birthday 
        { 
            get => birthday;
            set => birthday = value;
        }
        public bool HasBirthday 
        { 
            get => Birthday.Day == DateTime.Today.Day && Birthday.Month == DateTime.Today.Month;
        }
        public string ChineseSign 
        {
            get
            {
                return DateToSign().ToString();
            }
        }
        public string WesternSign
        {
            get
            {
                return DateToWSign().ToString();
            }
        }
        public int Age 
        {
            get
            {
                if (DateTime.Today.Year == Birthday.Year && (DateTime.Today.Month < Birthday.Month ||
                    (DateTime.Today.Month == Birthday.Month && DateTime.Today.Day < Birthday.Day)))
                    return -1;
                if (DateTime.Today.Month < Birthday.Month || (DateTime.Today.Month == Birthday.Month && DateTime.Today.Day < Birthday.Day))
                {
                        return DateTime.Today.Year - Birthday.Year - 1;
                }
                return DateTime.Today.Year - Birthday.Year;

            }
        }
        public WesternSigns DateToWSign()
        {
            if (Birthday.Day >= 21 && Birthday.Month == 1 ||
                Birthday.Day <= 19 && Birthday.Month == 2)
                return WesternSigns.Aquarius;
            else if(Birthday.Day >= 20 && Birthday.Month == 2 ||
                Birthday.Day <= 20 && Birthday.Month == 3)
                return WesternSigns.Pisces;
            else if(Birthday.Day >= 21 && Birthday.Month == 3  ||
                Birthday.Day <= 20 && Birthday.Month == 4)
                return WesternSigns.Aries;
            else if(Birthday.Day >= 21 && Birthday.Month == 4 ||
                Birthday.Day <= 20 && Birthday.Month == 5)
                return WesternSigns.Taurus;
            else if(Birthday.Day >= 21 && Birthday.Month == 5  ||
                Birthday.Day <= 21 && Birthday.Month == 6)
                return WesternSigns.Gemini;
            else if(Birthday.Day >= 22 && Birthday.Month == 6  ||
                Birthday.Day <= 22 && Birthday.Month == 7)
                return WesternSigns.Cancer;
            else if(Birthday.Day >= 23 && Birthday.Month == 7  ||
                Birthday.Day <= 22 && Birthday.Month == 8)
                return WesternSigns.Leo;
            else if(Birthday.Day >= 23 && Birthday.Month == 8  ||
                Birthday.Day <= 22 && Birthday.Month == 9)
                return WesternSigns.Virgo;
            else if(Birthday.Day >= 23 && Birthday.Month == 9  ||
                Birthday.Day <= 22 && Birthday.Month == 10)
                return WesternSigns.Libra;
            else if(Birthday.Day >= 23 && Birthday.Month == 10  ||
                Birthday.Day <= 22 && Birthday.Month == 11)
                return WesternSigns.Scorpio;
            else if(Birthday.Day >= 23 && Birthday.Month == 11  ||
                Birthday.Day <= 21 && Birthday.Month == 12)
                return WesternSigns.Saggitaurus;

            else return WesternSigns.Capricorn;
            
        }
        public ChineseSigns DateToSign()
        {
            int tmp = Birthday.Year % 12;
            if (tmp == 0)
                return ChineseSigns.Monkey;
            else if (tmp == 1)
                return ChineseSigns.Roster;
            else if(tmp == 2)
                return ChineseSigns.Dog;
            else if(tmp == 3)
                return ChineseSigns.Pig;
            else if(tmp == 4)
                return ChineseSigns.Rat;
            else if(tmp == 5)
                return ChineseSigns.Ox;
            else if(tmp == 6)
                return ChineseSigns.Tiger;
            else if(tmp == 7)
                return ChineseSigns.Rabbit;
            else if(tmp == 8)
                return ChineseSigns.Dragon;
            else if(tmp == 9)
                return ChineseSigns.Snake;
            else if(tmp == 10)
                return ChineseSigns.Horse;
            else return ChineseSigns.Goat;

        }
    }
   
    enum WesternSigns
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Saggitaurus,
        Capricorn,
        Aquarius,
        Pisces,
    }
    enum ChineseSigns
    {
        Monkey,
        Roster,
        Dog,
        Pig,
        Rat,
        Ox,
        Tiger,
        Rabbit,
        Dragon,
        Snake,
        Horse,
        Goat,
    }

}
