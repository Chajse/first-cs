// first c# with the boys

//numero uno

Console.WriteLine("Name: AJAAA");

//numero dos

Console.WriteLine("Name: "+ "AJAAA");

//numero tres

string myName = "AJAAA";
Console.WriteLine("Name: " + myName);

//numero quatro

Console.WriteLine($"Name: {myName}");

//numero singco

string myFriend = "dominic molino";
Console.WriteLine($"My name is {myName} and my megaidok's name is {myFriend}");

//numero sais

Console.WriteLine($"my name {myName} has {myName.Length} letters");
Console.WriteLine($"my megaidok's name {myFriend} has {myFriend.Length} letters");

//numero siyete

string Thing = "Putok";
Console.WriteLine($"Shawn has {Thing}");

//numero otso

string greeting = "    MABANTOT SI SHAWN RADA    ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

//numero nuwebe

string sayGreet= "Denzel low sa Iron HAHAHAHA";
Console.WriteLine(sayGreet);
sayGreet = sayGreet.Replace("Denzel", "Aid");
Console.WriteLine(sayGreet);

//diez

Console.WriteLine(sayGreet.ToUpper());
Console.WriteLine(sayGreet.ToLower());

//onse boolean

string myStatement = "ang singit ni Aid ay mabaho, kapag gabi ay mabango";
Console.WriteLine(myStatement.Contains("mabaho"));
Console.WriteLine(myStatement.Contains("Mabango"));

//dose 
Console.WriteLine(myStatement.StartsWith("ang"));
Console.WriteLine(myStatement.StartsWith("kapag"));

Console.WriteLine(myStatement.EndsWith("mabango"));
Console.WriteLine(myStatement.EndsWith("singit"));