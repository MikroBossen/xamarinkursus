using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatorApp
{
    class viewmodelMVVM
    {

    }

    // Viewmodel til ClockMVVM
    class ClockViewModel : INotifyPropertyChanged
    {
        // Lokal variabel
        DateTime dateTimeVar;

        // Udbyder event
        public event PropertyChangedEventHandler PropertyChanged;

        // Constructor
        public ClockViewModel()
        {
            // Setter propertien DateTime - ikke vores variabel dateTime.
            this.DateTimeProp = DateTime.Now;

            // Opdaterer propertien DateTime
            // Kaldes hvert sekund: StartTimer(TimeSpan.FromSeconds(1)
            // indtil funktion holder op med at virke - i princippet aldrig, men når pc'en går på pause, 
            // så stopper den.
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTimeProp = DateTime.Now;
                return true;
            });
        }

        // Property
        public DateTime DateTimeProp
        {
            set
            {
                // Køres kun, hvis den lokale variabel er forskellig fra værdien, man har i objektet
                // for at spare en "dyr" proces med at køre PropertyChanged
                if (dateTimeVar != value)
                {
                    dateTimeVar = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("DateTimeProp"));
                    }
                }
            }
            get
            {
                return dateTimeVar;
            }
        }
    }

    // Viewmodel til ColorMVVM
    public class HslViewModel : INotifyPropertyChanged
    {
        double hue, saturation, luminosity;
        Color color;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Hue
        {
            set
            {
                if (hue != value)
                {
                    hue = value;
                    // Forespørger på subscribers:
                    OnPropertyChanged("Hue");
                    SetNewColor();
                }
            }
            get
            {
                return hue;
            }
        }

        public double Saturation
        {
            set
            {
                if (saturation != value)
                {
                    saturation = value;
                    OnPropertyChanged("Saturation");
                    SetNewColor();
                }
            }
            get
            {
                return saturation;
            }
        }

        public double Luminosity
        {
            set
            {
                if (luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetNewColor();
                }
            }
            get
            {
                return luminosity;
            }
        }

        public Color Color
        {
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");

                    this.Hue = value.Hue;
                    this.Saturation = value.Saturation;
                    this.Luminosity = value.Luminosity;
                }
            }
            get
            {
                return color;
            }
        }

        void SetNewColor()
        {
            this.Color = Color.FromHsla(this.Hue,
                                        this.Saturation,
                                        this.Luminosity);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    // Viewmodel til EnterPhoneNoMVVM
    class KeypadViewModel : INotifyPropertyChanged
    {
        string inputString = "";
        string displayText = "";
        char[] specialChars = { '*', '#' };

        public event PropertyChangedEventHandler PropertyChanged;

        // Constructor
        public KeypadViewModel()
        {
            // Properties AddCharCommand og InputString
            this.AddCharCommand = new Command<string>((key) =>
            {
                // Add the key to the input string
                this.InputString += key;
            });

            // Properties DeleteCharCommand og InputString
            this.DeleteCharCommand = new Command((nothing) =>
            {
                // Strip a character from the input string.
                this.InputString = this.InputString.Substring(0,
                                    this.InputString.Length - 1);
            },
                (nothing) =>
                {
                    // Return true if there's something to delete.
                    return this.InputString.Length > 0;
                });
        }

        // Public properties
        public string InputString
        {
            protected set
            {
                if (inputString != value)
                {
                    inputString = value;
                    OnPropertyChanged("InputString");
                    this.DisplayText = FormatText(inputString);

                    // Perhaps the delete button must be enabled/disabled.
                    ((Command)this.DeleteCharCommand).ChangeCanExecute();
                }
            }

            get { return inputString; }
        }

        public string DisplayText
        {
            protected set
            {
                if (displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");
                }
            }
            get { return displayText; }
        }

        // ICommand implementations
        public ICommand AddCharCommand { protected set; get; }

        public ICommand DeleteCharCommand { protected set; get; }

        // Omsætte angivet tlf. nr. til korrekt format
        string FormatText(string str)
        {
            // Søger efter placering (0-baseret) - hvis ingen forekomster returneres -1
            // Her: sætter hasNonNumbers til true, hvis definerede special tegn findes i inputet 
            bool hasNonNumbers = str.IndexOfAny(specialChars) != -1;
            string formatted = str;

            if (hasNonNumbers || str.Length < 4 || str.Length > 10)
            {
            }
            // Format 000-0XXX
            // Substring(int index) Starter på opgivet index og tager rest. af string
            // Substring(int index, count y) Starter på opgivet index og tager opgivet antal tegn (count)
            else if (str.Length < 8)
            {
                formatted = String.Format("{0}-{1}",
                                          str.Substring(0, 3),
                                          str.Substring(3));
            }
            else
            {
                formatted = String.Format("({0}) {1}-{2}",
                                          str.Substring(0, 3),
                                          str.Substring(3, 3),
                                          str.Substring(6));
            }
            return formatted;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}
