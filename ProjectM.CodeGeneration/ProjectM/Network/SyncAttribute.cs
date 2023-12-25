// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncAttribute
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using ProjectM.CodeGeneration;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class SyncAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubFieldPostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomSnapshotFieldName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FieldType;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEntityField_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNetworkedEntityField_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_New_Type_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBeforeBufferSerializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBeforeBufferDeserializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_New_String_FieldInfo_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_New_Void_FieldInfo_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSettingsForComparison_Public_Void_FieldInfo_BinaryWriter_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635517, XrefRangeEnd = 635540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEntityField()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncAttribute.NativeMethodInfoPtr_IsEntityField_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635540, XrefRangeEnd = 635550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsNetworkedEntityField()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncAttribute.NativeMethodInfoPtr_IsNetworkedEntityField_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 635554, RefRangeEnd = 635599, XrefRangeStart = 635550, XrefRangeEnd = 635554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncAttribute(
      Il2CppSystem.Type fieldType,
      string subFieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subFieldPostfix);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635599, XrefRangeEnd = 635600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Type GetSnapshotFieldType(FieldInfo targetField)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_New_Type_FieldInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GenerateBeforeBufferSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateBeforeBufferSerializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GenerateBeforeBufferDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateBeforeBufferDeserializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateSerializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635600, XrefRangeEnd = 635607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GenerateCopyToSnapshotCode(
      CodeSegment segment,
      string snapshotFieldName,
      string fullRealFieldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(snapshotFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fullRealFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 635614, RefRangeEnd = 635615, XrefRangeStart = 635607, XrefRangeEnd = 635614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GenerateCopyFromSnapshotCode(
      CodeSegment segment,
      string snapshotFieldName,
      string fullRealFieldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(snapshotFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fullRealFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635615, XrefRangeEnd = 635620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GenerateServerEqualsCheck(
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
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_New_String_FieldInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SerializeAdditionalSettingsForComparison(
      FieldInfo targetField,
      BinaryWriter writer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncAttribute.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_New_Void_FieldInfo_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635620, XrefRangeEnd = 635626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSettingsForComparison(FieldInfo targetField, BinaryWriter writer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncAttribute.NativeMethodInfoPtr_SerializeSettingsForComparison_Public_Void_FieldInfo_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncAttribute()
    {
      Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Network", nameof (SyncAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr);
      SyncAttribute.NativeFieldInfoPtr_SubFieldPostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, nameof (SubFieldPostfix));
      SyncAttribute.NativeFieldInfoPtr_CustomSnapshotFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, nameof (CustomSnapshotFieldName));
      SyncAttribute.NativeFieldInfoPtr_FieldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, nameof (FieldType));
      SyncAttribute.NativeMethodInfoPtr_IsEntityField_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663485);
      SyncAttribute.NativeMethodInfoPtr_IsNetworkedEntityField_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663486);
      SyncAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663487);
      SyncAttribute.NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_New_Type_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663488);
      SyncAttribute.NativeMethodInfoPtr_GenerateBeforeBufferSerializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663489);
      SyncAttribute.NativeMethodInfoPtr_GenerateBeforeBufferDeserializeCode_Public_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663490);
      SyncAttribute.NativeMethodInfoPtr_GenerateSerializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663491);
      SyncAttribute.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Abstract_Virtual_New_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663492);
      SyncAttribute.NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663493);
      SyncAttribute.NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_New_Void_CodeSegment_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663494);
      SyncAttribute.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_New_String_FieldInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663495);
      SyncAttribute.NativeMethodInfoPtr_SerializeAdditionalSettingsForComparison_Protected_Virtual_New_Void_FieldInfo_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663496);
      SyncAttribute.NativeMethodInfoPtr_SerializeSettingsForComparison_Public_Void_FieldInfo_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncAttribute>.NativeClassPtr, 100663497);
    }

    public SyncAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string SubFieldPostfix
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_SubFieldPostfix)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_SubFieldPostfix), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string CustomSnapshotFieldName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_CustomSnapshotFieldName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_CustomSnapshotFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.Type FieldType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_FieldType));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncAttribute.NativeFieldInfoPtr_FieldType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
