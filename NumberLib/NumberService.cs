namespace NumberLib
{
    public class NumberService
    {
        public bool isEven(int value)
        {
            if (value % 2 == 1)
            {
                return false;
            }

            return true;
        }
    }
}