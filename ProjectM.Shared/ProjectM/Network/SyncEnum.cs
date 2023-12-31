// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncEnum
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using ProjectM.CodeGeneration;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class SyncEnum : SyncAttribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncEnumType;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeserializeFunctions;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnumData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SyncEnumType_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_Void_FieldInfo_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSerializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDeserializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Static_String_Type_String_String_SyncEnumType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Public_Static_Void_Type_BinaryWriter_SyncEnumType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalyzedEnumData_Private_Static_EnumAnalyzeResult_SyncEnumType_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRangedIntegerValue_Private_Static_Boolean_SerializedEnumId_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValueAsLong_Private_Static_Boolean_Array_Int32_Type_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValueAsULong_Private_Static_Boolean_Array_Int32_Type_byref_UInt64_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786196, XrefRangeEnd = 786203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncEnum(
      SyncEnumType syncEnumType,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &syncEnumType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr__ctor_Public_Void_SyncEnumType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786203, XrefRangeEnd = 786207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEnum.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786207, XrefRangeEnd = 786211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEnum.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786211, XrefRangeEnd = 786216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GenerateServerEqualsCheck(
      FieldInfo targetField,
      string variable1,
      string variable2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable2);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEnum.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786216, XrefRangeEnd = 786225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SerializeAdditionalSettingsForComparison(
      FieldInfo targetField,
      BinaryWriter writer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEnum.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_Void_FieldInfo_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 786282, RefRangeEnd = 786283, XrefRangeStart = 786225, XrefRangeEnd = 786282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GenerateSerializeEnumCode(
      CodeSegment segment,
      string enumFieldName,
      Il2CppSystem.Type enumType,
      SyncEnumType syncEnumType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(enumFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncEnumType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_GenerateSerializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 786335, RefRangeEnd = 786336, XrefRangeStart = 786283, XrefRangeEnd = 786335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GenerateDeserializeEnumCode(
      CodeSegment segment,
      string enumFieldName,
      Il2CppSystem.Type enumType,
      SyncEnumType syncEnumType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(enumFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncEnumType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_GenerateDeserializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 786412, RefRangeEnd = 786413, XrefRangeStart = 786336, XrefRangeEnd = 786412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GenerateServerEqualsCheck(
      Il2CppSystem.Type enumType,
      string variable1,
      string variable2,
      SyncEnumType syncEnumType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncEnumType;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Static_String_Type_String_String_SyncEnumType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786413, XrefRangeEnd = 786418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeAdditionalSettingsForComparison(
      Il2CppSystem.Type enumType,
      BinaryWriter writer,
      SyncEnumType syncEnumType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &syncEnumType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Public_Static_Void_Type_BinaryWriter_SyncEnumType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 786457, RefRangeEnd = 786462, XrefRangeStart = 786418, XrefRangeEnd = 786457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncEnum.EnumAnalyzeResult GetAnalyzedEnumData(
      SyncEnumType syncEnumType,
      Il2CppSystem.Type enumType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &syncEnumType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_GetAnalyzedEnumData_Private_Static_EnumAnalyzeResult_SyncEnumType_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SyncEnum.EnumAnalyzeResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 786490, RefRangeEnd = 786491, XrefRangeStart = 786462, XrefRangeEnd = 786490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetRangedIntegerValue(
      SyncEnum.SerializedEnumId enumId,
      out int minValue,
      out int maxValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) enumId));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_TryGetRangedIntegerValue_Private_Static_Boolean_SerializedEnumId_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 786548, RefRangeEnd = 786549, XrefRangeStart = 786491, XrefRangeEnd = 786548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetValueAsLong(
      Il2CppSystem.Array values,
      int i,
      Il2CppSystem.Type integralType,
      out long result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &i;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) integralType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_TryGetValueAsLong_Private_Static_Boolean_Array_Int32_Type_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786549, XrefRangeEnd = 786602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetValueAsULong(
      Il2CppSystem.Array values,
      int i,
      Il2CppSystem.Type integralType,
      out ulong result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &i;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) integralType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.NativeMethodInfoPtr_TryGetValueAsULong_Private_Static_Boolean_Array_Int32_Type_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncEnum()
    {
      Il2CppClassPointerStore<SyncEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncEnum));
      SyncEnum.NativeFieldInfoPtr_SyncEnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, nameof (SyncEnumType));
      SyncEnum.NativeFieldInfoPtr__DeserializeFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, nameof (_DeserializeFunctions));
      SyncEnum.NativeFieldInfoPtr__EnumData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, nameof (_EnumData));
      SyncEnum.NativeMethodInfoPtr__ctor_Public_Void_SyncEnumType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669291);
      SyncEnum.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669292);
      SyncEnum.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669293);
      SyncEnum.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669294);
      SyncEnum.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_Void_FieldInfo_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669295);
      SyncEnum.NativeMethodInfoPtr_GenerateSerializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669296);
      SyncEnum.NativeMethodInfoPtr_GenerateDeserializeEnumCode_Public_Static_Void_CodeSegment_String_Type_SyncEnumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669297);
      SyncEnum.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Static_String_Type_String_String_SyncEnumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669298);
      SyncEnum.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Public_Static_Void_Type_BinaryWriter_SyncEnumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669299);
      SyncEnum.NativeMethodInfoPtr_GetAnalyzedEnumData_Private_Static_EnumAnalyzeResult_SyncEnumType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669301);
      SyncEnum.NativeMethodInfoPtr_TryGetRangedIntegerValue_Private_Static_Boolean_SerializedEnumId_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669302);
      SyncEnum.NativeMethodInfoPtr_TryGetValueAsLong_Private_Static_Boolean_Array_Int32_Type_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669303);
      SyncEnum.NativeMethodInfoPtr_TryGetValueAsULong_Private_Static_Boolean_Array_Int32_Type_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, 100669304);
    }

    public SyncEnum(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SyncEnumType SyncEnumType
    {
      get
      {
        return *(SyncEnumType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.NativeFieldInfoPtr_SyncEnumType));
      }
      [param: In] set
      {
        *(SyncEnumType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.NativeFieldInfoPtr_SyncEnumType)) = value;
      }
    }

    public static unsafe Dictionary<Il2CppSystem.Type, string> _DeserializeFunctions
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SyncEnum.NativeFieldInfoPtr__DeserializeFunctions, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, string>) null : new Dictionary<Il2CppSystem.Type, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SyncEnum.NativeFieldInfoPtr__DeserializeFunctions, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<SyncEnum.SerializedEnumId, SyncEnum.EnumAnalyzeResult> _EnumData
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SyncEnum.NativeFieldInfoPtr__EnumData, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<SyncEnum.SerializedEnumId, SyncEnum.EnumAnalyzeResult>) null : new Dictionary<SyncEnum.SerializedEnumId, SyncEnum.EnumAnalyzeResult>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SyncEnum.NativeFieldInfoPtr__EnumData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class EnumAnalyzeResult : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IntegralTypeName;
      private static readonly System.IntPtr NativeFieldInfoPtr_SerializeFunctionName;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeserializeFunctionName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Ranged;
      private static readonly System.IntPtr NativeFieldInfoPtr_Min;
      private static readonly System.IntPtr NativeFieldInfoPtr_Max;

      static EnumAnalyzeResult()
      {
        Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, nameof (EnumAnalyzeResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr);
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_IntegralTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (IntegralTypeName));
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_SerializeFunctionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (SerializeFunctionName));
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_DeserializeFunctionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (DeserializeFunctionName));
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Ranged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (Ranged));
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (Min));
        SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, nameof (Max));
      }

      public EnumAnalyzeResult(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public EnumAnalyzeResult()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncEnum.EnumAnalyzeResult>.NativeClassPtr, data));
      }

      public unsafe string IntegralTypeName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_IntegralTypeName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_IntegralTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string SerializeFunctionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_SerializeFunctionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_SerializeFunctionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string DeserializeFunctionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_DeserializeFunctionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_DeserializeFunctionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool Ranged
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Ranged));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Ranged)) = value;
        }
      }

      public unsafe int Min
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Min));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Min)) = value;
        }
      }

      public unsafe int Max
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Max));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.EnumAnalyzeResult.NativeFieldInfoPtr_Max)) = value;
        }
      }
    }

    public sealed class SerializedEnumId : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EnumType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SyncEnumType;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SerializedEnumId_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786188, XrefRangeEnd = 786189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.SerializedEnumId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786189, XrefRangeEnd = 786192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.SerializedEnumId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786192, XrefRangeEnd = 786196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(SyncEnum.SerializedEnumId other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncEnum.SerializedEnumId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SerializedEnumId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SerializedEnumId()
      {
        Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncEnum>.NativeClassPtr, nameof (SerializedEnumId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr);
        SyncEnum.SerializedEnumId.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, nameof (EnumType));
        SyncEnum.SerializedEnumId.NativeFieldInfoPtr_SyncEnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, nameof (SyncEnumType));
        SyncEnum.SerializedEnumId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, 100669305);
        SyncEnum.SerializedEnumId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, 100669306);
        SyncEnum.SerializedEnumId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SerializedEnumId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, 100669307);
      }

      public SerializedEnumId(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SerializedEnumId()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncEnum.SerializedEnumId>.NativeClassPtr, data));
      }

      public unsafe Il2CppSystem.Type EnumType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.SerializedEnumId.NativeFieldInfoPtr_EnumType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.SerializedEnumId.NativeFieldInfoPtr_EnumType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SyncEnumType SyncEnumType
      {
        get
        {
          return *(SyncEnumType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.SerializedEnumId.NativeFieldInfoPtr_SyncEnumType));
        }
        [param: In] set
        {
          *(SyncEnumType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncEnum.SerializedEnumId.NativeFieldInfoPtr_SyncEnumType)) = value;
        }
      }
    }
  }
}
