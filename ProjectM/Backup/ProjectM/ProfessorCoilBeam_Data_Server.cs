// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilBeam_Data_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProfessorCoilBeam_Data_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Width;
    [FieldOffset(0)]
    public float Width;

    static ProfessorCoilBeam_Data_Server()
    {
      Il2CppClassPointerStore<ProfessorCoilBeam_Data_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilBeam_Data_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilBeam_Data_Server>.NativeClassPtr);
      ProfessorCoilBeam_Data_Server.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilBeam_Data_Server>.NativeClassPtr, nameof (Width));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilBeam_Data_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
