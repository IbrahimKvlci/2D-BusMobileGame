using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PathManager : MonoBehaviour, IPathService
{
    List<IPath> paths;

    private void Awake()
    {
        paths = FindObjectsOfType<MonoBehaviour>(false).OfType<IPath>().ToList();
    }

    public bool PathIsDone()
    {
        foreach (var path in paths)
        {
            if (!path.IsTherePath) return false;
        }
        foreach (var path in paths)
        {
            path.CanDraw = false;
        }
        return true;
    }
}
