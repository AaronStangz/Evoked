using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Mats")]
    public int wood;
    public int scrap;
    public int goldBar;

    [Header("Story Items")]
    public int files;

    [Header("ammo")]
    public int arAmmo;
    public int smgAmmo;
    public int shotgunAmmo;

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
    public int eclipseEnforcerLevel;
    public int phantomWhisperLevel;
    public int cobaltSentinelLevel;
    public int zenithDefenderLevel;
    public int emberGuardianLevel;
    public int nebulaHavocLevel;


    [Header("Gun Part sNeeded")]
    public int eclipseEnforcerPartsNeeded;
    public int phantomWhisperPartsNeeded;
    public int cobaltSentinelPartsNeeded;
    public int zenithDefenderPartsNeeded;
    public int emberGuardianPartsNeeded;
    public int nebulaHavocPartsNeeded;
}
