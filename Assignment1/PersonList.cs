using System.Collections;
using System.Collections.Generic;
using Assignment1.IO;

namespace Assignment1
{
    /// <summary>
    /// Bank individual Set
    /// 
    /// Among other things, this class includes an example of how to deserialize a whole list of bank individual objects from a file
    /// </summary>
    public class PersonList : IEnumerable<Person>
    {
        private List<Person> _listOfPeople = new List<Person>();

        public ImportExporterStrategy StorageStrategy { get; set; }

        public void Add(Person individual)
        {
            if (individual != null)
                _listOfPeople.Add(individual);
        }

        public void Load(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename) && StorageStrategy != null)
                _listOfPeople = StorageStrategy.Load(filename);
        }

        public void Save(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename) && StorageStrategy != null)
                StorageStrategy.Save(filename, _listOfPeople);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return _listOfPeople.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonEnum(_listOfPeople.ToArray());
        }
    }

    public class PersonEnum : IEnumerator
    {
        private readonly Person[] _listOfPeople;
        private int _currentPosition = -1;

        public PersonEnum(Person[] listOfPeople)
        {
            _listOfPeople = listOfPeople;
        }

        public bool MoveNext()
        {
            return (++_currentPosition < _listOfPeople.Length);
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        object IEnumerator.Current { get { return Current; } }

        public Person Current
        {
            get
            {
                return (_currentPosition >= 0 && _currentPosition < _listOfPeople.Length) ? _listOfPeople[_currentPosition] : null;
            }
        }
    }

}
