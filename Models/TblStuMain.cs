using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblStuMain
{
    public long StuId { get; set; }

    public long? StuInqId { get; set; }

    public string? StuRegNumber { get; set; }

    public string StuName { get; set; } = null!;

    public string StuFatherName { get; set; } = null!;

    public int StuStatus { get; set; }

    public DateTime? StuDob { get; set; }

    public string? StuGender { get; set; }

    public string? StuFatherCnic { get; set; }

    public int? StuFatherOccupation { get; set; }

    public string? StuHomeStreet { get; set; }

    public int? StuHomeTown { get; set; }

    public string? StuCity { get; set; }

    public string? StuFatherBusinessAdd { get; set; }

    public int? StuFatherBusinessTown { get; set; }

    public string? StuFatherMobile { get; set; }

    public string? StuHomeTelNo { get; set; }

    public string? StuOfficeTelNo { get; set; }

    public string? StuEmail { get; set; }

    public DateTime? StuAdmDate { get; set; }

    public int? StuAdmClass { get; set; }

    public int? StuAdmTestResults { get; set; }

    public string? StuAdmRemarks { get; set; }

    public int? StuCurrentClass { get; set; }

    public int? StuCurrentWing { get; set; }

    public string? StuCurrentSection { get; set; }

    public DateTime? StuLastPromotionDate { get; set; }

    public long? StuCurrentDiscount { get; set; }

    public int? StuDiscountReason { get; set; }

    public DateTime? StuWithDrawalDate { get; set; }

    public string? StuWithDrawalCause { get; set; }

    public string? StuWithDrawalRemarks { get; set; }

    public string? StuFeeReminderRemarks { get; set; }

    public string? StuAdditionalRemarks { get; set; }

    public int? StuReligionId { get; set; }

    public int? StuCastId { get; set; }

    public string? StuMedicalProblems { get; set; }

    public string? StuAdmissionNumber { get; set; }

    public bool? StuBirthCertificate { get; set; }

    public bool? StuBform { get; set; }

    public bool? StuFatherCniccopy { get; set; }

    public bool? StuSlc { get; set; }

    public bool? StuResultCard { get; set; }

    public byte[]? Image { get; set; }

    public int? StuFingerPrint { get; set; }

    public byte[]? Photo { get; set; }
}
