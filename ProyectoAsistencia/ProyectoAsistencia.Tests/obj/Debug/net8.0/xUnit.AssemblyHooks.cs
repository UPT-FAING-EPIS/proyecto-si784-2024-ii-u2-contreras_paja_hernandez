// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using global::System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::ProyectoAsistencia_Tests_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "4.0.31-beta")]
public class ProyectoAsistencia_Tests_XUnitAssemblyFixture : global::Xunit.IAsyncLifetime
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    public async Task InitializeAsync()
    {
        var currentAssembly = typeof(ProyectoAsistencia_Tests_XUnitAssemblyFixture).Assembly;
        await global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStartAsync(currentAssembly);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public async Task DisposeAsync()
    {
        var currentAssembly = typeof(ProyectoAsistencia_Tests_XUnitAssemblyFixture).Assembly;
        await global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEndAsync(currentAssembly);
    }
}

[global::Xunit.CollectionDefinition("SpecFlowNonParallelizableFeatures", DisableParallelization = true)]
public class ProyectoAsistencia_Tests_SpecFlowNonParallelizableFeaturesCollectionDefinition
{
}
#pragma warning restore
