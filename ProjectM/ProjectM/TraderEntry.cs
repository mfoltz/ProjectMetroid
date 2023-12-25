// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TraderEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CostStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CostCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullRechargeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RechargeInterval;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Int32_Int32_0;
    [FieldOffset(0)]
    public int CostStartIndex;
    [FieldOffset(4)]
    public int CostCount;
    [FieldOffset(8)]
    public int OutputStartIndex;
    [FieldOffset(12)]
    public int OutputCount;
    [FieldOffset(16)]
    public int StockAmount;
    [FieldOffset(20)]
    public float FullRechargeTime;
    [FieldOffset(24)]
    public float RechargeInterval;

    [CallerCount(0)]
    public unsafe int GetHashCode(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderEntry.NativeMethodInfoPtr_GetHashCode_Public_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TraderEntry()
    {
      Il2CppClassPointerStore<TraderEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr);
      TraderEntry.NativeFieldInfoPtr_CostStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (CostStartIndex));
      TraderEntry.NativeFieldInfoPtr_CostCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (CostCount));
      TraderEntry.NativeFieldInfoPtr_OutputStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (OutputStartIndex));
      TraderEntry.NativeFieldInfoPtr_OutputCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (OutputCount));
      TraderEntry.NativeFieldInfoPtr_StockAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (StockAmount));
      TraderEntry.NativeFieldInfoPtr_FullRechargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (FullRechargeTime));
      TraderEntry.NativeFieldInfoPtr_RechargeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, nameof (RechargeInterval));
      TraderEntry.NativeMethodInfoPtr_GetHashCode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, 100676706);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
