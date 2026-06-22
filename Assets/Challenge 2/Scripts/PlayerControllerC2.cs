using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerC2 : MonoBehaviour
{
    public GameObject dogPrefab;
   

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
         
        }
    }
}
