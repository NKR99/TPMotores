using UnityEngine;

public class DenimEnemy : MonoBehaviour
{
    [SerializeField] Transform transformPlayer;
    [SerializeField] float speedRotation;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LookAtQ();
    }

    // Mira la posición del Player implementando Quaternion + Lerp
    void LookAtQ()
    {

        Quaternion newRotation = Quaternion.LookRotation(transformPlayer.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedRotation * Time.deltaTime);


    }
}
