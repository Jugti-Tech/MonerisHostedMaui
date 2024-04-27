using CommunityToolkit.Maui.Markup;

namespace PaymentApp.CustomControls;

public class CustomEntry : Entry
{
    public CustomEntry()
    {
        this.AppThemeBinding(Entry.TextColorProperty, Colors.Black, Colors.White)
       .AppThemeBinding(Entry.PlaceholderColorProperty, Colors.Black, Colors.White);
        this.FontFamily = "InterMedium";
        this.FontSize = 15;

    }

}