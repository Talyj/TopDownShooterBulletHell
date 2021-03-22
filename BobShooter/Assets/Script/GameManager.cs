
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    private static GameManager Instance()
    {
        return Singleton;
    }

    private List<IUpdater> Up = new List<IUpdater>();

    private void Awake()
    {
        Singleton = this;
        new TAccessor<MoveModule>();
        new TAccessor<SpawnModule>();
    }

    void Start()
    {
        Up.Add(new MoveSys());
        Up.Add(new SpawnSys());
    }

    void Update()
    {
        foreach (var upi in Up)
        {
            upi.SystemUpdate();
        }
    }
}
