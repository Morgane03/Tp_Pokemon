using UnityEngine;

public class GetPokemon : MonoBehaviour
{
    private Pokemon sashaPokemon;
    private Pokemon ondinePokemon;
    private Pokemon[] sashaPokemons = { new Salameche(), new Bulbizarre(), new Carapuce(), new Pikatchu() };
    private Pokemon[] ondinePokemons = { new Salameche(), new Bulbizarre(), new Carapuce(), new Pikatchu() };

    [SerializeField]
    private Terrain terrain;

    public Pokemon[] SashaPokemons { get { return sashaPokemons; } }
    public Pokemon[] OndinePokemons { get { return ondinePokemons; }}

    public void StartGame()
    {
        terrain.GiveField();

        for (int i = 0; i < 2; i++)
        {
            int sashaRandomPokemonIndex = Random.Range(0, sashaPokemons.Length);
            int ondineRandomPokemonIndex = Random.Range(0, ondinePokemons.Length);
            sashaPokemons[i] = sashaPokemons[sashaRandomPokemonIndex];
            ondinePokemons[i] = ondinePokemons[ondineRandomPokemonIndex];
        }

        Debug.Log($"Sasha possède les Pokémon {sashaPokemons[0].PokemonName} et {sashaPokemons[1].PokemonName}");
        Debug.Log($"Ondine possède les Pokémon {ondinePokemons[0].PokemonName} et {ondinePokemons[1].PokemonName}");

        StartBattle();
    }

    public void StartBattle()
    {
        sashaPokemon = sashaPokemons[0];
        ondinePokemon = ondinePokemons[0];
        Debug.Log($"Sasha : {sashaPokemon.PokemonName} je te choisis !");
        Debug.Log($"Ondine : {ondinePokemon.PokemonName} je te choisis !");
    }

    public void SachaChange()
    {
        sashaPokemon = sashaPokemons[0];
        Debug.Log($"Sasha : {sashaPokemon.PokemonName} je te choisis !");
    }

    public void OndineChange()
    {
        ondinePokemon = ondinePokemons[0];
        Debug.Log($"Ondine : {ondinePokemon.PokemonName} je te choisis !");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            sashaPokemon.AttackSpePokemon(ondinePokemon);
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            sashaPokemon.Charge(ondinePokemon);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            ondinePokemon.AttackSpePokemon(sashaPokemon);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ondinePokemon.Charge(sashaPokemon);
        }
    }
}
