// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDateTime
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameDateTime
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DayOfYear;
    private static readonly System.IntPtr NativeFieldInfoPtr_Day;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayOfWeek;
    private static readonly System.IntPtr NativeFieldInfoPtr_Month;
    private static readonly System.IntPtr NativeFieldInfoPtr_Year;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeekDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hour;
    private static readonly System.IntPtr NativeFieldInfoPtr_Minute;
    [FieldOffset(0)]
    public ushort DayOfYear;
    [FieldOffset(2)]
    public byte Day;
    [FieldOffset(3)]
    public byte DayOfWeek;
    [FieldOffset(4)]
    public byte Month;
    [FieldOffset(8)]
    public uint Year;
    [FieldOffset(12)]
    public WeekDay WeekDay;
    [FieldOffset(16)]
    public byte Hour;
    [FieldOffset(17)]
    public byte Minute;

    static GameDateTime()
    {
      Il2CppClassPointerStore<GameDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDateTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr);
      GameDateTime.NativeFieldInfoPtr_DayOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (DayOfYear));
      GameDateTime.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (Day));
      GameDateTime.NativeFieldInfoPtr_DayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (DayOfWeek));
      GameDateTime.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (Month));
      GameDateTime.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (Year));
      GameDateTime.NativeFieldInfoPtr_WeekDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (WeekDay));
      GameDateTime.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (Hour));
      GameDateTime.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, nameof (Minute));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
