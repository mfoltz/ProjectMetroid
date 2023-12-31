// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class SpellModSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModSettings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModSettings()
    {
      Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellModSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr);
      SpellModSettings.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr, nameof (SpellMod));
      SpellModSettings.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr, nameof (Conditional));
      SpellModSettings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModSettings>.NativeClassPtr, 100664525);
    }

    public SpellModSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpellModAsset SpellMod
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModSettings.NativeFieldInfoPtr_SpellMod));
        return pointer == System.IntPtr.Zero ? (SpellModAsset) null : new SpellModAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModSettings.NativeFieldInfoPtr_SpellMod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModSettings.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModSettings.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
