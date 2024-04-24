using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IObserver
{
    protected Subject subject;
    public abstract void ThongBao(Subject subject, object arg);
}
