// Decompiled with JetBrains decompiler
// Type: ProjectM.BindableSetting
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class BindableSetting : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BindViaSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsObjectFieldId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BindableSetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BindableSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BindableSetting()
    {
      Il2CppClassPointerStore<BindableSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BindableSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr);
      BindableSetting.NativeFieldInfoPtr_BindViaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr, nameof (BindViaSettings));
      BindableSetting.NativeFieldInfoPtr_SettingsObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr, nameof (SettingsObject));
      BindableSetting.NativeFieldInfoPtr_SettingsObjectFieldId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr, nameof (SettingsObjectFieldId));
      BindableSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting>.NativeClassPtr, 100667472);
    }

    public BindableSetting(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool BindViaSettings
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_BindViaSettings));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_BindViaSettings)) = value;
      }
    }

    public unsafe ScriptableObject SettingsObject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_SettingsObject));
        return pointer == System.IntPtr.Zero ? (ScriptableObject) null : new ScriptableObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_SettingsObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string SettingsObjectFieldId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_SettingsObjectFieldId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting.NativeFieldInfoPtr_SettingsObjectFieldId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
