﻿#pragma strict

function OnTriggerEnter(tr: Collider)
{

if ( tr.collider.tag == "Enemy_Warrior")
{
 Application.LoadLevel (3);
 
}
}