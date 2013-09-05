using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericVariant;
using Extensions;

namespace Usage
{
    //Option<T> = Variant<Unit,T>
    //実体をVariantに委譲している
    //(或いは無名のバリアントに名前をつけているとも言えるかも)
    public sealed class Option<T>
    {
        private Option() { }
        private Variant<Unit, T> variant;
        public static Option<T> None()
        {
            //このへんがダサい
            var option = new Option<T>();
            option.variant = Variant<Unit, T>.C1(Unit.New());
            return option;
        }
        public static Option<T> Some(T a)
        {
            var option = new Option<T>();
            option.variant = Variant<Unit, T>.C2(a);
            return option;
        }
        public TResult Match<TResult>(Func<TResult> None, Func<T, TResult> Some)
        {
            return variant.Match(_ => None(), Some);
        }
    }
}
