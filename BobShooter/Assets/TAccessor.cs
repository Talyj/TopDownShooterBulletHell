using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAccessor<T>
{
    List<T> ListT;

    public static TAccessor<T> Instance()
    {
        return Singleton;
    }

    private static TAccessor<T> Singleton;

    public TAccessor()
    {
        Singleton = this;
        ListT = new List<T>();
    }
    
    public void Add(T parametres)
    {
        ListT.Add(parametres);
    }

    public List<T> DisplayListT()
    {
        return ListT;
    }

}
