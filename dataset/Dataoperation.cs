using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dataset
{

    public class Dataoperation
    {
        List<Digikalamodel> Records;
        public Dataoperation(List<Digikalamodel> Records)
        {
            this.Records = Records;
        }
        
        public void Oddnumber()
        {

            foreach (var record in Records)
            {
                int result = record.ID_Customer;
                if (result % 2 != 0)
                {
                    Fileandtext fp = new Fileandtext();
                    fp.Fileandtextprocessor("OddNumber", result);


                }
               
                        

            }
            

        }
        public void Primenumber()
        {
            int a = 0;
            foreach (var record in Records)
            {
                int number, i, m = 0, flag = 0;
                number = record.ID_Customer;
                m = number / 2;
                for (i = 2; i <= m; i++)
                {
                    if (number % i == 0)
                    {
                        
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    Fileandtext fp = new Fileandtext();
                    fp.Fileandtextprocessor("PrimeNumbers", number);
                }
            }
            

        }
        public void Mirrornumber()
        {
            foreach(var record in Records)
            {
                int number = record.ID_Customer;
                int temp = number;
                int reverse = 0;

                while (temp > 0)
                {
                    int remainder = temp % 10;
                    reverse = (reverse * 10) + remainder;
                    temp /= 10;
                }

                if (number == reverse)
                {
                    Fileandtext fp = new Fileandtext();
                    fp.Fileandtextprocessor("MirrorNumbers", number);
                }
                    
                else
                    ;
                    
            }
        }
        public bool IsOddAndPrime()
        {
            foreach(var record in Records)
            {
                int number = record.ID_Customer;
                if (number == 2)
                    return true;

                if (number % 2 == 0 || number < 2)
                    return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                    if (number % i == 0)
                        

                return true;
            }
            return false;
        }
        public  void OddAndPrime()
        {

            foreach (var record in Records)
            {
                int number = record.ID_Customer;
                if (number == 2)
                {
                    Fileandtext fp = new Fileandtext();
                    fp.Fileandtextprocessor("OddandPrime", number);
                }

                else if (number % 2 != 0 && IsPrime(number))
                {
                    Fileandtext fp = new Fileandtext();
                    fp.Fileandtextprocessor("OddandPrime", number);
                }

            }
            
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

    }
}   
        
