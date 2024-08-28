namespace PrisonerDilemnaGame
{
    internal class TitForTat
    {
        public int[] arr {  get; set; }
        public TitForTat(int[] array)
        {
            arr = array;
        }

        public int[] GoldBalance(string[] r, string[] b)
        {
            int[] arr = { 3, 3 };
            
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] == "share")
                {
                    if (b[i] == "share")
                    {
                        arr[0] += 2;
                        arr[1] += 2;
                    }
                    else
                    {
                        arr[0] -= 1;
                        arr[1] += 3;
                    }
                }
                else
                {
                    if (b[i] == "share")
                    {
                        arr[0] += 3;
                        arr[1] -= 1;
                    }
                }
            }
            return arr;
        }

    }
}
