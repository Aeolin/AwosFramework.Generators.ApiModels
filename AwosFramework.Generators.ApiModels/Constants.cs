using System;
using System.Collections.Generic;
using System.Text;

namespace AwosFramework.Generators.ApiModels
{
	public static class Constants
	{
		public const string NameSpace = "AwosFramework.Generators.ApiModels";

		public const string ApiModelAttribute = 
		$$"""
		using System;

		namespace {{NameSpace}} 
		{
			[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
			public class ApiModelAttribute : Attribute 
			{
				public string PropertyName { get; set; }
			}
		}
		""";
	}
}
