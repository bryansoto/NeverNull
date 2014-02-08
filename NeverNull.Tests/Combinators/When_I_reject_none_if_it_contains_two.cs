using Machine.Specifications;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (NeverNull.Combinators), "Reject")]
    public class When_I_reject_none_if_it_contains_two {
        static Option<int> _none;
        static Option<int> _result;

        Establish context = () => _none = Option.None;

        Because of =
            () => _result = _none.Reject(i => i == 3);

        It should_return_none =
            () => _result.IsEmpty.ShouldBeTrue();
    }
}