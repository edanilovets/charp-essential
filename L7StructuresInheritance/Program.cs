using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Структруры. Наследование
//Наследование структур разрешено только от интерфейсов
//Наследование структур от классов и структур запрещено

namespace L7StructuresInheritance
{
    //Наследование структур разрешено только от интерфейсов
    struct MyStruct : ICloneable
    {
        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}