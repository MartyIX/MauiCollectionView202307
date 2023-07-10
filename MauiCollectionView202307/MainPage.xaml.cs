using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiCollectionView202307;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Monkey> Monkeys { get; }

	public MainPage()
	{
        Monkeys = new()
        {
            new Monkey()
            {
                Name = "#1"
            },
            new Monkey()
            {
                Name = "#2"
            },
            new Monkey()
            {
                Name = "#3"
            },
        };

        OnPropertyChanged(nameof(Monkeys));

        this.BindingContext = this;
        InitializeComponent();
	}

    /// <inheritdoc cref="EventHandler"/>
    public void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        
    }
}

public class Monkey
{
    public string Name { get; set; }
}