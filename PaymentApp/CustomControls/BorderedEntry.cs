using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApp.CustomControls
{
    public class BorderedEntry : CustomBorder
    {
        public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(BorderedEntry), string.Empty, BindingMode.TwoWay, propertyChanged: EntryTextPropetyChanged);

        private static void EntryTextPropetyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BorderedEntry control = (BorderedEntry)bindable;
            if (control != null)
            {
                control.entry.Text = newValue?.ToString();
            }
        }

        public string EntryText
        {
            get => (string)GetValue(EntryTextProperty);
            set => SetValue(EntryTextProperty, value);
        }

        public static readonly BindableProperty PlaceholderTextProperty = BindableProperty.Create(nameof(PlaceholderText), typeof(string), typeof(BorderedEntry), string.Empty, BindingMode.OneTime, propertyChanged: PlaceholderTextPropetyChanged);

        private static void PlaceholderTextPropetyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BorderedEntry control = (BorderedEntry)bindable;
            if (control != null)
            {
                control.entry.Placeholder = newValue?.ToString();
            }
        }

        public string PlaceholderText
        {
            get => (string)GetValue(PlaceholderTextProperty);
            set => SetValue(PlaceholderTextProperty, value);
        }


        public CustomEntry entry;

        public BorderedEntry()
        {
            try
            {
                HorizontalOptions = LayoutOptions.Start;
                entry = new CustomEntry { }.Bind(CustomEntry.TextProperty, nameof(EntryText), BindingMode.TwoWay, source: this);

                entry.FontFamily = "InterMedium";
                entry.FontSize = 15;
                Content = entry;

            }

            catch (Exception ex)
            {

                Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
