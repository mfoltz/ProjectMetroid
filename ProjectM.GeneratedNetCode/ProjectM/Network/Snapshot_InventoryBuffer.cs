// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_InventoryBuffer
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_InventoryBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAmountOverride;
    [FieldOffset(0)]
    public int Amount;
    [FieldOffset(4)]
    public NetworkId ItemEntity;
    [FieldOffset(12)]
    public PrefabGUID ItemType;
    [FieldOffset(16)]
    public int MaxAmountOverride;

    static Snapshot_InventoryBuffer()
    {
      Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_InventoryBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr);
      Snapshot_InventoryBuffer.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr, nameof (Amount));
      Snapshot_InventoryBuffer.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr, nameof (ItemEntity));
      Snapshot_InventoryBuffer.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr, nameof (ItemType));
      Snapshot_InventoryBuffer.NativeFieldInfoPtr_MaxAmountOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr, nameof (MaxAmountOverride));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_InventoryBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
