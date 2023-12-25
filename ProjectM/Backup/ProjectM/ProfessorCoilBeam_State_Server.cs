// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilBeam_State_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProfessorCoilBeam_State_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NextBlastTickAge;
    private static readonly System.IntPtr NativeFieldInfoPtr_Event;
    private static readonly System.IntPtr NativeFieldInfoPtr_CoilIndex0;
    private static readonly System.IntPtr NativeFieldInfoPtr_CoilIndex1;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    [FieldOffset(0)]
    public double NextBlastTickAge;
    [FieldOffset(8)]
    public Entity Event;
    [FieldOffset(16)]
    public int CoilIndex0;
    [FieldOffset(20)]
    public int CoilIndex1;
    [FieldOffset(24)]
    public ProfessorCoilBeamState State;

    static ProfessorCoilBeam_State_Server()
    {
      Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilBeam_State_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr);
      ProfessorCoilBeam_State_Server.NativeFieldInfoPtr_NextBlastTickAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, nameof (NextBlastTickAge));
      ProfessorCoilBeam_State_Server.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, nameof (Event));
      ProfessorCoilBeam_State_Server.NativeFieldInfoPtr_CoilIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, nameof (CoilIndex0));
      ProfessorCoilBeam_State_Server.NativeFieldInfoPtr_CoilIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, nameof (CoilIndex1));
      ProfessorCoilBeam_State_Server.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, nameof (State));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilBeam_State_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
