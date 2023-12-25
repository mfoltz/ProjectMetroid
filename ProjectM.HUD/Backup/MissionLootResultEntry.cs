// Decompiled with JetBrains decompiler
// Type: MissionLootResultEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MissionLootResultEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionLootResultEntry_Data_ControllerType_GridSelectionGroup_2_MissionLootResultEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205413, RefRangeEnd = 1205414, XrefRangeStart = 1205392, XrefRangeEnd = 1205413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    MissionLootResultEntry entry,
    MissionLootResultEntry.Data data,
    ControllerType controllerType,
    GridSelectionGroup<MissionLootResultEntry, MissionLootResultEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionLootResultEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionLootResultEntry_Data_ControllerType_GridSelectionGroup_2_MissionLootResultEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MissionLootResultEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionLootResultEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MissionLootResultEntry()
  {
    Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MissionLootResultEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr);
    MissionLootResultEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, nameof (Name));
    MissionLootResultEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, nameof (Icon));
    MissionLootResultEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, nameof (Amount));
    MissionLootResultEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionLootResultEntry_Data_ControllerType_GridSelectionGroup_2_MissionLootResultEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, 100663315);
    MissionLootResultEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, 100663316);
  }

  public MissionLootResultEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText Name
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Name));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Amount
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Amount));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.NativeFieldInfoPtr_Amount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssingedServants;

    static Data()
    {
      Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionLootResultEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr);
      MissionLootResultEntry.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, nameof (Icon));
      MissionLootResultEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, nameof (Name));
      MissionLootResultEntry.Data.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, nameof (Min));
      MissionLootResultEntry.Data.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, nameof (Max));
      MissionLootResultEntry.Data.NativeFieldInfoPtr_AssingedServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, nameof (AssingedServants));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MissionLootResultEntry.Data>.NativeClassPtr, data));
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe int Min
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Min));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Min)) = value;
      }
    }

    public unsafe int Max
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Max));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_Max)) = value;
      }
    }

    public unsafe int AssingedServants
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_AssingedServants));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionLootResultEntry.Data.NativeFieldInfoPtr_AssingedServants)) = value;
      }
    }
  }
}
