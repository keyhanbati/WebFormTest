using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices; 
using WebFormTest.db;

namespace WebFormTest.Models.Units
{
    [Serializable]
    [DebuggerDisplay("ID = {UnitID}, Code = {UnitCode}, Type = {UnitType}, FormatedText = {FormatedText}, ParentID = {ParentUnitID}")]
    public class UnitInfo : IUnitInfo
    {
        private int _id;

        private int _code;

        private UnitTypes _type;

        private int? _digitCode;

        private string _name;

        private int _parentUnitID;

        private IUnitInfo _parentUnit;

        private DateTime? _mergeDate;

        private int? _mergeToUnitID;

        private bool _isVirtual;

        private UnitStatuses _status;

        private int _flag;

        private DateTime? _openningDate;

        private int? _accountingCode;

        private int? _unitDegreeId;

        private int? _BankId;

        public int UnitID => _id;

        public int UnitCode => _code;

        public UnitTypes UnitType => _type;

        public int? DigitCode => _digitCode;

        public string UnitName => _name;

        public UnitTypes ParentUnitType => ParentUnit.UnitType;

        public int ParentUnitCode => ParentUnit.UnitCode;

        public int ParentUnitID => _parentUnitID;

        public UnitInfo ParentUnit { get; set; }

        public DateTime? MergeDate => _mergeDate;

        public int? MergeToUnitID => _mergeToUnitID;

        public bool IsVirtual => _isVirtual;

        public UnitStatuses UnitStatus => _status;

        public int Flag => _flag;

        public string UnitStatusName { get; set; }

        public string FormatedText => Conversions.ToString(UnitCode) + " - " + FormatedName;

        public string FormatedTextWithDigit { get; set; }

        public string FormatedName
        {
            get; set;
        }

        public string ClearName
        {
            get; set;
        }

        public DateTime? OpenningDate => _openningDate;

        public int? AccountingCode => _accountingCode;

        public int? UnitDegreeId => _unitDegreeId;

        public int? BankId => _BankId;

        public int UnitFlag => throw new NotImplementedException();

        public int? UnitDegree => throw new NotImplementedException();

        public string GetUnitName(bool showDigit)
        {
            if (showDigit)
            {
                return FormatedTextWithDigit;
            }

            return FormatedText;
        }
        public UnitInfo()
        {
        }

        public UnitInfo(int unitID, int unitCode, UnitTypes unitType, int? digitCode, string unitName, int parentUnitID, DateTime? mergeDate, int? mergeToUnitID, bool isVirtual, UnitStatuses unitStatus, int unitFlag, DateTime? openningDate, int? accountingCode, int? unitDegree, int? bankId)
        {
            _parentUnit = null;
            _id = unitID;
            _code = unitCode;
            _type = unitType;
            _digitCode = digitCode;
            _name = unitName;
            _parentUnitID = parentUnitID;
            _mergeDate = mergeDate;
            _mergeToUnitID = mergeToUnitID;
            _isVirtual = isVirtual;
            _status = unitStatus;
            _flag = unitFlag;
            _openningDate = openningDate;
            _accountingCode = accountingCode;
            _unitDegreeId = unitDegree;
            _BankId = bankId;
        }

        public UnitInfo(int unitID, int unitCode, UnitTypes unitType, int? digitCode, string unitName, int parentUnitID, DateTime? mergeDate, int? mergeToUnitID, bool isVirtual, UnitStatuses unitStatus, int unitFlag, DateTime? openningDate, int? accountingCode, int? unitDegree)
        {
            _parentUnit = null;
            _id = unitID;
            _code = unitCode;
            _type = unitType;
            _digitCode = digitCode;
            _name = unitName;
            _parentUnitID = parentUnitID;
            _mergeDate = mergeDate;
            _mergeToUnitID = mergeToUnitID;
            _isVirtual = isVirtual;
            _status = unitStatus;
            _flag = unitFlag;
            _openningDate = openningDate;
            _accountingCode = accountingCode;
            _unitDegreeId = unitDegree;
        }

    } 
    public class UnitInfo2 
    {
        private int _id;

        private int _code;

        private UnitTypes _type;

        private int? _digitCode;

        private string _name;

        private int _parentUnitID;

        private IUnitInfo _parentUnit;

        private DateTime? _mergeDate;

        private int? _mergeToUnitID;

        private bool _isVirtual;

        private UnitStatuses _status;

        private int _flag;

        private DateTime? _openningDate;

        private int? _accountingCode;

        private int? _unitDegreeId;

        private int? _BankId;

        public int UnitID => _id;

        public int UnitCode => _code;

        public UnitTypes UnitType => _type;

        public int? DigitCode => _digitCode;

        public string UnitName => _name;

        public UnitTypes ParentUnitType => ParentUnit.UnitType;

        public int ParentUnitCode => ParentUnit.UnitCode;

        public int ParentUnitID => _parentUnitID;

        public UnitInfo2 ParentUnit { get; set; }

        public DateTime? MergeDate => _mergeDate;

        public int? MergeToUnitID => _mergeToUnitID;

        public bool IsVirtual => _isVirtual;

        public UnitStatuses UnitStatus => _status;

        public int Flag => _flag;

        public string UnitStatusName { get; set; }

        public string FormatedText => Conversions.ToString(UnitCode) + " - " + FormatedName;

        public string FormatedTextWithDigit { get; set; }

        public string FormatedName
        {
            get; set;
        }

        public string ClearName
        {
            get; set;
        }

        public DateTime? OpenningDate => _openningDate;

        public int? AccountingCode => _accountingCode;

        public int? UnitDegreeId => _unitDegreeId;

        public int? BankId => _BankId;

        public int UnitFlag => throw new NotImplementedException();

        public int? UnitDegree => throw new NotImplementedException();

        public string GetUnitName(bool showDigit)
        {
            if (showDigit)
            {
                return FormatedTextWithDigit;
            }

            return FormatedText;
        }

        public UnitInfo2()
        { 
        } 
    }
    public interface IUnitInfo
    {
        int UnitID { get; }

        int UnitCode { get; }

        UnitTypes UnitType { get; }

        int? DigitCode { get; }

        string UnitName { get; }

        string FormatedText { get; }

        string FormatedTextWithDigit { get; }

        string FormatedName { get; }

        int ParentUnitID { get; }

        DateTime? MergeDate { get; }

        int? MergeToUnitID { get; }

        bool IsVirtual { get; }

        UnitStatuses UnitStatus { get; }

        int UnitFlag { get; }

        DateTime? OpenningDate { get; }

        int? AccountingCode { get; }

        int? UnitDegree { get; }
    }
    public enum UnitStatuses : byte
    { 
        Active = 1, 
        Deactive
    }
    public enum UnitTypes
    {
        None,
        HeadQuarter,
        BranchHead,
        Branch,
        Manager,
        Office,
        Region,
        HeadOffice,
        Counter,
        Staff,
        Line,
        Assistance,
        FinanceRegion,
        FinanceCounter,
        District
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Token { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string OtpCode { get; set; }
        public bool IsPassExpired { get; set; }
        public List<string> UserViewroles { get; set; }
        public Dictionary<string, string> Claims { get; set; }

    }
}

 
