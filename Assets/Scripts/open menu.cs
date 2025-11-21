using UnityEngine;

public class openmenu : MonoBehaviour
{
    public GameObject menu;
    public BasicPlayerMovement BPM;
    public bool open = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = !Cursor.visible;
            //Cursor.lockState = CursorLockMode.None;
            menu.SetActive(!open);
            open = !open;
        }
        else if (menu.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            BPM.speed = 0f;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            BPM.speed = 5f;
        }
    }
}
