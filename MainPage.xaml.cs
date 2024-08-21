using System.Runtime.CompilerServices;

namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello Mark!";
            ColorRed = Colors.Red;

            this.BindingContext = this;

           
        }

        private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "ISPAYDORMAN";
        }

        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "ISPAYDORMAN";
        }

        private void OnChangedBackgroundColor(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightGray;
        }

        private void OnChangedBackgroundColorG(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }
        private void OnChangedBackgroundColorL(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void OnChangedBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }
    }

}
