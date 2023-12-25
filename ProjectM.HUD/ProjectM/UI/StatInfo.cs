// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StatInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StatInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public float Min;
    [FieldOffset(8)]
    public float Max;

    static StatInfo()
    {
      Il2CppClassPointerStore<StatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StatInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatInfo>.NativeClassPtr);
      StatInfo.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatInfo>.NativeClassPtr, nameof (Value));
      StatInfo.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatInfo>.NativeClassPtr, nameof (Min));
      StatInfo.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatInfo>.NativeClassPtr, nameof (Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
