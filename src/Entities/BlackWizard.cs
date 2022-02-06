namespace Jogo_POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;  
        }
        public override string Attack(){
            return this.Name + " Lançou magia negra";
        }

        public string Attack(int Bonus){
            
            if(Bonus > 6)
                return this.Name + " Lançou magia negra super efetiva com bonus de " + Bonus;
            else 
                return this.Name + " Lançou magia negra com força fraca com bonus de " + Bonus;
        }
    }
}