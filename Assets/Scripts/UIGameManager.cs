using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIGameManager : MonoBehaviour
{
    public InputSystem_Actions inputs;
    public WindowManager wmanager = new();

    private void Awake()
    {
        inputs = new();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.UI.Escape.performed += HideCurrentPanel;

        wmanager.OnElementAdded += OnElementAdded;
        wmanager.OnElementRemoved += OnElementRemoved;
    }


    void Start()
    {

    }
    void Update()
    {

    }
    private void OnElementAdded(Window window)
    {
        if(window.window != null)
        {
            window.window.SetActive(true);
            Debug.Log("Se abrio la ventana: " + window.window.name);
        }

    }
    private void OnElementRemoved(Window window)
    {
        if (window.window != null)
        {
            window.window.SetActive(false);
            Debug.Log("Se cerro la ventana: " + window.window.name);
        }
    }

    private void HideCurrentPanel(InputAction.CallbackContext context)
    {
        if (wmanager.Count == 0) return;

        Window window = wmanager.Pop();

        if (window.window != null)
        {
            Debug.Log("Cerrando la Pestaña: " + window.window.name);
        }
    }

    public void BtnOpenPanel(GameObject panel, ScriptableObject data)
    {
        Window window = new(panel);
        wmanager.Push(window);

        WindowView view = panel.GetComponent<WindowView>();

        if (view != null && data != null)
        {
            view.Setup(data);
        }
        else
        {
            Debug.Log("Panel sin WindowView");
        }

    }
    [Button]
    public void PeekFromStack()
    {
        Debug.Log(wmanager.Peek().window.name);
    }
    [Button]
    public void Count() => Debug.Log(wmanager.Count);

    public void BtnCloseCurrent()
    {
        if(wmanager.Count >  0)
        {
            wmanager.Pop();
        }
    }

    public void BtnCloseAll()
    {
        while (wmanager.Count > 0)
        {
            wmanager.Pop();
        }

        Debug.Log("Se cerraron todas la ventanas");
    }

}