using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericVariant;
using Extensions;

namespace Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variant生のまま");
            var foo = new[]{
                Variant<int,string>.C1(4),
                Variant<int,string>.C2("foo")};
            foo
                .ForEach(either => either
                    .Match(
                        C1: i => i.ToString(),
                        C2: s => s)
                    .Act(Console.WriteLine));

            //Option<T> = Variant<Unit,T>
            Console.WriteLine("\nOption");
            var hoge = new[] { 
                Option<int>.None(),
                Option<int>.Some(10) };
            hoge
                .ForEach(opt => opt.
                    Match(
                        None: () => -1,
                        Some: v => v)
                    .Act(Console.WriteLine));

            //ConsList<T> = Variant<Unit,Tuple<T,ConsList<T>>>
            Console.WriteLine("\nConsList");
            var list = new[] { 2, 3, 5 , 8, 12 }.ToConsList();

            list
                .Match(
                    Nil: () => 0,
                    Cons: (head, tail) => head)
                .Act(Console.WriteLine);

            //Sum
            list
                .Catamorphism(
                    nil: () => 0,
                    cons: (h, t) => h + t)
                .Act(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
