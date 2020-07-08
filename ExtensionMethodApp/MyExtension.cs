namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int expinent)
        {
            int result = myInt;
            for (int i = 1; i < expinent; i++)
            {
                result *= myInt;
            }
            return result;
        }
    }
}