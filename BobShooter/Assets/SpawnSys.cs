using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class SpawnSys : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<SpawnModule> myModuleAccessor = TAccessor<SpawnModule>.Instance();
        foreach (var module in myModuleAccessor.DisplayListT())
        {
            
        }
    }
}
