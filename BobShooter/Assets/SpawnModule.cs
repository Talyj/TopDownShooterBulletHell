using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnModule : ScriptableObject
{
    public Transform spawnPointHorizontalHaut;
    public Transform spawnPointVerticalGauche;
    public Transform spawnPoint3VerticalDroit;

    public GameObject farmerHaut;
    public GameObject farmerVertical;

    public void SpawnPointHorizontalHaut(Transform spawnPointHorizontalHaut)
    {
        this.spawnPointHorizontalHaut = spawnPointHorizontalHaut;
    }
    
    public void SpawnPointVerticalGauche(Transform spawnPointVerticalGauche)
    {
        this.spawnPointVerticalGauche = spawnPointVerticalGauche;
    }
    
    public void SpawnPoint3VerticalDroit(Transform spawnPoint3VerticalDroit)
    {
        this.spawnPoint3VerticalDroit = spawnPoint3VerticalDroit;
    }

    public void FarmerHaut(GameObject farmerHaut)
    {
        this.farmerHaut = farmerHaut;
    }
    
    public void FamerVertical(GameObject farmerVertical)
    {
        this.farmerVertical = farmerVertical;
    }

    public SpawnModule(Transform spawnPointHorizontalHaut, Transform spawnPointVerticalGauche,
        Transform spawnPoint3VerticalDroit, GameObject farmerHaut, GameObject farmerVertical)
    {
        this.spawnPointHorizontalHaut = spawnPointHorizontalHaut;
        this.spawnPointVerticalGauche = spawnPointVerticalGauche;
        this.spawnPoint3VerticalDroit = spawnPoint3VerticalDroit;
        this.farmerHaut = farmerHaut;
        this.farmerVertical = farmerVertical;
    }
}
