// Decompiled with JetBrains decompiler
// Type: ProjectM.DateDuration
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct DateDuration
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Years;
    private static readonly System.IntPtr NativeFieldInfoPtr_Months;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weeks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Days;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hours;
    private static readonly System.IntPtr NativeFieldInfoPtr_Minutes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManualTime;
    [FieldOffset(0)]
    public int Years;
    [FieldOffset(4)]
    public int Months;
    [FieldOffset(8)]
    public int Weeks;
    [FieldOffset(12)]
    public int Days;
    [FieldOffset(16)]
    public int Hours;
    [FieldOffset(20)]
    public int Minutes;
    [FieldOffset(24)]
    public float ManualTime;

    static DateDuration()
    {
      Il2CppClassPointerStore<DateDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DateDuration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateDuration>.NativeClassPtr);
      DateDuration.NativeFieldInfoPtr_Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Years));
      DateDuration.NativeFieldInfoPtr_Months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Months));
      DateDuration.NativeFieldInfoPtr_Weeks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Weeks));
      DateDuration.NativeFieldInfoPtr_Days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Days));
      DateDuration.NativeFieldInfoPtr_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Hours));
      DateDuration.NativeFieldInfoPtr_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (Minutes));
      DateDuration.NativeFieldInfoPtr_ManualTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, nameof (ManualTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateDuration>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
