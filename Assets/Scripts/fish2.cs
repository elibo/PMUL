using UnityEngine;
using System.Collections;

public class fish2
    : MonoBehaviour
{

    private float speed = -1;
  
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (speed != 1)
        {
            speed = 1;
            transform.Rotate(0, 180, 0);
            transform.position += new Vector3(speed * Time.deltaTime, Random.value, 0);
        }
        else
        {
            speed = -1;
            transform.Rotate(0, 180, 0);
            transform.position += new Vector3(speed * Time.deltaTime, Random.value, 0);
        }
    }

}
