using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlWahabAPI.Models;

public partial class ApidbContext : DbContext
{
    public ApidbContext()
    {
    }

    public ApidbContext(DbContextOptions<ApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblGenClass> TblGenClasses { get; set; }

    public virtual DbSet<TblGenFeeType> TblGenFeeTypes { get; set; }

    public virtual DbSet<TblGenMonth> TblGenMonths { get; set; }

    public virtual DbSet<TblGenWing> TblGenWings { get; set; }

    public virtual DbSet<TblRptAcademyResult> TblRptAcademyResults { get; set; }

    public virtual DbSet<TblStuExam> TblStuExams { get; set; }

    public virtual DbSet<TblStuExamResult> TblStuExamResults { get; set; }

    public virtual DbSet<TblStuExamType> TblStuExamTypes { get; set; }

    public virtual DbSet<TblStuFeeDueAndReceived> TblStuFeeDueAndReceiveds { get; set; }

    public virtual DbSet<TblStuMain> TblStuMains { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<ViewFeePaidApi> ViewFeePaidApis { get; set; }

    public virtual DbSet<ViewFeePaidComplete> ViewFeePaidCompletes { get; set; }

    public virtual DbSet<ViewFeeReceivableApi> ViewFeeReceivableApis { get; set; }

    public virtual DbSet<ViewFeeReceivableComplete> ViewFeeReceivableCompletes { get; set; }

    public virtual DbSet<ViewResult> ViewResults { get; set; }

    public virtual DbSet<ViewStudent> ViewStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=APIDB;Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblGenClass>(entity =>
        {
            entity.HasKey(e => e.ClassId);

            entity.ToTable("tblGenClasses");

            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.ClassName)
                .IsUnicode(false)
                .HasColumnName("className");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<TblGenFeeType>(entity =>
        {
            entity.HasKey(e => e.FeeTypeId);

            entity.ToTable("tblGenFeeTypes");

            entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");
            entity.Property(e => e.FeeTypeDesc)
                .IsUnicode(false)
                .HasColumnName("feeTypeDesc");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("serviceType");
        });

        modelBuilder.Entity<TblGenMonth>(entity =>
        {
            entity.HasKey(e => e.MonthId);

            entity.ToTable("tblGenMonths");

            entity.Property(e => e.MonthId).HasColumnName("monthID");
            entity.Property(e => e.MonthName)
                .IsUnicode(false)
                .HasColumnName("monthName");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
        });

        modelBuilder.Entity<TblGenWing>(entity =>
        {
            entity.HasKey(e => e.WingId);

            entity.ToTable("tblGenWings");

            entity.Property(e => e.WingId).HasColumnName("wingID");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.WingDesc)
                .IsUnicode(false)
                .HasColumnName("wingDesc");
        });

        modelBuilder.Entity<TblRptAcademyResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRptAcademyResult");

            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.GradeSlot1)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot1");
            entity.Property(e => e.GradeSlot2)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot2");
            entity.Property(e => e.GradeSlot3)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot3");
            entity.Property(e => e.GradeSlot4)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot4");
            entity.Property(e => e.GradeSlot5)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot5");
            entity.Property(e => e.GradeSlot6)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot6");
            entity.Property(e => e.GradeSlot7)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot7");
            entity.Property(e => e.Paper10Name)
                .IsUnicode(false)
                .HasColumnName("Paper10_Name");
            entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");
            entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");
            entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");
            entity.Property(e => e.Paper10Slot4).HasColumnName("Paper10_Slot4");
            entity.Property(e => e.Paper10Slot5).HasColumnName("Paper10_Slot5");
            entity.Property(e => e.Paper10Slot6).HasColumnName("Paper10_Slot6");
            entity.Property(e => e.Paper10Slot7).HasColumnName("Paper10_Slot7");
            entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");
            entity.Property(e => e.Paper11Name)
                .IsUnicode(false)
                .HasColumnName("Paper11_Name");
            entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");
            entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");
            entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");
            entity.Property(e => e.Paper11Slot4).HasColumnName("Paper11_Slot4");
            entity.Property(e => e.Paper11Slot5).HasColumnName("Paper11_Slot5");
            entity.Property(e => e.Paper11Slot6).HasColumnName("Paper11_Slot6");
            entity.Property(e => e.Paper11Slot7).HasColumnName("Paper11_Slot7");
            entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");
            entity.Property(e => e.Paper12Name)
                .IsUnicode(false)
                .HasColumnName("Paper12_Name");
            entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");
            entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");
            entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");
            entity.Property(e => e.Paper12Slot4).HasColumnName("Paper12_Slot4");
            entity.Property(e => e.Paper12Slot5).HasColumnName("Paper12_Slot5");
            entity.Property(e => e.Paper12Slot6).HasColumnName("Paper12_Slot6");
            entity.Property(e => e.Paper12Slot7).HasColumnName("Paper12_Slot7");
            entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");
            entity.Property(e => e.Paper13Name)
                .IsUnicode(false)
                .HasColumnName("Paper13_Name");
            entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");
            entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");
            entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");
            entity.Property(e => e.Paper13Slot4).HasColumnName("Paper13_Slot4");
            entity.Property(e => e.Paper13Slot5).HasColumnName("Paper13_Slot5");
            entity.Property(e => e.Paper13Slot6).HasColumnName("Paper13_Slot6");
            entity.Property(e => e.Paper13Slot7).HasColumnName("Paper13_Slot7");
            entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");
            entity.Property(e => e.Paper14Name)
                .IsUnicode(false)
                .HasColumnName("Paper14_Name");
            entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");
            entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");
            entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");
            entity.Property(e => e.Paper14Slot4).HasColumnName("Paper14_Slot4");
            entity.Property(e => e.Paper14Slot5).HasColumnName("Paper14_Slot5");
            entity.Property(e => e.Paper14Slot6).HasColumnName("Paper14_Slot6");
            entity.Property(e => e.Paper14Slot7).HasColumnName("Paper14_Slot7");
            entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");
            entity.Property(e => e.Paper1Name)
                .IsUnicode(false)
                .HasColumnName("Paper1_Name");
            entity.Property(e => e.Paper1Slot1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Paper1_Slot1");
            entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");
            entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");
            entity.Property(e => e.Paper1Slot4).HasColumnName("Paper1_Slot4");
            entity.Property(e => e.Paper1Slot5).HasColumnName("Paper1_Slot5");
            entity.Property(e => e.Paper1Slot6).HasColumnName("Paper1_Slot6");
            entity.Property(e => e.Paper1Slot7).HasColumnName("Paper1_Slot7");
            entity.Property(e => e.Paper1Total)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Paper1_Total");
            entity.Property(e => e.Paper2Name)
                .IsUnicode(false)
                .HasColumnName("Paper2_Name");
            entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");
            entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");
            entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");
            entity.Property(e => e.Paper2Slot4).HasColumnName("Paper2_Slot4");
            entity.Property(e => e.Paper2Slot5).HasColumnName("Paper2_Slot5");
            entity.Property(e => e.Paper2Slot6).HasColumnName("Paper2_Slot6");
            entity.Property(e => e.Paper2Slot7).HasColumnName("Paper2_Slot7");
            entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");
            entity.Property(e => e.Paper3Name)
                .IsUnicode(false)
                .HasColumnName("Paper3_Name");
            entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");
            entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");
            entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");
            entity.Property(e => e.Paper3Slot4).HasColumnName("Paper3_Slot4");
            entity.Property(e => e.Paper3Slot5).HasColumnName("Paper3_Slot5");
            entity.Property(e => e.Paper3Slot6).HasColumnName("Paper3_Slot6");
            entity.Property(e => e.Paper3Slot7).HasColumnName("Paper3_Slot7");
            entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");
            entity.Property(e => e.Paper4Name)
                .IsUnicode(false)
                .HasColumnName("Paper4_Name");
            entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");
            entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");
            entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");
            entity.Property(e => e.Paper4Slot4).HasColumnName("Paper4_Slot4");
            entity.Property(e => e.Paper4Slot5).HasColumnName("Paper4_Slot5");
            entity.Property(e => e.Paper4Slot6).HasColumnName("Paper4_Slot6");
            entity.Property(e => e.Paper4Slot7).HasColumnName("Paper4_Slot7");
            entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");
            entity.Property(e => e.Paper5Name)
                .IsUnicode(false)
                .HasColumnName("Paper5_Name");
            entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");
            entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");
            entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");
            entity.Property(e => e.Paper5Slot4).HasColumnName("Paper5_Slot4");
            entity.Property(e => e.Paper5Slot5).HasColumnName("Paper5_Slot5");
            entity.Property(e => e.Paper5Slot6).HasColumnName("Paper5_Slot6");
            entity.Property(e => e.Paper5Slot7).HasColumnName("Paper5_Slot7");
            entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");
            entity.Property(e => e.Paper6Name)
                .IsUnicode(false)
                .HasColumnName("Paper6_Name");
            entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");
            entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");
            entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");
            entity.Property(e => e.Paper6Slot4).HasColumnName("Paper6_Slot4");
            entity.Property(e => e.Paper6Slot5).HasColumnName("Paper6_Slot5");
            entity.Property(e => e.Paper6Slot6).HasColumnName("Paper6_Slot6");
            entity.Property(e => e.Paper6Slot7).HasColumnName("Paper6_Slot7");
            entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");
            entity.Property(e => e.Paper7Name)
                .IsUnicode(false)
                .HasColumnName("Paper7_Name");
            entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");
            entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");
            entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");
            entity.Property(e => e.Paper7Slot4).HasColumnName("Paper7_Slot4");
            entity.Property(e => e.Paper7Slot5).HasColumnName("Paper7_Slot5");
            entity.Property(e => e.Paper7Slot6).HasColumnName("Paper7_Slot6");
            entity.Property(e => e.Paper7Slot7).HasColumnName("Paper7_Slot7");
            entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");
            entity.Property(e => e.Paper8Name)
                .IsUnicode(false)
                .HasColumnName("Paper8_Name");
            entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");
            entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");
            entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");
            entity.Property(e => e.Paper8Slot4).HasColumnName("Paper8_Slot4");
            entity.Property(e => e.Paper8Slot5).HasColumnName("Paper8_Slot5");
            entity.Property(e => e.Paper8Slot6).HasColumnName("Paper8_Slot6");
            entity.Property(e => e.Paper8Slot7).HasColumnName("Paper8_Slot7");
            entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");
            entity.Property(e => e.Paper9Name)
                .IsUnicode(false)
                .HasColumnName("Paper9_Name");
            entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");
            entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");
            entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");
            entity.Property(e => e.Paper9Slot4).HasColumnName("Paper9_Slot4");
            entity.Property(e => e.Paper9Slot5).HasColumnName("Paper9_Slot5");
            entity.Property(e => e.Paper9Slot6).HasColumnName("Paper9_Slot6");
            entity.Property(e => e.Paper9Slot7).HasColumnName("Paper9_Slot7");
            entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");
            entity.Property(e => e.PercSlot1).HasColumnName("Perc_Slot1");
            entity.Property(e => e.PercSlot2).HasColumnName("Perc_Slot2");
            entity.Property(e => e.PercSlot3).HasColumnName("Perc_Slot3");
            entity.Property(e => e.PercSlot4).HasColumnName("Perc_Slot4");
            entity.Property(e => e.PercSlot5).HasColumnName("Perc_Slot5");
            entity.Property(e => e.PercSlot6).HasColumnName("Perc_Slot6");
            entity.Property(e => e.PercSlot7).HasColumnName("Perc_Slot7");
            entity.Property(e => e.PositionSlot1)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot1");
            entity.Property(e => e.PositionSlot2)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot2");
            entity.Property(e => e.PositionSlot3)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot3");
            entity.Property(e => e.PositionSlot4)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot4");
            entity.Property(e => e.PositionSlot5)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot5");
            entity.Property(e => e.PositionSlot6)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot6");
            entity.Property(e => e.PositionSlot7)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot7");
            entity.Property(e => e.Section)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("section");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");
            entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");
            entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");
            entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");
            entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");
            entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");
            entity.Property(e => e.TotalSlot6).HasColumnName("Total_Slot6");
            entity.Property(e => e.TotalSlot7).HasColumnName("Total_Slot7");
        });

        modelBuilder.Entity<TblStuExam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK_tblStuExams_1");

            entity.ToTable("tblStuExams");

            entity.Property(e => e.ExamId).HasColumnName("examID");
            entity.Property(e => e.ExamDescription)
                .IsUnicode(false)
                .HasColumnName("examDescription");
            entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isActive");
            entity.Property(e => e.IsRecordEntered).HasColumnName("isRecordEntered");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.SessionId).HasColumnName("sessionID");
        });

        modelBuilder.Entity<TblStuExamResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStuExamResults");

            entity.Property(e => e.ActualMarks).HasColumnName("actualMarks");
            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.ExamId).HasColumnName("examID");
            entity.Property(e => e.MarksObtained).HasColumnName("marksObtained");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Section)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.StdMarks).HasColumnName("stdMarks");
            entity.Property(e => e.StdMarksObtained)
                .HasDefaultValueSql("((0))")
                .HasColumnName("stdMarksObtained");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.SubjectId).HasColumnName("subjectID");
        });

        modelBuilder.Entity<TblStuExamType>(entity =>
        {
            entity.HasKey(e => e.ExamTypeId);

            entity.ToTable("tblStuExamTypes");

            entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");
            entity.Property(e => e.ExamTypeDesc)
                .IsUnicode(false)
                .HasColumnName("examTypeDesc");
            entity.Property(e => e.ExamTypeRemarks)
                .IsUnicode(false)
                .HasColumnName("examTypeRemarks");
        });

        modelBuilder.Entity<TblStuFeeDueAndReceived>(entity =>
        {
            entity.ToTable("tblStuFeeDueAndReceived");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.FeeCollector).HasColumnName("feeCollector");
            entity.Property(e => e.FeeDue)
                .HasDefaultValueSql("((0))")
                .HasColumnName("feeDue");
            entity.Property(e => e.FeeMonthId).HasColumnName("feeMonthID");
            entity.Property(e => e.FeePaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("feePaid");
            entity.Property(e => e.FeeRemarks)
                .IsUnicode(false)
                .HasDefaultValueSql("('None')")
                .HasColumnName("feeRemarks");
            entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");
            entity.Property(e => e.FeeUnpaid)
                .HasComputedColumnSql("([feeDue]-[feePaid])", false)
                .HasColumnName("feeUnpaid");
            entity.Property(e => e.FundAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fundAmount");
            entity.Property(e => e.InstallmentStatus).HasColumnName("installmentStatus");
            entity.Property(e => e.ReceiptTime)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("receiptTime");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.WriteOff)
                .HasDefaultValueSql("((0))")
                .HasColumnName("writeOff");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<TblStuMain>(entity =>
        {
            entity.HasKey(e => e.StuId);

            entity.ToTable("tblStuMain");

            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.StuAdditionalRemarks)
                .IsUnicode(false)
                .HasColumnName("stuAdditionalRemarks");
            entity.Property(e => e.StuAdmClass).HasColumnName("stuAdmClass");
            entity.Property(e => e.StuAdmDate)
                .HasColumnType("date")
                .HasColumnName("stuAdmDate");
            entity.Property(e => e.StuAdmRemarks)
                .IsUnicode(false)
                .HasColumnName("stuAdmRemarks");
            entity.Property(e => e.StuAdmTestResults).HasColumnName("stuAdmTestResults");
            entity.Property(e => e.StuAdmissionNumber)
                .IsUnicode(false)
                .HasColumnName("stuAdmissionNumber");
            entity.Property(e => e.StuBform).HasColumnName("stuBForm");
            entity.Property(e => e.StuBirthCertificate).HasColumnName("stuBirthCertificate");
            entity.Property(e => e.StuCastId).HasColumnName("stuCastID");
            entity.Property(e => e.StuCity)
                .IsUnicode(false)
                .HasColumnName("stuCity");
            entity.Property(e => e.StuCurrentClass).HasColumnName("stuCurrentClass");
            entity.Property(e => e.StuCurrentDiscount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("stuCurrentDiscount");
            entity.Property(e => e.StuCurrentSection)
                .IsUnicode(false)
                .HasColumnName("stuCurrentSection");
            entity.Property(e => e.StuCurrentWing).HasColumnName("stuCurrentWing");
            entity.Property(e => e.StuDiscountReason).HasColumnName("stuDiscountReason");
            entity.Property(e => e.StuDob)
                .HasColumnType("date")
                .HasColumnName("stuDOB");
            entity.Property(e => e.StuEmail)
                .IsUnicode(false)
                .HasColumnName("stuEmail");
            entity.Property(e => e.StuFatherBusinessAdd)
                .IsUnicode(false)
                .HasColumnName("stuFatherBusinessAdd");
            entity.Property(e => e.StuFatherBusinessTown).HasColumnName("stuFatherBusinessTown");
            entity.Property(e => e.StuFatherCnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("stuFatherCNIC");
            entity.Property(e => e.StuFatherCniccopy).HasColumnName("stuFatherCNICCopy");
            entity.Property(e => e.StuFatherMobile)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("stuFatherMobile");
            entity.Property(e => e.StuFatherName)
                .IsUnicode(false)
                .HasColumnName("stuFatherName");
            entity.Property(e => e.StuFatherOccupation).HasColumnName("stuFatherOccupation");
            entity.Property(e => e.StuFeeReminderRemarks)
                .IsUnicode(false)
                .HasColumnName("stuFeeReminderRemarks");
            entity.Property(e => e.StuFingerPrint).HasColumnName("stuFingerPrint");
            entity.Property(e => e.StuGender)
                .IsUnicode(false)
                .HasColumnName("stuGender");
            entity.Property(e => e.StuHomeStreet)
                .IsUnicode(false)
                .HasColumnName("stuHomeStreet");
            entity.Property(e => e.StuHomeTelNo)
                .IsUnicode(false)
                .HasColumnName("stuHomeTelNo");
            entity.Property(e => e.StuHomeTown).HasColumnName("stuHomeTown");
            entity.Property(e => e.StuInqId).HasColumnName("stuInqID");
            entity.Property(e => e.StuLastPromotionDate)
                .HasColumnType("date")
                .HasColumnName("stuLastPromotionDate");
            entity.Property(e => e.StuMedicalProblems)
                .IsUnicode(false)
                .HasColumnName("stuMedicalProblems");
            entity.Property(e => e.StuName)
                .IsUnicode(false)
                .HasColumnName("stuName");
            entity.Property(e => e.StuOfficeTelNo)
                .IsUnicode(false)
                .HasColumnName("stuOfficeTelNo");
            entity.Property(e => e.StuRegNumber)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("stuRegNumber");
            entity.Property(e => e.StuReligionId).HasColumnName("stuReligionID");
            entity.Property(e => e.StuResultCard).HasColumnName("stuResultCard");
            entity.Property(e => e.StuSlc).HasColumnName("stuSLC");
            entity.Property(e => e.StuStatus).HasColumnName("stuStatus");
            entity.Property(e => e.StuWithDrawalCause)
                .IsUnicode(false)
                .HasColumnName("stuWithDrawalCause");
            entity.Property(e => e.StuWithDrawalDate)
                .HasColumnType("date")
                .HasColumnName("stuWithDrawalDate");
            entity.Property(e => e.StuWithDrawalRemarks)
                .IsUnicode(false)
                .HasColumnName("stuWithDrawalRemarks");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUsers");

            entity.Property(e => e.ActualName)
                .IsUnicode(false)
                .HasColumnName("actualName");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Roles)
                .IsUnicode(false)
                .HasColumnName("roles");
            entity.Property(e => e.SecurityAnswer)
                .IsUnicode(false)
                .HasColumnName("securityAnswer");
            entity.Property(e => e.SecurityQuestion)
                .IsUnicode(false)
                .HasColumnName("securityQuestion");
            entity.Property(e => e.UserType)
                .IsUnicode(false)
                .HasColumnName("userType");
            entity.Property(e => e.Username)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ViewFeePaidApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFeePaidAPI");

            entity.Property(e => e.FeeAmount).HasColumnName("feeAmount");
            entity.Property(e => e.FeeMonth)
                .IsUnicode(false)
                .HasColumnName("feeMonth");
            entity.Property(e => e.FeeType)
                .IsUnicode(false)
                .HasColumnName("feeType");
            entity.Property(e => e.FeeYear).HasColumnName("feeYear");
            entity.Property(e => e.StuId).HasColumnName("stuID");
        });

        modelBuilder.Entity<ViewFeePaidComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFeePaidComplete");

            entity.Property(e => e.Class).IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.FatherName)
                .IsUnicode(false)
                .HasColumnName("Father Name");
            entity.Property(e => e.FeeDue).HasColumnName("Fee Due");
            entity.Property(e => e.FeeMonth)
                .IsUnicode(false)
                .HasColumnName("Fee Month");
            entity.Property(e => e.FeePaid).HasColumnName("feePaid");
            entity.Property(e => e.FeeRemarks)
                .IsUnicode(false)
                .HasColumnName("feeRemarks");
            entity.Property(e => e.FeeType)
                .IsUnicode(false)
                .HasColumnName("Fee Type");
            entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");
            entity.Property(e => e.FeeUnpaid).HasColumnName("Fee Unpaid");
            entity.Property(e => e.FeeYear).HasColumnName("Fee Year");
            entity.Property(e => e.Home).IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.MonthId).HasColumnName("monthID");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ShortName).IsUnicode(false);
            entity.Property(e => e.StuFeeReminderRemarks)
                .IsUnicode(false)
                .HasColumnName("stuFeeReminderRemarks");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.StuOfficeTelNo)
                .IsUnicode(false)
                .HasColumnName("stuOfficeTelNo");
            entity.Property(e => e.Wing).IsUnicode(false);
            entity.Property(e => e.WingId).HasColumnName("wingID");
        });

        modelBuilder.Entity<ViewFeeReceivableApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFeeReceivableAPI");

            entity.Property(e => e.FeeMonth)
                .IsUnicode(false)
                .HasColumnName("Fee Month");
            entity.Property(e => e.FeeType)
                .IsUnicode(false)
                .HasColumnName("Fee Type");
            entity.Property(e => e.FeeUnpaid).HasColumnName("Fee Unpaid");
            entity.Property(e => e.FeeYear).HasColumnName("Fee Year");
            entity.Property(e => e.StuId).HasColumnName("stuID");
        });

        modelBuilder.Entity<ViewFeeReceivableComplete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewFeeReceivableComplete");

            entity.Property(e => e.Class).IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.FatherName)
                .IsUnicode(false)
                .HasColumnName("Father Name");
            entity.Property(e => e.FeeDue).HasColumnName("Fee Due");
            entity.Property(e => e.FeeMonth)
                .IsUnicode(false)
                .HasColumnName("Fee Month");
            entity.Property(e => e.FeeRemarks)
                .IsUnicode(false)
                .HasColumnName("feeRemarks");
            entity.Property(e => e.FeeType)
                .IsUnicode(false)
                .HasColumnName("Fee Type");
            entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");
            entity.Property(e => e.FeeUnpaid).HasColumnName("Fee Unpaid");
            entity.Property(e => e.FeeYear).HasColumnName("Fee Year");
            entity.Property(e => e.Home).IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.MonthId).HasColumnName("monthID");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ShortName).IsUnicode(false);
            entity.Property(e => e.StuFeeReminderRemarks)
                .IsUnicode(false)
                .HasColumnName("stuFeeReminderRemarks");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.StuOfficeTelNo)
                .IsUnicode(false)
                .HasColumnName("stuOfficeTelNo");
            entity.Property(e => e.Wing).IsUnicode(false);
            entity.Property(e => e.WingId).HasColumnName("wingID");
        });

        modelBuilder.Entity<ViewResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewResult");

            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.ClassName)
                .IsUnicode(false)
                .HasColumnName("className");
            entity.Property(e => e.GradeSlot1)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot1");
            entity.Property(e => e.GradeSlot2)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot2");
            entity.Property(e => e.GradeSlot3)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot3");
            entity.Property(e => e.GradeSlot4)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot4");
            entity.Property(e => e.GradeSlot5)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot5");
            entity.Property(e => e.GradeSlot6)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot6");
            entity.Property(e => e.GradeSlot7)
                .IsUnicode(false)
                .HasColumnName("Grade_Slot7");
            entity.Property(e => e.Paper10Name)
                .IsUnicode(false)
                .HasColumnName("Paper10_Name");
            entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");
            entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");
            entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");
            entity.Property(e => e.Paper10Slot4).HasColumnName("Paper10_Slot4");
            entity.Property(e => e.Paper10Slot5).HasColumnName("Paper10_Slot5");
            entity.Property(e => e.Paper10Slot6).HasColumnName("Paper10_Slot6");
            entity.Property(e => e.Paper10Slot7).HasColumnName("Paper10_Slot7");
            entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");
            entity.Property(e => e.Paper11Name)
                .IsUnicode(false)
                .HasColumnName("Paper11_Name");
            entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");
            entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");
            entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");
            entity.Property(e => e.Paper11Slot4).HasColumnName("Paper11_Slot4");
            entity.Property(e => e.Paper11Slot5).HasColumnName("Paper11_Slot5");
            entity.Property(e => e.Paper11Slot6).HasColumnName("Paper11_Slot6");
            entity.Property(e => e.Paper11Slot7).HasColumnName("Paper11_Slot7");
            entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");
            entity.Property(e => e.Paper12Name)
                .IsUnicode(false)
                .HasColumnName("Paper12_Name");
            entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");
            entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");
            entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");
            entity.Property(e => e.Paper12Slot4).HasColumnName("Paper12_Slot4");
            entity.Property(e => e.Paper12Slot5).HasColumnName("Paper12_Slot5");
            entity.Property(e => e.Paper12Slot6).HasColumnName("Paper12_Slot6");
            entity.Property(e => e.Paper12Slot7).HasColumnName("Paper12_Slot7");
            entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");
            entity.Property(e => e.Paper13Name)
                .IsUnicode(false)
                .HasColumnName("Paper13_Name");
            entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");
            entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");
            entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");
            entity.Property(e => e.Paper13Slot4).HasColumnName("Paper13_Slot4");
            entity.Property(e => e.Paper13Slot5).HasColumnName("Paper13_Slot5");
            entity.Property(e => e.Paper13Slot6).HasColumnName("Paper13_Slot6");
            entity.Property(e => e.Paper13Slot7).HasColumnName("Paper13_Slot7");
            entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");
            entity.Property(e => e.Paper14Name)
                .IsUnicode(false)
                .HasColumnName("Paper14_Name");
            entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");
            entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");
            entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");
            entity.Property(e => e.Paper14Slot4).HasColumnName("Paper14_Slot4");
            entity.Property(e => e.Paper14Slot5).HasColumnName("Paper14_Slot5");
            entity.Property(e => e.Paper14Slot6).HasColumnName("Paper14_Slot6");
            entity.Property(e => e.Paper14Slot7).HasColumnName("Paper14_Slot7");
            entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");
            entity.Property(e => e.Paper1Name)
                .IsUnicode(false)
                .HasColumnName("Paper1_Name");
            entity.Property(e => e.Paper1Slot1).HasColumnName("Paper1_Slot1");
            entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");
            entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");
            entity.Property(e => e.Paper1Slot4).HasColumnName("Paper1_Slot4");
            entity.Property(e => e.Paper1Slot5).HasColumnName("Paper1_Slot5");
            entity.Property(e => e.Paper1Slot6).HasColumnName("Paper1_Slot6");
            entity.Property(e => e.Paper1Slot7).HasColumnName("Paper1_Slot7");
            entity.Property(e => e.Paper1Total).HasColumnName("Paper1_Total");
            entity.Property(e => e.Paper2Name)
                .IsUnicode(false)
                .HasColumnName("Paper2_Name");
            entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");
            entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");
            entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");
            entity.Property(e => e.Paper2Slot4).HasColumnName("Paper2_Slot4");
            entity.Property(e => e.Paper2Slot5).HasColumnName("Paper2_Slot5");
            entity.Property(e => e.Paper2Slot6).HasColumnName("Paper2_Slot6");
            entity.Property(e => e.Paper2Slot7).HasColumnName("Paper2_Slot7");
            entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");
            entity.Property(e => e.Paper3Name)
                .IsUnicode(false)
                .HasColumnName("Paper3_Name");
            entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");
            entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");
            entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");
            entity.Property(e => e.Paper3Slot4).HasColumnName("Paper3_Slot4");
            entity.Property(e => e.Paper3Slot5).HasColumnName("Paper3_Slot5");
            entity.Property(e => e.Paper3Slot6).HasColumnName("Paper3_Slot6");
            entity.Property(e => e.Paper3Slot7).HasColumnName("Paper3_Slot7");
            entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");
            entity.Property(e => e.Paper4Name)
                .IsUnicode(false)
                .HasColumnName("Paper4_Name");
            entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");
            entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");
            entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");
            entity.Property(e => e.Paper4Slot4).HasColumnName("Paper4_Slot4");
            entity.Property(e => e.Paper4Slot5).HasColumnName("Paper4_Slot5");
            entity.Property(e => e.Paper4Slot6).HasColumnName("Paper4_Slot6");
            entity.Property(e => e.Paper4Slot7).HasColumnName("Paper4_Slot7");
            entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");
            entity.Property(e => e.Paper5Name)
                .IsUnicode(false)
                .HasColumnName("Paper5_Name");
            entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");
            entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");
            entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");
            entity.Property(e => e.Paper5Slot4).HasColumnName("Paper5_Slot4");
            entity.Property(e => e.Paper5Slot5).HasColumnName("Paper5_Slot5");
            entity.Property(e => e.Paper5Slot6).HasColumnName("Paper5_Slot6");
            entity.Property(e => e.Paper5Slot7).HasColumnName("Paper5_Slot7");
            entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");
            entity.Property(e => e.Paper6Name)
                .IsUnicode(false)
                .HasColumnName("Paper6_Name");
            entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");
            entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");
            entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");
            entity.Property(e => e.Paper6Slot4).HasColumnName("Paper6_Slot4");
            entity.Property(e => e.Paper6Slot5).HasColumnName("Paper6_Slot5");
            entity.Property(e => e.Paper6Slot6).HasColumnName("Paper6_Slot6");
            entity.Property(e => e.Paper6Slot7).HasColumnName("Paper6_Slot7");
            entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");
            entity.Property(e => e.Paper7Name)
                .IsUnicode(false)
                .HasColumnName("Paper7_Name");
            entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");
            entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");
            entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");
            entity.Property(e => e.Paper7Slot4).HasColumnName("Paper7_Slot4");
            entity.Property(e => e.Paper7Slot5).HasColumnName("Paper7_Slot5");
            entity.Property(e => e.Paper7Slot6).HasColumnName("Paper7_Slot6");
            entity.Property(e => e.Paper7Slot7).HasColumnName("Paper7_Slot7");
            entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");
            entity.Property(e => e.Paper8Name)
                .IsUnicode(false)
                .HasColumnName("Paper8_Name");
            entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");
            entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");
            entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");
            entity.Property(e => e.Paper8Slot4).HasColumnName("Paper8_Slot4");
            entity.Property(e => e.Paper8Slot5).HasColumnName("Paper8_Slot5");
            entity.Property(e => e.Paper8Slot6).HasColumnName("Paper8_Slot6");
            entity.Property(e => e.Paper8Slot7).HasColumnName("Paper8_Slot7");
            entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");
            entity.Property(e => e.Paper9Name)
                .IsUnicode(false)
                .HasColumnName("Paper9_Name");
            entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");
            entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");
            entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");
            entity.Property(e => e.Paper9Slot4).HasColumnName("Paper9_Slot4");
            entity.Property(e => e.Paper9Slot5).HasColumnName("Paper9_Slot5");
            entity.Property(e => e.Paper9Slot6).HasColumnName("Paper9_Slot6");
            entity.Property(e => e.Paper9Slot7).HasColumnName("Paper9_Slot7");
            entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");
            entity.Property(e => e.PercSlot1).HasColumnName("Perc_Slot1");
            entity.Property(e => e.PercSlot2).HasColumnName("Perc_Slot2");
            entity.Property(e => e.PercSlot3).HasColumnName("Perc_Slot3");
            entity.Property(e => e.PercSlot4).HasColumnName("Perc_Slot4");
            entity.Property(e => e.PercSlot5).HasColumnName("Perc_Slot5");
            entity.Property(e => e.PercSlot6).HasColumnName("Perc_Slot6");
            entity.Property(e => e.PercSlot7).HasColumnName("Perc_Slot7");
            entity.Property(e => e.PositionSlot1)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot1");
            entity.Property(e => e.PositionSlot2)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot2");
            entity.Property(e => e.PositionSlot3)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot3");
            entity.Property(e => e.PositionSlot4)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot4");
            entity.Property(e => e.PositionSlot5)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot5");
            entity.Property(e => e.PositionSlot6)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot6");
            entity.Property(e => e.PositionSlot7)
                .HasMaxLength(50)
                .HasColumnName("Position_Slot7");
            entity.Property(e => e.Section)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.StuName)
                .IsUnicode(false)
                .HasColumnName("stuName");
            entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");
            entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");
            entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");
            entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");
            entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");
            entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");
            entity.Property(e => e.TotalSlot6).HasColumnName("Total_Slot6");
            entity.Property(e => e.TotalSlot7).HasColumnName("Total_Slot7");
        });

        modelBuilder.Entity<ViewStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewStudents");

            entity.Property(e => e.ClassName)
                .IsUnicode(false)
                .HasColumnName("className");
            entity.Property(e => e.StuId).HasColumnName("stuID");
            entity.Property(e => e.StuName)
                .IsUnicode(false)
                .HasColumnName("stuName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
