using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_
{
    class CMyClass
    {
        public int theStudentCount;
        public string theName;
        public int theGrade;

        public CMyClass() 
        {
            theGrade = 0;
        }

        public CMyClass(int aGrade)
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = aGrade;
        }

        public CMyClass(int aGrade, string aName):this() //생성자 위에 것으로 자동 적용!!!! java와 좀 다르다
        {
            theName = aName;
            theGrade = aGrade;
        }

        public string GetName()
        {
            string res = string.Format("{0}학년 {1}, {2}명", theGrade, theName, theStudentCount);
            return (res);
        }

        public void Increase(int aValue)
        {
            aValue++;
        }

        public void Increase(ref int aValue) //ref : 값이 바뀔 수 있구나!!!! 파악 가능 //pointer
        {
            aValue++;
        }

        public void MakeValue(out int aValue) //out : 대입하는거. 무조건 생성(할당)해야됨
        {
            aValue = 19;
        }
    }
}
