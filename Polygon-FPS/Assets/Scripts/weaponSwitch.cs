using UnityEngine;

public class weaponSwitch : MonoBehaviour
{
    [Tooltip("This will give you which weapon object is currently showing")]
    private int selectedWeapon = 0;
    public Transform gun1_transform;
    public Transform gun2_transform;
    public GameObject gun1;
    public GameObject gun2;
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
                swap(gun1_transform, gun2_transform);
                gun1.transform.position = gun2.transform.position;
            }
            else
            {
                selectedWeapon++;
                swap(gun2_transform, gun1_transform);
                gun2.transform.position = gun1.transform.position;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
            {
                selectedWeapon = transform.childCount - 1;
                swap(gun1_transform, gun2_transform);
                gun2.transform.position = gun1.transform.position;
            }
            else
            {
                selectedWeapon--;
                swap(gun2_transform, gun1_transform);
                gun1.transform.position = gun2.transform.position;
            }
        } 
        if(previousSelectedWeapon!=selectedWeapon)
        {
            SelectWeapon();
        }
    }
    
    void swap(Transform a, Transform b)
    {
        Quaternion target = Quaternion.identity;
        target = b.rotation;
        b.rotation = a.rotation;
        a.rotation = target;
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