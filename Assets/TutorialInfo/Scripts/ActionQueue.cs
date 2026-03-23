using System.Collections.Generic;
using UnityEngine;

public class ActionQueue : MonoBehaviour
{
    private Queue<string> actions = new Queue<string>();

    void Start()
    {
        actions.Enqueue("Attack");
        actions.Enqueue("Move");
    }

    void Update()
    {
        if (actions.Count > 0)
        {
            Debug.Log(actions.Dequeue());
        }
    }
}