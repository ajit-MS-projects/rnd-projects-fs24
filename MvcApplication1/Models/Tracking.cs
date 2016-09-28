using System;

namespace MvcApplication1.Models
{
    /// <summary>
    /// Tracking entity to store data about view and click tracking
    /// </summary>
    public class Tracking 
    {
        #region Implementation of ITracking
        
        public int AdvertiserId { get; set; }
        
        public int PublisherId { get; set; }
        
        public long ViewTime { get; set; }
        
        public string Referer { get; set; }
        public Guid FingerPrintId { get; set; }
        
        public string MarketingChannel { get; set; }
        
        public string TouchPoint { get; set; }
        
        public int AdvertisementId { get; set; }
        
        #endregion
    }
}
