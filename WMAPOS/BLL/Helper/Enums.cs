using System;
using System.Data.Entity;
using System.Linq;

namespace BLL.Helper
{
    #region حالات شاشة التعديل
    /// <summary>
    /// حالات شاشة التعديل
    /// </summary>
    public enum EditFormActionType
    {
        Edit = 0,
        New,
        First,
        Next,
        Previous,
        Last
    }
    #endregion
    #region حالة الاصل
    /// <summary>
    /// حالة الاصل
    /// </summary>
    public enum AssetStatus
    {
        Active = 1,
        InActive = 2,
        TotallyDepreciated = 3,
        Sold = 4,
        New = 5
    }

    public enum NBTypes
    {
        /// <summary>
        /// Receipt Notebook 
        /// </summary>
        NBR,
        /// <summary>
        /// Payment Notebook 
        /// </summary>
        NBP,
        /// <summary>
        /// Check Notebook 
        /// </summary>
        NBC
    }

    public enum VoucherStatus
    {
        Available = 1,
        Canceled = 2,
        Used = 3
    }
    #endregion
    #region معاملات النظام
    /// <summary>
    /// انواع المعاملات الموجوده فى النظام ككل
    /// lkp_TrxTypes
    /// </summary>
    public enum TrxTypes
    {

        /// <summary>
        /// تسليم عهد للموظف
        /// </summary>
        ATDL = 1,
        /// <summary>
        /// استلام عهد من موظف
        /// </summary>
        ATRC,
        /// <summary>
        /// البنوك
        /// </summary>
        Bank,
        /// <summary>
        /// تمديد ضمان بنكي
        /// </summary>
        BGEX,
        /// <summary>
        /// اصدار ضمان بنكي
        /// </summary>
        BGIS,
        /// <summary>
        /// طلب اصدار ضمان بنكى
        /// </summary>
        BGRQ,
        /// <summary>
        /// ارتجاع ضمان بنكي
        /// </summary>
        BGRT,
        /// <summary>
        /// الزيارات
        /// </summary>
        BSVI,
        /// <summary>
        /// أجازات الماكيرات
        /// </summary>
        BSVO,
        /// <summary>
        /// دفعة بنكية
        /// </summary>
        CABP,
        /// <summary>
        /// تحصيل بنكي
        /// </summary>
        CABR,
        /// <summary>
        /// توزيع مركز تكلفة
        /// </summary>
        CACC,
        /// <summary>
        /// طباعة شيكات
        /// </summary>
        CACH,
        /// <summary>
        /// اشعارات دائنة
        /// </summary>
        CACN,
        /// <summary>
        /// سند صرف
        /// </summary>
        CAPY,
        /// <summary>
        /// سند قبض
        /// </summary>
        CARC,
        /// <summary>
        /// شيكات تحت التحصيل
        /// </summary>
        CACU,
        /// <summary>
        /// اشعارات مدينة
        /// </summary>
        CADN,
        /// <summary>
        /// تسوية عهد نقدية
        /// </summary>
        CAPA,
        /// <summary>
        /// الصناديق
        /// </summary>
        Cash,
        /// <summary>
        /// تحويل نقدية
        /// </summary>
        CATR,
        /// <summary>
        /// شيكات تحت الدفع
        /// </summary>
        CAUP,
        /// <summary>
        /// صرف الاعاشة
        /// </summary>
        CTDL,
        /// <summary>
        /// القوالب
        /// </summary>
        CTTM,
        /// <summary>
        /// رصيد افتتاحي
        /// </summary>
        CUBB,
        /// <summary>
        /// تسويات
        /// </summary>
        CVAD,
        /// <summary>
        /// رصيد افتتاحي
        /// </summary>
        FXBB,
        /// <summary>
        /// تعاقد اصول
        /// </summary>
        FXCN,
        /// <summary>
        /// تجهيز اصول
        /// </summary>
        FXPP,
        /// <summary>
        /// تفعيل اصول
        /// </summary>
        FXAC,
        /// <summary>
        /// صرف أصول
        /// </summary>
        FXDL,
        /// <summary>
        /// إهلاكات
        /// </summary>
        FXDP,
        /// <summary>
        /// تعلية أصل
        /// </summary>
        FXEL,
        /// <summary>
        /// اهلاك نهائي
        /// </summary>
        FXFD,
        /// <summary>
        /// مشتريات أصول
        /// </summary>
        FXPR,
        /// <summary>
        /// صيانة الاصول
        /// </summary>
        FXMT,
        /// <summary>
        /// مرتجع مشتريات أصول
        /// </summary>
        FXPX,
        /// <summary>
        /// استلام - صرف - تحويل أصول
        /// </summary>
        FXTR,
        /// <summary>
        /// إعادة تقييم الأصل
        /// </summary>
        FXRE,
        /// <summary>
        /// مبيعات أصول
        /// </summary>
        FXSA,
        /// <summary>
        /// مرتجع مبيعات أصول
        /// </summary>
        FXSX,
        /// <summary>
        /// مناقلة سيارة
        /// </summary>
        FXTN,
        /// <summary>
        /// استلام اصول
        /// </summary>
        FXRC,
        /// <summary>
        /// رصيد إفتتاحى
        /// </summary>
        GLBB,
        /// <summary>
        /// قيد يومية
        /// </summary>
        GLJV,
        /// <summary>
        /// قيد تكرارى
        /// </summary>
        GLRE,
        /// <summary>
        /// الرصيد الإفتتاحى للغياب
        /// </summary>
        HRAB,
        /// <summary>
        /// الحضور والإنصراف
        /// </summary>
        HRAT,
        /// <summary>
        /// عقد موظف
        /// </summary>
        HRCN,
        /// <summary>
        /// أجازة إضطرارية غير مدفوعة
        /// </summary>
        HRCV,
        /// <summary>
        /// استعاضة على رأس العمل
        /// </summary>
        HRDL,
        /// <summary>
        /// تجديد مستندات موظف
        /// </summary>
        HRDR,
        /// <summary>
        /// أجراء لموظف
        /// </summary>
        HREA,
        /// <summary>
        /// كفالة موظف
        /// </summary>
        HREG,
        /// <summary>
        /// ترقية موظف
        /// </summary>
        HREP,
        /// <summary>
        /// هروب
        /// </summary>
        HRES,
        /// <summary>
        /// معاملة أيام التجاوز
        /// </summary>
        HRET,
        /// <summary>
        /// إيقاف موظف
        /// </summary>
        HREZ,
        /// <summary>
        /// خرج و لم يعد
        /// </summary>
        HRGB,
        /// <summary>
        /// بدل السكن
        /// </summary>
        HRHF,
        /// <summary>
        /// انهاء اصابة عمل
        /// </summary>
        HRIE,
        /// <summary>
        /// سلف موظفين
        /// </summary>
        HRLN,
        /// <summary>
        /// تسديد قسط سلفة
        /// </summary>
        HRLP,
        /// <summary>
        /// نقل موظف
        /// </summary>
        HRLT,
        /// <summary>
        /// الرصيد الإفتتاحى لأيام التجاوز
        /// </summary>
        HROB,
        /// <summary>
        /// انهاء خدمات موظف
        /// </summary>
        HROS,
        /// <summary>
        /// المخصصات الوظيفية
        /// </summary>
        HRPV,
        /// <summary>
        /// الرواتب
        /// </summary>
        HRSA,
        /// <summary>
        /// إنهاء إيقاف موظف
        /// </summary>
        HRSE,
        /// <summary>
        /// تسديد قسط سلفة مع الراتب
        /// </summary>
        HRSL,
        /// <summary>
        /// نقل كفالة
        /// </summary>
        HRST,
        /// <summary>
        /// الإشراف
        /// </summary>
        HRSU,
        /// <summary>
        /// الرصيد الإفتتاحى لتذاكر السفر
        /// </summary>
        HRTB,
        /// <summary>
        /// صرف تذاكر سفر
        /// </summary>
        HRTI,
        /// <summary>
        /// اجازة اضطرارية
        /// </summary>
        HRTV,
        /// <summary>
        /// الرصيد الإفتتاحى للأجازات
        /// </summary>
        HRVB,
        /// <summary>
        /// اجازة موظف
        /// </summary>
        HRVC,
        /// <summary>
        /// طلب اجازة
        /// </summary>
        HRVO,
        /// <summary>
        /// الإنذارات
        /// </summary>
        HRWA,
        /// <summary>
        /// اصابة عمل
        /// </summary>
        HRWI,
        /// <summary>
        /// مباشرة العمل
        /// </summary>
        HRWP,
        /// <summary>
        /// فاتورة وساطة - مورد
        /// </summary>
        IMPR,
        /// <summary>
        /// فاتورة وساطة - عميل
        /// </summary>
        IMSA,
        /// <summary>
        /// تسويات المخزون
        /// </summary>
        IVAD,
        /// <summary>
        /// تجميع مخزني
        /// </summary>
        IVAS,
        /// <summary>
        /// رصيد افتتاحي
        /// </summary>
        IVBB,
        /// <summary>
        /// محضر الجرد
        /// </summary>
        IVCF,
        /// <summary>
        /// الجرد المخزني
        /// </summary>
        IVCT,
        /// <summary>
        /// صرف مخزني
        /// </summary>
        IVDL,
        /// <summary>
        /// اتلاف مخزني
        /// </summary>
        IVDP,
        /// <summary>
        /// تفكيك مخزني
        /// </summary>
        IVDS,
        /// <summary>
        /// حجز كميات
        /// </summary>
        IVHD,
        /// <summary>
        /// طلب حجز كميات
        /// </summary>
        IVHR,
        /// <summary>
        /// استلام مخزني
        /// </summary>
        IVRC,
        /// <summary>
        /// إعادة تقييم المخزون
        /// </summary>
        IVSR,
        /// <summary>
        /// طلب تحويل مخزنى
        /// </summary>
        IVTQ,
        /// <summary>
        /// تحويل مخزني
        /// </summary>
        IVTR,
        /// <summary>
        /// فك حجز كميات
        /// </summary>
        IVUH,
        /// <summary>
        /// سند عرض
        /// </summary>
        JWDV,
        /// <summary>
        /// سند شراء
        /// </summary>
        JWPV,
        /// <summary>
        /// سند إرجاع
        /// </summary>
        JWRV,
        /// <summary>
        /// المجوهرات : فاتورة مبيعات
        /// </summary>
        JWSI,
        /// <summary>
        /// اغلاق الاعتماد
        /// </summary>
        LCCL,
        /// <summary>
        /// مصاريف الاعتماد
        /// </summary>
        LCEX,
        /// <summary>
        /// استلام بضاعة اعتماد مستندي
        /// </summary>
        LCGR,
        /// <summary>
        /// انقاص تأمين الاعتماد
        /// </summary>
        LCID,
        /// <summary>
        /// زيادة تأمين الاعتماد
        /// </summary>
        LCII,
        /// <summary>
        /// فتح اعتماد
        /// </summary>
        LCOP,
        /// <summary>
        /// تسديد اعتماد
        /// </summary>
        LCPP,
        /// <summary>
        /// صرف مواد خام للتصنيع
        /// </summary>
        MFDL,
        /// <summary>
        /// تكلفة معدات التصنيع
        /// </summary>
        MFFX,
        /// <summary>
        /// تكلفة العمالة
        /// </summary>
        MFHR,
        /// <summary>
        /// تكاليف تصنيع أخرى
        /// </summary>
        MFOC,
        /// <summary>
        /// استلام المنتج التام
        /// </summary>
        MFRC,
        /// <summary>
        /// ارتجاع مواد خام
        /// </summary>
        MFRT,
        /// <summary>
        /// إضافة بنود لمشروع
        /// </summary>
        OJAI,
        /// <summary>
        /// مستخلص عقد جهة مالكة
        /// </summary>
        OJCE,
        /// <summary>
        /// عقود المقاولين
        /// </summary>
        OJCN,
        /// <summary>
        /// حذف بنود مشروع
        /// </summary>
        OJDI,
        /// <summary>
        /// عقود مقاولين الباطن
        /// </summary>
        OJSC,
        /// <summary>
        /// مستخلص عقد مقاول الباطن
        /// </summary>
        OJSE,
        /// <summary>
        /// تكاليف مضافة
        /// </summary>
        PRAC,
        /// <summary>
        /// مقارنة أسعار
        /// </summary>
        PRCM,
        /// <summary>
        /// طلب شــراء
        /// </summary>
        PRFQ,
        /// <summary>
        /// فاتورة مشتريات
        /// </summary>
        PRIV,
        /// <summary>
        /// أمر شراء
        /// </summary>
        PROR,
        /// <summary>
        /// عرض أسعار 
        /// </summary>
        PRQU,
        /// <summary>
        /// مرتجع مشتريات
        /// </summary>
        PRRT,
        /// <summary>
        /// اغلاق نقاط البيع
        /// </summary>
        PSCL,
        /// <summary>
        /// تسويات مستأجرين
        /// </summary>
        READ,
        /// <summary>
        /// دفعة بنك
        /// </summary>
        REBP,
        /// <summary>
        /// تحصيل بنكي
        /// </summary>
        REBR,
        /// <summary>
        /// انهاء عقد التأجير
        /// </summary>
        RECE,
        /// <summary>
        /// اشعارات دائنة
        /// </summary>
        RECN,
        /// <summary>
        /// دفعة نقدية
        /// </summary>
        RECP,
        /// <summary>
        /// تجديد عقد التأجير
        /// </summary>
        RECR,
        /// <summary>
        /// تحصيل نقدي
        /// </summary>
        RECV,
        /// <summary>
        /// اشعارات مدينة
        /// </summary>
        REDN,
        /// <summary>
        /// تنازل عن وحدة عقارية
        /// </summary>
        REEW,
        /// <summary>
        /// فاتورة مبيعات عقار
        /// </summary>
        REIV,
        /// <summary>
        /// انهاء صيانة عقار
        /// </summary>
        REME,
        /// <summary>
        /// صيانة عقار
        /// </summary>
        REMS,
        /// <summary>
        /// تجديد التعاقد لمجموعة من العقود
        /// </summary>
        RERA,
        /// <summary>
        /// عقد تأجير
        /// </summary>
        RERC,
        /// <summary>
        /// مرتجع مبيعات عقار
        /// </summary>
        RERT,
        /// <summary>
        /// ارتجاع عقار أو وحدة
        /// </summary>
        RESR,
        /// <summary>
        /// فاتورة مبيعات
        /// </summary>
        SAIV,
        /// <summary>
        /// أمر بيع
        /// </summary>
        SAOR,
        /// <summary>
        /// عروض الأسعار
        /// </summary>
        SAQT,
        /// <summary>
        /// مرتجع مبيعات
        /// </summary>
        SART,
        /// <summary>
        /// 
        /// </summary>
        SLIC,
        /// <summary>
        /// رصيد افتتاحي لمورد
        /// </summary>
        VNBB,
        /// <summary>
        /// اغلاق السنة المالية
        /// </summary>
        YERL,
        /// <summary>
        /// كشف الجرد
        /// </summary>
        FXIR,
        /// <summary>
        /// معاملة الجرد
        /// </summary>
        FXIP,
        /// <summary>
        /// نقل مديونيه
        /// </summary>
        DETR
    }
    #endregion
    #region حالات المعاملات
    /// <summary>
    /// حالات المعاملات
    /// </summary>
    public enum SubmitStatus
    {
        Active = 1,
        Approved = 2,
        Holding = 4,
        Rejected = 5,
        UnPost = 6,
        RaisUp = 7
    }
    #endregion
    #region انواع الحركة
    /// <summary>
    /// انواع الحركة
    /// </summary>
    public enum SubmitTypes
    {
        Save = 1,
        Post = 2,
        UnPost = 3
    }
    #endregion
    #region  الاعدادات

    /// <summary>
    /// انواع الكنترول
    /// </summary>
    public enum ControlsTypes
    {
        CheckBox = 1,
        TextBox = 2,
        NumericTextBox = 3,
        DropDownList = 4,
        CustomDropDownList = 5,
        MultiSelect = 6
    }

    /// <summary>
    /// مستوى الاعدادات
    /// </summary>
    public enum SettingLevel
    {
        Company = 0,
        Branch = 1,
        User = 2,
        UserBranch = 3
    }
    #endregion
    #region انواع الصلاحيات
    /// <summary>
    /// انواع الصلاحيات
    /// </summary>
    public enum ActionPermissions
    {
        View,
        Create,
        Update,
        Delete,
        Approve,
        UnApprove,
        Print
    }
    #endregion
    #region انواع السداد
    /// <summary>
    /// انواع السداد
    /// </summary>
    public enum PaymentTypes
    {
        AtmCard = 1,
        Cash = 2,
        Visa = 3,
        Check = 4,
        MasterCard = 5,
        Credit = 7,
        Tranfer = 8,
        ReEvaluate = 9
    }
    #endregion
    #region نتيجة العملية المنفذة
    /// <summary>
    /// نتيجة العملية المنفذة
    /// </summary>
    public enum TransactionResult
    {
        None,
        SaveSuccess, // when insert or update success
        SaveFailed, // when inset or update error occured
        DeleteSuccess, // when delete success
        DeleteFailed, // when delete faild
        ErrorOccured, // when an error occured for any reason
        IsExists, // save record has the same unique key 
        ApproveSuccess, // when approve success
        UnApproveSuccess, // when unapprove success
        ApproveFailed, // when approve error occured
        UnApproveFailed, // when unapprove error occured
        Authenticated, // when user login success
        NotAuthenticated, // when user login failed
        ReferenceToAnotherTable, // when user login failed
        Balanced,
        UnBalanced,
        IsDuplicateDetailsData // when user create duplicate data in details

    }
    #endregion
    #region انواع الحسابات
    /// <summary>
    /// انواع الحسابات
    /// </summary>
    public enum CbAccountTypes
    {
        Cash = 1,
        Bank = 2,
        ReEvaluate = 3
    }
    #endregion
    #region انواع حساب الضرائب
    /// <summary>
    /// انواع حساب الضرائب
    /// </summary>
    public enum TaxCalculationTypes
    {
        TotalAmount = 1,
        NetAmount = 2,
        TotalAmountwithTaxes = 3,
        NetAmountwithTaxes = 4
    }

    #endregion
}