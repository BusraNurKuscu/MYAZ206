using System.Collections;

namespace Array
{
    public class Array  : ICloneable, IEnumerable
    {
        private Object[] InnerArr { get; set; }
         public int Lengt => InnerArr.Length;   
        public Array(int defaultSize =16)
        {
           InnerArr = new Object[defaultSize];

        }
        public Array(params Object[] sourceArrays) : this(sourceArrays.Length)
        {
            System.Array.Copy(sourceArrays, InnerArr, sourceArrays.Length);
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
            if (!(index >= 0 && index < InnerArr.Length))
                throw new ArgumentException();

            //boş değeri kontrol eder
            if (value == null)
                throw new ArgumentNullException();
            InnerArr[index] = value;
            return;
        }

        public void CheckOutKeyWordRef(out int variable)
        {
            variable = 100;
            return;
        }
        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArr.Length))
                throw new ArgumentException();
            return InnerArr[index];
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        public IEnumerator GetEnumerator()
        {
            return InnerArr.GetEnumerator();
           //return new CustomArrayEnumerator(innerArr);
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < InnerArr.Length; i++)
            {
                     if(InnerArr[i].Equals (value))
                    return i;
            }
            return -1;
        }
    }
}