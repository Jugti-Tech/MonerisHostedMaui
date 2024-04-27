

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;


namespace PaymentApp
{
    public partial class SavePaymentCardViewModel : BaseViewModel
    {
        



      

        public SavePaymentCardViewModel() : base()
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }

        }

      


    }
}
