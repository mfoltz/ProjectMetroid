// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilEvent
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
  public struct ProfessorCoilEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Manager;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RangeSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeamPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    [FieldOffset(0)]
    public Entity Manager;
    [FieldOffset(8)]
    public float PreviewTime;
    [FieldOffset(12)]
    public float BlastTime;
    [FieldOffset(16)]
    public float RangeSq;
    [FieldOffset(20)]
    public PrefabGUID BeamPrefabGuid;
    [FieldOffset(24)]
    public int Priority;

    static ProfessorCoilEvent()
    {
      Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr);
      ProfessorCoilEvent.NativeFieldInfoPtr_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (Manager));
      ProfessorCoilEvent.NativeFieldInfoPtr_PreviewTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (PreviewTime));
      ProfessorCoilEvent.NativeFieldInfoPtr_BlastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (BlastTime));
      ProfessorCoilEvent.NativeFieldInfoPtr_RangeSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (RangeSq));
      ProfessorCoilEvent.NativeFieldInfoPtr_BeamPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (BeamPrefabGuid));
      ProfessorCoilEvent.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, nameof (Priority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
