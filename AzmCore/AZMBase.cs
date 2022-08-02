﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Threading;
using UCNLDrivers;
using UCNLNav;
using UCNLNMEA;
using UCNLPhysics;
using UCNLUI;

namespace AzimuthSuite.AzmCore
{
    #region Custom enums

    [Flags]
    public enum RemoteVisibleDataItems
    {
        none = 0,
        isDistanceAndAzimuth = 1,        // Slant range projection and azimuth
        isDepth = 2,                     // Depth
        isReverseAzimuth = 4,            // Reverse azimuth
        isElevation = 8,                 // Elevation
        isMiscInfo = 16,                 // MSR, PTime
        isLocation = 32                  // Lat & Lon
    }

    #endregion

    #region Custom classes

    public class Remote
    {
        #region Properties
        public REMOTE_ADDR_Enum Address { get; private set; }
        public AgingValue<double> SlantRange_m { get; private set; }
        public AgingValue<double> Depth_m { get; private set; }
        public AgingValue<double> SlantRangeProjection_m { get; private set; }
        public AgingValue<double> ADistance_m { get; private set; }
        public AgingValue<double> Azimuth_deg { get; private set; }
        public AgingValue<double> AAzimuth_deg { get; private set; }
        public AgingValue<double> Elevation_deg { get; private set; }
        public AgingValue<double> ReverseAzimuth_deg { get; private set; }
        public AgingValue<double> PTime_s { get; private set; }
        public AgingValue<double> MSR_dB { get; private set; }
        
        public AgingValue<double> Latitude_deg { get; private set; }
        public AgingValue<double> Longitude_deg { get; private set; }
        public bool IsTimeout { get; set; }
        public AgingValue<string> Message { get; private set; }

        public DHFilter FilterState;

        #endregion

        #region Constructor

        public Remote(REMOTE_ADDR_Enum id)
        {
            Address = id;

            SlantRange_m = new AgingValue<double>(3, 32, AZM.meters1dec_fmtr);
            Depth_m = new AgingValue<double>(3, 32, AZM.meters1dec_fmtr);
            SlantRangeProjection_m = new AgingValue<double>(3, 32, AZM.meters1dec_fmtr);
            ADistance_m = new AgingValue<double>(3, 32, AZM.meters1dec_fmtr);
            Azimuth_deg = new AgingValue<double>(3, 32, AZM.degrees1dec_fmtr);
            AAzimuth_deg = new AgingValue<double>(3, 32, AZM.degrees1dec_fmtr);
            Elevation_deg = new AgingValue<double>(3, 32, AZM.degrees1dec_fmtr);
            PTime_s = new AgingValue<double>(3, 32, x => string.Format(CultureInfo.InvariantCulture, "{0:F04} sec", x));
            MSR_dB = new AgingValue<double>(3, 32, AZM.db_fmtr);
            Latitude_deg = new AgingValue<double>(3, 32, AZM.latlon_fmtr);
            Longitude_deg = new AgingValue<double>(3, 32, AZM.latlon_fmtr);
            ReverseAzimuth_deg = new AgingValue<double>(3, 32, AZM.degrees1dec_fmtr);
            IsTimeout = false;
            Message = new AgingValue<string>(3, 32, x => x);
        }

        #endregion

        #region Methods

        public Dictionary<string, string> ToStringList(RemoteVisibleDataItems visibleItems)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isDistanceAndAzimuth))
            {
                if (ADistance_m.IsInitializedAndNotObsolete)
                    result.Add("DST", ADistance_m.ToString());
                else
                {
                    if (SlantRangeProjection_m.IsInitialized)
                        result.Add("DST", SlantRangeProjection_m.ToString());
                }
                if (AAzimuth_deg.IsInitializedAndNotObsolete)
                    result.Add("AZM", AAzimuth_deg.ToString());
                else
                {
                    if (Azimuth_deg.IsInitialized)
                        result.Add("AZM", Azimuth_deg.ToString());
                }
            }

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isDepth))
            {
                if (Depth_m.IsInitialized)
                    result.Add("DPT", Depth_m.ToString());
            }

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isReverseAzimuth))
            {
                if (ReverseAzimuth_deg.IsInitialized)
                    result.Add("RAZ", ReverseAzimuth_deg.ToString());
            }

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isElevation))
            {
                if (Elevation_deg.IsInitialized)
                    result.Add("ELV", Elevation_deg.ToString());
            }

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isMiscInfo))
            {
                if (MSR_dB.IsInitialized)
                    result.Add("MSR", MSR_dB.ToString());

                if (PTime_s.IsInitialized)
                    result.Add("PTM", PTime_s.ToString());
            }

            if (visibleItems.HasFlag(RemoteVisibleDataItems.isLocation))
            {
                if (Latitude_deg.IsInitialized)
                    result.Add("LAT", Latitude_deg.ToString());

                if (Longitude_deg.IsInitialized)
                    result.Add("LON", Longitude_deg.ToString());
            }

            if (IsTimeout)
                result.Add("TMO", "🏴‍");

            if (Message.IsInitialized)
                result.Add("WRN", Message.ToString());

            return result;
        }

        #endregion
    }

    #endregion

    #region Custom EventArgs

    public class RelativeLocationUpdatedEventArgs : EventArgs
    {
        #region Properties

        public string ID { get; set; }
        public double PRange_m { get; set; }
        public double Azimuth_deg { get; set; }
        public bool IsTimeout { get; set; }

        #endregion

        #region Constructor

        public RelativeLocationUpdatedEventArgs(string id, double pRange_m, double azimuth_deg, bool isTimeout)
        {
            ID = id;
            PRange_m = pRange_m;
            Azimuth_deg = azimuth_deg;
            IsTimeout = isTimeout;
        }

        #endregion
    }

    public class AbsoluteLocationUpdatedEventArgs : EventArgs
    {
        #region Properties
        public string ID { get; set; }

        public double Latitude_deg { get; set; }

        public double Longitude_deg { get; set; }

        public double Depth_m { get; set; }

        #endregion

        #region Constructor

        public AbsoluteLocationUpdatedEventArgs(string id, double lat_deg, double lon_deg, double dpt_m)
        {
            ID = id;
            Latitude_deg = lat_deg;
            Longitude_deg = lon_deg;
            Depth_m = dpt_m;
        }

        #endregion
    }

    public class RemoteTimeoutEventArgs : EventArgs
    {
        #region Properties

        public REMOTE_ADDR_Enum RemoteAddress { get; private set; }

        #endregion

        #region Constructor

        public RemoteTimeoutEventArgs(REMOTE_ADDR_Enum addr)
        {
            RemoteAddress = addr;
        }

        #endregion
    }

    #endregion

    public class AZMBase : IDisposable
    {
        #region Properties

        bool disposed = false;

        AZMPort azmPort;
        uGNSSSerialPort gnssPort;
        NMEASerialPort outPort;

        public bool IsActive
        {
            get { return azmPort.IsActive; }
        }

        public bool AZMPortDetected
        {
            get { return azmPort.Detected; }
        }

        public string AZMPortName
        {
            get { return azmPort.PortName; }
        }

        public string AZMPortStatus
        {
            get { return azmPort.ToString(); }
        }


        public bool IsOutPortInitiaziled
        {
            get => (outPort != null) && (outPort.IsOpen);
        }

        public string OutPortName
        {
            get => outPort == null ? "" : outPort.PortName;
        }

        public REMOTE_ADDR_Enum RemoteToOutport { get; set; }


        public bool IsUseGNSS { get; private set; }

        public bool GNSSPortDetected
        {
            get { return (gnssPort != null) && (gnssPort.Detected); }
        }

        public string GNSSPortStatus
        {
            get { return gnssPort == null ? string.Empty : gnssPort.ToString(); }
        }

        public double Heading
        {
            get { return (!heading.IsInitialized) ? 0 : heading.Value; }
        }

        
        public ushort AddressMask { get; private set; }

        public double MaxDist_m { get; private set; }

        public double Salinity_PSU { get; private set; }


        double phi_deg;
        double x_offset_m;
        double y_offset_m;

        AgingValue<double> stationDepth_m;
        AgingValue<double> waterTemperature_C;
        AgingValue<double> stationPitch_deg;
        AgingValue<double> stationRoll_deg;

        AgingValue<double> latitude_deg;
        AgingValue<double> longitude_deg;
        AgingValue<double> course_deg;
        AgingValue<double> speed;
        AgingValue<double> heading;

        Dictionary<REMOTE_ADDR_Enum, Remote> remotes;

        readonly string[] llSeparators = new string[] { ">>", " " };

        bool polling_stated_received = false;
        DateTime prevRemAckTS = DateTime.Now;

        #endregion

        #region Constructor

        public AZMBase(ushort addrMask, double salinity_PSU, double maxDist_m, double hdn_adj_deg, double gnss_x_offset_m, double gnss_y_offset_m)
        {
            #region Misc. parameters

            RemoteToOutport = REMOTE_ADDR_Enum.REM_ADDR_1;

            AddressMask = addrMask;

            if ((salinity_PSU >= PHX.PHX_SALINITY_PSU_MIN) && (salinity_PSU <= PHX.PHX_SALINITY_PSU_MAX))
                Salinity_PSU = salinity_PSU;
            else
                throw new ArgumentOutOfRangeException(nameof(salinity_PSU));

            if ((hdn_adj_deg >= 0) && (hdn_adj_deg <= 360))
                phi_deg = hdn_adj_deg;
            else
                throw new ArgumentOutOfRangeException(nameof(hdn_adj_deg));

            if ((maxDist_m >= AZM.ABS_MIN_RANGE_M) && (maxDist_m <= AZM.ABS_MAX_RANGE_M))
                MaxDist_m = maxDist_m;
            else
                throw new ArgumentOutOfRangeException(nameof(maxDist_m));

            x_offset_m = gnss_x_offset_m;
            y_offset_m = gnss_y_offset_m;

            remotes = new Dictionary<REMOTE_ADDR_Enum, Remote>();

            #endregion

            #region AgingValues

            stationDepth_m = new AgingValue<double>(3, 10, AZM.meters1dec_fmtr);
            waterTemperature_C = new AgingValue<double>(3, 10, AZM.degC_fmtr);
            stationPitch_deg = new AgingValue<double>(3, 10, AZM.degrees1dec_fmtr);
            stationRoll_deg = new AgingValue<double>(3, 10, AZM.degrees1dec_fmtr);

            latitude_deg = new AgingValue<double>(3, 10, AZM.latlon_fmtr);
            longitude_deg = new AgingValue<double>(3, 10, AZM.latlon_fmtr);
            course_deg = new AgingValue<double>(3, 10, AZM.degrees1dec_fmtr);
            speed = new AgingValue<double>(3, 10, x => string.Format(CultureInfo.InvariantCulture,
                "{0:F01} km/h ({1:F01} m/s)", x, x / 3.6));
            heading = new AgingValue<double>(3, 10, AZM.degrees1dec_fmtr);

            #endregion

            #region azmPort

            azmPort = new AZMPort(BaudRate.baudRate9600);
            azmPort.IsTryAlways = true;
            azmPort.IsLogIncoming = true;

            azmPort.DetectedChanged += (o, e) =>
            {
                AZMPortDetectedChanged.Rise(o, e);

                if (azmPort.Detected)
                    if (IsUseGNSS && !gnssPort.IsActive)
                        gnssPort.Start();                
            };
            azmPort.DeviceInfoValidChanged += (o, e) =>
            {
                if (azmPort.IsDeviceInfoValid && (azmPort.DeviceType == AZM_DEVICE_TYPE_Enum.DT_BASE))
                {
                    LogEventHandler.Rise(o, new LogEventArgs(LogLineType.INFO, 
                        string.Format(CultureInfo.InvariantCulture, 
                        "Querying to start polling (AddrMask={0}, Salinity={1:F01} PSU, MaxDist={2:F01} m)", 
                        addrMask, salinity_PSU, maxDist_m)));

                    azmPort.Query_BaseStart(addrMask, salinity_PSU, maxDist_m);
                }
            };
            azmPort.ACKReceived += (o, e) =>
            {
                if ((e.SentenceID == ICs.IC_D2D_STRSTP) && (e.ResultID != IC_RESULT_Enum.IC_RES_OK))
                {
                    LogEventHandler.Rise(o, new LogEventArgs(LogLineType.ERROR, string.Format("IC_D2D_STRSTP caused a \"{0}\" error, retrying...", e.ResultID)));
                    LogEventHandler.Rise(o, new LogEventArgs(LogLineType.INFO,
                        string.Format("Querying to start polling (AddrMask={0}, Salinity={1:F01} PSU, MaxDist={2:F01} m)", addrMask, salinity_PSU, maxDist_m)));
                    azmPort.Query_BaseStart(addrMask, salinity_PSU, maxDist_m);
                }
            };
            azmPort.IsActiveChanged += (o, e) => IsActiveChanged.Rise(o, e);
            azmPort.LogEventHandler += (o, e) => LogEventHandler.Rise(o, e);
            azmPort.NDTAReceived += (o, e) =>
            {
                ProcessStationLocalParameters(e);

                if (e.Status == NDTA_Status_Enum.NDTA_REMT) // Remote timeout
                {
                    SetRemoteTimeoutStatus(e.Address);
                    prevRemAckTS = DateTime.Now;
                }
                else if (e.Status == NDTA_Status_Enum.NDTA_REMR) // Remote response
                {
                    ProcessRemote(e);
                    prevRemAckTS = DateTime.Now;
                }

                if (DateTime.Now.Subtract(prevRemAckTS).Seconds > 5)
                {
                    polling_stated_received = false;
                    LogEventHandler.Rise(this,
                        new LogEventArgs(LogLineType.ERROR, "Remote action timeout (Short-term power shutdown?) , restarting polling..."));
                    azmPort.Query_BaseStart(addrMask, salinity_PSU, maxDist_m);
                }

                StateUpdateHandler.Rise(this, new EventArgs());                
            };
            azmPort.STRSTPReceived += (o, e) =>
            {
                LogEventHandler.Rise(o,
                    new LogEventArgs(LogLineType.INFO,
                        string.Format(CultureInfo.InvariantCulture,
                        "Polling started (AddrMask={0}, Salinity={1:F01} PSU, SoundSpeed={2}, MaxDist={3:F01} m)",
                        e.AddrMask,
                        e.Sty_PSU,
                        double.IsNaN(e.SoundSpeed_mps) ? "Auto" : string.Format(CultureInfo.InvariantCulture, "{0:F01} m/s", e.SoundSpeed_mps),
                        e.MaxDist_m)));

                polling_stated_received = true;
            };

            #endregion
        }

        #endregion

        #region Methods

        #region Private        

        private void TryWriteOutput(double lat_deg, double lon_deg, double rdpt_m, double razm_deg)
        {
            List<string> eStrings = new List<string>();
            string latCardinal = lat_deg > 0 ? "N" : "S";
            string lonCardinal = lon_deg > 0 ? "E" : "W";

            #region RMC

            eStrings.Add(
                NMEAParser.BuildSentence(
                    TalkerIdentifiers.GP,
                    SentenceIdentifiers.RMC,
                    new object[]
                    {
                        DateTime.Now,
                        "Valid",
                        lat_deg, latCardinal,
                        lon_deg, lonCardinal,
                        null,
                        null, // track true
                        DateTime.Now,
                        null, // magnetic variation
                        null, // magnetic variation direction
                        "A",
                    }));

            #endregion

            #region GGA

            eStrings.Add(
                NMEAParser.BuildSentence(
                    TalkerIdentifiers.GP, 
                    SentenceIdentifiers.GGA, 
                    new object[]
                    {
                        DateTime.Now,
                        lat_deg, latCardinal,
                        lon_deg, lonCardinal,
                        "GPS fix",
                        4,
                        null,
                        (double.IsNaN(rdpt_m) ? null : (object)(-rdpt_m)),
                        "M",
                        null,
                        "M",
                        null,
                        null
                    }));

            #endregion

            #region HDT

            eStrings.Add(
                NMEAParser.BuildSentence(
                    TalkerIdentifiers.GP, 
                    SentenceIdentifiers.HDT, 
                    new object[]
                    {
                        double.IsNaN(razm_deg) ? null : (object)razm_deg,
                        "T"
                    }));

            #endregion

            foreach (var item in eStrings)
            {
                try
                {
                    outPort.SendData(item);
                    LogEventHandler.Rise(this, 
                        new LogEventArgs(LogLineType.INFO, 
                        string.Format("{0} ({1}) << {2}", 
                        outPort.PortName, 
                        "OUT", item)));
                }
                catch (Exception ex)
                {
                    LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
                }
            }
        }

        private void SetRemoteTimeoutStatus(REMOTE_ADDR_Enum address)
        {
            if (!remotes.ContainsKey(address))
                remotes.Add(address, new Remote(address));

            remotes[address].IsTimeout = true;

            if (remotes[address].Azimuth_deg.IsInitialized &&
                remotes[address].SlantRangeProjection_m.IsInitialized)
            {
                RelativeLocationUpdated.Rise(this,
                    new RelativeLocationUpdatedEventArgs(AZM.Addr2Str(address),
                    remotes[address].SlantRangeProjection_m.Value,
                    remotes[address].Azimuth_deg.Value,
                    true));
            }
        }

        private void CalcAbsLocation(double olat_rad, double olon_rad, 
            double azm_rad, double dst_m, 
            out double rlat_rad, out double rlon_rad, out double razm_rad)
        {            
            if (!Algorithms.VincentyDirect(olat_rad, olon_rad, azm_rad, dst_m,
                Algorithms.WGS84Ellipsoid,
                Algorithms.VNC_DEF_EPSILON, Algorithms.VNC_DEF_IT_LIMIT,
                out rlat_rad, out rlon_rad, out razm_rad, out _))
            {
                Algorithms.HaversineDirect(olat_rad, olon_rad, dst_m, azm_rad,
                    Algorithms.WGS84Ellipsoid.MajorSemiAxis_m,
                    out rlat_rad, out rlon_rad);

                razm_rad = Algorithms.Wrap2PI(azm_rad + Math.PI);
            }
        }

        private void ProcessRemote(NDTAReceivedEventArgs e)
        {
            if (!remotes.ContainsKey(e.Address))
                remotes.Add(e.Address, new Remote(e.Address));

            bool is_a = false;
            bool is_srp = false;

            remotes[e.Address].IsTimeout = false;

            if (AZM.IsErrorCode(e.ResponseCode))
            {
                CDS_RESP_CODES_Enum rError = (CDS_RESP_CODES_Enum)Enum.ToObject(typeof(CDS_RESP_CODES_Enum), e.ResponseCode);

                if ((rError == CDS_RESP_CODES_Enum.CDS_ERR_BAT_LOW) ||
                    (rError == CDS_RESP_CODES_Enum.CDS_RSYS_STRT))
                    remotes[e.Address].Message.Value = rError.ToString().Replace("CDS", "").Replace('_', ' ');
                else
                    remotes[e.Address].Message.Value = string.Format("{0} caused {1}", e.RequestCode, rError);
            }

            if (!double.IsNaN(e.MSR_dB))
                remotes[e.Address].MSR_dB.Value = e.MSR_dB;

            if (!double.IsNaN(e.PropTime_s))
                remotes[e.Address].PTime_s.Value = e.PropTime_s;
            
            if (!double.IsNaN(e.SlantRange_m))
                remotes[e.Address].SlantRange_m.Value = e.SlantRange_m;

            if (!double.IsNaN(e.SlantRangeProjection_m))
            {
                remotes[e.Address].SlantRangeProjection_m.Value = e.SlantRangeProjection_m;
                is_srp = true;
            }

            if (!double.IsNaN(e.RemotesDepth_m))
                remotes[e.Address].Depth_m.Value = e.RemotesDepth_m;

            if (!double.IsNaN(e.HAngle_deg))
            {
                remotes[e.Address].Azimuth_deg.Value = e.HAngle_deg;
                is_a = true;
            }

            if (!double.IsNaN(e.VAngle_deg))
                remotes[e.Address].Elevation_deg.Value = e.VAngle_deg;

            if (is_a && is_srp)
            {
                if (latitude_deg.IsInitializedAndNotObsolete &&
                    longitude_deg.IsInitializedAndNotObsolete &&
                    heading.IsInitializedAndNotObsolete)
                {
                    double a_azm = 0;
                    double a_rng = 0;
                    PolarCS_ShiftRotate(heading.Value, phi_deg, e.HAngle_deg, e.SlantRangeProjection_m,
                        x_offset_m, y_offset_m, out a_azm, out a_rng);

                    remotes[e.Address].AAzimuth_deg.Value = a_azm;
                    remotes[e.Address].ADistance_m.Value = a_rng;

                    RelativeLocationUpdated.Rise(this,
                        new RelativeLocationUpdatedEventArgs(AZM.Addr2Str(e.Address),
                        a_azm, a_rng, false));

                    if (remotes[e.Address].FilterState == null)
                        remotes[e.Address].FilterState = new DHFilter(16, 0.5, 5);

                    CalcAbsLocation(
                        Algorithms.Deg2Rad(latitude_deg.Value), Algorithms.Deg2Rad(longitude_deg.Value),
                        Algorithms.Deg2Rad(a_azm), a_rng,
                        out double rlat_rad, out double rlon_rad, out double razm_deg);

                    DateTime ts = DateTime.Now;

                    if (remotes[e.Address].FilterState.Process(rlat_rad, rlon_rad, 0, ts, 
                            out rlat_rad, out rlon_rad, out _, out ts))
                    {
                        double rlat_deg = Algorithms.Rad2Deg(rlat_rad);
                        double rlon_deg = Algorithms.Rad2Deg(rlon_rad);
                        double rdpt_m = remotes[e.Address].Depth_m.IsInitialized ? remotes[e.Address].Depth_m.Value : 0;

                        AbsoluteLocationUpdated.Rise(this,
                            new AbsoluteLocationUpdatedEventArgs(
                                AZM.Addr2Str(e.Address),
                                rlat_deg,
                                rlon_deg,
                                rdpt_m));

                        if (IsOutPortInitiaziled && 
                            ((e.Address == RemoteToOutport) ||
                             (e.Address == REMOTE_ADDR_Enum.REM_ADDR_INVALID)))
                            TryWriteOutput(rlat_deg, rlon_deg, rdpt_m, razm_deg);
                    }
                }
                else
                {
                    RelativeLocationUpdated.Rise(this,
                        new RelativeLocationUpdatedEventArgs(AZM.Addr2Str(e.Address), 
                        e.HAngle_deg, e.SlantRangeProjection_m, false));
                }
            }            
        }

        /// <summary>
        /// All angles clockwise from the North direction
        /// </summary>
        /// <param name="heading_deg">Compass reading, 0-360° clockwise from North direction</param>
        /// <param name="phi_deg">Antenna - comрass zero directions difference, °</param>
        /// <param name="bearing_deg">Bearing to a responder, 0-360° clockwise from North direction</param>
        /// <param name="r_m">slant range projection, m</param>
        /// <param name="xt">transversal GNSS/antenna offset</param>
        /// <param name="yt">longitudal GNSS/antenna offset</param>
        /// <param name="a_deg">Absolute azimuth to the responder</param>
        /// <param name="r_a">Range to the responder (from the GNSS position)</param>
        private static void PolarCS_ShiftRotate(double heading_deg, double phi_deg, double bearing_deg,
            double r_m, double xt, double yt,
            out double a_deg, out double r_a)
        {
            double alpha = Algorithms.Deg2Rad(heading_deg);
            double teta = Algorithms.Wrap2PI(Algorithms.Deg2Rad(450 - (bearing_deg - phi_deg)));
            double xr = xt + r_m * Math.Cos(teta);
            double yr = yt + r_m * Math.Sin(teta);
            r_a = Math.Sqrt(xr * xr + yr * yr);
            a_deg = Algorithms.Rad2Deg(Algorithms.Wrap2PI(2.5 * Math.PI - (Math.Atan2(xr, yr) + alpha)));
        }

        private void ProcessStationLocalParameters(NDTAReceivedEventArgs e)
        {            
            if (!double.IsNaN(e.LocTemp_C))
                waterTemperature_C.Value = e.LocTemp_C;

            if (!double.IsNaN(e.LocPrs_mBar))
            {
                if (waterTemperature_C.IsInitialized)
                {
                    double waterDensity_kgm3 =
                        PHX.Water_density_calc(waterTemperature_C.Value,
                                               e.LocPrs_mBar,
                                               Salinity_PSU);

                    stationDepth_m.Value = PHX.Depth_by_pressure_calc(e.LocPrs_mBar,
                        PHX.PHX_ATM_PRESSURE_MBAR, waterDensity_kgm3, PHX.PHX_GRAVITY_ACC_MPS2);
                }
            }

            if (!double.IsNaN(e.LocPitch_deg))
                stationPitch_deg.Value = e.LocPitch_deg;
            if (!double.IsNaN(e.LocRoll_deg))
                stationRoll_deg.Value = e.LocRoll_deg;
        }

        #endregion

        #region Public

        public void Demo()
        {
            remotes.Add(REMOTE_ADDR_Enum.REM_ADDR_1, new Remote(REMOTE_ADDR_Enum.REM_ADDR_1));
            remotes[REMOTE_ADDR_Enum.REM_ADDR_1].Azimuth_deg.Value = 45;
            remotes[REMOTE_ADDR_Enum.REM_ADDR_1].SlantRangeProjection_m.Value = 777;
            remotes[REMOTE_ADDR_Enum.REM_ADDR_1].MSR_dB.Value = 37.7;
            remotes[REMOTE_ADDR_Enum.REM_ADDR_1].Depth_m.Value = 77.7;

            heading.Value = 135;
            HeadingUpdated.Rise(this, null);

            RelativeLocationUpdated.Rise(this,
                new RelativeLocationUpdatedEventArgs(AZM.Addr2Str(REMOTE_ADDR_Enum.REM_ADDR_1),
                777, 45, false));

            StateUpdateHandler.Rise(this, null);

        }
        
        public void Emulate(string eString)
        {
            string str = eString.Trim() + NMEAParser.SentenceEndDelimiter;

            var splits = str.Split(llSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (splits.Length == 3)
            {
                if (splits[1] == "(GNSS)")
                {
                    if (gnssPort == null)
                        AuxGNSSInit(BaudRate.baudRate9600);

                    gnssPort.EmulateInput(splits[2]);
                }
                else if (splits[1] == "(AZM)")
                {
                    azmPort.EmulateInput(splits[2]);
                }
            }
        }

        public void AuxGNSSInit(BaudRate baudrate)
        {
            if (!IsUseGNSS)
            {
                IsUseGNSS = true;

                gnssPort = new uGNSSSerialPort(baudrate);
                gnssPort.IsLogIncoming = true;
                gnssPort.IsTryAlways = true;

                gnssPort.DetectedChanged += (o, e) => GNSSPortDetectedChanged.Rise(o, e);
                gnssPort.IsActiveChanged += (o, e) => IsGNSSActiveChanged.Rise(o, e);
                gnssPort.HeadingUpdated += (o, e) =>
                {
                    heading.Value = gnssPort.Heading;
                    HeadingUpdated.Rise(this, new EventArgs());
                };

                gnssPort.LocationUpdated += (o, e) =>
                {
                    latitude_deg.Value = gnssPort.Latitude;
                    longitude_deg.Value = gnssPort.Longitude;
                    course_deg.Value = gnssPort.CourseOverGround;
                    speed.Value = gnssPort.GroundSpeed;

                    AbsoluteLocationUpdated.Rise(this,
                        new AbsoluteLocationUpdatedEventArgs("Station",
                        gnssPort.Latitude,
                        gnssPort.Longitude,
                        stationDepth_m.Value));

                    StateUpdateHandler.Rise(o, e);
                };

                gnssPort.LogEventHandler += (o, e) => LogEventHandler.Rise(o, e);
            }
        }

        public void Start()
        {
            if (IsUseGNSS && gnssPort.IsActive)
                gnssPort.Stop();

            if (!azmPort.IsActive)
            {
                azmPort.Start();
                polling_stated_received = false;
            }
        }

        public void Stop()
        {
            if (azmPort.IsActive)
            {
                azmPort.Query_BaseStop();
                Thread.Sleep(300);
                azmPort.Stop();
            }

            if (IsUseGNSS && gnssPort.IsActive)
                gnssPort.Stop();
        }

        public string GetMiscInfoDescription()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("STATION\r\n━━━━━━━\r\n");

            if (stationDepth_m.IsInitialized)
                sb.AppendFormat("DPT: {0}\r\n", stationDepth_m.ToString());

            if (waterTemperature_C.IsInitialized)
                sb.AppendFormat("WTM: {0}\r\n", waterTemperature_C.ToString());

            if (stationPitch_deg.IsInitialized)
                sb.AppendFormat("PTC: {0}\r\n", stationPitch_deg.ToString());

            if (stationRoll_deg.IsInitialized)
                sb.AppendFormat("ROL: {0}\r\n", stationRoll_deg.ToString());

            if (latitude_deg.IsInitialized)
                sb.AppendFormat("LAT: {0}\r\n", latitude_deg.ToString());
            if (longitude_deg.IsInitialized)
                sb.AppendFormat("LON: {0}\r\n", longitude_deg.ToString());

            if (speed.IsInitialized)
                sb.AppendFormat("SPD: {0}\r\n", speed.ToString());

            if (course_deg.IsInitialized)
                sb.AppendFormat("CRS: {0}\r\n", course_deg.ToString());

            if (heading.IsInitialized)
                sb.AppendFormat("HDN: {0}\r\n", heading.ToString());

            return sb.ToString();
        }

        public Dictionary<string, Dictionary<string, string>> GetRemotesDescription(RemoteVisibleDataItems dataToShow)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            foreach (var remote in remotes)
            {
                result.Add(AZM.Addr2Str(remote.Key), remote.Value.ToStringList(dataToShow));
            }

            return result;
        }

        public void InitOutputPort(string portName, BaudRate baudRate)
        {
            outPort = new NMEASerialPort(
                new SerialPortSettings(portName, baudRate, Parity.None, DataBits.dataBits8, StopBits.One, Handshake.None));
            outPort.PortError += (o, e) => 
            LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, string.Format("{0} (OUT) >> {1}", portName, e.EventType)));

            outPort.Open();
        }

        public void DeInitOutputPort()
        {
            if (IsOutPortInitiaziled)
            {
                try
                {
                    outPort.Close();
                }
                catch (Exception ex)
                {
                    LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
                }
            }
        }

        public List<string> GetAvailablePortNames()
        {
            List<string> result = new List<string>();
            var pNames = SerialPort.GetPortNames();

            List<string> usedPorts = new List<string>();
            if (azmPort.Detected)
                usedPorts.Add(azmPort.PortName);

            if ((gnssPort != null) &&
                (gnssPort.Detected))
                usedPorts.Add(gnssPort.PortName);

            foreach (var name in pNames)
            {
                if (usedPorts.IndexOf(name) == -1)
                    result.Add(name);
            }

            return result;
        }

        #endregion

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (azmPort != null)
                        azmPort.Dispose();

                    if (gnssPort != null)
                        gnssPort.Dispose();

                    if (outPort != null)
                        outPort.Dispose();
                }

                disposed = true;
            }
        }

        #endregion

        #region Events

        public EventHandler<LogEventArgs> LogEventHandler;

        public EventHandler AZMPortDetectedChanged;
        public EventHandler GNSSPortDetectedChanged;

        public EventHandler IsActiveChanged;
        public EventHandler IsGNSSActiveChanged;

        public EventHandler HeadingUpdated;
        public EventHandler<AbsoluteLocationUpdatedEventArgs> AbsoluteLocationUpdated;
        public EventHandler<RelativeLocationUpdatedEventArgs> RelativeLocationUpdated;

        public EventHandler StateUpdateHandler;

        #endregion
    }
}
