using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MyStack<string> namestack = new();

    void Start()
    {
        
    }

    [Button]
    public void PushToStack(string value)
    {
        namestack.Push(value);
    }

    [Button]
    public void PopToStack()
    {
        Debug.Log(namestack.Pop());
    }

    [Button]
    public void PeekFromStack()
    {
        Debug.Log(namestack.Peek());
    }

    public void ClearStack()
    {
        namestack.Clear();
    }

    public void count() => Debug.Log(namestack.Count);

    // Update is called once per frame
    void Update()
    {
        
    }
}
