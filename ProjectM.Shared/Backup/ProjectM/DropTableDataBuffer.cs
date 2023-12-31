// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableDataBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DropTableDataBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
    [FieldOffset(0)]
    public float DropRate;
    [FieldOffset(4)]
    public PrefabGUID ItemGuid;
    [FieldOffset(8)]
    public DropItemType ItemType;
    [FieldOffset(12)]
    public int Quantity;

    static DropTableDataBuffer()
    {
      Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DropTableDataBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr);
      DropTableDataBuffer.NativeFieldInfoPtr_DropRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr, nameof (DropRate));
      DropTableDataBuffer.NativeFieldInfoPtr_ItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr, nameof (ItemGuid));
      DropTableDataBuffer.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr, nameof (ItemType));
      DropTableDataBuffer.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr, nameof (Quantity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropTableDataBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
