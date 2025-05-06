using UnityEngine;
[CreateAssetMenu(menuName = "Skills/Blue Flare")]
public class BlueFlare : Skill
{
    public float damage = 10f;
    public GameObject bf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Activate(GameObject user)
    {
        Debug.Log("Blue Flare has been triggered.");
        Vector3 spawnPos = user.transform.position + user.transform.forward * 3f + Vector3.up * 10f; //3 steps in front of the player then moves 10 steps aboves the player

        Debug.Log($"Blue Flare activated!");
    }
}
