using UnityEngine;
using TMPro;

public class BuyMenu : MonoBehaviour
{
    public GameObject canvas;
    public GameObject[] turretPrefabs;
    private int turretLevel = 0;
    public TextMeshProUGUI buttonText;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (canvas.activeSelf)
            {
                canvas.SetActive(false);
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                canvas.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void BuyTurret()
    {
        for (int i = 0; i < turretPrefabs.Length; i++)
        {
            if (i == turretLevel)
            {
                turretPrefabs[i].SetActive(true);
            }
            else
            {
                turretPrefabs[i].SetActive(false);
            }
        
        }
        
        if (turretLevel < turretPrefabs.Length - 1)
        {

            turretLevel++;


        
        
        }

    
    
    }


}
