// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveBuffOnGameplayEventEntry_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class RemoveBuffOnGameplayEventEntry_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveBuffOnGameplayEventEntry_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventEntry_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveBuffOnGameplayEventEntry_Editor()
    {
      Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RemoveBuffOnGameplayEventEntry_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr);
      RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr, nameof (Buff));
      RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr, nameof (SpellMod));
      RemoveBuffOnGameplayEventEntry_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventEntry_Editor>.NativeClassPtr, 100678329);
    }

    public RemoveBuffOnGameplayEventEntry_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent Buff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_Buff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModPrefabGuidSettings SpellMod
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_SpellMod));
        return pointer == System.IntPtr.Zero ? (SpellModPrefabGuidSettings) null : new SpellModPrefabGuidSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventEntry_Editor.NativeFieldInfoPtr_SpellMod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
