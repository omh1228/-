using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private Stack<string> states = new Stack<string>();

    public void PushState(string state)
    {
        states.Push(state);
    }

    public void PopState()
    {
        if (states.Count > 0)
            states.Pop();
    }
}