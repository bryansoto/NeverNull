using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (RejectExt), "Reject")]
    public class When_I_reject_a_some_containing_two_if_it_contains_three {
        static Option<int> _two;
        static Option<int> _result;

        Establish context = () => _two = Option.From(2);

        Because of =
            () => _result = _two.Reject(i => i == 3);

        It should_contain_two_in_the_some =
            () => _result.Value.Should().Be(2);

        It should_return_a_some =
            () => _result.HasValue.Should().BeTrue();
    }
}