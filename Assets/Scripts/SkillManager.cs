using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public Skill[] equippedSkills; //Assigns skills to the inspector in the Editor
    public GameObject Anna;
    private float lastUsedTime;

    // Update is called once per frame
    public void Use(GameObject user)
    {
        if (Input.GetKeyDown(KeyCode.Q) && Time.time >= lastUsedTime + equippedSkills[0].cooldown)
        {
            UseSkill(0);
            lastUsedTime = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.E))
            UseSkill(0);
    }

    void UseSkill(int index)
    {
        if (equippedSkills[index] != null)
        {
            Debug.Log("Using skill: " + equippedSkills[index].name);
            equippedSkills[index].Use(Anna);
        }
        else
        {
            Debug.Log("No skill assigned to slot" + index);
        }
    }
}
