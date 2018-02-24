using System;
using UnityEngine;

[Serializable]
public class Variable : ScriptableObject
{

}

[Serializable]
public class Variable<T> : Variable
{
    public T DefaultValue;

    private T currentValue;

    public T Value
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    public static implicit operator T(Variable<T> variable)
    {
        return variable.currentValue;
    }

    private void OnEnable()
    {
        currentValue = DefaultValue;
    }

    public void Reset()
    {
        currentValue = DefaultValue;
    }
}
