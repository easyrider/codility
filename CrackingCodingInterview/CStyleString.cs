using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCodingInterview
{
    public class CStyleString : IEnumerable<char>
    {
        public const char NullCharacter = '\0';
        private readonly Random _random = new Random();
        private char[] _value;

        public CStyleString(string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            var length = value.Length;
            _value = new char[length + 1];
            Array.Copy(value.ToCharArray(), _value, length);
            _value[length] = NullCharacter;
        }

        public char this[int index]
        {
            get
            {
                var length = _value.Length;
                if (index < length)
                    return _value[index];
                return (char) _random.Next(char.MinValue, char.MaxValue);
            }

            set
            {
                if (index < _value.Length)
                {
                    _value[index] = value;    
                }
                else if (index >= _value.Length)
                {
                    var tmp = new char[index + 1];
                    _value.CopyTo(tmp, 0);
                    tmp[index] = value;
                    _value = tmp;
                } 
                else throw new NotImplementedException();
            }
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
            return new string(_value.TakeWhile(x=>x != NullCharacter).ToArray());
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