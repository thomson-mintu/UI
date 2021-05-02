using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnTouchDown : MonoBehaviour
{
	GameObject Appletxt,balltxt ,cattxt;
    private GameObject dogtxt;
    private GameObject eggtxt;
    private GameObject fishtxt;
    private GameObject giraffetxt;
    private GameObject helitxt;
    private GameObject icetxt;
    private GameObject jackettxt;
    private GameObject kangarootxt;
    private GameObject liontxt;
    private GameObject mangotxt;
    private GameObject notetxt;
    private GameObject orangetxt;
    private GameObject parrottxt;
    private GameObject queentxt;
    private GameObject rattxt;
    private GameObject snowtxt;
    private GameObject treetxt;
    private GameObject umbrellatxt;
    private GameObject vantxt;
    private GameObject watchtxt;
    private GameObject xylotxt;
    private GameObject yachttxt;
    private GameObject zebratxt;

    private void Start()
    {
		Appletxt = GameObject.FindGameObjectWithTag("AppleTxt");
		balltxt = GameObject.FindGameObjectWithTag("footballtxt");
		cattxt = GameObject.FindGameObjectWithTag("cattxt");
		dogtxt = GameObject.FindGameObjectWithTag("dogtxt");
		eggtxt = GameObject.FindGameObjectWithTag("eggtxt");
		fishtxt = GameObject.FindGameObjectWithTag("fishtxt");
		giraffetxt = GameObject.FindGameObjectWithTag("giraffetxt");
		helitxt = GameObject.FindGameObjectWithTag("helitxt");
		icetxt = GameObject.FindGameObjectWithTag("icecreamtxt");
		jackettxt = GameObject.FindGameObjectWithTag("jackettxt");
		kangarootxt = GameObject.FindGameObjectWithTag("kangarootxt");
		liontxt = GameObject.FindGameObjectWithTag("liontxt");
		mangotxt = GameObject.FindGameObjectWithTag("mangotxt");
		notetxt= GameObject.FindGameObjectWithTag("notetxt");
		orangetxt = GameObject.FindGameObjectWithTag("orangetxt");
		parrottxt= GameObject.FindGameObjectWithTag("parrottxt");
		queentxt= GameObject.FindGameObjectWithTag("queentxt");
		rattxt = GameObject.FindGameObjectWithTag("rattxt");
		snowtxt = GameObject.FindGameObjectWithTag("snowtxt");
		treetxt = GameObject.FindGameObjectWithTag("treetxt");
		umbrellatxt = GameObject.FindGameObjectWithTag("umbrellatxt");
		vantxt = GameObject.FindGameObjectWithTag("vantxt");
		watchtxt = GameObject.FindGameObjectWithTag("watchtxt");
		xylotxt = GameObject.FindGameObjectWithTag("xylotxt");
		yachttxt= GameObject.FindGameObjectWithTag("yachttxt");
		zebratxt = GameObject.FindGameObjectWithTag("zebratxt");

		Appletxt.SetActive(false);
		balltxt.SetActive(false);
		cattxt.SetActive(false);
		dogtxt.SetActive(false);
		eggtxt.SetActive(false);
		fishtxt.SetActive(false);
		giraffetxt.SetActive(false);
		helitxt.SetActive(false);
		icetxt.SetActive(false);
		jackettxt.SetActive(false);
		kangarootxt.SetActive(false);
		liontxt.SetActive(false);
		mangotxt.SetActive(false);
		notetxt.SetActive(false);
		orangetxt.SetActive(false);
		parrottxt.SetActive(false);
		queentxt.SetActive(false);
		rattxt.SetActive(false);
		snowtxt.SetActive(false);
		treetxt.SetActive(false);
		umbrellatxt.SetActive(false);
		vantxt.SetActive(false);
		watchtxt.SetActive(false);
		xylotxt.SetActive(false);
		yachttxt.SetActive(false);
		zebratxt.SetActive(false);
	}
    void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{ // if left button pressed...
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "Apple")
				{
					if (Appletxt.activeSelf == true)
					{
						Appletxt.SetActive(false);
					}
					else
					{
						Appletxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "football")
				{
					if (balltxt.activeSelf == true)
					{
						balltxt.SetActive(false);
					}
					else
					{
						balltxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "cat")
				{
					if (cattxt.activeSelf == true)
					{
						cattxt.SetActive(false);
					}
					else
					{
						cattxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "dog")
				{
					if (dogtxt.activeSelf == true)
					{
						dogtxt.SetActive(false);
					}
					else
					{
						dogtxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "egg")
				{
					if (eggtxt.activeSelf == true)
					{
						eggtxt.SetActive(false);
					}
					else
					{
						eggtxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "fish")
				{
					if (fishtxt.activeSelf == true)
					{
						fishtxt.SetActive(false);
					}
					else
					{
						fishtxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "giraffe")
				{
					if (giraffetxt.activeSelf == true)
					{
						giraffetxt.SetActive(false);
					}
					else
					{
						giraffetxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "heli")
				{
					if (helitxt.activeSelf == true)
					{
						helitxt.SetActive(false);
					}
					else
					{
						helitxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "icecream")
				{
					if (icetxt.activeSelf == true)
					{
						icetxt.SetActive(false);
					}
					else
					{
						icetxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "jacket")
				{
					if (jackettxt.activeSelf == true)
					{
						jackettxt.SetActive(false);
					}
					else
					{
						jackettxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "kangaroo")
				{
					if (kangarootxt.activeSelf == true)
					{
						kangarootxt.SetActive(false);
					}
					else
					{
						kangarootxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "lion")
				{
					if (liontxt.activeSelf == true)
					{
						liontxt.SetActive(false);
					}
					else
					{
						liontxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "mango")
				{
					if (mangotxt.activeSelf == true)
					{
						mangotxt.SetActive(false);
					}
					else
					{
						mangotxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "note")
				{
					if (notetxt.activeSelf == true)
					{
						notetxt.SetActive(false);
					}
					else
					{
						notetxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "orange")
				{
					if (orangetxt.activeSelf == true)
					{
						orangetxt.SetActive(false);
					}
					else
					{
						orangetxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "parrot")
				{
					if (parrottxt.activeSelf == true)
					{
						parrottxt.SetActive(false);
					}
					else
					{
						parrottxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "queen")
				{
					if (queentxt.activeSelf == true)
					{
						queentxt.SetActive(false);
					}
					else
					{
						queentxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "rat")
				{
					if (rattxt.activeSelf == true)
					{
						rattxt.SetActive(false);
					}
					else
					{
						rattxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "snow")
				{
					if (snowtxt.activeSelf == true)
					{
						snowtxt.SetActive(false);
					}
					else
					{
						snowtxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "tree")
				{
					if (treetxt.activeSelf == true)
					{
						treetxt.SetActive(false);
					}
					else
					{
						treetxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "umbrella")
				{
					if (umbrellatxt.activeSelf == true)
					{
						umbrellatxt.SetActive(false);
					}
					else
					{
						umbrellatxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "van")
				{
					if (vantxt.activeSelf == true)
					{
						vantxt.SetActive(false);
					}
					else
					{
						vantxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "watch")
				{
					if (watchtxt.activeSelf == true)
					{
						watchtxt.SetActive(false);
					}
					else
					{
						watchtxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "xylo")
				{
					if (xylotxt.activeSelf == true)
					{
						xylotxt.SetActive(false);
					}
					else
					{
						xylotxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "yacht")
				{
					if (yachttxt.activeSelf == true)
					{
						yachttxt.SetActive(false);
					}
					else
					{
						yachttxt.SetActive(true);
					}
				}
				if (hit.collider.tag == "zebra")
				{
					if (zebratxt.activeSelf == true)
					{
						zebratxt.SetActive(false);
					}
					else
					{
						zebratxt.SetActive(true);
					}
				}
			}
		}

	}
}