// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptionsAccountId
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics
{
  public sealed class BeginPlayerSessionOptionsAccountId : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_BeginPlayerSessionOptionsAccountIdInternal_0;

    public unsafe MetricsAccountIdType AccountIdType
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MetricsAccountIdType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId Epic
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953344, RefRangeEnd = 953345, XrefRangeStart = 953338, XrefRangeEnd = 953344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 953351, RefRangeEnd = 953354, XrefRangeStart = 953345, XrefRangeEnd = 953351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String External
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953360, RefRangeEnd = 953361, XrefRangeStart = 953354, XrefRangeEnd = 953360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 953367, RefRangeEnd = 953371, XrefRangeStart = 953361, XrefRangeEnd = 953367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953371, XrefRangeEnd = 953372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BeginPlayerSessionOptionsAccountId(EpicAccountId value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BeginPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953372, XrefRangeEnd = 953373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BeginPlayerSessionOptionsAccountId(Epic.OnlineServices.Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BeginPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953373, XrefRangeEnd = 953375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BeginPlayerSessionOptionsAccountId(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BeginPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953375, XrefRangeEnd = 953379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(
      ref BeginPlayerSessionOptionsAccountIdInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_byref_BeginPlayerSessionOptionsAccountIdInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BeginPlayerSessionOptionsAccountId()
    {
      Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptionsAccountId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr);
      BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_AccountIdType));
      BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_Epic));
      BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_External));
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669508);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669509);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669510);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669511);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669512);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669513);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669514);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669515);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669516);
      BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_byref_BeginPlayerSessionOptionsAccountIdInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100669517);
    }

    public BeginPlayerSessionOptionsAccountId(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BeginPlayerSessionOptionsAccountId()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, data));
    }

    public unsafe MetricsAccountIdType m_AccountIdType
    {
      get
      {
        return *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType));
      }
      [param: In] set
      {
        *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType)) = value;
      }
    }

    public unsafe EpicAccountId m_Epic
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic));
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String m_External
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
