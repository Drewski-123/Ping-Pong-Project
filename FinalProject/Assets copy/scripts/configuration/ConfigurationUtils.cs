﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving for easy difficulty
    /// </summary>
    public static float EasyBallImpulseForce
    {
        get { return configurationData.EasyBallImpulseForce; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving for medium difficulty
    /// </summary>
    public static float MediumBallImpulseForce
    {
        get { return configurationData.MediumBallImpulseForce; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving for hard difficulty
    /// </summary>
    public static float HardBallImpulseForce
    {
        get { return configurationData.HardBallImpulseForce; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// for easy difficulty
    /// </summary>
    public static float EasyMinSpawnDelay
    {
        get { return configurationData.EasyMinSpawnDelay; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// for easy difficulty
    /// </summary>
    public static float EasyMaxSpawnDelay
    {
        get { return configurationData.EasyMaxSpawnDelay; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// for medium difficulty
    /// </summary>
    public static float MediumMinSpawnDelay
    {
        get { return configurationData.MediumMinSpawnDelay; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// for medium difficulty
    /// </summary>
    public static float MediumMaxSpawnDelay
    {
        get { return configurationData.MediumMaxSpawnDelay; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// for hard difficulty
    /// </summary>
    public static float HardMinSpawnDelay
    {
        get { return configurationData.HardMinSpawnDelay; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// for hard difficulty
    /// </summary>
    public static float HardMaxSpawnDelay
    {
        get { return configurationData.MediumMaxSpawnDelay; }
    }

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets how many seconds a ball stays alive
    /// </summary>
    public static float BallLifeSeconds
    {
        get { return configurationData.BallLifeSeconds; }
    }

    /// <summary>
    /// Gets the number of points a standard ball is worth
    /// </summary>
    public static int StandardPoints
    {
        get { return configurationData.StandardPoints; }
    }

    /// <summary>
    /// Gets the number of hits a standard ball is worth
    /// </summary>
    public static int StandardHits
    {
        get { return configurationData.StandardHits; }
    }

    /// <summary>
    /// Gets the number of points a bonus ball is worth
    /// </summary>
    public static int BonusPoints
    {
        get { return configurationData.BonusPoints; }
    }

    /// <summary>
    /// Gets the number of hits a bonus ball is worth
    /// </summary>
    public static int BonusHits
    {
        get { return configurationData.BonusHits; }
    }

    /// <summary>
    /// Gets the number of seconds the freezer effect lasts
    /// </summary>
    public static float FreezerSeconds
    {
        get { return configurationData.FreezerSeconds; }
    }

    /// <summary>
    /// Gets the number of seconds the speedup effect lasts
    /// </summary>
    public static float SpeedupSeconds
    {
        get { return configurationData.SpeedupSeconds; }
    }

    /// <summary>
    /// Gets the speedup multiplier
    /// </summary>
    public static float SpeedupFactor
    {
        get { return configurationData.SpeedupFactor; }
    }

    /// <summary>
    /// Gets the probability of spawning a standard ball
    /// </summary>
    public static float StandardBallSpawnProbability
    {
        get { return configurationData.StandardBallSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a bonus ball
    /// </summary>
    public static float BonusBallSpawnProbability
    {
        get { return configurationData.BonusBallSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a freezer pickup
    /// </summary>
    public static float FreezerPickupSpawnProbability
    {
        get { return configurationData.FreezerPickupSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a speedup pickup
    /// </summary>
    public static float SpeedupPickupSpawnProbability
    {
        get { return configurationData.SpeedupPickupSpawnProbability; }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
