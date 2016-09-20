namespace Login
{
    public class VoterValidator : IVoterValidator
    {
        public void CheckIfUserCanVote()
        {
            CheckIfThisUserVoted();
            CheckBlackList();
        }
        private void CheckIfThisUserVoted()
        {
            // sprawdza bazę czy już głosował, jeśli tak to break; MessageBox
        }
        private void CheckBlackList()
        {
            // sprawdza czarną listę, jeśli jest to break; MessageBox
        }

    }
}