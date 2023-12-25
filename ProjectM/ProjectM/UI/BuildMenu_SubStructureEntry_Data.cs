// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_SubStructureEntry_Data
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class BuildMenu_SubStructureEntry_Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlighted;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Variations;

    static BuildMenu_SubStructureEntry_Data()
    {
      Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (BuildMenu_SubStructureEntry_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr);
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Icon));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (PrefabGuid));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Stacks));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Disabled));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Highlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Highlighted));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Name));
      BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, nameof (Variations));
    }

    public BuildMenu_SubStructureEntry_Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BuildMenu_SubStructureEntry_Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenu_SubStructureEntry_Data>.NativeClassPtr, data));
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID PrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_PrefabGuid)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public unsafe bool Disabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Disabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Disabled)) = value;
      }
    }

    public unsafe bool Highlighted
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Highlighted));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Highlighted)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe IColorCollection Variations
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Variations));
        return pointer == System.IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_SubStructureEntry_Data.NativeFieldInfoPtr_Variations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
