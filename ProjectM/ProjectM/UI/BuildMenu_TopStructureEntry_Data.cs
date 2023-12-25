// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_TopStructureEntry_Data
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class BuildMenu_TopStructureEntry_Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlueprintType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitedType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Variations;

    static BuildMenu_TopStructureEntry_Data()
    {
      Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (BuildMenu_TopStructureEntry_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr);
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Icon));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (PrefabGuid));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_TooltipPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (TooltipPrefabGuid));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_SubData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (SubData));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Name));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Stacks));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_UnlockedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (UnlockedChildren));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Index));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_MaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (MaxLimit));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (LimitCount));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_BlueprintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (BlueprintType));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (LimitedType));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Disabled));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Highlight));
      BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, nameof (Variations));
    }

    public BuildMenu_TopStructureEntry_Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BuildMenu_TopStructureEntry_Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenu_TopStructureEntry_Data>.NativeClassPtr, data));
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID PrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID TooltipPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_TooltipPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_TooltipPrefabGuid)) = value;
      }
    }

    public unsafe List<BuildMenu_SubStructureEntry_Data> SubData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_SubData));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_SubStructureEntry_Data>) null : new List<BuildMenu_SubStructureEntry_Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_SubData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public unsafe int UnlockedChildren
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_UnlockedChildren));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_UnlockedChildren)) = value;
      }
    }

    public unsafe int Index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Index)) = value;
      }
    }

    public unsafe int MaxLimit
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_MaxLimit));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_MaxLimit)) = value;
      }
    }

    public unsafe int LimitCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitCount)) = value;
      }
    }

    public unsafe BlueprintType BlueprintType
    {
      get
      {
        return *(BlueprintType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_BlueprintType));
      }
      [param: In] set
      {
        *(BlueprintType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_BlueprintType)) = value;
      }
    }

    public unsafe CastleLimitedType LimitedType
    {
      get
      {
        return *(CastleLimitedType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitedType));
      }
      [param: In] set
      {
        *(CastleLimitedType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_LimitedType)) = value;
      }
    }

    public unsafe bool Disabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Disabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Disabled)) = value;
      }
    }

    public unsafe bool Highlight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Highlight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Highlight)) = value;
      }
    }

    public unsafe IColorCollection Variations
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Variations));
        return pointer == System.IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry_Data.NativeFieldInfoPtr_Variations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
