using UnityEngine;

public class Salameche : Pokemon
{
    private PokemonChange pokemonChange;
    public int damage;
    public Salameche() : base("Salamèche", 100, 60, 40, 60, "Feu") { }

    public override void AttackSpePokemon(Pokemon _target)
    {
        if (isAlive || _target.IsAlive)
        {
            int _damage = attack;
            Debug.Log($"{pokemonName} utilise l'attaque Flammèche");
            switch (_target.Type)
            {
                case "Feu":
                    _damage = (int)(attack * 0.5f);
                    break;
                case "Eau":
                    _damage = (int)(attack * 2f);
                    break;
                case "Plante":
                    _damage = (int)(attack * 0.5f);
                    break;
                default :
                    _damage = (int)(attack * 1f);
                    break;
            }
            Debug.Log($"{_target.PokemonName} perd {_damage} PV");
            _target.TakeDamage(_damage);
        }
    }

    public override void Charge(Pokemon _target)
    {
        if (isAlive || _target.IsAlive)
        {
            int _damage = attack;
            Debug.Log($"{pokemonName} utilise l'attaque Charge");
            switch (_target.Type)
            {
                case "Roche":
                    _damage = (int)(attack * 0.1f);
                    break;
                case "Acier":
                    _damage = (int)(attack * 0.1f);
                    break;
                case "Spectre":
                    _damage = 0;
                    break;
                default:
                    _damage = (int)(attack * 0.2f);
                    break;
            }
            Debug.Log($"{_target.PokemonName} perd {_damage} PV");
            _target.TakeDamage(_damage);
        }
    }

    public override void TakeDamage(int _damage)
    {
        hp -= _damage;
        if (hp <= 0)
        {
            isAlive = false;
            Death();
        }
        else
        {
            Debug.Log($"{pokemonName} : PV = {hp}");
        }
    }

    public override void Death()
    {
        PokemonChange changepokemon = FindObjectOfType<PokemonChange>();
        pokemonChange = changepokemon;
        Debug.Log($"{pokemonName} est K.O");
        pokemonChange.ChangePokemon();
    }
}
