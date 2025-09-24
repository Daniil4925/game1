using UnityEngine;
public enum RegionName
{
    Undefined,
    Left,
    Right,
    Center
}
[System.Serializable]
public class ScreenRegion
{
    public RegionName regionName;
    public ClickHandler RegionObject;
}
public class ScreenSpliter : MonoBehaviour
{
    [SerializeField] private ScreenRegion[] regions;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (ScreenRegion region in regions)
        {
            if (region.RegionObject.IsClick)
            {
                print(region.regionName);
            }
        }
    }
}
