using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerC2 : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelay = 20.0f;  

    // Start is called before the first frame update
    void Update()
    {
        fireDelay -= 0.1f;
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 20.0f;
        }
    }
}
