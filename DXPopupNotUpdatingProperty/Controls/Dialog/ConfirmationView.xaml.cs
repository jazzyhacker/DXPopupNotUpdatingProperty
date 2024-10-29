using System.Windows.Input;

namespace DXPopupNotUpdatingProperty.Controls.Dialog;

public partial class ConfirmationView : ContentView
{
    #region Bindable Properties
    #region IsOpenDXPopup
    public static readonly BindableProperty IsOpenDXPopupProperty = BindableProperty.Create(nameof(IsOpenDXPopup), typeof(bool), typeof(ConfirmationView), false);

    public bool IsOpenDXPopup
    {
        get => (bool)GetValue(IsOpenDXPopupProperty);
        set => SetValue(IsOpenDXPopupProperty, value);
    }
    #endregion

    #region IsOpen
    public static readonly BindableProperty IsOpenLabelProperty = BindableProperty.Create(nameof(IsOpenLabel), typeof(bool), typeof(ConfirmationView), false);

    public bool IsOpenLabel
    {
        get => (bool)GetValue(IsOpenLabelProperty);
        set => SetValue(IsOpenLabelProperty, value);
    }
    #endregion

    #region Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ConfirmationView), string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    #endregion

    #region YesCommand
    public static readonly BindableProperty YesCommandProperty = BindableProperty.Create(nameof(YesCommand), typeof(ICommand), typeof(ConfirmationView));

    public ICommand YesCommand
    {
        get => (ICommand)GetValue(YesCommandProperty);
        set => SetValue(YesCommandProperty, value);
    }
    #endregion

    #region CancelCommand
    public static readonly BindableProperty CancelCommandProperty = BindableProperty.Create(nameof(CancelCommand), typeof(ICommand), typeof(ConfirmationView));

    public ICommand CancelCommand
    {
        get => (ICommand)GetValue(CancelCommandProperty);
        set => SetValue(CancelCommandProperty, value);
    }
    #endregion
    #endregion

    public ConfirmationView()
	{
		InitializeComponent();
	}
}