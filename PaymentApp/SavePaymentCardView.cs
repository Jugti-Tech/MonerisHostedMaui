using CommunityToolkit.Maui.Markup;
using PaymentApp.CustomControls;
using System.Text.Json;
using static PaymentApp.Enums;

namespace PaymentApp;

public class SavePaymentCardView : BaseView
{
  
    public SavePaymentCardView(SavePaymentCardViewModel viewModel) : base(viewModel)
    {
        try
        {
            Shell.SetNavBarIsVisible(this, false);
            HybridWebView.HybridWebView hybridWebView = new()
            {
                HybridAssetRoot = "hybrid_root",
                MainFile = "index.html",
                JSInvokeTarget = new MyJSInvokeTarget(this)
            };

            base.BaseContentGrid.Children.Add(new ImageButton { Source = "back.png", HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start }.Row(BodyRow.first).Column(BodyColumn.first));

            base.BaseContentGrid.Children.Add(new VerticalStackLayout
            {

                Children =
            {
                new Bold28Label { Text="Add Card"},

                 new BorderedEntry { PlaceholderText = "Name On Card", WidthRequest=250 }.Margins(0,0,0,0),


                 new BorderedEntry { PlaceholderText = "Street", WidthRequest=250 }.Margins(0,10,0,0),


                 new BorderedEntry { PlaceholderText = "Post Code", WidthRequest=250 }.Margins(0,10,0,0),


             hybridWebView,

            }
            }.Row(BodyRow.second).ColumnSpan(2));

        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", ex.Message, "Ok");

        }

    }
}

sealed class MyJSInvokeTarget
{
    private readonly SavePaymentCardView _mainPage;
   
    public MyJSInvokeTarget(SavePaymentCardView mainPage)
    {
        _mainPage = mainPage;
      
    }

    public async void CallMeFromScript(string? dataKey, string? bin, string? errorMessage, JsonElement? responseCode)
    {
        // Handle the message received from JavaScript
        try
        {

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                // convert jsonElement to string[]
                string?[] responseCodeArray = responseCode.Value.EnumerateArray().Select(x => x.GetString()).ToArray();

                int count = 0;
                string message = string.Empty;
                foreach (var item in responseCodeArray)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                       

                    }
                }

              
            }



            else if (!string.IsNullOrWhiteSpace(dataKey))
            {
               

             
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");

        }


    }


}