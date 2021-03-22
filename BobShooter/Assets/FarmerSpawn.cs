using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerSpawn : MonoBehaviour
{
    List<ScriptableObject> Modules;
    public SpawnModule spawnComponent;

    public Transform haut;
    public Transform gauche;
    public Transform droite;

    public GameObject farmerHaut;
    public GameObject farmerVertical;

    private int _nbMonsters = 0;
    private int _grpMonsters = 3;

    private void Start()
    {
        spawnComponent = new SpawnModule(haut, gauche, droite, farmerHaut, farmerVertical);
        
        Modules = new List<ScriptableObject>();
        Modules.Add(spawnComponent);
        TAccessor<SpawnModule>.Instance().Add(spawnComponent);
    }

    private void Spawn(Transform position, GameObject farmer)
    {
        Instantiate(farmer, position);
        _nbMonsters += 1;

    }
    private void Update()
    {
        if (_nbMonsters < 9)
        {
            for (int i = 0; i < _grpMonsters; i++)
            {
                Spawn(haut ,farmerHaut);
            }
            
            for (int i = 0; i < _grpMonsters; i++)
            {
                Spawn(gauche, farmerVertical);
            }
            
            for (int i = 0; i < _grpMonsters; i++)
            {
                Spawn(droite, farmerVertical);
            }
        }
    }
}
