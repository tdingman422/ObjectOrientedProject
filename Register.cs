using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    internal class Register
    {
        //variables
        private int twenties;
        private int tens;
        private int fives;
        private int ones;
        private int quarters;
        private int dimes;
        private int nickels;
        private int pennies;

        //default constructor
        public Register() {
            //sets initial number of each in register to zero
            twenties = 0; 
            tens = 0;
            fives = 0;
            ones = 0;
            quarters = 0;
            dimes = 0;
            nickels = 0;
            pennies = 0;
        }

        //constructor that sets amounts to passed values
        public Register(int tw, int te, int f, int o, int q, int d, int n, int p)
        {
            twenties = tw;
            tens = te;
            fives = f;
            ones = o;
            quarters = q;
            dimes = d;
            nickels = n;
            pennies = p;
        }

        //methods for finding amount needed of each type
        public int NumTwenties(double amount) {
            int count = 0;
            while (amount >= 20 && count <= twenties)
            {
                count++;
                amount -= 20;
                //fixes float precission issues
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumTens(double amount) {
            int count = 0;
            while (amount >= 10 && count <= tens)
            {
                count++;
                amount -= 10;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumFives(double amount) {
            int count = 0;
            while (amount >= 5 && count <= fives)
            {
                count++;
                amount -= 5;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumOnes(double amount)
        {
            int count = 0;
            while (amount >= 1 && count <= ones)
            {
                count++;
                amount -= 1;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumQuarters(double amount)
        {
            int count = 0;
            while (amount >= 0.25 && count <= quarters)
            {
                count++;
                amount -= 0.25;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumDimes(double amount)
        {
            int count = 0;
            while (amount >= 0.1 && count <= dimes)
            {
                count++;
                amount -= 0.1;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumNickels(double amount)
        {
            int count = 0;
            while (amount >= 0.05 && count <= nickels)
            {
                count++;
                amount -= 0.05;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        public int NumPennies(double amount)
        {
            int count = 0;
            while (amount >= 0.01 && count <= pennies)
            {
                count++;
                amount -= 0.01;
                amount = Math.Round(amount, 2, MidpointRounding.AwayFromZero);
            }
            return count;
        }

        //getters
        public int GetTwenties()
        { 
            return twenties; 
        }

        public int GetTens() 
        { 
            return tens; 
        }

        public int GetFives() 
        {
            return fives;
        }

        public int GetOnes()
        {
            return ones;
        }

        public int GetQuarters()
        {
            return quarters;
        }

        public int GetDimes()
        {
            return dimes;
        }

        public int GetNickels()
        {
            return nickels;
        }

        public int GetPennies()
        {
            return pennies;
        }

        //setters
        public void SetTwenties(int amount)
        {
            twenties = amount;
        }

        public void SetTens(int amount)
        {
            tens = amount;
        }

        public void SetFives(int amount)
        {
            fives = amount;
        }

        public void SetOnes(int amount) 
        {  
            ones = amount; 
        }

        public void SetQuarters(int amount)
        {
            quarters = amount;
        }

        public void SetDimes(int amount)
        {
            dimes = amount;
        }

        public void SetNickels(int amount)
        {
            nickels = amount;
        }

        public void SetPennies(int amount)
        {
            pennies = amount;
        }

        //incrementers
        public void IncrementTwenties(int amount)
        {
            twenties += amount;
        }

        public void IncrementTens(int amount)
        {
            tens += amount;
        }

        public void IncrementFives(int amount)
        {
            fives += amount;
        }

        public void IncrementOnes(int amount)
        {
            ones += amount;
        }

        public void IncrementQuarters(int amount)
        {
            quarters += amount;
        }

        public void IncrementDimes(int amount)
        {
            dimes += amount;
        }

        public void IncrementNickles(int amount)
        {
            nickels += amount;
        }

        public void IncrementPennies(int amount)
        {
            pennies += amount;
        }

        //decrementors
        public void DecrementTwenties(int amount)
        {
            twenties -= amount;
        }

        public void DecrementTens(int amount)
        {
            tens -= amount;
        }

        public void DecrementFives(int amount)
        {
            fives -= amount;
        }

        public void DecrementOnes(int amount)
        {
            ones -= amount;
        }

        public void DecrementQuarters(int amount)
        {
            quarters -= amount;
        }

        public void DecrementDimes(int amount)
        {
            dimes -= amount;
        }

        public void DecrementNickels(int amount)
        {
            nickels -= amount;
        }

        public void DecrementPennies(int amount)
        {
            pennies -= amount;
        }
    }
}
