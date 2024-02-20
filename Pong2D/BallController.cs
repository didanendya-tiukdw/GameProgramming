using UnityEngine; 
public class BallController : MonoBehaviour
{ 
	public int force; 
	Rigidbody2D rigid; 
	
	// Use this for initialization 
	void Start () 
    { 
        rigid = GetComponent<Rigidbody2D> (); 
        Vector2 arah = new Vector2 (2, 0).normalized; 
        rigid.AddForce (arah * force); 
    } 
    // Update is called once per frame 
    void Update ()
    { 

    }
    void ResetBall ()
    {
        transform.localPosition = new Vector2 (0, 0); 4. rigid.velocity = new Vector2 (0, 0);
    }
    private void OnCollisionEnter2D (Collision2D coll)
    { 
        if (coll.gameObject.name == "TepiKanan") 
        { 
            ResetBall ();
            Vector2 arah = new Vector2 (2, 0).normalized; 
            rigid.AddForce (arah * force); 
        } if (coll.gameObject.name == "TepiKiri") 
            ResetBall (); 
            Vector2 arah = new Vector2 (-2, 0).normalized; 
            rigid.AddForce (arah * force);
        }
        if(coll.gameObject.name == "Pemukul1" || coll.gameObject.name == "Pemukul2")
        {
            float sudut =(transform.position.y - coll.transform.position.y)*5f;
            Vector2 arah = new Vector2(rigid.velocity.x, sudut).normalized; 
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah * force * 2); 7. }
    } 
}