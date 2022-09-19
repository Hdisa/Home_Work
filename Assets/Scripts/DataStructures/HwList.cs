using UnityEngine;

namespace DataStructures
{
    public class HwList : MonoBehaviour
    {
        private void Start()
        {
            _student.Add("a");
            _student.Add("b");
            _student.Add("c");
            _student.Add("d");
            _student.Remove(1);
            _student.Add("e");
            _student.Replace(0, "f");
            Debug.Log(_student[3]);
        }

        private readonly AltList _student = new AltList(4);
    }

    class AltList
    {
        private static int Length { get; set; }
        public AltList(int length)
        {
            Length = length;
        }
        public string this[int index] => _strArray[index];
        
        private readonly string[] _strArray = new string[Length];
        public void Add(string item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_strArray[i] == null)
                {
                    _strArray[i] = item;
                    break;
                }
            }
        }
        public void Remove(int index)
        {
            _strArray[index] = null;
        }

        public void Replace(int index, string item)
        {
            _strArray[index] = item;
        }
    }
}