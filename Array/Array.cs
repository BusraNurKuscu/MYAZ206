using System.Collections;

namespace Array
{
    public class Array  : ICloneable, IEnumerable
    {
        private Object[] innerArr { get; set; }
         public int Lengt => innerArr.Length;   
        public Array(int defaultSize =16)
        {
           innerArr = new Object[defaultSize];

        }
        public Array(params Object[] sourceArrays) : this(sourceArrays.Length)
        {
            System.Array.Copy(sourceArrays, innerArr, sourceArrays.Length);
            //int c = 0;
            //foreach (var source in sourceArrays)
            //{
            //    innerArr[c] = source;
            //    c++;
            //}
        }
        public void SetValue(Object value, int index)
        {    
            // aralık dışını kontrol eder
            if (!(index >= 0 && index < innerArr.Length))
                throw new ArgumentException();

            //boş değeri kontrol eder
            if (value == null)
                throw new ArgumentNullException();
            innerArr[index] = value;
            return;
        }

        public void CheckOutKeyWordRef(out int variable)
        {
            variable = 100;
            return;
        }
        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < innerArr.Length))
                throw new ArgumentException();
            return innerArr[index];
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        public IEnumerator GetEnumerator()
        {
            return innerArr.GetEnumerator();
           //return new CustomArrayEnumerator(innerArr);
        }
    }
}