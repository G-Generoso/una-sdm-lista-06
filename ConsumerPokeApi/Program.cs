﻿using ConsumerPokeApi.Models;
using static System.Console;

Console.WriteLine("Digite o nome do pokemon que deseja pesquisar:");

var nome =  ReadLine().ToLower();
var pokemonUrl = $"https://pokeapi.co/api/v2/pokemon/{nome}";

Console.WriteLine($"Carregando informações do pokemon {nome}...");
var httpClient = new HttpClient();

try
{
    HttpResponseMessage? response = await httpClient.GetAsync(pokemonUrl);
    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();
    var pokemon = System.Text.Json.JsonSerializer.Deserialize<ConsumerPokeApi.Models.Pokemon>(responseBody);
   Console.WriteLine($"""
Pokemon encontrado: 
ID: {pokemon.Id}
NOME: {pokemon.Nome}
ALTURA: {pokemon.Altura}
PESO: {pokemon.Peso}
""");
}
catch (System.Exception ex)
{
    WriteLine("Erro ao consutar pokemon. Verifique e tente utilizar outro nome: " + ex.Message);
}