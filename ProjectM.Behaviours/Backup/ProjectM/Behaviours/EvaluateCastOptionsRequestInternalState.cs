// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsRequestInternalState
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EvaluateCastOptionsRequestInternalState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CandidateGroupEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CandidateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSuccessDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSuccessDelayElapsed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CandidateCastOptionIndex;
    [FieldOffset(0)]
    public Entity CandidateGroupEntity;
    [FieldOffset(8)]
    public Entity CandidateEntity;
    [FieldOffset(16)]
    public float CurrentSuccessDelay;
    [FieldOffset(20)]
    public float CurrentSuccessDelayElapsed;
    [FieldOffset(24)]
    public int CandidateCastOptionIndex;

    static EvaluateCastOptionsRequestInternalState()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsRequestInternalState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr);
      EvaluateCastOptionsRequestInternalState.NativeFieldInfoPtr_CandidateGroupEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, nameof (CandidateGroupEntity));
      EvaluateCastOptionsRequestInternalState.NativeFieldInfoPtr_CandidateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, nameof (CandidateEntity));
      EvaluateCastOptionsRequestInternalState.NativeFieldInfoPtr_CurrentSuccessDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, nameof (CurrentSuccessDelay));
      EvaluateCastOptionsRequestInternalState.NativeFieldInfoPtr_CurrentSuccessDelayElapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, nameof (CurrentSuccessDelayElapsed));
      EvaluateCastOptionsRequestInternalState.NativeFieldInfoPtr_CandidateCastOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, nameof (CandidateCastOptionIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsRequestInternalState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
