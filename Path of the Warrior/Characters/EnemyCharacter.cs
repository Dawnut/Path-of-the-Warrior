namespace DungeonProject
{ 
    class EnemyCharacter : BaseCharacter
    {
        /// <summary>
        /// Enemy character.
        /// </summary>
        public EnemyType Enemy { get; set; }

        public EnemyCharacter(EnemyType enemy, string name, int hp, int dmg)
        {
            this.Enemy = enemy;
            base.CharName = name;
            base.HP = hp;
            base.DMG = dmg;
        }
    }
}
