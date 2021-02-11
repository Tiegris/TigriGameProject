using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStructure;
using TiegrisUtil.Math;

namespace GameMechanic
{

    public class ClassicBattleResolver : BattleResolverBase
    {
        public override bool BattleOver { get; protected set; }
        public override UnitType CurrentStage { get; protected set; }

        public override void Reset() {
            CurrentStage = UnitType.Support;
            BattleOver = false;
        }

        public override void NextStage() {
            int def1 = Army1.Battalions[counterUnit(CurrentStage)];
            int def2 = Army2.Battalions[counterUnit(CurrentStage)];
            int att1 = Army1.Battalions[CurrentStage];
            int att2 = Army1.Battalions[CurrentStage];

            double dmgProb1 = att1 == 0 ? 0 : att1 / (att1 + def2);
            double dmgProb2 = att2 == 0 ? 0 : att2 / (att2 + def1);

            double critProb1 = att1 == 0 ? 0 : att1 / (att1 + def2 * 2);
            double critProb2 = att2 == 0 ? 0 : att2 / (att2 + def1 * 2);

            double ran1 = Game.Random.ContinuousDouble();
            double ran2 = Game.Random.ContinuousDouble();

            int dmg1 = 0;
            int dmg2 = 0;

            if (ran1 < critProb1)
                dmg1 = 2;
            else if (ran1 < dmgProb1)
                dmg1 = 1;

            if (ran2 < critProb2)
                dmg2 = 2;
            else if (ran2 < dmgProb2)
                dmg2 = 1;

            Army1.RemoveRandom(dmg1);
            Army2.RemoveRandom(dmg2);

            nextStage();
        }

        private void applyBonuses(ref int def1, ref int def2, ref int att1, ref int att2) {
            //deffender bonus
            if (Bonuses1.Deffender) def1++;
            if (Bonuses2.Deffender) def2++;

            //combined arms bonus
            if (Army1.Battalions[UnitType.Cavalry] > 0 &&
                Army1.Battalions[UnitType.Halberdier] > 0 &&
                Army1.Battalions[UnitType.Support] > 0) att1++;
            if (Army2.Battalions[UnitType.Cavalry] > 0 &&
                Army2.Battalions[UnitType.Halberdier] > 0 &&
                Army2.Battalions[UnitType.Support] > 0) att2++;
        }

        public override void Retreat(bool army1, bool army2) {
            if (army1 && army2) {
                BattleOver = true;
                return;
            }
            if (!army1 && !army2) {
                return;
            }
            if (army1 && !army2) {
                retreat(Army1, Army2);
                BattleOver = true;
                return;
            }
            if (!army1 && army2) {
                retreat(Army2, Army1);
                BattleOver = true;
                return;
            }
        }

        private void retreat(Army retreating, Army chasing) {
            int chasingCav = chasing.Battalions[UnitType.Cavalry] -
                retreating.Battalions[UnitType.Halberdier];
            if (chasingCav > 0)
                retreating.Battalions[UnitType.Support] -= chasingCav;

        }

        private UnitType counterUnit(UnitType type) {
            return type switch {
                UnitType.Support => UnitType.Cavalry,
                UnitType.Cavalry => UnitType.Halberdier,
                UnitType.Halberdier => UnitType.Support,
                _ => throw new Exception()
            };
        }

        private void nextStage() {
            CurrentStage = counterUnit(CurrentStage);
        }

    }
}
