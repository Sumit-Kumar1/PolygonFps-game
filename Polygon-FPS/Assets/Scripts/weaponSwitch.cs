using UnityEngine;

public class weaponSwitch : MonoBehaviour
{
    [Tooltip("This will give you which weapon object is currently showing")]
    private int selectedWeapon = 0;
    public Transform gun1_transform;
    public Transform gun2_transform;
    Quaternion target = Quaternion.identity;
    private bool flag = false;
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
                if(!flag)
                {
                    target = gun1_transform.rotation;
                    flag = true;
                }
                else
                {
                    gun1_transform.rotation = target;
                    target = gun1_transform.rotation;
                }   
            }
            else
            {   
                target = gun1_transform.rotation;
                selectedWeapon++;
                gun2_transform.rotation = target;
                target = gun2_transform.rotation;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
            {
                selectedWeapon = transform.childCount - 1;

            }
            else
            {
                selectedWeapon--;
            }
        }
        //this will give you the weapons on pressing the buttons 1 and 2.
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            selectedWeapon = 0;
        }
        if(Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }
        
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
