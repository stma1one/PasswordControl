using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PasswordControl.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordToggleEntry : ContentView
    {

        #region new Bindble properties
        public static readonly BindableProperty EyeIconImageProperty = BindableProperty.Create(nameof(EyeIconImage), typeof(string), typeof(PasswordToggleEntry), "closeeyeicon");
        public static readonly BindableProperty EntryIconImageProperty = BindableProperty.Create(nameof(EntryIconImage), typeof(string), typeof(PasswordToggleEntry), "personicon");
        public static readonly BindableProperty ShowPassWordCommandProperty = BindableProperty.Create(nameof(ShowPassWordCommand), typeof(ICommand), typeof(PasswordToggleEntry), null);
        public static readonly BindableProperty HidePassProperty = BindableProperty.Create(nameof(HidePass), typeof(bool), typeof(PasswordToggleEntry), true);
        public static readonly BindableProperty PasswordTextProperty = BindableProperty.Create(nameof(PasswordText), typeof(string), typeof(PasswordToggleEntry));        
        #endregion
        #region Properties
        public string EyeIconImage
        {
            get { return (string)GetValue(EyeIconImageProperty); }
            set { SetValue(EyeIconImageProperty, value); }
        }
        public string EntryIconImage
        {
            get { return (string)GetValue(EntryIconImageProperty); }
            set { SetValue(EntryIconImageProperty, value); }
        }

        public ICommand ShowPassWordCommand
        {
            get { return (ICommand)GetValue(ShowPassWordCommandProperty); }
            set { SetValue(ShowPassWordCommandProperty, value); }
        }
        public  bool HidePass { 
            get { return (bool)GetValue(HidePassProperty); }
            set { SetValue(HidePassProperty, value); }
        
        }
        public string PasswordText
        {
            get { return (string)GetValue(PasswordTextProperty); }
            set { SetValue(PasswordTextProperty, value); }
        }

     
        #endregion
        public PasswordToggleEntry()
        {
            InitializeComponent();
            ShowPassWordCommand = new Command(Toggle);
        }

        public  void Toggle()
        {
            HidePass = !HidePass;
            if (HidePass)
                EyeIconImage = "closeeyeicon";
            else
                EyeIconImage = "eyeiconpng";

        }
    }
}