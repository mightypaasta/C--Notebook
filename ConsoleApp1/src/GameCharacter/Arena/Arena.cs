namespace GameCharacter.Arena
{
    using GameCharacter.Base;
    using GameCharacter.Components;

    public class Arena
    {
        private Character _character1 {get; set;}
        private Character _character2 {get; set;}

        public Arena(Character character1, Character character2){
            _character1 = character1;
            _character2 = character2;
        }

        public void StartFight()
        {
            int turn = 0;
            while(_character1.Health >0 && _character2.Health>0){
                if(turn==0){
                    Console.WriteLine($"{_character1.Name} attacks {_character2.Name}");
                    int damageDealt = _character1.DealDamage(_character2);
                    Console.WriteLine($"{_character1.Name} did {damageDealt} damage to {_character2.Name} {_character2.Health}");
                    if(damageDealt==0){
                        Console.WriteLine($"{_character2.Name} successfully defended against {_character1.Name}");
                    }
                    turn=1;
                }else{
                    Console.WriteLine($"{_character2.Name} attacks {_character1.Name}");
                    int damageDealt = _character2.DealDamage(_character1);
                    Console.WriteLine($"{_character2.Name} did {damageDealt} damage to {_character1.Name} {_character1.Health}");
                    if(damageDealt==0){
                        Console.WriteLine($"{_character1.Name} successfully defended against {_character2.Name}");
                    }
                    turn=0;
                }
                Thread.Sleep(1000);
                Console.WriteLine();
            }
            if(_character1.Health==0){
                Console.WriteLine($"{_character1.Name} was defeated by {_character2.Name}");
            }else{
                Console.WriteLine($"{_character2.Name} was defeated by {_character1.Name}");
            }
        }
    }
}