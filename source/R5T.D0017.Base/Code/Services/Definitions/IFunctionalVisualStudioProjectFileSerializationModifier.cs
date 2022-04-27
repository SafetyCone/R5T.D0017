using System;
using System.Threading.Tasks;

using R5T.D0010;
using R5T.T0002;
using R5T.T0064;


namespace R5T.D0017
{
    /// <summary>
    /// Modifies an <see cref="IVisualStudioProjectFile"/> for serialization.
    /// 1) Handles adjustment of project-reference paths from relative to absolute.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IFunctionalVisualStudioProjectFileSerializationModifier : IServiceDefinition
    {
        /// <summary>
        /// Includes both <paramref name="visualStudioProjectFile"/> and <paramref name="projectFilePath"/> since project reference relative file paths will need to be made absolute.
        /// </summary>
        Task<T> ModifyDeserializeationAsync<T>(T visualStudioProjectFile, string projectFilePath, IMessageSink messageSink)
            where T : IVisualStudioProjectFile;

        /// <summary>
        /// Includes both <paramref name="stream"/> and <paramref name="projectFilePath"/> since project reference absolute file paths will need to be made relative.
        /// </summary>
        Task<T> ModifySerializationAsync<T>(T visualStudioProjectFile, string projectFilePath, IMessageSink messageSink)
            where T : IVisualStudioProjectFile;
    }
}
