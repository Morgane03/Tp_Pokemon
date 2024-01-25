using UnityEngine;

public class Bulbizarre : Pokemon
{
    private PokemonChange pokemonChange;
    public Bulbizarre() : base("Bulbizarre", 120, 40, 60, 30, "Plante") { }

    public override void AttackSpePokemon(Pokemon _target)
    {
        if (IsAlive || _target.IsAlive)
        {
            Debug.Log($"{pokemonName} utilise soin");
            hp += 30;
            if (hp > maxhp)
            {
                hp = maxhp;
            }
            Debug.Log($"{this.PokemonName} se soigne");
            Debug.Log($"{pokemonName} : PV = {hp}");
        }
    }

    public override void Charge(Pokemon _target)
    {
        if (isAlive || _target.IsAlive)
        {
            int _damage = attack;
            int _res = _target.Defense;
            Debug.Log($"{pokemonName} utilise l'attaque Charge");
            switch (_target.Type)
            {
                case "Roche":
                    _damage = (int)(attack * 0.1f * (1 / 3 * _res));
                    break;
                case "Acier":
                    _damage = (int)(attack * 0.1f * (1 / 3 * _res));
                    break;
                case "Spectre":
                    _damage = 0;
                    break;
                default:
                    _damage = (int)(attack * 0.2f * (1 / 3 * _res));
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
