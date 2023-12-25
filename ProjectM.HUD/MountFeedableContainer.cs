// Decompiled with JetBrains decompiler
// Type: MountFeedableContainer
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MountFeedableContainer : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
  private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_WaterTimerText;
  private static readonly System.IntPtr NativeFieldInfoPtr_WaterTimerFill;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_WaterTimeKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultWaterColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultProgressSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutOfWaterKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutOfWaterColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutOfWaterProgressSprite;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205495, RefRangeEnd = 1205496, XrefRangeStart = 1205475, XrefRangeEnd = 1205495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(MountFeedableContainer.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &data;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountFeedableContainer.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MountFeedableContainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountFeedableContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MountFeedableContainer()
  {
    Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MountFeedableContainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr);
    MountFeedableContainer.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (MaxSpeed));
    MountFeedableContainer.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (Acceleration));
    MountFeedableContainer.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (RotationSpeed));
    MountFeedableContainer.NativeFieldInfoPtr_WaterTimerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (WaterTimerText));
    MountFeedableContainer.NativeFieldInfoPtr_WaterTimerFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (WaterTimerFill));
    MountFeedableContainer.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (TimeKeys));
    MountFeedableContainer.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (LocalizedTime));
    MountFeedableContainer.NativeFieldInfoPtr_WaterTimeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (WaterTimeKey));
    MountFeedableContainer.NativeFieldInfoPtr_DefaultWaterColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (DefaultWaterColor));
    MountFeedableContainer.NativeFieldInfoPtr_DefaultProgressSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (DefaultProgressSprite));
    MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (OutOfWaterKey));
    MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (OutOfWaterColor));
    MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterProgressSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (OutOfWaterProgressSprite));
    MountFeedableContainer.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, 100663323);
    MountFeedableContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, 100663324);
  }

  public MountFeedableContainer(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe MountStatEntry MaxSpeed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_MaxSpeed));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_MaxSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MountStatEntry Acceleration
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_Acceleration));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_Acceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MountStatEntry RotationSpeed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_RotationSpeed));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_RotationSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText WaterTimerText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimerText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimerText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image WaterTimerFill
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimerFill));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimerFill), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedTimeBuilder LocalizedTime
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe LocalizationKey WaterTimeKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimeKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_WaterTimeKey)) = value;
    }
  }

  public unsafe Color DefaultWaterColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_DefaultWaterColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_DefaultWaterColor)) = value;
    }
  }

  public unsafe Sprite DefaultProgressSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_DefaultProgressSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_DefaultProgressSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey OutOfWaterKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterKey)) = value;
    }
  }

  public unsafe Color OutOfWaterColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterColor)) = value;
    }
  }

  public unsafe Sprite OutOfWaterProgressSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterProgressSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountFeedableContainer.NativeFieldInfoPtr_OutOfWaterProgressSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaterTimeRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxWaterTime;
    [FieldOffset(0)]
    public MountStatEntry.Data MaxSpeed;
    [FieldOffset(20)]
    public MountStatEntry.Data Acceleration;
    [FieldOffset(40)]
    public MountStatEntry.Data RotationSpeed;
    [FieldOffset(60)]
    public float Health;
    [FieldOffset(64)]
    public float MaxHealth;
    [FieldOffset(68)]
    public float WaterTimeRemaining;
    [FieldOffset(72)]
    public float MaxWaterTime;

    static Data()
    {
      Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MountFeedableContainer>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr);
      MountFeedableContainer.Data.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (MaxSpeed));
      MountFeedableContainer.Data.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (Acceleration));
      MountFeedableContainer.Data.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (RotationSpeed));
      MountFeedableContainer.Data.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (Health));
      MountFeedableContainer.Data.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (MaxHealth));
      MountFeedableContainer.Data.NativeFieldInfoPtr_WaterTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (WaterTimeRemaining));
      MountFeedableContainer.Data.NativeFieldInfoPtr_MaxWaterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, nameof (MaxWaterTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountFeedableContainer.Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
