// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitStatsSettingsElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitStatsSettingsElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMax;
    [FieldOffset(0)]
    public UnitBaseStatsType UnitBaseStatsType;
    [FieldOffset(4)]
    public CurveReference Curve;
    [FieldOffset(12)]
    public float ValueMin;
    [FieldOffset(16)]
    public float ValueMax;

    static UnitStatsSettingsElement()
    {
      Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitStatsSettingsElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr);
      UnitStatsSettingsElement.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr, nameof (UnitBaseStatsType));
      UnitStatsSettingsElement.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr, nameof (Curve));
      UnitStatsSettingsElement.NativeFieldInfoPtr_ValueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr, nameof (ValueMin));
      UnitStatsSettingsElement.NativeFieldInfoPtr_ValueMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr, nameof (ValueMax));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitStatsSettingsElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
