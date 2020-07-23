using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vier_gewinnt_Logic
{
    public class VierGewinntController
    {
        Dictionary<int, List<int>> ColumnRowList = new Dictionary<int, List<int>>();
        int column = 7;
        int row = 6;

        public void createNewDictionary()
        {
            ColumnRowList.Clear();
            List<int> rows = new List<int>();
            for (int i = 0; i < row; i++)
            {
                rows.Add(0);
            };
            for (int i = 0; i < column; i++)
            {
                ColumnRowList.Add(i, rows.ToList());
                //row.ToList --> neue Instanz der rows-List
            }
        }

        public int? checkThrowIn(int column, int player)
        {
            int? row = null;

            if (ColumnRowList[column].Any(c => c == 0))
            {
                row = ColumnRowList[column].IndexOf(0);
                ColumnRowList[column][ColumnRowList[column].IndexOf(0)] = player;
            }
            


            //for (int i = 0; i < ColumnRowList[column].Count; i++)
            //{
            //    if (ColumnRowList[column][i] == 0)
            //    {
            //        ColumnRowList[column][i] = player;
            //        break;
            //    }
            //}

            //var value = ColumnRowList.Where(x => x.Key == column)
            //    .Select(x => x.Value).FirstOrDefault();
            //for (int i = 0; i < value.Count; i++)
            //{
            //    if(value[i] == 0)
            //    {
            //        value[i] = player;
            //    }

            //}
            return row;
        }

        public int CheckFourInRow()
        {
            int playerWin = 0;
            int count = 0;
            for (int c = 0; c < column; c++)
            {
                count = 0;
                for (int r = 0; r < row; r++)
                {
                    var player = ColumnRowList[c][r];
                    if (player > 0)
                    {
                        if (playerWin == player)
                        {
                            count++;
                        }
                        else
                        {
                            playerWin = player;
                            count = 1;
                        }
                    }
                    else
                    {
                        playerWin = 0;
                        count = 0;
                    }
                    if (count == 4)
                        break;
                }
                if (count == 4)
                    break;
            }
            if (count < 4)
            {
                playerWin = 0;
                count = 0;
                for (int r = 0; r < row; r++)
                {
                    count = 0;
                    for (int c = 0; c < column; c++)
                    {
                        var player = ColumnRowList[c][r];
                        if (player > 0)
                        {
                            if (playerWin == player)
                            {
                                count++;
                            }
                            else
                            {
                                playerWin = player;
                                count = 1;
                            }
                        }
                        else
                        {
                            playerWin = 0;
                            count = 0;
                        }
                        if (count == 4)
                            break;
                    }
                    if (count == 4)
                        break;
                }
            }
            if (count < 4)
            {
                playerWin = 0;
                count = 0;
                int row1 = row;
                for (int c = -2; c < 4; c++)
                {
                    if (c > 1)
                        row1--;
                    int q = c;
                    count = 0;
                    for (int r = 0; r < row1; r++)
                    {
                        if (q >= 0)
                        {
                            var player = ColumnRowList[q][r];
                            if (player > 0)
                            {
                                if (playerWin == player)
                                {
                                    count++;
                                }
                                else
                                {
                                    playerWin = player;
                                    count = 1;
                                }
                            }
                            else
                            {
                                playerWin = 0;
                                count = 0;
                            }
                        }
                        q++;
                        if (count == 4)
                            break;
                    }
                    if (count == 4)
                        break;
                }
            }
            if (count < 4)
            {
                playerWin = 0;
                count = 0;
                int rowMin = 0;
                for (int c = -2; c < 4; c++)
                {
                    if (c > 1)
                        rowMin++; ;
                    int q = c;
                    count = 0;
                    for (int r = row - 1; r >= rowMin; r--)
                    {
                        if (q >= 0)
                        {
                            var player = ColumnRowList[q][r];
                            if (player > 0)
                            {
                                if (playerWin == player)
                                {
                                    count++;
                                }
                                else
                                {
                                    playerWin = player;
                                    count = 1;
                                }
                            }
                            else
                            {
                                playerWin = 0;
                                count = 0;
                            }
                        }
                        q++;
                        if (count == 4)
                            break;
                    }
                    if (count == 4)
                        break;
                }
            }
            if (count < 4)
                playerWin = 0;
            return playerWin;
        }
    }
}
