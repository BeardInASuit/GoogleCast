﻿using System.Threading.Tasks;
using GoogleCast.Models.Receiver;

namespace GoogleCast.Channels
{
    /// <summary>
    /// Interface for the receiver channel
    /// </summary>
    public interface IReceiverChannel : IStatusChannel<ReceiverStatus>
    {
        /// <summary>
        /// Retrieves the status
        /// </summary>
        /// <returns>the status</returns>
        Task<ReceiverStatus> GetStatusAsync();

        /// <summary>
        /// Launches an application
        /// </summary>
        /// <param name="applicationId">application identifier</param>
        /// <returns>receiver status</returns>
        Task<ReceiverStatus> LaunchAsync(string applicationId);

        /// <summary>
        /// Checks the connection is well established
        /// </summary>
        /// <param name="ns">namespace</param>
        /// <returns>an application object</returns>
        Task<Application> EnsureConnectionAsync(string ns);

        /// <summary>
        /// Sets the volume
        /// </summary>
        /// <param name="level">volume level (0.0 to 1.0)</param>
        /// <returns>receiver status</returns>
        Task<ReceiverStatus> SetVolumeAsync(float level);

        /// <summary>
        /// Sets a value indicating whether the audio should be muted
        /// </summary>
        /// <param name="isMuted">true if audio should be muted; otherwise, false</param>
        /// <returns>receiver status</returns>
        Task<ReceiverStatus> SetIsMutedAsync(bool isMuted);

        /// <summary>
        /// Stops the current applications
        /// </summary>
        /// <param name="applications">applications to stop</param>
        /// <returns>ReceiverStatus</returns>
        Task<ReceiverStatus?> StopAsync(params Application[] applications);
    }
}
