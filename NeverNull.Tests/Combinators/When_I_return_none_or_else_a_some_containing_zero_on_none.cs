using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (OrElseExt), "OrElse")]
    public class When_I_return_none_or_else_a_some_containing_zero_on_none {
        static Option<int> _none;
        static Option<int> _result;

        Establish context = () => _none = Option.None;

        Because of =
            () => _result = _none.OrElse(0);

        It should_contain_zero_in_the_some =
            () => _result.Value.Should().Be(0);

        It should_return_a_some =
            () => _result.HasValue.Should().BeTrue();
    }
}