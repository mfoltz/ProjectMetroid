// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventoryDragData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InventoryDragData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    [FieldOffset(0)]
    public NetworkId Inventory;
    [FieldOffset(8)]
    public PrefabGUID ItemId;
    [FieldOffset(12)]
    public int SlotIndex;

    static InventoryDragData()
    {
      Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventoryDragData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr);
      InventoryDragData.NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr, nameof (Inventory));
      InventoryDragData.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr, nameof (ItemId));
      InventoryDragData.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr, nameof (SlotIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryDragData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
