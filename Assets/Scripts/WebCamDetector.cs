using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Unity.Barracuda;
using UnityEngine.Profiling;

[RequireComponent(typeof(OnGUICanvasRelativeDrawer))]
public class WebCamDetector : MonoBehaviour
{
    [Tooltip("File of YOLO model. If you want to use another than YOLOv2 tiny, it may be necessary to change some const values in YOLOHandler.cs")]
    public NNModel modelFile;
    [Tooltip("Text file with classes names separated by coma ','")]
    public TextAsset classesFile;

    [Tooltip("RawImage component which will be used to draw resuls.")]
    public RawImage imageRenderer;

    [Range(0.05f, 1f)]
    [Tooltip("The minimum value of box confidence below which boxes won't be drawn.")]
    public float MinBoxConfidence = 0.3f;
    GameObject total;

    public GameObject dog;
    public GameObject plane;
    public GameObject sofa;
    public GameObject car;
    public TextMesh title;
    public TextMesh descr;
    public GameObject descriptor;


    NNHandler nn;
    YOLOHandler yolo;

    WebCamTexture camTexture;
    Texture2D displayingTex;

    TextureScaler textureScaler;

    string[] classesNames;
    OnGUICanvasRelativeDrawer relativeDrawer;

    Color[] colorArray = new Color[] { Color.red, Color.green, Color.blue, Color.cyan, Color.magenta, Color.yellow };

    void Start()
    {
        var dev = SelectCameraDevice();
        camTexture = new WebCamTexture(dev);
        camTexture.Play();

        nn = new NNHandler(modelFile);
        yolo = new YOLOHandler(nn);

        textureScaler = new TextureScaler(nn.model.inputs[0].shape[1], nn.model.inputs[0].shape[2]);

        relativeDrawer = GetComponent<OnGUICanvasRelativeDrawer>();
        relativeDrawer.relativeObject = imageRenderer.GetComponent<RectTransform>();

        classesNames = classesFile.text.Split(',');
    }

    void Update()
    {
        CaptureAndPrepareTexture(camTexture, ref displayingTex);

        var boxes = yolo.Run(displayingTex);
        DrawResults(boxes, displayingTex);
        imageRenderer.texture = displayingTex;
        boxes.ForEach(box => search(box));


    }

     private void search(YOLOHandler.ResultBox box)
    {
        if(box.classes[box.bestClassIdx]> MinBoxConfidence)
        {
            String clsname = classesNames[box.bestClassIdx];
            Debug.Log("Object is "+ clsname);
            if(String.Compare(clsname," dog")==0)
            {
                dog.SetActive(true);
                descriptor.SetActive(true);
                title.text = "Dog";
                descr.text = "Dog is a domestic animal";
            }
            else if (String.Compare(clsname, "aeroplane") == 0)
            {
                plane.SetActive(true);
                descriptor.SetActive(true);
                title.text = "Aeroplane";
                descr.text = "Aeroplane is a flying vehicle";
            }
            else if (String.Compare(clsname, " car") == 0)
            {
                car.SetActive(true);
                descriptor.SetActive(true);
                title.text = "Car";
                descr.text = "Car is land vehicle";
            }
            else if (String.Compare(clsname, " sofa") == 0)
            {
                sofa.SetActive(true);
                descriptor.SetActive(true);
                title.text = "Sofa";
                descr.text = "Sofa is a furniture";
            }
            else
            {
                sofa.SetActive(false);
                descriptor.SetActive(false);
                dog.SetActive(false);
                car.SetActive(false);
                plane.SetActive(false);
            }
        }
    }
    private void OnDestroy()
    {
        nn.Dispose();
        yolo.Dispose();
        textureScaler.Dispose();

        camTexture.Stop();
    }

    private void CaptureAndPrepareTexture(WebCamTexture camTexture, ref Texture2D tex)
    {
        Profiler.BeginSample("Texture processing");
        TextureCropTools.CropToSquare(camTexture, ref tex);
        textureScaler.Scale(tex);
        Profiler.EndSample();
    }

    private void DrawResults(IEnumerable<YOLOHandler.ResultBox> results, Texture2D img)
    {
        relativeDrawer.Clear();
        results.ForEach(box => DrawBox(box, displayingTex));

    }

    private void DrawBox(YOLOHandler.ResultBox box, Texture2D img)
    {
        if (box.classes[box.bestClassIdx] < MinBoxConfidence)
            return;

        TextureDrawingUtils.DrawRect(img, box.rect, colorArray[box.bestClassIdx % colorArray.Length],
                                    (int)(box.classes[box.bestClassIdx] / MinBoxConfidence), true, true);
        relativeDrawer.DrawLabel(classesNames[box.bestClassIdx], box.rect.position);
        //Debug.Log(classesNames[box.bestClassIdx]);
    }

    /// <summary>
    /// Return first backfaced camera name if avaible, otherwise first possible
    /// </summary>
    string SelectCameraDevice()
    {
        if (WebCamTexture.devices.Length == 0)
            throw new Exception("Any camera isn't avaible!");

        foreach (var cam in WebCamTexture.devices)
        {
            if (!cam.isFrontFacing)
                return cam.name;
        }
        return WebCamTexture.devices[0].name;
    }

}
