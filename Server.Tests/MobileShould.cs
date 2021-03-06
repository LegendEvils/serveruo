using System;
using System.Collections.Generic;
using Server.Network;
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
			
			// Description
			Assert.Null(sut.Name);
			Assert.Null(sut.NameMod);
			Assert.Null(sut.RawName);
			
			Assert.Null(sut.Title);
			Assert.Null(sut.TitleName);
			

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
			
			Assert.Null(sut.ResistanceMods);
			
			Assert.Equal(0, sut.MagicDamageAbsorb);
			Assert.Equal(0, sut.MeleeDamageAbsorb);
			
			Assert.Equal(new[] {0, 0, 0, 0, 0 }, sut.Resistances);
			

			// Body
			Assert.IsType<Body>(sut.Body);
			Assert.IsType<Body>(sut.RawBody);
			Assert.IsType<Body>(sut.BodyMod);
			Assert.Equal(0, sut.BodyValue);


			// Abilities
			Assert.False(sut.CanSwim);
			Assert.False(sut.CantWalk);
			Assert.True(sut.CanTarget);
			Assert.False(sut.CanHearGhosts);
			
			Assert.False(sut.CanRegenHits);
			Assert.False(sut.CanRegenMana);
			Assert.False(sut.CanRegenStam);
			

			// Stats
			Assert.Equal(1, sut.Str);
			Assert.Equal(1, sut.Dex);
			Assert.Equal(1, sut.Int);
			
			Assert.Equal(0, sut.Luck);
			Assert.Equal(0, sut.Fame);
			Assert.Equal(0, sut.Karma);
			
			Assert.Equal(0, sut.RawStr);
			Assert.Equal(0, sut.RawDex);
			Assert.Equal(0, sut.RawInt);
			
			Assert.Equal(0, sut.RawStatTotal);

			Assert.Equal(125, sut.StrCap);
			Assert.Equal(125, sut.DexCap);
			Assert.Equal(125, sut.IntCap);

			Assert.Equal(150, sut.StrMaxCap);
			Assert.Equal(150, sut.DexMaxCap);
			Assert.Equal(150, sut.IntMaxCap);

			Assert.IsType<StatLockType>(sut.StrLock);
			Assert.IsType<StatLockType>(sut.DexLock);
			Assert.IsType<StatLockType>(sut.IntLock);

			Assert.Equal(DateTime.MinValue, sut.LastStrGain);
			Assert.Equal(DateTime.MinValue, sut.LastDexGain);
			Assert.Equal(DateTime.MinValue, sut.LastIntGain);
			
			Assert.Equal(DateTime.MinValue, sut.LastStatGain);
			Assert.Equal(0, sut.Hits);
			Assert.Equal(50, sut.HitsMax);

			Assert.Equal(0, sut.TithingPoints);
			Assert.Equal(0, sut.Mana);
			Assert.Equal(1, sut.ManaMax);

			Assert.Equal(0, sut.Hunger);
			Assert.Equal(0, sut.Thirst);
			
			Assert.Equal(0, sut.VirtualArmor);
			Assert.Equal(0, sut.ArmorRating);
			
			Assert.Equal(0, sut.RacialSkillBonus);

			Assert.IsType<List<DamageEntry>>(sut.DamageEntries);
			Assert.Empty(sut.DamageEntries);

			Assert.Equal(0, sut.Kills);
			Assert.Equal(0, sut.Deaths);
			
			Assert.IsType<VirtueInfo>(sut.Virtues);

			// Equipment
			Assert.Null(sut.ArmsArmor);
			Assert.Null(sut.ChestArmor);
			Assert.Null(sut.HandArmor);
			Assert.Null(sut.HeadArmor);
			Assert.Null(sut.LegsArmor);
			Assert.Null(sut.NeckArmor);
			
			Assert.Null(sut.Bracelet);
			Assert.Null(sut.Ring);
			Assert.Null(sut.Talisman);
			
			Assert.Null(sut.Backpack);
			// get() calls BankBox constructor which has more dependencies which cannot be resolved at the moment.
			// Assert.Null(sut.BankBox);
			Assert.Null(sut.Holding);
			
			Assert.IsType<List<Item>>(sut.Items);
			
			Assert.Equal(0,sut.TotalGold);
			Assert.Equal(0,sut.TotalItems);
			
			Assert.Equal(0, sut.TotalWeight);
			Assert.Equal(Int32.MaxValue, sut.MaxWeight);
			
			Assert.Null(sut.Mount);

			
			// Characteristics
			Assert.False(sut.Player);
			Assert.Null(sut.Race);
			Assert.False(sut.Female);

			Assert.True(sut.Alive);
			Assert.False(sut.Blessed);
			Assert.False(sut.Deleted);
			Assert.False(sut.Flying);
			Assert.False(sut.Frozen);
			Assert.False(sut.GuardImmune);
			Assert.False(sut.Hidden);
			Assert.False(sut.IgnoreMobiles);
			Assert.False(sut.IsBodyMod);
			Assert.False(sut.IsDeadBondedPet);
			Assert.False(sut.IsStealthing);
			Assert.False(sut.KeepsItemsOnDeath);
			Assert.False(sut.Meditating);
			Assert.False(sut.Mounted);
			Assert.False(sut.Murderer);
			Assert.False(sut.Paralyzed);
			Assert.False(sut.Poisoned);
			Assert.False(sut.Pushing);
			Assert.True(sut.RegenThroughPoison);
			Assert.True(sut.RetainPackLocsOnDeath);
			Assert.False(sut.Warmode);

			Assert.True(sut.HasBlood);
			Assert.False(sut.HasTrade);

			Assert.Null(sut.Poison);
			Assert.Null(sut.PoisonTimer);


			// Location
			Assert.IsType<Region>(sut.Region);
			
			Assert.Null(sut.WalkRegion);
			Assert.IsType<Point3D>(sut.Location);
			
			Assert.Equal(0, sut.X);
			Assert.Equal(0, sut.Y);
			Assert.Equal(0, sut.Z);

			Assert.IsType<Map>(sut.Map);
			
			Assert.IsType<Direction>(sut.Direction);

			Assert.Null(sut.LogoutMap);
			Assert.IsType<Point3D>(sut.LogoutLocation);


			// Guild
			Assert.False(sut.DisplayGuildAbbr);
			Assert.False(sut.DisplayGuildTitle);
			Assert.Null(sut.Guild);
			Assert.Null(sut.GuildFealty);
			Assert.Null(sut.GuildTitle);
			
			Assert.Null(sut.Weapon);


			// Followers
			Assert.Equal(0, sut.Followers);
			Assert.Equal(5, sut.FollowersMax);

			Assert.Equal(0, sut.FaceItemID);
			
			Assert.Equal(0, sut.HairItemID);
			Assert.Equal(0, sut.FacialHairItemID);
			
			// Statistics
			Assert.Null(sut.LastKiller);
			Assert.Equal(DateTime.MinValue, sut.LastKilled);
			Assert.Equal(0, sut.LastMoveTime);


			// Interaction
			Assert.Null(sut.Target);
			Assert.False(sut.TargetLocked);

			Assert.IsType<List<AggressorInfo>>(sut.Aggressed);
			Assert.Empty(sut.Aggressed);

			Assert.IsType<List<AggressorInfo>>(sut.Aggressors);
			Assert.Empty(sut.Aggressors);
			
			Assert.Equal(0, sut.NextActionMessage);
			Assert.Equal(0, sut.NextActionTime);
			Assert.Equal(0, sut.NextActionTime);
			
			Assert.Equal(0, sut.NextCombatTime);
			Assert.NotNull(sut.NextSkillTime);
			Assert.Equal(0, sut.NextSpellTime);

			// Hues
			Assert.Equal(-1, sut.HueMod);
			
			Assert.Equal(0x2106, sut.HuedItemID);

			Assert.Equal(0, sut.DefaultBloodHue);

			Assert.Equal(0, sut.Hue);
			Assert.Equal(0, sut.BloodHue);
			Assert.Equal(0, sut.EmoteHue);
			Assert.Equal(0, sut.FaceHue);
			Assert.Equal(0, sut.FacialHairHue);
			Assert.Equal(0,sut.WhisperHue);
			Assert.Equal(0,sut.YellHue);

			Assert.Equal(-1, sut.NameHue);
			
			
			// Settings
			Assert.Equal(0, sut.BaseSoundID);
			Assert.False(sut.YellowHealthbar);
			Assert.Null(sut.Language);
			Assert.Equal(0, sut.LightLevel);
			Assert.IsType<DFAlgorithm>(sut.DFA);
			Assert.Null(sut.Prompt);
			
			
			// Unsorted
			Assert.Null(sut.Account);

			Assert.Equal(0, sut.BAC);
			
			Assert.Null(sut.NetState);
			
			Assert.False(sut.NoMoveHS);
			
			Assert.IsType<OPLInfo>(sut.OPLPacket);
			
			Assert.Null(sut.Party);
			
			Assert.Null(sut.Profile);
			
			Assert.False(sut.ProfileLocked);
			
			Assert.IsType<ObjectPropertyList>(sut.PropertyList);
			
			Assert.False(sut.PublicHouseContent);
			
			Assert.Null(sut.QuestArrow);

			Assert.IsType<RemoveMobile>(sut.RemovePacket);
			
		}
	}
}