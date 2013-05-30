using System;

namespace GenericVariant
{
    public sealed class Variant<T1>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1> C1(T1 v1)
        {
            var v =new Variant<T1>();
            v.label=1; v.value1 = v1;
            return v;
        }

        public T Match<T>(Func<T1, T> C1)
        {
            switch (this.label)
            {
                default: return C1(this.value1);
            }
        }
    }
    public sealed class Variant<T1,T2>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2> C1(T1 v1)
        {
            var v =new Variant<T1,T2>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2> C2(T2 v2)
        {
            var v =new Variant<T1,T2>();
            v.label=2; v.value2 = v2;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
                default: return C2(this.value2);
            }
        }
    }
    public sealed class Variant<T1,T2,T3>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=3; v.value3 = v3;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
                default: return C3(this.value3);
            }
        }
    }
    public sealed class Variant<T1,T2,T3,T4>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3,T4> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3,T4> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3,T4> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=3; v.value3 = v3;
            return v;
        }
        private T4 value4;
        public static Variant<T1,T2,T3,T4> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=4; v.value4 = v4;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
				case 3: return C3(this.value3);
                default: return C4(this.value4);
            }
        }
    }
    public sealed class Variant<T1,T2,T3,T4,T5>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=3; v.value3 = v3;
            return v;
        }
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=4; v.value4 = v4;
            return v;
        }
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=5; v.value5 = v5;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
				case 3: return C3(this.value3);
				case 4: return C4(this.value4);
                default: return C5(this.value5);
            }
        }
    }
    public sealed class Variant<T1,T2,T3,T4,T5,T6>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=3; v.value3 = v3;
            return v;
        }
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=4; v.value4 = v4;
            return v;
        }
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=5; v.value5 = v5;
            return v;
        }
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=6; v.value6 = v6;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
				case 3: return C3(this.value3);
				case 4: return C4(this.value4);
				case 5: return C5(this.value5);
                default: return C6(this.value6);
            }
        }
    }
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=3; v.value3 = v3;
            return v;
        }
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=4; v.value4 = v4;
            return v;
        }
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=5; v.value5 = v5;
            return v;
        }
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=6; v.value6 = v6;
            return v;
        }
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=7; v.value7 = v7;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
				case 3: return C3(this.value3);
				case 4: return C4(this.value4);
				case 5: return C5(this.value5);
				case 6: return C6(this.value6);
                default: return C7(this.value7);
            }
        }
    }
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8>
    {
        private Variant(){}
        private int label;
		
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=1; v.value1 = v1;
            return v;
        }
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=2; v.value2 = v2;
            return v;
        }
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=3; v.value3 = v3;
            return v;
        }
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=4; v.value4 = v4;
            return v;
        }
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=5; v.value5 = v5;
            return v;
        }
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=6; v.value6 = v6;
            return v;
        }
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=7; v.value7 = v7;
            return v;
        }
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=8; v.value8 = v8;
            return v;
        }

        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8)
        {
            switch (this.label)
            {
				case 1: return C1(this.value1);
				case 2: return C2(this.value2);
				case 3: return C3(this.value3);
				case 4: return C4(this.value4);
				case 5: return C5(this.value5);
				case 6: return C6(this.value6);
				case 7: return C7(this.value7);
                default: return C8(this.value8);
            }
        }
    }
}

