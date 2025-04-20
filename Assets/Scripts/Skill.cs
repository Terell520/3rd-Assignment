using UnityEngine;

 public abstract class Skill : ScriptableObject 
{
    //ScriptableObject: Data containers that saves large amounts of data.
    //Abstract: allows one to force a class to inherit an attribute. Need to make variables with the keyword "abstract" because it forces any class to inherit the variable.
    public string skillName;
    public float cooldown;
    public float lastUsedTime;

    public abstract void Activate(GameObject user);

    public bool IsReady()
    {
        return Time.time >= lastUsedTime + cooldown;
    }

    public void Use(GameObject user)
    {
        if (IsReady())
        {
            Activate(user);
            lastUsedTime = Time.time;
        }
    }
}
