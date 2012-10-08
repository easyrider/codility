using System;
using System.Collections;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    public class CStyleString : IEnumerable<char>
    {
        public const char NullCharacter = '\0';
        private readonly Random _random = new Random();
        private readonly char[] _value;

        public CStyleString(string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            _value = value.ToCharArray();
        }

        public char this[int index]
        {
            get
            {
                int length = _value.Length;
                if (index < length)
                    return _value[index];
                if (index == length)
                    return NullCharacter;
                return (char) _random.Next(char.MinValue, char.MaxValue);
            }

            set { _value[index] = value; }
        }

        #region IEnumerable<char> Members

        public IEnumerator<char> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        public override string ToString()
        {
            return new string(_value);
        }

        #region Nested type: Enumerator

        private class Enumerator : IEnumerator<char>
        {
            private readonly CStyleString _str;
            private int _position;

            public Enumerator(CStyleString str)
            {
                if (str == null) throw new ArgumentNullException("str");
                _str = str;
                Reset();
            }

            #region IEnumerator<char> Members

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                _position++;
                return true;
            }

            public void Reset()
            {
                _position = -1;
            }

            public char Current
            {
                get { return _str[_position]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            #endregion
        }

        #endregion
    }
}