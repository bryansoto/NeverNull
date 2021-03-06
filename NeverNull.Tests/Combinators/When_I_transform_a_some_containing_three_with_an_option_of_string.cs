using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (TransformWithExt), "TransformWith")]
    public class When_I_transform_a_some_containing_three_with_an_option_of_string {
        static Option<string> _result;

        Because of = () => _result = Option.Some(3)
                                           .TransformWith(i => Option.From(i.ToString()), () => Option.Some("nothing"));

        It should_contain_three_as_string_in_the_result =
            () => _result.Value.Should().Be("3");

        It should_return_a_some =
            () => _result.HasValue.Should().BeTrue();
    }
}