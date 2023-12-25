// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilBeam_State_Shared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProfessorCoilBeam_State_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_End;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlastTime;
    [FieldOffset(0)]
    public float3 Start;
    [FieldOffset(12)]
    public float3 End;
    [FieldOffset(24)]
    public float PreviewTime;
    [FieldOffset(28)]
    public float BlastTime;

    static ProfessorCoilBeam_State_Shared()
    {
      Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilBeam_State_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr);
      ProfessorCoilBeam_State_Shared.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr, nameof (Start));
      ProfessorCoilBeam_State_Shared.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr, nameof (End));
      ProfessorCoilBeam_State_Shared.NativeFieldInfoPtr_PreviewTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr, nameof (PreviewTime));
      ProfessorCoilBeam_State_Shared.NativeFieldInfoPtr_BlastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr, nameof (BlastTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilBeam_State_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
