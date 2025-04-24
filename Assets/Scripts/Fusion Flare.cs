using UnityEngine;

[CreateAssetMenu(menuName = "Skills/Fusion Flare")]
public class FusionFlare : Skill
{
    public GameObject flame;
    public float damage = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Activate(GameObject user)
    {
        Debug.Log("Fusion Flare has been triggered.");
        Vector3 spawnPos = user.transform.position + user.transform.forward * 3f + Vector3.up * 10f;
        GameObject fx = GameObject.Instantiate(flame, spawnPos, Quaternion.identity);

        Debug.Log($"Fusion Flare activated!");
    }
}
