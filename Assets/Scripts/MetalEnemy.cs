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

    void FollowLerp()
    {
        transform.position = Vector3.Lerp(transform.position, transformPlayer.position, speedEnemy * Time.deltaTime);

    }

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

    void LookAt()
    {

        transform.LookAt(transformPlayer);

    }
}
