string Friend = "Szymon";
Console.WriteLine(Friend);

Friend = "Maria";
Console.WriteLine(Friend);

Console.WriteLine("Hello " + Friend);

Console.WriteLine($"Hello {Friend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
Console.WriteLine($"The name {Friend} has a {Friend.Length} letters. ");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string message = "Hello, how are you?";
Console.WriteLine(message);
message = message.Replace("Hello", "Hi");
Console.WriteLine(message);

Console.WriteLine(message.ToUpper());
Console.WriteLine(message.ToLower());


string songtext = "Forever young i want to be forever young";
Console.WriteLine(songtext.Contains("young"));
Console.WriteLine(songtext.Contains("never"));