using MvvmHelpers;
using System.Collections.Generic;

namespace ExpanderGridTest
{
	public class Contact : ObservableObject
	{
		public Contact(string _name) => name = _name;

		private string name;
		public string Name
		{
			get => name;
			set => SetProperty(ref name, value);
		}

		private string? company;
		public string? Company
		{
			get => company;
			set => SetProperty(ref company, value);
		}

		private string? phone;
		public string? Phone
		{
			get => phone;
			set => SetProperty(ref phone, value);
		}

		private string? email;
		public string? Email
		{
			get => email;
			set => SetProperty(ref email, value);
		}

		public static IReadOnlyList<Contact> Contacts => new List<Contact>()
		{
			new Contact("Dave Smith")
			{
				Company="Developer Industries",
				Phone="+19369363563289",
				Email="dave.smith@developerindustries.com"
			},
			new Contact("Mike Jones")
			{
				Company="A Big Company Inc."
			},
			new Contact("Henry Black")
		};
	}
}
