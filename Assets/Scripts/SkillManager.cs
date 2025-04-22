using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public Skill[] equippedSkills; //Assigns skills to the inspector in the Editor
    public GameObject Anna;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            UseSkill(0);
        if (Input.GetKeyDown(KeyCode.E))
            UseSkill(0);
    }

    void UseSkill(int index)
    {
        if (equippedSkills[index] != null)
        {
            equippedSkills[index].Use(Anna);
        }
    }
}
