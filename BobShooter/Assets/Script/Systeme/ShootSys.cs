using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSys : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<ShootModule> myModuleAccessor = TAccessor<ShootModule>.Instance();
        foreach (var module in myModuleAccessor.DisplayListT())
        {
           
        }
    }
}
