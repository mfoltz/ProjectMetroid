// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateProfessorCoilEvent_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateProfessorCoilEvent_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeamCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeamPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    [FieldOffset(0)]
    public ProfessorCoilEventType EventType;
    [FieldOffset(4)]
    public int BeamCount;
    [FieldOffset(8)]
    public float PreviewTime;
    [FieldOffset(12)]
    public float BlastTime;
    [FieldOffset(16)]
    public float Range;
    [FieldOffset(20)]
    public PrefabGUID BeamPrefabGuid;
    [FieldOffset(24)]
    public int Priority;

    static Script_CreateProfessorCoilEvent_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateProfessorCoilEvent_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr);
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (EventType));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_BeamCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (BeamCount));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_PreviewTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (PreviewTime));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_BlastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (BlastTime));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (Range));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_BeamPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (BeamPrefabGuid));
      Script_CreateProfessorCoilEvent_DataServer.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, nameof (Priority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateProfessorCoilEvent_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
