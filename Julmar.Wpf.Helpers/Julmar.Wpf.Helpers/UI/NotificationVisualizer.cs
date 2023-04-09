﻿extern alias Composition; 

using System;
using JulMar.Windows.Interfaces;
using Composition::System.ComponentModel.Composition;

namespace JulMar.Windows.UI
{
    /// <summary>
    /// This implements the INotificationVisualizer interface for WPF
    /// </summary>
    [Export(typeof(INotificationVisualizer))]
    sealed class NotificationVisualizer : INotificationVisualizer
    {
        /// <summary>
        /// This provides a "Wait" support
        /// </summary>
        /// <param name="title">Title (if any)</param>
        /// <param name="message">Message (if any)</param>
        /// <returns>Disposable element</returns>
        public IDisposable BeginWait(string title, string message)
        {
            return new WaitCursor();
        }
    }
}