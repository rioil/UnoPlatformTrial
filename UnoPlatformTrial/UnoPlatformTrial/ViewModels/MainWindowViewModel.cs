using Reactive.Bindings;
using System;
using System.Collections.ObjectModel;
using UnoPlatformTrial.Models;

namespace UnoPlatformTrial.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactivePropertySlim<ObservableCollection<Item>> Messages { get; set; }
        public ReactivePropertySlim<Item?> SelectedItem { get; }

        public MainWindowViewModel()
        {
            Messages = new ReactivePropertySlim<ObservableCollection<Item>>(new ObservableCollection<Item>());
            SelectedItem = new ReactivePropertySlim<Item?>();
            AddMessageCommand = new ReactiveCommandSlim().WithSubscribe(AddMessage);
        }

        public ReactiveCommandSlim AddMessageCommand { get; set; }
        private void AddMessage()
        {
            Messages.Value.Add(new(Messages.Value.Count + 1, Guid.NewGuid().ToString()));
        }
    }
}
