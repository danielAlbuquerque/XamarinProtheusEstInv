using System;
using Xamarin.Forms;

namespace SigaMATA270.Validators
{
    public class UsernameValidationBehavior : Behavior<Entry>
    {
		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged += HandleTextChanged;
			base.OnAttachedTo(bindable);
		}

		void HandleTextChanged(object sender, TextChangedEventArgs e)
		{
			bool IsValid = false;
            IsValid = !String.IsNullOrEmpty(e.NewTextValue) && !String.IsNullOrWhiteSpace(e.NewTextValue);
			((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;
		}

		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.TextChanged -= HandleTextChanged;
			base.OnDetachingFrom(bindable);
		}
    }
}
