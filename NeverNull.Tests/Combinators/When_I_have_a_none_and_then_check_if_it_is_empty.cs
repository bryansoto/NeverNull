using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (ThenExt), "Then")]
    public class When_I_have_a_none_and_then_check_if_it_is_empty {
        static Option<bool> _result;
        static Option<int> _none;

        Establish context = () => _none = Option.None;

        Because of = () => _result = _none.Then(o => o.IsEmpty);

        It should_return_a_none =
            () => _result.IsEmpty.Should().BeTrue();
    }
}