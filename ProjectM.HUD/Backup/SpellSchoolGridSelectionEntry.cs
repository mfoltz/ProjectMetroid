// Decompiled with JetBrains decompiler
// Type: SpellSchoolGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SpellSchoolGridSelectionEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Frame;
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameColor_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameColor_Hover;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameColor_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconColor_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconColor_Hovered;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconColor_Selected;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_SpellSchoolGridSelectionEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205832, RefRangeEnd = 1205833, XrefRangeStart = 1205829, XrefRangeEnd = 1205832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    SpellSchoolGridSelectionEntry entry,
    SpellSchoolGridSelectionEntry.Data data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpellSchoolGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_SpellSchoolGridSelectionEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpellSchoolGridSelectionEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpellSchoolGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpellSchoolGridSelectionEntry()
  {
    Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (SpellSchoolGridSelectionEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr);
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (Frame));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (Icon));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (FrameColor_Normal));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (FrameColor_Hover));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (FrameColor_Selected));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (IconColor_Normal));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (IconColor_Hovered));
    SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (IconColor_Selected));
    SpellSchoolGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_SpellSchoolGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, 100663352);
    SpellSchoolGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, 100663353);
  }

  public SpellSchoolGridSelectionEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image Frame
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Frame));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Frame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color FrameColor_Normal
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Normal));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Normal)) = value;
    }
  }

  public unsafe Color FrameColor_Hover
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Hover));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Hover)) = value;
    }
  }

  public unsafe Color FrameColor_Selected
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Selected));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_FrameColor_Selected)) = value;
    }
  }

  public unsafe Color IconColor_Normal
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Normal));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Normal)) = value;
    }
  }

  public unsafe Color IconColor_Hovered
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Hovered));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Hovered)) = value;
    }
  }

  public unsafe Color IconColor_Selected
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Selected));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.NativeFieldInfoPtr_IconColor_Selected)) = value;
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SchoolSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_Selected;

    static Data()
    {
      Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr);
      SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr, nameof (EntryId));
      SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_SchoolSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr, nameof (SchoolSprite));
      SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr, nameof (Selected));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolGridSelectionEntry.Data>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe Sprite SchoolSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_SchoolSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_SchoolSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Selected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_Selected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolGridSelectionEntry.Data.NativeFieldInfoPtr_Selected)) = value;
      }
    }
  }
}
