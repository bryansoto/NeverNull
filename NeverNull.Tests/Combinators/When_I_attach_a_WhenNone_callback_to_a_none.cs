﻿using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (IfNoneExt), "IfNone")]
    class When_I_attach_a_WhenNone_callback_to_a_none {
        static Option<int> _none;
        static bool _callbackExecuted;

        Establish context = () => _none = Option.None;

        Because of = () => _none.IfNone(() => _callbackExecuted = true);

        It should_execute_the_callback = () => _callbackExecuted.Should().BeTrue();
    }
}