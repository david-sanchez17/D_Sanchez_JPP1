using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerC2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1.0f;
    private float nextFire = 0.0f;
   

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
         
        }
    }
}
