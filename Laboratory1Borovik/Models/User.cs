using System;

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
            if(Birthday.Day >= 20 && Birthday.Month == 2 ||
               Birthday.Day <= 20 && Birthday.Month == 3)
                return WesternSigns.Pisces;
            if(Birthday.Day >= 21 && Birthday.Month == 3  ||
               Birthday.Day <= 20 && Birthday.Month == 4)
                return WesternSigns.Aries;
            if(Birthday.Day >= 21 && Birthday.Month == 4 ||
               Birthday.Day <= 20 && Birthday.Month == 5)
                return WesternSigns.Taurus;
            if(Birthday.Day >= 21 && Birthday.Month == 5  ||
               Birthday.Day <= 21 && Birthday.Month == 6)
                return WesternSigns.Gemini;
            if(Birthday.Day >= 22 && Birthday.Month == 6  ||
               Birthday.Day <= 22 && Birthday.Month == 7)
                return WesternSigns.Cancer;
            if(Birthday.Day >= 23 && Birthday.Month == 7  ||
               Birthday.Day <= 22 && Birthday.Month == 8)
                return WesternSigns.Leo;
            if(Birthday.Day >= 23 && Birthday.Month == 8  ||
               Birthday.Day <= 22 && Birthday.Month == 9)
                return WesternSigns.Virgo;
            if(Birthday.Day >= 23 && Birthday.Month == 9  ||
               Birthday.Day <= 22 && Birthday.Month == 10)
                return WesternSigns.Libra;
            if(Birthday.Day >= 23 && Birthday.Month == 10  ||
               Birthday.Day <= 22 && Birthday.Month == 11)
                return WesternSigns.Scorpio;
            if(Birthday.Day >= 23 && Birthday.Month == 11  ||
               Birthday.Day <= 21 && Birthday.Month == 12)
                return WesternSigns.Saggitaurus;

            return WesternSigns.Capricorn;

        }
        public ChineseSigns DateToSign()
        {
            int tmp = Birthday.Year % 12;
            switch (tmp)
            {
                case 0:
                    return ChineseSigns.Monkey;
                case 1:
                    return ChineseSigns.Roster;
                case 2:
                    return ChineseSigns.Dog;
                case 3:
                    return ChineseSigns.Pig;
                case 4:
                    return ChineseSigns.Rat;
                case 5:
                    return ChineseSigns.Ox;
                case 6:
                    return ChineseSigns.Tiger;
                case 7:
                    return ChineseSigns.Rabbit;
                case 8:
                    return ChineseSigns.Dragon;
                case 9:
                    return ChineseSigns.Snake;
                case 10:
                    return ChineseSigns.Horse;
                default:
                    return ChineseSigns.Goat;
            }
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
