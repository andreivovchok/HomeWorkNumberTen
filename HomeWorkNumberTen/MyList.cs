using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWorkNumberTen
{
    public class MyList : IList<MyItem>
    {
        private List<MyItem> _myItems = new List<MyItem>();

        public MyItem this[int index] 
        {
            get { return _myItems[index]; }
            set { _myItems[index] = value; }
        }

        public int Count 
        { 
            get { return _myItems.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(MyItem item)
        {
            _myItems.Add(item);
        }

        public void Clear()
        {
            _myItems.Clear();
        }

        public bool Contains(MyItem item)
        {
            return _myItems.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            _myItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return _myItems.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return _myItems.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            _myItems.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return _myItems.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _myItems.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _myItems.GetEnumerator();
        }
    }
}
