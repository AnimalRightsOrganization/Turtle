﻿/* UI层解析消息后，传给本3d对象管理器。
 * 本管理器执行那种颜色，走几步的操作。
 */
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DG.Tweening;

[CustomEditor(typeof(MapManager))]
public class DemoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector(); //显示默认所有参数

        MapManager demo = (MapManager)target;

        if (GUILayout.Button("+1"))
        {
            demo.Move1(demo.selectedTurtle, 1);
        }
        if (GUILayout.Button("+2"))
        {
            demo.Move2(demo.selectedTurtle);
        }
        if (GUILayout.Button("-1"))
        {
            demo.Move1(demo.selectedTurtle, -1);
        }


        if (GUILayout.Button("PlayCard"))
        {
            demo.PlayCard();
        }
    }
}
public enum TurtleColor
{
    NONE = -1, //未指定的
    RED = 0,
    YELLOW = 1,
    GREEN = 2,
    BLUE = 3,
    PURPLE = 4,
    COUNT = 5,
}
public class MapManager : MonoBehaviour
{
    static MapManager _instance;
    public static MapManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<MapManager>();
            return _instance;
        }
    }

    public const float TURTLE_HEIGHT = 0.25f;

    public bool IsLock = false;

    public Transform Map;
    public Transform[] Rock;
    public Transform[] Turtle;
    public RectTransform[] Hands;
    public List<RectTransform> HandCards;
    public Transform DeskCards;

    // 记录每个格子中的乌龟，及顺序（从下到上）
    //key:格子ID  value:乌龟，及顺序
    public List<int>[] GridData;
    // 查询某乌龟当前所在格子
    //key:乌龟颜色  value:格子ID
    public int[] TurtlePos;

    public void InitAssets()
    {
        //var map_asset = ResManager.LoadPrefab("Prefabs/Map");
        //Map = Instantiate(map_asset).transform;
        Map = transform.Find("Map");
        //Map.name = "Map";
        Rock = new Transform[10];
        for (int i = 0; i < Map.childCount; i++)
        {
            var item = Map.GetChild(i);
            Rock[i] = item;
        }

        //var turtle_asset = ResManager.LoadPrefab("Prefabs/Turtle");
        Turtle = new Transform[5];
        var turtles = transform.Find("Turtles");
        for (int i = 0; i < turtles.childCount; i++)
        {
            //var obj = Instantiate(turtle_asset);
            //obj.name = $"Turtle_{i}";
            var item = turtles.GetChild(i);
            Turtle[i] = item.transform;
        }
    }
    public void InitData()
    {
        // 起点有5只龟
        GridData = new List<int>[10];
        for (int i = 0; i < 10; i++)
        {
            GridData[i] = new List<int>();
        }
        GridData[0] = new List<int> { 0, 1, 2, 3, 4 };

        // 5只龟在起点
        TurtlePos = new int[5];
        TurtlePos[0] = 0;
        TurtlePos[1] = 0;
        TurtlePos[2] = 0;
        TurtlePos[3] = 0;
        TurtlePos[4] = 0;
    }
    public void Dispose()
    {
        Destroy(Map.gameObject);
        for (int i = Turtle.Length - 1; i >= 0; i--)
        {
            var obj = Turtle[i].gameObject;
            Destroy(obj);
        }
    }

    public Tweener Move1(TurtleColor turtle, int step)
    {
        Tweener tw = null;
        if (IsLock)
        {
            Debug.LogError("移动中...稍后再试");
            return tw;
        }

        // 数据层计算
        int turtle_id = (int)turtle;
        int src_id = TurtlePos[turtle_id];
        if (src_id >= 9)
        {
            Debug.LogError("已经到达终点");
            return tw;
        }
        int dest_id = src_id + step;
        if (dest_id < 0)
        {
            Debug.LogError("已经在起点");
            return tw;
        }
        Vector3 dest_pos = Rock[dest_id].position;

        // 数据层修改
        TurtlePos[turtle_id] = dest_id; //乌龟移动到新的格子
        GridData[src_id].Remove(turtle_id); //原格子删除它
        GridData[dest_id].Add(turtle_id); //新格子加入它


        //TODO: 曡在上层的乌龟，也要移动


        // 表现层计算高度
        int dest_count = GridData[dest_id].Count;
        dest_pos.y = TURTLE_HEIGHT * dest_count;

        // 表现层修改
        tw = Turtle[turtle_id].DOMove(dest_pos, 0.5f);
        tw.OnPlay(() =>
        {
            IsLock = true;
        });
        tw.OnComplete(() =>
        {
            IsLock = false;
        });
        return tw;
    }
    public void Move2(TurtleColor turtle)
    {
        //TODO:
        //~~①Inspector上显示字典。~~
        //~~②走完叠起来。~~
        //~~③后退。~~
        //~~④移动两格。~~
        //⑤叠起来走。抽取区间。

        var tw = Move1(turtle, 1);
        //这里再次注册委托，相当于把Move1里面的委托覆盖了
        tw.OnPlay(() =>
        {
            IsLock = true;
        });
        tw.OnComplete(() =>
        {
            IsLock = false;

            Move1(turtle, 1);
        });
    }

    public RectTransform ui_game;
    public void PlayCard()
    {
        var cgroup = HandCards[selectedCard].GetComponent<CanvasGroup>();

        var dest = ui_game.position;
        var tw1 = cgroup.transform.DOMove(dest, 0.5f);
        //tw1.SetDelay(1); //延迟出牌
        tw1.OnComplete(() =>
        {
            var tw2 = cgroup.DOFade(0, 0.5f);
            tw2.SetDelay(1); //延迟消失
            tw2.OnComplete(() =>
            {
                HandCards[selectedCard].SetParent(DeskCards);
                HandCards.RemoveAt(selectedCard);
                SortHandCards();
            });
        });
    }

    void SortHandCards()
    {
        for (int i = 0; i < Hands.Length; i++)
        {
            var handSlot = Hands[i];
            var handCard = HandCards[i];
            handCard.SetParent(handSlot);
            handCard.localPosition = Vector3.zero;
        }
    }





    void Start()
    {
        //InitAssets();
        InitData();
    }
    public TurtleColor selectedTurtle;
    public int selectedCard;
}