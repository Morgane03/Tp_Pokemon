using UnityEngine;
using UnityEngine.SceneManagement;

public class PokemonChange : MonoBehaviour
{
    private GetPokemon getPokemonScript;
    private Pokemon[] sashaPokemons;
    private Pokemon[] ondinePokemons;

    // Start is called before the first frame update
    void Start()
    {
        getPokemonScript = FindObjectOfType<GetPokemon>();
        sashaPokemons = getPokemonScript.SashaPokemons;
        ondinePokemons = getPokemonScript.OndinePokemons;
    }

    public void ChangePokemon()
    {
        if (!sashaPokemons[0].isAlive)
        {
            sashaPokemons[0] = sashaPokemons[1];
            getPokemonScript.SachaChange();
        }
        else if (!ondinePokemons[0].isAlive)
        {
            ondinePokemons[0] = ondinePokemons[1];
            getPokemonScript.OndineChange();
        }
    }

    public void BattleEnd()
    {
        Debug.Log("Fin du combat");
        if (sashaPokemons[0].isAlive)
        {
            Debug.Log("Sasha a gagné");
        }
        else
        {
            Debug.Log("Ondine a gagné");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
