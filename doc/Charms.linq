<Query Kind="Program" />

void Main()
{
	var isSkiller = "(TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)";
	
	var charmPrefix = new List<(string name, int smallMin, int smallMax, int largeMin, int largeMax, int grandMin, int grandMax,  string query1, string query2, string query3)>()
	{
		("Defense",				1, 30,					2, 60,				3,	100,				"cm# ID", "DEF", ""),
		("Min Damage",			1, 1,					1, 2,				1,	3,					"cm# ID", "STAT23", ""),
		("Max Stamina",			4*256, 16*256,			8*256, 32*256,		12*256,	50*256,			"cm# ID", "STAT11", ""),
		//Bronze, Iron, Steel
		("Attack Rating", 		2, 36, 					4, 77, 				6, 132, 				"cm# ID", "STAT19", "STAT24=0"),
		("Mana",				1, 17,					2, 34,				3,	59,					"cm# ID", "MANA", ""),			
		("All Resist",			3, 5,					3, 8,				3,	15,					"cm# ID", "RES", ""),
		("Fire Resist",			3, 11,					4, 15,				7,	30,					"cm# ID", "STAT39", "STAT45=0"),
		("Lightning Resist", 	3, 11,					4, 15,				7,	30,					"cm# ID", "STAT41", "STAT39=0"),		
		("Cold Resist",			3, 11,					4, 15,				7,	30,					"cm# ID", "STAT43", "STAT41=0"),
		("Poison Resist", 		3, 11,					4, 15,				7,	30,					"cm# ID", "STAT45", "STAT43=0"),		
		("Magic Find", 			-3, -7,					1, 6,				1,	12,					"cm# ID", "MFIND", ""),
		
		// Jagged, Forked, Serrated
		("Max Damage", 			1, 1,					1, 2,				1,	3,					"cm# ID", "STAT24", "STAT19=0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
																													
		("Fire", 				2, 29,					2, 43,				2,	36,					"cm# ID", "STAT49", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),		
		("Light", 				6, 71,					5, 90,				4,	79,					"cm# ID", "STAT51", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
		("Cold", 				2, 20,					3, 30,				2,	25,					"cm# ID", "STAT55", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
		("Poison", 				52, 299,				35, 299,			18,	171,				"cm# ID", "STAT58", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
	};

	var charmSuffix = new List<(string name, int smallMin, int smallMax, int largeMin, int largeMax, int grandMin, int grandMax, string query1, string query2, string query3)>()
	{
		("Life",                5, 20,      			6, 35,      		5,  45,         		"cm# ID", "LIFE", ""),
		("Dexterity",          	1, 2,       			2, 5,       		3,  6,          		"cm# ID", "DEX", ""),
		("Strength",          	1, 2,      				2, 5,       		3,  6,          		"cm# ID", "STR", ""),
		("FHR",          		5, 5,       			8, 8,       		12,  12,        		"cm# ID", "FHR", ""),
		("FRW",          		3, 3,       			5, 5,       		7,  7,          		"cm# ID", "FRW", ""),	
		("Gold Find",         	5, 10,      			5, 22,      		10,  40,        		"cm# ID", "GFIND", ""),	
		("Magic Find", 			3, 7,					-1, -6,				-1,	-12,				"cm# ID", "MFIND", ""),

		("Fire",                2, 13,                  2, 17,              2,  14,                 "cm# ID", "STAT49", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
		("Light",               3, 28,                  3, 38,              2,  33,                 "cm# ID", "STAT51", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
		("Cold",                2, 9,                   2, 12,              2,  11,                 "cm# ID", "STAT55", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
		("Poison",              21, 86,                 21, 86,             21, 86,                 "cm# ID", "STAT58", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
	
		("Max Damage",      	1, 1,                 	1, 2,             	1, 4,                 	"cm# ID", "STAT24", "STAT19=0 (DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
	};
	
	var charmBoth = new List<(string name, int smallMin, int smallMax, int largeMin, int largeMax, int grandMin, int grandMax, string query1, string query2, string query3)>()
	{	
		("Attack Rating",		10, 20,                 10, 48,             10, 76,                 "cm# ID", "STAT19", "STAT24>0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
		("Max Damage",      	1, 3,                 	1, 6,             	1, 10,                 	"cm# ID", "STAT24", "STAT19>0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
		
		// Fine,Sharp Solo
		("Attack Rating",       10, 20,                 10, 48,             10, 76,                 "cm# ID", "STAT19", "STAT24>0 (LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
		("Max Damage",      	1, 3,                   1, 6,               1, 10,                  "cm# ID", "STAT24", "STAT19>0 (LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),

		// Maximum Damage Only
		("Max Damage",      	1, 2,                   1, 4,               1, 7,                   "cm# ID", "STAT24", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
	
		// Single Element
		("Fire",                2, 42,                  2, 60,              2, 50,                  "cm# ID", "STAT49", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
		("Light",               3, 99,                  3, 128,             2, 112,                 "cm# ID", "STAT51", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
		("Cold",                2, 29,                  2, 42,              2, 36,                  "cm# ID", "STAT55", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
		("Poison",              21, 385,                 21, 385,             21, 257,                  "cm# ID", "STAT58", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),

	};


	Console.WriteLine();
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("///// Prefixes");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine();


	foreach(var item in charmPrefix)
	{
		var smallSpace = Math.Abs(item.smallMax) / 1.0;
		var largeSpace = Math.Abs(item.largeMax) / 2.0;
		var grandSpace = Math.Abs(item.grandMax) / 3.0;
		
		Console.WriteLine(ItemFilter.Comment(item.name + "\t\t\t\t Efficiency(Small: " + smallSpace.ToString("0.0") + " | Large: " + largeSpace.ToString("0.0") + " | Grand: " + grandSpace.ToString("0.0") + ")"));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
		
		// Small
		var smallMostEfficient = (smallSpace >= largeSpace) && (smallSpace >= grandSpace);
		if (item.smallMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.smallMin, item.smallMax, smallMostEfficient, item.name, item.query1.Replace("#","1"), item.query2, item.query3);
		}
				
		// Large
		var largeMostEfficient = (largeSpace >= smallSpace) && (largeSpace >= grandSpace);
		if (item.largeMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.largeMin, item.largeMax, largeMostEfficient, item.name, item.query1.Replace("#","2"), item.query2, item.query3);			
		}
		
		// Grand
		var grandMostEfficient = (grandSpace >= smallSpace) && (grandSpace >= largeSpace);
		if (item.grandMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.grandMin, item.grandMax, grandMostEfficient, item.name, item.query1.Replace("#","3"), item.query2, item.query3);				
		}
		
		Console.WriteLine();
	}
	
	Console.WriteLine();
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("///// Suffixes");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine();
	
	foreach (var item in charmSuffix)
	{
		var smallSpace = Math.Abs(item.smallMax) / 1.0;
		var largeSpace = Math.Abs(item.largeMax) / 2.0;
		var grandSpace = Math.Abs(item.grandMax) / 3.0;

		Console.WriteLine(ItemFilter.Comment(item.name + "\t\t\t Efficiency(Small:" + smallSpace.ToString("0.0") + " | Large:" + largeSpace.ToString("0.0") + " | Grand: " + grandSpace.ToString("0.0") + ")"));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");

		// Small
		var smallMostEfficient = (smallSpace >= largeSpace) && (smallSpace >= grandSpace);
		if (item.smallMax > 0)
		{
			ItemFilter.DisplaySuffixLogic(item.smallMin, item.smallMax, smallMostEfficient, item.name, item.query1.Replace("#", "1"), item.query2, item.query3);
		}

		// Large
		var largeMostEfficient = (largeSpace >= smallSpace) && (largeSpace >= grandSpace);
		if (item.largeMax > 0)
		{
			ItemFilter.DisplaySuffixLogic(item.largeMin, item.largeMax, largeMostEfficient, item.name, item.query1.Replace("#", "2"), item.query2, item.query3);
		}

		// Grand
		var grandMostEfficient = (grandSpace >= smallSpace) && (grandSpace >= largeSpace);
		if (item.grandMax > 0)
		{
			ItemFilter.DisplaySuffixLogic(item.grandMin, item.grandMax, grandMostEfficient, item.name, item.query1.Replace("#", "3"), item.query2, item.query3);
		}

		Console.WriteLine();
	}

	Console.WriteLine();
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("///// Both");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine();

	foreach (var item in charmBoth)
	{
		var smallSpace = Math.Abs(item.smallMax) / 1.0;
		var largeSpace = Math.Abs(item.largeMax) / 2.0;
		var grandSpace = Math.Abs(item.grandMax) / 3.0;

		Console.WriteLine(ItemFilter.Comment(item.name + "\t\t\t Efficiency(Small:" + smallSpace.ToString("0.0") + " | Large:" + largeSpace.ToString("0.0") + " | Grand: " + grandSpace.ToString("0.0") + ")"));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");

		// Small
		var smallMostEfficient = (smallSpace >= largeSpace) && (smallSpace >= grandSpace);
		if (item.smallMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.smallMin, item.smallMax, smallMostEfficient, item.name, item.query1.Replace("#", "1"), item.query2, item.query3);
		}

		// Large
		var largeMostEfficient = (largeSpace >= smallSpace) && (largeSpace >= grandSpace);
		if (item.largeMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.largeMin, item.largeMax, largeMostEfficient, item.name, item.query1.Replace("#", "2"), item.query2, item.query3);
		}

		// Grand
		var grandMostEfficient = (grandSpace >= smallSpace) && (grandSpace >= largeSpace);
		if (item.grandMax > 0)
		{
			ItemFilter.DisplayPrefixLogic(item.grandMin, item.grandMax, grandMostEfficient, item.name, item.query1.Replace("#", "3"), item.query2, item.query3);
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