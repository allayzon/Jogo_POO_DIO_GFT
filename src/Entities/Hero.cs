namespace Jogo_POO.src.Entities
{
    public abstract class Hero
    {
        
        public Hero()
        {
            
        }

        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;  
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return "Name: " + this.Name + "\nLevel: " + Level + "\nHeroType: " + HeroType + "\nHP: " + HP + "\nMP: " + MP;
        }

        public virtual string Attack(){
            return this.Name + " atacou com sua espada";
        }
    }
}