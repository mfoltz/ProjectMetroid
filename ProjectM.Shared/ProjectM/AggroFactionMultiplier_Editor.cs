// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroFactionMultiplier_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class AggroFactionMultiplier_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Multiplier;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AggroFactionMultiplier_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroFactionMultiplier_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroFactionMultiplier_Editor()
    {
      Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroFactionMultiplier_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr);
      AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr, nameof (Faction));
      AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr, nameof (Multiplier));
      AggroFactionMultiplier_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroFactionMultiplier_Editor>.NativeClassPtr, 100663895);
    }

    public AggroFactionMultiplier_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FactionAsset Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Faction));
        return pointer == System.IntPtr.Zero ? (FactionAsset) null : new FactionAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Multiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Multiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroFactionMultiplier_Editor.NativeFieldInfoPtr_Multiplier)) = value;
      }
    }
  }
}
