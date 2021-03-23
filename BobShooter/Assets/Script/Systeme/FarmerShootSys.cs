using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerShootSys : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<ShootFarmerModule> myModuleAccessor = TAccessor<ShootFarmerModule>.Instance();
        foreach (var module in myModuleAccessor.DisplayListT())
        {
           
        }
    }
}
