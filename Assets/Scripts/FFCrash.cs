using UnityEngine;

public class FFCrash : MonoBehaviour
{
    public float fallSpeed = 15f;
    public LayerMask groundLayer;
    public GameObject explosionVFX;
    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
        
        if (Physics.Raycast(transform.position, Vector3.down, 5f, groundLayer))
        {
            Explode();
        }
    }

    void Explode()
    {
        Debug.Log("Fusion Flare has landed.");

        if (explosionVFX != null)
            Instantiate(explosionVFX, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
