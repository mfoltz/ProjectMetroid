// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeSubMenu_AbilityEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class ForgeSubMenu_AbilityEntry : GenericSelectionEntry<ForgeSubMenu_AbilityEntry.Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipJewelAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235360, XrefRangeEnd = 1235368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Refresh([In] ref ForgeSubMenu_AbilityEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ForgeSubMenu_AbilityEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235368, XrefRangeEnd = 1235371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForgeSubMenu_AbilityEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_AbilityEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeSubMenu_AbilityEntry()
    {
      Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeSubMenu_AbilityEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr);
      ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_TooltipJewelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr, nameof (TooltipJewelAbility));
      ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_SpellModGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr, nameof (SpellModGroup));
      ForgeSubMenu_AbilityEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr, 100665729);
      ForgeSubMenu_AbilityEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr, 100665730);
    }

    public ForgeSubMenu_AbilityEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TooltipJewelAbility TooltipJewelAbility
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_TooltipJewelAbility));
        return pointer == System.IntPtr.Zero ? (TooltipJewelAbility) null : new TooltipJewelAbility(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_TooltipJewelAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_SpellModSelectionGroup SpellModGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_SpellModGroup));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_SpellModSelectionGroup) null : new ForgeSubMenu_SpellModSelectionGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.NativeFieldInfoPtr_SpellModGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModInfo;

      static Data()
      {
        Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry.Data>.NativeClassPtr);
        ForgeSubMenu_AbilityEntry.Data.NativeFieldInfoPtr_SpellModInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry.Data>.NativeClassPtr, nameof (SpellModInfo));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeSubMenu_AbilityEntry.Data>.NativeClassPtr, data));
      }

      public SpellModInfo SpellModInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.Data.NativeFieldInfoPtr_SpellModInfo);
          return new SpellModInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_AbilityEntry.Data.NativeFieldInfoPtr_SpellModInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellModInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
