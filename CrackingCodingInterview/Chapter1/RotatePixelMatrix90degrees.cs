using System;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.6"
        , Description = "Given an image represented by an NxN matrix, " +
                        "where each pixel in the image is 4 bytes, " +
                        "write a method to roatate image by 90 degrees. Can you do this in place?"
        )]
    public class RotatePixelMatrix90degrees : Algorithm<PixelMatrix, PixelMatrix>
    {
        protected override int? OnInitComplexity(PixelMatrix arg)
        {
            return arg.Size;
        }

        protected override PixelMatrix OnExecute(PixelMatrix arg)
        {   
            if (arg == null) 
                throw new ArgumentNullException("arg");

            var ret = (PixelMatrix)arg.Clone();
            var n = ret.Size;
            for(var layer = 0; layer < n /2 ; ++layer)
            {
                IncrementIteration();
                var first = layer;
                var last = n - 1 - layer;

                for (var i = first; i < last; i++)
                {
                    IncrementIteration();
                    var offset = i - first;

                    var top = ret.GetPixel(first, i);

                    ret.SetPixel(first, i, ret.GetPixel(last - offset, first));

                    ret.SetPixel(last - offset, first, ret.GetPixel(last, last - offset));

                    ret.SetPixel(last, last - offset, ret.GetPixel(i, last));

                    ret.SetPixel(i, last, top);
                }
            }

            return ret;
        }
    }

    public struct Pixel
    {
        public bool Equals(Pixel other)
        {
            return A == other.A && R == other.R && G == other.G && B == other.B;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = A.GetHashCode();
                hashCode = (hashCode*397) ^ R.GetHashCode();
                hashCode = (hashCode*397) ^ G.GetHashCode();
                hashCode = (hashCode*397) ^ B.GetHashCode();
                return hashCode;
            }
        }

        public Pixel(byte a, byte r, byte g, byte b) : this()
        {
            B = b;
            G = g;
            R = r;
            A = a;
        }

        public Pixel(int i)
            :this(
                    (byte)((i>>24)&Mask)
                    , (byte)((i >> 16) & Mask)
                    , (byte)((i >> 8) & Mask)
                    , (byte)(i & Mask))
        {
            
        }

        public byte A { get; private set; }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Pixel && Equals((Pixel) obj);
        }

        private const int Mask = 0xFF;
    }

    public sealed class PixelMatrix : ICloneable
    {
        private bool Equals(PixelMatrix other)
        {
            if (Size != other.Size) return false;

            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    if (!_pixels[i, j].Equals(other._pixels[i, j]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_pixels != null ? _pixels.GetHashCode() : 0)*397) ^ Size;
            }
        }

        private readonly Pixel[,] _pixels;

        public PixelMatrix(int size)
        {
            Size = size;
            _pixels = new Pixel[size,size];
        }

        public int Size { get; private set; }
        
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is PixelMatrix && Equals((PixelMatrix) obj);
        }

        public void SetPixel(int p0, int p1, Pixel p2)
        {
            _pixels[p0, p1] = p2;
        }

        public Pixel GetPixel(int p0, int p1)
        {
            return _pixels[p0, p1];
        }
    }
}
