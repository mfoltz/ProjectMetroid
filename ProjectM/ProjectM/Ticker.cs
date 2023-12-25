// Decompiled with JetBrains decompiler
// Type: ProjectM.Ticker
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Ticker
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeBetweenTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeToNextTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksMade;
    [FieldOffset(0)]
    public float TimeBetweenTicks;
    [FieldOffset(4)]
    public float TimeToNextTick;
    [FieldOffset(8)]
    public int MaxTicks;
    [FieldOffset(12)]
    public int TicksMade;

    static Ticker()
    {
      Il2CppClassPointerStore<Ticker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Ticker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ticker>.NativeClassPtr);
      Ticker.NativeFieldInfoPtr_TimeBetweenTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ticker>.NativeClassPtr, nameof (TimeBetweenTicks));
      Ticker.NativeFieldInfoPtr_TimeToNextTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ticker>.NativeClassPtr, nameof (TimeToNextTick));
      Ticker.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ticker>.NativeClassPtr, nameof (MaxTicks));
      Ticker.NativeFieldInfoPtr_TicksMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ticker>.NativeClassPtr, nameof (TicksMade));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ticker>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
