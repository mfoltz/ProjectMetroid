// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyUnitStatBuff_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ModifyUnitStatBuff_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseByStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_ByStackValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;

    static ModifyUnitStatBuff_Editor()
    {
      Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyUnitStatBuff_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr);
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (StatType));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (ModificationType));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StaticValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (StaticValue));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_IncreaseByStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (IncreaseByStacks));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ByStackValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (ByStackValue));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (Priority));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (EquipmentType));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (StatsSettings));
      ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (SpellMods));
    }

    public ModifyUnitStatBuff_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ModifyUnitStatBuff_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, data));
    }

    public unsafe UnitStatType StatType
    {
      get
      {
        return *(UnitStatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatType));
      }
      [param: In] set
      {
        *(UnitStatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatType)) = value;
      }
    }

    public unsafe ModificationType_Editor ModificationType
    {
      get
      {
        return *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ModificationType));
      }
      [param: In] set
      {
        *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ModificationType)) = value;
      }
    }

    public unsafe float StaticValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StaticValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StaticValue)) = value;
      }
    }

    public unsafe bool IncreaseByStacks
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_IncreaseByStacks));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_IncreaseByStacks)) = value;
      }
    }

    public unsafe float ByStackValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ByStackValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_ByStackValue)) = value;
      }
    }

    public unsafe int Priority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_Priority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_Priority)) = value;
      }
    }

    public unsafe EquipmentType EquipmentType
    {
      get
      {
        return *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_EquipmentType));
      }
      [param: In] set
      {
        *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_EquipmentType)) = value;
      }
    }

    public unsafe Item_StatsSettings_Asset StatsSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatsSettings));
        return pointer == System.IntPtr.Zero ? (Item_StatsSettings_Asset) null : new Item_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_StatsSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ModifyUnitStatBuff_Editor.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_SpellMods);
        return new ModifyUnitStatBuff_Editor.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_ByStackValue;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr);
        ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_StaticValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (StaticValue));
        ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_ByStackValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (ByStackValue));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuff_Editor.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> StaticValue
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_StaticValue));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_StaticValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> ByStackValue
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_ByStackValue));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuff_Editor.SpellModsAuthoring.NativeFieldInfoPtr_ByStackValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
