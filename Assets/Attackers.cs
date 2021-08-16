using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    [Range(-1f, 2f)]
    public float lizardWalkSpeed;
    Animator lizardAnim;
     SpriteRenderer lizardSprite;
    private GameObject currentObject;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        rb.isKinematic = true;
        lizardAnim = GetComponent<Animator>();
        lizardSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (lizardWalkSpeed>0&&lizardWalkSpeed<=2)
        //{
        //    lizardAnim.SetTrigger("IsWalking");
        //    transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);
        //}
        if (lizardWalkSpeed > 0 )
        {
         lizardSprite.flipX = false;
           // lizardAnim.SetTrigger("IsWalking");
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);
        }
        if (lizardWalkSpeed < 0)
        {
           lizardSprite.flipX = true;
            // lizardAnim.SetTrigger("IsWalking");
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered with" + name);
    }
    public void SetSpeed(float speed)
    {
        lizardWalkSpeed = speed;
    }
    public void StrikeCurrentTarget(float Currentdamage)
    {
        //GameObject.FindObjectOfType<Health>().Healthdamage(Currentdamage);
        if(currentObject)
        {
           Health health= currentObject.GetComponent<Health>();

            if(health)
            {
                health.Healthdamage(Currentdamage);
            }
        }
        
    }

    public void Attack(GameObject obj)
    {
        currentObject = obj;
    }
}
