using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassProject
{
    internal class File_IO_Management
    {

        //saves information to file
        public static void SaveData(string data)
        {
            FileStream outFile = new FileStream(Directory.GetCurrentDirectory() + "\\SaveData.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.Write(data);
            writer.Close();
            outFile.Close();
        }

        //creates and returns a register with data found in SaveData.txt
        public static Register CreateRegister()
        {
            Register register;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\SaveData.txt"))
            {
                FileStream inFile = new FileStream(Directory.GetCurrentDirectory() + "\\SaveData.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
                string data = reader.ReadLine();
                reader.Close();
                inFile.Close();
                string[] dataParsed = data.Split(',');
                int[] nums = new int[8];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(dataParsed[i]);
                }
                register = new Register(nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], nums[6], nums[7]);
            }
            else
            {
                register = new Register();
            }
            return register;
        }
    }
}
