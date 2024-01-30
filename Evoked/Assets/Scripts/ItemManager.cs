using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Mats")]
    public int wood;
    public int scrap;
    public int upgradePoints;
    public int goldBar;

    [Header("Mats")]
    public int MaxWood;
    public int MaxScrap;

    [Header("Story Items")]
    public int files;

    [Header("ammo")]
    public int MediumBullets;
    public int LightBullets;
    public int Shells;
    public int HeavyBullets;
    public int Rockets;

    [Header("MaxAmmo")]
    public int MaxMediumBullets;
    public int MaxLightBullets;
    public int MaxShells;
    public int MaxHeavyBullets;
    public int MaxRockets;

    [Header("Gun Blue Prints")]
    public int eclipseEnforcerBluePrints;
    public int phantomWhisperBluePrints;
    public int cobaltSentinelBluePrints;
    public int zenithDefenderBluePrints;
    public int emberGuardianBluePrints;
    public int nebulaHavocBluePrints;

    [Header("Gun Parts")]
    public int eclipseEnforcerParts;
    public int phantomWhisperParts;
    public int cobaltSentinelParts;
    public int zenithDefenderParts;
    public int emberGuardianParts;
    public int nebulaHavocParts;

    [Header("Gun Levels / xp;")]
    public int xp;
    public int gunXp;
    public int heroXp;
    [Space]
    public int eclipseEnforcerLevel;
    public int phantomWhisperLevel;
    public int cobaltSentinelLevel;
    public int zenithDefenderLevel;
    public int emberGuardianLevel;
    public int nebulaHavocLevel;
    [Space]
    public int eclipseEnforcerGunXP;
    public int phantomWhisperGunXP;
    public int cobaltSentinelGunXP;
    public int zenithDefenderGunXP;
    public int emberGuardianGunXP;
    public int nebulaHavocGunXP;


    [Header("Gun Part sNeeded")]
    public int eclipseEnforcerPartsNeeded;
    public int phantomWhisperPartsNeeded;
    public int cobaltSentinelPartsNeeded;
    public int zenithDefenderPartsNeeded;
    public int emberGuardianPartsNeeded;
    public int nebulaHavocPartsNeeded;
}
