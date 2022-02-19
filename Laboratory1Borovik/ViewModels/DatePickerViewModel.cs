using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory1.Tools;
using Laboratory1.Models;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Laboratory1.ViewModels
{
    internal class DatePickerViewModel: INotifyPropertyChanged
    {
        private RelayCommand<object>? validateFieldsCommand;
        private RelayCommand<object>? exitCommand;
        private User ourUser = new User();
        private string? westernZodiacSign;
        private string? chineseZodiacSign;
        private string? userAge;
        private string? congratulations;

        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public RelayCommand<object> ValidateFieldsCommand
        {
            get 
            { 
                return validateFieldsCommand ?? (validateFieldsCommand = new RelayCommand<object>(o => ValidateUserFields())); 
            }
        }
        public RelayCommand<object> ExitCommand
        {
            get
            {
                return exitCommand ?? (exitCommand = new RelayCommand<object>(o => Close()));
            }
        }
        private void Close()
        {
            Environment.Exit(0);
        }
        public void ValidateUserFields()
        {
            
            if (ValidateAge())
            {
                UserAge = ourUser.Age.ToString();
                WesternZodiacSign = ourUser.WesternSign;
                ChineseZodiacSign = ourUser.ChineseSign;
                Congratulations = GetCongratMessage();
            }
            else
            {
                MessageBox.Show("Wrong data!Your age is incorrect");
            }
        }
        
        public DateTime UserBirthday
        {
            get
            {
                return ourUser.Birthday;
            }
            set
            {
                ourUser.Birthday = value;
            }
        }
        public string ChineseZodiacSign
        {
            get
            {
                return chineseZodiacSign;
            }
            set
            {
                chineseZodiacSign = value;
                OnPropertyChanged(nameof(ChineseZodiacSign));
            }
        }
        public string WesternZodiacSign
        {
            get
            {
                return westernZodiacSign;
            }
            set
            {
                westernZodiacSign = value;
                OnPropertyChanged(nameof(WesternZodiacSign));
            }
        }
        public string UserAge 
        { 
            get
            {
                return userAge;
            }
            set
            {
                userAge = value;
                OnPropertyChanged(nameof(UserAge));
            }
        }
        public string Congratulations
        {
            get
            {
                return congratulations;
            }
            set
            {
                congratulations = value;
                OnPropertyChanged(nameof(Congratulations));
            }
        }

        public bool ValidateAge()
        {
            return ourUser.Age >=0 && ourUser.Age <= 135;
        }

        public string GetCongratMessage()
        {
            if(ourUser.HasBirthday)
            {
                return "Happy birthday!";
            }
            else
            {
                return "Today is not your birthday :(";
            }
        }
    }
}
