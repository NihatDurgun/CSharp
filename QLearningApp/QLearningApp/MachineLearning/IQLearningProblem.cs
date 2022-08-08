namespace QLearningApp.MachineLearning
{
    public interface IQLearningProblem
    {
        //void Rmatrisiuret();
        int NumberOfStates { get; }
        int NumberOfActions { get; }
        int[] GetValidActions(int currentState);
        double GetReward(int currentState, int action);
        bool GoalStateIsReached(int currentState,int endState);
    }
}
