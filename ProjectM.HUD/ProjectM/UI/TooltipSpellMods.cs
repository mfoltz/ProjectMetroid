// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipSpellMods
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipSpellMods : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1252817, RefRangeEnd = 1252819, XrefRangeStart = 1252795, XrefRangeEnd = 1252817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipSpellMods.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipSpellMods.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipSpellMods()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipSpellMods.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipSpellMods()
    {
      Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipSpellMods));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr);
      TooltipSpellMods.NativeFieldInfoPtr_JewelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr, nameof (JewelAbility));
      TooltipSpellMods.NativeFieldInfoPtr_SpellModEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr, nameof (SpellModEntries));
      TooltipSpellMods.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr, 100666701);
      TooltipSpellMods.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr, 100666702);
    }

    public TooltipSpellMods(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TooltipJewelAbility JewelAbility
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.NativeFieldInfoPtr_JewelAbility));
        return pointer == System.IntPtr.Zero ? (TooltipJewelAbility) null : new TooltipJewelAbility(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.NativeFieldInfoPtr_JewelAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipSpellModEntry> SpellModEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.NativeFieldInfoPtr_SpellModEntries));
        return pointer == System.IntPtr.Zero ? (List<TooltipSpellModEntry>) null : new List<TooltipSpellModEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.NativeFieldInfoPtr_SpellModEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModInfo;

      static Data()
      {
        Il2CppClassPointerStore<TooltipSpellMods.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipSpellMods>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipSpellMods.Data>.NativeClassPtr);
        TooltipSpellMods.Data.NativeFieldInfoPtr_SpellModInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipSpellMods.Data>.NativeClassPtr, nameof (SpellModInfo));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipSpellMods.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipSpellMods.Data>.NativeClassPtr, data));
      }

      public Il2CppSystem.Nullable<SpellModInfo> SpellModInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.Data.NativeFieldInfoPtr_SpellModInfo);
          return new Il2CppSystem.Nullable<SpellModInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<SpellModInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipSpellMods.Data.NativeFieldInfoPtr_SpellModInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<SpellModInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
