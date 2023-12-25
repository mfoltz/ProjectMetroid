// Decompiled with JetBrains decompiler
// Type: DurabilityGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DurabilityGridSelectionEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_DurabilityGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_DurabilityGridSelectionEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205919, XrefRangeEnd = 1205920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    DurabilityGridSelectionEntry entry,
    DurabilityGridSelectionEntry.Data data,
    ControllerType controllerType,
    GridSelectionGroup<DurabilityGridSelectionEntry, DurabilityGridSelectionEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DurabilityGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_DurabilityGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_DurabilityGridSelectionEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DurabilityGridSelectionEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DurabilityGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DurabilityGridSelectionEntry()
  {
    Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (DurabilityGridSelectionEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr);
    DurabilityGridSelectionEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr, nameof (Icon));
    DurabilityGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_DurabilityGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_DurabilityGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr, 100663358);
    DurabilityGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr, 100663359);
  }

  public DurabilityGridSelectionEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilitySprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityColor;

    static Data()
    {
      Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DurabilityGridSelectionEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr);
      DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilitySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr, nameof (DurabilitySprite));
      DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr, nameof (DurabilityPercentage));
      DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr, nameof (DurabilityColor));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurabilityGridSelectionEntry.Data>.NativeClassPtr, data));
    }

    public unsafe Sprite DurabilitySprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilitySprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilitySprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DurabilityPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityPercentage)) = value;
      }
    }

    public unsafe Color DurabilityColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityGridSelectionEntry.Data.NativeFieldInfoPtr_DurabilityColor)) = value;
      }
    }
  }
}
