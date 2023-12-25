// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  public sealed class RegisterEventOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventName_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParamDefs_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EventName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0;

    public unsafe uint EventId
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EventName
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventName_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonEventType EventType
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonEventType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<RegisterEventParamDef> ParamDefs
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RegisterEventParamDef>) null : new Il2CppReferenceArray<RegisterEventParamDef>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static RegisterEventOptions()
    {
      Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr);
      RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventId>k__BackingField");
      RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventName>k__BackingField");
      RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventType>k__BackingField");
      RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<ParamDefs>k__BackingField");
      RegisterEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674257);
      RegisterEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674258);
      RegisterEventOptions.NativeMethodInfoPtr_get_EventName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674259);
      RegisterEventOptions.NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674260);
      RegisterEventOptions.NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674261);
      RegisterEventOptions.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674262);
      RegisterEventOptions.NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674263);
      RegisterEventOptions.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100674264);
    }

    public RegisterEventOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public RegisterEventOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, data));
    }

    public unsafe uint _EventId_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _EventName_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AntiCheatCommonEventType _EventType_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<RegisterEventParamDef> _ParamDefs_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RegisterEventParamDef>) null : new Il2CppReferenceArray<RegisterEventParamDef>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
