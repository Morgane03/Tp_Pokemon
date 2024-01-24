using UnityEngine;

public abstract class Pokemon : MonoBehaviour
{
    public string pokemonName;
    public int hp;
    public int maxhp;
    protected int attack;
    protected int defense;
    protected int speed;
    protected string type;
    protected bool isInPokeball;
    public bool isAlive = true;

    public string PokemonName { get { return pokemonName; } }
    public int HP { get { return hp; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int Speed { get { return speed; } }
    public string Type { get { return type; } }
    public bool IsInPokeball { get { return isInPokeball; } }
    public bool IsAlive { get { return isAlive; } }

    public Pokemon(string _name, int _hp, int _attack, int _defense, int _speed, string _type)
    {
        this.pokemonName = _name;
        this.hp = _hp;
        this.attack = _attack;
        this.defense = _defense;
        this.speed = _speed;
        this.type = _type;
        maxhp = _hp;
    }

    public abstract void AttackSpePokemon(Pokemon _target);
    public abstract void Charge(Pokemon _target);
    public abstract void TakeDamage(int _damage);
    public abstract void Death();
}
