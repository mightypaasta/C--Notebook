namespace GameCharacter.Decorators
{
    using GameCharacter.Base;
    using GameCharacter.Components;

    public class Enhancement : ICharacter
    {
        protected ICharacter _character;
        public Enhancement(ICharacter character){
            _character = character;
        }
        public int Health => _character.Health;

        public int Attack => _character.Attack;

        public int Defense => _character.Defense;

        public int Speed => _character.Speed;

        public string Name => _character.Name;

        public virtual void DisplayStats()
        {
            _character.DisplayStats();
        }

        // public int Health => throw new NotImplementedException();

        // public int Attack => throw new NotImplementedException();

        // public int Defense => throw new NotImplementedException();

        // public int Speed => throw new NotImplementedException();

        // public string Name => throw new NotImplementedException();

        // public int Defend()
        // {
        //     throw new NotImplementedException();
        // }

        // public int Dodge()
        // {
        //     throw new NotImplementedException();
        // }

        // public int PerformAttack()
        // {
        //     throw new NotImplementedException();
        // }

    }

    public class WithWeapon : Enhancement
    {
        private readonly string _weaponName;
        private readonly int _weaponDamage;
        public WithWeapon(ICharacter character, string weaponName,int  weaponDamage): base(character)
        {
            _weaponName = weaponName;
            _weaponDamage = weaponDamage;
        }
        public override void DisplayStats()
        {
            _character.DisplayStats();
            Console.WriteLine($"With weapon {_weaponName}");
            Console.WriteLine($"Total Attack is {_character.Attack+_weaponDamage}");
        }
    }
}