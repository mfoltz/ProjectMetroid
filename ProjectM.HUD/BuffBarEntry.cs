// Decompiled with JetBrains decompiler
// Type: BuffBarEntry
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
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BuffBarEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Hours;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Minutes;
  private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeftBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background;
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
  private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
  private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Buff;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Debuff;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BuffBarEntry_Data_GridSelectionGroup_2_BuffBarEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1205342, RefRangeEnd = 1205344, XrefRangeStart = 1205327, XrefRangeEnd = 1205342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    BuffBarEntry entry,
    BuffBarEntry.Data data,
    GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuffBarEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BuffBarEntry_Data_GridSelectionGroup_2_BuffBarEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205344, XrefRangeEnd = 1205345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuffBarEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuffBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuffBarEntry()
  {
    Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (BuffBarEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr);
    BuffBarEntry.NativeFieldInfoPtr_LKey_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (LKey_Hours));
    BuffBarEntry.NativeFieldInfoPtr_LKey_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (LKey_Minutes));
    BuffBarEntry.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Stacks));
    BuffBarEntry.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (TimeKeys));
    BuffBarEntry.NativeFieldInfoPtr_TimeLeftBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (TimeLeftBuilder));
    BuffBarEntry.NativeFieldInfoPtr_TimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (TimeLeft));
    BuffBarEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Background));
    BuffBarEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Icon));
    BuffBarEntry.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Progress));
    BuffBarEntry.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (PrefabGUID));
    BuffBarEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Entity));
    BuffBarEntry.NativeFieldInfoPtr_Color_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Color_Buff));
    BuffBarEntry.NativeFieldInfoPtr_Color_Debuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Color_Debuff));
    BuffBarEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BuffBarEntry_Data_GridSelectionGroup_2_BuffBarEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, 100663304);
    BuffBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, 100663305);
  }

  public BuffBarEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizationKey LKey_Hours
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_LKey_Hours));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_LKey_Hours)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Minutes
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_LKey_Minutes));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_LKey_Minutes)) = value;
    }
  }

  public unsafe LocalizedText Stacks
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Stacks));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Stacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedTimeBuilder TimeLeftBuilder
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeLeftBuilder);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeLeftBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe LocalizedText TimeLeft
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeLeft));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_TimeLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Progress
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Progress));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID PrefabGUID
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_PrefabGUID));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_PrefabGUID)) = value;
    }
  }

  public unsafe Entity Entity
  {
    get
    {
      return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Entity));
    }
    [param: In] set
    {
      *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Entity)) = value;
    }
  }

  public unsafe Color Color_Buff
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Color_Buff));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Color_Buff)) = value;
    }
  }

  public unsafe Color Color_Debuff
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Color_Debuff));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.NativeFieldInfoPtr_Color_Debuff)) = value;
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDebuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_Age;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideNumberText;

    static Data()
    {
      Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffBarEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr);
      BuffBarEntry.Data.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (Entity));
      BuffBarEntry.Data.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (PrefabGUID));
      BuffBarEntry.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (Icon));
      BuffBarEntry.Data.NativeFieldInfoPtr_IsDebuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (IsDebuff));
      BuffBarEntry.Data.NativeFieldInfoPtr_Age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (Age));
      BuffBarEntry.Data.NativeFieldInfoPtr_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (LifeTime));
      BuffBarEntry.Data.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (Stacks));
      BuffBarEntry.Data.NativeFieldInfoPtr_HideNumberText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, nameof (HideNumberText));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffBarEntry.Data>.NativeClassPtr, data));
    }

    public unsafe Entity Entity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Entity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Entity)) = value;
      }
    }

    public unsafe PrefabGUID PrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_PrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_PrefabGUID)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsDebuff
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_IsDebuff));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_IsDebuff)) = value;
      }
    }

    public unsafe float Age
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Age));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Age)) = value;
      }
    }

    public unsafe float LifeTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_LifeTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_LifeTime)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public unsafe bool HideNumberText
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_HideNumberText));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarEntry.Data.NativeFieldInfoPtr_HideNumberText)) = value;
      }
    }
  }
}
