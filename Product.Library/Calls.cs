using System;
using Common.Library;
using System.Collections.Generic;

namespace CallsDB
{
    #region public enum
    //TODO:Implement extension methods to check data @ instance creation/update
    //done for FollowUp.Fdate
    //done for Sale / Upgrade.sale
    public enum CallType_enum
    {
        Residential, Commercial
    }
    public enum RequestType_enum
    {
        TSR, CSR, CR, OOF, FieldS, CSS,
    }
    public enum UpgradeType_enum
    {
        none, BUNDLE, HD_BUNDLE, MOVIES, PKG, SALES, TAKE2
    }
    public enum Severity_enum
    {
        X0, X1, X2, X3, X4, X5
    }
    #endregion
    public class Calls : CommonBase
    {
        public const string XmlFile = @"entities/CallXMLDB.xml";
        public const string KeyName = "CallData";
        public const string TopElement = "Tday";
        #region Private Variables
        private Tday _WhichDay;
        private int _CallType;
        private int _CallID;
        private caler _caller;
        private Act _account;
        //= new Act("200-2367-0098", "NS", new List<Memo> { new Memo("MemoType", "Memo Value") });
        private REQuest _req;
        //= new REQuest(RequestType_enum.TSR, new UpgradE(UpgradeType_enum.MOVIES, "DIMOV", false, false, new SALE("http://www.exemple.com/fgk.aspx?dt=3", false, new FollowUp(DateTime.Now))));

        #endregion

        #region Public Properties
        public int CallID {
            get { return _CallID; }
            set
            {
                if (_CallID != value)
                {
                    _CallID = value;
                    RaisePropertyChanged("CallID");
                }
            }
        }
        public int CallType
        {
            get { return _CallType; }
            set
            {
                if (_CallType != value)
                {
                    _CallType = value;
                    RaisePropertyChanged("CallType");
                }
            }
        }

        public Tday WhichDay
        {
            get { return _WhichDay; }
            set
            {
                if (_WhichDay != value)
                {
                    _WhichDay = value;
                    RaisePropertyChanged("WhichDay");
                }
            }
        }

        public caler Caller
        {
            get { return _caller; }
            set
            {
                if (_caller != value)
                {
                    _caller = value;
                    RaisePropertyChanged("_caller");
                }
            }
        }
        public Act ACT
        {
            get { return _account; }
            set
            {
                if (_account != value)
                {
                    _account = value;
                    RaisePropertyChanged("_account");
                }
            }
        }
        public REQuest Request
        {
            get { return _req; }
            set
            {
                if (_req != value)
                {
                    _req = value;
                    RaisePropertyChanged("_req");
                }
            }
        }
        #endregion
        #region ToString Override
        public override string ToString()
        {
            switch (_CallType)
            {
                case 1: return "Residential";
                default: return "Commercial";
            }

        }
        #endregion
    }
    internal class Tday : CommonBase
    {
        #region private variables
        private DateTime _WorkDate;
        private DateTime _ShiftStart;
        private DateTime _ShiftEnd;
        private Boolean _OT;
        private Boolean _StatDay;
        #endregion
        #region constructors

        /// <summary>
        /// Tday default constructor automated internal initialzation
        /// create a default workday
        /// </summary>

        public Tday()
        {
            this._WorkDate = DateTime.Now;
            this._ShiftStart = DateTime.Now;
            this._ShiftEnd = DateTime.Now.AddHours(8.5);
            this._OT = false;
            this._StatDay = false;
        }
        /// <summary>
        /// creadtes a workday for statuary days / overtime
        /// </summary>
        /// <param name="pOT">Boolean value indication if the shift is an overtime shift</param>
        /// <param name="pStatDay">Boolean value indication if it's a statuary day</param>
        public Tday(bool pOT, bool pStatDay)
        {
            this._WorkDate = DateTime.Now;
            this._ShiftStart = DateTime.Now;
            this._ShiftEnd = DateTime.Now.AddHours(8.5);
            this._OT = pOT;
            this._StatDay = pStatDay;
        }
        /// <summary>
        /// Constructor for Select/update queries
        /// </summary>
        /// <param name="pWorkDate">system.DateTime</param>
        /// <param name="pShiftStart">system.DateTime</param>
        /// <param name="pShiftEnd">system.DateTime + 8h 30min</param>
        /// <param name="pOT">Boolean value indication if the shift is an overtime shift</param>
        /// <param name="pStatDay">Boolean value indication if it's a statuary day</param>
        public Tday(DateTime pWorkDate, DateTime pShiftStart, DateTime pShiftEnd, bool pOT, bool pStatDay)
        {
            this._WorkDate = pWorkDate;
            this._ShiftStart = pShiftStart;
            this._ShiftEnd = pShiftEnd;
            this._OT = pOT;
            this._StatDay = pStatDay;
        }

        #endregion
        #region public Tday propeties

        public DateTime WorkDate
        {
            get { return _WorkDate; }
            set
            {
                if (_WorkDate != value)
                {
                    _WorkDate = value;
                    RaisePropertyChanged("WorkDate");
                }
            }
        }
        public DateTime ShiftStart
        {
            get { return _ShiftStart; }
            set
            {
                if (_ShiftStart != value)
                {
                    _ShiftStart = value;
                    RaisePropertyChanged("ShiftStart");
                }
            }
        }
        public DateTime ShiftEnd
        {
            get { return _ShiftEnd; }
            set
            {
                if (_ShiftEnd != value)
                {
                    _ShiftEnd = value;
                    RaisePropertyChanged("ShiftEnd");
                }
            }
        }
        public bool OT
        {
            get { return _OT; }
            set
            {
                if (_OT != value)
                {
                    _OT = value;
                    RaisePropertyChanged("OT");
                }
            }
        }
        public bool StatDay
        {
            get { return _StatDay; }
            set
            {
                if (_StatDay != value)
                {
                    _StatDay = value;
                    RaisePropertyChanged("StatDay");
                }
            }
        }
        #endregion
        #region methods overrides
        public override string ToString()
        {
            return this._WorkDate.ToString();
        }
        #endregion
    }

    internal class caler : CommonBase
    {
        #region private variables
        private bool _Owner;
        private string _Name;
        private string _Phone;
        #endregion
        #region constructor
        public caler(bool pOwner, string pName, string pPhone)
        {
            this._Owner = pOwner;
            this._Name = pName;
            this._Phone = pPhone;
        }
        #endregion
        #region public properties
        public bool Owner
        {
            get { return _Owner; }
            set
            {
                if (_Owner != value)
                {
                    _Owner = value;
                    RaisePropertyChanged("Owner");
                }
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        public string Phone
        {
            get { return _Phone; }
            set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }
        #endregion
        #region methods overrides
        public override string ToString()
        {
            return _Name;
        }
        #endregion
    }

    internal class Memos : CommonBase
    {
        #region private variables
        private string _memotype;
        private string _memocontent;
        #endregion
        #region contructor
        public Memos(string pmemotype, string pmemocontent)
        {
            this._memotype = pmemotype;
            this._memocontent = pmemocontent;
        }
        #endregion
        #region public properties
        public string MemoType
        {
            get { return _memotype; }
            set
            {
                if (_memotype != value)
                {
                    _memotype = value;
                    RaisePropertyChanged("_memotype");
                }
            }
        }
        public string MemoContent
        {
            get { return _memocontent; }
            set
            {
                if (_memocontent != value)
                {
                    _memocontent = value;
                    RaisePropertyChanged("_memocontent");
                }
            }
        }
        #endregion
        #region ToString override
        public override string ToString()
        {
            return _memotype + "\t" + _memocontent;
        }
        #endregion
    }

    internal class Act : CommonBase
    {
        #region private variables
        private string _act;
        private string _ns;
        private List<Memos> _memo;
        #endregion
        #region constructor
        public Act(string pact, string pns, List<Memos> pmemos)
        {
            this._ns = pns;
            this._memo = pmemos;
        }

        #endregion
        #region public properties
        public string ACT
        {
            get { return _act; }
            set
            {
                if (_act != value)
                {
                    _act = value;
                    RaisePropertyChanged("_act");
                }
            }
        }
        public string NS
        {
            get { return _ns; }
            set
            {
                if (_ns != value)
                {
                    _ns = value;
                    RaisePropertyChanged("_ns");
                }
            }
        }
        public List<Memos> Memo
        {
            get { return _memo; }
            set
            {
                if (_memo != value)
                {
                    _memo = value;
                    RaisePropertyChanged("_memo");
                }
            }
        }
        #endregion
        #region ToString override
        public override string ToString()
        {
            return _act;
        }
        #endregion
    }

    internal class SALE : CommonBase
    {
        #region private variables
        private string _offer;
        private bool _booked;
        private FollowUp? _followup;
        #endregion
        #region constuctor
        public SALE(string poffer, bool pbooked, FollowUp? pfollowup)
        {
            this._offer = poffer;
            this._booked = pbooked;
            this._followup = pfollowup;
        }
        #endregion
        #region public properties
        public string Offer
        {
            get { return _offer; }
            set
            {
                if (_offer != value)
                {
                    _offer = value;
                    RaisePropertyChanged("_offer");
                }
            }
        }
        public bool Booked
        {
            get { return _booked; }
            set
            {
                if (_booked != value)
                {
                    _booked = value;
                    RaisePropertyChanged("_booked");
                }
            }
        }
        public FollowUp? Followup
        {
            get { return _followup.HasValue ? _followup : null; }
            set
            {
                _followup = value;
                    RaisePropertyChanged("_followup");
            }
        }
        #endregion
        #region ToString oveeride
        public override string ToString()
        {
            return _offer;
        }
        #endregion
    }

    internal class UpgradE : CommonBase
    {
        #region private variables
        private int upgradeType;
        private string _value;
        private bool _cfpp;
        private bool _ebill;
        private SALE? _sale;
        #endregion
        #region constructor
        public UpgradE(int pupgradeType, bool pcfpp, bool pebill, SALE? psale)
        {
            this.upgradeType = pupgradeType;
            switch (pupgradeType)
            {
                case (int)UpgradeType_enum.BUNDLE: this._value = "BUNDLE";break;
                case (int)UpgradeType_enum.HD_BUNDLE: this._value = "HD_BUNDLE"; break;
                case (int)UpgradeType_enum.MOVIES: this._value = "MOVIES"; break;
                case (int)UpgradeType_enum.PKG: this._value = "PKG"; break;
                case (int)UpgradeType_enum.TAKE2: this._value = "TAKE2"; break;
                case (int)UpgradeType_enum.SALES: this._value = "SALES"; break;
                default: this._value = "---"; break;
            }
           
            this._cfpp = pcfpp;
            this._ebill = pebill;
            this._sale = psale;
        }
        #endregion
        #region public properties
        public int UpgradeType
        {
            get { return upgradeType; }
            set
            {
                if (upgradeType != value)
                {
                    upgradeType = value;
                    RaisePropertyChanged("upgradeType");
                }
            }
        }
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged("_value");
                }
            }
        }
        public bool CFPP
        {
            get { return _cfpp; }
            set
            {
                if (_cfpp != value)
                {
                    _cfpp = value;
                    RaisePropertyChanged("_cfpp");
                }
            }
        }
        public bool EBILL
        {
            get { return _ebill; }
            set
            {
                if (_ebill != value)
                {
                    _ebill = value;
                    RaisePropertyChanged("_ebill");
                }
            }
        }
        public SALE? sale
        {
            get { return _sale.HasValue?_sale:null; }
            set
            {
                _sale = value;
                RaisePropertyChanged("_sale");
            }
        }
        #endregion
        #region override tostring()
        public override string ToString()
        {
            return _value;
        }
        #endregion
    }

    internal class REQuest : CommonBase
    {
        #region private variables
        private int _requestType;
        private UpgradE _upgrade;
        #endregion
        #region constructor
        public REQuest(int prequestType, UpgradE pupgrade)
        {
            this._requestType = prequestType;
            this._upgrade = pupgrade;
        }
        #endregion
        #region public properties
        public int RequestType
        {
            get { return _requestType; }
            set
            {
                if (_requestType != value)
                {
                    _requestType = value;
                    RaisePropertyChanged("prequestType");
                }
            }
        }
        public UpgradE Upgrade {
            get { return _upgrade; }
            set
            {
                if (_upgrade != value)
                {
                    _upgrade = value;
                    RaisePropertyChanged("_upgrade");
                }
            }
        }
        #endregion
        #region override ToString()
        public override string ToString()
        {
            switch (_requestType)
            {
                case (int)RequestType_enum.CR: return "CR";
                case (int)RequestType_enum.CSR: return "CSR";
                case (int)RequestType_enum.CSS: return "CSS";
                case (int)RequestType_enum.FieldS: return "FieldS";
                case (int)RequestType_enum.OOF: return "OOF";
                default: return "TSR"; 
            }           
        }
        #endregion
    }

    internal class FollowUp:CommonBase
    {
        #region private variables
        private DateTime? _fdate;
        #endregion
        #region cnstroctor
        public FollowUp(DateTime? pfdate)
        {
            this._fdate = pfdate ?? null;
        }
        #endregion
        #region public properties
        public DateTime? Fdate {
            get { return _fdate.HasValue ? _fdate : new DateTime(1999, 02, 26); }
            set
            {
                if (_fdate != value)
                {
                    _fdate = value;
                    RaisePropertyChanged("_fdate");
                }
            }
        }
        #endregion
        #region override ToString()
        public override string ToString()
        {
            return _fdate.HasValue ? _fdate.Value.ToShortDateString() : "1999-02-26";
        }
        #endregion
    }
}

