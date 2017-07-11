using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July11,2017
 * Description-This is the Driver Class for my project
 * Version- 0.1 - Instanti
 */
namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super Dude");
            superhuman.Powers.Add(new Power("Teleportation",  50));
            superhuman.DisplayPowers();
        }
    }
}
