using UnityEngine;

public class MetalEnemy : MonoBehaviour
{
    [SerializeField] Transform transformPlayer;
    [SerializeField] float speedEnemy = 0.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowLerp();
        CheckDistancia();
        LookAt();
    }

    // Sigue al personaje con una velocidad lerp
    void FollowLerp()
    {
        transform.position = Vector3.Lerp(transform.position, transformPlayer.position, speedEnemy * Time.deltaTime);

    }

    // Chequea distancia al Player, a 2 unidades de distancia se detiene, sino continua.  
    void CheckDistancia()
    {
        float dist = Vector3.Distance(transform.position, transformPlayer.position);

        if (dist <= 2)
        {
            speedEnemy = 0;
        }
        else
        {
            speedEnemy = 0.5f;
        }
    }

    //mira siempre al jugador
    void LookAt()
    {

        transform.LookAt(transformPlayer);

    }
}
