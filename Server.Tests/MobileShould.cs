using System.Collections.Generic;
using Server.Tests.Fixtures;
using Xunit;

namespace Server.Tests
{
	public class MobileShould : IClassFixture<LoadWorldFixture>
	{
		[Fact]
		public void HaveInitialState()
		{
			var sut = new Mobile();

			Assert.Null(sut.Account);

			Assert.IsType<List<AggressorInfo>>(sut.Aggressed);
			Assert.Empty(sut.Aggressed);

			Assert.IsType<List<AggressorInfo>>(sut.Aggressors);
			Assert.Empty(sut.Aggressors);

			Assert.True(sut.Alive);

			Assert.Equal(default, sut.BAC);

			Assert.Null(sut.Backpack);

			// get() calls BankBox constructor which has more dependencies which cannot be resolved at the moment.
			// Assert.Null(sut.BankBox);

			// Resistances
			Assert.Equal(0, sut.BaseColdResistance);
			Assert.Equal(0, sut.BaseEnergyResistance);
			Assert.Equal(0, sut.BaseFireResistance);
			Assert.Equal(0, sut.BasePhysicalResistance);
			Assert.Equal(0, sut.BasePoisonResistance);

			Assert.Equal(0, sut.ColdResistance);
			Assert.Equal(0, sut.EnergyResistance);
			Assert.Equal(0, sut.FireResistance);
			Assert.Equal(0, sut.PhysicalResistance);
			Assert.Equal(0, sut.PoisonResistance);

			Assert.Equal(0, sut.BaseSoundID);

			Assert.False(sut.Blessed);

			// Hues
			Assert.Equal(0, sut.DefaultBloodHue);

			Assert.Equal(0, sut.Hue);
			Assert.Equal(0, sut.BloodHue);
			Assert.Equal(0, sut.EmoteHue);
			Assert.Equal(0, sut.FaceHue);
			Assert.Equal(0, sut.FacialHairHue);

			Assert.IsType<Body>(sut.Body);

			Assert.IsType<Body>(sut.BodyMod);

			Assert.Equal(0, sut.BodyValue);

			Assert.Null(sut.Bracelet);

			Assert.False(sut.CanSwim);
			Assert.False(sut.CantWalk);

			Assert.True(sut.CanTarget);

			Assert.False(sut.CanHearGhosts);

			Assert.False(sut.CanRegenHits);
			Assert.False(sut.CanRegenMana);
			Assert.False(sut.CanRegenStam);

			Assert.IsType<List<DamageEntry>>(sut.DamageEntries);
			Assert.Empty(sut.DamageEntries);
			Assert.Equal(0, sut.Deaths);

			Assert.False(sut.Deleted);

			// Stats
			Assert.Equal(1, sut.Str);
			Assert.Equal(1, sut.Dex);
			Assert.Equal(1, sut.Int);

			Assert.Equal(125, sut.StrCap);
			Assert.Equal(125, sut.DexCap);
			Assert.Equal(125, sut.IntCap);

			Assert.Equal(150, sut.StrMaxCap);
			Assert.Equal(150, sut.DexMaxCap);
			Assert.Equal(150, sut.IntMaxCap);

			Assert.IsType<StatLockType>(sut.StrLock);
			Assert.IsType<StatLockType>(sut.DexLock);
			Assert.IsType<StatLockType>(sut.IntLock);

			Assert.IsType<Direction>(sut.Direction);

			Assert.IsType<DFAlgorithm>(sut.DFA);

			// Guild
			Assert.False(sut.DisplayGuildAbbr);
			Assert.False(sut.DisplayGuildTitle);
			Assert.Null(sut.Guild);
			Assert.Null(sut.GuildFealty);
			Assert.Null(sut.GuildTitle);

			Assert.Equal(0, sut.Fame);

			Assert.False(sut.Female);

			// Properties
			Assert.False(sut.Flying);
			Assert.False(sut.Frozen);
			Assert.False(sut.Hidden);

			// Followers
			Assert.Equal(0, sut.Followers);
			Assert.Equal(5, sut.FollowersMax);

			Assert.Equal(0, sut.FaceItemID);
			Assert.Equal(0, sut.FacialHairItemID);

			Assert.Equal(0, sut.Fame);
			Assert.Equal(0, sut.Karma);

			Assert.False(sut.GuardImmune);

			Assert.Equal(0, sut.Hits);

			Assert.Null(sut.Holding);

			Assert.Equal(0, sut.Hunger);

			Assert.Equal(0, sut.ArmorRating);

			// Equipped Armor
			Assert.Null(sut.ArmsArmor);
			Assert.Null(sut.ChestArmor);
			Assert.Null(sut.HandArmor);
			Assert.Null(sut.HeadArmor);
			Assert.Null(sut.LegsArmor);
			Assert.Null(sut.NeckArmor);

			Assert.True(sut.HasBlood);
			Assert.False(sut.HasTrade);
		}
	}
}