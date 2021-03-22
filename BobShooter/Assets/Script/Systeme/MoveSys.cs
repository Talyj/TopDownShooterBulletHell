using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSys : IUpdater
{
    public void SystemUpdate()
    {
         TAccessor<MoveModule> myModuleAccessor = TAccessor<MoveModule>.Instance();
         foreach (var module in myModuleAccessor.DisplayListT())
         {
             module.playerTransform.position += new Vector3(module.speedX, module.speedY) * Time.deltaTime;
         }
    }
    
}
