using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    [SerializeField] private GameObject healthBar;
    private float health = 1.0f;
    private bool isDead = false;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = healthBar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
       StartCoroutine(CheckHealth());
    }

    IEnumerator CheckHealth(){
        if (health > 0.00f){
            health -= 0.05f;
            slider.value = health;
        }else if (health <= 0.0f){
            Debug.Log("You are dead");
            isDead = true;
        }

        yield return new WaitForSeconds(3.0f);
    }
}
