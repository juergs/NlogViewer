using NLog.Common;
using NLog.Targets;
using System;

namespace NlogViewer
{
    [Target("NlogViewer")]
    public class NlogViewerTarget : Target
    {
        public event Action<AsyncLogEventInfo> LogReceived;

        private int _MaxLines = 50;
        private bool _AutoScroll = true;
        private bool _LastSelect = true;

        public int MaxLines
        {
            get { return _MaxLines; }
            set { _MaxLines = value; }
        }

        public bool AutoScroll
        {
            get { return _AutoScroll; }
            set { _AutoScroll = value; }
        }

        public bool LastSelect
        {
            get { return _LastSelect; }
            set { _LastSelect = value; }
        }

        protected override void Write(NLog.Common.AsyncLogEventInfo logEvent)
        {
            base.Write(logEvent);
            LogReceived?.Invoke(logEvent);
        }
    }
}