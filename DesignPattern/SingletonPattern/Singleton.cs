using System;
namespace DesignPattern.Singleton
{
// 1. should be a public class
	public class Singleton
	{
		// 2. the only one instance
		// private: because it is accesible just from this class
		// readonly: because client just can read not edit
		// static: because dont need instance objects this property belongs to the class.
		private readonly static Singleton _instance = new Singleton();

		//4. a getter to access to the _instance from outside of the class.
		public static Singleton Instance
		{
			get
			{
				return _instance;
			}
		}

        // 3. prohibit instantiations
        private Singleton()
		{}
	}
}

