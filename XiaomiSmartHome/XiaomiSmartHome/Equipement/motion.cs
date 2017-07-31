﻿using Constellation;
using Constellation.Package;
using static XiaomiSmartHome.Model.Response;
using Newtonsoft.Json;

namespace XiaomiSmartHome.Equipement
{
    /// <summary>
    /// Motuon sensor
    /// </summary>
    [StateObject, XiaomiEquipement("motion")]
    public class Motion
    {
        /// <summary>
        /// Model type.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; } = "motion";

        /// <summary>
        /// SID (mac adress).
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// SID (mac adress).
        /// </summary>
        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        /// <summary>
        /// Battery type.
        /// </summary>
        public string Battery { get; set; } = "CR2450";

        /// <summary>
        /// Battery level.
        /// </summary>
        public int BatteryLevel { get; set; }

        /// <summary>
        /// Last report.
        /// </summary>
        [JsonProperty("data")]
        public MotionReport Report { get; set; }
    }

    /// <summary>
    /// Motion sensor last report
    /// </summary>
    [StateObject, XiaomiEquipement("motion_report")]
    public class MotionReport
    {
        /// <summary>
        /// Voltage left.
        /// </summary>
        public int Voltage { get; set; }

        /// <summary>
        /// Motion sensor state.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Motion sensor state.
        /// </summary>
        [JsonProperty("no_motion")]
        public string NoMotion { get; set; }
    }
}
