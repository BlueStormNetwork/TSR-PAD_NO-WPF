using System;
using Common.Library;

namespace CallsDB
{
    public class Tday : CommonBase
    {
        private DateTime _WorkDate;
        private DateTime _ShiftStart;
        private DateTime _ShiftEnd;
        private Boolean _OT;
        private Boolean _StatDay;

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

    }
    public class Calls : CommonBase
    {
        public const string XmlFile = @"entities/CallXMLDB.xml";
        public const string KeyName = "Call";
        public const string TopElement = "Tday";

        #region Private Variables
        private Tday _WDay;
        private string _CallType;
        private int _CallID;
        private decimal _Price;
        #endregion       
        #region Public Properties
        public string CallType
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

        public int ProductId
        {
            get { return _CallID; }
            set
            {
                if (_CallID != value)
                {
                    _CallID = value;
                    RaisePropertyChanged("ProductId");
                }
            }
        }



        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    RaisePropertyChanged("Price");
                }
            }
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return CallType;
        }
        #endregion
    }
}

