using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
  


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
       
       

    }

    //Movimiento del Player x Axis
    void PlayerMovement()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);

    }


}