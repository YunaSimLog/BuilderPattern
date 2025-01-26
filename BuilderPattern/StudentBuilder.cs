using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 빌더 클래스 예제
    /// </summary>
    internal class StudentBuilder
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

        #region public
        /// <summary>
        /// 생성자에 필수 멤버 값을 입력
        /// </summary>
        /// <param name="id"></param>
        public StudentBuilder(int id)
        {
            this._id = id;
        }

        // -------------------------------------------------------------------------------------
        // * 나머지 선택 멤버는 메서드로 설정
        //
        public StudentBuilder Name(string name)
        {
            this._name = name;
            return this;
        }

        public StudentBuilder Grade(string grade)
        {
            this._grade = grade;
            return this;
        }

        public StudentBuilder Phone(string phone)
        {
            this._phone = phone;
            return this;
        }
        // -------------------------------------------------------------------------------------

        /// <summary>
        /// Student 객체 생성
        /// </summary>
        /// <returns></returns>
        public Student Build()
        {
            return new Student(this._id, this._name, this._grade, this._phone);
        }

        #endregion
    }
}