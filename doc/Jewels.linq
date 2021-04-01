<Query Kind="Program" />

void Main()
{
	var charmPrefix = new List<(string name, int smallMin, int smallMax, string query1, string query2, string query3)>()
	{
		("Defense",				1, 64,			"jew ID MAG", "DEF", ""),

		("Mana",				5, 20,			"jew ID MAG", "MANA", ""),
		
		("All Resist",			5, 15,			"jew ID MAG", "RES", ""),
		("Fire Resist",			5, 30,			"jew ID MAG", "STAT39", "STAT45=0"),
		("Lightning Resist", 	5, 30,			"jew ID MAG", "STAT41", "STAT39=0"),
		("Cold Resist",			5, 30,			"jew ID MAG", "STAT43", "STAT41=0"),
		("Poison Resist", 		5, 30,			"jew ID MAG", "STAT45", "STAT43=0"),
		("Max Stamina",			10*256, 25*256,	"jew ID MAG", "STAT11", ""),
		("Attack Rating", 		10, 100, 		"jew ID MAG", "STAT19", ""),
		("Mana Per Kill",        1, 3,    		"jew ID MAG", "MAEK", ""),
		("Dmg Taken Goes To Mana",        7, 12,    "jew ID MAG", "DTM", ""),	
		("Enhanced Damage",        5, 40,    	"jew ID MAG", "STAT18", ""),	
		("Heal Stamina",        10, 15,    		"jew ID MAG", "STAT28", ""),
		
		("Dmg vs Demons",        25, 40,    		"jew ID MAG", "STAT121", ""),
		("Dmg vs Undead",        25, 50,   		 "jew ID MAG", "STAT122", ""),		
		("AR vs Demons",        25, 50,   		 "jew ID MAG", "STAT123", ""),
		("AR vs Undead",        25, 50,  		  "jew ID MAG", "STAT124", ""),

		("Bright",        1, 1,    				"jew ID MAG", "STAT89", ""),
		
		("Magic Find",        3, 7,    				"jew ID MAG", "MFIND", "(STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0 OR FHR>0 OR IAS>0 OR GFIND>0 OR LIFE>0 OR REPLIFE>0 OR STAT1>0 OR STR>0 OR DEX>0 OR STAT78>0 OR STAT91=-15)"),
		
		("Max Damage",        1, 15,    		"jew ID MAG", "STAT24", "(STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0 OR FHR>0 OR IAS>0 OR GFIND>0 OR LIFE>0 OR REPLIFE>0 OR STAT1>0 OR STR>0 OR DEX>0 OR STAT78>0 OR STAT91=-15)"),
		("Min Damage",			1, 8,			"jew ID MAG", "STAT23", "(STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0 OR FHR>0 OR IAS>0 OR GFIND>0 OR LIFE>0 OR REPLIFE>0 OR STAT1>0 OR STR>0 OR DEX>0 OR STAT78>0 OR STAT91=-15)"),
		//
		//
		////Bronze, Iron, Steel					 
		//
		//			
		//
		//
		//		
		//
		//		
		//("Magic Find", 			-3, -7,			"jew ID MAG", "MFIND", ""),
		//
		//// Jagged, Forked, Serrated
		//("Max Damage", 			1, 1,			"cm# ID MAG", "STAT24", "STAT19=0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
		//														
		//("Fire", 				2, 29,			"cm# ID MAG", "STAT49", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),		
		//("Light", 				6, 71,			"cm# ID MAG", "STAT51", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
		//("Cold", 				2, 20,			"cm# ID MAG", "STAT55", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
		//("Poison", 				52, 299,		"cm# ID MAG", "STAT58", "(LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0)"),
	};

	var charmSuffix = new List<(string name, int smallMin, int smallMax, string query1, string query2, string query3)>()
	{
		("Life",                3, 20,    "jew ID MAG", "LIFE", ""),
		("Dexterity",          	1, 9,     "jew ID MAG", "DEX", ""),
		("Strength",          	1, 9,     "jew ID MAG", "STR", ""),
		("Energy",          	1, 9,     "jew ID MAG", "STAT1", ""),		
		
		("FHR",          		7, 7,     "jew ID MAG", "FHR", ""),
		("IAS",          		15, 15,   "jew ID MAG", "IAS", ""),	
		
		("Gold Find",         	10, 30,   "jew ID MAG", "GFIND", ""),	
		
		("Fire",         		6, 50,    "jew ID MAG", "STAT49", ""),
		("Light",         		10, 100,  "jew ID MAG", "STAT51", ""),
		("Cold",         		1, 15,    "jew ID MAG", "STAT55", ""),
		("Poison",         		103, 103,    "jew ID MAG", "STAT58", ""),
	
		("Requirements",        -15, -15,    "jew ID MAG", "STAT91", ""),
		
		("Replenish Life",        1, 4,    "jew ID MAG", "REPLIFE", ""),
		
		("Attacker Takes Damage",        1, 5,    "jew ID MAG", "STAT78", ""),

		("Magic Find",        5, 10,        "jew ID MAG", "MFIND", "(DEF>0 OR STAT23>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR STAT11>0 OR STAT19>0 OR MAEK>0 OR DTM>0 OR STAT18>0 OR STAT28>0 OR STAT121>0 OR STAT122>0 OR STAT123>0 OR STAT124>0 OR STAT89>0)"),
		
		("Max Damage",        2, 15,        "jew ID MAG", "STAT24", "(DEF>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR STAT11>0 OR STAT19>0 OR MAEK>0 OR DTM>0 OR STAT18>0 OR STAT28>0 OR STAT121>0 OR STAT122>0 OR STAT123>0 OR STAT124>0 OR STAT89>0)"),
		("Min Damage",        1, 10,        "jew ID MAG", "STAT23", "(DEF>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR STAT11>0 OR STAT19>0 OR MAEK>0 OR DTM>0 OR STAT18>0 OR STAT28>0 OR STAT121>0 OR STAT122>0 OR STAT123>0 OR STAT124>0 OR STAT89>0)"),
			
//		("FRW",          		3, 3,     "jew ID MAG", "FRW", ""),	

//		
//		("Magic Find", 			3, 7,		"cm# ID", "MFIND", ""),
//
//		("Fire",                2, 13,    "cm# ID", "STAT49", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
//		("Light",               3, 28,    "cm# ID", "STAT51", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
//		("Cold",                2, 9,     "cm# ID", "STAT55", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
//		("Poison",              21, 86,   "cm# ID", "STAT58", "((STAT24>0 STAT19>0) OR DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
//	
//		("Max Damage",      	1, 1,     "cm# ID", "STAT24", "STAT19=0 (DEF>0 OR STAT23>0 OR STAT19>0 OR MANA>0 OR RES>0 OR STAT39>0 OR STAT41>0 OR STAT43>0 OR STAT45>0 OR MFIND>0 OR TABSK0=1 OR TABSK1=1 OR TABSK2=1 OR TABSK8=1 OR TABSK9=1 OR TABSK10=1 OR TABSK16=1 OR TABSK17=1 OR TABSK18=1 OR TABSK24=1 OR TABSK25=1 OR TABSK26=1 OR TABSK32=1 OR TABSK33=1 OR TABSK34=1 OR TABSK40=1 OR TABSK41=1 OR TABSK42=1 OR TABSK48=1 OR TABSK49=1 OR TABSK50=1)"),
	};
	
	var charmBoth = new List<(string name, int smallMin, int smallMax, string query1, string query2, string query3)>()
	{
		("Magic Find",        3, 17,        "jew ID MAG", "MFIND", "(DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 STAT23=0 STAT24=0)"),
		("Min Damage",        1, 18,        "jew ID MAG", "STAT23", "(DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 MFIND=0 STAT24=0)"),
		("Max Damage",        1, 30,        "jew ID MAG", "STAT24", "(DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 MFIND=0 STAT23=0)"),

		("Magic Find",        3, 10,        "jew ID MAG", "MFIND", "STAT23>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 STAT24=0)"),
		("Magic Find",        3, 10,        "jew ID MAG", "MFIND", "STAT24>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 STAT23=0)"),

		("Min Damage",        1, 10,        "jew ID MAG", "STAT23", "MFIND>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 STAT24=0)"),
		("Min Damage",        1, 10,        "jew ID MAG", "STAT23", "STAT24>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 MFIND=0)"),

		("Max Damage",        1, 15,        "jew ID MAG", "STAT24", "MFIND>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 STAT23=0)"),
		("Max Damage",        1, 15,        "jew ID MAG", "STAT24", "STAT23>0 (DEF=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 STAT11=0 STAT19=0 MAEK=0 DTM=0 STAT18=0 STAT28=0 STAT121=0 STAT122=0 STAT123=0 STAT124=0 STAT89=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 FHR=0 IAS=0 GFIND=0 LIFE=0 REPLIFE=0 STAT1=0 STR=0 DEX=0 STAT78=0 STAT91=0 MFIND=0)"),

	
//		("Attack Rating",		10, 20,             "cm# ID", "STAT19", "STAT24>0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
//		("Max Damage",      	1, 3,               "cm# ID", "STAT24", "STAT19>0 (LIFE>0 OR DEX>0 OR STR>0 OR FHR>0 OR FRW>0 OR GFIND>0 OR MFIND>0 OR STAT49>0 OR STAT51>0 OR STAT55>0 OR STAT58>0)"),
//		
//		// Fine,Sharp Solo
//		("Attack Rating",       10, 20,             "cm# ID", "STAT19", "STAT24>0 (LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//		("Max Damage",      	1, 3,               "cm# ID", "STAT24", "STAT19>0 (LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//
//		// Maximum Damage Only
//		("Max Damage",      	1, 2,               "cm# ID", "STAT24", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//	
//		// Single Element
//		("Fire",                2, 42,              "cm# ID", "STAT49", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT51=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//		("Light",               3, 99,              "cm# ID", "STAT51", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT55=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//		("Cold",                2, 29,              "cm# ID", "STAT55", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT58=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),
//		("Poison",              21, 385,           	"cm# ID", "STAT58", "(STAT19=0 LIFE=0 DEX=0 STR=0 FHR=0 FRW=0 GFIND=0 MFIND=0 STAT49=0 STAT51=0 STAT55=0 DEF=0 STAT23=0 MANA=0 RES=0 STAT39=0 STAT41=0 STAT43=0 STAT45=0 TABSK0=0 TABSK1=0 TABSK2=0 TABSK8=0 TABSK9=0 TABSK10=0 TABSK16=0 TABSK17=0 TABSK18=0 TABSK24=0 TABSK25=0 TABSK26=0 TABSK32=0 TABSK33=0 TABSK34=0 TABSK40=0 TABSK41=0 TABSK42=0 TABSK48=0 TABSK49=0 TABSK50=0)"),

	};


	Console.WriteLine();
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("///// Prefixes");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
	Console.WriteLine();


	foreach(var item in charmPrefix)
	{
		Console.WriteLine(ItemFilter.Comment(item.name));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");	
		ItemFilter.DisplayPrefixLogic(item.smallMin, item.smallMax, true, item.name, item.query1.Replace("#","1"), item.query2, item.query3);
			
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

		Console.WriteLine(ItemFilter.Comment(item.name));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
		ItemFilter.DisplaySuffixLogic(item.smallMin, item.smallMax, true, item.name, item.query1.Replace("#", "1"), item.query2, item.query3);

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

		Console.WriteLine(ItemFilter.Comment(item.name));
		Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
		ItemFilter.DisplayPrefixLogic(item.smallMin, item.smallMax, true, item.name, item.query1.Replace("#", "1"), item.query2, item.query3);

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