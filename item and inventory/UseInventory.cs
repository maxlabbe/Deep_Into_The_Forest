using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseInventory : MonoBehaviour
{
    public Inventory inventory;
    public GameObject inventoryMenu;
    public GameObject mouseLook;
    public GameObject cantUseUI;
    public int cantUseUITime;
    private bool action;

    private GameObject m_selectedObject;
    // Start is called before the first frame update
    void Start()
    {
        inventoryMenu.SetActive(false);
        cantUseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            inventoryMenu.SetActive(true);
            mouseLook.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;

            if (Input.GetMouseButtonDown(0))
            {
                InventoryMenu script = inventoryMenu.GetComponent<InventoryMenu>();
                if (script != null)
                {
                    m_selectedObject = script.GetSelectedItem();
                }

                if (m_selectedObject != null)
                {
                    if (m_selectedObject.CompareTag("mushroom"))
                    {
                        action = inventory.UseMushroom();
                    }

                    if (m_selectedObject.CompareTag("water"))
                    {
                        action = inventory.UseWater();
                    }

                    if (m_selectedObject.CompareTag("woodStick"))
                    {
                        inventoryMenu.SetActive(false);
                        action = inventory.UseWood();
                    }

                    if (!action)
                    {
                        StartCoroutine(ActiveCantUseMessaage(cantUseUITime));
                    }
                }
            }
        }

        else
        {
            inventoryMenu.SetActive(false);
            mouseLook.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private IEnumerator ActiveCantUseMessaage(int time)
    {
        cantUseUI.SetActive(true);
        yield return new WaitForSecondsRealtime(time);
        cantUseUI.SetActive(false);
    }
}
