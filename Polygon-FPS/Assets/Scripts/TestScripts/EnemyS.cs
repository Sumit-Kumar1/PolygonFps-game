using UnityEngine;

public class EnemyS : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootDelay = 0.0f;
    private float waitToShoot;
    float nextFire = 0;
    float fireDelay = 100;

    private void Start()
    {
    }
    private void Update()
    {

        if (Time.time * 1000 > nextFire)
        {
            nextFire = (Time.time * 1000) + fireDelay;
            Fire();
        }


        if (waitToShoot > 0)
        {
            waitToShoot = Time.deltaTime;
        }
    }

    private void Fire()
    {
        GameObject _bullet = Instantiate<GameObject>(bullet, new Vector3(this.transform.position.x + 3, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
        _bullet.transform.Translate(Vector3.forward * Time.deltaTime * 5.0f);

        customDestroy(_bullet);
    }

    //destroy the bullet after 3 seconds
    void customDestroy(GameObject bullet)
    {
        new WaitForSeconds(3.0f);
        Destroy(bullet);
    }
}
