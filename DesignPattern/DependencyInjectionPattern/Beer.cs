using System;
namespace DesignPattern.DependencyInjectionPattern
{
	public class Beer
	{
		private string _name { get; set; }
        private string _brand { get; set; }

		public string Name
		{
			get
			{
				return _name;
			}
		}

		public Beer(string name, string brand)
		{
			_name = name;
			_brand = brand;
		}
	}
}

