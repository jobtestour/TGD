using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollCheck : MonoBehaviour
{
    // Start is called before the first frame update

	Vector2 Left;
	Vector2 Right;
	Vector2 BottomCenterLeft;
	Vector2 BottomCenterRight;
	Vector2 Origin;
	Vector2 OriginLeft;
	Vector2 OriginRight;
	Vector2 OriginBottomLeft;
	Vector2 OriginBottomRight;
	Vector2 MiddleLeft;
	Vector2 MiddleRight;
	RaycastHit2D HitLeft;
	RaycastHit2D HitRight;
	RaycastHit2D HitCenterLeft;
	RaycastHit2D HitCenterRight;
	RaycastHit2D HitBottomLeft;
	RaycastHit2D HitBottomRight;
	RaycastHit2D HitBottomCenterLeft;
	RaycastHit2D HitBottomCenterRight;
	RaycastHit2D HitMiddleRight;
	RaycastHit2D HitMiddleLeft;

	Vector2 StartPlace;

	public LayerMask MaskToCheck;
	PopObject Pop;
	GameObject ObjToErase;
	public float Checkradius;


	void Start()
	{

		Pop = GameObject.FindGameObjectWithTag("Pop").GetComponent<PopObject>();

	



		StartPlace = transform.position;
	
	
	}




	void FixedUpdate()
	{
		CollChecker();
	
	}




	public void CollChecker()
	{

		Left = Vector2.left;
		Right = Vector2.right;


		Origin = transform.position;

		OriginLeft.x = transform.position.x + -GetComponent<SpriteRenderer>().bounds.extents.x;
		OriginLeft.y = transform.position.y;

		OriginRight.x = transform.position.x + GetComponent<SpriteRenderer>().bounds.extents.x;
		OriginRight.y = transform.position.y;

		OriginBottomLeft.x = transform.position.x + -GetComponent<SpriteRenderer>().bounds.extents.x;
		OriginBottomLeft.y = transform.position.y + -GetComponent<SpriteRenderer>().bounds.extents.y;

		OriginBottomRight.x = transform.position.x + GetComponent<SpriteRenderer>().bounds.extents.x;
		OriginBottomRight.y = transform.position.y - GetComponent<SpriteRenderer>().bounds.extents.y;

		BottomCenterLeft.x = transform.position.x;
		BottomCenterLeft.y = transform.position.y + -GetComponent<SpriteRenderer>().bounds.extents.y;

		BottomCenterRight.x = transform.position.x;
		BottomCenterRight.y = transform.position.y - GetComponent<SpriteRenderer>().bounds.extents.y;


		MiddleLeft.x=transform.position.x + -GetComponent<SpriteRenderer>().bounds.extents.x;
		MiddleLeft.y = transform.position.y + -GetComponent<SpriteRenderer>().bounds.extents.y/2;

		MiddleRight.x = transform.position.x + GetComponent<SpriteRenderer>().bounds.extents.x;
		MiddleRight.y = transform.position.y + -GetComponent<SpriteRenderer>().bounds.extents.y / 2;




		HitLeft = Physics2D.Raycast(OriginLeft, Left, Checkradius, MaskToCheck);

		HitRight = Physics2D.Raycast(OriginRight, Right, Checkradius, MaskToCheck);

		HitCenterLeft=Physics2D.Raycast(Origin, Left, Checkradius, MaskToCheck);

		HitCenterRight = Physics2D.Raycast(Origin, Right, Checkradius, MaskToCheck);

		HitBottomLeft=Physics2D.Raycast(OriginBottomLeft, Left, Checkradius, MaskToCheck);

		HitBottomRight = Physics2D.Raycast(OriginBottomRight, Right, Checkradius, MaskToCheck);

		HitBottomCenterLeft=Physics2D.Raycast(BottomCenterLeft, Left, Checkradius, MaskToCheck);

		HitBottomCenterRight = Physics2D.Raycast(BottomCenterRight, Right, Checkradius, MaskToCheck);

		HitMiddleLeft = Physics2D.Raycast(MiddleLeft, Left, Checkradius, MaskToCheck);

		HitMiddleRight = Physics2D.Raycast(MiddleRight, Right, Checkradius, MaskToCheck);

		//for debug --------------------------------------------------------------
		Debug.DrawRay(OriginLeft, Left, Color.cyan);//

		Debug.DrawRay(OriginRight, Right, Color.yellow);//

		Debug.DrawRay(Origin, Right, Color.red);//

		Debug.DrawRay(Origin, Left, Color.green);//

		Debug.DrawRay(OriginBottomLeft, Left, Color.blue);

		Debug.DrawRay(OriginBottomRight, Right, Color.black);

		Debug.DrawRay(BottomCenterLeft, Left, Color.black);

		Debug.DrawRay(BottomCenterRight, Right, Color.black);

		Debug.DrawRay(MiddleLeft, Left, Color.black);

		Debug.DrawRay(MiddleRight, Right, Color.black);

		//--------------------------------------------------------------------------
			if (HitLeft.collider)
			{

			//Debug.Log("HitLeft");

			if (HitLeft.collider.gameObject.CompareTag("CollBox"))
			{


				Destroy(HitLeft.collider.gameObject.transform.parent.gameObject);
			
			}

			}
			if (HitRight.collider)
			{
			
			if (HitRight.collider.gameObject.CompareTag("CollBox"))
			{
				Destroy(HitRight.collider.gameObject.transform.parent.gameObject);
		

			}
			}
			if (HitCenterLeft.collider)
			{

		
			if (HitCenterLeft.collider.gameObject.CompareTag("CollBox"))
			{
				Destroy(HitCenterLeft.collider.gameObject.transform.parent.gameObject);
	
			}

			}
			if (HitCenterRight.collider)
			{
	

			if (HitCenterRight.collider.gameObject.CompareTag("CollBox"))
			{
				Destroy(HitCenterRight.collider.gameObject.transform.parent.gameObject);

			}

			}
			if (HitBottomLeft.collider)
			{
	
			if (HitBottomLeft.collider.gameObject.CompareTag("Object"))
			{
				Destroy(HitBottomLeft.collider.gameObject.transform.parent.gameObject);

			}

			}
			if (HitBottomRight.collider)
			{
	

			if (HitBottomRight.collider.gameObject.CompareTag("CollBox"))
			{
				Destroy(HitBottomRight.collider.gameObject.transform.parent.gameObject);
	
			}
			}


			if (HitBottomCenterLeft.collider)
			{

	
				if (HitBottomCenterLeft.collider.gameObject.CompareTag("CollBox"))
				{
					Destroy(HitBottomCenterLeft.collider.gameObject.transform.parent.gameObject);
			
				}
			}
			
			if (HitBottomCenterRight.collider)
			{
	
				if (HitBottomCenterRight.collider.gameObject.CompareTag("CollBox"))
				{
					Destroy(HitBottomCenterRight.collider.gameObject.transform.parent.gameObject);
			
				}
			}
			if (HitMiddleLeft.collider)
			{

				if (HitMiddleLeft.collider.gameObject.CompareTag("CollBox"))
				{
					Destroy(HitMiddleLeft.collider.gameObject.transform.parent.gameObject);
				
				}
			
			
			
			}
			if (HitMiddleRight.collider)
			{


			if (HitMiddleRight.collider.gameObject.CompareTag("CollBox"))
			{
				Destroy(HitMiddleRight.collider.gameObject.transform.parent.gameObject);

			}
			
			
			}


	

	}



	public void ReplaceGlass() 
	{


		transform.position = StartPlace;
	
	
	
	
	}


}
