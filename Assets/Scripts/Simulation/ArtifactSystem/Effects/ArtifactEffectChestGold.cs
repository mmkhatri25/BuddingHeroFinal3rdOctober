using System;

namespace Simulation.ArtifactSystem.Effects
{
	public class ArtifactEffectChestGold : ArtifactEffect
	{
		public override EffectOperation GetEffectOperation()
		{
			return EffectOperation.Increaser;
		}

		public override void Apply(UniversalTotalBonus universalTotalBonus, int copiesAmount)
		{
			universalTotalBonus.goldChestFactor += this.GetGoldIncrease(copiesAmount);
		}

		public override string GetDescription()
		{
			return LM.Get("ARTIFACT_EFFECT_GOLD_CHEST");
		}

		public override string GetValueString(int copiesAmount, UniversalTotalBonus universalTotalBonus)
		{
			return GameMath.GetPercentString(this.GetGoldIncrease(copiesAmount), false);
		}

		private double GetGoldIncrease(int copiesAmount)
		{
			return 0.3 * (double)copiesAmount;
		}

		private const double BASE_FACTOR = 0.3;
	}
}
