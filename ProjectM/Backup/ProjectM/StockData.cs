// Decompiled with JetBrains decompiler
// Type: ProjectM.StockData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StockData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullRechargeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RechargeInterval;
    [FieldOffset(0)]
    public int Count;
    [FieldOffset(4)]
    public float FullRechargeTime;
    [FieldOffset(8)]
    public float RechargeInterval;

    static StockData()
    {
      Il2CppClassPointerStore<StockData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StockData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StockData>.NativeClassPtr);
      StockData.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StockData>.NativeClassPtr, nameof (Count));
      StockData.NativeFieldInfoPtr_FullRechargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StockData>.NativeClassPtr, nameof (FullRechargeTime));
      StockData.NativeFieldInfoPtr_RechargeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StockData>.NativeClassPtr, nameof (RechargeInterval));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StockData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
