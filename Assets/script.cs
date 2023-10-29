using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    //public her gør ta man kan se den i inspector i junity, og så kan den ændres dynamisk
    //ligesom inspect html/css
    [Header("header")] //er kinda som css i unity, ses header i inspector, det er fra unity engine
    [Tooltip("Movement right")]
    public float movingSpeed = .1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hello from {this.name}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){  //hvis der trykkes på knappen pil-op
            transform.position += Vector3.right * movingSpeed * Time.deltaTime;
        } else  if (Input.GetKey(KeyCode.DownArrow)){
             transform.position += Vector3.left * movingSpeed * Time.deltaTime;           
        }

        if (Input.GetKey(KeyCode.LeftArrow)){  //hvis der trykkes på knappen pil-op
            transform.rotation = Quaternion.Slerp(
            transform.rotation, 
            Quaternion.LookRotation(Vector3.back),
            1f);
        } 
        //localPosition er i forhold til game objects parent, samme med scale
        //transform.localPosition, .scale, .rotation - er Quaternion, vinkel på flade i forhold til punkt
        
         //skifter rotation, hvor meget skal objektet
        //rotere for at stå en bestemt retning, a er hvor vil jeg kigge hen, b hvor meget jeg
        //skal rotere for det, c noge

        //if (transform.position.x < 10){  //hvis x retning i vektor er mindre ens 10
        //    transform.position += Vector3.right * movingSpeed * Time.deltaTime;
        //}
        

        //name og transform r porperties, ses i Inspector i unity
        //trasform er en property som er en objekt reference, som har property/field position
        //læggerny vektor på for bevægelse, i x retning (højre), ganger noget på ellers bevæger den
        //sig meget hurtigt da den kaldes hele tiden. * 0.01 float gjorde vi først, nu deltaTime
        //transform.position += new Vector3(1,0,0) * .1f * Time.deltaTime;
        transform.position += Vector3.right * movingSpeed * Time.deltaTime;
        //deltatime er del af sekund den flyttes pr frame
        //ganger vektor med den del af sekund som 

        //structs, de er valuetyper ikke referencer, kan være årsag til at ting ikke virker
        //da man måske tror man redgere et tidligere objekt men det er struct
    }
}
