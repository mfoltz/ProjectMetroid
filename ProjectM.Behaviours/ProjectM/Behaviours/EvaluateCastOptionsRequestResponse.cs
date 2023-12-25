// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsRequestResponse
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
  public struct EvaluateCastOptionsRequestResponse
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptOnTargetDeath;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public float Cooldown;
    [FieldOffset(12)]
    public int AbilityIndex;
    [FieldOffset(16)]
    public bool InterruptOnTargetDeath;

    static EvaluateCastOptionsRequestResponse()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsRequestResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr);
      EvaluateCastOptionsRequestResponse.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr, nameof (TargetEntity));
      EvaluateCastOptionsRequestResponse.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr, nameof (Cooldown));
      EvaluateCastOptionsRequestResponse.NativeFieldInfoPtr_AbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr, nameof (AbilityIndex));
      EvaluateCastOptionsRequestResponse.NativeFieldInfoPtr_InterruptOnTargetDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr, nameof (InterruptOnTargetDeath));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsRequestResponse>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
