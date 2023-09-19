using Pokedex.http;

Console.WriteLine("Which pokemon you want to get informations about.");
string pokemon = Console.ReadLine().Trim().ToLower();

Uri uri = new Uri($"https://pokeapi.co/api/v2/pokemon/{pokemon}");

HttpHandler httpHandler = new HttpHandler();
string response = await httpHandler.RetResponse(uri);
Console.WriteLine(response);



