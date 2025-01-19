using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    public GameObject projectile;

    public void Shot()
    {
        GameObject projectileGameObject = Instantiate(projectile);
        projectileGameObject.transform.position = transform.position;
    }
}
