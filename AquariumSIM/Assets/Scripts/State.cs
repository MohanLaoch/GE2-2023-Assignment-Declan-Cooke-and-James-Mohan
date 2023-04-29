using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
   public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator Think()
    {
        yield break;
    }
    public virtual IEnumerator Exit()
    {
        yield break;
    }






}
