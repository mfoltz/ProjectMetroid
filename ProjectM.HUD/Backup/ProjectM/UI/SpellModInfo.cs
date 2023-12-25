// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellModInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class SpellModInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelData;

    static SpellModInfo()
    {
      Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellModInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr);
      SpellModInfo.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, nameof (SpellMods));
      SpellModInfo.NativeFieldInfoPtr_JewelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, nameof (JewelData));
    }

    public SpellModInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SpellModInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, data));
    }

    public unsafe List<TooltipSpellModEntry.Data> SpellMods
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModInfo.NativeFieldInfoPtr_SpellMods));
        return pointer == System.IntPtr.Zero ? (List<TooltipSpellModEntry.Data>) null : new List<TooltipSpellModEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModInfo.NativeFieldInfoPtr_SpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<TooltipJewelAbility.Data> JewelData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModInfo.NativeFieldInfoPtr_JewelData);
        return new Il2CppSystem.Nullable<TooltipJewelAbility.Data>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<TooltipJewelAbility.Data>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModInfo.NativeFieldInfoPtr_JewelData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<TooltipJewelAbility.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
