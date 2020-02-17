﻿using System;

namespace Inasync {

    internal readonly struct DeepAssertArgs {
        public readonly Type? TargetType;
        public readonly object? Actual;
        public readonly object? Expected;
        public readonly string Path;

        public DeepAssertArgs(Type? targetType, object? actual, object? expected, string path) {
            TargetType = targetType;
            Actual = actual;
            Expected = expected;
            Path = path;
        }

        public override string ToString() => $@"{{
      path: {Path}
    target: {TargetType?.FullName ?? "(null)"}
    actual: {Actual ?? "(null)"}
  expected: {Expected ?? "(null)"}
}}";
    }
}
