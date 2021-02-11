using System;
using GameStructure;

namespace GameMechanic
{
    public abstract class BattleResolverBase
    {
        protected Army Army1 { get; private set; }
        protected Army Army2 { get; private set; }

        protected BattleBonuses Bonuses1 { get; private set; }
        protected BattleBonuses Bonuses2 { get; private set; }

        public void InitialiseBattle(Army army1, Army army2, BattleBonuses army1_Bonuses, BattleBonuses army2_Bonuses) {
            this.Army1 = army1;
            this.Army2 = army2;
            this.Bonuses1 = army1_Bonuses;
            this.Bonuses2 = army2_Bonuses;
        }

        public void InitialiseBattle(Army army1, Army army2) {
            this.Army1 = army1;
            this.Army2 = army2;
        }

        public abstract void Reset();
        public abstract bool BattleOver { get; protected set; }

        public abstract void NextStage();

        public abstract UnitType CurrentStage { get; protected set; }

        public abstract void Retreat(bool army1, bool army2);
    }
}
