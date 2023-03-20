using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelTon
{
    internal class thredMockdata3
    {
        List<studunt> list;
        thredMockdata3()
        {
            List = getdata();
        }
        public static thredMockdata3 Instance
        { get { return nestedClass.mockData; } }


        internal List<studunt> List { get => list; set => list = value; }

        private List<studunt> getdata()
        {
            //נגיד שמעלים נתונים מקובץ
            List = new List<studunt>();
            list.Add(new studunt() { Id = 1001, Name = "Tamar" });
            list.Add(new studunt() { Id = 1002, Name = "Sara" });
            list.Add(new studunt() { Id = 1003, Name = "Lea" });

            for (int i = 0; i < 10000; i++)
            {
                List.Add(new studunt() { Id = i });
            }
            return List;
        }

        private class nestedClass
        {
            static nestedClass()
            {
            }
            public static readonly thredMockdata3 mockData = new thredMockdata3();
        }
    }

}

