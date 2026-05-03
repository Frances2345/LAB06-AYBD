using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIGameManager : MonoBehaviour
{
    public GameObject panelStats;
    public GameObject panelInventory;
    public GameObject panelMissions;
    public GameObject panelMap;

    public ScriptableObject statsData;
    public ScriptableObject inventoryData;
    public ScriptableObject missionsData;

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

    public void OpenStats()
    {
        BtnOpenPanel(panelStats, statsData);
    }

    public void OpenInventory()
    {
        BtnOpenPanel(panelInventory, inventoryData);
    }

    public void OpenMap()
    {
        BtnOpenPanel(panelMap, null);
    }

    public void OpenMissions()
    {
        BtnOpenPanel(panelMissions, missionsData);
    }

    public void BtnOpenPanel(GameObject panel, ScriptableObject data)
    {
        if (panel == null) return;

        //panel.transform.SetAsLastSibling();

        if (panel.transform.parent != null)
        {
            panel.transform.parent.SetAsLastSibling();
        }
        else
        {
            panel.transform.SetAsLastSibling();
        }

        Window window = new(panel);
        wmanager.Push(window);

        WindowView view = panel.GetComponent<WindowView>();

        if (view != null && data != null)
        {
            view.Setup(data);
        }

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
        BtnCloseCurrent();
    }

    public void PeekFromStack()
    {
        if (wmanager.Count > 0) Debug.Log(wmanager.Peek().window.name);
    }

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