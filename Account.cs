        public class Account
    {
        public int currentbalance;
        public int id;
        public int totalbalance;
        public int fee;
        public Account(int currentbalance, int id, int totalbalance,int fee)
        {
            this.currentbalance = currentbalance;
            this.id = id;
            this.totalbalance = totalbalance;
            this.fee = fee;
        }
        public int getid()
        {
         return id; 
        }
       public int withdraw(int currentbaalance,int totalbalance)
        {
            int withdraw = totalbalance - currentbaalance;
            if (currentbaalance > totalbalance)
            {
               
                Console.WriteLine($"Withdrawal amount is:{withdraw}");
            }
            else
            {
                Console.WriteLine("Withdraw impossible");
            }
            return withdraw;
        }
        public int diposit(int currentbaalance, int totalbalance)
        {
            int diposit = totalbalance + currentbaalance;

            Console.WriteLine($"The diposited balance is:{diposit}");

            return diposit;
        }
        public (int,int) display(int id,int fee)
        {
            int fee2 = id * fee;
            Console.WriteLine($"The fee of participant is:{fee2}");
            return (id, fee2);
        }
        public void checkvalidity(int currentbalance)
        {
            if (currentbalance <= 0)
            {
                Console.WriteLine("Valid Account");
            }
            else
            {
                Console.WriteLine("Invalid Account!");
            }
        }
        public int gettotalbalance(int currrentbalace)
        {
            int totalbalance = currentbalance * 12;
            return totalbalance;
        }
        public int getcurrentbalance(int currrentbalace)
        {
            return currentbalance;
        }
        public int getfee3(int currrentbalace, int totalbalance)
        {
            int fee3=currentbalance/totalbalance;
            Console.WriteLine($"The fee is:{fee}");
            return fee3;
        }
        public int getfee()
        {
            return fee * 45;
        }
    }
}
