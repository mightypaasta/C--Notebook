using GameCharacter.Components;

namespace GameCharacter.Base
{
    public interface ICharacter
    {
        int Health {get;}
        int Attack {get;}
        int Defense {get;}
        int Speed {get;}
        string Name {get;}
        void DisplayStats();
        int DealDamage(Character character);
    }
}