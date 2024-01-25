using UnityEngine;
using UnityEngine.SceneManagement;

public class PokemonChange : MonoBehaviour
{
    private GetPokemon getPokemonScript;
    private Pokemon[] sashaPokemons;
    private Pokemon[] ondinePokemons;
    private int sachaPokemonIndex = 0;
    private int ondinePokemonIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        getPokemonScript = FindObjectOfType<GetPokemon>();
        sashaPokemons = getPokemonScript.SashaPokemons;
        ondinePokemons = getPokemonScript.OndinePokemons;
    }

    public void ChangePokemon()
    {
        if (!sashaPokemons[0].isAlive && sachaPokemonIndex < 1)
        {
            sashaPokemons[0] = sashaPokemons[1];
            sachaPokemonIndex++;
            getPokemonScript.SachaChange();
        }
        else if (!ondinePokemons[0].isAlive && ondinePokemonIndex < 1)
        {
            ondinePokemons[0] = ondinePokemons[1];
            ondinePokemonIndex++;
            getPokemonScript.OndineChange();
        }
        else
        {
            BattleEnd();
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
        SceneManager.LoadScene("StartDuel");
    }
}
