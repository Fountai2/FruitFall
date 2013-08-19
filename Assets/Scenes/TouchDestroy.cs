using UnityEngine;
using System.Collections;

public class TouchDestroy : MonoBehaviour {
	private Touch touch;
	private Ray ray;
	RaycastHit hit;
	public LayerMask mask;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
/**	if(Input.touchCount ==1){
			touch = Input.touches[0];
			if(touch.phase == TouchPhase.Ended){
				ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
				if(Physics.Raycast(ray.origin, ray.direction * 100, out hit)){
					if (hit.transform != null) {
						Destroy(hit.GameObject);
					
				}
			}
		}
	} **/
	if (Input.touchCount ==1)
		{
    		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       // if (Physics.Raycast(ray,100, mask ))
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.gameObject )
				{
				 print("Hit something");
				Destroy (hit.transform.gameObject);
				}
           
			}
		}
			
	
	}
}
	

