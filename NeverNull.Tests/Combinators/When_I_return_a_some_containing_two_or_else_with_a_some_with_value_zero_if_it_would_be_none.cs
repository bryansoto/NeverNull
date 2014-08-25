using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators
{
    [Subject(typeof (OrElseWithExt), "OrElseWith")]
    public class When_I_return_a_some_containing_two_or_else_with_a_some_with_value_zero_if_it_would_be_none
    {
        static Option<int> _two;
        static Option<int> _result;

        Establish context = () => _two = 2;

        Because of = () => _result = _two.OrElseWith(0);

        It should_contain_two_in_the_some =
            () => _result.Value.Should().Be(2);

        It should_return_a_some =
            () => _result.HasValue.Should().BeTrue();
    }
}