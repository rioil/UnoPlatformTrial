using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using UnoPlatformTrial.Models;

namespace UnoPlatformTrial.Controls
{
    public partial class ItemDetailsView : UserControl
    {
        public ItemDetailsView()
        {
            InitializeComponent();
        }

        public Item? Item
        {
            get { return (Item?)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", typeof(Item), typeof(ItemDetailsView), new PropertyMetadata(default));
    }
}
