// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantPowerData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantPowerData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueMax;
    [FieldOffset(0)]
    public CurveReference Curve;
    [FieldOffset(8)]
    public float ValueMin;
    [FieldOffset(12)]
    public float ValueMax;

    static ServantPowerData()
    {
      Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantPowerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr);
      ServantPowerData.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr, nameof (Curve));
      ServantPowerData.NativeFieldInfoPtr_ValueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr, nameof (ValueMin));
      ServantPowerData.NativeFieldInfoPtr_ValueMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr, nameof (ValueMax));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantPowerData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
