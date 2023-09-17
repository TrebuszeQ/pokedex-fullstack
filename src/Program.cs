using Pokedex.http;

Console.WriteLine("Which pokemon you want to get informations about.");
string pokemon = Console.ReadLine().Trim().ToLower();

Uri uri = new Uri($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
HttpHandler httpHandler = new HttpHandler();
Awaiter(uri, httpHandler);


async Task<string> Awaiter(Uri uri, HttpHandler handler) {
    string lol = await handler.RetResponse(uri);
    return lol;
}

Console.WriteLine(Awaiter(uri, httpHandler));


