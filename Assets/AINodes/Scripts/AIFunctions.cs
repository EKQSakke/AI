using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFunctions : MonoBehaviour, IAIFunctions
{
    public void Log(string input)
    {
        Debug.Log("Functions Log:" + input);
    }
}

public interface IAIFunctions {
    public void Log(string input);
}
