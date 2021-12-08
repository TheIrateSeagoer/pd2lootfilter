<Query Kind="Program" />

void Main()
{
	var staffmods = new List<(List<string> filterKeywords, List<string> skills)>()
	{
		(new List<string>() {"CL6", "WP11"}, new List<string>(){ 	"SK36",
										"SK37",
										"SK38",
										"SK39",
										"SK40",
										"SK41",
										"SK42",
										"SK43",
										"SK44",
										"SK45",
										"SK46",
										"SK47",
										"SK48",
										"SK49",
										"SK50",
										"SK51",
										"SK52",
										"SK53",
										"SK54",
										"SK55",
										"SK56",
										"SK57",
										"SK58",
										"SK59",
										"SK60",
										"SK61",
										"SK62",
										"SK63",
										"SK64",
										"SK65",
										"SK369",
										"SK376",
										"SK383" }),																
		(new List<string>() {"CL4", "WP12"}, new List<string>(){ "SK66",
									  "SK67",
									  "SK68",
									  "SK69",
									  "SK70",
									  "SK71",
									  "SK72",
									  "SK73",
									  "SK74",
									  "SK75",
									  "SK76",
									  "SK77",
									  "SK78",
									  "SK79",
									  "SK80",
									  "SK81",
									  "SK82",
									  "SK83",
									  "SK84",
									  "SK85",
									  "SK86",
									  "SK87",
									  "SK88",
									  "SK89",
									  "SK90",
									  "SK91",
									  "SK92",
									  "SK93",
									  "SK94",
									  "SK95",
									  "SK367",
									  "SK374",
									  "SK381" }),
		(new List<string>() {"WP13"}, new List<string>(){   "SK96",
										  "SK97",
										  "SK98",
										  "SK99",
										  "SK100",
										  "SK101",
										  "SK102",
										  "SK103",
										  "SK104",
										  "SK105",
										  "SK106",
										  "SK107",
										  "SK108",
										  "SK109",
										  "SK110",
										  "SK111",
										  "SK112",
										  "SK113",
										  "SK114",
										  "SK115",
										  "SK116",
										  "SK117",
										  "SK118",
										  "SK119",
										  "SK120",
										  "SK121",
										  "SK122",
										  "SK123",
										  "SK124",
										  "SK125",
										  "SK364",
										  "SK371",
										  "SK378" }),
		(new List<string>() {"CL2"}, new List<string>(){   "SK126",
										  "SK127",
										  "SK128",
										  "SK129",
										  "SK130",
										  "SK131",
										  "SK132",
										  "SK133",
										  "SK134",
										  "SK135",
										  "SK136",
										  "SK137",
										  "SK138",
										  "SK139",
										  "SK140",
										  "SK141",
										  "SK142",
										  "SK143",
										  "SK144",
										  "SK145",
										  "SK146",
										  "SK147",
										  "SK148",
										  "SK149",
										  "SK150",
										  "SK151",
										  "SK152",
										  "SK153",
										  "SK154",
										  "SK155" }),
		(new List<string>() {"CL1", "(clb OR spc OR 9cl OR 9sp OR 7cl OR 7sp)"}, new List<string>(){     "SK221",
										  "SK222",
										  "SK223",
										  "SK224",
										  "SK225",
										  "SK226",
										  "SK227",
										  "SK228",
										  "SK229",
										  "SK230",
										  "SK231",
										  "SK232",
										  "SK233",
										  "SK234",
										  "SK235",
										  "SK236",
										  "SK237",
										  "SK238",
										  "SK239",
										  "SK240",
										  "SK241",
										  "SK242",
										  "SK243",
										  "SK244",
										  "SK245",
										  "SK246",
										  "SK247",
										  "SK248", 
										  "SK249",
										  "SK250",
										  "SK370" }),
	(new List<string>() {"CL5"}, new List<string>(){          "SK251",
											  "SK252",
											  "SK253",
											  "SK254",
											  "SK255",
											  "SK256",
											  "SK257",
											  "SK258",
											  "SK259",
											  "SK260",
											  "SK261",
											  "SK262",
											  "SK263",
											  "SK264",
											  "SK265",
											  "SK266",
											  "SK267",
											  "SK268",
											  "SK269",
											  "SK270",
											  "SK271",
											  "SK272",
											  "SK273",
											  "SK274",
											  "SK275",
											  "SK276",
											  "SK277",
											  "SK278",
											  "SK279",
											  "SK280",
											  "SK366" }),
	};

	for(int i = 1; i < 4; ++i)
	{
		foreach (var item in staffmods)
		{
			foreach(var keyword in item.filterKeywords)
			{
				StringBuilder s = new StringBuilder();
				s.Append("!RW !UNI !SET !RARE NMAG " + keyword);
				
				s.Append(" (");
				
				foreach(var skill in item.skills)
				{
					if (skill != item.skills.Last())
					{
						s.Append(skill+"<"+i+" AND ");
					}
				}
				s.Append(item.skills.Last()+"<"+i);
				
				s.Append(")");
				
				Console.Write(ItemFilter.Display(s.ToString()));
				Console.Write("#HIDE//");
				Console.WriteLine();
			}
		}
						Console.WriteLine();
	}
}

// You can define other methods, fields, classes and namespaces here
public static class ItemFilter
{
	public static string Comment(string text)
	{
		return "///// " + text;
	}
	public static string Display(string query)
	{
		return "ItemDisplay[" + query + "]:";	
	}
	
	public static string Range(string selector, int minValue, int maxValue)
	{
		return selector + ">" + (minValue-1) + " " + selector + "<" + maxValue;	
	}
	
	public static string ContinuePrefix(string prefix)
	{
		return prefix + " %NAME%%CONTINUE%//";
	}
	public static string ContinueSuffix(string suffix)
	{
		return "%NAME% " + suffix + "%CONTINUE%//";
	}

	public static string Perfect(this string text)
	{
		return "%PURPLE%" + text;
	}
	public static string Good(this string text)
	{
		return "%RED%" + text;
	}
	public static string GoodNotEfficient(this string text)
	{
		return "%DARK_GREEN%" + text;
	}
	public static string Bad(this string text)
	{
		return "%GRAY%" + text;
	}
	
	
	public static void DisplayPrefixLogic(int minValue, int maxValue, bool mostEfficient, string name, string query1, string query2, string query3)
	{
		if (minValue == maxValue)
		{
			if (mostEfficient)
			{
				Console.WriteLine(Display(query1 + " " + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix((mostEfficient? name.Perfect() : name.Bad())));
			}
		}
		else if (maxValue - minValue == 1)
		{
			Console.WriteLine(Display(query1 + " " + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix((mostEfficient? name.Perfect() : name.Good())));
			Console.WriteLine(Display(query1 + " " + query2 + "=" + minValue + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix((mostEfficient? name.Good() : name.Bad())));
		}
		else
		{
			var cutoff = (int)(maxValue * 0.9);
			Console.WriteLine(Display(query1 + " " + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix((mostEfficient? name.Perfect() : name.Good())));
			Console.WriteLine(Display(query1 + " " + Range(query2, cutoff, maxValue) + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix((mostEfficient? name.Good() : name.GoodNotEfficient())));
			Console.WriteLine(Display(query1 + " " + Range(query2, minValue, cutoff) + (string.IsNullOrEmpty(query3)?"":" " + query3)) + ContinuePrefix(name.Bad()));
		}
	}

	public static void DisplaySuffixLogic(int minValue, int maxValue, bool mostEfficient, string name, string query1, string query2, string query3)
	{
		if (minValue == maxValue)
		{
			Console.WriteLine(Display(query1 + " "  + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix((mostEfficient ? name.Perfect() : name.Bad())));
		}
		else if (maxValue - minValue == 1)
		{
			Console.WriteLine(Display(query1 + " " + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix((mostEfficient ? name.Perfect() : name.Good())));
			Console.WriteLine(Display(query1 + " " + query2 + "=" + minValue + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix((mostEfficient ? name.Good() : name.Bad())));
		}
		else
		{
			var cutoff = (int)(maxValue * 0.9);
			Console.WriteLine(Display(query1 + " " + query2 + "=" + maxValue + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix((mostEfficient ? name.Perfect() : name.Good())));
			Console.WriteLine(Display(query1 + " " + Range(query2, cutoff, maxValue) + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix((mostEfficient ? name.Good() : name.GoodNotEfficient())));
			Console.WriteLine(Display(query1 + " " + Range(query2, minValue, cutoff) + (string.IsNullOrEmpty(query3) ? "" : " " + query3)) + ContinueSuffix(name.Bad()));
		}
	}
}