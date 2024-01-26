﻿using OrreryFrameworkDemo.Data.Scripts.OrreryFrameworkDemo.Communication.ProjectileBases;
using VRage.Utils;

namespace OrreryFrameworkDemo.Data.Scripts.OrreryFrameworkDemo.Communication
{
    partial class HeartDefinitions
    {
        ProjectileDefinitionBase ExampleProjectile2 => new ProjectileDefinitionBase()
        {
            Name = "TestProjectile2",
            Ungrouped = new Ungrouped()
            {
                ReloadPowerUsage = 0,
                Recoil = 0,
                Impulse = 0,
            },
            Damage = new Damage()
            {
                SlimBlockDamageMod = 1,
                FatBlockDamageMod = 1,
                BaseDamage = 1000,
                AreaDamage = 0,
                AreaRadius = 0,
                MaxImpacts = 1,
            },
            PhysicalProjectile = new PhysicalProjectile()
            {
                Velocity = 800,
                Acceleration = 0,
                Health = 1,
                MaxTrajectory = 4000,
                MaxLifetime = -1,
                IsHitscan = false,
            },
            Visual = new Visual()
            {
                //Model = "Models\\Weapons\\Projectile_Missile.mwm",
                TrailTexture = MyStringId.GetOrCompute("WeaponLaser"),
                TrailFadeTime = 0f,
                TrailLength = 8,
                TrailWidth = 0.5f,
                TrailColor = new VRageMath.Vector4(0, 0, 100, 200),
                //AttachedParticle = "Smoke_Missile",
                ImpactParticle = "MaterialHit_Metal",
                VisibleChance = 1f,
            },
            Audio = new Audio()
            {
                TravelSound = "",
                TravelVolume = 100,
                TravelMaxDistance = 1000,
                ImpactSound = "WepSmallWarheadExpl",
                SoundChance = 0.1f,
            },
            Guidance = new Guidance[]
            {
                //new Guidance()
                //{
                //    TriggerTime = 0,
                //    ActiveDuration = -1,
                //    UseAimPrediction = false,
                //    TurnRate = -1.5f,
                //    IFF = 2,
                //    DoRaycast = false,
                //    CastCone = 0.5f,
                //    CastDistance = 1000,
                //    Velocity = 50f,
                //},
                //new Guidance()
                //{
                //    TriggerTime = 1f,
                //    ActiveDuration = -1f,
                //    UseAimPrediction = false,
                //    TurnRate = 3.14f,
                //    IFF = 2,
                //    DoRaycast = false,
                //    CastCone = 0.5f,
                //    CastDistance = 1000,
                //    Velocity = -1f,
                //}
            },
            LiveMethods = new LiveMethods()
            {
                DoOnShoot = false,
                DoOnImpact = false,
                DoUpdate1 = false,
            }
        };
    }
}
