// Decompiled with JetBrains decompiler
// Type: ProjectM.GainAlertByVicinity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GainAlertByVicinity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggregatedCircleRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggregatedConeRadius;
    [FieldOffset(0)]
    public AggroData Value;
    [FieldOffset(20)]
    public float AggregatedCircleRadius;
    [FieldOffset(24)]
    public float AggregatedConeRadius;

    static GainAlertByVicinity()
    {
      Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GainAlertByVicinity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr);
      GainAlertByVicinity.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr, nameof (Value));
      GainAlertByVicinity.NativeFieldInfoPtr_AggregatedCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr, nameof (AggregatedCircleRadius));
      GainAlertByVicinity.NativeFieldInfoPtr_AggregatedConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr, nameof (AggregatedConeRadius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GainAlertByVicinity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
