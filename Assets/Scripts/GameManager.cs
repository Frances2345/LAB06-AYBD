using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MyStack<string> namestack = new();

    public void PushToStack(string value)
    {
        namestack.Push(value);
    }

    public void PopToStack()
    {
        Debug.Log(namestack.Pop());
    }

    public void PeekFromStack()
    {
        Debug.Log(namestack.Peek());
    }

    public void ClearStack()
    {
        namestack.Clear();
    }

    public void count() => Debug.Log(namestack.Count);
}
