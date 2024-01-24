using UnityEngine;

public class Pikatchu : Pokemon
{
    public Pikatchu() : base("Pikachu", 80, 80, 60, 40, "Electrik") { }

    public override void Charge(Pokemon _pokemonEnnemy)
    {
        if (isAlive)
        {
            int _damage = (int)(attack * 0.2f);

            switch (_pokemonEnnemy.Type)
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
            }

            Debug.Log($"{pokemonName} utilise Charge");
            Debug.Log($"{_pokemonEnnemy.pokemonName} perd {_damage} PV");
            _pokemonEnnemy.TakeDamage(_damage);
        }
    }
    public override void AttackSpePokemon(Pokemon _pokemonEnnemy)
    {
        if (isAlive)
        {
            int _damage = (int)(attack * 0.9f);

            switch (_pokemonEnnemy.Type)
            {
                case "Electrik":
                    _damage = (int)(attack * 0.45f);
                    break;
                case "Plante":
                    _damage = (int)(attack * 0.45f);
                    break;
                case "Sol":
                    _damage = 0;
                    break;
                case "Eau":
                    _damage = (int)(attack * 1.8f);
                    break;
                default:
                    _damage = attack;
                    break;
            }

            Debug.Log($"{pokemonName} utilise Eclair");
            Debug.Log($"{_pokemonEnnemy.pokemonName} perd {_damage} PV");
            _pokemonEnnemy.TakeDamage(_damage);
        }
    }

    public override void TakeDamage(int _damage)
    {
        hp = hp - _damage;

        if (hp <= 0)
        {
            Debug.Log($"{pokemonName} PV : 0");
            Death();
        }
        else
        {
            Debug.Log($"{pokemonName} PV : {hp}");
        }
    }
    public override void Death()
    {
        Debug.Log($"{pokemonName} est K.O");
        isAlive = false;
    }
}
