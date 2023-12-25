// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsRequestInput
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
  public struct EvaluateCastOptionsRequestInput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Subject;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    [FieldOffset(0)]
    public Entity Subject;
    [FieldOffset(8)]
    public Entity CastOptionsPrefab;

    static EvaluateCastOptionsRequestInput()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsRequestInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsRequestInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsRequestInput>.NativeClassPtr);
      EvaluateCastOptionsRequestInput.NativeFieldInfoPtr_Subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInput>.NativeClassPtr, nameof (Subject));
      EvaluateCastOptionsRequestInput.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsRequestInput>.NativeClassPtr, nameof (CastOptionsPrefab));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsRequestInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
