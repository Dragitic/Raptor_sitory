namespace Login
{
    public class UserValidator : IUserValidator
    {
        public void CheckIfUserCanVote()
        {
            CheckIfThisUserVoted();
            CheckBlackList();
        }

        private void CheckBlackList()
        {
            throw new System.NotImplementedException();
        }

        private void CheckIfThisUserVoted()
        {
            throw new System.NotImplementedException();
        }
    }
}