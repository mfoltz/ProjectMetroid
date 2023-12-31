// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyBoneRope_Data
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyBoneRope_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SimulationWeightCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndWeight;
    [FieldOffset(0)]
    public int ModType;
    [FieldOffset(4)]
    public CurveReference SimulationWeightCurve;
    [FieldOffset(12)]
    public float Weight;
    [FieldOffset(16)]
    public float EndWeight;

    static ModifyBoneRope_Data()
    {
      Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyBoneRope_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr);
      ModifyBoneRope_Data.NativeFieldInfoPtr_ModType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr, nameof (ModType));
      ModifyBoneRope_Data.NativeFieldInfoPtr_SimulationWeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr, nameof (SimulationWeightCurve));
      ModifyBoneRope_Data.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr, nameof (Weight));
      ModifyBoneRope_Data.NativeFieldInfoPtr_EndWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr, nameof (EndWeight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyBoneRope_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
