// Decompiled with JetBrains decompiler
// Type: MountSaddleBearerContainer
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
public class MountSaddleBearerContainer : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
  private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_SaddleEntry;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnableToChangeSaddleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnableToChangeSaddleIcon;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205511, RefRangeEnd = 1205512, XrefRangeStart = 1205496, XrefRangeEnd = 1205511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(MountSaddleBearerContainer.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountSaddleBearerContainer.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MountSaddleBearerContainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountSaddleBearerContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MountSaddleBearerContainer()
  {
    Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MountSaddleBearerContainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr);
    MountSaddleBearerContainer.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (MaxSpeed));
    MountSaddleBearerContainer.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (Acceleration));
    MountSaddleBearerContainer.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (RotationSpeed));
    MountSaddleBearerContainer.NativeFieldInfoPtr_SaddleEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (SaddleEntry));
    MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (UnableToChangeSaddleText));
    MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (UnableToChangeSaddleIcon));
    MountSaddleBearerContainer.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, 100663325);
    MountSaddleBearerContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, 100663326);
  }

  public MountSaddleBearerContainer(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe MountStatEntry MaxSpeed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_MaxSpeed));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_MaxSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MountStatEntry Acceleration
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_Acceleration));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_Acceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MountStatEntry RotationSpeed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_RotationSpeed));
      return pointer == System.IntPtr.Zero ? (MountStatEntry) null : new MountStatEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_RotationSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MountSaddleEntry SaddleEntry
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_SaddleEntry));
      return pointer == System.IntPtr.Zero ? (MountSaddleEntry) null : new MountSaddleEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_SaddleEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText UnableToChangeSaddleText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image UnableToChangeSaddleIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.NativeFieldInfoPtr_UnableToChangeSaddleIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaddleIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaddleId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanChangeSaddle;

    static Data()
    {
      Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MountSaddleBearerContainer>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr);
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (MaxSpeed));
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (Acceleration));
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (RotationSpeed));
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (SaddleIcon));
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (SaddleId));
      MountSaddleBearerContainer.Data.NativeFieldInfoPtr_CanChangeSaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, nameof (CanChangeSaddle));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountSaddleBearerContainer.Data>.NativeClassPtr, data));
    }

    public unsafe MountStatEntry.Data MaxSpeed
    {
      get
      {
        return *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_MaxSpeed));
      }
      [param: In] set
      {
        *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_MaxSpeed)) = value;
      }
    }

    public unsafe MountStatEntry.Data Acceleration
    {
      get
      {
        return *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_Acceleration));
      }
      [param: In] set
      {
        *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_Acceleration)) = value;
      }
    }

    public unsafe MountStatEntry.Data RotationSpeed
    {
      get
      {
        return *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_RotationSpeed));
      }
      [param: In] set
      {
        *(MountStatEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_RotationSpeed)) = value;
      }
    }

    public unsafe Sprite SaddleIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleIcon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID SaddleId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_SaddleId)) = value;
      }
    }

    public unsafe bool CanChangeSaddle
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_CanChangeSaddle));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleBearerContainer.Data.NativeFieldInfoPtr_CanChangeSaddle)) = value;
      }
    }
  }
}
