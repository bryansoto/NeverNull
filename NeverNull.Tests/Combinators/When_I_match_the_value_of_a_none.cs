﻿using System;
using FluentAssertions;
using Machine.Specifications;
using NeverNull.Combinators;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (MatchExt), "Match")]
    class When_I_match_the_value_of_a_none {
        static Option<int> _none;
        static Action<int> _whenSome;
        static bool _noneCallbackExecuted;
        static Action _whenNone;
        static bool _someCallbackExecuted;

        Establish context = () => {
            _none = Option.None;

            _whenSome = i => _someCallbackExecuted = true;
            _whenNone = () => _noneCallbackExecuted = true;
        };

        Because of = () => _none.Match(
                                       _whenSome,
                                       _whenNone);

        It should_execute_the_none_callback = () => _noneCallbackExecuted.Should().BeTrue();

        It should_not_execute_the_some_callback = () => _someCallbackExecuted.Should().BeFalse();
    }
}