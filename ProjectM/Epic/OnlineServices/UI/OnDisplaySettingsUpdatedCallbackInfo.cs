// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.OnDisplaySettingsUpdatedCallbackInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  public sealed class OnDisplaySettingsUpdatedCallbackInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsExclusiveInput_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsExclusiveInput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0;

    public virtual unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsVisible
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsExclusiveInput
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_IsExclusiveInput_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Nullable_Unboxed<Result> GetResultCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Result>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 937612, RefRangeEnd = 937613, XrefRangeStart = 937599, XrefRangeEnd = 937612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(
      ref OnDisplaySettingsUpdatedCallbackInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnDisplaySettingsUpdatedCallbackInfo()
    {
      Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (OnDisplaySettingsUpdatedCallbackInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr);
      OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
      OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, "<IsVisible>k__BackingField");
      OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsExclusiveInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, "<IsExclusiveInput>k__BackingField");
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665193);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665194);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665195);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665196);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665197);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_set_IsExclusiveInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665198);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665199);
      OnDisplaySettingsUpdatedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, 100665200);
    }

    public OnDisplaySettingsUpdatedCallbackInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public OnDisplaySettingsUpdatedCallbackInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfo>.NativeClassPtr, data));
    }

    public unsafe Il2CppSystem.Object _ClientData_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsVisible_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsVisible_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
      }
    }

    public unsafe bool _IsExclusiveInput_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsExclusiveInput_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDisplaySettingsUpdatedCallbackInfo.NativeFieldInfoPtr__IsExclusiveInput_k__BackingField)) = value;
      }
    }
  }
}
