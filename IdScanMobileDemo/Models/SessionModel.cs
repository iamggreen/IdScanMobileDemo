using System;

namespace IdScanMobileDemo.Models
{
    public class SessionModel
    {
        public Guid SessionId { get; }

        public SessionModel(Guid sessionId)
        {
            SessionId = sessionId;
        }
    }
}
