using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartDuel()
    {
        SceneManager.LoadScene("DuelPokemon");
    }
}
