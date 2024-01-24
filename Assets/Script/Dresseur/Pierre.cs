using UnityEngine;

public class Pierre : MonoBehaviour
{
    private Pokemon[] sashaPokemons;
    private Pokemon[] ondinePokemons;

    private void Start()
    {
        GetPokemon getPokemonScript = FindObjectOfType<GetPokemon>();
        sashaPokemons = getPokemonScript.SashaPokemons;
        ondinePokemons = getPokemonScript.OndinePokemons;
    }

    public void SoinTotalSacha(Pokemon pokemon)
    {
        if(pokemon.isAlive && sashaPokemons[0])
        {
            sashaPokemons[0].hp = sashaPokemons[0].maxhp;
            Debug.Log($"Pierre soigne completement {pokemon.name} de Sasha");
        }
        else
        {
            sashaPokemons[1].hp = sashaPokemons[1].maxhp;
            Debug.Log($"Pierre soigne completement {pokemon.name} de Sasha");
        }
    }

    public void SoinTotalOndine(Pokemon pokemon)
    {
        if (pokemon.isAlive && ondinePokemons[0])
        {
            ondinePokemons[0].hp = ondinePokemons[0].maxhp;
            Debug.Log($"Pierre soigne completement {pokemon.name} d'Ondine");
        }
        else
        {
            ondinePokemons[1].hp = ondinePokemons[1].maxhp;
            Debug.Log($"Pierre soigne completement {pokemon.name} d'Ondine");
        }
    }

    public void Cuisiner()
    {
        Debug.Log($"Pierre cuisine pour guérir tous les Pokemons");
        foreach (Pokemon pokemon in sashaPokemons)
        {
            if (pokemon.isAlive)
            {
                if (pokemon.isAlive)
                {
                    HealPokemon(pokemon, 20);
                    Debug.Log($"Sacha : {pokemon.pokemonName} : PV = {pokemon.hp}");
                }
            }

        }
        foreach (Pokemon pokemon in ondinePokemons)
        {
            if (pokemon.isAlive)
            {
                HealPokemon(pokemon, 20);
                Debug.Log($"Ondine : {pokemon.pokemonName} : PV = {pokemon.hp}");
            }
        }
    }

    private void HealPokemon(Pokemon pokemon, int healAmount)
    {
        if (pokemon.hp < pokemon.maxhp - healAmount)
        {
            pokemon.hp += healAmount;
        }
        else
        {
            pokemon.hp = pokemon.maxhp;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cuisiner();
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SoinTotalSacha(sashaPokemons[0]);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SoinTotalSacha(sashaPokemons[1]);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SoinTotalOndine(ondinePokemons[0]);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SoinTotalOndine(ondinePokemons[1]);
        }
    }
}
