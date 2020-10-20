using System.Collections.Specialized;
using System.Xml.Serialization;
using UnityEngine;

public class weaponSwitch : MonoBehaviour
{
    [Tooltip("This will give you which weapon object is currently showing")]
    public int selectedWeapon = 0;
    public GameObject gun1_transform;
    public GameObject gun2_transform;
    
    void Start()
    {
        SelectWeapon();
    }

    
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount - 1)
            {
                selectedWeapon = 0;
                gun1_transform.transform.position = gun2_transform.transform.position; 
            }

            else
            {
                selectedWeapon++;
                gun2_transform.transform.position = gun1_transform.transform.position; 
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
            {
                selectedWeapon = transform.childCount - 1;
                gun2_transform.transform.position = gun1_transform.transform.position;
               
            }
            else
            {
                selectedWeapon--;
                gun1_transform.transform.position = gun2_transform.transform.position;
                
            }
        }
        //this will give you the wepons on pressing the buttons 1 and 2.
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            selectedWeapon = 0;
        }
        if(Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }
        //upto here.
        if(previousSelectedWeapon!=selectedWeapon)
        {
            SelectWeapon();
        }

    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
