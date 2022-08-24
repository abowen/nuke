// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Nuke.Common.Utilities;
using Nuke.Common.ValueInjection;

namespace Nuke.Common.Execution
{
    internal class HandleHelpRequestsAttribute : BuildExtensionAttributeBase, IOnBuildInitialized
    {
        public void OnBuildInitialized(
            NukeBuild build,
            IReadOnlyCollection<ExecutableTarget> executableTargets,
            IReadOnlyCollection<ExecutableTarget> executionPlan)
        {
            if (build.Help || executionPlan.Count == 0)
            {
                Host.Debug(GetTargetsText(build));
                Host.Debug(GetParametersText(build));
                Environment.Exit(exitCode: 0);
            }
        }

        public string GetTargetsText(NukeBuild build)
        {
            var builder = new StringBuilder();

            var longestTargetName = build.ExecutableTargets.Select(x => x.Name.Length).OrderByDescending(x => x).First();
            var padRightTargets = Math.Max(longestTargetName, val2: 20);
            builder.AppendLine("Targets (with their direct dependencies):");
            builder.AppendLine();
            foreach (var target in build.ExecutableTargets.Where(x => x.Listed))
            {
                var dependencies = target.ExecutionDependencies.Count > 0
                    ? $" -> {target.ExecutionDependencies.Select(x => x.Name).JoinCommaSpace()}"
                    : string.Empty;
                var targetEntry = target.Name + (target.IsDefault ? " (default)" : string.Empty);
                builder.AppendLine($"  {targetEntry.PadRight(padRightTargets)}{dependencies}");
                if (!string.IsNullOrWhiteSpace(target.Description))
                    builder.AppendLine($"    {target.Description}");
            }

            return builder.ToString();
        }

        public string GetParametersText(NukeBuild build)
        {
            var defaultTargets = build.ExecutableTargets.Where(x => x.IsDefault).Select(x => x.Name).ToList();
            var builder = new StringBuilder();

            var parameters = ValueInjectionUtility.GetParameterMembers(build.GetType(), includeUnlisted: false);
            var padRightParameter = Math.Max(parameters.Max(x => ParameterService.GetParameterDashedName(x).Length), val2: 16);

            List<string> SplitLines(string text)
            {
                var words = new Queue<string>(text.Split(' ').ToList());
                var lines = new List<string> { string.Empty };
                foreach (var word in words)
                {
                    var nextLength = padRightParameter + 6 + lines.Last().Length + word.Length;
                    if (nextLength >= Console.BufferWidth || nextLength > 90)
                        lines.Add(string.Empty);

                    lines[lines.Count - 1] = $"{lines.Last()} {word}";
                }

                return lines;
            }

            void PrintParameter(MemberInfo parameter)
            {
                var description = SplitLines(
                    // TODO: remove
                    ParameterService.GetParameterDescription(parameter)
                        ?.Replace("{default_target}", defaultTargets.Count > 0 ? defaultTargets.JoinCommaSpace() : "<none>")
                        .TrimEnd(".").Append(".")
                    ?? "<no description>");
                var parameterName = ParameterService.GetParameterDashedName(parameter);
                builder.AppendLine($"  --{parameterName.PadRight(padRightParameter)}  {description.First()}");
                foreach (var line in description.Skip(count: 1))
                    builder.AppendLine($"{new string(c: ' ', count: padRightParameter + 6)}{line}");
            }

            builder.AppendLine("Parameters:");

            var customParameters = parameters.Where(x => x.DeclaringType != typeof(NukeBuild)).ToList();
            if (customParameters.Count > 0)
                builder.AppendLine();
            customParameters.ForEach(PrintParameter);

            builder.AppendLine();

            var inheritedParameters = parameters.Where(x => x.DeclaringType == typeof(NukeBuild)).ToList();
            inheritedParameters.ForEach(PrintParameter);

            return builder.ToString();
        }
    }
}
