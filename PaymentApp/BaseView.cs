using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using static PaymentApp.Enums;

namespace PaymentApp;

public class BaseView : ContentPage
{
    public Grid BaseContentGrid;

    public BaseView(BaseViewModel viewModel)
    {
        try
        {
            BindingContext = viewModel;
            Padding = new Thickness(20);

            Content = BaseContentGrid = new Grid
            {
                RowDefinitions = Rows.Define(
                       (BodyRow.first, Auto),
                       (BodyRow.second, Star)
                       ),
                ColumnDefinitions = Columns.Define(
                       (BodyColumn.first, Auto),
                       (BodyColumn.second, Star)
                       ),
                RowSpacing = 20,
                Children =
                   {
                       new HorizontalStackLayout
        {
                           HorizontalOptions=LayoutOptions.End,
                           Spacing=20,
            Children =
            {
                new ImageButton { Source="notification.png", HeightRequest=24, WidthRequest=21},
                 new ImageButton { Source="cart.png", HeightRequest=22.22, WidthRequest=25}.BindCommand("NavigateToCartCommand"),



            }
        }.Row(BodyRow.first).Column(BodyColumn.second),


            }

            };



        }
        catch (Exception ex)
        {

        }

    }
}