// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_InventoryInstanceElement
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_InventoryInstanceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slots;
    [FieldOffset(0)]
    public InventoryInstanceElement.InstanceCategory Category;
    [FieldOffset(4)]
    public NetworkId ExternalInventoryEntity;
    [FieldOffset(12)]
    public int Slots;

    static Snapshot_InventoryInstanceElement()
    {
      Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_InventoryInstanceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr);
      Snapshot_InventoryInstanceElement.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr, nameof (Category));
      Snapshot_InventoryInstanceElement.NativeFieldInfoPtr_ExternalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr, nameof (ExternalInventoryEntity));
      Snapshot_InventoryInstanceElement.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr, nameof (Slots));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_InventoryInstanceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
