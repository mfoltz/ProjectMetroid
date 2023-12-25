// Decompiled with JetBrains decompiler
// Type: CostData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public sealed class CostData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
  private static readonly System.IntPtr NativeFieldInfoPtr_InStock;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemName;
  private static readonly System.IntPtr NativeFieldInfoPtr_RequirementMet;

  static CostData()
  {
    Il2CppClassPointerStore<CostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CostData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CostData>.NativeClassPtr);
    CostData.NativeFieldInfoPtr_ItemSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostData>.NativeClassPtr, nameof (ItemSprite));
    CostData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostData>.NativeClassPtr, nameof (Amount));
    CostData.NativeFieldInfoPtr_InStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostData>.NativeClassPtr, nameof (InStock));
    CostData.NativeFieldInfoPtr_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostData>.NativeClassPtr, nameof (ItemName));
    CostData.NativeFieldInfoPtr_RequirementMet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CostData>.NativeClassPtr, nameof (RequirementMet));
  }

  public CostData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CostData()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CostData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CostData>.NativeClassPtr, data));
  }

  public unsafe Sprite ItemSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_ItemSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_ItemSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int Amount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_Amount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_Amount)) = value;
    }
  }

  public unsafe int InStock
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_InStock));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_InStock)) = value;
    }
  }

  public unsafe LocalizationKey ItemName
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_ItemName));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_ItemName)) = value;
    }
  }

  public unsafe bool RequirementMet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_RequirementMet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CostData.NativeFieldInfoPtr_RequirementMet)) = value;
    }
  }
}
