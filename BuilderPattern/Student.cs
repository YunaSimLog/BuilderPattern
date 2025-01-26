using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Student
    {
        #region Attribute
        // -------------------------------------------------------------------------------------
        // * 초기화 필수 멤버
        private int _id;

        // * 초기화 선택적 멤버
        private string _name;
        private string _grade;
        private string _phone;
        // -------------------------------------------------------------------------------------
        #endregion

        #region Public
        public Student(int id, string name, string grade, string phone)
        {
            this._id = id;
            this._name = name;
            this._grade = grade;
            this._phone = phone;
        }
        #endregion
    }
}
