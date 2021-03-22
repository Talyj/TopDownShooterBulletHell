
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
    }

    void Start()
    {
        Up.Add(new MoveSys());
    }

    void Update()
    {
        foreach (var upi in Up)
        {
            upi.SystemUpdate();
        }
    }
}
