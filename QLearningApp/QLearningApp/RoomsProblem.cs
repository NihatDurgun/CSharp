using QLearningApp.MachineLearning;
using System.Collections.Generic;
using System;

namespace QLearningApp
{
    class RoomsProblem : IQLearningProblem
    {
        int[] engel;
        int endState;
        public RoomsProblem(int[] engel,int endState){
            this.engel = engel;
            this.endState = endState;
        }
        
        public int[,] Rmatrisiuret(int[] engel)
        { 
            int[,] matris = new int[4, 4];
            int[,] matris2 = new int[16, 16];
            int x = 0;
            int kutunumara;
            int kutunumara2; 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kutunumara = (i * 4) + j;
                    kutunumara2 = (i * 4) + j;

                    for (int y = 0; y < 16; y++)
                    {
                        matris2[x, y] = -1;
                    }
                    if (kutunumara + 1 < 16)
                    {
                        matris2[x, kutunumara + 1] = 0;
                        if (kutunumara + 1 == this.endState)
                        {
                            matris2[x, kutunumara + 1] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara + 1 == engel[gama])
                            {
                                matris2[x, kutunumara + 1] = -50;
                            }
                        }

                    }
                    if (kutunumara - 1 >= 0)
                    {
                        matris2[x, kutunumara - 1] = 0;
                        if (kutunumara - 1 == this.endState)
                        {
                            matris2[x, kutunumara - 1] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara - 1 == engel[gama])
                            {
                                matris2[x, kutunumara - 1] = -50;
                            }
                        }
                    }
                    if (kutunumara + 4 < 16)
                    {
                        matris2[x, kutunumara + 4] = 0;
                        if (kutunumara + 4 == this.endState)
                        {
                            matris2[x, kutunumara + 4] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara + 4 == engel[gama])
                            {
                                matris2[x, kutunumara + 4] = -50;
                            }
                        }
                    }
                    if (kutunumara - 4 >= 0)
                    {
                        matris2[x, kutunumara - 4] = 0;
                        if (kutunumara - 4 == this.endState)
                        {
                            matris2[x, kutunumara - 4] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara - 4 == engel[gama])
                            {
                                matris2[x, kutunumara - 4] = -50;
                            }
                        }
                    }
                    if (kutunumara2 - 3 < 16 && kutunumara2 != 0 && kutunumara2 != 1 && kutunumara2 != 2 && kutunumara2 != 3 && kutunumara2 != 7 && kutunumara2 != 11 && kutunumara2 != 15) //sağ üst çapraz
                    {
                        matris2[x, kutunumara2 - 3] = 0;
                        if (kutunumara2 - 3 == this.endState)
                        {
                            matris2[x, kutunumara2 - 3] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara2 - 3 == engel[gama])
                            {
                                matris2[x, kutunumara2 - 3] = -50;
                            }
                        }
                    }
                    if (kutunumara2 - 5 < 16 && kutunumara2 != 0 && kutunumara2 != 1 && kutunumara2 != 2 && kutunumara2 != 3 && kutunumara2 != 4 && kutunumara2 != 8 && kutunumara2 != 12) //sol üst çapraz
                    {
                        matris2[x, kutunumara2 - 5] = 0;
                        if (kutunumara2 - 5 == this.endState)
                        {
                            matris2[x, kutunumara2 - 5] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara2 - 5 == engel[gama])
                            {
                                matris2[x, kutunumara2 -5] = -50;
                            }
                        }
                    }
                    if (kutunumara2 + 5 >= 0 && kutunumara2 != 3 && kutunumara2 != 7 && kutunumara2 != 11 && kutunumara2 != 12 && kutunumara2 != 13 && kutunumara2 != 014 && kutunumara2 != 14 && kutunumara2 != 15)//sağ alt çapraz
                    {
                        matris2[x, kutunumara2 + 5] = 0;//sol alt çapraz
                        if (kutunumara2 + 5 == this.endState)
                        {
                            matris2[x, kutunumara2 + 5] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara2 + 5 == engel[gama])
                            {
                                matris2[x, kutunumara2 + 5] = -50;
                            }
                        }
                    }
                    if (kutunumara2 + 3 >= 0 && kutunumara2 != 0 && kutunumara2 != 4 && kutunumara2 != 8 && kutunumara2 != 12 && kutunumara2 != 13 && kutunumara2 != 14 && kutunumara2 != 15)
                    {
                        matris2[x, kutunumara2 + 3] = 0;
                        if (kutunumara2 + 3 == this.endState)
                        {
                            matris2[x, kutunumara2 + 3] = 100;
                        }
                        for (int gama = 0; gama < 4; gama++)
                        {
                            if (kutunumara2 + 3 == engel[gama])
                            {
                                matris2[x, kutunumara2 + 3] = -50;
                            }
                        }
                    }
                    x++;
                }

            }

            return matris2;
        }

        public int NumberOfStates => 16;

        public int NumberOfActions => 16;

        public double GetReward(int currentState, int action)
        {

            int[,] matris2 =Rmatrisiuret(this.engel);
            return matris2[currentState,action];
        } 

        public int[] GetValidActions(int currentState)
        {
            int[,] matris2 = Rmatrisiuret(this.engel);
            List<int> validActions = new List<int>();
            for (int i = 0; i < matris2.GetLength(1); i++)
            {
                if (matris2[currentState,i] != -1)
                    validActions.Add(i);
            }
            return validActions.ToArray();
        }

        public bool GoalStateIsReached(int currentState,int endState)
        {
            return currentState == endState;
        }
    }
}
