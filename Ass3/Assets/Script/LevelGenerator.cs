using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject[] wall;
    public int X;
    public int Y;

    int[,] levelMap =
{
    {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
    {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
    {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
    {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
    {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
    {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
    {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
    {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
    {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
    {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };


    // Start is called before the first frame update
    void Start()
    {
        wallGene();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void wallGene()
    {
        for (int i = 0; i < levelMap.GetLength(1); i++)
        {
            for (int j = 0; j < levelMap.GetLength(0); i++)
            {
                Vector3 vector3 = new Vector3(i, -j, 0);
                GameObject gameObject = Instantiate(wall[levelMap[j, i]], vector3, Quaternion.identity);

                //switch (j)
                //{
                //    case 0:
                //        if(i>=1 && i < 13)
                //        {
                //            gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);    
                //        }
                //    case 2:
                //        break;
                //}

                if (j == 0)
                {
                    if (i >= 1 && i < 13)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                }

                if (j == 2)
                {
                    if ((i >= 3 && i < 5) || (i >= 8 && i < 11))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 5 || i == 11)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);

                    }
                }

                if (j == 4)
                {
                    if ((i >= 2 && i < 5) || (i >= 7 && i < 11) || i == 13)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 5 || i == 11)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                    }
                }

                if (j == 6)
                {
                    if ((i >= 3 && i < 5) || (i >= 11 && i < 14))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 5 || i == 8)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    }
                }

                if (j == 7)
                {
                    if ((i >= 2 && i < 5) || (i >= 10 && i < 13))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 13)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    }
                    else if (i == 5)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                    }
                }

                if (j == 9)
                {
                    if ((i >= 0 && i < 5) || (i >= 8 && i < 11))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 5 || i == 11)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    }
                }

                if (j == 10)
                {
                    if ((i >= 9 && i < 11) || (i == 13))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 11)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                    }
                }

                if (j == 12)
                {
                    if (i >= 11 && i < 13)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                }

                if (j == 13)
                {
                    if ((i >= 0 && i < 5) || (i == 7))
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    }
                    else if (i == 5 || i == 8)
                    {
                        gameObject.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                    }
                }
            }

        }
    }
}
