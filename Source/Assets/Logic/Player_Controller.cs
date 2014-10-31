﻿using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour 
{
	
	
	public float Speed;              		// Скорость игрока
	private float MoveVertical;				// Перемещение по вертикали
	private float MoveHorizontal;			// Перемещение по горизонтали
	
	public SpriteRenderer Cat_SpriteRender;
	public Sprite HellCat_Sprite_Mode_One;
	public Sprite HellCat_Sprite_Mode_Two;

	//режим кошки, false = кошка видна целиком true = кошка ушла под землю
	public static bool Hellcat_Mode = false;

	// Перед обновлением сцены	
	void FixedUpdate()
	{		
		MoveHorizontal = Input.GetAxis("Horizontal");
		MoveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);
		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
		
		if (Hellcat_Mode == false) 
		{

			rigidbody.position = rigidbody.position + movement / Speed;
		} 
		else
		{			

			rigidbody.position = rigidbody.position + movement / (Speed / 2);
		}
		
		if (Input.GetKeyDown (KeyCode.Space)) 

		{			
			if (Hellcat_Mode == false) 
			{
				Hellcat_Mode = true;
				rigidbody.isKinematic = true;
				Cat_SpriteRender.sprite = HellCat_Sprite_Mode_Two;
			} 
			else 
			{
				Hellcat_Mode = false;
				rigidbody.isKinematic = false;
				Cat_SpriteRender.sprite = HellCat_Sprite_Mode_One;				
			}
		}
		
	}
}