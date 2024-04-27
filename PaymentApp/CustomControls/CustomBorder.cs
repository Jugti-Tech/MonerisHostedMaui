using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;

namespace PaymentApp.CustomControls;

public class CustomBorder : Border
{

    public CustomBorder()
    {

        StrokeThickness = .5;
        StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(10) };
        Padding = new Thickness(0);

        this.AppThemeBinding(Border.StrokeProperty, Brush.Black, Brush.White);
        this.AppThemeBinding(Border.BackgroundColorProperty, Colors.White, Color.FromArgb("#4C4C4C"));

    }
}