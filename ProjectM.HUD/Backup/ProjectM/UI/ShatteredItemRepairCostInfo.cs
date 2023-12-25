// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ShatteredItemRepairCostInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class ShatteredItemRepairCostInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairCostList;

    static ShatteredItemRepairCostInfo()
    {
      Il2CppClassPointerStore<ShatteredItemRepairCostInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ShatteredItemRepairCostInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShatteredItemRepairCostInfo>.NativeClassPtr);
      ShatteredItemRepairCostInfo.NativeFieldInfoPtr_RepairCostList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemRepairCostInfo>.NativeClassPtr, nameof (RepairCostList));
    }

    public ShatteredItemRepairCostInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ShatteredItemRepairCostInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShatteredItemRepairCostInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShatteredItemRepairCostInfo>.NativeClassPtr, data));
    }

    public unsafe List<CostData> RepairCostList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemRepairCostInfo.NativeFieldInfoPtr_RepairCostList));
        return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemRepairCostInfo.NativeFieldInfoPtr_RepairCostList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
