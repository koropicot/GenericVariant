using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericVariant;
using Extensions;

namespace Usage
{

    //ConsList<T> = Variant<Unit,Tuple<T,ConsList<T>>>
    public sealed class ConsList<T>
    {
        private ConsList() { }
        //再帰型は名前付けないと書けない
        private Variant<Unit, Tuple<T, ConsList<T>>> variant;
        public static ConsList<T> Nil()
        {
            var list = new ConsList<T>();
            list.variant = Variant<Unit, Tuple<T, ConsList<T>>>.C1(Unit.New());
            return list;
        }
        public static ConsList<T> Cons(T head, ConsList<T> tail)
        {
            var list = new ConsList<T>();
            list.variant = Variant<Unit, Tuple<T, ConsList<T>>>.C2(Tuple.Create(head, tail));
            return list;
        }
        public TResult Match<TResult>(Func<TResult> Nil, Func<T, ConsList<T>, TResult> Cons)
        {
            return variant.Match(_ => Nil(), t => Cons(t.Item1, t.Item2));
        }
    }

    public static class ConsList
    {
        public static TResult Catamorphism<T, TResult>(this ConsList<T> list, Func<TResult> nil, Func<T, TResult, TResult> cons)
        {
            return list.Match(nil, (t, l) => cons(t, l.Catamorphism(nil, cons)));
        }

        public static ConsList<T> ToConsList<T>(this IEnumerable<T> ieList)
        {
            return ieList.Any() ? ConsList<T>.Cons(ieList.First(), ieList.Skip(1).ToConsList()) : ConsList<T>.Nil();
        }
    }
}
