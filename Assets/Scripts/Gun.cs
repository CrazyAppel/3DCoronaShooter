using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzleflash;
    public ParticleSystem death;
    public Text scoreText;

    private int score = 0;
    //public ParticleSystem muzzleflash1;

    public Camera tpsCam;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleflash.Emit(1);
        //muzzleflash1.Emit(1);
        RaycastHit hit;
        if (Physics.Raycast(tpsCam.transform.position, tpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "CoronaSphere")
            {
                death.transform.position = hit.transform.position;
                death.time = 0;
                death.Play(withChildren:true);
                Destroy(hit.transform.parent.gameObject);
                score++;
                scoreText.text = score.ToString();
            }
        }
    }
}
