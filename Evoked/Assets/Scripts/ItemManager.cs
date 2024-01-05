using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Level")]
    public int xp;

    [Header("Mats")]
    public int wood;
    public int scrap;
    public int goldBar;

    [Header("StoryItems")]
    public int files;

    [Header("ammo")]
    public int arAmmo;
    public int smgAmmo;
    public int shotgunAmmo;

    [Header("GunParts")]
    public int eclipseEnforcerParts;
    public int phantomWhisperParts;
    public int cobaltSentinelParts;
    public int zenithDefenderParts;
    public int emberGuardianParts;
    public int nebulaHavocParts;

    [Header("GunPartsNeeded")]
    public int eclipseEnforcerPartsNeeded;
    public int phantomWhisperPartsNeeded;
    public int cobaltSentinelPartsNeeded;
    public int zenithDefenderPartsNeeded;
    public int emberGuardianPartsNeeded;
    public int nebulaHavocPartsNeeded;
}
