using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    [SerializeField] float rotateSpeed;
    [SerializeField] GameObject sWall;
  


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
        //Axis Vertical Movimiento Adelante Atrás
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        //Axis Horizontal Rotación estilo RE
        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);

    }

    // Triger de objeto Swall, al colisionar cambia de posición y rotación al azar en un rango determinado 
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "SWall")
        {
            float positionXWall = Random.Range(-8, 8);
            float positionZWall = Random.Range(-8, 8);
            float rotationWall = Random.Range(0, 360);

            sWall.transform.position = new Vector3(positionXWall, 1.5f, positionZWall);
            sWall.transform.Rotate(new Vector3(0, rotationWall, 0));

        }

    }


}