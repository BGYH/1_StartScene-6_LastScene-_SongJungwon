using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class JW_Ray_interactor_wand : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    private RaycastHit Collided_object;
    public float raycastDistance = 100f;
    public XRController controller = null;
    public GameObject earth_fire;
    public GameObject fire_fire;
    public GameObject water_fire;
    public GameObject wind_fire;
    public GameObject electric_fire;
    public GameObject dark_fire;
    public GameObject light_fire;
    public GameObject illusion_fire;
    public int select = 0;

    Canvas canvas2;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //JW_UI_script UI_script = GameObject.Find("next_start").GetComponent<JW_UI_script>();
        //if (UI_script.next_Panel == 1)
        //{
        //    if (Physics.Raycast(transform.position, transform.forward, out Collided_object, raycastDistance))
        //    {
        //        //UI_script UI_script = GameObject.Find("Start_UI").GetComponent<UI_script>();
        //        //Wand1_text wand1_Text = GameObject.Find("Wand_1").GetComponent<Wand1_text>();

        //        if (Collided_object.collider.gameObject.CompareTag("earth"))
        //        {
        //            //UI_script.wand_info.text = "���� ������";
        //            //wand1_Text.wand1_info.text = "���� ������";
        //            earth.text = "������ ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select earthwand");
        //                    earth_fire.SetActive(true);
        //                    dic["earth"] = 1;
        //                }

                        
        //            }
        //        }
        //        else
        //        {
        //            earth.text = " ";
                    
        //        }

        //        if (Collided_object.collider.gameObject.CompareTag("fire"))
        //        {
        //            fire.text = "���� ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    fire_fire.SetActive(true);
        //                    dic["fire"] = 1;
        //                }


        //            }
                    
        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            fire.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("water"))
        //        {
        //            water.text = "���� ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    water_fire.SetActive(true);
        //                    dic["water"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            water.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("wind"))
        //        {
        //            wind.text = "�ٶ��� ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    wind_fire.SetActive(true);
        //                    dic["wind"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            wind.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("electric"))
        //        {
        //            electric.text = "������ ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    electric_fire.SetActive(true);
        //                    dic["elctric"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            electric.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("dark"))
        //        {
        //            dark.text = "������ ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    dark_fire.SetActive(true);
        //                    dic["dark"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            dark.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("light"))
        //        {
        //            light.text = "���� ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    light_fire.SetActive(true);
        //                    dic["light"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            light.text = " ";
                    
        //        }
        //        if (Collided_object.collider.gameObject.CompareTag("illusion"))
        //        {
        //            illusion.text = "ȯ���� ������";
        //            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool AButton))// || Input.GetMouseButtonDown(0) a��ư������ ���� �ؾ���
        //            {

        //                if (AButton == true)
        //                {
        //                    Debug.Log("select");
        //                    illusion_fire.SetActive(true);
        //                    dic["illusion"] = 1;
        //                }


        //            }

        //        }
        //        else
        //        {
        //            //wand1_Text.wand1_info.text = "";
        //            illusion.text = " ";
                    
        //        }
        //    }
        //    else
        //    {

        //    }
        //}

    }
    Dictionary<string, int> dic = new Dictionary<string, int>()
    {
        {"eart",0 },{"fire",0},{"water",0},{"wind",0},{"electric",0},{"dark",0},{"light",0},{"illusion",0}
    };
    
}
