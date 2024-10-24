﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//sets up a scene and players avatars based on experiment definition
public class LevelManager
{
    public PlayerSystem _playerSystem;
    public ExperimentDefinition[] Experiments;
    [NonSerialized]
    public ExperimentDefinition ActiveExperiment;
    public bool Loading => _mainLoadOp != null && !_mainLoadOp.isDone;
    AsyncOperation _mainLoadOp;

    public LevelManager(PlayerSystem playerSys, ExperimentDefinition[] experiments)
    {
        _playerSystem = playerSys;
        Experiments = experiments;
    }

    bool _mainLoaded = false;
    bool _expLoaded = false;
    int _localPlayerIdx;
    List<int> _roles;


    public void LoadLevelWithLocalPlayer(int experiment, int localPlayerIdx, List<int> roles, NetworkingManager.Trail trail)
    {
        var expPrefab = Experiments[experiment];
        _mainLoadOp = SceneManager.LoadSceneAsync(expPrefab.Scene);
        _mainLoadOp.completed += (op) =>
        {
            ActiveExperiment = GameObject.Instantiate(expPrefab);
            for (int player = 0; player < roles.Count; player++)
            {
                var roleIdx = roles[player];
                if (roleIdx != -1)
                {
                    var role = ActiveExperiment.Roles[roleIdx];
                    var spawn = role.SpawnPoint;
                    if (localPlayerIdx == player)
                    {
                        Debug.Log($"Exp: {experiment}, RoleIdx: {roleIdx}, role: {role.Name}");
                        _playerSystem.SpawnLocalPlayer(spawn, player, role);
                    }
                    else
                    {
                        _playerSystem.SpawnRemotePlayer(spawn, player, role);
                    }
                }
            }
            foreach(IExperimentModifier em in ActiveExperiment.GetComponentsInChildren(typeof(IExperimentModifier)))
            {
                em.SetParameter(trail.experimentParameters);
            }
            _mainLoadOp = null;
        };
    }

    public void LoadLevelNoLocalPlayer(int experiment, List<int> playerStartingPositions, NetworkingManager.Trail trail)
    {
        LoadLevelWithLocalPlayer(experiment, 0, playerStartingPositions, trail);
    }

    internal string GetFilename(NetworkingManager.Trail currentTrail, int currentTrailIndex)
    {
        string result = currentTrailIndex + "_" + Experiments[currentTrail.experimentIndex].ShortName + "_roleIdx-" + currentTrail.roleIndex;
        foreach(var param in currentTrail.experimentParameters)
        {
            result += ("_" + param.name + "-" + param.value);
        }
        return result + DateTime.Now.ToString("_yy-MM-dd_hh-mm");
    }
}
