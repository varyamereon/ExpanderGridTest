using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Windows.Input;

namespace ExpanderGridTest
{
	public class MainPageViewModel : BaseViewModel
	{
		private IReadOnlyList<Contact> Contacts => Contact.Contacts;

		private Contact? currentContact;
		public Contact? CurrentContact
		{
			get => currentContact;
			set => SetProperty(ref currentContact, value);
		}

		public ICommand ButtonClickedCommand { get; }

		public MainPageViewModel() => ButtonClickedCommand = new Command<string>(OnButtonClickedCommandExecuted);

		private void OnButtonClickedCommandExecuted(string? parameter) => CurrentContact = parameter switch
		{
			"1" => Contacts[0],
			"2" => Contacts[1],
			"3" => Contacts[2],
			_ => null
		};
	}
}
