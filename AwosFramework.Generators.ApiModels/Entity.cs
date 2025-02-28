using System;
using System.Collections.Generic;
using System.Text;

namespace AwosFramework.Generators.ApiModels
{
	public class Entity
	{
		public string NameSpace { get; set; }
		public string Name { get; set; }

	}

	public class Field
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string DefaultValue { get; set; }
	}
}
