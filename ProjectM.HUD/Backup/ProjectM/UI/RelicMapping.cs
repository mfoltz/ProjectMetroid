// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RelicMapping
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class RelicMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerSetting;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerSetting_Unique;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerSetting_Plentiful;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerSetting_UniqueDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerSetting_PlentifulDesc;

    static RelicMapping()
    {
      Il2CppClassPointerStore<RelicMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (RelicMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr);
      RelicMapping.NativeFieldInfoPtr_ServerSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (ServerSetting));
      RelicMapping.NativeFieldInfoPtr_SettingDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (SettingDesc));
      RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (LKey_ServerSetting_Unique));
      RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Plentiful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (LKey_ServerSetting_Plentiful));
      RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_UniqueDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (LKey_ServerSetting_UniqueDesc));
      RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_PlentifulDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, nameof (LKey_ServerSetting_PlentifulDesc));
    }

    public RelicMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public RelicMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, data));
    }

    public unsafe LocalizedText ServerSetting
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_ServerSetting));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_ServerSetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SettingDesc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_SettingDesc));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_SettingDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_ServerSetting_Unique
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Unique));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Unique)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerSetting_Plentiful
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Plentiful));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_Plentiful)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerSetting_UniqueDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_UniqueDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_UniqueDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerSetting_PlentifulDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_PlentifulDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicMapping.NativeFieldInfoPtr_LKey_ServerSetting_PlentifulDesc)) = value;
      }
    }
  }
}
