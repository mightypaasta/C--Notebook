using System.ComponentModel.DataAnnotations;
using GameCharacter.Base;
using Microsoft.VisualBasic;

namespace GameCharacter.Components{

    public abstract class Character: ICharacter
    {
        public int Health {get; protected set;}
        public int Attack {get; protected set;}
        public int Defense {get; protected set;}
        public int Speed {get; protected set;}
        public string Name {get; protected set;} = "";
        public virtual void DisplayStats(){
            Console.WriteLine($"Stats for the {GetType().Name} : Health = {Health}, Attack = {Attack}, Defense={Defense}");
        }
        // public virtual void TakeDamage(int Damage){
        //     Health = Math.Min(0,Health-Damage);
        // }
        
        public virtual int DealDamage(Character character){
            int defenseRoll = Utils.random.Next(character.Defense);
            Console.WriteLine($"Defense Roll {defenseRoll}");
            int finalDamageAmt = Math.Max(0,character.Attack-defenseRoll);
            character.Health = Math.Max(0, character.Health-finalDamageAmt);
            return finalDamageAmt;
        }
        // public virtual void Defend(){
        //     this.Defense
        // }
        // public virtual 
    }

    public class Warrior : Character
    {
        public Warrior(string name)
        {   
            Health = 1500;
            Attack = 50;
            Defense = 50;
            Speed = 20;
            Name = name;
        }
    }

    public class Mage : Character {

        public Mage(string name)
        {
            Health = 1200;
            Attack = 80;
            Defense = 20;
            Speed = 30;
            Name = name;
        }

    }

    public class Archer : Character {

        public Archer(string name)
        {
            Health = 1000;
            Attack = 50;
            Defense = 30;
            Speed = 50;
            Name = name;
        }

    }
}