// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_TraderEntry
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_TraderEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CostCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CostStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockAmount;
    [FieldOffset(0)]
    public int CostCount;
    [FieldOffset(4)]
    public int CostStartIndex;
    [FieldOffset(8)]
    public int OutputCount;
    [FieldOffset(12)]
    public int OutputStartIndex;
    [FieldOffset(16)]
    public int StockAmount;

    static Snapshot_TraderEntry()
    {
      Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_TraderEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr);
      Snapshot_TraderEntry.NativeFieldInfoPtr_CostCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, nameof (CostCount));
      Snapshot_TraderEntry.NativeFieldInfoPtr_CostStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, nameof (CostStartIndex));
      Snapshot_TraderEntry.NativeFieldInfoPtr_OutputCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, nameof (OutputCount));
      Snapshot_TraderEntry.NativeFieldInfoPtr_OutputStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, nameof (OutputStartIndex));
      Snapshot_TraderEntry.NativeFieldInfoPtr_StockAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, nameof (StockAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_TraderEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
