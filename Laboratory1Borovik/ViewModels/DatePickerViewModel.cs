using System;
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
                return validateFieldsCommand ??= new RelayCommand<object>(o => ValidateUserFields()); 
            }
        }
        public RelayCommand<object> ExitCommand
        {
            get
            {
                return exitCommand ??= new RelayCommand<object>(o => Close());
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public bool ValidateAge()
        {
            return ourUser.Age >=0 && ourUser.Age <= 135;
        }

        public string GetCongratMessage()
        {
            return ourUser.HasBirthday ? "Happy birthday!" : "Today is not your birthday :(";
        }
    }
}
