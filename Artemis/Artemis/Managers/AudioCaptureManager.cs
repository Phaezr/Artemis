﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Artemis.Events;
using Artemis.Profiles.Layers.Types.Audio;
using Artemis.Profiles.Layers.Types.Audio.AudioCapturing;
using CSCore.CoreAudioAPI;
using Ninject.Extensions.Logging;

namespace Artemis.Managers
{
    public class AudioCaptureManager
    {
        private readonly List<AudioCapture> _audioCaptures;
        private MMDevice _lastDefaultPlayback;
        private MMDevice _lastDefaultRecording;

        public AudioCaptureManager(ILogger logger)
        {
            Logger = logger;
            _audioCaptures = new List<AudioCapture>();
            _lastDefaultPlayback = MMDeviceEnumerator.TryGetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            _lastDefaultRecording = MMDeviceEnumerator.TryGetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

            var defaultDeviceTimer = new Timer(1000);
            defaultDeviceTimer.Elapsed += DefaultDeviceTimerOnElapsed;
            defaultDeviceTimer.Start();
        }

        public event EventHandler<AudioDeviceChangedEventArgs> AudioDeviceChanged;

        private void DefaultDeviceTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            var defaultPlayback = MMDeviceEnumerator.TryGetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            var defaultRecording = MMDeviceEnumerator.TryGetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

            if (defaultPlayback?.DeviceID == _lastDefaultPlayback?.DeviceID &&
                defaultRecording?.DeviceID == _lastDefaultRecording?.DeviceID)
                return;

            _lastDefaultPlayback = defaultPlayback;
            _lastDefaultRecording = defaultRecording;
            OnAudioDeviceChanged(new AudioDeviceChangedEventArgs(_lastDefaultPlayback, _lastDefaultRecording));
        }

        public AudioCapture GetAudioCapture(MMDevice device, MmDeviceType type)
        {
            // Return existing audio capture if found
            var audioCapture = _audioCaptures.FirstOrDefault(a => a.Device.DeviceID == device.DeviceID);
            if (audioCapture != null)
                return audioCapture;

            // Else create a new one and return that
            var newAudioCapture = new AudioCapture(Logger, device, type);
            _audioCaptures.Add(newAudioCapture);
            return newAudioCapture;
        }

        public ILogger Logger { get; set; }

        protected virtual void OnAudioDeviceChanged(AudioDeviceChangedEventArgs e)
        {
            AudioDeviceChanged?.Invoke(this, e);
        }
    }
}