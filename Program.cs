class Program {
    static void Main(string[] args) {
       Console.WriteLine("Input the number of stalls open for rent: ");
        int n = int.Parse(Console.ReadLine());
        string[] stalls = new string[n];

        while (true) {
            Console.WriteLine("Input the stall number you want to reserve : ");
            int stallNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the stall number you want to reserve : ");
            int stallNumber2 = int.Parse(Console.ReadLine());
            if (stallNumber1 <= 0 || stallNumber2 <= 0) {
                if (stallNumber1 <= 0) {
                    stalls[stallNumber1] = "X" ;
                } else {
                    stalls[stallNumber2] = "X";
                }
            } else if (stallNumber1 <= 0 && stallNumber2 <= 0 ) {
                break;
            } else if (stallNumber1 == stallNumber2) {
                stalls[stallNumber1] = "X";
            } else {
                stalls[stallNumber1] = "X";
                stalls[stallNumber2] = "X";     
            }

        }
    }
}