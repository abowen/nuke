// Generated from https://github.com/nuke-build/nuke/blob/master/source/Nuke.Common/Tools/Pulumi/Pulumi.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Pulumi;

/// <summary>
///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathToolRequirement(PulumiPathExecutable)]
public partial class PulumiTasks
    : IRequirePathTool
{
    public const string PulumiPathExecutable = "pulumi";
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public static string PulumiPath =>
        ToolPathResolver.TryGetEnvironmentExecutable("PULUMI_EXE") ??
        ToolPathResolver.GetPathExecutable("pulumi");
    public static Action<OutputType, string> PulumiLogger { get; set; } = CustomLogger;
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    public static IReadOnlyCollection<Output> Pulumi(ref ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> customLogger = null)
    {
        using var process = ProcessTasks.StartProcess(PulumiPath, ref arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, customLogger ?? PulumiLogger);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiUpSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiUpSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiUpSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiUpSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiUpSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiUpSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiUpSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiUpSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiUpSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiUpSettings.ExpectNoChanges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiUpSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiUpSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiUpSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiUpSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiUpSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiUpSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiUpSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiUpSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiUpSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiUpSettings.Replace"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiUpSettings.SecretsProvider"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiUpSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiUpSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiUpSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiUpSettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiUpSettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiUpSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiUpSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiUpSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiUpSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiUpSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiUpSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiUpSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiUpSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiUpSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiUp(PulumiUpSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiUpSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiUpSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiUpSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiUpSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiUpSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiUpSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiUpSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiUpSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiUpSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiUpSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiUpSettings.ExpectNoChanges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiUpSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiUpSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiUpSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiUpSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiUpSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiUpSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiUpSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiUpSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiUpSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiUpSettings.Replace"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiUpSettings.SecretsProvider"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiUpSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiUpSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiUpSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiUpSettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiUpSettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiUpSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiUpSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiUpSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiUpSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiUpSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiUpSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiUpSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiUpSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiUpSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiUp(Configure<PulumiUpSettings> configurator)
    {
        return PulumiUp(configurator(new PulumiUpSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiUpSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiUpSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiUpSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiUpSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiUpSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiUpSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiUpSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiUpSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiUpSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiUpSettings.ExpectNoChanges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiUpSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiUpSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiUpSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiUpSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiUpSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiUpSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiUpSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiUpSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiUpSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiUpSettings.Replace"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiUpSettings.SecretsProvider"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiUpSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiUpSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiUpSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiUpSettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiUpSettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiUpSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiUpSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiUpSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiUpSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiUpSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiUpSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiUpSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiUpSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiUpSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiUpSettings Settings, IReadOnlyCollection<Output> Output)> PulumiUp(CombinatorialConfigure<PulumiUpSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiUp, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiPreviewSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiPreviewSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiPreviewSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiPreviewSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiPreview(PulumiPreviewSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiPreviewSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiPreviewSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiPreviewSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiPreviewSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiPreviewSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiPreview(Configure<PulumiPreviewSettings> configurator)
    {
        return PulumiPreview(configurator(new PulumiPreviewSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
    ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
    ///     <li><c>--policy-pack</c> via <see cref="PulumiPreviewSettings.PolicyPack"/></li>
    ///     <li><c>--policy-pack-config</c> via <see cref="PulumiPreviewSettings.PolicyPackConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
    ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
    ///     <li><c>--show-reads</c> via <see cref="PulumiPreviewSettings.ShowReads"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiPreviewSettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
    ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiPreviewSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPreview(CombinatorialConfigure<PulumiPreviewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiPreview, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfig(PulumiConfigSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfig(Configure<PulumiConfigSettings> configurator)
    {
        return PulumiConfig(configurator(new PulumiConfigSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfig(CombinatorialConfigure<PulumiConfigSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfig, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigCopySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigCopySettings.Cwd"/></li>
    ///     <li><c>--dest</c> via <see cref="PulumiConfigCopySettings.Destination"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigCopySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigCopySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigCopySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigCopySettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigCopySettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigCopySettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigCopySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigCopySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigCopy(PulumiConfigCopySettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigCopySettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigCopySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigCopySettings.Cwd"/></li>
    ///     <li><c>--dest</c> via <see cref="PulumiConfigCopySettings.Destination"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigCopySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigCopySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigCopySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigCopySettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigCopySettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigCopySettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigCopySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigCopySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigCopy(Configure<PulumiConfigCopySettings> configurator)
    {
        return PulumiConfigCopy(configurator(new PulumiConfigCopySettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigCopySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigCopySettings.Cwd"/></li>
    ///     <li><c>--dest</c> via <see cref="PulumiConfigCopySettings.Destination"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigCopySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigCopySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigCopySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigCopySettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigCopySettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigCopySettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigCopySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigCopySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigCopySettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigCopy(CombinatorialConfigure<PulumiConfigCopySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfigCopy, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigGetSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigGet(PulumiConfigGetSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigGetSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigGetSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigGet(Configure<PulumiConfigGetSettings> configurator)
    {
        return PulumiConfigGet(configurator(new PulumiConfigGetSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigGetSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigGetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigGet(CombinatorialConfigure<PulumiConfigGetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfigGet, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigRefresh(PulumiConfigRefreshSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigRefreshSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigRefresh(Configure<PulumiConfigRefreshSettings> configurator)
    {
        return PulumiConfigRefresh(configurator(new PulumiConfigRefreshSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigRefreshSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigRefresh(CombinatorialConfigure<PulumiConfigRefreshSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfigRefresh, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigRemoveSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigRemove(PulumiConfigRemoveSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigRemoveSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigRemoveSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigRemove(Configure<PulumiConfigRemoveSettings> configurator)
    {
        return PulumiConfigRemove(configurator(new PulumiConfigRemoveSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigRemoveSettings.Key"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigRemoveSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigRemove(CombinatorialConfigure<PulumiConfigRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfigRemove, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigSetSettings.Key"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
    ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
    ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigSet(PulumiConfigSetSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiConfigSetSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigSetSettings.Key"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
    ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
    ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiConfigSet(Configure<PulumiConfigSetSettings> configurator)
    {
        return PulumiConfigSet(configurator(new PulumiConfigSetSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;key&gt;</c> via <see cref="PulumiConfigSetSettings.Key"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
    ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
    ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
    ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiConfigSetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigSet(CombinatorialConfigure<PulumiConfigSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiConfigSet, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
    ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
    ///     <li><c>--show-name</c> via <see cref="PulumiStackSettings.ShowName"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
    ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStack(PulumiStackSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
    ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
    ///     <li><c>--show-name</c> via <see cref="PulumiStackSettings.ShowName"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
    ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStack(Configure<PulumiStackSettings> configurator)
    {
        return PulumiStack(configurator(new PulumiStackSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
    ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
    ///     <li><c>--show-name</c> via <see cref="PulumiStackSettings.ShowName"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
    ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStack(CombinatorialConfigure<PulumiStackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStack, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newSecretsProvider&gt;</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NewSecretsProvider"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackChangeSecretsProvider(PulumiStackChangeSecretsProviderSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackChangeSecretsProviderSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newSecretsProvider&gt;</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NewSecretsProvider"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackChangeSecretsProvider(Configure<PulumiStackChangeSecretsProviderSettings> configurator)
    {
        return PulumiStackChangeSecretsProvider(configurator(new PulumiStackChangeSecretsProviderSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newSecretsProvider&gt;</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NewSecretsProvider"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackChangeSecretsProviderSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackChangeSecretsProviderSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackChangeSecretsProvider(CombinatorialConfigure<PulumiStackChangeSecretsProviderSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackChangeSecretsProvider, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackExportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackExportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackExportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackExportSettings.File"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackExportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackExportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackExportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackExportSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackExportSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackExportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackExportSettings.Verbose"/></li>
    ///     <li><c>--version</c> via <see cref="PulumiStackExportSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackExport(PulumiStackExportSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackExportSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackExportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackExportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackExportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackExportSettings.File"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackExportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackExportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackExportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackExportSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackExportSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackExportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackExportSettings.Verbose"/></li>
    ///     <li><c>--version</c> via <see cref="PulumiStackExportSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackExport(Configure<PulumiStackExportSettings> configurator)
    {
        return PulumiStackExport(configurator(new PulumiStackExportSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackExportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackExportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackExportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackExportSettings.File"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackExportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackExportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackExportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackExportSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackExportSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackExportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackExportSettings.Verbose"/></li>
    ///     <li><c>--version</c> via <see cref="PulumiStackExportSettings.Version"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackExportSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackExport(CombinatorialConfigure<PulumiStackExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackExport, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;file&gt;</c> via <see cref="PulumiStackGraphSettings.File"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackGraphSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackGraphSettings.Cwd"/></li>
    ///     <li><c>--dependency-edge-color</c> via <see cref="PulumiStackGraphSettings.DependencyEdgeColor"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackGraphSettings.Emoji"/></li>
    ///     <li><c>--ignore-dependency-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></li>
    ///     <li><c>--ignore-parent-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackGraphSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackGraphSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackGraphSettings.NonInteractive"/></li>
    ///     <li><c>--parent-edge-color</c> via <see cref="PulumiStackGraphSettings.ParentEdgeColor"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackGraphSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackGraphSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackGraphSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackGraph(PulumiStackGraphSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackGraphSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;file&gt;</c> via <see cref="PulumiStackGraphSettings.File"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackGraphSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackGraphSettings.Cwd"/></li>
    ///     <li><c>--dependency-edge-color</c> via <see cref="PulumiStackGraphSettings.DependencyEdgeColor"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackGraphSettings.Emoji"/></li>
    ///     <li><c>--ignore-dependency-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></li>
    ///     <li><c>--ignore-parent-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackGraphSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackGraphSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackGraphSettings.NonInteractive"/></li>
    ///     <li><c>--parent-edge-color</c> via <see cref="PulumiStackGraphSettings.ParentEdgeColor"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackGraphSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackGraphSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackGraphSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackGraph(Configure<PulumiStackGraphSettings> configurator)
    {
        return PulumiStackGraph(configurator(new PulumiStackGraphSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;file&gt;</c> via <see cref="PulumiStackGraphSettings.File"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackGraphSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackGraphSettings.Cwd"/></li>
    ///     <li><c>--dependency-edge-color</c> via <see cref="PulumiStackGraphSettings.DependencyEdgeColor"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackGraphSettings.Emoji"/></li>
    ///     <li><c>--ignore-dependency-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></li>
    ///     <li><c>--ignore-parent-edges</c> via <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackGraphSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackGraphSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackGraphSettings.NonInteractive"/></li>
    ///     <li><c>--parent-edge-color</c> via <see cref="PulumiStackGraphSettings.ParentEdgeColor"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackGraphSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackGraphSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackGraphSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackGraphSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackGraph(CombinatorialConfigure<PulumiStackGraphSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackGraph, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackHistorySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackHistorySettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackHistorySettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackHistorySettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackHistorySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackHistorySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackHistorySettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackHistorySettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackHistorySettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackHistorySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackHistorySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackHistory(PulumiStackHistorySettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackHistorySettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackHistorySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackHistorySettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackHistorySettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackHistorySettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackHistorySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackHistorySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackHistorySettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackHistorySettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackHistorySettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackHistorySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackHistorySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackHistory(Configure<PulumiStackHistorySettings> configurator)
    {
        return PulumiStackHistory(configurator(new PulumiStackHistorySettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackHistorySettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackHistorySettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackHistorySettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackHistorySettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackHistorySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackHistorySettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackHistorySettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackHistorySettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackHistorySettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackHistorySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackHistorySettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackHistorySettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackHistory(CombinatorialConfigure<PulumiStackHistorySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackHistory, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackImportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackImportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackImportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackImportSettings.File"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackImportSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackImportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackImportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackImportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackImportSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackImportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackImportSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackImport(PulumiStackImportSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackImportSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackImportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackImportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackImportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackImportSettings.File"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackImportSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackImportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackImportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackImportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackImportSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackImportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackImportSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackImport(Configure<PulumiStackImportSettings> configurator)
    {
        return PulumiStackImport(configurator(new PulumiStackImportSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackImportSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackImportSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackImportSettings.Emoji"/></li>
    ///     <li><c>--file</c> via <see cref="PulumiStackImportSettings.File"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackImportSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackImportSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackImportSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackImportSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackImportSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackImportSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackImportSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackImportSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackImport(CombinatorialConfigure<PulumiStackImportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackImport, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;organizationAndName&gt;</c> via <see cref="PulumiStackInitSettings.OrganizationAndName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackInitSettings.Color"/></li>
    ///     <li><c>--copy-config-from</c> via <see cref="PulumiStackInitSettings.CopyConfigFrom"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackInitSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackInitSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackInitSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackInitSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackInitSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackInitSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackInitSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackInitSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackInitSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackInit(PulumiStackInitSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackInitSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;organizationAndName&gt;</c> via <see cref="PulumiStackInitSettings.OrganizationAndName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackInitSettings.Color"/></li>
    ///     <li><c>--copy-config-from</c> via <see cref="PulumiStackInitSettings.CopyConfigFrom"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackInitSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackInitSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackInitSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackInitSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackInitSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackInitSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackInitSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackInitSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackInitSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackInit(Configure<PulumiStackInitSettings> configurator)
    {
        return PulumiStackInit(configurator(new PulumiStackInitSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;organizationAndName&gt;</c> via <see cref="PulumiStackInitSettings.OrganizationAndName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackInitSettings.Color"/></li>
    ///     <li><c>--copy-config-from</c> via <see cref="PulumiStackInitSettings.CopyConfigFrom"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackInitSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackInitSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackInitSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackInitSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackInitSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackInitSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackInitSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackInitSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackInitSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackInitSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackInit(CombinatorialConfigure<PulumiStackInitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackInit, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all</c> via <see cref="PulumiStackListSettings.All"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackListSettings.NonInteractive"/></li>
    ///     <li><c>--organization</c> via <see cref="PulumiStackListSettings.Organization"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackListSettings.Profiling"/></li>
    ///     <li><c>--project</c> via <see cref="PulumiStackListSettings.Project"/></li>
    ///     <li><c>--tag</c> via <see cref="PulumiStackListSettings.Tag"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackList(PulumiStackListSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackListSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all</c> via <see cref="PulumiStackListSettings.All"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackListSettings.NonInteractive"/></li>
    ///     <li><c>--organization</c> via <see cref="PulumiStackListSettings.Organization"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackListSettings.Profiling"/></li>
    ///     <li><c>--project</c> via <see cref="PulumiStackListSettings.Project"/></li>
    ///     <li><c>--tag</c> via <see cref="PulumiStackListSettings.Tag"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackList(Configure<PulumiStackListSettings> configurator)
    {
        return PulumiStackList(configurator(new PulumiStackListSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all</c> via <see cref="PulumiStackListSettings.All"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackListSettings.NonInteractive"/></li>
    ///     <li><c>--organization</c> via <see cref="PulumiStackListSettings.Organization"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackListSettings.Profiling"/></li>
    ///     <li><c>--project</c> via <see cref="PulumiStackListSettings.Project"/></li>
    ///     <li><c>--tag</c> via <see cref="PulumiStackListSettings.Tag"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackListSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackList(CombinatorialConfigure<PulumiStackListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackList, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackOutput(PulumiStackOutputSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackOutputSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackOutput(Configure<PulumiStackOutputSettings> configurator)
    {
        return PulumiStackOutput(configurator(new PulumiStackOutputSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
    ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackOutputSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackOutput(CombinatorialConfigure<PulumiStackOutputSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackOutput, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newStackName&gt;</c> via <see cref="PulumiStackRenameSettings.NewStackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRenameSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRenameSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRenameSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRenameSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRenameSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRenameSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRenameSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRenameSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRenameSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackRename(PulumiStackRenameSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackRenameSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newStackName&gt;</c> via <see cref="PulumiStackRenameSettings.NewStackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRenameSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRenameSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRenameSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRenameSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRenameSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRenameSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRenameSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRenameSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRenameSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackRename(Configure<PulumiStackRenameSettings> configurator)
    {
        return PulumiStackRename(configurator(new PulumiStackRenameSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;newStackName&gt;</c> via <see cref="PulumiStackRenameSettings.NewStackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRenameSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRenameSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRenameSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRenameSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRenameSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRenameSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRenameSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRenameSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRenameSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackRenameSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackRename(CombinatorialConfigure<PulumiStackRenameSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackRename, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackRemoveSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRemoveSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackRemoveSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--preserve-config</c> via <see cref="PulumiStackRemoveSettings.PreserveConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRemoveSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiStackRemoveSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackRemove(PulumiStackRemoveSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackRemoveSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackRemoveSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRemoveSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackRemoveSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--preserve-config</c> via <see cref="PulumiStackRemoveSettings.PreserveConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRemoveSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiStackRemoveSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackRemove(Configure<PulumiStackRemoveSettings> configurator)
    {
        return PulumiStackRemove(configurator(new PulumiStackRemoveSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackRemoveSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackRemoveSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiStackRemoveSettings.Force"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--preserve-config</c> via <see cref="PulumiStackRemoveSettings.PreserveConfig"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackRemoveSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiStackRemoveSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackRemoveSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackRemove(CombinatorialConfigure<PulumiStackRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackRemove, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackSelectSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackSelectSettings.Color"/></li>
    ///     <li><c>--create</c> via <see cref="PulumiStackSelectSettings.Create"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSelectSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSelectSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSelectSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSelectSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSelectSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSelectSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackSelectSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSelectSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSelectSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackSelect(PulumiStackSelectSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackSelectSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackSelectSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackSelectSettings.Color"/></li>
    ///     <li><c>--create</c> via <see cref="PulumiStackSelectSettings.Create"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSelectSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSelectSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSelectSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSelectSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSelectSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSelectSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackSelectSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSelectSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSelectSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackSelect(Configure<PulumiStackSelectSettings> configurator)
    {
        return PulumiStackSelect(configurator(new PulumiStackSelectSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;stackName&gt;</c> via <see cref="PulumiStackSelectSettings.StackName"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackSelectSettings.Color"/></li>
    ///     <li><c>--create</c> via <see cref="PulumiStackSelectSettings.Create"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackSelectSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackSelectSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackSelectSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSelectSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSelectSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackSelectSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiStackSelectSettings.SecretsProvider"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackSelectSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackSelectSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackSelectSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackSelect(CombinatorialConfigure<PulumiStackSelectSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackSelect, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagSetSettings.Name"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiStackTagSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagSetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagSetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagSet(PulumiStackTagSetSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackTagSetSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagSetSettings.Name"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiStackTagSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagSetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagSetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagSet(Configure<PulumiStackTagSetSettings> configurator)
    {
        return PulumiStackTagSet(configurator(new PulumiStackTagSetSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagSetSettings.Name"/></li>
    ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiStackTagSetSettings.Value"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagSetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagSetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagSetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagSetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagSetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagSetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagSetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagSetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagSetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackTagSetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackTagSet(CombinatorialConfigure<PulumiStackTagSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackTagSet, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagGetSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagGetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagGetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagGet(PulumiStackTagGetSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackTagGetSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagGetSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagGetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagGetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagGet(Configure<PulumiStackTagGetSettings> configurator)
    {
        return PulumiStackTagGet(configurator(new PulumiStackTagGetSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagGetSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagGetSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagGetSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagGetSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagGetSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagGetSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagGetSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagGetSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagGetSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagGetSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackTagGetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackTagGet(CombinatorialConfigure<PulumiStackTagGetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackTagGet, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagRemoveSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagRemove(PulumiStackTagRemoveSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackTagRemoveSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagRemoveSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagRemove(Configure<PulumiStackTagRemoveSettings> configurator)
    {
        return PulumiStackTagRemove(configurator(new PulumiStackTagRemoveSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;name&gt;</c> via <see cref="PulumiStackTagRemoveSettings.Name"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagRemoveSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagRemoveSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagRemoveSettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagRemoveSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagRemoveSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagRemoveSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagRemoveSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackTagRemoveSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackTagRemove(CombinatorialConfigure<PulumiStackTagRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackTagRemove, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackTagListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagListSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagListSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagList(PulumiStackTagListSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiStackTagListSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackTagListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagListSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagListSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiStackTagList(Configure<PulumiStackTagListSettings> configurator)
    {
        return PulumiStackTagList(configurator(new PulumiStackTagListSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiStackTagListSettings.Color"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiStackTagListSettings.Cwd"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiStackTagListSettings.Emoji"/></li>
    ///     <li><c>--json</c> via <see cref="PulumiStackTagListSettings.Json"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiStackTagListSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiStackTagListSettings.LogToStderr"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiStackTagListSettings.NonInteractive"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiStackTagListSettings.Profiling"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiStackTagListSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiStackTagListSettings.Verbose"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiStackTagListSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackTagList(CombinatorialConfigure<PulumiStackTagListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiStackTagList, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;template&gt;</c> via <see cref="PulumiNewSettings.Template"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiNewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiNewSettings.Config"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiNewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiNewSettings.Cwd"/></li>
    ///     <li><c>--description</c> via <see cref="PulumiNewSettings.Description"/></li>
    ///     <li><c>--dir</c> via <see cref="PulumiNewSettings.Directory"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiNewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiNewSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiNewSettings.Force"/></li>
    ///     <li><c>--generate-only</c> via <see cref="PulumiNewSettings.GenerateOnly"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiNewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiNewSettings.LogToStderr"/></li>
    ///     <li><c>--name</c> via <see cref="PulumiNewSettings.Name"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiNewSettings.NonInteractive"/></li>
    ///     <li><c>--offline</c> via <see cref="PulumiNewSettings.Offline"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiNewSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiNewSettings.SecretsProvider"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiNewSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiNewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiNewSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiNewSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiNew(PulumiNewSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiNewSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;template&gt;</c> via <see cref="PulumiNewSettings.Template"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiNewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiNewSettings.Config"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiNewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiNewSettings.Cwd"/></li>
    ///     <li><c>--description</c> via <see cref="PulumiNewSettings.Description"/></li>
    ///     <li><c>--dir</c> via <see cref="PulumiNewSettings.Directory"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiNewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiNewSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiNewSettings.Force"/></li>
    ///     <li><c>--generate-only</c> via <see cref="PulumiNewSettings.GenerateOnly"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiNewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiNewSettings.LogToStderr"/></li>
    ///     <li><c>--name</c> via <see cref="PulumiNewSettings.Name"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiNewSettings.NonInteractive"/></li>
    ///     <li><c>--offline</c> via <see cref="PulumiNewSettings.Offline"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiNewSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiNewSettings.SecretsProvider"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiNewSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiNewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiNewSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiNewSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiNew(Configure<PulumiNewSettings> configurator)
    {
        return PulumiNew(configurator(new PulumiNewSettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;template&gt;</c> via <see cref="PulumiNewSettings.Template"/></li>
    ///     <li><c>--color</c> via <see cref="PulumiNewSettings.Color"/></li>
    ///     <li><c>--config</c> via <see cref="PulumiNewSettings.Config"/></li>
    ///     <li><c>--config-path</c> via <see cref="PulumiNewSettings.ConfigPath"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiNewSettings.Cwd"/></li>
    ///     <li><c>--description</c> via <see cref="PulumiNewSettings.Description"/></li>
    ///     <li><c>--dir</c> via <see cref="PulumiNewSettings.Directory"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiNewSettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiNewSettings.Emoji"/></li>
    ///     <li><c>--force</c> via <see cref="PulumiNewSettings.Force"/></li>
    ///     <li><c>--generate-only</c> via <see cref="PulumiNewSettings.GenerateOnly"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiNewSettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiNewSettings.LogToStderr"/></li>
    ///     <li><c>--name</c> via <see cref="PulumiNewSettings.Name"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiNewSettings.NonInteractive"/></li>
    ///     <li><c>--offline</c> via <see cref="PulumiNewSettings.Offline"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiNewSettings.Profiling"/></li>
    ///     <li><c>--secrets-provider</c> via <see cref="PulumiNewSettings.SecretsProvider"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiNewSettings.Stack"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiNewSettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiNewSettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiNewSettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiNewSettings Settings, IReadOnlyCollection<Output> Output)> PulumiNew(CombinatorialConfigure<PulumiNewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiNew, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiDestroySettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiDestroy(PulumiDestroySettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new PulumiDestroySettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        process.AssertZeroExitCode();
        return process.Output;
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiDestroySettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> PulumiDestroy(Configure<PulumiDestroySettings> configurator)
    {
        return PulumiDestroy(configurator(new PulumiDestroySettings()));
    }
    /// <summary>
    ///   <p>Pulumi is an <a href="https://github.com/pulumi/pulumi">open source</a> infrastructure as code tool for creating, deploying and managing cloud infrastructure. Pulumi works with traditional infrastructure like VMs, networks, and databases, in addition to modern architectures, including containers, Kubernetes clusters, and serverless functions. Pulumi supports dozens of public, private, and hybrid cloud service providers.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
    ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
    ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.Cwd"/></li>
    ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
    ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
    ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
    ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
    ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
    ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
    ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
    ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
    ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
    ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
    ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
    ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
    ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
    ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
    ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
    ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
    ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
    ///     <li><c>--suppress-permalink</c> via <see cref="PulumiDestroySettings.SuppressPermalink"/></li>
    ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
    ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
    ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
    ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
    ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(PulumiDestroySettings Settings, IReadOnlyCollection<Output> Output)> PulumiDestroy(CombinatorialConfigure<PulumiDestroySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(PulumiDestroy, PulumiLogger, degreeOfParallelism, completeOnFailure);
    }
}
#region PulumiUpSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiUpSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Config to use during the update.
    /// </summary>
    public virtual IReadOnlyList<string> Config => ConfigInternal.AsReadOnly();
    internal List<string> ConfigInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Use the configuration values in the specified file rather than detecting the file name.
    /// </summary>
    public virtual string ConfigFile { get; internal set; }
    /// <summary>
    ///   Config keys contain a path to a property in a map or list to set.
    /// </summary>
    public virtual bool? ConfigPath { get; internal set; }
    /// <summary>
    ///   Print detailed debugging output during resource operations.
    /// </summary>
    public virtual bool? Debug { get; internal set; }
    /// <summary>
    ///   Display operation as a rich diff showing the overall change.
    /// </summary>
    public virtual bool? Diff { get; internal set; }
    /// <summary>
    ///   Return an error if any changes occur during this update.
    /// </summary>
    public virtual bool? ExpectNoChanges { get; internal set; }
    /// <summary>
    ///   Optional message to associate with the update operation.
    /// </summary>
    public virtual string Message { get; internal set; }
    /// <summary>
    ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).
    /// </summary>
    public virtual int? Parallel { get; internal set; }
    /// <summary>
    ///   Run one or more policy packs as part of this update.
    /// </summary>
    public virtual IReadOnlyList<string> PolicyPack => PolicyPackInternal.AsReadOnly();
    internal List<string> PolicyPackInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.
    /// </summary>
    public virtual IReadOnlyList<string> PolicyPackConfig => PolicyPackConfigInternal.AsReadOnly();
    internal List<string> PolicyPackConfigInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Refresh the state of the stack's resources before this update.
    /// </summary>
    public virtual bool? Refresh { get; internal set; }
    /// <summary>
    ///   Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.
    /// </summary>
    public virtual IReadOnlyList<string> Replace => ReplaceInternal.AsReadOnly();
    internal List<string> ReplaceInternal { get; set; } = new List<string>();
    /// <summary>
    ///   The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>). Only used when creating a new stack from an existing template (default <c>default</c>).
    /// </summary>
    public virtual PulumiSecretsProvider SecretsProvider { get; internal set; }
    /// <summary>
    ///   Show configuration keys and variables.
    /// </summary>
    public virtual bool? ShowConfig { get; internal set; }
    /// <summary>
    ///   Show resources that are being read in, alongside those being managed directly in the stack.
    /// </summary>
    public virtual bool? ShowReads { get; internal set; }
    /// <summary>
    ///   Show detailed resource replacement creates and deletes instead of a single step.
    /// </summary>
    public virtual bool? ShowReplacementSteps { get; internal set; }
    /// <summary>
    ///   Show resources that don't need be updated because they haven't changed, alongside those that do.
    /// </summary>
    public virtual bool? ShowSames { get; internal set; }
    /// <summary>
    ///   Do not perform a preview before performing the update.
    /// </summary>
    public virtual bool? SkipPreview { get; internal set; }
    /// <summary>
    ///   The name of the stack to operate on. Defaults to the current stack.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Suppress display of stack outputs (in case they contain sensitive values).
    /// </summary>
    public virtual bool? SuppressOutputs { get; internal set; }
    /// <summary>
    ///   Suppress display of the state permalink.
    /// </summary>
    public virtual bool? SuppressPermalink { get; internal set; }
    /// <summary>
    ///   Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.
    /// </summary>
    public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
    internal List<string> TargetInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Allows updating of dependent targets discovered but not specified in <c>--target</c> list.
    /// </summary>
    public virtual bool? TargetDependents { get; internal set; }
    /// <summary>
    ///   Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.
    /// </summary>
    public virtual IReadOnlyList<string> TargetReplace => TargetReplaceInternal.AsReadOnly();
    internal List<string> TargetReplaceInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Automatically approve and perform the update after previewing it.
    /// </summary>
    public virtual bool? Yes { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("up")
          .Add("--config {value}", Config)
          .Add("--config-file {value}", ConfigFile)
          .Add("--config-path", ConfigPath)
          .Add("--debug", Debug)
          .Add("--diff", Diff)
          .Add("--expect-no-changes", ExpectNoChanges)
          .Add("--message {value}", Message)
          .Add("--parallel {value}", Parallel)
          .Add("--policy-pack {value}", PolicyPack)
          .Add("--policy-pack-config {value}", PolicyPackConfig)
          .Add("--refresh", Refresh)
          .Add("--replace {value}", Replace)
          .Add("--secrets-provider {value}", SecretsProvider)
          .Add("--show-config", ShowConfig)
          .Add("--show-reads", ShowReads)
          .Add("--show-replacement-steps", ShowReplacementSteps)
          .Add("--show-sames", ShowSames)
          .Add("--skip-preview", SkipPreview)
          .Add("--stack {value}", Stack)
          .Add("--suppress-outputs", SuppressOutputs)
          .Add("--suppress-permalink", SuppressPermalink)
          .Add("--target {value}", Target)
          .Add("--target-dependents", TargetDependents)
          .Add("--target-replace {value}", TargetReplace)
          .Add("--yes", Yes)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiPreviewSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiPreviewSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Config to use during the update.
    /// </summary>
    public virtual IReadOnlyList<string> Config => ConfigInternal.AsReadOnly();
    internal List<string> ConfigInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Use the configuration values in the specified file rather than detecting the file name.
    /// </summary>
    public virtual string ConfigFile { get; internal set; }
    /// <summary>
    ///   Config keys contain a path to a property in a map or list to set.
    /// </summary>
    public virtual bool? ConfigPath { get; internal set; }
    /// <summary>
    ///   Print detailed debugging output during resource operations.
    /// </summary>
    public virtual bool? Debug { get; internal set; }
    /// <summary>
    ///   Display operation as a rich diff showing the overall change.
    /// </summary>
    public virtual bool? Diff { get; internal set; }
    /// <summary>
    ///   Return an error if any changes occur during this update.
    /// </summary>
    public virtual bool? ExpectNoChanges { get; internal set; }
    /// <summary>
    ///   Serialize the preview diffs, operations, and overall output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Optional message to associate with the update operation.
    /// </summary>
    public virtual string Message { get; internal set; }
    /// <summary>
    ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).
    /// </summary>
    public virtual int? Parallel { get; internal set; }
    /// <summary>
    ///   Run one or more policy packs as part of this update.
    /// </summary>
    public virtual IReadOnlyList<string> PolicyPack => PolicyPackInternal.AsReadOnly();
    internal List<string> PolicyPackInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.
    /// </summary>
    public virtual IReadOnlyList<string> PolicyPackConfig => PolicyPackConfigInternal.AsReadOnly();
    internal List<string> PolicyPackConfigInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Refresh the state of the stack's resources before this update.
    /// </summary>
    public virtual bool? Refresh { get; internal set; }
    /// <summary>
    ///   Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.
    /// </summary>
    public virtual IReadOnlyList<string> Replace => ReplaceInternal.AsReadOnly();
    internal List<string> ReplaceInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Show configuration keys and variables.
    /// </summary>
    public virtual bool? ShowConfig { get; internal set; }
    /// <summary>
    ///   Show resources that are being read in, alongside those being managed directly in the stack.
    /// </summary>
    public virtual bool? ShowReads { get; internal set; }
    /// <summary>
    ///   Show detailed resource replacement creates and deletes instead of a single step.
    /// </summary>
    public virtual bool? ShowReplacementSteps { get; internal set; }
    /// <summary>
    ///   Show resources that don't need be updated because they haven't changed, alongside those that do.
    /// </summary>
    public virtual bool? ShowSames { get; internal set; }
    /// <summary>
    ///   The name of the stack to operate on. Defaults to the current stack.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Suppress display of stack outputs (in case they contain sensitive values).
    /// </summary>
    public virtual bool? SuppressOutputs { get; internal set; }
    /// <summary>
    ///   Suppress display of the state permalink.
    /// </summary>
    public virtual bool? SuppressPermalink { get; internal set; }
    /// <summary>
    ///   Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.
    /// </summary>
    public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
    internal List<string> TargetInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Allows updating of dependent targets discovered but not specified in <c>--target</c> list.
    /// </summary>
    public virtual bool? TargetDependents { get; internal set; }
    /// <summary>
    ///   Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.
    /// </summary>
    public virtual IReadOnlyList<string> TargetReplace => TargetReplaceInternal.AsReadOnly();
    internal List<string> TargetReplaceInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("preview")
          .Add("--config {value}", Config)
          .Add("--config-file {value}", ConfigFile)
          .Add("--config-path", ConfigPath)
          .Add("--debug", Debug)
          .Add("--diff", Diff)
          .Add("--expect-no-changes", ExpectNoChanges)
          .Add("--json", Json)
          .Add("--message {value}", Message)
          .Add("--parallel {value}", Parallel)
          .Add("--policy-pack {value}", PolicyPack)
          .Add("--policy-pack-config {value}", PolicyPackConfig)
          .Add("--refresh", Refresh)
          .Add("--replace {value}", Replace)
          .Add("--show-config", ShowConfig)
          .Add("--show-reads", ShowReads)
          .Add("--show-replacement-steps", ShowReplacementSteps)
          .Add("--show-sames", ShowSames)
          .Add("--stack {value}", Stack)
          .Add("--suppress-outputs", SuppressOutputs)
          .Add("--suppress-permalink", SuppressPermalink)
          .Add("--target {value}", Target)
          .Add("--target-dependents", TargetDependents)
          .Add("--target-replace {value}", TargetReplace)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Use the configuration values in the specified file rather than detecting the file name.
    /// </summary>
    public virtual string ConfigFile { get; internal set; }
    /// <summary>
    ///   Serialize the preview diffs, operations, and overall output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Show secret values when listing config instead of displaying blinded values.
    /// </summary>
    public virtual bool? ShowSecrets { get; internal set; }
    /// <summary>
    ///   The name of the stack to operate on. Defaults to the current stack.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config")
          .Add("--config-file {value}", ConfigFile)
          .Add("--json", Json)
          .Add("--show-secrets", ShowSecrets)
          .Add("--stack {value}", Stack)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigCopySettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigCopySettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the new stack to copy the config to.
    /// </summary>
    public virtual string Destination { get; internal set; }
    /// <summary>
    ///   The key contains a path to a property in a map or list to set.
    /// </summary>
    public virtual string Path { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config cp")
          .Add("--dest {value}", Destination)
          .Add("--path {value}", Path)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigGetSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigGetSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The key to the key-value pair in the configuration.
    /// </summary>
    public virtual string Key { get; internal set; }
    /// <summary>
    ///   Serialize the preview diffs, operations, and overall output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   The key contains a path to a property in a map or list to set.
    /// </summary>
    public virtual string Path { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config get")
          .Add("{value}", Key)
          .Add("--json", Json)
          .Add("--path {value}", Path)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigRefreshSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigRefreshSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Overwrite configuration file, if it exists, without creating a backup.
    /// </summary>
    public virtual bool? Force { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config refresh")
          .Add("--force", Force)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigRemoveSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigRemoveSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The key to the key-value pair in the configuration.
    /// </summary>
    public virtual string Key { get; internal set; }
    /// <summary>
    ///   The key contains a path to a property in a map or list to set.
    /// </summary>
    public virtual string Path { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config rm")
          .Add("{value}", Key)
          .Add("--path {value}", Path)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiConfigSetSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiConfigSetSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The key to the key-value pair in the configuration.
    /// </summary>
    public virtual string Key { get; internal set; }
    /// <summary>
    ///   The new value for specified configuration key.
    /// </summary>
    public virtual string Value { get; internal set; }
    /// <summary>
    ///   The key contains a path to a property in a map or list to set.
    /// </summary>
    public virtual string Path { get; internal set; }
    /// <summary>
    ///   Save the value as plaintext (unencrypted).
    /// </summary>
    public virtual bool? Plaintext { get; internal set; }
    /// <summary>
    ///   Encrypt the value instead of storing it in plaintext.
    /// </summary>
    public virtual bool? Secret { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("config set")
          .Add("{value}", Key)
          .Add("{value}", Value)
          .Add("--path {value}", Path)
          .Add("--plaintext", Plaintext)
          .Add("--secret", Secret)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Display each resource's provider-assigned unique ID.
    /// </summary>
    public virtual bool? ShowIds { get; internal set; }
    /// <summary>
    ///   Display only the stack name.
    /// </summary>
    public virtual bool? ShowName { get; internal set; }
    /// <summary>
    ///   Display stack outputs which are marked as secret in plaintext.
    /// </summary>
    public virtual bool? ShowSecrets { get; internal set; }
    /// <summary>
    ///   Display each resource's Pulumi-assigned globally unique URN.
    /// </summary>
    public virtual bool? ShowUrns { get; internal set; }
    /// <summary>
    ///   The name of the stack to operate on. Defaults to the current stack.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack")
          .Add("--show-ids", ShowIds)
          .Add("--show-name", ShowName)
          .Add("--show-secrets", ShowSecrets)
          .Add("--show-urns", ShowUrns)
          .Add("--stack {value}", Stack)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackChangeSecretsProviderSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackChangeSecretsProviderSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the new secrets provider.
    /// </summary>
    public virtual string NewSecretsProvider { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack change-secrets-provider")
          .Add("{value}", NewSecretsProvider)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackExportSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackExportSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   A filename to write stack output to.
    /// </summary>
    public virtual string File { get; internal set; }
    /// <summary>
    ///   Display stack outputs which are marked as secret in plaintext.
    /// </summary>
    public virtual bool? ShowSecrets { get; internal set; }
    /// <summary>
    ///   Previous stack version to export. (If unset, will export the latest.).
    /// </summary>
    public virtual string Version { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack export")
          .Add("--file {value}", File)
          .Add("--show-secrets", ShowSecrets)
          .Add("--version {value}", Version)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackGraphSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackGraphSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   A file that will have a Graphviz DOT graph written to it.
    /// </summary>
    public virtual string File { get; internal set; }
    /// <summary>
    ///   Sets the color of dependency edges in the graph (default <c>#246C60</c>).
    /// </summary>
    public virtual string DependencyEdgeColor { get; internal set; }
    /// <summary>
    ///   Ignores edges introduced by dependency resource relationships.
    /// </summary>
    public virtual bool? IgnoreDependencyEdges { get; internal set; }
    /// <summary>
    ///   Ignores edges introduced by parent/child resource relationships.
    /// </summary>
    public virtual bool? IgnoreParentEdges { get; internal set; }
    /// <summary>
    ///   Sets the color of parent edges in the graph (default <c>#AA6639</c>).
    /// </summary>
    public virtual string ParentEdgeColor { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack graph")
          .Add("{value}", File)
          .Add("--dependency-edge-color {value}", DependencyEdgeColor)
          .Add("--ignore-dependency-edges", IgnoreDependencyEdges)
          .Add("--ignore-parent-edges", IgnoreParentEdges)
          .Add("--parent-edge-color {value}", ParentEdgeColor)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackHistorySettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackHistorySettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Serialize the preview diffs, operations, and overall output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Show secret values when listing config instead of displaying blinded values.
    /// </summary>
    public virtual bool? ShowSecrets { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack history")
          .Add("--json", Json)
          .Add("--show-secrets", ShowSecrets)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackImportSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackImportSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   A filename to read stack input from.
    /// </summary>
    public virtual string File { get; internal set; }
    /// <summary>
    ///   Force the import to occur, even if apparent errors are discovered beforehand (not recommended).
    /// </summary>
    public virtual bool? Force { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack import")
          .Add("--file {value}", File)
          .Add("--force", Force)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackInitSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackInitSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The stack name, optionally preceded by the organization name and a slash: <c>[&lt;org-name&gt;/]&lt;stack-name&gt;</c>
    /// </summary>
    public virtual string OrganizationAndName { get; internal set; }
    /// <summary>
    ///   The name of the stack to copy existing config from.
    /// </summary>
    public virtual string CopyConfigFrom { get; internal set; }
    /// <summary>
    ///   The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).
    /// </summary>
    public virtual PulumiSecretsProvider SecretsProvider { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack init")
          .Add("{value}", OrganizationAndName)
          .Add("--copy-config-from {value}", CopyConfigFrom)
          .Add("--secrets-provider {value}", SecretsProvider)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackListSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackListSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   List all stacks instead of just stacks for the current project.
    /// </summary>
    public virtual bool? All { get; internal set; }
    /// <summary>
    ///   Emit output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Filter returned stacks to those in a specific organization.
    /// </summary>
    public virtual string Organization { get; internal set; }
    /// <summary>
    ///   Filter returned stacks to those with a specific project name.
    /// </summary>
    public virtual string Project { get; internal set; }
    /// <summary>
    ///   Filter returned stacks to those in a specific tag (<c>tag-name</c> or <c>tag-name=tag-value</c>).
    /// </summary>
    public virtual string Tag { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack ls")
          .Add("--all", All)
          .Add("--json", Json)
          .Add("--organization {value}", Organization)
          .Add("--project {value}", Project)
          .Add("--tag {value}", Tag)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackOutputSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackOutputSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the property whose output value should be listed. This is optional.
    /// </summary>
    public virtual string PropertyName { get; internal set; }
    /// <summary>
    ///   Emit output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Display outputs which are marked as secret in plaintext.
    /// </summary>
    public virtual bool? ShowSecrets { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack output")
          .Add("{value}", PropertyName)
          .Add("--json", Json)
          .Add("--show-secrets", ShowSecrets)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackRenameSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackRenameSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The new name for the stack.
    /// </summary>
    public virtual string NewStackName { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack rename")
          .Add("{value}", NewStackName)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackRemoveSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackRemoveSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name for the stack to be removed.
    /// </summary>
    public virtual string StackName { get; internal set; }
    /// <summary>
    ///   Forces deletion of the stack, leaving behind any resources managed by the stack.
    /// </summary>
    public virtual bool? Force { get; internal set; }
    /// <summary>
    ///   Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.
    /// </summary>
    public virtual bool? PreserveConfig { get; internal set; }
    /// <summary>
    ///   Skip confirmation prompts, and proceed with removal anyway.
    /// </summary>
    public virtual bool? Yes { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack rm")
          .Add("{value}", StackName)
          .Add("--force", Force)
          .Add("--preserve-config", PreserveConfig)
          .Add("--yes", Yes)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackSelectSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackSelectSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the stack that should be selected.
    /// </summary>
    public virtual string StackName { get; internal set; }
    /// <summary>
    ///   If selected stack does not exist, create it.
    /// </summary>
    public virtual bool? Create { get; internal set; }
    /// <summary>
    ///   Use with <c>--create</c> flag, The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).
    /// </summary>
    public virtual PulumiSecretsProvider SecretsProvider { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack select")
          .Add("{value}", StackName)
          .Add("--create", Create)
          .Add("--secrets-provider {value}", SecretsProvider)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackTagSetSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackTagSetSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the tag to be set.
    /// </summary>
    public virtual string Name { get; internal set; }
    /// <summary>
    ///   The value of the tag to be set.
    /// </summary>
    public virtual string Value { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack tag set")
          .Add("{value}", Name)
          .Add("{value}", Value)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackTagGetSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackTagGetSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the tag to be set.
    /// </summary>
    public virtual string Name { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack tag get")
          .Add("{value}", Name)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackTagRemoveSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackTagRemoveSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The name of the tag to be set.
    /// </summary>
    public virtual string Name { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack tag rm")
          .Add("{value}", Name)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiStackTagListSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiStackTagListSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Emit output as JSON.
    /// </summary>
    public virtual bool? Json { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("stack tag ls")
          .Add("--json", Json)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiNewSettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiNewSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   The template or URL to base the new stack off of.
    /// </summary>
    public virtual string Template { get; internal set; }
    /// <summary>
    ///   Config to save.
    /// </summary>
    public virtual IReadOnlyList<string> Config => ConfigInternal.AsReadOnly();
    internal List<string> ConfigInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Config keys contain a path to a property in a map or list to set.
    /// </summary>
    public virtual bool? ConfigPath { get; internal set; }
    /// <summary>
    ///   The project description; if not specified, a prompt will request it.
    /// </summary>
    public virtual string Description { get; internal set; }
    /// <summary>
    ///   The location to place the generated project; if not specified, the current directory is used.
    /// </summary>
    public virtual string Directory { get; internal set; }
    /// <summary>
    ///   Forces content to be generated even if it would change existing files.
    /// </summary>
    public virtual bool? Force { get; internal set; }
    /// <summary>
    ///   Generate the project only; do not create a stack, save config, or install dependencies.
    /// </summary>
    public virtual bool? GenerateOnly { get; internal set; }
    /// <summary>
    ///   The project name; if not specified, a prompt will request it.
    /// </summary>
    public virtual string Name { get; internal set; }
    /// <summary>
    ///   Use locally cached templates without making any network requests.
    /// </summary>
    public virtual bool? Offline { get; internal set; }
    /// <summary>
    ///   The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).
    /// </summary>
    public virtual PulumiSecretsProvider SecretsProvider { get; internal set; }
    /// <summary>
    ///   The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Skip prompts and proceed with default values.
    /// </summary>
    public virtual bool? Yes { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("new")
          .Add("{value}", Template)
          .Add("--config {value}", Config)
          .Add("--config-path", ConfigPath)
          .Add("--description {value}", Description)
          .Add("--dir {value}", Directory)
          .Add("--force", Force)
          .Add("--generate-only", GenerateOnly)
          .Add("--name {value}", Name)
          .Add("--offline", Offline)
          .Add("--secrets-provider {value}", SecretsProvider)
          .Add("--stack {value}", Stack)
          .Add("--yes", Yes)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiDestroySettings
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class PulumiDestroySettings : ToolSettings
{
    /// <summary>
    ///   Path to the Pulumi executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? PulumiTasks.PulumiPath;
    public override Action<OutputType, string> ProcessCustomLogger => base.ProcessCustomLogger ?? PulumiTasks.PulumiLogger;
    /// <summary>
    ///   Use the configuration values in the specified file rather than detecting the file name.
    /// </summary>
    public virtual string ConfigFile { get; internal set; }
    /// <summary>
    ///   Print detailed debugging output during resource operations.
    /// </summary>
    public virtual bool? Debug { get; internal set; }
    /// <summary>
    ///   Display operation as a rich diff showing the overall change.
    /// </summary>
    public virtual bool? Diff { get; internal set; }
    /// <summary>
    ///   Optional message to associate with the destroy operation.
    /// </summary>
    public virtual string Message { get; internal set; }
    /// <summary>
    ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).
    /// </summary>
    public virtual int? Parallel { get; internal set; }
    /// <summary>
    ///   Refresh the state of the stack's resources before this update.
    /// </summary>
    public virtual bool? Refresh { get; internal set; }
    /// <summary>
    ///   Show configuration keys and variables.
    /// </summary>
    public virtual bool? ShowConfig { get; internal set; }
    /// <summary>
    ///   Show detailed resource replacement creates and deletes instead of a single step.
    /// </summary>
    public virtual bool? ShowReplacementSteps { get; internal set; }
    /// <summary>
    ///   Show resources that don't need to be updated because they haven't changed, alongside those that do.
    /// </summary>
    public virtual bool? ShowSames { get; internal set; }
    /// <summary>
    ///   Do not perform a preview before performing the destroy.
    /// </summary>
    public virtual bool? SkipPreview { get; internal set; }
    /// <summary>
    ///   The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.
    /// </summary>
    public virtual string Stack { get; internal set; }
    /// <summary>
    ///   Suppress display of stack outputs (in case they contain sensitive values).
    /// </summary>
    public virtual bool? SuppressOutputs { get; internal set; }
    /// <summary>
    ///   Suppress display of the state permalink.
    /// </summary>
    public virtual bool? SuppressPermalink { get; internal set; }
    /// <summary>
    ///   Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.
    /// </summary>
    public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
    internal List<string> TargetInternal { get; set; } = new List<string>();
    /// <summary>
    ///   Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.
    /// </summary>
    public virtual bool? TargetDependents { get; internal set; }
    /// <summary>
    ///   Automatically approve and perform the destroy after previewing it.
    /// </summary>
    public virtual bool? Yes { get; internal set; }
    /// <summary>
    ///   Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).
    /// </summary>
    public virtual string Color { get; internal set; }
    /// <summary>
    ///   Run pulumi as if it had been started in another directory.
    /// </summary>
    public virtual string Cwd { get; internal set; }
    /// <summary>
    ///   Disable integrity checking of checkpoint files.
    /// </summary>
    public virtual bool? DisableIntegrityChecking { get; internal set; }
    /// <summary>
    ///   Enable emojis in the output.
    /// </summary>
    public virtual bool? Emoji { get; internal set; }
    /// <summary>
    ///   Flow log settings to child processes (like plugins).
    /// </summary>
    public virtual bool? LogFlow { get; internal set; }
    /// <summary>
    ///   Log to stderr instead of to files.
    /// </summary>
    public virtual bool? LogToStderr { get; internal set; }
    /// <summary>
    ///   Disable interactive mode for all commands.
    /// </summary>
    public virtual bool? NonInteractive { get; internal set; }
    /// <summary>
    ///   Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.
    /// </summary>
    public virtual string Profiling { get; internal set; }
    /// <summary>
    ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.
    /// </summary>
    public virtual string Tracing { get; internal set; }
    /// <summary>
    ///   Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.
    /// </summary>
    public virtual int? Verbose { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("destroy")
          .Add("--config-file {value}", ConfigFile)
          .Add("--debug", Debug)
          .Add("--diff", Diff)
          .Add("--message {value}", Message)
          .Add("--parallel {value}", Parallel)
          .Add("--refresh", Refresh)
          .Add("--show-config", ShowConfig)
          .Add("--show-replacement-steps", ShowReplacementSteps)
          .Add("--show-sames", ShowSames)
          .Add("--skip-preview", SkipPreview)
          .Add("--stack {value}", Stack)
          .Add("--suppress-outputs", SuppressOutputs)
          .Add("--suppress-permalink", SuppressPermalink)
          .Add("--target {value}", Target)
          .Add("--target-dependents", TargetDependents)
          .Add("--yes", Yes)
          .Add("--color {value}", Color)
          .Add("--cwd {value}", Cwd)
          .Add("--disable-integrity-checking", DisableIntegrityChecking)
          .Add("--emoji", Emoji)
          .Add("--logflow", LogFlow)
          .Add("--logtostderr", LogToStderr)
          .Add("--non-interactive", NonInteractive)
          .Add("--profiling {value}", Profiling)
          .Add("--tracing {value}", Tracing)
          .Add("--verbose {value}", Verbose);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region PulumiUpSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiUpSettingsExtensions
{
    #region Config
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Config"/> to a new list</em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, params string[] config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Config"/> to a new list</em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, params string[] config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T ClearConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, params string[] config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region ConfigFile
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T SetConfigFile<T>(this T toolSettings, string configFile) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = configFile;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigFile<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = null;
        return toolSettings;
    }
    #endregion
    #region ConfigPath
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetConfigPath<T>(this T toolSettings, bool? configPath) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = configPath;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigPath<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T EnableConfigPath<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T DisableConfigPath<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ToggleConfigPath<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = !toolSettings.ConfigPath;
        return toolSettings;
    }
    #endregion
    #region Debug
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T SetDebug<T>(this T toolSettings, bool? debug) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = debug;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ResetDebug<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T EnableDebug<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T DisableDebug<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ToggleDebug<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = !toolSettings.Debug;
        return toolSettings;
    }
    #endregion
    #region Diff
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T SetDiff<T>(this T toolSettings, bool? diff) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = diff;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ResetDiff<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T EnableDiff<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T DisableDiff<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ToggleDiff<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = !toolSettings.Diff;
        return toolSettings;
    }
    #endregion
    #region ExpectNoChanges
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T SetExpectNoChanges<T>(this T toolSettings, bool? expectNoChanges) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = expectNoChanges;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T ResetExpectNoChanges<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T EnableExpectNoChanges<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T DisableExpectNoChanges<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T ToggleExpectNoChanges<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = !toolSettings.ExpectNoChanges;
        return toolSettings;
    }
    #endregion
    #region Message
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Message"/></em></p>
    ///   <p>Optional message to associate with the update operation.</p>
    /// </summary>
    [Pure]
    public static T SetMessage<T>(this T toolSettings, string message) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = message;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Message"/></em></p>
    ///   <p>Optional message to associate with the update operation.</p>
    /// </summary>
    [Pure]
    public static T ResetMessage<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = null;
        return toolSettings;
    }
    #endregion
    #region Parallel
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T SetParallel<T>(this T toolSettings, int? parallel) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = parallel;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetParallel<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = null;
        return toolSettings;
    }
    #endregion
    #region PolicyPack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.PolicyPack"/> to a new list</em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal = policyPack.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.PolicyPack"/> to a new list</em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal = policyPack.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.AddRange(policyPack);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.AddRange(policyPack);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T ClearPolicyPack<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPack);
        toolSettings.PolicyPackInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPack);
        toolSettings.PolicyPackInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region PolicyPackConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.PolicyPackConfig"/> to a new list</em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal = policyPackConfig.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.PolicyPackConfig"/> to a new list</em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal = policyPackConfig.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.AddRange(policyPackConfig);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.AddRange(policyPackConfig);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T ClearPolicyPackConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPackConfig);
        toolSettings.PolicyPackConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPackConfig);
        toolSettings.PolicyPackConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region Refresh
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T SetRefresh<T>(this T toolSettings, bool? refresh) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = refresh;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ResetRefresh<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T EnableRefresh<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T DisableRefresh<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ToggleRefresh<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = !toolSettings.Refresh;
        return toolSettings;
    }
    #endregion
    #region Replace
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Replace"/> to a new list</em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetReplace<T>(this T toolSettings, params string[] replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal = replace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Replace"/> to a new list</em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal = replace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddReplace<T>(this T toolSettings, params string[] replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.AddRange(replace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.AddRange(replace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearReplace<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveReplace<T>(this T toolSettings, params string[] replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(replace);
        toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(replace);
        toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region SecretsProvider
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>). Only used when creating a new stack from an existing template (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T SetSecretsProvider<T>(this T toolSettings, PulumiSecretsProvider secretsProvider) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = secretsProvider;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>). Only used when creating a new stack from an existing template (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetSecretsProvider<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = null;
        return toolSettings;
    }
    #endregion
    #region ShowConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T SetShowConfig<T>(this T toolSettings, bool? showConfig) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = showConfig;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ResetShowConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T EnableShowConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T DisableShowConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowConfig<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = !toolSettings.ShowConfig;
        return toolSettings;
    }
    #endregion
    #region ShowReads
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T SetShowReads<T>(this T toolSettings, bool? showReads) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = showReads;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T ResetShowReads<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T EnableShowReads<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T DisableShowReads<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowReads<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = !toolSettings.ShowReads;
        return toolSettings;
    }
    #endregion
    #region ShowReplacementSteps
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T SetShowReplacementSteps<T>(this T toolSettings, bool? showReplacementSteps) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = showReplacementSteps;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ResetShowReplacementSteps<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T EnableShowReplacementSteps<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T DisableShowReplacementSteps<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowReplacementSteps<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
        return toolSettings;
    }
    #endregion
    #region ShowSames
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T SetShowSames<T>(this T toolSettings, bool? showSames) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = showSames;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSames<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSames<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSames<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSames<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = !toolSettings.ShowSames;
        return toolSettings;
    }
    #endregion
    #region SkipPreview
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the update.</p>
    /// </summary>
    [Pure]
    public static T SetSkipPreview<T>(this T toolSettings, bool? skipPreview) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = skipPreview;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the update.</p>
    /// </summary>
    [Pure]
    public static T ResetSkipPreview<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the update.</p>
    /// </summary>
    [Pure]
    public static T EnableSkipPreview<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the update.</p>
    /// </summary>
    [Pure]
    public static T DisableSkipPreview<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the update.</p>
    /// </summary>
    [Pure]
    public static T ToggleSkipPreview<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = !toolSettings.SkipPreview;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region SuppressOutputs
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T SetSuppressOutputs<T>(this T toolSettings, bool? suppressOutputs) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = suppressOutputs;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressOutputs<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressOutputs<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressOutputs<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressOutputs<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
        return toolSettings;
    }
    #endregion
    #region SuppressPermalink
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T SetSuppressPermalink<T>(this T toolSettings, bool? suppressPermalink) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = suppressPermalink;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressPermalink<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressPermalink<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressPermalink<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressPermalink<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = !toolSettings.SuppressPermalink;
        return toolSettings;
    }
    #endregion
    #region Target
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, params string[] target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, params string[] target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearTarget<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, params string[] target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region TargetDependents
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T SetTargetDependents<T>(this T toolSettings, bool? targetDependents) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = targetDependents;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ResetTargetDependents<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T EnableTargetDependents<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T DisableTargetDependents<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ToggleTargetDependents<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = !toolSettings.TargetDependents;
        return toolSettings;
    }
    #endregion
    #region TargetReplace
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.TargetReplace"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal = targetReplace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.TargetReplace"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal = targetReplace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.AddRange(targetReplace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiUpSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.AddRange(targetReplace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiUpSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearTargetReplace<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(targetReplace);
        toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiUpSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(targetReplace);
        toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region Yes
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the update after previewing it.</p>
    /// </summary>
    [Pure]
    public static T SetYes<T>(this T toolSettings, bool? yes) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = yes;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the update after previewing it.</p>
    /// </summary>
    [Pure]
    public static T ResetYes<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the update after previewing it.</p>
    /// </summary>
    [Pure]
    public static T EnableYes<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the update after previewing it.</p>
    /// </summary>
    [Pure]
    public static T DisableYes<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the update after previewing it.</p>
    /// </summary>
    [Pure]
    public static T ToggleYes<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = !toolSettings.Yes;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiUpSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiUpSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiUpSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiUpSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiUpSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiUpSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiPreviewSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiPreviewSettingsExtensions
{
    #region Config
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Config"/> to a new list</em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, params string[] config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Config"/> to a new list</em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, params string[] config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T ClearConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, params string[] config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Config"/></em></p>
    ///   <p>Config to use during the update.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region ConfigFile
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T SetConfigFile<T>(this T toolSettings, string configFile) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = configFile;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigFile<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = null;
        return toolSettings;
    }
    #endregion
    #region ConfigPath
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetConfigPath<T>(this T toolSettings, bool? configPath) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = configPath;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigPath<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T EnableConfigPath<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T DisableConfigPath<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ToggleConfigPath<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = !toolSettings.ConfigPath;
        return toolSettings;
    }
    #endregion
    #region Debug
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T SetDebug<T>(this T toolSettings, bool? debug) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = debug;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ResetDebug<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T EnableDebug<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T DisableDebug<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ToggleDebug<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = !toolSettings.Debug;
        return toolSettings;
    }
    #endregion
    #region Diff
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T SetDiff<T>(this T toolSettings, bool? diff) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = diff;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ResetDiff<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T EnableDiff<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T DisableDiff<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ToggleDiff<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = !toolSettings.Diff;
        return toolSettings;
    }
    #endregion
    #region ExpectNoChanges
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T SetExpectNoChanges<T>(this T toolSettings, bool? expectNoChanges) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = expectNoChanges;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T ResetExpectNoChanges<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T EnableExpectNoChanges<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T DisableExpectNoChanges<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
    ///   <p>Return an error if any changes occur during this update.</p>
    /// </summary>
    [Pure]
    public static T ToggleExpectNoChanges<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ExpectNoChanges = !toolSettings.ExpectNoChanges;
        return toolSettings;
    }
    #endregion
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region Message
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Message"/></em></p>
    ///   <p>Optional message to associate with the update operation.</p>
    /// </summary>
    [Pure]
    public static T SetMessage<T>(this T toolSettings, string message) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = message;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Message"/></em></p>
    ///   <p>Optional message to associate with the update operation.</p>
    /// </summary>
    [Pure]
    public static T ResetMessage<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = null;
        return toolSettings;
    }
    #endregion
    #region Parallel
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T SetParallel<T>(this T toolSettings, int? parallel) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = parallel;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetParallel<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = null;
        return toolSettings;
    }
    #endregion
    #region PolicyPack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.PolicyPack"/> to a new list</em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal = policyPack.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.PolicyPack"/> to a new list</em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal = policyPack.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.AddRange(policyPack);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.AddRange(policyPack);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T ClearPolicyPack<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPack<T>(this T toolSettings, params string[] policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPack);
        toolSettings.PolicyPackInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.PolicyPack"/></em></p>
    ///   <p>Run one or more policy packs as part of this update.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPack<T>(this T toolSettings, IEnumerable<string> policyPack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPack);
        toolSettings.PolicyPackInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region PolicyPackConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.PolicyPackConfig"/> to a new list</em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal = policyPackConfig.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.PolicyPackConfig"/> to a new list</em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T SetPolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal = policyPackConfig.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.AddRange(policyPackConfig);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T AddPolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.AddRange(policyPackConfig);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T ClearPolicyPackConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PolicyPackConfigInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPackConfig<T>(this T toolSettings, params string[] policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPackConfig);
        toolSettings.PolicyPackConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.PolicyPackConfig"/></em></p>
    ///   <p>Path to JSON file containing the config for the policy pack of the corresponding <c>--policy-pack</c> flag.</p>
    /// </summary>
    [Pure]
    public static T RemovePolicyPackConfig<T>(this T toolSettings, IEnumerable<string> policyPackConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(policyPackConfig);
        toolSettings.PolicyPackConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region Refresh
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T SetRefresh<T>(this T toolSettings, bool? refresh) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = refresh;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ResetRefresh<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T EnableRefresh<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T DisableRefresh<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ToggleRefresh<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = !toolSettings.Refresh;
        return toolSettings;
    }
    #endregion
    #region Replace
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Replace"/> to a new list</em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetReplace<T>(this T toolSettings, params string[] replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal = replace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Replace"/> to a new list</em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal = replace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddReplace<T>(this T toolSettings, params string[] replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.AddRange(replace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.AddRange(replace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearReplace<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ReplaceInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveReplace<T>(this T toolSettings, params string[] replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(replace);
        toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Replace"/></em></p>
    ///   <p>Specify resources to replace. Multiple resources can be specified using <c>--replace urn1 --replace urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveReplace<T>(this T toolSettings, IEnumerable<string> replace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(replace);
        toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region ShowConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T SetShowConfig<T>(this T toolSettings, bool? showConfig) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = showConfig;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ResetShowConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T EnableShowConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T DisableShowConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowConfig<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = !toolSettings.ShowConfig;
        return toolSettings;
    }
    #endregion
    #region ShowReads
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T SetShowReads<T>(this T toolSettings, bool? showReads) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = showReads;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T ResetShowReads<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T EnableShowReads<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T DisableShowReads<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowReads"/></em></p>
    ///   <p>Show resources that are being read in, alongside those being managed directly in the stack.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowReads<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReads = !toolSettings.ShowReads;
        return toolSettings;
    }
    #endregion
    #region ShowReplacementSteps
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T SetShowReplacementSteps<T>(this T toolSettings, bool? showReplacementSteps) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = showReplacementSteps;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ResetShowReplacementSteps<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T EnableShowReplacementSteps<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T DisableShowReplacementSteps<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowReplacementSteps<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
        return toolSettings;
    }
    #endregion
    #region ShowSames
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T SetShowSames<T>(this T toolSettings, bool? showSames) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = showSames;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSames<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSames<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSames<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSames<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = !toolSettings.ShowSames;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region SuppressOutputs
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T SetSuppressOutputs<T>(this T toolSettings, bool? suppressOutputs) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = suppressOutputs;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressOutputs<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressOutputs<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressOutputs<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressOutputs<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
        return toolSettings;
    }
    #endregion
    #region SuppressPermalink
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T SetSuppressPermalink<T>(this T toolSettings, bool? suppressPermalink) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = suppressPermalink;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressPermalink<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressPermalink<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressPermalink<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressPermalink<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = !toolSettings.SuppressPermalink;
        return toolSettings;
    }
    #endregion
    #region Target
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, params string[] target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, params string[] target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearTarget<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, params string[] target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region TargetDependents
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T SetTargetDependents<T>(this T toolSettings, bool? targetDependents) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = targetDependents;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ResetTargetDependents<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T EnableTargetDependents<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T DisableTargetDependents<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
    ///   <p>Allows updating of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ToggleTargetDependents<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = !toolSettings.TargetDependents;
        return toolSettings;
    }
    #endregion
    #region TargetReplace
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetReplace"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal = targetReplace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetReplace"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal = targetReplace.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.AddRange(targetReplace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.AddRange(targetReplace);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearTargetReplace<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetReplaceInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTargetReplace<T>(this T toolSettings, params string[] targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(targetReplace);
        toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
    ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for <c>--target urn --replace urn</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTargetReplace<T>(this T toolSettings, IEnumerable<string> targetReplace) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(targetReplace);
        toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiPreviewSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiPreviewSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiPreviewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigSettingsExtensions
{
    #region ConfigFile
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T SetConfigFile<T>(this T toolSettings, string configFile) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = configFile;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigFile<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = null;
        return toolSettings;
    }
    #endregion
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region ShowSecrets
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T SetShowSecrets<T>(this T toolSettings, bool? showSecrets) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = showSecrets;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSecrets<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSecrets<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSecrets<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSecrets<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigCopySettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigCopySettingsExtensions
{
    #region Destination
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Destination"/></em></p>
    ///   <p>The name of the new stack to copy the config to.</p>
    /// </summary>
    [Pure]
    public static T SetDestination<T>(this T toolSettings, string destination) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Destination = destination;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Destination"/></em></p>
    ///   <p>The name of the new stack to copy the config to.</p>
    /// </summary>
    [Pure]
    public static T ResetDestination<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Destination = null;
        return toolSettings;
    }
    #endregion
    #region Path
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetPath<T>(this T toolSettings, string path) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = path;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetPath<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigCopySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigCopySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigCopySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigCopySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigCopySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigCopySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigCopySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigCopySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigCopySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigCopySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigCopySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigCopySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigCopySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigCopySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigCopySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigCopySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigGetSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigGetSettingsExtensions
{
    #region Key
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T SetKey<T>(this T toolSettings, string key) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = key;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T ResetKey<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = null;
        return toolSettings;
    }
    #endregion
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region Path
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetPath<T>(this T toolSettings, string path) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = path;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetPath<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigRefreshSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigRefreshSettingsExtensions
{
    #region Force
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
    ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
    /// </summary>
    [Pure]
    public static T SetForce<T>(this T toolSettings, bool? force) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = force;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
    ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
    /// </summary>
    [Pure]
    public static T ResetForce<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
    ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
    /// </summary>
    [Pure]
    public static T EnableForce<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
    ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
    /// </summary>
    [Pure]
    public static T DisableForce<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
    ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
    /// </summary>
    [Pure]
    public static T ToggleForce<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = !toolSettings.Force;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigRefreshSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigRemoveSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigRemoveSettingsExtensions
{
    #region Key
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T SetKey<T>(this T toolSettings, string key) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = key;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T ResetKey<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = null;
        return toolSettings;
    }
    #endregion
    #region Path
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetPath<T>(this T toolSettings, string path) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = path;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetPath<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiConfigSetSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiConfigSetSettingsExtensions
{
    #region Key
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T SetKey<T>(this T toolSettings, string key) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = key;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Key"/></em></p>
    ///   <p>The key to the key-value pair in the configuration.</p>
    /// </summary>
    [Pure]
    public static T ResetKey<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Key = null;
        return toolSettings;
    }
    #endregion
    #region Value
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Value"/></em></p>
    ///   <p>The new value for specified configuration key.</p>
    /// </summary>
    [Pure]
    public static T SetValue<T>(this T toolSettings, string value) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Value = value;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Value"/></em></p>
    ///   <p>The new value for specified configuration key.</p>
    /// </summary>
    [Pure]
    public static T ResetValue<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Value = null;
        return toolSettings;
    }
    #endregion
    #region Path
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetPath<T>(this T toolSettings, string path) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = path;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Path"/></em></p>
    ///   <p>The key contains a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetPath<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Path = null;
        return toolSettings;
    }
    #endregion
    #region Plaintext
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
    ///   <p>Save the value as plaintext (unencrypted).</p>
    /// </summary>
    [Pure]
    public static T SetPlaintext<T>(this T toolSettings, bool? plaintext) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Plaintext = plaintext;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
    ///   <p>Save the value as plaintext (unencrypted).</p>
    /// </summary>
    [Pure]
    public static T ResetPlaintext<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Plaintext = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
    ///   <p>Save the value as plaintext (unencrypted).</p>
    /// </summary>
    [Pure]
    public static T EnablePlaintext<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Plaintext = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
    ///   <p>Save the value as plaintext (unencrypted).</p>
    /// </summary>
    [Pure]
    public static T DisablePlaintext<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Plaintext = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
    ///   <p>Save the value as plaintext (unencrypted).</p>
    /// </summary>
    [Pure]
    public static T TogglePlaintext<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Plaintext = !toolSettings.Plaintext;
        return toolSettings;
    }
    #endregion
    #region Secret
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Secret"/></em></p>
    ///   <p>Encrypt the value instead of storing it in plaintext.</p>
    /// </summary>
    [Pure]
    public static T SetSecret<T>(this T toolSettings, bool? secret) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Secret = secret;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Secret"/></em></p>
    ///   <p>Encrypt the value instead of storing it in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ResetSecret<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Secret = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Secret"/></em></p>
    ///   <p>Encrypt the value instead of storing it in plaintext.</p>
    /// </summary>
    [Pure]
    public static T EnableSecret<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Secret = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Secret"/></em></p>
    ///   <p>Encrypt the value instead of storing it in plaintext.</p>
    /// </summary>
    [Pure]
    public static T DisableSecret<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Secret = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Secret"/></em></p>
    ///   <p>Encrypt the value instead of storing it in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ToggleSecret<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Secret = !toolSettings.Secret;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiConfigSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackSettingsExtensions
{
    #region ShowIds
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.ShowIds"/></em></p>
    ///   <p>Display each resource's provider-assigned unique ID.</p>
    /// </summary>
    [Pure]
    public static T SetShowIds<T>(this T toolSettings, bool? showIds) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowIds = showIds;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.ShowIds"/></em></p>
    ///   <p>Display each resource's provider-assigned unique ID.</p>
    /// </summary>
    [Pure]
    public static T ResetShowIds<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowIds = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.ShowIds"/></em></p>
    ///   <p>Display each resource's provider-assigned unique ID.</p>
    /// </summary>
    [Pure]
    public static T EnableShowIds<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowIds = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.ShowIds"/></em></p>
    ///   <p>Display each resource's provider-assigned unique ID.</p>
    /// </summary>
    [Pure]
    public static T DisableShowIds<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowIds = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowIds"/></em></p>
    ///   <p>Display each resource's provider-assigned unique ID.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowIds<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowIds = !toolSettings.ShowIds;
        return toolSettings;
    }
    #endregion
    #region ShowName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.ShowName"/></em></p>
    ///   <p>Display only the stack name.</p>
    /// </summary>
    [Pure]
    public static T SetShowName<T>(this T toolSettings, bool? showName) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowName = showName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.ShowName"/></em></p>
    ///   <p>Display only the stack name.</p>
    /// </summary>
    [Pure]
    public static T ResetShowName<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowName = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.ShowName"/></em></p>
    ///   <p>Display only the stack name.</p>
    /// </summary>
    [Pure]
    public static T EnableShowName<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowName = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.ShowName"/></em></p>
    ///   <p>Display only the stack name.</p>
    /// </summary>
    [Pure]
    public static T DisableShowName<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowName = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowName"/></em></p>
    ///   <p>Display only the stack name.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowName<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowName = !toolSettings.ShowName;
        return toolSettings;
    }
    #endregion
    #region ShowSecrets
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T SetShowSecrets<T>(this T toolSettings, bool? showSecrets) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = showSecrets;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSecrets<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSecrets<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSecrets<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSecrets<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
        return toolSettings;
    }
    #endregion
    #region ShowUrns
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.ShowUrns"/></em></p>
    ///   <p>Display each resource's Pulumi-assigned globally unique URN.</p>
    /// </summary>
    [Pure]
    public static T SetShowUrns<T>(this T toolSettings, bool? showUrns) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowUrns = showUrns;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.ShowUrns"/></em></p>
    ///   <p>Display each resource's Pulumi-assigned globally unique URN.</p>
    /// </summary>
    [Pure]
    public static T ResetShowUrns<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowUrns = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.ShowUrns"/></em></p>
    ///   <p>Display each resource's Pulumi-assigned globally unique URN.</p>
    /// </summary>
    [Pure]
    public static T EnableShowUrns<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowUrns = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.ShowUrns"/></em></p>
    ///   <p>Display each resource's Pulumi-assigned globally unique URN.</p>
    /// </summary>
    [Pure]
    public static T DisableShowUrns<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowUrns = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowUrns"/></em></p>
    ///   <p>Display each resource's Pulumi-assigned globally unique URN.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowUrns<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowUrns = !toolSettings.ShowUrns;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Stack"/></em></p>
    ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackChangeSecretsProviderSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackChangeSecretsProviderSettingsExtensions
{
    #region NewSecretsProvider
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.NewSecretsProvider"/></em></p>
    ///   <p>The name of the new secrets provider.</p>
    /// </summary>
    [Pure]
    public static T SetNewSecretsProvider<T>(this T toolSettings, string newSecretsProvider) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NewSecretsProvider = newSecretsProvider;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.NewSecretsProvider"/></em></p>
    ///   <p>The name of the new secrets provider.</p>
    /// </summary>
    [Pure]
    public static T ResetNewSecretsProvider<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NewSecretsProvider = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackChangeSecretsProviderSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackChangeSecretsProviderSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackChangeSecretsProviderSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackChangeSecretsProviderSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackChangeSecretsProviderSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackChangeSecretsProviderSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackChangeSecretsProviderSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackChangeSecretsProviderSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackExportSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackExportSettingsExtensions
{
    #region File
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.File"/></em></p>
    ///   <p>A filename to write stack output to.</p>
    /// </summary>
    [Pure]
    public static T SetFile<T>(this T toolSettings, string file) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = file;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.File"/></em></p>
    ///   <p>A filename to write stack output to.</p>
    /// </summary>
    [Pure]
    public static T ResetFile<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = null;
        return toolSettings;
    }
    #endregion
    #region ShowSecrets
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T SetShowSecrets<T>(this T toolSettings, bool? showSecrets) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = showSecrets;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSecrets<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSecrets<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSecrets<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.ShowSecrets"/></em></p>
    ///   <p>Display stack outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSecrets<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
        return toolSettings;
    }
    #endregion
    #region Version
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Version"/></em></p>
    ///   <p>Previous stack version to export. (If unset, will export the latest.).</p>
    /// </summary>
    [Pure]
    public static T SetVersion<T>(this T toolSettings, string version) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Version = version;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Version"/></em></p>
    ///   <p>Previous stack version to export. (If unset, will export the latest.).</p>
    /// </summary>
    [Pure]
    public static T ResetVersion<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Version = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackExportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackExportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackExportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackExportSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackExportSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackExportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackGraphSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackGraphSettingsExtensions
{
    #region File
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.File"/></em></p>
    ///   <p>A file that will have a Graphviz DOT graph written to it.</p>
    /// </summary>
    [Pure]
    public static T SetFile<T>(this T toolSettings, string file) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = file;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.File"/></em></p>
    ///   <p>A file that will have a Graphviz DOT graph written to it.</p>
    /// </summary>
    [Pure]
    public static T ResetFile<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = null;
        return toolSettings;
    }
    #endregion
    #region DependencyEdgeColor
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.DependencyEdgeColor"/></em></p>
    ///   <p>Sets the color of dependency edges in the graph (default <c>#246C60</c>).</p>
    /// </summary>
    [Pure]
    public static T SetDependencyEdgeColor<T>(this T toolSettings, string dependencyEdgeColor) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DependencyEdgeColor = dependencyEdgeColor;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.DependencyEdgeColor"/></em></p>
    ///   <p>Sets the color of dependency edges in the graph (default <c>#246C60</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetDependencyEdgeColor<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DependencyEdgeColor = null;
        return toolSettings;
    }
    #endregion
    #region IgnoreDependencyEdges
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></em></p>
    ///   <p>Ignores edges introduced by dependency resource relationships.</p>
    /// </summary>
    [Pure]
    public static T SetIgnoreDependencyEdges<T>(this T toolSettings, bool? ignoreDependencyEdges) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreDependencyEdges = ignoreDependencyEdges;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></em></p>
    ///   <p>Ignores edges introduced by dependency resource relationships.</p>
    /// </summary>
    [Pure]
    public static T ResetIgnoreDependencyEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreDependencyEdges = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></em></p>
    ///   <p>Ignores edges introduced by dependency resource relationships.</p>
    /// </summary>
    [Pure]
    public static T EnableIgnoreDependencyEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreDependencyEdges = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></em></p>
    ///   <p>Ignores edges introduced by dependency resource relationships.</p>
    /// </summary>
    [Pure]
    public static T DisableIgnoreDependencyEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreDependencyEdges = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.IgnoreDependencyEdges"/></em></p>
    ///   <p>Ignores edges introduced by dependency resource relationships.</p>
    /// </summary>
    [Pure]
    public static T ToggleIgnoreDependencyEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreDependencyEdges = !toolSettings.IgnoreDependencyEdges;
        return toolSettings;
    }
    #endregion
    #region IgnoreParentEdges
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></em></p>
    ///   <p>Ignores edges introduced by parent/child resource relationships.</p>
    /// </summary>
    [Pure]
    public static T SetIgnoreParentEdges<T>(this T toolSettings, bool? ignoreParentEdges) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreParentEdges = ignoreParentEdges;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></em></p>
    ///   <p>Ignores edges introduced by parent/child resource relationships.</p>
    /// </summary>
    [Pure]
    public static T ResetIgnoreParentEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreParentEdges = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></em></p>
    ///   <p>Ignores edges introduced by parent/child resource relationships.</p>
    /// </summary>
    [Pure]
    public static T EnableIgnoreParentEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreParentEdges = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></em></p>
    ///   <p>Ignores edges introduced by parent/child resource relationships.</p>
    /// </summary>
    [Pure]
    public static T DisableIgnoreParentEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreParentEdges = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.IgnoreParentEdges"/></em></p>
    ///   <p>Ignores edges introduced by parent/child resource relationships.</p>
    /// </summary>
    [Pure]
    public static T ToggleIgnoreParentEdges<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.IgnoreParentEdges = !toolSettings.IgnoreParentEdges;
        return toolSettings;
    }
    #endregion
    #region ParentEdgeColor
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.ParentEdgeColor"/></em></p>
    ///   <p>Sets the color of parent edges in the graph (default <c>#AA6639</c>).</p>
    /// </summary>
    [Pure]
    public static T SetParentEdgeColor<T>(this T toolSettings, string parentEdgeColor) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ParentEdgeColor = parentEdgeColor;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.ParentEdgeColor"/></em></p>
    ///   <p>Sets the color of parent edges in the graph (default <c>#AA6639</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetParentEdgeColor<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ParentEdgeColor = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackGraphSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackGraphSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackGraphSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackGraphSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackGraphSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackGraphSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackHistorySettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackHistorySettingsExtensions
{
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.Json"/></em></p>
    ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region ShowSecrets
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T SetShowSecrets<T>(this T toolSettings, bool? showSecrets) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = showSecrets;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSecrets<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSecrets<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSecrets<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.ShowSecrets"/></em></p>
    ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSecrets<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackHistorySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackHistorySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackHistorySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackHistorySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackHistorySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackHistorySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackImportSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackImportSettingsExtensions
{
    #region File
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.File"/></em></p>
    ///   <p>A filename to read stack input from.</p>
    /// </summary>
    [Pure]
    public static T SetFile<T>(this T toolSettings, string file) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = file;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.File"/></em></p>
    ///   <p>A filename to read stack input from.</p>
    /// </summary>
    [Pure]
    public static T ResetFile<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = null;
        return toolSettings;
    }
    #endregion
    #region Force
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Force"/></em></p>
    ///   <p>Force the import to occur, even if apparent errors are discovered beforehand (not recommended).</p>
    /// </summary>
    [Pure]
    public static T SetForce<T>(this T toolSettings, bool? force) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = force;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Force"/></em></p>
    ///   <p>Force the import to occur, even if apparent errors are discovered beforehand (not recommended).</p>
    /// </summary>
    [Pure]
    public static T ResetForce<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.Force"/></em></p>
    ///   <p>Force the import to occur, even if apparent errors are discovered beforehand (not recommended).</p>
    /// </summary>
    [Pure]
    public static T EnableForce<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.Force"/></em></p>
    ///   <p>Force the import to occur, even if apparent errors are discovered beforehand (not recommended).</p>
    /// </summary>
    [Pure]
    public static T DisableForce<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.Force"/></em></p>
    ///   <p>Force the import to occur, even if apparent errors are discovered beforehand (not recommended).</p>
    /// </summary>
    [Pure]
    public static T ToggleForce<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = !toolSettings.Force;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackImportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackImportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackImportSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackImportSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackImportSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackImportSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackInitSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackInitSettingsExtensions
{
    #region OrganizationAndName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.OrganizationAndName"/></em></p>
    ///   <p>The stack name, optionally preceded by the organization name and a slash: <c>[&lt;org-name&gt;/]&lt;stack-name&gt;</c></p>
    /// </summary>
    [Pure]
    public static T SetOrganizationAndName<T>(this T toolSettings, string organizationAndName) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.OrganizationAndName = organizationAndName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.OrganizationAndName"/></em></p>
    ///   <p>The stack name, optionally preceded by the organization name and a slash: <c>[&lt;org-name&gt;/]&lt;stack-name&gt;</c></p>
    /// </summary>
    [Pure]
    public static T ResetOrganizationAndName<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.OrganizationAndName = null;
        return toolSettings;
    }
    #endregion
    #region CopyConfigFrom
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.CopyConfigFrom"/></em></p>
    ///   <p>The name of the stack to copy existing config from.</p>
    /// </summary>
    [Pure]
    public static T SetCopyConfigFrom<T>(this T toolSettings, string copyConfigFrom) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.CopyConfigFrom = copyConfigFrom;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.CopyConfigFrom"/></em></p>
    ///   <p>The name of the stack to copy existing config from.</p>
    /// </summary>
    [Pure]
    public static T ResetCopyConfigFrom<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.CopyConfigFrom = null;
        return toolSettings;
    }
    #endregion
    #region SecretsProvider
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T SetSecretsProvider<T>(this T toolSettings, PulumiSecretsProvider secretsProvider) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = secretsProvider;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetSecretsProvider<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackInitSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackInitSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackInitSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackInitSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackInitSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackInitSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackInitSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackInitSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackInitSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackInitSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackInitSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackInitSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackInitSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackInitSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackInitSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackInitSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackListSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackListSettingsExtensions
{
    #region All
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.All"/></em></p>
    ///   <p>List all stacks instead of just stacks for the current project.</p>
    /// </summary>
    [Pure]
    public static T SetAll<T>(this T toolSettings, bool? all) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.All = all;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.All"/></em></p>
    ///   <p>List all stacks instead of just stacks for the current project.</p>
    /// </summary>
    [Pure]
    public static T ResetAll<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.All = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.All"/></em></p>
    ///   <p>List all stacks instead of just stacks for the current project.</p>
    /// </summary>
    [Pure]
    public static T EnableAll<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.All = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.All"/></em></p>
    ///   <p>List all stacks instead of just stacks for the current project.</p>
    /// </summary>
    [Pure]
    public static T DisableAll<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.All = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.All"/></em></p>
    ///   <p>List all stacks instead of just stacks for the current project.</p>
    /// </summary>
    [Pure]
    public static T ToggleAll<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.All = !toolSettings.All;
        return toolSettings;
    }
    #endregion
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region Organization
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Organization"/></em></p>
    ///   <p>Filter returned stacks to those in a specific organization.</p>
    /// </summary>
    [Pure]
    public static T SetOrganization<T>(this T toolSettings, string organization) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Organization = organization;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Organization"/></em></p>
    ///   <p>Filter returned stacks to those in a specific organization.</p>
    /// </summary>
    [Pure]
    public static T ResetOrganization<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Organization = null;
        return toolSettings;
    }
    #endregion
    #region Project
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Project"/></em></p>
    ///   <p>Filter returned stacks to those with a specific project name.</p>
    /// </summary>
    [Pure]
    public static T SetProject<T>(this T toolSettings, string project) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Project = project;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Project"/></em></p>
    ///   <p>Filter returned stacks to those with a specific project name.</p>
    /// </summary>
    [Pure]
    public static T ResetProject<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Project = null;
        return toolSettings;
    }
    #endregion
    #region Tag
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Tag"/></em></p>
    ///   <p>Filter returned stacks to those in a specific tag (<c>tag-name</c> or <c>tag-name=tag-value</c>).</p>
    /// </summary>
    [Pure]
    public static T SetTag<T>(this T toolSettings, string tag) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tag = tag;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Tag"/></em></p>
    ///   <p>Filter returned stacks to those in a specific tag (<c>tag-name</c> or <c>tag-name=tag-value</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetTag<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tag = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackListSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackListSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackOutputSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackOutputSettingsExtensions
{
    #region PropertyName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.PropertyName"/></em></p>
    ///   <p>The name of the property whose output value should be listed. This is optional.</p>
    /// </summary>
    [Pure]
    public static T SetPropertyName<T>(this T toolSettings, string propertyName) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PropertyName = propertyName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.PropertyName"/></em></p>
    ///   <p>The name of the property whose output value should be listed. This is optional.</p>
    /// </summary>
    [Pure]
    public static T ResetPropertyName<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PropertyName = null;
        return toolSettings;
    }
    #endregion
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region ShowSecrets
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
    ///   <p>Display outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T SetShowSecrets<T>(this T toolSettings, bool? showSecrets) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = showSecrets;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
    ///   <p>Display outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSecrets<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
    ///   <p>Display outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSecrets<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
    ///   <p>Display outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSecrets<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
    ///   <p>Display outputs which are marked as secret in plaintext.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSecrets<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackOutputSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackRenameSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackRenameSettingsExtensions
{
    #region NewStackName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.NewStackName"/></em></p>
    ///   <p>The new name for the stack.</p>
    /// </summary>
    [Pure]
    public static T SetNewStackName<T>(this T toolSettings, string newStackName) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NewStackName = newStackName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.NewStackName"/></em></p>
    ///   <p>The new name for the stack.</p>
    /// </summary>
    [Pure]
    public static T ResetNewStackName<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NewStackName = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRenameSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRenameSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRenameSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRenameSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRenameSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRenameSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRenameSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRenameSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRenameSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRenameSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRenameSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRenameSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRenameSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRenameSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRenameSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackRenameSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackRemoveSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackRemoveSettingsExtensions
{
    #region StackName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.StackName"/></em></p>
    ///   <p>The name for the stack to be removed.</p>
    /// </summary>
    [Pure]
    public static T SetStackName<T>(this T toolSettings, string stackName) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.StackName = stackName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.StackName"/></em></p>
    ///   <p>The name for the stack to be removed.</p>
    /// </summary>
    [Pure]
    public static T ResetStackName<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.StackName = null;
        return toolSettings;
    }
    #endregion
    #region Force
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Force"/></em></p>
    ///   <p>Forces deletion of the stack, leaving behind any resources managed by the stack.</p>
    /// </summary>
    [Pure]
    public static T SetForce<T>(this T toolSettings, bool? force) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = force;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Force"/></em></p>
    ///   <p>Forces deletion of the stack, leaving behind any resources managed by the stack.</p>
    /// </summary>
    [Pure]
    public static T ResetForce<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.Force"/></em></p>
    ///   <p>Forces deletion of the stack, leaving behind any resources managed by the stack.</p>
    /// </summary>
    [Pure]
    public static T EnableForce<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.Force"/></em></p>
    ///   <p>Forces deletion of the stack, leaving behind any resources managed by the stack.</p>
    /// </summary>
    [Pure]
    public static T DisableForce<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.Force"/></em></p>
    ///   <p>Forces deletion of the stack, leaving behind any resources managed by the stack.</p>
    /// </summary>
    [Pure]
    public static T ToggleForce<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = !toolSettings.Force;
        return toolSettings;
    }
    #endregion
    #region PreserveConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.PreserveConfig"/></em></p>
    ///   <p>Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.</p>
    /// </summary>
    [Pure]
    public static T SetPreserveConfig<T>(this T toolSettings, bool? preserveConfig) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PreserveConfig = preserveConfig;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.PreserveConfig"/></em></p>
    ///   <p>Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.</p>
    /// </summary>
    [Pure]
    public static T ResetPreserveConfig<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PreserveConfig = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.PreserveConfig"/></em></p>
    ///   <p>Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.</p>
    /// </summary>
    [Pure]
    public static T EnablePreserveConfig<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PreserveConfig = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.PreserveConfig"/></em></p>
    ///   <p>Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.</p>
    /// </summary>
    [Pure]
    public static T DisablePreserveConfig<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PreserveConfig = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.PreserveConfig"/></em></p>
    ///   <p>Do not delete the corresponding Pulumi.&lt;stack-name&gt;.yaml configuration file for the stack.</p>
    /// </summary>
    [Pure]
    public static T TogglePreserveConfig<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PreserveConfig = !toolSettings.PreserveConfig;
        return toolSettings;
    }
    #endregion
    #region Yes
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Yes"/></em></p>
    ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
    /// </summary>
    [Pure]
    public static T SetYes<T>(this T toolSettings, bool? yes) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = yes;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Yes"/></em></p>
    ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
    /// </summary>
    [Pure]
    public static T ResetYes<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.Yes"/></em></p>
    ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
    /// </summary>
    [Pure]
    public static T EnableYes<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.Yes"/></em></p>
    ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
    /// </summary>
    [Pure]
    public static T DisableYes<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.Yes"/></em></p>
    ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
    /// </summary>
    [Pure]
    public static T ToggleYes<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = !toolSettings.Yes;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackSelectSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackSelectSettingsExtensions
{
    #region StackName
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.StackName"/></em></p>
    ///   <p>The name of the stack that should be selected.</p>
    /// </summary>
    [Pure]
    public static T SetStackName<T>(this T toolSettings, string stackName) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.StackName = stackName;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.StackName"/></em></p>
    ///   <p>The name of the stack that should be selected.</p>
    /// </summary>
    [Pure]
    public static T ResetStackName<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.StackName = null;
        return toolSettings;
    }
    #endregion
    #region Create
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Create"/></em></p>
    ///   <p>If selected stack does not exist, create it.</p>
    /// </summary>
    [Pure]
    public static T SetCreate<T>(this T toolSettings, bool? create) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Create = create;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Create"/></em></p>
    ///   <p>If selected stack does not exist, create it.</p>
    /// </summary>
    [Pure]
    public static T ResetCreate<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Create = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.Create"/></em></p>
    ///   <p>If selected stack does not exist, create it.</p>
    /// </summary>
    [Pure]
    public static T EnableCreate<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Create = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.Create"/></em></p>
    ///   <p>If selected stack does not exist, create it.</p>
    /// </summary>
    [Pure]
    public static T DisableCreate<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Create = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.Create"/></em></p>
    ///   <p>If selected stack does not exist, create it.</p>
    /// </summary>
    [Pure]
    public static T ToggleCreate<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Create = !toolSettings.Create;
        return toolSettings;
    }
    #endregion
    #region SecretsProvider
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.SecretsProvider"/></em></p>
    ///   <p>Use with <c>--create</c> flag, The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T SetSecretsProvider<T>(this T toolSettings, PulumiSecretsProvider secretsProvider) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = secretsProvider;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.SecretsProvider"/></em></p>
    ///   <p>Use with <c>--create</c> flag, The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetSecretsProvider<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackSelectSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackSelectSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackSelectSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackSelectSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackSelectSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackSelectSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackTagSetSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackTagSetSettingsExtensions
{
    #region Name
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T SetName<T>(this T toolSettings, string name) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = name;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T ResetName<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = null;
        return toolSettings;
    }
    #endregion
    #region Value
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Value"/></em></p>
    ///   <p>The value of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T SetValue<T>(this T toolSettings, string value) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Value = value;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Value"/></em></p>
    ///   <p>The value of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T ResetValue<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Value = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagSetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagSetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagSetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagSetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagSetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagSetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagSetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackTagSetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackTagGetSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackTagGetSettingsExtensions
{
    #region Name
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T SetName<T>(this T toolSettings, string name) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = name;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T ResetName<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagGetSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagGetSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagGetSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagGetSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagGetSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagGetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagGetSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackTagGetSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackTagRemoveSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackTagRemoveSettingsExtensions
{
    #region Name
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T SetName<T>(this T toolSettings, string name) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = name;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Name"/></em></p>
    ///   <p>The name of the tag to be set.</p>
    /// </summary>
    [Pure]
    public static T ResetName<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = null;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagRemoveSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagRemoveSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagRemoveSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagRemoveSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagRemoveSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagRemoveSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackTagRemoveSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiStackTagListSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiStackTagListSettingsExtensions
{
    #region Json
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T SetJson<T>(this T toolSettings, bool? json) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = json;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ResetJson<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T EnableJson<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T DisableJson<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.Json"/></em></p>
    ///   <p>Emit output as JSON.</p>
    /// </summary>
    [Pure]
    public static T ToggleJson<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Json = !toolSettings.Json;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiStackTagListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiStackTagListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiStackTagListSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiStackTagListSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiStackTagListSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiStackTagListSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiNewSettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiNewSettingsExtensions
{
    #region Template
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Template"/></em></p>
    ///   <p>The template or URL to base the new stack off of.</p>
    /// </summary>
    [Pure]
    public static T SetTemplate<T>(this T toolSettings, string template) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Template = template;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Template"/></em></p>
    ///   <p>The template or URL to base the new stack off of.</p>
    /// </summary>
    [Pure]
    public static T ResetTemplate<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Template = null;
        return toolSettings;
    }
    #endregion
    #region Config
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Config"/> to a new list</em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, params string[] config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Config"/> to a new list</em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T SetConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal = config.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiNewSettings.Config"/></em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, params string[] config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiNewSettings.Config"/></em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T AddConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.AddRange(config);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiNewSettings.Config"/></em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T ClearConfig<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiNewSettings.Config"/></em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, params string[] config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiNewSettings.Config"/></em></p>
    ///   <p>Config to save.</p>
    /// </summary>
    [Pure]
    public static T RemoveConfig<T>(this T toolSettings, IEnumerable<string> config) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(config);
        toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region ConfigPath
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T SetConfigPath<T>(this T toolSettings, bool? configPath) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = configPath;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigPath<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T EnableConfigPath<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T DisableConfigPath<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.ConfigPath"/></em></p>
    ///   <p>Config keys contain a path to a property in a map or list to set.</p>
    /// </summary>
    [Pure]
    public static T ToggleConfigPath<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigPath = !toolSettings.ConfigPath;
        return toolSettings;
    }
    #endregion
    #region Description
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Description"/></em></p>
    ///   <p>The project description; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T SetDescription<T>(this T toolSettings, string description) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Description = description;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Description"/></em></p>
    ///   <p>The project description; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T ResetDescription<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Description = null;
        return toolSettings;
    }
    #endregion
    #region Directory
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Directory"/></em></p>
    ///   <p>The location to place the generated project; if not specified, the current directory is used.</p>
    /// </summary>
    [Pure]
    public static T SetDirectory<T>(this T toolSettings, string directory) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Directory = directory;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Directory"/></em></p>
    ///   <p>The location to place the generated project; if not specified, the current directory is used.</p>
    /// </summary>
    [Pure]
    public static T ResetDirectory<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Directory = null;
        return toolSettings;
    }
    #endregion
    #region Force
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Force"/></em></p>
    ///   <p>Forces content to be generated even if it would change existing files.</p>
    /// </summary>
    [Pure]
    public static T SetForce<T>(this T toolSettings, bool? force) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = force;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Force"/></em></p>
    ///   <p>Forces content to be generated even if it would change existing files.</p>
    /// </summary>
    [Pure]
    public static T ResetForce<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.Force"/></em></p>
    ///   <p>Forces content to be generated even if it would change existing files.</p>
    /// </summary>
    [Pure]
    public static T EnableForce<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.Force"/></em></p>
    ///   <p>Forces content to be generated even if it would change existing files.</p>
    /// </summary>
    [Pure]
    public static T DisableForce<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.Force"/></em></p>
    ///   <p>Forces content to be generated even if it would change existing files.</p>
    /// </summary>
    [Pure]
    public static T ToggleForce<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Force = !toolSettings.Force;
        return toolSettings;
    }
    #endregion
    #region GenerateOnly
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.GenerateOnly"/></em></p>
    ///   <p>Generate the project only; do not create a stack, save config, or install dependencies.</p>
    /// </summary>
    [Pure]
    public static T SetGenerateOnly<T>(this T toolSettings, bool? generateOnly) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.GenerateOnly = generateOnly;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.GenerateOnly"/></em></p>
    ///   <p>Generate the project only; do not create a stack, save config, or install dependencies.</p>
    /// </summary>
    [Pure]
    public static T ResetGenerateOnly<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.GenerateOnly = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.GenerateOnly"/></em></p>
    ///   <p>Generate the project only; do not create a stack, save config, or install dependencies.</p>
    /// </summary>
    [Pure]
    public static T EnableGenerateOnly<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.GenerateOnly = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.GenerateOnly"/></em></p>
    ///   <p>Generate the project only; do not create a stack, save config, or install dependencies.</p>
    /// </summary>
    [Pure]
    public static T DisableGenerateOnly<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.GenerateOnly = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.GenerateOnly"/></em></p>
    ///   <p>Generate the project only; do not create a stack, save config, or install dependencies.</p>
    /// </summary>
    [Pure]
    public static T ToggleGenerateOnly<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.GenerateOnly = !toolSettings.GenerateOnly;
        return toolSettings;
    }
    #endregion
    #region Name
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Name"/></em></p>
    ///   <p>The project name; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T SetName<T>(this T toolSettings, string name) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = name;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Name"/></em></p>
    ///   <p>The project name; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T ResetName<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Name = null;
        return toolSettings;
    }
    #endregion
    #region Offline
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Offline"/></em></p>
    ///   <p>Use locally cached templates without making any network requests.</p>
    /// </summary>
    [Pure]
    public static T SetOffline<T>(this T toolSettings, bool? offline) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Offline = offline;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Offline"/></em></p>
    ///   <p>Use locally cached templates without making any network requests.</p>
    /// </summary>
    [Pure]
    public static T ResetOffline<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Offline = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.Offline"/></em></p>
    ///   <p>Use locally cached templates without making any network requests.</p>
    /// </summary>
    [Pure]
    public static T EnableOffline<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Offline = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.Offline"/></em></p>
    ///   <p>Use locally cached templates without making any network requests.</p>
    /// </summary>
    [Pure]
    public static T DisableOffline<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Offline = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.Offline"/></em></p>
    ///   <p>Use locally cached templates without making any network requests.</p>
    /// </summary>
    [Pure]
    public static T ToggleOffline<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Offline = !toolSettings.Offline;
        return toolSettings;
    }
    #endregion
    #region SecretsProvider
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T SetSecretsProvider<T>(this T toolSettings, PulumiSecretsProvider secretsProvider) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = secretsProvider;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.SecretsProvider"/></em></p>
    ///   <p>The type of the provider that should be used to encrypt and decrypt secrets (possible choices: <c>default</c>, <c>passphrase</c>, <c>awskms</c>, <c>azurekeyvault</c>, <c>gcpkms</c>, <c>hashivault</c>) (default <c>default</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetSecretsProvider<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SecretsProvider = null;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Stack"/></em></p>
    ///   <p>The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Stack"/></em></p>
    ///   <p>The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region Yes
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Yes"/></em></p>
    ///   <p>Skip prompts and proceed with default values.</p>
    /// </summary>
    [Pure]
    public static T SetYes<T>(this T toolSettings, bool? yes) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = yes;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Yes"/></em></p>
    ///   <p>Skip prompts and proceed with default values.</p>
    /// </summary>
    [Pure]
    public static T ResetYes<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.Yes"/></em></p>
    ///   <p>Skip prompts and proceed with default values.</p>
    /// </summary>
    [Pure]
    public static T EnableYes<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.Yes"/></em></p>
    ///   <p>Skip prompts and proceed with default values.</p>
    /// </summary>
    [Pure]
    public static T DisableYes<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.Yes"/></em></p>
    ///   <p>Skip prompts and proceed with default values.</p>
    /// </summary>
    [Pure]
    public static T ToggleYes<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = !toolSettings.Yes;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiNewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiNewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiNewSettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiNewSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiNewSettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiNewSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiDestroySettingsExtensions
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class PulumiDestroySettingsExtensions
{
    #region ConfigFile
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T SetConfigFile<T>(this T toolSettings, string configFile) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = configFile;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.ConfigFile"/></em></p>
    ///   <p>Use the configuration values in the specified file rather than detecting the file name.</p>
    /// </summary>
    [Pure]
    public static T ResetConfigFile<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ConfigFile = null;
        return toolSettings;
    }
    #endregion
    #region Debug
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T SetDebug<T>(this T toolSettings, bool? debug) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = debug;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ResetDebug<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T EnableDebug<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T DisableDebug<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.Debug"/></em></p>
    ///   <p>Print detailed debugging output during resource operations.</p>
    /// </summary>
    [Pure]
    public static T ToggleDebug<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = !toolSettings.Debug;
        return toolSettings;
    }
    #endregion
    #region Diff
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T SetDiff<T>(this T toolSettings, bool? diff) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = diff;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ResetDiff<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T EnableDiff<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T DisableDiff<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.Diff"/></em></p>
    ///   <p>Display operation as a rich diff showing the overall change.</p>
    /// </summary>
    [Pure]
    public static T ToggleDiff<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Diff = !toolSettings.Diff;
        return toolSettings;
    }
    #endregion
    #region Message
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Message"/></em></p>
    ///   <p>Optional message to associate with the destroy operation.</p>
    /// </summary>
    [Pure]
    public static T SetMessage<T>(this T toolSettings, string message) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = message;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Message"/></em></p>
    ///   <p>Optional message to associate with the destroy operation.</p>
    /// </summary>
    [Pure]
    public static T ResetMessage<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Message = null;
        return toolSettings;
    }
    #endregion
    #region Parallel
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T SetParallel<T>(this T toolSettings, int? parallel) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = parallel;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Parallel"/></em></p>
    ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default <c>2147483647</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetParallel<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Parallel = null;
        return toolSettings;
    }
    #endregion
    #region Refresh
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T SetRefresh<T>(this T toolSettings, bool? refresh) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = refresh;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ResetRefresh<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T EnableRefresh<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T DisableRefresh<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.Refresh"/></em></p>
    ///   <p>Refresh the state of the stack's resources before this update.</p>
    /// </summary>
    [Pure]
    public static T ToggleRefresh<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Refresh = !toolSettings.Refresh;
        return toolSettings;
    }
    #endregion
    #region ShowConfig
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T SetShowConfig<T>(this T toolSettings, bool? showConfig) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = showConfig;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ResetShowConfig<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T EnableShowConfig<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T DisableShowConfig<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
    ///   <p>Show configuration keys and variables.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowConfig<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowConfig = !toolSettings.ShowConfig;
        return toolSettings;
    }
    #endregion
    #region ShowReplacementSteps
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T SetShowReplacementSteps<T>(this T toolSettings, bool? showReplacementSteps) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = showReplacementSteps;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ResetShowReplacementSteps<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T EnableShowReplacementSteps<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T DisableShowReplacementSteps<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
    ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowReplacementSteps<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
        return toolSettings;
    }
    #endregion
    #region ShowSames
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T SetShowSames<T>(this T toolSettings, bool? showSames) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = showSames;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ResetShowSames<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T EnableShowSames<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T DisableShowSames<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowSames"/></em></p>
    ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
    /// </summary>
    [Pure]
    public static T ToggleShowSames<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.ShowSames = !toolSettings.ShowSames;
        return toolSettings;
    }
    #endregion
    #region SkipPreview
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the destroy.</p>
    /// </summary>
    [Pure]
    public static T SetSkipPreview<T>(this T toolSettings, bool? skipPreview) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = skipPreview;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the destroy.</p>
    /// </summary>
    [Pure]
    public static T ResetSkipPreview<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the destroy.</p>
    /// </summary>
    [Pure]
    public static T EnableSkipPreview<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the destroy.</p>
    /// </summary>
    [Pure]
    public static T DisableSkipPreview<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
    ///   <p>Do not perform a preview before performing the destroy.</p>
    /// </summary>
    [Pure]
    public static T ToggleSkipPreview<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SkipPreview = !toolSettings.SkipPreview;
        return toolSettings;
    }
    #endregion
    #region Stack
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Stack"/></em></p>
    ///   <p>The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T SetStack<T>(this T toolSettings, string stack) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = stack;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Stack"/></em></p>
    ///   <p>The stack name; either an existing stack or stack to create; if not specified, a prompt will request it.</p>
    /// </summary>
    [Pure]
    public static T ResetStack<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Stack = null;
        return toolSettings;
    }
    #endregion
    #region SuppressOutputs
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T SetSuppressOutputs<T>(this T toolSettings, bool? suppressOutputs) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = suppressOutputs;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressOutputs<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressOutputs<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressOutputs<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
    ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressOutputs<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
        return toolSettings;
    }
    #endregion
    #region SuppressPermalink
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T SetSuppressPermalink<T>(this T toolSettings, bool? suppressPermalink) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = suppressPermalink;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ResetSuppressPermalink<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T EnableSuppressPermalink<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T DisableSuppressPermalink<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.SuppressPermalink"/></em></p>
    ///   <p>Suppress display of the state permalink.</p>
    /// </summary>
    [Pure]
    public static T ToggleSuppressPermalink<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SuppressPermalink = !toolSettings.SuppressPermalink;
        return toolSettings;
    }
    #endregion
    #region Target
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, params string[] target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Target"/> to a new list</em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T SetTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal = target.ToList();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiDestroySettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, params string[] target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Adds values to <see cref="PulumiDestroySettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T AddTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.AddRange(target);
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Clears <see cref="PulumiDestroySettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T ClearTarget<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetInternal.Clear();
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiDestroySettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, params string[] target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Removes values from <see cref="PulumiDestroySettings.Target"/></em></p>
    ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: <c>--target urn1 --target urn2</c>.</p>
    /// </summary>
    [Pure]
    public static T RemoveTarget<T>(this T toolSettings, IEnumerable<string> target) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        var hashSet = new HashSet<string>(target);
        toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
        return toolSettings;
    }
    #endregion
    #region TargetDependents
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
    ///   <p>Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T SetTargetDependents<T>(this T toolSettings, bool? targetDependents) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = targetDependents;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
    ///   <p>Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ResetTargetDependents<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
    ///   <p>Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T EnableTargetDependents<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
    ///   <p>Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T DisableTargetDependents<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
    ///   <p>Allows destroying of dependent targets discovered but not specified in <c>--target</c> list.</p>
    /// </summary>
    [Pure]
    public static T ToggleTargetDependents<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.TargetDependents = !toolSettings.TargetDependents;
        return toolSettings;
    }
    #endregion
    #region Yes
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the destroy after previewing it.</p>
    /// </summary>
    [Pure]
    public static T SetYes<T>(this T toolSettings, bool? yes) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = yes;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the destroy after previewing it.</p>
    /// </summary>
    [Pure]
    public static T ResetYes<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the destroy after previewing it.</p>
    /// </summary>
    [Pure]
    public static T EnableYes<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the destroy after previewing it.</p>
    /// </summary>
    [Pure]
    public static T DisableYes<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.Yes"/></em></p>
    ///   <p>Automatically approve and perform the destroy after previewing it.</p>
    /// </summary>
    [Pure]
    public static T ToggleYes<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Yes = !toolSettings.Yes;
        return toolSettings;
    }
    #endregion
    #region Color
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T SetColor<T>(this T toolSettings, string color) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = color;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Color"/></em></p>
    ///   <p>Colorize output. Choices are: always, never, raw, auto (default <c>auto</c>).</p>
    /// </summary>
    [Pure]
    public static T ResetColor<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Color = null;
        return toolSettings;
    }
    #endregion
    #region Cwd
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T SetCwd<T>(this T toolSettings, string cwd) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = cwd;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Cwd"/></em></p>
    ///   <p>Run pulumi as if it had been started in another directory.</p>
    /// </summary>
    [Pure]
    public static T ResetCwd<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Cwd = null;
        return toolSettings;
    }
    #endregion
    #region DisableIntegrityChecking
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T SetDisableIntegrityChecking<T>(this T toolSettings, bool? disableIntegrityChecking) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ResetDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T EnableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T DisableDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
    ///   <p>Disable integrity checking of checkpoint files.</p>
    /// </summary>
    [Pure]
    public static T ToggleDisableIntegrityChecking<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
        return toolSettings;
    }
    #endregion
    #region Emoji
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T SetEmoji<T>(this T toolSettings, bool? emoji) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = emoji;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ResetEmoji<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T EnableEmoji<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T DisableEmoji<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.Emoji"/></em></p>
    ///   <p>Enable emojis in the output.</p>
    /// </summary>
    [Pure]
    public static T ToggleEmoji<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Emoji = !toolSettings.Emoji;
        return toolSettings;
    }
    #endregion
    #region LogFlow
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T SetLogFlow<T>(this T toolSettings, bool? logFlow) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = logFlow;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ResetLogFlow<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T EnableLogFlow<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T DisableLogFlow<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.LogFlow"/></em></p>
    ///   <p>Flow log settings to child processes (like plugins).</p>
    /// </summary>
    [Pure]
    public static T ToggleLogFlow<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogFlow = !toolSettings.LogFlow;
        return toolSettings;
    }
    #endregion
    #region LogToStderr
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T SetLogToStderr<T>(this T toolSettings, bool? logToStderr) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = logToStderr;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ResetLogToStderr<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T EnableLogToStderr<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T DisableLogToStderr<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
    ///   <p>Log to stderr instead of to files.</p>
    /// </summary>
    [Pure]
    public static T ToggleLogToStderr<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.LogToStderr = !toolSettings.LogToStderr;
        return toolSettings;
    }
    #endregion
    #region NonInteractive
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T SetNonInteractive<T>(this T toolSettings, bool? nonInteractive) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = nonInteractive;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ResetNonInteractive<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T EnableNonInteractive<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T DisableNonInteractive<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
    ///   <p>Disable interactive mode for all commands.</p>
    /// </summary>
    [Pure]
    public static T ToggleNonInteractive<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.NonInteractive = !toolSettings.NonInteractive;
        return toolSettings;
    }
    #endregion
    #region Profiling
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T SetProfiling<T>(this T toolSettings, string profiling) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = profiling;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Profiling"/></em></p>
    ///   <p>Emit CPU and memory profiles and an execution trace to <c>[filename].[pid].{cpu,mem,trace}</c>, respectively.</p>
    /// </summary>
    [Pure]
    public static T ResetProfiling<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Profiling = null;
        return toolSettings;
    }
    #endregion
    #region Tracing
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T SetTracing<T>(this T toolSettings, string tracing) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = tracing;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Tracing"/></em></p>
    ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file.</p>
    /// </summary>
    [Pure]
    public static T ResetTracing<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Tracing = null;
        return toolSettings;
    }
    #endregion
    #region Verbose
    /// <summary>
    ///   <p><em>Sets <see cref="PulumiDestroySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T SetVerbose<T>(this T toolSettings, int? verbose) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = verbose;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="PulumiDestroySettings.Verbose"/></em></p>
    ///   <p>Enable verbose logging (e.g., <c>v=3</c>); anything >3 is very verbose.</p>
    /// </summary>
    [Pure]
    public static T ResetVerbose<T>(this T toolSettings) where T : PulumiDestroySettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Verbose = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region PulumiSecretsProvider
/// <summary>
///   Used within <see cref="PulumiTasks"/>.
/// </summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<PulumiSecretsProvider>))]
public partial class PulumiSecretsProvider : Enumeration
{
    public static PulumiSecretsProvider default_ = (PulumiSecretsProvider) "default";
    public static PulumiSecretsProvider passphrase = (PulumiSecretsProvider) "passphrase";
    public static PulumiSecretsProvider awskms = (PulumiSecretsProvider) "awskms";
    public static PulumiSecretsProvider azurekeyvault = (PulumiSecretsProvider) "azurekeyvault";
    public static PulumiSecretsProvider gcpkms = (PulumiSecretsProvider) "gcpkms";
    public static PulumiSecretsProvider hashivault = (PulumiSecretsProvider) "hashivault";
    public static implicit operator PulumiSecretsProvider(string value)
    {
        return new PulumiSecretsProvider { Value = value };
    }
}
#endregion
