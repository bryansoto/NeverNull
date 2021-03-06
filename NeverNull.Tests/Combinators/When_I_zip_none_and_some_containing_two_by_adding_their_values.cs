using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (ZipExt), "Zip")]
    public class When_I_zip_none_and_some_containing_two_by_adding_their_values {
        static Option<int> _result;
        static Option<int> _two;
        static Option<int> _none;

        Establish ctx = () => {
            _two = Option.From(2);
            _none = Option.None;
        };

        Because of = () => _result = _none.Zip(_two, (a, b) => a + b);

        It should_return_none =
            () => _result.IsEmpty.Should().BeTrue();
    }
}