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
    private float spawnDelay = 3;
    private float spawnDelayRandom;

    private void Start()
    {
        spawnComponent = new SpawnModule(haut, gauche, droite, farmerHaut, farmerVertical);
        
        Modules = new List<ScriptableObject>();
        Modules.Add(spawnComponent);
        TAccessor<SpawnModule>.Instance().Add(spawnComponent);
    }

    private void Spawn(Transform position, GameObject farmer, int grpMonster)
    {
        for (int i = 0; i < grpMonster; i++)
        {
            Instantiate(farmer, position);
            _nbMonsters += 1;
        }
    }
    private void Update()
    {
        spawnDelayRandom = Random.Range(1, 4);
        spawnDelay -= Time.deltaTime;
        if (spawnDelay <= 0)
        {
            for (int i = 0; i < _grpMonsters; i++)
            {
                Spawn(haut ,farmerHaut, _grpMonsters);
                Spawn(gauche, farmerVertical, _grpMonsters);
                Spawn(droite, farmerVertical, _grpMonsters);
                
            }
            spawnDelay = spawnDelayRandom;
        }
    }
}
